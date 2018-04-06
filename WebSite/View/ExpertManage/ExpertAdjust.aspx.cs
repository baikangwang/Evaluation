using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;

namespace Evaluation.View.ExpertManage
{
    public partial class ExpertAdjust : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
        }

        protected void btnImport_Click(object sender, EventArgs e)
        {
            //if (FileUpload1.HasFile == false)//HasFile用来检查FileUpload是否有指定文件  
            //{
            //    Response.Write("<script>alert('请您选择Excel文件')</script> ");
            //    return;//当无文件时,返回  
            //}
            //string IsXls = System.IO.Path.GetExtension(FileUpload1.FileName).ToString().ToLower();//System.IO.Path.GetExtension获得文件的扩展名  
            //if (IsXls != ".xls")
            //{
            //    Response.Write("<script>alert('只可以选择Excel文件')</script>");
            //    return;//当选择的不是Excel文件时,返回  
            //}
            //if (!Directory.Exists(Server.MapPath("~/ExcelTemp/")))
            //{
            //    Directory.CreateDirectory(Server.MapPath("~/ExcelTemp/"));
            //}
            //string filename = FileUpload1.FileName;              //获取Execle文件名  DateTime日期函数  
            //string savePath = Server.MapPath("~/ExcelTemp/" + filename);//Server.MapPath 获得虚拟服务器相对路径  
            //FileUpload1.SaveAs(savePath);                        //SaveAs 将上传的文件内容保存在服务器上  
            //DataTable  dt = BLL.Common.ReadExcel(savePath, filename);           //调用自定义方法  
            //DataRow[] dr = dt.Select();            //定义一个DataRow数组  
            //int rowsnum = dt.Rows.Count;
            //if (rowsnum == 0)
            //{
            //    Response.Write("<script>alert('Excel表为空表,无数据!')</script>");   //当Excel表为空时,对用户进行提示  
            //}
            //else
            //{
            //    StringBuilder sbTable = new StringBuilder();
            //    sbTable.Append("<table>");
            //    sbTable.Append("<tr>");
            //    sbTable.Append("<td>用户编号</td>");
            //    sbTable.Append("<td>姓名</td>");
            //    sbTable.Append("<td>性别</td>");
            //    sbTable.Append("<td>证件类别</td>");
            //    sbTable.Append("<td>证件号</td>");
            //    sbTable.Append("<td>职称</td>");
            //    sbTable.Append("<td>专业</td>");
            //    sbTable.Append("<td>工作单位</td>");
            //    sbTable.Append("</tr>");

            //    OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            //    conn.Open();
                
            //    OleDbTransaction trans = conn.BeginTransaction();
            //    try
            //    {
            //        for (int i = 0; i < dr.Length; i++)
            //        {
            //            string UserID = dr[i]["用户编号"].ToString();
            //            string ExpertName = dr[i]["专家姓名"].ToString();
            //            string Gender = dr[i]["性别"].ToString();
            //            string IDType = dr[i]["证件类别"].ToString();
            //            string IDNumber = dr[i]["证件号"].ToString();
            //            string AcademicTitle = dr[i]["职称"].ToString();
            //            string Profession = dr[i]["专业"].ToString();
            //            string Workplace = dr[i]["工作单位"].ToString();
            //            string Email = dr[i]["电子邮件"].ToString();

            //            sbTable.Append("<tr>");
            //            sbTable.AppendFormat("<td><input type='text' value='{0}' /></td>", UserID);
            //            sbTable.AppendFormat("<td><input type='text' value='{0}' /></td>", ExpertName);
            //            sbTable.AppendFormat("<td><input type='text' value='{0}' /></td>", IDType);
            //            sbTable.AppendFormat("<td><input type='text' value='{0}' /></td>", IDNumber);
            //            sbTable.AppendFormat("<td><input type='text' value='{0}' /></td>", AcademicTitle);
            //            sbTable.AppendFormat("<td><input type='text' value='{0}' /></td>", Profession);
            //            sbTable.AppendFormat("<td><input type='text' value='{0}' /></td>", Workplace);
            //            sbTable.Append("</tr>");
            //            Dal.Models.Expert expert = new Dal.Models.Expert();
            //            expert.UserID = Convert.ToInt32(UserID);
            //            expert.ExpertName = ExpertName;
            //            expert.IDType = IDType;
            //            expert.IDNumber = IDNumber;
            //            expert.AcademicTitle = AcademicTitle;
            //            expert.Profession = Profession;
            //            expert.Workplace = Workplace;
            //            expert.CreateTime = DateTime.Now;
            //            Dal.Models.UserInfo userinfo = new Dal.Models.UserInfo();
            //            BLL.Expert.CreateExpert(expert,userinfo, 1, conn, trans);
            //        }

            //        trans.Commit();
            //    }
            //    catch
            //    {
            //        trans.Rollback();
            //    }

            //    conn.Close();

            //    sbTable.Append("</table>");
            //    Literal1.Text = sbTable.ToString();
            //    hdMsg.Value = "Excle表导入成功!";
            //}
        }
    }
}