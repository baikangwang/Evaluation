

/****** Object:  View [dbo].[V_Prize]    Script Date: 08/01/2017 12:43:13 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[V_Prize]'))
DROP VIEW [dbo].[V_Prize]
GO

/****** Object:  View [dbo].[V_Prize]    Script Date: 08/01/2017 12:43:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[V_Prize]
AS
SELECT     p.PrizeID, p.PrizeName, p.SpecialtyID, p.PrizeCode, p.PrizeTypeCode, p.TemplateCode, p.IsMultipleVoting, p.ParticipantLimit, p.AppendixDiscription, p.Ordinal, 
                      p.CreateTime, p.LastUpdateTime, ISNULL(p.MultipleVoteRound, 1) AS MultipleVoteRound, ISNULL(p.IsStopVote, 0) AS IsStopVote, p.votetype, p.RevoteRound, 
                      s.SpecialtyName, s.TotalOrdinal AS SpecialtyTotalOrdinal, s.ActivityID, scp.ConstantValue AS PrizeType, sv.ConstantValue AS VoteTypeText, 
                      L1.LevelLimitNumber AS FirstPrize, L2.LevelLimitNumber AS SecondPrize, L3.LevelLimitNumber AS ThirdPrize,
                          (SELECT     SUM(LevelLimitNumber) AS Expr1
                            FROM          dbo.PrizeLevel
                            WHERE      (PrizeID = p.PrizeID)) AS AwardCount,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          dbo.Declaration
                            WHERE      (PrizeID = p.PrizeID)) AS DeclarationCount,
                          (SELECT     COUNT(*) AS Expr1
                            FROM          dbo.Declaration AS Declaration_1
                            WHERE      (PrizeID = p.PrizeID) AND (DeclarationStatus = '1803')) AS DeclarationCheckCount,
                          (SELECT     COUNT(DISTINCT UserID) AS Expr1
                            FROM          dbo.Vote
                            WHERE      (PrizeID = p.PrizeID) AND (MultipleVoteRound = p.MultipleVoteRound) AND (ISNULL(ReVoteRound, 0) = ISNULL(p.RevoteRound, 0))) 
                      AS VotedExpertCount
, case when ISNULL(p.MultipleVoteRound, 1) = 1 then (SELECT COUNT(*) FROM dbo.Declaration WHERE PrizeID = p.PrizeID AND DeclarationStatus = '1803')
       else (SELECT COUNT(*) FROM dbo.VoteResult WHERE PrizeID = p.PrizeID AND isnull(MultipleVoteRound, 1) = (isnull(p.MultipleVoteRound, 1)-1))
       end as VoteDeclarationCount                      
FROM         dbo.Prize AS p INNER JOIN
                      dbo.Specialty AS s ON s.SpecialtyID = p.SpecialtyID INNER JOIN
                      dbo.SysConstant AS scp ON scp.ConstantCode = p.PrizeTypeCode LEFT OUTER JOIN
                      dbo.SysConstant AS sv ON sv.ConstantCode = p.votetype LEFT OUTER JOIN
                      dbo.PrizeLevel AS L1 ON L1.PrizeID = p.PrizeID AND L1.LevelCode = '0401' LEFT OUTER JOIN
                      dbo.PrizeLevel AS L2 ON L2.PrizeID = p.PrizeID AND L2.LevelCode = '0402' LEFT OUTER JOIN
                      dbo.PrizeLevel AS L3 ON L3.PrizeID = p.PrizeID AND L3.LevelCode = '0403'


GO


