using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.ExpertManage
{
    public partial class Allocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                string strActivityType = Session["ActivityType"].ToString();
                Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
                if (activity == null)
                {
                    Response.Redirect("../Mutual/HomePage.aspx");
                }
                else
                {
                    ddlSpecialty.DataSource = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, false, conn);
                    ddlSpecialty.DataTextField = "SpecialtyName";
                    ddlSpecialty.DataValueField = "SpecialtyID";
                    ddlSpecialty.DataBind();
                }
            }
        }
        protected void ddlSpecialty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SpecialtyID"] = ddlSpecialty.SelectedValue;
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            Dal.Models.UserInfo user = ((Dal.Models.UserInfo)Session["UserInfo"]);
            //int specialty = Convert.ToInt32(ddlSpecialty.SelectedValue);
            //List<Dal.Models.Declaration> lstDeclaration = BLL.Declaration.GetDeclarationList(user, activity.ActivityID.Value, conn)
            //    .Where(d => d.SpecialtyID == specialty).OrderBy(d => d.AssociationOrdinal).ToList();
            Dal.Models.DeclarationSearchCondition condition = new Dal.Models.DeclarationSearchCondition()
            {
                ActivityID = activity.ActivityID,
                DeclarationStatus = "1803",
                SpecialtyID = ddlSpecialty.SelectedValue,
                UserID = user.UserID,
                UserType = user.UserType
            };
            List<Dal.Models.Declaration> lstDeclaration = BLL.Declaration.GetDeclarationList(condition, conn);
            DataTable dtDeclaration = dtDeclaration = Dal.DataTableExtensions.ToDataTable(lstDeclaration);

            //根据活动和专业导出专家
            List<Dal.Models.Expert> lstExpert = BLL.Expert.GetExpertList(conn, user,null, "0701").Where(a => (a.SpecialtyNames ?? "").Contains(ddlSpecialty.SelectedItem.Text)).ToList();
            DataTable dtExpert = Dal.DataTableExtensions.ToDataTable(lstExpert);
            string TempletFileName = Server.MapPath("~/Content/Template/项目评审专家组及专家信息模版.xls");      //模板文件  
            string ReportFileName = Server.MapPath("~/Content/Temp/ExcelTemp/DecGroupListAndExpertTemp.xls");    //导出文件  
            FileStream file = null;
            try
            {
                file = new FileStream(TempletFileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception)
            {
                hdMsg.Value = "模板文件不存在或正在打开!";
                return;
            }
            HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
            HSSFSheet ws1 = (HSSFSheet)hssfworkbook.GetSheet("专家组");//Sheet1
            HSSFSheet ws2 = (HSSFSheet)hssfworkbook.GetSheet("专家");//Sheet2

            if (ws1 == null || ws2 == null)//工作薄中没有工作表
            {
                hdMsg.Value = "文件中缺少<专家组>或<专家>工作表!";
                return;
            }

            Dal.Models.ExpertGroup group = null;
            int count = dtDeclaration.Rows.Count;
            int iID;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    HSSFRow row = (HSSFRow)ws1.CreateRow(i + 2);
                    row.CreateCell(0).SetCellValue(i + 1); // 序号
                    row.CreateCell(1).SetCellValue(dtDeclaration.Rows[i]["DeclarationCode"].ToString().Trim());
                    row.CreateCell(2).SetCellValue(dtDeclaration.Rows[i]["DeclarationName"].ToString().Trim());
                    row.CreateCell(3).SetCellValue(dtDeclaration.Rows[i]["PrizeName"].ToString().Trim());

                    if (int.TryParse(dtDeclaration.Rows[i]["ExpertReviewGroupID"].ToString(), out iID))
                    {
                        // 评审专家组
                        group = BLL.ExpertGroup.GetExpertGroup(iID, conn);
                        row.CreateCell(4).SetCellValue(dtDeclaration.Rows[i]["ExpertReviewGroupName"].ToString());
                        row.CreateCell(5).SetCellValue(dtDeclaration.Rows[i]["ExpertReviewerName"].ToString());
                        row.CreateCell(6).SetCellValue(group.LeaderName);
                        row.CreateCell(7).SetCellValue(group.DeputyNames);
                        row.CreateCell(8).SetCellValue(group.MemberNames);

                        // 上级专家组1
                        if (group.ParentID != null)
                        {
                            group = BLL.ExpertGroup.GetExpertGroup(group.ParentID.Value, conn);
                            row.CreateCell(9).SetCellValue(group.GroupName);
                            row.CreateCell(10).SetCellValue(group.LeaderName);
                            row.CreateCell(11).SetCellValue(group.DeputyNames);

                            // 上级专家组2
                            if (group.ParentID != null)
                            {
                                group = BLL.ExpertGroup.GetExpertGroup(group.ParentID.Value, conn);
                                row.CreateCell(12).SetCellValue(group.GroupName);
                                row.CreateCell(13).SetCellValue(group.LeaderName);
                                row.CreateCell(14).SetCellValue(group.DeputyNames);

                                // 上级专家组3
                                if (group.ParentID != null)
                                {
                                    group = BLL.ExpertGroup.GetExpertGroup(group.ParentID.Value, conn);
                                    row.CreateCell(15).SetCellValue(group.GroupName);
                                    row.CreateCell(16).SetCellValue(group.LeaderName);
                                    row.CreateCell(17).SetCellValue(group.DeputyNames);
                                }
                            }
                        }
                    }
                }
            }
            ws1.ForceFormulaRecalculation = true;

            if (dtExpert.Rows.Count > 0)
            {
                for (int i = 0; i < dtExpert.Rows.Count; i++)
                {
                    HSSFRow row = (HSSFRow)ws2.CreateRow(i + 1);
                    row.CreateCell(0).SetCellValue(i + 1);
                    row.CreateCell(1).SetCellValue(dtExpert.Rows[i]["ExpertName"].ToString().Trim());//姓名
                    row.CreateCell(2).SetCellValue(dtExpert.Rows[i]["Gender"].ToString().Trim());//性别
                    row.CreateCell(3).SetCellValue(dtExpert.Rows[i]["IDTypeText"].ToString().Trim());//证件类别
                    row.CreateCell(4).SetCellValue(dtExpert.Rows[i]["IDNumber"].ToString().Trim());//证件号码
                    row.CreateCell(5).SetCellValue(dtExpert.Rows[i]["Email"].ToString().Trim());//电子邮箱
                    row.CreateCell(6).SetCellValue(dtExpert.Rows[i]["AcademicTitle"].ToString().Trim());//职称
                    row.CreateCell(7).SetCellValue(dtExpert.Rows[i]["Profession"].ToString().Trim());//研究方向
                    row.CreateCell(8).SetCellValue(dtExpert.Rows[i]["Workplace"].ToString().Trim());//工作单位
                    row.CreateCell(9).SetCellValue(dtExpert.Rows[i]["SpecialtyNames"].ToString().Trim());//评优专业
                }
            }

            //先删除上一个临时文件
            if (File.Exists(ReportFileName))
            {
                FileInfo fi = new FileInfo(ReportFileName);
                if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                    fi.Attributes = FileAttributes.Normal;
                File.Delete(ReportFileName);
            }

            try
            {
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
                    outputFileName = HttpUtility.UrlEncode("项目评审专家组及专家信息模版.xls");
                }
                else if (browser.Contains("FIREFOX") == true)
                {
                    outputFileName = "/项目评审专家组及专家信息模版.xls/";
                }
                else
                {
                    outputFileName = HttpUtility.UrlEncode("项目评审专家组及专家信息模版.xls");
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
            catch (Exception ex)
            {
                hdMsg.Value = "模板文件不存在或正在打开!";
                return;
            }
        }
    }
}