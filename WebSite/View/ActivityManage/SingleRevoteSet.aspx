<%@ Page Title="等票复投" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="SingleRevoteSet.aspx.cs" Inherits="Evaluation.View.ActivityManage.SingleRevoteSet" %>

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
            <a href="../ActivityManage/VoteResult.aspx">项目投票结果</a>
        </li>
    </ul>
    <div class="select">
        <span>
            项目名称：
            <asp:TextBox ID="txtDeclarationName" ClientIDMode="Static" runat="server" Width="168px" placeholder="项目名称"></asp:TextBox>
        </span>
        <span style="margin: 0 9px 0 12px;display:none">
            申报奖项：
            <asp:DropDownList ID="ddlPrizeName" runat="server" ClientIDMode="Static" Style="width: 168px; height: 25px;"></asp:DropDownList>
        </span>
        <span style="margin: 0 10px 0 0">
            申报单位：
            <asp:TextBox runat="server" ID="txtDeclarationUnit" ClientIDMode="Static" Style="width: 168px; height: 25px;"></asp:TextBox>
        </span>
        <span id="Status">
            奖项类别：
            <asp:DropDownList ID="ddlPrizeType" runat="server" ClientIDMode="Static" Style="width: 168px; height: 25px; margin-left: 0px;"></asp:DropDownList>
        </span>
        <asp:HiddenField ID="hfPrizeID" runat="server" ClientIDMode="Static" />
        <asp:HiddenField ID="hfReVotePrizeLevelCode" runat="server" ClientIDMode="Static" />
    </div>
    <br />
    <span class="inquire" style="margin-left: 45%; position: absolute; left: 50px;line-height:25px;">
        <input type="button" value="查 &nbsp;&nbsp; 询" class="btnt" onclick="onSearch();" style="margin-right:10px;" />
        <input type="button" value="开启等票复投" class="btnt" onclick="OnReVote();" style="margin-right:10px;width:100px;" />
    </span>
    <br />
    
    <div>
        <div id="toolbar" class="btn-group"></div>
        <table id="tbList" data-reorderable-columns="true"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px; margin-bottom: 127px;"></div>
    </div>
    <script>

        function onSearch(PerPage, CuttentPage) {
            var DeclarationName = $('#txtDeclarationName').val();
            var DeclarationUnit = $('#txtDeclarationUnit').val();
            var PrizeName = $('#ddlPrizeName').multipleSelect("getSelects").toString();
            var PrizeType = $('#ddlPrizeType').multipleSelect("getSelects").toString();
            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, PrizeType);
        }

        function OnReVote() {
            var DeclarationIDs = getIdSelections().toString();
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: {
                    "Action": "SetSingleRevote", "PrizeID": $("#hfPrizeID").val(), "DeclarationIDs": DeclarationIDs, "ReVotePrizeLevelCode": $("#hfReVotePrizeLevelCode").val()
                },
                success: function (data) {
                    ShowMessag(data);
                }
            })
        }

        function GetPrizeListBySpeciatly() {
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                async: false,
                data: { "Action": "GetPrizeListBySpeciatly", "SpeciatlyID": $("#ddlSpeciatly").val() },
                success: function (data) {
                    data = JSON.parse(data);
                    $("#ddlPrize").empty();
                    if (data.length > 0) {
                        for (var i = 0; i < data.length; i++) {
                            $("#ddlPrize").append("<option value=" + data[i].PrizeID + ">" + data[i].PrizeName + "</option>")
                            $("#ddlPrize").multipleSelect({
                                single: true,
                                allSelected: '',
                            });
                        }
                    }
                    else {
                        $("#ddlPrize").append("<option value= 0>没有奖项</option>");
                        $("#ddlPrize").multipleSelect({
                            single: true,
                            allSelected: '',
                        });
                    }
                }
            });
        };

        function operateFormatter2(value, row, index) {
            return [
                       '<a class="edit" href="javascript:void(0)" title="浏览">',
                       '<i class="fa fa-search"></i>',
                       '</a>  ',
            ].join('');
        }
        function select(){
               $('#tbList tbody tr input[type="checkbox"]').attr('disabled','disabled')
               for (var i = 1; i <= $('#tbList tbody tr').length; i++) {
                  var j=i+1;
                if(j <= $('#tbList tbody tr').length){             
                  var present=parseInt($('#tbList').find("tr").eq(i).find('td:nth-child(2)').text());
                  var next=parseInt($('#tbList').find("tr").eq(i + 1).find('td:nth-child(2)').text());
                  if(present==next){
                    $('#tbList').find("tr").eq(i).find('td input').removeAttr('disabled');                    
                    $('#tbList').find("tr").eq(i +1).find('td input').removeAttr('disabled');
                }
              }
            }
        }
        function InitTable(PerPage, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, PrizeType) {
            $('#tbList').bootstrapTable('destroy');
            window.operateEvents = {
                'click .edit': function (e, value, row, index) {
                    location.href = "VoteDetails.aspx?DeclarationID=" + row.DeclarationID + "&DeclarationName=" + row.DeclarationName;
                }
            }            
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: {
                    "Action": "GetMagReVoteList", "PageSize": PerPage, "CuttentPage": CuttentPage, "DeclarationName": DeclarationName,
                    "DeclarationUnit": DeclarationUnit, "PrizeType": PrizeType, "PrizeID": $("#hfPrizeID").val()   //"PrizeName": PrizeName
                },
                success: function (data) {
                    if (data != "") {
                        data = JSON.parse(data);
                        var Row = data[0];
                        $("#hfReVotePrizeLevelCode").val(data[1]);//等票复投的奖项级别
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
                                { checkbox: true},
                                { field: 'Ordinal', title: '序号', align: 'center', valign: 'middle'},                                
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
                                { field: 'details', title: '投票详情', align: 'center', valign: 'middle', events: operateEvents, formatter: operateFormatter2 },
                            ]
                        };
                        option.data = Row.Table;
                        $('#tbList').bootstrapTable(option);
                        select();
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

        function getIdSelections() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.DeclarationID;
            });
        }

        $(function () {
            var PerPage = '<%=ViewState["PerPage"] ?? 50 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>';
            $("#ddlPrizeName,#ddlPrizeType").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });

            $('select').multipleSelect('checkAll');

            InitTable(PerPage, CuttentPage);

            $("#ddlSpeciatly").multipleSelect({
                single: true
            });
        });

    </script>
</asp:Content>


