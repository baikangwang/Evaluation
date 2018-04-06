<%@ Page Title="项目分配列表" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="AllocationList.aspx.cs" Inherits="Evaluation.View.ExpertManage.AllocationList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>
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
            padding: 5px 6px !important;
            border: none;
            border: 1px solid #ccc;
            margin-left: 5px !important;
            margin-right: 12px !important;
        }

        #txtDeclarationBeginDate, #txtDeclarationEndDate, #txtEditBeginDate, #txtEditEndDate {
            margin-left: 0px !important;line-height:26px;
        }

        .btnt {
            width: 78px;
            margin: 0 auto;
            height: 26px;
            line-height: 26px;
            padding: 0px;
        }

        .inquire {
            width: 184px;
            margin: 0 auto;
            display: block;
            margin-top: 20px;
        }

        .input-group table {
            display: inline;
            float:right;
        }

        .datepicker input {
            height: 26px!important;
            line-height: 12px;
        }

        .DeclarationList {
            border: 1px solid #E1E1E1;
            border-radius: 5px;
            padding: 13px 10px 10px 10px;
        }

        .input-group-addon {
            padding: 0 6px;
        }

        #txtDeclarationName {
            height: 26px;
        }
        .file-caption-main {
            width: 430px !important;
            position: absolute;
            top:10px;
            left: 349px;
        }
          .control-label{
            font-weight:400;margin-left:13px;
        }
       .input-group-btn .btn{
            padding:2px 13px!important;
        }
        .form-control{
           border-top-left-radius:4px;
           border-bottom-left-radius:4px;
           padding:0;
           height:25px!important;
        }
            .file-caption-name {
            height: 16px!important;
        }
        .btn.btn-primary.btn-file{
          border-top-right-radius:4px;
          border-bottom-right-radius:4px;
        }
        .hidden-xs {
            display: inline !important;
        }
        .progress{
            display:none;
        }
        .condition {
            height: 41px;
        }

        #ContentPlaceHolder1_btnDownload {
            margin-left: 10px;
            position: absolute;
            left: 934px;
            top: 11px;
        }
        .ms-select-all{
            display:none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#" id="column1">评优管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a  id="column2" href="../ExpertManage/AllocationList.aspx">项目分配</a>
        </li>        
    </ul>
    <div class="DeclarationList" >
      
        <div class="select" style="margin: 0 20px 10px 0">
            <span>项目名称：&nbsp;<asp:TextBox ID="txtDeclarationName" ClientIDMode="Static" runat="server" Width="166px" placeholder="项目名称"></asp:TextBox>
            </span>
            <span>申报单位：&nbsp;
                <asp:TextBox runat="server" ID="txtDeclarationUnit" ClientIDMode="Static" Style="width: 166px; height: 26px;"></asp:TextBox>
            </span>
            <span style="margin-left: 13px;">申报奖项：&nbsp; <asp:DropDownList ID="ddlPrizeName" runat="server" ClientIDMode="Static" Style="width: 166px; height: 26px;"></asp:DropDownList>
            </span>
           <span style="display:none;">申报状态：&nbsp;
                <asp:DropDownList ID="ddlDeclarationStatus" runat="server" ClientIDMode="Static" Style="width: 166px; margin-left: 28px; height: 26px;"></asp:DropDownList>
            </span>
        </div>
        <div style="overflow:hidden;">
        <div style="float: left;">
            <div class="input-group" style="margin-right:20px;">
                <span style="position:relative;bottom:-6px;">申报日期：&nbsp;</span>
                <table>
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
        <div style="float: left;">
            <div class="input-group">
                <span style="position:relative;bottom:-6px;">修改日期：&nbsp;</span>
                <table>
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

    <span class="inquire">
        <input type="button" value="查  询" class="btnt"  onclick="onSearch();" style="margin-right:10px;" /> 
        <input type="button" value="导  入" class="btnt"  onclick="Import();" /> 
    </span>
    <br />

    <table id="tbList" data-reorderable-columns="true"></table>
    <div id="divPagination" style="overflow: hidden; margin-top: 10px;padding-bottom:100px;"></div>
    <script>
        function onSearch(PerPage, CuttentPage) {
            var DeclarationName = $('#txtDeclarationName').val().trim();
            var DeclarationUnit = $('#txtDeclarationUnit').val().trim();
            var PrizeName = $('#ddlPrizeName').multipleSelect("getSelects").toString();
            var DeclarationBeginDate = $('#txtDeclarationBeginDate').val().trim();
            var DeclarationEndDate = $('#txtDeclarationEndDate').val().trim();
            var EditBeginDate = $('#txtEditBeginDate').val().trim();
            var EditEndDate = $('#txtEditEndDate').val().trim();
            var DeclarationStatus = $('#ddlDeclarationStatus option:selected').val().trim();

            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, DeclarationBeginDate, DeclarationEndDate, EditBeginDate, EditEndDate, DeclarationStatus);
        }

        function getIdSelections() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.DeclarationID
            });
        }

        function PrizeFormatter(value, row, index) {
            var PrizeName;

            $.ajax({
                url: '../Mutual/Common.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "GetPrize",
                    "PrizeID": row.PrizeID
                },
                success: function (data) {
                    PrizeName = JSON.parse(data).PrizeName;
                }
            });

            return PrizeName;
        }

        function CreatorFormatter(value, row, index) {
            var UserName;

            $.ajax({
                url: '../Mutual/Common.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "GetUser",
                    "UserID": row.UserID
                },
                success: function (data) {
                    UserName = JSON.parse(data).UserName;
                }
            });

            return UserName;
        }
        function OrganizationFormatter(value, row, index) {
            var OrganizationName;
            $.ajax({
                url: '../Mutual/Common.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "GetOrganization",
                    "OrganizationID": row.OrganizationID
                },
                success: function (data) {
                    OrganizationName = JSON.parse(data).OrganizationName;
                }
            });

            return OrganizationName;
        }

        function CreateTimeFormatter(value, row, index) {
            var dtm;
            $.ajax({
                url: '../Mutual/Common.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "FormatDateTime",
                    "DateTime": row.CreateTime,
                    "format": "yyyy-MM-dd"
                },
                success: function (data) {
                    dtm = data;
                }
            });
            return dtm;
        }

        function LastUpdateTimeFormatter(value, row, index) {
            var dtm;
            $.ajax({
                url: '../Mutual/Common.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "FormatDateTime",
                    "DateTime": row.LastUpdateTime,
                    "format": "yyyy-MM-dd"
                },
                success: function (data) {
                    dtm = data;
                }
            });
            return dtm;
        }

        function operateFormatter(value, row, index) {
            return [
                '<a class="search" href="javascript:void(0)" title="查看">',
                '<i class="fa fa-search"></i>',
                '</a>  ',
            ].join('');
        }

        function p(s) {
            return s < 10 ? '0' + s : s;
        }
        function getNav() {
            //缓存当前页面所属栏目
            var ocolumn2Link = $("#column2").attr("href");
            var currerntNav = { column1: $("#column1").text(), column2Link: ocolumn2Link, column2: $("#column2").text() }
            $.cookie('currentPage', JSON.stringify(currerntNav), { path: '/' });
        }

        window.operateEvents = {
            'click .search': function (e, value, row, index) {
                var DeclarationID = row.DeclarationID;
                var Situation = row.DeclarationStatus;
                var IsAllow = row.IsAllow;
                getNav();

                var myDate = new Date();
                //获取当前年
                var year = myDate.getFullYear();
                //获取当前月
                var month = myDate.getMonth() + 1;
                //获取当前日
                var date = myDate.getDate();
                var h = myDate.getHours();       //获取当前小时数(0-23)
                var m = myDate.getMinutes();     //获取当前分钟数(0-59)
                var s = myDate.getSeconds();
                var now = year + '/' + p(month) + "/" + p(date) + " " + p(h) + ':' + p(m) + ":" + p(s);

                var nowDate = new Date(now.replace("-", "/").replace("-", "/"));
                var endDate = row.LastUpdateTime.replace("-", "/").replace("-", "/");

                if (endDate < nowDate && Situation != "驳回修改") {

                    location.href = "../../view/Declaration/Declaration.aspx?DeclarationID=" + DeclarationID + "&Situation='ExpertReview'";
                }
                else if (endDate < nowDate && Situation == "驳回修改") {
                    location.href = "../../view/Declaration/Declaration.aspx?DeclarationID=" + DeclarationID + "&Situation='Declaration'";
                }
                else if (Situation == "编写中" || Situation == "驳回修改") {
                    location.href = "../../view/Declaration/Declaration.aspx?DeclarationID=" + DeclarationID + "&Situation='Declaration'";
                }
                else if (Situation != "编写中" && Situation != "已提交" && Situation != "驳回修改") {
                    location.href = "../../view/Declaration/Declaration.aspx?DeclarationID=" + DeclarationID + "&Situation='ExpertReview'";
                }
                else if (Situation == "已提交" && IsAllow == "True") {
                    location.href = "../../view/Declaration/Declaration.aspx?DeclarationID=" + DeclarationID + "&Situation='Declaration'";
                }
                else if (Situation == "已提交" && IsAllow != "True") {
                    location.href = "../../view/Declaration/Declaration.aspx?DeclarationID=" + DeclarationID + "&Situation='ExpertReview'";
                }
            }
        }

        function InitTable(PageSize, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, DeclarationBeginDate, DeclarationEndDate, EditBeginDate, EditEndDate, DeclarationStatus) {
            $('#tbList').bootstrapTable('destroy');

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
                    "AllocationList": "AllocationList"
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data);
                        var index = 0;
                        var validGroupID = [];
                        var option = {
                            striped: true,                      //是否显示行间隔色
                            editable: true,
                            clickToSelect: true,
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "DeclarationID",            //每一行的唯一标识，一般为主键列
                            columns: [
                                { checkbox: true },
                                { field: 'DeclarationName', title: '项目名称', align: 'center', valign: 'middle' },
                                { field: 'PrizeName', title: '申报奖项', align: 'center', valign: 'middle' },
                                { field: 'DeclarationStatusText', title: '申报状态', align: 'center', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                { field: 'DeclareDate', title: '开始申报日期', align: 'center', valign: 'middle' },
                                { field: 'LastUpdateTime', title: '最后修改日期', align: 'center', valign: 'middle' },
                                { field: 'PrizeID', title: '奖项id', align: 'center', valign: 'middle', visible: false },
                                {
                                    field: 'ExpertReviewGroupID', title: '评审专家组', align: 'center', valign: 'middle', editable: {
                                        type: 'select',
                                        title: '选择专家组',
                                        source: function (row) {
                                            var index = $(this).parent().parent().attr("data-index");
                                            var PrizeID = Row.Table[index].PrizeID;
                                            var ExpertGroupID = Row.Table[index].ExpertReviewGroupID;
                                            var currentGroupID;

                                            var result = [];
                                            $.ajax({
                                                url: "../Mutual/ExpertManage.ashx",
                                                async: false,
                                                type: "post",
                                                data: { "Action": "GetExpertGroupListByPrize", "PrizeID": PrizeID },
                                                success: function (data, status) {
                                                    var newData = JSON.parse(data)
                                                    $.each(newData, function (key, value) {
                                                        if (ExpertGroupID == value.GroupID) {
                                                            currentGroupID = value.GroupID
                                                        }
                                                        result.push({ value: value.GroupID, text: value.GroupName });
                                                    });

                                                    if (currentGroupID) {
                                                        validGroupID[index] = currentGroupID;
                                                    }
                                                }
                                            });
                                            return result;
                                        }
                                    }
                                },
                                {
                                    field: 'ExpertReviewer', title: '意见填写人', align: 'center', valign: 'middle', editable: {
                                        type: 'select',
                                        title: '选择意见填写人',
                                        cellStyle: function cellStyle(value, row, index) {
                                            return {
                                                css: {
                                                    "display": "none"
                                                }
                                            };
                                        },
                                        source: function (row) {
                                            var index = $(this).parent().parent().attr("data-index");
                                            var ExpertGroupID = Row.Table[index].ExpertReviewGroupID;
                                            var result = [];
                                            $.ajax({
                                                url: "../Mutual/ExpertManage.ashx",
                                                async: false,
                                                type: "post",
                                                data: { "Action": "GetExpertsByGroupID", "ExpertGroupID": validGroupID[index] },
                                                success: function (data, status) {
                                                    var newData = JSON.parse(data);
                                                    $.each(newData, function (key, value) {
                                                        result.push({ value: value.ExpertID, text: value.ExpertName });
                                                    });
                                                }
                                            });
                                            return result;
                                        }

                                    }
                                },
                                {
                                    title: '操作', align: 'center', Valign: 'middle',
                                    events: operateEvents,
                                    formatter: operateFormatter
                                }
                            ],
                            onEditableSave: function (field, row, oldValue, $el) {
                                if (field == "ExpertReviewGroupID") {
                                    $.ajax({
                                        type: "post",
                                        url: "../Mutual/ExpertManage.ashx",
                                        data: {
                                            "Action": "Allocation",
                                            "ExpertReviewGroupID": row.ExpertReviewGroupID,
                                            "DeclarationID": row.DeclarationID
                                        },
                                        success: function (data, status) {
                                            if (data == "success") {
                                                ShowMessag('分配成功!');
                                            }
                                        },
                                        error: function (data) {
                                            ShowMessag(data);
                                        },
                                    });
                                }
                                if (field == "ExpertReviewer") {
                                    $.ajax({
                                        type: "post",
                                        url: "../Mutual/ExpertManage.ashx",
                                        data: {
                                            "Action": "SaveExpertReviewer",
                                            "DeclarationID": row.DeclarationID,
                                            "ExpertReviewerID": row.ExpertReviewer
                                        },
                                        error: function (data) {
                                            ShowMessag(data);
                                        }
                                    });
                                }
                            }
                        };
                        option.data = Row.Table;
                        $('#tbList').bootstrapTable(option);

                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(Row.RecordNumber, Row.CuttentPage, Row.PerPage));
                        $("#divPagination").append(myPaginationLinks(Row.RecordNumber, Row.CuttentPage, Row.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(Row.PerPage);
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbList'));
                    }
                }
            });

            $('#btn_delete').prop('disabled', "true");
            $('#btn_edit').prop('disabled', "true");

            $('#tbList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_delete').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                $('#btn_edit').prop('disabled', !($('#tbList').bootstrapTable('getSelections').length == 1));
            });
        }

        $(function () {
            $("#ddlPrizeName").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });

            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';

            //日期控件
            $(".datepicker").datepicker({
                language: "zh-CN",
                autoclose: true,
                todayHighlight: true,
                format: "yyyy-mm-dd"
            });
         
            onSearch(PerPage, CuttentPage);

            $('#ddlPrizeName').multipleSelect('checkAll');
        });

        $(".form-control").each(function () {
            $(this).css("margin-left", "25px")
        });
        $(".input-group-addon i").each(function () {
            $(this).css("margin-left", "2px")
        });

        function Import() {
            window.location = "../../View/ExpertManage/Allocation.aspx";
        }
    </script>
</asp:Content>
