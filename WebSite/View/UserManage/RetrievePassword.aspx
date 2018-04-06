<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RetrievePassword.aspx.cs" Inherits="Evaluation.View.UserManage.RetrievePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
        <script type="text/javascript" src="../../Content/assets/js/libs/jquery-1.10.2.min.js"></script>
        <link href="../../Content/plugins/Verification/jquery.idcode.css" rel="stylesheet" />
        <script src="../../Content/plugins/Verification/jquery.idcode.js"></script>
        <link rel="stylesheet" type="text/css" href="../../Content/font-awesome.css"/>
        <script type="text/javascript" src="../../Content/plugins/cookie/jquery.cookie.min.js"></script>
        <script type="text/javascript" src="../../Content/plugins/layer/layer.js"></script>
        <script type="text/javascript" src="../../Content/Javascript/FunctionJS.js"></script>
        <style>
            *{
                margin:0;padding:0;font-family:"微软雅黑";font-size:15px;
            }
            #Txtidcode{width:80px;}
            table{margin:auto;}
            table tr td{padding:10px;}
            table tr td {
                padding: 10px 0 10px 10px;
            }
           #btnNext{
             /*background: -webkit-gradient(linear, 0% 0%, 0% 100%,from(#39C4D8), to(#2C96A4));*/
             background-image:url(../../Content/Images/dl.png);
             background-size:cover;
            width:170px;
            color:#ffffff;
            border-radius:6px;
            font-family:"微软雅黑";
            font-weight:800;
            border-bottom:3px solid #0F7AD2;
            height:35px;
            outline:none;
            margin-left:50%;
            margin-left:94px;
            cursor: pointer;
            border:none;
            cursor:pointer;

        }
            #UpdatePanel1{
                margin-top:21px;
            }
            .crumbs{
                width:56%;
                height:36px;
             
                margin-left:24%;
                margin-top:20px;
                overflow:hidden;
            }
             .crumbs1 span{
                 color:#ffffff;
                 padding-left:27%;
                 display:block;
                 padding-top:8px;
             }
              .crumbs2 span{
                 color:#ffffff;
                 padding-left:33%;
                  display:block;
                 padding-top:8px;
             }
              .crumbs3 span{
                 color:#ffffff;
                 padding-left:41%;
                 display:block;
                 padding-top:8px;
             }


            .crumbs1{
                float:left;
                width:33%;
                height:100%;
              
                background-image:url(../../Content/Images/tab1.png) ;
                background-size: 100% 116%;
                background-repeat: no-repeat;
                background-position: 0 -2px;
            }
               .crumbs2{
                float:left;
                width:34%;
                height:100%;
                margin-left:-19px;
                background-image:url(../../Content/Images/tab2.png);
                background-size: 100% 112%;
                background-repeat: no-repeat;
                background-position: 0 -1px;
            }
                  .crumbs3{
                float:left;
                width:33%;
                height:100%;
                margin-left:-19px;
                background-image:url(../../Content/Images/tab2.png);
                 background-size: 100% 112%;
                background-repeat: no-repeat;
                background-position: 0 -1px;
            }
                  #btnNext{
                      font-weight:400;
                  }
                   .layui-layer-btn .layui-layer-btn0 {
            border-color: #34B0Ba !important;
            background-color: #34B0Ba !important;
            width: 78px !important;
            height: 26px !important;
        }

        .layui-layer.layui-layer-page.layer-anim {
            width: 280px !important;
            height: 156px !important;
            margin-left:-67px;
        }

        .layui-layer-btn a {
            line-height: 24px !important;
        }

        .layui-layer-setwin a:hover {
            background-color: transparent !important;
        }

        .layui-layer-title {
            background: #85E1E1 !important;
        }

        .layui-layer-content {
            height: 60px;
        }
        #txtIdcode{
            width:89px;
        }
        </style>
</head>
<body>
    <form runat="server" id="form1">
        <div class="img">
            <img  src="#" style="width: 100%; height: 100%;" />
        </div>         
        <div class="crumbs">
            <div class="crumbs1">
                <span>1.进行安全验证</span>
            </div>
            <div class="crumbs2">
                  <span>2.设置新密码</span>
            </div>
            <div class="crumbs3">
                  <span>3.成功</span>
            </div>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div style="width: 40%; margin: auto;padding-left:50px;">
                    <br />                                 
                    <div>
                        <table>
                            <tr>
                                <td>
                                    <label>请输入账号  :</label></td>
                                <td>
                                    <asp:TextBox ID="txtUserName" ClientIDMode="Static" runat="server" Enabled="false"></asp:TextBox><span style="color: red;font-size:13px;"> * </span>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>请输入邮箱  :</label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtEmail" ClientIDMode="Static"  runat="server"></asp:TextBox>
                                    <span style="color: red;font-size:13px"> * ( 邮箱必须是您注册时使用的邮箱! )</span>
                                </td>
                            </tr>
                            <tr>
                               <td colspan="2"class="tableAlign" >                    
                                   <span id="messageEmail" class="Promptmessage" style="color:red;" hidden="hidden">*请输入正确的邮箱</span>                    
                               </td>
                            </tr>
                            <tr>
                                <td>
                                    <label>输入验证码  :</label></td>
                                <td>
                                    <input type="text" id="txtIdcode" class="txtVerification" />&nbsp;
                                    <span id="Txtidcode_message" runat="server" style="color: red;font-size:13px;"></span>&nbsp;&nbsp;
                                    <span id="idcode"></span>
                                </td>
                            </tr>
                          
                            <tr>
                                <td colspan="2" style="position:relative;">
                                    <input id="btnNext" type="button" value="发送验证邮件" />
                                    <i class="fa fa-caret-right" style="color:#fff;position:absolute;left:240px;top:20px;cursor: pointer;"></i>
                                </td>
                            </tr>
                        </table>
                    </div>                  
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>       
    </form>
    <script>
        $.idcode.setCode();   //加载生成验证码方法

      
        // 发送邮件
        $("#btnNext").click(function () {
            if ($("#txtEmail").val() == null || $("#txtEmail").val() == "" || (!fChkMail($("#txtEmail").val()))) {
                $("#messageEmail").show();
            }
            else {
                var IsBy = $.idcode.validateCode();  //调用返回值，返回值结果为true或者false
                if (IsBy) {
                    $("#Txtidcode_message").text("");
                    $.ajax({
                        url: "../Mutual/UserManage.ashx",
                        type: "post",
                        data: {
                            "Action": "SendEmailToFindPwd",
                            "UserName": $("#txtUserName").val(),
                            "UserEmail": $("#txtEmail").val()
                        },
                        success: function (data) {
                            $("#btnN").attr("diasbled", "diasbled");
                            ShowMessag(data);
                        }
                    });
                } else {
                    $("#Txtidcode_message").text(" * ( 验证码不正确! )");
                    return false;
                }
            }
        });

        function fChkMail(szMail) {
            var szReg = /^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(.[a-zA-Z0-9_-])+/;
            return szReg.test(szMail);
        }

        $(function () {
            var logoSrc = $.cookie('logoSrc');
            $('.img img').attr("src", logoSrc);
        });

    </script>
</body>
</html>
