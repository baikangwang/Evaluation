<%@ Page Title="专家投票结果" Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="ExpertVoteResult.aspx.cs" Inherits="Evaluation.View.ActivityManage.ExpertVoteResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #content {
            padding-bottom: 240px !important;
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
            <a href="../ActivityManage/ExpertVoteResult.aspx">专家投票结果</a>
        </li>
    </ul>
        <div style="width:150px;margin:10px auto;">
    <asp:LinkButton runat="server" ID="lkbExport" class="btnt" ToolTip="导出投票结果" OnClick="lkbExport_Click">导出投票结果</asp:LinkButton>
    </div>
    <div>
        <div id="toolbar" class="btn-group"></div>
        <table id="tbList" data-reorderable-columns="true"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px; margin-bottom: 127px;"></div>
    </div> 
    <script>

        function operateFormatter2(value, row, index) {
            return [
                       '<a class="edit" href="javascript:void(0)" title="浏览">',
                       '<i class="fa fa-search"></i>',
                       '</a>  ',
            ].join('');
        }

        function InitTable(PerPage, CuttentPage) {
            $('#tbList').bootstrapTable('destroy');
            window.operateEvents = {
                'click .edit': function (e, value, row, index) {
                    location.href = "VoteDetails.aspx?DeclarationID=" + row.DeclarationID;
                }
            }
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: { "Action": "GetExpertVoteList", "PageSize": PerPage, "CuttentPage": CuttentPage },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data);
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
                                { field: 'ExpertName', title: '专家', align: 'center', valign: 'middle' },
                                { field: 'DeclarationName', title: '项目名称', align: 'center', valign: 'middle' },
                                { field: 'PrizeName', title: '申报奖项', align: 'center', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                { field: 'PrizeType', title: '奖项类别', align: 'center', valign: 'middle' },
                                { field: 'FirstPrize', title: '一等奖', align: 'center', valign: 'middle' },
                                { field: 'SecondPrize', title: '二等奖', align: 'center', valign: 'middle' },
                                { field: 'ThirdPrize', title: '三等奖', align: 'center', valign: 'middle' },
                                { field: 'Recommended', title: '推荐', align: 'center', valign: 'middle' },
                                { field: 'NotRecommended', title: '不推荐', align: 'center', valign: 'middle' },
                                { field: 'SlowRating', title: '缓评', align: 'center', valign: 'middle' },
                                { field: 'TurnOut', title: '转出', align: 'center', valign: 'middle' }
                            ]
                        }

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
        }

        function getIdSelections() {
            return $.map($('#tbExpertVoteResult').bootstrapTable('getData'), function (data) {
                return data;
            });
        };

        $(function () {          
            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
            InitTable(PerPage, CuttentPage);
            $("#ddlSpeciatly").multipleSelect({
                single: true
            });
        });

    </script>
</asp:Content>

