<%@ Page Title="专家评审" Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ExpertReview.aspx.cs" Inherits="Evaluation.View.ExpertElect.ExpertReview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
   <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>
   
    <link href="../../Content/plugins/ui-choose/src/ui-choose.css" rel="stylesheet" />
    <script src="../../Content/plugins/ui-choose/src/ui-choose.js"></script>
    <style>
        .table-bordered>thead>tr>th, .table-bordered>thead>tr>td{border-bottom:solid 3px #FFF}
        .bottom>tbody>tr>td{border-left: dashed 1px #EFEFEF;}
        .table-bordered{border-bottom:solid 3px #CFCFCF;border-top:solid 3px #CFCFCF;}
        .professional{height:30px;}
        .select input[type="text"]{
            padding: 5px 6px!important;border:none;border:1px solid #ccc;margin-left:20px;
        }
        .E_ml{
            margin-left:15px;           
        }
        .Datecontrol {
             width:75%;display:inline-block;position:relative;top:12px;
        }
        #txtDeclarationBeginDate,#txtDeclarationEndDate,#txtEditBeginDate,#txtEditEndDate{
            margin-left:0px!important;
        }  
        .select input[type="text"] {
            margin-left: 0px!important;
        }
        .inquire {
            
        }      
        .input-group-addon {
            height:25px;
            padding:0;
        }
        #content{
            padding-bottom:190px!important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <ul class="navs">
        <li class="nav1" id="main" style="float: left; padding-right: 5px;">
            <a href="#">专家评选</a>
            <span style="padding-left: 5px;">&gt;</span>
        </li>
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="../ExpertElect/ExpertReview.aspx">专家评审</a>
        </li>
    </ul>
    <div class="DeclarationList" style="height:90px;border:1px solid #e1e1e1;border-radius:5px;position:relative;padding:10px;">
        <div class="select" style=" margin: 0 20px 0 0">
            <span>项目名称：
                <asp:TextBox ID="txtDeclarationName" ClientIDMode="Static" runat="server" Width="168px" Height="26px" placeholder="项目名称"></asp:TextBox>
            </span>           
            <span class="E_ml">
                申报单位：
                <asp:TextBox runat="server" ID="txtDeclarationUnit" ClientIDMode="Static" Style="width: 168px;height:25px;"></asp:TextBox>
            </span>            
            <span>　
			    申报奖项： <asp:DropDownList ID="ddlPrizeName" runat="server" ClientIDMode="Static" Style="width: 168px;"></asp:DropDownList>
            </span>
        </div>
        <div >
            <div class="input-group">
                <span> 填报日期：</span>
                <table class="Datecontrol">
                    <tr>
                        <td>
                            <div class="datepicker input-group date">
                                <asp:TextBox ID="txtDeclarationBeginDate" ClientIDMode="Static" runat="server" Height="26px" Width="166px" class="form-control" placeholder="请选择开始日期"></asp:TextBox>
                                <span class="input-group-addon"><i class="fa fa-calendar"  aria-hidden="true"></i></span>
                            </div>
                        </td>
                        <td style="text-align:center" >
                            <span>&nbsp;&nbsp;至&nbsp;&nbsp;</span>
                        </td>
                        <td>
                            <div class="datepicker input-group date">
                                <asp:TextBox ID="txtDeclarationEndDate" ClientIDMode="Static" runat="server" Height="26px"  Width="166px" class="form-control" placeholder="请选择结束日期"></asp:TextBox>
                                <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div >
            <div class="input-group" style="left:512px; top:-38px;">
                <span>　修改日期：</span>
                <table class="Datecontrol">
                    <tr>
                        <td>
                            <div class="datepicker input-group date">
                                <asp:TextBox ID="txtEditBeginDate" ClientIDMode="Static" runat="server" Height="26px"  Width="166px" class="form-control" placeholder="请选择开始日期"></asp:TextBox>
                                <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                            </div>
                        </td>
                        <td >
                            <span>&nbsp;&nbsp;至&nbsp;&nbsp;</span>
                        </td>
                        <td>
                            <div class="datepicker input-group date">
                                <asp:TextBox ID="txtEditEndDate" ClientIDMode="Static" runat="server" Height="26px"  Width="166px" class="form-control" placeholder="请选择结束日期"></asp:TextBox>
                                <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
    <span class="inquire">
        <input type="button" value="查  询" class="btnt" style="width:78px;height:25px;margin:20px auto 0;display:block;padding:0" onclick="onSearch();" />
    </span>
    <br />
    <div id="toolbar" class="btn-group">
        <button id="btn_edit" type="button" class="btn btn-default" onclick="onEdit();">
            <span class="fa fa-pencil" aria-hidden="true"></span>&nbsp;评审
        </button>
    </div>
    <table id="tbList" data-reorderable-columns="true"></table>
    <div id="divPagination" style="overflow: hidden; margin-top: 10px;"></div>
    <script>
       
        function MaxColor() {
            if ($('#tbList tbody tr').length > 0 && $('#tbList tbody tr td').text() != "没有找到匹配的记录") {
                for (var i = 0; i < $('#tbList tbody tr').length; i++) {
                    var type = getIdSelections()[i].ExpertType                   
                    if (type == "组长（主审）") {
                            //$('#tbList').find("tr").eq(i + 1).find("td").attr("style", "background-color:#fff;")
                         $('#tbList').find("tr").eq(i + 1).find("td").css('background-color','#fff')
                        }               
                    if (type == "意见填写人") {
                            $('#tbList').find("tr").eq(i + 1).find("td").css('background-color','#fff')
                    }
                    if (type == "组员") {
                            $('#tbList').find("tr").eq(i + 1).find("td").css('background-color','#fff')
                    }
                }
            }
        }

        function onSearch(PerPage, CuttentPage) {
            var DeclarationName = $('#txtDeclarationName').val().trim();
            var DeclarationUnit = $('#txtDeclarationUnit').val().trim();
            var PrizeName = $('#ddlPrizeName').multipleSelect("getSelects").toString();
            var DeclarationBeginDate = $('#txtDeclarationBeginDate').val();
            var DeclarationEndDate = $('#txtDeclarationEndDate').val();
            var EditBeginDate = $('#txtEditBeginDate').val();
            var EditEndDate = $('#txtEditEndDate').val();
            var DeclarationStatus = $('#ddlDeclarationStatus option:selected').val();

            if (PerPage == null || PerPage == "") {
                PerPage = $('#per_page_select').val();
            }

            if (CuttentPage == null || CuttentPage == "") {
                CuttentPage = 1;
            }

            InitTable(PerPage, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, DeclarationBeginDate, DeclarationEndDate, EditBeginDate, EditEndDate);
        }

        function getIdSelectionsDeclarationID() {
            return $.map($('#tbList').bootstrapTable('getSelections'), function (row) {
                return row.DeclarationID
            });
        }

        function operateFormatter(value, row, index) {
            return [
                '<a class="edit" href="javascript:void(0)" title="评审">',
                '<i class="fa fa-edit"></i>',
                '</a>  ',
            ].join('');
        }

        function onEdit() {            
            var DeclarationID = getIdSelectionsDeclarationID();
            location.href = "../Declaration/Declaration.aspx?DeclarationID=" + DeclarationID + "&Situation='ExpertReview'";;//location.href实现客户端页面的跳转 
        }

        function InitTable(PageSize, CuttentPage, DeclarationName, DeclarationUnit, PrizeName, DeclarationBeginDate, DeclarationEndDate, EditBeginDate, EditEndDate) {
            $('#tbList').bootstrapTable('destroy');
            window.operateEvents = {
                'click .edit': function (e, value, row, index) {
                    location.href = "../Declaration/Declaration.aspx?DeclarationID=" + row.DeclarationID + "&Situation='ExpertReview'";//location.href实现客户端页面的跳转 
                },
            };

            $.ajax({
                url: '../Mutual/Declaration.ashx',
                type: "post",
                data: {
                    "Action": "GetDeclarationExList",
                    "PageSize": PageSize,
                    "CuttentPage": CuttentPage,
                    "DeclarationName": DeclarationName,
                    "DeclarationUnit": DeclarationUnit,
                    "PrizeName": PrizeName,
                    "DeclarationBeginDate": DeclarationBeginDate,
                    "DeclarationEndDate": DeclarationEndDate,
                    "EditBeginDate": EditBeginDate,
                    "EditEndDate": EditEndDate,
                    "ExpertReview": "ExpertReview"
                },
                success: function (data) {
                    if (data != "") {
                        var Row = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbar',                //工具按钮用哪个容器
                            striped: true,                      //是否显示行间隔色
                            editable: true,
                            clickToSelect: true,
                            showColumns: true,                  //是否显示所有的列
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "DeclarationID",            //每一行的唯一标识，一般为主键列
                            columns: [
                                { checkbox: true },
                                {
                                    field: 'DeclarationName', title: '项目名称', align: 'left', valign: 'middle',
                                    cellStyle: function () { return { css: { "text-align": "left" } } }
                                },
                                { field: 'PrizeName', title: '申报奖项', align: 'center', valign: 'middle' },
                                { field: 'OrganizationName', title: '申报单位', align: 'center', valign: 'middle' },
                                { field: 'operate', title: '操作', align: 'center', events: operateEvents, formatter: operateFormatter },
                                { field: 'ExpertType', title: '专家角色', align: 'center', valign: 'middle', visible: true }
                            ]
                        };
                        option.data = Row.Table;
                        $('#tbList').bootstrapTable(option);
                        //MaxColor();
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

            $('#btn_edit').prop('disabled', "true");
            $('#tbList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
                $('#btn_delete').prop('disabled', !$('#tbList').bootstrapTable('getSelections').length);
                $('#btn_edit').prop('disabled', !($('#tbList').bootstrapTable('getSelections').length == 1));
            });
        }

        $(function () {
            $("#ddlPrizeName").multipleSelect({
                selectAllText: '<span>全选</span>',
                allSelected: '全选',
                countSelected: '# 至 % 选中',
                noMatchesFound: '暂无选项',
            });

            $('select').multipleSelect('checkAll');
            var PerPage = '<%=ViewState["PerPage"] ?? 200 %>';
            var CuttentPage = '<%=ViewState["CuttentPage"] ?? 1 %>'
            InitTable(PerPage, CuttentPage);
        });
        $(".form-control").each(function () {
            $(this).css("margin-left", "25px")
        });
        $(".input-group-addon i").each(function () {
            $(this).css("padding-left", "5px")
            $(this).css("padding-right", "5px")
        });
        function getIdSelections() {
            return $.map($('#tbList').bootstrapTable('getData'), function (data) {
                return data;
            })
        };
    </script>
</asp:Content>
