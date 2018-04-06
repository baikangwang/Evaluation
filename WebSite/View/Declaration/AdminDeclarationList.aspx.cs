﻿using System;
using System.Data.OleDb;

namespace Evaluation.View.Declaration
{
    public partial class AdminDeclarationList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strActivityType =Session["ActivityType"].ToString();
            Dal.Models.Activity act = BLL.Activity.GetActivity(strActivityType, conn);
            if (act == null)
            {
                hdMsg.Value = "当前没有已经激活的申报活动。";
            }
            else
            {
                Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
                txtUser.Text = user.UserType;
                try
                {
                    txtLastUpdateTime.Text = BLL.Schedule.GetActivitySchedule(Convert.ToInt32(act.ActivityID), conn).DeclarationEndDate.ToString();
                }
                catch
                {
                    txtLastUpdateTime.Text = DateTime.Now.ToString();
                }
                string id = Request["DeclarationID"];
                string Img = Request["UploadFileID"];

                if (user.UserType == "0806" || user.UserType == "0807")
                {
                    txtDeclarationUnit.Visible = false;
                    txtUserType.Text = "会员";
                }

                //奖项绑值
                ddlPrizeName.DataSource = BLL.Prize.GetPrizeList(user, strActivityType, "", conn);
                ddlPrizeName.DataValueField = "PrizeID";
                ddlPrizeName.DataTextField = "PrizeName";
                ddlPrizeName.DataBind();

                //申报状态绑值
                ddlDeclarationStatus.DataSource = BLL.SysConstant.GetConstantList("18", conn);
                ddlDeclarationStatus.DataValueField = "ConstantCode";
                ddlDeclarationStatus.DataTextField = "ConstantValue";
                ddlDeclarationStatus.DataBind();
                ddlDeclarationStatus.Items.Remove(ddlDeclarationStatus.Items.FindByValue("1805"));
                ddlDeclarationStatus.Items.Remove(ddlDeclarationStatus.Items.FindByValue("1806"));
            }
            conn.Close();
        }
    }
}