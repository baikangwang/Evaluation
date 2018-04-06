<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="PublicBuilding.aspx.cs" Inherits="Evaluation.View.Declaration.PublicBuilding" validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/Participant.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/Appendix.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStates.ascx" %>
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
        #ProjectOverviewTextBox,#TechnicalFeaturesTextBox,#TechnicalDepthTextBox,#ComprehensiveBenefitTextBox
        ,#StructuralFeaturesTextBox,#ElectricityFeatures_ElectricalTextBox,#ElectricityFeatures_IntelligenceTextBox
        ,#ElectricityFeatures_GreenTextBox,#ElectricityFeatures_IntelligenceTextBox,#ElectricityFeatures_GreenTextBox
        , #Features_HVACTextBox,#Features_PowerTextBox,#Features_WaterSupplyAndDrainageTextBox
        ,#Features_FireFacilitiesTextBox,#EconomicsFeaturesTextBox{   
            margin-left:10px;width:97%;
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
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、建筑专业</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、结构专业</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、设备专业</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、电气专业</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab">7、经济指标</a></li>
            <li><a id="tab_08" href="#btab8" data-toggle="tab">8、附件目录</a></li>
            <li><a id="tab_09" href="#btab9" data-toggle="tab">9、法人声明</a></li>
            <li><a id="tab_10" href="#btab10" data-toggle="tab">10、合作声明</a></li>
            <li><a id="tab_11" href="#btab11" data-toggle="tab" class="ExpertReviewList2" style="display: none;">11、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_0101" class="tab_div" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 15%;">项目报优名称</td>
                            <td colspan="4">
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicDeclarationName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>立项名称</td>
                            <td colspan="4">
                                <asp:TextBox ID="ApprovalName" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicApprovalName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">申报单位<br />
                                (主申报)</td>
                            <td>申报单位</td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicDeclarationUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>通讯地址</td>
                            <td colspan="3">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicPostalAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>联系人</td>
                            <td>
                                <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="88.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsPublicLinkman" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>

                            <td style="width: 120px;">手机</td>
                            <td>
                                <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMobileNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>电话</td>
                            <td>
                                <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="88.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsPublicTelephoneNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>

                            <td>邮政编码</td>
                            <td>
                                <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicPostcode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>传真</td>
                            <td>
                                <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="88.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsPublicFaxNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>

                            <td>电子邮箱</td>
                            <td>
                                <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicEmailAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                                        <td style="width: 24.1%; border-right: none; text-align: left;">
                                            <asp:TextBox ID="CooperativeUnit1" runat="server" ClientIDMode="Static" Style="width: 88%;"
                                                 onblur="Sensitize('CooperativeUnit1','CollaborativePhase01')"></asp:TextBox>
                                        </td>
                                        <td style="border-right: none; width: 37.4%;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList1">
                                                <asp:DropDownList runat="server" ID="CollaborativePhase01" ClientIDMode="Static" Width="200px"></asp:DropDownList>
                                            </div>
                                            <div style="display: none">
                                                <asp:TextBox ID="CollaborativePhase1" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:TextBox ID="txtCollaborativePhase1" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                            </div>
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
                                            <asp:TextBox ID="CooperativeUnit2" runat="server" ClientIDMode="Static" Style="width: 88%;"
                                                 onblur="Sensitize('CooperativeUnit2','CollaborativePhase02')"></asp:TextBox>
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
                                            <asp:TextBox ID="CooperativeUnit3" runat="server" ClientIDMode="Static" Style="width: 88%;"
                                                 onblur="Sensitize('CooperativeUnit3','CollaborativePhase03')"></asp:TextBox>
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
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>建设单位</td>
                            <td colspan="4">
                                <asp:TextBox ID="DevelopmentOrganization" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicDevelopmentOrganization" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>施工单位</td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionOrganization" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicConstructionOrganization" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>使用单位</td>
                            <td colspan="4">
                                <asp:TextBox ID="UseUnit" runat="server" Width="97%" ClientIDMode="Static"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicUseUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点</td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionLocation" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicConstructionLocation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计类别</td>
                            <td style="width: 28%;">
                                <div class="DeclarationList">
                                    <asp:DropDownList runat="server" ID="DesignCategory" ClientIDMode="Static"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtDesignCategory" runat="server" Width="90%" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsPublicDesignCategory" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>设计起止时间</td>
                            <td style="width: 35%;" colspan="2">
                                <div class="datepicker input-group date" style="width: 48%;">
                                    <asp:TextBox ID="DesignStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计起始日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>

                                <div class="datepicker input-group date" style="width: 48%;">
                                    <asp:TextBox ID="DesignEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计结束日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsPublicDesignStartDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>开工时间</td>
                            <td>
                                <div class="datepicker input-group date" style="margin: 0px auto">
                                    <asp:TextBox ID="ConstructionStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择开工日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsPublicConstructionStartDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>竣工时间</td>
                            <td colspan="2">
                                <div class="datepicker input-group date" style="margin: 0px auto">
                                    <asp:TextBox ID="ConstructionEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsPublicConstructionEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>竣工验收时间</td>
                            <td>
                                <div class="datepicker input-group date" style="margin: 0px auto">
                                    <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工验收日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsPublicAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>竣工验收部门</td>
                            <td colspan="2">
                                <div style="margin: 0px auto; text-align: center;">
                                    <asp:TextBox ID="AcceptanceDepartment" runat="server" Width="64%"></asp:TextBox>
                                    <asp:CheckBox runat="server" ID="IsPublicAcceptanceDepartment" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>消防备案时间</td>
                            <td>
                                <div class="datepicker input-group date" style="margin: 0px auto">
                                    <asp:TextBox ID="FireControlRecordDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择消防备案日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsPublicFireControlRecordDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>交付使用时间</td>
                            <td colspan="2">
                                <div class="datepicker input-group date" style="margin: 0px auto">
                                    <asp:TextBox ID="DeliveryDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择交付使用日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsPublicDeliveryDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>投资来源</td>
                            <td colspan="4">
                                <div class="DeclarationList">
                                    <asp:DropDownList runat="server" ID="InvestSource" ClientIDMode="Static"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtInvestSource" runat="server" Width="90%" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsPublicInvestSource" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="padding: 0; display: none;">
                                <asp:DropDownList runat="server" ID="DeclarationLevel" ClientIDMode="Static"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>专业类别</td>
                            <td colspan="4">
                                <div class="DeclarationList">
                                    <asp:DropDownList runat="server" ID="ProfessionalCategories" ClientIDMode="Static"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtProfessionalCategories" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsMunicipalProfessionalCategories" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0101')" id="Save_0101">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0101','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onNext('01')"  class="btnt up" style="margin: 0 20px;">下 一 步</a>                       
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" ID="ucParticipant"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_0102" runat="server" GroupingText="技术申报内容(建筑专业)">
                    <table>
                        <tr>
                            <td rowspan="2" style="width: 90px;">建筑功能<br />
                                （使用性质）</td>
                            <td style="width: 50px;">地上</td>
                            <td colspan="3">
                                <asp:TextBox ID="UseProperty_Ground" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicUseProperty_Ground" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="width: 13%;">用地性质</td>
                            <td style="width: 25%;">
                                <asp:TextBox ID="LandNature" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicLandNature" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>地下</td>
                            <td colspan="3">
                                <asp:TextBox ID="UseProperty_Underground" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicUseProperty_Underground" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>设计使用年限</td>
                            <td>
                                <asp:TextBox ID="DesignServiceLife" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                年
                            <asp:CheckBox runat="server" ID="IsPublicDesignServiceLife" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">总用地面积</td>
                            <td>
                                <asp:TextBox ID="TotalLandArea" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                ha
                            <asp:CheckBox runat="server" ID="IsPublicTotalLandArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="width: 80px">代征地面积</td>
                            <td>
                                <asp:TextBox ID="ExpropriationArea" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                ha
                            <asp:CheckBox runat="server" ID="IsPublicExpropriationArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>建设用地面积</td>
                            <td>
                                <asp:TextBox ID="ConstructionArea" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                ha
                            <asp:CheckBox runat="server" ID="IsPublicConstructionArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">总建筑面积</td>
                            <td>
                                <asp:TextBox ID="OverallFloorage" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                ㎡
                            <asp:CheckBox runat="server" ID="IsPublicOverallFloorage" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>地上面积</td>
                            <td>
                                <asp:TextBox ID="OvergroundArea" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                ㎡
                            <asp:CheckBox runat="server" ID="IsPublicOvergroundArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>地下面积</td>
                            <td>
                                <asp:TextBox ID="UndergroundArea" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                ㎡
                            <asp:CheckBox runat="server" ID="IsPublicUndergroundArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">建筑基底面积</td>
                            <td>
                                <asp:TextBox ID="BuildingArea" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                ㎡
                            <asp:CheckBox runat="server" ID="IsPublicBuildingArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>绿地面积</td>
                            <td>
                                <asp:TextBox ID="GreenArea" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                ㎡
                            <asp:CheckBox runat="server" ID="IsPublicGreenArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>绿化率</td>
                            <td>
                                <asp:TextBox ID="GreeningRate" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                %
                            <asp:CheckBox runat="server" ID="IsPublicGreeningRate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">容 积 率</td>
                            <td>
                                <asp:TextBox ID="PlotRatio" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                
                            <asp:CheckBox runat="server" ID="IsPublicPlotRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>建筑密度</td>
                            <td>
                                <asp:TextBox ID="BuildingDensity" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                %
                            <asp:CheckBox runat="server" ID="IsPublicBuildingDensity" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>建筑分类/耐火等级</td>
                            <td>
                                <asp:TextBox ID="BuildingClassification" runat="server" ClientIDMode="Static" Width="36%" Style="float: left"></asp:TextBox><p style="float: left">  类/</p>
                                <asp:TextBox ID="FireResistanceRating" runat="server" ClientIDMode="Static" Width="35%" Style="float: left"></asp:TextBox> 级
                                <asp:CheckBox runat="server" ID="IsPublicBuildingClassification" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">建筑高度</td>
                            <td>
                                <asp:TextBox ID="BuildingHeight" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                m
                            <asp:CheckBox runat="server" ID="IsPublicBuildingHeight" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>地上层数</td>
                            <td>
                                <asp:TextBox ID="GroundLayerCount" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                层
                            <asp:CheckBox runat="server" ID="IsPublicGroundLayerCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>地下层数</td>
                            <td>
                                <asp:TextBox ID="UndergroundLayerCount" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                层
                            <asp:CheckBox runat="server" ID="IsPublicUndergroundLayerCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">机动车停车计</td>
                            <td>
                                <asp:TextBox ID="AutoParkingCount" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                辆
                            <asp:CheckBox runat="server" ID="IsPublicAutoParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>地上停车</td>
                            <td>
                                <asp:TextBox ID="GroundAutoParkingCount" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                辆
                            <asp:CheckBox runat="server" ID="IsPublicGroundAutoParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>地下停车</td>
                            <td>
                                <asp:TextBox ID="UndergroundAutoParkingCount" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                辆
                            <asp:CheckBox runat="server" ID="IsPublicUndergroundAutoParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">自行车停车计</td>
                            <td>
                                <asp:TextBox ID="BicycleParkingCount" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                辆
                            <asp:CheckBox runat="server" ID="IsPublicBicycleParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>地上停车</td>
                            <td>
                                <asp:TextBox ID="GroundBicycleParkingCount" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                辆
                            <asp:CheckBox runat="server" ID="IsPublicGroundBicycleParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>地下停车</td>
                            <td>
                                <asp:TextBox ID="UndergroundBicycleParkingCount" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                辆
                            <asp:CheckBox runat="server" ID="IsPublicUndergroundBicycleParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" colspan="2">防空地下室</td>
                            <td>建筑面积</td>
                            <td>战时用途</td>
                            <td>
                                <asp:TextBox ID="Basement_WartimeUse" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBasement_WartimeUse" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>抗力级别</td>
                            <td>
                                <asp:TextBox ID="Basement_ResistanceLevel" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                级
                            <asp:CheckBox runat="server" ID="IsPublicBasement_ResistanceLevel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="Basement_ConstructionArea" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                ㎡
                            <asp:CheckBox runat="server" ID="IsPublicBasement_ConstructionArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>平时用途</td>
                            <td>
                                <asp:TextBox ID="Basement_UsuallyUse" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBasement_UsuallyUse" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>防化级别</td>
                            <td>
                                <asp:TextBox ID="Basement_AntichemicalLevel" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                级
                            <asp:CheckBox runat="server" ID="IsPublicBasement_AntichemicalLevel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">备注</td>
                            <td colspan="5">
                                <asp:TextBox ID="ResidentialInfoMemo" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicResidentialInfoMemo" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">项目概况（限200～300字）</td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 200px"></asp:TextBox>
                                <script id="ProjectOverviewTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">技术特色（限200～400字）</td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="TechnicalFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 200px"></asp:TextBox>
                                <script id="TechnicalFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">技术成效与深度（限200～400字）</td>
                        </tr>
                        <tr>                            
                            <td colspan="7" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="TechnicalDepth" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 200px"></asp:TextBox>
                                <script id="TechnicalDepthTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">综合效益（限200～400字）</td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="ComprehensiveBenefit" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 200px"></asp:TextBox>
                                <script id="ComprehensiveBenefitTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0102')" id="Save_0102">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0102','Save');" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin:0 20px;">下 一 步</a>                       
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab4">
                <asp:Panel ID="panelPart_0103" runat="server" GroupingText="技术申报内容(结构专业)">
                    <table>
                        <tr>
                            <td colspan="3">结构体系</td>
                            <td colspan="3" style="width: 30%">
                                <asp:TextBox ID="StructuralSystem" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicStructuralSystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>抗震设防烈度</td>
                            <td colspan="2">
                                <asp:TextBox ID="FortificationIntensity" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                度
                            <asp:CheckBox runat="server" ID="IsPublicFortificationIntensity" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">抗震设防类别</td>
                            <td colspan="3">
                                <asp:TextBox ID="FortificationCategory" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicFortificationCategory" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>基本地震加速度</td>
                            <td colspan="2">
                                <asp:TextBox ID="BasicSeismicAcceleration" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                g
                            <asp:CheckBox runat="server" ID="IsPublicBasicSeismicAcceleration" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">设计地震分组</td>
                            <td colspan="3">
                                <asp:TextBox ID="SeismicGrouping" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicSeismicGrouping" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>建筑场地土类别</td>
                            <td colspan="2">
                                <asp:TextBox ID="SiteSoilType" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                类
                            <asp:CheckBox runat="server" ID="IsPublicSiteSoilType" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">基础类型</td>
                            <td colspan="3">
                                <asp:TextBox ID="BaseType" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseType" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>结构安全等级</td>
                            <td colspan="2">
                                <asp:TextBox ID="SafetyLevel" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                级
                            <asp:CheckBox runat="server" ID="IsPublicSafetyLevel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">混凝土总用量（砖混结构可不填写此栏及后三栏）</td>
                            <td colspan="3">
                                <asp:TextBox ID="ConcreteAmount" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                m³
                            <asp:CheckBox runat="server" ID="IsPublicConcreteAmount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>每平方米混凝土折算厚度</td>
                            <td colspan="2">
                                <asp:TextBox ID="PerSqM_ConcreteReducedThickness" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox>
                                cm/㎡
                            <asp:CheckBox runat="server" ID="IsPublicPerSqM_ConcreteReducedThickness" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" colspan="3">钢材总用量</td>
                            <td style="width: 80px;">钢筋:
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="SteelAmount_rebar" runat="server" ClientIDMode="Static" Width="81%"></asp:TextBox>
                                t
                            <asp:CheckBox runat="server" ID="IsPublicSteelAmount_rebar" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="2">每平方米钢材用量</td>
                            <td style="width: 80px;">钢筋:
                            </td>
                            <td>
                                <asp:TextBox ID="PerSqM_SteelAmount_rebar" runat="server" ClientIDMode="Static" Width="69%"></asp:TextBox>
                                kg/㎡
                                <asp:CheckBox runat="server" ID="IsPublicPerSqM_SteelAmount_rebar" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>型钢:
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="SteelAmount_SectionSteel" runat="server" ClientIDMode="Static" Width="81%"></asp:TextBox>
                                t
                                <asp:CheckBox runat="server" ID="IsPublicSteelAmount_SectionSteel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>型钢:
                            </td>
                            <td>
                                <asp:TextBox ID="PerSqM_SteelAmount_SectionSteel" runat="server" ClientIDMode="Static" Width="69%"></asp:TextBox>
                                kg/㎡
                            <asp:CheckBox runat="server" ID="IsPublicPerSqM_SteelAmount_SectionSteel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="21" style="width: 40px;">抗震分析主要结果</td>
                            <td colspan="2">程序名称：                
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="ModeProgramName" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="CheckBox1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                           <td>是否考虑扭转耦联</td>
                            <td colspan="2">
                                <div class="DeclarationList">
                                    <asp:DropDownList ID="IsConsiderCoupling" runat="server" ClientIDMode="Static" Width="81%"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsConsiderCoupling" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsResidentialTextBox105" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 80px;">振型号</td>
                            <td style="width: 100px;">周期</td>
                            <td style="width: 100px;">转角</td>
                            <td style="width: 100px;">平动系数(x+y)</td>
                            <td style="width: 100px;">扭转系数</td>
                            <td>X向基底剪力(kN)</td>
                            <td colspan="2">Y向基底剪力(kN)</td>
                        </tr>
                        <tr>
                            <td>
                                1
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle1" runat="server" ClientIDMode="Static" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeCycle1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle1" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeAngle1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient1" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTranslationalCoefficient1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TorsionCoefficient1" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTorsionCoefficient1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_X" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="BaseShear_Y" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_Y" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                2
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle2" runat="server" ClientIDMode="Static" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeCycle2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle2" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeAngle2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient2" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTranslationalCoefficient2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TorsionCoefficient2" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTorsionCoefficient2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>X向基底剪重比</td>
                            <td colspan="2">Y向基底剪重比</td>
                        </tr>
                        <tr>
                            <td>
                                3
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle3" runat="server" ClientIDMode="Static" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeCycle3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle3" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeAngle3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient3" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTranslationalCoefficient3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TorsionCoefficient3" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTorsionCoefficient3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BasalShearRatio_X" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBasalShearRatio_X" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="BasalShearRatio_Y" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBasalShearRatio_Y" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                4
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle4" runat="server" ClientIDMode="Static" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeCycle4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle4" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeAngle4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient4" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTranslationalCoefficient4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TorsionCoefficient4" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTorsionCoefficient4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>X向最小剪重比（层号）</td>
                            <td colspan="2">Y向最小剪重比（层号）</td>
                        </tr>
                        <tr>
                            <td>
                                5
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle5" runat="server" ClientIDMode="Static" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeCycle5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle5" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeAngle5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient5" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTranslationalCoefficient5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TorsionCoefficient5" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTorsionCoefficient5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MinShearWeightRatio_X" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMinShearWeightRatio_X" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MinShearWeightRatio_Y" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMinShearWeightRatio_Y" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                6
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle6" runat="server" ClientIDMode="Static" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeCycle6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle6" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeAngle6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient6" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTranslationalCoefficient6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TorsionCoefficient6" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTorsionCoefficient6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>X向最大层间位移角</td>
                            <td colspan="2">Y向最大层间位移角</td>
                        </tr>
                        <tr>
                            <td>
                                7
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle7" runat="server" ClientIDMode="Static" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeCycle7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle7" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeAngle7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient7" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTranslationalCoefficient7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TorsionCoefficient7" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTorsionCoefficient7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_X" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_X" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_Y" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                8
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle8" runat="server" ClientIDMode="Static" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeCycle8" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle8" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeAngle8" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient8" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTranslationalCoefficient8" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TorsionCoefficient8" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTorsionCoefficient8" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>X向最大位移比（层号）</td>
                            <td colspan="2">Y向最大位移比（层号）</td>
                        </tr>
                        <tr>
                            <td>
                                9
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeCycle9" runat="server" ClientIDMode="Static" Width="76%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeCycle9" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="VibrationModeAngle9" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicVibrationModeAngle9" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TranslationalCoefficient9" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTranslationalCoefficient9" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="TorsionCoefficient9" runat="server" ClientIDMode="Static" Width="73%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTorsionCoefficient9" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxDisplacementRatio_X" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxDisplacementRatio_X" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MaxDisplacementRatio_Y" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxDisplacementRatio_Y" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8">注：单塔可仅填前三个振型 </td>
                        </tr>
                        <tr>
                            <td colspan="3">时程分析波名</td>
                            <td>X向基底剪力(kN)</td>
                            <td>X向最大层间位移角</td>
                            <td>Y向基底剪力(kN)</td>
                            <td colspan="2">Y向最大层间位移角</td>
                        </tr>
                        <tr>
                            <td colspan="1">1</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName1" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTimeHistoryAnalysisName1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X1" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_X1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_X1" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_X1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y1" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_Y1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y1" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_Y1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">2</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName2" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTimeHistoryAnalysisName2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X2" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_X2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_X2" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_X2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y2" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_Y2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y2" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_Y2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">3</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName3" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTimeHistoryAnalysisName3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X3" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_X3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_X3" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_X3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y3" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_Y3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y3" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_Y3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">4</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName4" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTimeHistoryAnalysisName4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X4" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_X4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_X4" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_X4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y4" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_Y4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y4" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_Y4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">5</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName5" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTimeHistoryAnalysisName5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X5" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_X5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_X5" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_X5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y5" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_Y5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y5" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_Y5" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">6</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName6" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTimeHistoryAnalysisName6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X6" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_X6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_X6" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_X6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y6" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_Y6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y6" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_Y6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">7</td>
                            <td colspan="2">
                                <asp:TextBox ID="TimeHistoryAnalysisName7" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicTimeHistoryAnalysisName7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_X7" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_X7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_X7" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_X7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y7" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_Y7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y7" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_Y7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">各波平均值(当选3条波时为包络值)</td>
                            <td>
                                <asp:TextBox ID="BaseShear_X_Avg" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_X_Avg" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="MaxStoreyDriftAngle_X_Avg" runat="server" ClientIDMode="Static" Width="74%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_X_Avg" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="BaseShear_Y_Avg" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicBaseShear_Y_Avg" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="MaxStoreyDriftAngle_Y_Avg" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicMaxStoreyDriftAngle_Y_Avg" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="9" style="text-align: left; padding-left: 10px;">结构专业设计主要特点（限400~600字）</td>
                        </tr>
                        <tr>
                            <td colspan="9">
                                <asp:TextBox ID="StructuralFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="StructuralFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsPublicStructuralFeatures" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0103')" id="Save_0103">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0103','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('04')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('04')" class="btnt up" style="margin:0 20px;">下 一 步</a>                   
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab5">
                <asp:Panel ID="panelPart_0104" runat="server" GroupingText="技术申报内容(设备专业)">
                    <table>
                        <tr>
                            <td>供暖方式</td>
                            <td colspan="2">
                                <asp:TextBox ID="HeatingMode" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingMode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>供暖建筑面积</td>
                            <td colspan="2">
                                <asp:TextBox ID="HeatingConstructionArea" runat="server" ClientIDMode="Static" Width="82%"></asp:TextBox>
                                ㎡
                            <asp:CheckBox runat="server" ID="IsPublicHeatingConstructionArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">供暖热负荷</td>
                            <td rowspan="2" colspan="2">
                                <asp:TextBox ID="SpaceHeatingLoad" runat="server" ClientIDMode="Static" Style="width: 83%; margin-left: 7%;"></asp:TextBox>
                                KW
                            <asp:CheckBox runat="server" ID="IsPublicSpaceHeatingLoad" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="2">供暖热负荷指标</td>
                            <td colspan="2">
                                <asp:TextBox ID="SpaceHeatingLoadIndicators_TotalArea" runat="server" ClientIDMode="Static" Style="width: 50%; margin-left: 5%;"></asp:TextBox>
                                W/㎡（总建筑面积）
                            <asp:CheckBox runat="server" ID="IsPublicSpaceHeatingLoadIndicators_TotalArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:TextBox ID="SpaceHeatingLoadIndicators_AirConArea" runat="server" ClientIDMode="Static" Style="width: 50%; margin-left: 6%;"></asp:TextBox>
                                W/㎡（空调建筑面积）
                            <asp:CheckBox runat="server" ID="IsPublicSpaceHeatingLoadIndicators_AirConArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>空调系统形式</td>
                            <td colspan="2">
                                <asp:TextBox ID="AirConSysMode" runat="server" ClientIDMode="Static" Width="83%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicAirConSysMode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>空调建筑面积</td>
                            <td colspan="2">
                                <asp:TextBox ID="AirConBuildingArea" runat="server" ClientIDMode="Static" Width="82%"></asp:TextBox>
                                ㎡
                            <asp:CheckBox runat="server" ID="IsPublicAirConBuildingArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">空调冷负荷</td>
                            <td rowspan="2" colspan="2">
                                <asp:TextBox ID="AirConCoolingLoad" runat="server" ClientIDMode="Static" Style="width: 83%; margin-left: 7%;"></asp:TextBox>
                                KW
                            <asp:CheckBox runat="server" ID="IsPublicAirConCoolingLoad" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="2">空调冷指标</td>
                            <td colspan="2">
                                <asp:TextBox ID="AirConCoolingIndicators_TotalArea" runat="server" ClientIDMode="Static" Style="width: 50%; margin-left: 3%;"></asp:TextBox>
                                W/㎡（总建筑面积）
                            <asp:CheckBox runat="server" ID="IsPublicAirConCoolingIndicators_TotalArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:TextBox ID="AirConCoolingIndicators_AirConArea" runat="server" ClientIDMode="Static" Style="width: 50%; margin-left: 6%;"></asp:TextBox>
                                W/㎡（空调建筑面积）
                            <asp:CheckBox runat="server" ID="IsPublicAirConCoolingIndicators_AirConArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">空调热负荷</td>
                            <td rowspan="2" colspan="2">
                                <asp:TextBox ID="AirConHeatingLoad" runat="server" ClientIDMode="Static" Style="width: 83%; margin-left: 7%;"></asp:TextBox>
                                KW
                            <asp:CheckBox runat="server" ID="IsPublicAirConHeatingLoad" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="2">空调热指标</td>
                            <td colspan="2">
                                <asp:TextBox ID="AirConHeatingIndicators_TotalArea" runat="server" ClientIDMode="Static" Style="width: 50%; margin-left: 3%;"></asp:TextBox>
                                W/㎡（总建筑面积）
                            <asp:CheckBox runat="server" ID="IsPublicAirConHeatingIndicators_TotalArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:TextBox ID="AirConHeatingIndicators_AirConArea" runat="server" ClientIDMode="Static" Style="width: 50%; margin-left: 6%;"></asp:TextBox>
                                W/㎡（空调建筑面积）
                            <asp:CheckBox runat="server" ID="IsPublicAirConHeatingIndicators_AirConArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6">冷源</td>
                        </tr>
                        <tr>
                            <td rowspan="3">冷水机组类型</td>
                            <td>
                                <asp:TextBox ID="ChillerType1" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicChillerType1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="3">单台设计制冷量</td>
                            <td>
                                <asp:TextBox ID="ChillerOutput1" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicChillerOutput1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="3">台数</td>
                            <td>
                                <asp:TextBox ID="ChillerQuantity1" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicChillerQuantity1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="ChillerType2" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicChillerType2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="ChillerOutput2" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicChillerOutput2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="ChillerQuantity2" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicChillerQuantity2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="ChillerType3" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicChillerType3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="ChillerOutput3" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicChillerOutput3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="ChillerQuantity3" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicChillerQuantity3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6">热源</td>
                        </tr>
                        <tr>
                            <td rowspan="3">制热设备类型</td>
                            <td>
                                <asp:TextBox ID="HeatingEquipmentType1" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingEquipmentType1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="3">单台设计供热</td>
                            <td>
                                <asp:TextBox ID="HeatingEquipmentOutput1" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingEquipmentOutput1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="3">台数</td>
                            <td>
                                <asp:TextBox ID="HeatingEquipmentQuantity1" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingEquipmentQuantity1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="HeatingEquipmentType2" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingEquipmentType2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="HeatingEquipmentOutput2" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingEquipmentOutput2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="HeatingEquipmentQuantity2" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingEquipmentQuantity2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="HeatingEquipmentType3" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingEquipmentType3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="HeatingEquipmentOutput3" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingEquipmentOutput3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="HeatingEquipmentQuantity3" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingEquipmentQuantity3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>供暖系统制式</td>
                            <td colspan="5">
                                <asp:TextBox ID="HeatingSystem" runat="server" ClientIDMode="Static" Width="97.2%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHeatingSystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>空调水系统制式</td>
                            <td colspan="5">
                                <asp:TextBox ID="AirConWaterSystem" runat="server" ClientIDMode="Static" Width="97.2%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicAirConWaterSystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>给水系统形式</td>
                            <td colspan="5">
                                <asp:TextBox ID="WaterSupplySystem" runat="server" ClientIDMode="Static" Width="97.2%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicWaterSupplySystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>中水系统形式</td>
                            <td colspan="5">
                                <asp:TextBox ID="ReclaimedWaterSystem" runat="server" ClientIDMode="Static" Width="97.2%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicReclaimedWaterSystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>雨、污水系统形式</td>
                            <td colspan="5">
                                <asp:TextBox ID="SewageSystem" runat="server" ClientIDMode="Static" Width="97.2%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicSewageSystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>消防给水系统形式</td>
                            <td colspan="5">
                                <asp:TextBox ID="FireWaterSupplySystem" runat="server" ClientIDMode="Static" Width="97.2%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicFireWaterSupplySystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">设计特点:暖通、空调：（限制200～300字)</td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="Features_HVAC" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="Features_HVACTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsPublicFeatures_HVAC" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">动  力：（限制200～300字）</td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="Features_Power" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="Features_PowerTextBox" type="text/plain" style=" height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsPublicFeatures_Power" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">给 排 水：（限制100～200字）</td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="Features_WaterSupplyAndDrainage" ClientIDMode="Static" runat="server" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="Features_WaterSupplyAndDrainageTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsPublicFeatures_WaterSupplyAndDrainage" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">消防给水及其他灭火设施：（限制100～200字）</td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="Features_FireFacilities" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="Features_FireFacilitiesTextBox" type="text/plain" style=" height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsPublicFeatures_FireFacilities" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0104')" id="Save_0104">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0104','Save')" class="btnt">保  &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('05')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('05')" class="btnt up" style="margin:0 20px;">下 一 步</a>                       
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab6">
                <asp:Panel ID="panelPart_0105" runat="server" GroupingText="技术申报内容(电气专业)">
                    <table>
                        <tr>
                            <td colspan="2" style="width: 180px;">供电电源设计情况</td>
                            <td colspan="5">
                                <asp:TextBox ID="ElectricitySupplyDesign" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicElectricitySupplyDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">用电负荷等级确定情况</td>
                            <td colspan="5">
                                <asp:TextBox ID="ElectricityLoadLevels" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicElectricityLoadLevels" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">防雷类别及措施</td>
                            <td colspan="5">
                                <asp:TextBox ID="LightningProtection" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicLightningProtection" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">建筑电气设计</td>
                            <td colspan="5">
                                <asp:TextBox ID="HighVoltageDesign" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicHighVoltageDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">建筑智能化设计</td>
                            <td colspan="5">
                                <asp:TextBox ID="LowVoltageDesign" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicLowVoltageDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">电力总用电负荷</td>
                            <td colspan="2">
                                <asp:TextBox ID="TotalElectricityload" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>&nbsp; KW
                            <asp:CheckBox runat="server" ID="IsPublicTotalElectricityload" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">照明总用电负荷</td>
                            <td>
                                <asp:TextBox ID="TotalLightingLoad" runat="server" ClientIDMode="Static" Style="width: 53%"></asp:TextBox>
                                KW
                            <asp:CheckBox runat="server" ID="IsPublicTotalLightingLoad" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">变压器配置</td>
                            <td colspan="2">
                                <asp:TextBox ID="TransformerConfig" runat="server" ClientIDMode="Static" Width="50%"></asp:TextBox>/
                                <asp:TextBox ID="TransformerConfigUnit" runat="server" ClientIDMode="Static" Width="30%"></asp:TextBox>
                            <asp:CheckBox runat="server" ID="IsPublicTransformerConfig" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">变压器装机密度</td>
                            <td>
                                <asp:TextBox ID="TransformerDensity" runat="server" ClientIDMode="Static" Style="width: 53%"></asp:TextBox>
                                KVA/㎡
                            <asp:CheckBox runat="server" ID="IsPublicTransformerDensity" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">备用电源设置情况及总容量</td>
                            <td colspan="2">
                                <asp:TextBox ID="StandbyElectricity" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>&nbsp; KW
                            <asp:CheckBox runat="server" ID="IsPublicStandbyElectricity" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2">备用电源装机密度</td>
                            <td>
                                <asp:TextBox ID="StandbyElectricityDensity" runat="server" ClientIDMode="Static" Style="width: 25%"></asp:TextBox>
                                KVA/㎡或<asp:TextBox ID="StandbyElectricityDensityKW" runat="server" ClientIDMode="Static" Style="width: 25%"></asp:TextBox>KW/㎡
                            <asp:CheckBox runat="server" ID="IsResidentialStandbyElectricityDensity" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">备注</td>
                            <td colspan="5">
                                <asp:TextBox ID="ElectricityMemo" runat="server" ClientIDMode="Static" Width="96.6%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsPublicElectricityMemo" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">主要特点-建筑电气：（限200～300字）</td>
                        </tr>
                        <tr>
                            <td colspan="7">
                                <asp:TextBox ID="ElectricityFeatures_Electrical" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 200px;"></asp:TextBox>
                                <script id="ElectricityFeatures_ElectricalTextBox" type="text/plain" style=" height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsPublicElectricityFeatures_Electrical" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">主要特点-建筑智能化：（限200～300字）</td>
                        </tr>
                        <tr>
                            <td colspan="7">
                                <asp:TextBox ID="ElectricityFeatures_Intelligence" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 200px;"></asp:TextBox>
                                <script id="ElectricityFeatures_IntelligenceTextBox" type="text/plain" style=" height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsPublicElectricityFeatures_Intelligence" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">主要特点-绿色节能、环保措施：（限80～150字）</td>
                        </tr>
                        <tr>
                            <td colspan="7">
                                <asp:TextBox ID="ElectricityFeatures_Green" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 200px;"></asp:TextBox>
                                <script id="ElectricityFeatures_GreenTextBox" type="text/plain" style=" height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsPublicElectricityFeatures_Green" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0105')" id="Save_0105">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0105','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('06')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('06')" class="btnt up" style="margin:0 20px;">下 一 步</a>                        
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab7">
                <asp:Panel ID="panelPart_0106" runat="server" GroupingText="技术经济指标">
                    <table>
                        <tr>
                            <td style="width: 150px;">单位规模建筑面积指标</td>
                            <td colspan="3">
                                <asp:TextBox ID="UnitAreaIndicators" runat="server" ClientIDMode="Static" Width="70%"></asp:TextBox> ㎡/
                                 <asp:TextBox ID="UnitAreaIndicatorsUnit" runat="server" ClientIDMode="Static" Width="8%"></asp:TextBox>
                            </td>                                                                                   
                                <asp:CheckBox runat="server" ID="IsPublicUnitAreaIndicators" ClientIDMode="Static" ToolTip="公开" Checked="true" />                         
                            <td>使用面积系数</td>
                            <td colspan="3">
                                <asp:TextBox ID="UseAreaCoefficient" runat="server" ClientIDMode="Static" Width="84%"></asp:TextBox> %
                            </td>                          
                            <asp:CheckBox runat="server" ID="IsPublicUseAreaCoefficient" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                           
                        </tr>
                        <tr>
                            <td>单位建筑面积耗热量指标</td>
                            <td colspan="3">
                                <asp:TextBox ID="UnitAreaHotConsumption" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox> W/㎡
                            </td>                           
                                <asp:CheckBox runat="server" ID="IsPublicUnitAreaHotConsumption" ClientIDMode="Static" ToolTip="公开" Checked="true" />                          
                            <td>单位建筑面积耗冷量指标</td>
                            <td colspan="3">
                                <asp:TextBox ID="UnitAreaColdConsumption" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox> W/㎡
                            </td>                         
                            <asp:CheckBox runat="server" ID="IsPublicUnitAreaColdConsumption" ClientIDMode="Static" ToolTip="公开" Checked="true" />                          
                        </tr>
                        <tr>
                            <td>单位建筑面积变压器装机容量</td>
                            <td colspan="3">
                                <asp:TextBox ID="UnitAreaTransformerCapacity" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox> VA/㎡
                            </td>                        
                            <asp:CheckBox runat="server" ID="IsPublicUnitAreaTransformerCapacity" ClientIDMode="Static" ToolTip="公开" Checked="true" />                       
                            <td>日供水量</td>
                            <td colspan="3" >
                                <asp:TextBox ID="DailyWaterSupply" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>m<sup>3</sup> /日
                            </td>                        
                            <asp:CheckBox runat="server" ID="IsPublicDailyWaterSupply" ClientIDMode="Static" ToolTip="公开" Checked="true" />                     
                        </tr>
                        <tr>
                            <td colspan="4">概算</td>
                            <td colspan="4">竣工决算</td>
                        </tr>
                        <tr>
                            <td rowspan="2">总造价</td>
                            <td>人民币</td>
                            <td colspan="2">
                                <asp:TextBox ID="Estimate_RMB" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox> 万元
                            </td>                        
                            <asp:CheckBox runat="server" ID="IsPublicEstimate_RMB" ClientIDMode="Static" ToolTip="公开" Checked="true" />                           
                            <td rowspan="2">总造价</td>
                            <td style="width:57px;">人民币</td>
                            <td colspan="2">
                                <asp:TextBox ID="Settlement_RMB" runat="server" ClientIDMode="Static" Width="76%"></asp:TextBox> 万元
                            </td>                           
                            <asp:CheckBox runat="server" ID="IsPublicSettlement_RMB" ClientIDMode="Static" ToolTip="公开" Checked="true" />                           
                        </tr>
                        <tr>
                            <td>外币</td>
                            <td colspan="2">
                                <asp:TextBox ID="Estimate_ForeignCurrency" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox> 万美元
                            </td>                          
                            <asp:CheckBox runat="server" ID="IsPublicEstimate_ForeignCurrency" ClientIDMode="Static" ToolTip="公开" Checked="true" />                       
                            <td>外币</td>
                            <td  colspan="2">
                                <asp:TextBox ID="Settlement_ForeignCurrency" runat="server" ClientIDMode="Static" Width="69%"></asp:TextBox> 万美元
                            </td>                       
                            <asp:CheckBox runat="server" ID="IsPublicSettlement_ForeignCurrency" ClientIDMode="Static" ToolTip="公开" Checked="true" />                          
                        </tr>
                        <tr>
                            <td rowspan="2">土建与安装工程的比例</td>
                            <td>土建</td>
                            <td colspan="2">
                                <asp:TextBox ID="Estimate_CivilEngineering" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>  %
                            </td>                        
                            <asp:CheckBox runat="server" ID="IsPublicEstimate_CivilEngineering" ClientIDMode="Static" ToolTip="公开" Checked="true" />                          
                            <td rowspan="2">土建与安装工程的比例</td>
                            <td>土建</td>
                            <td colspan="2">
                                <asp:TextBox ID="Settlement_CivilEngineering" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>  %
                            </td>                          
                            <asp:CheckBox runat="server" ID="IsPublicSettlement_CivilEngineering" ClientIDMode="Static" ToolTip="公开" Checked="true" />                      
                        </tr>
                        <tr>
                            <td>安装</td>
                            <td  colspan="2">
                                <asp:TextBox ID="Estimate_Install" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>  %
                            </td>                          
                            <asp:CheckBox runat="server" ID="IsPublicEstimate_Install" ClientIDMode="Static" ToolTip="公开" Checked="true" />                       
                            <td>安装</td>
                            <td >
                                <asp:TextBox ID="Settlement_Install" runat="server" ClientIDMode="Static" Width="75%"></asp:TextBox>  %
                            </td>                         
                            <asp:CheckBox runat="server" ID="IsPublicSettlement_Install" ClientIDMode="Static" ToolTip="公开" Checked="true" />                          
                        </tr>
                        <tr>
                            <td>单位建筑面积造价</td>
                            <td colspan="3">
                                <asp:TextBox ID="Estimate_PerUnitAreaRMB" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> 元/㎡
                            </td>                            
                            <asp:CheckBox runat="server" ID="IsPublicEstimate_PerUnitAreaRMB" ClientIDMode="Static" ToolTip="公开" Checked="true" />                         
                            <td>单位建筑面积造价</td>
                            <td colspan="3">
                                <asp:TextBox ID="Settlement_OneUnitAreaRMB" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox> 元/㎡
                            </td>                           
                            <asp:CheckBox runat="server" ID="IsPublicSettlement_OneUnitAreaRMB" ClientIDMode="Static" ToolTip="公开" Checked="true" />                         
                        </tr>
                        <tr>
                            <td>单位规模造价</td>
                            <td colspan="3">
                                <asp:TextBox ID="Estimate_PerUnitScaleRMB" runat="server" ClientIDMode="Static" Width="72%"></asp:TextBox> 元/
                               <asp:TextBox ID="Estimate_PerUnitScaleRMBUnit" runat="server" ClientIDMode="Static" Style="width: 30px;"></asp:TextBox>
                            </td>                       
                                <asp:CheckBox runat="server" ID="IsPublicEstimate_PerUnitScaleRMBUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />                         
                            <td>单位规模造价</td>
                            <td colspan="3">
                                <asp:TextBox ID="Settlement_OneUnitScaleRMB" runat="server" ClientIDMode="Static" Width="67%"></asp:TextBox> 元/
                                <asp:TextBox ID="Settlement_OneUnitScaleRMBUnit" runat="server" ClientIDMode="Static" Style="width: 30px;"></asp:TextBox>
                            </td>                                                        
                                <asp:CheckBox runat="server" ID="IsPublicSettlement_OneUnitScaleRMBUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />                         
                        </tr>
                        <tr>
                            <td>结算与概算出入的主要原因</td>
                            <td colspan="7">
                                <asp:TextBox ID="Estimate_Settlement_Difference" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8" style="text-align: left; padding-left: 10px;">经济专业主要特点：（限制在200字）</td>
                        </tr>
                        <tr>
                            <td colspan="8" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="EconomicsFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"></asp:TextBox>
                                <script id="EconomicsFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsPublicEconomicsFeatures" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_0106')" id="Save_0106">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0106','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('07')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('07')" class="btnt up" style="margin:0 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab8">
                <uc:Appendix runat="server" ID="ucAppendix"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab9">
                <uc:LegalStates runat="server" ID="ucLegalStates"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab10">
                <uc:Certificate runat="server" ID="ucCertificate"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab11">
                <uc:Comments runat="server" ID="ucComments"></uc:Comments>
            </div>
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
            $("#StructuralFeatures").val(EncodeUEditorContent(UE.getEditor('StructuralFeaturesTextBox').getContent()));                            // 结构专业设计主要特点
            $("#Features_HVAC").val(EncodeUEditorContent(UE.getEditor('Features_HVACTextBox').getContent()));                                      // 设计特点:暖通、空调
            $("#Features_Power").val(EncodeUEditorContent(UE.getEditor('Features_PowerTextBox').getContent()));                                    // 设计特点:动力
            $("#Features_WaterSupplyAndDrainage").val(EncodeUEditorContent(UE.getEditor('Features_WaterSupplyAndDrainageTextBox').getContent()));  // 设计特点:给 排 水
            $("#Features_FireFacilities").val(EncodeUEditorContent(UE.getEditor('Features_FireFacilitiesTextBox').getContent()));                  // 消防给水及其他灭火设施
            $("#ElectricityFeatures_Electrical").val(EncodeUEditorContent(UE.getEditor('ElectricityFeatures_ElectricalTextBox').getContent()));                          // 设计特点：强电
            $("#ElectricityFeatures_Intelligence").val(EncodeUEditorContent(UE.getEditor('ElectricityFeatures_IntelligenceTextBox').getContent()));                              // 经济专业主要特点
            $("#ElectricityFeatures_Green").val(EncodeUEditorContent(UE.getEditor('ElectricityFeatures_GreenTextBox').getContent()));                              // 经济专业主要特点
            $("#EconomicsFeatures").val(EncodeUEditorContent(UE.getEditor('EconomicsFeaturesTextBox').getContent()));                              // 经济专业主要特点

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
                || !checkUEditor('StructuralFeaturesTextBox')
                || !checkUEditor('Features_HVACTextBox')
                || !checkUEditor('Features_PowerTextBox')
                || !checkUEditor('Features_WaterSupplyAndDrainageTextBox')
                || !checkUEditor('Features_FireFacilitiesTextBox')
                || !checkUEditor('ElectricityFeatures_ElectricalTextBox')
                || !checkUEditor('ElectricityFeatures_IntelligenceTextBox')
                || !checkUEditor('ElectricityFeatures_GreenTextBox')
                || !checkUEditor('EconomicsFeaturesTextBox')) {
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
            InitUEditor('ProjectOverviewTextBox', 300);              // 项目概况
            InitUEditor('TechnicalFeaturesTextBox', 400);              // 技术特色
            InitUEditor('TechnicalDepthTextBox', 400);              // 技术成效
            InitUEditor('ComprehensiveBenefitTextBox', 400);              // 综合效益
            InitUEditor('StructuralFeaturesTextBox', 600);                 // 结构专业设计主要特点
            InitUEditor('Features_HVACTextBox', 300);                      // 设计特点:暖通、空调
            InitUEditor('Features_PowerTextBox', 300);                     // 设计特点:动力
            InitUEditor('Features_WaterSupplyAndDrainageTextBox', 200);    // 设计特点:给 排 水
            InitUEditor('Features_FireFacilitiesTextBox', 200);            // 消防给水及其他灭火设施
            InitUEditor('ElectricityFeatures_ElectricalTextBox', 300);               // 设计特点：建筑电气
            InitUEditor('ElectricityFeatures_IntelligenceTextBox', 300);               // 设计特点：建筑智能化
            InitUEditor('ElectricityFeatures_GreenTextBox', 150);               // 设计特点：绿色节能
            InitUEditor('EconomicsFeaturesTextBox', 200);                  // 经济专业主要特点

            //重置页面顺序
            $("#AppendixPrev").click(function () {
                onPrev("08");
            });
            $("#AppendixNext").click(function () {
                onNext("08");
            });
            $("#LegalStatesPrev").click(function () {
                onPrev("09");
            });
            $("#LegalStatesNext").click(function () {
                onNext("09");
            });
            $("#CertificatePrev").click(function () {
                onPrev("10");
            });
            $("#CertificateNext").click(function () {
                onNext("10");
            });
            $("#CommentsPrev").click(function () {
                onPrev("11");
            });

            //保存上个pannel编辑内容
            $("#tabfather li a[data-toggle='tab']").click(function () {

                var TabsId = getCookie('TabId');
                var n = TabsId.substr(-2, 2);
                var id = $(this).attr("id").substr(-2, 2);
                ShowTab(id);
                //alert(n);
                //if (n == "01") {
                //   // $("#Save_0101").click();
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
                //    $("#Save_Participant").click();
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
