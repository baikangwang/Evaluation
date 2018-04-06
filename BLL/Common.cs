using com.google.zxing;
using com.google.zxing.common;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace BLL
{
    public class Common
    {
        public static int? ToInt32(object obj)
        {
            if (obj == null || obj == DBNull.Value)
            {
                return null;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }

        public static bool IsValidEmail(string strEmail)
        {
            return Regex.IsMatch(strEmail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)" + @"|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        //public static List<Dal.Models.AwardResult> GetAwardResultOld(int iPrizeID, OleDbConnection conn)
        //{
        //    List<Dal.Models.AwardResult> lstResult = GetAwardResultReport(iPrizeID, conn);

        //    if (lstResult.Count > 0)
        //    {
        //        return lstResult;
        //    }

        //    Dal.OleDbHlper.ExecuteNonQuery("Proc_GetAwardResult", conn, CommandType.StoredProcedure, null
        //       , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });

        //    Vote.ResetResultIndex(iPrizeID, "MidAwardResult", conn, null);

        //    string strSql = " select * from dbo.MidAwardResult m  "
        //         + "inner join V_Declaration d on d.DeclarationID = m.DeclarationID "
        //         + "where m.PrizeID = ? order by m.idx";

        //    lstResult = Dal.OleDbHlper.GetList<Dal.Models.AwardResult>(strSql, conn, CommandType.Text, null
        //        , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });

        //    Dal.Models.Prize prize = Prize.GetPrize(iPrizeID, conn);

        //    foreach (Dal.Models.AwardResult curAwardResult in lstResult)
        //    {
        //        if (prize.PrizeTypeCode == "0301" || prize.PrizeTypeCode == "0304")
        //        {
        //            if (curAwardResult.Ordinal <= prize.FirstPrize)
        //            {
        //                curAwardResult.VoteCode = "0601";
        //                curAwardResult.PrizeLevelCode = "0401";
        //            }
        //            else if (curAwardResult.Ordinal <= prize.FirstPrize + prize.SecondPrize)
        //            {
        //                curAwardResult.VoteCode = "0601";
        //                curAwardResult.PrizeLevelCode = "0402";
        //            }
        //            else if (curAwardResult.Ordinal <= prize.AwardCount)
        //            {
        //                curAwardResult.VoteCode = "0601";
        //                curAwardResult.PrizeLevelCode = "0403";
        //            }
        //            else
        //            {
        //                curAwardResult.VoteCode = "0602";
        //            }
        //        }
        //        else
        //        {
        //            if (curAwardResult.Ordinal <= prize.AwardCount)
        //            {
        //                curAwardResult.VoteCode = "0601";
        //            }
        //            else
        //            {
        //                curAwardResult.VoteCode = "0602";
        //            }
        //        }

        //    }

        //    return lstResult;

        //    #region
        //    //List<Dal.Models.VoteResult> lstFirstPrize = new List<Dal.Models.VoteResult>();
        //    //List<Dal.Models.VoteResult> lstSecondPrize = new List<Dal.Models.VoteResult>();
        //    //List<Dal.Models.VoteResult> lstThirdPrize = new List<Dal.Models.VoteResult>();
        //    //List<Dal.Models.VoteResult> lstRecommended = new List<Dal.Models.VoteResult>();
        //    //List<Dal.Models.VoteResult> lstNotRecommended = new List<Dal.Models.VoteResult>();
        //    //List<Dal.Models.VoteResult> lstTemp = new List<Dal.Models.VoteResult>();
        //    //List<Dal.Models.AwardResult> lstResult = new List<Dal.Models.AwardResult>();


        //    //Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);
        //    //List<Dal.Models.VoteResult> lstSelected = new List<Dal.Models.VoteResult>();


        //    ////当前轮次
        //    //List<Dal.Models.VoteResult> lstVoteResult = null;

        //    //if ((prize.PrizeTypeCode == "0301" || prize.PrizeTypeCode == "0304") && prize.VoteType != "2201")//多伦--推荐、不推荐
        //    //{
        //    //    if (prize.VoteType == "2202")//两次投票
        //    //    {
        //    //        // 一二三等奖入围的
        //    //        lstSelected = BLL.Vote.GetSelectedResult(iPrizeID, 1, conn);

        //    //        // 一二三等奖投票结果
        //    //        lstVoteResult = BLL.Vote.GetVoteResult(iPrizeID, conn);

        //    //        // 第一轮次投票结果
        //    //        lstTemp = BLL.Vote.GetVoteResult(iPrizeID, 1, conn);

        //    //        // 不入围的
        //    //        lstNotRecommended = lstTemp.Except(lstSelected).ToList();

        //    //        foreach (Dal.Models.VoteResult r in lstVoteResult)
        //    //        {
        //    //            lstResult.Add(new Dal.Models.AwardResult()
        //    //            {
        //    //                PrizeID = r.PrizeID,
        //    //                DeclarationID = r.DeclarationID,
        //    //                DeclarationName = r.DeclarationName,
        //    //                OrganizationName = r.OrganizationName,
        //    //                Ordinal = Convert.ToInt32(r.Ordinal),
        //    //                // 待定
        //    //                AwardStatus = "入围"
        //    //            });
        //    //        }

        //    //        foreach (Dal.Models.VoteResult r in lstNotRecommended)
        //    //        {
        //    //            lstResult.Add(new Dal.Models.AwardResult()
        //    //            {
        //    //                PrizeID = r.PrizeID,
        //    //                DeclarationID = r.DeclarationID,
        //    //                DeclarationName = r.DeclarationName,
        //    //                OrganizationName = r.OrganizationName,
        //    //                Ordinal = Convert.ToInt32(r.Ordinal),
        //    //                // 不入围
        //    //                AwardStatus = "不入围"
        //    //            });
        //    //        }

        //    //    }
        //    //    else//三次投票
        //    //    {
        //    //        // 一二三等奖入围的
        //    //        lstSelected = BLL.Vote.GetSelectedResult(iPrizeID, 1, conn);

        //    //        // 第一轮次投票结果
        //    //        lstTemp = BLL.Vote.GetVoteResult(iPrizeID, 1, conn);

        //    //        // 不入围的
        //    //        lstNotRecommended = lstTemp.Except(lstSelected).ToList();

        //    //        // 第二轮次投票结果
        //    //        lstTemp = BLL.Vote.GetVoteResult(iPrizeID, 2, conn);

        //    //        // 一二等奖
        //    //        lstSelected = BLL.Vote.GetSelectedResult(iPrizeID, 2, conn);

        //    //        // 三等奖
        //    //        lstThirdPrize = lstTemp.Except(lstSelected).ToList();

        //    //        foreach (Dal.Models.VoteResult r in lstNotRecommended)
        //    //        {
        //    //            lstResult.Add(new Dal.Models.AwardResult()
        //    //            {
        //    //                PrizeID = r.PrizeID,
        //    //                DeclarationID = r.DeclarationID,
        //    //                DeclarationName = r.DeclarationName,
        //    //                OrganizationName = r.OrganizationName,
        //    //                Ordinal = Convert.ToInt32(r.Ordinal),
        //    //                // 不入围
        //    //                AwardStatus = "不入围"
        //    //            });
        //    //        }

        //    //        foreach (Dal.Models.VoteResult r in lstThirdPrize)
        //    //        {
        //    //            lstResult.Add(new Dal.Models.AwardResult()
        //    //            {
        //    //                PrizeID = r.PrizeID,
        //    //                DeclarationID = r.DeclarationID,
        //    //                DeclarationName = r.DeclarationName,
        //    //                OrganizationName = r.OrganizationName,
        //    //                Ordinal = Convert.ToInt32(r.Ordinal),
        //    //                // 三等奖
        //    //                AwardStatus = "三等奖"
        //    //            });
        //    //        }

        //    //        // 一二等奖
        //    //        foreach (Dal.Models.VoteResult r in lstThirdPrize)
        //    //        {
        //    //            lstResult.Add(new Dal.Models.AwardResult()
        //    //            {
        //    //                PrizeID = r.PrizeID,
        //    //                DeclarationID = r.DeclarationID,
        //    //                DeclarationName = r.DeclarationName,
        //    //                OrganizationName = r.OrganizationName,
        //    //                Ordinal = Convert.ToInt32(r.Ordinal),
        //    //                // 待定
        //    //                AwardStatus = "一二等奖"
        //    //            });
        //    //        }
        //    //    }
        //    //}
        //    //else//单轮--一二三等奖
        //    //{
        //    //    lstVoteResult = BLL.Vote.GetVoteResult(iPrizeID, conn);
        //    //    foreach (Dal.Models.VoteResult r in lstVoteResult)
        //    //    {
        //    //        if (r.FirstPrize > 0)
        //    //        {
        //    //            lstResult.Add(new Dal.Models.AwardResult()
        //    //            {
        //    //                PrizeID = r.PrizeID,
        //    //                DeclarationID = r.DeclarationID,
        //    //                DeclarationName = r.DeclarationName,
        //    //                OrganizationName = r.OrganizationName,
        //    //                Ordinal = Convert.ToInt32(r.Ordinal),
        //    //                AwardStatus = "一等奖"
        //    //            });
        //    //        }
        //    //        else if (r.SecondPrize > 0)
        //    //        {
        //    //            lstResult.Add(new Dal.Models.AwardResult()
        //    //            {
        //    //                PrizeID = r.PrizeID,
        //    //                DeclarationID = r.DeclarationID,
        //    //                DeclarationName = r.DeclarationName,
        //    //                OrganizationName = r.OrganizationName,
        //    //                Ordinal = Convert.ToInt32(r.Ordinal),
        //    //                AwardStatus = "二等奖"
        //    //            });
        //    //        }
        //    //        else if (r.ThirdPrize > 0)
        //    //        {
        //    //            lstResult.Add(new Dal.Models.AwardResult()
        //    //            {
        //    //                PrizeID = r.PrizeID,
        //    //                DeclarationID = r.DeclarationID,
        //    //                DeclarationName = r.DeclarationName,
        //    //                OrganizationName = r.OrganizationName,
        //    //                Ordinal = Convert.ToInt32(r.Ordinal),
        //    //                AwardStatus = "二等奖"
        //    //            });
        //    //        }
        //    //        else
        //    //        {
        //    //            lstResult.Add(new Dal.Models.AwardResult()
        //    //            {
        //    //                PrizeID = r.PrizeID,
        //    //                DeclarationID = r.DeclarationID,
        //    //                DeclarationName = r.DeclarationName,
        //    //                OrganizationName = r.OrganizationName,
        //    //                Ordinal = Convert.ToInt32(r.Ordinal),
        //    //                AwardStatus = "不入围"
        //    //            });
        //    //        }
        //    //    }
        //    //}

        //    //object[] obj = { prize, lstResult };

        //    //return obj;
        //    #endregion
        //}

//        public static List<Dal.Models.AwardResult> GetAwardResult(int iPrizeID, OleDbConnection conn)
//        {
//            List<Dal.Models.AwardResult> lstResult = GetAwardResultReport(iPrizeID, conn);

//            if (lstResult.Count > 0)
//            {
//                return lstResult;
//            }

//            List<Dal.Models.AwardResult> lstMidResult = null;
//            lstResult = new List<Dal.Models.AwardResult>();

//            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);

//            string strSql = @" DELETE from MidAwardResult where PrizeID = " + iPrizeID.ToString()
//                + @" ; INSERT into MidAwardResult (idx,Ordinal,PrizeID, DeclarationID
//                                ,DeclarationName, OrganizationName, MultipleVoteRound
//                                ,FirstPrize,SecondPrize,ThirdPrize,Recommended,NotRecommended,SlowRating,TurnOut)
//                                select ROW_NUMBER() over(order by FirstPrize desc, SecondPrize desc, ThirdPrize desc, Recommended desc) idx
//                                , RANK() over(order by FirstPrize desc, SecondPrize desc, ThirdPrize desc, Recommended desc) Ordinal, * from (
//                                select v.PrizeID, v.DeclarationID, d.DeclarationName, d.OrganizationName, v.MultipleVoteRound
//	                                , sum(CASE WHEN v.VoteCode = '0601' AND v.PrizeLevelCode = '0401' THEN 1 ELSE 0 END) FirstPrize
//	                                , sum(CASE WHEN v.VoteCode = '0601' AND v.PrizeLevelCode = '0402' THEN 1 ELSE 0 END) SecondPrize
//	                                , sum(CASE WHEN v.VoteCode = '0601' AND v.PrizeLevelCode = '0403' THEN 1 ELSE 0 END) ThirdPrize
//	                                , sum(CASE WHEN v.VoteCode = '0601' THEN 1 ELSE 0 END) Recommended
//	                                , sum(CASE WHEN v.VoteCode = '0602' THEN 1 ELSE 0 END) NotRecommended
//	                                , sum(CASE WHEN v.VoteCode = '0603' THEN 1 ELSE 0 END) SlowRating
//	                                , sum(CASE WHEN v.VoteCode = '0604' THEN 1 ELSE 0 END) TurnOut 
//                                from Vote v inner join V_Declaration d on d.DeclarationID = v.DeclarationID  where  v.PrizeID = " + iPrizeID.ToString()
//                                + " group by v.PrizeID, v.DeclarationID, v.MultipleVoteRound, d.DeclarationName, d.OrganizationName) t";

//            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text);


//            switch (prize.VoteType)
//            {
//                case "2201":
//                    //单轮次
//                    strSql = "select * from MidAwardResult where PrizeID = " + iPrizeID
//                             + " order by Ordinal asc";
//                    lstMidResult = Dal.OleDbHlper.GetList<Dal.Models.AwardResult>(strSql, conn, CommandType.Text);
//                    if (prize.PrizeTypeCode == "0301")
//                    {
//                        //综合奖
//                        foreach (Dal.Models.AwardResult awdRst in lstMidResult)
//                        {
//                            if (awdRst.Ordinal <= prize.FirstPrize)
//                            {
//                                awdRst.AwardCode = "2301";
//                            }
//                            else if (awdRst.Ordinal <= prize.FirstPrize + prize.SecondPrize)
//                            {
//                                awdRst.AwardCode = "2302";
//                            }
//                            else if (awdRst.Ordinal <= prize.AwardCount)
//                            {
//                                awdRst.AwardCode = "2303";
//                            }
//                            else if (awdRst.NotRecommended > awdRst.SlowRating && awdRst.NotRecommended > awdRst.TurnOut)
//                            {
//                                awdRst.AwardCode = "2307";
//                            }
//                            else if (awdRst.SlowRating > awdRst.NotRecommended && awdRst.SlowRating > awdRst.TurnOut)
//                            {
//                                awdRst.AwardCode = "2308";
//                            }
//                            else if (awdRst.TurnOut > awdRst.NotRecommended && awdRst.TurnOut > awdRst.SlowRating)
//                            {
//                                awdRst.AwardCode = "2309";
//                            }
//                            lstResult.Add(awdRst);
//                        }
//                    }
//                    else
//                    {
//                        //单项奖
//                        foreach (Dal.Models.AwardResult awdRst in lstMidResult)
//                        {
//                            if (awdRst.Ordinal <= prize.AwardCount)
//                            {
//                                awdRst.AwardCode = "2306";
//                            }
//                            else if (awdRst.NotRecommended > awdRst.SlowRating && awdRst.NotRecommended > awdRst.TurnOut)
//                            {
//                                awdRst.AwardCode = "2307";
//                            }
//                            else if (awdRst.SlowRating > awdRst.NotRecommended && awdRst.SlowRating > awdRst.TurnOut)
//                            {
//                                awdRst.AwardCode = "2308";
//                            }
//                            else if (awdRst.TurnOut > awdRst.NotRecommended && awdRst.TurnOut > awdRst.SlowRating)
//                            {
//                                awdRst.AwardCode = "2309";
//                            }
//                            lstResult.Add(awdRst);
//                        }

//                    }
//                    break;
//                case "2202":
//                    //两轮次
//                    strSql = "select * from MidAwardResult where MultipleVoteRound = 2 and PrizeID = " + iPrizeID
//                              + " order by Ordinal asc";
//                   lstMidResult = Dal.OleDbHlper.GetList<Dal.Models.AwardResult>(strSql, conn, CommandType.Text);
//                   foreach (Dal.Models.AwardResult awdRst in lstMidResult)
//                    {
//                        if (awdRst.Ordinal <= prize.FirstPrize)
//                        {
//                            awdRst.AwardCode = "2301";
//                        }
//                        else if (awdRst.Ordinal <= prize.FirstPrize + prize.SecondPrize)
//                        {
//                            awdRst.AwardCode = "2302";
//                        }
//                        else if (awdRst.Ordinal <= prize.AwardCount)
//                        {
//                            awdRst.AwardCode = "2303";
//                        }
//                        lstResult.Add(awdRst);
//                    }
//                    strSql = "select * from MidAwardResult m where MultipleVoteRound = 1 and PrizeID = " + iPrizeID
//                             + " and (select DeclarationID from MidAwardResult where  MultipleVoteRound = 2 and DeclarationID = m.DeclarationID and  PrizeID = " + iPrizeID + ") is null"
//                             + " order by Ordinal asc";

//                    lstMidResult = Dal.OleDbHlper.GetList<Dal.Models.AwardResult>(strSql, conn, CommandType.Text);
//                    foreach (Dal.Models.AwardResult awdRst in lstMidResult)
//                    {
//                        if (awdRst.NotRecommended > awdRst.SlowRating && awdRst.NotRecommended > awdRst.TurnOut)
//                        {
//                            awdRst.AwardCode = "2307";
//                        }
//                        else if (awdRst.SlowRating > awdRst.NotRecommended && awdRst.SlowRating > awdRst.TurnOut)
//                        {
//                            awdRst.AwardCode = "2308";
//                        }
//                        else if (awdRst.TurnOut > awdRst.NotRecommended && awdRst.TurnOut > awdRst.SlowRating)
//                        {
//                            awdRst.AwardCode = "2309";
//                        }
//                        lstResult.Add(awdRst);
//                    }
//                    break;
//                case "2203":
//                    //三轮次
//                    strSql = "select * from MidAwardResult where MultipleVoteRound = 3 and PrizeID = " + iPrizeID
//                             + " order by Ordinal asc";
//                    lstMidResult = Dal.OleDbHlper.GetList<Dal.Models.AwardResult>(strSql, conn, CommandType.Text);
//                    foreach (Dal.Models.AwardResult awdRst in lstMidResult)
//                    {
//                        if (awdRst.Ordinal <= prize.FirstPrize)
//                        {
//                            awdRst.AwardCode = "2301";
//                        }
//                        else
//                        {
//                            awdRst.AwardCode = "2302";
//                        }
//                        lstResult.Add(awdRst);
//                    }
//                    strSql = "select * from MidAwardResult m where MultipleVoteRound = 2 and PrizeID = " + iPrizeID
//                             + " and (select DeclarationID from MidAwardResult where MultipleVoteRound = 3  and DeclarationID = m.DeclarationID and  PrizeID = " + iPrizeID + ") is null"
//                             + " order by Ordinal asc";
//                    lstMidResult = Dal.OleDbHlper.GetList<Dal.Models.AwardResult>(strSql, conn, CommandType.Text);
//                    foreach (Dal.Models.AwardResult awdRst in lstMidResult)
//                    {
//                        awdRst.AwardCode = "2303";
//                        lstResult.Add(awdRst);
//                    }
//                    strSql = "select * from MidAwardResult m where MultipleVoteRound = 1 and PrizeID = " + iPrizeID
//                             + " and (select DeclarationID from MidAwardResult where MultipleVoteRound = 2  and DeclarationID = m.DeclarationID and  PrizeID = " + iPrizeID + ") is null"
//                             + " order by Ordinal asc";
//                    lstMidResult = Dal.OleDbHlper.GetList<Dal.Models.AwardResult>(strSql, conn, CommandType.Text);
//                    foreach (Dal.Models.AwardResult awdRst in lstMidResult)
//                    {
//                        if (awdRst.NotRecommended > awdRst.SlowRating && awdRst.NotRecommended > awdRst.TurnOut)
//                        {
//                            awdRst.AwardCode = "2307";
//                        }
//                        else if (awdRst.SlowRating > awdRst.NotRecommended && awdRst.SlowRating > awdRst.TurnOut)
//                        {
//                            awdRst.AwardCode = "2308";
//                        }
//                        else if (awdRst.TurnOut > awdRst.NotRecommended && awdRst.TurnOut > awdRst.SlowRating)
//                        {
//                            awdRst.AwardCode = "2309";
//                        }
//                        lstResult.Add(awdRst);
//                    }
//                    break;
//            }

//            return lstResult;
            
//        }

        public static void SendMail(Dal.Models.MailInfo mailInfo)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            // 可以发送给多人   
            foreach (string strAddress in mailInfo.RecipientAddress)
            {
                msg.To.Add(strAddress);
            }

            // 可以抄送给多人
            foreach (string strAddress in mailInfo.CC)
            {
                msg.CC.Add(strAddress);
            }

            foreach (string strAddress in mailInfo.BCC)
            {
                msg.Bcc.Add(strAddress);
            }

            // 发件人地址 3个参数分别是发件人地址（可以随便写），发件人姓名，编码*/   
            msg.From = new MailAddress(mailInfo.SenderAddress);

            // 邮件标题 
            msg.Subject = mailInfo.Subject;

            // 邮件标题编码   
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            // 邮件内容 
            msg.Body = mailInfo.Content;

            // 邮件内容编码 
            msg.BodyEncoding = System.Text.Encoding.UTF8;

            // 是否是HTML邮件  
            msg.IsBodyHtml = mailInfo.IsBodyHtml;

            // 邮件优先级    
            msg.Priority = MailPriority.High;

            // 设置邮件发送服务器,服务器根据使用的邮箱而不同,可以到相应的 邮箱管理后台查看,下面是QQ的
            Dictionary<string, string> dicAppSettings = BLL.SysConstant.GetAppSettingDict("", conn);
            mailInfo.SmtpHost = dicAppSettings["SmtpHost"];
            mailInfo.SmtpAcount = dicAppSettings["SmtpAcount"];
            mailInfo.SmtpPassword = dicAppSettings["SmtpPassword"];
            mailInfo.SenderAddress = dicAppSettings["SenderAddress"];

            int iSmtpPortNumber = 25;
            if (!int.TryParse(dicAppSettings["SmtpPort"], out iSmtpPortNumber))
            {
                throw new FormatException("邮件发送端口号设置错误！");
            }

            mailInfo.SmtpPort = iSmtpPortNumber;

            SmtpClient client = new SmtpClient(mailInfo.SmtpHost, mailInfo.SmtpPort.Value);

            //这句要加上，不然会出错
            client.EnableSsl = false;

            // 设置发送人的邮箱账号和密码
            client.Credentials = new System.Net.NetworkCredential(mailInfo.SmtpAcount, mailInfo.SmtpPassword);

            // 发送邮件
            client.Send(msg);
            conn.Close();
        }

        public static void SendMail(Dal.Models.MailInfo mailInfo, OleDbConnection conn, OleDbTransaction trans = null)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

            // 可以发送给多人   
            foreach (string strAddress in mailInfo.RecipientAddress)
            {
                msg.To.Add(strAddress);
            }

            // 可以抄送给多人
            foreach (string strAddress in mailInfo.CC)
            {
                msg.CC.Add(strAddress);
            }

            foreach (string strAddress in mailInfo.BCC)
            {
                msg.Bcc.Add(strAddress);
            }

            // 发件人地址 3个参数分别是发件人地址（可以随便写），发件人姓名，编码*/   
            msg.From = new MailAddress(mailInfo.SenderAddress);

            // 邮件标题 
            msg.Subject = mailInfo.Subject;

            // 邮件标题编码   
            msg.SubjectEncoding = System.Text.Encoding.UTF8;

            // 邮件内容 
            msg.Body = mailInfo.Content;

            // 邮件内容编码 
            msg.BodyEncoding = System.Text.Encoding.UTF8;

            // 是否是HTML邮件  
            msg.IsBodyHtml = mailInfo.IsBodyHtml;

            // 邮件优先级    
            msg.Priority = MailPriority.High;

            Dictionary<string, string> dicAppSettings = BLL.SysConstant.GetAppSettingDict("", conn);
            mailInfo.SenderAddress = dicAppSettings["SenderAddress"];
            mailInfo.SmtpAcount = dicAppSettings["SmtpAcount"];
            mailInfo.SmtpPassword = dicAppSettings["SmtpPassword"];
            mailInfo.SmtpHost = dicAppSettings["SmtpHost"];
            int iSmtpPort = 25;
            if(!int.TryParse(dicAppSettings["SmtpPort"], out iSmtpPort))
            {
                throw new FormatException("邮件发送端口号设置错误！");
            }
            mailInfo.SmtpPort = iSmtpPort;

            // 设置邮件发送服务器

            SmtpClient client = new SmtpClient();
            //SmtpClient client = new SmtpClient(mailInfo.SmtpHost, mailInfo.SmtpPort ?? 25);

            // 设置SSL方式
            client.EnableSsl = false;

            // 设置发送人的邮箱账号和密码
            client.Credentials = new System.Net.NetworkCredential(mailInfo.SmtpAcount, mailInfo.SmtpPassword);

            // 发送邮件
            client.Send(msg);
        }

        public static System.Data.DataTable Pagger(System.Data.DataTable dtSource, string strSort, int iCurrentPage, int iRecordsPerPage, out int iRecordCount, out int iPageCount)
        {
            if (dtSource == null)
            {
                iRecordCount = 0;
                iPageCount = 0;
                return null;
            }

            iRecordCount = dtSource.Rows.Count;
            iPageCount = iRecordCount / iRecordsPerPage + 1;

            dtSource.DefaultView.Sort = strSort;
            System.Data.DataTable dtResult = dtSource.Clone();
            for (int i = iCurrentPage * iRecordsPerPage; i < dtSource.DefaultView.Count; i++)
            {
                if (i >= iCurrentPage * iRecordsPerPage && i < iCurrentPage * (iRecordsPerPage + 1))
                {
                    dtResult.Rows.Add(dtSource.DefaultView[i]);
                }
                if (i > iCurrentPage * (iRecordsPerPage + 1))
                {
                    break;
                }
            }

            return dtResult;
        }

        public static Dal.Models.PageInfo<T> Pagger<T>(System.Web.HttpContext context, List<T> lst) where T : Dal.Models.BaseEntity, new()
        {
            int iPageSize = 10;
            if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
            {
                iPageSize = 10;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(context.Request["CuttentPage"] ?? "1", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lst.Count();
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lst = lst.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();
            System.Data.DataTable dt = Dal.DataTableExtensions.ToDataTable(lst);
            Dal.Models.PageInfo<T> pgInfo = new Dal.Models.PageInfo<T>();
            pgInfo.CuttentPage = iCuttentPage;
            pgInfo.PerPage = iPageSize;
            pgInfo.RecordNumber = iRecordNumber;
            pgInfo.PagesCount = iPagesCount;

            pgInfo.Table = dt;

            return pgInfo;
        }

        #region 连接Excel  读取Excel数据   并返回DataSet数据集合
        /// <summary>  
        /// 连接Excel  读取Excel数据   并返回DataTable数据集合  
        /// </summary>  
        /// <param name="filepath">Excel服务器路径</param>  
        /// <param name="tableName">Excel表名称</param>  
        /// <returns></returns>  
        public static System.Data.DataTable ReadExcel(string filepath, string tableName)
        {
            string strConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'";
            OleDbConnection conn = new OleDbConnection(strConnString);
            try
            {
                conn.Open();
                string strCom = string.Format("SELECT * FROM [Sheet1$]");
                OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                myCommand.Fill(dt);
                conn.Close();
                if (!string.IsNullOrEmpty(tableName))
                {
                    dt.TableName = "[" + tableName + "$]";
                }
                return dt;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }
        public static System.Data.DataTable ReadExcelByNPOI(string filePath, bool isColumnName, int sheetNum)
        {
            System.Data.DataTable dataTable = null;
            FileStream fs = null;
            DataColumn column = null;
            DataRow dataRow = null;
            IWorkbook workbook = null;
            ISheet sheet = null;
            IRow row = null;
            ICell cell = null;
            int startRow = 0;
            try
            {
                using (fs = File.OpenRead(filePath))
                {
                    string strExtension = Path.GetExtension(filePath).ToLower();
                    switch (strExtension)
                    {
                        case ".xlsx": // 2007版本
                            workbook = new XSSFWorkbook(fs);
                            break;
                        case ".xls": // 2003版本  
                            workbook = new HSSFWorkbook(fs);
                            break;
                    }

                    if (workbook != null)
                    {
                        sheet = workbook.GetSheetAt(sheetNum);//读取第一个sheet，当然也可以循环读取每个sheet  
                        dataTable = new System.Data.DataTable();
                        if (sheet != null)
                        {
                            int rowCount = sheet.LastRowNum;//总行数  
                            if (rowCount > 0)
                            {
                                IRow firstRow = sheet.GetRow(0);//第一行  
                                int cellCount = firstRow.LastCellNum;//列数  

                                //构建datatable的列  
                                if (isColumnName)
                                {
                                    startRow = 1;//如果第一行是列名，则从第二行开始读取  
                                    for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                                    {
                                        cell = firstRow.GetCell(i);
                                        if (cell != null)
                                        {
                                            if (cell.StringCellValue != null)
                                            {
                                                column = new DataColumn(cell.StringCellValue);
                                                dataTable.Columns.Add(column);
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    for (int i = firstRow.FirstCellNum; i < cellCount; ++i)
                                    {
                                        column = new DataColumn("column" + (i + 1));
                                        dataTable.Columns.Add(column);
                                    }
                                }

                                //填充行  
                                for (int i = startRow; i <= rowCount; ++i)
                                {
                                    row = sheet.GetRow(i);
                                    if (row == null || row.FirstCellNum < 0) continue;

                                    dataRow = dataTable.NewRow();
                                    for (int j = row.FirstCellNum; j < cellCount; ++j)
                                    {
                                        cell = row.GetCell(j);
                                        if (cell == null)
                                        {
                                            dataRow[j] = "";
                                        }
                                        else
                                        {
                                            //CellType(Unknown = -1,Numeric = 0,String = 1,Formula = 2,Blank = 3,Boolean = 4,Error = 5,)  
                                            switch (cell.CellType)
                                            {
                                                case CellType.Blank:
                                                    dataRow[j] = "";
                                                    break;
                                                case CellType.Numeric:
                                                    short format = cell.CellStyle.DataFormat;
                                                    //对时间格式（2015.12.5、2015/12/5、2015-12-5等）的处理  
                                                    if (format == 14 || format == 31 || format == 57 || format == 58)
                                                        dataRow[j] = cell.DateCellValue;
                                                    else
                                                        dataRow[j] = cell.NumericCellValue;
                                                    break;
                                                case CellType.String:
                                                    dataRow[j] = cell.StringCellValue;
                                                    break;
                                            }
                                        }
                                    }
                                    dataTable.Rows.Add(dataRow);
                                }
                            }
                        }
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                if (fs != null)
                {
                    fs.Close();
                }
                return null;
            }
        }
        #endregion

        ///// <summary>
        ///// 读取页面控件值，保存到模版类中，然后存入数据库
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="iDeclarationID"></param>
        ///// <param name="tmp"></param>
        ///// <param name="ctrlAnchor"></param>
        ///// <returns></returns>
        //public static int SaveData<T>(int iDeclarationID, System.Web.UI.Control ctrlAnchor, OleDbConnection conn) where T : Dal.Models.TemplateBase, new()
        //{
        //    int iResult = 0;
        //    T tmp = new T();

        //    PropertyInfo[] pis = tmp.GetType().GetProperties();

        //    foreach (System.Web.UI.Control ctrl in ctrlAnchor.Controls)
        //    {
        //        List<PropertyInfo> lstProp = pis.Where(p => p.Name == ctrl.ID).ToList();
        //        if (lstProp.Count > 0)
        //        {
        //            if (ctrl.GetType() == typeof(System.Web.UI.WebControls.DropDownList))
        //            {
        //                lstProp[0].SetValue(tmp, ((System.Web.UI.WebControls.DropDownList)ctrl).SelectedValue);
        //            }
        //            else if (ctrl.GetType() == typeof(System.Web.UI.WebControls.RadioButtonList))
        //            {
        //                lstProp[0].SetValue(tmp, ((System.Web.UI.WebControls.RadioButtonList)ctrl).SelectedValue);
        //            }
        //            else if (ctrl.GetType() == typeof(System.Web.UI.WebControls.TextBox))
        //            {
        //                lstProp[0].SetValue(tmp, ((System.Web.UI.WebControls.TextBox)ctrl).Text);
        //            }
        //            else if (ctrl.GetType() == typeof(System.Web.UI.HtmlControls.HtmlInputText))
        //            {
        //                lstProp[0].SetValue(tmp, ((System.Web.UI.HtmlControls.HtmlInputText)ctrl).Value);
        //            }
        //            else if (ctrl.GetType() == typeof(System.Web.UI.WebControls.CheckBox))
        //            {
        //                lstProp[0].SetValue(tmp, ((System.Web.UI.WebControls.CheckBox)ctrl).Checked);
        //            }
        //        }
        //    }

        //    OleDbTransaction trans = conn.BeginTransaction();
        //    try
        //    {
        //        BLL.Declaration.SaveDeclarateData<T>(iDeclarationID, tmp, conn, trans);
        //        trans.Commit();
        //        iResult = 1;
        //    }
        //    catch
        //    {
        //        trans.Rollback();
        //    }

        //    return iResult;
        //}

        public static string ConvertDataTableToXML(DataTable xmlDS)
        {
            MemoryStream stream = null;
            XmlTextWriter writer = null;
            try
            {
                using (stream = new MemoryStream())
                using (writer = new XmlTextWriter(stream, Encoding.UTF8))
                {
                    xmlDS.WriteXml(writer);
                    int count = (int)stream.Length;
                    byte[] arr = new byte[count];
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.Read(arr, 0, count);
                    UTF8Encoding utf = new UTF8Encoding();

                    return utf.GetString(arr).Trim();
                }
            }
            catch
            {
                return String.Empty;
            }
            finally
            {
                if (writer != null) writer.Close();
            }
        }

        /// <summary>
        /// 根据模版类中的值为页面控件赋值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tmpClass"></param>
        /// <param name="page"></param>
        public static void SetData<T>(T tmpClass, System.Web.UI.Control ctrlContainer) where T : Dal.Models.TemplateBase
        {
            // 为控件赋值
            PropertyInfo piSubItem = null;
            System.Web.UI.Control ctrl = null;
            bool bIsRequired = false;
            bool bIsPublic = false;

            string strRecordType = "";

            PropertyInfo[] pisMain = typeof(T).GetProperties();
            foreach (PropertyInfo piItem in pisMain)
            {
                object objItem = piItem.GetValue(tmpClass);
                PropertyInfo[] pisSub = piItem.PropertyType.GetProperties();
                for (int i = 0; i < pisSub.Length; i += 4)
                {
                    piSubItem = pisSub[i];
                    ctrl = ctrlContainer.FindControl(piSubItem.Name);
                    strRecordType = pisSub[i + 1].GetValue(objItem) == null ? "nvarchar" : pisSub[i + 1].GetValue(objItem).ToString();
                    bIsRequired = pisSub[i + 2].GetValue(objItem) == null ? false : (bool)pisSub[i + 2].GetValue(objItem);
                    bIsPublic = pisSub[i + 3].GetValue(objItem) == null ? false : (bool)pisSub[i + 3].GetValue(objItem);

                    if (ctrl != null)
                    {
                        ctrl.ClientIDMode = System.Web.UI.ClientIDMode.Static;

                        if (ctrl.GetType() == typeof(System.Web.UI.WebControls.DropDownList))
                        {
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add(
                                "data", objItem.ToString().TrimStart("Dal.Models.".ToCharArray()));
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add("RecordType", strRecordType);
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add("IsRequired", bIsRequired.ToString());
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add("IsPublic", strRecordType);

                            ((System.Web.UI.WebControls.DropDownList)ctrl).SelectedValue =
                                piSubItem.GetValue(objItem) == null ? "" : piSubItem.GetValue(objItem).ToString();
                        }
                        else if (ctrl.GetType() == typeof(System.Web.UI.WebControls.TextBox))
                        {
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add(
                                "data", objItem.ToString().TrimStart("Dal.Models.".ToCharArray()));
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add("RecordType", strRecordType);
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add("IsRequired", bIsRequired.ToString());
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add("IsPublic", strRecordType);

                            ((System.Web.UI.WebControls.TextBox)ctrl).Text =
                                piSubItem.GetValue(objItem) == null ? "" : piSubItem.GetValue(objItem).ToString();
                        }
                        else if (ctrl.GetType() == typeof(System.Web.UI.WebControls.Label))
                        {
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add(
                                "data", objItem.ToString().TrimStart("Dal.Models.".ToCharArray()));
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add("RecordType", strRecordType);
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add("IsRequired", bIsRequired.ToString());
                            ((System.Web.UI.WebControls.WebControl)ctrl).Attributes.Add("IsPublic", strRecordType);

                            ((System.Web.UI.WebControls.Label)ctrl).Text =
                                piSubItem.GetValue(objItem) == null ? "" : piSubItem.GetValue(objItem).ToString();
                        }
                        else
                        {
                            ((System.Web.UI.HtmlControls.HtmlInputText)ctrl).Attributes.Add(
                                "data", objItem.ToString().TrimStart("Dal.Models.".ToCharArray()));
                            ((System.Web.UI.HtmlControls.HtmlInputText)ctrl).Attributes.Add("RecordType", strRecordType);
                            ((System.Web.UI.HtmlControls.HtmlInputText)ctrl).Attributes.Add("IsRequired", bIsRequired.ToString());
                            ((System.Web.UI.HtmlControls.HtmlInputText)ctrl).Attributes.Add("IsPublic", strRecordType);

                            ((System.Web.UI.HtmlControls.HtmlInputText)ctrl).Value =
                                piSubItem.GetValue(objItem) == null ? "" : piSubItem.GetValue(objItem).ToString();
                        }
                    }
                }
            }
        }

        public static string DecodeUEditorContent(string strUEditorContent)
        {
            string strResult = strUEditorContent.Replace("&lt;", "<");
            strResult = strResult.Replace("&gt;", ">");
            strResult = strResult.Replace("&quot;", "\"");
            strResult = strResult.Replace("&rsquo;", "'");
            strResult = strResult.Replace("&frasl;", "/");
            strResult = strResult.Replace("&nbsp;", " ");

            return strResult;
        }

        public static byte[] ReadFile(string strFileName)
        {
            FileStream fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);

            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Close();

            return buffer;
        }

        // 生成条形码
        public static string zxing(string strDeclarationCode)
        {
            try
            {
                //Regex rg = new Regex("^[0-9]{13}$");
                string ZxingCode1 = strDeclarationCode.Substring(0, strDeclarationCode.Length - 4);
                string ZxingCode = ZxingCode1 + strDeclarationCode.Substring(strDeclarationCode.Length - 3);
                MultiFormatWriter mutiWriter = new com.google.zxing.MultiFormatWriter();
                ByteMatrix bm = mutiWriter.encode(ZxingCode, com.google.zxing.BarcodeFormat.EAN_13, 200, 35);
                Bitmap img = bm.ToBitmap();
                //自动保存图片到当前目录
                string strRootDirectory = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\";
                string strSavePath = strRootDirectory + "Temp/" + strDeclarationCode + "";
                if (!Directory.Exists(strSavePath))
                {
                    Directory.CreateDirectory(strRootDirectory + "Temp");
                    Directory.CreateDirectory(strSavePath);
                }
                string filename = strSavePath + "\\EAN_13" + strDeclarationCode + ".jpg";
                img.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                return filename;
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }

        // 生成二维码
        public static string CreatQRcode(string strDeclarationCode)
        {
            try
            {
                MultiFormatWriter mutiWriter = new com.google.zxing.MultiFormatWriter();
                ByteMatrix bm = mutiWriter.encode(strDeclarationCode, com.google.zxing.BarcodeFormat.QR_CODE, 150, 150);
                // 二维码图片
                Bitmap img = bm.ToBitmap();

                // logo图片
                System.Drawing.Bitmap bmp = (System.Drawing.Bitmap)System.Drawing.Bitmap.FromFile(@"D:\BGI-yangzhen\Appraise\Content\Images\logos.png");
                Bitmap img2 = new Bitmap(40, 40);
                Graphics g = Graphics.FromImage(img2);


                // 插值算法的质量
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(bmp, new Rectangle(0, 0, 40, 40), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();


                Bitmap zbmp = new Bitmap(img.Width, img.Height);
                Graphics g3 = Graphics.FromImage(zbmp);
                g3.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g3.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g3.DrawImage(img, 0, 0);
                g3.Dispose();

                System.Drawing.Image BackImg = zbmp;
                Graphics g2 = Graphics.FromImage(BackImg);
                g2.DrawImage(img, 0, 0, img.Width, img.Height);
                g2.DrawImage(img2, BackImg.Width / 2 - img2.Width / 2, BackImg.Width / 2 - img2.Width / 2, img2.Width, img2.Height);
                g2.Dispose();
                GC.Collect();

                //自动保存图片到当前目录
                string strRootDirectory = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\";
                string strSavePath = strRootDirectory + "Temp/" + strDeclarationCode + "";
                if (!Directory.Exists(strSavePath))
                {
                    Directory.CreateDirectory(strRootDirectory + "Temp");
                    Directory.CreateDirectory(strSavePath);
                }
                string filename = strSavePath + "\\QRcode" + strDeclarationCode + ".jpg";
                BackImg.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                //img2.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                return filename;
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
    }

    public class WordAction
    {
        //public static void HtmlToMht(string strSrc, string strPath)
        //{
        //    CDO.Message msg = new CDO.MessageClass();
        //    msg.Configuration = new CDO.ConfigurationClass();
        //    msg.CreateMHTMLBody(strSrc, CDO.CdoMHTMLFlags.cdoSuppressNone, "", "");
        //    ADODB.Stream stream = msg.GetStream();
        //    stream.SaveToFile(strPath, ADODB.SaveOptionsEnum.adSaveCreateOverWrite);
        //}

        // 参数内容都是从数据库读出来的文章信息，其中content就是ewebeditor生成的html代码
        //public static string WriteDocx(string name, string content)
        //{
        //    // 将string型的日期格式转为DateTime型的因为默认的日期格式不能作为文件名，所以将日期的“：”替换为“-”
        //    DateTime dt = DateTime.Now;
        //    // HTML模板的路径
        //    string Temp_Name = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\Template\\富文本转Word.html";
        //    string File_Name = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\Template\\【" + dt.ToShortDateString().Replace("/", "-") + "】" + name + ".html";//生成html文件的路径
        //    string File_NameM = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\Template\\【" + dt.ToShortDateString().Replace("/", "-") + "】" + name + ".mht";//生成mht文件的路径
        //    string File_Name2 = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\Template\\【" + dt.ToShortDateString().Replace("/", "-") + "】" + name + ".docx";//生成Word文档的路径

        //    StreamReader sr = new StreamReader(Temp_Name);
        //    StringBuilder sbHtmltext = new StringBuilder();
        //    String line;
        //    while ((line = sr.ReadLine()) != null)
        //    {
        //        // 读取到html模板的内容
        //        sbHtmltext.Append(line);
        //    }
        //    sr.Close();

        //    // 替换相应的内容到指定的位置
        //    sbHtmltext = sbHtmltext.Replace("$htmldata", content);

        //    using (StreamWriter sw = new StreamWriter(File_Name, false, System.Text.Encoding.GetEncoding("UTF-8"))) //保存地址
        //    {
        //        //生成HTML文件
        //        sw.WriteLine(sbHtmltext);
        //        sw.Flush();
        //        sw.Close();
        //    }

        //    // 因为带图片的html直接转为Word的话，图片会以引用的形式展示
        //    // （也就是说不是内置到word文档里去的，一旦断网或将图片放在别的路径之后，打开word文档图片会显示不出来，
        //    // 所以通过折冲的办法先生成html，然后转换为mht，再转为word）
        //    //HtmlToMht(File_Name, File_NameM);

        //    //生成word
        //    //SaveAsWord(File_NameM, File_Name2);

        //    Spire.Doc.Document document = new Spire.Doc.Document();
        //    document.LoadFromFile(File_Name, FileFormat.Html, XHTMLValidationType.None);
        //    document.SaveToFile(File_Name2, FileFormat.Docx);

        //    return File_Name2;
        //}

        //public static void SaveAsWord(string fileName, string pFileName)//使用原生方法将mht转换为word文档，不是那种直接修改后缀名的方式
        //{
        //    object readOnly = false;
        //    object isVisible = true;
        //    object file1 = fileName;
        //    object html1 = pFileName;
        //    object format = WdSaveFormat.wdFormatDocument;
        //    //Microsoft.Office.Interop.Word.ApplicationClass oWordApp = new Microsoft.Office.Interop.Word.ApplicationClass();            
        //    ApplicationClass oWordApp = new ApplicationClass();
        //    oWordApp.Visible = false;
        //    Microsoft.Office.Interop.Word.Document oWordDoc = oWordApp.Documents.Open(ref file1, ref   format, ref   readOnly);

        //    //将web视图修改为默认视图，不然打开word的时候会以web视图去展示，而不是默认视图。（唯独这句代码是自己加的 = =|||）
        //    oWordApp.ActiveWindow.View.Type = Microsoft.Office.Interop.Word.WdViewType.wdPrintView;
        //    oWordDoc.SaveAs(ref   html1, ref   format);
        //    oWordDoc = null;
        //    oWordApp.Application.Quit();
        //    oWordApp = null;
        //    killAllProcess(); 
        //}

        protected static void killAllProcess() // 杀掉所有winword.exe进程
        {
            System.Diagnostics.Process[] myPs;
            myPs = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process p in myPs)
            {
                if (p.Id != 0)
                {
                    string myS = "WINWORD.EXE" + p.ProcessName + "  ID:" + p.Id.ToString();
                    try
                    {
                        if (p.Modules != null)
                            if (p.Modules.Count > 0)
                            {
                                System.Diagnostics.ProcessModule pm = p.Modules[0];
                                myS += "\n Modules[0].FileName:" + pm.FileName;
                                myS += "\n Modules[0].ModuleName:" + pm.ModuleName;
                                myS += "\n Modules[0].FileVersionInfo:\n" + pm.FileVersionInfo.ToString();
                                if (pm.ModuleName.ToLower() == "winword.exe")
                                    p.Kill();
                            }
                    }
                    catch
                    {
                    }
                    finally
                    {
                    }
                }
            }
        }

        //public static bool WordToPDF(string sourcePath, string targetPath)
        //{
        //    bool result = false;

        //    Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
        //    Microsoft.Office.Interop.Word.Document document = null;
        //    try
        //    {
        //        application.Visible = false;
        //        document = application.Documents.Open(sourcePath);
        //        document.ExportAsFixedFormat(targetPath, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
        //        result = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        result = false;
        //    }
        //    finally
        //    {
        //        document.Close();
        //    }
        //    return result;
        //}

        //public static byte[] HtmlToWord(string strHtmlContent, string strBasePath)
        //{
        //    using (MemoryStream generatedDocument = new MemoryStream())
        //    {
        //        if (!string.IsNullOrEmpty(strHtmlContent))
        //        {
        //            strHtmlContent = strHtmlContent.Replace("⁄", "\\");
        //            strBasePath.Replace("/","\\");

        //            if (!strBasePath.EndsWith("\\"))
        //            {
        //                strBasePath += "\\";
        //            }

        //            if (!strHtmlContent.Contains(strBasePath))
        //            {
        //                strHtmlContent = strHtmlContent.Replace("\\Content\\Temp\\", strBasePath + "Content\\Temp\\");
        //            }

        //            using (WordprocessingDocument package = WordprocessingDocument.Create(generatedDocument, WordprocessingDocumentType.Document))
        //            {
        //                MainDocumentPart mainPart =  package.AddMainDocumentPart();
        //                DocumentFormat.OpenXml.Wordprocessing.Document doc = new DocumentFormat.OpenXml.Wordprocessing.Document(new DocumentFormat.OpenXml.Wordprocessing.Body());
        //                doc.Load(mainPart);
        //                // doc.Save(mainPart);

        //                HtmlConverter converter = new HtmlConverter(mainPart);
        //                converter.BaseImageUrl = new Uri(strBasePath);//指定图片路径，否则在word中不能正常显示图片  
        //                converter.ExcludeLinkAnchor = false;

        //                IList<OpenXmlCompositeElement> paragraphs = converter.Parse(strHtmlContent);
        //                for (int i = 0; i < paragraphs.Count; i++)
        //                {
        //                    mainPart.Document.Body.Append(paragraphs[i]);
        //                }

        //                mainPart.Document.Save();
        //            }
        //        }

        //        return generatedDocument.ToArray();
        //    }
        //}

        //public static void HtmlToWord(string strHtmlContent, string strTemplateFileName, ref FileStream fsTemp)
        //{
        //    Spire.Doc.Document doc = new Spire.Doc.Document();
        //    doc.LoadFromFile(strTemplateFileName);
        //    doc.Replace("$htmldata", strHtmlContent, false, false);
        //    doc.SaveToStream(fsTemp, FileFormat.Docx);
        //}
    }

    /// <summary>
    /// 加密解密
    /// </summary>
    public static class Encryption
    {
        private static byte[] key = { 0x21, 0x43, 0x65, 0x87, 0x09, 0xBA, 0xDC, 0xFE };
        private static byte[] IV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        /// <summary>  
        /// 加密处理  
        /// </summary>  
        /// <param name="strInput"></param>  
        /// <returns></returns>  
        public static string Encrypt(string strInput)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                Byte[] inputByteArray = Encoding.UTF8.GetBytes(strInput);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch
            {
                return "";
            }
        }

        /// <summary>  
        /// 解密处理  
        /// </summary>  
        /// <param name="strInput"></param>  
        /// <returns></returns>  
        public static string Decrypt(string strInput)
        {
            if (!string.IsNullOrEmpty(strInput))
            {
                strInput = strInput.Replace(" ", "+");
                Byte[] inputByteArray = new Byte[strInput.Length];
                try
                {
                    DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                    inputByteArray = Convert.FromBase64String(strInput);
                    MemoryStream ms = new MemoryStream();
                    CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, IV), CryptoStreamMode.Write);
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
                catch
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }

        ///<summary>
        ///给一个字符串进行MD5加密  MD5
        ///</summary>
        ///<param   name="strText">待加密字符串</param>
        ///<returns>加密后的字符串</returns>
        public static string MD5Encrypt(string strText)
        {
            if (string.IsNullOrEmpty(strText))
            {
                return "";
            }

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(strText));
            return System.Text.Encoding.Default.GetString(result);
        }

        public static string MD5Encrypt(string strText, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (string.IsNullOrEmpty(strText))
            {
                return "";
            }

            string strSql = " select dbo.Fn_MD5Encrypt(?) ";
            return Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@param", OleDbType.VarWChar) { Value = strText }).ToString();
        }
    }

    /// <summary>
    /// 身份证操作
    /// </summary>
    public static class IDOperation
    {
        /// <summary>
        /// 验证18位身份证号
        /// </summary>
        /// <param name="Id">身份证号</param>
        /// <returns>验证成功为True，否则为False</returns>
        public static bool CheckIDCard18(string Id)
        {
            if (Id.Length != 18)
            {
                return false;
            }

            long n = 0;
            if (long.TryParse(Id.Remove(17), out n) == false || n < Math.Pow(10, 16) || long.TryParse(Id.Replace("x", "0").Replace("X", "0"), out n) == false)
            {
                return false;//数字验证
            }
            string address = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91";
            if (address.IndexOf(Id.Remove(2)) == -1)
            {
                return false;//省份验证
            }
            string birth = Id.Substring(6, 8).Insert(6, "-").Insert(4, "-");
            DateTime time = new DateTime();
            if (DateTime.TryParse(birth, out time) == false)
            {
                return false;//生日验证
            }
            string[] arrVarifyCode = ("1,0,x,9,8,7,6,5,4,3,2").Split(',');
            string[] Wi = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(',');
            char[] Ai = Id.Remove(17).ToCharArray();
            int sum = 0;
            for (int i = 0; i < 17; i++)
            {
                sum += int.Parse(Wi[i]) * int.Parse(Ai[i].ToString());
            }
            int y = -1;
            Math.DivRem(sum, 11, out y);
            if (arrVarifyCode[y] != Id.Substring(17, 1).ToLower())
            {
                return false;//校验码验证
            }
            return true;//符合GB11643-1999标准
        }

        public static string GetGenderFromID(string strID)
        {
            // 判断输入参数是否是身份证号
            if (string.IsNullOrEmpty(strID) || !CheckIDCard18(strID))
            {
                throw new Exception("身份证号错误！");
            }

            // 判断第17位是单数还是双数 
            int iDivRem = 0;
            Math.DivRem(Convert.ToInt32(strID[16]), 2, out iDivRem);

            // 单数：男 双数：女
            return iDivRem == 1 ? "男" : "女";
        }
    }

    public static class ObjectOperation
    {
        /// <summary>  
        /// 从DLL文件中查找指定的对象定义  
        /// </summary>  
        /// <param name="dllFile">DLL文件路径</param>  
        /// <param name="objFullName">对象完整名称（包名和类名），如：com.xxx.Test</param>  
        /// <returns>如果找到，返回其对应的Type；如果没找到，则返回null</returns>  
        private static Type GetObjectType(string dllFile, string objFullName)
        {
            Type type = Assembly.LoadFile(dllFile).GetType(objFullName);
            if (type != null)
            {
                return type;
            }
            return null;
        }

        /// <summary>  
        /// 根据指定的类全名，返回对象实例  
        /// </summary>  
        /// <param name="objFullName">对象完整名称（包名和类名），如：com.xxx.Test</param>  
        public static object CreateObjectInstance(string objFullName, string strServerPath)
        {
            // 查找需要对象的实现定义  
            Type type = Type.GetType(objFullName);
            if (type == null)
            {
                type = GetObjectType(strServerPath + "\\Dal.dll", objFullName);
            }

            if (type == null)
            {
                throw new Exception("找不到对象： " + objFullName);
            }

            //将对象实例化  
            return Activator.CreateInstance(type);
        }
    }

}

