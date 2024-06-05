using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FuzzyCMeansKMeans
{
    public partial class UpdateDataset : Form
    {
        public UpdateDataset()
        {
            InitializeComponent();
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.dentitionSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dentitionDataSet);
            }
            catch (NoNullAllowedException ex1)
            {
                MessageBox.Show(ex1.Message, Config.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex2)
            {
                MessageBox.Show(ex2.Message, Config.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OleDbException ex3)
            {
                MessageBox.Show(ex3.Message, Config.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataset_Load(object sender, EventArgs e)
        {
            this.dentitionAdapter.Fill(this.dentitionDataSet.Dentition);
        }

        private void dentitionGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, Config.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
