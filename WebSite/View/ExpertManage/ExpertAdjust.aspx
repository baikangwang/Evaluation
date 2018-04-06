<%@ Page Title="专业调整" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ExpertAdjust.aspx.cs" Inherits="Evaluation.View.ExpertManage.ExpertAdjust" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-size: 14px;
            font-family: "微软雅黑";
        }

        .div {
            margin-top: 18px;
        }
        .button-primary, .button-primary-flat{
            width:78px;
            height:25px;
            line-height:25px;
            padding:0;
            background-color:#33B0BA !important;
            border:none

        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">评优管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#">专业调整</a>
        </li>        
    </ul>
    <div class="container div">
        <div class="row">
            <div class="col-sm-12">
                <%--<h3>用户详情:专家</h3>--%>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <asp:Button ID="btnImport" runat="server" Text="导入" CssClass="btn btn-primary btn-3d button-primary button-rounded" OnClick="btnImport_Click" />
                <asp:Button ID="Button1" runat="server" Text="添加" CssClass="btn btn-primary btn-3d button-primary button-rounded" />
                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            </div>
        </div>
    </div>
<script type="text/javascript">
    $(function () {
        var msg = $("#hdMsg").val();
        if (msg != "")
        {
            ShowMessag(msg);
        }
    })
</script>
</asp:Content>
