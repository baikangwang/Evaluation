using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class Comments : System.Web.UI.UserControl
    {
        public Dal.Models.Declaration Decl { get; set; }
        public Dal.Models.Organization Org { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                Dal.Models.UserInfo UserInfo = (Dal.Models.UserInfo)Session["UserInfo"];
                Dal.Models.Activity act = (Dal.Models.Activity)Session["Activity"];
                Dal.Models.TemplateInfo tempInfo = (Dal.Models.TemplateInfo)Session["TemplateInfo"];
                Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(tempInfo.DeclarationID.Value, conn);
          
                txtGrade.Text = "Close";
                DeclarationID.Text = tempInfo.DeclarationID.ToString();
                if (UserInfo.UserType == "0805" && decl.ExpertReviewGroupID != null && decl.ExpertReviewer != 0)
                {
                    // 获取专家ID
                    Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(UserInfo.UserID.Value, conn);
                    if (expert.ExpertID == decl.ExpertReviewer)
                    {
                        txtGrade.Text = "Open";
                        txtReviewWriter.Text = expert.ExpertName;
                        FirstComment.Text = decl.ExpertReviewComment;

                    //    HtmlTableRow tr = new HtmlTableRow();
                    //    HtmlTableCell td1 = new HtmlTableCell("td");
                    //    td1.InnerHtml = "<p>评审意见填写人:" + expert.ExpertName + "</p>"
                    //        + "<textarea  ID='ExpertReviewComment' class='CommentsDis'  rows='3' cols='20' style='height:300px;width:90%;' data='Review'>"
                    //        + decl.ExpertReviewComment + "</textarea>";
                    //    td1.ColSpan = 4;
                    //    td1.Style.Add("border-bottom", "none");
                    //    td1.Style.Add("text-align", "center");
                    //    tr.Cells.Add(td1);

                    //    HtmlTableRow tr2 = new HtmlTableRow();
                    //    HtmlTableCell td2 = new HtmlTableCell("td");
                    //    HtmlTableCell td3 = new HtmlTableCell("td");
                    //    HtmlTableCell td4 = new HtmlTableCell("td");
                    //    HtmlTableCell td5 = new HtmlTableCell("td");
                    //    td2.InnerHtml = "组长（签名）:";
                    //    td2.Style.Add("width", "40%");
                    //    td2.Style.Add("border-top", "none");
                    //    td2.Style.Add("border-right", "none");

                    //    td3.InnerHtml = "";
                    //    td3.Style.Add("width", "10%");
                    //    td3.Style.Add("border-top", "none");
                    //    td3.Style.Add("border-right", "none");
                    //    td3.Style.Add("border-left", "none");

                    //    td4.InnerHtml = "评审日期:";
                    //    td4.Style.Add("width", "40%");
                    //    td4.Style.Add("border-top", "none");
                    //    td4.Style.Add("border-right", "none");
                    //    td4.Style.Add("border-left", "none");

                    //    td5.InnerHtml = "";
                    //    td5.Style.Add("width", "10%");
                    //    td5.Style.Add("border-top", "none");
                    //    td5.Style.Add("border-left", "none");
                    //    tr2.Cells.Add(td2);
                    //    tr2.Cells.Add(td3);
                    //    tr2.Cells.Add(td4);
                    //    tr2.Cells.Add(td5);

                    //    tbReview.Rows.Add(tr);
                    //    tbReview.Rows.Add(tr2);
                    }
                }

                conn.Close();

            }
        }
    }
}