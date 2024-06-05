using System;
using System.Globalization;
using System.Diagnostics;
using System.Threading; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FuzzyCMeansKMeans
{
    public partial class CMeansClustering : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable tblSeed;

        List<int> randArray;
        DataTable filteredTable;

        BackgroundWorker backgroundWorker;
        public Stopwatch stopWatch;

        int numClusters, maxIterations;

        public CMeansClustering()
        {
            InitializeComponent();
            conn = new OleDbConnection(Config.connString);

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);

            stopWatch = new Stopwatch();
        }

        private void ClusteringProcess_Load(object sender, EventArgs e)
        {
            ConnectDataset();
            Config.originalTable = tblSeed.Copy();
            librasGrid.DataSource = tblSeed;  
        }

        private void ConnectDataset()
        {
            string selCmd = "SELECT * FROM Dentition";

            conn.Open();
            adapter = new OleDbDataAdapter(selCmd, conn);
            tblSeed = new DataTable("Seed");
            adapter.Fill(tblSeed);
            conn.Close();
        }

        private void btnCluster_Click(object sender, EventArgs e)
        {
            numClusters = Convert.ToInt32(nudCluster.Value);
            Config.cCluster = numClusters;
            maxIterations = Convert.ToInt32(nudIteration.Value);
            Config.cMember = new List<int>();
            btnClose.Text = "Cancel";

            stopWatch.Reset();
            stopWatch.Start();

            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblStatus.Text = e.UserState as String;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                lblStatus.Text = "Canceled!";
            }
            else if (!(e.Error == null))
            {
                lblStatus.Text = ("Error: " + e.Error.Message);
            }

            //ShowClusterMembers();
            progressBar.Enabled = false;
            //this.btnCluster.Enabled = true;
            btnClose.Text = "Close";
            btnCluster.Enabled = false;

            ShowClusterMembers();
            spcBase.Panel2Collapsed = false;
            spcBase.Panel1Collapsed = true;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker.ReportProgress(0, "Working...");

            filteredTable = PrepareFuzzyTable(tblSeed);

            List<ClusterPoint> points = new List<ClusterPoint>();

            for (int row = 0; row < filteredTable.Rows.Count; row++)
            {
                double c2 = Convert.ToDouble(filteredTable.Rows[row]["Value"]);
                points.Add(new ClusterPoint(row, c2));
            }//for (int row = 0; row < tblSeed.Rows.Count; ++row)

            List<ClusterCentroid> centroids = new List<ClusterCentroid>();

            Random random = new Random();
            randArray = new List<int>();

            while (randArray.Count < numClusters)
            {
                int randomNumber1 = random.Next(filteredTable.Rows.Count);
                if (randArray.Contains(randomNumber1)) continue;
                randArray.Add(randomNumber1);
                centroids.Add(new ClusterCentroid(randomNumber1, Convert.ToDouble(filteredTable.Rows[randomNumber1]["Value"])));
            }

            FCM alg = new FCM(points, centroids, 2, filteredTable, numClusters);

            int k = 0;
            do
            {
                if ((backgroundWorker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    k++;
                    alg.J = alg.CalculateObjectiveFunction();
                    alg.CalculateClusterCentroids();
                    alg.Step();
                    double Jnew = alg.CalculateObjectiveFunction();

                    string strProgress = k.ToString() + "," + Math.Round(alg.J, 3).ToString() + ","
                        + Math.Round(Math.Abs(alg.J - Jnew), 3).ToString();

                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", stopWatch.Elapsed.Hours, stopWatch.Elapsed.Minutes, stopWatch.Elapsed.Seconds, stopWatch.Elapsed.Milliseconds / 10);
                    string strDuration = "Duration: " + elapsedTime;

                    ShowProgress(strProgress, strDuration);

                    backgroundWorker.ReportProgress((100 * k) / maxIterations, "Iteration " + k);

                    if (Math.Abs(alg.J - Jnew) < Config.accuracy) break;
                }
                Thread.Sleep(300);  
            }
            while (maxIterations > k);
            //Console.WriteLine("Done.");

            stopWatch.Stop();
            Config.cTime = Convert.ToInt32(stopWatch.ElapsedMilliseconds);
            //Config.cTime = Convert.ToInt32(stopWatch.ElapsedMilliseconds / 1000);
            //TimeSpan ts = stopWatch.Elapsed;

            double[,] Matrix = alg.U;
            Config.tableArray = new DataTable[centroids.Count];
            for (int i = 0; i < centroids.Count; i++)
            {
                Config.tableArray[i] = filteredTable.Clone();
                foreach (DataRow row in filteredTable.Rows)
                {
                    object[] values = row.ItemArray;
                    values[0] = Convert.ToInt32(row["ID"]);

                    for (int j = 1; j < values.Length; j++)
                        values[j] = 0;

                    Config.tableArray[i].Rows.Add(values);
                }//foreach (DataRow row in tblSeed.Rows)
            }//for (int i = 0; i < centroids.Count; i++)

            for (int j = 0; j < points.Count; j++)
            {
                for (int i = 0; i < centroids.Count; i++)
                {
                    ClusterPoint p = points[j];
                    if (Matrix[j, i] == p.ClusterIndex)
                    {
                        object[] values = Config.tableArray[i].Rows[(int)p.X].ItemArray;
                        //values[(int)p.Y] = p.OriginalValue;
                        values[1] = p.Value;
                        Config.tableArray[i].Rows[(int)p.X].ItemArray = values;
                    }
                }//for (int i = 0; i < centroids.Count; i++)
            }//for (int j = 0; j < points.Count; j++)

            // Resource cleanup...more work to do here to avoid memory problems!!!
            backgroundWorker.ReportProgress(100, "Done in " + k + " iterations.");
            ////alg.Dispose();
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = null;
            }
            for (int i = 0; i < centroids.Count; i++)
            {
                centroids[i] = null;
            }
            alg = null;
        }

        private DataTable PrepareFuzzyTable(DataTable sourceTable)
        {
            DataTable table = new DataTable("Fuzzy");
            table.Columns.Add("ID");
            table.Columns.Add("Value");

            for (int row = 0; row < sourceTable.Rows.Count; row++)
            {
                object[] values = new object[table.Columns.Count];
                values[0] = Convert.ToInt32(sourceTable.Rows[row][0]);

                double c2 = 0;
                for (int col = 1; col < sourceTable.Columns.Count - 1; col++)
                    c2 += Convert.ToDouble(sourceTable.Rows[row][col]);

                values[1] = c2;
                table.Rows.Add(values);
            }//for (int row = 0; row < tblSeed.Rows.Count; ++row)
            return table;
        }

        private delegate void ShowProgressDelegate(string strProgress, string strDuration);
        private void ShowProgress(string strProgress, string strDuration)
        {
            if (this.InvokeRequired)
            {
                object[] args = { strProgress, strDuration };
                this.Invoke(new ShowProgressDelegate(ShowProgress), args);
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (btnClose.Text == "Cancel")
            {
                if (backgroundWorker != null)
                    backgroundWorker.CancelAsync();

                lblStatus.Text = "Aborting, please wait...";

                btnClose.Text = "Close";
            }
            else if (btnClose.Text == "Close")
            {
                this.Close();
            }
        }

        private void ShowClusterMembers()
        {
            int index = 0;
            foreach (DataTable table in Config.tableArray)
            {
                index++;
                DataTable cluster = tblSeed.Clone();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    double val = Convert.ToDouble(table.Rows[i]["Value"]);
                    if (val == 0) continue;
                    object[] values = tblSeed.Rows[i].ItemArray;
                    cluster.Rows.Add(values);
                }//for (int i = 0; i < table.Rows.Count; i++)
                TabPage page = new TabPage("Cluster-" + index.ToString()
                    + " (" + cluster.Rows.Count.ToString() + " members)");
                Config.cMember.Add(cluster.Rows.Count);
                DataGridView dataGrid = CreateDataGrid();
                cluster.Columns.RemoveAt(0);
                dataGrid.DataSource = cluster;
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
    }//Class
}//NameSpace
