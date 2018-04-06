using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using BLL;
using Dal.Models;

namespace Evaluation.View.ExpertElect
{
    public partial class NewRevote : System.Web.UI.Page
    {
        public List<int> GroupIds { get; set; }

        private Dal.Models.Prize _prize;
        private RevotePrize _revotePrize;

        protected void Page_Init(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string PrizeID = Request["PrizeID"];
            // txtPrizeID.Text = PrizeID;
            _prize = BLL.Prize.GetPrize(Convert.ToInt32(PrizeID), conn);
            Revote revote=new Revote();
            _revotePrize = revote.GetLastRevotePrize(_prize, conn);
            //labPrizeName.Text = prize.PrizeName.ToString();
            var groups = revote.GetRevoteGroups(_prize, conn);
            this.GroupIds = groups.Select(g=>g.RevoteGroupId).ToList();
            conn.Close();
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitPage();
            }
        }
        private void InitPage()
        {
            //OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            //conn.Open();
            //string PrizeID = Request["PrizeID"].ToString();
            txtPrizeID.Text = _prize.PrizeID.Value.ToString();
            //var prize = BLL.Prize.GetPrize(Convert.ToInt32(PrizeID), conn);
            labPrizeName.Text = _prize.PrizeName.ToString();
            lblRevoteRound.Text = string.Format("第{0}轮复投",_revotePrize.RevoteRound);
            //var groups = new BLL.Revote().GetRevoteGroups(prize, conn);
            //conn.Close();
        }
    }
}