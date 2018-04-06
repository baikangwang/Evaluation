using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Evaluation.View.Mutual
{
    /// <summary>
    /// UserManage 的摘要说明
    /// </summary>
    public class UserManage : IHttpHandler, IRequiresSessionState 
    {
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
                    case "GetManagerList":
                        GetManagerList(context, conn);
                        break;
                    case "GetLeaguerUserList":
                        GetLeaguerUserList(context, conn);
                        break;
                    case "GetLeaguerUserChildList":
                        GetLeaguerUserChildList(context, conn);
                        break;
                    case "EditUser":
                        EditUser(context, conn);
                        break;
                    case "DelUser":
                        DelUser(context, conn);
                        break;
                    case"MultiselectDelUserList":
                        MultiselectDelUserList(context, conn);
                        break;
                    case "CreateUser":
                        CreateUser(context, conn);
                        break;
                    case "CreateLocalUser":
                        CreateLocalUser(context, conn);
                        break;
                    case "CreateUserM":
                        CreateUserM(context, conn);
                        break;
                    case "SendEmailToFindPwd":
                        SendEmailToFindPwd(context, conn);
                        break;
                    case "ImportLeaguerChildUser":
                        ImportLeaguerChildUser(context, conn);
                        break;
                    case "ImportLeaguerUser":
                        ImportLeaguerUser(context, conn);
                        break;
                    case "ResetPassword":
                        ResetPassword(context, conn);
                        break;
                    case "ResetExpertPassword":
                        ResetExpertPassword(context, conn);
                        break;
                    case "ForbiddenUser":
                        ForbiddenUser(context, conn);
                        break;
                    case "EnableUser":
                        EnableUser(context, conn);
                        break;
                }
            }

            conn.Close();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// 管理用户页面：管理用户列表，返回的一个List
        /// </summary>
        /// <remarks>
        /// 当前登录者为超级管理员 : 返回超级管理员、系统管理员、协会管理员、分会用户
        /// 当前登录者为系统管理员 : 返回系统管理员、协会管理员、分会用户
        /// 当前登录者为协会管理员 : 返回协会管理员、分会用户
        /// 当前登录者为分会用户 : 返回当前登录用户
        /// </remarks>
        /// <param name="context"></param>
        public void GetManagerList(HttpContext context, OleDbConnection conn)
        {
            string strUserName = context.Request["UserName"];
            Dal.Models.UserInfo userLogin = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.PageInfo<Dal.Models.UserInfo> pgif = new Dal.Models.PageInfo<Dal.Models.UserInfo>();
            List<Dal.Models.UserInfo> lstUser = BLL.User.GetManagerList(userLogin, strUserName, conn);

            if (lstUser == null)
            {
                pgif.CuttentPage = 1;
                pgif.PerPage = 10;
                pgif.RecordNumber = 0;
                pgif.PagesCount = 0;
                pgif.Table = null;
                context.Response.Write(JsonConvert.SerializeObject(pgif));
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
                context.Response.Write(strJson);
            }
        }

        public void GetLeaguerUserList(HttpContext context, OleDbConnection conn)
        {
            string userName = context.Request["UserName"];
            Dal.Models.PageInfo<Dal.Models.UserOrg> pgif = new Dal.Models.PageInfo<Dal.Models.UserOrg>();
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
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;

            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            //List<Dal.Models.UserOrg> userlist = BLL.User.GetUserListAllInfo(Convert.ToInt32(user.UserID), userName, pgif, conn);
            List<Dal.Models.UserOrg> userlist = BLL.User.GetLeaguerUserList(user.UserID.Value, userName, pgif, conn);

            if (userlist == null)
            {
                pgif.CuttentPage = 1;
                pgif.PerPage = 10;
                pgif.RecordNumber = 0;
                pgif.PagesCount = 0;
                pgif.Table = new DataTable();
                context.Response.Write(JsonConvert.SerializeObject(pgif));
            }
            else
            {
                //int iRecordNumber = userlist.Count;
                //int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
                //userlist = userlist.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();

                DataTable dtuserlist = Dal.DataTableExtensions.ToDataTable(userlist);
                dtuserlist.Columns.Add("UserTypeName");

                foreach (DataRow row in dtuserlist.Rows)
                {
                    row["UserTypeName"] = BLL.SysConstant.GetConstant(row["UserType"].ToString(), conn).ConstantValue;
                }

                //pgif.CuttentPage = iCuttentPage;
                //pgif.PerPage = iPageSize;
                //pgif.RecordNumber = iRecordNumber;
                //pgif.PagesCount = iPagesCount;
                pgif.Table = dtuserlist;

                string strJson = JsonConvert.SerializeObject(pgif);
                context.Response.Write(strJson);
            }

        }

        public void GetLeaguerUserChildList(HttpContext context, OleDbConnection conn)
        {
            string userName = context.Request["UserName"];
            Dal.Models.PageInfo<Dal.Models.UserInfo> pgif = new Dal.Models.PageInfo<Dal.Models.UserInfo>();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            List<Dal.Models.UserInfo> userlist = BLL.User.GetLeaguerChildList(user, userName, conn);

            if (userlist == null)
            {
                pgif.CuttentPage = 1;
                pgif.PerPage = 10;
                pgif.RecordNumber = 0;
                pgif.PagesCount = 0;
                pgif.Table = null;
                context.Response.Write(JsonConvert.SerializeObject(pgif));
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

                int iRecordNumber = userlist.Count;
                int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
                userlist = userlist.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();

                DataTable dtuserlist = Dal.DataTableExtensions.ToDataTable(userlist);
                dtuserlist.Columns.Add("UserTypeName");
                dtuserlist.Columns.Add("UserStatusName");

                foreach (DataRow row in dtuserlist.Rows)
                {
                    row["UserTypeName"] = BLL.SysConstant.GetConstant(row["UserType"].ToString(), conn).ConstantValue;
                    row["UserStatusName"] = BLL.SysConstant.GetConstant(row["UserStatus"].ToString(), conn).ConstantValue;
                }

                pgif.CuttentPage = iCuttentPage;
                pgif.PerPage = iPageSize;
                pgif.RecordNumber = iRecordNumber;
                pgif.PagesCount = iPagesCount;
                pgif.Table = dtuserlist;

                string strJson = JsonConvert.SerializeObject(pgif);
                context.Response.Write(strJson);
            }

        }

        /// <summary>
        /// 修改用户，需要参数UserID，UserStatus，Email
        /// </summary>s
        /// <param name="context"></param>
        public void EditUser(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                string userstatus = context.Request["UserStatus"];
                int id = Convert.ToInt32(context.Request["UserID"]);
                Dal.Models.UserInfo userinfo = BLL.User.GetUserInfo(id, conn, tran);
                userinfo.Email = context.Request["Email"];
                if (userstatus == "0701")
                {
                    BLL.User.EnableUser(id, conn, tran);
                }
                else if (userstatus == "0702")
                {
                    string strActivityType = context.Session["ActivityType"].ToString();
                    BLL.User.DisableUser(id, strActivityType, conn, tran);
                }
                BLL.User.Update(userinfo, conn, tran);
                tran.Commit();
                context.Response.Write("success");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        ///// <summary>
        ///// 用户激活状态，需要参数ConstantType
        ///// </summary>
        ///// <param name="context"></param>
        //public void GetUserStatus(HttpContext context, OleDbConnection conn)
        //{
        //    string strConstantType = context.Request["ConstantType"];
        //    List<Dal.Models.SysConstant> lstuserstatus = BLL.SysConstant.GetConstantList(strConstantType, conn);
        //    context.Response.Write(JsonConvert.SerializeObject(lstuserstatus));
        //}

        /// <summary>
        /// 删除用户，需要参数，UserID
        /// </summary>
        /// <param name="context"></param>
        public void DelUser(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                string id = context.Request["UserID"];
                int iUserID = Convert.ToInt32(id);
                if (iUserID == user.UserID.Value)
                {
                    throw new Exception("不能禁用或删除当前操作用户!");
                }
                string strActivityType = context.Session["ActivityType"].ToString();
                Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn, tran);
                if (activity == null)
                {
                    throw new Exception("没有激活的活动!");
                }
                int count = BLL.Declaration.DeclarationExsitUserCount(activity.ActivityID.Value,id, conn,tran);
                if (count > 0)
                {
                    throw new Exception("当前用户已经申报过项目，所以不能删除!");
                }
                BLL.User.DeleteUser(Convert.ToInt32(id), activity.ActivityID.Value, conn, tran);
                tran.Commit();
                context.Response.Write("删除成功！");
            }
            catch(Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
            conn.Close();
        }

        /// <summary>
        /// 删除多选用户列表Gqx
        /// </summary>
        /// <param name="context"></param>
        public void MultiselectDelUserList(HttpContext context, OleDbConnection conn)
        {
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write("没有激活的活动!");
                return;
            }

            string strUserID = context.Request["UserID"];
            int count = BLL.Declaration.DeclarationExsitUserCount(activity.ActivityID.Value, strUserID, conn);
            if (count > 0)
            {
                context.Response.Write("当前选中项中存在已经申报过项目的用户，所以不能删除!");
            }
            else
            {
                string[] arrayUserID = strUserID.Split(',');
                List<int> listUserID = new List<int>();
                foreach (var item in arrayUserID)
                {
                    listUserID.Add(Convert.ToInt32(item));
                }
                OleDbTransaction trans = conn.BeginTransaction();
                try
                {
                    for (int i = 0; i < listUserID.Count(); i++)
                    {
                        int iUserID = Convert.ToInt32(listUserID[i]);
                        BLL.User.DeleteUser(iUserID, Convert.ToInt32(activity.ActivityID), conn, trans);
                    }
                    trans.Commit();
                    context.Response.Write("删除成功！");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    context.Response.Write(ex.Message);
                }
            }
            conn.Close();
        }

        public void CreateUser(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = new Dal.Models.UserInfo();
            user.UserName = context.Request["txtUserName"];
            user.CreateUser = ((Dal.Models.UserInfo)context.Session["UserInfo"]).UserID;
            user.Email = context.Request["txtEmail"];
            user.IsPasswordChanged = false;
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                user.UserType = context.Request["UserType"];
                user.Password = BLL.SysConstant.GetAppSettings("DefaultPassword", conn, tran); ;
                user.UserID = BLL.User.CreateUser(user, conn, tran);
                tran.Commit();
                context.Response.Write("创建成功！");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        /// <summary>
        /// 创建地方协会用户
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void CreateLocalUser(HttpContext context, OleDbConnection conn)
        {
            string UserType = context.Request["UserType"];
            Dal.Models.UserInfo user = new Dal.Models.UserInfo();
            string strUserID = context.Request["UserID"];
            user.Email = context.Request["Email"];
            user.UserName = context.Request["UserName"];
            user.IsPasswordChanged = false;
            string strRegionCodes = context.Request["RegionCodes"];
            string strMessage = "";
            int iUserID = 0;

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                if (string.IsNullOrEmpty(strUserID))
                {
                    user.CreateUser = ((Dal.Models.UserInfo)context.Session["UserInfo"]).UserID;
                    user.Password = BLL.SysConstant.GetAppSettings("DefaultPassword", conn, tran);
                    user.UserType = UserType;
                    iUserID = BLL.User.CreateUser(user, conn, tran);
                    strMessage = "创建成功！";
                }
                else
                {
                    if (!int.TryParse(strUserID, out iUserID))
                    {
                        throw new Exception("参数错误!");
                    }

                    user.UserID = iUserID;
                    BLL.User.Update(user, conn, tran);

                    strMessage = "修改成功！";
                }
                BLL.User.SetUserRegion(iUserID, strRegionCodes, conn, tran);

                tran.Commit();
                context.Response.Write(strMessage);
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        /// <summary>
        /// 创建管理员
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void CreateUserM(HttpContext context, OleDbConnection conn)
        {
            string sType = context.Request["oType"];
            Dal.Models.UserInfo user = new Dal.Models.UserInfo();
            user.UserName = context.Request["UserName"];
            user.Email = context.Request["Email"];
            user.IsPasswordChanged = false;
            string SpecialtyIDs = context.Request["SpecialtyIDs"];

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                string strActivityType = context.Session["ActivityType"].ToString();
                int iUserID = 0;
                Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn, tran);
                if (actActivated == null)
                {
                    throw new ApplicationException("没有激活的活动!");
                }

                if (sType == "update")
                {
                    if (context.Request["UserID"] != null && context.Request["UserID"] != "")
                    {
                        user.UserID = Convert.ToInt32(context.Request["UserID"]);
                    }
                    else
                    {
                        throw new NoNullAllowedException("用户编号不允许为空！");
                    }
                    iUserID = BLL.User.Update(user, conn, tran);
                }
                else
                {
                    user.UserType = context.Request["UserType"];
                    user.Password = BLL.SysConstant.GetAppSettings("DefaultPassword", conn, tran); ;
                    user.CreateUser = ((Dal.Models.UserInfo)context.Session["UserInfo"]).UserID;
                    user.UserID = BLL.User.CreateUser(user, conn, tran);
                }

                if (user.UserID != ((Dal.Models.UserInfo)context.Session["UserInfo"]).UserID)
                {
                    BLL.User.SetUserSpecialty(user.UserID.Value, actActivated.ActivityID.Value, SpecialtyIDs, conn, tran);
                }

                tran.Commit();
                context.Response.Write("创建成功！");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }
 
        public void SendEmailToFindPwd(HttpContext context, OleDbConnection conn)
        {
            string UserName = context.Request["UserName"];
            string UserEmail = context.Request["UserEmail"];
            if(string.IsNullOrEmpty(UserName)||string.IsNullOrEmpty(UserEmail))
            {
                context.Response.Write("请补全信息！");
            }
            else
            {
                // 根据用户名取用户
                Dal.Models.UserInfo user = BLL.User.GetUserByName(UserName, conn);
                Dal.Models.Organization org;
                if (user == null)
                {
                    // 取单位信息
                    org = BLL.Organization.GetOrganizationByName(UserName, conn);
                    if (org == null)
                    {
                        org = BLL.Organization.GetOrganizationByCode(UserName, conn);
                    }

                    if (org != null)
                    {
                        user = BLL.User.GetUserInfo(org.UserID.Value, conn);
                        if (string.IsNullOrEmpty(user.Email))
                        {
                            user.Email = org.EmailAddress;
                        }
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(user.Email) && user.UserType == "0806")
                    {
                        // 取单位信息
                        org = BLL.Organization.GetOrganizationByUser(user.UserID.Value, conn);
                        user.Email = org.EmailAddress;
                    }
                }

                if (user == null)
                {
                    context.Response.Write("该用户不存在！");
                }
                else
                {
                    if (user.Email != UserEmail)
                    {
                        context.Response.Write("用户名和邮箱不匹配!");
                    }
                    else
                    {
                        Dal.Models.MailInfo mailinfo = new Dal.Models.MailInfo();
                        string strUrl = context.Request.Url.Host + ":" + context.Request.Url.Port + "/View/UserManage/RetrievePassword_Return?id=" + BLL.Encryption.Encrypt(user.UserID.Value.ToString());//加密
                        mailinfo.Subject = "修改密码";

                        Dictionary<string, string> dicAppSetting = BLL.SysConstant.GetAppSettingDict("", conn);
                        mailinfo.SenderAddress = dicAppSetting["SenderAddress"];
                        mailinfo.SmtpAcount = dicAppSetting["SmtpAcount"];
                        mailinfo.SmtpPassword = dicAppSetting["SmtpPassword"];

                        mailinfo.RecipientAddress.Add(UserEmail);
                        mailinfo.IsBodyHtml = true;
                        mailinfo.Content = "请登录页面：<a href='" + strUrl + "' >" + strUrl + "</a>   完成密码修改";
                        try
                        {
                            BLL.Common.SendMail(mailinfo);
                            context.Response.Write("发送成功!");
                        }
                        catch
                        {
                            context.Response.Write("邮箱不存在!");
                        }   
                    }
                }
            }
        }

        /// <summary>
        /// 导入会员子用户
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void ImportLeaguerChildUser(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo userinfo = (Dal.Models.UserInfo)context.Session["UserInfo"];
            if (context.Request.Files.Count > 0)
            {
                string fileName = "";
                HttpFileCollection files = context.Request.Files;
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFile file = files[i];
                    if (!Directory.Exists(context.Server.MapPath("~/Content/Temp/ExcelTemp/")))
                    {
                        Directory.CreateDirectory(context.Server.MapPath("~/Content/Temp/ExcelTemp/"));
                    }
                    fileName = context.Server.MapPath("~/Content/Temp/ExcelTemp/" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + file.FileName);
                    file.SaveAs(fileName);
                }

                DataTable dtLeaguerChildUser = new DataTable();
                Dal.Models.UserInfo user = new Dal.Models.UserInfo();
                bool isColumnName = true;

                // 0 ..sheet1
                dtLeaguerChildUser = BLL.Common.ReadExcelByNPOI(fileName, isColumnName, 0);

                int strFailUser = 1;//失败的用户添加到这里
                string strMessage = "";
                int renumbersussed = 0;
                OleDbTransaction tran = conn.BeginTransaction();
                try
                {
                    foreach (DataRow row in dtLeaguerChildUser.Rows)
                    {
                        if (!string.IsNullOrEmpty(row["序号"].ToString()) && !string.IsNullOrEmpty(row["用户名"].ToString()))
                        {
                            strFailUser = Convert.ToInt32(row["序号"]);
                            user = new Dal.Models.UserInfo();
                            user.UserName = row["用户名"].ToString();
                            user.Password = row["密码"].ToString();
                            user.Email = row["邮箱"].ToString();
                            user.CreateUser = userinfo.UserID;
                            user.UserType = "0807";
                            //string strPwd = System.Configuration.ConfigurationManager.AppSettings["DefaultPassword"];
                            string strPwd = BLL.SysConstant.GetAppSettings("DefaultPassword", conn, tran);
                            user.UserID = BLL.User.CreateUser(user, conn, tran);
                            BLL.User.ResetPassword(user.UserID.Value, strPwd, conn, tran);
                            strFailUser++;
                            renumbersussed++;
                        }
                        else
                        {
                            strMessage += "第 " + strFailUser + " 号数据，" + "序号或单位名称为空，不可导入！<br/>";
                            strFailUser++;
                        }
                    }
                    tran.Commit();
                    strMessage = "上传成功：" + renumbersussed + "条数据；<br/>" + strMessage;
                    context.Response.Write(JsonConvert.SerializeObject(strMessage));
                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    strMessage += "第 " + strFailUser + " 号数据，" + ex.Message + "<br/>";
                    strFailUser++;
                    context.Response.Write(JsonConvert.SerializeObject(strMessage));
                }
            }
        }

        /// <summary>
        /// 导入会员单位
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void ImportLeaguerUser(HttpContext context, OleDbConnection conn)
        {
            List<object> lstResult = new List<object>();
            Dal.Models.UserInfo userinfo = (Dal.Models.UserInfo)context.Session["UserInfo"];
            if (context.Request.Files.Count > 0)
            {
                string fileName = "";
                HttpFileCollection files = context.Request.Files;
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFile file = files[i];

                    if (!Directory.Exists(context.Server.MapPath("~/Content/Temp/ExcelTemp/")))
                    {
                        Directory.CreateDirectory(context.Server.MapPath("~/Content/Temp/ExcelTemp/"));
                    }
                    fileName = context.Server.MapPath("~/Content/Temp/ExcelTemp/" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + file.FileName);
                    file.SaveAs(fileName);
                }

                DataTable dtLeaguerUser = new DataTable();
                Dal.Models.Organization org = new Dal.Models.Organization();
                bool isColumnName = true;

                // 0 ..sheet1
                dtLeaguerUser = BLL.Common.ReadExcelByNPOI(fileName, isColumnName, 0);

                List<Dal.Models.Organization> lstOrg = new List<Dal.Models.Organization>();
                //创建单位, 如果创建失败，加入列表
                List<KeyValuePair<string, Dal.Models.Organization>> lstError = new List<KeyValuePair<string, Dal.Models.Organization>>();

                OleDbTransaction tran = conn.BeginTransaction();
                foreach (DataRow row in dtLeaguerUser.Rows)
                {
                    if (string.IsNullOrEmpty(row["单位名称"].ToString().Trim()))
                    {
                        continue;
                    }
                    org = new Dal.Models.Organization();
                    org.OrganizationName = row["单位名称"].ToString();
                    org.OrganizationCode = row["组织机构代码"].ToString();
                    org.UserName = row["登录账号"].ToString();
                    org.OrganizationAddress = row["单位地址"].ToString();
                    org.LegalPersonName = row["法人姓名"].ToString();
                    org.LegalPersonIDNo = row["法人身份证号"].ToString();
                    org.Linkman = row["联系人"].ToString();
                    org.TelephoneNumber = row["电话号码"].ToString();
                    org.MobileNumber = row["手机号"].ToString();
                    org.EmailAddress = row["电子邮箱"].ToString();
                    org.Postcode = row["邮政编码"].ToString();
                    org.FaxNumber = row["传真号"].ToString();
                    org.Password = BLL.SysConstant.GetAppSettings("DefaultPassword", conn, tran);
                    try
                    {
                        // 校验身份证号
                        if (!string.IsNullOrEmpty(org.LegalPersonIDNo) && !BLL.IDOperation.CheckIDCard18(org.LegalPersonIDNo))
                        {
                            throw new Exception("所输入的身份证号码不是有效身份证号码！");
                        }

                        // 判断邮箱地址
                        if (!string.IsNullOrEmpty(org.EmailAddress) && !BLL.Common.IsValidEmail(org.EmailAddress))
                        {
                            throw new Exception("电子邮件地址格式错误！");
                        }

                        BLL.Organization.CreateOrganization(org, userinfo.UserID.Value, conn, tran);
                        lstOrg.Add(org);
                    }
                    catch (Exception ex)
                    {
                        // 添加失败数据及失败原因
                        lstError.Add(new KeyValuePair<string, Dal.Models.Organization>(ex.Message, org));
                    }
                }
                tran.Commit();

                lstResult.Add(dtLeaguerUser.Rows.Count);
                lstResult.Add(lstOrg.Count);
                lstResult.Add(lstOrg);
                lstResult.Add(lstError);

                context.Response.Write(JsonConvert.SerializeObject(lstResult));
            }
        }

        ///重置密码
        public void ResetPassword(HttpContext context, OleDbConnection conn)
        {
            string id = context.Request["UserID"];
            //string psw = System.Configuration.ConfigurationManager.AppSettings["DefaultPassword"];
            string psw = BLL.SysConstant.GetAppSettings("DefaultPassword", conn);
            OleDbTransaction tran = conn.BeginTransaction();
            if (id != null && id != "")
            {
                try
                {
                    BLL.User.ResetPassword(Convert.ToInt32(id), psw, conn,tran);
                    tran.Commit();
                    context.Response.Write("重置密码成功！");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    context.Response.Write(ex.Message);
                }
                conn.Close();
            }
        }

        ///重置专家密码
        public void ResetExpertPassword(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction tran = conn.BeginTransaction();
            int expertId = Convert.ToInt32(context.Request["ExpertID"]);

            int id = BLL.Expert.GetExpert(expertId, conn, tran).UserID.Value;
            //string psw = System.Configuration.ConfigurationManager.AppSettings["DefaultPassword"];
            string psw = BLL.SysConstant.GetAppSettings("DefaultPassword", conn, tran);
            if (id != 0)
            {
                try
                {
                    BLL.User.ResetPassword(id, psw, conn, tran);
                    tran.Commit();
                    context.Response.Write("重置密码成功！");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    context.Response.Write(ex.Message);
                }
                conn.Close();
            }
        }

        public void ForbiddenUser(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();

            string id = context.Request["UserID"];
            OleDbTransaction tran = conn.BeginTransaction();

            if (id != null && id != "")
            {
                try
                {
                    int iUserID = Convert.ToInt32(id);
                    if (iUserID == user.UserID.Value)
                    {
                        throw new Exception("不能禁用或删除当前操作用户!");
                    }
                    BLL.User.DisableUser(iUserID, strActivityType, conn, tran);
                    tran.Commit();
                    context.Response.Write("禁用用户成功！");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    context.Response.Write(ex.Message);
                }
                conn.Close();
            }
        }

        public void EnableUser(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];

            string id = context.Request["UserID"];
            OleDbTransaction tran = conn.BeginTransaction();

            if (id != null && id != "")
            {
                try
                {
                    int iUserID = Convert.ToInt32(id);
                    BLL.User.EnableUser(iUserID, conn, tran);
                    tran.Commit();
                    context.Response.Write("激活用户成功！");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    context.Response.Write(ex.Message);
                }
                conn.Close();
            }
        }
    }
}