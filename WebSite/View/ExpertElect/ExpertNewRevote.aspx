<%@ Page  Title="专家投票" MasterPageFile="~/View/Mutual/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ExpertNewRevote.aspx.cs" Inherits="Evaluation.View.ExpertElect.ExpertNewRevote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/plugins/ui-choose/src/ui-choose.css" rel="stylesheet" />
    <script src="../../Content/plugins/ui-choose/src/ui-choose.js"></script>
    <style>
            .btnt {
            width:78px;
            padding:0;
            height:25px;
            line-height:25px;
            display:inline-block;
            text-align:center
                
        }
           .condition{
               border:1px solid #e1e1e1;
               border-radius:5px;
               padding:10px;              
           }
           #txtPrizeName{
               height:26px;             
               border:1px solid #aaa ;
           }
           .rbtn{
               width:80px;margin:15px auto;
           }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">专家评选</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ExpertElect/ExpertVote.aspx">专家投票</a>
        </li>        
    </ul>
    <div class="condition">
        <span>专  业： 
            <asp:DropDownList ID="ddlSpecialtyID" runat="server" ClientIDMode="Static" Style="width: 168px;"></asp:DropDownList>
        </span>
        <span style="margin:0 20px;">奖项类型：
		    <asp:DropDownList ID="ddlPrize" runat="server" ClientIDMode="Static" Style="width: 168px;"></asp:DropDownList>
        </span>
        <span>奖项名称：
            <asp:TextBox ID="txtPrizeName" ClientIDMode="Static" runat="server" Width="168px"></asp:TextBox>
        </span>
        <asp:HiddenField ID="hfVoteType" runat="server" ClientIDMode="Static" />
    </div>
    <div class="rbtn">
        <input type="button" id="btnSearchPrice" value="查 &nbsp;&nbsp; 询" class="btnt" onclick="Search();" />
    </div> 
    <div>
        <table id="tbExpertVotePrize"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px; margin-bottom: 130px;"></div>

    </div>
    <script>
        $(function () {
            var PerPage;
            var CuttentPage;

            if ($("#per_page_select").val() == null) {
                PerPage = 50;
            }
            else {
                PerPage = $("#per_page_select").val();
            }

            if ($("#pagination_links li a.active")[0] == null) {
                CuttentPage = 1;
            }
            else {
                CuttentPage = $("#pagination_links li a.active")[0].text;
            }
            InitTable(PerPage, CuttentPage);

            $("#ddlSpecialtyID,#ddlPrize").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });

            $('select').multipleSelect('checkAll');
        });

        function operateFormatter(value, row, index) {
            return [
             '<a class="Vote" href="javascript:void(0)" title="投票">',
             '<i class="fa fa-edit"></i>',
             '</a>  '
            ].join('');
        }

        function InitTable(PageSize, CuttentPage, Specialtys, PrizeType, PrizeName) {
            $('#tbExpertVotePrize').bootstrapTable('destroy');
            window.operateEvents = {
                'click .Vote': function (e, value, row, index) {
                    window.location = "NewRevote.aspx?PrizeID=" + row.PrizeID;
                },
                'click .ReVote': function (e, value, row, index) {
                    window.location = "ExpertNewRevote.aspx?PrizeID=" + row.PrizeID;
                },
                'click .XMTPJG': function (e, value, row, index) {
                    window.location = "../ActivityManage/VoteResult.aspx?PrizeID=" + row.PrizeID;
                },
                'click .AdminReVote': function (e, value, row, index) {
                    if (row.IsMultipleVoting == "False" && (row.PrizeTypeCode == "0301" || row.PrizeTypeCode == "0304")) {
                        window.location = "../ActivityManage/SingleRevoteSet.aspx?PrizeID=" + row.PrizeID;
                    }
                    else {
                        window.location = "../ActivityManage/MultipleRevoteSet.aspx?PrizeID=" + row.PrizeID;
                    }
                }
            };
            $.ajax({
                url: '../Mutual/ExpertElect.ashx',
                type: "post",
                data: {
                    "Action": "GetExpertRevotePrizeList",
                    "PageSize": PageSize,
                    "CuttentPage": CuttentPage,
                    "PageSize" : PageSize,
                    "Specialtys": Specialtys,
                    "PrizeType": PrizeType,
                    "PrizeName": PrizeName
                },
                success: function (data) {                 
                    if (data != "") {                        
                        var Row = JSON.parse(data)
                        var option = {
                            striped: true,                      //是否显示行间隔色
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "PrizeID",            //每一行的唯一标识，一般为主键列
                            columns: [
                                { field: 'PrizeName', title: '奖项名称', align: 'center', valign: 'middle' },
                                { field: 'SpecialtyName', title: '专业名称', align: 'center', valign: 'middle' },
                                { field: 'PrizeType', title: '奖项类型', align: 'center', valign: 'middle' },
                                { field: 'MultipleVoteRound', title: '当前轮次', align: 'center', valign: 'middle' },
                                { field: 'RevoteRound', title: '复投轮次', align: 'center', valign: 'middle' },
                                { field: 'RevoteApplicationCount', title: '需复投项目数量', align: 'center', valign: 'middle' },
                                { field: 'Vote', title: '操作', align: 'center', valign: 'middle', events: operateEvents, formatter: operateFormatter }]
                        };
                        option.data = Row.Table;;
                        $('#tbExpertVotePrize').bootstrapTable(option);

                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(Row.RecordNumber, Row.CuttentPage, Row.PerPage));
                        $("#divPagination").append(myPaginationLinks(Row.RecordNumber, Row.CuttentPage, Row.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(Row.PerPage);

                    } else {
                        $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbExpertVotePrize'));
                    }
                }
            });
        }

        function Search() {
            var Specialtys = $("#ddlSpecialtyID").first().multipleSelect("getSelects");
            var PrizeType = $("#ddlPrize").first().multipleSelect("getSelects");
            var PrizeName = $("#txtPrizeName").val();
            var PerPage = $('#per_page_select').val();
            var CuttentPage = 1;
            InitTable(PerPage, CuttentPage, Specialtys.toString(), PrizeType.toString(), PrizeName);
        }
    </script>
</asp:Content>