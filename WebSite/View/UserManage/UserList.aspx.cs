using NPOI.HSSF.UserModel;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Evaluation.View.UserManage
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            if (!IsPostBack)
            {
                InitPage();
            }
        }
        private void InitPage()
        {
            Dal.Models.UserInfo user = ((Dal.Models.UserInfo)Session["UserInfo"]);
        }

        protected void btnExportUserExcel_Click(object sender, EventArgs e)
        {
            string userIDs = checkedUserID.Value;
            userIDs = userIDs.Substring(0,userIDs.Length-1);
            //Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            DataTable dtUser = Dal.DataTableExtensions.ToDataTable(BLL.User.GetUserListByUserID(userIDs, conn));
            string TempletFileName = Server.MapPath("~/Content/Template/用户模版.xls");      //模板文件  
            string ReportFileName = Server.MapPath("~/Content/Temp/ExcelTemp/用户信息.xls");    //导出文件  
            FileStream file = null;
            try
            {
                file = new FileStream(TempletFileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception)
            {
                hdMsg.Value = "模板文件不存在或正在打开!";
                //Response.Write("<script>alert('模板文件不存在或正在打开');</script>");
                return;
            }
            HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
            HSSFSheet ws = (HSSFSheet)hssfworkbook.GetSheet("Sheet1");
            if (ws == null)//工作薄中没有工作表
            {
                hdMsg.Value = "工作薄中没有Sheet1工作表!";
                //Response.Write("<script>alert('工作薄中没有Sheet1工作表');</script>");
                return;
            }

            int count = dtUser.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    int _row = i + 1; //i + 1;
                    HSSFRow row = (HSSFRow)ws.CreateRow(_row);
                    row.CreateCell(0).SetCellValue(i + 1);
                    row.CreateCell(1).SetCellValue(dtUser.Rows[i]["UserName"].ToString());
                    row.CreateCell(2).SetCellValue(BLL.SysConstant.GetConstant(dtUser.Rows[i]["UserType"].ToString()).ConstantValue);
                    row.CreateCell(3).SetCellValue(BLL.SysConstant.GetConstant(dtUser.Rows[i]["UserStatus"].ToString()).ConstantValue);
                    row.CreateCell(4).SetCellValue(dtUser.Rows[i]["Email"].ToString());
                    if (dtUser.Rows[i]["CreateUser"] != null && dtUser.Rows[i]["CreateUser"].ToString() != "")
                    {
                        Dal.Models.UserInfo user = BLL.User.GetUserInfo(Convert.ToInt32(dtUser.Rows[i]["CreateUser"].ToString()), conn);
                        if (user != null)
                        {
                            row.CreateCell(5).SetCellValue(user.UserName.ToString());
                        }
                    }
                    row.CreateCell(6).SetCellValue(dtUser.Rows[i]["CreateTime"].ToString());
                }
            }
            ws.ForceFormulaRecalculation = true;

            //先删除上一个临时文件
            if (File.Exists(ReportFileName))
            {
                FileInfo fi = new FileInfo(ReportFileName);
                if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                    fi.Attributes = FileAttributes.Normal;
                File.Delete(ReportFileName);
            }

            //创建临时文件写入数据
            using (FileStream filess = File.OpenWrite(ReportFileName))
            {
                hssfworkbook.Write(filess);
            }
            System.IO.FileInfo filet = new System.IO.FileInfo(ReportFileName);
            Response.Clear();
            Response.Charset = "GB2312";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AddHeader("Content-Disposition", "attachment; filename=" + Server.UrlEncode("用户信息.xls"));
            Response.AddHeader("Content-Length", filet.Length.ToString());
            Response.ContentType = "application/ms-excel";
            Response.WriteFile(filet.FullName);
            Response.End();

            conn.Close();
        }

        /// <summary>
        /// 导出全部用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnExportAll_Click(object sender, EventArgs e)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            string strUserName = tbxUserName.Text.Trim();
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            DataTable dtUser = Dal.DataTableExtensions.ToDataTable(BLL.User.GetManagerList(user, strUserName, conn));//BLL.User.GetUserList(user.UserID.Value, conn)
            string TempletFileName = Server.MapPath("~/Content/Template/用户模版.xls");      //模板文件  
            string ReportFileName = Server.MapPath("~/Content/Temp/ExcelTemp/用户信息.xls");    //导出文件  
            FileStream file = null;
            try
            {
                file = new FileStream(TempletFileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception)
            {
                hdMsg.Value = "模板文件不存在或正在打开!";
                //Response.Write("<script>alert('模板文件不存在或正在打开');</script>");
                return;
            }
            HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
            HSSFSheet ws = (HSSFSheet)hssfworkbook.GetSheet("Sheet1");
            if (ws == null)//工作薄中没有工作表
            {
                hdMsg.Value = "工作薄中没有Sheet1工作表!";
                //Response.Write("<script>alert('工作薄中没有Sheet1工作表');</script>");
                return;
            }

            int count = dtUser.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    int _row = i + 1; //i + 1;
                    HSSFRow row = (HSSFRow)ws.CreateRow(_row);
                    row.CreateCell(0).SetCellValue(i + 1);
                    row.CreateCell(1).SetCellValue(dtUser.Rows[i]["UserName"].ToString());
                    row.CreateCell(2).SetCellValue(BLL.SysConstant.GetConstant(dtUser.Rows[i]["UserType"].ToString()).ConstantValue);
                    row.CreateCell(3).SetCellValue(BLL.SysConstant.GetConstant(dtUser.Rows[i]["UserStatus"].ToString()).ConstantValue);
                    row.CreateCell(4).SetCellValue(dtUser.Rows[i]["Email"].ToString());
                    if (dtUser.Rows[i]["CreateUser"] != null && dtUser.Rows[i]["CreateUser"].ToString() != "")
                    {
                        Dal.Models.UserInfo userInfo = BLL.User.GetUserInfo(Convert.ToInt32(dtUser.Rows[i]["CreateUser"].ToString()), conn);
                        if (userInfo != null)
                        {
                            row.CreateCell(5).SetCellValue(userInfo.UserName.ToString());
                        }
                        //row.CreateCell(5).SetCellValue(BLL.User.GetUserInfo(Convert.ToInt32(dtUser.Rows[i]["CreateUser"].ToString()), conn).UserName.ToString());
                    }
                    row.CreateCell(6).SetCellValue(dtUser.Rows[i]["CreateTime"].ToString());
                }
            }
            ws.ForceFormulaRecalculation = true;

            //先删除上一个临时文件
            if (File.Exists(ReportFileName))
            {
                FileInfo fi = new FileInfo(ReportFileName);
                if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                    fi.Attributes = FileAttributes.Normal;
                File.Delete(ReportFileName);
            }

            //创建临时文件写入数据
            using (FileStream filess = File.OpenWrite(ReportFileName))
            {
                hssfworkbook.Write(filess);
            }
            System.IO.FileInfo filet = new System.IO.FileInfo(ReportFileName);
            Response.Clear();
            Response.Charset = "GB2312";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AddHeader("Content-Disposition", "attachment; filename=" + Server.UrlEncode("用户信息.xls"));
            Response.AddHeader("Content-Length", filet.Length.ToString());
            Response.ContentType = "application/ms-excel";
            Response.WriteFile(filet.FullName);
            Response.End();

            conn.Close();
        }
    }
}