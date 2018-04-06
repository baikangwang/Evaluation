<%@ Page Title="" Language="C#" AutoEventWireup="true"  MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="ReviewResult.aspx.cs" Inherits="Evaluation.View.ActivityManage.ReviewResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .table-bordered > thead > tr > th, .table-bordered > thead > tr > td {
            border-bottom: solid 3px #FFF;
        }
        
        .bottom > tbody > tr > td {
            border-left: dashed 1px #EFEFEF;
        }

        .table-bordered {
            border-bottom: solid 3px #CFCFCF;
            border-top: solid 3px #CFCFCF;
        }

        .professional {
            height: 30px;
        }

        .select input[type="text"] {
            border: none;
            border: 1px solid #ccc;
            margin-right: 15px;
            line-height: 20px;
        }

        #txtDeclarationBeginDate, #txtDeclarationEndDate, #txtEditBeginDate, #txtEditEndDate {
            margin-left: 0px !important;
        }

        .select select {
            margin-right: 15px;
        }

        .input-group i {
            padding: 0 4px;
            margin-left: 0 !important;
        }

        .DeclarationList {
            border: 1px solid #e1e1e1;
            padding: 10px 10px 8px 10px;
            border-radius: 5px;
        }

            .DeclarationList input {
                height: 26px;
                line-height: 20px;
            }

        .input-group-addon {
            padding: 3px 3px;
        }

        .editable-container.editable-popup {
            margin-left: 3%;
        }

        .popover.top .arrow {
            left: 37%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <div style="display: none;">
        <asp:TextBox ID="txtLastUpdateTime" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>
    <div style="display: none;">
        <asp:TextBox ID="txtUserType" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>
    <div style="display: none;">
        <asp:TextBox ID="txtUser" ClientIDMode="Static" runat="server"></asp:TextBox>
    </div>

     <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">评优报表</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ActivityManage/ReviewResult.aspx">评审意见</a>
        </li>        
    </ul>
    <div class="DeclarationList" style="margin-bottom: 30px;">
        <div class="select">
            <span>项目名称：
                <asp:TextBox ID="txtDeclarationName" ClientIDMode="Static" runat="server" Width="168px" placeholder="项目名称"></asp:TextBox>
            </span>
            <span id="VIP">申报单位：
                <asp:TextBox runat="server" ID="txtDeclarationUnit" ClientIDMode="Static" Style="width: 168px; height: 25px;"></asp:TextBox>
            </span>
            <span style="margin: 0 15px;">申报奖项：
			    <asp:DropDownList ID="ddlPrize" runat="server" ClientIDMode="Static" Style="width: 168px; height: 25px;"></asp:DropDownList>
            </span>
            <span>评审专家：
                <asp:TextBox ID="txtExpertName" runat="server" ClientIDMode="Static" Width="168px" placeholder="专家姓名"></asp:TextBox>
            </span>
            <span>获奖等级：
                <asp:DropDownList ID="ddlAwardCode" runat="server" ClientIDMode="Static"  Style="width: 168px; height: 25px;"></asp:DropDownList>
            </span>
        </div>
    </div>

    <span class="inquire" style="margin-left: 50%; position: absolute; left: 50px;">
        <input type="button" value="查 &nbsp;&nbsp; 询" class="btnt" onclick="onSearch();" />
    </span>
    <br />
    <div>
        <div id="toolbar" class="btn-group">
            <button id="btn_exportOpinion" type="button" class="btn btn-default" onclick="onExportOpinion()">
                <span class="fa fa-share-square-o" aria-hidden="true"></span>&nbsp;导出评审意见
            </button>
        </div>       
        <table id="tbList" data-reorderable-columns="true"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px; margin-bottom: 127px;"></div>
    </div>
    <div id="Review" style="width: 70%; height: 480px; border: 1px solid #ccc; background: white; margin: auto; z-index: 3; left: 20%; bottom: 15%; position: fixed;  display: none; z-index: 99; top: 80px;">
        <div style="position: absolute; right: 20px; top: 3px;"><a style="color: red; font-size: 24px; cursor: pointer" onclick="Cancel();return false;">×</a> </div>
        <div style="margin: 25px auto 0 auto; width: 150px;font-size:26px;"> 评审内容:</div> 
        <table style="width: 80%;height:350px; margin:20px auto 0px auto; border-spacing: 7px; border-collapse: separate; border:1px solid #ccc;">
            <tr >
                <td style="vertical-align:text-top">
                   <div style="height:99%;width:100%;overflow:auto;" id="ReviewContent"></div>
                </td> 
            </tr> 
        </table> 
    </div>  
    <script>
        function formatTableUnit(value, row, index) {
            return {
                css: {
                    "white-space": "nowrap"
                }
            }
        };

        function Cancel() {
            $("#Review").css("display", "none");
        }

        function getSelectionedID() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.DeclarationID
            });
        }

        function dateFtt(fmt, date) { //author: meizz   
            var o = {
                "M+": date.getMonth() + 1,                 //月份   
                "d+": date.getDate(),                    //日   
                "h+": date.getHours(),                   //小时   
                "m+": date.getMinutes(),                 //分   
                "s+": date.getSeconds(),                 //秒   
                "q+": Math.floor((date.getMonth() + 3) / 3), //季度   
                "S": date.getMilliseconds()             //毫秒   
            };
            if (/(y+)/.test(fmt))
                fmt = fmt.replace(RegExp.$1, (date.getFullYear() + "").substr(4 - RegExp.$1.length));
            for (var k in o)
                if (new RegExp("(" + k + ")").test(fmt))
                    fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
            return fmt;
        }

        function operateFormatter(value, row, index) {
            return [
                '<a class="search" href="javascript:void(0)" title="评审内容">',
                '<i class="fa fa-search"></i>',
                '</a>  '
            ].join('');
        }

        function onExportOpinion() {
            var DeclarationID = getSelectionedID();
            DownLoad(DeclarationID, "ExportOpinion");
        }

        function DownLoad(DeclarationID, Status) {
            var form = $("<form>");   //定义一个form表单
            form.attr('style', 'display:none');   //在form表单中添加查询参数
            form.attr('target', '');
            form.attr('method', 'post');
            if (Status == "ExportOpinion") {
                form.attr('action', "../Declaration/DeclarationList.aspx?ExportOpinionID=" + DeclarationID);
            }

            var input1 = $('<input>');
            input1.attr('type', 'hidden');
            $('body').append(form);  //将表单放置在web中
            form.append(input1);   //将查询参数控件提交到表单上
            form.submit();
        }

        function onSearch(PerPage, CuttentPage) {
            var DeclarationName = $('#txtDeclarationName').val();
            var DeclarationUnit = $('#txtDeclarationUnit').val();
            var PrizeID = $('#ddlPrize').multipleSelect("getSelects").toString();
            var ExpertName = $('#txtExpertName').val();
            var AwardCode = $('#ddlAwardCode').multipleSelect("getSelects").toString();

            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage, DeclarationName, DeclarationUnit, PrizeID, ExpertName, AwardCode);
        }

        function InitTable(PerPage, CuttentPage, DeclarationName, DeclarationUnit, PrizeID, ExpertName, AwardCode) {
            $('#tbList').bootstrapTable('destroy');
            window.operateEvents = {
                'click .search': function (e, value, row, index) {
                    $('#ReviewContent').html(row.ExpertReviewComment);
                    $("#Review").css("display", "block");
                }
            }
            $.ajax({
                url: '../Mutual/ActivityManage.ashx',
                type: "post",
                data: {
                    "Action": "GetReviewList",
                    "PageSize": PerPage,
                    "CuttentPage": CuttentPage,
                    "DeclarationName": DeclarationName,
                    "DeclarationUnit": DeclarationUnit,
                    "PrizeID": PrizeID,
                    "ExpertName": ExpertName,
                    "AwardCode": AwardCode
                },
                success: function (data) {
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
                        uniqueId: "DeclarationID",            //每一行的唯一标识，一般为主键列
                        columns: [
                            { checkbox: true },
                            { field: 'DeclarationName', title: '项目名称', align: 'left', valign: 'middle' },
                            { field: 'PrizeName', title: '申报奖项', align: 'center', valign: 'middle' },
                            { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                            { filed: 'AwardCodeText', title: '获奖等级', align: 'center', valign: 'middle' },
                            { field: 'ExpertReviewerName', title: '评审人', align: 'center', valign: 'middle' },
                            {
                                field: 'ExpertReviewTime', title: '评审日期', align: 'center', valign: 'middle',
                                formatter: function (value, row, index) {
                                    if (value == null || value == "")
                                        return "";
                                    else
                                        return dateFtt("yyyy-MM-dd", new Date(value));
                                }
                            },
                            { field: 'details', title: '评审内容', align: 'center', valign: 'middle', events: operateEvents, formatter: operateFormatter },
                        ]
                    };
                    option.data = Row.List;

                    $('#tbList').bootstrapTable(option);

                    $("#divPagination").empty();
                    $("#divPagination").append(recordsCount(Row.RecordNumber, Row.CuttentPage, Row.PerPage));
                    $("#divPagination").append(myPaginationLinks(Row.RecordNumber, Row.CuttentPage, Row.PagesCount, "page_link", "active", "disabled"));
                    $("#divPagination").append(selectPerPage());
                    $("#per_page_select").val(Row.PerPage);
                }
            });

            $("#tbList th").css("align", "center");

            $("#btn_exportOpinion").prop('disabled', 'true');

            $('#tbList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_exportOpinion').prop('disabled', !($('#tbList').bootstrapTable('getSelections').length));
            });
        }

        $(function () {
            $("#ddlPrize").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });

            $("#ddlAwardCode").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });

            $('#ddlPrize').multipleSelect('checkAll');
            $('#ddlAwardCode').multipleSelect('uncheckAll');

            $('#per_page_select').val('<%=ViewState["PerPage"] ?? 50 %>');

            onSearch();
        });

    </script>
</asp:Content>
