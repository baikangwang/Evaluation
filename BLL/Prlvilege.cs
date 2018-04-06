using Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Dal.Models;
namespace BLL
{
    public class Prlvilege
    {
        int eQuery = 0;
        public List<UserGroup> GetPrivilege(OleDbConnection conn)
        {
            string strSql = "select * from UserGroup";
            List<UserGroup> lstUser = OleDbHlper.GetList<UserGroup>(strSql, conn);
            return lstUser;
        }
        public List<Control> GetControl(OleDbConnection conn, string GroupID)
        {
           
            string strSql = "select *  from Control inner join Page on Page.PageID= Control.PageID ";
            List<Control> lstControl = OleDbHlper.GetList<Control>(strSql, conn);
            OleDbTransaction trans = conn.BeginTransaction();
            string strsql = "select Control.ControlID,Details  from Control inner join Page on Page.PageID= Control.PageID inner join ControlsByGroup on ControlsByGroup.GroupID=? and Control.ControlID=ControlsByGroup.ControlID";
            List<Control> lstCheck = OleDbHlper.GetList<Control>(strsql, conn, CommandType.Text, trans,
                   new OleDbParameter("@GroupID", OleDbType.VarWChar) { Value = GroupID });
            for (int i = 0; i < lstCheck.Count; i++)
            {
                for (int j = 0; j < lstControl.Count; j++)
                {
                    if (lstControl[j].ControlID == lstCheck[i].ControlID)
                        lstControl[j].Details = lstCheck[i].Details;
                }
            }
            return lstControl;
        }
        public string GetPrivilegeList(HttpContext context, OleDbConnection conn)
        {
            string strUserName = context.Request["UserName"];
            PageInfo<UserGroup> pgif = new PageInfo<UserGroup>();
            List<UserGroup> lstUser = GetPrivilege(conn);
            if (lstUser == null)
            {
                pgif.CuttentPage = 1;
                pgif.PerPage = 10;
                pgif.RecordNumber = 0;
                pgif.PagesCount = 0;
                pgif.Table = null;
                return JsonConvert.SerializeObject(pgif);
            }
            else
            {
                int iPageSize = 10;
                if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
                {
                    iPageSize = 10;
                }
                int iCuttentPage = 1;
                if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
                {
                    iCuttentPage = 1;
                }
                int iRecordNumber = lstUser.Count;
                int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
                lstUser = lstUser.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();
                DataTable dtuserlist = Dal.DataTableExtensions.ToDataTable(lstUser);
                pgif.CuttentPage = iCuttentPage;
                pgif.PerPage = iPageSize;
                pgif.RecordNumber = iRecordNumber;
                pgif.PagesCount = iPagesCount;
                pgif.Table = dtuserlist;
                string strJson = JsonConvert.SerializeObject(pgif);
                return strJson;
            }
        }
        public string CreatePrivilege(string PrivilegeName, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            string strSql = "insert into UserGroup values(?)";
            try
            {
                eQuery = OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans,
                   new OleDbParameter("@PrivilegeName", OleDbType.VarWChar) { Value = PrivilegeName });
                trans.Commit();
                return "添加成功！";
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return ex.ToString();
            }

        }
        public string MultiselectDelPrivilege(List<int> listPrivilegeID, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            for (int i = 0; i < listPrivilegeID.Count(); i++)
            {
                int PrivilegeID = Convert.ToInt32(listPrivilegeID[i]);
                string strSql = "delete from UserGroup where GroupID=?";
                try
                {
                    OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans,
                new OleDbParameter("@GroupID", OleDbType.Integer) { Value = PrivilegeID });
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return (ex.Message);
                }
            }
            trans.Commit();
            return "删除成功！";
        }
        public string DeletePrivilege(int PrivilegeID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            trans = conn.BeginTransaction();
            try
            {
                string strSql = "delete from UserGroup where GroupID=?";
                eQuery = OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans,
                   new OleDbParameter("@GroupID", OleDbType.Integer) { Value = PrivilegeID });
                trans.Commit();
                return "添加成功！";
            }
            catch (Exception)
            {

                trans.Rollback();
                return "失败";
            }
        }
        public string UpdataPrivilege(UserGroup ug, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            string strSql = "update UserGroup set GroupName=? where GroupID=?";
            try
            {
                eQuery = OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans,
                   new OleDbParameter("@GroupName", OleDbType.VarWChar) { Value = ug.GroupName },
                   new OleDbParameter("@GroupID", OleDbType.Integer) { Value = ug.GroupID });
                trans.Commit();
                return "修改成功！";
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return ex.ToString();
            }
        }
        public DataTable GetPrivilegeTableByID(int id)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            OleDbTransaction trans = conn.BeginTransaction();
            string strSql = "select * from UserGroup where GroupID=?";
            DataTable dt = OleDbHlper.GetDataTable(strSql, conn, CommandType.Text, trans,
                   new OleDbParameter("@GroupID", OleDbType.Integer) { Value = id });
            conn.Close();
            conn.Dispose();
            return dt;
        }
        public string GetControlsList(HttpContext context, OleDbConnection conn)
        {
            string GroupID = context.Request["GroupID"];
            PageInfo<Control> pgif = new PageInfo<Control>();
            List<Control> lstUser = GetControl(conn, GroupID); ;
            if (lstUser == null)
            {
                pgif.CuttentPage = 1;
                pgif.PerPage = 10;
                pgif.RecordNumber = 0;
                pgif.PagesCount = 0;
                pgif.Table = null;
                return JsonConvert.SerializeObject(pgif);
            }
            else
            {
                int iPageSize = 10;
                if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
                {
                    iPageSize = 10;
                }
                int iCuttentPage = 1;
                if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
                {
                    iCuttentPage = 1;
                }
                int iRecordNumber = lstUser.Count;
                int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
                lstUser = lstUser.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();
                DataTable dtuserlist = Dal.DataTableExtensions.ToDataTable(lstUser);
                pgif.CuttentPage = iCuttentPage;
                pgif.PerPage = iPageSize;
                pgif.RecordNumber = iRecordNumber;
                pgif.PagesCount = iPagesCount;
                pgif.Table = dtuserlist;
                string strJson = JsonConvert.SerializeObject(pgif);
                return strJson;
            }
        }
    }
}
