<%@ Page Title="奖项管理" Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="PrizeList.aspx.cs" Inherits="Evaluation.View.ActivityManage.PrizeList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>       
        .table tbody>tr>td{
            border-top:0;
        }
        #ContentPlaceHolder1_btnSearchPrice{
            padding: 6px 30px;width:auto;margin-left:25px;margin-right:5px;
        }
        #btnSearchPrice{
            width:102px;
            margin-left:23px;margin-right:10px;
        }
        .btnt{
            width:100px!important;
        }
        .condition {
            width:100%;
            border:1px solid #e1e1e1;
            border-radius:5px;
            padding:10px;
            margin-bottom:15px;
            height:48px;
        }
         .ms-choice,.ms-choice span {
            height:25px;
            line-height:25px;
        }
        .btnt {
            padding:0;
            line-height:25px;
            height:25px;
            width: 78px!important;
        }

        a.btnt, #lbkSearch {
            width:78px;
            padding:0;
            height:25px;
            line-height:25px;
            display:inline-block;
            text-align:center                
        }
        .rbtn {
            width:200px;
            margin:0 auto;
        }
         .condition input{height:25px}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">评优管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ActivityManage/PrizeList.aspx">奖项管理</a>
        </li>        
    </ul>
    <div style="padding-bottom:90px;">
    <div class="condition">
        <span>选择专业 :&nbsp; </span>
        <asp:DropDownList ID="ddlSpecialtyID" runat="server" ClientIDMode="Static" Style="width: 168px;">
        </asp:DropDownList>
    </div>
    <div class="rbtn">
        <input type="button" id="btnSearchPrice" value="查 &nbsp;&nbsp; 询" class="btnt" onclick="onSearch();" />
    </div> 
        <div>
         <div id="toolbar" class="btn-group">
                <button id="btn_add" type="button" class="btn btn-default" onclick="onAdd()">
                    <span class="fa fa-plus" aria-hidden="true"></span>&nbsp;新增
                </button>
                <button id="btn_delete" type="button" class="btn btn-default" onclick="onDelete()">
                    <span class="fa fa-trash" aria-hidden="true"></span>&nbsp;删除（批量）
                </button>
            </div>
           <table id="tbPrizeList" data-reorderable-columns="true"></table>
           <div id="divPagination" style="overflow:hidden;margin-top:10px;"></div>
           </div>
           <input id="PerPageNum" type="text" hidden="hidden" />
           <input id="CuttentPageNum" type="text" hidden="hidden" />    
   </div>    
   <script>   
       function getRecipientsName() {
           return $.map($('#tbPrizeList').bootstrapTable('getSelections'), function (row) {
               return row.PrizeType
           });
       }
       function operateFormatter(value, row, index) {
           return [
               '<a class="edit" href="javascript:void(0)" title="编辑">',
               '<i class="fa fa-edit"></i>',
               '</a>  ',
               '<a class="remove" href="javascript:void(0)" title="删除">',
               '<i class="fa  fa-trash"></i>',
               '</a>',
           ].join('');
       }

       function onSearch(PerPage, CuttentPage) {
           var Specialtys = $("#ddlSpecialtyID").multipleSelect("getSelects");

           if (PerPage == null || PerPage == "") {
               PerPage = $('#per_page_select').val();
           }

           if (CuttentPage == null || CuttentPage == "") {
               CuttentPage = 1;
           }

           InitTable(PerPage, CuttentPage, Specialtys.toString());
       }

       function InitTable(PageSize, CuttentPage, Specialtys) {
           $("#tbPrizeList").bootstrapTable('destroy');
           window.operateEvents = {
               'click .edit': function (e, value, row, index) {
                   window.location = "../ActivityManage/PrizeSet.aspx?PrizeID=" + row.PrizeID + ""
               },
               'click .remove': function (e, value, row, index) {
                   ShowMessags('确定要删除吗?')
                   $(".layui-layer-btn0").click(function () {
                       $.ajax({
                           url: "../Mutual/ActivityManage.ashx",
                           type: "post",
                           data: { "Action": "DelPrize", "PrizeID": row.PrizeID,"DelSpecialtysID":row.SpecialtysID },
                           success: function (data) {
                               $("body").attr("class", "breakpoint-1200");
                               $(".modal-backdrop").remove();
                               if (data == "success") {
                                   $('#tbPrizeList').bootstrapTable('remove', {
                                       field: 'PrizeID',
                                       values: [row.PrizeID]
                                   });

                               } else {
                                   ShowMessag(data);
                               }
                           }
                       });
                   });
               }
           }

           $.ajax({
               url: "../Mutual/ActivityManage.ashx",
               type: "post",
               data: {
                   "Action": "GetPrizeList",
                   "Specialtys": Specialtys,
                   "PageSize": PageSize,
                   "CuttentPage": CuttentPage
                },
               success: function (data) {
                   if (data != "") {
                       var Row = JSON.parse(data)
                       var option = {
                           toolbar: "#toolbar",
                           striped: true,                      //是否显示行间隔色
                           showColumns: true,                  //是否显示所有的列
                           showRefresh: false,                 //是否显示刷新按钮
                           clickToSelect: true,
                           minimumCountColumns: 1,             //最少允许的列数
                           sidePagination: "client",
                           uniqueId: "PrizeID",
                           checkbox: "true",
                           queryParams: "",//传递参数（*）
                           columns: [
                               { checkbox: true },
                               { field: 'Ordinal', title: '序号', align: 'center', Valign: 'middle', visible: false },
                               { field: 'PrizeName', title: '奖项名称', align: 'center', Valign: 'middle' },
                               { field: 'SpecialtyName', title: '专业', align: 'center', Valign: 'middle' },
                               { field: 'PrizeType', title: '奖项类别', align: 'center', Valign: 'middle' },
                               { field: 'VoteTypeText', title: '投票方式', align: 'center', Valign: 'middle' },
                               { field: 'FirstPrize', title: '一等奖数量', align: 'center', Valign: 'middle' },
                               { field: 'SecondPrize', title: '二等奖数量', align: 'center', Valign: 'middle' },
                               { field: 'ThirdPrize', title: '三等奖数量', align: 'center', Valign: 'middle' },
                               { field: 'AwardCount', title: '获奖名额', align: 'center', Valign: 'middle' },
                               { field: 'ParticipantLimit', title: '项目人员数量', align: 'center', Valign: 'middle' },
                               {
                                   title: '操作', align: 'center', Valign: 'middle',
                                   events: operateEvents,
                                   formatter: operateFormatter
                               }],
                           onEditableSave: function (field, row, oldValue, $e1) {
                               $.ajax({
                                   type: "post",
                                   url: "",
                                   data: {},
                                   succcess: function (data, status) {
                                       if (data == "success") {
                                       }
                                   },
                                   error: function (data) {
                                       ShowMessag(data);
                                   }
                               });
                           }
                       };
                       option.data = Row.Table;
                       $("#tbPrizeList").bootstrapTable(option);
                       $("#divPagination").empty();
                       $("#divPagination").append(recordsCount(Row.RecordNumber, Row.CuttentPage, Row.PerPage));
                       $("#divPagination").append(myPaginationLinks(Row.RecordNumber, Row.CuttentPage, Row.PagesCount, "page_link", "active", "disabled"));
                       $("#divPagination").append(selectPerPage());
                       $("#per_page_select").val(Row.PerPage);
                       $('#tbPrizeList th[data-field="11"]').css('width', '55px');
                   } else {
                       $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbPrizeList'));
                   }
               }
           });
           $('#btn_delete').prop('disabled', "true");

           $('#tbPrizeList').on('check.bs.table uncheck.bs.table check-all.bs.table uncheck-all.bs.table', function () {
               $('#btn_delete').prop('disabled', !$('#tbPrizeList').bootstrapTable('getSelections').length);
           });
       }

       function getIdSelections() {
           return $.map($('#tbPrizeList').bootstrapTable('getSelections'), function (row) {
               return row.PrizeID
           });
       }
  
       function onAdd() {
           window.location = "PrizeSet.aspx";
       }

       function onDelete() {
           var PrizeID = getIdSelections();
           PrizeID = PrizeID.join(",");
           ShowMessags("确认要删除吗？");
           $('.layui-layer-btn0').on('click', function () {
               $.ajax({
                   url: '../Mutual/ActivityManage.ashx',
                   type: "post",
                   data: { "Action": "MultiselectDelPrize", "PrizeID": PrizeID },
                   success: function (data) {
                       if (data == "删除成功!") {
                           var PerPage = $("#per_page_select").val();
                           var CuttentPage = $("#pagination_links li a.active")[0].text;
                           InitTable(PerPage, CuttentPage);
                       } else {
                           ShowMessag(data);
                       }
                   }
               })
           })
       }

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
           onSearch(PerPage, CuttentPage);

           $("#ddlSpecialtyID").multipleSelect({
               selectAllText: '<span>全选</span>',
               allSelected: '全选',
               countSelected: '# 至 % 选中',
               noMatchesFound: '暂无选项',
           });
           $('#ddlSpecialtyID').multipleSelect('checkAll');          
       });

    </script>      
  </asp:Content>