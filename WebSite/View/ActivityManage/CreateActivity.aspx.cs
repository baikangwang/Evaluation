using System;
using System.Data.OleDb;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.ActivityManage
{
    public partial class CreateActivity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ActivityType"] == null || Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
                return;
            }

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            InitPage(conn);
            conn.Close();
        }

        private void InitPage(OleDbConnection conn)
        {
            string strActivityType = Session["ActivityType"].ToString();

            // 获取指定活动类型的当前激活活动
            Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn);
            string strErrorMessage = "";

            if(!IsPostBack)
            {
                txtActivityType.Text = BLL.SysConstant.GetConstant(strActivityType, conn).ConstantValue;

                if (actActivated == null)
                {
                    panelActivityInfo.Visible = false;
                    panelCreateActivity.Visible = true;

                    // 评优活动列表数据绑定
                    gvActivity.DataSource = BLL.Activity.GetActivityList(strActivityType, conn);
                    gvActivity.DataBind();
                }
                else
                {
                    panelCreateActivity.Visible = false;
                    panelActivityInfo.Visible = true;

                    txtCurrentActivity.Text = actActivated.ActivityName;

                    try
                    {
                        ucSchedule.UcSchedule = BLL.Schedule.GetActivitySchedule(actActivated.ActivityID.Value, conn);
                    }
                    catch (Exception ex)
                    {
                        strErrorMessage = ex.Message;
                    }

                    if (ucSchedule.UcSchedule == null)
                    {
                        ucSchedule.UcSchedule = new Dal.Models.Schedule();
                    }
                    ucSchedule.UcSchedule.ActivityID = actActivated.ActivityID;
                }
            }

            ucSchedule.OnSaveSchedule += SaveSchedule;

            hdMsg.Value = strErrorMessage;
        }

        protected void gvActivity_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            string strActivityType = Session["ActivityType"].ToString();

            string strMessage = "";
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            OleDbTransaction tran = null;
            Dal.Models.Activity act = null;
            Dal.Models.Activity actActivated = null;
            Dal.Models.Schedule UcSchedule = new Dal.Models.Schedule();
            switch (e.CommandName)
            {
                case "Activate":
                    tran = conn.BeginTransaction();
                    actActivated = BLL.Activity.GetActivity(strActivityType, conn, tran);
                    if (actActivated != null)
                    {
                        strMessage = "已存在进行中的评优活动，激活失败!";
                        tran.Rollback();
                    }
                    else
                    {
                        act = BLL.Activity.GetActivity(Convert.ToInt32(e.CommandArgument), conn, tran);
                        Dal.Models.Schedule schedule = BLL.Schedule.GetActivitySchedule(act.ActivityID.Value, conn, tran);
                        act.ActivityStatus = "1101";
                        try
                        {
                            if (schedule != null)
                            {
                                UcSchedule.ScheduleID = schedule.ScheduleID;
                            }
                            UcSchedule.IsDeclarationStart = false;
                            UcSchedule.IsDeclarationAutoStart = false;
                            UcSchedule.IsDeclarationAutoEnd = false;
                            UcSchedule.IsPrimaryElectionStart = false;
                            UcSchedule.IsPrimaryElectionAutoStart = false;
                            UcSchedule.IsPrimaryElectionAutoEnd = false;
                            UcSchedule.IsExpertReviewStart = false;
                            UcSchedule.IsExpertReviewAutoStart = false;
                            UcSchedule.IsExpertReviewAutoEnd = false;
                            UcSchedule.IsDownloadStart = false;
                            UcSchedule.IsDownloadAutoStart = false;
                            UcSchedule.IsDownloadAutoEnd = false;
                            UcSchedule.IsVoteStart = false;
                            UcSchedule.IsVoteAutoStart = false;
                            UcSchedule.IsVoteAutoEnd = false;
                            UcSchedule.IsReVoteStart = false;
                            BLL.Activity.UpdateActivity(act, conn, tran);
                            BLL.Schedule.SetSchedule(UcSchedule, conn, tran);
                            tran.Commit();

                            ucSchedule.activityRefresh();
                            panelCreateActivity.Visible = false;
                            panelActivityInfo.Visible = true;
                            txtCurrentActivity.Text = act.ActivityName;

                            strMessage = "激活成功！";
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            strMessage = ex.Message;
                        }
                    }

                    hdMsg.Value = strMessage;
                    break;
            }

            conn.Close();
        }

        protected void lkbFinishActivity_Click(object sender, EventArgs e)
        {
            string strMessage = "";
            string strActivityType = Session["ActivityType"].ToString();
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);

            conn.Open();
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn, tran);
                actActivated.ActivityStatus = "1110";
                BLL.Activity.UpdateActivity(actActivated, conn, tran);
                tran.Commit();
                strMessage = "活动结束!";
            }
            catch (Exception ex)
            {
                tran.Rollback();
                strMessage = ex.Message;
            }

            panelActivityInfo.Visible = false;
            panelCreateActivity.Visible = true;
            gvActivity.DataSource = BLL.Activity.GetActivityList(strActivityType, conn);
            gvActivity.DataBind();

            hdMsg.Value = strMessage;

            conn.Close();
        }

        protected void lkbCreateActivity_Click(object sender, EventArgs e)
        {
            Dal.Models.Activity activity = new Dal.Models.Activity();
            activity.ActivityName=txtActivityName.Text;
            activity.ActivityTypeCode = Session["ActivityType"].ToString();
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            OleDbTransaction trans = conn.BeginTransaction();
            string strMessage = "";

            int result = 0;
            try
            {
                result = BLL.Activity.CreateActivity(activity, conn, trans);
                trans.Commit();
                strMessage = "创建成功!";
            }
            catch (Exception ex)
            {
                trans.Rollback();
                strMessage = ex.Message;
            }

            ucSchedule.activityRefresh();
            panelCreateActivity.Visible = false;
            panelActivityInfo.Visible = true;
            txtCurrentActivity.Text = activity.ActivityName;
            hdMsg.Value = strMessage;
            conn.Close();
            
        }

        protected void SaveSchedule(object sender, EventArgs e)
        {
            string strActivityType = Session["ActivityType"].ToString();
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            OleDbTransaction trans = conn.BeginTransaction();
            Dal.Models.Schedule schedule = new Dal.Models.Schedule();
            Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn, trans);
            schedule.ActivityID = actActivated.ActivityID;

            DateTime dt;
            if (!string.IsNullOrEmpty(ucSchedule.DeclarationBeginDate)
                && DateTime.TryParse(ucSchedule.DeclarationBeginDate, out dt))
            {
                schedule.DeclarationBeginDate = dt;
            }

            if (!string.IsNullOrEmpty(ucSchedule.DeclarationEndDate)
                && DateTime.TryParse(ucSchedule.DeclarationEndDate, out dt))
            {
                schedule.DeclarationEndDate = dt;
            }

            schedule.IsDeclarationStart = ucSchedule.IsDeclarationStart == "True";
            schedule.IsDeclarationAutoStart = ucSchedule.IsDeclarationAutoStart == "True";
            schedule.IsDeclarationAutoEnd = ucSchedule.IsDeclarationAutoEnd == "True";

            if (!string.IsNullOrEmpty(ucSchedule.PrimaryElectionBeginDate)
                && DateTime.TryParse(ucSchedule.PrimaryElectionBeginDate, out dt))
            {
                schedule.PrimaryElectionBeginDate = dt;
            }

            if (!string.IsNullOrEmpty(ucSchedule.PrimaryElectionEndDate)
                && DateTime.TryParse(ucSchedule.PrimaryElectionEndDate, out dt))
            {
                schedule.PrimaryElectionEndDate = dt;
            }

            schedule.IsPrimaryElectionStart = ucSchedule.IsPrimaryElectionStart == "True";
            schedule.IsPrimaryElectionAutoStart = ucSchedule.IsPrimaryElectionAutoStart == "True";
            schedule.IsPrimaryElectionAutoEnd = ucSchedule.IsPrimaryElectionAutoEnd == "True";

            if (!string.IsNullOrEmpty(ucSchedule.ExpertReviewBeginDate)
                && DateTime.TryParse(ucSchedule.ExpertReviewBeginDate, out dt))
            {
                schedule.ExpertReviewBeginDate = dt;
            }

            if (!string.IsNullOrEmpty(ucSchedule.ExpertReviewEndDate)
                && DateTime.TryParse(ucSchedule.ExpertReviewEndDate, out dt))
            {
                schedule.ExpertReviewEndDate = dt;
            }

            schedule.IsExpertReviewStart = ucSchedule.IsExpertReviewStart == "True";
            schedule.IsExpertReviewAutoStart = ucSchedule.IsExpertReviewAutoStart == "True";
            schedule.IsExpertReviewAutoEnd = ucSchedule.IsExpertReviewAutoEnd == "True";

            if (!string.IsNullOrEmpty(ucSchedule.DownloadBeginDate)
                && DateTime.TryParse(ucSchedule.DownloadBeginDate, out dt))
            {
                schedule.DownloadBeginDate = dt;
            }

            if (!string.IsNullOrEmpty(ucSchedule.DownloadEndDate)
                && DateTime.TryParse(ucSchedule.DownloadEndDate, out dt))
            {
                schedule.DownloadEndDate = dt;
            }

            schedule.IsDownloadStart = ucSchedule.IsDownloadStart == "True";
            schedule.IsDownloadAutoStart = ucSchedule.IsDownloadAutoStart == "True";
            schedule.IsDownloadAutoEnd = ucSchedule.IsDownloadAutoEnd == "True";

            //投票
            if (!string.IsNullOrEmpty(ucSchedule.VoteBeginDate)
               && DateTime.TryParse(ucSchedule.VoteBeginDate, out dt))
            {
                schedule.VoteBeginDate = dt;
            }

            if (!string.IsNullOrEmpty(ucSchedule.VoteEndDate)
                && DateTime.TryParse(ucSchedule.VoteEndDate, out dt))
            {
                schedule.VoteEndDate = dt;
            }

            schedule.IsVoteStart = ucSchedule.IsVoteStart == "True";
            schedule.IsVoteAutoStart = ucSchedule.IsVoteAutoStart == "True";
            schedule.IsVoteAutoEnd = ucSchedule.IsVoteAutoEnd == "True";

            schedule.IsReVoteStart = ucSchedule.IsReVoteStart == "True";

            try
            {
                BLL.Schedule.SetSchedule(schedule, conn, trans);
                trans.Commit();
                hdMsg.Value = "时间节点设置成功！";
            }
            catch (Exception ex)
            {
                trans.Rollback();
                hdMsg.Value = ex.Message;
                ViewState["ErrorMessage"] = ex.Message;
            }

            conn.Close();
        }
    }
}