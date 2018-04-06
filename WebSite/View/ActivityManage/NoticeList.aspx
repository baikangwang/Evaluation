<%@ Page Title="公告管理" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="NoticeList.aspx.cs" Inherits="Evaluation.View.ActivityManage.NoticeList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        a:focus {
            color:inherit;
            text-decoration: none;
        }
        .lg .btn.btn-primary {
            background: #1B9AF7;
            float: none;
            height: 38px;
            width: 88px;
            padding-top: 9px;
        }
        #lbkAddAnnouncement{line-height:31px}
        #tb_noticeList thead {
            background: #DBF1EF;
        }

        .bootstrap-table {
            margin-top:13px;
        }
        #lbkAddAnnouncement {
            line-height:25px;
        }
        a.btnt {
            padding:0;
        }
        .btnt {
           display:block;
           padding:0px;
           height:25px;
           width:78px;
           line-height:25px;
           text-align:center
          }
        .button-primary:hover, .button-primary:focus, .button-primary-flat:hover, .button-primary-flat:focus {
            background-color: #62C1C9;
            border-color: #62C1C9;
            color: #FFF;
        }
        
        .table thead > tr > th {
            border-bottom: 0;
        }

        .bootstrap-table .table > thead > tr > th {
            border-bottom: 0;
        }
        .fixed-table-container thead th {
            border-left: 0;
           
        }
        .table thead:first-child tr:first-child th{
 border-top:1px solid #ccc;
        }
       
     input[type="text"]:focus {
  border-color: none;
}
   </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" id="main" style="float: left; padding-right: 5px;">
            <a href="#">评优管理</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="../ActivityManage/PrizeList.aspx">公告管理</a>
        </li>
    </ul>
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <div class="NoticeList">
        <div class="table-responsive">
            <div id="toolbar" class="btn-group">
                <button id="btn_add" type="button" class="btn btn-default" onclick="onAdd()">
                    <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增
                </button>
                <button id="btn_delete" type="button" class="btn btn-default" onclick="onDelete()">
                    <span class="fa fa-trash" aria-hidden="true"></span>&nbsp;删除（批量）
                </button>
            </div>
            <table id="tb_noticeList" data-reorderable-columns="true"></table>
            <div id="divPagination" style="overflow: hidden; margin-top: 10px; padding-bottom: 50px;"></div>
        </div>
    </div>
    <script>
        function formatTableUnit(value, row, index) {
            return {
                css: {
                    "white-space": "nowrap"
                }
            }
        };

        function operateFormatter(value, row, index) {
            var UserType = $('#tyUserType').val();
            if (UserType == "分会用户" || UserType == "会员用户" || UserType == "会员子用户" || UserType == "专家用户") {
                if (row.NoticeFileName == null) {
                    return [
                  '<a  href="javascript:void(0)" title="下载公告附件">',
                  '<i class="fa fa-download" style="font-size:16px;padding-right:4px;color:rgba(0,0,0,0.2)"></i>',
                  '</a>  ',
                    ].join('');
                }
                else {
                    return [
                   '<a class="download" href="javascript:void(0)" title="下载公告附件">',
                   '<i class="fa fa-download" style="font-size:16px;padding-right:4px;"></i>',
                   '</a>  ',
                    ].join('');
                }
            
            } else {
                if (row.NoticeFileName == null) {
                    return [
                   '<a  href="javascript:void(0)" title="下载公告附件">',
                   '<i class="fa fa-download" style="font-size:16px;padding-right:4px;color:rgba(0,0,0,0.2)"></i>',
                   '</a>  ',
                   '<a class="edit" href="javascript:void(0)" title="编辑">',
                   '<i class="fa fa-edit"></i>',
                   '</a>  ',
                   '<a class="remove" href="javascript:void(0)" title="删除">',
                   '<i class="fa fa-trash"></i>',
                   '</a>',
                    ].join('');
                }
                else {
                    return [
                   '<a class="download" href="javascript:void(0)" title="下载公告附件">',
                   '<i class="fa fa-download" style="font-size:16px;padding-right:4px;"></i>',
                   '</a>  ',
                   '<a class="edit" href="javascript:void(0)" title="编辑">',
                   '<i class="fa fa-edit"></i>',
                   '</a>  ',
                   '<a class="remove" href="javascript:void(0)" title="删除">',
                   '<i class="fa fa-trash"></i>',
                   '</a>',
                    ].join('');
                }
                
            }
        }

        function detailContent(value, row, index) {
            return [
                '<a class="detail" href="javascript:void(0)">',
                row.Title,
                '</a>',
            ].join('');
        }

        function LoadFile(NoticeID) {
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "LoadNoticeFile",
                    "NoticeID": NoticeID
                }
            });
        }

        $(function () {
            var UserType = $('#tyUserType').val();
            if (UserType == "分会用户" || UserType == "会员用户" || UserType == "会员子用户" || UserType == "专家用户") {
                $('#toolbar').remove();
            }
            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
            }

            var PerPage;
            var CuttentPage;
            if ($("#per_page_select").val() == null) {
                PerPage = 50;
            }
            else {
                PerPage = $("#per_page_select").val();
            }
            if ($("#pagination_links li a.active")[0] == null) {
                CuttentPage = 1;
            }
            else {
                CuttentPage = $("#pagination_links li a.active")[0].text;
            }
            InitTable(PerPage, CuttentPage);

        });

        function InitTable(PageSize, CuttentPage) {
            $("#tb_noticeList").bootstrapTable('destroy');
            window.operateEvents = {
                'click .download': function (e, value, row, index) {
                    LoadFile(row.NoticeID);
                    var form = $("<form>");   //定义一个form表单
                    form.attr('style', 'display:none');   //在form表单中添加查询参数
                    form.attr('target', '');
                    form.attr('method', 'post');
                    form.attr('action', "../Declaration/DeclarationList.aspx?NoticeID=" + row.NoticeID);
                    var input1 = $('<input>');
                    input1.attr('type', 'hidden');
                    $('body').append(form);  //将表单放置在web中
                    form.append(input1);   //将查询参数控件提交到表单上
                    form.submit();
                },
                'click .detail': function (e, value, row, index) {
                    window.location = "../ActivityManage/Notice.aspx?nid=" + row.NoticeID + "&statype=2"
                },
                'click .edit': function (e, value, row, index) {
                    window.location = "../ActivityManage/Notice.aspx?nid=" + row.NoticeID + "";
                },
                'click .remove': function (e, value, row, index) {
                    ShowMessags('确定要删除吗?')
                    $(".layui-layer-btn0").click(function () {
                        $.ajax({
                            url: "../Mutual/ActivityManage.ashx",
                            type: "post",
                            data: { "Action": "DelNotice", "NoticeID": row.NoticeID },
                            success: function (data) {
                                $("body").attr("class", "breakpoint-1200");
                                $(".modal-backdrop").remove();
                                if (data == "success") {
                                    var ParPage = $("#per_page_select").val();
                                    var CuttentPage = $("#pagination_links li a.active")[0].text;
                                    InitTable(ParPage, CuttentPage);
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
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: {
                    "Action": "GetAllNoticeList",
                    "PageSize": PageSize,
                    "CuttentPage": CuttentPage
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data);
                        var option = {
                            toolbar: '#toolbar',                //工具按钮用哪个容器
                            striped: true,                      //是否显示行间隔色
                            editable: false,                     //开启编辑模式
                            clickToSelect: true,                //开启点击选中行
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "NoticeID",            //每一行的唯一标识，一般为主键列
                            columns: [
                                { checkbox: true },
                                {
                                    field: 'Ordinal', title: '序号', align: 'center', Valign: 'middle', editable: {
                                        type: 'text',
                                        title: '序号',
                                        validate: function (v) {
                                            if (!v) return '不能为空';
                                        }
                                    }
                                },
                                {
                                    field: 'Title', title: '公告标题', align: 'center', Valign: 'middle', editable: {
                                        type: 'text',
                                        title: '公告标题',
                                        validate: function (v) {
                                            if (!v) return '不能为空';
                                        }
                                    }, events: operateEvents, formatter: detailContent, cellStyle: formatTableUnit
                                },
                                {
                                    field: 'LastEditTimeText', title: '创建时间', align: 'center', Valign: 'middle', editable: {
                                        type: 'text',
                                        title: '创建时间',
                                        validate: function (v) {
                                            if (!v) return '不能为空';
                                        }
                                    }
                                },
                                {
                                    title: '操作', align: 'center', valign: 'middle', events: operateEvents,
                                    formatter: operateFormatter
                                }
                            ]
                        };
                        option.data = Row.Table;

                        $('#tb_noticeList').bootstrapTable(option);
                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(Row.RecordNumber, Row.CuttentPage, Row.PerPage));
                        $("#divPagination").append(myPaginationLinks(Row.RecordNumber, Row.CuttentPage, Row.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(Row.PerPage);
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tb_noticeList'));
                    }
                }
            });
            $('#btn_delete').prop('disabled', "true");
            $('#tb_noticeList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_delete').prop('disabled', !$("#tb_noticeList").bootstrapTable('getSelections').length);
            });
        }

        function getIdSelections() {
            return $.map($('#tb_noticeList').bootstrapTable('getSelections'), function (row) {
                return row.NoticeID;
            });
        }

        function onAdd() {
            window.location = "../ActivityManage/Notice.aspx";
        }

        function onDelete() {
            var NoticeID = getIdSelections();
            NoticeID = NoticeID.join(",");
            ShowMessags("确认要删除吗？");
            $('.layui-layer-btn0').on('click', function () {
                $.ajax({
                    url: '../Mutual/ActivityManage.ashx',
                    type: "post",
                    data: { "Action": "MultiselectDelNoticeList", "NoticeID": NoticeID },
                    success: function (data) {
                        var ParPage = $("#per_page_select").val();
                        var CuttentPage = $("#pagination_links li a.active")[0].text;
                        InitTable(ParPage, CuttentPage);
                    }
                });
            });
        }

        function onSearch(PerPage, CuttentPage) {
            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage);
        }
    </script>
</asp:Content>
