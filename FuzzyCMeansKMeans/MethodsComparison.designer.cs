namespace FuzzyCMeansKMeans
{
    partial class MethodsComparison
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.spcBase = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kMeansList = new System.Windows.Forms.ListView();
            this.colParticular1 = new System.Windows.Forms.ColumnHeader();
            this.colValue1 = new System.Windows.Forms.ColumnHeader();
            this.cMeansList = new System.Windows.Forms.ListView();
            this.colParticular2 = new System.Windows.Forms.ColumnHeader();
            this.colValue2 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.spcBase.Panel1.SuspendLayout();
            this.spcBase.Panel2.SuspendLayout();
            this.spcBase.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCompare);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 50);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spcBase);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comparison of Clustering Methods";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(595, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Location = new System.Drawing.Point(514, 14);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // spcBase
            // 
            this.spcBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spcBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcBase.Location = new System.Drawing.Point(3, 16);
            this.spcBase.Name = "spcBase";
            // 
            // spcBase.Panel1
            // 
            this.spcBase.Panel1.Controls.Add(this.groupBox2);
            // 
            // spcBase.Panel2
            // 
            this.spcBase.Panel2.Controls.Add(this.groupBox3);
            this.spcBase.Size = new System.Drawing.Size(678, 393);
            this.spcBase.SplitterDistance = 337;
            this.spcBase.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kMeansList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 391);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "k-Means Clustering Method";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cMeansList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 391);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fuzzy c-Means Clustering Method";
            // 
            // kMeansList
            // 
            this.kMeansList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colParticular1,
            this.colValue1});
            this.kMeansList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kMeansList.GridLines = true;
            this.kMeansList.Location = new System.Drawing.Point(3, 16);
            this.kMeansList.Name = "kMeansList";
            this.kMeansList.Size = new System.Drawing.Size(329, 372);
            this.kMeansList.TabIndex = 0;
            this.kMeansList.UseCompatibleStateImageBehavior = false;
            this.kMeansList.View = System.Windows.Forms.View.Details;
            // 
            // colParticular1
            // 
            this.colParticular1.Text = "Particular";
            this.colParticular1.Width = 200;
            // 
            // colValue1
            // 
            this.colValue1.Text = "Value";
            this.colValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colValue1.Width = 100;
            // 
            // cMeansList
            // 
            this.cMeansList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colParticular2,
            this.colValue2});
            this.cMeansList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cMeansList.GridLines = true;
            this.cMeansList.Location = new System.Drawing.Point(3, 16);
            this.cMeansList.Name = "cMeansList";
            this.cMeansList.Size = new System.Drawing.Size(329, 372);
            this.cMeansList.TabIndex = 1;
            this.cMeansList.UseCompatibleStateImageBehavior = false;
            this.cMeansList.View = System.Windows.Forms.View.Details;
            // 
            // colParticular2
            // 
            this.colParticular2.Text = "Particular";
            this.colParticular2.Width = 200;
            // 
            // colValue2
            // 
            this.colValue2.Text = "Value";
            this.colValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colValue2.Width = 100;
            // 
            // MethodsComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MethodsComparison";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comparison of Clustering Methods";
            this.Load += new System.EventHandler(this.MethodsComparison_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.spcBase.Panel1.ResumeLayout(false);
            this.spcBase.Panel2.ResumeLayout(false);
            this.spcBase.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.SplitContainer spcBase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView kMeansList;
        private System.Windows.Forms.ColumnHeader colParticular1;
        private System.Windows.Forms.ColumnHeader colValue1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView cMeansList;
        private System.Windows.Forms.ColumnHeader colParticular2;
        private System.Windows.Forms.ColumnHeader colValue2;
    }
}