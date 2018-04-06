<%@ Page Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true"  CodeBehind="ExpertRevoteDetailList.aspx.cs" Inherits="Evaluation.View.ExpertElect.ExpertRevoteDetailList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
          <a href="#">评优报表</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ExpertElect/ExpertVoteDetailList.aspx">专家投票情况</a>
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
        <input type="button" id="btnSearchPrice" value="查 &nbsp;&nbsp; 询" class="btnt" onclick="onSearch();" />
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
        })
        
        function operateFormatter(value, row, index) {
            return [
             '<a class="RevoteResult" href="javascript:void(0)" title="查看复投结果">',
             '<i class="fa fa-search"></i>',
             '</a>  '
            ].join('');
        }

        function InitTable(PageSize, CuttentPage, Specialtys, PrizeType, PrizeName) {
            $('#tbExpertVotePrize').bootstrapTable('destroy');
            window.operateEvents = {
                'click .RevoteResult': function (e, value, row, index) {
                    window.location = "../ActivityManage/RevoteResult.aspx?PrizeID=" + row.PrizeID;
                },
            };

            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: {
                    "Action": "GetRevotePrizeList",
                    "PageSize": PageSize,
                    "CuttentPage": CuttentPage,
                    "PageSize": PageSize,
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
                                { field: 'RevoteRound', title: '复投轮次', align: 'center', valign: 'middle' },
                                { field: 'RevoteUserCount', title: '已投票专家数量', align: 'center', valign: 'middle' },
                                { field: 'Vote', title: '操作', align: 'center', valign: 'middle', events: operateEvents, formatter: operateFormatter }]
                        };
                        option.data = Row.Table;
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

        function onSearch(PerPage, CuttentPage) {
            var Specialtys = $("#ddlSpecialtyID").first().multipleSelect("getSelects");
            var PrizeType = $("#ddlPrize").first().multipleSelect("getSelects");
            var PrizeName = $("#txtPrizeName").val();

            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage, Specialtys.toString(), PrizeType.toString(), PrizeName);
        }
    </script>
</asp:Content>
