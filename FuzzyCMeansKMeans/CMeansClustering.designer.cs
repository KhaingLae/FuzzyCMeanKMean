namespace FuzzyCMeansKMeans
{
    partial class CMeansClustering
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCluster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.librasGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudIteration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudCluster = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.spcBase = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librasGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCluster)).BeginInit();
            this.spcBase.Panel1.SuspendLayout();
            this.spcBase.Panel2.SuspendLayout();
            this.spcBase.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 50);
            this.panel1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(218, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(68, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Iterations :";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 19);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(200, 16);
            this.progressBar.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(605, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCluster
            // 
            this.btnCluster.Location = new System.Drawing.Point(265, 28);
            this.btnCluster.Name = "btnCluster";
            this.btnCluster.Size = new System.Drawing.Size(158, 23);
            this.btnCluster.TabIndex = 2;
            this.btnCluster.Text = "Fuzzy C-means Clustering";
            this.btnCluster.UseVisualStyleBackColor = true;
            this.btnCluster.Click += new System.EventHandler(this.btnCluster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.librasGrid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 351);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dataset";
            // 
            // librasGrid
            // 
            this.librasGrid.AllowUserToAddRows = false;
            this.librasGrid.AllowUserToDeleteRows = false;
            this.librasGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.librasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.librasGrid.Location = new System.Drawing.Point(3, 16);
            this.librasGrid.Name = "librasGrid";
            this.librasGrid.ReadOnly = true;
            this.librasGrid.Size = new System.Drawing.Size(684, 332);
            this.librasGrid.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 65);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudIteration);
            this.groupBox2.Controls.Add(this.btnCluster);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudCluster);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 65);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clustering Option";
            // 
            // nudIteration
            // 
            this.nudIteration.Location = new System.Drawing.Point(197, 31);
            this.nudIteration.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudIteration.Name = "nudIteration";
            this.nudIteration.Size = new System.Drawing.Size(51, 20);
            this.nudIteration.TabIndex = 1;
            this.nudIteration.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Iterations:";
            // 
            // nudCluster
            // 
            this.nudCluster.Location = new System.Drawing.Point(76, 31);
            this.nudCluster.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCluster.Name = "nudCluster";
            this.nudCluster.Size = new System.Drawing.Size(51, 20);
            this.nudCluster.TabIndex = 0;
            this.nudCluster.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clusters:";
            // 
            // spcBase
            // 
            this.spcBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcBase.Location = new System.Drawing.Point(0, 0);
            this.spcBase.Name = "spcBase";
            // 
            // spcBase.Panel1
            // 
            this.spcBase.Panel1.Controls.Add(this.groupBox1);
            this.spcBase.Panel1.Controls.Add(this.panel2);
            // 
            // spcBase.Panel2
            // 
            this.spcBase.Panel2.Controls.Add(this.groupBox3);
            this.spcBase.Panel2Collapsed = true;
            this.spcBase.Size = new System.Drawing.Size(692, 418);
            this.spcBase.SplitterDistance = 458;
            this.spcBase.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(94, 98);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clustering by Fuzzy c-Means Method";
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 16);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(88, 79);
            this.tabControl.TabIndex = 0;
            // 
            // CMeansClustering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 468);
            this.Controls.Add(this.spcBase);
            this.Controls.Add(this.panel1);
            this.Name = "CMeansClustering";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clustering Process";
            this.Load += new System.EventHandler(this.ClusteringProcess_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.librasGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCluster)).EndInit();
            this.spcBase.Panel1.ResumeLayout(false);
            this.spcBase.Panel2.ResumeLayout(false);
            this.spcBase.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView librasGrid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCluster;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudIteration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudCluster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer spcBase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl;
    }
}