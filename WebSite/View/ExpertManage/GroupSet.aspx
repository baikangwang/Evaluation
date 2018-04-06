<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="GroupSet.aspx.cs" Inherits="Evaluation.View.ExpertManage.GroupSet" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        input[type="text"] {        
            border: none;
            height:25px;
            line-height:25px;
            padding:0;
            border: 1px solid #ccc;
            background: #fff;
            width:168px;         
        }
        input[readonly]{
            cursor:pointer;
            color:#000;
        }
        select{
            border: none;
            height:25px;
            line-height:25px;
            padding:0;
            border: 1px solid #ccc;
            background: #fff;
            width:168px;
        }
      
        #ContentPlaceHolder1_btnSaveExpertGroup{
             margin:20px 10px 0 43%;
        }
        .fixed-table-container {
         border:none!important;  
    }
        #per_page_select{
            width:60px;
        }
        #tipMessage{
            border:none;background:#eee;font-weight: bold;
        }
       
    </style>
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
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <asp:HiddenField runat="server" ID="hfParentID" ClientIDMode="Static" />
    <div style="border:1px solid #E1E1E1; width:100%;border-radius:4px;padding:15px;">
           <div style="margin-bottom:15px;">
            <span style="padding-left:63px;">专　业：</span>
            <asp:DropDownList runat="server" ID="ddlSpecialty" ClientIDMode="Static" Style="width: 168px;"></asp:DropDownList>
            <span style="margin-left:30px;">　专家组名：</span>
            <asp:TextBox ID="txtExpertGroupName" runat="server" ClientIDMode="Static"></asp:TextBox>
            <span style="margin-left:25px;">上级专家组：</span>
            <asp:DropDownList runat="server" ID="ddlParentGroup" ClientIDMode="Static" Style="width: 168px;"></asp:DropDownList>           
            </div>                      
            <span>专家组组长/主审：</span>
            <asp:TextBox ID="txtExpertGroupLeader" runat="server" ClientIDMode="Static"></asp:TextBox>
            <input type="text" id="txtExpertGroupLeaderText" runat="server" ClientIDMode="Static" readonly="readonly"/>
            <span style="padding-left:25px;">副组长/副审：</span>          
            <asp:TextBox ID="txtDeputyLeader" runat="server" ClientIDMode="Static"></asp:TextBox>
            <input type="text" id="txtDeputyLeaderText" runat="server" ClientIDMode="Static" readonly="readonly"/>
    
    </div>
    <asp:Button ID="btnSaveExpertGroup" runat="server" Text="保  存" class="btnt" OnClick="btnSaveExpertGroup_Click" />
    <asp:Button ID="btnCancel" runat="server" Text="返  回" class="btnt" OnClick="btnCancel_Click"/>
 
    <hr />
    <div style="padding-bottom:66px;">
        <input id="tipMessage" style="width:150px" hidden="hidden" />
        <table id="tbExpertList" hidden="hidden"></table>
        <div id="divPagination" style="overflow: hidden; margin-top: 10px;"></div>
    </div>
    <script type="text/javascript">      

        function InitTable(PageSize, CuttentPage) {
            $.ajax({
                url: '../Mutual/ExpertManage.ashx',
                type: "post",
                data: {
                    "Action": "GetSpecialtyExpertList",
                    "PageSize": PageSize,
                    "CuttentPage": CuttentPage,
                    "SpecialtyID": $("#ddlSpecialty").val()
                },
                success: function (data) {
                    $("#tbExpertList").bootstrapTable('destroy');
                    if (data != "") {
                        var Row = JSON.parse(data)
                        var option = {
                            toolbar: '#toolbar',                //工具按钮用哪个容器
                            striped: true,                      //是否显示行间隔色
                            showColumns: false,                  //是否显示所有的列
                            editable: false,
                            showRefresh: false,                  //是否显示刷新按钮
                            minimumCountColumns: 1,             //最少允许的列数
                            sidePagination: "client",
                            uniqueId: "ExpertID",            //每一行的唯一标识，一般为主键列
                            columns: [
                                { field: 'ExpertName', title: '专家姓名' },
                                { field: 'IDTypeText', title: '证件类别' },
                                { field: 'IDNumber', title: '证件号码' },
                                { field: 'AcademicTitle', title: '职称' },
                                { field: 'Profession', title: '研究方向' },
                                {
                                    field: 'SpecialtyNames', title: '评优专业',
                                    cellStyle: function (value, row, index) { return { css: { "width": "300px" } } }
                                },
                                { field: 'Workplace', title: '工作单位' },
                                {
                                    title: '操作', align: 'center', events: {
                                        'click .Leader': function (e, value, row, index) {
                                            if ($("#tipMessage").data("Type") == "GroupLeader") {
                                                $("#txtExpertGroupLeader").val(row.ExpertID);
                                                $("#txtExpertGroupLeaderText").val(row.ExpertName);
                                            }
                                            else {
                                                $("#txtDeputyLeader").val(row.ExpertID);
                                                $("#txtDeputyLeaderText").val(row.ExpertName);
                                            }
                                            $("#tbExpertList").hide();
                                            $("#divPagination").hide();
                                            $("#tipMessage").hide();
                                        }
                                    }, formatter: function (value, row, index) {
                                        return [
                                            '<a class="Leader" href="javascript:void(0)" title="添加">',
                                            '<i class="fa fa-check"></i>',
                                            '</a>  '
                                        ].join('');
                                    }
                                }
                            ],
                        };

                        option.data = Row.Table;
                        $('#tbExpertList').bootstrapTable(option);
                        $("#divPagination").empty();
                        $("#divPagination").append(recordsCount(Row.RecordNumber, Row.CuttentPage, Row.PerPage));
                        $("#divPagination").append(myPaginationLinks(Row.RecordNumber, Row.CuttentPage, Row.PagesCount, "page_link", "active", "disabled"));
                        $("#divPagination").append(selectPerPage());
                        $("#per_page_select").val(Row.PerPage);
                        $('#tbExpertList th[data-field="SpecialtyNames"] .th-inner').css({ 'width': '300px', 'margin': '0 auto' });
                    }
                }
            });
        }

        function InitParent() {
            console.log($("#ddlSpecialty").val());
            $.ajax({
                url: '../Mutual/ExpertManage.ashx',
                type: "post",
                async: false,
                data: {
                    "Action": "GetParentGroup",
                    "SpecialtyID": $("#ddlSpecialty").val()
                },
                success: function (data) {
                    if (data != "") {
                        data = JSON.parse(data);
                        $("#ddlParentGroup").empty();
                        if (data.length > 0) {
                            for (var i = 0; i < data.length; i++) {
                                if (data[i].GroupName != $("#txtExpertGroupName").val()) {
                                    $("<option value='" + data[i].GroupID + "'>" + data[i].GroupName + "</option>").appendTo($("#ddlParentGroup"));
                                }
                            }
                        }
                        $("<option value='0'>无</option>").appendTo($("#ddlParentGroup"));
                        $("#ddlParentGroup  option[value='" + $('#hfParentID').val() + "'] ").attr("selected", true);
                        $("#ddlParentGroup").val($('#hfParentID').val());
                    }
                }
            });
        }

        $(function () {
            $("#txtExpertGroupLeader").hide();
            $("#txtDeputyLeader").hide();
            $("#divPagination").hide();

            var msg = $("#hdMsg").val();
            if (msg != "") {
                ShowMessag(msg);
                if (msg == "保存成功!") {
                    $('.layui-layer-btn0').on('click', function () {
                        window.location = "../../view/ExpertManage/GroupList.aspx";
                    });
                }
            }

            $("#txtExpertGroupLeaderText").focus(function () {
                $("#tbExpertList").show();
                $("#divPagination").show();
                $("#tipMessage").val("请选择专家组组长/主审");
                $("#tipMessage").data("Type", "GroupLeader");
                $("#tipMessage").show();
            });

            $("#txtDeputyLeaderText").focus(function () {
                $("#tbExpertList").show();
                $("#divPagination").show();
                $("#tipMessage").val("请选择副组长/副审");
                $("#tipMessage").data("Type", "DeputyLeader");
                $("#tipMessage").show();
            });

            $('.ms-parent').on('click', function () {
                $("#tipMessage").hide();
                $("#tbExpertList").hide();
                $("#divPagination").hide();
            });

            $('#txtExpertGroupName').on('click', function () {
                $("#tipMessage").hide();
                $("#tbExpertList").hide();
                $("#divPagination").hide();
            });

            $("#ddlParentGroup").change(function () {
                $('#hfParentID').val($("#ddlParentGroup").val());
            });

            if (GetQueryString("GroupID") != null) {
                $("#ddlSpecialty").multipleSelect('disable');
            }
            else {
                $("#ddlSpecialty").change(function () {
                    $("#txtExpertGroupLeaderText").val("");
                    $("#txtExpertGroupLeader").val("");
                    $("#txtDeputyLeaderText").val("");
                    $("#txtDeputyLeader").val("");
                    InitParent();
                    InitTable(50, 1);
                });
            }
            InitParent();
            InitTable(50, 1);

        });
    </script>
</asp:Content>
