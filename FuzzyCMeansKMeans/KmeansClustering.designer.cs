namespace FuzzyCMeansKMeans
{
    partial class KmeansClustering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KmeansClustering));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.datasetPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.initialGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDatasetNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudClusters = new System.Windows.Forms.NumericUpDown();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.clusterPage = new System.Windows.Forms.TabPage();
            this.grpClusterGrid = new System.Windows.Forms.GroupBox();
            this.clusterGrid = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudClusterNo = new System.Windows.Forms.NumericUpDown();
            this.btnClusterBack = new System.Windows.Forms.Button();
            this.btnClusterNext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClusterMean = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSquareError = new System.Windows.Forms.TextBox();
            this.viewPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.masterGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewBack = new System.Windows.Forms.Button();
            this.dentitionDataSet = new FuzzyCMeansKMeans.DentitionDataSet();
            this.dentitionAdapter = new FuzzyCMeansKMeans.DentitionDataSetTableAdapters.DentitionAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panMain = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.bndNavCommon = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainTabControl.SuspendLayout();
            this.datasetPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initialGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClusters)).BeginInit();
            this.clusterPage.SuspendLayout();
            this.grpClusterGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClusterNo)).BeginInit();
            this.viewPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGrid)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dentitionDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bndNavCommon)).BeginInit();
            this.bndNavCommon.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.datasetPage);
            this.mainTabControl.Controls.Add(this.clusterPage);
            this.mainTabControl.Controls.Add(this.viewPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(692, 453);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.TabStop = false;
            // 
            // datasetPage
            // 
            this.datasetPage.Controls.Add(this.groupBox1);
            this.datasetPage.Controls.Add(this.tableLayoutPanel1);
            this.datasetPage.Location = new System.Drawing.Point(4, 22);
            this.datasetPage.Name = "datasetPage";
            this.datasetPage.Padding = new System.Windows.Forms.Padding(3);
            this.datasetPage.Size = new System.Drawing.Size(684, 427);
            this.datasetPage.TabIndex = 0;
            this.datasetPage.Text = "Data Set";
            this.datasetPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.initialGrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 391);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data set to be clusters :";
            // 
            // initialGrid
            // 
            this.initialGrid.AllowUserToAddRows = false;
            this.initialGrid.AllowUserToDeleteRows = false;
            this.initialGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.initialGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.initialGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initialGrid.Location = new System.Drawing.Point(3, 16);
            this.initialGrid.Name = "initialGrid";
            this.initialGrid.ReadOnly = true;
            this.initialGrid.Size = new System.Drawing.Size(672, 372);
            this.initialGrid.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Controls.Add(this.btnDatasetNext, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSet, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudClusters, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 394);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 30);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnDatasetNext
            // 
            this.btnDatasetNext.Enabled = false;
            this.btnDatasetNext.Location = new System.Drawing.Point(606, 3);
            this.btnDatasetNext.Name = "btnDatasetNext";
            this.btnDatasetNext.Size = new System.Drawing.Size(69, 23);
            this.btnDatasetNext.TabIndex = 3;
            this.btnDatasetNext.Text = "Next";
            this.btnDatasetNext.UseVisualStyleBackColor = true;
            this.btnDatasetNext.Click += new System.EventHandler(this.btnDatasetNext_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of clusters (k) :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudClusters
            // 
            this.nudClusters.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudClusters.Location = new System.Drawing.Point(484, 5);
            this.nudClusters.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudClusters.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudClusters.Name = "nudClusters";
            this.nudClusters.Size = new System.Drawing.Size(40, 20);
            this.nudClusters.TabIndex = 1;
            this.nudClusters.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnSet
            // 
            this.btnSet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSet.Location = new System.Drawing.Point(531, 3);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(68, 23);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(290, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(66, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // clusterPage
            // 
            this.clusterPage.Controls.Add(this.panel3);
            this.clusterPage.Controls.Add(this.panel2);
            this.clusterPage.Controls.Add(this.panel1);
            this.clusterPage.Location = new System.Drawing.Point(4, 22);
            this.clusterPage.Name = "clusterPage";
            this.clusterPage.Padding = new System.Windows.Forms.Padding(3);
            this.clusterPage.Size = new System.Drawing.Size(684, 427);
            this.clusterPage.TabIndex = 1;
            this.clusterPage.Text = "Clusters";
            this.clusterPage.UseVisualStyleBackColor = true;
            this.clusterPage.Enter += new System.EventHandler(this.clusterPage_Enter);
            // 
            // grpClusterGrid
            // 
            this.grpClusterGrid.Controls.Add(this.clusterGrid);
            this.grpClusterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpClusterGrid.Location = new System.Drawing.Point(0, 0);
            this.grpClusterGrid.Name = "grpClusterGrid";
            this.grpClusterGrid.Size = new System.Drawing.Size(678, 327);
            this.grpClusterGrid.TabIndex = 5;
            this.grpClusterGrid.TabStop = false;
            this.grpClusterGrid.Text = "Cluster 1:";
            // 
            // clusterGrid
            // 
            this.clusterGrid.AllowUserToAddRows = false;
            this.clusterGrid.AllowUserToDeleteRows = false;
            this.clusterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clusterGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.clusterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clusterGrid.Location = new System.Drawing.Point(3, 16);
            this.clusterGrid.Name = "clusterGrid";
            this.clusterGrid.ReadOnly = true;
            this.clusterGrid.Size = new System.Drawing.Size(672, 308);
            this.clusterGrid.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.Location = new System.Drawing.Point(596, 10);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(68, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalyze.Location = new System.Drawing.Point(569, 13);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(95, 23);
            this.btnAnalyze.TabIndex = 6;
            this.btnAnalyze.Text = "k-Means Cluster";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Initial Cluster -  k :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudClusterNo
            // 
            this.nudClusterNo.Location = new System.Drawing.Point(111, 13);
            this.nudClusterNo.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudClusterNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClusterNo.Name = "nudClusterNo";
            this.nudClusterNo.Size = new System.Drawing.Size(60, 20);
            this.nudClusterNo.TabIndex = 5;
            this.nudClusterNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClusterNo.ValueChanged += new System.EventHandler(this.nudClusterNo_ValueChanged);
            // 
            // btnClusterBack
            // 
            this.btnClusterBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClusterBack.Location = new System.Drawing.Point(488, 13);
            this.btnClusterBack.Name = "btnClusterBack";
            this.btnClusterBack.Size = new System.Drawing.Size(75, 23);
            this.btnClusterBack.TabIndex = 2;
            this.btnClusterBack.Text = "<< Back";
            this.btnClusterBack.UseVisualStyleBackColor = true;
            this.btnClusterBack.Click += new System.EventHandler(this.btnClusterBack_Click);
            // 
            // btnClusterNext
            // 
            this.btnClusterNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClusterNext.Enabled = false;
            this.btnClusterNext.Location = new System.Drawing.Point(521, 10);
            this.btnClusterNext.Name = "btnClusterNext";
            this.btnClusterNext.Size = new System.Drawing.Size(69, 23);
            this.btnClusterNext.TabIndex = 6;
            this.btnClusterNext.Text = "Next >>";
            this.btnClusterNext.UseVisualStyleBackColor = true;
            this.btnClusterNext.Visible = false;
            this.btnClusterNext.Click += new System.EventHandler(this.btnClusterNext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cluster means :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClusterMean
            // 
            this.txtClusterMean.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClusterMean.BackColor = System.Drawing.SystemColors.Info;
            this.txtClusterMean.Location = new System.Drawing.Point(100, 16);
            this.txtClusterMean.Name = "txtClusterMean";
            this.txtClusterMean.ReadOnly = true;
            this.txtClusterMean.Size = new System.Drawing.Size(61, 20);
            this.txtClusterMean.TabIndex = 5;
            this.txtClusterMean.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Squared-Error :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSquareError
            // 
            this.txtSquareError.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSquareError.BackColor = System.Drawing.SystemColors.Info;
            this.txtSquareError.Location = new System.Drawing.Point(254, 15);
            this.txtSquareError.Name = "txtSquareError";
            this.txtSquareError.ReadOnly = true;
            this.txtSquareError.Size = new System.Drawing.Size(61, 20);
            this.txtSquareError.TabIndex = 4;
            this.txtSquareError.TabStop = false;
            // 
            // viewPage
            // 
            this.viewPage.Controls.Add(this.tabControl);
            this.viewPage.Controls.Add(this.tableLayoutPanel4);
            this.viewPage.Location = new System.Drawing.Point(4, 22);
            this.viewPage.Name = "viewPage";
            this.viewPage.Size = new System.Drawing.Size(684, 427);
            this.viewPage.TabIndex = 2;
            this.viewPage.Text = "View Clusters";
            this.viewPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.masterGrid);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 365);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cluster view :";
            // 
            // masterGrid
            // 
            this.masterGrid.AllowUserToAddRows = false;
            this.masterGrid.AllowUserToDeleteRows = false;
            this.masterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.masterGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.masterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterGrid.Location = new System.Drawing.Point(3, 16);
            this.masterGrid.Name = "masterGrid";
            this.masterGrid.ReadOnly = true;
            this.masterGrid.RowHeadersVisible = false;
            this.masterGrid.Size = new System.Drawing.Size(664, 346);
            this.masterGrid.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.53846F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel4.Controls.Add(this.btnViewBack, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnClose, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 397);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(684, 30);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btnViewBack
            // 
            this.btnViewBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnViewBack.Location = new System.Drawing.Point(528, 3);
            this.btnViewBack.Name = "btnViewBack";
            this.btnViewBack.Size = new System.Drawing.Size(68, 23);
            this.btnViewBack.TabIndex = 2;
            this.btnViewBack.Text = "<< Back";
            this.btnViewBack.UseVisualStyleBackColor = true;
            this.btnViewBack.Visible = false;
            this.btnViewBack.Click += new System.EventHandler(this.btnViewBack_Click);
            // 
            // dentitionDataSet
            // 
            this.dentitionDataSet.DataSetName = "dentitionDataSet";
            this.dentitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dentitionAdapter
            // 
            this.dentitionAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAnalyze);
            this.panel1.Controls.Add(this.txtSquareError);
            this.panel1.Controls.Add(this.btnClusterBack);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtClusterMean);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 50);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClusterNext);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nudClusterNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 44);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpClusterGrid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 327);
            this.panel3.TabIndex = 8;
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.mainTabControl);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 0);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(692, 453);
            this.panMain.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(684, 397);
            this.tabControl.TabIndex = 7;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Seed Dataset";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(606, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bndNavCommon
            // 
            this.bndNavCommon.AddNewItem = null;
            this.bndNavCommon.CountItem = this.bindingNavigatorCountItem;
            this.bndNavCommon.DeleteItem = null;
            this.bndNavCommon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bndNavCommon.Location = new System.Drawing.Point(0, 0);
            this.bndNavCommon.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndNavCommon.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndNavCommon.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndNavCommon.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndNavCommon.Name = "bndNavCommon";
            this.bndNavCommon.PositionItem = this.bindingNavigatorPositionItem;
            this.bndNavCommon.Size = new System.Drawing.Size(692, 25);
            this.bndNavCommon.TabIndex = 3;
            this.bndNavCommon.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // KmeansClustering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 453);
            this.Controls.Add(this.bndNavCommon);
            this.Controls.Add(this.panMain);
            this.Name = "KmeansClustering";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "k-Means Clustering";
            this.Load += new System.EventHandler(this.calculateKmeans_Load);
            this.Activated += new System.EventHandler(this.calculateKmeans_Activated);
            this.mainTabControl.ResumeLayout(false);
            this.datasetPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.initialGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudClusters)).EndInit();
            this.clusterPage.ResumeLayout(false);
            this.grpClusterGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clusterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClusterNo)).EndInit();
            this.viewPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGrid)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dentitionDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bndNavCommon)).EndInit();
            this.bndNavCommon.ResumeLayout(false);
            this.bndNavCommon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage datasetPage;
        private System.Windows.Forms.TabPage clusterPage;
        private System.Windows.Forms.NumericUpDown nudClusters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView initialGrid;
        private System.Windows.Forms.TextBox txtSquareError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClusterBack;
        private System.Windows.Forms.GroupBox grpClusterGrid;
        private System.Windows.Forms.NumericUpDown nudClusterNo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView clusterGrid;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnDatasetNext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClusterMean;
        private System.Windows.Forms.Button btnClusterNext;
        private System.Windows.Forms.TabPage viewPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView masterGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnViewBack;
        private DentitionDataSet dentitionDataSet;
        private FuzzyCMeansKMeans.DentitionDataSetTableAdapters.DentitionAdapter dentitionAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.BindingNavigator bndNavCommon;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}