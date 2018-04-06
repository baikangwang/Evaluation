<%@ Page  Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="Industry.aspx.cs" Inherits="Evaluation.View.Declaration.Industry" validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/Participant.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/Appendix.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStates.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/Certificate.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %> 

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/Css/Declaration.css" rel="stylesheet" />
          
    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css"/>
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>
        
    <%--UEditor--%>
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>

    <%--ui-choose--%> 
    <link href="../../Content/plugins/ui-choose/src/ui-choose.css" rel="stylesheet" />
    <script src="../../Content/plugins/ui-choose/src/ui-choose.js"></script>

    <script src="../../Content/Javascript/Declaration.js"></script>

    <style>
        table{border:none; border-collapse: collapse;width:90%;margin:0px auto}
        table tr{border:none;}
        table tr td{border:1px solid;padding:10px 5px 5px 5px;text-align:center;line-height:25px;height:25px;}
        table tr td table{border:none;}
        table tr td table tr{border:none;}
        table tr td table td{border-left:none;border-top:none;text-align:center;border-bottom:none;} 
        #divfather{
            margin-top:20px;
        }
        .shejidanwei {width:100%; }
        .shejidanwei tr td{border-top:1px solid; } 
        input{border-style: solid ;
              border-color: rgba(128, 128, 128,0.5);
              border-width: 1px;
             
              height:25px;
        }
        input[type="text"]{
            padding: 0px 0px !important;
        }
        #teshutable{width:50%;}
       .nav-tabs>li.active>a, .nav-tabs>li.active>a:hover, .nav-tabs>li.active>a:focus{
            color: #FFF;
            background-color: #30b9cb;
            border: 1px solid #30b9cb;
            border-bottom-color: transparent
       }
       .nav-tabs {
            border-bottom: 2px solid #30b9cb;
        }
        .nav-tabs > li > a:hover {
            border-color: #30b9cb;
            color: #FFF;
            background:#30b9cb;
        }
        .nav > li > a:hover, .nav > li > a:focus {
            text-decoration: none;
        }
        a:hover {
            color: #fff;
            text-decoration: none;
            background-color: #30b9cb;
        }
        #ContentPlaceHolder1_divfather{
            margin-top:20px;
        }
        legend{
            border-bottom:0px;
            text-align: center;
        }
        #ContentPlaceHolder1_divfather table{
            margin:0px auto;
        }   
        input{
            text-align:center;
        }
        .ui-choose{
            margin-left:15px;
        }
        tbody > tr > td:nth-child(2) > div {
            left: -13px !important;
        }
        #btab2 table input{
            width:82%;
        }
        #btab2 table select{
            margin-left:5px;
        }
        #ContentPlaceHolder1_Appendix_panelAppendix textarea{
            margin:0px auto;
        }
        #ContentPlaceHolder1_LegalStates_TextBox273{
            margin-left: 28px;
            width: 56%;
            
        }
        #GroundLayer_Less6,#UndergroundLayer_Less6,#Height_Less6,#Count_Less6{
            float:none;
        }
        #edui1_toolbarbox {
            position: initial;
            z-index: 0;
        }

        #edui1 {
            z-index: 0;
        }
        #edui1_iframeholder{
            height:300px;
        }
        
        #btn_018Prev{
            margin-left: 43%;
            margin-top:40px; 
        }
        #AcceptanceDepartment{
            float:none!important;
        }

        #AcceptanceDepartment{
            margin-left:4px;
        }


        #content #test{
            height:2500px!important;
        }
        #TechnologicalInnovationTextBox,#DiscrepancyReasonTextBox,#OthersTextBox{
            text-align:left;width:85%;margin-left:10px;
        }
        #MainFeaturesTextBox{
            width:97%;margin-left:10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
       <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=150000" id="nav02" runat="server" ClientIDMode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
        </li>        
    </ul>
    <div style="display:none"><asp:TextBox ID="txtSituation" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox ID="txtUser" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox ID="txtTemplate" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、申报内容</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、附件目录</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、法人声明</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、合作声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab" class="ExpertReviewList2" style="display: none;">7、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_1501" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 150px;">项目名称</td>
                            <td>
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsIndustryDeclarationName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                （主申报）</td>
                            <td style="padding: 0;">
                                <table class="shejidanwei">
                                    <tr>
                                        <td style="border-top: none;">申报单位</td>
                                        <td colspan="4" style="border-top: none; border-right: none;">
                                            <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="94.8%"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsIndustryDeclarationUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>通讯地址</td>
                                        <td colspan="4" style="border-right: none;">
                                            <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="94.8%"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsIndustryPostalAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                                        </td>
                                    </tr>
                                    <tr>
                                        <td>联系人</td>
                                        <td>
                                            <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="88.5%"></asp:TextBox>
                                            <asp:CheckBox ID="IsIndustryLinkman" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                        <td>手机</td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="88.5%"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsIndustryMobileNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>电话</td>
                                        <td>
                                            <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="88.5%"></asp:TextBox>
                                            <asp:CheckBox ID="IsIndustryTelephoneNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                        <td>邮政编码</td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="88.5%"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsIndustryPostcode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>传真</td>
                                        <td>
                                            <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="88.5%"></asp:TextBox>
                                            <asp:CheckBox ID="IsIndustryFaxNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                                        </td>
                                        <td>电子邮箱</td>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="88.5%"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsIndustryEmailAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>境内、外合作设计单位</td>
                            <td style="padding: 0;" colspan="4">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 30.4%; border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:DropDownList runat="server" ID="DomesticOrAbord1" ClientIDMode="Static"></asp:DropDownList>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtDomesticOrAbord1" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                        </td>
                                        <td style="width: 23.8%; border-right: none; text-align: left;">
                                            <asp:TextBox ID="CooperativeUnit1" runat="server" ClientIDMode="Static" Style="width: 88%;" onblur="Sensitize('CooperativeUnit1','CollaborativePhase01')"></asp:TextBox>
                                        </td>
                                        <td style="border-right: none; width: 35%;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList1">
                                                <asp:DropDownList runat="server" ID="CollaborativePhase01" ClientIDMode="Static" Width="200px"></asp:DropDownList>
                                            </div>
                                            <div style="display: none">
                                                <asp:TextBox ID="CollaborativePhase1" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtCollaborativePhase1" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <%-- <asp:CheckBox runat="server" ID="IsResidentialCollaborativePhase1" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:DropDownList runat="server" ID="DomesticOrAbord2" ClientIDMode="Static"></asp:DropDownList>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtDomesticOrAbord2" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: left;" id="td2">
                                            <asp:TextBox ID="CooperativeUnit2" runat="server" ClientIDMode="Static" Style="width: 88%;" onblur="Sensitize('CooperativeUnit2','CollaborativePhase02')"></asp:TextBox>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList2">
                                                <asp:DropDownList runat="server" ID="CollaborativePhase02" ClientIDMode="Static" Width="200px"></asp:DropDownList>
                                            </div>
                                            <div style="display: none">
                                                <asp:TextBox ID="CollaborativePhase2" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtCollaborativePhase2" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <%--<asp:CheckBox runat="server" ID="IsResidentialCollaborativePhase2" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:DropDownList runat="server" ID="DomesticOrAbord3" ClientIDMode="Static"></asp:DropDownList>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtDomesticOrAbord3" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: left;" id="td3">
                                            <asp:TextBox ID="CooperativeUnit3" runat="server" ClientIDMode="Static" Style="width: 88%;" onblur="Sensitize('CooperativeUnit3','CollaborativePhase03')"></asp:TextBox>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList3">
                                                <asp:DropDownList runat="server" ID="CollaborativePhase03" ClientIDMode="Static" Width="200px"></asp:DropDownList>
                                            </div>
                                            <div style="display: none">
                                                <asp:TextBox ID="CollaborativePhase3" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtCollaborativePhase3" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <%--<asp:CheckBox runat="server" ID="IsResidentialCollaborativePhase3" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:DropDownList runat="server" ID="DomesticOrAbord4" ClientIDMode="Static"></asp:DropDownList>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtDomesticOrAbord4" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: left;" id="td4">
                                            <asp:TextBox ID="CooperativeUnit4" runat="server" ClientIDMode="Static" Style="width: 88%;" onblur="Sensitize('CooperativeUnit4','CollaborativePhase04')"></asp:TextBox>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList4">
                                                <asp:DropDownList runat="server" ID="CollaborativePhase04" ClientIDMode="Static" Width="200px"></asp:DropDownList>
                                            </div>
                                            <div style="display: none">
                                                <asp:TextBox ID="CollaborativePhase4" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtCollaborativePhase4" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <%--<asp:CheckBox runat="server" ID="IsResidentialCollaborativePhase4" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>施工单位</td>
                            <td>
                                <asp:TextBox ID="ConstructionOrganization" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsIndustryConstructionOrganization" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点</td>
                            <td>
                                <asp:TextBox ID="ConstructionLocation" runat="server" Width="95.5%" ClientIDMode="Static"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsIndustryConstructionLocation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计类别</td>

                            <td style="padding: 0">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 40%">
                                            <div class="DeclarationList">
                                                <asp:DropDownList runat="server" ID="DesignCategory" ClientIDMode="Static"></asp:DropDownList>
                                            </div>
                                            <div class="ExpertReviewList" style="display:none">
                                                <asp:TextBox ID="txtDesignCategory" runat="server" Width="90%" ClientIDMode="Static"></asp:TextBox>
                                            </div>
                                            <asp:CheckBox runat="server" ID="IsIndustryDesignCategory" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                        <td style="width: 200px;">设计起止时间
                                        </td>
                                        <td style="width: 40%; border-right: none;" >
                                            <div class="datepicker input-group date" style="width: 45%;">
                                                <asp:TextBox ID="DesignStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计开始日期"></asp:TextBox>
                                                <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                            </div>
                                         
                                            <div class="datepicker input-group date" style="width: 45%;">
                                                <asp:TextBox ID="DesignEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计终止日期"></asp:TextBox>
                                                <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                                <asp:CheckBox runat="server" ID="IsIndustryDesignEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>开工时间
                            </td>
                            <td style="padding: 0">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 40%">
                                            <div class="datepicker input-group date">
                                                <asp:TextBox ID="ConstructionStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择开工日期"></asp:TextBox>
                                                <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                                <asp:CheckBox runat="server" ID="IsIndustryConstructionStartDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                            </div>
                                        </td>
                                        <td style="width: 200px;">竣工时间
                                        </td>
                                        <td style="width: 40%; border-right: none;">
                                            <div class="datepicker input-group date">
                                                <asp:TextBox ID="ConstructionEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工日期"></asp:TextBox>
                                                <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                                <asp:CheckBox runat="server" ID="IsIndustryConstructionEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>竣工验收时间
                            </td>
                            <td style="padding: 0">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 40%;">
                                            <div class="datepicker input-group date">
                                                <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工验收日期"></asp:TextBox>
                                                <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                                <asp:CheckBox runat="server" ID="IsIndustryAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                            </div>
                                        </td>
                                        <td>竣工验收部门　
                                        </td>
                                        <td style="width: 40%; border-right: none;">
                                            <asp:TextBox runat="server" ID="AcceptanceDepartment" ClientIDMode="Static" Width="68%"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsIndustryAcceptanceDepartment" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>消防备案时间
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 40%;">
                                            <div class="datepicker input-group date">
                                                <asp:TextBox ID="FireControlRecordDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择消防备案日期"></asp:TextBox>
                                                <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                                <asp:CheckBox runat="server" ID="IsIndustryFireControlRecordDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                            </div>
                                        </td>
                                        <td>交付使用时间　
                                        </td>
                                        <td style="width: 40%; border-right: none;">
                                            <div class="datepicker input-group date">
                                                <asp:TextBox ID="DeliveryDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择交付使用日期"></asp:TextBox>
                                                <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                                <asp:CheckBox runat="server" ID="IsIndustryDeliveryDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                            </div>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>投资来源
                            </td>
                            <td colspan="4">
                                <div class="DeclarationList">
                                    <asp:DropDownList runat="server" ID="InvestSource" ClientIDMode="Static"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display:none">
                                    <asp:TextBox ID="txtInvestSource" runat="server" Width="90%" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsResidentialInvestSource" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_1501')" id="Save_1501">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onSave('Template_1501','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                    <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" id="ucParticipant"></uc:Participant>
            </div> 
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_1502" runat="server" ClientIDMode="Static" GroupingText="技术申报内容（工业工程）">
                    <table>
                        <tr>
                            <td style="padding:10px;width:20%">专业类别
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="ProfessionalCategories" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsIndustryProfessionalCategories" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设规模
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="ProjectScale" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsIndustryProjectScale" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计技术及创<br />
                                新要点
                            </td>
                            <td>
                                <asp:TextBox ID="TechnologicalInnovation" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="TechnologicalInnovationTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsIndustryTechnologicalInnovation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计概算
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="Estimate" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsIndustryEstimate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>竣工决算
                            </td>
                            <td>
                                <asp:TextBox runat="server" ID="Settlement" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsIndustrySettlement" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>决算与概算<br />
                                的出入原因
                            </td>
                            <td>
                                <asp:TextBox ID="DiscrepancyReason" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="DiscrepancyReasonTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsIndustryDiscrepancyReason" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align:left;padding-left:10px;">设计主要特点及社会、经济效益（限500字以内）</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:TextBox ID="MainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:98%;height:300px;"></asp:TextBox>
                                <script id="MainFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsMunicipalMainFeatures" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td> 
                        </tr>
                        <tr>
                            <td>其他
                            </td>
                            <td>
                                <asp:TextBox ID="Others" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="OthersTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsIndustryOthers" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_1502')" id="Save_1502">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onSave('Template_1502','Save')" class="btnt">保 &nbsp;&nbsp;存</a>
                    <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                    <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab4">
                <uc:Appendix runat="server" id="Appendix"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab5">
                <uc:LegalStates runat="server" ID="ucLegalStates"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab6">
                <uc:Certificate runat="server" ID="ucCertificate"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab7">
                <uc:Comments runat="server" ID="ucComments"></uc:Comments>
            </div>
        </div>
    </div>                   
  <script type="text/javascript">
      for (i = 1; i < 16; i++) {
          if ($("#ParticipantName" + i).val() == "") {
              $("#IDNumber" + i).attr('disabled', true);
          }
      }
  
      //页面跳转（保存）
      function onSave(PartCode, Tip) {
          var selectPrize1 = $("#CollaborativePhase01").multipleSelect("getSelects").toString();
          var selectPrize2 = $("#CollaborativePhase02").multipleSelect("getSelects").toString();
          var selectPrize3 = $("#CollaborativePhase03").multipleSelect("getSelects").toString();
          var selectPrize4 = $("#CollaborativePhase04").multipleSelect("getSelects").toString();

          $("#CollaborativePhase1").val(selectPrize1);
          $("#CollaborativePhase2").val(selectPrize2);
          $("#CollaborativePhase3").val(selectPrize3);
          $("#CollaborativePhase4").val(selectPrize4);

          // 富文本框取值
          $("#TechnologicalInnovation").val(EncodeUEditorContent(UE.getEditor('TechnologicalInnovationTextBox').getContent()));                  // 设计技术及创新要点
          $("#DiscrepancyReason").val(EncodeUEditorContent(UE.getEditor('DiscrepancyReasonTextBox').getContent()));                              // 决算与概算的出入原因
          $("#Others").val(EncodeUEditorContent(UE.getEditor('OthersTextBox').getContent()));                                                    // 其他
          $("#MainFeatures").val(EncodeUEditorContent(UE.getEditor('MainFeaturesTextBox').getContent()));                                        // 设计主要特点

          var result = [];
          $("[data='" + PartCode + "']").not("span").each(function () {
              if ($(this).attr("id") != null) {
                  result.push({ Name: $(this).attr("id"), Value: $(this).val() });
              }
          });

          if (!checkUEditor('TechnologicalInnovationTextBox')
                || !checkUEditor('DiscrepancyReasonTextBox')
                || !checkUEditor('OthersTextBox')
                || !checkUEditor('MainFeaturesTextBox')) {
              return false;
          }

          //保存
          $.ajax({
              type: "post",
              url: "../Mutual/Declaration.ashx",
              data: {
                  "Action": "Save",
                  "PartCode": PartCode,
                  "DeclarationID": $("#txtdeclID").val(),
                  "PageData": result
              },
              success: function (data, status) {
                  if (data == "success" && Tip == 'Save') {
                      ShowMessag("已保存");
                  }
              },
              error: function (data) {
                  ShowMessag("保存失败,请重新保存！");
              },
          });

          SetCollaborationInfo();
      }   

      $(function () {
          // 刷新分工表
          SetCollaborationInfo();
          notBackspace();
          // 富文本框
         InitUEditor('TechnologicalInnovationTextBox', 2500);           // 设计技术及创新要点
         InitUEditor('DiscrepancyReasonTextBox', 500);                  // 决算与概算的出入原因
         InitUEditor('OthersTextBox', 500);                             // 其他
         InitUEditor('MainFeaturesTextBox', 2000);                      // 设计主要特点

          //重置附件顺序
         $("#AppendixPrev").click(function () {
             onPrev("04");
         });
         $("#AppendixNext").click(function () {
             onNext("04");
         });
         $("#LegalStatesPrev").click(function () {
             onPrev("05");
         });
         $("#LegalStatesNext").click(function () {
             onNext("05");
         });
         $("#CertificatePrev").click(function () {
             onPrev("06");
         });
         $("#CertificateNext").click(function () {
             onNext("06");
         });
         $("#CommentsPrev").click(function () {
             onPrev("07");
         });

         $("#tabfather li a[data-toggle='tab']").click(function () {
              var TabsId = getCookie('TabId');
              var n = TabsId.substr(-2, 2);
              var id = $(this).attr("id").substr(-2, 2);
              ShowTab(id);          
              //if (n == "01") {
              //   // $("#Save_1501").click();
              //}
              //if (n == "02") {
              //    for (i = 1; i < 16; i++) {
              //        if ($("#ParticipantName" + i).val().length != 0 && $("#IDType" + i).find("option:selected").text() == "身份证") {
              //            if ($("#IDNumber" + i).val().length != 18) {
              //                ShowMessag("您输入的身份证号不正确！");
              //                $("#IDNumber" + i).css("border-color", "red");
              //                return false;
              //            }
              //        }
              //    }
              //    $("#Save_Participant").click();
              //}
              //else {
              //    n = parseInt(n) - 1;
              //    if (String(n).length == 1) {
              //       // $("#Save_150" + n).click();
              //    }
              //    else {
              //       // $("#Save_15" + n).click();
              //    }
              //}           
              //点击存储本次Tab的ID
              addCookie('TabId', $(this).attr("id"), 1);             
          })
      });    
      function Sensitize(CooperativeUnit, CollaborativePhase) {
          var i = CooperativeUnit.substr(-1);
          if ($("#" + CooperativeUnit).val().trim() != "") {
              $("#" + CollaborativePhase).attr('disabled', false);
              $("#DeclarationList" + i + " div button").removeClass("disabled");
          }
          else {
              $("#" + CollaborativePhase).attr('disabled', true);
              $("#DeclarationList" + i + " div button span").html("");
              $("#DeclarationList" + i + " div button").addClass("disabled");
              $("#" + CollaborativePhase).multipleSelect("uncheckAll");
          }
      }

      for (d = 2; d < 5; d++) {
          if ($("#CooperativeUnit" + d).val() == "") {
              $("#CooperativeUnit" + d).attr('disabled', true);
          }
          if ($("#CollaborativePhase" + d).val() == "") {
              $("#CollaborativePhase0" + d).attr('disabled', true);
          }
      }

      if ($("#CollaborativePhase1").val() == "") {
          $("#CollaborativePhase01").attr('disabled', true);
      }


      $("#td2").click(function () {
          if ($("#DeclarationList1 div button span").html() != "") {
              $("#CooperativeUnit2").attr('disabled', false);
          }
      })
      $("#td3").click(function () {
          if ($("#DeclarationList2 div button span").html() != "") {
              $("#CooperativeUnit3").attr('disabled', false);
          }
      })
      $("#td4").click(function () {
          if ($("#DeclarationList3 div button span").html() != "") {
              $("#CooperativeUnit4").attr('disabled', false);
          }
      })

      $("#CooperativeUnit2").change(function () {
          if ($("#CooperativeUnit2").val() == "") {
              $("#CooperativeUnit2").attr('disabled', true);
          }
      })
      $("#CooperativeUnit3").change(function () {
          if ($("#CooperativeUnit3").val() == "") {
              $("#CooperativeUnit3").attr('disabled', true);
          }
      })
      $("#CooperativeUnit4").change(function () {
          if ($("#CooperativeUnit4").val() == "") {
              $("#CooperativeUnit4").attr('disabled', true);
          }
      })
    </script>
</asp:Content>
