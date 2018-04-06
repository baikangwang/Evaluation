<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ResidentialBuilding_V2.aspx.cs" Inherits="Evaluation.View.Declaration.ResidentialBuilding_V2" validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/Participant.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/Appendix.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStates_V2.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/Certificate.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/Css/Declaration.css" rel="stylesheet" />

    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
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
                    padding: 10px 5px 5px 5px;
                    text-align: center;
                    line-height: 25px;
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
                            text-align: center;
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

        #tbAtlas a:hover {
            color: inherit;
            text-decoration: none;
            background-color: transparent;
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
            width: 82%;
        }

        #btab2 table select {
            margin-left: 5px;
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
        #ProjectOverviewTextBox,#Features_HVACTextBox,#Features_PowerTextBox,#Features_WaterSupplyAndDrainageTextBox,
        #Features_FireFacilitiesTextBox,#EconomicsFeaturesTextBox,
        #TechnicalFeaturesTextBox,
        #TechnicalDepthTextBox,
        #ComprehensiveBenefitTextBox,
        #ElectricityFeatures_HighVoltageTextBox,
        #ElectricityFeatures_LowVoltageTextBox,
        #ElectricityFeatures_EfficientTextBox,
        #StructuralFeaturesTextBox{
            width:97%;margin-left:10px;text-align:left;
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
        #MainreasonforchangeTextBox,#MainadvantagesanddisadvantagesTextBox,#AwardsTextBox,#UnitOpinionTextBox,#RecommendOpinionTextBox{
            width:85%;margin-left:10px;text-align:left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=020000" id="nav02" runat="server" clientidmode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
        </li>
    </ul>
    <div style="display: none">
        <asp:TextBox ID="txtSituation" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display: none">
        <asp:TextBox ID="txtUser" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display: none">
        <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display: none">
        <asp:TextBox ID="txtTemplate" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div class="tabbable" id="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、技术指标</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、审核意见</a></li>
           
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、附件目录</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、法人声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab">7、合作声明</a></li>
            <li><a id="tab_08" href="#btab8" data-toggle="tab" class="ExpertReviewList2" style="display: none;">8、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_0201" class="tab_div" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
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
                    <div style="display: none"><a onclick="javascript:onSave('Template_0201')" id="Save_0201" class="btnt">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0201','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onNext('01');" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" ID="ucParticipant"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_0202" runat="server" GroupingText="专业技术指标">
                    <table>
                        <tr>
                            <td>用地规模</td>
                            <td colspan="2"><asp:TextBox ID="Landscale" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> ha</td>
                            <td colspan="2">结构类型</td>
                            <td colspan="2"><asp:TextBox ID="Structuretype" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>居住建筑用地</td>
                            <td colspan="2"><asp:TextBox ID="Residentialbuildingland" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> ha</td>
                            <td colspan="2">公共建筑用地</td>
                            <td colspan="2"><asp:TextBox ID="Publicbuildingland" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox> </td>
                        </tr>
                        <tr>
                            <td>道路广场用地</td>
                            <td colspan="2"><asp:TextBox ID="Landforroad" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> ha</td>
                            <td colspan="2">绿化用地</td>
                            <td colspan="2"><asp:TextBox ID="Greenforland" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>建筑面积</td>
                            <td>总计</td>
                            <td><asp:TextBox ID="Grossfloorall" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox> 万m2</td>
                            <td>住宅</td>
                            <td><asp:TextBox ID="Grossfloorhome" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox> 万m2</td>
                            <td>公建</td>
                            <td><asp:TextBox ID="Grossfloorpublic" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox> 万m2</td>
                        </tr>
                        <tr>
                            <td>建筑高度（最高）</td>
                            <td colspan="2"><asp:TextBox ID="Buildingheight" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> m</td>
                            <td colspan="2">建筑高度（单体）</td>
                            <td colspan="2"><asp:TextBox ID="Buildingsigle" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> m</td>
                        </tr>
                        <tr>
                            <td>容 积 率</td>
                            <td colspan="2"><asp:TextBox ID="Volumeratio" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox></td>
                            <td colspan="2">绿 化 率</td>
                            <td colspan="2"><asp:TextBox ID="Greeningrate" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> %</td>
                        </tr>
                        <tr>
                            <td>住宅类型</td>
                            <td colspan="6"> <asp:TextBox ID="ResidentialType" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> </td>
                        </tr>
                        <tr>
                            <td rowspan="2">住宅平均每套<br/>建筑面积</td>
                            <td colspan="2" rowspan="2"><asp:TextBox ID="Averagefloor" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox> m2/套</td>
                            <td colspan="2" rowspan="2">总居住户数（人）</td>
                            <td colspan="2"><asp:TextBox ID="Totalnumber" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> 户</td>
                        </tr>
                        <tr>
                            <td colspan="2"><asp:TextBox ID="Totalnumberpeople" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> 人</td>
                        </tr>
                        <tr>
                            <td>机动车停放数量</td>
                            <td>总计</td>
                            <td><asp:TextBox ID="Parkingquantityall" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                            <td>地上</td>
                            <td><asp:TextBox ID="Parkingquantityup" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                            <td>地下</td>
                            <td><asp:TextBox ID="Parkingquantitydown" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>自行车停放数量</td>
                            <td>总计</td>
                            <td><asp:TextBox ID="Numberofparkedall" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                            <td>地上</td>
                            <td><asp:TextBox ID="Numberofparkedup" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                            <td>地下</td>
                            <td><asp:TextBox ID="Numberofparkeddown" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>机动车停车率</td>
                            <td colspan="2"><asp:TextBox ID="Vehicleparkingrate" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                            <td colspan="2">自行车停车率</td>
                            <td colspan="2"><asp:TextBox ID="Bicycleparkingrate" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>暖通/空调方式</td>
                            <td colspan="2"><asp:TextBox ID="HVACmode" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                            <td colspan="2">冷热源方式</td>
                            <td colspan="2"><asp:TextBox ID="Coldandheat" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>给排水方式</td>
                            <td colspan="2"><asp:TextBox ID="Watersupply" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                            <td colspan="2">消防给水方式</td>
                            <td colspan="2"><asp:TextBox ID="Firewatersupply" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                        </tr>
                          <tr>
                            <td>电热采暖</td>
                            <td colspan="2"><asp:TextBox ID="Electrothermalheating" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                            <td colspan="2">电梯总数</td>
                            <td colspan="2"><asp:TextBox ID="Elevatortotal" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>设 计 概 算</td>
                            <td colspan="2"><asp:TextBox ID="Designestimate" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> 万元</td>
                            <td colspan="2">竣工结算</td>
                            <td colspan="2"><asp:TextBox ID="Finalsettlement" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> 万元</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                住宅单方工程造价
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="Residentialunilateral" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox> 元/m2
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                               概算变更<br/>主要原因
                            </td>
                            <td colspan="5">
                                <asp:TextBox ID="Mainreasonforchange" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="MainreasonforchangeTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                               项目的主要优<br/>缺点及社会经<br/>济效益
                            </td>
                            <td colspan="5">
                                <p>（规划结构、交通组织、公建配套、环境景观、住宅设计、科技含量及各专业简要描述等，不少于1500字）</p>                               
                                <asp:TextBox ID="Mainadvantagesanddisadvantages" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="MainadvantagesanddisadvantagesTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>   
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0202')" id="Save_0202">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0202','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab4">
                <asp:Panel ID="panelPart_0203" runat="server" GroupingText="审核意见">
                      <table>                       
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
                    <div style="display: none"><a onclick="javascript:onSave('Template_0203')" id="Save_0203">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0203','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
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
    <%--</div>--%>

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

        //重置页面顺序
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
            //$("#ProjectOverview").val(EncodeUEditorContent(UE.getEditor('ProjectOverviewTextBox').getContent()));                       // 项目概况
            //$("#TechnicalFeatures").val(EncodeUEditorContent(UE.getEditor('TechnicalFeaturesTextBox').getContent()));                   // 技术特色
            //$("#TechnicalDepth").val(EncodeUEditorContent(UE.getEditor('TechnicalDepthTextBox').getContent()));                         // 技术成效
            //$("#ComprehensiveBenefit").val(EncodeUEditorContent(UE.getEditor('ComprehensiveBenefitTextBox').getContent()));             // 综合效益
            //$("#StructuralFeatures").val(EncodeUEditorContent(UE.getEditor('StructuralFeaturesTextBox').getContent()));                            // 结构专业设计主要特点
            //$("#Features_HVAC").val(EncodeUEditorContent(UE.getEditor('Features_HVACTextBox').getContent()));                                      // 设计特点:暖通、空调
            //$("#Features_Power").val(EncodeUEditorContent(UE.getEditor('Features_PowerTextBox').getContent()));                                    // 设计特点:动力
            //$("#Features_WaterSupplyAndDrainage").val(EncodeUEditorContent(UE.getEditor('Features_WaterSupplyAndDrainageTextBox').getContent()));  // 设计特点:给 排 水
            //$("#Features_FireFacilities").val(EncodeUEditorContent(UE.getEditor('Features_FireFacilitiesTextBox').getContent()));                  // 消防给水及其他灭火设施
            //$("#ElectricityFeatures_HighVoltage").val(EncodeUEditorContent(UE.getEditor('ElectricityFeatures_HighVoltageTextBox').getContent()));  // 设计特点：强电
            //$("#ElectricityFeatures_LowVoltage").val(EncodeUEditorContent(UE.getEditor('ElectricityFeatures_LowVoltageTextBox').getContent()));    // 设计特点：弱电
            //$("#ElectricityFeatures_Efficient").val(EncodeUEditorContent(UE.getEditor('ElectricityFeatures_EfficientTextBox').getContent()));      // 设计特点：节能
            //$("#EconomicsFeatures").val(EncodeUEditorContent(UE.getEditor('EconomicsFeaturesTextBox').getContent()));                              // 经济专业主要特点
            $("#Mainreasonforchange").val(EncodeUEditorContent(UE.getEditor('MainreasonforchangeTextBox').getContent()));
            $("#Mainadvantagesanddisadvantages").val(EncodeUEditorContent(UE.getEditor('MainadvantagesanddisadvantagesTextBox').getContent()));
            $("#Awards").val(EncodeUEditorContent(UE.getEditor('AwardsTextBox').getContent()));
            $("#UnitOpinion").val(EncodeUEditorContent(UE.getEditor('UnitOpinionTextBox').getContent()));
            $("#RecommendOpinion").val(EncodeUEditorContent(UE.getEditor('RecommendOpinionTextBox').getContent()));

            if (!checkUEditor('MainreasonforchangeTextBox')
                || !checkUEditor('MainadvantagesanddisadvantagesTextBox')
                || !checkUEditor('AwardsTextBox')
                || !checkUEditor('UnitOpinionTextBox')
                || !checkUEditor('RecommendOpinionTextBox')
                ) {
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
                }
            });
            SetCollaborationInfo();
            ////刷新分工表
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
            //    }
            //});

            //return true;
        }

        $(function () {
            SetCollaborationInfo();
            notBackspace();
            // 富文本框
            InitUEditor('MainreasonforchangeTextBox', 2000);                 
            InitUEditor('MainadvantagesanddisadvantagesTextBox', 2000);               
            InitUEditor('AwardsTextBox', 1000);                 
            InitUEditor('UnitOpinionTextBox', 1000);             
            InitUEditor('RecommendOpinionTextBox', 1000);                 


            $("#tabfather li a[data-toggle='tab']").click(function () {
                var TabsId = getCookie('TabId');
                var n = TabsId.substr(-2, 2);
                var id = $(this).attr("id").substr(-2, 2);
                ShowTab(id);             
                //if (n == "01") {
                //    //$("#Save_0201").click();
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
                //    //$("#Save_Participant").click();
                //}
                //else {
                //   // n = parseInt(n) - 1;
                //   // if (String(n).length == 1) {
                //        //$("#Save_020" + n).click();
                //   // }
                //   // else {
                //        //$("#Save_02" + n).click();
                //  //  }
                //}
                //点击存储本次Tab的ID
                addCookie('TabId', $(this).attr("id"), 1);               
            });
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
