<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="SingleVote.aspx.cs" Inherits="Evaluation.View.ExpertElect.SingleVote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .tb_tr_td_padding_5 tr td {
            padding: 5px;
        }

        .btnt {
            width: 78px;
            padding: 0;
            height: 25px;
            line-height: 25px;
            display: inline-block;
            text-align: center;
        }
         #btnDiv{
                width:300px;
                margin:30px auto;
            }
         .box .fixed-table-body .table td{
           padding:0 8px !important;
       }
          #tbExpertVote input[type="radio"] {
            width: 25px;
            height: 25px;
            position: relative;           
            left: 12px;
            top: 3px;
            z-index:10;
            opacity:0;
            cursor:pointer;
        }
        #tbExpertVote .fa {
            position: relative;
            top: -2px;
            right: 11px;
            font-size:22px;
        }
        #btnSubmit{
            margin:0 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtPrizeID" runat="server" ClientIDMode="Static" style="border:none;background-color:transparent;color:transparent;"></asp:TextBox>
    <ul class="navs">
        <li class="nav1" id="main" style="float: left; padding-right: 5px;">
            <a href="#">专家评选</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#">专家投票</a>
        </li>
    </ul>
<div class="box">
    <div style="width:100%; height:105px; border:1px solid #ccc;border-radius:5px;padding:6px 0 6px 10px;margin-bottom:15px;">
        <table class="tb_tr_td_padding_5">
            <tr>
                <td style="padding-left:19px;">当前奖项为：</td>  
                <td><b><asp:Label ID="labPrizeName" runat="server" Text="Label"></asp:Label></b></td>
                <td style="padding-left:19px;">奖项名额：</td>
                <td><div id="divLimit"></div></td>
            </tr>
            <tr>
                <td style="padding-left:19px;">已投票数量：</td>
                <td><div id="divVoted"></div></td>
                <td style="padding-left:19px;">未投票数量：</td>
                <td><div id="divRemain"></div></td>
            </tr>
        </table>
   </div>
    <div>
        <table id="tbExpertVote"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px; margin-bottom: 130px;"></div>
    </div>
    <div id="btnDiv">
        <input type="button" class="btnt" id="btnVote" value="保 &nbsp;存" />
        <input type="button" class="btnt" id="btnSubmit" value="提 &nbsp;交" />
        <input type="button" class="btnt" id="btnBack" value="返 &nbsp;回" />
    </div>

</div>
    <script>
        $(function () {
            $("#txtPrizeID").hide();
            $('#tbExpertVote').on('click', 'a', function () {
                $(this).closest('tr').find('input').next('.fa').css('color', '#868686');
                $(this).next('.fa').css('color', '#FFA200')
            });
            InitTable()
        });

        $("#btnBack").click(function () {
            //window.location = "../../View/ExpertElect/ExpertVote.aspx";
            window.history.go(-1);
        });

        $("#btnSubmit").click(function () {
            if ($('#tbExpertVote tbody tr').length > 0 && $('#tbExpertVote tbody tr td').text() != "没有找到匹配的记录") {
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    data: { "Action": "SubmitVote", "PrizeID": $("#txtPrizeID").val() },
                    success: function (data) {
                        ShowMessag(data);
                    }
                })
            }
            else {
                ShowMessag("没有数据!");
            }
        });

        $("#btnVote").click(function () {
            if ($('#tbExpertVote tbody tr').length > 0 && $('#tbExpertVote tbody tr td').text() != "没有找到匹配的记录") {
                var postData = "[";
                for (var i = 0; i < $('#tbExpertVote tbody tr').length; i++) {
                    postData = postData + '{"DeclarationID":"' + getIdSelections()[i].DeclarationID +
                        '","VoteCode":"' + $("input[name='rbtn" + i + "']:checked").val() +
                        '","VoteType":"' + "0502" +
                        '","PrizeID":"' + getIdSelections()[i].PrizeID +
                        '"},';
                }
                postData = postData.substring(0, postData.length - 1) + "]";
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    dataType: "json",
                    data: { "Action": "AddExpertVote", "JsonData": postData, "PrizeID": $("#txtPrizeID").val() },
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

        function VoteFormatter(value, row, index) {
            var f = "<a class=\"export\" href=\"javascript:void(0);\" title=\"投票\" >"
                + "<i class=\"fa fa-star-o\" aria-hidden=\"true\" style=\"color:"
                + (value == true ? "#FFA200" : "#868686") + ";\"></i>"
                + "</a>";
            return f;
        }

        function InitTable() {
            $('#tbExpertVote').bootstrapTable('destroy');
            window.operateEvents = {
                'click .export': function (e, value, row, index) {
                    ;
                }
            };
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: { "Action": "GetExpertVoteList", "PrizeID": $("#txtPrizeID").val() },
                success: function (data) {
                    if (data != "") {
                        if (data == "暂无奖项!" || data == "投票未开始或已经结束!") {
                            ShowMessag(data);
                        }
                        else {
                            var Row = JSON.parse(data);
                            $("#divLimit").empty();
                            $("#divVoted").empty();
                            $("#divRemain").empty();

                            // 奖项名额
                            var Limit = (Row[0].FirstPrize == null ? "" : "一等奖：<span style=\"color:red;\"><b>" + Row[0].FirstPrize + "</b></span>")
                                + (Row[0].SecondPrize == null ? "" : "二等奖：<span style=\"color:red;\"><b>" + Row[0].SecondPrize + "</b></span> ")
                                + (Row[0].ThirdPrize == null ? "" : "三等奖：<span style=\"color:red;\"><b>" + Row[0].ThirdPrize + "</b></span> ")
                                + (Row[0].FirstPrize == null ? "<span style=\"color:red;\"><b>" + Row[0].AwardCount + "</b></span>" : "");
                            $("#divLimit").append(Limit);

                            // 已投票数量
                            var Voted = (Row[0].FirstPrize == null ? "" : "一等奖：<span style=\"color:red;\"><b>" + Row[2].FirstPrize + "</b></span>")
                                + (Row[0].SecondPrize == null ? "" : "二等奖：<span style=\"color:red;\"><b>" + Row[2].SecondPrize + "</b></span> ")
                                + (Row[0].ThirdPrize == null ? "" : "三等奖：<span style=\"color:red;\"><b>" + Row[2].ThirdPrize + "</b></span>")
                                + (Row[0].FirstPrize == null ? "<span style=\"color:red;\"><b>" + Row[2].Recommended + "</b></span>" : "");
                            $("#divVoted").append(Voted);

                            // 未投票数量
                            var Remain = (Row[0].FirstPrize == null ? "" : "一等奖：<span style=\"color:red;\"><b>" + Row[3].FirstPrize + "</b></span>")
                                + (Row[0].SecondPrize == null ? "" : "二等奖：<span style=\"color:red;\"><b>" + Row[3].SecondPrize + "</b></span>")
                                + (Row[0].ThirdPrize == null ? "" : "三等奖：<span style=\"color:red;\"><b>" + Row[3].ThirdPrize + "</b></span>")
                                + (Row[0].FirstPrize == null ? "<span style=\"color:red;\"><b>" + (Row[3].Recommended == null ? Row[0].AwardCount : Row[3].Recommended) + "</b></span>" : "");
                            $("#divRemain").append(Remain);

                            var option = {
                                toolbar: '#toolbar',                //工具按钮用哪个容器
                                striped: true,                      //是否显示行间隔色
                                showRefresh: false,                  //是否显示刷新按钮
                                minimumCountColumns: 1,             //最少允许的列数
                                sidePagination: "client",
                                uniqueId: "DeclarationID",            //每一行的唯一标识，一般为主键列
                                columns: [
                                    { field: 'DeclarationName', title: '项目名称', align: 'center', valign: 'middle' },
                                    { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                    { field: 'FirstPrize', title: '一等奖', align: 'center', valign: 'middle', events: operateEvents, formatter: VoteFormatter },
                                    { field: 'SecondPrize', title: '二等奖', align: 'center', valign: 'middle', events: operateEvents, formatter: VoteFormatter },
                                    { field: 'ThirdPrize', title: '三等奖', align: 'center', valign: 'middle', events: operateEvents, formatter: VoteFormatter },
                                    { field: 'Recommended', title: '推荐', align: 'center', valign: 'middle', events: operateEvents, formatter: VoteFormatter },
                                    { field: 'NotRecommended', title: '不推荐', align: 'center', valign: 'middle', events: operateEvents, formatter: VoteFormatter },
                                    { field: 'SlowRating', title: '缓评', align: 'center', valign: 'middle', events: operateEvents, formatter: VoteFormatter },
                                    { field: 'TurnOut', title: '转出', align: 'center', valign: 'middle', events: operateEvents, formatter: VoteFormatter }
                                ]
                            };
                            if (Row[0].PrizeTypeCode == "0302" || Row[0].PrizeTypeCode == "0303" || (Row[0].VoteType = "2202" && Row[0]. )) {
                                option.columns.splice(2, 3);
                            }
                            else {
                                option.columns.splice(5, 1);
                            }
                            option.data = Row[1];
                            $('#tbExpertVote').bootstrapTable(option);

                            RowColor();
                        }
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbExpertVote'));
                    }
                }
            });
        }

        function getIdSelections() {
            return $.map($('#tbExpertVote').bootstrapTable('getData'), function (data) {
                return data;
            });
        }

        //给已经投过票的行变颜色
        function RowColor() {
            if ($('#tbExpertVote tbody tr').length > 0 && $('#tbExpertVote tbody tr td').text() != "没有找到匹配的记录") {
                for (var i = 0; i < $('#tbExpertVote tbody tr').length; i++) {
                    var IsSubmit = getIdSelections()[i].IsSubmit;
                    if (IsSubmit != null) {
                        $('#tbExpertVote').find("tr").eq(i + 1).find("td").attr("style", "background-color:#DBF1EF;")
                    }
                }
            }
        }

    </script>
</asp:Content>
