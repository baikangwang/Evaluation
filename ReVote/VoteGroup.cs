using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace ReVote
{
    public class VoteGroup
    {
        public virtual int[] Projects { get; private set; }

        public virtual double[,] Awards { get; private set; }

        public virtual double[,] Votes { get; private set; }

        public VoteGroup(double[,] initRanks, double[] votingRow,double[]votingAwards, int targetRank)
        {
            if (votingRow.Length > votingAwards.Length)
            {
                List<double> optVotingAwarding = new List<double>(votingAwards);
                double last = optVotingAwarding.LastOrDefault();
                for (int i = 0; i < votingRow.Length - votingAwards.Length; i++)
                {
                    optVotingAwarding.Add(last + i + 1);
                }

                votingAwards = optVotingAwarding.ToArray();
            }

            Matrix<double> awards = CreateMatrix.DenseOfRowArrays(new double[][] {votingAwards, votingRow});

            int length = awards.ColumnCount;
            for (int i = length - 1; i >= 0; i--)
            {
                if ((int) awards[1, i] == 0)
                    awards = awards.RemoveColumn(i);
            }

            this.Awards = awards.Transpose().ToArray();

            List<int> projects=new List<int>();

            for (int i = 0; i < initRanks.GetUpperBound(0)+1; i++)
            {
                if((int)initRanks[i,1]==targetRank)
                    projects.Add((int)initRanks[i,0]);
            }
            this.Projects = projects.ToArray();
        }

        public VoteGroup(int[] projects, double[,] awards)
        {
            this.Awards = awards;
            this.Projects = projects;
        }

        public void CollectVotes(double[,] votes)
        {
            this.Votes = votes;
        }
    }
}
