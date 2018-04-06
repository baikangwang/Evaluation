<%@ Page Title="投票结果确认" Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="VoteResult.aspx.cs" Inherits="Evaluation.View.ActivityManage.VoteResult" %>

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
    <asp:HiddenField runat="server" ClientIDMode="Static" ID="hfPrizeID" />
    <ul class="navs">
        <li class="nav1" id="main" style="float: left; padding-right: 5px;">
            <a href="#">评优管理</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="../ActivityManage/VoteResult.aspx">投票结果确认</a>
        </li>
    </ul>
    <br />
    <div class="col-sm-12">
        <div>
            <div>
                <button type="button" class="btn btn-default" onclick="PreviousRound();">
                    <span class="fa fa-arrow-circle-left" aria-hidden="true"></span>
                    &nbsp;切换到上一轮次
                </button>
                <span  style="padding-left:19px;padding-right:19px;">
                    奖项名称：<label id="lblPrizeName" style="padding-right:19px;">2</label>
                    当前轮次：第<label id="lblRound">8</label>轮
                    <span style="padding-left:19px;">投票状态：<label id="lblIsStop">2</label></span> 
                </span>
                <button type="button" class="btn btn-default" onclick="NextRound();">
                    <span class="fa fa-arrow-circle-right" aria-hidden="true"></span>
                    &nbsp;切换到下一轮次
                </button>
            </div>
            <br />
            <div style="text-wrap:none;">
                <span id="spanMulti">
                    <span style="padding-right:19px;">一等奖名额：<input type="text" style="width:76px;" id="txtFirstPrize" value="5" /></span>
                    <span style="padding-right:19px;">二等奖名额：<input type="text" style="width:76px;" id="txtSecondPrize" value="5" /></span>
                    <span style="padding-right:19px;">三等奖名额：<input type="text" style="width:76px;" id="txtThirdPrize" value="5" /></span>
                </span>
                <span id="spanSingle" style="padding-right:19px;">
                    获奖名额：<input type="text" style="width:76px;" id="txtAwardCount" value="5" /></span>
                <button type="button" class="btn btn-default" onclick="SetAwardCount();">
                    <span class="fa fa-flag" aria-hidden="true"></span>
                    &nbsp;设定获奖名额
                </button>
            </div>
            <div>
                <br />
                <span style="padding-right:19px;">本轮次应选择项目数：<label id="lblAwardCount"></label></span> <span>当前已选择项目数：<label id="lblSelectedCount"></label></span>
            </div>
            <br />
        </div>
        <div id="toolbar" class="btn-group">
            <button type="button" class="btn btn-default" onclick="StopPrizeVote(true)">
                <span class="fa fa-stop" aria-hidden="true"></span>
                &nbsp;停止投票
            </button>
            <button type="button" class="btn btn-default" onclick="onRevote()">
                <span class="fa fa-retweet" aria-hidden="true"></span>
                &nbsp;等票复投
            </button>
            <button type="button" class="btn btn-default" onclick="onReset()">
                <span class="fa fa-calculator" aria-hidden="true"></span>
                &nbsp;重新计算
            </button>
            <asp:Button ID="btnExport" class="btn btn-default" runat="server" ToolTip="导出投票结果"
                OnClick="btnExport_Click" Text="导出投票结果" />
            <button type="button" class="btn btn-default" onclick="SetVoteResult()">
                <span class="fa fa-check-square" aria-hidden="true"></span>
                &nbsp;选择进入下一轮投票的项目
            </button>
            <button type="button" class="btn btn-default" onclick="StopPrizeVote(false)">
                <span class="fa fa-play" aria-hidden="true"></span>
                &nbsp;开始投票
            </button>
        </div>
        <table id="tbResultList"></table>
        <div id="divPagination" style="overflow: hidden;margin-top:10px;padding-bottom:130px; "></div>
    </div>
    <script>
        var checkCnt = 0;
        var ordinal = 0;
        var Row = null;
        var prize = null;

        // 等票复投事件
        function onRevote() {
            var listData = $('#tbResultList').bootstrapTable('getData');

            listData = JSON.stringify(listData);
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "Revote",
                    "data": listData,
                    "PrizeID": $("#hfPrizeID").val()
                },
                success: function (data) {
                    ShowMessag(data);
                }
            });
        }

        function onReset() {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "ResetVoteResult",
                    "PrizeID": $("#hfPrizeID").val(),
                    "MultipleVoteRound": $("#lblRound").text()
                },
                success: function (data) {
                    InitTable();
                }
            });
        }

        //返回综合奖多伦投票的上一轮
        function PreviousRound() {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "StartMultipleVote",
                    "btnValue": "返回上一轮",
                    "PrizeID": $("#hfPrizeID").val()
                },
                success: function (data) {
                    if (data.length > 0) {
                        ShowMessag(data);
                    } else {
                        $("#lblRound").text(data);
                    }
                }
            });
        }

        //开启综合奖多伦投票的下一轮
        function NextRound() {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "StartMultipleVote",
                    "btnValue": "开启下一轮",
                    "PrizeID": $("#hfPrizeID").val()
                },
                success: function (data) {                   
                    if (data.length > 0) {
                        ShowMessag(data);
                    }
                    else {
                        $("#lblRound").text(data);
                    }
                }
            });
        }

        function SetAwardCount() {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "SetAwardCount",
                    "AwardCount": $("#txtAwardCount").val(),
                    "FirstPrize": $("#txtFirstPrize").val(),
                    "SecondPrize": $("#txtSecondPrize").val(),
                    "ThirdPrize": $("#txtThirdPrize").val(),
                    "btnValue": $("#btnNext").val(),
                    "PrizeID": $("#hfPrizeID").val()
                },
                success: function (data) {
                    if (data.length > 0) {
                        ShowMessag(data);
                    }
                }
            });
        }

        function SetVoteResult() {
            if ($("#lblAwardCount").text() != $("#lblSelectedCount").text())
            {
                ShowMessag("当前选择的项目数量错误，请核对后再提交！");
            } else {
                var DeclarationID = $.map($('#tbResultList').bootstrapTable('getSelections'), function (row) {
                    return row.DeclarationID
                });

                $.ajax({
                    url: '../Mutual/ExpertElect.ashx',
                    type: "post",
                    dataType: "json",
                    data: {
                        "Action": "SetVoteResult",
                        "PrizeID": $("#hfPrizeID").val(),
                        "DeclarationID": DeclarationID.join(',')
                    },
                    success: function (data) {
                        $("#lblIsStop").text("投票中");
                        ShowMessag(data);
                    }
                });
            }
        }

        function StopPrizeVote(IsStopVote) {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                dataType: "json",
                data: {
                    "Action": "StopPrizeVote",
                    "PrizeID": $("#hfPrizeID").val(),
                    "StopVote": IsStopVote
                },
                success: function (data) {
                    $("#lblIsStop").text(data ? "暂停" : "投票中");
                    //ShowMessag(data);
                    //InitTable();
                }
            });
        }

        // 自动勾选
        function stateFormatter(value, row, index) {
            if (Row[2].length == 0) {
                if (prize.MultipleVoteRound == 1) {
                    if (prize.AwardCount == null || prize.AwardCount == 0) {
                        return { checked: false };
                    }
                    else {
                        return {
                            checked: (index < prize.AwardCount || row.Ordinal <= ordinal)
                        };
                    }
                } else if (prize.MultipleVoteRound == 2) {
                    if ((prize.FirstPrize + prize.SecondPrize) == 0) {
                        return { checked: false };
                    } else {
                        return {
                            checked: (index < (prize.FirstPrize + prize.SecondPrize) || row.Ordinal <= ordinal)
                        };
                    }
                }
            }
            else {
                for (var i = 0; i < Row[2].length; i++) {
                    if (row.DeclarationID == Row[2][i].DeclarationID) {
                        return { checked: true };
                    }
                }

                return { checked: false };
            }
        }

        function InitTable(PerPage, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, PrizeType) {
            $('#tbResultList').bootstrapTable('destroy');

            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "GetVoteResult",
                    "PrizeID": $("#hfPrizeID").val()
                },
                success: function (data) {
                    if (data != "") {
                        Row = JSON.parse(data);
                        prize = Row[0];

                        if (prize.AwardCount == null) {
                            prize.AwardCount = 0;
                        }
                        if (prize.FirstPrize == null) {
                            prize.FirstPrize = 0;
                        }
                        if (prize.SecondPrize == null) {
                            prize.SecondPrize = 0;
                        }

                        if (prize.MultipleVoteRound == 1) {
                            checkCnt = prize.AwardCount;
                        } else if (prize.MultipleVoteRound == 2) {
                            checkCnt = prize.FirstPrize + prize.SecondPrize;
                        }

                        $("#lblPrizeName").text(prize.PrizeName);
                        $("#lblRound").text(prize.MultipleVoteRound);
                        
                        $("#lblIsStop").text(prize.IsStopVote ? "暂停" : "投票中");

                        if (prize.MultipleVoteRound == null) {
                            prize.MultipleVoteRound = 1;
                        }

                        if (prize.MultipleVoteRound == 1) {
                            $("#lblAwardCount").text(prize.AwardCount);
                        } else if (prize.MultipleVoteRound == 2) {
                            if (prize.FirstPrize == null) {
                                prize.FirstPrize = 0;
                            }

                            if (prize.SecondPrize == null) {
                                prize.SecondPrize = 0;
                            }

                            $("#lblAwardCount").text(prize.FirstPrize + prize.SecondPrize);
                        }

                        if (prize.PrizeTypeCode == '0302' || prize.PrizeTypeCode == '0303') {
                            $("#spanMulti").hide();
                            $("#spanSingle").show();

                            $("#txtAwardCount").val(prize.AwardCount);
                        } else {
                            $("#spanMulti").show();
                            $("#spanSingle").hide();

                            $("#txtFirstPrize").val(prize.FirstPrize);
                            $("#txtSecondPrize").val(prize.SecondPrize);
                            $("#txtThirdPrize").val(prize.ThirdPrize);
                        }

                        if (Row[1].length > 0) {
                            ordinal = Row[1][checkCnt - 1].Ordinal;
                        }
                        else {
                            ordinal = 0;
                        }

                        var option = {
                            striped: true,                    //是否显示行间隔色
                            sortable: false,
                            editable: false,
                            clickToSelect: true,
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "DeclarationID",            //每一行的唯一标识，一般为主键列
                            columns: [
                                { field: 'checked', checkbox: true, formatter: stateFormatter },
                                { 
                                    title: '序号',//标题  
                                    formatter: function (value, row, index) {
                                        return index + 1;
                                    }
                                },
                                { field: 'Ordinal', title: '排序', align: 'center', valign: 'middle' },
                                { field: 'DeclarationName', title: '项目名称', align: 'center', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                { field: 'FirstPrize', title: '一等奖', align: 'center', valign: 'middle' },
                                { field: 'SecondPrize', title: '二等奖', align: 'center', valign: 'middle' },
                                { field: 'ThirdPrize', title: '三等奖', align: 'center', valign: 'middle' },
                                { field: 'Recommended', title: '推荐', align: 'center', valign: 'middle' },
                                { field: 'NotRecommended', title: '不推荐', align: 'center', valign: 'middle' },
                                { field: 'SlowRating', title: '缓评', align: 'center', valign: 'middle' },
                                { field: 'TurnOut', title: '转出', align: 'center', valign: 'middle' },
                                {
                                    field: 'ExpertPercent', title: '是否达标', align: 'center', valign: 'middle',
                                    formatter: function (value, row, index) {
                                        var Standard = parseFloat('<%=Standard %>');
                                        if (value == null || value == "" || value >= Standard)
                                            return "";
                                        else
                                            return "<span style='color:deepskyblue;'><b>未过" + Standard + "%</b></span>";
                                    }
                                },
                                {
                                    field: 'IsNeedRevote', title: '等票复投', align: 'center', valign: 'middle',
                                    formatter: function (value, row, index) {
                                        if (value == null || value == "False")
                                            return "";
                                        else
                                            return "<span style='color:red;'><b>需要</b></span>";
                                    }
                                }
                            ]
                        };

                        if (Row[0].PrizeTypeCode == "0302" || Row[0].PrizeTypeCode == "0303"
                            || ((Row[0].VoteType == "2202" || Row[0].VoteType == "2203") && Row[0].MultipleVoteRound == 1)) {
                            option.columns.splice(5, 3);
                        }
                        else if (Row[0].VoteType == "2202" && Row[0].MultipleVoteRound == 2) {
                            option.columns.splice(7, 1);
                            option.columns.splice(option.columns.length - 3, 3);
                        } else if (Row[0].VoteType == "2201" && (Row[0].PrizeTypeCode == "0301" || Row[0].PrizeTypeCode == "0304")) {
                            option.columns.splice(7, 1);
                        }
                        else {
                            option.columns.splice(5, 3);
                            option.columns.splice(option.columns.length - 2, 2);

                            if (Row[0].MultipleVoteRound == 2) {
                                option.columns[5].title = "一等奖、二等奖";
                                option.columns[6].title = "三等奖";
                            } else {
                                option.columns[5].title = "一等奖";
                                option.columns[6].title = "二等奖";
                            }
                        }

                        option.data = Row[1];
                        $('#tbResultList').bootstrapTable(option);

                        $('#lblSelectedCount').text($('#tbResultList').bootstrapTable('getSelections').length);

                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbResultList'));
                    }
                }
            });

            $('#tbResultList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#lblSelectedCount').text($('#tbResultList').bootstrapTable('getSelections').length);
            });

        }

        $(function () {
            InitTable();
        });

    </script>
</asp:Content>
