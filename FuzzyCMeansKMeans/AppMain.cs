using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FuzzyCMeansKMeans
{
    public partial class AppMain : Form
    {
        public AppMain()
        {
            InitializeComponent();
            this.Text = Config.AppTitle;
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeMenu_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalMenu_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalMenu_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void CloseAllMenu_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
                childForm.Close();
        }

        private bool isOpenning(string headerText)
        {
            foreach (Form child in MdiChildren)
            {
                if (child.Text == headerText)
                {
                    child.Activate();
                    return true;
                }//if (child.Text == headerText)
            }//foreach (Form child in MdiChildren)

            return false;
        }

        private void updateDatasetMenu_Click(object sender, EventArgs e)
        {
            UpdateDataset child = new UpdateDataset();
            if (isOpenning(child.Text)) return;
            child.MdiParent = this;
            child.WindowState = FormWindowState.Maximized;
            child.Show();
        }

        private void kMeansMenu_Click(object sender, EventArgs e)
        {
            KmeansClustering child = new KmeansClustering();
            if (isOpenning(child.Text)) return;
            child.MdiParent = this;
            child.WindowState = FormWindowState.Maximized;
            child.Show();
        }

        private void fuzzyCMeansMethodMenu_Click(object sender, EventArgs e)
        {
            CMeansClustering child = new CMeansClustering();
            if (isOpenning(child.Text)) return;
            child.MdiParent = this;
            child.WindowState = FormWindowState.Maximized;
            child.Show();
        }

        private void aboutMenu_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog(this);
        }

        private void comparisonMenu_Click(object sender, EventArgs e)
        {
            MethodsComparison child = new MethodsComparison();
            if (isOpenning(child.Text)) return;
            child.ShowDialog(this);
        }

        private void mammalsMenu_Click(object sender, EventArgs e)
        {
            ViewMammalImage child = new ViewMammalImage();
            if (isOpenning(child.Text)) return;
            child.MdiParent = this;
            child.WindowState = FormWindowState.Maximized;
            child.Show();
        }
    }//Class
}//NameSpace
