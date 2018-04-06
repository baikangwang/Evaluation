using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web.UI.HtmlControls;

namespace Evaluation.View.Mutual
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ActivityType"] == null || Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
                return;
            }

            if (!IsPostBack)
            {
                #region
                Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
                hdUserid.Value = user.UserID.ToString();

                if (user.IsPasswordChanged == false && Session["Prompt"] == null)
                {
                    hdMsg.Value = "当前为系统默认密码，请修改密码!";
                    Session["Prompt"] = "1";
                }

                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();

                string strActivityType = Session["ActivityType"].ToString();
                Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn);

                // 活动关闭阶段只有超级管理员可以登录
                if (actActivated == null)
                {
                    if (user.UserType != "0801" && user.UserType != "0802" && user.UserType != "0803")
                    {
                        Response.Redirect("../Mutual/UserEntry.aspx");
                        return;
                    }
                }

                string strUserType = "";
                try
                {
                    strUserType = BLL.SysConstant.GetConstant(user.UserType, conn).ConstantValue;
                }
                catch
                {
                    strUserType = "用户";
                    user.LastLoginTime = DateTime.Now;
                }

                litUserName.Text = user.UserName;
                litEmail.Text = user.Email;
                litUserType.Text = strUserType;
                if (user.LastLoginTime == null)
                {
                    litLastLoginTime.Text = "无";
                }
                else
                {
                    litLastLoginTime.Text = user.LastLoginTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                }

                if (actActivated == null || actActivated.ActivityID == null)
                {
                    litNewDeclaration.Text = "0";
                    litCompleteDeclaration.Text = "0";
                }
                else
                {
                    litNewDeclaration.Text = BLL.Declaration.GetWeeklyNewDeclarationCount(actActivated.ActivityID.Value, 0, conn).ToString();
                    litCompleteDeclaration.Text = BLL.Declaration.GetWeeklyCompleteDeclaration(actActivated.ActivityID.Value, conn).Count.ToString();

                    try
                    {
                        litExpertCount.Text = BLL.Expert.GetExpertList(conn,user).Count().ToString();
                    }
                    catch
                    {
                        litExpertCount.Text = "0";
                    }

                    try
                    {
                        litDeclarationCount.Text = BLL.Declaration.GetDeclarationCount(actActivated.ActivityID.Value, conn).ToString();
                    }
                    catch
                    {
                        litDeclarationCount.Text = "0";
                    }

                    //List<Dal.Models.Specialty> lstSpec = null;
                    //try
                    //{
                    //    lstSpec = BLL.Specialty.GetSpecialtyList(actActivated.ActivityID.Value, true, conn);
                    //}
                    //catch
                    //{
                    //    lstSpec = new List<Dal.Models.Specialty>();
                    //}

                    //string strDeclarationCount = "";
                    //string strSpecialty = "";
                    //string strJson = "";
                    //int iCount = 0;
                    //foreach (Dal.Models.Specialty spec in lstSpec)
                    //{
                    //    strSpecialty += spec.SpecialtyName + ",";
                    //    try
                    //    {
                    //        iCount = BLL.Declaration.CountInSpecialty(spec.SpecialtyID.Value, conn);
                    //    }
                    //    catch
                    //    {
                    //        iCount = 0;
                    //    }
                    //    strDeclarationCount += iCount.ToString() + ",";
                    //    strJson += " { value: " + iCount.ToString() + ", name: '" + spec.SpecialtyName + "' },";
                    //}

                    //if (!string.IsNullOrEmpty(strSpecialty))
                    //{
                    //    ViewState["SpecialtyName"] = strSpecialty.TrimEnd(",".ToCharArray());
                    //    ViewState["DeclarationCount"] = strDeclarationCount.TrimEnd(",".ToCharArray());
                    //    ViewState["Json"] = strJson.TrimEnd(",".ToCharArray());
                    //}
                }

                pUserType.InnerHtml = user.UserType;

                conn.Close();
                #endregion
            }
            GetNotice();
            GetNewDeclaration();
        }

        /// <summary>
        /// 加载最新申报信息
        /// </summary>
        public void GetNewDeclaration()
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn);

            List<Dal.Models.Declaration> decl = null;
            if (actActivated != null)
            {
                decl = BLL.Declaration.GetDeclarationList(user, Convert.ToInt32(actActivated.ActivityID), conn);
                if (user.UserType == "0805")
                {
                    decl = decl.Where(d => d.DeclarationStatus == "1803").OrderByDescending(d => d.DeclareDate).Take(4).ToList();
                }
                else
                {
                    decl = decl.Where(d => !(new string[] { "1805", "1806" }.Contains(d.DeclarationStatus))).OrderByDescending(d => d.DeclareDate).Take(4).ToList();
                }

                for (int i = 0; i < decl.Count; i++)
                {
                    HtmlTableRow tr = new HtmlTableRow();
                    HtmlTableCell td1 = new HtmlTableCell("td");
                    HtmlTableCell td2 = new HtmlTableCell("td");
                    HtmlTableCell td3 = new HtmlTableCell("td");
                    HtmlTableCell td4 = new HtmlTableCell("td");
                    td1.InnerHtml = decl[i].DeclarationCode.ToString();
                    td2.InnerHtml = "<a href='../Declaration/Declaration.aspx?DeclarationID="
                        + decl[i].DeclarationID + "&Situation=ExpertReview'>" + decl[i].DeclarationName.ToString() + "</a>";
                    td3.InnerHtml = decl[i].SpecialtyName;
                    td4.InnerHtml = decl[i].PrizeName;
                    tr.Cells.Add(td1);
                    tr.Cells.Add(td2);
                    tr.Cells.Add(td3);
                    tr.Cells.Add(td4);
                    NewDeclaration.Rows.Add(tr);
                }
            }

            conn.Close();
        }

        /// <summary>
        /// 加载公告标题
        /// </summary>
        public void GetNotice()
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity != null)
            {
                int activityID = Convert.ToInt32(activity.ActivityID);
                OleDbTransaction tran = conn.BeginTransaction();
                List<Dal.Models.Notice> notice = BLL.Notice.GetNoticeList(activityID, conn, tran);

                for (int i = 0; i < notice.Count; i++)
                {
                    HtmlTableRow tr = new HtmlTableRow();
                    HtmlTableCell td1 = new HtmlTableCell("td");
                    HtmlTableCell td2 = new HtmlTableCell("td");
                    HtmlTableCell td3 = new HtmlTableCell("td");
                    td1.InnerHtml = "<a href='../../View/ActivityManage/Notice.aspx?nid=" + notice[i].NoticeID + "&statype=3'>" + notice[i].Title + "</a>";
                    td2.InnerHtml = Convert.ToDateTime(notice[i].EffectTime).ToString("yyyy-MM-dd");
                    td3.InnerHtml = notice[i].Clicks.ToString();
                    tr.Cells.Add(td1);
                    tr.Cells.Add(td2);
                    tr.Cells.Add(td3);
                    tbNotice.Rows.Add(tr);
                }
            }
        }
    }
}