namespace FuzzyCMeansKMeans
{
    partial class ViewMammalImage
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
            this.btnClose = new System.Windows.Forms.Button();
            this.spcBase = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mammalList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.dentitionDataSet = new FuzzyCMeansKMeans.DentitionDataSet();
            this.dentitionAdapter = new FuzzyCMeansKMeans.DentitionDataSetTableAdapters.DentitionAdapter();
            this.panel1.SuspendLayout();
            this.spcBase.Panel1.SuspendLayout();
            this.spcBase.Panel2.SuspendLayout();
            this.spcBase.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentitionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(605, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // spcBase
            // 
            this.spcBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcBase.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcBase.Location = new System.Drawing.Point(0, 0);
            this.spcBase.Name = "spcBase";
            // 
            // spcBase.Panel1
            // 
            this.spcBase.Panel1.Controls.Add(this.groupBox1);
            // 
            // spcBase.Panel2
            // 
            this.spcBase.Panel2.Controls.Add(this.groupBox2);
            this.spcBase.Size = new System.Drawing.Size(692, 418);
            this.spcBase.SplitterDistance = 194;
            this.spcBase.TabIndex = 1;
            this.spcBase.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mammalList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Mammal";
            // 
            // mammalList
            // 
            this.mammalList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.mammalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mammalList.FullRowSelect = true;
            this.mammalList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.mammalList.HideSelection = false;
            this.mammalList.Location = new System.Drawing.Point(3, 16);
            this.mammalList.MultiSelect = false;
            this.mammalList.Name = "mammalList";
            this.mammalList.Size = new System.Drawing.Size(186, 397);
            this.mammalList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.mammalList.TabIndex = 0;
            this.mammalList.UseCompatibleStateImageBehavior = false;
            this.mammalList.View = System.Windows.Forms.View.Details;
            this.mammalList.SelectedIndexChanged += new System.EventHandler(this.mammalList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 416);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mammals Image";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.picImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 397);
            this.panel2.TabIndex = 0;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(3, 3);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(130, 116);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // dentitionDataSet
            // 
            this.dentitionDataSet.DataSetName = "DentitionDataSet";
            this.dentitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dentitionAdapter
            // 
            this.dentitionAdapter.ClearBeforeFill = true;
            // 
            // ViewMammalImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 468);
            this.Controls.Add(this.spcBase);
            this.Controls.Add(this.panel1);
            this.Name = "ViewMammalImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mammals Image";
            this.Load += new System.EventHandler(this.LibrasImage_Load);
            this.panel1.ResumeLayout(false);
            this.spcBase.Panel1.ResumeLayout(false);
            this.spcBase.Panel2.ResumeLayout(false);
            this.spcBase.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dentitionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer spcBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ListView mammalList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private DentitionDataSet dentitionDataSet;
        private FuzzyCMeansKMeans.DentitionDataSetTableAdapters.DentitionAdapter dentitionAdapter;
    }
}