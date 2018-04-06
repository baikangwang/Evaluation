<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlList.aspx.cs" Inherits="Evaluation.View.Privilege.ControlList" MasterPageFile="~/View/Mutual/Site.Master"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .table {
            width: 100%;
        }

        tr:hover > th {
            background-color: inherit;
        }

        .table > tbody > tr > th.warning {
            background-color: #DBF1EF;
            border-color: #DBF1EF;
        }

        .container {
            max-width: none !important;
            padding: 0;
        }

        .row {
            margin: 0;
        }

        .col-sm-12, .col-xs-12, .col-sm-8 {
            position: relative;
            padding: 0;
        }

            .col-sm-12.col-xs-12.lg input {
                position: absolute;
                right: 0;
            }

        .col-sm-2 {
            position: relative;
            padding-left: 70px;
        }

        .fixed-table-toolbar .bs-bars, .fixed-table-toolbar .search, .fixed-table-toolbar .columns {
            position: relative;
            margin-bottom: 0px;
            margin-top: 22px;
        }

        #ContentPlaceHolder1_btnExportLeaguerUser {
            margin-left: 6px;
            margin-right: 6px;
        }

        .btnt {
            width: 78px;
            border-radius: 6px;
            background: #33B0BA;
            color: #fff;
            border: none;
            padding: 0;
            font-size: 13px;
            height: 25px;
            line-height: 25px;
        }

        a:hover {
            color: #fff;
            text-decoration: none;
        }

        input[type="text"] {
            vertical-align: middle;
            border: 0;
            border: 1px solid #AAAAAA;
        }

            input[type="text"]:focus {
                border: 1px solid #AAAAAA;
            }

        input[type="file"] {
            margin-top: 15px;
        }

        .col-sm-10.yellow {
            margin-top: 12px;
        }

        .table thead > tr > th {
            border-bottom: 0;
        }

        .bootstrap-table .table > thead > tr > th {
            border-bottom: 0;
        }

        .table tbody > tr > td {
            border-top: 0;
        }

        .fixed-table-container thead th {
            border-left: 0;
        }

        #txtUserType {
            display: none;
        }

        .ms-choice {
            height: 25px;
        }

        #lbkSearch {
            width: 78px;
            padding: 0;
            height: 25px;
            display: inline-block;
            text-align: center;
            line-height: 25px;
        }

        .condition {
            width: 100%;
            border: 1px solid #e1e1e1;
            border-radius: 5px;
            padding: 10px;
            margin-bottom: 15px;
        }

        .buttonarea {
            width: 200px;
            margin: 0 auto;
        }

            .buttonarea button, .buttonarea input {
                height: 25px;
                padding: 0;
            }

        #ContentPlaceHolder1_btnExportAll {
            margin: 0 10px;
        }

        #ContentPlaceHolder1_butExportUserExcel {
            color: #333;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <ul class="navs">
        <li class="nav1" id="main" style="float: left; padding-right: 5px;">
            <a href="#">权限管理</a>
        </li>
    </ul>
    <div class="container div ">
        <div class="row">
            <div class="col-sm-12 col-xs-12">
                <asp:TextBox ID="txtUserType" ClientIDMode="Static" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-12 btn_add" id="association">
                <div id="toolbar" class="btn-group">
                </div>
                <table id="tbList" data-reorderable-columns="true"></table>
                <div id="divPagination" style="overflow: hidden; margin-top: 10px;"></div>
            </div>
        </div>
    </div>
    <script>
        var GroupID = window.location.search.substr(-1);
        function formatTableUnit(value, row, index) {
            return {
                css: {
                    "width": "289px"
                }
            }
        };
        function SpecialtyIconFormatter(value, row, index) {
            return ['<i class="fa ' + row.SpecialtyIcon + '"></i>'].join('');
        }
  
        function operateFormatter(value, row, index) {
            if (row.Details=="True") {
                return [
                  '<a class="check" href="javascript:void(0)" title="编辑">',
                  '<input type="checkbox" id="checkControl"  checked="checked" />',
                  '</a>  '
                ].join('');
            }
            else {
                return [
                 '<a class="check" href="javascript:void(0)" title="编辑">',
                 '<input type="checkbox" id="checkControl"  />',
                 '</a>  '
                ].join('');
            }
          
        }
        function Search() {
            var userName = $("#tbxUserName").val().trim();
            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
            InitTable(PerPage, CuttentPage);
        }


        function InitTable(PageSize, CuttentPage) {
            $('#tbList').bootstrapTable('destroy');
            window.operateEvents = {
                'click .forbidden': function (e, value, row, index) {
                    $.ajax({
                        url: "../Mutual/UserManage.ashx",
                        type: "post",
                        data: { "Action": "ForbiddenUser", "UserID": row.UserID },
                        success: function (data) {
                            ShowMessag(data);
                            $(".layui-layer-btn0").click(function () {
                                var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
                                var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
                                InitTable(PerPage, CuttentPage);
                            });
                        }
                    });
                },
                'click .updatacheck': function (e, value, row, index) {
                    onRowEdit(row.ControlID,row.Details);
                }
            };
            $.ajax({
                url: "../Privilege/PrivilegeManage.ashx",
                type: "post",
                data: { "Action": "GetControlsList", "PageSize": PageSize, "CuttentPage": CuttentPage, "GroupID": GroupID },
                success: function (data) {
                    if (data != "") {
                        // alert(getdata)
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
                            uniqueId: "ControlID",          //每一行的唯一标识，一般为主键列
                            columns: [
                                { field: 'PageName', title: '所属页面', align: 'center', valign: 'middle' },
                                { field: 'ControlName', title: '控件名称', align: 'center', valign: 'middle' },
                                { field: 'ControlType', title: '控件类型', align: 'center', valign: 'middle' },
                                { field: 'operate', title: '是否选中', align: 'center', valign: 'middle', events: operateEvents, formatter: operateFormatter },
                            ]
                        };
                        option.data = Row.Table;
                        $('#tbList').bootstrapTable(option);
                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(Row.RecordNumber, Row.CuttentPage, Row.PerPage));
                        $("#divPagination").append(myPaginationLinks(Row.RecordNumber, Row.CuttentPage, Row.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(Row.PerPage);
                        $('#tbList th[data-field="SpecialtyNames"] .th-inner').css({ 'width': '285px', 'margin': '0 auto' });
                    }
                    else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbList'));
                    }
                }
            });

            $("#btn_delete").prop('disabled', 'true');
            $('#ContentPlaceHolder1_butExportUserExcel').prop('disabled', 'true');
            $("#tbList").on("check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table", function () {
                $("#ContentPlaceHolder1_butExportUserExcel").prop('disabled', !$("#tbList").bootstrapTable('getSelections').length);
                $("#btn_delete").prop('disabled', function () {
                    if (!$("#tbList").bootstrapTable('getSelections').length) {
                        return true;
                    }
                    else {
                        var row = $("#tbList").bootstrapTable('getSelections');
                        var currentLoginUser = $('#spUserName').html();
                        for (var i = 0; i < row.length; i++) {
                            if (row[i].UserTypeText == currentLoginUser) {
                                return true;
                            }
                        }
                        return false;
                    }
                });
            });
        }

        function getIdSelections() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.GroupID;
            });
        }

        function getIdUserTypes() {
            return $.map($('#tbList').bootstrapTable('getData'), function (data) {
                return data;
            });
        };
        function onRowEdit(ControlID, Details) {
          $
        }
        $(function () {
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            };
            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
                var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
                InitTable(PerPage, CuttentPage);
            });

    </script>
</asp:Content>
