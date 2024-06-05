using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FuzzyCMeansKMeans
{
    public partial class KmeansClustering : Form
    {
        private double startTime;
        private double eventsTime;
        //private LogList log;
        private AppMain main;

        private int noChanges;
        private DataTable initialTable;
        private DataTable masterTable;
        private BindingSource initialBindingSource;
        private BindingSource clusterBindingSource;
        private BindingSource masterBindingSource;
        private int maxClusters;
        private int noOfClusters;
        private int clusterIndex = 0;
        private double sqrError = 0;
        private List<DataTable> tableList=new List<DataTable>();
        private double[] clusterMeans;
        private Color[] color ={Color.LightYellow,Color.Honeydew,Color.PowderBlue,Color.SeaShell,
            Color.GhostWhite,Color.Cornsilk,Color.PaleGreen,Color.LightSkyBlue,Color.PaleTurquoise,
            Color.LavenderBlush,Color.LightCyan,Color.AliceBlue};

        private DataTable[] tableArray;

        public KmeansClustering()
        {
            InitializeComponent();
        }

        private void setDataSource()
        {
            initialBindingSource = new BindingSource();
            initialBindingSource.DataSource = initialTable;
            initialGrid.DataSource = initialTable;
            initialGrid.Columns[0].Visible = false;

            bndNavCommon.BindingSource = initialBindingSource;
            maxClusters = initialTable.Rows.Count / 2;
            nudClusters.Maximum = maxClusters; 
        }

        private void calculateKmeans_Load(object sender, EventArgs e)
        {
            this.dentitionAdapter.Fill(this.dentitionDataSet.Dentition);
            masterTable = this.dentitionDataSet.Dentition.Copy();
            initialTable = this.dentitionDataSet.Dentition.Copy();

            main = (AppMain)this.MdiParent;  
            setDataSource(); 
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            noOfClusters = (int)nudClusters.Value;
            nudClusters.Enabled = false;
            btnSet.Enabled = false;
            btnReset.Enabled = true;
            btnDatasetNext.Enabled = true;

            Config.kCluster = noOfClusters;
            Config.kMember = new List<int>();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
            btnDatasetNext.Enabled = false; 
            btnSet.Enabled = true;
            nudClusters.Enabled = true;

            Config.kCluster = 0;
            Config.kMember = new List<int>();
        }

        private void btnDatasetNext_Click(object sender, EventArgs e)
        {
            splitInitialTable(noOfClusters);
            initClusterMeans();
            sqrError = calcSqrError(); 
            nudClusterNo.Maximum = noOfClusters;
            mainTabControl.SelectedIndex = 1;
            btnAnalyze.Enabled = true;
            btnClusterNext.Enabled = false;
        }

        private void addNewTabletoList(int index)
        {
            tableList.Add(new DataTable("Cluster " + index.ToString()));   
            foreach (DataColumn col in initialTable.Columns)
                tableList[index].Columns.Add(col.ColumnName);   
        }

        private void splitInitialTable(int spcount)
        {
            int totalRows=initialTable.Rows.Count;
            int splitRows = totalRows/ spcount; 
            int count = 0;
            int tblIndex=0;
            
            tableList = new List<DataTable>();

            addNewTabletoList(tblIndex); 
            foreach (DataRow row in initialTable.Rows)
            {
                count++;
                tableList[tblIndex].Rows.Add((object[])row.ItemArray.Clone());
                
                if (((totalRows - count) >= splitRows) && (count % splitRows == 0))
                {
                    tblIndex++;
                    addNewTabletoList(tblIndex);
                }

            }//foreach (DataRow row in initialTable.Rows)
        }

        private void initClusterMeans()
        {
            clusterMeans = new double[tableList.Count];
            for (int i = 0; i < tableList.Count; i++)
                clusterMeans[i] = calcClusterMeans(i);
        }

        private double calcClusterMeans(int index)
        {
            int colCount = tableList[index].Columns.Count - 2;
            double sum = 0;
            double avg = 0;
            //i = 1 to leave primary key cloumn
            for (int i = 1; i < tableList[index].Columns.Count - 1; i++)
            {
                sum = 0;
                foreach (DataRow row in tableList[index].Rows)
                    sum += Convert.ToDouble(row.ItemArray[i]);

                avg += (sum / tableList[index].Rows.Count);
            }//for (int i = 1; i < tableList[index].Columns.Count - 1; i++)

            avg = avg / colCount;
            return Math.Round(avg,4);
        }

        private double calcObjectMeans(int tblIndex, int rowIndex)
        {
            int colCount = tableList[tblIndex].Columns.Count - 2;    
            double avg=0;

            //i=1 to leave primary key column
            for (int i = 1; i < tableList[tblIndex].Columns.Count - 1; i++)
                avg += Convert.ToDouble(tableList[tblIndex].Rows[rowIndex].ItemArray[i]);

            avg = avg / colCount;
            return avg;
        }

        private double calcSqrError()
        {
            int cCount = tableList.Count;
            double sqrErr = 0;
            double p = 0;
            for (int i = 0; i < cCount; i++)
            {
                for (int j = 0; j < tableList[i].Rows.Count; j++)
                {
                    p = calcObjectMeans(i, j);
                    sqrErr += Math.Pow(p - clusterMeans[i], 2);
                }//foreach (DataRow row in tableList[i].Rows)
            }//for (int i = 0; i < cCount; i++)
            sqrErr /= initialTable.Rows.Count;
            return Math.Round(sqrErr, 4); 
        }

        private void showClusterTable(int index)
        {
            clusterBindingSource = new BindingSource();
            clusterBindingSource.DataSource = tableList[clusterIndex];
            clusterGrid.DataSource = tableList[clusterIndex];
            clusterGrid.Columns[0].Visible = false;

            bndNavCommon.BindingSource = clusterBindingSource;
            txtClusterMean.Text = clusterMeans[index].ToString();
            grpClusterGrid.Text = "Cluster " + Convert.ToString(index + 1) + " :";    
        }

        private void clusterPage_Enter(object sender, EventArgs e)
        {
            showClusterTable(clusterIndex);
            txtSquareError.Text = sqrError.ToString();  
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //clusterIndex = (int)nudClusterNo.Value-1;
            //showClusterTable(clusterIndex);
        }

        private void nudClusterNo_ValueChanged(object sender, EventArgs e)
        {
            clusterIndex = (int)nudClusterNo.Value - 1;
            showClusterTable(clusterIndex);
        }

        private void btnClusterBack_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 0;
            bndNavCommon.BindingSource = initialBindingSource;  
        }

        private void kmeansProcess()
        {
            double objMeans=0;
            bool changed=true;
            int rowsCount = 0;
            int nearest = 0;
            int[] tmp = new int[2];

            noChanges = 0;

            while (changed)
            {
                changed = false;
                for (int i = 0; i < tableList.Count; i++)
                {
                    rowsCount =tableList[i].Rows.Count;
                    for (int j = 0; j < rowsCount; j++)
                    {
                        objMeans = calcObjectMeans(i, j);
                        nearest = findNearestCluster(objMeans,i); ;
                        if (nearest != i)
                        {
                            tableList[nearest].Rows.Add((object[])
                                tableList[i].Rows[j].ItemArray.Clone());
                            tableList[i].Rows.RemoveAt(j);
                            j--;
                            rowsCount--;
                            changed = true;
                        }//if (nearest != i)
                    }//for (int j = 0; j < tableList[i].Rows.Count; j++)
                }//for (int i = 0; i < tableList.Count; i++)

                if (changed)
                {
                    noChanges++;
                    //Recalculat each cluster means
                    for (int i = 0; i < tableList.Count; i++)
                        clusterMeans[i] = calcClusterMeans(i);

                    //Set changes to log
                    eventsTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
                    //log.distinct.atExecTime.Add((eventsTime - startTime)/1000);
                    //log.distinct.sqrError.Add(calcSqrError());  
                }//if (changed)
            }// while (changed)

        }

        private int findNearestCluster(double objMeans,int srcIndex)
        {
            double diff =Math.Abs(objMeans - clusterMeans[srcIndex]);
            int nearest = srcIndex;
            for (int i = 0; i < clusterMeans.Length; i++)
            {
                if (i != srcIndex)
                {
                    double tmp = Math.Abs(objMeans - clusterMeans[i]);
                    if (tmp < diff)
                    {
                        diff = tmp;
                        nearest = i;
                    }
                }//if (i != srcIndex)
            }//for (int i = 0; i < clusterMeans.Length; i++)
            return nearest;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
            int index = (int)nudClusterNo.Value;

            Config.kMember = new List<int>();
            tableArray = new DataTable[noOfClusters];

            kmeansProcess();

            for (int i = 0; i < tableArray.Length; i++)
                tableArray[i] = tableList[i].Copy();
            
            txtClusterMean.Text = clusterMeans[index-1].ToString();    
            sqrError = calcSqrError();
            txtSquareError.Text = sqrError.ToString();   
            btnAnalyze.Enabled = false;
            btnClusterNext.Enabled = true;

            ViewClusters();

            //Config.kTime = Convert.ToInt32((eventsTime - startTime) / 1000);
            Config.kTime = Convert.ToInt32(eventsTime - startTime);
        }

        private void btnClusterNext_Click(object sender, EventArgs e)
        {
            ViewClusters();
        }

        private void ViewClusters()
        {
            mainTabControl.SelectedIndex = 2;
            masterBindingSource = new BindingSource();
            masterBindingSource.DataSource = masterTable;
            bndNavCommon.BindingSource = masterBindingSource;
            masterGrid.DataSource = masterTable;
            masterGrid.Columns[0].Visible = false;

            showClusterColor();

            ShowClusterMembers();
        }

        private void showClusterColor()
        {
            int index = 0;
            foreach (DataGridViewRow row in masterGrid.Rows)
            {
                index=findInWhichClusterTable(row.Cells[0].Value.ToString());
                if ((index >= 0) && (index < color.Length))
                {
                    row.DefaultCellStyle.BackColor = color[index];  
                }//if ((index < 0) && (index >= color.Length))
            }//foreach (DataGridViewRow row in masterDataGridView.Rows)
        }

        private int findInWhichClusterTable(string itemVal)
        {
            for (int i =0; i < tableList.Count;i++)
            {
                foreach (DataRow row in tableList[i].Rows)
                {
                    if (itemVal == row.ItemArray[0].ToString())
                        return i;
                }//foreach (DataRow row in tableList[i].Rows)
            }// for (int i =0; i < tableList.Count;i++)
            return -1;
        }

        private void btnViewBack_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 1;
            bndNavCommon.BindingSource = clusterBindingSource;  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void calculateKmeans_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
        }

        private void ShowClusterMembers()
        {
            int index = 0;
            foreach (DataTable table in tableArray)
            {
                index++;
                TabPage page = new TabPage("Cluster-" + index.ToString()
                    + " (" + table.Rows.Count.ToString() + " members)");

                Config.kMember.Add(table.Rows.Count);

                DataGridView dataGrid = CreateDataGrid();
                table.Columns.RemoveAt(0);
                dataGrid.DataSource = table;
                page.Controls.Add(dataGrid);
                tabControl.TabPages.Add(page);
            }//foreach (DataTable table in tableArray)
        }

        private DataGridView CreateDataGrid()
        {
            DataGridView dataGrid = new DataGridView();
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ReadOnly = true;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.BackgroundColor = SystemColors.Window;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            return dataGrid;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                masterBindingSource = new BindingSource();
                masterBindingSource.DataSource = masterTable;
                bndNavCommon.BindingSource = masterBindingSource;
            }
            else
            {
                masterBindingSource = new BindingSource();
                masterBindingSource.DataSource = tableArray[tabControl.SelectedIndex - 1];
                bndNavCommon.BindingSource = masterBindingSource;
            }
        }
    }//class
}//namespace