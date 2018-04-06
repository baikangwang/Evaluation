<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ResidentialBuildingReview.aspx.cs" Inherits="Evaluation.View.Declaration.ResidentialBuildingReview" ValidateRequest="false" %>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/Certificatereview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>
    <script type="text/javascript" charset="utf-8" src="../../Content/Javascript/DeclarationReview.js"></script>

    <%--UEditor--%>
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>
    <%--<script src="../../Content/plugins/ueditor/ueditor.parse.js"></script>--%>

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

        a.btnt:hover {
            cursor: pointer;
        }

        #AppendixTable td a, #AtlasTable td a {
            margin: 0 0.5em;
        }
         .edui-editor.edui-default{
            z-index:1!important; border:none!important;background-color:#eee!important;
        }
        .edui-editor-toolbarboxouter.edui-default{
            height:0px;
        }
        .edui-default .edui-editor-bottomContainer td{
            border-top:none!important;border-right:none;
        }
        .edui-default .edui-editor-toolbarboxouter{
            border-bottom:none!important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a><a href="../Declaration/Declare.aspx?SepcCode=020000" id="nav02"></a><a href="#" id="nav03"></a>
        </li>
    </ul>
    <div style="display: none">
        <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox>
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

        <div class="tab-content" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0201" class="tab_div" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 15%;">项目报优名称</td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationName" Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>立项名称</td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ApprovalName" Width="96%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">申报单位<br />
                                (主申报)</td>
                            <td>申报单位</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationUnit" Width="93.2%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>通讯地址</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="PostalAddress" Width="93.2%"></asp:Label>

                            </td>
                        </tr>
                        <tr>
                            <td>联系人</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Linkman" Width="83.5%"></asp:Label>
                            </td>

                            <td>手机</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MobileNumber" Width="83.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>电话</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TelephoneNumber" Width="83.5%"></asp:Label>
                            </td>

                            <td>邮政编码</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Postcode" Width="83.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>传真</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FaxNumber" Width="83.5%"></asp:Label>
                            </td>

                            <td>电子邮箱</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="EmailAddress" Width="83.5%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>境内、外合作设计单位</td>
                            <td style="padding: 0;" colspan="4">
                                <table style="width: 100%;">
                                    <tr>
                                        <td style="width: 30.4%; border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DomesticOrAbord1"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord1" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="width: 23.8%; border-right: none; text-align: center;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit1" Style="width: 88%;" onblur="Sensitize('CooperativeUnit1','CollaborativePhase01')"></asp:Label>
                                        </td>
                                        <td style="border-right: none; width: 35%;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList1">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="CollaborativePhase1" Width="200px"></asp:Label>
                                            </div>

                                            <%-- <asp:CheckBox  ID="IsResidentialCollaborativePhase1"  ToolTip="公开" Checked="true" />--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DomesticOrAbord2"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord2" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td2">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit2" Style="width: 88%;" onblur="Sensitize('CooperativeUnit2','CollaborativePhase02')"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList2">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="CollaborativePhase2" Width="200px"></asp:Label>
                                            </div>

                                            <%--<asp:CheckBox  ID="IsResidentialCollaborativePhase2"  ToolTip="公开" Checked="true" />--%>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DomesticOrAbord3"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord3" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td3">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit3" Style="width: 88%;" onblur="Sensitize('CooperativeUnit3','CollaborativePhase03')"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList3">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="CollaborativePhase3" Width="200px"></asp:Label>
                                            </div>

                                            <%--<asp:CheckBox  ID="IsResidentialCollaborativePhase3"  ToolTip="公开" Checked="true" />--%>
                                        </td>

                                    </tr>
                                    <tr>
                                        <td style="border-right: none;">
                                            <div class="DeclarationList">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="DomesticOrAbord4"></asp:Label>
                                            </div>
                                            <div class="ExpertReviewList" style="display: none">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="txtDomesticOrAbord4" Style="width: 88%;"></asp:Label>
                                            </div>
                                        </td>
                                        <td style="border-right: none; text-align: center;" id="td4">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit4" Style="width: 88%;" onblur="Sensitize('CooperativeUnit4','CollaborativePhase04')"></asp:Label>
                                        </td>
                                        <td style="border-right: none;" class="Selects">
                                            <div class="DeclarationList" id="DeclarationList4">
                                                <asp:Label runat="server" ClientIDMode="Static" ID="CollaborativePhase4" Width="200px"></asp:Label>
                                            </div>

                                            <%--<asp:CheckBox  ID="IsResidentialCollaborativePhase4"  ToolTip="公开" Checked="true" />--%>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>建设单位</td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DevelopmentOrganization" Width="95.7%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>施工单位</td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionOrganization" Width="95.7%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>使用单位</td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseUnit" Width="95.7%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点</td>
                            <td colspan="4">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionLocation" Width="95.7%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>设计类别</td>
                            <td style="width: 31%;">
                                <div class="DeclarationList">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DesignCategory"></asp:Label>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="txtDesignCategory" Width="90%"></asp:Label>
                                </div>
                            </td>
                            <td style="width: 15%">设计起止时间</td>
                            <td style="width: 35%;" colspan="2">

                                <asp:Label runat="server" ClientIDMode="Static" ID="DesignStartDate"></asp:Label><span style="padding: 0 0.5em">至</span>
                                <asp:Label runat="server" ClientIDMode="Static" ID="DesignEndDate"></asp:Label>

                            </td>
                        </tr>
                        <tr>
                            <td>开工时间</td>
                            <td>
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionStartDate" placeholder="请选择开工日期"></asp:Label>
                                </div>
                            </td>
                            <td>竣工时间</td>
                            <td colspan="2">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionEndDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>竣工验收时间</td>
                            <td>
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="AcceptanceDate"></asp:Label>
                                </div>
                            </td>
                            <td>竣工验收部门</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AcceptanceDepartment" Width="68%" Style="margin-left: 6px;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>消防备案时间</td>
                            <td>
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="FireControlRecordDate"></asp:Label>
                                </div>
                            </td>
                            <td>交付使用时间</td>
                            <td colspan="2">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="DeliveryDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>投资来源</td>
                            <td colspan="4">
                                <div class="DeclarationList">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="InvestSource"></asp:Label>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="txtInvestSource" Width="90%"></asp:Label>
                                </div>
                            </td>
                            <td style="padding: 0; display: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationLevel"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>专业类别</td>
                            <td colspan="4">
                                <div class="DeclarationList">
                                    <asp:Label runat="server" ID="ProfessionalCategories" ClientIDMode="Static"></asp:Label>
                                </div>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" ID="ParticipantReview"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0202" GroupingText="技术申报内容(建筑专业)">
                    <table>
                        <tr>
                            <td rowspan="2" style="width: 85px;">建筑功能<br />
                                （使用性质）</td>
                            <td style="width: 32px;">地上</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseProperty_Overground" Width="94%"></asp:Label>
                            </td>
                            <td style="width: 130px;">用地性质</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="LandNature" Width="75%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>地下</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseProperty_Underground" Width="94%"></asp:Label>
                            </td>
                            <td>设计使用年限</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="DesignServiceLife" Width="75%"></asp:Label>
                                年
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">总用地面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TotalLandArea" Width="70%"></asp:Label>
                                ha
                            </td>
                            <td style="width: 130px">代征地面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ExpropriationArea" Width="70%"></asp:Label>
                                ha
                            </td>
                            <td>建设用地面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionArea" Width="75%"></asp:Label>
                                ha
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">总建筑面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="OverallFloorage" Width="70%"></asp:Label>
                                ㎡
                            </td>
                            <td>地上面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="OvergroundArea" Width="70%"></asp:Label>
                                ㎡
                            </td>
                            <td>地下面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="UndergroundArea" Width="75%"></asp:Label>
                                ㎡
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">建筑基地面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BuildingArea" Width="70%"></asp:Label>
                                ㎡
                            </td>
                            <td>绿地面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="GreenArea" Width="70%"></asp:Label>
                                ㎡
                            </td>
                            <td>绿化率</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="GreeningRate" Width="75%"></asp:Label>
                                %
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">容 积 率</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="PlotRatio" Width="70%"></asp:Label>
                            </td>
                            <td>建筑密度</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BuildingDensity" Width="70%"></asp:Label>
                                %
                            </td>
                            <td>建筑分类/耐火等级</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BuildingClassification" Width="31%"></asp:Label><span>/</span>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FireResistanceRating" Width="31%"></asp:Label>类/级
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">建筑高度</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BuildingHeight" Width="70%"></asp:Label>
                                m
                            </td>
                            <td>地上层数</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="OvergroundLayerCount" Width="70%"></asp:Label>
                                层
                            </td>
                            <td>地下层数</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="UndergroundLayerCount" Width="75%"></asp:Label>
                                层
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">机动车停车计</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="AutoParkingCount" Width="70%"></asp:Label>
                                辆
                            </td>
                            <td>地上停车</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="OvergroundAutoParkingCount" Width="70%"></asp:Label>
                                辆
                            </td>
                            <td>地下停车</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="UndergroundAutoParkingCount" Width="75%"></asp:Label>
                                辆
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">自行车停车计</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BicycleParkingCount" Width="70%"></asp:Label>
                                辆
                            </td>
                            <td>地上停车</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="OvergroundBicycleParkingCount" Width="70%"></asp:Label>
                                辆
                            </td>
                            <td>地下停车</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="UndergroundBicycleParkingCount" Width="75%"></asp:Label>
                                辆
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" colspan="2">防空地下室</td>
                            <td>建筑面积</td>
                            <td>战时用途</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Basement_WartimeUse" Width="70%"></asp:Label>
                            </td>
                            <td>抗力级别</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Basement_ResistanceLevel" Width="75%"></asp:Label>
                                级
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Basement_ConstructionArea" Width="70%"></asp:Label>
                                ㎡
                            </td>
                            <td>平时用途</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Basement_UsuallyUse" Width="70%"></asp:Label>
                            </td>
                            <td>防化级别</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Basement_AntichemicalLevel" Width="75%"></asp:Label>
                                级
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7">居 住 建 筑 类 需 补 充 填 写 以 下 各 项</td>
                        </tr>
                        <tr>
                            <td colspan="2" style="width: 180px;">住宅用地</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ResidentialLand" Width="70%"></asp:Label>
                                ha
                            </td>
                            <td>配套公建用地</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SupportingConstructionLand" Width="70%"></asp:Label>
                                ha
                            </td>
                            <td>非配套公建用地</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="NonMatchingConstructionLand" Width="75%"></asp:Label>
                                ha
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">道路用地</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="LandForRoads" Width="70%"></asp:Label>
                                ha
                            </td>
                            <td>公共绿地</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="GreenSpace" Width="70%"></asp:Label>
                                ha
                            </td>
                            <td>配套公建面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SupportingConstructionArea" Width="75%"></asp:Label>
                                ㎡
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">居住建筑面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ResidentialBuildingArea" Width="70%"></asp:Label>
                                ㎡
                            </td>
                            <td>平均每套建筑面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="AverageAreaPerSet" Width="68.5%"></asp:Label>
                                ㎡/套
                            </td>
                            <td>非配套公建面积</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="NonMatchingConstructionArea" Width="75%"></asp:Label>
                                ㎡
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">总居住户数</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TotalHousehold" Width="70%"></asp:Label>
                                户
                            </td>
                            <td>每户人均数</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="AveragePersonPerHousehold" Width="68.5%"></asp:Label>
                                人/户
                            </td>
                            <td>总居住人数</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TotalPerson" Width="75%"></asp:Label>
                                人
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">公共人均绿地</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="PerPersonGreenSpace" Width="68.5%"></asp:Label>
                                ㎡/人
                            </td>
                            <td>机动车指标</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VehicleIndicators" Width="68.5%"></asp:Label>
                                辆/户
                            </td>
                            <td>自行车指标</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BicycleIndicators" Style="width: 75%; margin-left: 7%;"></asp:Label>
                                辆/户
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" rowspan="4">住宅类型</td>
                            <td>总栋数</td>
                            <td>保障房</td>
                            <td>商品房</td>
                            <td>公寓</td>
                            <td>其他</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BuildingCount" Width="70%"></asp:Label>
                                栋
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SecurityHousing" Width="50%"></asp:Label>
                                栋
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="CommercialHousing" Width="70%"></asp:Label>
                                栋
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Apartment" Width="60%"></asp:Label>
                                栋
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="OtherResidentialType" Width="75%"></asp:Label>
                                栋
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">其中保障房包含</td>
                            <td>限价商品房</td>
                            <td>经济适用房</td>
                            <td>公租房</td>
                            <td>廉租房</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="CappedPriceHousing" Width="50%"></asp:Label>
                                栋
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="AffordableHousing" Width="70%"></asp:Label>
                                栋
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="PRH" Width="65%"></asp:Label>
                                栋
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="LowRentHousing" Width="75%"></asp:Label>
                                栋
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">层数特征</td>
                            <td colspan="5" style="padding: 0;">
                                <table style="width: 100%">
                                    <tr>
                                        <td style="width: 33.3%;">1-6层</td>
                                        <td style="width: 33.3%;">7-10层</td>
                                        <td style="border-right: none">10层以上</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">层数（层）</td>
                            <td style="padding: 0;">地上</td>
                            <td colspan="5" style="padding: 0;">
                                <table style="width: 100%" class="ceng">
                                    <tr>
                                        <td style="width: 33.3%;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="OvergroundLayer_Less6"></asp:Label>
                                        </td>
                                        <td style="width: 33.3%;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="OvergroundLayer_7To10"></asp:Label>
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="OvergroundLayer_Above10"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="padding: 0;">地下</td>
                            <td colspan="5" style="padding: 0;">
                                <table style="width: 100%" class="ceng">
                                    <tr>
                                        <td style="width: 33.3%;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="UndergroundLayer_Less6"></asp:Label>
                                        </td>
                                        <td style="width: 33.3%;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="UndergroundLayer_7To10"></asp:Label>
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="UndergroundLayer_Above10"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">高度（m）</td>
                            <td colspan="5" style="padding: 0;">
                                <table style="width: 100%" class="ceng">
                                    <tr>
                                        <td style="width: 33.3%;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Height_Less6"></asp:Label>
                                        </td>
                                        <td style="width: 33.3%;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Height_7To10"></asp:Label>
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Height_Above10"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">栋数（栋）</td>
                            <td colspan="5" style="padding: 0;">
                                <table style="width: 100%" class="ceng">
                                    <tr>
                                        <td style="width: 33.3%;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Count_Less6"></asp:Label>
                                        </td>
                                        <td style="width: 33.3%;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Count_7To10"></asp:Label>
                                        </td>
                                        <td style="border-right: none;">
                                            <asp:Label runat="server" ClientIDMode="Static" ID="Count_Above10"></asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">备注</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ResidentialInfoMemo" Width="95%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">项目概况：（限200~300字）</td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 200px"></asp:TextBox>
                                <script id="ProjectOverviewTextBox" type="text/plain" style="height: 300px;" defer="defer"></script>
                               <%-- <div id="ProjectOverviewTextBox" class="ue_content"></div>--%>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: center; padding-left: 10px;">技术特色：（限200~400字）</td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="TechnicalFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 200px; display: block"></asp:TextBox>
                                <script id="TechnicalFeaturesTextBox" type="text/plain" style="height: 300px;" defer="defer"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: center; padding-left: 10px;">技术成效与深度：（限200~400字）</td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="TechnicalDepth" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 200px; display: block"></asp:TextBox>
                                <script id="TechnicalDepthTextBox" type="text/plain" style="height: 300px;" defer="defer"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: center; padding-left: 10px;">综合效益：（限200~400字）</td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="ComprehensiveBenefit" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 200px; display: block"></asp:TextBox>
                                <script id="ComprehensiveBenefitTextBox" type="text/plain" style="height: 300px;" defer="defer"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>

                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab4">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0203" GroupingText="技术申报内容(结构专业)">
                    <table>
                        <tr>
                            <td colspan="3">结构体系</td>
                            <td colspan="3" style="width: 30%">
                                <asp:Label runat="server" ClientIDMode="Static" ID="StructuralSystem" Width="88%"></asp:Label>
                            </td>
                            <td style="width:150px;">抗震设防烈度</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SeismicFortificationIntensity" Width="79%"></asp:Label>
                                度
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">抗震设防类别</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SeismicFortificationCategory" Width="88%"></asp:Label>
                            </td>
                            <td>基本地震加速度</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="BasicSeismicAcceleration" Width="79%"></asp:Label>
                                g
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">设计地震分组</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="EarthquakeGrouping" Width="88%"></asp:Label>
                            </td>
                            <td>建筑场地土类别</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionSiteSoilType" Width="79%"></asp:Label>
                                类
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">基础类型</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseType" Width="88%"></asp:Label>
                            </td>
                            <td>结构安全等级</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="StructuralSafetyLevel" Width="79%"></asp:Label>
                                级
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">混凝土总用量（砖混结构可不填写此栏及后三栏）</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConcreteAmount" Style="width: 88%; margin-left: 6%;"></asp:Label>
                                m³
                            </td>
                            <td>每平方米混凝土折算厚度</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="PerSqM_ConcreteReducedThickness" Width="79%"></asp:Label>
                                cm/㎡
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" colspan="3">钢材总用量</td>
                            <td style="width: 80px;">钢筋:
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SteelAmount_rebar" Width="82%"></asp:Label>
                                t
                            </td>
                            <td rowspan="2">每平方米钢材用量</td>
                            <td style="width: 80px;">钢筋:
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="PerSqM_SteelAmount_rebar" Width="71%"></asp:Label>
                                kg/㎡
                            </td>
                        </tr>
                        <tr>
                            <td>型钢:
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SteelAmount_SectionSteel" Width="82%"></asp:Label>
                                t
                            </td>
                            <td>型钢:
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="PerSqM_SteelAmount_SectionSteel" Width="71%"></asp:Label>
                                kg/㎡
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="21" style="width: 60px;">抗震分析主要结果</td>
                            <td colspan="2">程序名称：                
                            </td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ModeProgramName" Width="89%"></asp:Label>
                            </td>
                            <td>是否考虑扭转耦联</td>
                            <td colspan="2">
                                <div class="DeclarationList">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="IsConsiderCoupling" Width="81%"></asp:Label>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="txtIsConsiderCoupling" Style="width: 88%;"></asp:Label>
                                </div>
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
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle1" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle1" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient1" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient1" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                2
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle2" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle2" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient2" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient2" Width="77%"></asp:Label>
                            </td>
                            <td>X向基底剪重比</td>
                            <td colspan="2">Y向基底剪重比</td>
                        </tr>
                        <tr>
                            <td>
                                3
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle3" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle3" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient3" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient3" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BasalShearRatio_X" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="BasalShearRatio_Y" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                4
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle4" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle4" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient4" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient4" Width="77%"></asp:Label>
                            </td>
                            <td>X向最小剪重比（层号）</td>
                            <td colspan="2">Y向最小剪重比（层号）</td>
                        </tr>
                        <tr>
                            <td>
                                5
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle5" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle5" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient5" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient5" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MinShearWeightRatio_X" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MinShearWeightRatio_Y" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                6
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle6" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle6" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient6" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient6" Width="77%"></asp:Label>
                            </td>
                            <td>X向最大层间位移角</td>
                            <td colspan="2">Y向最大层间位移角</td>
                        </tr>
                        <tr>
                            <td>
                                7
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle7" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle7" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient7" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient7" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                8
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle8" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle8" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient8" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient8" Width="77%"></asp:Label>
                            </td>
                            <td>X向最大位移比（层号）</td>
                            <td colspan="2">Y向最大位移比（层号）</td>
                        </tr>
                        <tr>
                            <td>
                                9
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeCycle9" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="VibrationModeAngle9" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TranslationalCoefficient9" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TorsionCoefficient9" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxDisplacementRatio_X" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxDisplacementRatio_Y" Width="80%"></asp:Label>
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
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName1" Width="88%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X1" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X1" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y1" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y1" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">2</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName2" Width="88%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X2" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X2" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y2" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y2" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">3</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName3" Width="88%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X3" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X3" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y3" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y3" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">4</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName4" Width="88%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X4" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X4" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y4" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y4" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">5</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName5" Width="88%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X5" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X5" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y5" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y5" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">6</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName6" Width="88%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X6" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X6" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y6" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y6" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="1">7</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TimeHistoryAnalysisName7" Width="88%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X7" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X7" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y7" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y7" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">各波平均值(当选3条波时为包络值)</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_X_Avg" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_X_Avg" Width="77%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="BaseShear_Y_Avg" Width="85%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="MaxStoreyDriftAngle_Y_Avg" Width="80%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="9" style="text-align: center; padding-left: 10px;">结构专业设计主要特点（限400~600字）：</td>
                        </tr>
                        <tr>
                            <td colspan="9">
                                <asp:TextBox runat="server" ClientIDMode="Static" ID="StructuralFeatures" TextMode="MultiLine" Style="width: 97%; height: 300px; display: block">                                                                    
                                </asp:TextBox>
                                <script id="StructuralFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('04')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('04')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab5">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0204" GroupingText="技术申报内容(设备专业)">
                    <table>
                        <tr>
                            <td style="width:120px;">供暖方式</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingMode" Width="87%"></asp:Label>
                            </td>
                            <td>供暖建筑面积</td>                         
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingConstructionArea" Width="85%"></asp:Label>
                                ㎡
                            </td>
                        </tr>
                        <%--<tr>
                            <td>供暖热负荷</td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="SpaceHeatingLoad" Style="width: 87%; margin-left: 9%;"></asp:Label>
                                KW
                            </td>
                            <td>供暖热负荷指标</td>
                            <td colspan="2">
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="SpaceHeatingLoadIndicators" Style="width: 85%; margin-left: 6%;"></asp:Label>
                                W/㎡
                            </td>
                        </tr>--%>
                        <tr>
                            <td rowspan="2">供暖热负荷</td>
                            <td rowspan="2" colspan="2">
                                <asp:Label ID="SpaceHeatingLoad" runat="server" ClientIDMode="Static" Style="width: 83%;display:inline-block;"></asp:Label>
                                KW
                            </td>
                            <td rowspan="2">供暖热负荷指标</td>
                            <td colspan="2">
                                <asp:Label ID="SpaceHeatingLoadIndicators_TotalArea" runat="server" ClientIDMode="Static" Style="width: 50%; display:inline-block;"></asp:Label>
                                W/㎡（总建筑面积）
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="SpaceHeatingLoadIndicators_AirConArea" runat="server" ClientIDMode="Static" Style="width: 48%; display:inline-block;"></asp:Label>
                                W/㎡（空调建筑面积）
                            </td>
                        </tr>

                        <tr>
                            <td>空调系统形式</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AirConSysMode" Width="87%"></asp:Label>
                            </td>
                            <td>空调建筑面积</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AirConBuildingArea" Width="85%"></asp:Label>
                                ㎡
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">空调冷负荷</td>
                            <td rowspan="2" colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AirConCoolingLoad" Width="87%"></asp:Label>
                                KW
                            </td>
                            <td rowspan="2">空调冷指标</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AirConCoolingIndicators_TotalArea" Width="50%"></asp:Label>
                                W/㎡（总建筑面积）
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AirConCoolingIndicators_AirConArea" Style="width: 50%; display:inline-block;"></asp:Label>
                                W/㎡（空调建筑面积）
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">空调热负荷</td>
                            <td rowspan="2" colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AirConHeatingLoad" Width="87%"></asp:Label>
                                KW
                            </td>
                            <td rowspan="2">空调热指标</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AirConHeatingIndicators_TotalArea" Style="width: 50%;display:inline-block;"></asp:Label>
                                W/㎡（总建筑面积）
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AirConHeatingIndicators_AirConArea" Style="width: 50%; display:inline-block;"></asp:Label>
                                W/㎡（空调建筑面积）
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6">冷源</td>
                        </tr>
                        <tr>
                            <td rowspan="3">冷水机组类型</td>
                            <td style="width: 150px;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ChillerType1" Width="87%"></asp:Label>
                            </td>
                            <td rowspan="3">单台设计制冷量</td>
                            <td style="width: 15%;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ChillerOutput1" Width="87%"></asp:Label>
                            </td>
                            <td rowspan="3">台数</td>
                            <td style="width: 15%;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ChillerQuantity1" Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ChillerType2" Width="87%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ChillerOutput2" Width="87%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ChillerQuantity2" Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ChillerType3" Width="87%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ChillerOutput3" Width="87%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ChillerQuantity3" Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6">热源</td>
                        </tr>
                        <tr>
                            <td rowspan="3">制热设备类型</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingEquipmentType1" Width="87%"></asp:Label>
                            </td>
                            <td rowspan="3">单台设计供热</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingEquipmentOutput1" Width="87%"></asp:Label>
                            </td>
                            <td rowspan="3">台数</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingEquipmentQuantity1" Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingEquipmentType2" Width="87%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingEquipmentOutput2" Width="87%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingEquipmentQuantity2" Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingEquipmentType3" Width="87%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingEquipmentOutput3" Width="87%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingEquipmentQuantity3" Width="92%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>供暖系统制式</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="HeatingSystem" Width="97.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>空调水系统制式</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AirConWaterSystem" Width="97.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>给水系统形式</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="WaterSupplySystem" Width="97.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>中水系统形式</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ReclaimedWaterSystem" Width="97.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>雨、污水系统形式</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="SewageSystem" Width="97.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>消防给水系统形式</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="FireWaterSupplySystem" Width="97.3%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: center; padding-left: 10px;">设计特点:暖通、空调：（限制200～300字)</td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox runat="server" ClientIDMode="Static" ID="Features_HVAC" TextMode="MultiLine" Style="width: 99%; height: 300px; display: block"> </asp:TextBox>
                                <script id="Features_HVACTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: center; padding-left: 10px;">动  力：（限制200～300字）</td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox runat="server" ClientIDMode="Static" ID="Features_Power" TextMode="MultiLine" Style="width: 99%; height: 300px; display: block"> </asp:TextBox>
                                <script id="Features_PowerTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: center; padding-left: 10px;">给 排 水：（限制100～200字）</td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox runat="server" ClientIDMode="Static" ID="Features_WaterSupplyAndDrainage" TextMode="MultiLine" Style="width: 99%; height: 300px; display: block"> </asp:TextBox>
                                <script id="Features_WaterSupplyAndDrainageTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: center; padding-left: 10px;">消防给水及其他灭火设施：（限制100～200字）</td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="Features_FireFacilities" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 99%; height: 300px;"> </asp:TextBox>
                                <script id="Features_FireFacilitiesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('05')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('05')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab6">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0205" GroupingText="技术申报内容(电气专业)">
                    <table>
                        <tr>
                            <td colspan="2" style="width: 180px;">供电电源设计情况</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ElectricitySupplyDesign" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">用电负荷等级确定情况</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ElectricityLoadLevels" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">防雷类别及措施</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="LightningProtection" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">建筑电气设计</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="HighVoltageDesign" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">建筑智能化设计</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="LowVoltageDesign" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">电力总用电负荷</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TotalElectricityload" Width="80%"></asp:Label>
                                KW
                            </td>
                            <td colspan="2">照明总用电负荷</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TotalLightingLoad" Style="width: 50%"></asp:Label>
                                KW
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">变压器配置</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="TransformerConfig" Style="width: 50%;"></asp:Label>/
                                <asp:Label runat="server" ClientIDMode="Static" ID="TransformerConfigUnit" Width="30%"></asp:Label>
                            </td>
                            <td colspan="2">变压器装机密度</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TransformerDensity" Style="width: 50%"></asp:Label>
                                KVA/㎡
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">备用电源设置情况及总容量</td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="StandbyElectricity" Width="80%"></asp:Label>
                                KW
                            </td>
                            <td colspan="2">备用电源装机密度</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="StandbyElectricityDensity" Style="width: 25%"></asp:Label>
                                KVA/㎡或<asp:Label runat="server" ClientIDMode="Static" ID="StandbyElectricityDensityKW" Style="width: 25%"></asp:Label>KW/㎡
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="3" colspan="1" style="width:70px;">居住建筑</td>
                            <td  style="width:100px;">住宅类型</td>
                            <td>经济适用房</td>
                            <td colspan="2">商品房</td>
                            <td>公寓</td>
                            <td>其他</td>
                        </tr>
                        <tr>
                            <td>用电指标<br />
                                （kVA/㎡）</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Indicators_AffordableHousing" Width="86%"></asp:Label>
                            </td>
                            <td colspan="2">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Indicators_CommercialHousing" Width="86%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Indicators_Apartment" Width="86%"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Indicators_Other" Width="91%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>备注</td>
                            <td colspan="5">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ElectricityMemo" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: center; padding-left: 10px;">设计特点-建筑电气：（限制200～300字）</td>
                        </tr>
                        <tr>
                            <td colspan="7">
                                <asp:TextBox ID="ElectricityFeatures_HighVoltage" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="ElectricityFeatures_HighVoltageTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: center; padding-left: 10px;">设计特点-建筑智能化：（限制200～300字）</td>
                        </tr>
                        <tr>
                            <td colspan="7">
                                <p></p>
                                <asp:TextBox ID="ElectricityFeatures_LowVoltage" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="ElectricityFeatures_LowVoltageTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7" style="text-align: center; padding-left: 10px;">设计特点-绿色节能、环保措施：（限制80～150字）
                            </td>
                        </tr>
                        <tr>
                            <td colspan="7">
                                 <asp:TextBox ID="ElectricityFeatures_Efficient" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="ElectricityFeatures_EfficientTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('06')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('06')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab7">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0206" GroupingText="技术经济指标">
                    <table>
                        <tr>
                            <td style="width:180px;">单位规模建筑面积指标</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UnitAreaIndicators" Width="74%"></asp:Label>
                                &nbsp;㎡/    
                            <asp:Label runat="server" ClientIDMode="Static" ID="UnitAreaIndicatorsUnit" Width="9%"></asp:Label>
                            </td>
                            <td style="width:180px;">使用面积系数</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseAreaCoefficient" Style="width: 81%; display:inline-block;"></asp:Label>
                                %
                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积耗热量指标</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UnitAreaHotConsumption" Width="80%"></asp:Label>
                                W/㎡ 
                            </td>
                            <td>单位建筑面积耗冷量指标</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UnitAreaColdConsumption" Width="81%"></asp:Label>
                                W/㎡
                            </td>

                        </tr>
                        <tr>
                            <td>单位建筑面积变压器装机容量</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UnitAreaTransformerCapacity" Width="81%"></asp:Label>
                                VA/㎡
                            </td>
                            <td>日供水量</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DailyWaterSupply" Style="width: 81%; display:inline-block;"></asp:Label>
                                m<sup>3</sup> /日
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">概算</td>
                            <td colspan="4">竣工决算</td>
                        </tr>
                        <tr>
                            <td rowspan="2">总造价</td>
                            <td style="width: 80px;">人民币</td>
                            <td style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Estimate_RMB" Width="90%"></asp:Label>
                            </td>
                            <td style="width: 50px; border-left: none; text-align: left;">万元
                            </td>
                            <td rowspan="2">总造价</td>
                            <td style="width: 80px;">人民币</td>
                            <td style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Settlement_RMB" Width="90%"></asp:Label>
                            </td>
                            <td style="width: 50px; border-left: none; text-align: left;">万元
                            </td>
                        </tr>
                        <tr>
                            <td>外币</td>
                            <td style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Estimate_ForeignCurrency" Width="90%"></asp:Label>
                            </td>
                            <td style="width: 50px; border-left: none; text-align: left;">万美元
                            </td>
                            <td>外币</td>
                            <td style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Settlement_ForeignCurrency" Width="90%"></asp:Label>
                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">万美元
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">土建与安装工程的比例</td>
                            <td>土建</td>
                            <td style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Estimate_CivilEngineering" Width="90%"></asp:Label>
                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">%
                            </td>
                            <td rowspan="2">土建与安装工程的比例</td>
                            <td>土建</td>
                            <td style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Settlement_CivilEngineering" Width="90%"></asp:Label>

                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">%
                            </td>
                        </tr>
                        <tr>
                            <td>安装</td>
                            <td style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Estimate_Install" Width="90%"></asp:Label>
                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">%
                            </td>
                            <td>安装</td>
                            <td style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Settlement_Install" Width="90%"></asp:Label>

                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">%
                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积造价</td>
                            <td colspan="2" style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Estimate_PerUnitAreaRMB" Width="93%"></asp:Label>
                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">元/㎡
                            </td>
                            <td>单位建筑面积造价</td>
                            <td colspan="2" style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Settlement_OneUnitAreaRMB" Width="93%"></asp:Label>

                            </td>
                            <td style="width: 60px; border-left: none; text-align: left;">元/㎡
                            </td>
                        </tr>
                        <tr>
                            <td>单位规模造价</td>
                            <td colspan="2" style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Estimate_PerUnitScaleRMB" Width="93%"></asp:Label>
                                <%--<asp:CheckBox  ID="IsResidentialEstimate_PerUnitScaleRMB"  ToolTip="公开" Checked="true" />--%>
                            </td>
                            <td style="width: 60px; border-left: none; text-align: left; padding: 10px 0 0 0;">
                                <p style="float: left;">元/</p>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Estimate_PerUnitScaleRMBUnit" Style="width: 30px;"></asp:Label>
                            </td>
                            <td>单位规模造价</td>
                            <td colspan="2" style="border-right: none;">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Settlement_OneUnitScaleRMB" Width="93%"></asp:Label>
                            </td>
                            <td style="width: 80px; border-left: none; text-align: left; padding: 10px 0 0 0;">
                                <p style="float: left;">元/</p>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Settlement_OneUnitScaleRMBUnit" Style="width: 30px;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>结算与概算出入的主要原因</td>
                            <td colspan="7">
                                <asp:Label runat="server" ClientIDMode="Static" ID="Estimate_Settlement_Difference" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8" style="text-align: center; padding-left: 10px;">经济专业主要特点：（限制在200字）</td>
                        </tr>
                        <tr>
                            <td colspan="8" style="text-align: left; padding-left: 10px;">
                                <asp:TextBox ID="EconomicsFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="EconomicsFeaturesTextBox" type="text/plain" style=" height: 300px;"></script> 
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onPrev('07')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('07')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab8">
                <uc:Appendix runat="server" ID="AppendixReview"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab9">
                <uc:LegalStates runat="server" ID="LegalStatesReview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab10">
                <uc:Certificate runat="server" ID="CertificateReview"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab11">
                <uc:Comments runat="server" ID="CommentsReview"></uc:Comments>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        function setData(data) {
            data = JSON.parse(data)[1];
            for (var i = 0; i < data.length; i++) {
                var oval;
                if (data[i].RecordType == "select") {
                    oval = data[i].ConstantValue ? data[i].ConstantValue : "---";
                } else {
                    oval = data[i].Data ? data[i].Data : "---";
                }
                var element = "#" + data[i].RecordNameEn;                           
                $(element).html(oval);               
            }
            for (var j = 1; j < 5; j++) {
                if ($('#CooperativeUnit' + j).text() == "---") {
                    $('#DomesticOrAbord' + j).text("---");
                }
            }
        }

        function setPart9Data(data) {
            data = JSON.parse(data)[0];
            var LegalPeopleName = data.LegalPersonName ? data.LegalPersonName : "";
            var LegalPeopleNumber = data.LegalPersonIDNo ? data.LegalPersonIDNo : "";        
            $("#LegalPeopleName").text(LegalPeopleName);
            $("#LegalPeopleNumber").text(LegalPeopleNumber);
        }
        function setPart10Data(data) {
            var data1 = JSON.parse(data)[0];
            var data2 = JSON.parse(data)[5];

            //合作勘察设计项目合作声明
            $("#DeclarationName6").text(data1.DeclarationName);
            $("#DeclarationUnit6").text(data1.OrganizationName);
            $("#uPrize6").text(data1.PrizeName);
            $("#Divisiontable").empty()
            data2[0].勘察设计单位 = data1.OrganizationName
            // console.log(data2)
            for (var i = 0; i < data2.length; i++) {
                var item1 = "勘察设计单位";
                var item2 = "概念性方案设计";
                var item3 = "方案设计（建筑）";
                var item4 = "方案设计（结构）";
                var item5 = "初步设计（建筑）";
                var item6 = "初步设计（结构）";
                var item7 = "初步设计（设备）";
                var item8 = "初步设计（电气）";
                var item9 = "施工图设计（建筑）";
                var item10 = "施工图设计（结构）";
                var item11 = "施工图设计（设备）";
                var item12 = "施工图设计（电气）"
                var index = i + 1;
                var item = "<tr>" +
                       "<td>" + index + "</td>" +
                       "<td>" + data2[i][item1] + "</td>" +
                       "<td>" + data2[i][item2] + "</td>" +
                       "<td>" + data2[i][item3] + "</td>" +
                       "<td>" + data2[i][item4] + "</td>" +
                       "<td>" + data2[i][item5] + "</td>" +
                       "<td>" + data2[i][item6] + "</td>" +
                       "<td>" + data2[i][item7] + "</td>" +
                       "<td>" + data2[i][item8] + "</td>" +
                       "<td>" + data2[i][item9] + "</td>" +
                       "<td>" + data2[i][item10] + "</td>" +
                       "<td>" + data2[i][item11] + "</td>" +
                       "<td>" + data2[i][item12] + "</td>" +
                       "<tr>"
                $("#Divisiontable").append(item);
            }
        }
        $(function () {

            $("#tbAppendix>tr>td:last").hide();

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

            $.ajax({
                type: "post",
                url: "../Mutual/Declaration.ashx",
                async: false,
                data: {
                    "Action": "GetData",
                    "DeclarationID": $("#txtDeclarationID").val(),
                },
                success: function (data, status) {
                    var DeclarationName = JSON.parse(data)[0].DeclarationName ? JSON.parse(data)[0].DeclarationName : "---"
                    var PrizeName = JSON.parse(data)[0].PrizeName ? JSON.parse(data)[0].PrizeName : "---"
                    setNav3(DeclarationName, PrizeName)
                    setData(data);
                    setPart2Data(data);//人员情况
                    setPart8Data(data) //附件目录
                    setPart9Data(data);//代表申明
                    setPart10Data(data);//合作声明                   
                }
            });

            InitUEditor('ProjectOverviewTextBox', 300);                 // 项目概况
            InitUEditor('TechnicalFeaturesTextBox', 400);               // 技术特色
            InitUEditor('TechnicalDepthTextBox', 400);                  // 技术成效
            InitUEditor('ComprehensiveBenefitTextBox', 400);            // 综合效益
            InitUEditor('StructuralFeaturesTextBox', 600);                 // 结构专业设计主要特点
            InitUEditor('Features_HVACTextBox', 300);                      // 设计特点:暖通、空调
            InitUEditor('Features_PowerTextBox', 300);                     // 设计特点:动力
            InitUEditor('Features_WaterSupplyAndDrainageTextBox', 200);    // 设计特点:给 排 水
            InitUEditor('Features_FireFacilitiesTextBox', 200);            // 消防给水及其他灭火设施
            InitUEditor('ElectricityFeatures_HighVoltageTextBox', 300);    // 设计特点：强电
            InitUEditor('ElectricityFeatures_LowVoltageTextBox', 300);     // 设计特点：弱电
            InitUEditor('ElectricityFeatures_EfficientTextBox', 150);      // 设计特点：节能
            InitUEditor('EconomicsFeaturesTextBox', 200);                  // 经济专业主要特点
        });

        // 初始化富文本框
        function InitUEditor(container, max) {
            var text = $("#" + container.replace("TextBox", ""));
            text.hide();
            var ue = UE.getEditor(container, {
                wordCount:false,
                autoHeightEnabled: true,
                readonly: true,
                autoHeightEnabled :false,
                toolbars: [[]]
            });
            ue.ready(function () {
                //设置编辑器的内容
                ue.setContent(text.val());
            });
        }
    </script>
</asp:Content>
