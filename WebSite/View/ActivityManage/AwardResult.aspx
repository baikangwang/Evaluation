<%@ Page Title="投票结果" Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="AwardResult.aspx.cs" Inherits="Evaluation.View.ActivityManage.AwardResult" %>

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
            <a href="../ActivityManage/AwardResult.aspx">投票结果</a>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="../ActivityManage/RevoteResult.aspx">复投结果</a>
        </li>
    </ul>
    <br />
    <div style="text-wrap:none;">
        <span id="spanMulti">
            <span style="padding-right:19px;">一等奖名额：<label id="lblFirstPrize"></label></span>
            <span style="padding-right:19px;">二等奖名额：<label id="lblSecondPrize"></label></span>
            <span style="padding-right:19px;">三等奖名额：<label id="lblThirdPrize"></label></span>
        </span>
        <span id="spanSingle" style="padding-right:19px;">
            获奖名额：<label id="lblAwardCount"></label></span>
    </div>
    <br />

    <span class="inquire" style="margin-left: 45%; position: absolute; left: 50px;line-height:25px;">
        <input type="button" value="重新计算" class="btnt"  onclick="OnResetAwardResult();" style="margin-right:10px;" /> 
<%--        <input type="button" value="提  交" class="btnt"  onclick="OnSubmit();" style="margin-right:10px;" /> --%>
        <input type="button" value="等票复投" class="btnt"  onclick="OnRevote();" style="margin-right:10px;" /> 
        <asp:Button runat="server" ID="ExportAward" Text="导出投票结果" class="btnt" OnClick="ExportAward_Click" />
    </span>
    <br />

    <table id="tbResultList" data-reorderable-columns="true"></table>

    <script>
        function OnResetAwardResult() {
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "ResetAwardResult",
                    "PrizeID": $("#hfPrizeID").val()
                },
                success: function (data) {
                    InitTable();
                }
            });
        }

        function OnRevote() {
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

        function InitTable(PerPage, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, PrizeType) {
            $('#tbResultList').bootstrapTable('destroy');

            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "GetAwardResult",
                    "PrizeID": $("#hfPrizeID").val()
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data);
                        prize = Row[0];

                        if (prize.PrizeTypeCode == '0302' || prize.PrizeTypeCode == '0303') {
                            $("#spanMulti").hide();
                            $("#spanSingle").show();

                            $("#lblAwardCount").text(prize.AwardCount);
                        } else {
                            $("#spanMulti").show();
                            $("#spanSingle").hide();

                            $("#lblFirstPrize").text(prize.FirstPrize);
                            $("#lblSecondPrize").text(prize.SecondPrize);
                            $("#lblThirdPrize").text(prize.ThirdPrize);
                        }
                        
                        var option = {
                            striped: true,                    //是否显示行间隔色
                            editable: true,
                            clickToSelect: true,
                            showColumns: true,                  //是否显示所有的列
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
                                //{ field: 'Ordinal', title: '排名', align: 'center', valign: 'middle' },
                                {
                                    field: 'InnerOrdinal', title: '同奖项排序', align: 'center', valign: 'middle', editable: {
                                        type: 'text',
                                        title: '同奖项排序',
                                        validate: function (v) {
                                            if (!v) {
                                                return '序号不能为空！';
                                            } else if (isNaN(v)) {
                                                return '序号只能是数字！';
                                            }
                                        }
                                    }
                                },
                                { field: 'DeclarationName', title: '项目名称', align: 'left', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'left', valign: 'middle' },
                                { field: 'FirstPrize', title: '一等奖', align: 'center', valign: 'middle' },
                                { field: 'SecondPrize', title: '二等奖', align: 'center', valign: 'middle' },
                                { field: 'ThirdPrize', title: '三等奖', align: 'center', valign: 'middle' },
                                { field: 'Recommended', title: '推荐', align: 'center', valign: 'middle' },
                                { field: 'NotRecommended', title: '不推荐', align: 'center', valign: 'middle' },
                                { field: 'SlowRating', title: '缓评', align: 'center', valign: 'middle' },
                                { field: 'TurnOut', title: '转出', align: 'center', valign: 'middle' },
                                {
                                    field: 'AwardStatus', title: '投票结果', align: 'center', valign: 'middle',
                                    formatter: function (value, row, index) {
                                        if (row.VoteCode == '0601' && row.PrizeLevelCode == '0401') {
                                            return "一等奖";
                                        } else if (row.VoteCode == '0601' && row.PrizeLevelCode == '0402') {
                                            return "二等奖";
                                        } else if (row.VoteCode == '0601' && row.PrizeLevelCode == '0403') {
                                            return "三等奖";
                                        } else if (row.VoteCode == '0601') {
                                            return "获奖";
                                        }
                                        else if (row.VoteCode == '0602') {
                                            return "不推荐";
                                        }
                                        else if (row.VoteCode == '0603') {
                                            return "缓评";
                                        }
                                        else if (row.VoteCode == '0604') {
                                            return "转出";
                                        }
                                    }
                                },
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
                                            switch (row.RevoteLevelCode)
                                            {
                                                case "2301":
                                                    return "<span style='color:red;'><b>需要</b></span>";
                                                case "2302":
                                                    return "<span style='color:blue;'><b>需要</b></span>";
                                                case "2303":
                                                    return "<span style='color:fuchsia;'><b>需要</b></span>";
                                                default:
                                                    return "<span style='color:red;'><b>需要</b></span>";
                                            }
                                            
                                            
                                    }
                                },
                                {
                                    field: 'AwardCode', title: '选定奖项', align: 'center', valign: 'middle',
                                    editable: {
                                        type: 'select',
                                        title: '选定奖项',
                                        source: [
                                            { value: '2301', text: '一等奖' },
                                            { value: '2302', text: '二等奖' },
                                            { value: '2303', text: '三等奖' },
                                            { value: '2304', text: '推荐' },
                                            { value: '2305', text: '不推荐' },
                                            { value: '2306', text: '缓评' },
                                            { value: '2307', text: '转出' }
                                        ]
                                    }
                                }
                            ],
                            onEditableSave: function (field, row, oldValue, $el) {
                                console.log(field);
                                if (field == "AwardCode") {
                                    $.ajax({
                                        type: "post",
                                        url: "../Mutual/ExpertElect.ashx",
                                        data: {
                                            "Action": "SetAwardCode",
                                            "DeclarationID": row.DeclarationID,
                                            "AwardCode": row.AwardCode
                                        },
                                        success: function (data) {
                                            InitTable();
                                        },
                                        error: function (data) {
                                            ShowMessag(data);
                                        }
                                    });
                                } else if (field == "InnerOrdinal") {
                                    $.ajax({
                                        type: "post",
                                        url: "../Mutual/ExpertElect.ashx",
                                        data: {
                                            "Action": "SetInnerOrdinal",
                                            "DeclarationID": row.DeclarationID,
                                            "InnerOrdinal": row.InnerOrdinal
                                        },
                                        success: function (data) {
                                            InitTable();
                                        },
                                        error: function (data) {
                                            ShowMessag(data);
                                        }
                                    });
                                }
                            }
                        };

                        option.data = Row[1];
                        $('#tbResultList').bootstrapTable(option);

                        var tableId = document.getElementById("ifrTab1");
                        for (var i = 1; i < tableId.rows.length; i++) {
                            if ('XXX1' == tableId.rows[i].cells[1].innerHTML) {
                                tableId.rows[i].setAttribute("style", "background: #fedd7c;");
                            }
                        }

                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbResultList'));
                    }
                }
            });
        }

        $(function () {
            InitTable();
        });

    </script>
</asp:Content>
