using Newtonsoft.Json;
using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace Evaluation.View.ExpertManage
{
    public partial class ExpertImport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            if (user == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn);
            if (actActivated == null)
            {
                Response.Redirect("../Mutual/HomePage.aspx");
                return;
            }
            //if (!IsPostBack)
            //{
            //    ddlSpecialty.DataSource = BLL.Specialty.GetSpecialtyListByUserType(actActivated.ActivityID.Value, user.UserType, user.UserID.Value, true, conn);
            //    ddlSpecialty.DataTextField = "SpecialtyName";
            //    ddlSpecialty.DataValueField = "SpecialtyID";
            //    ddlSpecialty.DataBind();
            //}

            conn.Close();
            conn.Dispose();
        }

        protected void lkbImport_Click(object sender, EventArgs e)
        {

            //Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];

            //if (fuExpert.HasFile == false)//HasFile用来检查FileUpload是否有指定文件  
            //{
            //    hdMsg.Value = "请选择要上传的文件!";
            //    return;//当无文件时,返回  
            //}
            //string IsXls = System.IO.Path.GetExtension(fuExpert.FileName).ToString().ToLower();//System.IO.Path.GetExtension获得文件的扩展名  
            //if (IsXls != ".xls")
            //{
            //    hdMsg.Value = "只可以选择Excel文件!";
            //    //Response.Write("<script>alert('只可以选择Excel文件')</script>");
            //    return;//当选择的不是Excel文件时,返回  
            //}
            //if (!Directory.Exists(Server.MapPath("~/Content/Temp/ExcelTemp/")))
            //{
            //    Directory.CreateDirectory(Server.MapPath("~/Content/Temp/ExcelTemp/"));
            //}
            //string filename = fuExpert.FileName;              //获取Execle文件名  DateTime日期函数  
            //string strTempPath = Server.MapPath("~/Content/Temp/ExcelTemp/" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + filename);//Server.MapPath 获得虚拟服务器相对路径  
            //fuExpert.SaveAs(strTempPath);                        //SaveAs 将上传的文件内容保存在服务器上  
            //DataTable dt = BLL.Common.ReadExcel(strTempPath, filename);           //调用自定义方法  
            //if (dt.Rows.Count == 0)
            //{
            //    //Response.Write("<script>alert('Excel表为空表,无数据!')</script>");   //当Excel表为空时,对用户进行提示  
            //    hdMsg.Value = "Excel表为空表,无数据!";
            //}
            //else
            //{
            //    OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            //    conn.Open();
            //    string strActivityType = Request.Cookies["ActivityType"].Value;
            //    Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            //    if (activity == null)
            //    {
            //        hdMsg.Value = "当前活动已关闭，请联系活动管理人员！";
            //        return;
            //    }

            //    Dal.Models.Expert expert = null;
            //    List<Dal.Models.Expert> lstExpert = new List<Dal.Models.Expert>();
            //    List<KeyValuePair<string, Dal.Models.Expert>> lstError = new List<KeyValuePair<string, Dal.Models.Expert>>();
            //    //int? iSpecialtyID;


            //    OleDbTransaction trans = conn.BeginTransaction();
            //    foreach (DataRow row in dt.Rows)
            //    {
            //        if (!string.IsNullOrEmpty(row["姓名"].ToString()))
            //        {
            //            expert = new Dal.Models.Expert();
            //            expert.ExpertName = row["姓名"].ToString();
            //            expert.Gender = row["性别"].ToString();
            //            List<Dal.Models.SysConstant> constant = BLL.SysConstant.GetConstantList("09", conn, trans);
            //            constant = constant.Where(c => c.ConstantValue == row["证件类别"].ToString() || c.ConstantCode == row["证件类别"].ToString()).ToList();
            //            if (constant != null && constant.Count > 0)
            //            {
            //                expert.IDType = constant[0].ConstantCode;
            //            }
            //            else
            //            {
            //                hdMsg.Value = "证件类别错误！";
            //                return;
            //            }

            //            if (expert.IDType == "0901")
            //            {
            //                string cardID = row["证件号码"].ToString();
            //                bool checkedIDCard = BLL.IDOperation.CheckIDCard18(cardID);
            //                if (checkedIDCard)
            //                {
            //                    expert.IDNumber = row["证件号码"].ToString();
            //                }
            //                else
            //                {
            //                    hdMsg.Value = "身份证号码错误，请重新核对！";
            //                    return;
            //                }
            //            }
            //            else
            //            {
            //                expert.IDNumber = row["证件号码"].ToString();
            //            }
            //            expert.AcademicTitle = row["职称"].ToString();
            //            expert.Profession = row["专业"].ToString();
            //            expert.Workplace = row["工作单位"].ToString();
            //            //string strSpecialty = row["评优专业"].ToString();

            //            try
            //            {
            //                Dal.Models.UserInfo userinfo = new Dal.Models.UserInfo();
            //                BLL.Expert.CreateExpert(expert, userinfo, user.UserID.Value, conn, trans);
            //                expert = BLL.Expert.GetExpert(expert.IDType, expert.IDNumber, conn, trans);
            //                #region
            //                //string[] arrSpecialty = strSpecialty.Split(",".ToCharArray());
            //                //foreach (string str in arrSpecialty)
            //                //{
            //                //    iSpecialtyID = BLL.Specialty.GetIDByName(str, activity.ActivityID.Value, conn, trans);
            //                //    if ((iSpecialtyID ?? 0) != 0)
            //                //    {
            //                //        BLL.User.SetUserSpecialty(expert.UserID.Value, activity.ActivityID.Value, conn, trans, iSpecialtyID.Value);
            //                //    }
            //                //    else
            //                //    {
            //                //        throw new Exception("专业不存在") { Source = str};
            //                //    }
            //                //}
            //                #endregion
            //                lstExpert.Add(BLL.Expert.GetExpert(expert.IDType, expert.IDNumber, conn, trans));
            //                hdMsg.Value = "导入成功!";
            //                trans.Commit();
            //            }
            //            catch (Exception ex)
            //            {
            //                lstError.Add(new KeyValuePair<string, Dal.Models.Expert>(ex.Message, expert));
            //                //Response.Write("<script>alert('导入失败!')</script>");
            //                hdMsg.Value = "导入失败：" + ex.Message;
            //                trans.Rollback();
            //                conn.Close();
            //                return;
            //            }
            //        }
            //    }
            //    conn.Close();
            //}
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            FileStream file = null;
            string TempletFileName = Server.MapPath("~/Content/Template/专家.xls");      //模板文件  
            string ReportFileName = Server.MapPath("~/Content/Temp/ExcelTemp/专家.xls");    //导出文件  

            try
            {
                file = new FileStream(TempletFileName, FileMode.Open, FileAccess.Read);
                HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);

                //创建临时文件写入数据
                using (FileStream filess = File.OpenWrite(ReportFileName))
                {
                    hssfworkbook.Write(filess);
                }
                System.IO.FileInfo filet = new System.IO.FileInfo(ReportFileName);
                string outputFileName = null;
                string browser = this.Context.Request.UserAgent.ToUpper();

                if (browser.Contains("MS") == true && browser.Contains("IE") == true)
                {
                    outputFileName = HttpUtility.UrlEncode("专家模板.xls");
                }
                else if (browser.Contains("FIREFOX") == true)
                {
                    outputFileName = "/专家模板.xls/";
                }
                else
                {
                    outputFileName = HttpUtility.UrlEncode("专家模板.xls");
                }
                Response.Clear();
                Response.Charset = "GB2312";
                Response.ContentEncoding = System.Text.Encoding.UTF8;
                Response.AddHeader("Content-Disposition", "attachment; filename=" + outputFileName);
                Response.AddHeader("Content-Length", filet.Length.ToString());
                Response.ContentType = "application/ms-excel";
                Response.WriteFile(filet.FullName);
                Response.End();
            }
            catch (Exception)
            {
                hdMsg.Value = "模板文件不存在或正在打开";
                //Response.Write("<script>alert('模板文件不存在或正在打开');</script>");
                return;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../View/ExpertManage/ExpertList.aspx");
        }
    }
}