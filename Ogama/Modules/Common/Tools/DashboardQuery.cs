

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;


namespace Ogama.Modules.Common.Tools
{
    /// <summary>
    /// This static class has all the methodes needed to generate a dashboard db 
    /// </summary>    
    public static class DashboardQuery
    {

        ///////////////////////////////////////////////////////////////////////////////
        // Create/Drop Database                                                      //
        ///////////////////////////////////////////////////////////////////////////////
        #region CREATE/DROP DB
        /// <summary>
        /// Create a sqlite db file 
        /// </summary>
        /// <param name="dBName">the name of the db</param>
        public static void CreateDBFile(string dBName)
        {
            SQLiteConnection.CreateFile(dBName);
        }
      

        #endregion //DB


        ///////////////////////////////////////////////////////////////////////////////
        // Add/Delete Table                                                          //
        ///////////////////////////////////////////////////////////////////////////////
        #region Add/Delete Table
        /// <summary>
        /// Create empty table into db if it not exists
        /// </summary>
        /// <param name="tableName"></param>
        public static string CreateTableIfNotExists(string tableName)
        {
            string queryString = "CREATE TABLE IF NOT EXISTS " + tableName + " (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL)";
            return queryString;            
        }

        public static string CreateTable(string tableName, string columnDefinition, string columns)
        {
            string queryString = "CREATE TABLE " + tableName + " (id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL)";
            return queryString;
        }

        /// <summary>
        /// This method checks for a table with the given name
        /// and removes it, if it was found.
        /// </summary>
        /// <param name="tableName">A <see cref="string"/> with the name of the table to be removed.</param>
        public static void RemoveTable(string tableName)
        {
            //if (Queries.TableExists(tableName))
            //{
            //    Queries.ExecuteSQLCommand("DROP TABLE " + tableName);
            //}
        }
    
        #endregion //Table



        ///////////////////////////////////////////////////////////////////////////////
        // Add/Delete Column                                                         //
        ///////////////////////////////////////////////////////////////////////////////
        #region ADD/Delete Column

        /// <summary>
        /// This method checks for a column with the given name in the given table
        /// and adds it with the given SQL Type, if it was not found.
        /// </summary>
        /// <param name="tableName">A <see cref="string"/> with the table name.</param>
        /// <param name="columnName">A <see cref="string"/> with the column name.</param>
        /// <param name="columnType">A <see cref="string"/> with the SQL column type of the new column.</param>
        public static string AddColumn(string tableName, string columnName, string columnType)
        {
            string addQuery = null;
            addQuery = "ALTER TABLE " + tableName + " ADD " + columnName + " " + columnType;                
                        
            return addQuery;
        }


        /// <summary>
        /// This method checks for a column with the given name in the given table
        /// and changes its SQL Type, if it was found.
        /// </summary>
        /// <param name="tableName">A <see cref="string"/> with the table name.</param>
        /// <param name="columnName">A <see cref="string"/> with the column name.</param>
        /// <param name="columnType">A <see cref="string"/> with the SQL column type of the new column.</param>
        public static void ChangeColumnType(string tableName, string columnName, string columnType)
        {
            //if (Queries.ColumnExists(tableName, columnName))
            //{
            //    string query = "ALTER TABLE " + tableName + " ALTER COLUMN " + columnName + " " + columnType;
            //    Queries.ExecuteSQLCommand(query);
            //}
        }

        /// <summary>
        /// This method checks for a column with the given name in the given table
        /// and removes it, if it was found.
        /// </summary>
        /// <param name="tableName">A <see cref="string"/> with the table name.</param>
        /// <param name="columnName">A <see cref="string"/> with the column name.</param>
        public static void RemoveColumn(string tableName, string columnName)
        {
            //if (Queries.ColumnExists(tableName, columnName))
            //{
            //    Queries.ExecuteSQLCommand("ALTER TABLE " + tableName + " DROP COLUMN " + columnName);
            //}
        }

        /// <summary>
        /// This method checks if a column exista already into the db
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="columnName"></param>
        /// <returns>true/false</returns>
        public static bool ColumnExists(string tableName, string columnName)
        {            
            SQLiteConnection connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            string query = string.Format("PRAGMA table_info({0})", tableName);
            var command = new SQLiteCommand(query, connection);
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int nameIndex = reader.GetOrdinal("name");
                while (reader.Read())
                {
                    if (reader.GetString(nameIndex).Equals(columnName))
                    {
                        connection.Close();
                        return true;
                    }
                }
            }
            connection.Close();
            return false;   
        }

        /// <summary>
        /// This method gets the columns of a table
        /// </summary>
        /// <param name="tableName">the name of the table</param>
        /// <returns>a list of columns names </returns>
        public static List<string> GetExistingColumns(string tableName)
        {
            SQLiteConnection connection = new SQLiteConnection(Document.ActiveDocument.ExperimentSettings.DashboardDbConnectionString);
            connection.Open();
            List<string> columns= new List<string>();

            string query = string.Format("PRAGMA table_info({0})", tableName);
            var command = new SQLiteCommand(query, connection);
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int nameIndex = reader.GetOrdinal("name");
                while (reader.Read())
                {
                    //Console.WriteLine(reader.GetString(nameIndex));                    
                    columns.Add(reader.GetString(nameIndex));
                }
            }
            //connection.Close();
            return columns;
        }

        /// <summary>
        /// This method checks if a column name is among a list of names
        /// </summary>
        /// <param name="columnsNames">liste of columns names</param>
        /// <param name="columnName">the column to find</param>
        /// <returns></returns>
        public static bool CheckColumnNameExits(List<string> columnsNames, string columnName)
        {
            foreach (string column in columnsNames)
            {
                //Console.WriteLine(column);
                if (column == columnName)
                    return true;
            }
            return false;
        }
        #endregion //Column


        ///////////////////////////////////////////////////////////////////////////////
        // Insert/Update/Delete Data                                                 //
        ///////////////////////////////////////////////////////////////////////////////
        #region Insert/Delete/Update Data

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="testName"></param>
        /// <param name="width"></param>
        /// <param name="heigth"></param>
        /// <returns></returns>
        public static string InsertDataIntoTableTest(string tableName, string testName, int width, int heigth )
        {
            string query = "INSERT INTO [" + tableName + "] (name, width_screen, height_screen) VALUES ('" + testName + "', '" + width + "', '" + heigth + "')" ;
            return query; 
        }

        public static string InsertData(string tableName, string columns, string columnsValues)
        {
            
            string query = "INSERT INTO [" + tableName + "] ("+ columns +") VALUES ("+columnsValues+")" ;            
            return query;
        }


        public static string GetIdUsingCondition(string columnName, string tableName, string value )
        {
            string query = "SELECT (id) FROM [" + tableName + "] WHERE (" + columnName + "='" + value + "')";
            return query;
        }

        public static int GetLastID(SQLiteCommand command)
        {
            command.CommandText = "SELECT last_insert_rowid()";
            int lastId = Convert.ToInt16(command.ExecuteScalar());
            return lastId;
        }

        public static string deleteIdFromWhere(string tableName, int columnValue)
        {
            string query = "DELETE FROM [" + tableName + "] WHERE (id='" + columnValue + "')";
            return query;
        }

        public static string GetIdUsingConditions(string tableName, string[] columnNames, string[] columnValues)
        {
            string query = "SELECT (id) FROM [" + tableName + "] WHERE " ;
            for(int i=0; i<columnNames.Length; i++)
            {
                query +="("+columnNames[i] + "='" + columnValues[i] +"') ";
                if (i != columnNames.Length - 1)
                    query += "AND ";

            }          
            return query;
        }
        

        #endregion //Data


       


    }
}
