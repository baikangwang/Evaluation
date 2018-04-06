<%@ Page Title="项目-专家投票情况" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ExpertVoteDetail.aspx.cs" Inherits="Evaluation.View.ExpertElect.ExpertVoteDetail" %>
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
            <a href="#">评优报表</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="../ExpertElect/ExpertVoteDetailList.aspx">专家投票情况</a>
        </li>
    </ul>
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

        function InitTable(PerPage, CuttentPage, PrizeID) {
            $('#tbList').bootstrapTable('destroy');

            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: {
                    "Action": "GetExpertVoteDetail",
                    "PageSize": PerPage,
                    "CuttentPage": CuttentPage,
                    "PrizeID": PrizeID
                },
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
                            uniqueId: "ExpertID",            //每一行的唯一标识，一般为主键列
                            columns: [
                                { field: 'PrizeName', title: '奖项名称', align: 'center', valign: 'middle' },
                                { field: 'ExpertName', title: '专家姓名', align: 'center', valign: 'middle' },
                                { field: 'VoteStatus', title: '投票情况', align: 'center', valign: 'middle' },
                                { field: 'IsSubmitText', title: '是否提交', align: 'center', valign: 'middle' }
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
            var PrizeID = '<%=ViewState["PrizeID"] ?? 1 %>';
            InitTable(PerPage, CuttentPage, PrizeID);
            $("#ddlSpeciatly").multipleSelect({
                single: true
            });
        });

    </script>
</asp:Content>

