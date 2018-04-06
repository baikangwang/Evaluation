<%@ Page  Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ManagerUser.aspx.cs" Inherits="Evaluation.View.UserManage.ManagerUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        table {
            margin-top: 18px;
        }

            table tr td {
                padding: 5px 3px 12px;text-align:right;
            }

        input[type="text"] {
            width: 200px;
            height: 25px;
            border: none;
            border: 1px solid #ccc;
            background: #fff;
        }

        input[type="password"] {
            width: 200px;
            height: 25px;
            border: none;
            border: 1px solid #ccc;
            background: #fff;
        }
        #ContentPlaceHolder1_btnCancel{
            margin:20px 18% 0 10px;
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
          <a href="#">用户</a>
        </li>        
    </ul>
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <div style="margin:15px auto; width:317px;border:1px solid #e1e1e1;border-radius:3px;padding: 2px 18px 10px 15px;">
        <table>
            <tr>
                <td>用户姓名：</td>
                <td>
                    <asp:TextBox ID="UserName" runat="server" Enabled="false"></asp:TextBox></td>
            </tr>
            <%--<tr>
                <td>密码：</td>
                <td>
                    <asp:TextBox ID="PassWord" runat="server"></asp:TextBox></td>
            </tr>--%>
            <tr>
                <td>邮箱：</td>
                <td>
                    <asp:TextBox ID="Email" ClientIDMode="Static" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"class="tableAlign" >                    
                    <span id="messageEmail" class="Promptmessage" style="color:red;margin-right:97px;" hidden="hidden">*邮箱格式不正确</span>                    
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Btn_EditUser" class="btnt" runat="server" Text="保  存" OnClientClick="return requiredInfo()" OnClick="BtnEditUser_Click" />
                    <asp:Button ID="btnCancel" class="btnt" runat="server" Text="返  回" OnClick="btnCancel_Click" />
                </td>
            </tr>
        </table>
    </div>
    <script>
        $("#ddlSpecialtyID").multipleSelect();
    </script>
    <script type="text/javascript">
        $(function () {
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
                if (msg == "修改成功!") {
                    $(".layui-layer-btn0").click(function () {
                        window.location = "UserList.aspx";
                    });
                }
            }
        });
        function requiredInfo() {
            if ($("#Email").val() == null || $("#Email").val() == "" || (!fChkMail($("#Email").val()))) {
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
