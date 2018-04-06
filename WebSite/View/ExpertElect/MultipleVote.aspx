 <%@ Page Title="" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="MultipleVote.aspx.cs" Inherits="Evaluation.View.ExpertElect.MultipleVote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btnt {
            width: 78px;
            padding: 0;
            height: 25px;
            line-height: 25px;
            display: inline-block;
            text-align: center;
        }

        .tb_tr_td_padding_5 tr td {
            padding: 5px;
        }

        #btnDiv {
            width: 300px;
            margin: 30px auto;
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
           input[type="radio"]{
               cursor:pointer;
           }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="txtPrizeID" runat="server" ClientIDMode="Static" style="display:none;"></asp:TextBox>
    <asp:TextBox ID="txtMultipleVoteRound" runat="server" ClientIDMode="Static" style="display:none;"></asp:TextBox>
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
    <div style="width:100%;border:1px solid #ccc;border-radius:5px;padding:6px 0 6px 10px;margin-bottom:15px;">
    <table class="tb_tr_td_padding_5">
        <tr>
            <td colspan="7">当前奖项为：&nbsp;  <asp:Label ID="labPrizeName" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="7">当前轮次为：&nbsp;  <asp:Label ID="lblMultipleVoteRound" runat="server" ClientIDMode="Static"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="7">奖项名额为：&nbsp;  <asp:Label ID="lblPrizeNum" runat="server" style="color: red;"></asp:Label></td>
        </tr>
        <%--<tr>
            <td colspan="7">奖项名额为：&nbsp;  <span id="dp0" style="color: red;">?</span></td> 多轮投
        </tr>--%>
        <tr>
            <td>已投票数量：</td>
            <td>推荐 <span id="p0" style="color: red;">?</span> 名</td>
            <td>不推荐 <span id="p1" style="color: red;">?</span> 名</td>  
            <td style="padding-left:15px;">缓评 <span id="p2" style="color: red;">?</span> 名</td>
            <td style="padding-left:15px;">转出 <span id="p3" style="color: red;">?</span> 名</td>
        </tr>
    </table>
       </div>

    <table id="tbExpertVote"></table>
    <div id="btnDiv">
        <input type="button" class="btnt" id="btnVote" value="保 &nbsp;存" />
        <input type="button" class="btnt" id="btnSubmit" value="提 &nbsp;交" />
        <input type="button" class="btnt" id="btnBack" value="返 &nbsp;回" />
    </div>

</div>
    <script>
        $(function () {
            $("#txtPrizeID").hide();
             InitTable()
            $('#tbExpertVote').on('click', 'input', function () {
               $(this).closest('tr').find('input').next('.fa').css('color', '#868686');   
               $(this).next('.fa').css('color', '#FFA200')              
            });
        })

        $("#btnBack").click(function () {
            // window.location = "../../View/ExpertElect/ExpertVote.aspx";
            window.history.go(-1);
        });

        $("#btnVote").click(function () {
            if ($('#tbExpertVote tbody tr').length > 0 && $('#tbExpertVote tbody tr td').text() != "没有找到匹配的记录") {
                var postData = "[";
                for (var i = 0; i < $('#tbExpertVote tbody tr').length; i++) {
                    postData = postData + '{"DeclarationID":"' + getIdSelections()[i].DeclarationID +
                        '","VoteCode":"' + $("input[name='rbtn" + i + "']:checked").val() +
                        '","VoteType":"' + "0502" +
                        '","PrizeID":"' + getIdSelections()[i].PrizeID +
                        '","MultipleVoteRound":"' + $("#lblMultipleVoteRound").text() +
                        '"},';
                }
                postData = postData.substring(0, postData.length - 1) + "]";
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    dataType: "json",
                    data: { "Action": "AddExpertVote", "JsonData": postData,"PrizeID":$("#txtPrizeID").val() },
                    success: function (data) {
                        ShowMessag(data);
                        InitTable();
                    }
                });
            }
            else {
                ShowMessag("没有数据!");
            }
        })

        $("#btnSubmit").click(function () {
            if ($('#tbExpertVote tbody tr').length > 0 && $('#tbExpertVote tbody tr td').text() != "没有找到匹配的记录") {
                $.ajax({
                    url: '../Mutual/ExpertElect.ashx',
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
        })

        function operateFormatter0(value, row, index) {
            if (row.VoteCode == "0601") {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0601" checked="checked" />'
                      +'<i class="fa fa-thumbs-up" aria-hidden="true" style="color:#FFA200"></i>'
                   
                ].join('');
            }
            else {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0601" />'
                     +'<i class="fa fa-thumbs-up" aria-hidden="true" style="color:#868686;"></i>'
                   
                ].join('');
            }
        }
        function operateFormatter1(value, row, index) {
            if (row.VoteCode == "0602" || row.VoteCode == null) {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0602" checked="checked" />'
                      +'<i class="fa fa-thumbs-down " aria-hidden="true" style="color:#FFA200"></i>'
                   
                ].join('');
            }
            else {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0602" />'
                     +'<i class="fa fa-thumbs-down " aria-hidden="true" style="color:#868686;"></i>'
                  
                ].join('');
            }
        }
        function operateFormatter2(value, row, index) {
            if (row.VoteCode == "0603") {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0603" checked="checked" />'
                      +'<i class="fa fa-recycle " aria-hidden="true" style="color:#FFA200"></i>'
                  
                ].join('');
            }
            else {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0603" />'
                     +'<i class="fa fa-recycle " aria-hidden="true" style="color:#868686;"></i>'
                  
                ].join('');
            }
        }
        function operateFormatter3(value, row, index) {
            if (row.VoteCode == "0604") {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0604" checked="checked" />'
                      +'<i class="fa fa-share-square-o" aria-hidden="true" style="color:#FFA200"></i>'
                    
                ].join('');
            }
            else {
                return [
                    '<input type="radio" class="export" name="rbtn' + index + '" value="0604" />'
                      +'<i class="fa fa-share-square-o" aria-hidden="true" style="color:#868686;"></i>'
                   
                ].join('');
            }
        }
        function InitTable() {
            $('#tbExpertVote').bootstrapTable('destroy');   
            window.operateEvents = {
                'click .export': function (e, value, row, index) {
                }
            };
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: { "Action": "GetMultipleVoteList", "PrizeID": $("#txtPrizeID").val() },
                success: function (data) {
                    $('#tbExpertVote').bootstrapTable('destroy');
                        if (data == "投票未开始或已经结束!") {
                            ShowMessag(data);
                        }
                        if (data != "投票未开始或已经结束!") {
                        var Row = JSON.parse(data)

                        //给当前专家每个投票项的已投票数量绑定数值
                        for (var m = 0; m < Row[1].length; m++) {
                            $("#p" + m + "").text(Row[1][m]);
                        }

                        //给当前专家每个投票项的未投票数量绑定数值
                        //for (var m = 0; m < Row[2].length; m++) {
                        //    $("#dp" + m + "").text(Row[2][m]);
                        //}

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
                                { field: 'DeclarationStatusText', title: '申报状态', align: 'center', valign: 'middle' },
                                { field: 'PrizeName', title: '申报奖项', align: 'center', valign: 'middle' },
                                { field: 'Recommended', title: '推荐', align: 'center', valign: 'middle', events: operateEvents, formatter: operateFormatter0 },
                                { field: 'NotRecommended', title: '不推荐', align: 'center', valign: 'middle', events: operateEvents, formatter: operateFormatter1 },
                                { field: 'SlowRating', title: '缓评', align: 'center', valign: 'middle', events: operateEvents, formatter: operateFormatter2 },
                                { field: 'TurnOut', title: '转出', align: 'center', valign: 'middle', events: operateEvents, formatter: operateFormatter3 }]
                        };
                        option.data = Row[0];
                        $('#tbExpertVote').bootstrapTable(option);
                        RemoveColoums();
                    } else {
                        $('<tr><td >没有找到匹配的记录</td></tr>').appendTo($('#tbExpertVote'));
                    }
                }
            });
        }
        function getIdSelections() {
            return $.map($('#tbExpertVote').bootstrapTable('getData'), function (data) {
                return data;
            })
        }
        //去掉多余的列
        function RemoveColoums() {
            if ($("#txtMultipleVoteRound").val() == "2" || $("#txtMultipleVoteRound").val() == "3") {
                if ($('#tbExpertVote thead').find("tr").eq(0).find("th").eq(6).text() == "缓评") {
                    $('#tbExpertVote thead').find("tr").eq(0).find("th").eq(6).remove();
                    $('#tbExpertVote thead').find("tr").eq(0).find("th").eq(6).remove();
                    for (var i = 0; i < $('#tbExpertVote tbody tr').length; i++) {
                        $('#tbExpertVote tbody').find("tr").eq(i).find("td").eq(6).remove();
                        $('#tbExpertVote tbody').find("tr").eq(i).find("td").eq(6).remove();
                    }
                }

            }
        }
    </script>
</asp:Content>
