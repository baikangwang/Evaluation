using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UploadFileInfo
    {
        /// <summary>
        /// 根据类别查询
        /// </summary>
        /// <param name="iOwnerID"></param>
        /// <param name="iCorrelationID"></param>
        /// <param name="strTypeCode"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static Dal.Models.UploadFileInfo GetUploadFile(int iOwnerID, int? iCorrelationID, string strTypeCode, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (string.IsNullOrEmpty(strTypeCode))
            {
                throw new NoNullAllowedException("文件类别不允许为空！");
            }

            if (strTypeCode != "NoticeAppendix" && strTypeCode != "DeclarationAppendix" && strTypeCode != "DeclarationMedia" && strTypeCode != "UpdateContent" && strTypeCode != "UpdateSqlText" && strTypeCode != "UpdatePackage" && strTypeCode != "UpdateSourceCode")
            {
                throw new NoNullAllowedException("文件类别错误！");
            }

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" select f.UploadFileID, f.TypeCode, f.OwnerID, f.CorrelationID ");
            sbSql.Append(" , case f.TypeCode when 'NoticeAppendix' then 'Notice' ");
            sbSql.Append("                   when 'DeclarationAppendix' then ap.AppendixName ");
            sbSql.Append("                   when 'DeclarationMedia' then m.MediaName ");
            sbSql.Append("   end CorrelationName ");
            sbSql.Append(" ,  f.FileName, REPLACE(f.URL, '\\','/') URL, f.UploadTime ");
            sbSql.Append(" from UploadFile f ");
            sbSql.Append(" left join Atlas at on at.AtlasID = f.CorrelationID ");
            sbSql.Append(" left join Appendix ap on ap.AppendixID = f.CorrelationID ");
            sbSql.Append(" left join Media m on m.MediaID = f.CorrelationID ");

            List<OleDbParameter> lstParameter = new List<OleDbParameter>();
            string strCondition = "";
            strCondition += " where OwnerID = ? and TypeCode = ? ";
            lstParameter.Add(new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID });
            lstParameter.Add(new OleDbParameter("@TypeCode", OleDbType.VarWChar) { Value = strTypeCode });

            if (iCorrelationID != null)
            {
                strCondition += " and CorrelationID = ? ";
                lstParameter.Add(new OleDbParameter("@CorrelationID", OleDbType.Integer) { Value = iCorrelationID });
            }

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(sbSql.ToString() + strCondition, conn, CommandType.Text, tran, lstParameter.ToArray());

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.UploadFileInfo>(reader);
        }

        public static bool IsExsitData(string strTypeCode, int iCorrelationID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select count(*) from UploadFile  where CorrelationID= ? and TypeCode= ? ";

            object objResult = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@CorrelationID", OleDbType.Integer) { Value = iCorrelationID }
                 , new OleDbParameter("@TypeCode", OleDbType.VarWChar) { Value = strTypeCode });

            return objResult == null ? false : Convert.ToInt32(objResult) > 0;
        }

        public static List<Dal.Models.UploadFileInfo> GetFileList(int? iOwnerID, int? iCorrelationID, string strTypeCode, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" select f.UploadFileID, f.TypeCode, f.OwnerID, f.CorrelationID ");
            sbSql.Append(" , case when isnull(f.CorrelationID,0) = 0  then 'Notice' else ISNULL(Atlas.AtlasName, Appendix.AppendixName) end CorrelationName ");
            sbSql.Append(" ,  f.FileName, REPLACE(f.URL, '\\','/') URL, f.UploadTime ");
            sbSql.Append(" from UploadFile f ");
            sbSql.Append(" left join Atlas on Atlas.AtlasID = f.CorrelationID ");
            sbSql.Append(" left join Appendix on Appendix.AppendixID = f.CorrelationID ");

            List<OleDbParameter> lstParameter = new List<OleDbParameter>();
            string strCondition = "";
            if (!string.IsNullOrEmpty(strTypeCode))
            {
                strCondition += " TypeCode like ? and ";
                lstParameter.Add(new OleDbParameter("@TypeCode", OleDbType.VarWChar) { Value = "%" + strTypeCode + "%" });
            }

            if (iOwnerID != null)
            {
                strCondition += " OwnerID = ?  and ";
                lstParameter.Add(new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID });
            }

            if (iCorrelationID != null)
            {
                strCondition += " CorrelationID = ? and ";
                lstParameter.Add(new OleDbParameter("@CorrelationID", OleDbType.Integer) { Value = iCorrelationID });
            }

            if (!string.IsNullOrEmpty(strCondition))
            {
                strCondition = " where " + strCondition.TrimEnd(" and ".ToArray());
            }

            return Dal.OleDbHlper.GetList<Dal.Models.UploadFileInfo>(sbSql.ToString() + strCondition, conn, CommandType.Text, tran, lstParameter.ToArray());
        }

        public static List<Dal.Models.UploadFileInfo> GetAppendixList(int iDeclarationID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" select f.UploadFileID, f.TypeCode, f.OwnerID, f.CorrelationID ");
            sbSql.Append(" ,a.AppendixID, a.AppendixName  CorrelationName, a.SizeLimit, a.UploadLimitMax AmountLimit, a.IsRequired ");
            sbSql.Append(" , f.FileName, REPLACE(f.URL, '\\','/') URL, f.UploadTime ");
            sbSql.Append(" from Appendix a ");
            sbSql.Append(" inner join Prize p on p.SpecialtyID = a.SpecialtyID ");
            sbSql.Append(" inner join Declaration d on d.AdjustedPrize = p.PrizeID ");
            sbSql.Append(" left join UploadFile f on f.CorrelationID = a.AppendixID ");
            sbSql.Append(" and f.TypeCode = 'DeclarationAppendix' and f.OwnerID = d.DeclarationID ");
            sbSql.Append(" where d.DeclarationID = ? ");

            return Dal.OleDbHlper.GetList<Dal.Models.UploadFileInfo>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID });
        }

        public static List<Dal.Models.UploadFileInfo> GetAtlasList(int iDeclarationID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            return GetAtlasList(iDeclarationID, null, conn, tran);
        }

        public static List<Dal.Models.UploadFileInfo> GetAtlasList(int iDeclarationID, int? iAtlasID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            List<OleDbParameter> lstPara = new List<OleDbParameter>();

            sbSql.Append(" select f.UploadFileID, f.TypeCode, f.OwnerID, f.CorrelationID ");
            sbSql.Append(" ,a.AtlasID, a.AtlasName  CorrelationName, a.SizeLimit, a.UploadLimitMax AmountLimit, a.IsRequired ");
            sbSql.Append(" , f.FileName, REPLACE(f.URL, '\\','/') URL, f.UploadTime ");
            sbSql.Append(" from Atlas a ");
            sbSql.Append(" inner join Prize p on p.SpecialtyID = a.SpecialtyID ");
            sbSql.Append(" inner join Declaration d on d.AdjustedPrize = p.PrizeID ");
            sbSql.Append(" left join UploadFile f on f.CorrelationID = a.AtlasID ");
            sbSql.Append(" and f.TypeCode = 'DeclarationAtlas' and f.OwnerID = d.DeclarationID ");
            sbSql.Append(" where d.DeclarationID = ?  ");
            lstPara.Add(new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID });

            if (iAtlasID != null)
            {
                sbSql.Append(" and a.AtlasID = ? ");
                lstPara.Add(new OleDbParameter("@AtlasID", OleDbType.Integer) { Value = iAtlasID });
            }
            sbSql.Append(" order by a.AtlasID, f.UploadTime  ");
            return Dal.OleDbHlper.GetList<Dal.Models.UploadFileInfo>(
                sbSql.ToString(), conn, CommandType.Text, tran, lstPara.ToArray());
        }

        public static List<Dal.Models.UploadFileInfo> GetMediaList(int iDeclarationID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" select f.UploadFileID, f.TypeCode, f.OwnerID, f.CorrelationID ");
            sbSql.Append(" ,m.MediaID, m.MediaName CorrelationName, m.SizeLimit, m.IsRequired ");
            sbSql.Append(" , f.FileName, REPLACE(f.URL, '\\','/') URL, f.UploadTime ");
            sbSql.Append(" from Media m ");
            sbSql.Append(" inner join Prize p on p.SpecialtyID = m.SpecialtyID ");
            sbSql.Append(" inner join Declaration d on d.AdjustedPrize = p.PrizeID ");
            sbSql.Append(" left join UploadFile f on f.CorrelationID = m.MediaID ");
            sbSql.Append(" and f.TypeCode = 'DeclarationMedia' and f.OwnerID = d.DeclarationID ");
            sbSql.Append(" where d.DeclarationID = ? ");

            return Dal.OleDbHlper.GetList<Dal.Models.UploadFileInfo>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID });
        }

        public static Dal.Models.UploadFileInfo GetUploadFile(int iUploadFileID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" select f.UploadFileID, f.TypeCode, f.OwnerID, f.CorrelationID ");
            sbSql.Append(" , case when isnull(f.CorrelationID,0) = 0  then 'Notice' else ISNULL(Atlas.AtlasName, Appendix.AppendixName) end CorrelationName ");
            sbSql.Append(" ,  f.FileName, REPLACE(f.URL, '\\','/') URL, f.UploadTime ");
            sbSql.Append(" from UploadFile f ");
            sbSql.Append(" left join Atlas on Atlas.AtlasID = f.CorrelationID ");
            sbSql.Append(" left join Appendix on Appendix.AppendixID = f.CorrelationID ");
            sbSql.Append(" where f.UploadFileID = ? ");

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(sbSql.ToString(), conn, CommandType.Text, tran
                 , new OleDbParameter("@UploadFileID", OleDbType.Integer) { Value = iUploadFileID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.UploadFileInfo>(reader);
        }

        public static void LoadFile(Dal.Models.UploadFileInfo file, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (file == null || file.UploadFileID == null)
            {
                throw new NullReferenceException("文件编号不允许为空！");
            }

            StringBuilder sb = new StringBuilder();
            string strSql = " SELECT UploadFileID,TypeCode,OwnerID,CorrelationID,FileName,URL,UploadTime FROM UploadFile where UploadFileID = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@UploadFileID", OleDbType.Integer) { Value = file.UploadFileID });

            if (reader.Read())
            {
                if (string.IsNullOrEmpty(file.URL))
                {
                    file.URL = reader["URL"].ToString();
                }

                file.URL = file.URL.Replace("/", "\\");

                if (file.URL.Contains("Evaluation\\WebSite\\Content"))
                {
                    file.URL = file.URL.Substring(file.URL.IndexOf("Evaluation\\WebSite\\Content") + "Evaluation\\WebSite\\".Length + 1);
                }                
            }

            reader.Close();

            string strFileName = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + file.URL;
            if (!File.Exists(strFileName))
            {
                strSql = " SELECT FileContent FROM UploadFile where UploadFileID = ? ";
                reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@UploadFileID", OleDbType.Integer) { Value = file.UploadFileID });

                if (reader.Read())
                {
                    if (reader["FileContent"] != null && reader["FileContent"] != DBNull.Value)
                    {
                        byte[] byteFileContent = (byte[])reader["FileContent"];
                        if (byteFileContent != null && byteFileContent.LongLength > 0)
                        {
                            BLL.Compression.DecompressFile(byteFileContent, strFileName);
                        }
                        else
                        {
                            throw new Exception("找不到指定的文件!");
                        }
                    }
                    else
                    {
                        //throw new Exception("找不到指定的文件!");
                    }                    
                }                
            }

        }

        public static void SaveFile(Dal.Models.UploadFileInfo file, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRootDirectory = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;

            if (file.SizeLimit == null || file.AmountLimit == null)
            {
                switch (file.Type)
                {
                    case Dal.Models.FileType.DeclarationAppendix:
                        Dal.Models.Appendix AppendixInfo = BLL.Appendix.GetAppendix(file.CorrelationID.Value, conn, tran);

                        file.SizeLimit = AppendixInfo.SizeLimit;
                        file.AmountLimit = 1;
                        break;
                    case Dal.Models.FileType.DeclarationAtlas:
                        Dal.Models.Atlas AtlasInfo = BLL.Atlas.GetAtlas(file.CorrelationID.Value, conn, tran);

                        file.SizeLimit = AtlasInfo.SizeLimit;
                        file.AmountLimit = AtlasInfo.UploadLimitMax;
                        break;
                    case Dal.Models.FileType.DeclarationMedia:
                        Dal.Models.Media media = BLL.Media.GetMedia(file.CorrelationID.Value, conn, tran);

                        file.SizeLimit = media.SizeLimit;
                        file.AmountLimit = 1;
                        break;
                    default:
                        file.SizeLimit = 0;
                        file.AmountLimit = 0;
                        break;
                }
            }

            byte[] bufferCompressed = null;
            StringBuilder sb = new StringBuilder();
            int iResult = 0;

            try
            {
                using (System.IO.FileStream StreamToZip = new System.IO.FileStream(
                    strRootDirectory + file.URL, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    double dfileSize = StreamToZip.Length / 1048576;
                    if (dfileSize > file.SizeLimit && file.SizeLimit != 0)
                    {
                        throw new Exception("上传文件大小超过设置范围内!");
                    }

                    //try
                    //{
                    //    bufferCompressed = Compression.CompressFile(StreamToZip);
                    //}
                    //catch
                    //{
                    //    bufferCompressed = null;
                    //}
                }

                if (file.CorrelationID == null)
                {
                    sb.Append(" select UploadFileID from UploadFile where OwnerID = ? and FileName = ? ");
                    iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(sb.ToString(), conn, CommandType.Text, tran
                        , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = file.OwnerID }
                        , new OleDbParameter("@FileName", OleDbType.VarWChar) { Value = file.FileName })) ?? 0;

                    if (iResult > 0 && iResult != file.UploadFileID)
                    {
                        throw new Exception("文件名重名！");
                    }

                    if (file.UploadFileID == null)
                    {
                        InsertFile(file, bufferCompressed, conn, tran);
                    }
                    else
                    {
                        UpdateFile(file, bufferCompressed, conn, tran);
                    }
                }
                else
                {
                    if (file.Type.ToString() == "DeclarationAtlas")
                    {
                        sb.Append(" select UploadFileID from UploadFile where OwnerID = ? and CorrelationID = ? and FileName = ? ");
                        iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(sb.ToString(), conn, CommandType.Text, tran
                            , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = file.OwnerID }
                            , new OleDbParameter("@CorrelationID", OleDbType.Integer) { Value = file.CorrelationID }
                            , new OleDbParameter("@FileName", OleDbType.VarWChar) { Value = file.FileName })) ?? 0;

                        if (iResult == 0)
                        {
                            List<Dal.Models.UploadFileInfo> lstUploadFileInfo = BLL.UploadFileInfo.GetFileList(
                               file.OwnerID, file.CorrelationID, "DeclarationAtlas", conn, tran);

                            if (lstUploadFileInfo.Count() == file.AmountLimit && file.AmountLimit != 0)
                            {
                                throw new Exception("超过数量上限！");
                            }

                            InsertFile(file, bufferCompressed, conn, tran);
                        }
                        else
                        {
                            if (file.UploadFileID == null || iResult == file.UploadFileID.Value)
                            {
                                file.UploadFileID = iResult;
                                UpdateFile(file, bufferCompressed, conn, tran);
                            }
                            else
                            {
                                throw new Exception("文件名重名！");
                            }
                        }
                    }
                    else
                    {
                        sb.Append(" select UploadFileID from UploadFile where OwnerID = ? and CorrelationID = ? and TypeCode = ? ");
                        iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(sb.ToString(), conn, CommandType.Text, tran
                            , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = file.OwnerID }
                            , new OleDbParameter("@CorrelationID", OleDbType.Integer) { Value = file.CorrelationID }
                            , new OleDbParameter("@TypeCode", OleDbType.VarWChar) { Value = file.Type })) ?? 0;

                        if (iResult > 0)
                        {
                            file.UploadFileID = iResult;
                            UpdateFile(file, bufferCompressed, conn, tran);
                        }
                        else
                        {
                            InsertFile(file, bufferCompressed, conn, tran);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sb = null;
                bufferCompressed = null;

                GC.Collect();
            }
        }

        public static void InsertFile(Dal.Models.UploadFileInfo file, byte[] bufferCompressed, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(" insert into UploadFile(TypeCode, OwnerID, CorrelationID, FileName, FileContent, URL, UploadTime) ");
            sb.Append(" values(?, ?, ?, ?, ?, ?, ?) ");
            Dal.OleDbHlper.ExecuteNonQuery(sb.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@TypeCode", OleDbType.VarWChar) { Value = file.Type.ToString() }
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = file.OwnerID }
                , new OleDbParameter("@CorrelationID", OleDbType.Integer) { Value = file.CorrelationID }
                , new OleDbParameter("@FileName", OleDbType.VarWChar) { Value = file.FileName }
                , new OleDbParameter("@FileContent", OleDbType.VarBinary) { Value = bufferCompressed }
                , new OleDbParameter("@URL", OleDbType.VarWChar) { Value = file.URL }
                , new OleDbParameter("@UploadTime", OleDbType.Date) { Value = DateTime.Now });
        }

        public static void UpdateFile(Dal.Models.UploadFileInfo file, byte[] bufferCompressed, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(" update UploadFile set FileName = ?, FileContent = ?, URL = ?, UploadTime = ? ");
            sb.Append(" where UploadFileID = ? ");
            Dal.OleDbHlper.ExecuteNonQuery(sb.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@FileName", OleDbType.VarWChar) { Value = file.FileName }
                , new OleDbParameter("@FileContent", OleDbType.VarBinary) { Value = bufferCompressed }
                , new OleDbParameter("@URL", OleDbType.VarWChar) { Value = file.URL }
                , new OleDbParameter("@UploadTime", OleDbType.Date) { Value = DateTime.Now }
                , new OleDbParameter("@UploadFileID", OleDbType.Integer) { Value = file.UploadFileID });
        }

        public static void DownLoadFile(int iOwnerID, string strTypeCode, string strPath, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from UploadFile  where OwnerID = ? and TypeCode= ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID }
                 , new OleDbParameter("@TypeCode", OleDbType.VarWChar) { Value = strTypeCode });

            string strFileName = "";
            string strFolderName = "";
            try
            {
                while (reader.Read())
                {
                    byte[] File = BLL.Compression.DecompressBytes((byte[])reader["FileContent"]);

                    switch (strTypeCode)
                    {
                        case "DeclarationAppendix":
                            strFolderName = "/附件/" + BLL.Appendix.GetAppendix(Convert.ToInt32(reader["CorrelationID"]), conn, tran).AppendixName;
                            break;
                        case "DeclarationAtlas":
                            strFolderName = "/图集/" + BLL.Atlas.GetAtlas(Convert.ToInt32(reader["CorrelationID"]), conn, tran).AtlasName;
                            break;
                        default:
                            strFolderName = "Images";
                            break;
                    }

                    strFileName = strPath.TrimEnd('/').TrimEnd('\\') + "/" + strFolderName + "/" + reader["FileName"].ToString();

                    System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(strFileName));

                    if (System.IO.File.Exists(strFileName))
                    {
                        System.IO.File.Delete(strFileName);
                    }

                    FileStream fs = new FileStream(strFileName, FileMode.CreateNew);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(File, 0, File.Length);
                    bw.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }

        }

        public static int DeleteUploadFile(int iUploadFileID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            int iEffected = 0;
            string strSql = "";

            strSql = " delete from UploadFile where UploadFileID = ? ";
            iEffected = Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@UploadFileID", OleDbType.Integer) { Value = iUploadFileID });

            return iEffected;
        }
    }
}
