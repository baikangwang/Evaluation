using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReVote
{
    public class OrgRank
    {
        public double[,] OrgRanks { get; private set; }

        public double[,] Awards { get; private set; }

        public List<Rank> SubRanks { get; private set; }

        public OrgRank() : this(new double[0, 0], new double[0, 0])
        {
            
        }

        public OrgRank(double[,] orgRanks,double[,] awards)
        {
            this.OrgRanks = orgRanks;
            this.Awards = awards;
            this.SubRanks=new List<Rank>();
        }

        public void AddSubRank(Rank rank)
        {
            this.SubRanks.Add(rank);
        }

        public void Update(double[,] orgRanks)
        {
            this.OrgRanks = orgRanks;
        }

        public void Verfied()
        {
            this.SubRanks.Clear();
        }
    }

    public class Rank
    {
        public double[,] Ranks { get; set; }

        public double[,] Awards { get; set; }

        public Rank(double[,] ranks, double[,] awards)
        {
            this.Ranks = ranks;
            this.Awards = awards;
        }
    }
}
