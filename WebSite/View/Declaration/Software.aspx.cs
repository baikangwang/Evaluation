﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class Software : System.Web.UI.Page
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
                //根据当前模板状态显示部件
                //Dal.Models.TemplateInfo tempInfo = (Dal.Models.TemplateInfo)Session["TemplateInfo"];
                Dal.Models.TemplateInfo tempInfo = null;
                try
                {
                    tempInfo = ((Declaration)Context.Handler).TempInfo;
                }
                catch
                {
                    Response.Redirect("../Mutual/UserEntry.aspx");
                }
                if (tempInfo == null)
                {
                    Response.Redirect("../Mutual/UserEntry.aspx");
                }

                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();

                //显示模板的当前编辑部分
                //divfather.FindControl(tempInfo.Anchor).Visible = true;
                Dal.Models.Template_16_Software tempSoftware =
                    BLL.Declaration.GetDeclarationData<Dal.Models.Template_16_Software>(tempInfo.DeclarationID.Value, conn);
                Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(tempInfo.DeclarationID.Value, conn);

                SetDropDownList(DevelopmentModel, BLL.SysConstant.GetConstantList("25", conn));
                SetDropDownList(SoftwareCategory, BLL.SysConstant.GetConstantList("26", conn));
                SetDropDownList(SecurityLevel, BLL.SysConstant.GetConstantList("27", conn));
                //为控件赋值
                BLL.Common.SetData<Dal.Models.Template_16_Software>(tempSoftware, divfather);

                // 设置参与人员
                ucParticipant.ParticipantList = BLL.Declaration.GetParticipant(tempInfo.DeclarationID.Value, conn);

                Dal.Models.Organization org = BLL.Organization.GetOrganization(decl.OrganizationID.Value, conn);

                DeclarationName.Text = decl.DeclarationName;
                DeclarationUnit.Text = org.OrganizationName;
                PostalAddress.Text = org.OrganizationAddress;
                Linkman.Text = org.Linkman;
                TelephoneNumber.Text = org.TelephoneNumber;
                FaxNumber.Text = org.FaxNumber;
                MobileNumber.Text = org.MobileNumber;
                Postcode.Text = org.Postcode;
                EmailAddress.Text = org.EmailAddress; ;//org.EmailAddress
                txtDeclarationID.Text = decl.DeclarationID.ToString();
                txtTemplate.Text = tempInfo.TemplateCode;

                ucLegalStates.Org = org;
                ucLegalStates.Decl = decl;
                ucCertificate.Org = org;
                ucCertificate.Decl = decl;
                ucParticipant.Org = org;
                ucParticipant.Decl = decl;
                ucComments.Org = org;
                ucComments.Decl = decl;
                //接受登录人员
                Dal.Models.UserInfo userInfo = (Dal.Models.UserInfo)Session["UserInfo"];
                txtUser.Text = userInfo.UserType;

                //接受场景
                if (!string.IsNullOrEmpty(tempInfo.Situation.ToString()))
                {
                    txtSituation.Text = tempInfo.Situation.ToString();
                }

                if (tempInfo.Situation.ToString() == "Declara")
                {
                    string strActivityType = Session["ActivityType"].ToString();

                    // 获取指定活动类型的当前激活活动
                    Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn);
                    if (actActivated == null)
                    {
                        conn.Close();
                        Response.Redirect("../Mutual/UserEntry.aspx");
                        return;
                    }

                    int iActivity = actActivated.ActivityID.Value;
                    string strSpecialty = decl.DeclarationCode.Substring(4, 6);
                    Dal.Models.Specialty dSpecialty = BLL.Specialty.GetSpecialtyByCode(strSpecialty, iActivity, conn);
                    conn.Close();
                    nav02.InnerText = dSpecialty.SpecialtyName;
                }
            }
        }
        public void SetDropDownList(DropDownList drop, List<Dal.Models.SysConstant> lst)
        {
            drop.DataSource = lst;
            drop.DataTextField = "ConstantValue";
            drop.DataValueField = "ConstantCode";
            drop.DataBind();
        }
    }
}