﻿<%@ Page Title="项目管理" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="AdminDeclarationList.aspx.cs" Inherits="Evaluation.View.Declaration.AdminDeclarationList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>

    <!--UEditor-->
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>


    <link href="../../Content/plugins/ui-choose/src/ui-choose.css" rel="stylesheet" />
    <script src="../../Content/plugins/ui-choose/src/ui-choose.js"></script>
    <style>
        .table-bordered > thead > tr > th, .table-bordered > thead > tr > td {
            border-bottom: solid 3px #FFF;
        }
        
        .bottom > tbody > tr > td {
            border-left: dashed 1px #EFEFEF;
        }

        .table-bordered {
            border-bottom: solid 3px #CFCFCF;
            border-top: solid 3px #CFCFCF;
        }

        .professional {
            height: 30px;
        }

        .select input[type="text"] {
            border: none;
            border: 1px solid #ccc;
            margin-right: 15px;
            line-height: 20px;
        }

        #txtDeclarationBeginDate, #txtDeclarationEndDate, #txtEditBeginDate, #txtEditEndDate {
            margin-left: 0px !important;
        }

        .select select {
            margin-right: 15px;
        }

        .input-group i {
            padding: 0 4px;
            margin-left: 0 !important;
        }

        .DeclarationList {
            border: 1px solid #e1e1e1;
            padding: 10px 10px 8px 10px;
            border-radius: 5px;
        }

            .DeclarationList input {
                height: 26px;
                line-height: 20px;
            }

        .input-group-addon {
            padding: 3px 3px;
        }

        .editable-container.editable-popup {
            margin-left: 3%;
        }

        .popover.top .arrow {
            left: 37%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <div style="display: none;">
        <asp:TextBox ID="txtLastUpdateTime" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>
    <div style="display: none;">
        <asp:TextBox ID="txtUserType" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>
    <div style="display: none;">
        <asp:TextBox ID="txtUser" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="column1">项目管理</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a id="column2" href="../Declaration/AdminDeclarationList.aspx">项目管理</a>
        </li>
    </ul>
    <div class="DeclarationList" style="margin-bottom: 30px;">
        <div class="select">
            <span>项目名称：
                <asp:TextBox ID="txtDeclarationName" ClientIDMode="Static" runat="server" Width="168px" placeholder="项目名称"></asp:TextBox>
            </span>
            <span id="VIP">申报单位：
                <asp:TextBox runat="server" ID="txtDeclarationUnit" ClientIDMode="Static" Style="width: 168px; height: 25px;"></asp:TextBox>
            </span>
            <span style="margin: 0 15px;">
                申报奖项：
			    <asp:DropDownList ID="ddlPrizeName" runat="server" ClientIDMode="Static" Style="width: 168px; height: 25px;"></asp:DropDownList>
            </span>
            <span>
                申报状态：
                <asp:DropDownList ID="ddlDeclarationStatus" runat="server" ClientIDMode="Static" Style="width: 168px; height: 25px; margin-left: 0px;"></asp:DropDownList>
            </span>
        </div>
        <div style="overflow: hidden;">
            <div style="float: left; margin: 12px 24px 0 0px">
                <div class="input-group">
                    <span style="float: left; padding-top: 8px;">填报日期：</span>
                    <table style="float: left">
                        <tr>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="txtDeclarationBeginDate" ClientIDMode="Static" runat="server" class="form-control" placeholder="请选择开始日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                            </td>
                            <td>
                                <span>&nbsp;至&nbsp;</span>
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="txtDeclarationEndDate" ClientIDMode="Static" runat="server" class="form-control" placeholder="请选择结束日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
            <div style="float: left; margin: 12px 0 0 0px">
                <div class="input-group">
                    <span style="float: left; padding-top: 8px;">修改日期：</span>
                    <table style="float: left">
                        <tr>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="txtEditBeginDate" ClientIDMode="Static" runat="server" class="form-control" placeholder="请选择开始日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                            </td>
                            <td>
                                <span>&nbsp;至&nbsp;</span>
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="txtEditEndDate" ClientIDMode="Static" runat="server" class="form-control" placeholder="请选择结束日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </div>

    <span class="inquire" style="margin-left: 50%; position: absolute; left: 50px;">
        <input type="button" value="查 &nbsp;&nbsp; 询" class="btnt" onclick="onSearch();" />
    </span>
    <br />
    <%--项目评价相关--%>
    <div id="Evaluate" style="width: 70%; height: 480px; border: 1px solid black; background: white; margin: auto; z-index: 3; left: 20%; bottom: 15%; position: fixed; display: none; z-index: 99; top: 70px;">
        <h3 style="margin: 15px auto 0 auto; width: 150px;">项目评价</h3>
        <div style="position: absolute; right: 10px; top: 3px;"><a style="color: red; font-size: 24px; cursor: pointer" onclick="CancelEvaluate();return false;">×</a> </div>
        <table style="width: 80%; margin: auto; border-spacing: 7px; border-collapse: separate;">
            <tr>
                <td>
                    <asp:TextBox ID="DeclarationComment" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 80%; height: 300px;margin-left: 60px; margin-top: 30px;"></asp:TextBox>
                    <script id="DeclarationCommentTextBox" type="text/plain" style="height: 300px;"></script>
                </td>
            </tr>
        </table>
        <div style="width: 240px; margin: 30px auto;">            
            <input type="button" value="取 &nbsp; 消" class="btnt" style="width: 78px;" onclick="CancelEvaluate(); return false;" />
        </div>
    </div>
    <div>
        <div id="toolbar" class="btn-group">
            <button id="btn_deleteAdmin" type="button" class="btn btn-default" onclick="onAdminDelete()">
                <span class="fa fa-trash-o" aria-hidden="true"></span>&nbsp;管理员删除（批量）
            </button>
            <button id="btn_exportOpinion" type="button" class="btn btn-default" onclick="onExportOpinion()">
                <span class="fa fa-share-square-o" aria-hidden="true"></span>&nbsp;导出评审意见
            </button>
            <button id="btn_ExportRecommendOpinion" type="button" class="btn btn-default" onclick="onExportRecommendOpinion()">
                <span class="fa fa-share-square-o" aria-hidden="true"></span>&nbsp;导出推荐意见表（批量）
            </button>
            <button id="btn_export" type="button" class="btn btn-default" onclick="onExport()">
                <span class="fa fa-download" aria-hidden="true"></span>&nbsp;导出（批量）
            </button>
            <button id="btn_exportall" type="button" class="btn btn-default" onclick="onExportAll()">
                <span class="fa fa-share-square-o" aria-hidden="true"></span>&nbsp;全部导出（批量）
            </button>
        </div>       
        <table id="tbList" data-reorderable-columns="true"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px; margin-bottom: 127px;"></div>
    </div>

    <script>
        var user = $("#txtUser").val();
        var userType = '<%=(Session["UserInfo"] == null ? "" :((Dal.Models.UserInfo)Session["UserInfo"]).UserType.ToString()) %>';

        function onSearch(PerPage, CuttentPage) {
            var DeclarationName = $('#txtDeclarationName').val();
            var DeclarationUnit = $('#txtDeclarationUnit').val();
            var PrizeName = $('#ddlPrizeName').multipleSelect("getSelects").toString();
            var DeclarationBeginDate = $('#txtDeclarationBeginDate').val();
            var DeclarationEndDate = $('#txtDeclarationEndDate').val();
            var EditBeginDate = $('#txtEditBeginDate').val();
            var EditEndDate = $('#txtEditEndDate').val();
            var DeclarationStatus = $('#ddlDeclarationStatus').multipleSelect("getSelects").toString();

            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, DeclarationBeginDate, DeclarationEndDate, EditBeginDate, EditEndDate, DeclarationStatus);
        }
        function CancelEvaluate() {
            $("#Evaluate").css("display", "none");
            $("#DeclarationComment").val("");
            ue.setContent("");

        }
        function getIdSelections() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.DeclarationID
            });
        }

        function getDeclarationStatus() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.DeclarationStatusText
            });
        }

        function getIsAllowUpdate() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.IsAllowUpdate
            });
        }
        function getDeclarationTime() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.IsDeclarationStart
            });
        }
        function getIsDownTime() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.IsDownloadStart
            });
        }
        function operateFormatter(value, row, index) {
            var View;
            var Download;
            var AdminRemove;
            var Exportall;
            var Evaluate;

            if (row.OrganizationName == "") {
                View = [
                    '<a class="edit" href="javascript:void(0)" title="浏览">',
                    '<i class="fa fa-search" style="color:rgba(0,0,0,0.2)></i>',
                    '</a>'
                ];
            }
            else {
                View = [
                    '<a class="edit" href="javascript:void(0)" title="浏览">',
                    '<i class="fa fa-search"></i>',
                    '</a>  '
                ];
            }

            AdminRemove = [
                '<a class="AdminRemove" href="javascript:void(0)" title="管理员删除">',
                '<i class="fa fa-trash-o"></i>',
                '</a> '
            ];

            if (row.OrganizationName == "" || (row.DeclarationStatus != "1802" && row.DeclarationStatus != "1803") || row.IsDownloadStart == "False") {
                Download = [
                    '<a  href="javascript:void(0)" >',
                    '<i class="fa fa-download" style="color:rgba(0,0,0,0.2)"></i>',
                    '</a>'
                ];

                Exportall = [
                    '<a  href="javascript:void(0)"  style="padding-left:5px">',
                    '<i class="fa fa-share-square-o " style="color:rgba(0,0,0,0.2)"></i>',
                    '</a> '
                ];
            }
            else {
                Download = [
                    '<a class="export" href="javascript:void(0)" title="导出">',
                    '<i class="fa fa-download"></i>',
                    '</a>'
                ];

                Exportall = [
                 '<a class="exportall " href="javascript:void(0)" title="本项目全部导出" style="padding-left:5px">',
                 '<i class="fa fa-share-square-o " ></i>',
                 '</a> '
                ];
            }

            if (row.DeclarationStatus == "1803" || row.DeclarationStatus == "1804") {
                Evaluate = [
                    '<a class="evaluate" href="javascript:void(0)" title="查看评价" style="margin-left:5px;">',
                    '<i class="fa fa-yelp"></i>',
                    '</a> '
                ];
            }
            else {
                Evaluate = [
                    '<a  href="javascript:void(0)" title="查看评价">',
                    '<i class="fa fa-yelp" style="color:rgba(0,0,0,0.2)"></i>',
                    '</a> ',
                ];
            }

            if (userType == "0809" || userType == "0808") {
                return View.join('');
            }
            else {
                return View.concat(AdminRemove, Download, Evaluate).join('');
            }            
        }

        function onAdminDelete() {
            ShowMessags('是否删除此申报？');
            $('.layui-layer-btn0').on('click', function () {
                var DeclarationID = getIdSelections();
                DeclarationID = DeclarationID.join(",");
                DelPlural(DeclarationID, "1805");
            });
        }

        function DelPlural(DeclaraID, status) {
            $.ajax({
                url: '../Mutual/Declaration.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "Delete",
                    "DeclarationID": DeclaraID,
                    "DeclarationStatus": status
                },
                success: function (data) {
                    var ArrayDeclaraID = DeclaraID.split(',');
                    for (i = 0; i < ArrayDeclaraID.length; i++) {
                        $('#tbList').bootstrapTable('remove', {
                            field: 'DeclarationID',
                            values: [ArrayDeclaraID[i]]
                        });
                    }
                }
            });
        }

        function onExport() {
            var DeclarationID = getIdSelections();
            DownLoad(DeclarationID, "Export");
        }

        function onExportAll() {
            var DeclarationID = getIdSelections();
            DownLoad(DeclarationID, "ExportAll");
        }

        function onExportOpinion() {
            var DeclarationID = getIdSelections();
            DownLoad(DeclarationID, "ExportOpinion");
        }

        function onExportRecommendOpinion() {
            var DeclarationID = getIdSelections();
            DownLoad(DeclarationID, "ExportRecommendOpinion");
        }

        function DownLoad(DeclarationID, Status) {
            var form = $("<form>");   //定义一个form表单
            form.attr('style', 'display:none');   //在form表单中添加查询参数
            form.attr('target', '');
            form.attr('method', 'post');
            if (Status == "Export") {
                form.attr('action', "../Declaration/DeclarationList.aspx?DeclarationID=" + DeclarationID);
            }
            else if (Status == "ExportAll") {
                form.attr('action', "../Declaration/DeclarationList.aspx?ExportDeclarationID=" + DeclarationID);
            }
			else if (Status == "ExportOpinion") {
                form.attr('action', "../Declaration/DeclarationList.aspx?ExportOpinionID=" + DeclarationID);
            }			
			else if (Status == "ExportRecommendOpinion") {
			    form.attr('action', "../Declaration/DeclarationList.aspx?ExportRecommendOpinionID=" + DeclarationID);
			}
			else {
                form.attr('action', "../Declaration/DeclarationList.aspx?ExportSummaryID=" + DeclarationID);
            }
            var input1 = $('<input>');
            input1.attr('type', 'hidden');
            $('body').append(form);  //将表单放置在web中
            form.append(input1);   //将查询参数控件提交到表单上
            form.submit();
        }

        function getNav() {
            //缓存当前页面所属栏目
            var ocolumn2Link = $("#column2").attr("href");
            var currerntNav = { column1: $("#column1").text(), column2Link: ocolumn2Link, column2: $("#column2").text() }
            $.cookie('currentPage', JSON.stringify(currerntNav), { path: '/' });
        }

        // 初始化富文本框
        function InitUEditor(container) {
            var text = $("#" + container.replace("TextBox", ""));
            text.hide();
            var ue = UE.getEditor(container, {
                wordCount: false,
                autoHeightEnabled: true,
                readonly: true,
                toolbars: [[]]
            });
            ue.ready(function () {
                //设置编辑器的内容
                ue.setContent(text.val());
            });
        }

        function InitTable(PageSize, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, DeclarationBeginDate, DeclarationEndDate, EditBeginDate, EditEndDate, DeclarationStatus) {
            $('#tbList').bootstrapTable('destroy');
            window.operateEvents = {
                'click .export': function (e, value, row, index) {
                    if (row.OrganizationName != "" && (row.DeclarationStatus == "1802" || row.DeclarationStatus == "1803")) {
                        DownLoad(row.DeclarationID, "Export");
                    }
                },
                'click .exportall': function (e, value, row, index) {
                    if (row.OrganizationName != "" && (row.DeclarationStatus == "1802" || row.DeclarationStatus == "1803")) {
                        DownLoad(row.DeclarationID, "ExportAll");
                    }
                },
                'click .edit': function (e, value, row, index) {
                    if (row.OrganizationName != "") {
                        location.href = "Declaration.aspx?DeclarationID=" + row.DeclarationID + "&Situation='ExpertReview'";
                        getNav();
                    }
                },
                'click .evaluate': function (e, value, row, index) {
                    if (row.OrganizationName != "" && (row.DeclarationStatus == "1803" || row.DeclarationStatus == "1804")) {
                        $.ajax({
                            url: '../Mutual/Declaration.ashx',
                            type: "post",
                            data: { "Action": "GetComment", "DeclarationID": row.DeclarationID },
                            success: function (data) {
                                data = JSON.parse(data);
                                if (data == null || data == "") {
                                    $("#DeclarationComment").val("管理员未给出评价！");
                                }
                                else {
                                    $("#DeclarationComment").val(data);
                                }

                                InitUEditor("DeclarationCommentTextBox");
                            }
                        });
                        $("#Evaluate").css("display", "block");
                    }
                },
                'click .AdminRemove': function (e, value, row, index) {
                    ShowMessags('是否删除此申报？');
                    $('.layui-layer-btn0').on('click', function () {
                        $.ajax({
                            url: '../Mutual/Declaration.ashx',
                            type: "post",
                            data: {
                                "Action": "ThoroughDelete",
                                "DeclarationID": row.DeclarationID
                            },
                            success: function (data) {
                                if (data = "success") {
                                    $('#tbList').bootstrapTable('remove', {
                                        field: 'DeclarationID',
                                        values: [row.DeclarationID]
                                    });
                                }
                                else {
                                    ShowMessag(data);
                                }
                            }
                        });
                    });
                }
            };

            $.ajax({
                url: '../Mutual/Declaration.ashx',
                type: "post",
                data: {
                    "Action": "GetDeclarationList",
                    "PageSize": PageSize,
                    "CuttentPage": CuttentPage,
                    "DeclarationName": DeclarationName,
                    "DeclarationUnit": DeclarationUnit,
                    "PrizeName": PrizeName,
                    "DeclarationBeginDate": DeclarationBeginDate,
                    "DeclarationEndDate": DeclarationEndDate,
                    "EditBeginDate": EditBeginDate,
                    "EditEndDate": EditEndDate,
                    "DeclarationStatus": DeclarationStatus
                },
                success: function (data) {
                    if (data != "") {                     
                        var Row = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbar',                //工具按钮用哪个容器
                            striped: true,                    //是否显示行间隔色
                            sortable: true,
                            editable: true,
                            clickToSelect: true,
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "DeclarationID",          //每一行的唯一标识，一般为主键列
                            columns: [
                                { checkbox: true },
                                { field: 'DeclarationName', title: '项目名称', align: 'center', valign: 'middle' },
                                { field: 'DeclarationCode', title: '项目编号', align: 'center', valign: 'middle', visible: false },
                                { field: 'PrizeName', title: '申报奖项', align: 'center', valign: 'middle' },
                                { field: 'DeclarationStatusText', title: '申报状态', align: 'center', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                { field: 'DeclareDate', title: '开始填报日期', align: 'center', valign: 'middle' },
                                { field: 'LastUpdateTime', title: '最后修改时间', align: 'center', valign: 'middle' },
                                { field: 'operate', title: '操作', align: 'center', events: operateEvents, formatter: operateFormatter }
                            ],
                            onEditableSave: function (field, row, oldValue, $el) {
                                $.ajax({
                                    type: "post",
                                    url: '../Mutual/Declaration.ashx',
                                    data: {
                                        "Action": "UpdateOrganizationOrdinal",
                                        "DeclarationID": row.DeclarationID,
                                        "newValue": row.Order
                                    },
                                    success: function (data) {
                                        ShowMessag(data);
                                    }
                                });
                            }
                        }
                      
                    } else {
                        $('<tr"><td>没有找到匹配的记录</td></tr>').appendTo($('#tbList'));
                    };
                    option.data = Row.Table;
                    $('#tbList').bootstrapTable(option);                
                    $("#divPagination").empty();
                    $("#divPagination").append(recordsCount(Row.RecordNumber, Row.CuttentPage, Row.PerPage));
                    $("#divPagination").append(myPaginationLinks(Row.RecordNumber, Row.CuttentPage, Row.PagesCount, "page_link", "active", "disabled"));
                    $("#divPagination").append(selectPerPage());
                    $("#per_page_select").val(Row.PerPage);
                    $('th:last-child').css('width', '110px');
                }
            });
        
            $('#btn_delete2').prop('disabled', "true");
            $('#btn_edit').prop('disabled', "true");
            $('#btn_export').prop('disabled', "true");
            $('#btn_exportall').prop('disabled', "true");
            $('#btn_exportOpinion').prop('disabled', "true");
            $('#btn_exportSummary').prop('disabled', "true");
            $('#btn_ExportRecommendOpinion').prop('disabled', "true");
            $('#btn_deleteAdmin').prop('disabled', "true");

            $('#tbList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                var ArrayStatus = getDeclarationStatus().indexOf("编写中");
                var ArrayStatus2 = getDeclarationStatus().indexOf("收件封存");
                var ArrayStatus3 = getIsDownTime().indexOf("False");
                if (ArrayStatus2 >= 0) {
                    $('#btn_delete2').prop('disabled', "true");
                }
                else {
                    $('#btn_delete2').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                }
                $('#btn_edit').prop('disabled', !($('#tbList').bootstrapTable('getSelections').length == 1));
                if (ArrayStatus >= 0 || ArrayStatus3 >= 0) {
                    $('#btn_export').prop('disabled', "true");
                    $('#btn_exportall').prop('disabled', "true");
                }
                else {
                    $('#btn_export').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                    $('#btn_exportall').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                }

                $('#btn_exportSummary').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                $('#btn_exportOpinion').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                $('#btn_ExportRecommendOpinion').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                $('#btn_deleteAdmin').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
            });
        }

        $(function () {
            if (userType == "") {
                window.location = "../Mutual/UserEntry.aspx";
            }

            if (userType == "0809" || userType == "0808") {
                $("#btn_deleteAdmin").hide();
                $("#btn_exportOpinion").hide();
                $("#btn_ExportRecommendOpinion").hide();
                $("#btn_export").hide();
                $("#btn_exportall").hide();
            }

            $("#ddlPrizeName, #ddlDeclarationStatus").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });

            $('select').multipleSelect('checkAll');

            //日期控件
            $(".datepicker").datepicker({
                language: "zh-CN",
                autoclose: true,
                todayHighlight: true,
                format: "yyyy-mm-dd"
            });

            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            }

            var PerPage = '<%=ViewState["PerPage"] ?? 200 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';

            $(".form-control").each(function () {
                $(this).css("margin-left", "25px")
            });

            $(".input-group-addon i").each(function () {
                $(this).css("margin-left", "10px")
            });

            InitTable(PerPage, CuttentPage);
        });

    </script>
</asp:Content>
