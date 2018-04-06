using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex;

namespace ReVote
{
    public class VoteRecorder
    {
        /// <summary>
        /// Rank the votes
        /// </summary>
        /// <param name="votes">
        /// each row presents a project grains the number of votes per award
        /// int[P,A]
        /// P: Projects, A: the awards
        /// </param>
        /// <param name="awards">
        /// each column presents a award's weight and number
        /// int[A,N]
        /// A: awards, N: the number per award
        /// </param>
        public OrgRank InitRank(int[] projects, double[,] votes, double[,] awards,bool isRevoted=false)
        {
            // matV(P,A) = actual votes to matrix PxW
            Matrix<double> matV = CreateMatrix.DenseOfArray(votes);

            // matA(W,N) = the awards's name and number
            Matrix<double> matA = CreateMatrix.DenseOfArray(awards);

            double[] scores = null;
            if (!isRevoted)
            {
                // vecA(W,1) = vector Ax1
                // pick the award's weight into a single array
                double[] weights = matA.Column(0).ToArray();
                weights = weights.Select(a => (double) Math.Pow(10, weights.Length - a)).ToArray();

                Vector<double> vecA = CreateVector.DenseOfArray(weights);

                // S(P,1)=matV(P,A) X vecW(A,1)
                Vector<double> vecS = matV.Multiply(vecA.Conjugate());
                scores = vecS.ToArray();
            }
            else
            {
                scores = matV.Column(0).ToArray();
            }

            // Sort and Rank
            // Sort by the scores
            Array.Sort(scores, projects, Comparer<double>.Create((a, b) =>
            {
                if (a > b) return -1;
                else if (a < b) return 1;
                return 0;
            }));

            // [1,2]
            // [2,2]   => [1,1,2,2,3,3]
            // [3,2]
            double[] awardNos = To1DAwards(awards);
            // double[] awardItems = matA.Column(0).ToArray();

            // column(0): projectId
            // column(1): actual rank
            // column(2): expected rank
            // column(3): score
            Matrix<double> matRanks = CreateMatrix.DenseOfColumnArrays(new double[][]
                {
                    projects.Select(p=>(double)p).ToArray(),
                    new double[projects.Length],
                    new double[projects.Length],
                    scores
                });


            //int rank_length = 0;
            int current = 0;
            while (true)
            {
                if (current >= projects.Length)
                    break;

                if (current == 0)
                {
                    matRanks[current, 1] = awardNos[current];
                    matRanks[current, 2] = awardNos[current];
                }
                else if ((int)scores[current] == (int)scores[current - 1])
                {
                    matRanks[current, 1] = matRanks[current - 1, 1];
                    if (current < awardNos.Length)
                        matRanks[current, 2] = awardNos[current];
                }
                else if ((int) scores[current] < (int) scores[current - 1])
                {
                    //if (current >= awardNos.Length)
                    //    break;
                    if (current < awardNos.Length)
                        matRanks[current, 1] = awardNos[current];
                    if (current < awardNos.Length)
                        matRanks[current, 2] = awardNos[current];


                }
                else // (int) scores[current_score] > (int) scores[current_score - 1]
                {
                    // won't be here
                    // do nothing
                }

                current++;
                //rank_length++;
            }

            OrgRank orgRank = new OrgRank(matRanks.SubMatrix(0,matRanks.RowCount,0,2).ToArray(), awards);
            Stack<Rank> stack_Ranks = new Stack<Rank>();

            int rank_length = matRanks.RowCount;

            for (int i = matRanks.RowCount - 1; i >= 0; i--)
            {
                if (i < matRanks.RowCount - 1)
                {
                    // compare scores
                    int cur = (int)matRanks[i, 3];
                    int last = (int)matRanks[i + 1, 3];
                    if (matRanks[i+1, 1] > 0 && cur != last)
                    // 0 rank means the project won't be involved into VoteVerify
                    {
                        int start_row = i + 1;
                        int length = rank_length - (i + 1);
                        // pick the [project,rank]
                        double[,] ranks = matRanks.SubMatrix(start_row, length, 0, 2).ToArray();
                        // pick the [award]
                        double[] sub_awardNos = matRanks.Column(2).SubVector(start_row, length).ToArray().Where(a=>a>0).ToArray();
                        double[,] sub_awards = this.To2DAwards(sub_awardNos);
                        stack_Ranks.Push(new Rank(ranks, sub_awards));
                        // drop the part being picked above
                        matRanks = matRanks.SubMatrix(0, start_row, 0, matRanks.ColumnCount);
                        rank_length = matRanks.RowCount;
                    }
                }

                if (i < matRanks.RowCount - 1 && (int)matRanks[i + 1, 1] <= 0)
                {
                    // 0 rank means the project won't be involved into VoteVerify
                    rank_length--;
                }

                // pick the last part
                if (i == 0)
                {
                    int start_row = 0;
                    int length = rank_length;
                    // pick the [project,rank]
                    double[,] ranks = matRanks.SubMatrix(start_row, length, 0, 2).ToArray();
                    // pick the [award]
                    double[] sub_awardNos = matRanks.Column(2).SubVector(start_row, length).ToArray().Where(a => a > 0).ToArray();
                    double[,] sub_awards = this.To2DAwards(sub_awardNos);
                    stack_Ranks.Push(new Rank(ranks, sub_awards));
                }
            }

            while (stack_Ranks.Count > 0)
            {
                orgRank.AddSubRank(stack_Ranks.Pop());
            }

            return orgRank;
        }

        /// <summary>
        /// Rank the votes
        /// </summary>
        /// <param name="votes">
        /// each row presents a project grains the number of votes per award
        /// int[P,A]
        /// P: Projects, A: the awards
        /// </param>
        /// <param name="awards">
        /// each column presents a award's weight and number
        /// int[A,N]
        /// A: awards, N: the number per award
        /// </param>
        [Obsolete]
        public OrgRank InitRankOld(int[] projects, double[,] votes, double[,] awards, bool isRevoted = false)
        {
            // matV(P,A) = actual votes to matrix PxW
            Matrix<double> matV = CreateMatrix.DenseOfArray(votes);

            // matA(W,N) = the awards's name and number
            Matrix<double> matA = CreateMatrix.DenseOfArray(awards);

            double[] scores = null;
            if (!isRevoted)
            {
                // vecA(W,1) = vector Ax1
                // pick the award's weight into a single array
                double[] weights = matA.Column(0).ToArray();
                weights = weights.Select(a => (double)Math.Pow(10, weights.Length - a)).ToArray();

                Vector<double> vecA = CreateVector.DenseOfArray(weights);

                // S(P,1)=matV(P,A) X vecW(A,1)
                Vector<double> vecS = matV.Multiply(vecA.Conjugate());
                scores = vecS.ToArray();
            }
            else
            {
                scores = matV.Column(0).ToArray();
            }

            // Sort and Rank
            // Sort by the scores
            Array.Sort(scores, projects, Comparer<double>.Create((a, b) =>
            {
                if (a > b) return -1;
                else if (a < b) return 1;
                return 0;
            }));

            // [1,2]
            // [2,2]   => [1,1,2,2,3,3]
            // [3,2]
            double[] awardNos = To1DAwards(awards);
            double[] awardItems = matA.Column(0).ToArray();

            // Rank
            // Grain the rank denpending on the scores one by one
            // when the current score equals to the last, get the same level rank
            // when the current score is less than the last, get the next level rank
            int award_index = 0;
            // int award_no_index = 0;
            int rank_length = 0;
            int count_number = 0;
            int score_index = 0;
            // double last_score = 0.0d;

            Matrix<double> matRanks =
                CreateMatrix.DenseOfColumnArrays(new double[][]
                {
                    projects.Select(p=>(double)p).ToArray(),
                    new double[projects.Length]
                });


            while (true)
            {
                if (score_index == scores.Length) break;
                var current_score = scores[score_index];

                if (current_score == 0)
                {
                    rank_length += count_number;
                    break;
                }
                if (score_index > 0 && current_score < scores[score_index - 1])
                {
                    var current_award_no = matA[award_index, 1];
                    if (count_number >= current_award_no)
                    {
                        award_index++;
                        rank_length += count_number;
                        count_number = 0;
                        if (award_index == awardItems.Length) break;
                    }
                }
                else if (score_index > 0 && current_score == scores[score_index - 1])
                {
                    // do nothing
                }

                matRanks[score_index, 1] = awardItems[award_index];
                score_index++;
                count_number++;
            }

            OrgRank orgRank = new OrgRank();

            if (rank_length == 0 || rank_length == awardNos.Length)
            {
                orgRank = SingleRank(matRanks, rank_length, awardNos, awards);
            }
            else if (rank_length > awardNos.Length)
            {
                int newRank_length = this.CalculateNearestLength(scores, rank_length, awardNos.Length);

                if (newRank_length < awardNos.Length)
                {
                    // split again
                    Vector<double> vecAwardNos = CreateVector.DenseOfArray(awardNos);

                    orgRank = new OrgRank(matRanks.ToArray(), awards);

                    // split ranks into two groups
                    Matrix<double> matRanks1 = matRanks.SubMatrix(0, newRank_length, 0, matRanks.ColumnCount);
                    // split award_numbers into two sub_awards
                    double[,] awards1 = To2DAwards(vecAwardNos.SubVector(0, newRank_length).ToArray());
                    Rank rank1 = new Rank(matRanks1.ToArray(), awards1);
                    orgRank.AddSubRank(rank1);

                    // here rank_length must great than newRank_length
                    // because it should always equals or less than rank_length
                    // it should go to the first SingleRank() if rank_length==newRank_length
                    if (rank_length > newRank_length)
                    {
                        // split ranks into two groups
                        int length = rank_length - newRank_length;
                        Matrix<double> matRanks2 = matRanks.SubMatrix(newRank_length, length, 0, matRanks.ColumnCount);
                        // split award_numbers into two sub_awards
                        length = awardNos.Length - newRank_length;
                        double[,] awards2 = To2DAwards(vecAwardNos.SubVector(newRank_length, length).ToArray());
                        Rank rank2 = new Rank(matRanks2.ToArray(), awards2);
                        orgRank.AddSubRank(rank2);
                    }

                }
                else // newRank_length >= awardNos.Length
                {
                    // reset other's rank as 0
                    for (int i = newRank_length; i < matRanks.RowCount; i++)
                    {
                        matRanks[i, 1] = 0;
                    }

                    orgRank = SingleRank(matRanks, newRank_length, awardNos, awards);
                }
            }
            else if (rank_length < awardNos.Length)
            {
                orgRank = SplitRank(matRanks, rank_length, awardNos, awards);
            }

            return orgRank;
        }

        private OrgRank SingleRank(Matrix<double> matRanks, int rank_length, double[] awardNos, double[,] awards)
        {
            if (rank_length == 0)
            {
                //fill the top ranks of the length of awards as the last award
                double next_award = awardNos[0];

                for (int i = 0; i < awardNos.Length; i++)
                {
                    if (i < matRanks.RowCount)
                        matRanks[i, 1] = next_award;
                }
            }

            OrgRank orgRank = new OrgRank(matRanks.ToArray(), awards);
            orgRank.AddSubRank(new Rank(matRanks.ToArray(), awards));

            return orgRank;
        }

        private OrgRank SplitRank(Matrix<double> matRanks, int rank_length, double[] awardNos,double[,] awards)
        {
            Vector<double> vecAwardNos = CreateVector.DenseOfArray(awardNos);
            //fill the rest of ranks as the last award
            double next_award = vecAwardNos[rank_length];
            for (int i = rank_length; i < matRanks.RowCount; i++)
            {
                if (i < matRanks.RowCount)
                    matRanks[i, 1] = next_award;
            }

            OrgRank orgRank = new OrgRank(matRanks.ToArray(), awards);

            // split ranks into two groups
            Matrix<double> matRanks1 = matRanks.SubMatrix(0, rank_length, 0, matRanks.ColumnCount);
            // split award_numbers into two sub_awards
            double[,] awards1 = To2DAwards(vecAwardNos.SubVector(0, rank_length).ToArray());
            Rank rank1 = new Rank(matRanks1.ToArray(), awards1);
            orgRank.AddSubRank(rank1);

            // split ranks into two groups
            int length = matRanks.RowCount - rank_length;
            Matrix<double> matRanks2 = matRanks.SubMatrix(rank_length, length, 0, matRanks.ColumnCount);
            // split award_numbers into two sub_awards
            length = awardNos.Length - rank_length;
            double[,] awards2 = To2DAwards(vecAwardNos.SubVector(rank_length, length).ToArray());
            Rank rank2 = new Rank(matRanks2.ToArray(), awards2);
            orgRank.AddSubRank(rank2);

            return orgRank;
        }

        private int CalculateNearestLength(double[] scores,int initLength, int awardLength)
        {
            // to locate the first number of the last group having the same numbers
            double last = scores[initLength - 1];
            int lastIndex = initLength - 1;
            while (lastIndex >= 0)
            {
                if (last < scores[lastIndex])
                    break;
                lastIndex--;
            }

            int length = lastIndex < 0 ? 0 : lastIndex + 1;

            if (length == 0) return initLength;

            if (length <= awardLength) return length;

            if (length > awardLength)
            {
                return CalculateNearestLength(scores, length, awardLength);
            }

            return initLength;
        }

        public VerifyResult VerifyRank(double[,] initRanks, double[,] expAwards)
        {
            // init
            Matrix<double> matInitRanks = CreateMatrix.DenseOfArray(initRanks).Clone(); // make a copy so don't effect the original ranks
            Matrix<double> matExpAwards = CreateMatrix.DenseOfArray(expAwards);

            // clean up matRanks to filter out the rows have rank of 0
            Tuple<int, double> zero = matInitRanks.Column(1).Find(r => r == 0.0d, Zeros.Include);
            if (zero != null && zero.Item1>0)
                matInitRanks = matInitRanks.SubMatrix(0, zero.Item1, 0, matInitRanks.ColumnCount);

            Vector<double> vecActRankNumber = matInitRanks.Column(1);
            Vector<double> vecExpAwards = CreateVector.DenseOfArray(To1DAwards(expAwards));

            // init dimension
            int row = Math.Max(vecActRankNumber.Count, vecExpAwards.Count);
            int column = matExpAwards.RowCount;

            // matrix of Actual
            Matrix<double> matActRankNo = ToRankMatrix(row, column, vecActRankNumber.ToArray());
            // matrix of Expected
            Matrix<double> matExpAwardsNo = ToRankMatrix(row, column, vecExpAwards.ToArray());

            // diff between the matrix of Actual and the matrix of Expected
            Matrix<double> matDiff = matExpAwardsNo.Subtract(matActRankNo);

            if (matDiff.ForAll(d => d == 0.0d) /*.Equals(CreateMatrix.Dense(row, column, 0.0d)*/)
            {
                return new VerifyResult()
                {
                    Pass = true,
                    OptRanks = matInitRanks.ToArray(),
                    OrgRanks = initRanks
                };
            }
            else
            {
                double[,] actAwards = To2DAwards(vecActRankNumber.ToArray());

                return new VerifyResult()
                {
                    Pass = false,
                    DiffMatrix = matDiff.ToArray(),
                    ActRankNoMatrix = matActRankNo.ToArray(),
                    ActAwards = actAwards,
                    ExpAwards = expAwards,
                    OptRanks = matInitRanks.ToArray(),
                    OrgRanks = initRanks
                };
            }
        }

        public double[,] GroupRank(double[,] actualAwards, double[,] actualRankMatrix, double[,] diffMatrix)
        {
            // shink the matrix of Actual
            Matrix<double> matShinkedRank = Shink(actualAwards, CreateMatrix.DenseOfArray(actualRankMatrix));

            // shink the matrix of diff
            Matrix<double> matShinkedDiff = Shink(actualAwards, CreateMatrix.DenseOfArray(diffMatrix));

            // the matrix of ReVote groups
            Matrix<double> matGroups = matShinkedRank.Add(matShinkedDiff);

            return matGroups.ToArray();
        }

        public List<VoteGroup> GroupRevote(double[,] orgRanks, double[,] initRanks, double[,] actualAwards, double[,] expAwards, double[,] rankGroups)
        {
            List<VoteGroup> lstVoteGroups=new List<VoteGroup>();

            // build awards matrix
            Matrix<double> matExpAwards = CreateMatrix.DenseOfArray(expAwards).Clone();
            Matrix<double> matActAwards = CreateMatrix.DenseOfArray(actualAwards);

            // build awards vector
            Vector<double> vecAwards = matExpAwards.Column(0);
            // build expect number of rank
            Vector<double> vecExpNumber = matExpAwards.Column(1);

            //build actual Rank matrix;
            Matrix<double> matActRankNumber = CreateMatrix.DenseOfArray(rankGroups);

            // build expected Rank matrix
            int dimension = vecAwards.Count;
            Matrix<double> matExpRankNumber = CreateMatrix.Dense(dimension, dimension, 0.0d);
            for (int i = 0; i < vecExpNumber.Count; i++)
            {
                matExpRankNumber[i, i] = vecExpNumber[i];
            }

            // build actual number of rank
            Vector<double> vecActNumber = matActAwards.Column(1);
            // build awards vector
            Vector<double> vecActAwards = matActAwards.Column(0);

            for (int i = 0; i < vecActAwards.Count; i++)
            {
                int targetRank = (int) vecActAwards[i];//i + 1;
                Vector<double> vecActual = matActRankNumber.Row(i);
                if (matActRankNumber.Row(i).ForAll(r => r == 0)||vecExpNumber.ForAll(e=>e==0))
                {
                    // nothing needs to be revote, hence skip it
                    continue;
                }

                if (matActRankNumber.Row(i).Equals(matExpRankNumber.Row(i)))
                {
                    if (vecActNumber[i] > vecExpNumber[i])
                    {
                        // push to revote group
                        VoteGroup group = new VoteGroup(initRanks, vecActual.ToArray(), vecActAwards.ToArray(), targetRank);
                        lstVoteGroups.Add(group);
                        // update the exp number
                        vecExpNumber=vecExpNumber.Subtract(vecActual);
                    }
                }
                else
                {
                    // has other rank number
                    if (vecActual.Count(v => v > 0) > 1)
                    {
                        // push to revote group
                        VoteGroup group = new VoteGroup(initRanks, vecActual.ToArray(), vecActAwards.ToArray(), targetRank);
                        lstVoteGroups.Add(group);
                        // update the exp number
                        vecExpNumber = vecExpNumber.Subtract(vecActual);
                    }
                    else if (vecActNumber[i] < vecExpNumber[i])
                    {
                        // update initRank with actRunk
                        for (int j = 0; j < orgRanks.GetUpperBound(0)+1; j++)
                        {
                            if ((int)orgRanks[j, 1] == targetRank)
                            {
                                orgRanks[j, 1] = vecActual[i];
                            }
                        }
                    }
                    else if (vecActNumber[i] > vecExpNumber[i])
                    {
                        // push to revote group
                        VoteGroup group = new VoteGroup(initRanks, vecActual.ToArray(), vecActAwards.ToArray(), targetRank);
                        lstVoteGroups.Add(group);
                        // update the exp number
                        vecExpNumber = vecExpNumber.Subtract(vecActual);
                    }
                }
            }

            return lstVoteGroups;
        }

        public double[,] UpdateRank(double[,] parentRanks, double[,] childRanks)
        {
            Matrix<double> matParent = CreateMatrix.DenseOfArray(parentRanks);
            Matrix<double> matChild = CreateMatrix.DenseOfArray(childRanks);

            for (int i = 0; i < matChild.RowCount; i++)
            {
                int project = (int)matChild[i, 0];
                Tuple<int, double> found = matParent.Column(0).Find(p => (int) p == project);
                if (found != null)
                {
                    matParent[found.Item1, 1] = matChild[i, 1];
                }
            }

            return matParent.ToArray();
        }

        public double[,] SortRank(double[,] orgRanks)
        {
            Matrix<double> matRanks = CreateMatrix.DenseOfArray(orgRanks);
            double[] projects = matRanks.Column(0).ToArray();
            double[] ranks = matRanks.Column(1).ToArray();

            Array.Sort(ranks, projects, Comparer<double>.Create((a, b) =>
            {
                if (a == 0 && b != 0) return 1;
                if (a != 0 && b == 0) return -1;
                if (a > b) return 1;
                if (a < b) return -1;
                return 0;
            }));

            matRanks.SetColumn(0,CreateVector.DenseOfArray(projects));
            matRanks.SetColumn(1, CreateVector.DenseOfArray(ranks));

            return matRanks.ToArray();
        }

        private double[] To1DAwards(double[,] awards2D)
        {
            // [1,2]
            // [2,2]   => [1,1,2,2,3,3]
            // [3,2]
            Matrix<double> matAwards2D = CreateMatrix.DenseOfArray(awards2D);
            int totalAwards = (int)matAwards2D.Column(1).Sum();
            double[] awardRanks = new double[totalAwards];
            int index = 0;
            for (int r = 0; r < matAwards2D.RowCount; r++)
            {
                double award = awards2D[r, 0];
                double number = awards2D[r, 1];

                for (int n = 0; n < number; n++)
                {
                    awardRanks[index] = award;
                    index++;
                }
            }

            return awardRanks;
        }

        private double[,] To2DAwards(double[] awards1D)
        {
            double[] awardItems = awards1D.Distinct().OrderBy(a => a).ToArray();
            Matrix<double> matAwards = ToRankMatrix(awards1D.Length, awardItems.Length, awards1D);
            Vector<double> vecNumberActual = matAwards.ColumnSums();
            //Vector<double> vecAwardsItems = CreateVector.DenseOfArray(awardItems);
            matAwards = CreateMatrix.DenseOfRowArrays(new double[][] {awardItems, vecNumberActual.ToArray()});
            //Matrix<double> matExpAwards =
            //    CreateMatrix.DenseOfRowArrays(new double[][]
            //    {expAwardItems, CreateVector.Dense<double>(expAwardItems.Length, 0.0d).ToArray()});

            //for (int i = 0; i < matAwards.ColumnCount; i++)
            //{
            //    int awardItem = (int)matAwards[0, i];

            //    Tuple<int, double> found = matExpAwards.Row(0).Find(e => e == awardItem);
            //    if (found != null)
            //    {
            //        matExpAwards.SetColumn(i,matAwards.Column(i));
            //    }
            //}

            /*
            double[,] awardsActual = new double[awardItems.Length, 2];
            for (int i = 0; i < vecNumberActual.Count; i++)
            {

                awardsActual[i, 0] = awardItems[i];
                awardsActual[i, 1] = vecNumberActual[i];
            }

            return awardsActual;
             */
            return matAwards.Transpose().ToArray();

        }

        private Matrix<double> ToRankMatrix(int row, int column, double[] vecRank)
        {
            Matrix<double> matRank = CreateMatrix.Dense(row, column, 0.0d);
            int r = 0;
            for (int i = 0; i < vecRank.Length; i++)
            {
                if (i > 0 && vecRank[i] != vecRank[i - 1])
                    r++;
                if (r > column - 1)
                    r = column - 1;

                matRank[i, r] = 1;
            }

            return matRank;
        }

        private Matrix<double> Shink(double[,] awards, Matrix<double> matRank)
        {
            int row = awards.GetUpperBound(0) + 1;
            int column = matRank.ColumnCount;
            Matrix<double> matShinked = CreateMatrix.Dense(row,column,0.0d);

            Matrix<double> clone = matRank.Clone();
            int length = awards.GetUpperBound(0) + 1;

            for (int i = 0; i < length; i++)
            {
                int number = (int)awards[i, 1];

                Matrix<double> sub = clone.SubMatrix(0, number, 0, matRank.ColumnCount);
                matShinked.SetRow(i, sub.ColumnSums());
                if (i < length - 1)
                    clone = clone.SubMatrix(number, clone.RowCount - number, 0, clone.ColumnCount);
            }

            return matShinked;
        }
    }
}
