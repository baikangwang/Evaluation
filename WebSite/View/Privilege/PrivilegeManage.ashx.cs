using BLL;
using Dal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Evaluation.View.Privilege
{
    /// <summary>
    /// PrivilegeManage 的摘要说明
    /// </summary>
    public class PrivilegeManage : IHttpHandler
    {

        Prlvilege p = new Prlvilege();
        public void ProcessRequest(HttpContext context)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            context.Response.ContentType = "text/plain";
            string strAction = context.Request["Action"];
            if (!string.IsNullOrEmpty(strAction))
            {
                switch (strAction)
                {
                    case "GetPrivilegeList":
                        GetPrivilegeList(context, conn);
                        break;
                    case "CreatePrivilege":
                        CreatePrivilege(context, conn);
                        break;
                    case "MultiselectDelPrivilege":
                        MultiselectDelPrivilege(context, conn);
                        break;
                    case "DelPrivilege":
                        DelPrivilege(context, conn);
                        break;
                    case "UpdatePrivilege":
                        UpdatePrivilege(context, conn);
                        break;
                    case "GetControlsList":
                        GetControlsList(context, conn);
                        break;
                    default:
                        break;
                }
            }
            conn.Close();
            conn.Dispose();
        }

        private void GetControlsList(HttpContext context, OleDbConnection conn)
        {
            string List = p.GetControlsList(context, conn);
            context.Response.Write(List);
        }



        private void UpdatePrivilege(HttpContext context, OleDbConnection conn)
        {

            UserGroup ug = new UserGroup();
            ug.GroupID = int.Parse(context.Request["PrivilegeID"]);
            ug.GroupName = context.Request["PrivilegeName"];
            string Msg = p.UpdataPrivilege(ug, conn);
            context.Response.Write(Msg);
        }

        private void DelPrivilege(HttpContext context, OleDbConnection conn)
        {
            int PrivilegeID = Convert.ToInt32(context.Request["PrivilegeID"]);
            OleDbTransaction trans = null;
            string Msg = p.DeletePrivilege(PrivilegeID, conn, trans);
            context.Response.Write(Msg);
        }

        private void MultiselectDelPrivilege(HttpContext context, OleDbConnection conn)
        {
            string PrivilegeID = context.Request["PrivilegeID"];
            string[] arrayPrivilegeID = PrivilegeID.Split(',');
            List<int> listPrivilegeID = new List<int>();
            foreach (var item in arrayPrivilegeID)
            {
                listPrivilegeID.Add(Convert.ToInt32(item));
            }
            string Msg = p.MultiselectDelPrivilege(listPrivilegeID, conn);
            context.Response.Write(Msg);

        }

        private void CreatePrivilege(HttpContext context, OleDbConnection conn)
        {

            string PrivilegeName = context.Request["PrivilegeName"];
            if (PrivilegeName == "" || PrivilegeName == null)
                context.Response.Write("权限名称未输入");
            else
            {
                string Msg = p.CreatePrivilege(PrivilegeName, conn);
                context.Response.Write(Msg);
            }

        }

        private void GetPrivilegeList(HttpContext context, OleDbConnection conn)
        {
            string f = p.GetPrivilegeList(context, conn);
            context.Response.Write(f);

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}