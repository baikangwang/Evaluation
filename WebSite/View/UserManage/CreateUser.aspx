<%@ Page Title="创建用户" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="Evaluation.View.UserManage.CreateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-size: 14px;
            font-family: "微软雅黑";
        }
        table tr td {
            padding: 5px 2px 10px 5px;text-align:right;
        }
        .div tr {
            margin-bottom: 5px;
        }
        #Btn_AddUser {
            width: 100%;
        }
        .btn {
            width:78px;
            border-radius: 4px;
            background: #33B0BA;
            color: #fff;
            border: none;
            margin:10px auto;
            display:block;
            padding:0;
            height:25px;
            line-height:25px;
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
            width:166px;
            height:25px;
            border: 1px solid #ccc;
            background: #fff;           
        }  
             
        .tableAlign{
            text-align:left;
            padding:0 10px 0 0;
        }
        .Promptmessage{margin-left:88px;}
        #btnAddUser{
            margin-top:25px;
        }
        #ContentPlaceHolder1_btnAddUser{
            margin:37px 10px 10px 16%;
        }
        .ms-drop ul {
           text-align:left;
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
          <a href="../UserManage/CreateUser.aspx">用户</a>
        </li>        
    </ul>
    <div style="width:296px;height:330px;margin:0 auto;">
     <div id="reminder" style="text-align:center;font-size:15px;font-weight:600;"></div>
    <div style="width:296px;padding: 17px 3px 10px 20px; margin:15px auto; border:1px solid #e1e1e1;border-radius:5px;">        
        <table class="div">          
            <tr>
                <td>用户名称：</td>                
                <td><input id="txtUserName" type="text"  />
                </td>                
            </tr>
            <tr>
                <td colspan="2"class="tableAlign" >                    
                    <span id="messageName"class="Promptmessage" style="color:red;" hidden="hidden">*用户名不能为空！</span>
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
                <td colspan="2"class="tableAlign" >                    
                    <span id="message" class="Promptmessage" style="color:red;" hidden="hidden">*两次密码输入不一致!</span>
                </td>
            </tr>--%>
            <tr>
                <td>邮  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 箱：</td>
                <td><input id="txtEmail" type="text"  />
                </td>          
            </tr>
            <tr>
                <td colspan="2"class="tableAlign" >                    
                    <span id="messageEmail" class="Promptmessage" style="color:red;" hidden="hidden">*输入正确的邮箱！</span>                    
                </td>
            </tr>
            <%--<tr>
                <td>选择专业：</td>          
                <td>
                 <asp:DropDownList runat="server" ID="ddlSpecialtyUser" ClientIDMode="Static" Style="width: 60%;"></asp:DropDownList>
                </td>
            </tr>--%>          
                    <%--<input id="btnAddUser" class="btn" type="button" value="保 &nbsp;&nbsp;  存" onclick="requiredInfo()"/>--%>            
        </table>
         <asp:Button ID="btnAddUser" class="btnt" runat="server" Text="保 &nbsp;&nbsp;  存" OnClientClick="return requiredInfo()"/>
        <input type="button" value="返  &nbsp;  回" class="btnt" onclick="history.go(-1)" />
    </div>
        </div>
    <script>
        $(function () {
            var url = window.location.search.substr(-4);                   
            if (url == '0802') {
                $('#reminder').html('系统管理员')
            } else if (url == '0803') {
                $('#reminder').html('协会管理员')
            }
        })
        function requiredInfo() {
            var num=0;

            if ($("#txtUserName").val() == null || $("#txtUserName").val() == "") {
                $("#messageName").show();
                num++;
            }
            else {
                $("#messageName").hide();
            }
            if ($("#txtEmail").val() == null || $("#txtEmail").val() == "" || (!fChkMail($("#txtEmail").val()))) {
                $("#messageEmail").show();
                num++;
            }
            else {
                $("#messageEmail").hide();
            }

            if (num > 0) {
                return false;
            }
            else {
                var temp = false;
                $("#message").hide();
                $("#messageEmail").hide();
                $("#messageName").hide();
                $.ajax({
                    url: "../Mutual/UserManage.ashx",
                    type: "post",
                    data: {
                        "Action": "CreateUser",
                        "txtUserName": $("#txtUserName").val(),
                        "UserType":GetQueryString("UserType"),
                        "txtEmail": $("#txtEmail").val(),
                    },
                    success: function (data) {
                        ShowMessag(data);
                        var type = $('#tyUserType').val()
                        if (data == "创建成功！") {
                            $(".layui-layer-btn0").click(function () {
                                temp = true;
                                if(type=="会员用户"){
                                    window.location = 'LeaguerChildUserList.aspx'
                                } else {
                                    window.location = 'UserList.aspx'
                                }
                               
                            });
                        }
                    }
                });
                return temp;
            }
        }
        function fChkMail(szMail) {
            var szReg = /^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(.[a-zA-Z0-9_-])+/;
            return szReg.test(szMail);
        }
    </script>
</asp:Content>