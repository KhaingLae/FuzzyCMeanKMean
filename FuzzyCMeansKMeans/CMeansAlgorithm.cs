using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FuzzyCMeansKMeans
{
    public class FCM
    {

        private List<ClusterPoint> Points;
        private List<ClusterCentroid> Clusters;
        public double[,] U;

        public DataTable myTable;
        private bool isConverged = false;
        private DataTable processedTable;
        public DataTable getProcessedTable { get { return processedTable; } }
        public bool Converged { get { return isConverged; } }

        private double Fuzzyness;
        private double Eps = Math.Pow(10, -5);
        public double J { get; set; }
        //public int myValueWidth;
        //public int myValueHeight;


        public FCM(List<ClusterPoint> points, List<ClusterCentroid> clusters, float fuzzy, DataTable myTable, int numCluster)
        {
            if (points == null)
            {
                throw new ArgumentNullException("points");
            }

            if (clusters == null)
            {
                throw new ArgumentNullException("clusters");
            }

            processedTable = myTable.Copy(); 

            this.Points = points;
            this.Clusters = clusters;
            //this.myValueHeight = myTable.Rows.Count;
            //this.myValueWidth = myTable.Columns.Count;  
            this.myTable = myTable.Copy();
            U = new double[this.Points.Count, this.Clusters.Count];
            this.Fuzzyness = fuzzy;

            double diff;

            // Iterate through all points to create initial U matrix
            for (int i = 0; i < this.Points.Count; i++)
            {
                ClusterPoint p = this.Points[i];
                double sum = 0.0;

                for (int j = 0; j < this.Clusters.Count; j++)
                {
                    ClusterCentroid c = this.Clusters[j];
                    diff = Math.Sqrt(Math.Pow(CalculateEuclideanDistance(p, c), 2.0));
                    U[i, j] = (diff == 0) ? Eps : diff;
                    sum += U[i, j];
                }//for (int j = 0; j < this.Clusters.Count; j++)
            }//for (int i = 0; i < this.Points.Count; i++)

            this.RecalculateClusterMembershipValues();
        }

        private void RecalculateClusterMembershipValues()
        {
            for (int i = 0; i < this.Points.Count; i++)
            {
                double max = 0.0;
                double min = 0.0;
                double sum = 0.0;
                double newmax = 0;
                var p = this.Points[i];
                //Normalize the entries
                for (int j = 0; j < this.Clusters.Count; j++)
                {
                    max = U[i, j] > max ? U[i, j] : max;
                    min = U[i, j] < min ? U[i, j] : min;
                }
                //Sets the values to the normalized values between 0 and 1
                for (int j = 0; j < this.Clusters.Count; j++)
                {
                    U[i, j] = (U[i, j] - min) / (max - min);
                    sum += U[i, j];
                }
                //Makes it so that the sum of all values is 1 
                for (int j = 0; j < this.Clusters.Count; j++)
                {
                    U[i, j] = U[i, j] / sum;
                    if (double.IsNaN(U[i, j]))
                    {
                        ///Console.WriteLine("NAN value: point({0}) cluster({1}) sum {2} newmax {3}", i, j, sum, newmax);
                        U[i, j] = 0.0;
                    }
                    //Console.WriteLine("ClusterIndex: point({0}) cluster({1}) min {2} max {3} value {4} p.ClusterIndex {5}", i, j, min, max, U[i, j], p.ClusterIndex);
                    newmax = U[i, j] > newmax ? U[i, j] : newmax;
                }
                // ClusterIndex is used to store the strongest membership value to a cluster, used for defuzzification
                p.ClusterIndex = newmax;
            }//for (int i = 0; i < this.Points.Count; i++)
        }

        public void Step()
        {
            for (int c = 0; c < Clusters.Count; c++)
            {
                for (int h = 0; h < Points.Count; h++)
                {
                    double top;
                    top = CalculateEuclideanDistance(Points[h], Clusters[c]);
                    if (top < 1.0) top = Eps;

                    // sumTerms is the sum of distances from this data point to all clusters.
                    double sumTerms = 0.0;

                    for (int ck = 0; ck < Clusters.Count; ck++)
                    {
                        sumTerms += top / CalculateEuclideanDistance(Points[h], Clusters[ck]);

                    }
                    // Then the membership value can be calculated as...
                    U[h, c] = (double)(1.0 / Math.Pow(sumTerms, (2 / (this.Fuzzyness - 1))));
                }//for (int h = 0; h < Points.Count; h++)
            }//for (int c = 0; c < Clusters.Count; c++)
            this.RecalculateClusterMembershipValues();
        }

        private double CalculateEuclideanDistance(ClusterPoint p, ClusterCentroid c)
        {
            return Math.Sqrt(Math.Pow(p.Value - c.Value, 2.0));
        }

        public double CalculateObjectiveFunction()
        {
            double Jk = 0.0;

            for (int i = 0; i < this.Points.Count; i++)
            {
                for (int j = 0; j < this.Clusters.Count; j++)
                {
                    Jk += Math.Pow(U[i, j], this.Fuzzyness) * Math.Pow(this.CalculateEuclideanDistance(Points[i], Clusters[j]), 2);
                }//for (int j = 0; j < this.Clusters.Count; j++)
            }//for (int i = 0; i < this.Points.Count; i++)
            return Jk;
        }

        public void CalculateClusterCentroids()
        {
            //Console.WriteLine("Cluster Centroid calculation:");
            for (int j = 0; j < this.Clusters.Count; j++)
            {
                ClusterCentroid c = this.Clusters[j];
                double l = 0.0;
                c.ValueCount = 1;
                c.ValSum = 0;
                c.MembershipSum = 0;

                for (int i = 0; i < this.Points.Count; i++)
                {

                    ClusterPoint p = this.Points[i];
                    l = Math.Pow(U[i, j], this.Fuzzyness);
                    c.ValSum += l * p.Value;
                    c.MembershipSum += l;

                    if (U[i, j] == p.ClusterIndex)
                    {
                        c.ValueCount += 1;
                    }
                }//for (int i = 0; i < this.Points.Count; i++)
                c.Value = c.ValSum / c.MembershipSum;
            }//for (int j = 0; j < this.Clusters.Count; j++)

            DataTable tempTable = myTable.Clone();
            foreach (DataRow row in myTable.Rows)
            {
                object[] values = row.ItemArray;
                values[0] = Convert.ToInt32(row["ID"]);  
                
                for (int i = 1; i < values.Length; i++)
                    values[i] = 0;
                
                tempTable.Rows.Add(values);
            }//foreach (DataRow row in tblLibra.Rows)

            for (int j = 0; j < this.Points.Count; j++)
            {
                for (int i = 0; i < this.Clusters.Count; i++)
                {
                    ClusterPoint p = this.Points[j];
                    if (U[j, i] == p.ClusterIndex)
                    {
                        object[] values = tempTable.Rows[(int)p.X].ItemArray;
                        values[1] = this.Clusters[i].Value;
                        tempTable.Rows[(int)p.X].ItemArray = values;
                    }
                }//for (int i = 0; i < this.Clusters.Count; i++)
            }//for (int j = 0; j < this.Points.Count; j++)

            processedTable = tempTable.Copy();
        }

        /// <summary>
        /// Perform a complete run of the algorithm until the desired accuracy is achieved.
        /// For demonstration issues, the maximum Iteration counter is set to 20.
        /// </summary>
        /// <param name="accuracy">Algorithm accuracy</param>
        /// <returns>The number of steps the algorithm needed to complete</returns>

    }//Class
}//NameSpace
