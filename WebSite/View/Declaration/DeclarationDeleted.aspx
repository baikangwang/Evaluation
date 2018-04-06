<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="DeclarationDeleted.aspx.cs" Inherits="Evaluation.View.Declaration.DeclarationDeleted" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>

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
            padding: 5px 6px !important;
            border: none;
            border: 1px solid #ccc;
            margin-right: 6px;
        }

        #txtDeclarationBeginDate, #txtDeclarationEndDate, #txtEditBeginDate, #txtEditEndDate {
            margin-left: 0px !important;
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display: none;">
        <asp:TextBox ID="txtLastUpdateTime" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>
    <div style="display: none;">
        <asp:TextBox ID="txtUserType" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="column1">项目管理</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a id="column2" href="../Declaration/DeclarationDeleted.aspx">已删除项目</a>
        </li>
    </ul>
    <div class="DeclarationList" style="margin-bottom: 30px;">
        <div class="select">
            <span>项目名称：
                <asp:TextBox ID="txtDeclarationName" ClientIDMode="Static" runat="server" Width="168px" placeholder="项目名称"></asp:TextBox>
            </span>
            <span id="VIP">申报单位：
                <asp:TextBox runat="server" ID="txtDeclarationUnit" ClientIDMode="Static"></asp:TextBox>
            </span>
            <span style="margin: 0 9px 0 12px">申报奖项：
			    <asp:DropDownList ID="ddlPrizeName" runat="server" ClientIDMode="Static" Style="width: 168px; height: 25px;"></asp:DropDownList>
            </span>
            <span id="Status">申报状态：
                  <asp:DropDownList ID="ddlDeclarationStatus" runat="server" ClientIDMode="Static" Style="width: 168px; height: 25px; margin-left: 0px;"></asp:DropDownList>
            </span>
        </div>
        <div style="overflow:hidden;">
        <div style="float: left; margin: 12px 14px 0 0px">
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
    <div>
        <div id="toolbar" class="btn-group">
            <button id="btn_recovery" type="button" class="btn btn-default" onclick="onRecover()">
                <span class="fa fa-undo" aria-hidden="true"></span>&nbsp;恢复（批量）
            </button>
            <button id="btn_remove" type="button" class="btn btn-default" onclick="onDelete()">
                <span class="fa fa-trash" aria-hidden="true"></span>&nbsp;彻底删除（批量）
            </button>
        </div>

        <table id="tbList" data-reorderable-columns="true"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px; margin-bottom: 130px;"></div>
    </div>

    <script>
        var UserType = $("#txtUserType").val();
        if (UserType == "会员") {
            $("#VIP").css("display", "none");
        }
        if (UserType == "管理员") {
            $("#Status").css("display", "none");
        }
        function onSearch(PerPage, CuttentPage) {
            var DeclarationName = $('#txtDeclarationName').val().trim();
            var DeclarationUnit = $('#txtDeclarationUnit').val().trim();
            var PrizeName = $('#ddlPrizeName').multipleSelect("getSelects").toString();
            var DeclarationBeginDate = $('#txtDeclarationBeginDate').val();
            var DeclarationEndDate = $('#txtDeclarationEndDate').val();
            var EditBeginDate = $('#txtEditBeginDate').val();
            var EditEndDate = $('#txtEditEndDate').val();
            var DeclarationStatus = $('#ddlDeclarationStatus').multipleSelect("getSelects").toString();
            if (UserType == "管理员") {
                DeclarationStatus = "1805";
            }

            //ShowMessag(DeclarationBeginDate);
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

        function getIdSelections2() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.DeclarationStatusText
            });
        }

        function getIdSelections3() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.IsAllowUpdate
            });
        }

        function operateFormatter(value, row, index) {
            //if (row.DeclarationStatus == "1806") {
            if (UserType == "管理员") {
                return [
                    '<a class="edit" href="javascript:void(0)" title="浏览">',
                    '<i class="fa fa-search"></i>',
                    '</a>  ',
                    '<a class="recovery"  href="javascript:void(0)" title="恢复状态">',
                    '<i class="fa fa-undo"></i>',
                    '</a> ',
                    '<a class="remove"  href="javascript:void(0)" title="彻底删除">',
                    '<i class="fa fa-trash-o"></i>',
                    '</a> ',
                ].join('');
            }
            else {
                if (row.DeclarationStatus == "1806") {
                    return [
                        '<a class="edit" href="javascript:void(0)" title="浏览">',
                        '<i class="fa fa-search"></i>',
                        '</a>  ',
                        '<a class="recovery"  href="javascript:void(0)" title="恢复状态">',
                        '<i class="fa fa-undo"></i>',
                        '</a> ',
                         '<a class="remove"  href="javascript:void(0)" title="彻底删除">',
                        '<i class="fa fa-trash-o"></i>',
                        '</a> ',

                    ].join('');
                }
                else {
                    return [
                       '<a class="edit" href="javascript:void(0)" title="浏览">',
                       '<i class="fa fa-search"></i>',
                       '</a>  ',
                       '<a href="javascript:void(0)" title="恢复状态">',
                       '<i class="fa fa-undo" style="color:gray"></i>',
                       '</a> ',
                       '<a class="remove"  href="javascript:void(0)" title="彻底删除">',
                       '<i class="fa fa-trash-o"></i>',
                       '</a> ',
                    ].join('');
                }
            }

        }
        function onRecover() {
            var DeclarationID = getIdSelections();
            DeclarationID = DeclarationID.join(",");
            RecPlural(DeclarationID);
        }
        function onDelete() {
            var DeclarationID = getIdSelections();
            DeclarationID = DeclarationID.join(",");
            Delete(DeclarationID);
        }
        function RecPlural(DeclaraID) {
            ShowMessags('是否恢复所选申报项目？');
            $('.layui-layer-btn0').on('click', function () {
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    async: false,
                    data: { "Action": "Recovery", "DeclarationID": DeclaraID },
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
            });
        };
        function Delete(DeclaraID) {
            ShowMessags('是否彻底删除所选申报项目？');
            $('.layui-layer-btn0').on('click', function () {
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    async: false,
                    data: {
                        "Action": "DeleteDeclaration",
                        "DeclarationID": DeclaraID
                    },
                    success: function (data) {
                        //ShowMessag('彻底删除成功')
                        var ArrayDeclaraID = DeclaraID.split(',');
                        for (i = 0; i < ArrayDeclaraID.length; i++) {
                            $('#tbList').bootstrapTable('remove', {
                                field: 'DeclarationID',
                                values: [ArrayDeclaraID[i]]
                            });
                        }
                    }
                });
            });
        };
        function p(s) {
            return s < 10 ? '0' + s : s;
        };
        function getNav() {
            //缓存当前页面所属栏目
            var ocolumn2Link = $("#column2").attr("href");
            var currerntNav = { column1: $("#column1").text(), column2Link: ocolumn2Link, column2: $("#column2").text() }
            $.cookie('currentPage', JSON.stringify(currerntNav), { path: '/' });
        }
        function InitTable(PageSize, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, DeclarationBeginDate, DeclarationEndDate, EditBeginDate, EditEndDate, DeclarationStatus) {
            $('#tbList').bootstrapTable('destroy');

            window.operateEvents = {
                'click .edit': function (e, value, row, index) {
                    getNav()
                    location.href = "Declaration.aspx?DeclarationID=" + row.DeclarationID + "&Situation='Delete'";
                },
                'click .remove': function (e, value, row, index) {
                    ShowMessags('是否彻底删除所选申报项目？');
                    $('.layui-layer-btn0').on('click', function () {
                        $.ajax({
                            url: '../Mutual/Declaration.ashx',
                            type: "post",
                            data: {
                                "Action": "DeleteDeclaration",
                                "DeclarationID": row.DeclarationID
                            },
                            success: function (data) {
                                //ShowMessag('彻底删除成功')
                                $('#tbList').bootstrapTable('remove', {
                                    field: 'DeclarationID',
                                    values: [row.DeclarationID]
                                });
                            }
                        });
                    })
                },
                'click .recovery': function (e, value, row, index) {
                    ShowMessags('是否恢复所选申报项目？');
                    $('.layui-layer-btn0').on('click', function () {
                        $.ajax({
                            url: '../Mutual/Declaration.ashx',
                            type: "post",
                            data: { "Action": "Recovery", "DeclarationID": row.DeclarationID },
                            success: function (data) {
                                if (data = "success") {
                                    ShowMessag('恢复成功')
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
                    })
                },
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
                    "DeclarationStatus": DeclarationStatus,
                    "PageType": $("#txtUserType").val()
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
                            uniqueId: "DeclarationID",            //每一行的唯一标识，一般为主键列
                            columns: [
                                { checkbox: true },
                                { field: 'DeclarationName', title: '项目名称', align: 'center', valign: 'middle' },
                                { field: 'PrizeName', title: '申报奖项', align: 'center', valign: 'middle' },
                                { field: 'DeclarationStatusText', title: '申报状态', align: 'center', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                { field: 'DeclareDate', title: '开始填报日期', align: 'center', valign: 'middle' },
                                { field: 'DeleteTime', title: '删除时间', align: 'center', valign: 'middle' },
                                { field: 'operate', title: '操作', align: 'center', events: operateEvents, formatter: operateFormatter }
                            ]
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

            $('#btn_remove').prop('disabled', "true");
            $("#btn_recovery").prop('disabled', "true");
       
            $('#tbList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                var ArrayStatus = getIdSelections2().indexOf("管理员删除");
                if (ArrayStatus >= 0 && UserType == "会员") {
                    $('#btn_recovery').prop('disabled', "true");
                }
                else {
                    $('#btn_recovery').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                }
                $('#btn_remove').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
            });
        }

        $(function () {
            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
            $("#ddlPrizeName,#ddlDeclarationStatus").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });
            $('select').multipleSelect('checkAll');
            InitTable(PerPage, CuttentPage);

            //日期控件
            $(".datepicker").datepicker({
                language: "zh-CN",
                autoclose: true,
                todayHighlight: true,
                format: "yyyy-mm-dd"
            });

            $(".form-control").each(function () {
                $(this).css("margin-left", "25px")
            });

            $(".input-group-addon i").each(function () {
                $(this).css("margin-left", "10px")
            });
        });

    </script>

</asp:Content>
