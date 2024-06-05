using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FuzzyCMeansKMeans
{
    public partial class ViewMammalImage : Form
    {
        public ViewMammalImage()
        {
            InitializeComponent();
        }

        private void LibrasImage_Load(object sender, EventArgs e)
        {
            this.dentitionAdapter.Fill(this.dentitionDataSet.Dentition);
            PopulateMammalList();
        }

        private void PopulateMammalList()
        {
            foreach (DataRow row in this.dentitionDataSet.Dentition.Rows)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(row["Mammal"]));
                mammalList.Items.Add(item);
            }//foreach (DataRow row in this.dentitionDataSet.Dentition.Rows)
        }

        private void mammalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mammalList.SelectedItems.Count <= 0) return;
            string mammal = mammalList.SelectedItems[0].Text;
            if (mammal.Length <= 0) return;
            string filePath = Application.StartupPath + "\\Mammals\\" + mammal + ".jpg";
            picImage.Image = new Bitmap(filePath);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }//Class
}//NameSpace
