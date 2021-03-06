﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace Evaluation.View.ActivityManage
{
    public partial class AwardResult : System.Web.UI.Page
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

        private void SetNewCell(NPOI.SS.UserModel.IRow row, int iIdx, string strValue, NPOI.SS.UserModel.ICellStyle style=null)
        {
            NPOI.SS.UserModel.ICell cell = row.CreateCell(iIdx, NPOI.SS.UserModel.CellType.String);
            cell.SetCellValue(strValue);
            if (style != null)
            {
                cell.CellStyle = style;
            }
            else
            {
                cell.CellStyle.BorderBottom = 0;
            }
        }

        protected void ExportAward_Click(object sender, EventArgs e)
        {
            int iPrizeID = 0;
            int.TryParse(hfPrizeID.Value, out iPrizeID);

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            List<Dal.Models.AwardResult> list = BLL.Vote.GetAwardResultReport(iPrizeID, conn);
            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID,conn);
            string ReportFileName = System.Web.HttpContext.Current.Server.MapPath("~/Content/Temp/ExcelTemp/投票结果_" + prize.PrizeName + ".xls");

            try
            {
                NPOI.HSSF.UserModel.HSSFWorkbook wk = new NPOI.HSSF.UserModel.HSSFWorkbook();
                NPOI.SS.UserModel.ISheet ws = wk.CreateSheet("投票结果");
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
                SetNewCell(row, 0, "排名", style);
                //增加同名奖内部排序
                SetNewCell(row, 1, "同名奖内部排序", style);

                SetNewCell(row, 2, "项目名称", style);
                SetNewCell(row, 3, "申报单位", style);
                //SetNewCell(row, 3, "申报奖项", style);
                SetNewCell(row, 4, "获奖结果", style);

                ws.SetColumnWidth(0, 2000);
                //设置同名奖内部排序列宽
                ws.SetColumnWidth(1, 3500);

                ws.SetColumnWidth(2, 10000);
                ws.SetColumnWidth(3, 10000);
                ws.SetColumnWidth(4, 4000);

                for (int i = 0; i < list.Count(); i++)
                {
                    row = ws.CreateRow(i + 1);

                    SetNewCell(row, 0, list[i].Ordinal.ToString(), style);
                    //写入同名奖内部排序
                    SetNewCell(row, 1, list[i].InnerOrdinal.ToString(), style);

                    SetNewCell(row, 2, list[i].DeclarationName.ToString(), style);
                    SetNewCell(row, 3, list[i].OrganizationName.ToString(), style);
                    //SetNewCell(row, 3, list[i].PrizeName.ToString(), style);

                    //SetNewCell(row, 3, BLL.Vote.GetAwardsStatus(list[i].VoteCode.ToString(), list[i].PrizeLevelCode), style);
                    SetNewCell(row, 4, list[i].AwardCodeText, style);

                }
                //添加专家签名
                row = ws.CreateRow(list.Count() + 2);
                SetNewCell(row, 1, "专家签名：");
                //添加日期
                row = ws.CreateRow(list.Count() + 6);
                SetNewCell(row, 3, "日期：");
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
                Response.Write(JsonConvert.SerializeObject(ex.Message));
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
                conn.Dispose(); 
                return;
            }

            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
            conn.Dispose();

            System.IO.FileInfo filet = new System.IO.FileInfo(ReportFileName);
            Response.Clear();
            Response.Charset = "GB2312";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AddHeader("Content-Disposition", "attachment; filename=AwardResult_" + DateTime.Now.ToFileTime().ToString() + ".xls");
            Response.AddHeader("Content-Length", filet.Length.ToString());
            Response.ContentType = "application/ms-excel";
            Response.WriteFile(filet.FullName);
            Response.End();
        }
    }
}