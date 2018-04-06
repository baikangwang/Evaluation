<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreatePrivilege.aspx.cs" MasterPageFile="~/View/Mutual/Site.Master" Inherits="Evaluation.View.Privilege.CreatePrivilege" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-size: 14px;
            font-family: "微软雅黑";
        }

        table tr td {
            padding: 5px 2px 10px 5px;
            text-align: right;
        }

        .div tr {
            margin-bottom: 5px;
        }

        #Btn_AddUser {
            width: 100%;
        }

        .btn {
            width: 78px;
            border-radius: 4px;
            background: #33B0BA;
            color: #fff;
            border: none;
            margin: 10px auto;
            display: block;
            padding: 0;
            height: 25px;
            line-height: 25px;
        }

            .btn:hover, .ui-state-default:hover, .ui-widget-content .ui-state-default:hover, .ui-widget-header .ui-state-default:hover, .ColVis_MasterButton:hover, .fc-state-default:hover, .btn:focus, .ui-state-default:focus, .ui-widget-content .ui-state-default:focus, .ui-widget-header .ui-state-default:focus, .ColVis_MasterButton:focus, .fc-state-default:focus {
                color: #fff !important;
                background-color: #62C1C9 !important;
                border-color: rgba(0,0,0,0.13);
            }

        input[type="text"]:focus {
            border-color: #ccc;
        }

        input[type="text"] {
            width: 166px;
            height: 25px;
            border: 1px solid #ccc;
            background: #fff;
        }

        .tableAlign {
            text-align: left;
            padding: 0 10px 0 0;
        }

        .Promptmessage {
            margin-left: 88px;
        }

        #btnAddUser {
            margin-top: 25px;
        }

        #ContentPlaceHolder1_btnAddUser {
            margin: 37px 10px 10px 16%;
        }

        .ms-drop ul {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <ul class="navs">
        <li class="nav1" id="main" style="float: left; padding-right: 5px;">
            <a href="#">权限管理</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="../UserManage/CreateUser.aspx">用户</a>
        </li>
    </ul>
    <div style="width: 296px; height: 330px; margin: 0 auto;">
        <div id="reminder" style="text-align: center; font-size: 15px; font-weight: 600;"></div>
        <div style="width: 296px; padding: 17px 3px 10px 20px; margin: 15px auto; border: 1px solid #e1e1e1; border-radius: 5px;">
            <table class="div">
                <tr>
                    <td>权限组名称：</td>
                    <td>
                        <asp:TextBox ID="PrivilegeName" runat="server" ClientID="PrivilegeName"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnUpdateUser" runat="server" class="btnt"  Text="修 &nbsp;&nbsp;  改" OnClick="Button2_Click" />
            <asp:Button ID="btnAddUser" runat="server" class="btnt"  Text="保 &nbsp;&nbsp;  存" OnClick="btnAddUser_Click"/>
            <input type="button" value="返  &nbsp;  回" class="btnt" onclick="window.location = '../Privilege/PrivilegeList.aspx'" />
        </div>
    </div>
    <script>

        $(function () {
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
                if (msg == "添加成功!" || msg == "修改成功!") {
                    $(".layui-layer-btn0").click(function () {
                      
                    });
                }
            }
        });
    </script>
</asp:Content>
