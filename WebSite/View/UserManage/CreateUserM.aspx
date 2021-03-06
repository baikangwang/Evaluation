﻿<%@ Page Title="创建用户" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="CreateUserM.aspx.cs" Inherits="Evaluation.View.UserManage.CreateUserM" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-size: 14px;
            font-family: "微软雅黑";
        }

        table tr td {
            padding: 5px 0 10px 5px;
        }

        .div tr {
            margin-bottom: 5px;
        }

        #Btn_AddUser {
            width: 100%;
        }

        #content {
            margin-left: 203px;
            overflow: hidden;
            padding: 60px;
            padding-right: 0;
            padding-left: 30px;
            background-color: #eeeeee;
            padding-top: 110px;
            padding-right: 30px;
            padding-bottom:170px!important;
        }

        .btn {
            width: 78px;
            border-radius: 4px;
            background: #33B0BA;
            color: #fff;
            margin-top: 10px;
            border: none;
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
            border: 1px solid #ccc;
            background: #fff;
        }

        .btn:hover, .ui-state-default:hover, .ui-widget-content .ui-state-default:hover, .ui-widget-header .ui-state-default:hover, .ColVis_MasterButton:hover, .fc-state-default:hover, .btn:focus, .ui-state-default:focus, .ui-widget-content .ui-state-default:focus, .ui-widget-header .ui-state-default:focus, .ColVis_MasterButton:focus, .fc-state-default:focus {
            color: #fff !important;
            background-color: #62C1C9 !important;
            border-color: rgba(0,0,0,0.13);
        }

        input[type="text"]:focus {
            border-color: #ccc;
        }

        .tableAlign {
            text-align: left;
            padding: 0 10px 0 0;
        }

        .Promptmessage {
            margin-left: 88px;
        }

        .ms-choice {
            height: 25px;
            line-height: 25px;
            border-radius: 0px;
            border-color: #ccc;
        }
        #listSpecialty option{
            margin-left:7px;
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
    <div style="width:280px;margin:0 auto;">
     <div id="reminder1" style="text-align:center;font-size:15px;font-weight:600;">分会管理员</div>
       <div style="width:280px;padding: 15px 0 0 13px; margin:15px auto; border:1px solid #e1e1e1;border-radius:5px;">
        <asp:HiddenField ID="operateType" runat="server" ClientIDMode="Static" />
        <asp:HiddenField ID="hdUserID" runat="server" ClientIDMode="Static" />
        <asp:HiddenField ID="hdIsSelf" runat="server" ClientIDMode="Static" />
        <asp:HiddenField ID="checkeds" runat="server" ClientIDMode="Static" />
       
        <table class="div">
            <tr>
                <td>用户名称：</td>                
                <td>
                    <input id="txtUserName" runat="server" ClientIDMode="Static" type="text"/>
                </td>                
            </tr>
            <tr>
                <td colspan="2"class="tableAlign" >                    
                    <span id="messageName" class="Promptmessage" style="color:red;" hidden="hidden">*用户名不能为空!</span>
                </td>
            </tr>
            <%--<tr>
                <td>密 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 码：</td>
                <td><input id="txtPassword" type="password"  /></td>              
            </tr>
            <tr>
                <td>确认密码：</td>
                <td><input id="txtRePassword" type="password"  />
                </td>       
            </tr>
            <tr>
                <td colspan="2" class="tableAlign">                    
                    <span id="message" class="Promptmessage"style="color:red;" hidden="hidden">*两次密码输入不一致!</span>
                </td>
            </tr>--%>
            <tr>
                <td>邮  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 箱：</td>
                <td><input id="txtEmail" runat="server" type="text" ClientIDMode="Static" />
                </td>          
            </tr>
            <tr>
                <td colspan="2" class="tableAlign">                           
                    <span id="messageEmail" class="Promptmessage" style="color:red;" hidden="hidden">*请输入正确的邮箱格式!</span>
                </td>
            </tr>
            <tr>
                <td id="pad">专 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 业：</td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlSpecialty" ClientIDMode="Static" Style="width:165px;height:30px;"></asp:DropDownList>
                    <asp:ListBox runat="server" ID="listSpecialty" ClientIDMode="Static" Style="width:166px;display:none;border-color:#ddd;" Enabled="false" ></asp:ListBox>
                </td>      
            </tr>
            <tr>
                <td colspan="2" class="tableAlign">                    
                    <span id="messageddlSpecialty"class="Promptmessage" style="color:red;" hidden="hidden">请选择专业!</span>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align:center">
                    <input id="btnAddUser" class="btn" type="button" value="保 &nbsp;&nbsp;  存" style="width:78px;height:25px;line-height:25px;padding:0;margin:22px 5px 10px;" />
                    <input id="btnCancel" class="btn" type="button" value="返 &nbsp;&nbsp;  回" style="width:78px;height:25px;line-height:25px;padding:0;margin:22px 5px 10px;" />
                </td>
            </tr>
        </table>
    </div>
        </div>
    <script>
        function fChkMail(szMail) {
            var szReg = /^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(.[a-zA-Z0-9_-])+/;
            return szReg.test(szMail);
        }

        $(function () {
            $('#listSpecialty').attr('size', $('#listSpecialty option').length);
            var UserName = $('#txtUserName').val();
            if (UserName != "") {
                $('#txtUserName').attr('disabled', 'disabled')
            }
            $("#ddlSpecialty").multipleSelect({
                selectAllText: '全选',
                allSelected: '全部选中',
            });
            var types = $('#tyUserType').val();
            if (types == "分会用户") {              
                $('.ms-parent ').css('display', 'none');
            }
            var tem = $("#checkeds").val().split(",");
            $("#ddlSpecialty").multipleSelect('setSelects', tem);
            if ($("#hdIsSelf").val() == "true") {
                $("#ddlSpecialty").multipleSelect('disable');
                document.getElementById("listSpecialty").style.display = "block";               
            }

        });

        $("#btnAddUser").click(function () {
            var bError = false;
            if ($("#txtPassword").val() != $("#txtRePassword").val()) {
                $("#message").show();
                bError = true;
            }

            if ($("#txtUserName").val() == null || $("#txtUserName").val() == "") {
                $("#messageName").show();
                bError = true;
            }

            if ($("#txtEmail").val() == null || $("#txtEmail").val() == "" || (!fChkMail($("#txtEmail").val()))) {
                $("#messageEmail").show();
                $("#messageEmail1").hide();
                bError = true;
            }

            if (bError == false) {
                var SpecialtyIDs = $("select").first().multipleSelect("getSelects").toString();
                $("#message").hide();
                $("#messageEmail").hide();
                $("#messageName").hide();

                $.ajax({
                    url: "../Mutual/UserManage.ashx",
                    type: "post",
                    data: {
                        "Action": "CreateUserM",
                        "UserType": "0804", //GetQueryString("UserType"),
                        "UserID": $("#hdUserID").val(),
                        "UserName": $("#txtUserName").val(),
                        //"Password": $("#txtPassword").val(),
                        "Email": $("#txtEmail").val(),
                        "SpecialtyIDs": SpecialtyIDs,
                        "oType": $("#operateType").val()
                    },
                    success: function (data) {
                        ShowMessag(data);
                        if (data == "创建成功！" || data == "修改成功！") {
                            $(".layui-layer-btn0").click(function () {
                                window.location = "UserList.aspx";
                            });
                        }
                    }
                });
            }
        });

        $("#btnCancel").click(function () {
            window.location = "UserList.aspx";
        });
    </script>
</asp:Content>