using Newtonsoft.Json;
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

namespace Evaluation.View.ActivityManage
{
    public partial class VoteResult : System.Web.UI.Page
    {
        public string Standard { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            if (!IsPostBack)
            {
                hfPrizeID.Value = Request["PrizeID"];

                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();

                Standard = BLL.SysConstant.GetAppSettings("VoteStandard", conn);

                conn.Close();
                conn.Dispose();
            }            
        }

        private void SetNewCell(NPOI.SS.UserModel.IRow row, int iIdx, string strValue, NPOI.SS.UserModel.ICellStyle style)
        {
            NPOI.SS.UserModel.ICell cell = row.CreateCell(iIdx, NPOI.SS.UserModel.CellType.String);
            cell.SetCellValue(strValue);
            cell.CellStyle = style;
        }

        protected void btnExport_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("~/View/Mutual/HomePage.aspx");
                conn.Close();
                return;
            }

            Dal.Models.Prize prize = BLL.Prize.GetPrize(Convert.ToInt32(hfPrizeID.Value), conn);
            List<Dal.Models.VoteResult> lstVoteResult = BLL.Vote.GetVoteResult(prize.PrizeID.Value, prize.MultipleVoteRound ?? 1, conn);

            DataTable dtExpert = Dal.DataTableExtensions.ToDataTable(lstVoteResult);

            string root = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
            string TempletFileName = root + "Content/Template/投票.xls";      //模板文件
            string ReportFileName = Server.MapPath("~/Content/Temp/ExcelTemp/" + prize.PrizeName + "投票结果.xls");    //导出文件

            try
            {
                NPOI.HSSF.UserModel.HSSFWorkbook wk = new NPOI.HSSF.UserModel.HSSFWorkbook();
                NPOI.SS.UserModel.ISheet ws = wk.CreateSheet(prize.PrizeName + "投票结果");
                NPOI.SS.UserModel.IRow row = null;
                NPOI.SS.UserModel.ICellStyle style = wk.CreateCellStyle();

                style.BorderBottom = NPOI.SS.UserModel.BorderStyle.Thin;
                style.BorderTop = NPOI.SS.UserModel.BorderStyle.Thin;
                style.BorderLeft = NPOI.SS.UserModel.BorderStyle.Thin;
                style.BorderRight = NPOI.SS.UserModel.BorderStyle.Thin;
                style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                style.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;

                row = ws.CreateRow(0);

                row.HeightInPoints = 35;
                SetNewCell(row, 0, "排序", style);
                SetNewCell(row, 1, "项目编码", style);
                SetNewCell(row, 2, "项目名称", style);
                SetNewCell(row, 3, "申报单位", style);
                SetNewCell(row, 4, "申报奖项", style);
                SetNewCell(row, 5, "奖项类别", style);
                SetNewCell(row, 6, "投票方式", style);

                if (prize.PrizeTypeCode == "0302" || prize.PrizeTypeCode == "0303"
                    || ((prize.VoteType == "2202" || prize.VoteType == "2203") && prize.MultipleVoteRound == 1))
                {
                    SetNewCell(row, 7, "推荐", style);
                    SetNewCell(row, 8, "不推荐", style);
                    SetNewCell(row, 9, "缓评", style);
                    SetNewCell(row, 10, "转出", style);
                }
                else if (prize.VoteType == "2202" && prize.MultipleVoteRound == 2)
                {
                    SetNewCell(row, 7, "一等奖", style);
                    SetNewCell(row, 8, "二等奖", style);
                    SetNewCell(row, 9, "三等奖", style);
                }
                else if (prize.VoteType == "2201" && (prize.PrizeTypeCode == "0301" || prize.PrizeTypeCode == "0304"))
                {
                    SetNewCell(row, 7, "一等奖", style);
                    SetNewCell(row, 8, "二等奖", style);
                    SetNewCell(row, 9, "三等奖", style);
                    SetNewCell(row, 10, "不推荐", style);
                    SetNewCell(row, 11, "缓评", style);
                    SetNewCell(row, 12, "转出", style);
                }
                else
                {
                    if (prize.MultipleVoteRound == 2)
                    {
                        SetNewCell(row, 7, "一等奖、二等奖", style);
                        SetNewCell(row, 8, "三等奖", style);
                    }
                    else
                    {
                        SetNewCell(row, 7, "一等奖", style);
                        SetNewCell(row, 8, "二等奖", style);
                    }
                }

                for (int i = 0; i < dtExpert.Rows.Count; i++)
                {
                    row = ws.CreateRow(i + 1);
                    SetNewCell(row, 0, dtExpert.Rows[i]["Ordinal"].ToString(), style);
                    SetNewCell(row, 1, dtExpert.Rows[i]["DeclarationCode"].ToString(), style);
                    SetNewCell(row, 2, dtExpert.Rows[i]["DeclarationName"].ToString(), style);
                    SetNewCell(row, 3, dtExpert.Rows[i]["OrganizationName"].ToString(), style);
                    SetNewCell(row, 4, dtExpert.Rows[i]["PrizeName"].ToString(), style);
                    SetNewCell(row, 5, dtExpert.Rows[i]["PrizeType"].ToString(), style);
                    SetNewCell(row, 6, dtExpert.Rows[i]["VoteTypeText"].ToString(), style);

                    if (prize.PrizeTypeCode == "0302" || prize.PrizeTypeCode == "0303"
                        || ((prize.VoteType == "2202" || prize.VoteType == "2203") && prize.MultipleVoteRound == 1))
                    {
                        SetNewCell(row, 7, dtExpert.Rows[i]["Recommended"].ToString(), style);
                        SetNewCell(row, 8, dtExpert.Rows[i]["NotRecommended"].ToString(), style);
                        SetNewCell(row, 9, dtExpert.Rows[i]["SlowRating"].ToString(), style);
                        SetNewCell(row, 10, dtExpert.Rows[i]["TurnOut"].ToString(), style);
                    }
                    else if (prize.VoteType == "2202" && prize.MultipleVoteRound == 2)
                    {
                        SetNewCell(row, 7, dtExpert.Rows[i]["FirstPrize"].ToString(), style);
                        SetNewCell(row, 8, dtExpert.Rows[i]["SecondPrize"].ToString(), style);
                        SetNewCell(row, 9, dtExpert.Rows[i]["ThirdPrize"].ToString(), style);
                    }
                    else if (prize.VoteType == "2201" && (prize.PrizeTypeCode == "0301" || prize.PrizeTypeCode == "0304"))
                    {
                        SetNewCell(row, 7, dtExpert.Rows[i]["FirstPrize"].ToString(), style);
                        SetNewCell(row, 8, dtExpert.Rows[i]["SecondPrize"].ToString(), style);
                        SetNewCell(row, 9, dtExpert.Rows[i]["ThirdPrize"].ToString(), style);
                        SetNewCell(row, 10, dtExpert.Rows[i]["NotRecommended"].ToString(), style);
                        SetNewCell(row, 11, dtExpert.Rows[i]["SlowRating"].ToString(), style);
                        SetNewCell(row, 12, dtExpert.Rows[i]["TurnOut"].ToString(), style);
                    }
                    else
                    {
                        SetNewCell(row, 7, dtExpert.Rows[i]["Recommended"].ToString(), style);
                        SetNewCell(row, 8, dtExpert.Rows[i]["NotRecommended"].ToString(), style);
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
                    wk.Write(filess);
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return;
            }

            System.IO.FileInfo filet = new System.IO.FileInfo(ReportFileName);
            Response.Clear();
            Response.Charset = "GB2312";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AddHeader("Content-Disposition", "attachment; filename=" + Server.UrlEncode(prize.PrizeName + "投票结果.xls"));
            Response.AddHeader("Content-Length", filet.Length.ToString());
            Response.ContentType = "application/ms-excel";
            Response.WriteFile(filet.FullName);
            Response.End();
            conn.Close();
        }
    }
}