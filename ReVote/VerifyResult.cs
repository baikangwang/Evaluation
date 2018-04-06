using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace ReVote
{
    public class VerifyResult
    {
        public bool Pass { get; set; }

        public double[,] ActRankNoMatrix { get; set; }

        //public double[,] ExpectedMatrix { get; set; }

        public double[,] DiffMatrix { get; set; }

        public double[,] ExpAwards { get; set; }
        public double[,] ActAwards { get; set; }

        public double[,] OptRanks { get; set; }
        public double[,] OrgRanks { get; set; }
    }
}
