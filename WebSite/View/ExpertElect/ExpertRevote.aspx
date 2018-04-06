<%@ Page Title="等票复投" Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="ExpertRevote.aspx.cs" Inherits="Evaluation.View.ActivityManage.ExpertRevote" %>

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
         #tbList input[type="radio"] {
            width: 25px;
            height: 25px;
            position: relative;           
            left: 12px;
            top: 3px;
            z-index:10;
            opacity:0;
            cursor:pointer;
        }
        #tbList .fa {
            position: relative;
            top: -2px;
            right: 11px;
            font-size:22px;
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
        <input id="txtMsg" type="text" style="width:400px;border:none" disabled="disabled" />
        <asp:HiddenField ID="hfPrizeID" runat="server" ClientIDMode="Static" />
        <asp:HiddenField ID="hfReVotePrizeLevel" runat="server" ClientIDMode="Static" />
        <asp:HiddenField ID="hfReVoteRound" runat="server" ClientIDMode="Static" />
        <div id="toolbar" class="btn-group"></div>
        <table id="tbList" data-reorderable-columns="true"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px; margin-bottom: 127px;"></div>
    </div>
    <div>
        <input type="button" class="btnt" id="btnVote" value="投 &nbsp;票" />
        <input type="button" class="btnt" id="btnBack" value="返 &nbsp;回" />
    </div>
    <script>
        $("#btnVote").click(function () {
            if ($('#tbList tbody tr').length > 0 && $('#tbList tbody tr td').text() != "没有找到匹配的记录") {
                var postData = "[";
                for (var i = 0; i < $('#tbList tbody tr').length; i++) {
                    postData = postData + '{"DeclarationID":"' + getIdSelections()[i].DeclarationID +
                        '","VoteCode":"' + $("input[name='rbtn" + i + "']:checked").val() +
                        '","PrizeID":"' + getIdSelections()[i].PrizeID +
                        '"},';
                }
                postData = postData.substring(0, postData.length - 1) + "]";
                $.ajax({
                    url: '../Mutual/ActivityManage.ashx',
                    type: "post",
                    dataType: "json",
                    data: {
                        "Action": "AddExpertReVote", "JsonData": postData, "PrizeID": $("#hfPrizeID").val(),
                        "ReVotePrizeLevel": $("#hfReVotePrizeLevel").val(), "ReVoteRound": $("#hfReVoteRound").val()
                    },
                    success: function (data) {
                        ShowMessag(data);
                        InitTable();
                    }
                });
            }
            else {
                ShowMessag("没有数据!");
            }
        });
        function getIdSelections() {
            return $.map($('#tbList').bootstrapTable('getData'), function (data) {
                return data;
            })
        }
        $("#btnBack").click(function(){
            window.history.go(-1);
        });
        function operateFormatter(value, row, index) {
            if (row.VoteCode == "0602") {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0601"/>'
                      + '<i class="fa fa-thumbs-up" aria-hidden="true" style="color:#868686"></i>',
                      '<input type="radio" class="export" name="rbtn' + index + '" value="0602" checked="checked"/>'
                      + '<i class="fa fa-thumbs-down" aria-hidden="true" style="color:#FFA200"></i>'
                ].join('');
            }
            else {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0601" checked="checked"/>'
                      + '<i class="fa fa-thumbs-up" aria-hidden="true" style="color:#FFA200"></i>',
                      '<input type="radio" class="export" name="rbtn' + index + '" value="0602"/>'
                      + '<i class="fa fa-thumbs-down" aria-hidden="true" style="color:#868686"></i>'
                ].join('');
            }
        }

        function InitTable(PerPage, CuttentPage) {
            $('#tbList').bootstrapTable('destroy');
            window.operateEvents = {
                'click .export': function (e, value, row, index) {
                }
            };
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: {
                    "Action": "GetReVoteList", "PageSize": PerPage, "CuttentPage": CuttentPage, "PrizeID": $("#hfPrizeID").val()
                },
                success: function (data) {
                    if (data != "") {
                        data = JSON.parse(data);
                        var Row = data[0];
                        var reVoteBatch = data[1];
                        var rePrizeLevel;
                        if (reVoteBatch.PrizeLevelCode == "0401")
                        {
                            rePrizeLevel = "一等奖";
                        }
                        else if (reVoteBatch.PrizeLevelCode == "0402") {
                            rePrizeLevel = "二等奖";
                        }
                        else if (reVoteBatch.PrizeLevelCode == "0403") {
                            rePrizeLevel = "三等奖";
                        }

                        var round = reVoteBatch.Round;
                        $("#hfReVotePrizeLevel").val(reVoteBatch.PrizeLevelCode);
                        $("#hfReVoteRound").val(round);

                        $("#txtMsg").val("本轮为等票复投" + rePrizeLevel + "第" + round + "轮");
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
                                { field: 'ReVote', title: '复投', align: 'center', valign: 'middle', events: operateEvents, formatter: operateFormatter }
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
            $('#tbList').on('click', 'input', function () {
                $(this).closest('tr').find('input').next('.fa').css('color', '#868686');
                $(this).next('.fa').css('color', '#FFA200')
            });
        });

    </script>
</asp:Content>
