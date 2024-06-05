using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FuzzyCMeansKMeans
{
    public partial class MethodsComparison : Form
    {
        public MethodsComparison()
        {
            InitializeComponent();
        }

        private void MethodsComparison_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (Config.kMember == null || Config.cMember == null)
            {
                MessageBox.Show("One or more methods has not been clustered. Cannot compare clustering methods."
                    , Config.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListViewItem item = new ListViewItem("Run-Time");
            item.SubItems.Add(Convert.ToString(Config.kTime)+ " ms");
            kMeansList.Items.Add(item);

            item = new ListViewItem("Number of Clusters");
            item.SubItems.Add(Convert.ToString(Config.kCluster));
            kMeansList.Items.Add(item);

            for (int i = 0; i < Config.kMember.Count; i++)
            {
                item = new ListViewItem("Clusters - " + (i+1).ToString());
                item.SubItems.Add(Convert.ToString(Config.kMember[i]));
                kMeansList.Items.Add(item);
            }//for (int i = 0; i < Config.kMember.Count; i++)

            item = new ListViewItem("Run-Time");
            item.SubItems.Add(Convert.ToString(Config.cTime) + " ms");
            cMeansList.Items.Add(item);

            item = new ListViewItem("Number of Clusters");
            item.SubItems.Add(Convert.ToString(Config.cCluster));
            cMeansList.Items.Add(item);

            btnCompare.Enabled = false;

            for (int i = 0; i < Config.kMember.Count; i++)
            {
                item = new ListViewItem("Clusters - " + (i + 1).ToString());
                item.SubItems.Add(Convert.ToString(Config.cMember[i]));
                cMeansList.Items.Add(item);
            }//for (int i = 0; i < Config.kMember.Count; i++)

            if (Config.kTime == Config.cTime)
            {
                MessageBox.Show("Run-time of K-Means and Fuzzy C-Means clustering methods are equal for this comparison.", Config.AppTitle
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Config.kTime < Config.cTime)
            {
                MessageBox.Show("K-Means method is less run-time than Fuzzy C-Means method this comparison.", Config.AppTitle
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Config.kTime > Config.cTime)
            {
                MessageBox.Show("K-Means method is greater run-time than Fuzzy C-Means method this comparison.", Config.AppTitle
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }//Class
}//NameSpace
