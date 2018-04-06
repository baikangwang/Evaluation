<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RetrievePassword_Return.aspx.cs" Inherits="Evaluation.View.UserManage.RetrievePassword_Return" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
            <script type="text/javascript" src="../../Content/assets/js/libs/jquery-1.10.2.min.js"></script>
            <script type="text/javascript" src="../../Content/plugins/cookie/jquery.cookie.min.js"></script>
        <style>
            *{
                margin:0;padding:0;font-family:"微软雅黑";font-size:15px;
            }
            table{margin:auto;}
            table tr td{padding:10px;}
            #Btn_success{
                width:100px;height:28px;margin-left:98px;
                background:url(../../Content/Images/dl.png);
                background-size:cover;
                border:none;
                border-radius:6px;
                color:#fff;
                margin-top:24px;
                outline:none;
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
              
                 background-image:url(../../Content/Images/tab1a.png) ;
                background-size: 100% 121%;
                background-repeat: no-repeat;
                background-position: 0 -2px;
            }
               .crumbs2{
                float:left;
                width:35%;
                height:100%;
                 margin-left:-20px;
               
                 background-image:url(../../Content/Images/tab2a.png) ;
                background-size: 100% 129%;
                background-repeat: no-repeat;
                background-position: 0 -4px;
            }
                  .crumbs3{
                float:left;
                width:34%;
                height:100%;
                margin-left:-18.5px;
               
                 background-image:url(../../Content/Images/tab2.png) ;
                background-size: 100% 124%;
                background-repeat: no-repeat;
                background-position: 0 -2px;
            }
            table tr td {
                padding: 10px 0 10px 10px;
            }
        </style>
</head>
<body>
    <form runat="server">
        <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />

        <div class="img">
            <img src="#" style="width: 100%; height: 100%;" />
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
        <br />
        <div style="width: 30%; margin: auto;margin-top:21px;">
        
            <table>
                <tr>
                    <td>
                        <asp:Label ID="UserName" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>请输入密码：</label></td>
                    <td style="padding: 10px 0 10px 5px;">
                        <asp:TextBox ID="Password" runat="server"></asp:TextBox><span style="color: red;font-size:13px;margin-left:4px">*</span>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>请再次输入：</label></td>
                    <td style="padding: 10px 0 10px 5px;">
                        <asp:TextBox ID="Password_R" runat="server"></asp:TextBox><span style="color: red;font-size:13px;margin-left:4px">*</span>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" >
                        <asp:Button ID="Btn_success" class="btn btn-primary" runat="server" Text=" &nbsp;确  认&nbsp; " OnClick="Btn_success_Click" />
                    </td>
                </tr>
            </table>
           
        </div>
      
    </form>
</body>
    <script type="text/javascript">
        $(function () {
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            }
            var logoSrc = $.cookie('logoSrc');
            $('.img img').attr("src", logoSrc);
        })
    </script>
</html>