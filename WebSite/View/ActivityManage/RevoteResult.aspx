<%@ Page Title="投票结果" Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="RevoteResult.aspx.cs" Inherits="Evaluation.View.ActivityManage.RevoteResult" %>

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
        <input type="button" value="提  交" class="btnt"  onclick="OnSubmit();" style="margin-right:10px;" />
        <input type="button" value="继续复投" class="btnt"  onclick="OnRevote();" style="margin-right:10px;" /> 
        <asp:Button runat="server" ID="ExportAward" Text="导出投票结果" class="btnt" OnClick="ExportAward_Click" />
    </span>
    <br />

    <table id="tbResultList" data-reorderable-columns="true"></table>

    <script>
        function OnSubmit() {
            var listData = $('#tbResultList').bootstrapTable('getData');

            listData = JSON.stringify(listData);
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "SubmitRevoteResult",
                    "PrizeID": $("#hfPrizeID").val(),
                    "Views":listData
                },
                success: function (data) {
                    ShowMessag(data);
                }
            });
        }

        function OnRevote() {
            //var listData = $('#tbResultList').bootstrapTable('getData');

            //listData = JSON.stringify(listData);
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "RevoteMore",
                    "PrizeID": $("#hfPrizeID").val()
                },
                success: function (data) {
                    ShowMessag(data);
                }
            });
        }

        function operateFormatter(value, row, index) {
            if (row.AwardCode === '0401') {
                return "一等奖";
            } else if (row.AwardCode === '0402') {
                return "二等奖";
            } else if (row.AwardCode === '0403') {
                return "三等奖";
            } else if (row.AwardCode === '0404') {
                return "推荐";
            }
            return "";
        }

        function InitTable() {
            $('#tbResultList').bootstrapTable('destroy');

            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "GetRevoteResult",
                    "PrizeID": $("#hfPrizeID").val()
                },
                success: function (data) {
                    if (data != "") {
                        var response = JSON.parse(data);
                        //console.log(response);
                        var awards = response.Awards;
                        var selectSource = [];
                        if (response.IsIndividual) {
                            $("#lblAwardCount").text(awards.Recommended);

                            // show individual
                            $("#spanMulti").hide();
                            $("#spanSingle").show();
                            // initial select.source
                            selectSource = [
                                { value: '0404', text: '推荐' },
                                { value: '', text: '不推荐' }
                            ];

                        } else {
                            $("#lblFirstPrize").text(awards.FirstPrize);
                            $("#lblSecondPrize").text(awards.SecondPrize);
                            $("#lblThirdPrize").text(awards.ThirdPrize);
                            // show multiple
                            $("#spanMulti").show();
                            $("#spanSingle").hide();
                            // initial select.source
                            selectSource = [
                                { value: '0401', text: '一等奖' },
                                { value: '0402', text: '二等奖' },
                                { value: '0403', text: '三等奖' },
                                { value: '', text: '不推荐' }
                            ];
                        }

                        var option = {
                            striped: true,                    //是否显示行间隔色
                            editable: true,
                            clickToSelect: true,
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "DeclarationId",            //每一行的唯一标识，一般为主键列
                            columns: [
                                {
                                    title: '序号',//标题  
                                    formatter: function (value, row, index) {
                                        return index + 1;
                                    }
                                },
                                { field: 'Award', title: '排名', align: 'center', valign: 'middle' },
                                { field: 'DeclarationName', title: '项目名称', align: 'left', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'left', valign: 'middle' },
                                { field: 'RevoteRecommended', title: '推荐', align: 'center', valign: 'middle' },
                                { field: 'RevoteNotRecommended', title: '不推荐', align: 'center', valign: 'middle' },
                                {
                                    field: 'AwardStatus', title: '复投结果', align: 'center', valign: 'middle',
                                    formatter: operateFormatter
                                },
                                {
                                    field: 'AwardCode', title: '选定奖项', align: 'center', valign: 'middle',
                                    formatter: function (value, row, index) {
                                        if (row.AwardCode == "0401") {
                                            return "0401";
                                        } else if (row.AwardCode == "0402") {
                                            return "0402";
                                        } else if (row.AwardCode == "0403") {
                                            return "0403";
                                        } else if (row.AwardCode == "0404") {
                                            return "0404";
                                        } else {
                                            return "";
                                        }
                                    },
                                    editable: {
                                        type: 'select',
                                        title: '选定奖项',
                                        source: selectSource
                                    }
                                }
                            ],
                            onEditableSave: function (field, row, oldValue, $el) {

                                //console.log(field);
                                //console.log(row);
                                //console.log(oldValue);
                                //console.log($el);

                                row.AwardStatus = row.AwardCode;
                                if (row.AwardCode === '0401') {
                                    row.Award= 1;
                                } else if (row.AwardCode === '0402') {
                                    row.Award=2;
                                } else if (row.AwardCode === '0403') {
                                    row.Award = 3;
                                } else if (row.AwardCode === '0404') {
                                    row.Award = 4;
                                } else {
                                    row.Award = 0;
                                }

                                var listData = $('#tbResultList').bootstrapTable('getData');
                                $('#tbResultList').bootstrapTable("load", listData);
                            }
                        };

                        option.data = response.Views;
                        $('#tbResultList').bootstrapTable(option);

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
