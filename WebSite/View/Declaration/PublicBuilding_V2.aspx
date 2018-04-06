<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="PublicBuilding_V2.aspx.cs" Inherits="Evaluation.View.Declaration.PublicBuilding_V2" ValidateRequest="false" %>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/Participant.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/Appendix.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStates_V2.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/Certificate.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>

    <%--UEditor--%>
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>
    <link href="../../Content/Css/Declaration.css" rel="stylesheet" />
    <script src="../../Content/Javascript/Declaration.js"></script>

    <%--ui-choose--%>
    <link href="../../Content/plugins/ui-choose/src/ui-choose.css" rel="stylesheet" />
    <script src="../../Content/plugins/ui-choose/src/ui-choose.js"></script>

    <style>
        table {
            border: none;
            border-collapse: collapse;
            width: 90%;
            margin: 0px auto;
        }

            table tr {
                border: none;
            }

                table tr td {
                    border: 1px solid;
                    padding: 10px 0px 5px 0px;
                    height: 25px;
                }

                    table tr td table {
                        border: none;
                    }

                        table tr td table tr {
                            border: none;
                        }

                        table tr td table td {
                            border-left: none;
                            border-top: none;
                            border-bottom: none;
                        }

        #divfather {
            margin-top: 20px;
        }

        .shejidanwei {
            width: 100%;
        }

            .shejidanwei tr td {
                border-top: 1px solid;
            }

        input {
            border-style: solid;
            border-color: rgba(128, 128, 128,0.5);
            border-width: 1px;
            height: 25px;
        }

            input[type="text"] {
                padding: 0px 0px !important;
            }

        #teshutable {
            width: 50%;
        }

        .nav-tabs > li.active > a, .nav-tabs > li.active > a:hover, .nav-tabs > li.active > a:focus {
            color: #FFF;
            background-color: #30b9cb;
            border: 1px solid #30b9cb;
            border-bottom-color: transparent;
        }

        .nav-tabs {
            border-bottom: 2px solid #30b9cb;
        }

            .nav-tabs > li > a:hover {
                border-color: #30b9cb;
                color: #FFF;
                background: #30b9cb;
            }

        .nav > li > a:hover, .nav > li > a:focus {
            text-decoration: none;
        }

        a:hover {
            color: #fff;
            text-decoration: none;
            background-color: #30b9cb;
        }

        #ContentPlaceHolder1_divfather {
            margin-top: 20px;
        }

        legend {
            border-bottom: 0px;
            text-align: center;
        }

        #ContentPlaceHolder1_divfather table {
            margin: 0px auto;
        }

        #panelPart_0101 fieldset table ul.ui-choose > li.selected {
            border-color: #30b9cb;
            background-color: #30b9cb;
            color: #fff;
        }

        #panelPart_0101 fieldset table ul.ui-choose > li:hover {
            border-color: #30b9cb;
        }

        input {
            text-align: center;
        }

        .ui-choose {
            margin-left: 15px;
        }

        #btab2 table input {
            width: 84%;
        }

        #btab2 table select {
            margin-left: 10px;
            margin-right: 10px;
        }

        #ContentPlaceHolder1_Appendix_panelAppendix textarea {
            margin: 0px auto;
        }

        #ContentPlaceHolder1_LegalStates_TextBox273 {
            margin-left: 28px;
            width: 56%;
        }

        #GroundLayer_Less6, #UndergroundLayer_Less6, #Height_Less6, #Count_Less6 {
            float: none;
        }

        #edui1_toolbarbox {
            position: initial;
            z-index: 0;
        }

        #edui1 {
            z-index: 0;
        }

        #ueditor, #ueditor2, #ueditor7, #ueditor8 {
            text-align: left;
        }

        #edui1_iframeholder {
            height: 300px;
        }

        #btn_018Prev {
            margin-left: 43%;
            margin-top: 40px;
        }

        #AcceptanceDepartment {
            float: none !important;
        }

        #content #test {
            height: 2500px !important;
        }

        .file-caption-main {
            width: 80% !important;
        }

        .form-control {
            border-top-left-radius: 4px;
            border-bottom-left-radius: 4px;
        }

        .file-caption-name {
            height: 16px !important;
        }

        .hidden-xs {
            display: inline !important;
        }

        .btn.btn-primary.btn-file {
            border-top-right-radius: 4px;
            border-bottom-right-radius: 4px;
        }

        .cart {
            transition: all 0.8s ease;
            opacity: 0;
            z-index: 20000;
            position: fixed;
            top: 0;
            right: 0;
            bottom: 0;
            left: 0;
            margin: auto;
            background: rgba(0,0,0,0.8);
            height: 0;
            width: 100%;
            overflow: hidden;
        }

        .rongqi {
            height: 100%;
        }

        .closes {
            width: 30px;
            height: 30px;
            position: absolute;
            top: 50px;
            background-image: url(../../Content/Images/close.png);
            filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(src='../../Content/Images/close.png', sizingMethod='scale');
            background-size: contain;
            right: 200px;
            cursor: pointer;
        }

        .cart.shows {
            height: 100%;
            opacity: 1;
        }

        .rongqi img {
            width: auto;
            height: auto;
            max-width: 100%;
            max-height: 80%;
            border: 5px solid #fff;
            position: absolute;
            top: 0;
            left: 0;
            bottom: 0;
            right: 0;
            margin: auto;
        }

        #tbAtlas a, #tbAppendix a {
            color: #30b9cb;
        }

            #tbAtlas a:hover, #tbAppendix a:hover {
                background: #eeeeee;
            }

        #tbAtlas i, #tbAppendix i {
            font-size: 16px;
        }

        #ProjectOverviewTextBox,#TechnicalFeaturesTextBox, #TechnicalDepthTextBox, #ComprehensiveBenefitTextBox, #StructuralFeaturesTextBox, #ElectricityFeatures_ElectricalTextBox, #ElectricityFeatures_IntelligenceTextBox, #ElectricityFeatures_GreenTextBox, #ElectricityFeatures_IntelligenceTextBox, #ElectricityFeatures_GreenTextBox, #Features_HVACTextBox, #Features_PowerTextBox, #Features_WaterSupplyAndDrainageTextBox, #Features_FireFacilitiesTextBox, #EconomicsFeaturesTextBox {
            margin-left: 10px;
            width: 97%;
        }
        #ProjectOverviewTextBox,#TechnicalFeaturesTextBox,#TechnicalDepthTextBox,#ComprehensiveBenefitTextBox,#AwardsTextBox,#UnitOpinionTextBox,#RecommendOpinionTextBox{
            margin-left: 10px;
            width: 85%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a id="top"></a>
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=010000" id="nav02" runat="server" clientidmode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
        </li>
    </ul>
    <div style="display: none">
        <asp:TextBox ID="txtSituation" runat="server" ClientIDMode="Static"></asp:TextBox>
    </div>
    <div style="display: none">
        <asp:TextBox ID="txtUser" runat="server" ClientIDMode="Static"></asp:TextBox>
    </div>
    <div style="display: none">
        <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox>
    </div>
    <div style="display: none">
        <asp:TextBox ID="txtTemplate" runat="server" ClientIDMode="Static"></asp:TextBox>
    </div>
    <div class="tabbable" id="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、项目特点</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、建筑专业</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、结构专业</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、设备专业</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab">7、电气专业</a></li>
            <li><a id="tab_08" href="#btab8" data-toggle="tab">8、经济指标</a></li>
            <li><a id="tab_09" href="#btab9" data-toggle="tab">9、附件目录</a></li>
            <li><a id="tab_10" href="#btab10" data-toggle="tab">10、法人声明</a></li>
            <li><a id="tab_11" href="#btab11" data-toggle="tab">11、合作声明</a></li>
            <li><a id="tab_12" href="#btab12" data-toggle="tab" class="ExpertReviewList2" style="display: none;">12、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_0101" class="tab_div" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 130px;">项目名称
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="95.3%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceDeclarationName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>主要设计单位
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="95.3%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceApprovalName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                            <td>工程设计起止时间
                            </td>
                            <td style="margin-left: 2.5%;">
                                <div class="datepicker input-group date" style="width: 47%;">
                                    <asp:TextBox ID="DesignStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计起始日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 1px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>

                                <div class="datepicker input-group date" style="width: 47%;">
                                    <asp:TextBox ID="DesignEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计结束日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 1px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsCivilAirDefenceDesignEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>竣工验收时间
                            </td>
                            <td colspan="2">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工验收日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsCivilAirDefenceAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td>验收部门
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                通讯地址
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefencePostalAddress" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>单位资质
                            </td>
                            <td>
                                <asp:TextBox ID="Qualification" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                            </td>
                            <td>证书编号
                            </td>
                            <td>
                                <asp:TextBox ID="CertificateNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位联系人
                            </td>
                            <td style="width: 30%">
                                <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceLinkman" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>手    机
                            </td>
                            <td>
                                <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceMobileNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>电    话
                            </td>
                            <td>
                                <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceTelephoneNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefencePostcode" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>传    真
                            </td>
                            <td>
                                <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceFaxNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefenceEmailAddress" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align:left!important; padding-left:20px;">
                                申报材料目录（不限于此）：<br />
                                <asp:TextBox ID="FileCatalog" runat="server" TextMode="MultiLine" ClientIDMode="Static" Width="96.5%" Height="300px"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardFileCatalog" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0101')" id="Save_0101">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0101','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin: 0 20px;">下 一 步</a>
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" ID="ucParticipant"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panel1" runat="server" GroupingText="工程勘察设计项目特点">
                    <table>
                        <tr>
                            <td style="width:130px;">项目概况
                            </td>
                            <td>
                                <p>（项目总体介绍、项目规模、复杂程度及影响程度等，限500字）</p>
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="ProjectOverviewTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>技术特色
                            </td>
                            <td>
                                <p>（项目特色及主要的技术成果指标，限1500字）</p>
                                <asp:TextBox ID="TechnicalFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="TechnicalFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>技术成效<br />
                                与深度
                            </td>
                            <td>
                                <p>（解决的技术难题、工程问题的成效与深度，限1500字）</p>
                                <asp:TextBox ID="TechnicalDepth" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="TechnicalDepthTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>综合效益
                            </td>
                            <td>
                                <p>（项目产生的经济、社会、环境效益，限500字）</p>
                                <asp:TextBox ID="ComprehensiveBenefit" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="ComprehensiveBenefitTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0102')" id="Save_0102">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0102','Save');" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin: 0 20px;">下 一 步</a>
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab4">
                <asp:Panel ID="panelPart_0103" runat="server" GroupingText="专业技术指标（建筑专业）">
                    <table>
                        <tr>
                            <td style="width: 155px">建筑用途（性质）
                            </td>
                            <td>
                                <asp:TextBox ID="UseProperty" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenUseProperty" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>建筑规模
                            </td>
                            <td>
                                <asp:TextBox ID="BuildingScale" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenBuildingScale" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">总用地面积
                            </td>
                            <td rowspan="2">
                                <asp:TextBox ID="TotalLandArea" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                ㎡
                                <asp:CheckBox runat="server" ID="IsGreenTotalLandArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="2">其  中
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">代征地面积:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="ExpropriationArea" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                            ha
                                    <asp:CheckBox runat="server" ID="IsGreenExpropriationArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">建设用地面积:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="ConstructionArea" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                            ha
                                    <asp:CheckBox runat="server" ID="IsGreenConstructionArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">总建筑面积
                            </td>
                            <td rowspan="2">
                                <asp:TextBox ID="OverallFloorage" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                ㎡
                                <asp:CheckBox runat="server" ID="IsGreenOverallFloorage" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="2">其  中
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地上:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="OvergroundArea" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                            ㎡
                                    <asp:CheckBox runat="server" ID="IsGreenOvergroundArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地下:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="UndergroundArea" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                            ㎡
                                    <asp:CheckBox runat="server" ID="IsGreenUndergroundArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>建筑基底面积
                            </td>
                            <td>
                                <asp:TextBox ID="BuildingArea" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                ㎡
                        <asp:CheckBox runat="server" ID="IsGreenBuildingArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>容 积 率
                            </td>
                            <td>
                                <asp:TextBox ID="PlotRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                        <asp:CheckBox runat="server" ID="IsGreenPlotRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>绿 地 面 积
                            </td>
                            <td>
                                <asp:TextBox ID="GreenArea" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                ㎡
                        <asp:CheckBox runat="server" ID="IsGreenGreenArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>绿 化 率
                            </td>
                            <td>
                                <asp:TextBox ID="GreeningRate" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                %
                        <asp:CheckBox runat="server" ID="IsGreenGreeningRate" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>建筑高度 
                            </td>
                            <td>
                                <asp:TextBox ID="BuildingHeight" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                m 
                        <asp:CheckBox runat="server" ID="IsGreenBuildingHeight" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>建筑分类<br />
                                （高层建筑）<br />
                                (一类/二类)
                            </td>
                            <td>
                                <asp:TextBox ID="BuildingClassification" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenBuildingClassification" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">层数
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地上:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="OvergroundLayerCount" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                            层
                                    <asp:CheckBox runat="server" ID="IsGreenOvergroundLayerCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">耐火等级<br />
                                （一级/二级）
                            </td>
                            <td rowspan="2">
                                <asp:TextBox ID="FireResistanceRating" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenFireResistanceRating" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地下:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="UndergroundLayerCount" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                            层
                                    <asp:CheckBox runat="server" ID="IsGreenUndergroundLayerCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">主要层高
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地上:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="LayerHeight_Overground" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                            m
                                    <asp:CheckBox runat="server" ID="IsGreenLayerHeight_Overground" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">主楼/裙房电<br />
                                梯数
                            </td>
                            <td style="padding: 0">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">主楼:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="ElevatorNumber_MainBuilding" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                            台
                                     <asp:CheckBox runat="server" ID="IsGreenElevatorNumber_MainBuilding" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">地下:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="LayerHeight_Underground" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                            m
                                    <asp:CheckBox runat="server" ID="IsGreenLayerHeight_Underground" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="padding: 0">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 100px;">裙房:             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="ElevatorNumber_PodiumBuilding" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                                            台
                                    <asp:CheckBox runat="server" ID="IsGreenElevatorNumber_PodiumBuilding" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">机动车停放数量
                            </td>
                            <td rowspan="2" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 100px">总计 :             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="AutoParkingCount" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                            辆
                                            <asp:CheckBox runat="server" ID="IsGreenAutoParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>地上
                            </td>
                            <td>
                                <asp:TextBox ID="OvergroundAutoParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                辆
                                <asp:CheckBox runat="server" ID="IsGreenOvergroundAutoParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:TextBox ID="UndergroundAutoParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                辆
                                <asp:CheckBox runat="server" ID="IsGreenUndergroundAutoParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">自行车停放数量
                            </td>
                            <td rowspan="2" style="padding: 0">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 100px;">总计 :             
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="BicycleParkingCount" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                            辆
                                            <asp:CheckBox runat="server" ID="IsGreenBicycleParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>地上
                            </td>
                            <td>
                                <asp:TextBox ID="OvergroundBicycleParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                辆
                                <asp:CheckBox runat="server" ID="IsGreenOvergroundBicycleParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:TextBox ID="UndergroundBicycleParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                辆
                                <asp:CheckBox runat="server" ID="IsGreenUndergroundBicycleParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 154px">周围道路宽度及性质：            
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="RoadWidth" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                            <script id="RoadWidthTextBox" type="text/plain" style="height: 300px;"></script>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0103')" id="Save_0103">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0103','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('04')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('04')" class="btnt up" style="margin: 0 20px;">下 一 步</a>
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab5">
                <asp:Panel ID="panelPart_0104" runat="server" GroupingText="专业技术指标（结构专业）">
                    <table>
                        <tr>
                            <td colspan="3" style="width: 200px;">结构体系</td>
                            <td colspan="4">
                                <asp:TextBox ID="StructuralSystem" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenStructuralSystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="width: 135px;">抗震设防烈度</td>
                            <td colspan="4">
                                <asp:TextBox ID="SeismicFortificationIntensity" runat="server" Width="80%"></asp:TextBox>
                                度
                        <asp:CheckBox runat="server" ID="IsGreenSeismicFortificationIntensity" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">抗震设防类别</td>
                            <td colspan="4">
                                <asp:TextBox ID="SeismicFortificationCategory" runat="server" Style="width: 90%; margin-left: 4%;"></asp:TextBox>
                                类
                        <asp:CheckBox runat="server" ID="IsGreenSeismicFortificationCategory" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>设计基本地震加速度值</td>
                            <td colspan="4">
                                <asp:TextBox ID="BasicSeismicAcceleration" runat="server" Width="80%"></asp:TextBox>
                                g
                        <asp:CheckBox runat="server" ID="IsGreenBasicSeismicAcceleration" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">设计地震分组</td>
                            <td colspan="4">
                                <asp:TextBox ID="EarthquakeGrouping" runat="server" Style="width: 90%; margin-left: 4%;"></asp:TextBox>
                                组
                        <asp:CheckBox runat="server" ID="IsGreenEarthquakeGrouping" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>场 地 类 别</td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionSiteSoilType" runat="server" Width="80%"></asp:TextBox>
                                类
                        <asp:CheckBox runat="server" ID="IsGreenConstructionSiteSoilType" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">基础类型</td>
                            <td colspan="8">
                                <asp:TextBox ID="BaseType" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenBaseType" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>

                        </tr>
                        <tr>
                            <td colspan="3">混凝土总用量</td>
                            <td colspan="4">
                                <asp:TextBox ID="ConcreteAmount" runat="server" Style="width: 89%;"></asp:TextBox>
                                m³
                        <asp:CheckBox runat="server" ID="IsGreenConcreteAmount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>每平方米混凝土折算厚度</td>
                            <td colspan="4">
                                <asp:TextBox ID="PerSqM_ConcreteReducedThickness" runat="server" Width="78%"></asp:TextBox>
                                cm/㎡
                        <asp:CheckBox runat="server" ID="IsGreenPerSqM_ConcreteReducedThickness" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" colspan="3">钢材总用量</td>
                            <td colspan="1">钢筋</td>
                            <td colspan="2">
                                <asp:TextBox ID="SteelAmount_rebar" runat="server" Style="width: 84%"></asp:TextBox>
                                t
                            </td>

                            <td rowspan="2">每平方米<br />
                                钢材用量</td>
                            <td colspan="1">钢筋</td>
                            <td colspan="3">
                                <asp:TextBox ID="PerSqM_SteelAmount_rebar" runat="server" Style="width: 78%"></asp:TextBox>
                                kg/㎡
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">型钢</td>
                            <td colspan="2">
                                <asp:TextBox ID="SteelAmount_SectionSteel" runat="server" Style="width: 84%"></asp:TextBox>
                                t
                            </td>
                            <td colspan="1">型钢</td>
                            <td colspan="3">
                                <asp:TextBox ID="PerSqM_SteelAmount_SectionSteel" runat="server" Style="width: 78%"></asp:TextBox>
                                kg/㎡
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="13">
                                抗<br />
                                震<br />
                                分<br />
                                析
                            </td>
                            <td colspan="3">程序名称</td>
                            <td colspan="7">
                                <asp:TextBox ID="SeismicAnalysisProgramName" runat="server" Style="width: 97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="3">
                                不<br />
                                考<br />
                                虑<br />
                                扭<br />
                                转<br />
                                耦<br />
                                联
                            </td>
                            <td colspan="2">方向
                            </td>
                            <td colspan="2">T1(s)
                            </td>
                            <td>F<sub>EK</sub> (kN)
                            </td>
                            <td colspan="2">F<sub>EK</sub>/Geq
                            </td>
                            <td>△Uu (mm)
                            </td>
                            <td>△Uu/h
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">横向
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="NoCoupling_H_T1" runat="server" Style="width: 89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenNoCoupling_H_T1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="NoCoupling_H_Fek_kN" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenNoCoupling_H_Fek_kN" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="NoCoupling_H_Fek_Geq" runat="server" Style="width: 83%"></asp:TextBox>
                                %
                         <asp:CheckBox runat="server" ID="IsGreenNoCoupling_H_Fek_Geq" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>
                                <asp:TextBox ID="NoCoupling_H_Uu_mm" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenNoCoupling_H_Uu_mm" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="NoCoupling_H_Uu_h" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenNoCoupling_H_Uu_h" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">纵向
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="NoCoupling_V_T1" runat="server" Style="width: 89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenNoCoupling_V_T1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="NoCoupling_V_Fek_kN" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenNoCoupling_V_Fek_kN" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="NoCoupling_V_Fek_Geq" runat="server" Style="width: 83%"></asp:TextBox>
                                %
                         <asp:CheckBox runat="server" ID="IsGreenNoCoupling_V_Fek_Geq" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>
                                <asp:TextBox ID="NoCoupling_V_Uu_mm" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenNoCoupling_V_Uu_mm" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="NoCoupling_V_Uu_h" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenNoCoupling_V_Uu_h" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="4">
                                考<br />
                                虑<br />
                                扭<br />
                                转<br />
                                耦<br />
                                联
                            </td>
                            <td>振型<br />
                                号
                            </td>
                            <td>T(s)
                            </td>
                            <td>转角
                            </td>
                            <td>扭转系数
                            </td>
                            <td>方向
                            </td>
                            <td>F<sub>EK</sub> (kN)
                            </td>
                            <td>F<sub>EK</sub>/Geq
                            </td>
                            <td>△Ue (mm)
                            </td>
                            <td>△Ue/h
                            </td>
                        </tr>
                        <tr>
                            <td>1
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_T1" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_T1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_Corner1" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_Corner1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_TorsionCoefficient1" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_TorsionCoefficient1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>横向
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_H_Fek_kN" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_H_Fek_kN" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_H_Fek_Geq" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_H_Fek_Geq" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_H_Ue_mm" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_H_Ue_mm" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_H_Ue_h" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_H_Ue_h" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>2
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_T2" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_T2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_Corner2" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_Corner2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_TorsionCoefficient2" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_TorsionCoefficient2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>纵向
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_V_Fek_kN" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_V_Fek_kN" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_V_Fek_Geq" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_V_Fek_Geq" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_V_Ue_mm" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_V_Ue_mm" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_V_Ue_h" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_V_Ue_h" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>3
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_T3" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_T3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_Corner3" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_Corner3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Coupling_TorsionCoefficient3" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCoupling_TorsionCoefficient3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>

                            <td>地震作用最大方向
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="MaxActionDirection" runat="server" Style="width: 93.5%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">时程分析程序名称</td>
                            <td colspan="7">
                                <asp:TextBox ID="TimeHistoryAnalysisProgramName" runat="server" Style="width: 96.6%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">波     名
                            </td>
                            <td colspan="2">F<sub>EK</sub> (kN)
                            </td>
                            <td colspan="2">F<sub>EK</sub>/Geq
                            </td>
                            <td>△U/h
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:TextBox ID="TimeHistory_WaveName1" runat="server" Style="width: 92.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTimeHistory_WaveName1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_kN1" runat="server" Style="width: 89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTimeHistory_Fek_kN1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_Geq1" runat="server" Style="width: 78%"></asp:TextBox>
                                %
                        <asp:CheckBox runat="server" ID="IsGreenTimeHistory_Fek_Geq1" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>
                                <asp:TextBox ID="TimeHistory_U_h1" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTimeHistory_U_h1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:TextBox ID="TimeHistory_WaveName2" runat="server" Style="width: 92.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTimeTimeHistory_WaveName2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_kN2" runat="server" Style="width: 89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTimeHistory_Fek_kN2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_Geq2" runat="server" Style="width: 78%"></asp:TextBox>
                                %
                        <asp:CheckBox runat="server" ID="IsGreenTimeHistory_Fek_Geq2" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>
                                <asp:TextBox ID="TimeHistory_U_h2" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTimeHistory_U_h2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:TextBox ID="TimeHistory_WaveName3" runat="server" Style="width: 92.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTimeHistory_WaveName3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_kN3" runat="server" Style="width: 89%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTimeHistory_Fek_kN3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistory_Fek_Geq3" runat="server" Style="width: 78%"></asp:TextBox>
                                %
                        <asp:CheckBox runat="server" ID="IsGreenTimeHistory_Fek_Geq3" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>
                                <asp:TextBox ID="TimeHistory_U_h3" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTimeHistory_U_h3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="11" style="text-align: left; padding-left: 10px;">结构专业设计主要特点：（不少于600字）</td>
                        </tr>
                        <tr>
                            <td colspan="11">
                                <asp:TextBox ID="StructureMainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="StructureMainFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0104')" id="Save_0104">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0104','Save')" class="btnt">保  &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('05')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('05')" class="btnt up" style="margin: 0 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab6">
                <asp:Panel ID="panelPart_0105" runat="server" GroupingText="专业技术指标（设备专业）">
                    <table>
                        <tr>
                            <td>采  暖  方  式
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="HeatingMode" runat="server" Style="width: 97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenHeatingMode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>采暖/空调总热负荷
                            </td>
                            <td>
                                <asp:TextBox ID="SpaceHeatingLoad" runat="server" Style="width: 82%"></asp:TextBox>
                                kW
                        <asp:CheckBox runat="server" ID="IsGreenSpaceHeatingLoad" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>空调总冷负荷
                            </td>
                            <td>
                                <asp:TextBox ID="AirConCoolingLoad" runat="server" Style="width: 83%"></asp:TextBox>
                                kW
                        <asp:CheckBox runat="server" ID="IsGreenAirConCoolingLoad" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>空调通风方式
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="AirConVentilationMode" runat="server" Style="width: 97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenAirConVentilationMode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>空调水系统方式
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="AirConWaterSystemMode" runat="server" Style="width: 97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenAirConWaterSystemMode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>给水系统方式
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="WaterSupplySystemMode" runat="server" Style="width: 97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenWaterSupplySystemMode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>中水回收使用方式
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="ReclaimedWaterRecycling" runat="server" Style="width: 97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenReclaimedWaterRecycling" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>雨、污水排放方式
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="SewageDischargeMode" runat="server" Style="width: 97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenSewageDischargeMode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>消防给水方式
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="FireWaterSupplyMode" runat="server" Style="width: 97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenFireWaterSupplyMode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align: left; padding-left: 10px;">设备专业设计主要特点：</td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <p>暖  通：（不少于300字）动  力：（不少于200字）给 排 水：（不少于200字）消防给水：（不少于200字）</p>
                                <asp:TextBox ID="MechanicalMainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="MechanicalMainFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0105')" id="Save_0105">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0105','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('06')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('06')" class="btnt up" style="margin: 0 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab7">
                <asp:Panel ID="panelPart_0106" runat="server" GroupingText="专业技术指标（电气专业）">
                    <table>
                        <tr>
                            <td>动力总电负荷
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="PowerTotalElectricLoad" runat="server" Style="width: 83%"></asp:TextBox>
                                kW
                        <asp:CheckBox runat="server" ID="IsGreenPowerTotalElectricLoad" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>照明总电负荷
                            </td>
                            <td>
                                <asp:TextBox ID="LightingTotalElectricLoad" runat="server" Style="width: 78%"></asp:TextBox>
                                kW
                        <asp:CheckBox runat="server" ID="IsGreenLightingTotalElectricLoad" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">供电电源设计情况
                            </td>
                            <td rowspan="2" colspan="2">
                                <asp:TextBox ID="DesignOfPowerSupply" runat="server" Style="width: 90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenDesignOfPowerSupply" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>变压器装机台数
                            </td>
                            <td>
                                <asp:TextBox ID="TransformerInstalledNumber" runat="server" Style="width: 80%"></asp:TextBox>
                                台
                        <asp:CheckBox runat="server" ID="IsGreenTransformerInstalledNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>变压器装机容量
                            </td>
                            <td>
                                <asp:TextBox ID="TransformerInstalledCapacity" runat="server" Style="width: 75%"></asp:TextBox>
                                kVA
                        <asp:CheckBox runat="server" ID="IsGreenTransformerInstalledCapacity" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>防雷设防类别及方式
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="LightningProtectionClass" runat="server" Style="width: 96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenLightningProtectionClass" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>动 力 内 容
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="DynamicContent" runat="server" Style="width: 96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenDynamicContent" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>弱电设计内容
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="WeakDesignContent" runat="server" Style="width: 96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenWeakDesignContent" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>照明方式节能措施
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="EnergySavingMeasures" runat="server" Style="width: 96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenEnergySavingMeasures" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>用电负荷等级确定情况
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="PowerLoadLevel" runat="server" Style="width: 96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenPowerLoadLevel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="5" style="text-align: left; padding-left: 10px;">电气专业设计主要特点：</td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <p>强  电：（不少于150字）弱  电：（不少于200字）</p>
                                <asp:TextBox ID="ElectricalMainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenElectricalMainFeatures" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="ElectricalMainFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0106')" id="Save_0106">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0106','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('07')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('07')" class="btnt up" style="margin: 0 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab8">
                <asp:Panel ID="panelPart_0107" runat="server" GroupingText="专业技术指标（技术经济指标）">
                    <table>
                        <tr>
                            <td>单位规模建筑面积指标
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 75%; border-right: none;">
                                            <asp:TextBox ID="UnitAreaIndicators" runat="server" Style="width: 70%"></asp:TextBox>
                                            ㎡<%--/ 
                                              <asp:TextBox ID="UnitAreaIndicatorsUnit" runat="server" Style="width: 10%; margin-left: 0px;"></asp:TextBox>--%></td>
                                        <asp:CheckBox runat="server" ID="IsGreenUnitAreaIndicatorsUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                    </tr>
                                </table>
                            </td>
                            <td>使用面积系数
                            </td>
                            <td>
                                <asp:TextBox ID="UseAreaCoefficient" runat="server" Style="width: 77%; margin-left: -6%;"></asp:TextBox>
                                %
                               
                        <asp:CheckBox runat="server" ID="IsGreenUseAreaCoefficient" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积耗热
                        量指标
                            </td>
                            <td>
                                <asp:TextBox ID="UnitAreaHotConsumption" runat="server" Width="73%"></asp:TextBox>
                                W/㎡
                        <asp:CheckBox runat="server" ID="IsGreenUnitAreaHotConsumption" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>单位建筑面积耗
                        冷量指标
                            </td>
                            <td>
                                <asp:TextBox ID="UnitAreaColdConsumption" runat="server" Width="77%"></asp:TextBox>
                                W/㎡
                        <asp:CheckBox runat="server" ID="IsGreenUnitAreaColdConsumption" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积变压
                        器装机容量
                            </td>
                            <td>
                                <asp:TextBox ID="UnitAreaTransformerCapacity" runat="server" Width="73%"></asp:TextBox>
                                VA/㎡
                        <asp:CheckBox runat="server" ID="IsGreenUnitAreaTransformerCapacity" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>日供水量
                            </td>
                            <td>
                                <asp:TextBox ID="DailyWaterSupply" runat="server" Width="77%"></asp:TextBox>
                                m³/日
                        <asp:CheckBox runat="server" ID="IsGreenDailyWaterSupply" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">概     算
                            </td>
                            <td colspan="2">竣 工 结 算
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">总造价
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">人民币:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="Estimate_RMB" runat="server" Width="75%"></asp:TextBox>
                                            万元
                                    <asp:CheckBox runat="server" ID="IsGreenEstimate_RMB" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">总造价
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">人民币:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="Settlement_RMB" runat="server" Width="71%"></asp:TextBox>
                                            万元
                                    <asp:CheckBox runat="server" ID="IsGreenSettlement_RMB" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">外币:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="Estimate_ForeignCurrency" runat="server" Width="75%"></asp:TextBox>
                                            美元
                                    <asp:CheckBox runat="server" ID="IsGreenEstimate_ForeignCurrency" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">外币:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="Settlement_ForeignCurrency" runat="server" Width="69%"></asp:TextBox>
                                            万美元
                                    <asp:CheckBox runat="server" ID="IsGreenSettlement_ForeignCurrency" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">土建与安装工<br />
                                程的比例
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">土建:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="Estimate_CivilEngineering" runat="server" Width="75%"></asp:TextBox>
                                            %
                                    <asp:CheckBox runat="server" ID="IsGreenEstimate_CivilEngineering" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">土建与安装工<br />
                                程的比例
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">土建:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="Settlement_CivilEngineering" runat="server" Width="72%"></asp:TextBox>
                                            %
                                    <asp:CheckBox runat="server" ID="IsGreenSettlement_CivilEngineering" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">安装:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="Estimate_Install" runat="server" Width="75%"></asp:TextBox>
                                            %
                                    <asp:CheckBox runat="server" ID="IsGreenEstimate_Install" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 100px;">安装:      
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="Settlement_Install" runat="server" Width="72%"></asp:TextBox>
                                            %
                                    <asp:CheckBox runat="server" ID="IsGreenSettlement_Install" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积造价</td>
                            <td>
                                <asp:TextBox ID="Estimate_PerUnitAreaRMB" runat="server" Width="81%"></asp:TextBox>
                                元/㎡
                                <asp:CheckBox runat="server" ID="IsGreenEstimate_PerUnitAreaRMB" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>单位建筑面积造价</td>
                            <td>
                                <asp:TextBox ID="Settlement_OneUnitAreaRMB" runat="server" Width="81%"></asp:TextBox>
                                元/㎡
                                <asp:CheckBox runat="server" ID="IsGreenSettlement_OneUnitAreaRMB" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>单位规模造价</td>
                            <td style="padding: 0;">
                                <asp:TextBox ID="Estimate_PerUnitScaleRMB" runat="server" Width="70%"></asp:TextBox>
                                元/㎡
                                <asp:CheckBox runat="server" ID="IsGreenEstimate_PerUnitScaleRMBUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>单位规模造价
                            </td>
                            <td>
                                <asp:TextBox ID="Settlement_OneUnitScaleRMB" runat="server" Width="70%"></asp:TextBox>
                                元/㎡
                                <asp:CheckBox runat="server" ID="IsGreenSettlement_OneUnitScaleRMBUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
<%--                        <tr>
                            <td>绿色建筑增量<br />
                                成本
                            </td>
                            <td>
                                <asp:TextBox ID="Estimate_IncrementalCost" runat="server" Width="72%"></asp:TextBox>
                                元/㎡
                        <asp:CheckBox runat="server" ID="IsGreenEstimate_IncrementalCost" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>绿色建筑增量<br />
                                成本
                            </td>
                            <td>
                                <asp:TextBox ID="Settlement_IncrementalCost" runat="server" Width="73%"></asp:TextBox>
                                元/㎡
                        <asp:CheckBox runat="server" ID="IsGreenSettlement_IncrementalCost" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>--%>
                        <tr>
                            <td>结算与概算出入<br />
                                的主要原因
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="Estimate_Settlement_Difference" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenEstimate_Settlement_Difference" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align: left; padding-left: 10px;">经济专业主要特点：（不少于100字）
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:TextBox ID="EconomicsFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="EconomicsFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <table>
                        <tr>
                            <td colspan="11" style="border: none;">
                                <h3>审核意见</h3>
                            </td>
                        </tr>
                        <tr>
                            <td>曾获奖项
                            </td>
                            <td>
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="AwardsTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                意   见
                            </td>
                            <td>
                                <asp:TextBox ID="UnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="UnitOpinionTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>地方、部门勘察设计同业协会推荐意见
                            </td>
                            <td>
                                <asp:TextBox ID="RecommendOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="RecommendOpinionTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0107')" id="Save_0107">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0107','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('08')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('08')" class="btnt up" style="margin: 0 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab9">
                <uc:Appendix runat="server" ID="ucAppendix"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab10">
                <uc:LegalStates runat="server" ID="ucLegalStates"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab11">
                <uc:Certificate runat="server" ID="ucCertificate"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab12">
                <uc:Comments runat="server" ID="ucComments"></uc:Comments>
            </div>
        </div>


        <script type="text/javascript">
            $('#ProfessionalCategories').ui_choose();
            $('#IsConsiderCoupling').ui_choose();
            switch ($('#IsConsiderCoupling').val()) {
                case "2901":
                    $('#txtIsConsiderCoupling').val("是");
                    break;
                case "2902":
                    $('#txtIsConsiderCoupling').val("否");
                    break;
            }

            for (i = 1; i < 16; i++) {
                if ($("#ParticipantName" + i).val() == "") {
                    $("#IDNumber" + i).attr('disabled', true);
                }
            }


            //页面保存
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

                $("#ProjectOverview").val(EncodeUEditorContent(UE.getEditor('ProjectOverviewTextBox').getContent()));
                $("#TechnicalFeatures").val(EncodeUEditorContent(UE.getEditor('TechnicalFeaturesTextBox').getContent()));                        // 技术特色
                $("#TechnicalDepth").val(EncodeUEditorContent(UE.getEditor('TechnicalDepthTextBox').getContent()));                        // 技术成效
                $("#ComprehensiveBenefit").val(EncodeUEditorContent(UE.getEditor('ComprehensiveBenefitTextBox').getContent()));                        // 综合效益
                $("#RoadWidth").val(EncodeUEditorContent(UE.getEditor('RoadWidthTextBox').getContent()));
                $("#StructureMainFeatures").val(EncodeUEditorContent(UE.getEditor('StructureMainFeaturesTextBox').getContent()));                            // 结构专业设计主要特点
                $("#MechanicalMainFeatures").val(EncodeUEditorContent(UE.getEditor('MechanicalMainFeaturesTextBox').getContent()));                                      // 设计特点:暖通、空调
                $("#ElectricalMainFeatures").val(EncodeUEditorContent(UE.getEditor('ElectricalMainFeaturesTextBox').getContent()));                                    // 设计特点:动力
                $("#EconomicsFeatures").val(EncodeUEditorContent(UE.getEditor('EconomicsFeaturesTextBox').getContent()));  // 设计特点:给 排 水
                $("#Awards").val(EncodeUEditorContent(UE.getEditor('AwardsTextBox').getContent()));
                $("#UnitOpinion").val(EncodeUEditorContent(UE.getEditor('UnitOpinionTextBox').getContent()));
                $("#RecommendOpinion").val(EncodeUEditorContent(UE.getEditor('RecommendOpinionTextBox').getContent()));
                //$("#ElectricityFeatures_Green").val(EncodeUEditorContent(UE.getEditor('ElectricityFeatures_GreenTextBox').getContent()));                              // 经济专业主要特点
                //$("#EconomicsFeatures").val(EncodeUEditorContent(UE.getEditor('EconomicsFeaturesTextBox').getContent()));                              // 经济专业主要特点

                var result = [];
                $("[data='" + PartCode + "']").not("span").each(function () {
                    if ($(this).attr("id") != null) {
                        result.push({ Name: $(this).attr("id"), Value: $(this).val() });
                    }
                });

                if (!checkUEditor('ProjectOverviewTextBox')
                    || !checkUEditor('TechnicalFeaturesTextBox')
                    || !checkUEditor('TechnicalDepthTextBox')
                    || !checkUEditor('ComprehensiveBenefitTextBox')
                    || !checkUEditor('RoadWidthTextBox')
                    || !checkUEditor('StructureMainFeaturesTextBox')
                    || !checkUEditor('MechanicalMainFeaturesTextBox')
                    || !checkUEditor('ElectricalMainFeaturesTextBox')
                    || !checkUEditor('EconomicsFeaturesTextBox')
                    || !checkUEditor('AwardsTextBox')
                    || !checkUEditor('UnitOpinionTextBox')
                    || !checkUEditor('RecommendOpinionTextBox')
                    //|| !checkUEditor('ElectricityFeatures_GreenTextBox')
                    //|| !checkUEditor('EconomicsFeaturesTextBox')
                    ) {
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
                            ShowMessag('已保存')
                        }
                    },
                    error: function (data) {
                        ShowMessag("保存失败, 请重新保存！");
                    }
                });

                SetCollaborationInfo();
            }

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
            //            } else {
            //                $('#CollaborativePhase02').val("");
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
            //        else {
            //            $("#txtDeclarationUnit2").val("");
            //            for (i = 1; i < 10; i++) {
            //                $("#CollaborativePhase2_0" + i).val("");
            //            }
            //            $("#CollaborativePhase2_10").val("");
            //            $("#CollaborativePhase2_11").val("");

            //            $("#txtDeclarationUnit3").val("");
            //            for (i = 1; i < 10; i++) {
            //                $("#CollaborativePhase3_0" + i).val("");
            //            }
            //            $("#CollaborativePhase3_10").val("");
            //            $("#CollaborativePhase3_11").val("");

            //            $("#txtDeclarationUnit4").val("");
            //            for (i = 1; i < 10; i++) {
            //                $("#CollaborativePhase4_0" + i).val("");
            //            }
            //            $("#CollaborativePhase4_10").val("");
            //            $("#CollaborativePhase4_11").val("");

            //            $("#txtDeclarationUnit5").val("");
            //            for (i = 1; i < 10; i++) {
            //                $("#CollaborativePhase5_0" + i).val("");
            //            }
            //            $("#CollaborativePhase5_10").val("");
            //            $("#CollaborativePhase5_11").val("");
            //        }
            //    }
            //});


            $(function () {
                SetCollaborationInfo();

                notBackspace();

                // 富文本框
                InitUEditor('ProjectOverviewTextBox', 500);              // 项目概况
                InitUEditor('TechnicalFeaturesTextBox', 1500);              // 技术特色
                InitUEditor('TechnicalDepthTextBox', 1500);              // 技术成效
                InitUEditor('ComprehensiveBenefitTextBox', 500);              // 综合效益
                InitUEditor('RoadWidthTextBox', 500);
                InitUEditor('StructureMainFeaturesTextBox', 1000);
                InitUEditor('MechanicalMainFeaturesTextBox', 2000);
                InitUEditor('ElectricalMainFeaturesTextBox', 1000);
                InitUEditor('EconomicsFeaturesTextBox', 500);
                InitUEditor('AwardsTextBox', 1000);
                InitUEditor('UnitOpinionTextBox', 1000);
                InitUEditor('RecommendOpinionTextBox', 1000);            

                //重置页面顺序
                $("#AppendixPrev").click(function () {
                    onPrev("09");
                });
                $("#AppendixNext").click(function () {
                    onNext("09");
                });
                $("#LegalStatesPrev").click(function () {
                    onPrev("10");
                });
                $("#LegalStatesNext").click(function () {
                    onNext("10");
                });
                $("#CertificatePrev").click(function () {
                    onPrev("11");
                });
                $("#CertificateNext").click(function () {
                    onNext("11");
                });
                $("#CommentsPrev").click(function () {
                    onPrev("12");
                });

                //保存上个pannel编辑内容
                $("#tabfather li a[data-toggle='tab']").click(function () {
                    var TabsId = getCookie('TabId');
                    var n = TabsId.substr(-2, 2);
                    var id = $(this).attr("id").substr(-2, 2);
                    ShowTab(id);
                    //alert(n);
                    //if (n == "01") {
                    //    // $("#Save_0101").click();
                    //} else if (n == "02") {
                    //    for (i = 1; i < 16; i++) {
                    //        if ($("#ParticipantName" + i).val().length != 0 && $("#IDType" + i).find("option:selected").text() == "身份证") {
                    //            if ($("#IDNumber" + i).val().length != 18) {
                    //                ShowMessag("您输入的身份证号不正确！");
                    //                $("#IDNumber" + i).css("border-color", "red");
                    //                return false;
                    //            }
                    //        }
                    //    }
                    //    //$("#Save_Participant").click();
                    //}
                    //else {
                    //    n = parseInt(n) - 1;
                    //    //$("#Save_01" + preZeroFill(n, 2)).click();
                    //}

                    //点击存储本次Tab的ID 
                    addCookie('TabId', $(this).attr("id"), 1);
                });
            });

            ////CollaborativePhase02CooperativeUnit1
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
            });

            $("#td3").click(function () {
                if ($("#DeclarationList2 div button span").html() != "") {
                    $("#CooperativeUnit3").attr('disabled', false);
                }
            });

            $("#td4").click(function () {
                if ($("#DeclarationList3 div button span").html() != "") {
                    $("#CooperativeUnit4").attr('disabled', false);
                }
            });

            $("#CooperativeUnit2").change(function () {
                if ($("#CooperativeUnit2").val() == "") {
                    $("#CooperativeUnit2").attr('disabled', true);
                }
            });
            $("#CooperativeUnit3").change(function () {
                if ($("#CooperativeUnit3").val() == "") {
                    $("#CooperativeUnit3").attr('disabled', true);
                }
            });
            $("#CooperativeUnit4").change(function () {
                if ($("#CooperativeUnit4").val() == "") {
                    $("#CooperativeUnit4").attr('disabled', true);
                }
            });
        </script>
</asp:Content>
