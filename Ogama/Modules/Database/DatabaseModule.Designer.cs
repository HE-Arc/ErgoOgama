using System.ComponentModel;
using System.Windows.Forms;

namespace Ogama.Modules.Database
{
  partial class DatabaseModule
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      CustomDispose();
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseModule));
            this.cmsDataGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsModifyData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvRawData = new System.Windows.Forms.DataGridView();
            this.dgvTrials = new System.Windows.Forms.DataGridView();
            this.colTrialsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialsSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialsTrialSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialsTrialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialsTrialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialsCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialsTrialStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialsDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialsEliminateData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.colSubjectsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectsSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectsCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectsAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectsSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectsHandedness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectsComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGlasses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmbiance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tacTables = new System.Windows.Forms.TabControl();
            this.tbpSubjects = new System.Windows.Forms.TabPage();
            this.tbpSubjectParameters = new System.Windows.Forms.TabPage();
            this.dgvSubjectParameters = new System.Windows.Forms.DataGridView();
            this.colSubjectParametersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectParametersSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectParametersParam = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSubjectParametersSubjectNameParamValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpParams = new System.Windows.Forms.TabPage();
            this.dgvParams = new System.Windows.Forms.DataGridView();
            this.colParamsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpTrials = new System.Windows.Forms.TabPage();
            this.tbpTrialEvents = new System.Windows.Forms.TabPage();
            this.dgvTrialEvents = new System.Windows.Forms.DataGridView();
            this.colTrialEventsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialEventsSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialEventsTrialSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialEventsEventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialEventsEventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialEventsEventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialEventsEventTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrialEventsEventParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpRawdata = new System.Windows.Forms.TabPage();
            this.tbpGazeFixations = new System.Windows.Forms.TabPage();
            this.dgvGazeFixations = new System.Windows.Forms.DataGridView();
            this.colGazeFixationsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGazeFixationsSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGazeFixationsTrialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGazeFixationsTrialSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGazeFixationsCountInTrial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGazeFixationsStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGazeFixationsLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGazeFixationsPosX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGazeFixationsPosY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpMouseFixations = new System.Windows.Forms.TabPage();
            this.dgvMouseFixations = new System.Windows.Forms.DataGridView();
            this.colMouseFixationsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMouseFixationsSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMouseFixationsTrialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMouseFixationsTrialSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMouseFixationsCountInTrial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMouseFixationsStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMouseFixationsLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMouseFixationsPosX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMouseFixationsPosY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpAOI = new System.Windows.Forms.TabPage();
            this.dgvAOIs = new System.Windows.Forms.DataGridView();
            this.tbpShapeGroups = new System.Windows.Forms.TabPage();
            this.dgvShapeGroups = new System.Windows.Forms.DataGridView();
            this.colShapeGroupsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colShapeGroupsShapeGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCalibrations = new System.Windows.Forms.TabPage();
            this.dgvCalibrations = new System.Windows.Forms.DataGridView();
            this.colCalibrationsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalibrationsSubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalibrationsAccuracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalibrationsAccuracyLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCalibrationsAccuracyRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imlTabs = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.btnImportOgamaFormat = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFilterData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnSpecial = new System.Windows.Forms.ToolStripButton();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.bgwExport = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAOIsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAOIsTrialID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAOIsSlideNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAOIsShapeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAOIsShapeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAOIsShapeNumPts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAOIsShapePts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAOIsShapeGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsoSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoFKSubjectsTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoFKTrialsEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoTrialsAOIs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoTrialsGazeFixations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoTrialsMouseFixations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoShapeGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoFKSubjectsSubjectParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoSubjectParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoTrialEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoGazeFixations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoMouseFixations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoAOIs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoParams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoCalibrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoFKSubjectsCalibrations)).BeginInit();
            this.cmsDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tacTables.SuspendLayout();
            this.tbpSubjects.SuspendLayout();
            this.tbpSubjectParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectParameters)).BeginInit();
            this.tbpParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            this.tbpTrials.SuspendLayout();
            this.tbpTrialEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrialEvents)).BeginInit();
            this.tbpRawdata.SuspendLayout();
            this.tbpGazeFixations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGazeFixations)).BeginInit();
            this.tbpMouseFixations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMouseFixations)).BeginInit();
            this.tbpAOI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAOIs)).BeginInit();
            this.tbpShapeGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShapeGroups)).BeginInit();
            this.tbpCalibrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalibrations)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsoSubjects
            // 
            this.bsoSubjects.AllowNew = false;
            // 
            // bsoFKTrialsEvents
            // 
            this.bsoFKTrialsEvents.Sort = "EventTime";
            // 
            // cmsDataGridView
            // 
            this.cmsDataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSelect,
            this.cmsCopy,
            this.cmsModifyData});
            this.cmsDataGridView.Name = "cmsDataGridView";
            this.cmsDataGridView.Size = new System.Drawing.Size(219, 70);
            // 
            // cmsSelect
            // 
            this.cmsSelect.Name = "cmsSelect";
            this.cmsSelect.Size = new System.Drawing.Size(218, 22);
            this.cmsSelect.Text = "Select all rows";
            this.cmsSelect.Click += new System.EventHandler(this.cmsSelect_Click);
            // 
            // cmsCopy
            // 
            this.cmsCopy.Image = global::Ogama.Properties.Resources.CopyHS;
            this.cmsCopy.Name = "cmsCopy";
            this.cmsCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cmsCopy.Size = new System.Drawing.Size(218, 22);
            this.cmsCopy.Text = "Copy selected rows";
            this.cmsCopy.Click += new System.EventHandler(this.cmsCopy_Click);
            // 
            // cmsModifyData
            // 
            this.cmsModifyData.Name = "cmsModifyData";
            this.cmsModifyData.Size = new System.Drawing.Size(218, 22);
            this.cmsModifyData.Text = "modify data";
            this.cmsModifyData.Click += new System.EventHandler(this.cmsModifyData_Click);
            // 
            // dgvRawData
            // 
            this.dgvRawData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRawData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvRawData.ContextMenuStrip = this.cmsDataGridView;
            this.dgvRawData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawData.Location = new System.Drawing.Point(3, 3);
            this.dgvRawData.Name = "dgvRawData";
            this.dgvRawData.Size = new System.Drawing.Size(1151, 360);
            this.dgvRawData.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dgvRawData, "This table displays only the data of the selected trial or subject depending on f" +
        "ilter mode.\r\nRight click for a context menu.");
            this.dgvRawData.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            this.dgvRawData.Validated += new System.EventHandler(this.dgvRawData_Validated);
            // 
            // dgvTrials
            // 
            this.dgvTrials.AllowUserToAddRows = false;
            this.dgvTrials.AutoGenerateColumns = false;
            this.dgvTrials.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvTrials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrialsID,
            this.colTrialsSubjectName,
            this.colTrialsTrialSequence,
            this.colTrialsTrialID,
            this.colTrialsTrialName,
            this.colTrialsCategory,
            this.colTrialsTrialStartTime,
            this.colTrialsDuration,
            this.colTrialsEliminateData});
            this.dgvTrials.ContextMenuStrip = this.cmsDataGridView;
            this.dgvTrials.DataSource = this.bsoFKSubjectsTrials;
            this.dgvTrials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrials.Location = new System.Drawing.Point(3, 3);
            this.dgvTrials.Name = "dgvTrials";
            this.dgvTrials.Size = new System.Drawing.Size(1151, 360);
            this.dgvTrials.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dgvTrials, "Select trial row to filter the data of the preceding tables.\r\nRight click for a c" +
        "ontext menu.");
            this.dgvTrials.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            this.dgvTrials.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrials_RowEnter);
            // 
            // colTrialsID
            // 
            this.colTrialsID.DataPropertyName = "ID";
            this.colTrialsID.HeaderText = "ID";
            this.colTrialsID.MinimumWidth = 30;
            this.colTrialsID.Name = "colTrialsID";
            this.colTrialsID.ReadOnly = true;
            this.colTrialsID.Width = 60;
            // 
            // colTrialsSubjectName
            // 
            this.colTrialsSubjectName.DataPropertyName = "SubjectName";
            this.colTrialsSubjectName.HeaderText = "Subjectname";
            this.colTrialsSubjectName.MinimumWidth = 30;
            this.colTrialsSubjectName.Name = "colTrialsSubjectName";
            this.colTrialsSubjectName.Width = 80;
            // 
            // colTrialsTrialSequence
            // 
            this.colTrialsTrialSequence.DataPropertyName = "TrialSequence";
            this.colTrialsTrialSequence.HeaderText = "Sequence";
            this.colTrialsTrialSequence.MinimumWidth = 30;
            this.colTrialsTrialSequence.Name = "colTrialsTrialSequence";
            this.colTrialsTrialSequence.Width = 80;
            // 
            // colTrialsTrialID
            // 
            this.colTrialsTrialID.DataPropertyName = "TrialID";
            this.colTrialsTrialID.HeaderText = "TrialID";
            this.colTrialsTrialID.MinimumWidth = 30;
            this.colTrialsTrialID.Name = "colTrialsTrialID";
            this.colTrialsTrialID.Width = 40;
            // 
            // colTrialsTrialName
            // 
            this.colTrialsTrialName.DataPropertyName = "TrialName";
            this.colTrialsTrialName.HeaderText = "Name";
            this.colTrialsTrialName.MinimumWidth = 30;
            this.colTrialsTrialName.Name = "colTrialsTrialName";
            this.colTrialsTrialName.Width = 80;
            // 
            // colTrialsCategory
            // 
            this.colTrialsCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrialsCategory.DataPropertyName = "Category";
            this.colTrialsCategory.HeaderText = "Category";
            this.colTrialsCategory.MinimumWidth = 30;
            this.colTrialsCategory.Name = "colTrialsCategory";
            // 
            // colTrialsTrialStartTime
            // 
            this.colTrialsTrialStartTime.DataPropertyName = "TrialStartTime";
            this.colTrialsTrialStartTime.HeaderText = "StartTime";
            this.colTrialsTrialStartTime.MinimumWidth = 30;
            this.colTrialsTrialStartTime.Name = "colTrialsTrialStartTime";
            this.colTrialsTrialStartTime.Width = 60;
            // 
            // colTrialsDuration
            // 
            this.colTrialsDuration.DataPropertyName = "Duration";
            this.colTrialsDuration.HeaderText = "Duration";
            this.colTrialsDuration.MinimumWidth = 30;
            this.colTrialsDuration.Name = "colTrialsDuration";
            this.colTrialsDuration.Width = 60;
            // 
            // colTrialsEliminateData
            // 
            this.colTrialsEliminateData.DataPropertyName = "EliminateData";
            this.colTrialsEliminateData.HeaderText = "Eliminate";
            this.colTrialsEliminateData.MinimumWidth = 30;
            this.colTrialsEliminateData.Name = "colTrialsEliminateData";
            this.colTrialsEliminateData.Width = 60;
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AllowUserToAddRows = false;
            this.dgvSubjects.AutoGenerateColumns = false;
            this.dgvSubjects.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubjectsID,
            this.colSubjectsSubjectName,
            this.colSubjectsCategory,
            this.colSubjectsAge,
            this.colSubjectsSex,
            this.colSubjectsHandedness,
            this.colSubjectsComments,
            this.colGlasses,
            this.colLight,
            this.colAmbiance,
            this.colLanguage,
            this.colType});
            this.dgvSubjects.ContextMenuStrip = this.cmsDataGridView;
            this.dgvSubjects.DataSource = this.bsoSubjects;
            this.dgvSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubjects.Location = new System.Drawing.Point(3, 3);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.Size = new System.Drawing.Size(1151, 360);
            this.dgvSubjects.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgvSubjects, "Select a row to filter the data in the preceding tables.\r\nRight click for a conte" +
        "xt menu.");
            this.dgvSubjects.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSubjects_DataError);
            this.dgvSubjects.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_RowEnter);
            this.dgvSubjects.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvSubjects_UserDeletingRow);
            // 
            // colSubjectsID
            // 
            this.colSubjectsID.DataPropertyName = "ID";
            this.colSubjectsID.HeaderText = "ID";
            this.colSubjectsID.MinimumWidth = 30;
            this.colSubjectsID.Name = "colSubjectsID";
            this.colSubjectsID.ReadOnly = true;
            this.colSubjectsID.Width = 60;
            // 
            // colSubjectsSubjectName
            // 
            this.colSubjectsSubjectName.DataPropertyName = "SubjectName";
            this.colSubjectsSubjectName.HeaderText = "SubjectName";
            this.colSubjectsSubjectName.MinimumWidth = 30;
            this.colSubjectsSubjectName.Name = "colSubjectsSubjectName";
            this.colSubjectsSubjectName.Width = 80;
            // 
            // colSubjectsCategory
            // 
            this.colSubjectsCategory.DataPropertyName = "Category";
            this.colSubjectsCategory.HeaderText = "Category";
            this.colSubjectsCategory.MinimumWidth = 30;
            this.colSubjectsCategory.Name = "colSubjectsCategory";
            this.colSubjectsCategory.Width = 60;
            // 
            // colSubjectsAge
            // 
            this.colSubjectsAge.DataPropertyName = "Age";
            this.colSubjectsAge.HeaderText = "Age";
            this.colSubjectsAge.MinimumWidth = 30;
            this.colSubjectsAge.Name = "colSubjectsAge";
            this.colSubjectsAge.Width = 40;
            // 
            // colSubjectsSex
            // 
            this.colSubjectsSex.DataPropertyName = "Sex";
            this.colSubjectsSex.HeaderText = "Sex";
            this.colSubjectsSex.MinimumWidth = 30;
            this.colSubjectsSex.Name = "colSubjectsSex";
            this.colSubjectsSex.Width = 40;
            // 
            // colSubjectsHandedness
            // 
            this.colSubjectsHandedness.DataPropertyName = "Handedness";
            this.colSubjectsHandedness.HeaderText = "Handedness";
            this.colSubjectsHandedness.MinimumWidth = 30;
            this.colSubjectsHandedness.Name = "colSubjectsHandedness";
            this.colSubjectsHandedness.Width = 80;
            // 
            // colSubjectsComments
            // 
            this.colSubjectsComments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubjectsComments.DataPropertyName = "Comments";
            this.colSubjectsComments.HeaderText = "Comments";
            this.colSubjectsComments.MinimumWidth = 30;
            this.colSubjectsComments.Name = "colSubjectsComments";
            // 
            // colGlasses
            // 
            this.colGlasses.DataPropertyName = "Glasses";
            this.colGlasses.HeaderText = "Glasses";
            this.colGlasses.MinimumWidth = 30;
            this.colGlasses.Name = "colGlasses";
            this.colGlasses.ReadOnly = true;
            // 
            // colLight
            // 
            this.colLight.DataPropertyName = "Light";
            this.colLight.HeaderText = "Room Light";
            this.colLight.MinimumWidth = 40;
            this.colLight.Name = "colLight";
            this.colLight.ReadOnly = true;
            // 
            // colAmbiance
            // 
            this.colAmbiance.DataPropertyName = "Ambiance";
            this.colAmbiance.HeaderText = "Room Ambiance";
            this.colAmbiance.MinimumWidth = 40;
            this.colAmbiance.Name = "colAmbiance";
            this.colAmbiance.ReadOnly = true;
            // 
            // colLanguage
            // 
            this.colLanguage.DataPropertyName = "Language";
            this.colLanguage.HeaderText = "Language";
            this.colLanguage.MinimumWidth = 50;
            this.colLanguage.Name = "colLanguage";
            this.colLanguage.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "SubjectType";
            this.colType.MinimumWidth = 50;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tacTables);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1165, 393);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1165, 418);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tacTables
            // 
            this.tacTables.Controls.Add(this.tbpSubjects);
            this.tacTables.Controls.Add(this.tbpSubjectParameters);
            this.tacTables.Controls.Add(this.tbpParams);
            this.tacTables.Controls.Add(this.tbpTrials);
            this.tacTables.Controls.Add(this.tbpTrialEvents);
            this.tacTables.Controls.Add(this.tbpRawdata);
            this.tacTables.Controls.Add(this.tbpGazeFixations);
            this.tacTables.Controls.Add(this.tbpMouseFixations);
            this.tacTables.Controls.Add(this.tbpAOI);
            this.tacTables.Controls.Add(this.tbpShapeGroups);
            this.tacTables.Controls.Add(this.tbpCalibrations);
            this.tacTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tacTables.ImageList = this.imlTabs;
            this.tacTables.Location = new System.Drawing.Point(0, 0);
            this.tacTables.Name = "tacTables";
            this.tacTables.SelectedIndex = 0;
            this.tacTables.Size = new System.Drawing.Size(1165, 393);
            this.tacTables.TabIndex = 1;
            // 
            // tbpSubjects
            // 
            this.tbpSubjects.Controls.Add(this.dgvSubjects);
            this.tbpSubjects.ImageKey = "Subjects";
            this.tbpSubjects.Location = new System.Drawing.Point(4, 23);
            this.tbpSubjects.Name = "tbpSubjects";
            this.tbpSubjects.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSubjects.Size = new System.Drawing.Size(1157, 366);
            this.tbpSubjects.TabIndex = 0;
            this.tbpSubjects.Text = "Subjects";
            this.tbpSubjects.UseVisualStyleBackColor = true;
            // 
            // tbpSubjectParameters
            // 
            this.tbpSubjectParameters.Controls.Add(this.dgvSubjectParameters);
            this.tbpSubjectParameters.ImageKey = "SubjectProperties";
            this.tbpSubjectParameters.Location = new System.Drawing.Point(4, 23);
            this.tbpSubjectParameters.Name = "tbpSubjectParameters";
            this.tbpSubjectParameters.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSubjectParameters.Size = new System.Drawing.Size(1157, 366);
            this.tbpSubjectParameters.TabIndex = 8;
            this.tbpSubjectParameters.Text = "Subject parameters";
            this.tbpSubjectParameters.UseVisualStyleBackColor = true;
            // 
            // dgvSubjectParameters
            // 
            this.dgvSubjectParameters.AutoGenerateColumns = false;
            this.dgvSubjectParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjectParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubjectParametersID,
            this.colSubjectParametersSubjectName,
            this.colSubjectParametersParam,
            this.colSubjectParametersSubjectNameParamValue});
            this.dgvSubjectParameters.DataSource = this.bsoFKSubjectsSubjectParameters;
            this.dgvSubjectParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubjectParameters.Location = new System.Drawing.Point(3, 3);
            this.dgvSubjectParameters.Name = "dgvSubjectParameters";
            this.dgvSubjectParameters.Size = new System.Drawing.Size(1151, 360);
            this.dgvSubjectParameters.TabIndex = 0;
            // 
            // colSubjectParametersID
            // 
            this.colSubjectParametersID.DataPropertyName = "ID";
            this.colSubjectParametersID.HeaderText = "ID";
            this.colSubjectParametersID.MinimumWidth = 30;
            this.colSubjectParametersID.Name = "colSubjectParametersID";
            this.colSubjectParametersID.ReadOnly = true;
            this.colSubjectParametersID.Width = 60;
            // 
            // colSubjectParametersSubjectName
            // 
            this.colSubjectParametersSubjectName.DataPropertyName = "SubjectName";
            this.colSubjectParametersSubjectName.HeaderText = "SubjectName";
            this.colSubjectParametersSubjectName.MinimumWidth = 80;
            this.colSubjectParametersSubjectName.Name = "colSubjectParametersSubjectName";
            // 
            // colSubjectParametersParam
            // 
            this.colSubjectParametersParam.DataPropertyName = "Param";
            this.colSubjectParametersParam.DataSource = this.bsoParams;
            this.colSubjectParametersParam.DisplayMember = "Param";
            this.colSubjectParametersParam.HeaderText = "Param";
            this.colSubjectParametersParam.MinimumWidth = 80;
            this.colSubjectParametersParam.Name = "colSubjectParametersParam";
            this.colSubjectParametersParam.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSubjectParametersParam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSubjectParametersParam.ValueMember = "Param";
            // 
            // colSubjectParametersSubjectNameParamValue
            // 
            this.colSubjectParametersSubjectNameParamValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSubjectParametersSubjectNameParamValue.DataPropertyName = "ParamValue";
            this.colSubjectParametersSubjectNameParamValue.HeaderText = "ParamValue";
            this.colSubjectParametersSubjectNameParamValue.MinimumWidth = 60;
            this.colSubjectParametersSubjectNameParamValue.Name = "colSubjectParametersSubjectNameParamValue";
            // 
            // tbpParams
            // 
            this.tbpParams.Controls.Add(this.dgvParams);
            this.tbpParams.ImageKey = "Params";
            this.tbpParams.Location = new System.Drawing.Point(4, 23);
            this.tbpParams.Name = "tbpParams";
            this.tbpParams.Padding = new System.Windows.Forms.Padding(3);
            this.tbpParams.Size = new System.Drawing.Size(1157, 366);
            this.tbpParams.TabIndex = 9;
            this.tbpParams.Text = "CustomParams";
            this.tbpParams.UseVisualStyleBackColor = true;
            // 
            // dgvParams
            // 
            this.dgvParams.AutoGenerateColumns = false;
            this.dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParamsID,
            this.paramDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvParams.DataSource = this.bsoParams;
            this.dgvParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParams.Location = new System.Drawing.Point(3, 3);
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.Size = new System.Drawing.Size(1151, 360);
            this.dgvParams.TabIndex = 0;
            // 
            // colParamsID
            // 
            this.colParamsID.DataPropertyName = "ID";
            this.colParamsID.HeaderText = "ID";
            this.colParamsID.Name = "colParamsID";
            this.colParamsID.ReadOnly = true;
            // 
            // paramDataGridViewTextBoxColumn
            // 
            this.paramDataGridViewTextBoxColumn.DataPropertyName = "Param";
            this.paramDataGridViewTextBoxColumn.HeaderText = "Param";
            this.paramDataGridViewTextBoxColumn.Name = "paramDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // tbpTrials
            // 
            this.tbpTrials.Controls.Add(this.dgvTrials);
            this.tbpTrials.ImageKey = "Trials";
            this.tbpTrials.Location = new System.Drawing.Point(4, 23);
            this.tbpTrials.Name = "tbpTrials";
            this.tbpTrials.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTrials.Size = new System.Drawing.Size(1157, 366);
            this.tbpTrials.TabIndex = 1;
            this.tbpTrials.Text = "Trials";
            this.tbpTrials.UseVisualStyleBackColor = true;
            // 
            // tbpTrialEvents
            // 
            this.tbpTrialEvents.Controls.Add(this.dgvTrialEvents);
            this.tbpTrialEvents.ImageKey = "Events";
            this.tbpTrialEvents.Location = new System.Drawing.Point(4, 23);
            this.tbpTrialEvents.Name = "tbpTrialEvents";
            this.tbpTrialEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTrialEvents.Size = new System.Drawing.Size(1157, 366);
            this.tbpTrialEvents.TabIndex = 5;
            this.tbpTrialEvents.Text = "Trial Events";
            this.tbpTrialEvents.UseVisualStyleBackColor = true;
            // 
            // dgvTrialEvents
            // 
            this.dgvTrialEvents.AllowUserToAddRows = false;
            this.dgvTrialEvents.AutoGenerateColumns = false;
            this.dgvTrialEvents.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvTrialEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTrialEventsID,
            this.colTrialEventsSubjectName,
            this.colTrialEventsTrialSequence,
            this.colTrialEventsEventID,
            this.colTrialEventsEventTime,
            this.colTrialEventsEventType,
            this.colTrialEventsEventTask,
            this.colTrialEventsEventParam});
            this.dgvTrialEvents.ContextMenuStrip = this.cmsDataGridView;
            this.dgvTrialEvents.DataSource = this.bsoFKTrialsEvents;
            this.dgvTrialEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrialEvents.Location = new System.Drawing.Point(3, 3);
            this.dgvTrialEvents.Name = "dgvTrialEvents";
            this.dgvTrialEvents.Size = new System.Drawing.Size(1151, 360);
            this.dgvTrialEvents.TabIndex = 0;
            this.dgvTrialEvents.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // colTrialEventsID
            // 
            this.colTrialEventsID.DataPropertyName = "ID";
            this.colTrialEventsID.HeaderText = "ID";
            this.colTrialEventsID.MinimumWidth = 30;
            this.colTrialEventsID.Name = "colTrialEventsID";
            this.colTrialEventsID.ReadOnly = true;
            this.colTrialEventsID.Width = 60;
            // 
            // colTrialEventsSubjectName
            // 
            this.colTrialEventsSubjectName.DataPropertyName = "SubjectName";
            this.colTrialEventsSubjectName.HeaderText = "SubjectName";
            this.colTrialEventsSubjectName.MinimumWidth = 30;
            this.colTrialEventsSubjectName.Name = "colTrialEventsSubjectName";
            this.colTrialEventsSubjectName.Width = 80;
            // 
            // colTrialEventsTrialSequence
            // 
            this.colTrialEventsTrialSequence.DataPropertyName = "TrialSequence";
            this.colTrialEventsTrialSequence.HeaderText = "TrialSequence";
            this.colTrialEventsTrialSequence.MinimumWidth = 30;
            this.colTrialEventsTrialSequence.Name = "colTrialEventsTrialSequence";
            this.colTrialEventsTrialSequence.Width = 80;
            // 
            // colTrialEventsEventID
            // 
            this.colTrialEventsEventID.DataPropertyName = "EventID";
            this.colTrialEventsEventID.HeaderText = "EventID";
            this.colTrialEventsEventID.MinimumWidth = 30;
            this.colTrialEventsEventID.Name = "colTrialEventsEventID";
            this.colTrialEventsEventID.Width = 60;
            // 
            // colTrialEventsEventTime
            // 
            this.colTrialEventsEventTime.DataPropertyName = "EventTime";
            this.colTrialEventsEventTime.HeaderText = "EventTime";
            this.colTrialEventsEventTime.MinimumWidth = 30;
            this.colTrialEventsEventTime.Name = "colTrialEventsEventTime";
            this.colTrialEventsEventTime.Width = 60;
            // 
            // colTrialEventsEventType
            // 
            this.colTrialEventsEventType.DataPropertyName = "EventType";
            this.colTrialEventsEventType.HeaderText = "EventType";
            this.colTrialEventsEventType.MinimumWidth = 30;
            this.colTrialEventsEventType.Name = "colTrialEventsEventType";
            this.colTrialEventsEventType.Width = 80;
            // 
            // colTrialEventsEventTask
            // 
            this.colTrialEventsEventTask.DataPropertyName = "EventTask";
            this.colTrialEventsEventTask.HeaderText = "EventTask";
            this.colTrialEventsEventTask.MinimumWidth = 30;
            this.colTrialEventsEventTask.Name = "colTrialEventsEventTask";
            this.colTrialEventsEventTask.Width = 80;
            // 
            // colTrialEventsEventParam
            // 
            this.colTrialEventsEventParam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTrialEventsEventParam.DataPropertyName = "EventParam";
            this.colTrialEventsEventParam.HeaderText = "EventParam";
            this.colTrialEventsEventParam.MinimumWidth = 30;
            this.colTrialEventsEventParam.Name = "colTrialEventsEventParam";
            // 
            // tbpRawdata
            // 
            this.tbpRawdata.Controls.Add(this.dgvRawData);
            this.tbpRawdata.ImageKey = "RawData";
            this.tbpRawdata.Location = new System.Drawing.Point(4, 23);
            this.tbpRawdata.Name = "tbpRawdata";
            this.tbpRawdata.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRawdata.Size = new System.Drawing.Size(1157, 366);
            this.tbpRawdata.TabIndex = 2;
            this.tbpRawdata.Text = "Raw data";
            this.tbpRawdata.UseVisualStyleBackColor = true;
            // 
            // tbpGazeFixations
            // 
            this.tbpGazeFixations.Controls.Add(this.dgvGazeFixations);
            this.tbpGazeFixations.ImageKey = "GazeFixations";
            this.tbpGazeFixations.Location = new System.Drawing.Point(4, 23);
            this.tbpGazeFixations.Name = "tbpGazeFixations";
            this.tbpGazeFixations.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGazeFixations.Size = new System.Drawing.Size(1157, 366);
            this.tbpGazeFixations.TabIndex = 3;
            this.tbpGazeFixations.Text = "Gaze Fixations";
            this.tbpGazeFixations.UseVisualStyleBackColor = true;
            // 
            // dgvGazeFixations
            // 
            this.dgvGazeFixations.AllowUserToAddRows = false;
            this.dgvGazeFixations.AutoGenerateColumns = false;
            this.dgvGazeFixations.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvGazeFixations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGazeFixationsID,
            this.colGazeFixationsSubjectName,
            this.colGazeFixationsTrialID,
            this.colGazeFixationsTrialSequence,
            this.colGazeFixationsCountInTrial,
            this.colGazeFixationsStartTime,
            this.colGazeFixationsLength,
            this.colGazeFixationsPosX,
            this.colGazeFixationsPosY});
            this.dgvGazeFixations.ContextMenuStrip = this.cmsDataGridView;
            this.dgvGazeFixations.DataSource = this.bsoTrialsGazeFixations;
            this.dgvGazeFixations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGazeFixations.Location = new System.Drawing.Point(3, 3);
            this.dgvGazeFixations.Name = "dgvGazeFixations";
            this.dgvGazeFixations.Size = new System.Drawing.Size(1151, 360);
            this.dgvGazeFixations.TabIndex = 0;
            this.dgvGazeFixations.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // colGazeFixationsID
            // 
            this.colGazeFixationsID.DataPropertyName = "ID";
            this.colGazeFixationsID.HeaderText = "ID";
            this.colGazeFixationsID.MinimumWidth = 30;
            this.colGazeFixationsID.Name = "colGazeFixationsID";
            this.colGazeFixationsID.ReadOnly = true;
            this.colGazeFixationsID.Width = 60;
            // 
            // colGazeFixationsSubjectName
            // 
            this.colGazeFixationsSubjectName.DataPropertyName = "SubjectName";
            this.colGazeFixationsSubjectName.HeaderText = "SubjectName";
            this.colGazeFixationsSubjectName.MinimumWidth = 30;
            this.colGazeFixationsSubjectName.Name = "colGazeFixationsSubjectName";
            this.colGazeFixationsSubjectName.Width = 80;
            // 
            // colGazeFixationsTrialID
            // 
            this.colGazeFixationsTrialID.DataPropertyName = "TrialID";
            this.colGazeFixationsTrialID.HeaderText = "TrialID";
            this.colGazeFixationsTrialID.MinimumWidth = 30;
            this.colGazeFixationsTrialID.Name = "colGazeFixationsTrialID";
            this.colGazeFixationsTrialID.Width = 60;
            // 
            // colGazeFixationsTrialSequence
            // 
            this.colGazeFixationsTrialSequence.DataPropertyName = "TrialSequence";
            this.colGazeFixationsTrialSequence.HeaderText = "TrialSequence";
            this.colGazeFixationsTrialSequence.MinimumWidth = 30;
            this.colGazeFixationsTrialSequence.Name = "colGazeFixationsTrialSequence";
            this.colGazeFixationsTrialSequence.Width = 80;
            // 
            // colGazeFixationsCountInTrial
            // 
            this.colGazeFixationsCountInTrial.DataPropertyName = "CountInTrial";
            this.colGazeFixationsCountInTrial.HeaderText = "CountInTrial";
            this.colGazeFixationsCountInTrial.MinimumWidth = 30;
            this.colGazeFixationsCountInTrial.Name = "colGazeFixationsCountInTrial";
            this.colGazeFixationsCountInTrial.Width = 80;
            // 
            // colGazeFixationsStartTime
            // 
            this.colGazeFixationsStartTime.DataPropertyName = "StartTime";
            this.colGazeFixationsStartTime.HeaderText = "StartTime";
            this.colGazeFixationsStartTime.MinimumWidth = 30;
            this.colGazeFixationsStartTime.Name = "colGazeFixationsStartTime";
            this.colGazeFixationsStartTime.Width = 80;
            // 
            // colGazeFixationsLength
            // 
            this.colGazeFixationsLength.DataPropertyName = "Length";
            this.colGazeFixationsLength.HeaderText = "Length";
            this.colGazeFixationsLength.MinimumWidth = 30;
            this.colGazeFixationsLength.Name = "colGazeFixationsLength";
            this.colGazeFixationsLength.Width = 80;
            // 
            // colGazeFixationsPosX
            // 
            this.colGazeFixationsPosX.DataPropertyName = "PosX";
            this.colGazeFixationsPosX.HeaderText = "PosX";
            this.colGazeFixationsPosX.MinimumWidth = 30;
            this.colGazeFixationsPosX.Name = "colGazeFixationsPosX";
            this.colGazeFixationsPosX.Width = 60;
            // 
            // colGazeFixationsPosY
            // 
            this.colGazeFixationsPosY.DataPropertyName = "PosY";
            this.colGazeFixationsPosY.HeaderText = "PosY";
            this.colGazeFixationsPosY.MinimumWidth = 30;
            this.colGazeFixationsPosY.Name = "colGazeFixationsPosY";
            this.colGazeFixationsPosY.Width = 60;
            // 
            // tbpMouseFixations
            // 
            this.tbpMouseFixations.Controls.Add(this.dgvMouseFixations);
            this.tbpMouseFixations.ImageKey = "MouseFixations";
            this.tbpMouseFixations.Location = new System.Drawing.Point(4, 23);
            this.tbpMouseFixations.Name = "tbpMouseFixations";
            this.tbpMouseFixations.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMouseFixations.Size = new System.Drawing.Size(1157, 366);
            this.tbpMouseFixations.TabIndex = 7;
            this.tbpMouseFixations.Text = "Mouse Fixations";
            this.tbpMouseFixations.UseVisualStyleBackColor = true;
            // 
            // dgvMouseFixations
            // 
            this.dgvMouseFixations.AllowUserToAddRows = false;
            this.dgvMouseFixations.AutoGenerateColumns = false;
            this.dgvMouseFixations.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvMouseFixations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMouseFixationsID,
            this.colMouseFixationsSubjectName,
            this.colMouseFixationsTrialID,
            this.colMouseFixationsTrialSequence,
            this.colMouseFixationsCountInTrial,
            this.colMouseFixationsStartTime,
            this.colMouseFixationsLength,
            this.colMouseFixationsPosX,
            this.colMouseFixationsPosY});
            this.dgvMouseFixations.ContextMenuStrip = this.cmsDataGridView;
            this.dgvMouseFixations.DataSource = this.bsoTrialsMouseFixations;
            this.dgvMouseFixations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMouseFixations.Location = new System.Drawing.Point(3, 3);
            this.dgvMouseFixations.Name = "dgvMouseFixations";
            this.dgvMouseFixations.Size = new System.Drawing.Size(1151, 360);
            this.dgvMouseFixations.TabIndex = 0;
            this.dgvMouseFixations.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // colMouseFixationsID
            // 
            this.colMouseFixationsID.DataPropertyName = "ID";
            this.colMouseFixationsID.HeaderText = "ID";
            this.colMouseFixationsID.MinimumWidth = 30;
            this.colMouseFixationsID.Name = "colMouseFixationsID";
            this.colMouseFixationsID.ReadOnly = true;
            this.colMouseFixationsID.Width = 60;
            // 
            // colMouseFixationsSubjectName
            // 
            this.colMouseFixationsSubjectName.DataPropertyName = "SubjectName";
            this.colMouseFixationsSubjectName.HeaderText = "SubjectName";
            this.colMouseFixationsSubjectName.MinimumWidth = 30;
            this.colMouseFixationsSubjectName.Name = "colMouseFixationsSubjectName";
            this.colMouseFixationsSubjectName.Width = 80;
            // 
            // colMouseFixationsTrialID
            // 
            this.colMouseFixationsTrialID.DataPropertyName = "TrialID";
            this.colMouseFixationsTrialID.HeaderText = "TrialID";
            this.colMouseFixationsTrialID.MinimumWidth = 30;
            this.colMouseFixationsTrialID.Name = "colMouseFixationsTrialID";
            this.colMouseFixationsTrialID.Width = 60;
            // 
            // colMouseFixationsTrialSequence
            // 
            this.colMouseFixationsTrialSequence.DataPropertyName = "TrialSequence";
            this.colMouseFixationsTrialSequence.HeaderText = "TrialSequence";
            this.colMouseFixationsTrialSequence.MinimumWidth = 30;
            this.colMouseFixationsTrialSequence.Name = "colMouseFixationsTrialSequence";
            this.colMouseFixationsTrialSequence.Width = 80;
            // 
            // colMouseFixationsCountInTrial
            // 
            this.colMouseFixationsCountInTrial.DataPropertyName = "CountInTrial";
            this.colMouseFixationsCountInTrial.HeaderText = "CountInTrial";
            this.colMouseFixationsCountInTrial.MinimumWidth = 30;
            this.colMouseFixationsCountInTrial.Name = "colMouseFixationsCountInTrial";
            this.colMouseFixationsCountInTrial.Width = 80;
            // 
            // colMouseFixationsStartTime
            // 
            this.colMouseFixationsStartTime.DataPropertyName = "StartTime";
            this.colMouseFixationsStartTime.HeaderText = "StartTime";
            this.colMouseFixationsStartTime.MinimumWidth = 30;
            this.colMouseFixationsStartTime.Name = "colMouseFixationsStartTime";
            this.colMouseFixationsStartTime.Width = 80;
            // 
            // colMouseFixationsLength
            // 
            this.colMouseFixationsLength.DataPropertyName = "Length";
            this.colMouseFixationsLength.HeaderText = "Length";
            this.colMouseFixationsLength.MinimumWidth = 30;
            this.colMouseFixationsLength.Name = "colMouseFixationsLength";
            this.colMouseFixationsLength.Width = 80;
            // 
            // colMouseFixationsPosX
            // 
            this.colMouseFixationsPosX.DataPropertyName = "PosX";
            this.colMouseFixationsPosX.HeaderText = "PosX";
            this.colMouseFixationsPosX.MinimumWidth = 30;
            this.colMouseFixationsPosX.Name = "colMouseFixationsPosX";
            this.colMouseFixationsPosX.Width = 60;
            // 
            // colMouseFixationsPosY
            // 
            this.colMouseFixationsPosY.DataPropertyName = "PosY";
            this.colMouseFixationsPosY.HeaderText = "PosY";
            this.colMouseFixationsPosY.MinimumWidth = 30;
            this.colMouseFixationsPosY.Name = "colMouseFixationsPosY";
            this.colMouseFixationsPosY.Width = 60;
            // 
            // tbpAOI
            // 
            this.tbpAOI.Controls.Add(this.dgvAOIs);
            this.tbpAOI.ImageKey = "AOIs";
            this.tbpAOI.Location = new System.Drawing.Point(4, 23);
            this.tbpAOI.Name = "tbpAOI";
            this.tbpAOI.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAOI.Size = new System.Drawing.Size(1157, 366);
            this.tbpAOI.TabIndex = 4;
            this.tbpAOI.Text = "Areas of Interest";
            this.tbpAOI.UseVisualStyleBackColor = true;
            // 
            // dgvAOIs
            // 
            this.dgvAOIs.AutoGenerateColumns = false;
            this.dgvAOIs.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvAOIs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAOIsID,
            this.colAOIsTrialID,
            this.colAOIsSlideNr,
            this.colAOIsShapeName,
            this.colAOIsShapeType,
            this.colAOIsShapeNumPts,
            this.colAOIsShapePts,
            this.colAOIsShapeGroup});
            this.dgvAOIs.ContextMenuStrip = this.cmsDataGridView;
            this.dgvAOIs.DataSource = this.bsoTrialsAOIs;
            this.dgvAOIs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAOIs.Location = new System.Drawing.Point(3, 3);
            this.dgvAOIs.Name = "dgvAOIs";
            this.dgvAOIs.Size = new System.Drawing.Size(1151, 360);
            this.dgvAOIs.TabIndex = 0;
            this.dgvAOIs.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // tbpShapeGroups
            // 
            this.tbpShapeGroups.Controls.Add(this.dgvShapeGroups);
            this.tbpShapeGroups.ImageKey = "ShapeGroups";
            this.tbpShapeGroups.Location = new System.Drawing.Point(4, 23);
            this.tbpShapeGroups.Name = "tbpShapeGroups";
            this.tbpShapeGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tbpShapeGroups.Size = new System.Drawing.Size(1157, 366);
            this.tbpShapeGroups.TabIndex = 6;
            this.tbpShapeGroups.Text = "Shape Groups";
            this.tbpShapeGroups.UseVisualStyleBackColor = true;
            // 
            // dgvShapeGroups
            // 
            this.dgvShapeGroups.AutoGenerateColumns = false;
            this.dgvShapeGroups.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvShapeGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShapeGroupsID,
            this.colShapeGroupsShapeGroup});
            this.dgvShapeGroups.ContextMenuStrip = this.cmsDataGridView;
            this.dgvShapeGroups.DataSource = this.bsoShapeGroups;
            this.dgvShapeGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShapeGroups.Location = new System.Drawing.Point(3, 3);
            this.dgvShapeGroups.Name = "dgvShapeGroups";
            this.dgvShapeGroups.Size = new System.Drawing.Size(1151, 360);
            this.dgvShapeGroups.TabIndex = 0;
            this.dgvShapeGroups.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // colShapeGroupsID
            // 
            this.colShapeGroupsID.DataPropertyName = "ID";
            this.colShapeGroupsID.HeaderText = "ID";
            this.colShapeGroupsID.MinimumWidth = 30;
            this.colShapeGroupsID.Name = "colShapeGroupsID";
            this.colShapeGroupsID.ReadOnly = true;
            this.colShapeGroupsID.Width = 60;
            // 
            // colShapeGroupsShapeGroup
            // 
            this.colShapeGroupsShapeGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colShapeGroupsShapeGroup.DataPropertyName = "ShapeGroup";
            this.colShapeGroupsShapeGroup.HeaderText = "ShapeGroup";
            this.colShapeGroupsShapeGroup.MinimumWidth = 30;
            this.colShapeGroupsShapeGroup.Name = "colShapeGroupsShapeGroup";
            // 
            // tbpCalibrations
            // 
            this.tbpCalibrations.Controls.Add(this.dgvCalibrations);
            this.tbpCalibrations.Location = new System.Drawing.Point(4, 23);
            this.tbpCalibrations.Name = "tbpCalibrations";
            this.tbpCalibrations.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCalibrations.Size = new System.Drawing.Size(1157, 366);
            this.tbpCalibrations.TabIndex = 10;
            this.tbpCalibrations.Text = "Calibrations";
            this.tbpCalibrations.UseVisualStyleBackColor = true;
            // 
            // dgvCalibrations
            // 
            this.dgvCalibrations.AllowUserToDeleteRows = false;
            this.dgvCalibrations.AllowUserToOrderColumns = true;
            this.dgvCalibrations.AutoGenerateColumns = false;
            this.dgvCalibrations.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvCalibrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalibrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCalibrationsID,
            this.colCalibrationsSubjectName,
            this.colCalibrationsAccuracy,
            this.colCalibrationsAccuracyLeft,
            this.colCalibrationsAccuracyRight});
            this.dgvCalibrations.DataSource = this.bsoFKSubjectsCalibrations;
            this.dgvCalibrations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalibrations.Location = new System.Drawing.Point(3, 3);
            this.dgvCalibrations.Name = "dgvCalibrations";
            this.dgvCalibrations.Size = new System.Drawing.Size(1151, 360);
            this.dgvCalibrations.TabIndex = 0;
            this.dgvCalibrations.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            // 
            // colCalibrationsID
            // 
            this.colCalibrationsID.DataPropertyName = "ID";
            this.colCalibrationsID.HeaderText = "ID";
            this.colCalibrationsID.Name = "colCalibrationsID";
            this.colCalibrationsID.ReadOnly = true;
            // 
            // colCalibrationsSubjectName
            // 
            this.colCalibrationsSubjectName.DataPropertyName = "SubjectName";
            this.colCalibrationsSubjectName.HeaderText = "SubjectName";
            this.colCalibrationsSubjectName.Name = "colCalibrationsSubjectName";
            // 
            // colCalibrationsAccuracy
            // 
            this.colCalibrationsAccuracy.DataPropertyName = "Accuracy";
            this.colCalibrationsAccuracy.HeaderText = "Accuracy";
            this.colCalibrationsAccuracy.Name = "colCalibrationsAccuracy";
            // 
            // colCalibrationsAccuracyLeft
            // 
            this.colCalibrationsAccuracyLeft.DataPropertyName = "AccuracyLeft";
            this.colCalibrationsAccuracyLeft.HeaderText = "AccuracyLeft";
            this.colCalibrationsAccuracyLeft.Name = "colCalibrationsAccuracyLeft";
            // 
            // colCalibrationsAccuracyRight
            // 
            this.colCalibrationsAccuracyRight.DataPropertyName = "AccuracyRight";
            this.colCalibrationsAccuracyRight.HeaderText = "AccuracyRight";
            this.colCalibrationsAccuracyRight.Name = "colCalibrationsAccuracyRight";
            // 
            // imlTabs
            // 
            this.imlTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTabs.ImageStream")));
            this.imlTabs.TransparentColor = System.Drawing.Color.Magenta;
            this.imlTabs.Images.SetKeyName(0, "Subjects");
            this.imlTabs.Images.SetKeyName(1, "SubjectProperties");
            this.imlTabs.Images.SetKeyName(2, "GazeFixations");
            this.imlTabs.Images.SetKeyName(3, "MouseFixations");
            this.imlTabs.Images.SetKeyName(4, "Trials");
            this.imlTabs.Images.SetKeyName(5, "RawData");
            this.imlTabs.Images.SetKeyName(6, "Events");
            this.imlTabs.Images.SetKeyName(7, "ShapeGroups");
            this.imlTabs.Images.SetKeyName(8, "AOIs");
            this.imlTabs.Images.SetKeyName(9, "Params");
            // 
            // toolStrip1
            // 
            this.toolStrip1.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Ogama.Properties.Settings.Default, "DTBToolbarLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImport,
            this.btnImportOgamaFormat,
            this.btnExport,
            this.toolStripSeparator1,
            this.btnSave,
            this.toolStripSeparator3,
            this.btnFilterData,
            this.toolStripSeparator2,
            this.btnHelp,
            this.btnSpecial});
            this.toolStrip1.Location = global::Ogama.Properties.Settings.Default.DTBToolbarLocation;
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(258, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // btnImport
            // 
            this.btnImport.Image = global::Ogama.Properties.Resources.MagicWand;
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(113, 22);
            this.btnImport.Text = "Import Assistant";
            this.btnImport.ToolTipText = "Start import assistant to import eye- and/or mousetracker\r\ndata from ASCII files." +
    "";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnImportOgamaFormat
            // 
            this.btnImportOgamaFormat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImportOgamaFormat.Image = global::Ogama.Properties.Resources.ImportData;
            this.btnImportOgamaFormat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportOgamaFormat.Name = "btnImportOgamaFormat";
            this.btnImportOgamaFormat.Size = new System.Drawing.Size(23, 22);
            this.btnImportOgamaFormat.ToolTipText = "Import data that was previously exported with OGAMA.";
            this.btnImportOgamaFormat.Click += new System.EventHandler(this.btnImportOgamaFormat_Click);
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = global::Ogama.Properties.Resources.ExportData;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(23, 22);
            this.btnExport.ToolTipText = "Export tables into ASCII-files.";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::Ogama.Properties.Resources.saveHS;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Commit changes";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFilterData
            // 
            this.btnFilterData.Checked = true;
            this.btnFilterData.CheckOnClick = true;
            this.btnFilterData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnFilterData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilterData.Image = global::Ogama.Properties.Resources.Filter2HS;
            this.btnFilterData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilterData.Name = "btnFilterData";
            this.btnFilterData.Size = new System.Drawing.Size(23, 22);
            this.btnFilterData.Text = "Filter by subject and trial";
            this.btnFilterData.Click += new System.EventHandler(this.btnFilterData_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = global::Ogama.Properties.Resources.HelpBmp;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.ToolTipText = "Displays help for this interface.";
            // 
            // btnSpecial
            // 
            this.btnSpecial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSpecial.Image = ((System.Drawing.Image)(resources.GetObject("btnSpecial.Image")));
            this.btnSpecial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(23, 22);
            this.btnSpecial.Text = "toolStripButton1";
            this.btnSpecial.ToolTipText = "Special Conversions";
            this.btnSpecial.Visible = false;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // sfdExport
            // 
            this.sfdExport.DefaultExt = "*.txt";
            this.sfdExport.FileName = "*.txt";
            this.sfdExport.Filter = "Text files - *.txt|*.txt|comma separated values - *.csv|*.csv";
            this.sfdExport.Title = "Choose file to save raw data ...";
            // 
            // bgwExport
            // 
            this.bgwExport.WorkerReportsProgress = true;
            this.bgwExport.WorkerSupportsCancellation = true;
            this.bgwExport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwExport_DoWork);
            this.bgwExport.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwExport_ProgressChanged);
            this.bgwExport.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwExport_RunWorkerCompleted);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn2.HeaderText = "SubjectName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn4.HeaderText = "Age";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sex";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sex";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Handedness";
            this.dataGridViewTextBoxColumn6.HeaderText = "Handedness";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn7.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Glasses";
            this.dataGridViewTextBoxColumn8.HeaderText = "Glasses";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Light";
            this.dataGridViewTextBoxColumn9.HeaderText = "Room Light";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Ambiance";
            this.dataGridViewTextBoxColumn10.HeaderText = "Room Ambiance";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 40;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Language";
            this.dataGridViewTextBoxColumn11.HeaderText = "Language";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn12.HeaderText = "SubjectType";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 60;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn14.HeaderText = "SubjectName";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Param";
            this.dataGridViewComboBoxColumn1.DataSource = this.bsoParams;
            this.dataGridViewComboBoxColumn1.DisplayMember = "Param";
            this.dataGridViewComboBoxColumn1.HeaderText = "Param";
            this.dataGridViewComboBoxColumn1.MinimumWidth = 80;
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.ValueMember = "Param";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ParamValue";
            this.dataGridViewTextBoxColumn15.HeaderText = "ParamValue";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn16.HeaderText = "ID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Param";
            this.dataGridViewTextBoxColumn17.HeaderText = "Param";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn18.HeaderText = "Description";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn19.HeaderText = "ID";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 60;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn20.HeaderText = "Subjectname";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 80;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "TrialSequence";
            this.dataGridViewTextBoxColumn21.HeaderText = "Sequence";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 80;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "TrialID";
            this.dataGridViewTextBoxColumn22.HeaderText = "TrialID";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 40;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "TrialName";
            this.dataGridViewTextBoxColumn23.HeaderText = "Name";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 80;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn24.HeaderText = "Category";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "TrialStartTime";
            this.dataGridViewTextBoxColumn25.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 60;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn26.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 60;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "EliminateData";
            this.dataGridViewTextBoxColumn27.HeaderText = "Eliminate";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 60;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn28.HeaderText = "ID";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 60;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn29.HeaderText = "SubjectName";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 80;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "TrialSequence";
            this.dataGridViewTextBoxColumn30.HeaderText = "TrialSequence";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 80;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "EventID";
            this.dataGridViewTextBoxColumn31.HeaderText = "EventID";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 60;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "EventTime";
            this.dataGridViewTextBoxColumn32.HeaderText = "EventTime";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 60;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "EventType";
            this.dataGridViewTextBoxColumn33.HeaderText = "EventType";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 80;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "EventTask";
            this.dataGridViewTextBoxColumn34.HeaderText = "EventTask";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 80;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn35.DataPropertyName = "EventParam";
            this.dataGridViewTextBoxColumn35.HeaderText = "EventParam";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn36.HeaderText = "ID";
            this.dataGridViewTextBoxColumn36.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Width = 60;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn37.HeaderText = "SubjectName";
            this.dataGridViewTextBoxColumn37.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Width = 80;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "TrialID";
            this.dataGridViewTextBoxColumn38.HeaderText = "TrialID";
            this.dataGridViewTextBoxColumn38.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.Width = 60;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "TrialSequence";
            this.dataGridViewTextBoxColumn39.HeaderText = "TrialSequence";
            this.dataGridViewTextBoxColumn39.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.Width = 80;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "CountInTrial";
            this.dataGridViewTextBoxColumn40.HeaderText = "CountInTrial";
            this.dataGridViewTextBoxColumn40.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.Width = 80;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn41.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn41.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.Width = 80;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Length";
            this.dataGridViewTextBoxColumn42.HeaderText = "Length";
            this.dataGridViewTextBoxColumn42.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.Width = 80;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "PosX";
            this.dataGridViewTextBoxColumn43.HeaderText = "PosX";
            this.dataGridViewTextBoxColumn43.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.Width = 60;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "PosY";
            this.dataGridViewTextBoxColumn44.HeaderText = "PosY";
            this.dataGridViewTextBoxColumn44.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.Width = 60;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn45.HeaderText = "ID";
            this.dataGridViewTextBoxColumn45.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Width = 60;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn46.HeaderText = "SubjectName";
            this.dataGridViewTextBoxColumn46.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.Width = 80;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "TrialID";
            this.dataGridViewTextBoxColumn47.HeaderText = "TrialID";
            this.dataGridViewTextBoxColumn47.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.Width = 60;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "TrialSequence";
            this.dataGridViewTextBoxColumn48.HeaderText = "TrialSequence";
            this.dataGridViewTextBoxColumn48.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.Width = 80;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "CountInTrial";
            this.dataGridViewTextBoxColumn49.HeaderText = "CountInTrial";
            this.dataGridViewTextBoxColumn49.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.Width = 80;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn50.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn50.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.Width = 80;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Length";
            this.dataGridViewTextBoxColumn51.HeaderText = "Length";
            this.dataGridViewTextBoxColumn51.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.Width = 80;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "PosX";
            this.dataGridViewTextBoxColumn52.HeaderText = "PosX";
            this.dataGridViewTextBoxColumn52.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.Width = 60;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "PosY";
            this.dataGridViewTextBoxColumn53.HeaderText = "PosY";
            this.dataGridViewTextBoxColumn53.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.Width = 60;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn54.HeaderText = "ID";
            this.dataGridViewTextBoxColumn54.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.Width = 60;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "TrialID";
            this.dataGridViewTextBoxColumn55.HeaderText = "TrialID";
            this.dataGridViewTextBoxColumn55.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.Width = 60;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "SlideNr";
            this.dataGridViewTextBoxColumn56.HeaderText = "SlideNr";
            this.dataGridViewTextBoxColumn56.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.Width = 60;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "ShapeName";
            this.dataGridViewTextBoxColumn57.HeaderText = "Name";
            this.dataGridViewTextBoxColumn57.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.Width = 80;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "ShapeType";
            this.dataGridViewTextBoxColumn58.HeaderText = "Type";
            this.dataGridViewTextBoxColumn58.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.Width = 80;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "ShapeNumPts";
            this.dataGridViewTextBoxColumn59.HeaderText = "NumPts";
            this.dataGridViewTextBoxColumn59.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.Width = 60;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn60.DataPropertyName = "ShapePts";
            this.dataGridViewTextBoxColumn60.HeaderText = "Points";
            this.dataGridViewTextBoxColumn60.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "ShapeGroup";
            this.dataGridViewComboBoxColumn2.DataSource = this.bsoShapeGroups;
            this.dataGridViewComboBoxColumn2.DisplayMember = "ShapeGroup";
            this.dataGridViewComboBoxColumn2.HeaderText = "Group";
            this.dataGridViewComboBoxColumn2.MinimumWidth = 30;
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.ValueMember = "ShapeGroup";
            this.dataGridViewComboBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn61.HeaderText = "ID";
            this.dataGridViewTextBoxColumn61.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            this.dataGridViewTextBoxColumn61.Width = 60;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn62.DataPropertyName = "ShapeGroup";
            this.dataGridViewTextBoxColumn62.HeaderText = "ShapeGroup";
            this.dataGridViewTextBoxColumn62.MinimumWidth = 30;
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "SubjectName";
            this.dataGridViewTextBoxColumn63.HeaderText = "SubjectName";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "Accuracy";
            this.dataGridViewTextBoxColumn64.HeaderText = "Accuracy";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "AccuracyLeft";
            this.dataGridViewTextBoxColumn65.HeaderText = "AccuracyLeft";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            // 
            // colAOIsID
            // 
            this.colAOIsID.DataPropertyName = "ID";
            this.colAOIsID.HeaderText = "ID";
            this.colAOIsID.Name = "colAOIsID";
            this.colAOIsID.ReadOnly = true;
            // 
            // colAOIsTrialID
            // 
            this.colAOIsTrialID.DataPropertyName = "TrialID";
            this.colAOIsTrialID.HeaderText = "TrialID";
            this.colAOIsTrialID.Name = "colAOIsTrialID";
            // 
            // colAOIsSlideNr
            // 
            this.colAOIsSlideNr.DataPropertyName = "SlideNr";
            this.colAOIsSlideNr.HeaderText = "SlideNr";
            this.colAOIsSlideNr.Name = "colAOIsSlideNr";
            // 
            // colAOIsShapeName
            // 
            this.colAOIsShapeName.DataPropertyName = "ShapeName";
            this.colAOIsShapeName.HeaderText = "ShapeName";
            this.colAOIsShapeName.Name = "colAOIsShapeName";
            // 
            // colAOIsShapeType
            // 
            this.colAOIsShapeType.DataPropertyName = "ShapeType";
            this.colAOIsShapeType.HeaderText = "ShapeType";
            this.colAOIsShapeType.Name = "colAOIsShapeType";
            // 
            // colAOIsShapeNumPts
            // 
            this.colAOIsShapeNumPts.DataPropertyName = "ShapeNumPts";
            this.colAOIsShapeNumPts.HeaderText = "ShapeNumPts";
            this.colAOIsShapeNumPts.Name = "colAOIsShapeNumPts";
            // 
            // colAOIsShapePts
            // 
            this.colAOIsShapePts.DataPropertyName = "ShapePts";
            this.colAOIsShapePts.HeaderText = "ShapePts";
            this.colAOIsShapePts.Name = "colAOIsShapePts";
            // 
            // colAOIsShapeGroup
            // 
            this.colAOIsShapeGroup.DataPropertyName = "ShapeGroup";
            this.colAOIsShapeGroup.HeaderText = "ShapeGroup";
            this.colAOIsShapeGroup.Name = "colAOIsShapeGroup";
            // 
            // DatabaseModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 418);
            this.Controls.Add(this.toolStripContainer1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Ogama.Properties.Settings.Default, "DatabaseModuleLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::Ogama.Properties.Settings.Default.DatabaseModuleLocation;
            this.Logo = global::Ogama.Properties.Resources.DatabaseLogo;
            this.Name = "DatabaseModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Module";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatabaseModule_FormClosing);
            this.Load += new System.EventHandler(this.DatabaseModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsoSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoFKSubjectsTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoFKTrialsEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoTrialsAOIs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoTrialsGazeFixations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoTrialsMouseFixations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoShapeGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoFKSubjectsSubjectParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoSubjectParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoTrialEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoGazeFixations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoMouseFixations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoAOIs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoParams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoCalibrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsoFKSubjectsCalibrations)).EndInit();
            this.cmsDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tacTables.ResumeLayout(false);
            this.tbpSubjects.ResumeLayout(false);
            this.tbpSubjectParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjectParameters)).EndInit();
            this.tbpParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).EndInit();
            this.tbpTrials.ResumeLayout(false);
            this.tbpTrialEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrialEvents)).EndInit();
            this.tbpRawdata.ResumeLayout(false);
            this.tbpGazeFixations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGazeFixations)).EndInit();
            this.tbpMouseFixations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMouseFixations)).EndInit();
            this.tbpAOI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAOIs)).EndInit();
            this.tbpShapeGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShapeGroups)).EndInit();
            this.tbpCalibrations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalibrations)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private ToolTip toolTip1;
    private ToolStripContainer toolStripContainer1;
    private ToolStrip toolStrip1;
    private ToolStripButton btnExport;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripButton btnHelp;
    private SaveFileDialog sfdExport;
    private ContextMenuStrip cmsDataGridView;
    private ToolStripMenuItem cmsSelect;
    private ToolStripMenuItem cmsCopy;
    private ToolStripMenuItem cmsModifyData;
    private ToolStripButton btnSpecial;
    private ToolStripButton btnImportOgamaFormat;
    private BackgroundWorker bgwExport;
    private ImageList imlTabs;
		private ToolStripButton btnFilterData;
        private ToolStripSeparator toolStripSeparator2;
    private ToolStripButton btnSave;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripButton btnImport;
    private DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn accuracyDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn accuracyLeftDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
    private TabControl tacTables;
    private TabPage tbpSubjects;
    private DataGridView dgvSubjects;
    private DataGridViewTextBoxColumn colSubjectsID;
    private DataGridViewTextBoxColumn colSubjectsSubjectName;
    private DataGridViewTextBoxColumn colSubjectsCategory;
    private DataGridViewTextBoxColumn colSubjectsAge;
    private DataGridViewTextBoxColumn colSubjectsSex;
    private DataGridViewTextBoxColumn colSubjectsHandedness;
    private DataGridViewTextBoxColumn colSubjectsComments;
    private DataGridViewTextBoxColumn colGlasses;
    private DataGridViewTextBoxColumn colLight;
    private DataGridViewTextBoxColumn colAmbiance;
    private DataGridViewTextBoxColumn colLanguage;
    private DataGridViewTextBoxColumn colType;
    private TabPage tbpSubjectParameters;
    private DataGridView dgvSubjectParameters;
    private DataGridViewTextBoxColumn colSubjectParametersID;
    private DataGridViewTextBoxColumn colSubjectParametersSubjectName;
    private DataGridViewComboBoxColumn colSubjectParametersParam;
    private DataGridViewTextBoxColumn colSubjectParametersSubjectNameParamValue;
    private TabPage tbpParams;
    private DataGridView dgvParams;
    private DataGridViewTextBoxColumn colParamsID;
    private DataGridViewTextBoxColumn paramDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private TabPage tbpTrials;
    private DataGridView dgvTrials;
    private DataGridViewTextBoxColumn colTrialsID;
    private DataGridViewTextBoxColumn colTrialsSubjectName;
    private DataGridViewTextBoxColumn colTrialsTrialSequence;
    private DataGridViewTextBoxColumn colTrialsTrialID;
    private DataGridViewTextBoxColumn colTrialsTrialName;
    private DataGridViewTextBoxColumn colTrialsCategory;
    private DataGridViewTextBoxColumn colTrialsTrialStartTime;
    private DataGridViewTextBoxColumn colTrialsDuration;
    private DataGridViewTextBoxColumn colTrialsEliminateData;
    private TabPage tbpTrialEvents;
    private DataGridView dgvTrialEvents;
    private DataGridViewTextBoxColumn colTrialEventsID;
    private DataGridViewTextBoxColumn colTrialEventsSubjectName;
    private DataGridViewTextBoxColumn colTrialEventsTrialSequence;
    private DataGridViewTextBoxColumn colTrialEventsEventID;
    private DataGridViewTextBoxColumn colTrialEventsEventTime;
    private DataGridViewTextBoxColumn colTrialEventsEventType;
    private DataGridViewTextBoxColumn colTrialEventsEventTask;
    private DataGridViewTextBoxColumn colTrialEventsEventParam;
    private TabPage tbpRawdata;
    private DataGridView dgvRawData;
    private TabPage tbpGazeFixations;
    private DataGridView dgvGazeFixations;
    private DataGridViewTextBoxColumn colGazeFixationsID;
    private DataGridViewTextBoxColumn colGazeFixationsSubjectName;
    private DataGridViewTextBoxColumn colGazeFixationsTrialID;
    private DataGridViewTextBoxColumn colGazeFixationsTrialSequence;
    private DataGridViewTextBoxColumn colGazeFixationsCountInTrial;
    private DataGridViewTextBoxColumn colGazeFixationsStartTime;
    private DataGridViewTextBoxColumn colGazeFixationsLength;
    private DataGridViewTextBoxColumn colGazeFixationsPosX;
    private DataGridViewTextBoxColumn colGazeFixationsPosY;
    private TabPage tbpMouseFixations;
    private DataGridView dgvMouseFixations;
    private DataGridViewTextBoxColumn colMouseFixationsID;
    private DataGridViewTextBoxColumn colMouseFixationsSubjectName;
    private DataGridViewTextBoxColumn colMouseFixationsTrialID;
    private DataGridViewTextBoxColumn colMouseFixationsTrialSequence;
    private DataGridViewTextBoxColumn colMouseFixationsCountInTrial;
    private DataGridViewTextBoxColumn colMouseFixationsStartTime;
    private DataGridViewTextBoxColumn colMouseFixationsLength;
    private DataGridViewTextBoxColumn colMouseFixationsPosX;
    private DataGridViewTextBoxColumn colMouseFixationsPosY;
    private TabPage tbpAOI;
    private DataGridView dgvAOIs;
    private TabPage tbpShapeGroups;
    private DataGridView dgvShapeGroups;
    private DataGridViewTextBoxColumn colShapeGroupsID;
    private DataGridViewTextBoxColumn colShapeGroupsShapeGroup;
    private TabPage tbpCalibrations;
    private DataGridView dgvCalibrations;
    private DataGridViewTextBoxColumn colCalibrationsID;
    private DataGridViewTextBoxColumn colCalibrationsSubjectName;
    private DataGridViewTextBoxColumn colCalibrationsAccuracy;
    private DataGridViewTextBoxColumn colCalibrationsAccuracyLeft;
    private DataGridViewTextBoxColumn colCalibrationsAccuracyRight;
    private DataGridViewTextBoxColumn colAOIsID;
    private DataGridViewTextBoxColumn colAOIsTrialID;
    private DataGridViewTextBoxColumn colAOIsSlideNr;
    private DataGridViewTextBoxColumn colAOIsShapeName;
    private DataGridViewTextBoxColumn colAOIsShapeType;
    private DataGridViewTextBoxColumn colAOIsShapeNumPts;
    private DataGridViewTextBoxColumn colAOIsShapePts;
    private DataGridViewTextBoxColumn colAOIsShapeGroup;
  }
}