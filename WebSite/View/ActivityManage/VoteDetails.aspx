<%@ Page Title="投票结果详情" Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="VoteDetails.aspx.cs" Inherits="Evaluation.View.ActivityManage.VoteDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #content {
            padding-bottom: 240px !important;
        }
        #dt{
            border:1px solid #dddddd;width:100%;
        }
         #dt td{
             height:30px;
         }
       
         #dt tbody> tr:nth-child(odd) > td{
         background:#fff;
         }
         #dt tbody> tr:nth-child(odd) > td{
         background:#EDEDED;
         }
         #lblDeclarationName{
             font-weight:600;margin-bottom:8px;display: inline-block;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <ul class="navs">
        <li class="nav1" id="main" style="float: left; padding-right: 5px;">
            <a href="#">评优管理</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="../ActivityManage/VoteResult.aspx">投票结果</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#">投票结果详情</a>
        </li>
    </ul>
    <asp:Label ID="lblDeclarationName" runat="server" ClientIDMode="Static"> </asp:Label>
    <asp:HiddenField ID="DeclarationID" ClientIDMode="Static" runat="server" />
    <br />
    <table id="dtVoteDetail" data-reorderable-columns="true"></table>
    <div style="width:80px;margin:40px auto;">
    <input type="button" name="name" class="btnt" value="返  回" onclick="Back()"/>
    </div>
    <script>
        $(document).ready(function () {
            var msg = $("#hdMsg").val();
            if (msg != '') {
                ShowMessag(msg);
            }
            InitTable();
        });
        function InitTable() {
            $('#dtVoteDetail').bootstrapTable('destroy');
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: { "Action": "GetVoteDetail", "DeclarationID": $("#DeclarationID").val() },
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
                            uniqueId: "VoteCode",            //每一行的唯一标识，一般为主键列
                            columns: [
                                { field: 'VoteType', title: '投票类型', align: 'center', valign: 'middle' },
                                { field: 'VoteNum', title: '投票数量', align: 'center', valign: 'middle' },
                                { field: 'ExpertName', title: '投票专家', align: 'center', valign: 'middle' }
                            ]
                        };
                        option.data = Row;
                        $('#dtVoteDetail').bootstrapTable(option);
                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#dtVoteDetail'));
                    }
                }
            });
        }
          function Back(){
              history.go(-1)
          };
    </script>
</asp:Content>
