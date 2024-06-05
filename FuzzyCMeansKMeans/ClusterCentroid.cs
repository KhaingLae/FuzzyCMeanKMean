using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FuzzyCMeansKMeans
{
    public class ClusterCentroid //: ClusterPoint
    {
        public double Row { get; set; }
        public double ValueCount { get; set; }
        public double ValSum { get; set; }
        public double MembershipSum { get; set; }
        public double Value { get; set; }
        public double OriginalValue { get; set; }

        public ClusterCentroid(double row, double val)
        {
            this.Row = row;
            this.ValSum = 0;
            this.ValueCount = 0;
            this.MembershipSum = 0;
            this.Value = val;
            this.OriginalValue = val;
        }
    }//Class
}//NameSpace
