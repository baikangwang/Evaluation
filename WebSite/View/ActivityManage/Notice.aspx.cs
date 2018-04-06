using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.ActivityManage
{
    public partial class Notice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(Request["nid"]))
                {
                    panelOperation.Visible = true;
                    panelLook.Visible = false;
                    lbkConserve.Visible = true;
                    lbkUpdate.Visible = false;
                }
                else
                {
                    int id = Convert.ToInt32(Request["nid"]);
                    InitPage(id);
                    string strtype = Request["statype"] == null ? "0" : Request["statype"].ToString();
                    if (strtype == "3" || strtype == "2")//表示查看
                    {
                        clickNum(Convert.ToInt32(Request["nid"]));
                        panelOperation.Visible = false;
                        panelLook.Visible = true;
                    }
                    else
                    {
                        panelOperation.Visible = true;
                        panelLook.Visible = false;
                        lbkConserve.Visible = false;
                    }
                }
            }
        }

        public void InitPage(int id)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            OleDbTransaction tran = conn.BeginTransaction();
            Dal.Models.Notice notice = BLL.Notice.GetNotice(id, conn,tran);
            txtTitle.Text = notice.Title;
            txtNoticeContent.Text = notice.NoticeContent;
            NoticeID.Value = id.ToString();
            TbxOrdinal.Text = notice.Ordinal == null ? "" : notice.Ordinal.ToString();

            lblTitle.Text = notice.Title;
            lblDate.Text = Convert.ToDateTime(notice.LastEditTime).ToString("yyyy-MM-dd");
            nContent.InnerHtml = notice.NoticeContent;

            Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(id, null, "NoticeAppendix", conn, tran);
            if (dUploadFileInfo != null)
            {
                StringBuilder sbInnerHtml = new StringBuilder();
                sbInnerHtml.Append(dUploadFileInfo.FileName);
                sbInnerHtml.AppendFormat("<a class='DeleteNoticeAppendix' onclick='DeleteNoticeAppendix({0});return false;' title='删除' href=''>", id);
                sbInnerHtml.Append("<i class='fa fa-trash-o'></i>");
                sbInnerHtml.Append("</a>");
                sbInnerHtml.AppendFormat("　　　<a class='DownloadNoticeAppendix' onclick=\"DownloadAppendix({0});return false;\" title='下载' href=''>", id);
                sbInnerHtml.Append("<i class='fa fa-download'></i></a></td>");
                tdUploadFileInfo.InnerHtml = sbInnerHtml.ToString();

                tabLookUploadFileInfo.Visible = true;
                tdLookUploadFileInfo.InnerHtml = sbInnerHtml.ToString();
            }
            else
            {
                tabLookUploadFileInfo.Visible = false;
                tdUploadFileInfo.InnerHtml = "暂未上传附件！";
            }
            conn.Close();
            hdMsg.Value = "";
        }
        protected void lbkConserve_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            OleDbTransaction tran = conn.BeginTransaction();
            string strActivityType =Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn, tran);
            if (activity == null)
            {
                hdMsg.Value = "当前活动已关闭，请联系活动管理人员！";
                return;
            }

            Dal.Models.Notice notice = new Dal.Models.Notice();
            if (ViewState["NoticeID"] == null)
            {
                try
                {
                    notice.ActivityID = Convert.ToInt32(activity.ActivityID);
                    notice.Title = txtTitle.Text.Trim();
                    notice.NoticeContent = txtNoticeContent.Text;
                    notice.CreateTime = DateTime.Now;
                    notice.EffectTime = DateTime.Now;//Convert.ToDateTime(txtStartDate.Text);
                    int iOrdinal = 0;
                    if (!string.IsNullOrEmpty(TbxOrdinal.Text) && Int32.TryParse(TbxOrdinal.Text, out iOrdinal))
                    {
                        notice.Ordinal = iOrdinal;//Convert.ToInt32(TbxOrdinal.Text);
                    }
                    ViewState["NoticeID"] = BLL.Notice.CreateNotice(notice, Convert.ToInt32(activity.ActivityID), conn, tran);
                    NoticeID.Value = ViewState["NoticeID"].ToString();

                    Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(Convert.ToInt32(NoticeID.Value), null, "NoticeAppendix", conn, tran);
                    if (dUploadFileInfo != null)
                    {
                        StringBuilder sbInnerHtml = new StringBuilder();
                        sbInnerHtml.Append(dUploadFileInfo.FileName);
                        sbInnerHtml.AppendFormat("<a class='DeleteNoticeAppendix' onclick='DeleteNoticeAppendix({0});return false;' title='删除' href=''>", NoticeID.Value);
                        sbInnerHtml.Append("<i class='fa fa-trash-o'></i>");
                        sbInnerHtml.Append("</a>");
                        sbInnerHtml.AppendFormat("　　　<a class='DownloadNoticeAppendix' onclick=\"DownloadAppendix({0});return false;\" title='下载' href=''>", NoticeID.Value);
                        sbInnerHtml.Append("<i class='fa fa-download'></i></a></td>");

                        tdUploadFileInfo.InnerHtml = sbInnerHtml.ToString();

                    }
                    else
                    {
                        tdUploadFileInfo.InnerHtml = "暂未上传附件！";
                    }
                    tran.Commit();
                    hdMsg.Value = "发布成功！";
                }
                catch (Exception)
                {
                    tran.Rollback();
                    hdMsg.Value = "发布失败！";
                    conn.Close();
                    return;
                }
            }
            else
            {
                UpdateNoticeBack();
            }
            conn.Close();
        }
                
        public void clickNum(int noticID)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            OleDbTransaction tran = conn.BeginTransaction();
            int rs = BLL.Notice.UpdateClicks(noticID,conn, tran);
            tran.Commit();
        }

        protected void LbkCancel_Click(object sender, EventArgs e)
        {
            string strtype = Request["statype"] == null ? "0" : Request["statype"].ToString();
            if (strtype == "3")//表示查看
            {
                Response.Redirect("~/View/Mutual/HomePage.aspx");
            }
            else
            {
                Response.Redirect("~/view/ActivityManage/NoticeList.aspx");
            }
        }

        protected void UpdateNoticeBack()
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            OleDbTransaction tran = conn.BeginTransaction();
            int id = Convert.ToInt32(Request["nid"]);
            if (ViewState["NoticeID"] != null)
            {
                id = Convert.ToInt32(ViewState["NoticeID"]);
                NoticeID.Value = ViewState["NoticeID"].ToString();
                Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(Convert.ToInt32(id), null, "NoticeAppendix", conn, tran);
                if (dUploadFileInfo != null)
                {
                    StringBuilder sbInnerHtml = new StringBuilder();
                    sbInnerHtml.Append(dUploadFileInfo.FileName);
                    sbInnerHtml.AppendFormat("<a class='DeleteNoticeAppendix' onclick='DeleteNoticeAppendix({0});return false;' title='删除' href=''>", id);
                    sbInnerHtml.Append("<i class='fa fa-trash-o'></i>");
                    sbInnerHtml.Append("</a>");
                    sbInnerHtml.AppendFormat("　　　<a class='DownloadNoticeAppendix' onclick=\"DownloadAppendix({0});return false;\" title='下载' href=''>", id);
                    sbInnerHtml.Append("<i class='fa fa-download'></i></a></td>");

                    tdUploadFileInfo.InnerHtml = sbInnerHtml.ToString();
                }
                else
                {
                    tdUploadFileInfo.InnerHtml = "暂未上传附件！";
                }
            }

            string strActivityType =Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn, tran);
            if (activity == null)
            {
                hdMsg.Value = "当前活动已关闭，请联系活动管理人员！";
                tran.Rollback();
                conn.Close();
                return;
            }

            Dal.Models.Notice notice = new Dal.Models.Notice();
            try
            {
                notice.ActivityID = Convert.ToInt32(activity.ActivityID);
                notice.Title = txtTitle.Text.Trim();
                notice.NoticeContent = txtNoticeContent.Text;
                notice.CreateTime = DateTime.Now;
                notice.EffectTime = DateTime.Now;//Convert.ToDateTime(txtStartDate.Text);
                int iOrdinal = 0;
                if (!string.IsNullOrEmpty(TbxOrdinal.Text) && Int32.TryParse(TbxOrdinal.Text, out iOrdinal))
                {
                    notice.Ordinal = iOrdinal;//Convert.ToInt32(TbxOrdinal.Text);
                }
                int result = BLL.Notice.UpdateNotice(notice, id, conn, tran);
                tran.Commit();
                hdMsg.Value = "操作成功！";
            }
            catch (Exception)
            {
                tran.Rollback();
                hdMsg.Value = "操作失败！";
                conn.Close();
                return;
            }
            conn.Close();
        }

        protected void lbkUpdate_Click(object sender, EventArgs e)
        {
            UpdateNoticeBack();
        }

        protected void LbkBack_Click(object sender, EventArgs e)
        {
            string strtype = Request["statype"] == null ? "0" : Request["statype"].ToString();
            if (strtype == "3")//表示查看
            {
                Response.Redirect("~/View/Mutual/HomePage.aspx");
            }
            else
            {
                Response.Redirect("~/view/ActivityManage/NoticeList.aspx");
            }
        }
    }
}