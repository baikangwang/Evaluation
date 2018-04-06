<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="NewRevote.aspx.cs" Inherits="Evaluation.View.ExpertElect.NewRevote" %>
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
          table[id^='tbRevoteGroup'] input[type="radio"] {
            width: 25px;
            height: 25px;
            position: relative;           
            left: 12px;
            top: 3px;
            z-index:10;
            opacity:0;
            cursor:pointer;
        }
        table[id^='tbRevoteGroup'] .fa {
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
            <a href="#">等票复投</a>
        </li>
    </ul>
    <div class="box">
        <div style="width:100%; border:1px solid #ccc;border-radius:5px;padding:6px 0 6px 10px;margin-bottom:15px;">
            <table class="tb_tr_td_padding_5">
                <tr>
                    <td style="padding-left:19px;">当前奖项：</td>  
                    <td><b><asp:Label ID="labPrizeName" runat="server" Text="Label"></asp:Label></b></td>
                    <td style="padding-left:19px"><asp:Label ID="lblRevoteRound" runat="server" Text="Label"></asp:Label></td>
                </tr>
            </table>
       </div>
    <% foreach (int gId in this.GroupIds){%>
        <div style="width:100%; border:1px solid #ccc;border-radius:5px;padding:6px 0 6px 10px;margin-bottom:15px;">
            <table class="tb_tr_td_padding_5">
                <tr>
                    <td colspan="2" style="padding-left:19px;"><div id="divLimit<%=gId%>"></div></td>
                </tr>
                <tr>
                    <td style="padding-left:19px;">已投票数量：</td>
                    <td><div id="divVoted<%=gId%>"></div></td>
                </tr>
            </table>
       </div>
        <div>
            <table id="tbRevoteGroup<%=gId%>"></table>
        </div>
    <% } %>
        <div style="margin:20px auto;">未投票项目全部投：
           <asp:DropDownList runat="server" ClientIDMode="Static"  ID="ddlVoteType">
                <asp:ListItem Selected="False" Text="推荐" recommended='1' notrecommended='0' ></asp:ListItem>
                <asp:ListItem Selected="True" Text="不推荐" recommended='0' notrecommended='1' ></asp:ListItem>
             </asp:DropDownList>  
            <input type="button" name="name" class="btnt" id="bSubmit" value="投  票 " style="margin-left:20px;"/>  
        </div>
        <div style="width:200px;margin:30px auto;">
            <input type="button" class="btnt" id="btnSubmit" value="提 &nbsp;交" />
            <input type="button" class="btnt" id="btnBack" value="返 &nbsp;回" />
        </div>
    </div>
    <script>
        var groupIds=[];
        $(function () {
            $('#ddlVoteType').ui_choose();
            $("#txtPrizeID").hide();

            InitTable();
        });

        $("#btnBack").click(function () {
            //window.location = "../../View/ExpertElect/ExpertVote.aspx";
            window.history.go(-1);
        });

        $("#btnSubmit").click(function () {
            var valid = true;
            for (var i = 0; i < groupIds.length; i++) {
                valid = valid && $('#tbRevoteGroup' + groupIds[i] + ' tbody tr').length > 0
                    && $('#tbRevoteGroup' + groupIds[i] + ' tbody tr td').text() !== "没有找到匹配的记录";
            }

            if (valid) {
                $.ajax({
                    url: '../Mutual/ExpertElect.ashx',
                    type: "post",
                    data: {
                        "Action": "SubmitRevotingVote",
                        "PrizeID": $("#txtPrizeID").val()
                    },
                    success: function (data) {
                        ShowMessag(data);
                        if (data === "提交成功!") {
                            $("span[id^='spanIsSubmit'").text("已提交");
                        }                        
                    }
                });
            }
            else {
                ShowMessag("没有数据!");
            }
        });

        $("#bSubmit").click(function () {
            var e = $("#ddlVoteType").find("option:selected");
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "BatchRevotingVote",
                    "PrizeID": $("#txtPrizeID").val(),
                    "Recommended": e.attr("recommended"),
                    "NotRecommended": e.attr("notrecommended")
                },
                success: function (data) {
                    ShowMessag(data);
                    InitTable();
                }
            });
        });

        function onVote(e, row) {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                dataType: "json",
                data: {
                    "Action": "RevotingVote",
                    "DeclarationID": row.DeclarationId,
                    "RevoteGroupId": row.RevoteGroupId,
                    "RevoteRecommended": e.attr("recommended"),
                    "NotRevoteRecommended": e.attr("notrecommended"),
                    "PrizeId": $("#txtPrizeID").val()
                },
                success: function (data) {
                    console.log(data);
                    if (!data.hasOwnProperty("Views")) {
                        ShowMessag(data.Message);
                        return;
                    }
                    var info;
                    for (var i = 0; i < data.Views.length; i++) {
                        if (data.Views[i].RevoteGroupId === row.RevoteGroupId) {
                            info = data.Views[i].Info;
                            break;
                        }
                    }
                    if (info) {
                        SetVoteInfo(info,row.RevoteGroupId);
                    }
                    e.closest('tr').find('a').children('.fa').css('color', '#868686');
                    e.children().attr("style", "color:#FFA200");
                }
            });
        }

        function SetVoteInfo(info,gId) {
            $("#divLimit" + gId).empty();
            $("#divVoted" + gId).empty();

            var awards = info.Awards;
            // 单次投票
            // 奖项名额
            var limit = "<span style=\"padding-left:19px;\">推荐票数：" + info.Recommended + "</b></span>";
            limit += "<span style=\"padding-left:19px;\">推荐名额：";
            for (var i = 0; i < awards.length; i++) {
                var award = awards[i];
                limit += award.AwardLabel + ": <span style=\"padding-right:19px;color:red;\"><b>" + award.Number + "</b></span>";
            }
            limit += "</span>";
            $("#divLimit" + gId).append(limit);

            // 已投票数量
            var voted = "推荐：<span style=\"padding-right:19px;color:red;\" id='spanVoteRecommended" + gId + "'><b>" + info.Voted + "</b></span>";
            voted += "<span>投票状态：</span>";
            voted += "<span style=\"color:red;\" id=\"spanIsSubmit" + gId + "\"><b>" + (info.IsSubmit === true ? "已提交" : "未提交") + "</b></span>";

            $("#divVoted" + gId).append(voted);
        }

        function getVotingFieldLabels(awards) {
            var labels = {
                recommended: '推荐',
                notRecommended:'不推荐'
            };

            if (awards.length >= 3) {
                labels.recommended = awards[0].AwardLabel + '/' + awards[1].AwardLabel;
            }else if (awards.length >= 1) {
                labels.recommended = awards[0].AwardLabel;
            }

            return labels;
        }

        function InitTable() {
            $('table[id^="tbRevoteGroup"]').bootstrapTable('destroy');

            window.operateEvents = {
                'click .export': function (e, value, row, index) {
                    onVote($(e.currentTarget), row);
                }
            };
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "GetRevoteGroupViews",
                    "PrizeID": $("#txtPrizeID").val()
                },
                success: function (data) {
                    if (data !== "") {
                        if (data === "暂无奖项!" || data === "投票未开始或已经结束!") {
                            ShowMessag(data);
                        }
                        else {
                            var revotingGroupViews = JSON.parse(data);

                            for (var i = 0; i < revotingGroupViews.length; i++) {
                                var view = revotingGroupViews[i];

                                var gId = view.RevoteGroupId;
                                groupIds.push(gId);

                                SetVoteInfo(view.Info,gId);

                                var labels= getVotingFieldLabels(view.Info.Awards);

                                var option = {
                                    toolbar: '#toolbar',                //工具按钮用哪个容器
                                    striped: true,                      //是否显示行间隔色
                                    showRefresh: false,                  //是否显示刷新按钮
                                    minimumCountColumns: 1,             //最少允许的列数
                                    sidePagination: "client",
                                    uniqueId: "DeclarationID",            //每一行的唯一标识，一般为主键列
                                    columns: [
                                        //{ field: 'TypeEx', title: '分类编号', align: 'center', valign: 'middle' },
                                        {
                                            field: 'DeclarationName', title: '项目名称', align: 'left', valign: 'middle',
                                            cellStyle: function () { return { css: { "text-align": "left" } } },
                                            events: operateEvents,
                                            formatter: function (value, row, index) {
                                                var DeclarationID = row.DeclarationID;
                                                var f = "<a href=\../../view/Declaration/Declaration.aspx?DeclarationID=" + DeclarationID + "&Situation='ExpertReview'\" >"
                                                    + value;
                                                + "</a>";
                                                return f;
                                            }
                                        },
                                        { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                        {
                                            field: 'RevoteRecommended', title: labels.recommended, align: 'center', valign: 'middle', events: operateEvents,
                                            formatter: function (value, row, index) {
                                                var f = "<a class=\"export\" href=\"javascript:void(0);\" title=\"推荐\" "
                                                    + "recommended='1' notrecommended='0'>"
                                                    + "<i class=\"fa fa-star\" aria-hidden=\"true\" style=\"color:"
                                                    + (value === 1 ? "#FFA200" : "#868686") + ";\"></i>"
                                                    + "</a>";
                                                return f;
                                            }
                                        },
                                        {
                                            field: 'RevoteNotRecommended', title: labels.notRecommended, align: 'center', valign: 'middle', events: operateEvents,
                                            formatter: function (value, row, index) {
                                                var f = "<a class=\"export\" href=\"javascript:void(0);\" title=\"不推荐\" "
                                                    + "notrecommended='1' recommended='0'>"
                                                    + "<i class=\"fa fa-star\" aria-hidden=\"true\" style=\"color:"
                                                    + (value === 1 ? "#FFA200" : "#868686") + ";\"></i>"
                                                    + "</a>";
                                                return f;
                                            }
                                        }
                                    ]
                                };

                                console.log(view);

                                option.data = view.VotingViews;
                                $('#tbRevoteGroup' + gId).bootstrapTable(option);
                            }
                        }
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbRevoteGroup' + gId));
                    }
                }
            });
        }
    </script>

</asp:Content>
