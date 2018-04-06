<%@ Page Title="专家用户" MasterPageFile="~/View/Mutual/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ExpertUser.aspx.cs" Inherits="Evaluation.View.UserManage.ExpertUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-size: 14px;
            font-family: "微软雅黑";
        }

        table tr td {
            padding: 6px 0px 10px 6px;
            text-align: right;
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

        input[type="text"] {
            height: 26px;
            width: 250px;
            border: none;
            border: 1px solid #ccc;
            background: #fff;
            line-height:20px;
            padding:0 5px!important;
        }

        input[type="password"] {
            border: none;
            border: 1px solid #ccc;
            height: 26px;
            width: 250px;
        }

        .btn {
            width: 78px;
            border-radius: 4px;
            background: #33B0BA;
            color: #fff;
            border: none;
            padding: 0;
            height: 26px;
            font-size: 13px;
            margin-top: 20px;
        }

            .div .btn:hover, .btn:focus {
                background-color: #33B0BA !important;
                color: #fff !important;
            }

        .Promptmessage {
            text-align: left;
            padding: 0 0 0 82px;
        }

        #ContentPlaceHolder1_btnCancel {
            margin-right: 23%;
            margin-left: 10px;
        }

        #rbtnIDType td {
            padding: 0 0 0 6px;
        }

        label {
            font-weight: 400 !important;
        }
       .ms-parent {
            width: 250px !important;
       }
       #content{
           padding-bottom:180px!important;
       }
       .ms-drop.bottom ul{
           text-align:left;
       }
       #listSpecialty option{
           padding-left:5px;
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">评优管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ExpertManage/ExpertList.aspx">专家管理</a>
        </li>        
    </ul>
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <asp:HiddenField ID="checkeds" runat="server" ClientIDMode="Static" />
    <div style="width:370px; margin:15px auto; border:1px solid #E1E1E1; border-radius:5px;padding: 15px 20px 0 15px;">
        <table class="div"> 
            <tr>
                <td>姓名：</td>
                <td>
                    <asp:TextBox ID="txtExpertName" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="Promptmessage">
                    <span id="msExpertName"  style="color:red;" hidden="hidden">*请输入专家姓名</span>
                </td>
            </tr>
            <tr runat="server" id="trGender">
                <td>性别：</td>
                <td style="text-align:left;">
                    <asp:DropDownList runat="server" ID="ddlGender" ClientIDMode="Static" CssClass="dropdown">
                        <asp:ListItem Text="男" Value="男" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="女" Value="女" ></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>登录账号：</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server" CssClass="input" Text="自动生成" ClientIDMode="Static" Enabled="false"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="Promptmessage">
                    <span id="msUserName"  style="color:red;" hidden="hidden">*请输入登录账号</span>
                </td>
            </tr>
            <tr>
                <td>职称：</td>
                <td>
                    <asp:TextBox ID="txtAcademicTitle" runat="server" CssClass="input"></asp:TextBox></td>
            </tr>
            <tr>
                <td>研究方向：</td>
                <td>
                    <asp:TextBox ID="txtProfession" runat="server" CssClass="input"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>单位：</td>
                <td>
                    <asp:TextBox ID="txtWorkplace" runat="server" CssClass="input"></asp:TextBox></td>
            </tr>
            <tr>
                <td>证件类型：</td>
                <td>
                    <asp:RadioButtonList RepeatDirection="Horizontal" ID="rbtnIDType" runat="server"  ClientIDMode="Static">
                        <asp:ListItem Value="0901" Selected="True">身份证</asp:ListItem>
                        <asp:ListItem Value="0902">军官证</asp:ListItem>
                        <asp:ListItem Value="0903">护照</asp:ListItem>
                    </asp:RadioButtonList>
                    <span id="msIDType" class="Promptmessage" style="color:red;" hidden="hidden">*请输入证件类型</span>
                </td>
            </tr>
            <tr>
                <td>证件号码：</td>
                <td>
                    <asp:TextBox ID="txtIDNumber" runat="server" CssClass="input"  ClientIDMode="Static"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td colspan="2" class="Promptmessage">
                    <span id="msIDNumber"  style="color:red;" hidden="hidden">*请输入证件号码</span>
                      <span id="msIDNumberh"  style="color:red;" hidden="hidden">*格式不正确</span>
                    <span id="msIDNumbert"  style="color:red;" hidden="hidden">*身份证号码必须是18位</span>
                </td>
            </tr>
            <tr>
                <td>邮箱：</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="input"  ClientIDMode="Static" placeholder="请输入有效的邮箱"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2"  class="Promptmessage">
                    <span id="msEmail" style="color:red;" hidden="hidden">*请输入邮箱,不能以 - _ .以及其它特殊字符开头和结束,域名结尾为2~5个字母，比如cn、com</span>
                    <span id="Confirmpassword" style="color:red;"hidden="hidden">密码不一致，请重新输入</span>
                </td>
            </tr>
            <tr>
                <td>专业：</td>
                <td>
                    <asp:DropDownList runat="server" ID="ddlSpecialty" ClientIDMode="Static" Style="width:165px;height:30px;"></asp:DropDownList>
                    <asp:ListBox runat="server" ID="listSpecialty" ClientIDMode="Static" Style="width:249px;display:none;border-color:#ddd;" Enabled="false" ></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td colspan="2"  class="Promptmessage">
                </td>
            </tr>
            <%--<tr>
                <td>密码：</td>
                <td>
                    <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>密码确认：</td>
                <td><asp:TextBox ID="txtConfirmpassword" TextMode="Password" runat="server" CssClass="input" ClientIDMode="Static"></asp:TextBox>
                </td>
            </tr>--%>
            <tr >
                <td colspan="2" >
                    <asp:Button ID="btnCreateUser" class="btn" runat="server" Text="添&nbsp;&nbsp;&nbsp;&nbsp;加" OnClientClick="return requiredInfo()"  OnClick="btnCreateUser_Click" />
                    <asp:Button ID="btnEditUser" class="btn" runat="server" Text="保&nbsp;&nbsp;&nbsp;&nbsp;存" OnClientClick="return requiredInfo()" OnClick="btnEditUser_Click" />
                    <asp:Button ID="btnCancel" class="btn" runat="server" Text="返&nbsp;&nbsp;&nbsp;&nbsp;回" OnClick="btnCancel_Click" />
                   
                 </td>
            </tr>
            <tr>
                <td colspan="2">
                </td>
            </tr>
        </table>
    </div>
<script>
    $(function () {      
        $('#listSpecialty').attr('size',$('#listSpecialty option').length)
        $('#ddlGender').ui_choose();       
        var pathname = window.location.search;
        if (pathname != "") {
            $('.ui-choose').off("click");
            $('.ui-choose li').css('cursor', 'not-allowed');
        }

        if ($("#ddlSpecialty").length > 0) {
            $("#ddlSpecialty").multipleSelect({
                selectAllText: '全选',
                allSelected: '全部选中',
            });
        }
        else {
            $("#listSpecialty").show();
        }

        var tem = $("#checkeds").val().split(",");
        $("#ddlSpecialty").multipleSelect('setSelects', tem);

        $("#ddlSpecialty").change(function () {
            $("#checkeds").val($('#ddlSpecialty').multipleSelect("getSelects"));
        });

        $('.div >tbody> tr > td:nth-child(1)').css({ 'width': '27%' });

        var msg = $("#hdMsg").val();
        if (msg != "") {
            ShowMessag(msg);
            if (msg == "添加成功!" || msg == "修改成功!" || msg == "用户信息不存在或用户异常!") {
                $(".layui-layer-btn0").click(function () {
                    window.location = "../../view/ExpertManage/ExpertList.aspx";
                });
            }
        }
    });

    function requiredInfo() {
        var num = 0;
        if ($("#txtExpertName").val() == null || $("#txtExpertName").val() == "") {
            $("#msExpertName").show();
            num++;
        } else {
            $("#msExpertName").hide();

        }
       
        var varvalue;
        var vRbtid = document.getElementById("rbtnIDType");
        var vRbtidList = vRbtid.getElementsByTagName("INPUT");
        for (var i = 0; i < vRbtidList.length; i++) {
            if (vRbtidList[i].checked) {
                varvalue = vRbtidList[i].value;
            }
        }
        if (varvalue == null || varvalue == "") {
            $("#msIDType").show();
            num++;
        }
        else {
            $("#msIDType").hide();
        }
        if ($("#txtIDNumber").val() == null || $("#txtIDNumber").val() == "") {
            $("#msIDNumber").show();
            num++;
        }
        else {
            $("#msIDNumber").hide();
        }
        if (varvalue == "0901" && $("#txtIDNumber").val().length != 18 && $("#txtIDNumber").val().length >0) {
            $("#msIDNumbert").show();
            $("#msIDNumber").hide();
            num++;
        } else {
            $("#msIDNumbert").hide();
        }

        //if (varvalue == "0902" && (!IDNumberj($("#txtIDNumber").val()))) {
        //    $("#msIDNumberh").show();
        //    $("#msIDNumber").hide();
        //    num++;
        //} else {
        //    $("#msIDNumbert").hide();
        //    $("#msIDNumberh").hide();
         
        //}

        //if (varvalue == "0903" && (!IDNumberh($("#txtIDNumber").val()))) {
        //    $("#msIDNumberh").hide();
        //    $("#msIDNumber").hide();
        //    num++;
        //} else {
        //    $("#msIDNumbert").hide();
        //    $("#msIDNumberh").show();
        //}
        if ($("#txtEmail").val() == null || $("#txtEmail").val() == "" || (!fChkMail($("#txtEmail").val()))) {
            $("#msEmail").show();
            num++;
        } else {
            $("#msEmail").hide();

        }

        if (num > 0) {
            return false;
        } else {
            return true;
        }
      
    }

    function fChkMail(szMail) {
        var szReg = /^(\w)+(\.\w+)*@(\w)+((\.\w+)+)$/;
        return szReg.test(szMail);
    }
    function IDNumberj(szMail) {
        var szReg =/^\d{8}$/;
        return szReg.test(szMail);
    }
    function IDNumberh(szMail) {
        var szReg = /^[a-zA-Z0-9]{3,21}$/;
        return szReg.test(szMail);
    }
</script>
</asp:Content>
