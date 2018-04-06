<%@ Page Title="专家组添加人员" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="GroupMember.aspx.cs" Inherits="Evaluation.View.ExpertManage.GroupMember" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">评优管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ExpertManage/GroupList">专家组管理</a>
        </li>        
    </ul>
    <div>
        <asp:Label ID="labExpertGroupName" runat="server" Text="Label" style="font-size:15px;margin:5px 0 5px 0;display:block;font-weight:600;"></asp:Label>
        <asp:TextBox ID="txtExpertGroupID" runat="server" ClientIDMode="Static"></asp:TextBox>
        <asp:HiddenField ID="hfSpecialtyID" runat="server" ClientIDMode="Static" />
        <table id="tbExpertGroupMemberList"></table>
    </div>
    <span style="font-size:15px;margin:20px 0 5px 0;display:block;font-weight:600;">请从下面表格里选择要加入组的专家</span>
    <div>
        <table id="tbExpertList"></table>
    </div>
    <div style="width:80px;margin:30px auto;">
        <asp:Button runat="server" ID="btnBack" class="btnt" text="返   回" OnClick="btnBack_Click" />
    </div>
     <script type="text/javascript">
      
         var GroupID = $("#txtExpertGroupID").val();

         $(function () {
             $("#txtExpertGroupID").hide();
             InitTable();
             InitTableExpert()
         });
             
         function InitTable() {
             $("#tbExpertGroupMemberList").bootstrapTable('destroy');
             var option2 = {
                 striped: true,                      //是否显示行间隔色                
                 showColumns: false,                  //是否显示所有的列
                 showRefresh: false,                  //是否显示刷新按钮
                 minimumCountColumns: 1,             //最少允许的列数
                 sidePagination: "client",
                 uniqueId: "ExpertGroupMemberID",            //每一行的唯一标识，一般为主键列
                 columns: [
                        { field: 'ExpertName', title: '专家姓名', align: 'center', valign: 'middle' },
                        { field: 'GroupName', title: '专家组', align: 'center', valign: 'middle' },
                        { field: 'GradeValue', title: '身份', align: 'center', valign: 'middle' },
                        {
                            title: '操作', align: 'center', valign: 'middle',
                            events: {
                                'click .DelMember': function (e, value, row, index) {
                                    $.ajax({
                                        url: '../Mutual/ExpertManage.ashx',
                                        type: "post",
                                        data: {
                                            "Action": "DelExpertGroupMember",
                                            "ExpertID": row.ExpertID,
                                            "GroupID": GroupID
                                        },
                                        success: function (data) {
                                            $('#tbExpertGroupMemberList').bootstrapTable('remove', {
                                                field: 'ExpertID',
                                                values: [row.ExpertID]
                                            });
                                            InitTableExpert();
                                        }
                                    });
                                }
                            },
                            formatter: function (value, row, index) {
                                if (row.Grade == 1201 || row.Grade == 1202) {
                                    return [
                                    '<a href="javascript:void(0)" title="移除">',
                                    '<i class="fa fa-trash-o" style="font-size:18px;color:rgba(0,0,0,0.2)"></i>',
                                    '</a>  '
                                    ].join('');
                                }
                                else {
                                    return [
                                    '<a class="DelMember" href="javascript:void(0)" title="移除">',
                                    '<i class="fa fa-trash-o" style="font-size:18px;"></i>',
                                    '</a>  '
                                    ].join('');
                                }
                            }
                        }
                 ],
             };
             $.ajax({
                 url: '../Mutual/ExpertManage.ashx',
                 type: "post",
                 data: {
                     "Action": "ExpertGroupMemberList",
                     "GroupID": GroupID
                 },
                 success: function (data) {
                     if (data != "") {
                         var Row = JSON.parse(data)
                         option2.data = Row;
                         $('#tbExpertGroupMemberList').bootstrapTable(option2);
                     } else {
                         $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbExpertGroupMemberList'));
                     }
                 }
             });
         };
         function InitTableExpert() {
             $("#tbExpertList").bootstrapTable('destroy');
             var option = {
                 striped: true,                      //是否显示行间隔色
                 showColumns: false,                  //是否显示所有的列
                 showRefresh: false,                  //是否显示刷新按钮
                 minimumCountColumns: 1,             //最少允许的列数
                 sidePagination: "client",
                 uniqueId: "ExpertID",            //每一行的唯一标识，一般为主键列
                 columns: [
                     { field: 'ExpertName', title: '专家姓名', align: 'center', valign: 'middle' },
                     { field: 'IDTypeText', title: '证件类别', align: 'center', valign: 'middle' },
                     { field: 'IDNumber', title: '证件号码', align: 'center', valign: 'middle' },
                     { field: 'AcademicTitle', title: '职称', align: 'center', valign: 'middle' },
                     { field: 'Profession', title: '研究方向', align: 'center', valign: 'middle' },
                     { field: 'SpecialtyNames', title: '评优专业', align: 'center', valign: 'middle' },
                     { field: 'Workplace', title: '工作单位', align: 'center', valign: 'middle' },
                     {
                         title: '操作', align: 'center', valign: 'middle',
                         events: {
                             'click .addMember': function (e, value, row, index) {
                                 $.ajax({
                                     url: '../Mutual/ExpertManage.ashx',
                                     type: "post",
                                     data: {
                                         "Action": "AddExpertGroupMember",
                                         "ExpertID": row.ExpertID,
                                         "GroupID": GroupID
                                     },
                                     success: function (data) {
                                         $('#tbExpertList').bootstrapTable('remove', {
                                             field: 'ExpertID',
                                             values: [row.ExpertID]
                                         });
                                         InitTable();
                                     }
                                 });
                             }
                         },
                         formatter: function (value, row, index) {
                             return [
                                 '<a class="addMember" href="javascript:void(0)" title="添加">',
                                 '<i class="fa  fa-check"></i>',
                                 '</a>  '
                             ].join('');
                         }
                     }
                 ]
             };
             $.ajax({
                 url: '../Mutual/ExpertManage.ashx',
                 type: "post",
                 data: {
                     "Action": "GetExpertOutsideGroup",
                     "GroupID": GroupID,
                     "SpecialtyID": $("#hfSpecialtyID").val()
                 },
                 success: function (data) {
                     if (data != "") {
                         var Row = JSON.parse(data);
                         option.data = Row;
                         $('#tbExpertList').bootstrapTable(option);
                     } else {
                         $('<tr><td>没有找到匹配的记录</td></tr>').appendTo($('#tbExpertList'));
                     }
                 }
             });
         }
     </script>
</asp:Content>
