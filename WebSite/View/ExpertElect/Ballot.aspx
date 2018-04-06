<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="Ballot.aspx.cs" Inherits="Evaluation.View.ExpertElect.Ballot" %>
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
                width:200px;
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
            top:0;
            right:0;
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
        <div style="width:100%; border:1px solid #ccc;border-radius:5px;padding:6px 0 6px 10px;margin-bottom:15px;">
            <table class="tb_tr_td_padding_5">
                <tr>
                    <td style="padding-left:19px;">当前奖项：</td>  
                    <td><b><asp:Label ID="labPrizeName" runat="server" Text="Label"></asp:Label></b></td>
                    <td style="padding-left:19px;"><div id="divLimit"></div></td>
                </tr>
                <tr>
                    <td style="padding-left:19px;">已投票数量：</td>
                    <td colspan="2"><div id="divVoted"></div><div id="divRemain"></div></td>
                </tr>
            </table>
       </div>
        <div>
            <table id="tbExpertVote"></table>
            <%--<div id="divPagination" style="overflow: hidden; margin-top: 10px; margin-bottom: 130px;"></div>--%>
        </div>
        <div style="margin:20px auto;">未投票项目全部投：
           <asp:DropDownList runat="server" ClientIDMode="Static"  ID="ddlVoteType">
                        <asp:ListItem Selected="False" Text="一等奖" Value="2301" VoteCode='0601' LevelCode='0401'></asp:ListItem>
                        <asp:ListItem Selected="False" Text="二等奖" Value="2302" VoteCode='0601' LevelCode='0402' ></asp:ListItem>
                        <asp:ListItem Selected="False" Text="三等奖" Value="2303" VoteCode='0601' LevelCode='0403' ></asp:ListItem>
                        <asp:ListItem Selected="False" Text="推荐" Value="2304" VoteCode='0601' LevelCode='' ></asp:ListItem>
                        <asp:ListItem Selected="False" Text="不推荐" Value="2305" VoteCode='0602' LevelCode='' ></asp:ListItem>
                        <asp:ListItem Selected="False" Text="缓评" Value="2306" VoteCode='0603' LevelCode='' ></asp:ListItem>
                        <asp:ListItem Selected="False" Text="转出" Value="2307" VoteCode='0604' LevelCode='' ></asp:ListItem>
             </asp:DropDownList>  
            <input type="button" name="name" class="btnt" id="btnVoteAll" value="选  择 " style="margin-left:20px;"/>  
        </div>
        <div style="width:200px;margin:30px auto;">
            <input type="button" class="btnt" id="btnSubmit" value="提 &nbsp;交" />
            <input type="button" class="btnt" id="btnBack" value="返 &nbsp;回" />
        </div>
    </div>
    <script>
        var Row;
        $(function () {
            $('#ddlVoteType').ui_choose();
            $('.ui-choose li').hide();

            $("#txtPrizeID").hide();
            $("#divRemain").hide();

            InitTable();
        });

        $("#btnVoteAll").click(function () {
            var e = $("#ddlVoteType").find("option:selected");
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "BatchBallot",
                    "PrizeID": $("#txtPrizeID").val(),
                    "VoteCode": e.attr("votecode"),
                    "LevelCode": e.attr("levelcode")
                },
                success: function (data) {
                    ShowMessag(data);
                    InitTable();
                }
            });
        });

        $("#btnBack").click(function () {
            window.location = "../../View/ExpertElect/ExpertVote.aspx";
        });

        $("#btnSubmit").click(function () {
            if ($('#tbExpertVote tbody tr').length > 0 && $('#tbExpertVote tbody tr td').text() != "没有找到匹配的记录") {
                $.ajax({
                    url: '../Mutual/ExpertElect.ashx',
                    type: "post",
                    data: {
                        "Action": "SubmitVote",
                        "PrizeID": $("#txtPrizeID").val()
                    },
                    success: function (data) {
                        ShowMessag(data);
                        if (data == "提交成功!") {
                            $("#spanIsSubmit").text("已提交");
                        }                        
                    }
                });
            }
            else {
                ShowMessag("没有数据!");
            }
        });

        function onVote(e, row) {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                dataType: "json",
                data: {
                    "Action": "Ballot",
                    "DeclarationID": row.DeclarationID,
                    "VoteCode": e.attr("votecode"),
                    "LevelCode": e.attr("LevelCode"),
                    "PrizeID": Row[0].PrizeID,
                    "MultipleVoteRound": Row[0].MultipleVoteRound
                },
                success: function (data) {
                    if (data.length == 1) {
                        ShowMessag(data[0]);
                        return;
                    }
                    SetVoteInfo(data);
                    e.closest('tr').find('a').children('.fa').css('color', '#868686');
                    e.children().attr("style", "color:#FFA200");
                }
            });
        }

        function SetVoteInfo(Row) {
            $("#divLimit").empty();
            $("#divVoted").empty();
            $("#divRemain").empty();

            if (Row[0].PrizeTypeCode == "0302" || Row[0].PrizeTypeCode == "0303" || Row[0].VoteType == "2201"
                || (Row[0].VoteType == "2202" && Row[0].MultipleVoteRound == 2)) {
                // 奖项名额
                var Limit = ((Row[0].PrizeTypeCode == "0301" || Row[0].PrizeTypeCode == "0304")
                    ? "<span>本奖项投票方式：<b>" + Row[0].VoteTypeText + "</b></span>" : "")
                    + (Row[0].VoteType != "2201" ? "<span style=\"padding-left:19px;\"><b>第" + Row[0].MultipleVoteRound + "轮投票</b></span>" : "")
                    + "<span style=\"padding-left:19px;\">推荐名额："
                    + (Row[0].FirstPrize == null ? "" : "一等奖：<span style=\"padding-right:19px;color:red;\"><b>" + Row[0].FirstPrize + "</b></span>")
                    + (Row[0].SecondPrize == null ? "" : "二等奖：<span style=\"padding-right:19px;color:red;\"><b>" + Row[0].SecondPrize + "</b></span> ")
                    + (Row[0].ThirdPrize == null ? "" : "三等奖：<span style=\"padding-right:19px;color:red;\"><b>" + Row[0].ThirdPrize + "</b></span> ")
                    + (Row[0].FirstPrize == null ? "<span style=\"color:red;\"><b>" + Row[0].AwardCount + "</b></span>" : "")
                    + "</span>";
                $("#divLimit").append(Limit);

                // 已投票数量
                var Voted = (Row[0].FirstPrize == null ? "" : "一等奖：<span style=\"padding-right:19px;color:red;\" id='spanVoteFirstPrize'><b>" + Row[2].FirstPrize + "</b></span>")
                    + (Row[0].SecondPrize == null ? "" : "二等奖：<span style=\"padding-right:19px;color:red;\" id='spanVoteSecondPrize'><b>" + Row[2].SecondPrize + "</b></span> ")
                    + (Row[0].ThirdPrize == null ? "" : "三等奖：<span style=\"padding-right:19px;color:red;\" id='spanVoteThirdPrize'><b>" + Row[2].ThirdPrize + "</b></span>")
                    + (Row[0].FirstPrize == null ? "推荐：<span style=\"padding-right:19px;color:red;\" id='spanVoteRecommended'><b>" + Row[2].Recommended + "</b></span>" : "")
                    + (Row[0].VoteType == "2202" ? "" : "不推荐：<span style=\"padding-right:19px;color:red;\" id='spanVoteNotRecommended'><b>"
                    + Row[2].NotRecommended + "</b></span>缓评：<span style=\"padding-right:19px;color:red;\" id='spanVoteSlowRating'><b>"
                    + Row[2].SlowRating + "</b></span>转出：<span style=\"padding-right:19px;color:red;\" id='spanVoteTurnOut'><b>"
                    + Row[2].TurnOut + "</b></span>")
                    + "<span>投票状态：</span>"
                    + "<span style=\"color:red;\" id=\"spanIsSubmit\"><b>" + (Row[1][0].IsSubmit == true ? "已提交" : "未提交") + "</b></span>";

                $("#divVoted").append(Voted);

                // 未投票数量
                var Remain = "未投票数量：<span style=\"padding-left:19px;\">"
                    + (Row[0].FirstPrize == null ? "" : "一等奖：<span style=\"padding-right:19px;color:red;\" id='spanRemainFirstPrize'><b>" + Row[3].FirstPrize + "</b></span>")
                    + (Row[0].SecondPrize == null ? "" : "二等奖：<span style=\"padding-right:19px;color:red;\" id='spanRemainSecondPrize'><b>" + Row[3].SecondPrize + "</b></span>")
                    + (Row[0].ThirdPrize == null ? "" : "三等奖：<span style=\"padding-right:19px;color:red;\" id='spanRemainThirdPrize'><b>" + Row[3].ThirdPrize + "</b></span>")
                    + (Row[0].FirstPrize == null ? "<span style=\"color:red;\" id='spanRemainRecommended'><b>"
                    + (Row[3].Recommended == null ? Row[0].AwardCount : Row[3].Recommended) + "</b></span>" : "")
                    + "</span>";
                $("#divRemain").append(Remain);
            } else if ((Row[0].VoteType == "2202" || Row[0].VoteType == "2203") && Row[0].MultipleVoteRound == 1) {
                // 奖项名额
                var Limit = "<span>本奖项投票方式：<b>" + Row[0].VoteTypeText + "</b></span>"
                    + "<span style=\"padding-left:19px;\"><b>第" + Row[0].MultipleVoteRound + "轮</b>投票</span>"
                    + "<span style=\"padding-left:19px;\">推荐名额：<span style=\"color:red;\"><b>" + Row[0].AwardCount + "</b></span></span>";
                $("#divLimit").append(Limit);

                // 已投票数量
                var Voted = "<span style=\"padding-right:19px;color:red;\" id='spanVoteRecommended'>推荐：<b>" + Row[2].Recommended + "</b></span>"
                    + "<span style=\"padding-right:19px;color:red;\" id='spanVoteNotRecommended'>不推荐：<b>" + Row[2].NotRecommended + "</b></span>"
                    + "<span style=\"padding-right:19px;color:red;\" id='spanVoteSlowRating'>缓评：<b>" + Row[2].SlowRating + "</b></span>"
                    + "<span style=\"padding-right:19px;color:red;\" id='spanVoteTurnOut'>转出：<b>" + Row[2].TurnOut + "</b></span>"
                    + "<span>投票状态：</span>"
                    + "<span style=\"color:red;\" id=\"spanIsSubmit\"><b>" + (Row[1][0].IsSubmit == true ? "已提交" : "未提交") + "</b></span>";

                $("#divVoted").append(Voted);

                // 未投票数量
                var Remain = "未投票数量：<span style=\"padding-left:19px;color:red;\" id='spanRemainRecommended'><b>"
                    + (Row[3].Recommended == null ? Row[0].AwardCount : Row[3].Recommended) + "</b></span>";
                $("#divRemain").append(Remain);
            } else if (Row[0].VoteType == "2203" && Row[0].MultipleVoteRound == 2) {
                // 奖项名额
                var Limit = "<span>本奖项投票方式：<b>" + Row[0].VoteTypeText + "</b></span>"
                     + "<span style=\"padding-left:19px;\"><b>第" + Row[0].MultipleVoteRound + "轮</b>投票</span>"
                     + "<span style=\"padding-left:19px;\">一等奖、二等奖名额：<span style=\"color:red;\"><b>"
                     + (Row[0].FirstPrize + Row[0].SecondPrize)
                     + "</b></span></span>";
                $("#divLimit").append(Limit);

                // 已投票数量
                var Voted = "一等奖、二等奖：<span style=\"padding-right:19px;color:red;\" id='spanVoteRecommended'><b>" + Row[2].Recommended + "</b></span>"
                    + "三等奖：<span style=\"padding-right:19px;color:red;\" id='spanVoteNotRecommended'><b>" + Row[2].NotRecommended + "</b></span>"
                    + "<span>投票状态：</span>"
                    + "<span style=\"color:red;\" id=\"spanIsSubmit\"><b>" + (Row[1][0].IsSubmit == true ? "已提交" : "未提交") + "</b></span>";
                ;
                $("#divVoted").append(Voted);

                // 未投票数量
                var Remain = "未投票数量：<span style=\"padding-left:19px;color:red;\" id='spanRemainRecommended'><b>"
                    + (Row[3].Recommended == null ? (Row[0].FirstPrize + Row[0].SecondPrize) : Row[3].Recommended)
                    + "</b></span>";
                $("#divRemain").append(Remain);
            } else {
                // 奖项名额
                var Limit = "<span>本奖项投票方式：<b>" + Row[0].VoteTypeText + "</b></span>"
                     + "<span style=\"padding-left:19px;\"><b>第" + Row[0].MultipleVoteRound + "轮</b>投票</span>"
                     + "<span style=\"padding-left:19px;\">一等奖名额：<span style=\"color:red;\"><b>" + Row[0].FirstPrize + "</b></span></span>";
                $("#divLimit").append(Limit);

                // 已投票数量
                var Voted = "一等奖：<span style=\"padding-right:19px;color:red;\" id='spanVoteRecommended'><b>" + Row[2].Recommended + "</b></span>"
                    + "二等奖：<span style=\"padding-right:19px;color:red;\" id='spanVoteNotRecommended'><b>" + Row[2].NotRecommended + "</b></span>"
                    + "<span>投票状态：</span>"
                    + "<span style=\"color:red;\" id=\"spanIsSubmit\"><b>" + (Row[1][0].IsSubmit == true ? "已提交" : "未提交") + "</b></span>"
                    + "</span>";

                $("#divVoted").append(Voted);

                // 未投票数量
                var Remain = "未投票数量：<span style=\"padding-left:19px;color:red;\" id='spanRemainRecommended'><b>"
                    + (Row[3].Recommended == null ? Row[0].FirstPrize : Row[3].Recommended)
                    + "</b></span>";
                $("#divRemain").append(Remain);
            }
        }

        function InitTable() {
            $('#tbExpertVote').bootstrapTable('destroy');

            window.operateEvents = {
                'click .export': function (e, value, row, index) {
                    onVote($(e.currentTarget), row);
                }
            };
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "GetExpertVoteList",
                    "PrizeID": $("#txtPrizeID").val()
                },
                success: function (data) {
                    if (data != "") {
                        if (data == "暂无奖项!" || data == "投票未开始或已经结束!") {
                            ShowMessag(data);
                        }
                        else {
                            Row = JSON.parse(data);
                            SetVoteInfo(Row);

                            var option = {
                                toolbar: '#toolbar',                //工具按钮用哪个容器
                                striped: true,                      //是否显示行间隔色
                                showRefresh: false,                  //是否显示刷新按钮
                                minimumCountColumns: 1,             //最少允许的列数
                                sidePagination: "client",
                                uniqueId: "DeclarationID",            //每一行的唯一标识，一般为主键列
                                columns: [
                                    {
                                        title: '序号',//标题  
                                        formatter: function (value, row, index) {
                                            return index + 1;
                                        }
                                    },
                                    //{ field: 'TypeEx', title: '分类编号', align: 'center', valign: 'middle' },
                                    {
                                        field: 'DeclarationName', title: '项目名称', align: 'left', valign: 'middle',
                                        cellStyle: function () { return { css: { "text-align": "left" } } },
                                        events: operateEvents,
                                        formatter: function (value, row, index) {
                                            var DeclarationID = row.DeclarationID;
                                            var Situation = row.DeclarationStatus;
                                            var f = "<a href=\../../view/Declaration/Declaration.aspx?DeclarationID=" + DeclarationID + "&Situation='ExpertReview'\" >"
                                                + value;
                                            + "</a>";
                                            return f;
                                        }
                                    },
                                    { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                    {
                                        field: 'FirstPrize', title: '一等奖', align: 'center', valign: 'middle', events: operateEvents,
                                        formatter: function (value, row, index) {
                                            var f = "<a class=\"export\" href=\"javascript:void(0);\" title=\"一等奖\" "
                                                + "VoteCode='0601' LevelCode='0401' >"
                                                + "<i class=\"fa fa-star\" aria-hidden=\"true\" style=\"color:"
                                                + (value == true ? "#FFA200" : "#868686") + ";\"></i>"
                                                + "</a>";
                                            return f;
                                        }
                                    },
                                    {
                                        field: 'SecondPrize', title: '二等奖', align: 'center', valign: 'middle', events: operateEvents,
                                        formatter: function (value, row, index) {
                                            var f = "<a class=\"export\" href=\"javascript:void(0);\" title=\"二等奖\" "
                                                + "VoteCode='0601' LevelCode='0402' >"
                                                + "<i class=\"fa fa-star\" aria-hidden=\"true\" style=\"color:"
                                                + (value == true ? "#FFA200" : "#868686") + ";\"></i>"
                                                + "</a>";
                                            return f;
                                        }
                                    },
                                    {
                                        field: 'ThirdPrize', title: '三等奖', align: 'center', valign: 'middle', events: operateEvents,
                                        formatter: function (value, row, index) {
                                            var f = "<a class=\"export\" href=\"javascript:void(0);\" title=\"三等奖\" "
                                                + "VoteCode='0601' LevelCode='0403' >"
                                                + "<i class=\"fa fa-star\" aria-hidden=\"true\" style=\"color:"
                                                + (value == true ? "#FFA200" : "#868686") + ";\"></i>"
                                                + "</a>";
                                            return f;
                                        }
                                    },
                                    {
                                        field: 'Recommended', title: '推荐', align: 'center', valign: 'middle', events: operateEvents,
                                        formatter: function (value, row, index) {
                                            var f = "<a class=\"export\" href=\"javascript:void(0);\" title=\"推荐\" "
                                                + "VoteCode='0601' LevelCode='' >"
                                                + "<i class=\"fa fa-star\" aria-hidden=\"true\" style=\"color:"
                                                + (value == true ? "#FFA200" : "#868686") + ";\"></i>"
                                                + "</a>";
                                            return f;
                                        }
                                    },
                                    {
                                        field: 'NotRecommended', title: '不推荐', align: 'center', valign: 'middle', events: operateEvents,
                                        formatter: function (value, row, index) {
                                            var f = "<a class=\"export\" href=\"javascript:void(0);\" title=\"不推荐\" "
                                                + "VoteCode='0602' LevelCode='' >"
                                                + "<i class=\"fa fa-star\" aria-hidden=\"true\" style=\"color:"
                                                + (value == true ? "#FFA200" : "#868686") + ";\"></i>"
                                                + "</a>";
                                            return f;
                                        }
                                    },
                                    {
                                        field: 'SlowRating', title: '缓评', align: 'center', valign: 'middle', events: operateEvents,
                                        formatter: function (value, row, index) {
                                            var f = "<a class=\"export\" href=\"javascript:void(0);\" title=\"缓评\" "
                                                + "VoteCode='0603' LevelCode='' >"
                                                + "<i class=\"fa fa-star\" aria-hidden=\"true\" style=\"color:"
                                                + (value == true ? "#FFA200" : "#868686") + ";\"></i>"
                                                + "</a>";
                                            return f;
                                        }
                                    },
                                    {
                                        field: 'TurnOut', title: '转出', align: 'center', valign: 'middle', events: operateEvents,
                                        formatter: function (value, row, index) {
                                            var f = "<a class=\"export\" href=\"javascript:void(0);\" title=\"转出\" "
                                                + "VoteCode='0604' LevelCode='' >"
                                                + "<i class=\"fa fa-star\" aria-hidden=\"true\" style=\"color:"
                                                + (value == true ? "#FFA200" : "#868686") + ";\"></i>"
                                                + "</a>";
                                            return f;
                                        }
                                    }
                                ]
                            };

                            var code = $('#ddlVoteType').val();

                            if (Row[0].PrizeTypeCode == "0302" || Row[0].PrizeTypeCode == "0303"
                                || ((Row[0].VoteType == "2202" || Row[0].VoteType == "2203") && Row[0].MultipleVoteRound == 1)) {
                                // 显示 推荐不推荐缓评转出
                                option.columns.splice(3, 3);

                                $('.ui-choose li:gt(2)').show();

                                if (code != "2304" && code != "2305" && code != "2306" && code != "2307") {
                                    $('.ui-choose li:eq(3)').addClass("selected");
                                    $('#ddlVoteType option:eq(3)').attr("Selected", "True");
                                }
                            }
                            else if (Row[0].VoteType == "2202" && Row[0].MultipleVoteRound == 2) {
                                option.columns.splice(6, 1);
                                option.columns.splice(option.columns.length - 3, 3);

                                $('.ui-choose li').show();
                                $('.ui-choose li:gt(2)').hide();

                                if (code != "2301" && code != "2302" && code != "2303") {
                                    $('#ddlVoteType option:eq(0)').attr("Selected", "True");
                                    $('.ui-choose li:eq(0)').addClass("selected");
                                }
                            } else if (Row[0].VoteType == "2201" && (Row[0].PrizeTypeCode == "0301" || Row[0].PrizeTypeCode == "0304")) {
                                option.columns.splice(6, 1);

                                $('.ui-choose li').show();
                                $('.ui-choose li:eq(3)').hide();

                                if (code != "2301" && code != "2302" && code != "2303" && code != "2305" && code != "2306" && code != "2307") {
                                    $('#ddlVoteType option:eq(0)').attr("Selected", "True");
                                    $('.ui-choose li:eq(0)').addClass("selected");
                                }
                            }
                            else {
                                // 显示推荐不推荐
                                option.columns.splice(3, 3);
                                option.columns.splice(option.columns.length - 2, 2);

                                $('.ui-choose li:eq(3)').show();
                                $('.ui-choose li:eq(4)').show();

                                if (code != "2304" && code != "2305") {
                                    $('#ddlVoteType option:eq(3)').attr("Selected", "True");
                                    $('.ui-choose li:eq(3)').addClass("selected");
                                }                                

                                if (Row[0].MultipleVoteRound == 2) {
                                    option.columns[2].title = "一等奖、二等奖";
                                    option.columns[3].title = "三等奖";
                                    $('.ui-choose li:eq(3)').text("一等奖、二等奖")
                                    $('.ui-choose li:eq(4)').text("三等奖");
                                } else {
                                    option.columns[2].title = "一等奖";
                                    option.columns[3].title = "二等奖";
                                    $('.ui-choose li:eq(3)').text("一等奖")
                                    $('.ui-choose li:eq(4)').text("二等奖");
                                }
                            }

                            option.data = Row[1];
                            $('#tbExpertVote').bootstrapTable(option);

                            //RowColor();
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
                        $('#tbExpertVote').find("tr").eq(i + 1).find("td").css('background-color', '#DBF1EF')
                    }
                }
            }           
        }

    </script>

</asp:Content>
