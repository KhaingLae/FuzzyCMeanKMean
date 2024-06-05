using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FuzzyCMeansKMeans
{
    public class ClusterPoint
    {
        public double X { get; set; }

        public double Value { get; set; }

        public double OriginalValue { get; set; }

        public double ClusterIndex { get; set; }

        public ClusterPoint(double row, double val)
        {
            this.X = row;
            this.Value = val;
            this.OriginalValue = val;
            this.ClusterIndex = -1;
        }

        public ClusterPoint(double row, double z, object tag)
        {
            this.X = row;
            this.Value = z;
            this.ClusterIndex = -1;
        }
    }//Class
}//NameSpace
