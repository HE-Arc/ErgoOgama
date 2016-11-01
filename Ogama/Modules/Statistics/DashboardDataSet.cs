
namespace Ogama.Modules.Statistics
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using Ogama.Modules.Common.Tools;
using Ogama.Modules.Common.SlideCollections;
using Ogama.Modules.Common.Types;
using System.IO;
using System.Data;
using Ogama.DataSet;
using System.Collections;
using System.Windows.Forms;
using Ogama.Modules.SlideshowDesign.DesignModule.StimuliDialogs;
using VectorGraphics.Elements.ElementCollections;
using Ogama.Modules.AOI;
    using VectorGraphics.Elements;



    /// <summary>
    /// 
    /// </summary>
    public class DashboardDataSet
    {
        protected TestsTable testTable;
        protected TrialsTable trial;
        protected SubjectsTable subject;
        protected TrialSequencesTable sequence;
        protected AOIGroupsTable aoiGroup;
        protected AOIsTable aoi;
        protected FixationsTable fixation;
        protected CalibrationsTable calibration;
        protected TrialEventsTable trialEvents;

        protected AOIS_FixationsTable aoi_fixation;
        protected AOIS_MouseDownTable aoi_mouseDown;


        public DashboardDataSet()
        {
            
            if (!File.Exists(Document.ActiveDocument.ExperimentSettings.DashboardDatabasePath))
            {
                //if (!File.Exists(Ogama.Properties.ExperimentSettings.DASHBOARD_DB_NAME + ".db"))
                //{
                //    System.Console.WriteLine(true);
                //} 
                DashboardQuery.CreateDBFile(Document.ActiveDocument.ExperimentSettings.DashboardDatabasePath);       
            }       
        } 

        public void createTables()
        {
             
            testTable = new TestsTable();
            trial = new TrialsTable();
            subject = new SubjectsTable();
            sequence = new TrialSequencesTable();
            aoiGroup = new AOIGroupsTable();
            aoi = new AOIsTable();
            fixation = new FixationsTable();
            calibration = new CalibrationsTable();
            trialEvents = new TrialEventsTable();
            aoi_fixation = new AOIS_FixationsTable();
            aoi_mouseDown = new AOIS_MouseDownTable();
            

           
        }
        public void populateTables()
        {
            string testName = Document.ActiveDocument.ExperimentSettings.Name;
            //delete experiment if it is already in the table 
            testTable.deleteTestIfExists(testName);
            // reset the autoincrement for all the tables
            this.resetAutoIncrementForAllTables();
            //insert data
            int newTestId = testTable.insertData();
            DataTable ogamaTrialTable = Document.ActiveDocument.DocDataSet.TrialsAdapter.GetData();
            var idsTrialsLink = trial.insertData(ogamaTrialTable, newTestId);
            subject.insertData(newTestId);
            var sequnceIds = sequence.insertData(ogamaTrialTable, idsTrialsLink, newTestId);
            var groupIdslink = aoiGroup.insertData(newTestId);
            var idsAoisLink = aoi.insertData(idsTrialsLink, groupIdslink);
            var idsFixationsLink = fixation.insertData(idsTrialsLink, newTestId);
            calibration.insertData(newTestId);
            var idsMouseLink = trialEvents.insertData(idsTrialsLink, newTestId);

            aoi_fixation.insertData(idsAoisLink, idsFixationsLink);
            aoi_mouseDown.insertData(idsAoisLink, idsMouseLink);
            
        }

        protected void resetAutoIncrementForAllTables()
        {
            SQLiteConnection connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = "UPDATE sqlite_sequence SET seq = (SELECT MAX(id) FROM " + testTable.TableName + ") WHERE name='" + testTable.TableName + "'"; 
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE sqlite_sequence SET seq = (SELECT MAX(id) FROM " + trial.TableName + ") WHERE name='" + trial.TableName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE sqlite_sequence SET seq = (SELECT MAX(id) FROM " + subject.TableName + ") WHERE name='" + subject.TableName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE sqlite_sequence SET seq = (SELECT MAX(id) FROM " + sequence.TableName + ") WHERE name='" + sequence.TableName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE sqlite_sequence SET seq = (SELECT MAX(id) FROM " + aoiGroup.TableName + ") WHERE name='" + aoiGroup.TableName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE sqlite_sequence SET seq = (SELECT MAX(id) FROM " + aoi.TableName + ") WHERE name='" + aoi.TableName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE sqlite_sequence SET seq = (SELECT MAX(id) FROM " + fixation.TableName + ") WHERE name='" + fixation.TableName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE sqlite_sequence SET seq = (SELECT MAX(id) FROM " + calibration.TableName + ") WHERE name='" + calibration.TableName + "'";
                    command.ExecuteNonQuery();
                    command.CommandText = "UPDATE sqlite_sequence SET seq = (SELECT MAX(id) FROM " + trialEvents.TableName + ") WHERE name='" + trialEvents.TableName + "'";
                    command.ExecuteNonQuery();

                }
                transaction.Commit();
            }
            connection.Close();
            
        }

        
    }
    /// <summary>
    /// 
    /// </summary>
    public class TestsTable
    {
        private string tableName = "tests";
        private string colName = "name";
        private string colWidth = "width_screen";
        private string colHeight = "height_screen";
        private string colInstructions = "instruction";
        SQLiteConnection connection;
        /// <summary>
        /// 
        /// </summary>
        public TestsTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    //create table test 
                    command.Transaction = transaction;
                    command.CommandText = DashboardQuery.CreateTableIfNotExists(tableName);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table tests if not exists ");
                    var columnsNames = DashboardQuery.GetExistingColumns(tableName);
                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colName))
                    {
                         command.CommandText = DashboardQuery.AddColumn(tableName, colName, "varchar(50) NULL");
                         command.ExecuteNonQuery();
                         Console.WriteLine("Add column " +colName);
                    }
                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colWidth))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colWidth, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " +colWidth);
                    }
                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colHeight))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colHeight, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column "+colHeight);
                    }
                    if(!DashboardQuery.CheckColumnNameExits(columnsNames, colInstructions))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colInstructions, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colInstructions);
                    }
                    
                }
                transaction.Commit();
            }
            connection.Close();
        } 
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="testName"></param>
        public void deleteTestIfExists(string testName)
        {
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.CommandText = DashboardQuery.GetIdUsingCondition(colName, tableName, testName);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        int testIdIfExist = Convert.ToInt32(result);
                        command.CommandText = DashboardQuery.deleteIdFromWhere(tableName, testIdIfExist);
                        command.ExecuteNonQuery();                        
                        
                    }
                }
                transaction.Commit();
            }
            connection.Close();            
        }

        public string TableName
        {
            get { return this.tableName; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int insertData()
        {
            int newTestId = -1;           
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    string testName = Document.ActiveDocument.ExperimentSettings.Name;
                    int width = Document.ActiveDocument.ExperimentSettings.WidthStimulusScreen;
                    int height = Document.ActiveDocument.ExperimentSettings.HeightStimulusScreen; 
                    string instruction = Document.ActiveDocument.ExperimentSettings.ExperimentInstruction;
                    instruction = instruction.Replace("'", "''");
                    command.CommandText = DashboardQuery.InsertDataIntoTableTest(tableName, testName, width, height, instruction);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Insert data into " +tableName);
                    newTestId = DashboardQuery.GetLastID(command);                   
                }
                transaction.Commit();
            }            
            connection.Close();            
            return newTestId;
        }
    }

    /// <summary>
    ///  
    /// </summary>
    public class TrialsTable
    {
        private string tableName = "trials";
        private string colTestId = "test_id";
        private string colName = "name";
        private string colCategory = "category";
        private string colImageName = "image";
        private SQLiteConnection connection;
        /// <summary>
        /// create table Trial 
        /// </summary>       
        public TrialsTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    command.CommandText = DashboardQuery.CreateTableIfNotExists(tableName);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table " +tableName+ " if not exists");
                    var columnsNames = DashboardQuery.GetExistingColumns(tableName);

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colTestId))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colTestId, "integer") + " REFERENCES tests(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colTestId+ " and foreign key");               
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colName))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colName, "varchar(255) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column "+colName );
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colCategory))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colCategory, "varchar(255) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column "+colCategory);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colImageName))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colImageName, "varchar(255) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colImageName);
                    }
                }
                transaction.Commit();
            }
            connection.Close();
        }

        public string TableName
        {
            get { return this.tableName; }
        }
        /// <summary>
        /// trials table 
        /// </summary>
        /// <param name="originalTable"> get the trails from Trials table  </param>
        /// <param name="testId"></param>
        public Dictionary<int, int> insertData(DataTable originalTable, int testId)
        {
            var trialsView = new DataView(originalTable);
            trialsView.Sort = "TrialID ASC";
            connection.Open();
            int lastId = -1;
            
            Dictionary<int, int> linkOldIdsToNewIds = new Dictionary<int, int>();
            string columnsString = colTestId +", "+colName+", "+colCategory+", "+colImageName;
            Dictionary<int, string> photos = getSlidesImages();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;                    
                    foreach (DataRowView trial in trialsView)
                    {                     
                        int currentid = Convert.ToInt32(trial["TrialID"]);                       
                        if (currentid > lastId)
                        {
                            string photo = null;
                            if(photos.ContainsKey(currentid))
                                photo = photos[currentid];                        
                            string columnsValues = "'" + testId.ToString() + "', '" + trial["TrialName"].ToString() + "', '" + trial["Category"] + "', '" + photo + "'";
                            command.CommandText = DashboardQuery.InsertData(tableName, columnsString, columnsValues);
                            command.ExecuteNonQuery();
                            lastId = currentid;
                            linkOldIdsToNewIds.Add(lastId, DashboardQuery.GetLastID(command));
                        }                        
                    }                    
                }
                transaction.Commit();
            }
            Console.WriteLine("Insert data into " + tableName);
            connection.Close();
            return linkOldIdsToNewIds;
        }

        public static Dictionary<int, string> getSlidesImages()
        {
            
            Dictionary<int, string> photosNames = new Dictionary<int, string>();
            var nodes = Document.ActiveDocument.ExperimentSettings.SlideShow.Nodes;            
            foreach (TreeNode subNode in nodes)
            {
                //Console.WriteLine(subNode.Text);
                var subCollectionNode = subNode as SlideshowTreeNode;
                if (subCollectionNode is BrowserTreeNode)
                {
                    var browserSlide = subCollectionNode as BrowserTreeNode;                    
                    var lastKey = 0;
                    foreach (KeyValuePair<string, int> urlToID in browserSlide.UrlToID)
                    {
                        lastKey = urlToID.Value;
                        if (!urlToID.Key.Contains(".png"))
                        {
                            string filename = BrowserDialog.GetFilenameFromUrl(new System.Uri(urlToID.Key));                            
                            photosNames.Add(urlToID.Value, filename);                            
                        }
                        else
                        { 
                            //update the image if we find the same id
                            if (photosNames.ContainsKey(lastKey))
                                photosNames[lastKey] = urlToID.Key;
                            else
                                photosNames.Add(urlToID.Value, urlToID.Key);                            
                            
                        }
                        
                    }

                }
            }
            return photosNames;
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class SubjectsTable
    {
        private string tableName = "subjects";
        private string colTestId = "test_id";
        private string colName = "name";
        private string colAge = "age";
        private string colSex = "sex";
        private string colCategory = "category";
        private string colLanguage = "language";
        private string colType = "type";
        private string colGlasses = "glasses";
        private string colHandedness = "handedness";
        private string colAmbiance = "ambiance";
        private string colLight = "light";
        private string colComments = "comments";
        private string colVideo = "video";
        private string colEliminate = "eliminate";
        SQLiteConnection connection;

        //create table Subject
        public SubjectsTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    command.CommandText = DashboardQuery.CreateTableIfNotExists(tableName);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table " + tableName +" if not exists ");
                    var columnsNames = DashboardQuery.GetExistingColumns(tableName);

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colTestId))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colTestId, "integer") + " REFERENCES tests(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colTestId + " and foreign key");
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colName))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colName, "varchar(50) NOT NULL DEFAULT 'Unknown'");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column "+ colName );               
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colAge))
                    {                        
                        command.CommandText = DashboardQuery.AddColumn(tableName, colAge, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column "+ colAge);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colSex))
                    {                        
                        command.CommandText = DashboardQuery.AddColumn(tableName, colSex, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colSex);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colCategory))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colCategory, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colCategory);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colLanguage))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colLanguage, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colLanguage);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colType))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colType, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colType);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colGlasses))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colGlasses, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colGlasses);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colHandedness))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colHandedness, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colHandedness);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colAmbiance))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colAmbiance, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colAmbiance);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colLight))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colLight, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colLight);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colComments))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colComments, "varchar(4000) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colComments);
                    }
                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colVideo))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colVideo, "varchar(4000) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colVideo);
                    }
                    if(!DashboardQuery.CheckColumnNameExits(columnsNames, colEliminate))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colEliminate, "integer ");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colEliminate);

                    }
                }
                transaction.Commit();
            }
            connection.Close();
        }


        public string TableName
        {
            get { return this.tableName; }
        }
        /// <summary>
        /// subjects table
        /// </summary>
        /// <param name="testId"></param>
        /// <returns></returns>
        public int[] insertData(int testId)
        {
            DataTable subjectsTable = Document.ActiveDocument.DocDataSet.SubjectsAdapter.GetData();
            int[] linkOldToNewId = new int[subjectsTable.DefaultView.Count + 10];            
            connection.Open();
            string columnsString = colTestId + ", " + colName + ", " + colAge + ", " + colSex + ", " + colCategory + ", " + colLanguage + ", " +
                                    colType + ", " + colGlasses + ", " + colHandedness + ", " + colAmbiance + ", " + colLight + ", " + colComments + ", " + colVideo + ", " +colEliminate;            
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    foreach(DataRow subjectRow in subjectsTable.Rows)
                    {
                        int currentid = Convert.ToInt32(subjectRow["ID"]);                        
                        string columnsValues = "'" + testId.ToString() + "', '" + subjectRow["SubjectName"].ToString() + "', '" + subjectRow["Age"] + "', '" + subjectRow["Sex"] + "', '" + subjectRow["Category"] +
                                              "', '" + subjectRow["Language"] + "', '" + subjectRow["Type"] + "', '" + subjectRow["Glasses"] + "', '" + subjectRow["Handedness"] + "', '" + subjectRow["Ambiance"] +
                                              "', '" + subjectRow["Light"] + "', '" + subjectRow["Comments"].ToString().Replace("'", " ") + "', '" + getVideoFor(subjectRow["SubjectName"].ToString()) + "', '0'";

                        command.CommandText = DashboardQuery.InsertData(tableName, columnsString, columnsValues);                       
                        command.ExecuteNonQuery();                        
                        linkOldToNewId[currentid] = DashboardQuery.GetLastID(command);
                        
                    }
                }
                transaction.Commit();
            }
            Console.WriteLine("Insert data into " + tableName);
            connection.Close();
            return linkOldToNewId;
        }

        public static string getVideoFor(string subjectName)
        {
            string videoFile = Path.Combine(Document.ActiveDocument.ExperimentSettings.ThumbsPath, subjectName + ".avi");
            if (File.Exists(videoFile))
                return subjectName + ".avi";
            else
                return null;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class TrialSequencesTable
    {
        private string tableName = "trial_sequences";
        private string colSubjectId = "subject_id";
        private string colSequence = "sequence";
        private string colTrialId = "trial_id";
        private string colStart = "start_time";
        private string colDuration = "duration";
        SQLiteConnection connection;
        /// <summary>
        /// 
        /// </summary>
        public TrialSequencesTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    command.CommandText = DashboardQuery.CreateTableIfNotExists(tableName);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table " + tableName + " if not exists");
                    var columnsNames = DashboardQuery.GetExistingColumns(tableName);

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colSubjectId))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colSubjectId, "integer") + " REFERENCES subjects(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colSubjectId + " and foreign key");
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colSequence))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colSequence, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colSequence);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colTrialId))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colTrialId, "integer") + " REFERENCES trials(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colTrialId + " and foreign key");
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colStart))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colStart, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colStart);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colDuration))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colDuration, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colDuration);
                    }
                }
                transaction.Commit();
            }
            connection.Close();
        }

        public string TableName
        {
            get { return this.tableName; }
        }

        /// <summary>
        /// We take only the trials from Ogama trial table, re-numbering from 1 to n  
        /// </summary>
        /// <param name="arrayLink"></param>
        /// <param name="ogamaTrialTable"></param>
        public Dictionary<int, int> insertData(DataTable ogamaTrialTable, Dictionary<int, int> idsTrialsLink, int testId)
        {           
            connection.Open();      
            Dictionary<int, int> linkOldIdsToNewIds = new Dictionary<int, int>();
            string columnsString = colSubjectId + ", " + colSequence + ", " + colTrialId + ", " + colStart + ", " +colDuration;
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    foreach (DataRow sequenceRow in ogamaTrialTable.Rows)
                    {
                        int currentid = Convert.ToInt32(sequenceRow["ID"]);

                        //get the id for the dashboard subject table    
                        string[] columnNames = new string[] { "name", "test_id" };
                        string[] columnValues = new string[] { sequenceRow["SubjectName"].ToString(), testId.ToString()  };
                        command.CommandText = DashboardQuery.GetIdUsingConditions("subjects", columnNames, columnValues);
                        int subjectId = Convert.ToInt16(command.ExecuteScalar());                        

                        //get the corespondent id of trial from the dashboard trial table
                        int id = Convert.ToInt32(sequenceRow["TrialID"]);
                        int trialId = idsTrialsLink[id];
                       
                        string columnsValues = "'" + subjectId.ToString() + "', '" + sequenceRow["TrialSequence"].ToString() + "', '" + trialId.ToString() + "', '" + sequenceRow["TrialStartTime"].ToString() +
                                                "', '" + sequenceRow["Duration"].ToString() + "'";
                        command.CommandText = DashboardQuery.InsertData(tableName, columnsString, columnsValues);                        
                        command.ExecuteNonQuery();
                        linkOldIdsToNewIds.Add(currentid, DashboardQuery.GetLastID(command));                        
                    }
                }
                transaction.Commit();
            }
            Console.WriteLine("Insert data into " + tableName);
            connection.Close();
            return linkOldIdsToNewIds;
        }
    }

    public class AOIGroupsTable
    {
        private string tableName = "aoi_groups";
        private string colName = "name";
        private string colTestId = "test_id";
        SQLiteConnection connection;

        public AOIGroupsTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    command.CommandText = DashboardQuery.CreateTableIfNotExists(tableName);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table " +tableName+ " if not exists");
                    var columnsNames = DashboardQuery.GetExistingColumns(tableName);

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colName))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colName, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colName);               
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colTestId))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colTestId, "integer") + " REFERENCES tests(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colTestId + " and foreign key");
                    }
                }
                transaction.Commit();
            }
            connection.Close();
        }

        public string TableName
        {
            get { return this.tableName; }
        }

        public Dictionary<int, string> insertData(int testId)
        {
            DataTable ogamaAoiGroup = Document.ActiveDocument.DocDataSet.ShapeGroupsAdapter.GetData();
            connection.Open();           
            Dictionary<int, string> linkOldIdsToNewIds = new Dictionary<int, string>();
            string columnsString = colTestId + ", " + colName;
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    foreach (DataRow groupRow in ogamaAoiGroup.Rows)
                    {
                        int currentid = Convert.ToInt32(groupRow["ID"]);
                        string columnsValues = "'" + testId + "', '" + groupRow["ShapeGroup"].ToString() + "'";
                        command.CommandText = DashboardQuery.InsertData(tableName, columnsString, columnsValues);                        
                        command.ExecuteNonQuery();
                        linkOldIdsToNewIds.Add(DashboardQuery.GetLastID(command), groupRow["ShapeGroup"].ToString());
                    }
                }
                transaction.Commit();
            }
            Console.WriteLine("Insert data into " + tableName);
            connection.Close();
            return linkOldIdsToNewIds;
        }

     }

    public class AOIsTable
    {
        private string tableName = "aois";
        private string colTrialId = "trial_id";
        private string colName = "name";
        private string colType = "type";
        private string colNumPoints = "no_points";
        private string colPoints = "points";
        private string colGroup = "aoi_group_id";
        SQLiteConnection connection;

        public AOIsTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    command.CommandText = DashboardQuery.CreateTableIfNotExists(tableName);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table " + tableName + " if not exists");
                    var columnsNames = DashboardQuery.GetExistingColumns(tableName);

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colTrialId))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colTrialId, "integer") + " REFERENCES trials(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colTrialId + " and foreign key");
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colName))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colName, "varchar(255) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colName);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colType))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colType, "varchar(50) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colType);
                    }

                    if(!DashboardQuery.CheckColumnNameExits(columnsNames, colNumPoints))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colNumPoints, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colNumPoints);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colPoints))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colPoints, "varchar(4000) NULL");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colPoints);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colGroup))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colGroup, "integer") + " REFERENCES aoi_groups(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colGroup);
                    }
                }
                transaction.Commit();
            }
            connection.Close();
        }

        public string TableName
        {
            get { return this.tableName; }
        }

        public Dictionary<int, int> insertData(Dictionary<int, int> linkToTrials, Dictionary<int, string> linkToGroups)
        {
            DataTable ogamaAois = Document.ActiveDocument.DocDataSet.AOIsAdapter.GetData();
            connection.Open();
            //int[] linkOldToNewId = new int[ogamaAois.DefaultView.Count + 10];
            Dictionary<int, int> linkOldToNewId = new Dictionary<int, int>();
            string columnsString = colTrialId + ", " + colName + ", " + colType + ", " + colNumPoints + ", " + colPoints + ", " +colGroup;
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    foreach (DataRow aoiRow in ogamaAois.Rows)
                    {
                        int currentid = Convert.ToInt32(aoiRow["ID"]);

                        //get the corespondent id of trial from the dashboard trial table  
                        int id = Convert.ToInt32(aoiRow["TrialID"]);
                        int trialId = linkToTrials[id];                        

                        int groupId;
                        //get the id of group form the dashboard aoi_groups table
                        if (String.IsNullOrEmpty(aoiRow["ShapeGroup"].ToString()))
                            groupId = linkToGroups.Keys.First();
                        else
                            groupId = linkToGroups.FirstOrDefault(x => x.Value == aoiRow["ShapeGroup"].ToString()).Key;  
      
                        string columnsValues = "'" + trialId + "', '" + aoiRow["ShapeName"].ToString() + "', '" + aoiRow["ShapeType"].ToString() + "', '" + aoiRow["ShapeNumPts"].ToString() +
                                                "', '" + aoiRow["ShapePts"].ToString() + "', '" + groupId + "'";
                        command.CommandText = DashboardQuery.InsertData(tableName, columnsString, columnsValues);                       
                        command.ExecuteNonQuery();
                        linkOldToNewId.Add(currentid, DashboardQuery.GetLastID(command));
                        //linkOldToNewId[currentid] = DashboardQuery.GetLastID(command);
                    }
                }
                transaction.Commit();
            }
            Console.WriteLine("Insert data into " + tableName);
            connection.Close();
            return linkOldToNewId;
        }

    }

    public class FixationsTable
    {
        private string tableName = "fixations";
        private string colSequenceId = "trial_sequence_id";
        private string colTrialId = "trial_id";
        private string colCountIntrial = "cout_in_trial";
        private string colStartTime = "start_time";
        private string colLength = "length";
        private string colPosx = "posx";
        private string colPosy = "posy";
        SQLiteConnection connection;
        /// <summary>
        /// From Ogama GazeFixation to Dashboard Fixation table where new trial_sequence_id = subject_id, sequence_id, trial_id( the new id from trial table dashboard db) 
        /// </summary>
        public FixationsTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    command.CommandText = DashboardQuery.CreateTableIfNotExists(tableName);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table " + tableName + " if not exists");
                    var columnsNames = DashboardQuery.GetExistingColumns(tableName);

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colSequenceId))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colSequenceId, "integer") + " REFERENCES trial_sequences(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colSequenceId + " and foreign key");
                    }

                    if(!DashboardQuery.CheckColumnNameExits(columnsNames, colTrialId))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colTrialId, "integer") + " REFERENCES trials(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colTrialId + " and foreign key");
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colCountIntrial))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colCountIntrial, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colCountIntrial);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colStartTime))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colStartTime, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colStartTime);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colLength))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colLength, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colLength);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colPosx))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colPosx, "float");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colPosx);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colPosy))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colPosy, "float");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colPosy);
                    }
                }
                transaction.Commit();
            }
            connection.Close();
        }

        public string TableName
        {
            get { return this.tableName; }
        }

        public Dictionary<int, int> insertData(Dictionary<int, int> linkToTrials, int testId)
        {
            DataTable ogamaFixations = Document.ActiveDocument.DocDataSet.GazeFixationsAdapter.GetData();
            connection.Open();
            Dictionary<int, int> linkOldIdsToNewIds = new Dictionary<int, int>();
            string columnsString = colSequenceId + ", " + colTrialId + ", " + colCountIntrial + ", " + colStartTime + ", " + colLength + ", " + colPosx + ", " + colPosy;
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    foreach (DataRow fixation in ogamaFixations.Rows)
                    {
                        // get data from ogama fixation table
                        int currentid = Convert.ToInt32(fixation["ID"]);
                        string subjectName = fixation["SubjectName"].ToString();
                        int trialIdOld = Convert.ToInt32(fixation["TrialID"]);
                        string sequence = fixation["TrialSequence"].ToString();

                        //get from the dashboard/subjects table the id for the subject name
                        string[] columnNames = new string[] { "name", "test_id" };
                        string[] columnValues = new string[] { subjectName, testId.ToString() };
                        command.CommandText = DashboardQuery.GetIdUsingConditions("subjects", columnNames, columnValues);                       
                        string subjectId = command.ExecuteScalar().ToString();

                        //get from the dashboard/trials table the id for the ogama trial id
                        int trialIdNew = linkToTrials[trialIdOld]; 

                        //get the sequence id from dashbord/trial_sequences knowing the subject_id, trial_id, sequence
                        string[] columnNamesS = new string[]{"subject_id", "trial_id", "sequence" };
                        string[] columnValuesS = new string[] { subjectId, trialIdNew.ToString(), sequence };
                        command.CommandText = DashboardQuery.GetIdUsingConditions("trial_sequences", columnNamesS, columnValuesS);
                        int sequenceId = Convert.ToInt32(command.ExecuteScalar());

                        string values = "'" + sequenceId + "', '"+ trialIdNew + "', '"+ fixation["CountInTrial"].ToString() + "', '" + fixation["StartTime"].ToString() + "', '" + fixation["Length"].ToString() +
                                                "', '" + fixation["PosX"].ToString() + "', '" + fixation["PosY"].ToString() + "'";
                        command.CommandText = DashboardQuery.InsertData(tableName, columnsString, values);
                       
                        command.ExecuteNonQuery();
                        linkOldIdsToNewIds.Add(currentid,DashboardQuery.GetLastID(command));
                    }
                }
                transaction.Commit();
            }
            Console.WriteLine("Insert data into " + tableName);
            connection.Close();
            return linkOldIdsToNewIds;
        }


    }

    public class AOIS_FixationsTable
    {
        private string tableName = "fixation_aoi";
        private string colAoiId = "aoi_id";
        private string colFixationId = "fixation_id";
        SQLiteConnection connection;

        public AOIS_FixationsTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;                
                   // var columnsNames = DashboardQuery.GetExistingColumns(tableName);
                    command.CommandText = DashboardQuery.CreateTableIfNotExistsWithoutID(tableName) + "(" + colFixationId + " integer REFERENCES fixations(id) ON DELETE CASCADE,  " + colAoiId + " integer REFERENCES aois(id) ON DELETE CASCADE)";
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table " + tableName + " if not exists");
                }           
                transaction.Commit();
            }
            connection.Close();
        }
        
        public string TableName
        {
            get { return this.tableName;}
        }

        public void insertData(Dictionary<int, int> linkToAois, Dictionary<int, int> linkToFixations )
        {
            DataTable ogamaFixations = Document.ActiveDocument.DocDataSet.GazeFixationsAdapter.GetData();
            DataView fixationsView = new DataView(ogamaFixations);
            var ogamaAois = new DataView(Document.ActiveDocument.DocDataSet.AOIs);
            int foregoingTrialId = -1;
            var AOIs = new VGElementCollection();
            Dictionary<int, VGElement> aoisColection = new Dictionary<int, VGElement>();
            connection.Open();
            string columnsString = colFixationId + ", " + colAoiId;
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    foreach (DataRowView fixationRow in fixationsView)
                    {
                        
                        var trialID = (int)fixationRow["TrialID"];                         
                        if (trialID != foregoingTrialId)
                        {
                            ogamaAois.RowFilter = "TrialID=" + trialID.ToString();
                            foregoingTrialId = trialID;
                            AOIs.Clear();
                            aoisColection.Clear();
                            foreach (DataRowView row in ogamaAois)
                            {
                                string strPtList = row["ShapePts"].ToString();
                                string aoiType = row["ShapeType"].ToString();
                                string aoiName = row["ShapeName"].ToString();
                                string shapeGroup = row["ShapeGroup"].ToString();

                                VGElement aoi = Queries.GetVGElementFromDatabase(aoiType, aoiName, shapeGroup, strPtList);
                                AOIs.Add(aoi);
                                aoisColection.Add(Convert.ToInt32(row["ID"]), aoi);
                            }
                        }                                   

                        Dictionary<int, VGElement> fixation_aois = Statistic.FixationOnAOIs(AOIs, fixationRow);
                        foreach (var fixAoi in fixation_aois)
                        {         
                           
                            //get id from ogama AOIS table 
                            int oldId, newId;
                            if (aoisColection.ContainsValue(fixAoi.Value))
                            {
                                
                                //Console.WriteLine(aoisColection.FirstOrDefault(x => x.Value == fixAoi.Value).Key);
                                oldId = aoisColection.FirstOrDefault(x => x.Value == fixAoi.Value).Key;
                                newId = linkToAois[oldId];
                                
                                string columnsValues = "'" + linkToFixations[fixAoi.Key] + "', '" + newId + "'";
                                command.CommandText = DashboardQuery.InsertData(tableName, columnsString, columnsValues);
                                command.ExecuteNonQuery();
                            }
                        }
                        
                    }  
                }
                transaction.Commit();
            }
            connection.Close();      
        }

    }

    public class CalibrationsTable
    {
        private string tableName = "calibrations";
        private string colSubjectId = "subject_id";
        private string colAccuracy = "accuracy";
        private string colAccuracyLeft = "accuracy_left";
        private string colAccuracyRight = "accuracy_right";
        private SQLiteConnection connection;
        /// <summary>
        /// create table Calibrations 
        /// </summary>       
        public CalibrationsTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    command.CommandText = DashboardQuery.CreateTableIfNotExists(tableName);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table " +tableName+ " if not exists");
                    var columnsNames = DashboardQuery.GetExistingColumns(tableName);

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colSubjectId))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colSubjectId, "integer") + " REFERENCES subjects(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colSubjectId+ " and foreign key");               
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colAccuracy))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colAccuracy, "float NOT NULL DEFAULT '0.0'");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colAccuracy);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colAccuracyLeft))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colAccuracyLeft, "float NOT NULL DEFAULT '0.0'");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colAccuracyLeft);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colAccuracyRight))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colAccuracyRight, "float NOT NULL DEFAULT '0.0'");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colAccuracyRight);
                    }
                }
                transaction.Commit();
            }
            connection.Close();
        }

        public string TableName
        {
            get { return this.tableName; }
        }

        public void insertData(int testId)
        {
            DataTable originalCalibrations = Document.ActiveDocument.DocDataSet.CalibrationsAdapter.GetData();
            
            connection.Open();
            string columnsString = colSubjectId + ", " + colAccuracy + ", " + colAccuracyLeft + ", " + colAccuracyRight;
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    foreach (DataRow calibration in originalCalibrations.Rows)
                    {
                        //get the subjectId from the dashboard subject table  
                        string[] columnNames = new string[] { "name", "test_id" };
                        string[] columnValues = new string[] { calibration["SubjectName"].ToString(), testId.ToString() };
                        command.CommandText = DashboardQuery.GetIdUsingConditions("subjects", columnNames, columnValues);    
                        
                        //command.CommandText = DashboardQuery.GetIdUsingCondition("name", "subjects", calibration["SubjectName"].ToString());
                        int subjectId = Convert.ToInt16(command.ExecuteScalar());

                        string columnsValues = "'" + subjectId.ToString() + "', '" + Convert.ToDouble(calibration["Accuracy"]) + "', '" + calibration["AccuracyLeft"] +
                                                "', '" + calibration["AccuracyRight"] + "'";
                        command.CommandText = DashboardQuery.InsertData(tableName, columnsString, columnsValues);
                        //command.CommandText = "INSERT INTO [" + tableName + "] (subject_id, accuracy, accuracy_left, accuracy_right) VALUES (1, 0.26, 0.32, 15.36)";
                      
                        command.ExecuteNonQuery();                        
                    }
                }
                transaction.Commit();
            }
            Console.WriteLine("Insert data into " + tableName);
            connection.Close();
            
        }
    }

    public class TrialEventsTable
    {
        private string tableName = "trial_events";
        private string colSequenceId = "trial_sequence_id";
        private string colTime = "time";
        private string colType = "type";
        private string colTask = "task";
        private string colParam = "param";
        SQLiteConnection connection;

        public string TableName
        {
            get
            {
                return this.tableName;
            }
        }

        public TrialEventsTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    command.CommandText = DashboardQuery.CreateTableIfNotExists(tableName);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table " + tableName + " if not exists");
                    var columnsNames = DashboardQuery.GetExistingColumns(tableName);

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colSequenceId))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colSequenceId, "integer") + " REFERENCES trial_sequences(id) ON DELETE CASCADE";
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colSequenceId + " and foreign key");
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colTime))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colTime, "integer");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colTime);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colType))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colType, "varchar(50) NOT NULL DEFAULT 'Unknown'");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colType);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colTask))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colTask, "varchar(50) NOT NULL DEFAULT 'Unknown'");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colTask);
                    }

                    if (!DashboardQuery.CheckColumnNameExits(columnsNames, colParam))
                    {
                        command.CommandText = DashboardQuery.AddColumn(tableName, colParam, "varchar(4000) NOT NULL DEFAULT 'Unknown'");
                        command.ExecuteNonQuery();
                        Console.WriteLine("Add column " + colParam);
                    }                    
                }
                transaction.Commit();
            }
            connection.Close();

        }

        public Dictionary<int, int> insertData(Dictionary<int, int> linkToTrials, int testId)
        {
            DataTable ogamaTrialEvents = Document.ActiveDocument.DocDataSet.TrialEventsAdapter.GetData();            
            connection.Open();            
            string columnsString = colSequenceId + ", " + colTime + ", " + colType + ", " + colTask + ", " + colParam ;
            Dictionary<int, int> linkOldIdsToNewIds = new Dictionary<int, int>();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    foreach (DataRow events in ogamaTrialEvents.Rows)
                    {
                        // get data from ogama trial_events table    
                        int currentid = Convert.ToInt16(events["ID"]);
                        string subjectName = events["SubjectName"].ToString();                        
                        string sequence = events["TrialSequence"].ToString();

                        //get from the dashboard/subjects table the id for the subject name
                        string[] columnNames = new string[] { "name", "test_id" };
                        string[] columnValues = new string[] { subjectName, testId.ToString() };
                        command.CommandText = DashboardQuery.GetIdUsingConditions("subjects", columnNames, columnValues);      
                        //command.CommandText = DashboardQuery.GetIdUsingCondition("name", "subjects", subjectName);
                        string subjectId = command.ExecuteScalar().ToString();
                       
                        //get the sequence id from dashbord/trial_sequences knowing the subject_id, sequence
                        string[] columnNamesS = new string[] { "subject_id", "sequence" };
                        string[] columnValuesS = new string[] { subjectId, sequence };
                        command.CommandText = DashboardQuery.GetIdUsingConditions("trial_sequences", columnNamesS, columnValuesS);
                        int sequenceId = Convert.ToInt32(command.ExecuteScalar());

                        string values = "'" + sequenceId + "', '" + events["EventTime"].ToString() + "', '" + events["EventType"].ToString() + "', '" + events["EventTask"].ToString() +
                                                "', '" + events["EventParam"].ToString() + "'";
                        command.CommandText = DashboardQuery.InsertData(tableName, columnsString, values);
                        command.ExecuteNonQuery();
                        linkOldIdsToNewIds.Add(currentid, DashboardQuery.GetLastID(command));
                        
                    }
                }
                transaction.Commit();
            }
            Console.WriteLine("Insert data into " + tableName);
            connection.Close();

            return linkOldIdsToNewIds;

        }

    }


    public class AOIS_MouseDownTable
    {
        private string tableName = "mousedown_aoi";
        private string colAoiId = "aoi_id";
        private string colMouseId = "mousedown_id";
        SQLiteConnection connection;

        public string TableName
        {
            get { return this.tableName; }
        }

        public AOIS_MouseDownTable()
        {
            connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    command.CommandText = DashboardQuery.CreateTableIfNotExistsWithoutID(tableName) + "(" + colMouseId + " integer REFERENCES trial_events(id) ON DELETE CASCADE,  " + colAoiId + " integer REFERENCES aois(id) ON DELETE CASCADE)";
                    command.ExecuteNonQuery();
                    Console.WriteLine("Create table " + tableName + " if not exists");
                }
                transaction.Commit();
            }
            connection.Close();
        }


        public void insertData(Dictionary<int, int> linkToAois, Dictionary<int, int> linkToTrialEvents )
        {
            var ogamaAois = new DataView(Document.ActiveDocument.DocDataSet.AOIs);

            DataView events = new DataView(Document.ActiveDocument.DocDataSet.TrialEventsAdapter.GetData());
            var AOIs = new VGElementCollection();
            Dictionary<int, VGElement> aoisColection = new Dictionary<int, VGElement>();

            connection.Open();
            string columnsString = colMouseId + ", " + colAoiId;
            using (SQLiteTransaction transaction = connection.BeginTransaction())
            {
                using (SQLiteCommand command = new SQLiteCommand(connection))
                {
                    command.Transaction = transaction;
                    foreach (DataRowView eventsRow in events)
                    {
                        if (eventsRow["EventType"].ToString() == "Mouse" && eventsRow["EventTask"].ToString() == "Down")
                        {
                            
                            var trials = new DataView(Document.ActiveDocument.DocDataSet.TrialsAdapter.GetDataBySubjectAndSequence(eventsRow["SubjectName"].ToString(), Convert.ToInt16(eventsRow["TrialSequence"])));
                            foreach(DataRowView trial in trials )
                            {
                                
                                ogamaAois.RowFilter = "TrialID=" + trial["TrialID"].ToString();
                                AOIs.Clear();
                                aoisColection.Clear();
                                foreach (DataRowView row in ogamaAois)
                                {
                                    string strPtList = row["ShapePts"].ToString();
                                    string aoiType = row["ShapeType"].ToString();
                                    string aoiName = row["ShapeName"].ToString();
                                    string shapeGroup = row["ShapeGroup"].ToString();

                                    VGElement aoi = Queries.GetVGElementFromDatabase(aoiType, aoiName, shapeGroup, strPtList);
                                    AOIs.Add(aoi);
                                    aoisColection.Add(Convert.ToInt32(row["ID"]), aoi);
                                }                        
                            }
                            Dictionary<int, VGElement> mouse_aois = Statistic.MouseDownOnAOIs(AOIs, eventsRow);
                            foreach (var mouseAoi in mouse_aois)
                            {
                               
                                //get id from ogama AOIS table 
                                int oldId, newId;
                                if (aoisColection.ContainsValue(mouseAoi.Value))
                                {
                                    
                                    oldId = aoisColection.FirstOrDefault(x => x.Value == mouseAoi.Value).Key;
                                    newId = linkToAois[oldId];

                                    string columnsValues = "'" + linkToTrialEvents[mouseAoi.Key] + "', '" + newId + "'";
                                    command.CommandText = DashboardQuery.InsertData(tableName, columnsString, columnsValues);
                                    command.ExecuteNonQuery();
                                }

                            }
                    
                        }
                    }            
                }
                transaction.Commit();
            }
            connection.Close();
            

        }

    }

}
