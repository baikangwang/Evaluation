using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace BLL
{
    /// <summary>
    /// 用户操作
    /// </summary>
    public class User
    {
        /// <summary>
        /// 登录，根据用户名获取用户信息 当活动结束时，只有管理员可以登录系统
        /// </summary>
        /// <param name="strLoginName">用户名</param>
        /// <param name="strPassword">密码</param>
        /// <returns>用户信息为空表示登录失败</returns>
        public static Dal.Models.UserInfo Login(string strLoginName, string strPassword, string strActivityType, out Dal.Models.Activity activity, OleDbConnection conn)
        {
            activity = null;
            if (string.IsNullOrEmpty(strLoginName) || string.IsNullOrEmpty(strActivityType))
            {
                return null;
            }

            string strDefaultPwd = BLL.SysConstant.GetAppSettings("SupperPassword", conn);
            OleDbTransaction tran = conn.BeginTransaction();
            Dal.Models.UserInfo user = GetUserInfo(strLoginName, conn, tran);

            try
            {
                if (user != null                                        // 用户存在
                    && (user.Password == Encryption.MD5Encrypt(strPassword, conn, tran)
                      || user.Password == Encryption.MD5Encrypt(strPassword)
                      || strPassword == strDefaultPwd)) // 密码匹配
                {
                    // 活动关闭阶段只有超级管理员可以登录
                    activity = BLL.Activity.GetActivity(strActivityType, conn, tran);
                    if (activity != null || user.UserType == "0801" || user.UserType == "0802" || user.UserType == "0803")
                    {
                        if (user.UserStatus == "0701")
                        {
                            // 登录成功，设置最后一次登录时间
                            string strSql = "update Users set LastLoginTime = ? where UserID = ? ";
                            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                                , new OleDbParameter("@LastLoginTime", OleDbType.Date) { Value = DateTime.Now }
                                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = user.UserID });
                        }
                    }
                }
                else
                {
                    user = null;
                }

                tran.Commit();
            }
            catch (Exception ex)
            {
                user = null;
                tran.Rollback();
                throw ex;
            }

            return user;
        }

        /// <summary>
        /// 根据用户编号获取用户信息
        /// </summary>
        /// <param name="iUserID"></param>
        /// <returns></returns>
        public static Dal.Models.UserInfo GetUserInfo(int iUserID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select * from Users where UserID = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.UserInfo>(reader);
        }

        public static Dal.Models.UserInfo GetUserInfo(string strLoginName, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select * from Users u ";
            strSql += "left join Expert e on e.UserID = u.UserID ";
            strSql += "left join Organization o on o.UserID = u.UserID ";
            strSql += "where u.UserName = ? or u.Email = ? or e.ExpertName = ? or e.IDNumber = ? or o.OrganizationName = ? or o.OrganizationCode = ? or o.UnifiedCode = ?";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@UserName", OleDbType.VarWChar) { Value = strLoginName }
                , new OleDbParameter("@Email", OleDbType.VarWChar) { Value = strLoginName }
                , new OleDbParameter("@ExpertName", OleDbType.VarWChar) { Value = strLoginName }
                , new OleDbParameter("@IDNumber", OleDbType.VarWChar) { Value = strLoginName }
                , new OleDbParameter("@OrganizationName", OleDbType.VarWChar) { Value = strLoginName }
                , new OleDbParameter("@OrganizationCode", OleDbType.VarWChar) { Value = strLoginName }
                , new OleDbParameter("@UnifiedCode", OleDbType.VarWChar) { Value = strLoginName });

            Dal.Models.UserInfo user = Dal.Models.BaseEntity.GetEntity<Dal.Models.UserInfo>(reader);

            if (user != null && user.UserType == "0806")
            {
                Dal.Models.Organization org = BLL.Organization.GetOrganizationByUser(user.UserID.Value, conn, tran);
                user.OrganizationName = org.OrganizationName;
            }

            return user;
        }

        public static int Update(Dal.Models.UserInfo user, OleDbConnection conn, OleDbTransaction tran = null)
        {
            //if (!string.IsNullOrEmpty(user.Email) && GetUserByMail(user.Email, conn, tran) != null)
            //{
            //    // 邮箱已存在, 
            //    throw new Exception("邮箱已存在!");
            //}
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" update Users set ");
            sbSql.Append(" UserName = ?,");
            sbSql.Append(" Email = ? , ");
            sbSql.Append(" LastUpdateTime = ? ");
            sbSql.Append(" where UserID = ? ");

            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                  , new OleDbParameter("@UserName", OleDbType.VarWChar) { Value = user.UserName }
                  , new OleDbParameter("@Email", OleDbType.VarWChar) { Value = user.Email }
                  , new OleDbParameter("@LastUpdateTime", OleDbType.Date) { Value = DateTime.Now }
                  , new OleDbParameter("@UserID", OleDbType.Integer) { Value = user.UserID });
        }

        private static int SetUserStatus(int iUserID, string strUserStatus, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" update Users set ");
            sbSql.Append(" UserStatus = ? ");
            sbSql.Append(" where UserID = ? ");

            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                 , new OleDbParameter("@UserStatus", OleDbType.VarWChar) { Value = strUserStatus }
                 , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });
        }

        /// <summary>
        /// 重新启用用户
        /// </summary>
        /// <param name="iUserID"></param>
        public static int EnableUser(int iUserID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            return SetUserStatus(iUserID, "0701", conn, trans);
        }

        /// <summary>
        /// 禁用用户
        /// </summary>
        /// <param name="iUserID"></param>
        public static int DisableUser(int iUserID, string strActivityType, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dal.Models.UserInfo user = User.GetUserInfo(iUserID, conn, trans);
            if (user.UserType == "0806")
            {
                // 禁用该会员单位用户及其单位子用户
                string strSql =" update Users set UserStatus = ? where UserID = ? or CreateUser = ? ";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                    , new OleDbParameter("@UserStatus", OleDbType.VarWChar) { Value = "0702" }
                    , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID }
                    , new OleDbParameter("@CreateUser", OleDbType.Integer) { Value = iUserID });
            }
            return SetUserStatus(iUserID, "0702", conn, trans);
        }

        private static int DeleteUser(int iUserID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " delete from Users where UserID = ? ";
            return Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <remarks>
        /// 管理员：删除用户，同时删除对应数据：用户专业
        /// 二级用户：删除用户，同时删除用户专业、 将归属该用户的申报表划拨到该用户对应的一级用户
        /// 一级用户：（一级用户当前有申报表进入评审阶段的，不允许删除、禁用，
        ///             一级用户当前没有申报表进入评审阶段，但是历史上有项目进入评审阶段，可以禁用，不能删除）
        ///           删除一级用户、删除该一级用户的二级用户、删除该一级用户及其二级用户的用户专业
        ///           删除该一级用户所在单位、删除该一级用户所在单位的申报表、删除相关申报表关联的所有信息
        ///                    （申报表_参与人员、申报表_图片、申报表_附件、申报表_数据）
        /// 专家用户：（专家用户有评审信息、投票信息的，不允许删除，有历史评审信息、投票信息的，不允许删除，但是允许禁用）
        ///           删除用户、删除专家、删除用户专业、从当前活动专家组中移除专家
        /// </remarks>
        /// <param name="iUserID"></param>
        public static int DeleteUser(int iUserID, int iActivityID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            int iResult = 0;
            object objResult = null;
            Dal.Models.UserInfo user = User.GetUserInfo(iUserID, conn, trans);
            Dal.Models.Activity activity = Activity.GetActivity(iActivityID, conn, trans);
            StringBuilder sbSql = new StringBuilder();

            switch (user.UserType)
            {
                case "0801":
                    throw new Exception("超级管理员不能被禁用或删除!");
                case "0802": // 系统管理员
                case "0803": // 协会管理员
                case "0804": // 分会用户
                    // 管理员：删除用户，同时删除对应数据：用户专业
                    // 如果用户有申报表审查记录，不允许删除
                    sbSql.Clear();
                    sbSql.Append(" select COUNT(*) from Declaration where QualificationReviewer = ? ");
                    objResult = Dal.OleDbHlper.ExecuteScalar(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@QualificationReviewer", OleDbType.Integer) { Value = iUserID });
                    iResult = Common.ToInt32(objResult) ?? 0;

                    if (iResult > 0)
                    {
                        throw new Exception("用户有申报表审查记录，不允许删除!");
                    }

                    // 删除对应数据：用户专业
                    iResult += RemoveUserSpecialty(iUserID, iActivityID, conn, trans);

                    // 删除用户
                    iResult += DeleteUser(iUserID, conn, trans);

                    break;
                case "0805":
                    // 专家用户：（专家用户在当前活动有专业组、投票信息的，不允许删除禁用，有历史评审信息、投票信息的，不允许删除，但是允许禁用）

                    Dal.Models.Expert expert = Expert.GetExpertByUserID(iUserID, conn, trans);

                    // 判断是否在专业组中
                    sbSql.Clear();
                    sbSql.Append(" select COUNT(*) from GroupMember where ExpertID = ? ");
                    objResult = Dal.OleDbHlper.ExecuteScalar(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = expert.ExpertID });
                    iResult = Common.ToInt32(objResult) ?? 0;

                    if (iResult > 0)
                    {
                        throw new Exception("所选专家已在专业组中，不允许删除!");
                    }

                    // 判断是否有投票信息
                    sbSql.Clear();
                    sbSql.Append(" select COUNT(*) from Vote where Vote.UserID = ? ");
                    objResult = Dal.OleDbHlper.ExecuteScalar(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });

                    iResult = Common.ToInt32(objResult) ?? 0;

                    if (iResult > 0)
                    {
                        throw new Exception("所选专家有投票信息，不允许删除!");
                    }

                    // 删除对应数据：用户专业
                    iResult += RemoveUserSpecialty(iUserID, iActivityID, conn, trans);

                    // 删除专家
                    sbSql.Clear();
                    sbSql.Append(" delete from Expert where ExpertID = ? ");
                    iResult += Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = expert.ExpertID });

                    // 删除用户
                    iResult += DeleteUser(iUserID, conn, trans);

                    break;
                case "0806":
                    // 一级用户：（一级用户当前有申报表进入评审阶段的，不允许删除、禁用，
                    //             一级用户当前没有申报表进入评审阶段，但是历史上有项目进入评审阶段，可以禁用，不能删除）

                    // 判断申报表状态
                    sbSql.Clear();
                    sbSql.Append(" select COUNT(*) from Declaration ");
                    sbSql.Append(" inner join Organization on Organization.OrganizationID = Declaration.OrganizationID ");
                    sbSql.Append(" inner join Prize on Prize.PrizeID = Declaration.PrizeID ");
                    sbSql.Append(" inner join Specialty on Specialty.SpecialtyID = Prize.PrizeID ");
                    sbSql.Append(" inner join Activity on Activity.ActivityID = Specialty.ActivityID ");
                    sbSql.Append(" where Declaration.DeclarationStatus in ('1802', '1803', '1804') ");
                    sbSql.Append(" and Organization.UserID = ? and Activity.ActivityID = ? ");

                    objResult = Dal.OleDbHlper.ExecuteScalar(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID }
                        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
                    iResult = Common.ToInt32(objResult) ?? 0;

                    // 有申报表
                    if (iResult > 0)
                    {
                        throw new Exception("所选用户有申报表进入评审阶段，不允许删除!");
                    }

                    // 删除该用户上传的文件
                    sbSql.Clear();
                    sbSql.Append(" delete from UploadFile ");
                    sbSql.Append(" where (TypeCode in ('DeclarationAppendix','DeclarationAtlas') and OwnerID in ");
                    sbSql.Append(" ( select DeclarationID from Declaration d ");
                    sbSql.Append(" inner join Organization o on o.OrganizationID = d.OrganizationID ");
                    sbSql.Append(" where o.UserID = ?)) or ");
                    sbSql.Append(" (TypeCode = 'DeclarationImage' and OwnerID in ( ");
                    sbSql.Append(" select DataID from dbo.Declaration_Data dd ");
                    sbSql.Append(" inner join Declaration d on d.DeclarationID = dd.DeclarationID ");
                    sbSql.Append(" where d.UserID = ? )) ");
                    iResult = Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID }
                        , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });

                    // 删除申报表_数据
                    sbSql.Clear();
                    sbSql.Append(" delete from Declaration_Data where DeclarationID in ");
                    sbSql.Append(" ( select DeclarationID from Declaration d inner join Organization o ");
                    sbSql.Append(" on o.OrganizationID = d.OrganizationID ");
                    sbSql.Append(" where o.UserID = ?) ");
                    iResult += Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });

                    // 删除申报表
                    sbSql.Clear();
                    sbSql.Append(" delete from Declaration where OrganizationID in ");
                    sbSql.Append(" ( select OrganizationID from Organization where UserID = ?)");
                    iResult += Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });

                    // 删除该一级用户及其二级用户的用户专业
                    sbSql.Clear();
                    sbSql.Append(" delete from UserSpecialty where UserID in (select UserID from dbo.Users where UserID= ? OR CreateUser = ? ) ");
                    iResult += Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID }
                        , new OleDbParameter("@CreateUser", OleDbType.Integer) { Value = iUserID });

                    // 删除该一级用户的二级用户
                    sbSql.Clear();
                    sbSql.Append(" delete from Users where CreateUser = ? ");
                    iResult += Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@CreateUser", OleDbType.Integer) { Value = iUserID });

                    // 删除单位
                    sbSql.Clear();
                    sbSql.Append(" delete from Organization where UserID = ? ");
                    iResult += Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });

                    // 删除用户
                    iResult += DeleteUser(iUserID, conn, trans);

                    break;
                case "0807":
                    // 二级用户：禁用用户，同时删除用户专业、 将归属该用户的申报表划拨到该用户对应的一级用户

                    // 将归属该用户的申报表划拨到该用户对应的一级用户
                    iResult = Declaration.AdjustOwner(iUserID, user.CreateUser.Value, activity.ActivityID.Value, conn, trans);

                    // 删除用户专业
                    iResult += RemoveUserSpecialty(iUserID, activity.ActivityID.Value, conn, trans);

                    // 删除用户
                    iResult += DeleteUser(iUserID, conn, trans);
                    break;
                case "0808":
                    // 删除用户区域
                    sbSql.Clear();
                    sbSql.Append(" delete from UserRegion where UserID = ? ");
                    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                         , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });

                    // 删除用户
                    iResult += DeleteUser(iUserID, conn, trans);
                    break;
                default:
                    break;
            }

            return iResult;
        }

        public static int ResetPassword(int iUserID, string strPassword, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" update Users set ");
            sbSql.Append(" Password = dbo.Fn_MD5Encrypt(?) ");
            sbSql.Append(" ,IsPasswordChanged = 'true'");
            sbSql.Append(" where UserID = ? ");

            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@Password", OleDbType.VarWChar) { Value = strPassword }
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });
        }

        public static int ForbiddenUser(int iUserID,string iUserStatus, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" update Users set ");
            sbSql.Append(" UserStatus = ? ");
            sbSql.Append(" where UserID = ? ");

            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@UserStatus", OleDbType.VarWChar) { Value = iUserStatus }
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });
        }

        /// <summary>
        /// 判断邮箱是否被占用
        /// </summary>
        /// <param name="strEmail"></param>
        /// <returns></returns>
        public static Dal.Models.UserInfo GetUserByMail(string strEmail, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = "select * from Users where Email = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@Email", OleDbType.VarWChar) { Value = strEmail });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.UserInfo>(reader);
        }

        /// <summary>
        /// 判断是否重名
        /// </summary>
        /// <param name="strName"></param>
        /// <returns></returns>
        public static Dal.Models.UserInfo GetUserByName(string strName, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 判断用户名是否存在
            string strSql = "select * from Users where UserName = ? or Email = ?";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@UserName", OleDbType.VarWChar) { Value = strName }
                , new OleDbParameter("@Email", OleDbType.VarWChar) { Value = strName });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.UserInfo>(reader);
        }

        /// <summary>
        /// 创建新用户(管理员、二级用户)
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int CreateUser(Dal.Models.UserInfo user, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            int? iResult;

            if (user == null
                || user.CreateUser == null
                || string.IsNullOrEmpty(user.UserName))
            {
                throw new Exception("用户信息不全！");
            }

            if (string.IsNullOrEmpty(user.UserType))
            {
                Dal.Models.UserInfo userCreator = GetUserInfo(user.CreateUser.Value, conn, tran);
                if (userCreator.UserType == "0801")
                {
                    // 超级管理员创建系统管理员和协会管理员，默认系统管理员
                    user.UserType = "0802";
                }
                else if(userCreator.UserType == "0802" )
                {
                    // 系统管理员创建协会管理员
                    user.UserType = "0803";
                }
                else if (userCreator.UserType == "0803")
                {
                    // 协会管理员创建管理员
                    user.UserType = "0804";
                }
                else if (userCreator.UserType == "0804")
                {
                    // 管理员创建会员用户
                    user.UserType = "0806";
                }
                else if (userCreator.UserType == "0806")
                {
                    // 一级用户创建二级用户
                    user.UserType = "0807";
                }
                else
                {
                    // 参数错误
                    throw new Exception("参数错误！");
                }
            }

            // 判断用户名是否存在
            user.UserName = user.UserName.Trim();
            if (GetUserByName(user.UserName, conn, tran) != null
                || BLL.Organization.GetOrganizationByName(user.UserName, conn, tran) != null
                || BLL.Organization.GetOrganizationByCode(user.UserName, conn, tran) != null)
            {
                // 用户名已存在, 
                throw new Exception("用户名已存在，不可再次创建！");
            }

            user.Email = user.Email.Trim();
            if (!string.IsNullOrEmpty(user.Email))
            {
                if (!Common.IsValidEmail(user.Email))
                {
                    // 邮箱格式错误
                    throw new Exception("邮箱格式错误，请重新填写！");
                }

                if (GetUserByMail(user.Email, conn, tran) != null)
                {
                    // 邮箱已存在, 
                    throw new Exception("邮箱已存在，请换其他邮箱！");
                }
            }

            sbSql.Append("  INSERT INTO Users ( ");
            sbSql.Append("          UserName ");
            sbSql.Append("         ,Password ");
            sbSql.Append("         ,UserType ");
            sbSql.Append("         ,Email    ");
            sbSql.Append("         ,UserStatus ");
            sbSql.Append("         ,CreateTime ");
            sbSql.Append("         ,CreateUser ");
            sbSql.Append("         ,LastUpdateTime ");
            sbSql.Append("         ,IsPasswordChanged ");
            sbSql.Append(" ) VALUES ( ?, dbo.Fn_MD5Encrypt(?), ?, ?, '0701', GetDate(), ?, GetDate(),0) ");

            iResult = Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@UserName", OleDbType.VarWChar) { Value = user.UserName }
                , new OleDbParameter("@Password", OleDbType.VarWChar) { Value = user.Password }
                , new OleDbParameter("@UserType", OleDbType.VarWChar) { Value = user.UserType }
                , new OleDbParameter("@Email", OleDbType.VarWChar) { Value = user.Email }
                , new OleDbParameter("@CreateUser", OleDbType.Integer) { Value = user.CreateUser }
                );

            user.UserID = GetUserByName(user.UserName, conn, tran).UserID;

            Dictionary<string, string> dictAppSettings = SysConstant.GetAppSettingDict("", conn, tran);
            string strSendMailWhenCreateUser = dictAppSettings["SendMailWhenCreateUser"];
            if (strSendMailWhenCreateUser.ToLower() == "true")
            {
                Dal.Models.MailInfo mailinfo = new Dal.Models.MailInfo();
                mailinfo.Subject = "";
                mailinfo.SenderAddress = dictAppSettings["SenderAddress"];
                mailinfo.SmtpAcount = dictAppSettings["SmtpAcount"];
                mailinfo.SmtpPassword = dictAppSettings["SmtpPassword"];
                mailinfo.RecipientAddress.Add(user.Email);
                mailinfo.IsBodyHtml = true;
                mailinfo.Content = "您已成功注册" + dictAppSettings["SystemName"] + "系统的账号！";
                Common.SendMail(mailinfo);
            }

            return user.UserID.Value;
        }

        public static string GetUserSpecialtyIDs(int iUserID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select dbo.Fn_GetUserSpecialtyID(?,dbo.Fn_GetCurrentActivityID())";

            object objResult = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });

            return objResult == null || objResult == DBNull.Value ? "" : objResult.ToString();
        }
        public static List<Dal.Models.UserInfo> GetlstAssociationUser(OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select * from dbo.Users where UserType in('0808','0809')";
            return Dal.OleDbHlper.GetList<Dal.Models.UserInfo>(
                   strSql, conn, CommandType.Text, tran);
        }
        public static string GetUserRegion(int iUserID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select STUFF((SELECT ','+CAST(RegionCode AS VARCHAR(50)) FROM UserRegion WHERE UserID= ? FOR XML PATH('') ),1,1,'') ";
            return Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran, new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID }).ToString();
        }

        public static List<Dal.Models.GroupMember> GetGroupMemberList(int iExpertID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from GroupMember  where ExpertID = ? ";

            return Dal.OleDbHlper.GetList<Dal.Models.GroupMember>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = iExpertID });
        }

        public static void SetUserRegion(int iUserID, string strRegionCodes, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (string.IsNullOrEmpty(strRegionCodes))
            {
                throw new Exception("参数错误");
            }

            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" delete from UserRegion where UserID = ? ");
            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                 , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });

            sbSql.Clear();
            sbSql.AppendFormat(" insert into UserRegion(UserID, RegionCode) select {0}, ConstantCode as RegionCode from SysConstant where ConstantType = '34' and ConstantCode in ({1})"
                , iUserID, strRegionCodes);
            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans);
        }

        /// <summary>
        /// 设定用户的专业
        /// </summary>
        /// <param name="iUserID"></param>
        /// <param name="iActivityID"></param>
        /// <param name="strSpecialtyIDs"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static void SetUserSpecialty(int iUserID, int iActivityID, string strSpecialtyIDs, OleDbConnection conn, OleDbTransaction trans = null)
        {
            RemoveUserSpecialty(iUserID, iActivityID, conn, trans);

            List<string> lstSpecialtyIDs = new List<string>();
            if (!string.IsNullOrEmpty(strSpecialtyIDs))
            {
                string strSql = " insert into UserSpecialty(UserID, SpecialtyID) select " + iUserID.ToString() + ", SpecialtyID from Specialty where SpecialtyID in (" + strSpecialtyIDs + ")";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans);
            }
        }

        public static void AddUserSpecialty(int iUserID, int iSpecialtyID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSqlCount = " select count(*) from UserSpecialty where UserID = ? and SpecialtyID = ? ";
            string strSqlInsert = " insert into UserSpecialty(UserID, SpecialtyID) VALUES (?, ?)";

            int iCount = Convert.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSqlCount, conn, CommandType.Text, trans
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID }
                , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID }));

            if (iCount == 0)
            {
                Dal.OleDbHlper.ExecuteNonQuery(strSqlInsert, conn, CommandType.Text, trans
                    , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID }
                    , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
            }
        }

        public static int RemoveUserSpecialty(int iUserID, int iActivityID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" delete from UserSpecialty where UserID = ? ");
            sbSql.Append(" and SpecialtyID in (select SpecialtyID from Specialty where ActivityID = ?) ");
            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                 , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID }
                 , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
        }

        /// <summary>
        /// 获取会员子用户
        /// </summary>
        /// <param name="user">当前登录用户</param>
        /// <param name="strSearchUserName"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static List<Dal.Models.UserInfo> GetLeaguerChildList(Dal.Models.UserInfo user, string strSearchUserName, OleDbConnection conn, OleDbTransaction trans = null)
        {
            List<OleDbParameter> lstPara = new List<OleDbParameter>();
            string strSql;
            if (user.UserType == "0807")
            {
                strSql = " select * from V_User where UserID = ? ";
                lstPara.Add(new OleDbParameter("@UserID", OleDbType.Integer) { Value = user.UserID.Value });
            }
            else
            {
                strSql = " select * from V_User where UserType='0807' and CreateUser = ? ";
                lstPara.Add(new OleDbParameter("@CreateUser", OleDbType.Integer) { Value = user.UserID.Value });
            }

            if (!string.IsNullOrEmpty(strSearchUserName))
            {
                strSql += " and UserName like ? ";
                lstPara.Add(new OleDbParameter("@UserName", OleDbType.VarWChar) { Value = "%" + strSearchUserName + "%" });
            }
            strSql += " order by CreateTime desc ";

            return Dal.OleDbHlper.GetList<Dal.Models.UserInfo>(strSql, conn, CommandType.Text, trans, lstPara.ToArray());
        }

        public static List<Dal.Models.UserInfo> GetChildUserList(int iUserID, string userName, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select * from Users ";
            if (userName != null && userName.Length > 0)
            {
                strSql += " where UserName like '%" + userName + "%'";
            }
            strSql += " order by CreateTime desc";

            return Dal.OleDbHlper.GetList<Dal.Models.UserInfo>(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@CreateUser", OleDbType.Integer) { Value = iUserID });
        }

        public static List<Dal.Models.UserInfo> GetUserListByUserID(string strUserID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select * from Users where UserID in (" + strUserID + ")  order by CreateTime desc";
            return Dal.OleDbHlper.GetList<Dal.Models.UserInfo>(strSql, conn, CommandType.Text, trans);
        }

        public static DataTable GetOrganizationlist(int iLoginUserID, string SearchUserName, string CheckedUserIDs, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dal.Models.UserInfo user = BLL.User.GetUserInfo(iLoginUserID, conn, trans);
            DataTable dt = new DataTable();
            if ((new List<string> { "0801", "0802", "0803" }).Contains(user.UserType))
            {
                string sbSql = "select u.UserID, UserName, [Password], UserType, Email, UserStatus,";
                sbSql += " LegalPersonName,LegalPersonIDNo, Linkman, MobileNumber,EmailAddress,OrganizationAddress,o.* from Users u";
                sbSql += " left join Organization o on o.UserID = u.UserID where u.UserType = '0806' ";
                if (SearchUserName != null && SearchUserName.Length > 0)
                {
                    sbSql += " AND UserName like '%" + SearchUserName + "%'";
                }
                if (CheckedUserIDs != null && CheckedUserIDs.Length > 0)
                {
                    sbSql += " AND u.UserID in(" + CheckedUserIDs + ")";
                }
                sbSql += " order by u.CreateTime desc";
                dt = Dal.OleDbHlper.GetDataTable(sbSql, conn, CommandType.Text);
            }
            else if ((new List<string> { "0804" }).Contains(user.UserType))
            {
            }
            else if ((new List<string> { "0806" }).Contains(user.UserType))
            {
                // 一级用户：获取子用户
                //lstUser = GetChildUserListAllInfo(iLoginUserID, conn, trans);
                //一级用户：获取本用户的信息

                string strSql = " select u.UserID, UserName, [Password], UserType, Email, UserStatus,";
                strSql += "LegalPersonName,LegalPersonIDNo, Linkman, MobileNumber,EmailAddress,OrganizationAddress,o.* from Users u";
                strSql += " left join Organization o on o.UserID = u.UserID where u.UserID = " + iLoginUserID;
                if (SearchUserName != null && SearchUserName.Length > 0)
                {
                    strSql += " AND u.UserName like '%" + SearchUserName + "%'";
                }
                strSql += "  order by u.CreateTime desc";
                dt = Dal.OleDbHlper.GetDataTable(strSql, conn, CommandType.Text);
            }
            return dt;
        }

        public static List<Dal.Models.UserOrg> GetLeaguerUserList(int iLoginUserID, string SearchUserName, Dal.Models.PageInfo<Dal.Models.UserOrg> pgif, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dal.Models.UserInfo user = GetUserInfo(iLoginUserID, conn, trans);
            List<Dal.Models.UserOrg> lstUser = null;
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" select u.UserID, UserName, [Password], UserType, Email, UserStatus,s.ConstantValue UserStatusText,");
            sbSql.Append("LegalPersonName,LegalPersonIDNo, Linkman,TelephoneNumber, MobileNumber,EmailAddress,OrganizationAddress,OrganizationName from Users u");
            sbSql.Append(" left join Organization o on o.UserID = u.UserID ");
            sbSql.Append(" left join SysConstant s on s.ConstantCode = u.UserStatus");
            sbSql.Append(" where u.UserType='0806'");

            // 超级管理员、系统管理员、协会管理员：获取全部用户, 一级用户：获取本用户的信息
            if (!(new List<string> { "0801", "0802", "0803" }).Contains(user.UserType))
            {
                sbSql.AppendFormat(" and u.UserID = {0}", iLoginUserID);
            }

            if (SearchUserName != null && SearchUserName.Length > 0)
            {
                sbSql.Append(" and u.UserName like '%" + SearchUserName + "%'");
            }

            sbSql.Append(" order by u.CreateTime desc ");
            lstUser = Dal.OleDbHlper.GetList<Dal.Models.UserOrg>(sbSql.ToString(), pgif, conn, trans);

            return lstUser;
        }

        public static List<Dal.Models.UserInfo> GetManagerList(Dal.Models.UserInfo userLogin, string strUserName, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (userLogin == null)
            {
                return null;
            }

            List<Dal.Models.UserInfo> lstUser = null;
            StringBuilder sbSql = new StringBuilder();

            switch (userLogin.UserType)
            {
                case "0801": // 超级管理员 ：获取超级管理员、系统管理员、协会管理员、分会用户、地方用户、同业协会用户
                case "0802": // 系统管理员 : 返回系统管理员、协会管理员、分会用户、地方用户、同业协会用户
                case "0803": // 协会管理员 : 返回协会管理员、分会用户、地方用户、同业协会用户
                    sbSql.Append(" select * from V_User u ");
                    sbSql.AppendFormat(" where ((u.UserType >= '{0}' and u.UserType <= '0804') or u.UserType in ('0808','0809')) ", userLogin.UserType);
                    if (!string.IsNullOrEmpty(strUserName))
                    {
                        sbSql.Append(" AND u.UserName like ? ");
                    }
                    sbSql.Append(" order by u.UserType, u.CreateTime desc ");
                    lstUser = Dal.OleDbHlper.GetList<Dal.Models.UserInfo>(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@UserName", OleDbType.VarWChar) { Value = "%" + strUserName + "%" });
                    break;
                case "0804": // 分会用户 : 返回当前登录用户
                case "0808": // 地方协会 : 返回当前登录用户
                case "0809": // 同业协会 : 返回当前登录用户
                    sbSql.Append(" select * from V_User u ");
                    sbSql.AppendFormat(" where u.UserID = {0} ", userLogin.UserID);

                    if (!string.IsNullOrEmpty(strUserName))
                    {
                        sbSql.Append(" AND u.UserName like '%" + strUserName + "%'");
                    }
                    sbSql.Append(" order by u.UserType, u.CreateTime desc ");
                    lstUser = Dal.OleDbHlper.GetList<Dal.Models.UserInfo>(sbSql.ToString(), conn, CommandType.Text, trans
                        , new OleDbParameter("@UserName", OleDbType.VarWChar) { Value = "%" + strUserName + "%" });
                    break;
            }

            return lstUser;
        }

        public static Dal.Models.Organization GetOrganization(int iUserID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" select  o.* from Organization o ");
            sbSql.Append(" inner join Users u on u.UserID = o.UserID ");
            sbSql.Append(" left join Users u2 on u2.CreateUser = o.UserID ");
            sbSql.Append(" where u.UserID = ? or u2.UserID = ? order by u.CreateTime desc ");

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@UserID", OleDbType.VarWChar) { Value = iUserID }
                , new OleDbParameter("@UserID2", OleDbType.VarWChar) { Value = iUserID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Organization>(reader);
        }

        public static int GetOrganizationCount(OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select count(*) from Users u where u.UserStatus = '0701' and UserType = '0806' ";

            object objResult = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, trans);

            int? iResult = Common.ToInt32(objResult);

            return iResult ?? 0;
        }

        public static int GetOrganizationChildCount(OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select count(*) from Users u where u.UserStatus = '0701' and UserType = '0807' ";

            object objResult = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, trans);

            int? iResult = Common.ToInt32(objResult);

            return iResult ?? 0;
        }
    }
}
