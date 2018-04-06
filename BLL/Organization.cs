using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Linq;

namespace BLL
{
    public class Organization
    {
        public static Dal.Models.Organization GetOrganization(int iOrganizationID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Organization where OrganizationID = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OrganizationID", OleDbType.Integer) { Value = iOrganizationID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Organization>(reader);
        }

        public static Dal.Models.Organization GetOrganizationByName(string strOrganizationName, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Organization where OrganizationName = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OrganizationName", OleDbType.VarWChar) { Value = strOrganizationName });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Organization>(reader);
        }

        public static Dal.Models.Organization GetOrganizationByCode(string strOrganizationCode, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Organization where OrganizationCode = ? or UnifiedCode = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OrganizationCode", OleDbType.VarWChar) { Value = strOrganizationCode }
                , new OleDbParameter("@UnifiedCode", OleDbType.VarWChar) { Value = strOrganizationCode });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Organization>(reader);
        }

        public static Dal.Models.Organization GetOrganizationByUser(int iUserID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select o.OrganizationID,o.UserID, o.OrganizationName, o.Abbreviation, o.UnifiedCode, o.OrganizationCode, o.OrganizationAddress ";
            strSql += " , o.LegalPersonName, o.LegalPersonIDNo, o.Linkman, o.MobileNumber, o.TelephoneNumber, o.Postcode, o.FaxNumber, o.EmailAddress";
                strSql += " , o.CreateTime, o.LastUpdateTime,Password, u.UserName";
                strSql += " from Organization o left join Users u on u.UserID = o.UserID  where o.UserID = ? order by o.OrganizationName ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Organization>(reader);
        }

        /// <summary>
        /// 判断机构代码是不是有效的
        /// </summary>
        /// <param name="organizationCertificate">机构代码</param>
        /// <returns></returns>
        public static bool IsOrganizationCode(String organizationCertificate)
        {
            String temp = organizationCertificate.ToUpper();
            if (temp.Contains("-"))
            {
                temp = temp.Replace("-", "");
            }

            if (temp.Length != 9)
            {
                return false;
            }

            // 获取前面8位  
            String pre8 = temp.Substring(0, 8);
            char[] pre8chars = pre8.ToCharArray();// 0~z;  

            // 加权因子
            int[] power = { 3, 7, 9, 10, 5, 8, 4, 2 };
            int sum = 0;
            for (int i = 0; i < pre8chars.Length; i++)
            {
                int intTemp = pre8chars[i] > '9' ? (pre8chars[i] - 'A' + 10) : Int32.Parse(pre8chars[i].ToString());
                sum += intTemp * power[i];
            }

            // 计算校验码
            String codeTEmp = (11 - sum % 11) == 10 ? "X" : (11 - sum % 11) == 11 ? 0 + "" : (11 - sum % 11) + "";

            // 获取校验码  
            String code = temp.Substring(8, 1);

            // 判断机构代码的校验码和计算出的校验码是否一致
            return code.Equals(codeTEmp);
        }

        /// <summary>
        /// 统一社会信用代码校验
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool IsSocialCreditCode(string code)
        {
            if (code == null || code.Length != 18)
            {
                return false;
            }

            code = code.ToUpper();

            // 加权因子
            int[] factor = { 1, 3, 9, 27, 19, 26, 16, 17, 20, 29, 25, 13, 8, 24, 10, 30, 28 };

            // 校验基数
            string str = "0123456789ABCDEFGHJKLMNPQRTUWXY";

            int total = factor.Select((p, i) => p * str.IndexOf(code[i])).Sum();

            int index = total % 31 == 0 ? 0 : (31 - total % 31);

            return str[index] == code.Last();
        }

        public static int CreateOrganization(Dal.Models.Organization org, int iCurrentUserID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (string.IsNullOrEmpty(org.OrganizationName) || string.IsNullOrEmpty(org.OrganizationCode))
            {
                return -1;
            }

            // 判断重名
            if (GetOrganizationByName(org.OrganizationName, conn, trans) != null)
            {
                throw new Exception("单位名已存在!");
            }

            if (IsSocialCreditCode(org.OrganizationCode))
            {
                org.UnifiedCode = org.OrganizationCode;

                // 社会统一代码和组织机构代码对应关系：
                // 营业执照：全部号码
                // 组织机构代码：第9位至倒数第2位，共9位数 
                // 税务登记证号码：第3位至倒数第2位，共15位数
                org.OrganizationCode = org.UnifiedCode.Substring(9, 9);
            }
            //else
            //{
            //    if (!IsOrganizationCode(org.OrganizationCode))
            //    {
            //        throw new Exception("组织机构代码或社会统一代码输入错误，请检查后再次输入!");
            //    }
            //}

            // 判断组织机构代码
            if (GetOrganizationByCode(org.OrganizationCode, conn, trans) != null)
            {
                throw new Exception("组织机构代码已存在!");
            }

            if (org.CreateTime == null || org.LastUpdateTime == null)
            {
                org.CreateTime = DateTime.Now;
                org.LastUpdateTime = org.CreateTime;
            }

            Dal.Models.UserInfo user = new Dal.Models.UserInfo();
            user.UserName = string.IsNullOrEmpty(org.UserName) ? org.OrganizationName : org.UserName;
            //org.Password; //user.DefaultPassword;
            user.Password = string.IsNullOrEmpty(org.UnifiedCode) ? org.OrganizationCode : org.UnifiedCode;
            user.Email = org.EmailAddress;
            user.UserStatus = "0701";
            user.UserType = "0806";
            user.CreateTime = org.CreateTime;
            user.LastUpdateTime = org.CreateTime;
            user.CreateUser = iCurrentUserID;
            user.IsPasswordChanged = false;

            // 创建用户
            int iResult = User.CreateUser(user, conn, trans);  
            if (iResult <= 0)
            {
                return iResult;
            }

            string strPwd = BLL.SysConstant.GetAppSettings("DefaultPassword", conn, trans);
            BLL.User.ResetPassword(iResult, strPwd, conn, trans);
            user.UserID = iResult;

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO Organization(        ");
            sbSql.Append("            UserID                ");
            sbSql.Append("           ,OrganizationName      ");
            sbSql.Append("           ,Abbreviation          ");
            sbSql.Append("           ,UnifiedCode           ");
            sbSql.Append("           ,OrganizationCode      ");
            sbSql.Append("           ,OrganizationAddress   ");
            sbSql.Append("           ,LegalPersonName       ");
            sbSql.Append("           ,LegalPersonIDNo       ");
            sbSql.Append("           ,Linkman               ");
            sbSql.Append("           ,MobileNumber          ");
            sbSql.Append("           ,TelephoneNumber       ");
            sbSql.Append("           ,Postcode              ");
            sbSql.Append("           ,FaxNumber             ");
            sbSql.Append("           ,EmailAddress          ");
            sbSql.Append("           ,CreateTime            ");
            sbSql.Append("           ,LastUpdateTime        ");
            sbSql.Append("    ) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?) ");
            iResult = Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = user.UserID }
                , new OleDbParameter("@OrganizationName", OleDbType.VarWChar) { Value = org.OrganizationName }
                , new OleDbParameter("@Abbreviation", OleDbType.VarWChar) { Value = org.Abbreviation }
                , new OleDbParameter("@UnifiedCode", OleDbType.VarWChar) { Value = org.UnifiedCode }
                , new OleDbParameter("@OrganizationCode", OleDbType.VarWChar) { Value = org.OrganizationCode }
                , new OleDbParameter("@OrganizationAddress", OleDbType.VarWChar) { Value = org.OrganizationAddress }
                , new OleDbParameter("@LegalPersonName", OleDbType.VarWChar) { Value = org.LegalPersonName }
                , new OleDbParameter("@LegalPersonIDNo", OleDbType.VarWChar) { Value = org.LegalPersonIDNo }
                , new OleDbParameter("@Linkman", OleDbType.VarWChar) { Value = org.Linkman }
                , new OleDbParameter("@MobileNumber", OleDbType.VarWChar) { Value = org.MobileNumber }
                , new OleDbParameter("@TelephoneNumber", OleDbType.VarWChar) { Value = org.TelephoneNumber }
                , new OleDbParameter("@Postcode", OleDbType.VarWChar) { Value = org.Postcode }
                , new OleDbParameter("@FaxNumber", OleDbType.VarWChar) { Value = org.FaxNumber }
                , new OleDbParameter("@EmailAddress", OleDbType.VarWChar) { Value = org.EmailAddress }
                , new OleDbParameter("@CreateTime", OleDbType.Date) { Value = org.CreateTime }
                , new OleDbParameter("@LastUpdateTime", OleDbType.Date) { Value = org.LastUpdateTime });

            if (iResult > 0)
            {
                org = GetOrganizationByName(org.OrganizationName, conn, trans);
                iResult = org.OrganizationID.Value;
            }

            return iResult;
        }

        public static int DeleteOrganization(int iOrganizationID, int iActivityID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dal.Models.Organization org = GetOrganization(iOrganizationID, conn, trans);
            return User.DeleteUser(org.UserID.Value, iActivityID, conn, trans);
        }

        public static int UpdateOrganization(Dal.Models.Organization organization, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" update Organization set ");
            sbSql.Append(" OrganizationName = ? , ");
            sbSql.Append(" Abbreviation = ? , ");
            sbSql.Append(" UnifiedCode = ?, ");
            sbSql.Append(" OrganizationCode = ?, ");
            sbSql.Append(" OrganizationAddress = ?, ");
            sbSql.Append(" LegalPersonName = ?, ");
            sbSql.Append(" LegalPersonIDNo = ?, ");
            sbSql.Append(" Linkman = ?, ");
            sbSql.Append(" MobileNumber = ?, ");
            sbSql.Append(" TelephoneNumber = ?, ");
            sbSql.Append(" Postcode = ?, ");
            sbSql.Append(" FaxNumber = ?, ");
            sbSql.Append(" EmailAddress = ?, ");
            sbSql.Append(" LastUpdateTime = ? ");
            sbSql.Append(" where OrganizationID = ? ;");
            sbSql.Append(" update Users set UserName= ?, Email = ? where UserID = ? ");

            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                  , new OleDbParameter("@OrganizationName", OleDbType.VarWChar) { Value = organization.OrganizationName }
                  , new OleDbParameter("@Abbreviation", OleDbType.VarWChar) { Value = organization.Abbreviation }
                  , new OleDbParameter("@UnifiedCode", OleDbType.VarWChar) { Value = organization.UnifiedCode }
                  , new OleDbParameter("@OrganizationCode", OleDbType.VarWChar) { Value = organization.OrganizationCode }
                  , new OleDbParameter("@OrganizationAddress", OleDbType.VarWChar) { Value = organization.OrganizationAddress }
                  , new OleDbParameter("@LegalPersonName", OleDbType.VarWChar) { Value = organization.LegalPersonName }
                  , new OleDbParameter("@LegalPersonIDNo", OleDbType.VarWChar) { Value = organization.LegalPersonIDNo }
                  , new OleDbParameter("@Linkman", OleDbType.VarWChar) { Value = organization.Linkman }
                  , new OleDbParameter("@MobileNumber", OleDbType.VarWChar) { Value = organization.MobileNumber }
                  , new OleDbParameter("@TelephoneNumber", OleDbType.VarWChar) { Value = organization.TelephoneNumber }
                  , new OleDbParameter("@Postcode", OleDbType.VarWChar) { Value = organization.Postcode }
                  , new OleDbParameter("@FaxNumber", OleDbType.VarWChar) { Value = organization.FaxNumber }
                  , new OleDbParameter("@EmailAddress", OleDbType.VarWChar) { Value = organization.EmailAddress }
                  , new OleDbParameter("@LastUpdateTime", OleDbType.Date) { Value = DateTime.Now }
                  , new OleDbParameter("@OrganizationID", OleDbType.Integer) { Value = organization.OrganizationID }
                  , new OleDbParameter("@UserName", OleDbType.VarWChar) { Value = organization.UserName }
                  , new OleDbParameter("@Email", OleDbType.VarWChar) { Value = organization.EmailAddress }
                  , new OleDbParameter("@UserID", OleDbType.Integer) { Value = organization.UserID }
                  );
        }
    }
}
