<%@ Page  Language="C#" AutoEventWireup="true"  MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="SpecialtySet.aspx.cs" Inherits="Evaluation.View.ActivityManage.SpecialtySet" %>

<%@ Register TagPrefix="uc" TagName="Schedule" Src="~/View/ActivityManage/Schedule.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Bootstrap-Iconpicker -->    
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/bootstrap-iconpicker/css/bootstrap-iconpicker.css" />
    <script src="../../Content/plugins/bootstrap-iconpicker/js/iconset/iconset-fontawesome-4.2.0.min.js"></script>
    <script type="text/javascript" src="../../Content/plugins/bootstrap-iconpicker/js/bootstrap-iconpicker.js"></script>  
    <style>
        .table.table-bordered.table-hover {
            width: auto;
        }

        #Content2 {
            font-family: "微软雅黑";
        }

        #Table select {
            display: none;
        }

        .row {
            margin-left: 0;
        }

        #lkbSetAtlas {
            margin-left: 5px;
            margin-right: 5px;
        }

        input[type="text"] {
            vertical-align: middle;
            border: none;
            height: 26px;
            border: 1px solid #ccc;
            line-height: 12px;
            width: 166px;
        }

            input[type="text"]:focus {
                border-color: #ccc;
                vertical-align: middle;
            }
            .ms-parent {
                width: 166px !important;
            }
        .container {
            padding: 0;
        }

        #ContentPlaceHolder1_txtSpecialtyName, #ContentPlaceHolder1_txtSpecialtyCode, #ContentPlaceHolder1_txtOrdinal, #txtIconPicker {
            height: 26px;
        }

        #target .caret {
            padding-right: 0px;
            margin-left: 0px !important;
            padding-bottom: 7px !important;
        }

        .iconpicker {
            min-width: 40px;
            height: 26px !important;
        }

        #ContentPlaceHolder1_txtSpecialtyName {
            margin-right: 30px;
        }

        #ContentPlaceHolder1_txtOrdinal {
            margin-right: 30px;
        }

        .bootstrap-switch.bootstrap-switch-mini .bootstrap-switch-handle-off {
            padding: 3px 5px;
            height: auto;
        }

        .bootstrap-switch.bootstrap-switch-mini .bootstrap-switch-handle-on {
            padding: 3px 5px;
            height: auto;
        }

        .bootstrap-switch.bootstrap-switch-mini .bootstrap-switch-label {
            padding: 3px 5px;
            height: auto;
        }

        a:hover {
            color: #fff;
            text-decoration: none;
            background-color: #62C1C9;
        }

        .ms-parent {
            margin-right: 15px;
        }

        select {
            width: 165px;
            margin-right: 30px;
            height: 26px;
            border: 1px solid #ccc;
        }
        .input-group.date .input-group-addon {
        cursor:default;
      }
        #ContentPlaceHolder1_lkbUpdate {
            margin-right: 10px;
            padding: 7px 16px;
        }
        .table tbody > tr > td.inpcheck{          
          padding:20px 0 15px 0!important;
        }
        /*选择图集*/
        h4 {
            font-family: "微软雅黑";
        }

        .modal-body label {
            font-weight: 400;
        }

        .modal-title {
            font-weight: 500;
        }

        .modal-header {
            padding: 10px 20px 10px 20px;
        }

        .modal-content {
            width: 308px;
        }

        .modal-body input {
            height: 26px;
        }

        #btnAddAtlas {
            width: 78px;
            padding: 0;
            margin-left: 20px;
        }

        .modal-footer .btnt {
            width:78px;
        }

        .bootstrap-table .table > thead > tr > th {
            vertical-align: middle;
        }

        .btn-lg {
            line-height: 0.33;
            border-radius: 6px;
        }

        #txtOrdinal {
            margin-right: 25px;
            height: 26px;
        }
        #ContentPlaceHolder1_lkbSetPrize{
            color:#333;
        }
        #ContentPlaceHolder1_lkbSetPrize:hover{
             background:transparent;
        }
        #divBtn {
            width: 200px;
            margin: 5px auto 0;
        }

        #lkbSetAtlas, #lkbSetAppendix {
            line-height: 23px;
        }

        .modal-header .close {
            margin-top: -3px !important;
        }

        ul.ui-choose > li.selected {
            background-color: #33B0BA;
            color: #fff;
            border-color: #33B0BA;
        }

        ul.ui-choose > li:hover {
            z-index: 4;
            border-color: #33B0BA;
        }

        .table.table-bordered.table-hover input {
            height: 28px !important;
            line-height: 28px;
        }

        fixed-table-toolbar .bs-bars, .fixed-table-toolbar .search, .fixed-table-toolbar .columns {
            line-height: 30px !important;
        }

        #ContentPlaceHolder1_gvPrize {
            border: 1px solid #ccc;
            width: 253px;
        }

        .table thead > tr > th, .table tbody > tr > th, .table tfoot > tr > th, .table thead > tr > td, .table tbody > tr > td {
            padding: 4px !important;
        }
        .fixed-table-container thead th .th-inner, .fixed-table-container tbody td .th-inner{
             padding: 4px !important;
        }
        #txtSpecialtyCode{
            margin-right:25px;
        }
        #inpcheck{
            height:26px!important;
        }
        #AtlasPart,#AppendixPart,#MediaPart,#divPrizeList,#divChild{
            margin-top:30px;
        }
        #Table.table-hover tbody tr:nth-child(1):hover > th {
            background-color: #85E1E1;
        }
        #AtlasPart,#AppendixPart,#MediaPart{
        display:none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <asp:HiddenField runat="server" ID="hfParentID" ClientIDMode="Static" />
    <asp:HiddenField runat="server" ID="hfSpecialID" ClientIDMode="Static" />

     <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">评优管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ActivityManage/SpecialtyList.aspx">专业管理</a>
             <span style="padding-left:5px;">&gt;</span>
        </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ActivityManage/SpecialtySet.aspx">专业详情</a>
        </li>
    </ul>
    <div class="container div" style="padding-bottom:150px;">
        <div class="row">
            <div class="col-sm-12">
                <div id="BasePart">
                    <div style="border: 1px solid #e1e1e1; padding: 15px; border-radius: 5px;">
                        <asp:Label ID="labSpecialtyName" runat="server" Text="专业名称 :" Style="font-weight: 600;"></asp:Label>&nbsp;
                        <asp:TextBox ID="txtSpecialtyName" ClientIDMode="Static" runat="server" Enabled="false"></asp:TextBox>
                        <span id="msSpecialtyName" class="Promptmessage" style="color: red;" hidden="hidden">*请输入专业名称</span>
                        <span style="padding-left:25px;">所属专业 :&nbsp;
                            <asp:DropDownList runat="server" ID="ddlParent" ClientIDMode="Static" OnSelectedIndexChanged="ddlParent_SelectedIndexChanged"></asp:DropDownList>
                            <asp:HiddenField ID="hfLevel" runat="server" />
                        </span>
                        <div style="margin:13px 0 15px 0">
                            <asp:TextBox ID="txtSpecialtyID" ClientIDMode="Static" runat="server"></asp:TextBox>
                             <asp:Label ID="labOrdinal" runat="server" Text="排列序号 :"></asp:Label>&nbsp;
                            <asp:TextBox ID="txtOrdinal" ClientIDMode="Static" runat="server" onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;"></asp:TextBox>                                                       
                            <asp:Label ID="Label1" runat="server" Text="专业图标 :"></asp:Label>&nbsp;

                            <!----iconPicker-->
                            <input id="txtIconPicker" runat="server"/>
                            <button class="btn btn-default" id="target" style="height: 30px;"></button>
                        </div>                   
                        <span>是否使用活动时间表： </span>  
                        <asp:DropDownList runat="server" ID="ddlIsInheritSchedule" ClientIDMode="Static">
                            <asp:ListItem Selected="False" Text="是" Value="True"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="否" Value="False"></asp:ListItem>
                        </asp:DropDownList>
                        &nbsp;&nbsp;&nbsp;
                        <span style="padding-left:23px;">提交后是否允许修改： </span>   
                        <asp:DropDownList runat="server" ID="ddlIsAllowUpdate" ClientIDMode="Static">
                            <asp:ListItem Selected="False" Text="是" Value="True"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="否" Value="False"></asp:ListItem>
                        </asp:DropDownList>
                        <span style="padding-left:23px;">必填项未填是否允许提交： </span>   
                        <asp:DropDownList runat="server" ID="ddlIsAllowSubmit" ClientIDMode="Static">
                            <asp:ListItem Selected="False" Text="是" Value="True"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="否" Value="False"></asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <br />
                        <span>收件封存时发送邮件： </span>   
                        <asp:DropDownList runat="server" ID="ddlIsSendReceivePost" ClientIDMode="Static">
                            <asp:ListItem Selected="False" Text="是" Value="1"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="否" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                            <span style="padding-left:41px;">驳回修改时发送邮件： </span>   
                        <asp:DropDownList runat="server" ID="ddlIsSendUpdatePost" ClientIDMode="Static">
                            <asp:ListItem Selected="False" Text="是" Value="1"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="否" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                            <div style="display:none">
                            <span style="padding-left:43px;">管理员删除时发送邮件： </span>   
                        <asp:DropDownList runat="server" ID="ddlIsSendDeletePost" ClientIDMode="Static">
                            <asp:ListItem Selected="False" Text="是" Value="1"></asp:ListItem>
                            <asp:ListItem Selected="True" Text="否" Value="0"></asp:ListItem>
                        </asp:DropDownList>
                                </div>
                        <asp:HiddenField runat="server" ID="hfSpecialtyLevel" ClientIDMode="Static" />
                        <br />   
                        <br/>                 
                        <div id="divBtn" style="display:block"> 
                            <asp:LinkButton ID="lkbCreate" runat="server" OnClientClick="return checked()" OnClick="lkbCreate_Click" class="btnt">
                                添  &nbsp; 加
                            </asp:LinkButton>&nbsp;&nbsp;
                            <asp:LinkButton ID="lkbUpdate" runat="server" ClientIDMode="Static" OnClick="lkbUpdate_Click" class="btnt">
                                保  &nbsp; 存
                            </asp:LinkButton>&nbsp;&nbsp;
                           <%-- <asp:LinkButton ID="lkbCancel" runat="server" ClientIDMode="Static" OnClientClick="onCancel();"  class="btnt">
                                返  &nbsp; 回
                            </asp:LinkButton>--%>
                            <a href="#" id="lkbCancel" class="btnt" onclick="onCancel()">返  &nbsp; 回</a>
                        </div>
                    </div>
                    <uc:Schedule runat="server" ID="ucSchedule" ClientIDMode="Static"></uc:Schedule>
                </div>

                <%--附件部分--%>
                <div id="AppendixPart">
                 <asp:Label ID="lblSpecialtyAppendix" runat="server" Text="附件列表：" Style="font-weight: 600;"></asp:Label>
                    <asp:TextBox ID="tbxSpecialtyAppendix" runat="server" Text="" Enabled="false" style="display:none;"></asp:TextBox>                 
                    <div id="toolbarAppendix" class="btn-group">
                        <button id="btn_addAppendix" type="button" class="btn btn-default" data-toggle="modal" data-target="#selectAppendix" onclick="AppendixAdd()">
                            <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增
                        </button>
                    </div>
                    <table id="tbAppendix"></table>
                </div>
                
                <%--图集部分--%>
                <div id="AtlasPart">
                   <asp:Label ID="lblSpecialtyAtlas" runat="server" Text="图集列表：" Style="font-weight:600;"></asp:Label>
                        <asp:TextBox ID="tbxSpecialtyAtlas" runat="server" Text="" Enabled="false" style="display:none;"></asp:TextBox>                 
                    <div id="toolbarAtlas" class="btn-group">
                        <button id="btn_addAtlas" type="button" class="btn btn-default" data-toggle="modal" data-target="#selectAtlas" onclick="AtlasAdd()">
                            <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增
                        </button>
                    </div>
                    <table id="tbAtlas"></table>
                </div>

                <%--视频部分--%>
                <div id="MediaPart">
                 <asp:Label ID="Label2" runat="server" Text="视频列表：" Style="font-weight: 600;"></asp:Label>
                    <asp:TextBox ID="tbxSpecialtyMedia" runat="server" Text="" Enabled="false" style="display:none;"></asp:TextBox>                 
                    <div id="toolbarMedia" class="btn-group">
                        <button id="btn_addMedia" type="button" class="btn btn-default" data-toggle="modal" data-target="#selectMedia" onclick="MediaAdd()">
                            <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增
                        </button>
                    </div>
                    <table id="tbMedia"></table>
                </div>

                <div id="divPrizeList">
                    <span style="font-weight:600">奖项列表：</span>
                    <div id="toolbarPrize" class="btn-group">                
                        <button id="btn_addPrize" type="button" class="btn btn-default" onclick="onAddPrize()">
                            <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增
                        </button>
                        <button id="btn_editPrize" type="button" class="btn btn-default" onclick="onEditPrize();">
                            <span class="fa fa-pencil" aria-hidden="true"></span>&nbsp;修改
                        </button>
                        <button id="btn_deletePrize" type="button" class="btn btn-default" onclick="onDelete()">
                            <span class="fa fa-trash" aria-hidden="true"></span>&nbsp;删除（批量）
                        </button>
                        <input id="lkbSetAtlas" runat="server" type="button" value="设置图集" class="btnt" clientidmode="Static" style="display:none;"/>
                        <input id="lkbSetAppendix" runat="server" type="button" value="设置附件" class="btnt" clientidmode="Static" style="display:none;"/>
                    </div>
                    <table id="tbPrizeList"></table>
                </div>

                <div id="divChild">
                    <span style="font-weight:600">子专业列表：</span>
                    <div id="toolbarChild" class="btn-group">                
                        <button id="btn_addChild" type="button" class="btn btn-default" onclick="onAddChild()">
                            <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增
                        </button>
                        <button id="btn_editChild" type="button" class="btn btn-default" onclick="onEditChild();">
                            <span class="fa fa-pencil" aria-hidden="true"></span>&nbsp;修改
                        </button>
                        <button id="btn_deleteChild" type="button" class="btn btn-default" onclick="onDeleteChild()">
                            <span class="fa fa-trash" aria-hidden="true"></span>&nbsp;删除（批量）
                        </button>
                    </div>
                    <table id="tbChildList"></table>
                </div>
            </div>
        </div>
    </div>

    <!-- 模态框（Modal） -->
    <div class="modal fade" id="selectAtlas" tabindex="-1" role="dialog" aria-labelledby="selectAtlasLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                    <h4 class="modal-title" id="selectAtlasLabel">图集</h4>
                </div>
                <div class="modal-body" style="padding: 25px 20px;">
                    <label>图集名称：</label><asp:HiddenField ID="hAtlasID" ClientIDMode="Static" runat="server" />
                    <asp:TextBox runat="server" ID="txtAtlasName" ClientIDMode="Static"></asp:TextBox>
                    <br />
                    <br />
                    <label>数量上限：</label>
                    <asp:TextBox runat="server" ID="txtUploadLimitMax" ClientIDMode="Static" value="0"
                         onkeypress="if (event.keyCode < 48 || event.keyCode >57) {event.returnValue = false;}"></asp:TextBox> (个)
                    <br />
                    <br />
                    <label>单张上限：</label>
                    <asp:TextBox runat="server" ID="txtSizeLimit" ClientIDMode="Static"  value="0"
                         onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;"></asp:TextBox> (兆)
                    <br />
                    <br />
                    <label>排 &nbsp; &nbsp; &nbsp; 序：</label>
                    <asp:TextBox runat="server" ID="txtAtlasOrdinal" ClientIDMode="Static"
                         onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;"></asp:TextBox>
                    <br />
                    <br />
                    <label>是否必需：</label>
                    <asp:DropDownList runat="server" ID="ddlAtlasIsRequired" ClientIDMode="Static">
                        <asp:ListItem Selected="False" Text="是" Value="True"></asp:ListItem>
                        <asp:ListItem Selected="True" Text="否" Value="False"></asp:ListItem>
                    </asp:DropDownList>
                    <br />

                </div>
                <div class="modal-footer" style="text-align:center;background-color:#fff;border:none;padding:0 0 15px 0">
                    <input type="button" id="btnAddAtlas" value="保&nbsp;&nbsp;存" class="btnt" style="margin-right:10px;"/>
                    <button type="button" id="modalAtlas" class="btnt btn-primary">返&nbsp;&nbsp;回</button>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="selectAppendix" tabindex="-1" role="dialog" aria-labelledby="selectAppendixLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                    <h4 class="modal-title" id="selectAppendixLabel">附件集</h4>
                </div>
                <div class="modal-body" style="padding:25px 20px;">
                    <label>附件名称：</label><asp:HiddenField ID="hAppendixID" ClientIDMode="Static" runat="server" />
                    <asp:TextBox runat="server" ID="txtAppendixName" ClientIDMode="Static"></asp:TextBox>
                    <br />
                    <br />
                    <label>容量上限：</label>
                    <asp:TextBox runat="server" ID="txtSizeLimit2" ClientIDMode="Static" value="0"
                         onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;"></asp:TextBox> (兆)
                    <br />
                    <br />
                    <label>排 &nbsp; &nbsp; &nbsp; 序：</label>
                    <asp:TextBox runat="server" ID="txtAppendixOrdinal" ClientIDMode="Static"
                         onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;"></asp:TextBox>                   
                    <br />
                    <br />
                    <label>是否必需：</label>
                    <asp:DropDownList runat="server" ID="ddlAppendixIsRequired" ClientIDMode="Static">
                        <asp:ListItem Selected="False" Text="是" Value="True"></asp:ListItem>
                        <asp:ListItem Selected="True" Text="否" Value="False"></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </div>
                <div class="modal-footer" style="text-align:center;background-color:#fff;border:none;padding:0 0 15px 0;">
                     <input type="button" id="btnAddAppendix" value="保&nbsp;&nbsp;存" class="btnt" style="margin-right:10px;"/>
                    <button type="button" id="modalAppendix" class="btnt btn-primary">返&nbsp;&nbsp;回</button>
                </div>
            </div>
        </div>
    </div>
    <div class="modal fade" id="selectMedia" tabindex="-1" role="dialog" aria-labelledby="selectMediaLabel" aria-hidden="true">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                    <h4 class="modal-title" id="selectMediaLabel">视频</h4>
                </div>
                <div class="modal-body" style="padding:25px 20px;">
                    <label>视频名称：</label><asp:HiddenField ID="hMediaID" ClientIDMode="Static" runat="server" />
                    <asp:TextBox runat="server" ID="txtMediaName" ClientIDMode="Static"></asp:TextBox>
                    <br />
                    <br />
                    <label>容量上限：</label>
                    <asp:TextBox runat="server" ID="txtMediaSizeLimit" ClientIDMode="Static" value="0"
                         onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;"></asp:TextBox> (兆)
                    <br />
                    <br />
                    <label>排 &nbsp; &nbsp; &nbsp; 序：</label>
                    <asp:TextBox runat="server" ID="txtMediaOrdinal" ClientIDMode="Static"
                         onkeypress="if (event.keyCode < 48 || event.keyCode >57) event.returnValue = false;"></asp:TextBox>                   
                    <br />
                    <br />
                    <label>是否必需：</label>
                    <asp:DropDownList runat="server" ID="ddlMediaIsRequired" ClientIDMode="Static">
                        <asp:ListItem Selected="False" Text="是" Value="True"></asp:ListItem>
                        <asp:ListItem Selected="True" Text="否" Value="False"></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </div>
                <div class="modal-footer" style="text-align:center;background-color:#fff;border:none;padding:0 0 15px 0;">
                     <input type="button" id="btnAddMedia" value="保&nbsp;&nbsp;存" class="btnt" style="margin-right:10px;"/>
                    <button type="button" id="modalMedia" class="btnt btn-primary">返&nbsp;&nbsp;回</button>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
       
        function getSelectedPrizeId() {
            return $.map($('#tbPrizeList').bootstrapTable('getSelections'), function (row) {
                return row.PrizeID
            });
        }
        function getChildListId() {
            return $.map($('#tbChildList').bootstrapTable('getSelections'), function (row) {
                return row.SpecialtyID
            });
        }
    
        function getSelectedAppendixRow() {
            return $.map($('#tbAppendix').bootstrapTable('getSelections'), function (row) {
                return row;
            });
        }

        function getSelectedAppendixID() {
            return $.map($('#tbAppendix').bootstrapTable('getSelections'), function (row) {
                return row.AppendixID;
            });
        }

        function getSelectedAtlasRow() {
            return $.map($('#tbAtlas').bootstrapTable('getSelections'), function (row) {
                return row;
            });
        }

        function onCancel() {
            var pathname = window.location.search;
            if (pathname.indexOf('?sid=') > -1) {
                window.location = "SpecialtyList.aspx"
            } else {
                history.go(-1);
            };
          
        }

        function onAddPrize() {
            window.location = "PrizeSet.aspx?SpecialID=" + $("#txtSpecialtyID").val();
        }    
        
        function onEditPrize() {
            var PrizeID = getSelectedPrizeId();
            window.location = "../ActivityManage/PrizeSet.aspx?PrizeID=" + PrizeID + ""
        }

        function setDatepicker(begin, end, func) {
            begin.datepicker({
                language: "zh-CN",
                format: "yyyy-mm-dd",
                autoclose: true,
                todayHighlight: true,
            }).on('changeDate', function (e) {
                var startTime = begin.val();
                end.datepicker(func, startTime);
            });
        }

        $(function () {
            hideBasePart()
            var pathname = window.location.search;

            if ($("#txtSpecialtyID").val() != "") {
                $('#AtlasPart,#AppendixPart,#MediaPart').css('display', 'block')
            }
            else {
                $("#divChild").hide();
                $("#divPrizeList").hide();
            }

            $("#ddlParent").multipleSelect({
                single: true,
            });

            $('#ddlIsInheritSchedule').ui_choose();
            $('#ddlIsAllowUpdate').ui_choose();
            $('#ddlIsAllowSubmit').ui_choose();
            $('#ddlIsSendReceivePost').ui_choose();
            $('#ddlIsSendUpdatePost').ui_choose();
            $('#ddlIsSendDeletePost').ui_choose();

            $('#ddlIsDeclarationStart').ui_choose();
            $('#ddlIsDeclarationAutoStart').ui_choose();
            $('#ddlIsDeclarationAutoEnd').ui_choose();

            $('#ddlIsPrimaryElectionStart').ui_choose();
            $('#ddlIsPrimaryElectionAutoStart').ui_choose();
            $('#ddlIsPrimaryElectionAutoEnd').ui_choose();

            $('#ddlIsExpertReviewStart').ui_choose();
            $('#ddlIsExpertReviewAutoStart').ui_choose();
            $('#ddlIsExpertReviewAutoEnd').ui_choose();

            $('#ddlIsDownloadStart').ui_choose();
            $('#ddlIsDownloadAutoStart').ui_choose();
            $('#ddlIsDownloadAutoEnd').ui_choose();

            $('#ddlIsVoteStart').ui_choose();
            $('#ddlIsVoteAutoStart').ui_choose();
            $('#ddlIsVoteAutoEnd').ui_choose();

            $('#ddlIsReVoteStart').ui_choose();

            $('#ddlAppendixIsRequired').ui_choose();
            $('#ddlAtlasIsRequired').ui_choose();
            $('#ddlMediaIsRequired').ui_choose();

            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
                if (msg == "添加成功!") {
                    $('.layui-layer-btn0').click(function () {
                        var pathname = window.location.search;
                        var pathnames = pathname.slice(5);
                        if (pathname.indexOf('pid=') > -1) {
                            window.location = "SpecialtySet.aspx?sid=" + pathnames + "#divChild";
                        } else {
                            window.location = "SpecialtyList.aspx"
                        };
                    });
                } else if (msg == "修改成功!") {
                    $('.layui-layer-btn0').click(function () {
                        var pathname = window.location.search;
                        if (pathname.indexOf('show=child') > -1) {
                            history.go(-2);
                        }
                    });
                }
            };

            $('#target').iconpicker({
                align: 'center', // Only in div tag
                arrowClass: 'btn-danger',
                arrowPrevIconClass: 'fa fa-arrow-left',
                arrowNextIconClass: 'fa fa-arrow-right',
                cols: 5,
                footer: true,
                header: true,
                //icon: 'fa fa-star',
                iconset: 'fontawesome',
                labelHeader: '{0} / {1} 页',
                labelFooter: '{0} - {1} / 共{2}个',
                placement: 'bottom', // Only in button tag
                rows: 5,
                search: false,
                selectedClass: 'btn-success',
                unselectedClass: ''
            });

            $('#target').on('change', function (e) {
                $("#ContentPlaceHolder1_txtIconPicker").val(e.icon);
            });

            //$('#txtDeclarationBeginDate,#txtExpertReviewBeginDate,#txtDownloadBeginDate,#txtDeclarationEndDate,#txtPrimaryElectionEndDate,#txtExpertReviewEndDate,#txtDownloadEndDate,#txtVoteBeginDate,#txtVoteEndDate').css('cursor', 'pointer').datepicker({
            //    language: "zh-CN",
            //    format: "yyyy-mm-dd",
            //    autoclose: true,
            //    todayHighlight: true,
            //});

            $.ajax({
                url: "../Mutual/ActivityManage.ashx",
                type: "post",
                data: { "Action": "GetScheduleData" },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data);
                    }
                    if (Row.DeclarationBeginDate != null) {
                        $('#txtDeclarationBeginDate').datepicker('setStartDate', Row.DeclarationBeginDate.substring(0, 10));
                    }
                    if (Row.ExpertReviewBeginDate != null) {
                        $('#txtExpertReviewBeginDate').datepicker('setStartDate', Row.ExpertReviewBeginDate.substring(0, 10));
                    }
                    if (Row.DownloadBeginDate != null) {
                        $('#txtDownloadBeginDate').datepicker('setStartDate', Row.DownloadBeginDate.substring(0, 10));
                    }              
                    if(Row.VoteBeginDate!=null){
                         $('#txtVoteBeginDate').datepicker('setStartDate', Row.VoteBeginDate.substring(0, 10));
                    }
                    $('#txtDeclarationEndDate').datepicker('setStartDate', $('#txtDeclarationBeginDate').val());
                    $('#txtExpertReviewEndDate').datepicker('setStartDate', $('#txtExpertReviewBeginDate').val());
                    $('#txtDownloadEndDate').datepicker('setStartDate', $('#txtDownloadBeginDate').val());
                    $('#txtVoteEndDate').datepicker('setStartDate', $('#txtVoteBeginDate').val());
                    if (Row.DeclarationEndDate != null) {
                        $('#txtDeclarationEndDate').datepicker('setEndDate', Row.DeclarationEndDate.substring(0, 10));
                    }
                    if (Row.ExpertReviewEndDate != null) {
                        $('#txtExpertReviewEndDate').datepicker('setEndDate', Row.ExpertReviewEndDate.substring(0, 10));
                    }
                    if (Row.DownloadEndDate != null) {
                        $('#txtDownloadEndDate').datepicker('setEndDate', Row.DownloadEndDate.substring(0, 10));
                    }                  
                    if(Row.VoteEndDate!=null){
                     $('#txtVoteEndDate').datepicker('setEndDate', Row.VoteEndDate.substring(0, 10));
                    }                 
                }
            });

            //开始时间： 
            setDatepicker($('#txtDeclarationBeginDate'), $('#txtDeclarationEndDate'), 'setStartDate');
            setDatepicker($('#txtExpertReviewBeginDate'), $('#txtExpertReviewEndDate'), 'setStartDate');
            setDatepicker($('#txtDownloadBeginDate'), $('#txtDownloadEndDate'), 'setStartDate');
            setDatepicker($('#txtVoteBeginDate'), $('#txtVoteEndDate'), 'setStartDate');

            //结束时间： 
            setDatepicker($('#txtDeclarationEndDate'), $('#txtDeclarationBeginDate'), 'setEndDate');
            setDatepicker($('#txtExpertReviewEndDate'), $('#txtExpertReviewBeginDate'), 'setEndDate');
            setDatepicker($('#txtDownloadEndDate'), $('#txtDownloadBeginDate'), 'setEndDate');
            setDatepicker($('#txtVoteEndDate'), $('#txtVoteBeginDate'), 'setEndDate');

            $("#txtSpecialtyID").hide();

            $('#selectAtlas').modal({
                backdrop: 'static',
                keyboard: false,
                show: false
            });

            if ($("#txtSpecialtyID").val() != "") {
                InitTableAtlas();
                InitTableAppendix();
                InitTableMedia();
                InitChildList();
                InittbPrizeList();
            }

            //返回基础信息部分
            $(".backToBase").click(function () {
                $("#BasePart").show();
                $("#AtlasPart").hide();
                $("#AppendixPart").hide();
                $("#MediaPart").hide();
                $("#divBtn").show();
            });

            $("#txtIconPicker").attr("disabled", "disabled");

            notBackspace();//禁用Backspace键盘键

            if ($("#txtSpecialtyID").val() == "") {
                $('#btn_addAppendix').prop('disabled', "true");
                $('#btn_addMedia').prop('disabled', "true");
                $('#btn_addAtlas').prop('disabled', "true");
                $('#btn_addPrize').prop('disabled', "true");
                $('#btn_addChild').prop('disabled', "true");
            }

            $("#btnAddAtlas").click(function () {
                if ($("#txtAtlasName").val() == null || $("#txtAtlasName").val() == "") {
                    ShowMessag("请输入图集名称!");
                }
                else if (isNaN($("#txtUploadLimitMax").val()) || $("#txtUploadLimitMax").val() == "") {
                    ShowMessag("数量上限必须为正整数!");
                }
                else if (isNaN($("#txtSizeLimit").val()) || $("#txtSizeLimit").val() == "") {
                    ShowMessag("容量上限必须为正整数!");
                }
                else if ($("#txtAtlasOrdinal").val() == null || $("#txtAtlasOrdinal").val() == "") {
                    $("#txtAtlasOrdinal").val("1000000");
                }
                else {
                    $.ajax({
                        url: "../Mutual/ActivityManage.ashx",
                        type: "post",
                        data: {
                            "Action": "CreateAtlas",
                            "txtSpecialtyID": $("#txtSpecialtyID").val(),
                            "txtAtlasName": $("#txtAtlasName").val(),
                            "txtUploadLimitMax": $("#txtUploadLimitMax").val(),
                            "txtUploadLimitMin": $("#txtUploadLimitMin").val(),
                            "txtSizeLimit": $("#txtSizeLimit").val(),
                            "txtAtlasOrdinal": $("#txtAtlasOrdinal").val(),
                            "IsRequired": $("#ddlAtlasIsRequired").val(),
                            "txtAtlasID": $("#hAtlasID").val()
                        },
                        success: function (data) {
                            ShowMessag(data);
                            InitTableAtlas();
                            $(".close").click();
                        }
                    });
                }
            });

            $("#btnAddAppendix").click(function () {
                if ($("#txtAppendixName").val() == null || $("#txtAppendixName").val() == "") {
                    ShowMessag("请输入附件集名称!");
                }
                else if (isNaN($("#txtSizeLimit2").val()) || $("#txtSizeLimit2").val() == "") {
                    ShowMessag("容量上限必须为正整数!");
                }
                else if ($("#txtAppendixOrdinal").val() == null || $("#txtAppendixOrdinal").val() == "") {
                    $("#txtAppendixOrdinal").val("1000000");
                }
                else {
                    $.ajax({
                        url: "../Mutual/ActivityManage.ashx",
                        type: "post",
                        data: {
                            "Action": "CreateAppendix",
                            "SpecialtyID": $("#txtSpecialtyID").val(),
                            "AppendixName": $("#txtAppendixName").val(),
                            "SizeLimit": $("#txtSizeLimit2").val(),
                            "AppendixOrdinal": $("#txtAppendixOrdinal").val(),
                            "IsRequired": $("#ddlAppendixIsRequired").val(),
                            "AppendixID": $("#hAppendixID").val()
                        },
                        success: function (data) {
                            ShowMessag(data);
                            InitTableAppendix();
                            $(".close").click();
                        }
                    });
                }
            });

            $("#btnAddMedia").click(function () {
                if ($("#txtMediaName").val() == null || $("#txtMediaName").val() == "") {
                    ShowMessag("请输入视频名称!");
                }
                else if (isNaN($("#txtMediaSizeLimit").val()) || $("#txtMediaSizeLimit").val() == "") {
                    ShowMessag("容量上限必须为正整数!");
                }
                else if ($("#txtMediaOrdinal").val() == null || $("#txtMediaOrdinal").val() == "") {
                    $("#txtMediaOrdinal").val("1000000");
                }
                else {
                    $.ajax({
                        url: "../Mutual/ActivityManage.ashx",
                        type: "post",
                        data: {
                            "Action": "CreateMedia",
                            "SpecialtyID": $("#txtSpecialtyID").val(),
                            "MediaName": $("#txtMediaName").val(),
                            "SizeLimit": $("#txtMediaSizeLimit").val(),
                            "MediaOrdinal": $("#txtMediaOrdinal").val(),
                            "IsRequired": $("#ddlMediaIsRequired").val(),
                            "MediaID": $("#hMediaID").val()
                        },
                        success: function (data) {
                            ShowMessag(data);
                            InitTableMedia();
                            $(".close").click();
                        }
                    })
                }
            });

            $("#modalAtlas").click(function () {
                $(".close").click();
            });

            $("#modalAppendix").click(function () {
                $(".close").click();
            });

            $("#modalMedia").click(function () {
                $(".close").click();
            });

            $("#ddlParent").change(function () {
                var strParentID = $("#ddlParent").val();
                //当父专业不等于0时;
                if (strParentID != "0") {
                    //启动
                    if ($('.IsInheritTemplet').val() == "1") {
                        $.ajax({
                            url: "../Mutual/ActivityManage.ashx",
                            type: "post",
                            data: {
                                "Action": "SpecialtyTemplete",
                                "SpecialtyID": strParentID
                            },
                            success: function (data) {
                                $("#ddlTemplate").val(data);
                            }
                        });
                    }
                }
                else {
                    if ($('.IsInheritTemplet').val() == "1") {
                        $('.IsInheritTemplet').click();
                    }
                    //禁用
                    $('.IsInheritTemplet').bootstrapSwitch('disabled', true);
                }

                //选择父专业时，默认的排序序号
                $.ajax({
                    url: "../Mutual/ActivityManage.ashx",
                    type: "post",
                    data: {
                        "Action": "SpecialtySetCount",
                        "ParentId": strParentID,
                    },
                    success: function (data) {
                        $("#txtOrdinal").val(data);
                    }
                });

                //选择专业时，默认的专业编码
                $.ajax({
                    url: "../Mutual/ActivityManage.ashx",
                    type: "post",
                    data: {
                        "Action": "GetSpecialtyCode",
                        "ParentId": strParentID,
                    },
                    success: function (data) {
                        $("#txtSpecialtyCode").val(data);
                    }
                });
            });
        });

        function notBackspace(){ 
            var keyCode,target; document.onkeydown = keydown; function keydown(e)
            { e = e || window.event; keyCode = e.keyCode || 
            e.which, target = e.srcElement || e.target; 
                //只有当前对象为text、textarea、password并且只是可读状态时才禁用返回键 
                if ( keyCode === 8 && ( target.type === "text" || target.type === "textarea" || 
                target.type === "password" ) && target.readOnly === true )
                { keyCode = 0; e.returnValue = false; return false; } }
        }

        function getIdSelections() {
            return $.map($('#tbAtlas').bootstrapTable('getSelections'), function (row) {
                return row.AtlasName
            });
        }

        function operateFormatterAtlas(value, row, index) {
            return [
                '<a class="edit" href="javascript:void(0)" title="编辑" data-toggle="modal" data-target="#selectAtlas">',
               '<i class="fa fa-edit"></i>',
               '</a>  ',
                '<a class="remove" href="javascript:void(0)" title="删除">',
                '<i class="fa  fa-trash"></i>',
                '</a>',
            ].join('');
        }

        function operateFormatterAppendix(value, row, index) {
            return [
                '<a class="edit" href="javascript:void(0)" title="编辑" data-toggle="modal" data-target="#selectAppendix">',
                '<i class="fa fa-edit"></i>',
                '</a>  ',
                '<a class="remove" href="javascript:void(0)" title="删除">',
                '<i class="fa  fa-trash"></i>',
                '</a>',
            ].join('');
        }

        function operateFormatterMedia(value, row, index) {
            return [
                '<a class="edit" href="javascript:void(0)" title="编辑" data-toggle="modal" data-target="#selectMedia">',
                '<i class="fa fa-edit"></i>',
                '</a>  ',
                '<a class="remove" href="javascript:void(0)" title="删除">',
                '<i class="fa  fa-trash"></i>',
                '</a>',
            ].join('');
        }

        function AtlasAdd() {
            $("#txtAtlasName").val("");
            $("#txtUploadLimitMax").val("");
            $("#txtUploadLimitMin").val("");
            $("#txtSizeLimit").val("");
            $("#txtAtlasOrdinal").val("");
            $('#ddlAtlasIsRequired').val("False");
            $("#ddlAtlasIsRequired").next().find('li').removeClass('selected');
            $("#ddlAtlasIsRequired").next().find('li[data-value=' + $("#ddlAtlasIsRequired").val() + ']').attr('class', 'selected');
            $("#hAtlasID").val("");
        }

        function AppendixAdd() {
            $("#hAppendixID").val("");
            $("#txtAppendixName").val("");
            $("#txtSizeLimit2").val("");
            $("#txtAppendixOrdinal").val("");
            $('#ddlAppendixIsRequired').val("False");
            $("#ddlAppendixIsRequired").next().find('li').removeClass('selected');
            $("#ddlAppendixIsRequired").next().find('li[data-value=' + $("#ddlAppendixIsRequired").val() + ']').attr('class', 'selected');
            $("#hAppendixID").val("");
        }

        function MediaAdd() {
            $("#hMediaID").val("");
            $("#txtMediaName").val("");
            $("#txtMediaSizeLimit").val("");
            $("#txtMediaOrdinal").val("");
            $('#ddlMediaIsRequired').val("False");
            $("#ddlMediaIsRequired").next().find('li').removeClass('selected');
            $("#ddlMediaIsRequired").next().find('li[data-value=' + $("#ddlMediaIsRequired").val() + ']').attr('class', 'selected');
            $("#hMediaID").val("");
        }

        function onDelete() {
            ShowMessags('确定删除吗?');
            $(".layui-layer-btn0").click(function () {
                var PrizeID = getSelectedPrizeId();
                PrizeID = PrizeID.join(',');
                $.ajax({
                    url: '../Mutual/ActivityManage.ashx',
                    type: 'post',
                    data: {
                        "Action": "MultiselectDelPrize",
                        "PrizeID": PrizeID,
                        "DelSpecialtyID": $("#txtSpecialtyID").val()
                    },
                    success: function (data) {
                        ShowMessag(data);
                        InittbPrizeList();
                    }
                });
            });
        }
      
        function InitTableAtlas() {
            $("#tbAtlas").bootstrapTable('destroy');
            $.ajax({
                url: "../Mutual/ActivityManage.ashx",
                type: "post",
                data: {
                    "Action": "GetAtlasList",
                    "SpecialtyID": $("#txtSpecialtyID").val()
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbarAtlas',
                            striped: true,
                            editable: false,      //是否显示行间隔色
                            showColumns: false,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            clickToSelect: true,
                            uniqueId: "AtlasID",
                            //singleSelect: true,
                            columns: [
                                { checkbox: true },
                                {
                                    field: 'Ordinal', title: '序号', align: 'center', Valign: 'middle', editable: {
                                        type: 'text',
                                        title: '序号',
                                        validate: function (v) {
                                            if (isNaN(v)) {
                                                return '请输入数字';
                                            }
                                            if (!v) return '不能为空';
                                        }
                                    }
                                },
                                {
                                    field: 'AtlasName', title: '图集名称', align: 'center', Valign: 'middle'
                                },
                                {
                                    field: 'UploadLimitMax', title: '图片数量上限(个)', align: 'center', Valign: 'middle', editable: {
                                        type: 'text',
                                        title: '图片数量上限(个)',
                                        validate: function (v) {
                                            if (isNaN(v)) {
                                                return '请输入数字';
                                            }
                                            if (!v) return '不能为空';
                                        }
                                    }
                                },
                                {
                                    field: 'SizeLimit', title: '图片大小限制(兆)', align: 'center', Valign: 'middle', editable: {
                                        type: 'text',
                                        title: '图片大小限制(兆)',
                                        validate: function (v) {
                                            if (isNaN(v)) {
                                                return '请输入数字';
                                            }
                                            if (!v) return '不能为空';
                                        }
                                    }
                                },
                                {
                                    field: 'IsRequired', title: '是否必需', align: 'center', Valign: 'middle', formatter: function (value, row, index) {
                                        return row.IsRequired ? "是" : "否";
                                    }
                                },
                                {
                                    title: '操作', align: 'center', valign: 'middle', events: {
                                        'click .edit': function (e, value, row, index) {
                                            $.ajax({
                                                url: "../Mutual/ActivityManage.ashx",
                                                type: "post",
                                                data: {
                                                    "Action": "GetAtlasByAtlasID",
                                                    "upAtlasID": row.AtlasID
                                                },
                                                success: function (data) {
                                                    var Row = JSON.parse(data);
                                                    $("#txtSpecialtyID").val(Row.SpecialtyID);
                                                    $("#txtAtlasName").val(Row.AtlasName);
                                                    $("#txtUploadLimitMax").val(Row.UploadLimitMax);
                                                    $("#txtUploadLimitMin").val(Row.UploadLimitMin);
                                                    $("#txtSizeLimit").val(Row.SizeLimit);
                                                    $("#txtAtlasOrdinal").val(Row.Ordinal);
                                                    $("#ddlAtlasIsRequired").val(Row.IsRequired ? "True" : "False");
                                                    $("#ddlAtlasIsRequired").next().find('li').removeClass('selected');
                                                    $("#ddlAtlasIsRequired").next().find('li[data-value=' + $("#ddlAtlasIsRequired").val() + ']').attr('class', 'selected');
                                                    $("#hAtlasID").val(row.AtlasID);
                                                }
                                            });
                                        },
                                        'click .remove': function (e, value, row, index) {
                                            ShowMessags("是否确认删除？");
                                            $('.layui-layer-btn0').on('click', function () {
                                                $.ajax({
                                                    url: "../Mutual/ActivityManage.ashx",
                                                    type: "post",
                                                    data: {
                                                        "Action": "DelAtlas",
                                                        "AtlasID": row.AtlasID,
                                                        "DelSpecialtyID": $("#txtSpecialtyID").val()
                                                    },
                                                    success: function (data) {
                                                        ShowMessag(data);
                                                        InitTableAtlas();
                                                    }
                                                });
                                            });
                                        }
                                    },
                                    formatter: operateFormatterAtlas
                                }
                            ],
                            onEditableSave: function (field, row, oldValue, $el) {
                                $.ajax({
                                    type: "post",
                                    url: "../Mutual/ActivityManage.ashx",
                                    data: {
                                        "Action": "UpdateAtlas",
                                        "Ordinal": row.Ordinal,
                                        "AtlasID": row.AtlasID,
                                        "AtlasName": row.AtlasName,
                                        "UploadLimitMax": row.UploadLimitMax,
                                        "UploadLimitMin": row.UploadLimitMin,
                                        "IsRequired": row.IsRequired,
                                        "SizeLimit": row.SizeLimit
                                    },
                                    success: function (data, status) {
                                        ShowMessag(data);
                                        InitTableAtlas();
                                    }
                                });
                            }
                        };
                        option.data = Row;
                        $("#tbAtlas").bootstrapTable(option);
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbAtlas'));
                    }
                }
            });

            $('#btn_deleteAtlas').prop('disabled', "true");
            $('#btn_editAtlas').prop('disabled', "true");

            $('#tbAtlas').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_deleteAtlas').prop('disabled', !$('#tbAtlas').bootstrapTable('getSelections').length);
                $('#btn_editAtlas').prop('disabled', !($('#tbAtlas').bootstrapTable('getSelections').length == 1));
            });
        }

        function InitTableAppendix() {
            $("#tbAppendix").bootstrapTable('destroy');
            $.ajax({
                url: "../Mutual/ActivityManage.ashx",
                type: "post",
                data: {
                    "Action": "GetAppendixList",
                    "SpecialtyID": $("#txtSpecialtyID").val()
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbarAppendix',
                            editable: false,
                            striped: true,                            //是否显示行间隔色
                            showColumns: false,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            clickToSelect: true,
                            uniqueId: "AppendixID",
                            //singleSelect: true,
                            columns: [
                                { checkbox: true },
                                {
                                    field: 'Ordinal', title: '序号', align: 'center', Valign: 'middle', editable: {
                                        type: 'text',
                                        title: '序号',
                                        validate: function (v) {
                                            if (isNaN(v)) {
                                                return '请输入数字';
                                            }
                                            if (!v) return '不能为空';
                                        }
                                    }
                                },
                                {
                                    field: 'AppendixName', title: '附件集名称', align: 'center', Valign: 'middle'
                                },
                                {
                                    field: 'SizeLimit', title: '附件大小限制(兆)', align: 'center', Valign: 'middle', editable: {
                                        type: 'text',
                                        title: '附件大小限制(兆)',
                                        validate: function (v) {
                                            if (isNaN(v)) {
                                                return '请输入数字';
                                            }
                                            if (!v) return '不能为空';
                                        }
                                    }
                                },
                                {
                                    field: 'IsRequired', title: '是否必需', align: 'center', Valign: 'middle'
                                    , formatter: function (value, row, index) {
                                        return row.IsRequired ? "是" : "否";
                                    }
                                },
                                {
                                    title: '操作', align: 'center', valign: 'middle', events: {
                                        'click .edit': function (e, value, row, index) {
                                            $.ajax({
                                                url: "../Mutual/ActivityManage.ashx",
                                                type: "post",
                                                data: {
                                                    "Action": "GetAppendixByAppendixID",
                                                    "upAppendixID": row.AppendixID
                                                },
                                                success: function (data) {
                                                    var Row = JSON.parse(data);
                                                    $("#hAppendixID").val(row.AppendixID);
                                                    $("#txtAppendixName").val(Row.AppendixName);
                                                    $("#txtSizeLimit2").val(Row.SizeLimit);
                                                    $("#txtAppendixOrdinal").val(Row.Ordinal);
                                                    $("#txtSpecialtyID").val(Row.SpecialtyID);
                                                    $("#ddlAppendixIsRequired").val(Row.IsRequired ? "True" : "False");
                                                    $("#ddlAppendixIsRequired").next().find('li').removeClass('selected');
                                                    $("#ddlAppendixIsRequired").next().find('li[data-value=' + $("#ddlAppendixIsRequired").val() + ']').attr('class', 'selected');
                                                }
                                            });
                                        },
                                        'click .remove': function (e, value, row, index) {
                                            ShowMessags("是否确认删除？");
                                            $('.layui-layer-btn0').on('click', function () {
                                                $.ajax({
                                                    url: "../Mutual/ActivityManage.ashx",
                                                    type: "post",
                                                    data: {
                                                        "Action": "DelAppendix",
                                                        "AppendixID": row.AppendixID,
                                                        "DelSpecialtyID": $("#txtSpecialtyID").val()
                                                    },
                                                    success: function (data) {
                                                        ShowMessag(data);
                                                        InitTableAppendix();
                                                    }
                                                });
                                            });
                                        }
                                    },
                                    formatter: operateFormatterAppendix
                                }
                            ],
                            onEditableSave: function (field, row, oldValue, $el) {
                                $.ajax({
                                    type: "post",
                                    url: "../Mutual/ActivityManage.ashx",
                                    data: {
                                        "Action": "UpdateAppendix",
                                        "Ordinal": row.Ordinal,
                                        "AppendixID": row.AppendixID,
                                        "AppendixName": row.AppendixName,
                                        "UploadLimitMax": row.UploadLimitMax,
                                        "UploadLimitMin": row.UploadLimitMin,
                                        "SizeLimit": row.SizeLimit,
                                        "IsRequired": row.IsRequired
                                    },
                                    success: function (data, status) {
                                        ShowMessag(data);
                                        InitTableAppendix();
                                    }
                                });
                            }
                        };
                        option.data = Row;
                        $("#tbAppendix").bootstrapTable(option);
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbAppendix'));
                    }
                }
            });

            $('#btn_deleteAppendix').prop('disabled', "true");
            $('#btn_editAppendix').prop('disabled', "true");

            $('#tbAppendix').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_deleteAppendix').prop('disabled', !$('#tbAppendix').bootstrapTable('getSelections').length);
                $('#btn_editAppendix').prop('disabled', !($('#tbAppendix').bootstrapTable('getSelections').length == 1));
            });
        }

        function InitTableMedia() {
            $("#tbMedia").bootstrapTable('destroy');
            $.ajax({
                url: "../Mutual/ActivityManage.ashx",
                type: "post",
                data: {
                    "Action": "GetMediaList",
                    "SpecialtyID": $("#txtSpecialtyID").val()
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbarMedia',
                            editable: false,
                            striped: true,                            //是否显示行间隔色
                            showColumns: false,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            clickToSelect: true,
                            uniqueId: "MediaID",
                            columns: [
                                { checkbox: true },
                                {
                                    field: 'Ordinal', title: '序号', align: 'center', Valign: 'middle', editable: {
                                        type: 'text',
                                        title: '序号',
                                        validate: function (v) {
                                            if (isNaN(v)) {
                                                return '请输入数字';
                                            }
                                            if (!v) return '不能为空';
                                        }
                                    }
                                },
                                {
                                    field: 'MediaName', title: '视频名称', align: 'center', Valign: 'middle'
                                },
                                {
                                    field: 'SizeLimit', title: '视频大小限制(兆)', align: 'center', Valign: 'middle', editable: {
                                        type: 'text',
                                        title: '视频大小限制(兆)',
                                        validate: function (v) {
                                            if (isNaN(v)) {
                                                return '请输入数字';
                                            }
                                            if (!v) return '不能为空';
                                        }
                                    }
                                },
                                {
                                    field: 'IsRequired', title: '是否必需', align: 'center', Valign: 'middle', formatter: function (value, row, index) {
                                        return row.IsRequired ? "是" : "否";
                                    }
                                },
                                {
                                    title: '操作', align: 'center', valign: 'middle', events: {
                                        'click .edit': function (e, value, row, index) {
                                            $.ajax({
                                                url: "../Mutual/ActivityManage.ashx",
                                                type: "post",
                                                data: { "Action": "GetMediaByMediaID", "upMediaID": row.MediaID },
                                                success: function (data) {
                                                    var Row = JSON.parse(data);
                                                    $("#hMediaID").val(Row.MediaID);
                                                    $("#txtMediaName").val(Row.MediaName);
                                                    $("#txtMediaSizeLimit").val(Row.SizeLimit);
                                                    $("#txtMediaOrdinal").val(Row.Ordinal);
                                                    $("#txtSpecialtyID").val(Row.SpecialtyID);
                                                    $("#ddlMediaIsRequired").val(Row.IsRequired ? "True" : "False");
                                                    $("#ddlMediaIsRequired").next().find('li').removeClass('selected');
                                                    $("#ddlMediaIsRequired").next().find('li[data-value=' + $("#ddlMediaIsRequired").val() + ']').attr('class', 'selected');
                                                }
                                            });
                                        },
                                        'click .remove': function (e, value, row, index) {
                                            ShowMessags("是否确认删除？");
                                            $('.layui-layer-btn0').on('click', function () {
                                                $.ajax({
                                                    url: "../Mutual/ActivityManage.ashx",
                                                    type: "post",
                                                    data: {
                                                        "Action": "DelMedia", "MediaID": row.MediaID,
                                                        "DelSpecialtyID": $("#txtSpecialtyID").val()
                                                    },
                                                    success: function (data) {
                                                        ShowMessag(data);
                                                        InitTableMedia();
                                                    }
                                                });
                                            });
                                        }
                                    },
                                    formatter: operateFormatterMedia
                                }
                            ]
                        };
                        option.data = Row;
                        $("#tbMedia").bootstrapTable(option);
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbMedia'));
                    }
                }
            });

            $('#btn_deleteMedia').prop('disabled', "true");
            $('#btn_editMedia').prop('disabled', "true");

            $('#tbMedia').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_deleteMedia').prop('disabled', !$('#tbMedia').bootstrapTable('getSelections').length);
                $('#btn_editMedia').prop('disabled', !($('#tbMedia').bootstrapTable('getSelections').length == 1));
            });
        }

        function InittbPrizeList() {
            $("#tbPrizeList").bootstrapTable('destroy');
            window.operateEvents = {
                'click .edit': function (e, value, row, index) {
                    window.location = "../ActivityManage/PrizeSet.aspx?PrizeID=" + row.PrizeID;
                },
                'click .remove': function (e, value, row, index) {
                    ShowMessags('确定要删除吗?')
                    $(".layui-layer-btn0").click(function () {
                        $.ajax({
                            url: "../Mutual/ActivityManage.ashx",
                            type: "post",
                            data: { "Action": "DelPrize", "PrizeID": row.PrizeID, "DelSpecialtyID": $("#txtSpecialtyID").val() },
                            success: function (data) {
                                $("body").attr("class", "breakpoint-1200");
                                $(".modal-backdrop").remove();
                                if (data == "success") {
                                    $('#tbPrizeList').bootstrapTable('remove', {
                                        field: 'PrizeID',
                                        values: [row.PrizeID]
                                    });
                                    InittbPrizeList();
                                    if ($("#tbPrizeList").bootstrapTable('getData').length == 0) {
                                        $("#divChild").show();
                                    }
                                } else {
                                    ShowMessag(data);
                                }
                            }
                        });
                    });
                }
            };

            $.ajax({
                url: "../Mutual/ActivityManage.ashx",
                type: "post",
                data: {
                    "Action": "GetPrizeList",
                    "Specialtys": $("#txtSpecialtyID").val()
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbarPrize',
                            striped: true,                      //是否显示行间隔色
                            showColumns: false,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            clickToSelect: true,
                            uniqueId: "PrizeID",
                            //checkbox: "true",
                            queryParams: "",//传递参数（*）
                            columns: [
                                { checkbox: true },
                                { field: 'Ordinal', title: '序号', align: 'center', Valign: 'middle' },
                                { field: 'PrizeName', title: '奖项名称', align: 'center', Valign: 'middle' },
                                { field: 'SpecialtyName', title: '专业', align: 'center', Valign: 'middle' },
                                { field: 'PrizeType', title: '奖项类别', align: 'center', Valign: 'middle' },
                                { field: 'VoteTypeText', title: '投票方式', align: 'center', Valign: 'middle' },
                                { field: 'FirstPrize', title: '一等奖数量', align: 'center', Valign: 'middle' },
                                { field: 'SecondPrize', title: '二等奖数量', align: 'center', Valign: 'middle' },
                                { field: 'ThirdPrize', title: '三等奖数量', align: 'center', Valign: 'middle' },
                                { field: 'AwardCount', title: '获奖项目数量', align: 'center', Valign: 'middle' },
                                { field: 'ParticipantLimit', title: '项目人员数量', align: 'center', Valign: 'middle' },
                                {
                                    title: '操作', align: 'center', Valign: 'middle', events: operateEvents, formatter: function (value, row, index) {
                                        return [
                                            '<a class="edit" href="javascript:void(0)" title="编辑">',
                                            '<i class="fa fa-edit"></i>',
                                            '</a>  ',
                                            '<a class="remove" href="javascript:void(0)" title="删除">',
                                            '<i class="fa  fa-trash"></i>',
                                            '</a>',
                                        ].join('');
                                    }
                                }
                            ]
                        };
                        option.data = Row.Table;
                        $("#tbPrizeList").bootstrapTable(option);


                        if (Row.Table.length > 0) {
                            $("#divChild").hide();
                        }
                        else {
                            $("#divChild").show();
                        }
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbPrizeList'));
                    }
                }
            });

            $('#btn_deletePrize').prop('disabled', "true");
            $('#btn_editPrize').prop('disabled', "true");

            $('#tbPrizeList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_deletePrize').prop('disabled', !$('#tbPrizeList').bootstrapTable('getSelections').length);
                $('#btn_editPrize').prop('disabled', !($('#tbPrizeList').bootstrapTable('getSelections').length == 1));
            });
        }

        function onAddChild() {         
            window.location = "../ActivityManage/SpecialtySet.aspx?pid=" + $("#txtSpecialtyID").val();
        }

        function onEditChild() {
            var SpecialtyID = getChildListId();
            window.location = "../ActivityManage/SpecialtySet.aspx?sid=" + SpecialtyID;
        }

        function onDeleteChild() {
            ShowMessags('确定删除吗?');
            $(".layui-layer-btn0").click(function () {
                var vSpecialtyIDs = getChildListId();
                vSpecialtyIDs = vSpecialtyIDs.join(',');
                $.ajax({
                    url: "../Mutual/ActivityManage.ashx",
                    type: "post",
                    data: {
                        "Action": "BatchDelSpecialty",
                        "SpecialtyIDs": vSpecialtyIDs
                    },
                    success: function (data) {
                        $("body").attr("class", "breakpoint-1200");
                        ShowMessag(data);
                        InitChildList();
                        $(".modal-backdrop").remove();
                    }
                });
            });
        }

        function InitChildList() {
            $("#tbChildList").bootstrapTable('destroy');
            $.ajax({
                url: "../Mutual/ActivityManage.ashx",
                type: "post",
                data: {
                    "Action": "GetChildSpecialtyList",
                    "SpecialtyID": $("#txtSpecialtyID").val()
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbarChild',
                            striped: true,                      //是否显示行间隔色
                            showColumns: false,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            clickToSelect: true,
                            uniqueId: "SpecialtyID",
                            queryParams: "",//传递参数（*）
                            columns: [
                                { checkbox: true },
                                { field: 'Ordinal', title: '序号', align: 'center', Valign: 'middle' },
                                { field: 'SpecialtyName', title: '专业名称', align: 'center', Valign: 'middle' },
                                {
                                    field: 'SpecialtyIcon', title: '专业图标', align: 'center', valign: 'middle'
                                    , formatter: function (value, row, index) {
                                        return ['<i class="fa ' + row.SpecialtyIcon + '"></i>'].join('');
                                    }
                                },
                                { field: 'ParentName', title: '父专业', align: 'center', Valign: 'middle' },
                                { field: 'SpecialtyLevel', title: '专业级别', align: 'center', valign: 'middle' },
                                { field: 'ChildCount', title: '子专业数', align: 'center', Valign: 'middle' },
                                { field: 'PrizeCount', title: '奖项数', align: 'center', Valign: 'middle' },
                                {
                                    title: '操作', align: 'center', Valign: 'middle',
                                    formatter: function (value, row, index) {
                                        return [
                                            '<a class="edit" href="javascript:void(0)" title="编辑">',
                                            '<i class="fa fa-edit"></i>',
                                            '</a>  ',
                                            '<a class="remove" href="javascript:void(0)" title="删除">',
                                            '<i class="fa  fa-trash"></i>',
                                            '</a>',
                                        ].join('');
                                    },
                                    events: {
                                        'click .edit': function (e, value, row, index) {
                                            window.location = "../ActivityManage/SpecialtySet.aspx?sid=" + row.SpecialtyID + "&show=child" + "&specialtyLevel=" + row.SpecialtyLevel;
                                        },
                                        'click .remove': function (e, value, row, index) {
                                            if (row.ChildCount > 0) {
                                                ShowMessags('删除专业将同时删除专业的所有子专业，确定要一起删除吗? ');
                                            }
                                            else {
                                                ShowMessags('确定要删除吗?');
                                            }

                                            $(".layui-layer-btn0").click(function () {
                                                $.ajax({
                                                    url: "../Common/ActivityManage.ashx",
                                                    type: "post",
                                                    data: {
                                                        "Action": "DelSpecialty",
                                                        "SpecialtyID": row.SpecialtyID,
                                                        "DelSpecialtyID": $("#txtSpecialtyID").val()
                                                    },
                                                    success: function (data) {
                                                        $("body").attr("class", "breakpoint-1200");
                                                        ShowMessag(data)
                                                        InitChildList();
                                                        if ($("#tbPrizeList").bootstrapTable('getData').length == 0) {
                                                            $("#divChild").show();
                                                        }
                                                        $(".modal-backdrop").remove();
                                                        //if (data == "success") {
                                                        //    $('#tbChildList').bootstrapTable('remove', { field: 'SpecialtyID', values: [row.SpecialtyID] });
                                                        //    InitChildList();
                                                        //} else {
                                                        //    ShowMessag(data)
                                                        //}
                                                    }
                                                });
                                            });
                                        }
                                    }
                                }
                            ]
                        };
                        option.data = Row;
                        $("#tbChildList").bootstrapTable(option);

                        if (Row.length > 0) {
                            $("#divPrizeList").hide();
                        }
                        else {
                            $("#divPrizeList").show();
                        }
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbChildList'));
                    }
                }
            });

            $('#btn_deleteChild').prop('disabled', "true");
            $('#btn_editChild').prop('disabled', "true");
            $('#btn_addChild').prop('disabled', $('#hfSpecialtyLevel').val() == "三级");          
            $('#tbChildList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_deleteChild').prop('disabled', !$('#tbChildList').bootstrapTable('getSelections').length);
                $('#btn_editChild').prop('disabled', !($('#tbChildList').bootstrapTable('getSelections').length == 1));
            });
        }

        //分会用户隐藏BasePart
        function hideBasePart(){
             var userType = $('#tyUserType').val();
            // console.log("userType=="+userType)
             if (userType == "分会用户") {
                $("#BasePart").hide();
                $("#AppendixPart").css("margin-top","0px");
             }
        }

        function checked() {        
            if ($("#txtSpecialtyName").val() == null || $("#txtSpecialtyName").val() == "") {
                $("#msSpecialtyName").show();
                return false;
            } else {
                $("#msSpecialtyName").hide();
                return true;
            }
        }

    </script>

 </asp:Content>