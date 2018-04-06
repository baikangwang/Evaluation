<%@ Page Title="等票复投" Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="Revote.aspx.cs" Inherits="Evaluation.View.ActivityManage.Revote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #content {
            padding-bottom: 240px !important;
        }
        #txtDeclarationName,#txtDeclarationUnit{
            border:1px solid #ccc;
            height:25px;
        }
        .select{
            border:1px solid #e1e1e1;
            border-radius:5px;
            padding:10px;
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
            <a href="../ActivityManage/VoteResult.aspx">等票复投</a>
        </li>
    </ul>
    <br />
    <div>
        <div id="toolbar" class="btn-group"></div>
        <table id="tbList" data-reorderable-columns="true"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px; margin-bottom: 127px;"></div>
    </div>
    <script>
        function operateFormatter0(value, row, index) {
            if (row.VoteCode == "0401") {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0401"/>'
                    + '<i class="fa fa-star" aria-hidden="true" style="color:#FFA200"></i>'
                ].join('');
            }
            else if (row.VoteCode == "0402") {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0402"/>'
                    + '<i class="fa fa-star-half-full" aria-hidden="true" style="color:#FFA200"></i>'
                ].join('');
            }
            else if (row.VoteCode == "0403") {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0403"/>'
                    + '<i class="fa fa-star-o " aria-hidden="true" style="color:#FFA200"></i>'
                ].join('');
            }
            else if (row.VoteCode == "0601") {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0601"/>'
                      + '<i class="fa fa-thumbs-up" aria-hidden="true" style="color:#FFA200"></i>'
                ].join('');
            }
        }

        function InitTable(PerPage, CuttentPage) {
            $('#tbList').bootstrapTable('destroy');
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: {
                    "Action": "GetVoteList", "PageSize": PerPage, "CuttentPage": CuttentPage},
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
                                { field: 'DeclarationName', title: '项目名称', align: 'center', valign: 'middle' },
                                { field: 'PrizeName', title: '申报奖项', align: 'center', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                { field: 'PrizeType', title: '奖项类别', align: 'center', valign: 'middle' },
                                { field: 'FirstPrize', title: '一等奖', align: 'center', valign: 'middle' },
                                { field: 'SecondPrize', title: '二等奖', align: 'center', valign: 'middle' },
                                { field: 'ThirdPrize', title: '三等奖', align: 'center', valign: 'middle' },
                                { field: 'NotRecommended', title: '不推荐', align: 'center', valign: 'middle' },
                                { field: 'SlowRating', title: '缓评', align: 'center', valign: 'middle' },
                                { field: 'TurnOut', title: '转出', align: 'center', valign: 'middle' },
                                { field: 'ReVote', title: '复投', align: 'center', valign: 'middle',events:operateEvents,formatter:operateFormatter }
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
        }

        $(function () {
            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
            InitTable(PerPage, CuttentPage);
        });

    </script>
</asp:Content>
