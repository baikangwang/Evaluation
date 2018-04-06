using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Evaluation.View.UserManage
{
    public partial class LeaguerUser : System.Web.UI.Page
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
                int userID = Request["xid"] == null ? 0 : Convert.ToInt32(Request["xid"]);
                if (userID == 0)
                {
                    btnEditUser.Visible = false;
                }
                else
                {
                    //int id = Convert.ToInt32(Request["id"]);
                    InitPage(userID);
                }
            }
        }

        public void InitPage(int id)
        {
            btnCreateUser.Visible = false;
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            Dal.Models.Organization organization = BLL.Organization.GetOrganizationByUser(id, conn);
            if (organization != null)
            {
                txtOrganizationID.Value = organization.OrganizationID.ToString();
                txtOrganizationName.Text = organization.OrganizationName;
                txtOrganizationCode.Text = organization.OrganizationCode;
                txtOrganizationAddress.Text = organization.OrganizationAddress;
                txtLegalPersonName.Text = organization.LegalPersonName;
                txtLegalPersonIDNo.Text = organization.LegalPersonIDNo;
                txtLinkman.Text = organization.Linkman;
                txtTelephoneNumber.Text = organization.TelephoneNumber;
                txtMobileNumber.Text = organization.MobileNumber;
                txtEmailAddress.Text = organization.EmailAddress;
                txtPostcode.Text = organization.Postcode;
                txtFaxNumber.Text = organization.FaxNumber;
                txtUserName.Text = organization.UserName;

                //txtUserName.Enabled = false;
                //txtOrganizationCode.Enabled = false;
                txtOrganizationName.Enabled = false;
            }
            conn.Close();
        }

        public void btnEditUser_click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            Dal.Models.Organization organization = BLL.Organization.GetOrganization(Convert.ToInt32(txtOrganizationID.Value.Trim()), conn);
            organization.OrganizationName = txtOrganizationName.Text.Trim();
            organization.OrganizationCode = txtOrganizationCode.Text.Trim();
            organization.OrganizationAddress = txtOrganizationAddress.Text.Trim();
            organization.LegalPersonName = txtLegalPersonName.Text.Trim();
            organization.UserName = txtUserName.Text.Trim();
            organization.LegalPersonIDNo = txtLegalPersonIDNo.Text.Trim();
            organization.Linkman = txtLinkman.Text.Trim();
            organization.TelephoneNumber = txtTelephoneNumber.Text.Trim();
            organization.MobileNumber = txtMobileNumber.Text.Trim();
            organization.EmailAddress = txtEmailAddress.Text.Trim();
            organization.Postcode = txtPostcode.Text.Trim();
            organization.FaxNumber = txtFaxNumber.Text.Trim();

            if (!string.IsNullOrEmpty(organization.LegalPersonIDNo)
                && !BLL.IDOperation.CheckIDCard18(organization.LegalPersonIDNo))
            {
                hdMsg.Value = "法人身份证号错误，请重新核对!";
                conn.Close();
                return;
            }

            OleDbTransaction tran = conn.BeginTransaction();

            try
            {
                BLL.Organization.UpdateOrganization(organization, conn, tran);
                tran.Commit();
                hdMsg.Value = "修改成功!";
            }
            catch (Exception ex)
            {
                hdMsg.Value = ex.Message;
                tran.Rollback();
            }
            conn.Close();
        }

        public void btnCreateUser_click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            Dal.Models.UserInfo CreateUser = (Dal.Models.UserInfo)Session["UserInfo"];
            Dal.Models.Organization organization = new Dal.Models.Organization();
            organization.OrganizationName = txtOrganizationName.Text.Trim();
            organization.Password = BLL.SysConstant.GetAppSettings("DefaultPassword", conn);
            organization.OrganizationCode = txtOrganizationCode.Text.Trim();
            organization.OrganizationAddress = txtOrganizationAddress.Text.Trim();
            organization.LegalPersonName = txtLegalPersonName.Text.Trim();
            organization.UserName = txtUserName.Text.Trim();
            organization.Linkman = txtLinkman.Text.Trim();
            organization.TelephoneNumber = txtTelephoneNumber.Text.Trim();
            organization.MobileNumber = txtMobileNumber.Text.Trim();
            organization.EmailAddress = txtEmailAddress.Text.Trim();
            organization.Postcode = txtPostcode.Text.Trim();
            organization.FaxNumber = txtFaxNumber.Text.Trim();

            if (!string.IsNullOrEmpty(organization.LegalPersonIDNo)
                && !BLL.IDOperation.CheckIDCard18(organization.LegalPersonIDNo))
            {
                hdMsg.Value = "法人身份证号错误，请重新核对!";
                conn.Close();
                return;
            }

            OleDbTransaction tran = conn.BeginTransaction();

            try
            {
                BLL.Organization.CreateOrganization(organization, CreateUser.UserID.Value, conn, tran);
                tran.Commit();
                hdMsg.Value = "添加成功!";
            }
            catch (Exception ex)
            {
                hdMsg.Value = ex.Message;
                tran.Rollback();
            }

            conn.Close();
            conn.Dispose();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/view/UserManage/LeaguerUserList.aspx");
        }
    }
}