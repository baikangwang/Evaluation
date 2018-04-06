using BLL;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Privilege
{
    public partial class CreatePrivilege : System.Web.UI.Page
    {
        Prlvilege p = new Prlvilege();
        int PrivilegeID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            PrivilegeID = Request["PrivilegeID"] == null ? 0 : Convert.ToInt32(Request["PrivilegeID"]);
            if (!IsPostBack)
            {
                if (PrivilegeID > 0)
                {
                    InitPage(PrivilegeID);
                    btnAddUser.Visible = false;
                }
                else
                {
                    btnUpdateUser.Visible = false;
                }
            }
        }
        public void InitPage(int PrivilegeID)
        {
            DataTable dt = p.GetPrivilegeTableByID(PrivilegeID);
            PrivilegeName.Text = dt.Rows[0][1].ToString();
        }

        public void UpdatePrivilege()
        {

            if (PrivilegeName.Text == "" || PrivilegeName.Text == null)
                hdMsg.Value = "文本框为空";
            else
            {
                UserGroup ug = new UserGroup();
                ug.GroupID = PrivilegeID;
                ug.GroupName = PrivilegeName.Text;
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                string Msg = p.UpdataPrivilege(ug, conn);
                conn.Close();
                conn.Dispose();
                hdMsg.Value = Msg;
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            UpdatePrivilege();
        }

        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            if (PrivilegeName.Text == "" || PrivilegeName.Text == null)
                hdMsg.Value = "文本框为空";
            else
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                string Msg = p.CreatePrivilege(PrivilegeName.Text, conn);
                conn.Close();
                conn.Dispose();
                hdMsg.Value = Msg;
            }
        }
    }
}