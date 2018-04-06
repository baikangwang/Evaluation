<%@ Page Title="修改密码" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="Evaluation.View.UserManage.UpdatePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
input{
    height:25px;
    border:none;
    border:1px solid #ccc;
}
.div tr td{
    padding-bottom:9px;
}
#ContentPlaceHolder1_btnUpdatePassword{
    margin:20px 6px 10px 17%;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">用户管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#">修改密码</a>
        </li>        
    </ul>
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <div style="width:280px;padding:18px 0 0 20px; margin:15px auto; border:1px solid #e1e1e1;border-radius:5px;">
        <table class="div">
            <tr>
                <td>原始密码：</td>
                <td><asp:TextBox runat="server" ID="txtYsPassword" ClientIDMode="Static"></asp:TextBox></td>              
            </tr>
            <tr>
                <td colspan="2" class="tableAlign" >                    
                    <span id="messageYsPassword" class="Promptmessage" style="color:red;" hidden="hidden">*请输入原始密码!</span>
                </td>
            </tr>
            <tr>
                <td>新&nbsp;密 &nbsp;码：</td>
                <td><asp:TextBox runat="server" ID="txtPassword" ClientIDMode="Static"></asp:TextBox></td>              
            </tr>
            <tr>
                <td colspan="2" class="tableAlign" >                    
                    <span id="messagePass" class="Promptmessage" style="color:red;" hidden="hidden">*请输入新密码!</span>
                </td>
            </tr>
            <tr>
                <td>确认密码：</td>
                <td><asp:TextBox runat="server" ID="txtRePassword" ClientIDMode="Static"></asp:TextBox></td>       
            </tr>
            <tr>
                <td colspan="2" class="tableAlign" >                    
                    <span id="message" class="Promptmessage" style="color:red;" hidden="hidden">*两次密码输入不一致!</span>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button id="btnUpdatePassword"  class="btnt" runat="server" Text="保 &nbsp;&nbsp;  存" OnClientClick="return checkrs()" OnClick="btnUpdatePassword_Click"/>
                    <asp:Button runat="server" ID="btnCancle" class="btnt" Text="返 &nbsp;&nbsp;  回" OnClick="btnCancle_Click" />
                </td>
            </tr>
        </table>
    </div>
    <script type="text/javascript">
        $(function () {
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            }
        })
        function checkrs() {
            var num = 0;
            //if ($("#txtYsPassword").val() == null || $("#txtYsPassword").val().trim() == "") {
            //    $("#messageYsPassword").show();
            //    num++;
            //}
            //else {
            //    $("#messageYsPassword").hide();
            //}
            if ($("#txtPassword").val() == null || $("#txtPassword").val().trim() == "") {
                $("#messagePass").show();
                num++;
            }
            else {
                $("#messagePass").hide();
            }
            if ($("#txtPassword").val().trim() != $("#txtRePassword").val().trim()) {
                $("#message").show();
                num++;
            }
            else {
                $("#message").hide();
            }
            if (num > 0) {
                return false;
            }
            else {
                return true;
            }
        }
    </script>
</asp:Content>
