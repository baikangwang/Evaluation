using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.ExpertElect
{
    public partial class MultipleVote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                InitPage();
            }
        }
        private void InitPage()
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            //获取当前活动类型编码
            string strActivityType = Session["ActivityType"].ToString();

            //获取当前活动ID
            int iActivityID = BLL.Activity.GetActivityID(strActivityType, conn);
            string PrizeID = Request["PrizeID"].ToString();
            txtPrizeID.Text = PrizeID;

            Dal.Models.Prize prize = BLL.Prize.GetPrize(Convert.ToInt32(PrizeID), conn);
            txtMultipleVoteRound.Text = prize.MultipleVoteRound.ToString();
            lblMultipleVoteRound.Text = txtMultipleVoteRound.Text == "" ? "1" : txtMultipleVoteRound.Text;
            labPrizeName.Text = prize.PrizeName.ToString();
            string PrizeType = Request["PrizeType"].ToString();
            string prizeLevel = "";
            if (PrizeType == "0301" || PrizeType == "0304")//综合奖多轮投、专项奖多轮投
            {
                int sum = 0;
                Dal.Models.Prize prizeList = BLL.Prize.GetPrize(Convert.ToInt32(PrizeID), conn);
                if (lblMultipleVoteRound.Text.Trim() == "1")//第一轮都三等奖的，名额全部显示
                {
                    lblPrizeNum.Text = prizeList.AwardCount.ToString();
                }
                else if (lblMultipleVoteRound.Text.Trim() == "2")
                {
                    sum = prizeList.FirstPrize.Value + prizeList.SecondPrize.Value;
                    lblPrizeNum.Text = sum.ToString();
                }
                else if (lblMultipleVoteRound.Text.Trim() == "3")
                {
                    sum = prizeList.FirstPrize.Value;
                    lblPrizeNum.Text = sum.ToString();
                }
            }
            else if (PrizeType == "0302")//单项奖
            {
                prizeLevel = "0404";
                lblPrizeNum.Text = BLL.Prize.GetPrizeLevel(Convert.ToInt32(PrizeID), prizeLevel, conn).LevelLimitNumber.ToString();
            }
            else if (PrizeType == "0303")//中小创
            {
                prizeLevel = "0405";
                lblPrizeNum.Text = BLL.Prize.GetPrizeLevel(Convert.ToInt32(PrizeID), prizeLevel, conn).LevelLimitNumber.ToString();
            }

            conn.Close();
        }
    }
}