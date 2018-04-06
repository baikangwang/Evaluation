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
    /// ExpertManage 的摘要说明
    /// </summary>
    public class ExpertManage : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            //Session丢失时，将cookie赋给Session
            if (context.Session["UserInfo"] == null)
            {
                context.Session["UserInfo"] = BLL.User.GetUserInfo(Convert.ToInt32(context.Request.Cookies["UserId"].Value), conn);
            }

            context.Response.ContentType = "text/plain";
            string strAction = context.Request["Action"];
            if (!string.IsNullOrEmpty(strAction))
            {
                switch (strAction)
                {
                    case "GetExpertList":
                        GetExpertList(context, conn);
                        break;
                    case "EditExpert":
                        EditExpert(context, conn);
                        break;
                    case "DelExpert":
                        DelExpert(context, conn);
                        break;
                    case "GetExpertGroupList":
                        GetExpertGroupList(context, conn);
                        break;
                    case "AddExpertGroupMember":
                        AddExpertGroupMember(context, conn);
                        break;
                    case "DelExpertGroupMember":
                        DelExpertGroupMember(context, conn);
                        break;
                    case "ExpertGroupMemberList":
                        ExpertGroupMemberList(context, conn);
                        break;
                    case "GetExpertOutsideGroup":
                        GetExpertOutsideGroup(context, conn);
                        break;
                    case "MultiselectDelExpertList":
                        MultiselectDelExpertList(context, conn);
                        break;
                    case "ImportExpertGroup":
                        ImportExpertGroup(context, conn);
                        break;
                    case "ImportExpert":
                        ImportExpert(context, conn);
                        break;
                    //case "GetAllExpertGroupList":
                    //    GetAllExpertGroupList(context, conn);
                    //    break;
                    case "Allocation":
                        Allocation(context, conn);
                        break;
                    case "Delete":
                        Delete(context, conn);
                        break;
                    case "GetParentGroup":
                        GetParentGroup(context, conn);
                        break;
                    case "GetExpertGroupListByPrize":
                        GetExpertGroupListByPrize(context, conn);
                        break;
                    case "GetExpertsByGroupID":
                        GetExpertsByGroupID(context, conn);
                        break;
                    case "SaveExpertReviewer":
                        SaveExpertReviewer(context, conn);
                        break;
                    case "GetSpecialtyExpertList":
                        GetSpecialtyExpertList(context, conn);
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

        public void GetExpertList(HttpContext context, OleDbConnection conn)
        {
            string strQuery = context.Request["strQuery"];
            string strQueryStatus = context.Request["QueryStatus"];
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            List<Dal.Models.Expert> lstExpert = BLL.Expert.GetExpertList(conn, user, strQuery, strQueryStatus);
            if (lstExpert.Count > 0)
            {
                lstExpert = lstExpert.OrderByDescending(r => r.ExpertID).ToList();
            }

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
            int iRecordNumber = lstExpert.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstExpert = lstExpert.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();

            DataTable dtExpert = Dal.DataTableExtensions.ToDataTable(lstExpert);

            Dal.Models.PageInfo<Dal.Models.Expert> pgif = new Dal.Models.PageInfo<Dal.Models.Expert>()
            {
                CuttentPage = iCuttentPage,
                PagesCount = iPagesCount,
                PerPage = iPageSize,
                RecordNumber = iRecordNumber,
                Table = dtExpert,
                List = lstExpert
            };

            context.Response.Write(JsonConvert.SerializeObject(pgif));
        }

        public void GetSpecialtyExpertList(HttpContext context, OleDbConnection conn)
        {
            string strQuery = context.Request["strQuery"];
            string strQueryStatus = context.Request["QueryStatus"];
            int specialtyId = context.Request["SpecialtyID"] == null ? 0 : Convert.ToInt32(context.Request["SpecialtyID"]);
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            List<Dal.Models.Expert> lstExpert = new List<Dal.Models.Expert>();
            List<Dal.Models.Expert> listExpert = BLL.Expert.GetExpertList(conn, user, strQuery, strQueryStatus);
            if (listExpert.Count > 0)
            {
                lstExpert = listExpert.Where(s => (s.SpecialtyIDs ?? "").Contains(specialtyId.ToString())).ToList();
            }

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
            int iRecordNumber = lstExpert.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstExpert = lstExpert.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();

            DataTable dtExpert = Dal.DataTableExtensions.ToDataTable(lstExpert);

            Dal.Models.PageInfo<Dal.Models.Expert> pgif = new Dal.Models.PageInfo<Dal.Models.Expert>()
            {
                CuttentPage = iCuttentPage,
                PagesCount = iPagesCount,
                PerPage = iPageSize,
                RecordNumber = iRecordNumber,
                Table = dtExpert,
                List = lstExpert
            };

            context.Response.Write(JsonConvert.SerializeObject(pgif));
        }

        /// <summary>
        /// 专家修改，修改需要参数，ExpertID，ExpertName，Workplace，IDType
        /// </summary>
        /// <param name="context"></param>
        public void EditExpert(HttpContext context, OleDbConnection conn)
        {
            string id = context.Request["ExpertID"];

            Dal.Models.Expert expert = BLL.Expert.GetExpert(Convert.ToInt32(id), conn);
            expert.ExpertName = context.Request["ExpertName"];
            expert.Workplace = context.Request["Workplace"];
            expert.IDType = context.Request["IDType"];

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                BLL.Expert.UpdateExpert(expert, conn, tran);
                tran.Commit();
                context.Response.Write("success");
            }
            catch(Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        public void Allocation(HttpContext context, OleDbConnection conn)
        {
            int iDeclarationID = 0;
            Int32.TryParse(context.Request["DeclarationID"], out iDeclarationID);

            int iExpertGroupID = 0;
            Int32.TryParse(context.Request["ExpertReviewGroupID"], out iExpertGroupID);

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                BLL.Declaration.AllocateDeclaration(iDeclarationID, iExpertGroupID, conn, tran);
                tran.Commit();
                context.Response.Write("success");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }
        /// <summary>
        /// 删除专家，需要参数，ExpertID
        /// </summary>
        /// <param name="context"></param>
        public void DelExpert(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                string id = context.Request["ExpertID"];
                string strActivityType = context.Session["ActivityType"].ToString();
                Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn, tran);
                if (activity == null)
                {
                    throw new Exception("当前活动已关闭，请联系活动管理人员！");
                }
                BLL.Expert.DeleteExpert(Convert.ToInt32(id), activity.ActivityID.Value, conn, tran);
                tran.Commit();
                context.Response.Write("success");
            }
            catch(Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void GetExpertGroupList(HttpContext context, OleDbConnection conn)
        {
            string strSpecialtyID = context.Request["Specialtys"];
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write("当前活动已关闭，请联系活动管理人员！");
                return;
            }

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
            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;

            List<Dal.Models.ExpertGroup> lstExpertGroup = BLL.ExpertGroup.GetGroupList(activity.ActivityID.Value, strSpecialtyID, conn);

            if (lstExpertGroup.Count > 0)
            {
                lstExpertGroup = lstExpertGroup.OrderByDescending(r => r.GroupID).ToList();
            }

            int iRecordNumber = lstExpertGroup.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstExpertGroup = lstExpertGroup.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();

            DataTable dtExpertGroup = Dal.DataTableExtensions.ToDataTable(lstExpertGroup);
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = dtExpertGroup;

            context.Response.Write(JsonConvert.SerializeObject(pgif));
        }

        //public void GetAllExpertGroupList(HttpContext context, OleDbConnection conn)
        //{
        //    string strActivityType = context.Session["ActivityType"].ToString();
        //    Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
        //    if (activity == null)
        //    {
        //        context.Response.Write("当前活动已关闭，请联系活动管理人员！");
        //        return;
        //    }
        //    List<Dal.Models.ExpertGroup> lstExpertGroup = BLL.ExpertGroup.GetGroupList(activity.ActivityID.Value, null, conn);
        //    List<Dal.Models.ExpertGroup> lstParentExpertGroup = new List<Dal.Models.ExpertGroup>();
        //    for (int i = 0; i < lstExpertGroup.Count(); i++)
        //    {
        //        for (int j = 0; j < lstExpertGroup.Count(); j++)
        //        {
        //            if (lstExpertGroup[i].GroupID == lstExpertGroup[j].ParentID)
        //            {
        //                lstParentExpertGroup.Add(lstExpertGroup[i]);
        //            }
        //        }
        //    }
        //    for (int o = 0; o < lstParentExpertGroup.Count(); o++)
        //    {
        //        lstExpertGroup.Remove(lstParentExpertGroup[o]);
        //    }

        //    context.Response.Write(JsonConvert.SerializeObject(lstExpertGroup));
        //}

        public void GetExpertGroupListByPrize(HttpContext context, OleDbConnection conn)
        {
            int iPrize = context.Request["PrizeID"] == "" ? 0 : Convert.ToInt32(context.Request["PrizeID"]);
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write("当前活动已关闭，请联系活动管理人员！");
                return;
            }
            List<Dal.Models.ExpertGroup> lstExpertGroup = BLL.ExpertGroup.GetExpertGroupByPrizeID(activity.ActivityID.Value,iPrize, conn);
            List<Dal.Models.ExpertGroup> lstParentExpertGroup = new List<Dal.Models.ExpertGroup>();
            for (int i = 0; i < lstExpertGroup.Count(); i++)
            {
                for (int j = 0; j < lstExpertGroup.Count(); j++)
                {
                    if (lstExpertGroup[i].GroupID == lstExpertGroup[j].ParentID)
                    {
                        lstParentExpertGroup.Add(lstExpertGroup[i]);
                    }
                }
            }
            for (int o = 0; o < lstParentExpertGroup.Count(); o++)
            {
                lstExpertGroup.Remove(lstParentExpertGroup[o]);
            }

            context.Response.Write(JsonConvert.SerializeObject(lstExpertGroup));
        }

        //获取奖项下专业下的所有组员
        public void GetExpertsByGroupID(HttpContext context, OleDbConnection conn)
        {
            int iExpertGroupID = context.Request["ExpertGroupID"] == "" ? 0 : Convert.ToInt32(context.Request["ExpertGroupID"]);
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write("当前活动已关闭，请联系活动管理人员！");
                return;
            }
            List<Dal.Models.GroupMember> lstExpertGroup = BLL.GroupMember.GetExpertsByPrizeID(iExpertGroupID, conn);
            List<Dal.Models.GroupMember> lstParentExpertGroup = new List<Dal.Models.GroupMember>();
            
            context.Response.Write(JsonConvert.SerializeObject(lstExpertGroup));
        }

        public void GetExpertOutsideGroup(HttpContext context, OleDbConnection conn)
        {
            int id = Convert.ToInt32(context.Request["GroupID"]);
            int specialtyId = Convert.ToInt32(context.Request["SpecialtyID"]);
            List<Dal.Models.Expert> lstExpert = BLL.Expert.GetPrepMember(id, specialtyId, conn);
            DataTable dtExpert = Dal.DataTableExtensions.ToDataTable(lstExpert);
            context.Response.Write(JsonConvert.SerializeObject(dtExpert));
        }

        public void AddExpertGroupMember(HttpContext context, OleDbConnection conn)
        {
            int id = Convert.ToInt32(context.Request["GroupID"]);
            string ExpertId = context.Request["ExpertID"];
            if (ExpertId != null)
            {
                Dal.Models.GroupMember expertGroupMember = new Dal.Models.GroupMember();
                expertGroupMember.GroupID = id;
                expertGroupMember.ExpertID = Convert.ToInt32(ExpertId);
                expertGroupMember.Duty = "";
                expertGroupMember.Grade = "";
                BLL.ExpertGroup.AddMember(expertGroupMember, conn);
            }
            List<Dal.Models.GroupMember> lstExpertGroupMember = BLL.ExpertGroup.GetGroupMemberList(id, conn);
            context.Response.Write(JsonConvert.SerializeObject(lstExpertGroupMember));
        }

        public void DelExpertGroupMember(HttpContext context, OleDbConnection conn)
        {
            int id = Convert.ToInt32(context.Request["GroupID"]);
            int ExpertId = Convert.ToInt32(context.Request["ExpertID"]);
            BLL.ExpertGroup.RemoveMember(id, ExpertId, conn);
            BLL.ExpertGroup.DeteleGroupLeader(id, ExpertId, conn);
            context.Response.Write("success");
        }

        public void ExpertGroupMemberList(HttpContext context, OleDbConnection conn)
        {
            int id = Convert.ToInt32(context.Request["GroupID"]);
            List<Dal.Models.GroupMember> lstExpertGroupMember = BLL.ExpertGroup.GetGroupMemberList(id, conn);
            DataTable dtExpertGroupMember = Dal.DataTableExtensions.ToDataTable(lstExpertGroupMember);
            context.Response.Write(JsonConvert.SerializeObject(dtExpertGroupMember));
        }

        public void MultiselectDelExpertList(HttpContext context, OleDbConnection conn)
        {
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write("当前活动已关闭，请联系活动管理人员！");
                return;
            }
            OleDbTransaction trans = conn.BeginTransaction();

            string strExpertID = context.Request["ExpertID"];
            string[] arrayExpertID = strExpertID.Split(',');

            List<int> listExpertID = new List<int>();
            foreach (var item in arrayExpertID)
            {
                listExpertID.Add(Convert.ToInt32(item));
            }
            try
            {
                for (int i = 0; i < listExpertID.Count(); i++)
                {
                    int iExpertID = Convert.ToInt32(listExpertID[i]);
                    BLL.Expert.DeleteExpert(iExpertID, activity.ActivityID.Value, conn, trans);
                }
                trans.Commit();
                context.Response.Write("删除成功!");
            }
            catch(Exception ex)
            {
                trans.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        /// <summary>
        /// 取专家组副组长或专家组成员信息
        /// </summary>
        /// <param name="iSpecialtyID">专业编号</param>
        /// <param name="strMemberNames">副组长名或者成员名</param>
        /// <param name="strOriginalMemberIDs">原组副组长编号或者成员编号</param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns>专家组副组长或专家组成员编号</returns>
        public string GetMemberIDs(int iSpecialtyID, string strMemberNames, string strOriginalMemberIDs, OleDbConnection conn, OleDbTransaction tran)
        {
            string strResult = "";

            // 如果姓名不为空，取专家编号
            if (!string.IsNullOrEmpty(strMemberNames))
            {
                Dal.Models.Expert expertMember = null;
                List<string> lstDeputy = strMemberNames.ToString().Replace("、", ",").Replace("，", ",").Split(',').ToList();
                for (int i = 0; i < lstDeputy.Count; i++)
                {
                    // 根据专家名取专家
                    expertMember = BLL.Expert.GetExpert(lstDeputy[i].ToString(), conn, tran);
                    if (expertMember == null)
                    {
                        throw new Exception("专家：" + lstDeputy[i].ToString() + "不存在！");
                    }

                    if (!expertMember.SpecialtyIDs.Contains(iSpecialtyID.ToString()))
                    {
                        throw new Exception("专家：" + expertMember.ExpertName + "专业不符！");
                    }

                    strResult += expertMember.ExpertID + ",";
                }
                strResult = strResult.TrimEnd(',');
            }

            // 如果编号与现有编号不同，合并
            if (!string.IsNullOrEmpty(strOriginalMemberIDs) && strOriginalMemberIDs != strResult)
            {
                if (string.IsNullOrEmpty(strResult))
                {
                    strResult = strOriginalMemberIDs;
                }
                else
                {
                    string[] arrDeputyID = strOriginalMemberIDs.Split(',');                    
                    foreach (string strDeputyID in arrDeputyID)
                    {
                        if (!strResult.Split(',').Contains(strDeputyID))
                        {
                            strResult += "," + strDeputyID;
                        }
                    }
                }
            }

            return strResult;
        }

        public Dal.Models.ExpertGroup AddGroup(
            int iActivityID,
            int iSpecialtyID,
            string strSpecialtyName,
            Dal.Models.UserInfo user,
            DataRow row,
            int iGroupNameIdx,
            int? iParentID,
            bool bHasMember,
            OleDbConnection conn,
            OleDbTransaction tran)
        {
            Dal.Models.ExpertGroup groupNew = new Dal.Models.ExpertGroup();
            Dal.Models.ExpertGroup groupOrriginal = null;
            Dal.Models.Expert expertMember = null;

            groupNew.ActivityID = iActivityID;
            groupNew.SpecialtyID = iSpecialtyID;
            groupNew.GroupName = row[iGroupNameIdx].ToString();
            groupNew.CreateTime = DateTime.Now;
            groupNew.ParentID = iParentID;

            #region 专家组长、专家组名、上级专家组
            // 判断专家组长是否存在
            if (bHasMember)
            {
                groupNew.LeaderName = row[iGroupNameIdx + 2].ToString();
            }
            else
            {
                groupNew.LeaderName = row[iGroupNameIdx + 1].ToString();
            }

            if (string.IsNullOrEmpty(groupNew.LeaderName) && string.IsNullOrEmpty(groupNew.GroupName))
            {
                return null;
            }

            if (string.IsNullOrEmpty(groupNew.GroupName))
            {
                throw new Exception("专家组组名不能为空！");
            }

            if (string.IsNullOrEmpty(groupNew.LeaderName))
            {
                throw new NullReferenceException("专家组组长不能为空！");
            }

            // 根据专家名取专家
            expertMember = BLL.Expert.GetExpert(groupNew.LeaderName, conn, tran);

            if (expertMember == null)
            {
                throw new Exception("专家：" + groupNew.LeaderName + "不存在！");
            }

            // 判断专家专业
            if (!expertMember.SpecialtyNames.Contains(strSpecialtyName))
            {
                throw new Exception("专家：" + groupNew.LeaderName + "专业不符！");
            }

            // 根据专家组组名取专家组
            groupOrriginal = BLL.ExpertGroup.GetExpertGroup(groupNew.GroupName, iSpecialtyID, conn, tran);
            if (groupOrriginal == null)
            {
                groupNew.GroupLeader = expertMember.ExpertID;
            }
            else
            {
                if (groupOrriginal.GroupLeader != expertMember.ExpertID)
                {
                    throw new Exception("专家组组长：" + groupNew.LeaderName + "信息不符！");
                }

                if (groupOrriginal.ParentID != iParentID)
                {
                    throw new Exception("同一专家组只能有一个上级专家组！");
                }

                groupNew.GroupID = groupOrriginal.GroupID;
                groupNew.GroupLeader = expertMember.ExpertID;
            }
         
            #endregion

            #region 专家组副组长
            // 取副组长名
            if (bHasMember)
            {
                groupNew.DeputyNames = row[iGroupNameIdx + 3].ToString();
            }
            else
            {
                groupNew.DeputyNames = row[iGroupNameIdx + 2].ToString();
            }

            // 如果副组长名不为空，取副组长专家编号，如果副组长编号与现有专家组副组长编号不同，合并副组长
            groupNew.DeputyIDs = GetMemberIDs(iSpecialtyID, groupNew.DeputyNames, groupOrriginal == null ? "" : groupOrriginal.DeputyIDs, conn, tran);
            #endregion

            #region 专家组成员
            // 判断专家组成员是否存在
            if (bHasMember)
            {
                groupNew.MemberNames = row[iGroupNameIdx + 4].ToString();
            }

            // 如果专家组成员不为空，取专家组成员专家编号，如果专家组成员编号与现有专家组成员编号不同，合并专家组成员
            groupNew.MemberIDs = GetMemberIDs(iSpecialtyID, groupNew.MemberNames, groupOrriginal == null ? "" : groupOrriginal.MemberIDs, conn, tran);
            #endregion

            Dal.Models.ExpertGroup group = BLL.ExpertGroup.CreateExpertGroup(groupNew, user, conn, tran);

            return group;
        }

        /// <summary>
        /// 接收上传文件
        /// </summary>
        public string UploadFile(HttpContext context)
        {
            string excelFile = "";
            HttpFileCollection files = context.Request.Files;
            for (int i = 0; i < files.Count; i++)
            {
                HttpPostedFile file = files[i];
                if (!Directory.Exists(context.Server.MapPath("~/Content/Temp/ExcelTemp/")))
                {
                    Directory.CreateDirectory(context.Server.MapPath("~/Content/Temp/ExcelTemp/"));
                }
                excelFile = context.Server.MapPath("~/Content/Temp/ExcelTemp/" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + file.FileName);
                file.SaveAs(excelFile);
            }
            return excelFile;
        }

        public void ImportExpertGroup(HttpContext context, OleDbConnection conn)
        {
            // 返回数据信息
            List<object> lstResult = new List<object>();

            if (context.Session["UserInfo"] == null)
            {
                lstResult.Add("-1");
                lstResult.Add("当前会话已结束，请重新登录！");
                context.Response.Write(JsonConvert.SerializeObject(lstResult));
                return;
            }

            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                lstResult.Add("-1");
                lstResult.Add("当前活动已关闭，请联系活动管理人员！");
                context.Response.Write(JsonConvert.SerializeObject(lstResult));
                return;
            }

            if (context.Request.Files.Count <= 0)
            {
                lstResult.Add("-1");
                lstResult.Add("请选择文件！");
                context.Response.Write(JsonConvert.SerializeObject(lstResult));
                return;
            }

            // 接收上传文件
            string excelFile = UploadFile(context);

            // 读取文件中的数据
            DataTable dtTemp = BLL.Common.ReadExcelByNPOI(excelFile, true, 0);
            if (dtTemp == null)
            {
                lstResult.Add("-1");
                lstResult.Add("读取文件中的数据失败！");
                context.Response.Write(JsonConvert.SerializeObject(lstResult));
                return;
            }

            //判断上传文件内容格式是否完整
            if (dtTemp.Columns[0].ColumnName != "项目信息" || dtTemp.Columns[15].ColumnName != "上级专家组3"
                || dtTemp.Columns[12].ColumnName != "上级专家组2" || dtTemp.Columns[9].ColumnName != "上级专家组1")
            {
                lstResult.Add("-1");
                lstResult.Add("上传成功！由于上传文件内容与模版内容不符，数据添加失败!");
                context.Response.Write(JsonConvert.SerializeObject(lstResult));
                return;
            }

            Dal.Models.ExpertGroup group = null;
            Dal.Models.Declaration decl = null;
            Dal.Models.Expert expertReviewer = null;

            dtTemp.Columns.Add("Ordinal");
            dtTemp.Columns.Add("ErrorMessage");
            DataTable dtError = dtTemp.Clone();
            DataTable dtAllocate = dtTemp.Clone();

            OleDbTransaction tran = conn.BeginTransaction();
            for (int i = 1; i < dtTemp.Rows.Count; i++)
            {
                try
                {
                    // 如果没有填写项目评审专家组，略过
                    if (string.IsNullOrEmpty(dtTemp.Rows[i][4].ToString()) && string.IsNullOrEmpty(dtTemp.Rows[i][6].ToString()))
                    {
                        throw new NullReferenceException("项目评审专家组为空！");
                    }

                    decl = BLL.Declaration.GetDeclaration(dtTemp.Rows[i][1].ToString(), conn, tran);

                    //最上级专家组3
                    group = AddGroup(activity.ActivityID.Value, decl.SpecialtyID.Value, decl.SpecialtyName, user, dtTemp.Rows[i], 15, null, false, conn, tran);

                    //上级专家组2
                    group = AddGroup(activity.ActivityID.Value, decl.SpecialtyID.Value, decl.SpecialtyName, user, dtTemp.Rows[i], 12, group == null ? null : group.GroupID, false, conn, tran);

                    //上级专家组1
                    group = AddGroup(activity.ActivityID.Value, decl.SpecialtyID.Value, decl.SpecialtyName, user, dtTemp.Rows[i], 9, group == null ? null : group.GroupID, false, conn, tran);

                    //评审小组
                    group = AddGroup(activity.ActivityID.Value, decl.SpecialtyID.Value, decl.SpecialtyName, user, dtTemp.Rows[i], 4, group == null ? null : group.GroupID, true, conn, tran);

                    if (decl == null)
                    {
                        throw new Exception("项目：" + dtTemp.Rows[i][1].ToString() + "不存在!");
                    }

                    // 设定项目评审专家组
                    BLL.Declaration.AllocateDeclaration(decl.DeclarationID.Value, group.GroupID, conn, tran);

                    // 设定审批意见填写人
                    if (string.IsNullOrEmpty(dtTemp.Rows[i][5].ToString()))
                    {
                        // 审批意见填写人为空，则默认为专家组组长
                        BLL.Declaration.SetExpertReviewer(decl.DeclarationID.Value, group.GroupLeader, conn, tran);
                    }
                    else
                    {
                        expertReviewer = BLL.Expert.GetExpert(dtTemp.Rows[i][5].ToString(), conn, tran);
                        if (expertReviewer == null)
                        {
                            throw new Exception("审批意见填写人：" + dtTemp.Rows[i][5].ToString() + "不存在!");
                        }

                        if (!(expertReviewer.SpecialtyIDs ?? "").Contains(decl.SpecialtyID.ToString()))
                        {
                            throw new Exception("审批意见填写人：" + dtTemp.Rows[i][5].ToString() + "与项目专业不匹配!");
                        }

                        if (!BLL.ExpertGroup.IsExpertInGroup(group.GroupID.Value, expertReviewer.ExpertID.Value, conn, tran))
                        {
                            BLL.ExpertGroup.AddMember(new Dal.Models.GroupMember() { ExpertID = expertReviewer.ExpertID, GroupID = group.GroupID }, conn, tran);
                        }

                        BLL.Declaration.SetExpertReviewer(decl.DeclarationID.Value, expertReviewer.ExpertID, conn, tran);
                    }

                    dtAllocate.ImportRow(dtTemp.Rows[i]);
                }
                catch (Exception ex)
                {
                    dtTemp.Rows[i]["ErrorMessage"] = ex.Message;
                    dtError.ImportRow(dtTemp.Rows[i]);
                }
            }
            tran.Commit();

            lstResult.Add(dtTemp.Rows.Count - 1);
            lstResult.Add(dtAllocate.Rows.Count);
            lstResult.Add(dtAllocate);
            lstResult.Add(dtError);

            context.Response.Write(JsonConvert.SerializeObject(lstResult));
        }

        /// <summary>
        /// 导入专家
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        /// <remarks>第一个对象标识：0 没有文件 1 有文件 第二个对象：成功列表  第三个对象：失败列表及失败原因</remarks>
        public void ImportExpert(HttpContext context, OleDbConnection conn)
        {
            List<object> lstResult = new List<object>();
            if (context.Session["ActivityType"] == null)
            {
                lstResult.Add("-1");
                lstResult.Add("当前会话已结束，请重新登录！");
                context.Response.Write(JsonConvert.SerializeObject(lstResult));
                return;
            }

            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                lstResult.Add("-1");
                lstResult.Add("当前活动已关闭，请联系活动管理人员！");
                context.Response.Write(JsonConvert.SerializeObject(lstResult));
                return;
            }

            //int specialtyID = Convert.ToInt32(context.Request["SpecialtyID"]);

            if (context.Request.Files.Count <= 0)
            {
                lstResult.Add("-1");
                lstResult.Add("请选择文件！");
                context.Response.Write(JsonConvert.SerializeObject(lstResult));
                return;
            }

            // 接收上传文件
            string excelFile = UploadFile(context);

            // 读取文件中的数据
            DataTable dtExpert = BLL.Common.ReadExcelByNPOI(excelFile, true, 0);

            if (dtExpert == null)
            {
                lstResult.Add("-1");
                lstResult.Add("读取文件中的数据失败！");
                context.Response.Write(JsonConvert.SerializeObject(lstResult));
                return;
            }

            List<DataRow> removelist = new List<DataRow>();
            for (int i = 0; i < dtExpert.Rows.Count; i++)
            {
                bool IsNull = true;
                for (int j = 0; j < dtExpert.Columns.Count; j++)
                {
                    if (!string.IsNullOrEmpty(dtExpert.Rows[i][j].ToString().Trim()))
                    {
                        IsNull = false;
                        break;
                    }
                }
                if (IsNull)
                {
                    removelist.Add(dtExpert.Rows[i]);
                }
            }
            for (int i = 0; i < removelist.Count; i++)
            {
                dtExpert.Rows.Remove(removelist[i]);
            }

            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Expert expert = null;
            Dal.Models.Expert expertOriginal = null;
            Dal.Models.UserInfo userOriginal = null;
            List<Dal.Models.Expert> lstExpert = new List<Dal.Models.Expert>();

            //创建专家,如果专家创建失败，加入到这里
            List<KeyValuePair<string, Dal.Models.Expert>> lstError = new List<KeyValuePair<string, Dal.Models.Expert>>();
            List<Dal.Models.SysConstant> lstConstant = BLL.SysConstant.GetConstantList("09", conn);

            string strDefaultPassword = BLL.SysConstant.GetAppSettings("DefaultPassword", conn);
            Dal.Models.SysConstant cnstIDType = null;
            foreach (DataRow row in dtExpert.Rows)
            {
                if (string.IsNullOrEmpty(row["姓名"].ToString().Trim()))
                {
                    continue;
                }

                expert = new Dal.Models.Expert();
                expert.ExpertName = row["姓名"].ToString().Trim();
                expert.Gender = row["性别"].ToString().Trim();
                expert.IDTypeText = row["证件类别"].ToString().Trim();
                expert.IDNumber = row["证件号码"].ToString().Trim();
                expert.Email = row["电子邮箱"].ToString().Trim();
                expert.AcademicTitle = row["职称"].ToString().Trim();
                expert.Profession = row["研究方向"].ToString().Trim();
                expert.Workplace = row["工作单位"].ToString().Trim();
                expert.SpecialtyNames = row["评优专业"].ToString().Trim();

                OleDbTransaction tran = conn.BeginTransaction();

                try
                {
                    if (string.IsNullOrEmpty(expert.IDTypeText)
                        || string.IsNullOrEmpty(expert.IDNumber)
                        || string.IsNullOrEmpty(expert.Email)
                        || string.IsNullOrEmpty(expert.SpecialtyNames))
                    {
                        throw new Exception("专家信息不完整！");
                    }

                    // 判断证件类别
                    cnstIDType = lstConstant.Find(delegate(Dal.Models.SysConstant item) { return item.ConstantValue == expert.IDTypeText; });
                    if (cnstIDType == null)
                    {
                        throw new Exception("证件类别输入错误！");
                    }
                    else
                    {
                        expert.IDType = cnstIDType.ConstantCode;
                        if (expert.IDType == "0901" && !BLL.IDOperation.CheckIDCard18(expert.IDNumber))
                        {
                            throw new Exception("所输入的身份证号码不是有效身份证号码！");
                        }
                    }

                    // 判断证件号
                    expertOriginal = BLL.Expert.GetExpert(expert.ExpertName, conn, tran);
                    if (expertOriginal != null)
                    {
                        if (expertOriginal.ExpertName != expert.ExpertName && expertOriginal.IDType == expert.IDType && expertOriginal.IDNumber == expert.IDNumber)
                        {
                            throw new Exception("专家库中存在证件类别和证件号相同，但是不同名的专家！");
                        }
                    }

                    // 判断邮箱地址
                    if (!BLL.Common.IsValidEmail(expert.Email))
                    {
                        throw new Exception("电子邮件地址格式错误！");
                    }
                    else
                    {
                        userOriginal = BLL.User.GetUserByMail(expert.Email, conn, tran);
                        if (userOriginal != null && (expertOriginal == null || userOriginal.UserID != expertOriginal.UserID))
                        {
                            throw new Exception("电子邮件地址已被占用，请更换电子邮件地址！");
                        }
                    }

                    // 判断专业
                    List<Dal.Models.Specialty> lstSpecialty = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, true, conn,tran);
                    string[] specialtyNames = expert.SpecialtyNames.Replace("，", ",").Split(',');
                    expert.SpecialtyNames = "";
                    List<Dal.Models.Specialty> lstInputSpecialty = null;
                    for (int i = 0; i < specialtyNames.Count(); i++)
                    {
                        lstInputSpecialty = lstSpecialty.Where(s => s.SpecialtyName == specialtyNames[i]).ToList();
                        if (lstInputSpecialty.Count > 0)
                        {
                            if (user.UserType != "0804" || user.SpecialtyNames.Split().Contains(lstInputSpecialty[i].SpecialtyName))
                            {
                                expert.SpecialtyIDs += lstInputSpecialty[0].SpecialtyID + ",";
                                expert.SpecialtyNames += lstInputSpecialty[0].SpecialtyName + ",";
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(expert.SpecialtyIDs))
                    {
                        expert.SpecialtyIDs = expert.SpecialtyIDs.TrimEnd(',');
                        expert.SpecialtyNames = expert.SpecialtyNames.TrimEnd(',');
                    }
                    else
                    {
                        throw new Exception("评优专业不匹配！");
                    }

                    // 专家数据入库
                    if (expertOriginal != null)
                    {
                        expert.ExpertID = expertOriginal.ExpertID;
                        expert.UserID = expertOriginal.UserID;
                        BLL.Expert.UpdateExpert(expert, conn, tran);
                    }
                    else
                    {
                        expert.ExpertID = BLL.Expert.CreateExpert(expert, strDefaultPassword, user.UserID.Value, conn, tran);
                    }

                    if (expert.SpecialtyIDs.Length > 0)
                    {
                        string[] specialtyIDs = expert.SpecialtyIDs.Split(',');
                        for (int i = 0; i < specialtyIDs.Count(); i++)
                        {
                            BLL.User.AddUserSpecialty(expert.UserID.Value, Convert.ToInt32(specialtyIDs[i]), conn, tran);
                        }
                    }
                    //BLL.User.SetUserSpecialty(expert.UserID.Value, activity.ActivityID.Value, expert.SpecialtyIDs, conn, tran);

                    // 添加到成功数据中
                    lstExpert.Add(expert);
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    // 添加失败数据及失败原因
                    lstError.Add(new KeyValuePair<string, Dal.Models.Expert>(ex.Message, expert));
                }
            }

            lstResult.Add(dtExpert.Rows.Count);
            lstResult.Add(lstExpert.Count);
            lstResult.Add(lstExpert);
            lstResult.Add(lstError);

            context.Response.Write(JsonConvert.SerializeObject(lstResult));
        }

        public void Delete(HttpContext context,  OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            string strGroupID = context.Request["GroupID"];
            try
            {
                var liststr = strGroupID.Split(',');
                for (int j = 0; j < liststr.Count(); j++)
                {
                    BLL.ExpertGroup.RemoveGroup(Convert.ToInt32(liststr[j]), conn, trans);
                }
                trans.Commit();
                context.Response.Write(JsonConvert.SerializeObject("删除成功"));
            }
            catch (Exception ex)
            {
                trans.Rollback();
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
            }                
        }

        public void GetParentGroup(HttpContext context, OleDbConnection conn)
        {
            int specialtyID = Convert.ToInt32(context.Request["SpecialtyID"]);
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write("当前活动已关闭，请联系活动管理人员！");
                return;
            }
            List<Dal.Models.ExpertGroup> profession = BLL.ExpertGroup.GetGroupList(activity.ActivityID.Value, specialtyID.ToString(), conn);
            context.Response.Write(JsonConvert.SerializeObject(profession));
        }

        public void SaveExpertReviewer(HttpContext context, OleDbConnection conn)
        {
            int iDeclarationID = 0;
            Int32.TryParse(context.Request["DeclarationID"], out iDeclarationID);
            int iExpertGroupID = context.Request["ExpertReviewerID"] == null ? 0 : Convert.ToInt32(context.Request["ExpertReviewerID"]);
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                BLL.Declaration.SaveExpertReviewer(iDeclarationID, iExpertGroupID, conn, tran);
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }
    }
}