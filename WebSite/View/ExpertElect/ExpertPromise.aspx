<%@ Page Title="专家评审" Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ExpertPromise.aspx.cs" Inherits="Evaluation.View.ExpertElect.ExpertPromise" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .navbox{
            width:800px;height:auto;margin:0 auto;
        }
         .navbox h2{
            font-weight:500;font-size:32px;text-align:center;margin-bottom:30px;margin-top:0;
        }
         p{
             text-indent:2em;font-size: 16px;line-height: 2;    
         }
         .btns{
             width:200px;margin:60px auto 30px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="navbox">
        <h2>专 家 承 诺 书</h2>
        <p> 本人同意受邀作为北京工程勘察设计行业协会（以下简称“协会”）主办的2017年度“北京市优秀工程勘察设计奖”（以下简称“市优评选”）
            的评审专家，在担任评审专家期间，郑重承诺如下：
        </p>
        <p>一、遵循公平、公正的原则，秉承严肃、认真和高度负责的工作态度，独立客观的发表自己的见解，尊重其他专家的不同意见；</p>
        <p>二、遵守保密制度，在工作过程中及未经协会同意前，不采取笔记、录音、录像、拍摄等方式留存与评选活动有关的任何资料，
            不以任何形式擅自透露协会、其他专家或本人在评选活动中的信息；
        </p>
        <p>三、遵守回避原则，接受委托的工作内容如涉及本人曾参与的项目、本人所在单位的项目及与本人有直接利害关系的第三方项目时，
            应事先声明，并在提供意见环节中主动回避；
        </p>
        <p>四、担任协会行业专家期间，应尊重北京工程勘察设计行业协会所委托工作的时间安排，在不能保证工作时间或时间上有冲突时，应事先声明，
            以保证工作进度要求和工作质量。妥善保管专家在线投票的账号和密码，使用本人账号在线提交的评价意见、投票结果均应是本人真实意见的表达，
            不委托他人代为投票或发表意见。
        </p>
        <div class="btns">
        <input type="button" name="name" value="返   回"  class="btnt" style="margin-right:20px;" id="Back" />
        <input type="button" name="name" value="同   意"  class="btnt" id="consent"/>
        </div>
    </div>
    <script>
        $(function () {
            $('#consent').click(function () {
                window.location="../ExpertElect/ExpertReview.aspx"
            })
            $('#Back').click(function () {
                window.location = "../Mutual/HomePage.aspx"
            })
        })
    </script>
</asp:Content>

