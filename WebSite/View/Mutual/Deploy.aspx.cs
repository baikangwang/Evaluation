using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Mutual
{
    public partial class Deploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            // 更新内容
            Dal.Models.UploadFileInfo dUpdateContent = BLL.UploadFileInfo.GetUploadFile(0, 0, "UpdateContent", conn);
            if (dUpdateContent != null)
            {
                UpdateContent.InnerHtml = GetInnerHtml(dUpdateContent);
            }
            else
            {
                UpdateContent.InnerHtml = "暂未上传文件";
            }

            // Sql文
            Dal.Models.UploadFileInfo dUpdateSqlText = BLL.UploadFileInfo.GetUploadFile(0, 0, "UpdateSqlText", conn);
            if (dUpdateSqlText != null)
            {              
                UpdateSqlText.InnerHtml = GetInnerHtml(dUpdateSqlText);
            }
            else 
            {
                UpdateSqlText.InnerHtml = "暂未上传文件";
            }

            // 发布包
            Dal.Models.UploadFileInfo dUpdatePackage = BLL.UploadFileInfo.GetUploadFile(0, 0, "UpdatePackage", conn);
            if (dUpdatePackage != null)
            {
                UpdatePackage.InnerHtml = GetInnerHtml(dUpdatePackage);
            }
            else
            {
                UpdatePackage.InnerHtml = "暂未上传文件";
            }

            // 源代码
            Dal.Models.UploadFileInfo dUpdateSourceCode = BLL.UploadFileInfo.GetUploadFile(0, 0, "UpdateSourceCode", conn);
            if (dUpdateSourceCode != null)
            {
                UpdateSourceCode.InnerHtml = GetInnerHtml(dUpdateSourceCode);
            }
            else
            {
                UpdateSourceCode.InnerHtml = "暂未上传文件";
            }
            conn.Close();
        }
        public string GetInnerHtml(Dal.Models.UploadFileInfo UploadFileInfo)
        {
            StringBuilder sbFileName = new StringBuilder();
            sbFileName.AppendFormat("<a>{0}</a>", UploadFileInfo.FileName);
            sbFileName.Append("<br />");
            sbFileName.AppendFormat("<a  onclick='DeleteAppendix({0},{1},{2});return false;' title='删除' href=''>"
                , UploadFileInfo.UploadFileID, UploadFileInfo.OwnerID, UploadFileInfo.CorrelationID);
            sbFileName.Append("<i class='fa fa-trash-o'></i></a>");
            sbFileName.AppendFormat("　　　<a onclick=\'DownloadAppendix({0});return false;\' title='下载' href=''>", UploadFileInfo.UploadFileID);
            sbFileName.Append("<i class='fa fa-download'></i></a>");
            return sbFileName.ToString();
        }
    }
}