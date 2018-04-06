using System;
using System.Data.OleDb;

namespace Evaluation.View.ActivityManage
{
    public partial class Schedule : System.Web.UI.UserControl
    {
        public Dal.Models.Schedule UcSchedule { get; set; }
        public string DeclarationBeginDate { get { return txtDeclarationBeginDate.Text; } }
        public string DeclarationEndDate { get { return txtDeclarationEndDate.Text; } }
        public string PrimaryElectionBeginDate { get { return txtPrimaryElectionBeginDate.Text; } }
        public string PrimaryElectionEndDate { get { return txtPrimaryElectionEndDate.Text; } }
        public string ExpertReviewBeginDate { get { return txtExpertReviewBeginDate.Text; } }
        public string ExpertReviewEndDate { get { return txtExpertReviewEndDate.Text; } }

        public string DownloadBeginDate{ get { return txtDownloadBeginDate.Text; }}
        public string DownloadEndDate { get { return txtDownloadEndDate.Text; } }
        public string VoteBeginDate { get { return txtVoteBeginDate.Text; } }
        public string VoteEndDate { get { return txtVoteEndDate.Text; } }

        public string IsDeclarationStart{get{return ddlIsDeclarationStart.SelectedValue;}}
        public string IsDeclarationAutoStart{get{return ddlIsDeclarationAutoStart.SelectedValue;}}
        public string IsDeclarationAutoEnd{get{return ddlIsDeclarationAutoEnd.SelectedValue;}}
        public string IsPrimaryElectionStart{get{return ddlIsPrimaryElectionStart.SelectedValue;}}
        public string IsPrimaryElectionAutoStart{get{return ddlIsPrimaryElectionAutoStart.SelectedValue;}}
        public string IsPrimaryElectionAutoEnd{get{return ddlIsPrimaryElectionAutoEnd.SelectedValue;}}
        public string IsExpertReviewStart{get{return ddlIsExpertReviewStart.SelectedValue;}}
        public string IsExpertReviewAutoStart{get{return ddlIsExpertReviewAutoStart.SelectedValue;}}
        public string IsExpertReviewAutoEnd{get{return ddlIsExpertReviewAutoEnd.SelectedValue;}}
        public string IsDownloadStart{ get { return ddlIsDownloadStart.SelectedValue; } }
        public string IsDownloadAutoStart{ get { return ddlIsDownloadAutoStart.SelectedValue; } }
        public string IsDownloadAutoEnd { get { return ddlIsDownloadAutoEnd.SelectedValue; } }
        public string IsVoteStart { get { return ddlIsVoteStart.SelectedValue; } }
        public string IsVoteAutoStart { get { return ddlIsVoteAutoStart.SelectedValue; } }
        public string IsVoteAutoEnd { get { return ddlIsVoteAutoEnd.SelectedValue; } }
        public string IsReVoteStart{get{return ddlIsReVoteStart.SelectedValue;}}

        public event EventHandler OnSaveSchedule;

        //protected void InitDropDownList(System.Web.UI.WebControls.DropDownList ddl, bool bIsTrue)
        //{
        //    ddl.Items.Clear();
        //    ddl.Items.Add(new System.Web.UI.WebControls.ListItem("是", "True"));
        //    ddl.Items.Add(new System.Web.UI.WebControls.ListItem("否", "False"));
        //    ddl.SelectedValue = bIsTrue ? "True" : "False";
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (UcSchedule != null)
                {
                    #region
                    // 申报 开始时间
                    if (UcSchedule.DeclarationBeginDate != null)
                    {
                        txtDeclarationBeginDate.Text = UcSchedule.DeclarationBeginDate.Value.ToString("yyyy-MM-dd");
                    }

                    // 申报 结束时间
                    if (UcSchedule.DeclarationEndDate != null)
                    {
                        txtDeclarationEndDate.Text = UcSchedule.DeclarationEndDate.Value.ToString("yyyy-MM-dd");
                    }

                    // 申报 是否开始
                     // cbIsDeclarationStart.Checked = UcSchedule.IsDeclarationStart ?? false;
                   ddlIsDeclarationStart.SelectedValue = UcSchedule.IsDeclarationStart == true ? "True" : "False";
                   //InitDropDownList(ddlIsDeclarationStart, UcSchedule.IsDeclarationStart == true);

                    // 申报 是否自动开始
                    //cbIsDeclarationAutoStart.Checked = UcSchedule.IsDeclarationAutoStart ?? false;
                   ddlIsDeclarationAutoStart.SelectedValue = UcSchedule.IsDeclarationAutoStart == true ? "True" : "False";
                    //InitDropDownList(ddlIsDeclarationAutoStart, UcSchedule.IsDeclarationAutoStart == true);

                    // 申报 是否自动结束
                    //cbIsDeclarationAutoEnd.Checked = UcSchedule.IsDeclarationAutoEnd ?? false;
                   ddlIsDeclarationAutoEnd.SelectedValue = UcSchedule.IsDeclarationAutoEnd == true ? "True" : "False";
                    //InitDropDownList(ddlIsDeclarationAutoEnd, UcSchedule.IsDeclarationAutoEnd == true);

                    // 海选 开始时间
                    if (UcSchedule.PrimaryElectionBeginDate != null)
                    {
                        txtPrimaryElectionBeginDate.Text = UcSchedule.PrimaryElectionBeginDate.Value.ToString("yyyy-MM-dd");
                    }

                    // 海选 结束时间
                    if (UcSchedule.PrimaryElectionEndDate != null)
                    {
                        txtPrimaryElectionEndDate.Text = UcSchedule.PrimaryElectionEndDate.Value.ToString("yyyy-MM-dd");
                    }

                    // 海选 是否开始
                    //cbIsPrimaryElectionStart.Checked = UcSchedule.IsPrimaryElectionStart ?? false;
                    ddlIsPrimaryElectionStart.SelectedValue = UcSchedule.IsPrimaryElectionStart == true ? "True" :"False";
                    //InitDropDownList(ddlIsPrimaryElectionStart, UcSchedule.IsPrimaryElectionStart == true);

                    // 海选 是否自动开始
                    //cbIsPrimaryElectionAutoStart.Checked = UcSchedule.IsPrimaryElectionAutoStart ?? false;
                    ddlIsPrimaryElectionAutoStart.SelectedValue = UcSchedule.IsPrimaryElectionAutoStart == true ? "True" : "False";
                    //InitDropDownList(ddlIsPrimaryElectionAutoStart, UcSchedule.IsPrimaryElectionAutoStart == true);

                    // 海选 是否自动结束
                    //cbIsPrimaryElectionAutoEnd.Checked = UcSchedule.IsPrimaryElectionAutoEnd ?? false;
                    ddlIsPrimaryElectionAutoEnd.SelectedValue = UcSchedule.IsPrimaryElectionAutoEnd == true ? "True" : "False";
                    //InitDropDownList(ddlIsPrimaryElectionAutoEnd, UcSchedule.IsPrimaryElectionAutoEnd == true);

                    // 评审 开始时间
                    if (UcSchedule.ExpertReviewBeginDate != null)
                    {
                        txtExpertReviewBeginDate.Text = UcSchedule.ExpertReviewBeginDate.Value.ToString("yyyy-MM-dd");
                    }

                    // 评审 结束时间
                    if (UcSchedule.ExpertReviewEndDate != null)
                    {
                        txtExpertReviewEndDate.Text = UcSchedule.ExpertReviewEndDate.Value.ToString("yyyy-MM-dd");
                    }

                    ddlIsExpertReviewStart.SelectedValue = UcSchedule.IsExpertReviewStart == true ? "True" : "False";
                    ddlIsExpertReviewAutoStart.SelectedValue = UcSchedule.IsExpertReviewAutoStart == true ? "True" : "False";
                    ddlIsExpertReviewAutoEnd.SelectedValue = UcSchedule.IsExpertReviewAutoEnd == true ? "True" : "False";

                    // 下载 是否开始
                    //cbIsDownloadStart.Checked = UcSchedule.IsDownloadStart ?? false;
                    ddlIsDownloadStart.SelectedValue = UcSchedule.IsDownloadStart == true ? "True" : "False";
                    //InitDropDownList(ddlIsDownloadStart, UcSchedule.IsDownloadStart == true);

                    // 下载 是否自动开始
                    //cbIsDownloadAutoStart.Checked = UcSchedule.IsDownloadAutoStart ?? false;
                    ddlIsDownloadAutoStart.SelectedValue = UcSchedule.IsDownloadAutoStart == true ? "True" : "False";
                    //InitDropDownList(ddlIsDownloadAutoStart, UcSchedule.IsDownloadAutoStart == true);

                    // 下载 是否自动结束
                    //cbIsDownloadAutoEnd.Checked = UcSchedule.IsDownloadAutoEnd ?? false;
                    ddlIsDownloadAutoEnd.SelectedValue = UcSchedule.IsDownloadAutoEnd == true ? "True" : "False";
                    //InitDropDownList(ddlIsDownloadAutoEnd, UcSchedule.IsDownloadAutoEnd == true);

                    // 下载 开始时间
                    if (UcSchedule.DownloadBeginDate != null)
                    {
                        txtDownloadBeginDate.Text = UcSchedule.DownloadBeginDate.Value.ToString("yyyy-MM-dd");
                    }

                    // 下载 结束时间
                    if (UcSchedule.DownloadEndDate != null)
                    {
                        txtDownloadEndDate.Text = UcSchedule.DownloadEndDate.Value.ToString("yyyy-MM-dd");
                    }

                    // 投票是否开始
                    ddlIsVoteStart.SelectedValue = UcSchedule.IsVoteStart == true ? "True" : "False";
                    // 投票是否自动开始
                    ddlIsVoteAutoStart.SelectedValue = UcSchedule.IsVoteAutoStart == true ? "True" : "False";
                    // 投票是否自动结束
                    ddlIsVoteAutoEnd.SelectedValue = UcSchedule.IsVoteAutoEnd == true ? "True" : "False";
                    // 投票开始时间
                    if (UcSchedule.VoteBeginDate != null)
                    {
                        txtVoteBeginDate.Text = UcSchedule.VoteBeginDate.Value.ToString("yyyy-MM-dd");
                    }
                    // 投票结束时间
                    if (UcSchedule.VoteEndDate != null)
                    {
                        txtVoteEndDate.Text = UcSchedule.VoteEndDate.Value.ToString("yyyy-MM-dd");
                    }

                    // 等票复投 是否开始
                    //cbIsReVoteStart.Checked = UcSchedule.IsReVoteStart ?? false;
                    ddlIsReVoteStart.SelectedValue = (UcSchedule.IsReVoteStart == true ? true : false).ToString();
                    //InitDropDownList(ddlIsReVoteStart, UcSchedule.IsReVoteStart == true);
                #endregion
                }
                else
                {
                    #region
                    string strNow = DateTime.Now.ToString("yyyy-MM-dd");
                    txtDeclarationBeginDate.Text = strNow;
                    txtDeclarationEndDate.Text = strNow;
                    txtPrimaryElectionBeginDate.Text = strNow;
                    txtPrimaryElectionEndDate.Text = strNow;
                    txtExpertReviewBeginDate.Text = strNow;
                    txtExpertReviewEndDate.Text = strNow;
                    txtDownloadBeginDate.Text = strNow;
                    txtDownloadEndDate.Text = strNow;
                    txtVoteBeginDate.Text = strNow;
                    txtVoteEndDate.Text = strNow;

                    ddlIsDeclarationStart.SelectedValue = "False";
                    ddlIsPrimaryElectionStart.SelectedValue = "False";
                    ddlIsExpertReviewStart.SelectedValue = "False";
                    ddlIsDownloadStart.SelectedValue = "False";
                    ddlIsVoteStart.SelectedValue = "False";
                    ddlIsReVoteStart.SelectedValue = "False";

                    // 申报 是否开始
                    //cbIsDeclarationStart.Checked = false;

                    // 申报 是否自动开始
                    ddlIsDeclarationAutoStart.SelectedValue = "False";

                    // 申报 是否自动结束
                    ddlIsDeclarationAutoEnd.SelectedValue = "False";

                    //// 海选 是否开始
                    //cbIsPrimaryElectionStart.Checked = false;

                    //// 海选 是否自动开始
                    ddlIsPrimaryElectionAutoStart.SelectedValue = "False";

                    // 海选 是否自动结束
                    ddlIsPrimaryElectionAutoEnd.SelectedValue = "False";

                    //// 评审 是否开始
                    //cbIsExpertReviewStart.Checked = false;

                    //// 评审 是否自动开始
                    ddlIsExpertReviewAutoStart.SelectedValue = "False";

                    // 评审 是否自动结束
                    ddlIsExpertReviewAutoEnd.SelectedValue = "False";

                    //下载 是否自动开始
                    ddlIsDownloadAutoStart.SelectedValue = "False";

                    // 下载 是否自动结束
                    ddlIsDownloadAutoEnd.SelectedValue = "False";

                    //投票 是否自动开始
                    ddlIsVoteAutoStart.SelectedValue = "False";

                    //投票 是否自动结束
                    ddlIsVoteAutoEnd.SelectedValue = "False";

                    //// 等票复投 是否开始
                    //cbIsReVoteStart.Checked = false;
                    #endregion
                }
            }
            
        }

        public void activityRefresh()
        {
            string strNow = DateTime.Now.ToString("yyyy-MM-dd");
            txtDeclarationBeginDate.Text = strNow;
            txtDeclarationEndDate.Text = strNow;
            txtPrimaryElectionBeginDate.Text = strNow;
            txtPrimaryElectionEndDate.Text = strNow;
            txtExpertReviewBeginDate.Text = strNow;
            txtExpertReviewEndDate.Text = strNow;
            txtDownloadBeginDate.Text = strNow;
            txtDownloadEndDate.Text = strNow;
            txtVoteBeginDate.Text = strNow;
            txtVoteEndDate.Text = strNow;

            ddlIsDeclarationStart.SelectedValue = "False";
            ddlIsPrimaryElectionStart.SelectedValue = "False";
            ddlIsExpertReviewStart.SelectedValue = "False";
            ddlIsDownloadStart.SelectedValue = "False";
            ddlIsVoteStart.SelectedValue = "False";
            ddlIsReVoteStart.SelectedValue = "False";

            // 申报 是否开始
            //cbIsDeclarationStart.Checked = false;

            // 申报 是否自动开始
            ddlIsDeclarationAutoStart.SelectedValue = "False";

            // 申报 是否自动结束
            ddlIsDeclarationAutoEnd.SelectedValue = "False";

            //// 海选 是否开始
            //cbIsPrimaryElectionStart.Checked = false;

            //// 海选 是否自动开始
            ddlIsPrimaryElectionAutoStart.SelectedValue = "False";

            // 海选 是否自动结束
            ddlIsPrimaryElectionAutoEnd.SelectedValue = "False";

            //// 评审 是否开始
            //cbIsExpertReviewStart.Checked = false;

            //// 评审 是否自动开始
            ddlIsExpertReviewAutoStart.SelectedValue = "False";

            // 评审 是否自动结束
            ddlIsExpertReviewAutoEnd.SelectedValue = "False";

            //// 下载 是否开始
            //cbIsDownloadStart.Checked = false;

            //// 下载 是否自动开始
            ddlIsDownloadAutoStart.SelectedValue = "False";

            // 下载 是否自动结束
            ddlIsDownloadAutoEnd.SelectedValue = "False";

            // 投票 是否自动开始
            ddlIsVoteAutoStart.SelectedValue = "False";

            // 投票 是否自动结束
            ddlIsVoteAutoEnd.SelectedValue = "False";
        }

        public void btnSetSchedule_Click(object sender, EventArgs e)
        {
            if (OnSaveSchedule != null)
            {
                OnSaveSchedule(sender, e);
            }
            else
            {
                System.Web.UI.WebControls.HiddenField hdMsg = (System.Web.UI.WebControls.HiddenField)this.Parent.FindControl("hdMsg");
                if ((UcSchedule.ActivityID == null && UcSchedule.SpecialtyID == null)
                    || (UcSchedule.ActivityID != null && UcSchedule.SpecialtyID != null))
                {
                    //throw new Exception("参数设置错误");
                    hdMsg.Value = "参数设置错误!";
                }

                DateTime dt;
                if (!string.IsNullOrEmpty(txtDeclarationBeginDate.Text)
                    && DateTime.TryParse(txtDeclarationBeginDate.Text, out dt))
                {
                    UcSchedule.DeclarationBeginDate = dt;
                }

                if (!string.IsNullOrEmpty(txtDeclarationEndDate.Text)
                    && DateTime.TryParse(txtDeclarationEndDate.Text, out dt))
                {
                    UcSchedule.DeclarationEndDate = dt;
                }

                 //UcSchedule.IsDeclarationStart = cbIsDeclarationStart.Checked;
                UcSchedule.IsDeclarationStart = ddlIsDeclarationStart.SelectedValue == "True";
                 //UcSchedule.IsDeclarationAutoStart = cbIsDeclarationAutoStart.Checked;
                UcSchedule.IsDeclarationAutoStart = ddlIsDeclarationAutoStart.SelectedValue == "True";
                 //UcSchedule.IsDeclarationAutoEnd = cbIsDeclarationAutoEnd.Checked;
                UcSchedule.IsDeclarationAutoEnd = ddlIsDeclarationAutoEnd.SelectedValue == "True"; 

                if (!string.IsNullOrEmpty(txtPrimaryElectionBeginDate.Text)
                    && DateTime.TryParse(txtPrimaryElectionBeginDate.Text, out dt))
                {
                    UcSchedule.PrimaryElectionBeginDate = dt;
                }

                if (!string.IsNullOrEmpty(txtPrimaryElectionEndDate.Text)
                    && DateTime.TryParse(txtPrimaryElectionEndDate.Text, out dt))
                {
                    UcSchedule.PrimaryElectionEndDate = dt;
                }

                UcSchedule.IsPrimaryElectionStart = ddlIsPrimaryElectionStart.SelectedValue == "True";
                //UcSchedule.IsPrimaryElectionStart = cbIsPrimaryElectionStart.Checked;
                UcSchedule.IsPrimaryElectionAutoStart = ddlIsPrimaryElectionAutoStart.SelectedValue == "True";
                 //UcSchedule.IsPrimaryElectionAutoStart = cbIsPrimaryElectionAutoStart.Checked;
                UcSchedule.IsPrimaryElectionAutoEnd = ddlIsPrimaryElectionAutoEnd.SelectedValue == "True";
                 //UcSchedule.IsPrimaryElectionAutoEnd = cbIsPrimaryElectionAutoEnd.Checked;

                if (!string.IsNullOrEmpty(txtExpertReviewBeginDate.Text)
                    && DateTime.TryParse(txtExpertReviewBeginDate.Text, out dt))
                {
                    UcSchedule.ExpertReviewBeginDate = dt;
                }

                if (!string.IsNullOrEmpty(txtExpertReviewEndDate.Text)
                    && DateTime.TryParse(txtExpertReviewEndDate.Text, out dt))
                {
                    UcSchedule.ExpertReviewEndDate = dt;
                }

                UcSchedule.IsExpertReviewStart = ddlIsExpertReviewStart.SelectedValue == "True";
                //UcSchedule.IsExpertReviewStart = cbIsExpertReviewStart.Checked;
                UcSchedule.IsExpertReviewAutoStart = ddlIsExpertReviewAutoStart.SelectedValue == "True";
                  //UcSchedule.IsExpertReviewAutoStart = cbIsExpertReviewAutoStart.Checked;
                UcSchedule.IsExpertReviewAutoEnd = ddlIsExpertReviewAutoEnd.SelectedValue == "True";
                 //UcSchedule.IsExpertReviewAutoEnd = cbIsExpertReviewAutoEnd.Checked;

               

                if (!string.IsNullOrEmpty(txtDownloadBeginDate.Text)
                   && DateTime.TryParse(txtDownloadBeginDate.Text, out dt))
                {
                    UcSchedule.DownloadBeginDate = dt;
                }

                if (!string.IsNullOrEmpty(txtDownloadEndDate.Text)
                    && DateTime.TryParse(txtDownloadEndDate.Text, out dt))
                {
                    UcSchedule.DownloadEndDate = dt;
                }

                UcSchedule.IsDownloadStart = ddlIsDownloadStart.SelectedValue == "True";
                //UcSchedule.IsDownloadStart = cbIsDownloadStart.Checked;
                UcSchedule.IsDownloadAutoStart = ddlIsDownloadAutoStart.SelectedValue == "True";
                //UcSchedule.IsDownloadAutoStart = cbIsDownloadAutoStart.Checked;
                UcSchedule.IsDownloadAutoEnd = ddlIsDownloadAutoEnd.SelectedValue == "True";
                //UcSchedule.IsDownloadAutoEnd = cbIsDownloadAutoEnd.Checked;

                //投票
                if (!string.IsNullOrEmpty(txtVoteBeginDate.Text)
                   && DateTime.TryParse(txtVoteBeginDate.Text, out dt))
                {
                    UcSchedule.VoteBeginDate = dt;
                }
                if (!string.IsNullOrEmpty(txtVoteEndDate.Text)
                    && DateTime.TryParse(txtVoteEndDate.Text, out dt))
                {
                    UcSchedule.VoteEndDate = dt;
                }
                UcSchedule.IsVoteStart = ddlIsVoteStart.SelectedValue == "True";
                UcSchedule.IsVoteAutoStart = ddlIsVoteAutoStart.SelectedValue == "True";
                UcSchedule.IsVoteAutoEnd = ddlIsVoteAutoEnd.SelectedValue == "True";

                UcSchedule.IsReVoteStart = ddlIsReVoteStart.SelectedValue == "True";
                //UcSchedule.IsReVoteStart = cbIsReVoteStart.Checked;

                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();

                OleDbTransaction trans = conn.BeginTransaction();

                try
                {
                    BLL.Schedule.SetSchedule(UcSchedule, conn, trans);
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
}