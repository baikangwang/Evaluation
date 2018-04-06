<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="LeaguerChildUser.aspx.cs" Inherits="Evaluation.View.UserManage.LeaguerChildUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>

        table tr td {
            padding: 5px 0 10px 5px;
        }

        #Btn_EditUser {
            width: 100%;
        }

        .btn {
            padding: 0;
            width: 78px;
            text-align: center;
            border-radius: 4px;
            height: 25px;
            line-height: 25px;
            display: block;
            margin: 0 auto;
        }

        input[type="text"]:focus {
            border-color: #ccc;
        }

        input[type="text"] {
            width: 165px;
            height: 25px;
            border: 1px solid #ccc;
            background: #fff;
        }

        input[type="password"] {
            width: 165px;
            height: 25px;
            border: none;
            border: 1px solid #ccc;
            background: #fff;
        }

        #ContentPlaceHolder1_BtnEditUser {
           margin-right:10px;
            margin-top: 10px;
        }

        #ContentPlaceHolder1_btnCreateUser {
            margin-right: 10px;
        }
    </style>   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
     <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">用户管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#">会员子用户</a>
        </li>        
    </ul>
    <div style="width:280px;margin:15px auto; border:1px solid #e1e1e1;border-radius:4px; padding: 15px 0 0 13px;">
       <%--  <div id="reminder" style="text-align:center;font-size:15px;font-weight:600;"></div>--%>
        <table>
            <tr>
                <td style="text-align:right">用户姓名：</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox></td>
            </tr>
            <%--<tr>
                <td style="text-align:right">密 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;码：</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox></td>
            </tr>
            <tr>
                <td style="text-align:right">确认密码：</td>
                <td>
                    <asp:TextBox ID="txtPasswordConfirm" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>--%>
            <tr>
                <td style="text-align:right">邮 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;箱：</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"class="tableAlign" >                    
                    <span id="messageEmail" class="Promptmessage" style="color:red;" hidden="hidden">*请输入正确的邮箱</span>                    
                </td>
            </tr>
            </table>
           <div style="width:180px;margin:30px auto 22px;">
                    <asp:Button ID="BtnEditUser" class="btnt" runat="server" Text="保  存" OnClientClick="return requiredInfo()" OnClick="BtnEditUser_Click" />
                    <asp:Button ID="btnCreateUser" class="btnt" runat="server" Text="添  加" OnClientClick="return requiredInfo()" OnClick="btnCreateUser_Click" />              
                    <asp:Button ID="btnCancle" CssClass="btnt" runat="server" Text="返  回" OnClick="btnCancle_Click" />
          </div>      

       
    </div>
<script type="text/javascript">
    $(function () {
        var msg = $("#hdMsg").val();
        if (msg != "") {
            ShowMessag(msg);
            if (msg == "保存成功!" || msg == "修改成功!") {
                $(".layui-layer-btn0").click(function () {
                    window.location = "LeaguerChildUserList.aspx";
                });
            }
        }
    });
    function requiredInfo() {
        if ($("#txtEmail").val() == null || $("#txtEmail").val() == "" || (!fChkMail($("#txtEmail").val()))) {
            $("#messageEmail").show();
            return false;
        }
        else {
            $("#messageEmail").hide();
            return true;
        }
    }
    function fChkMail(szMail) {
        var szReg = /^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(.[a-zA-Z0-9_-])+/;
        return szReg.test(szMail);
    }
    </script>
</asp:Content>
