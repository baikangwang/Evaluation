<%@ Page Title="会员用户" Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="LeaguerUser.aspx.cs" Inherits="Evaluation.View.UserManage.LeaguerUser" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        table tr td {
            padding: 5px 0 12px 5px;
            text-align: right;
        }
        
        .btn:hover, .ui-state-default:hover, .ui-widget-content .ui-state-default:hover, .ui-widget-header .ui-state-default:hover, .ColVis_MasterButton:hover, .fc-state-default:hover, .btn:focus, .ui-state-default:focus, .ui-widget-content .ui-state-default:focus, .ui-widget-header .ui-state-default:focus, .ColVis_MasterButton:focus, .fc-state-default:focus {
            color: #fff !important;
            background-color: #62C1C9 !important;
            border-color: rgba(0,0,0,0.13);
        }
        #IDType {
            padding: 0px;
            margin: 0px;
        }

        .input {
            width: 100%;
        }

        #Btn_EditUser {
            width: 100%;
        }

        .font_red {
            color: red;
        }

        input[type="text"] {
            width:250px;
            height:25px;
            border: none;
            border: 1px solid #ccc;
            background: #fff; 
            padding:0 4px!important;   
        }
        input[type="password"]{
            width:250px;
            height:25px;
            border: none;
            border: 1px solid #ccc;
            background: #fff;   
        }

        .btn {
            width: 105px;
            border-radius:4px;
            background: #33B0BA;
            color: #fff;
            border: none;    
            font-size: 13px;
            margin:20px auto;
            display:block
            
        }
        .div{
            margin:15px auto; width:425px;border:1px solid #e1e1e1;border-radius:3px;padding:15px 18px 0px 10px;
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
          <a href="../UserManage/LeaguerUserList.aspx">会员用户</a>
        </li>        
    </ul>
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <div  class='div'>
        <table>
            <tr>
                <td>单位名称：</td>
                <td>
                    <asp:HiddenField runat="server" ClientIDMode="Static" ID="txtOrganizationID" />
                    <asp:TextBox ID="txtOrganizationName" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                    <span id="msOrganizationName" class="Promptmessage" style="color:red;" hidden="hidden">*必填</span>
                </td>
            </tr>
           <%-- <tr>
                <td colspan="2" class="Promptmessage">
                  
                </td>
            </tr>--%>
            <%--<tr>
                <td>统一社会信用代码：</td>
                <td>
                    <asp:TextBox ID="txtUnifiedCode" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>                            
                    <span id="msUnifiedCodeOrOrCode1" class="Promptmessage" style="color:red;" hidden="hidden">*格式不正确</span>
                </td> 
            </tr>--%>            
            <tr>
                <td>组织机构代码证：</td>
                <td>
                    <asp:TextBox ID="txtOrganizationCode" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                       <span id="msUnifiedCodeOrOrCode" class="Promptmessage" style="color:red;" hidden="hidden">*必填</span>
                </td>
            </tr>
            <tr>
                <td>登录账号：</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                    <span id="msUserName" class="Promptmessage" style="color:red;" hidden="hidden">*必填</span>
                </td>
            </tr>
            <%--<tr>
                <td>单位简称：</td>
                <td>
                    <asp:TextBox ID="txtAbbreviation" runat="server" CssClass="input"></asp:TextBox></td>
            </tr>--%>
            <tr>
                <td>单位地址：</td>
                <td>
                    <asp:TextBox ID="txtOrganizationAddress" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                    <span id="msOrganizationAddress" class="Promptmessage" style="color:red;" hidden="hidden">*必填</span>
                </td>
            </tr>
            <tr>
                <td>法人姓名：</td>
                <td>
                    <asp:TextBox ID="txtLegalPersonName" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                    <span id="msLegalPersonName" class="Promptmessage" style="color:red;" hidden="hidden">*必填</span>
                </td>
            </tr>
            <tr>
                <td>法人身份证号：</td>
                <td>
                    <asp:TextBox ID="txtLegalPersonIDNo" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                    <span id="msLegalPersonIDNo" class="Promptmessage" style="color:red;" hidden="hidden">*请输入18位身份证号</span>
                </td>
            </tr>
            <tr>
                <td>申报联系人：</td>
                <td>
                    <asp:TextBox ID="txtLinkman" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                    <span id="msLinkman" class="Promptmessage" style="color:red;" hidden="hidden">*必填</span>
                </td>
            </tr>
            <tr>
                <td>电话：</td>
                <td>
                    <asp:TextBox ID="txtTelephoneNumber" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                    <span id="msTelephoneNumber" class="Promptmessage" style="color:red;" hidden="hidden">*请输入电话号码</span>
                </td>
            </tr>
            <tr>
                <td>手机：</td>
                <td>
                    <asp:TextBox ID="txtMobileNumber" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                    <span id="msMobileNumber" class="Promptmessage" style="color:red;" hidden="hidden">*请输入手机号码</span>
                </td>
            </tr>
            <tr>
                <td>邮箱：</td>
                <td>
                    <asp:TextBox ID="txtEmailAddress" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                    <span id="msEmailAddress" class="Promptmessage" style="color:red;" hidden="hidden">*邮箱格式不正确</span>
                </td>
            </tr>
            <%--<tr>
                <td>密码：</td>
                <td>
                    <asp:TextBox ID="txtPassWord" runat="server" CssClass="input" TextMode="Password" ClientIDMode="Static"></asp:TextBox>
                </td>
            </tr>--%>
            <tr hidden="hidden">
                <td colspan="2" class="Promptmessage">
                    <span id="msPassWord" class="Promptmessage" style="color:red;" hidden="hidden">*密码</span>
                </td>
            </tr>
            <tr>
                <td>邮政编码：</td>
                <td>
                    <asp:TextBox ID="txtPostcode" runat="server" CssClass="input"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>传真：</td>
                <td>
                    <asp:TextBox ID="txtFaxNumber" runat="server" CssClass="input"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" >
                    <div style="margin:5px auto -10px;width:190px;">
                    <asp:Button ID="btnEditUser" class="btn" runat="server" Text="保&nbsp;&nbsp;&nbsp;&nbsp;存" OnClientClick="return requiredInfo()" OnClick="btnEditUser_click" Width="78px" Height="25px" Style="display: inline-block;line-height: 25px;padding: 0;margin-right:10px;"/>
                    <asp:Button ID="btnCreateUser" class="btn" runat="server" Text="添&nbsp;&nbsp;&nbsp;&nbsp;加" OnClientClick="return requiredInfo()" OnClick="btnCreateUser_click" Width="78px" Height="25px" Style="display: inline-block;line-height: 25px;padding: 0;margin-right:10px;"/>
                    <asp:Button ID="btnCancel" CssClass="btn" runat="server"  Text="返&nbsp;&nbsp;&nbsp;&nbsp;回" OnClick="btnCancel_Click" Width="78px" Height="25px" Style="display: inline-block;line-height: 25px;padding: 0;"/></div>
                </td>
            </tr>
        </table>
    </div>
<script type="text/javascript">
    $(function () {
        var msg = $("#hdMsg").val();
        if (msg != "") {
            ShowMessag(msg);
            if (msg == "添加成功!" || msg == "修改成功!") {
                $(".layui-layer-btn0").click(function () {
                    window.location = "LeaguerUserList.aspx";
                });
            }
        }
    });

    function requiredInfo() {    
        $('.input').closest("td").css('text-align', 'left');
        var num = 0;
        if ($("#txtOrganizationName").val() == null || $("#txtOrganizationName").val() == "") {
            $('.div').css('width', '565px');
            $("#msOrganizationName").show();
            num++;
        } else {
            $("#msOrganizationName").hide();
        }

        if (($("#txtOrganizationCode").val() == null || $("#txtOrganizationCode").val() == "")) {
            $('.div').css('width', '565px');
            $("#msUnifiedCodeOrOrCode").show();         
            num++;
        } else {
            $("#msUnifiedCodeOrOrCode").hide();          
        }

        //if ($("#txtOrganizationAddress").val() == null || $("#txtOrganizationAddress").val() == "") {
        //    $('.div').css('width', '565px');
        //    $("#msOrganizationAddress").show();
        //    num++;
        //} else {
        //    $("#msOrganizationAddress").hide();
        //}

        //if ($("#txtLegalPersonName").val() == null || $("#txtLegalPersonName").val() == "") {
        //    $('.div').css('width', '565px');
        //    $("#msLegalPersonName").show();
        //    num++;
        //} else {
        //    $("#msLegalPersonName").hide();
        //}

        //if ($("#txtLegalPersonIDNo").val() == null || $("#txtLegalPersonIDNo").val() == "" || $("#txtLegalPersonIDNo").val().length != 18) {
        //    $('.div').css('width', '565px');
        //    $("#msLegalPersonIDNo").show();
        //    num++;
        //} else {
        //    $("#msLegalPersonIDNo").hide();
        //}

        //if ($("#txtLinkman").val() == null || $("#txtLinkman").val() == "") {
        //    $('.div').css('width', '565px');
        //    $("#msLinkman").show();
        //    num++;
        //} else {
        //    $("#msLinkman").hide();
        //}

        //if ($("#txtTelephoneNumber").val() == null || $("#txtTelephoneNumber").val() == "") {
        //    $('.div').css('width', '565px');
        //    $("#msTelephoneNumber").show();
        //    num++;
        //} else {
        //    $("#msTelephoneNumber").hide();
        //}
        //if ($("#txtMobileNumber").val() == null || $("#txtMobileNumber").val() == "") {
        //    $('.div').css('width', '565px');
        //    $("#msMobileNumber").show();
        //    num++;
        //} else {
        //    $("#msMobileNumber").hide();
        //}

        //if ($("#txtEmailAddress").val() == null || $("#txtEmailAddress").val() == "" || (!fChkMail($("#txtEmailAddress").val()))) {
        //    $('.div').css('width', '565px');
        //    $("#msEmailAddress").show();
        //    num++;
        //} else {
        //    $("#msEmailAddress").hide();
        //}

        if ($("#txtUserName").val() == null || $("#txtUserName").val() == "") {
            $('.div').css('width', '565px');
            $("#msUserName").show();
            num++;
        } else {
            $("#msUserName").hide();
        }

        if (num > 0) {
            return false;
        } else {
            return true;
        }
       
    }
    function fChkMail(szMail) {
        var szReg = /^([a-zA-Z0-9_-])+@([a-zA-Z0-9_-])+(.[a-zA-Z0-9_-])+/;
        return szReg.test(szMail);
    }
    function fCode(code) {
        var szReg = /[^_IOZSVa-z\W]{2}\d{6}[^_IOZSVa-z\W]{10}/g;
        return szReg.test(code);
    }
</script>
</asp:Content>
