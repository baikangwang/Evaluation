<%@ Page Title="活动管理" Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="CreateActivity.aspx.cs" Inherits="Evaluation.View.ActivityManage.CreateActivity" %>

<%@ Register TagPrefix="uc" TagName="Schedule" Src="~/View/ActivityManage/Schedule.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        input[disabled] {
            background-color: none;
        }

        input[type="text"] {
            padding: 3px 6px !important;
            border: none;
            border: 1px solid #ccc;
            background: #fff;
            margin-right: 20px;
        }

        .table-hover tbody > tr > th:hover {
            background-color: #aee8e3;
        }

        .table-hover tbody tr:hover > th {
            background-color: #aee8e3;
        }
        .btn:hover {
            color: #fff;
            background-color: #33B0BA;
        }

        .table {
            width: auto;
        }

        .fa-save:before, .fa-floppy-o:before {
            content: "";
        }

        label, button, select, textarea {
            font-size: 14px !important;
            font-weight: normal;
        }

        .table.table-bordered.table-hover {
            min-width: 765px;
            overflow: hidden;
            border: 1px solid #ccc;
        }

            .table.table-bordered.table-hover > tbody > tr > th {
                border: 0;
                background: #85E1E1;
            }

        .table-bordered > tbody > tr > td {
            border: 0;
        }
        #ContentPlaceHolder1_lkbFinishActivity{
            width:150px;
        }
        /*结束评优活动*/
        #ContentPlaceHolder1_panelCreateActivity > table > tbody > tr > td {
            padding-right:4px;
        }

        #ContentPlaceHolder1_panelCreateActivity label {
            display: inline-block;
            margin-bottom: 0px;
        }

        #ContentPlaceHolder1_panelCreateActivity .btn-primary {
            width:78px;
            border-radius: 4px;
            background: #33B0BA;
            color: #fff;
            border: none;          
            font-size: 13px;
            height:25px;
            line-height:13px;
        }

        #ContentPlaceHolder1_panelCreateActivity .table {
            width: 100%;
        }
        #ContentPlaceHolder1_lkbCreateActivity{
            line-height:16px!important;
        }
            #ContentPlaceHolder1_panelCreateActivity .table tbody > tr:last-child td {
                padding: 8px 8px;
            }
             .condition {
            width:100%;
            border:1px solid #e1e1e1;
            border-radius:5px;
            padding:10px;
            margin-bottom:15px;
        }
        .condition input{height:26px}
        #lkbSetSchedule{
            width:78px;
            padding:0;
            height:26px;
            line-height:26px;
            margin-top:12px;         
        }
       
        #ContentPlaceHolder1_txtCurrentActivity{
            width:270px;
        }
       .inpcheck{  
        background:#EDEDED;padding:20px 0 15px 0!important;
    }
       .input-group.date .input-group-addon {
        cursor:default;
      }
       #Table select{
           display:none;
       }
       #Table tbody > tr:nth-child(2) > td{
           background:#fff;
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">评优管理</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="../ActivityManage/CreateActivity.aspx">活动管理</a>
        </li>        
    </ul>
    <div style="width:auto; margin: auto; margin-left: 0;" id="div;">  
        <asp:Panel runat="server" ID="panelActivityInfo" ClientIDMode="Static">
                <div class="condition">
                    <label>当前评优活动：</label>
                    <asp:TextBox ID="txtCurrentActivity" runat="server" Enabled="false"></asp:TextBox>
                    <asp:LinkButton runat="server" ID="lkbFinishActivity" class="btn btnt" OnClick="lkbFinishActivity_Click">
                        结束本次评优活动
                    </asp:LinkButton>
                </div>             
                <br />
                <uc:Schedule runat="server" ID="ucSchedule"></uc:Schedule>
                <table id="tb_CreateActivity"></table>
            </asp:Panel>
        <asp:Panel runat="server" ID="panelCreateActivity">
            <table>
                <tr>
                    <td>
                        <label>活动名称：</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtActivityName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <label>当前活动类别：</label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtActivityType" runat="server" Enabled="false"></asp:TextBox>
                    </td>
                    <td>
                        <asp:LinkButton runat="server" ID="lkbCreateActivity" class="btn btn-primary btn-sm"
                            OnClick="lkbCreateActivity_Click">
                                创&nbsp;&nbsp;建
                        </asp:LinkButton>
                        <%--<asp:Button ID="btnCreateActivity" runat="server" Text="创建评优活动" class="btn btn-primary btn-sm" OnClick="btnCreateActivity_Click" />--%>
                    </td>
                </tr>
            </table>
            <br />

            <asp:GridView ID="gvActivity" class="table table-striped table-bordered table-hover" runat="server"
                AutoGenerateColumns="False" AllowSorting="true"
                DataKeyNames="ActivityID"
                AllowPaging="False"
                OnRowCommand="gvActivity_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="评优活动名称" HeaderStyle-CssClass="table_head_center warning">
                        <ItemTemplate>
                            <asp:Label ID="ActivityName" runat="server" Text='<%# Bind("ActivityName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" HorizontalAlign="Center" />
                    </asp:TemplateField>
<%--                    <asp:TemplateField HeaderText="评优活动类别" HeaderStyle-CssClass="table_head_center warning">
                        <ItemTemplate>
                            <asp:Label ID="ActivityTypeName" runat="server" Text='<%# Bind("ActivityTypeName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" HorizontalAlign="Center" />
                    </asp:TemplateField>--%>
                    <asp:TemplateField HeaderText="活动状态" HeaderStyle-CssClass="table_head_center warning">
                        <ItemTemplate>
                            <asp:Label ID="ActivityStatusName" runat="server" Text='<%# Bind("ActivityStatusName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="创建时间" HeaderStyle-CssClass="table_head_center warning">
                        <ItemTemplate>
                            <asp:Label ID="CreateTime" runat="server" Text='<%# Bind("CreateTime", "{0:d}") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="结束时间" HeaderStyle-CssClass="table_head_center warning">
                        <ItemTemplate>
                            <asp:Label ID="LastUpdateTime" runat="server" Text='<%# Bind("LastUpdateTime", "{0:d}") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" HorizontalAlign="Center" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="激活" HeaderStyle-CssClass="table_head_center warning">
                        <ItemTemplate>
                            <asp:LinkButton ID="Activate" runat="server" CommandName="Activate" CommandArgument='<%# ""+Eval("ActivityID") %>'
                                class="btn btn-primary "> 
                                    重新激活
                            </asp:LinkButton>
                        </ItemTemplate>
                        <ItemStyle Width="50px" HorizontalAlign="Center" />
                    </asp:TemplateField>
<%--                <asp:TemplateField HeaderText="删除" HeaderStyle-CssClass="table_head_center warning">
                        <ItemTemplate>
                            <asp:LinkButton ID="UpdateActivity" runat="server" CommandName="UpdateActivity" CommandArgument='<%# ""+Eval("ActivityID") %>'
                                class="btn btn-primary "> 
                                    删除
                            </asp:LinkButton>
                        </ItemTemplate>
                        <ItemStyle Width="50px" HorizontalAlign="Center" />
                    </asp:TemplateField>--%>
                </Columns>
            </asp:GridView>
        </asp:Panel>
    </div>
    <script type="text/javascript">
        
        $('#ddlIsDeclarationStart').ui_choose();
        $('#ddlIsDeclarationAutoStart').ui_choose();
        $('#ddlIsDeclarationAutoEnd').ui_choose();

        $('#ddlIsPrimaryElectionStart').ui_choose();
        $('#ddlIsPrimaryElectionAutoStart').ui_choose();
        $('#ddlIsPrimaryElectionAutoEnd').ui_choose();

        $('#ddlIsExpertReviewStart').ui_choose();
        $('#ddlIsExpertReviewAutoStart').ui_choose();
        $('#ddlIsExpertReviewAutoEnd').ui_choose();

        $('#ddlIsDownloadStart').ui_choose();
        $('#ddlIsDownloadAutoStart').ui_choose();
        $('#ddlIsDownloadAutoEnd').ui_choose();

        $('#ddlIsVoteStart').ui_choose();
        $('#ddlIsVoteAutoStart').ui_choose();
        $('#ddlIsVoteAutoEnd').ui_choose();

        $('#ddlIsReVoteStart').ui_choose();

        $(".table.table-bordered.table-hover").addClass("table-striped");

        $(function () {
            var msg = $("#hdMsg").val();
            if (msg != "")
            {           
                    ShowMessag(msg);                           
            }

            $('#txtDeclarationBeginDate,#txtPrimaryElectionBeginDate,#txtExpertReviewBeginDate,#txtDownloadBeginDate,#txtDeclarationEndDate,#txtPrimaryElectionEndDate,#txtExpertReviewEndDate,#txtDownloadEndDate,#txtVoteBeginDate,#txtVoteEndDate').css('cursor', 'pointer').datepicker({
                language: "zh-CN",
                format: "yyyy-mm-dd",
                autoclose: true,
                todayHighlight: true,
            });
            $('#txtDeclarationBeginDate').datepicker('setStartDate', Date.now.toString("yyyy-mm-dd"));
            $('#txtPrimaryElectionBeginDate').datepicker('setStartDate', Date.now.toString("yyyy-mm-dd"));
            $('#txtExpertReviewBeginDate').datepicker('setStartDate', Date.now.toString("yyyy-mm-dd"));
            $('#txtDownloadBeginDate').datepicker('setStartDate', Date.now.toString("yyyy-mm-dd"));
            $('#txtVoteBeginDate').datepicker('setStartDate', $('#txtExpertReviewBeginDate').val());
            $('#txtDeclarationEndDate').datepicker('setStartDate', $('#txtDeclarationBeginDate').val());
            $('#txtPrimaryElectionEndDate').datepicker('setStartDate', $('#txtPrimaryElectionBeginDate').val());
            $('#txtExpertReviewEndDate').datepicker('setStartDate', $('#txtExpertReviewBeginDate').val());
            $('#txtDownloadEndDate').datepicker('setStartDate', $('#txtDownloadBeginDate').val());
            $('#txtVoteEndDate').datepicker('setStartDate', $('#txtVoteBeginDate').val());

            //开始时间： 
            $('#txtDeclarationBeginDate').datepicker().on('changeDate', function (e) {
                var startTime = $('#txtDeclarationBeginDate').val();
                $('#txtDeclarationEndDate').datepicker('setStartDate', startTime);
            });
            $('#txtPrimaryElectionBeginDate').datepicker().on('changeDate', function (e) {
                var startTime = $('#txtPrimaryElectionBeginDate').val();
                $('#txtPrimaryElectionEndDate').datepicker('setStartDate', startTime);
            });
            $('#txtExpertReviewBeginDate').datepicker().on('changeDate', function (e) {
                var startTime = $('#txtExpertReviewBeginDate').val();
                $('#txtExpertReviewEndDate').datepicker('setStartDate', startTime);
            });
            $('#txtDownloadBeginDate').datepicker().on('changeDate', function (e) {
                var startTime = $('#txtDownloadBeginDate').val();
                $('#txtDownloadEndDate').datepicker('setStartDate', startTime);
            });
            $('#txtVoteBeginDate').datepicker().on('changeDate', function (e) {
                var startTime = $('#txtVoteBeginDate').val();
                $('#txtVoteEndDate').datepicker('setStartDate', startTime);
            });
            //结束时间： 
            $('#txtDeclarationEndDate').datepicker().on('changeDate', function (e) {
                var endTime = $('#txtDeclarationEndDate').val();
                $('#txtDeclarationBeginDate').datepicker('setEndDate', endTime);
            });
            $('#txtPrimaryElectionEndDate').datepicker().on('changeDate', function (e) {
                var startTime = $('#txtPrimaryElectionEndDate').val();
                $('#txtPrimaryElectionBeginDate').datepicker('setEndDate', startTime);
            });
            $('#txtExpertReviewEndDate').datepicker().on('changeDate', function (e) {
                var startTime = $('#txtExpertReviewEndDate').val();
                $('#txtExpertReviewBeginDate').datepicker('setEndDate', startTime);
            });
            $('#txtDownloadEndDate').datepicker().on('changeDate', function (e) {
                var endTime = $('#txtDownloadEndDate').val();
                $('#txtDownloadBeginDate').datepicker('setEndDate', endTime);
            });
            $('#txtVoteEndDate').datepicker().on('changeDate', function (e) {
                var endTime = $('#txtVoteEndDate').val();
                $('#txtVoteBeginDate').datepicker('setEndDate', endTime);
            });
       });

    </script>
</asp:Content>
