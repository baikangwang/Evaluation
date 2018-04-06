<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="Survey_V2.aspx.cs" Inherits="Evaluation.View.Declaration.Survey_V2" %>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/Participant.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/Appendix.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStates_V2.ascx" %>
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
        #panelPart_0101 fieldset table ul.ui-choose>li.selected {
            border-color: #30b9cb;
            background-color: #30b9cb;
            color: #fff;
        }
        #panelPart_0101 fieldset table ul.ui-choose>li:hover {
            border-color: #30b9cb;
        }
        input{
            text-align:center;
        }
        .ui-choose{
            margin-left:15px;
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
        #ueditor,#ueditor2,#ueditor7,#ueditor8{
            text-align:left;
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
            margin-left:6px;
        }


        #content #test{
            height:2500px!important;
        }
        #ProjectOverviewTextBox,#TechnicalFeatureTextBox,#EffectivenessTextBox,#BenefitsTextBox,#AwardTextBox,#RecommendOpinionTextBox,#UnitOpinionTextBox{
            text-align:left;width:86%;margin-left:10px;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <ul class="navs">
       <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=140000" id="nav02" runat="server" ClientIDMode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
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
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、审核意见</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、附件目录</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、法人声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab">7、合作声明</a></li>
            <li><a id="tab_08" href="#btab8" data-toggle="tab" class="ExpertReviewList2" style="display: none;">8、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_1401" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 150px;">项目名称
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyDeclarationName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>                       
                        <tr style="display:none;">
                            <td>项目主要技术<br />
                                经济指标水平
                            </td>
                            <td colspan="3">
                                <div class="DeclarationList">
                                <asp:DropDownList ID="TechnicalEconomicIndicators" runat="server" ClientIDMode="Static" Width="95.5%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtTechnicalEconomicIndicators" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsSurveyTechnicalEconomicIndicators" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位 
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyDeclarationUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                            <td>通信地址
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyPostalAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>联系人
                            </td>
                            <td style="width: 35%">
                                <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyLinkman" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="width: 150px;">传真
                            </td>
                            <td>
                                <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyFaxNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>电话
                            </td>
                            <td>
                                <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyTelephoneNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyPostcode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>手机
                            </td>
                            <td>
                                <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyMobileNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyEmailAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>项目申报单位资质<br />
                                证书名称/编号
                            </td>
                            <td colspan="3" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="CertificateName" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>  /
                                        </td>                                 
                                        <td style="border-right: none;">
                                            <asp:TextBox ID="CertificateNumber" runat="server" ClientIDMode="Static" Style="width: 91%; margin-left: 0;"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsSurveyCertificateNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>建设单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DevelopmentOrganization" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyDevelopmentOrganization" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>项目起止时间
                            </td>
                            <td>
                                <div class="datepicker input-group date" style="width: 47%;">
                                    <asp:TextBox ID="ProjectStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="项目起始日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                                
                                <div class="datepicker input-group date" style="width: 47%;">
                                    <asp:TextBox ID="ProjectEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="项目结束日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsSurveyProjectEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>项目建成/完成时间
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="ConstructionEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="项目建成/完成日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsSurveyConstructionEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>验收部门
                            </td>
                            <td>
                                <asp:TextBox ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="68%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSurveyAcceptanceDepartment" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>验收时间
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="验收日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsSurveyAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                    <%--<tr>
                            <td style="width:150px; padding:25px;">
                                曾获奖项
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 200px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenAwards" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                <%--<script id="AwardsTextBox" type="text/plain" style=" height: 300px;"></script>--%>
                     <%--      </td> 
                        </tr>--%>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1401')" id="Save_1401">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onSave('Template_1401','Save')" class="btnt">保  &nbsp;&nbsp; 存</a>
                    <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" ID="ucParticipant"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_1402" runat="server" ClientIDMode="Static" GroupingText="申报项目成果概要">
                    <table>
                        <tr>
                            <td style="width: 100px;">项目概况（项目总体介绍、项目规模、复杂程度及影响程度等，限500字。）
                            </td>
                            <td>
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="ProjectOverviewTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsSurveyProjectOverview" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>项目特色（项目特点、主要工程问题、技术难点及技术创新、实施效果与成果指标等，限3000字。）
                            </td>
                            <td>
                                <asp:TextBox ID="TechnicalFeature" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="TechnicalFeatureTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsSurveyTechnicalFeature" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                       <%-- <tr>
                            <td>解决技术难题、工程问题的成效与深度
                            </td>
                            <td>
                                <asp:TextBox ID="Effectiveness" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="EffectivenessTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsSurveyEffectiveness" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>--%>
                        <tr>
                            <td>整体效益（项目产生的经济、社会、环境、效益等，限500字。）
                            </td>
                            <td>
                                <asp:TextBox ID="Benefits" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="BenefitsTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsSurveyBenefits" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1402')" id="Save_1402">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onSave('Template_1402','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                    <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                    <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab4">
                <asp:Panel ID="panelPart_1403" runat="server" ClientIDMode="Static" GroupingText="申报单位/推荐部门机构审核意见">
                    <table>
                        <tr>
                            <td style="width: 100px;">曾获奖项
                            </td>
                            <td>
                                <asp:TextBox ID="Award" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="AwardTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="CheckBox1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />意   见
                            </td>
                            <td>
                                <asp:TextBox ID="UnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="UnitOpinionTextBox" type="text/plain" style="height: 300px;"></script>
                                <div class="datepicker input-group date survey" style="width: 25%;">
                                    <asp:TextBox ID="UnitOpinionTime" class="form-control" runat="server" ClientIDMode="Static" placeholder="填写日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                                <asp:CheckBox runat="server" ID="CheckBox2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>地方、部门勘察设计同业协会推荐<br />意   见
                            </td>
                            <td>
                                <asp:TextBox ID="RecommendOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>
                                <script id="RecommendOpinionTextBox" type="text/plain" style="height: 300px;"></script>
                                <div class="datepicker input-group date survey" style="width: 20%;">
                                    <asp:TextBox ID="RecommendOpinionTime" class="form-control" runat="server" ClientIDMode="Static" placeholder="填写日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                                <asp:CheckBox runat="server" ID="CheckBox3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1403')" id="Save_1403">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                    <a onclick="javascript:onSave('Template_1403','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                    <a onclick="javascript:onPrev('04')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                    <a onclick="javascript:onNext('04')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div> 
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab5">
                <uc:Appendix runat="server" ID="Appendix"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab6">
                <uc:LegalStates runat="server" ID="ucLegalStates"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab7">
                <uc:Certificate runat="server" ID="ucCertificate"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab8">
                <uc:Comments runat="server" ID="ucComments"></uc:Comments>
            </div>
        </div>
    </div>
             
  <script type="text/javascript">
      $('.datepicker.input-group.date.Survey').css('width', '25%')
      $('#TechnicalEconomicIndicators').ui_choose();

      switch ($('#TechnicalEconomicIndicators').val()) {
          case "3201":
              $('#txtTechnicalEconomicIndicators').val("国际先进");
              break;
          case "3202":
              $('#txtTechnicalEconomicIndicators').val("国内领先");
              break;
          case "3203":
              $('#txtTechnicalEconomicIndicators').val("国内先进");
              break;
          case "3204":
              $('#txtTechnicalEconomicIndicators').val("其它");
              break;
      }

      for (i = 1; i < 16; i++) {
          if ($("#ParticipantName" + i).val() == "") {
              $("#IDNumber" + i).attr('disabled', true);
          }
      }
      //重置附件顺序
      $("#AppendixPrev").click(function () {
          onPrev("05");
      });
      $("#AppendixNext").click(function () {
          onNext("05");
      });
      $("#LegalStatesPrev").click(function () {
          onPrev("06");
      });
      $("#LegalStatesNext").click(function () {
          onNext("06");
      });
      $("#CertificatePrev").click(function () {
          onPrev("07");
      });
      $("#CertificateNext").click(function () {
          onNext("07");
      });
      $("#CommentsPrev").click(function () {
          onPrev("08");
      });
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
          $("#ProjectOverview").val(EncodeUEditorContent(UE.getEditor('ProjectOverviewTextBox').getContent()));              // 项目概况、规模、影响程度
          $("#TechnicalFeature").val(EncodeUEditorContent(UE.getEditor('TechnicalFeatureTextBox').getContent()));            // 技术特色，主要技术成果指标水平
          //$("#Effectiveness").val(EncodeUEditorContent(UE.getEditor('EffectivenessTextBox').getContent()));                  // 解决技术难题、工程问题的成效与深度
          $("#Benefits").val(EncodeUEditorContent(UE.getEditor('BenefitsTextBox').getContent()));                            // 经济、社会、环境效益
          $("#Award").val(EncodeUEditorContent(UE.getEditor('AwardTextBox').getContent()));
          $("#RecommendOpinion").val(EncodeUEditorContent(UE.getEditor('RecommendOpinionTextBox').getContent()));
          $("#UnitOpinion").val(EncodeUEditorContent(UE.getEditor('UnitOpinionTextBox').getContent()));
          if (!checkUEditor('ProjectOverviewTextBox')
                || !checkUEditor('TechnicalFeatureTextBox')
                || !checkUEditor('BenefitsTextBox')
                || !checkUEditor('AwardTextBox')
                || !checkUEditor('RecommendOpinionTextBox')
                || !checkUEditor('UnitOpinionTextBox')) {
              return false;
          }

          var result = [];
          $("[data='" + PartCode + "']").not("span").each(function () {
              if ($(this).attr("id") != null) {
                  result.push({ Name: $(this).attr("id"), Value: $(this).val() });
              }
          });
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
                  ShowMessag("保存失败, 请重新保存！");
              },
          });
          SetCollaborationInfo1()
          //刷新分工表
          //$.ajax({
          //    type: "post",
          //    url: "../Mutual/Declaration.ashx",
          //    data: {
          //        "Action": "FreshDivision",
          //        "DeclarationID": $("#txtDeclarationID").val(),
          //    },
          //    success: function (data, status) {
          //        if (data != "[]") {
          //            data = JSON.parse(data);
          //            if (data[0]) {
          //                $("#txtDeclarationUnit2").val(data[0]["Data"]);
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase2_0" + i).val("×");
          //                }
          //                $("#CollaborativePhase2_10").val("×");
          //                $("#CollaborativePhase2_11").val("×");
          //            }
          //            if (data[2]) {
          //                var strs = new Array();
          //                if (data[2]["Data"] != null) {
          //                    strs = data[2]["Data"].split(",");
          //                    for (i = 0; i < strs.length; i++) {
          //                        var ee = strs[i].substring(2, 4);
          //                        $("#CollaborativePhase2_" + ee).val("√");
          //                    }
          //                }
          //            }
          //            if (data[3]) {
          //                $("#txtDeclarationUnit3").val(data[3]["Data"]);
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase3_0" + i).val("×");
          //                }
          //                $("#CollaborativePhase3_10").val("×");
          //                $("#CollaborativePhase3_11").val("×");
          //            }
          //            else {
          //                $("#txtDeclarationUnit3").val("");
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase3_0" + i).val("");
          //                }
          //                $("#CollaborativePhase3_10").val("");
          //                $("#CollaborativePhase3_11").val("");
          //            }
          //            if (data[5]) {
          //                var strs = new Array();
          //                if (data[5]["Data"] != null) {
          //                    strs = data[5]["Data"].split(",");
          //                    for (i = 0; i < strs.length; i++) {
          //                        var ee = strs[i].substring(2, 4);
          //                        $("#CollaborativePhase3_" + ee).val("√");
          //                    }
          //                }
          //            }
          //            if (data[6]) {
          //                $("#txtDeclarationUnit4").val(data[6]["Data"]);
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase4_0" + i).val("×");
          //                }
          //                $("#CollaborativePhase4_10").val("×");
          //                $("#CollaborativePhase4_11").val("×");
          //            }
          //            else {
          //                $("#txtDeclarationUnit4").val("");
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase4_0" + i).val("");
          //                }
          //                $("#CollaborativePhase4_10").val("");
          //                $("#CollaborativePhase4_11").val("");
          //            }
          //            if (data[8]) {
          //                var strs = new Array();
          //                if (data[8]["Data"] != null) {
          //                    strs = data[8]["Data"].split(",");
          //                    for (i = 0; i < strs.length; i++) {
          //                        var ee = strs[i].substring(2, 4);
          //                        $("#CollaborativePhase4_" + ee).val("√");
          //                    }
          //                }
          //            }
          //            if (data[9]) {
          //                $("#txtDeclarationUnit5").val(data[9]["Data"]);
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase5_0" + i).val("×");
          //                }
          //                $("#CollaborativePhase5_10").val("×");
          //                $("#CollaborativePhase5_11").val("×");
          //            }
          //            else {
          //                $("#txtDeclarationUnit5").val("");
          //                for (i = 1; i < 10; i++) {
          //                    $("#CollaborativePhase5_0" + i).val("");
          //                }
          //                $("#CollaborativePhase5_10").val("");
          //                $("#CollaborativePhase5_11").val("");

          //            }
          //            if (data[11]) {
          //                var strs = new Array();
          //                if (data[11]["Data"] != null) {
          //                    strs = data[11]["Data"].split(",");
          //                    for (i = 0; i < strs.length; i++) {
          //                        var ee = strs[i].substring(2, 4);
          //                        $("#CollaborativePhase5_" + ee).val("√");
          //                    }
          //                }
          //            }
          //        }
          //    },
          //});
      }


      $(function () {
          SetCollaborationInfo1();
          notBackspace();
          // 富文本框
          InitUEditor('ProjectOverviewTextBox', 500);               // 项目概况、规模、影响程度
          InitUEditor('TechnicalFeatureTextBox', 3000);               // 技术特色，主要技术成果指标水平        
          InitUEditor('BenefitsTextBox', 500);                      // 经济、社会、环境效益
          InitUEditor('AwardTextBox', 1000);
          InitUEditor('RecommendOpinionTextBox', 1000);
          InitUEditor('UnitOpinionTextBox', 1000);

          $("#tabfather li a[data-toggle='tab']").click(function () {
              var TabsId = getCookie('TabId');
              var n = TabsId.substr(-2, 2);
              var id = $(this).attr("id").substr(-2, 2);
              ShowTab(id);
              //ShowMessag(n);
              //if (n == "01") {
              //    //$("#Save_1401").click();
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
              //        // $("#Save_140" + n).click();
              //    }
              //    else {
              //        //$("#Save_14" + n).click();
              //    }
              //}
              //点击存储本次Tab的ID
              addCookie('TabId', $(this).attr("id"), 1);
              //ShowMessag($(this).attr("id"));
          })
      });
      //CollaborativePhase02CooperativeUnit1
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
