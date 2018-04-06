<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="ResidentialBuildingReview_V2.aspx.cs" Inherits="Evaluation.View.Declaration.ResidentialBuildingReview_V2" ValidateRequest="false" %>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesReview_V2.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/Certificatereview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/Css/Declaration.css" rel="stylesheet" />

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

         .review .edui-editor.edui-default{
            z-index:1!important; border:none!important;background-color:#eee!important;
        }

         .review  .edui-editor-toolbarboxouter.edui-default{
            height:0px;
        }

         .review  .edui-default .edui-editor-bottomContainer td{
            border-top:none!important;border-right:none;
        }

         .review  .edui-default .edui-editor-toolbarboxouter{
            border-bottom:none!important;
        }

        /*#MainreasonforchangeTextBox,#MainadvantagesanddisadvantagesTextBox,#AwardsTextBox,#UnitOpinionTextBox,#RecommendOpinionTextBox{
            width:85%;margin-left:10px;text-align:left;
        }*/

         .review {
             width:85%;margin-left:10px;text-align:left;
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
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、技术指标</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、审核意见</a></li>
           
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、附件目录</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、法人声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab">7、合作声明</a></li>
            <li><a id="tab_08" href="#btab8" data-toggle="tab" class="ExpertReviewList2" style="display: none;">8、评审意见</a></li>
        </ul>

        <div class="tab-content" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_0201" class="tab_div" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 130px;">项目名称
                            </td>
                            <td colspan="4">
                                <asp:Label ID="DeclarationName" runat="server" ClientIDMode="Static" Width="95.3%"></asp:Label>                           
                            </td>
                        </tr>
                        <tr>
                            <td>主要设计单位
                            </td>
                            <td colspan="4">
                                <asp:Label ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="95.3%"></asp:Label>                             
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
                            <td>工程设计起止时间
                            </td>
                            <td style="margin-left: 2.5%;">
                                <div> 
                                    <asp:Label ID="DesignStartDate"  runat="server" ClientIDMode="Static"></asp:Label>至
                                      <asp:Label ID="DesignEndDate"  runat="server" ClientIDMode="Static" ></asp:Label>                                     
                                </div>
                            </td>
                            <td>竣工验收时间
                            </td>
                            <td colspan="2">
                                <div>
                                    <asp:Label ID="AcceptanceDate" runat="server" ClientIDMode="Static"></asp:Label>                                   
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>验收部门
                            </td>
                            <td colspan="4">
                                <asp:Label ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                通讯地址
                            </td>
                            <td colspan="4">
                                <asp:Label ID="PostalAddress" runat="server" ClientIDMode="Static" Width="97%"></asp:Label>                            
                            </td>
                        </tr>
                        <tr>
                            <td>单位资质
                            </td>
                            <td>
                                <asp:Label ID="Qualification" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>
                            </td>
                            <td>证书编号
                            </td>
                            <td>
                                <asp:Label ID="CertificateNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位联系人
                            </td>
                            <td style="width: 30%">
                                <asp:Label ID="Linkman" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>                          
                            </td>
                            <td>手    机
                            </td>
                            <td>
                                <asp:Label ID="MobileNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:Label>                             
                            </td>
                        </tr>
                        <tr>
                            <td>电    话
                            </td>
                            <td>
                                <asp:Label ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>                              
                            </td>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:Label ID="Postcode" runat="server" ClientIDMode="Static" Width="93%"></asp:Label>                          
                            </td>
                        </tr>
                        <tr>
                            <td>传    真
                            </td>
                            <td>
                                <asp:Label ID="FaxNumber" runat="server" ClientIDMode="Static" Width="87%"></asp:Label>                              
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:Label ID="EmailAddress" runat="server" ClientIDMode="Static" Width="93%"></asp:Label>                               
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align:left; padding-left:20px;">
                                申报材料目录（不限于此）：<br />
                                <asp:Label  runat="server"  ClientIDMode="Static" ID="FileCatalog"  Width="96%"></asp:Label>
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
              <asp:Panel ID="panelPart_0202" runat="server" GroupingText="专业技术指标">
                    <table>
                        <tr>
                            <td>用地规模</td>
                            <td colspan="2"><asp:Label ID="Landscale" runat="server" ClientIDMode="Static" Width="80%"></asp:Label> ha</td>
                            <td colspan="2">结构类型</td>
                            <td colspan="2"><asp:Label ID="Structuretype" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>居住建筑用地</td>
                            <td colspan="2"><asp:Label ID="Residentialbuildingland" runat="server" ClientIDMode="Static" Width="80%"></asp:Label> ha</td>
                            <td colspan="2">公共建筑用地</td>
                            <td colspan="2"><asp:Label ID="Publicbuildingland" runat="server" ClientIDMode="Static" Width="90%"></asp:Label> </td>
                        </tr>
                        <tr>
                            <td>道路广场用地</td>
                            <td colspan="2"><asp:Label ID="Landforroad" runat="server" ClientIDMode="Static" Width="80%"></asp:Label> ha</td>
                            <td colspan="2">绿化用地</td>
                            <td colspan="2"><asp:Label ID="Greenforland" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                        </tr>
                      <tr>
                            <td>建筑面积</td>
                            <td>总计</td>
                            <td><asp:Label ID="Grossfloorall" runat="server" ClientIDMode="Static" Width="70%"></asp:Label> 万m2</td>
                            <td style="width:80px;">住宅</td>
                            <td><asp:Label ID="Grossfloorhome" runat="server" ClientIDMode="Static" Width="70%"></asp:Label> 万m2</td>
                            <td style="width:80px;">公建</td>
                            <td><asp:Label ID="Grossfloorpublic" runat="server" ClientIDMode="Static" Width="70%"></asp:Label> 万m2</td>
                        </tr>
                         <tr>
                            <td>建筑高度（最高）</td>
                            <td colspan="2"><asp:Label ID="Buildingheight" runat="server" ClientIDMode="Static" Width="80%"></asp:Label> m</td>
                            <td colspan="2">建筑高度（单体）</td>
                            <td colspan="2"><asp:Label ID="Buildingsigle" runat="server" ClientIDMode="Static" Width="85%"></asp:Label> m</td>
                        </tr>
                      <tr>
                            <td>容 积 率</td>
                            <td colspan="2"><asp:Label ID="Volumeratio" runat="server" ClientIDMode="Static" Width="80%"></asp:Label></td>
                            <td colspan="2">绿 化 率</td>
                            <td colspan="2"><asp:Label ID="Greeningrate" runat="server" ClientIDMode="Static" Width="85%"></asp:Label> %</td>
                        </tr>
                        <tr>
                            <td>住宅类型</td>
                            <td colspan="6"><asp:Label ID="ResidentialType" runat="server" ClientIDMode="Static" Width="85%"></asp:Label> </td>
                        </tr>
                        <tr>
                            <td rowspan="2">住宅平均每套<br/>建筑面积</td>
                            <td colspan="2" rowspan="2"><asp:Label ID="Averagefloor" runat="server" ClientIDMode="Static" Width="70%"></asp:Label> m2/套</td>
                            <td colspan="2" rowspan="2">总居住户数（人）</td>
                            <td colspan="2"><asp:Label ID="Totalnumber" runat="server" ClientIDMode="Static" Width="85%"></asp:Label> 户</td>
                        </tr>
                        <tr>
                            <td colspan="2"><asp:Label ID="Totalnumberpeople" runat="server" ClientIDMode="Static" Width="85%"></asp:Label> 人</td>
                        </tr>
                        <tr>
                            <td>机动车停放数量</td>
                            <td>总计</td>
                            <td><asp:Label ID="Parkingquantityall" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                            <td>地上</td>
                            <td><asp:Label ID="Parkingquantityup" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                            <td>地下</td>
                            <td><asp:Label ID="Parkingquantitydown" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>自行车停放数量</td>
                            <td>总计</td>
                            <td><asp:Label ID="Numberofparkedall" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                            <td>地上</td>
                            <td><asp:Label ID="Numberofparkedup" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                            <td>地下</td>
                            <td><asp:Label ID="Numberofparkeddown" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>机动车停车率</td>
                            <td colspan="2"><asp:Label ID="Vehicleparkingrate" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                            <td colspan="2">自行车停车率</td>
                            <td colspan="2"><asp:Label ID="Bicycleparkingrate" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                        </tr>
                          <tr>
                            <td>暖通/空调方式</td>
                            <td colspan="2"><asp:Label ID="HVACmode" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                            <td colspan="2">冷热源方式</td>
                            <td colspan="2"><asp:Label ID="Coldandheat" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                        </tr>
                          <tr>
                            <td>给排水方式</td>
                            <td colspan="2"><asp:Label ID="Watersupply" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                            <td colspan="2">消防给水方式</td>
                            <td colspan="2"><asp:Label ID="Firewatersupply" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                        </tr>
                          <tr>
                            <td>电热采暖</td>
                            <td colspan="2"><asp:Label ID="Electrothermalheating" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                            <td colspan="2">电梯总数</td>
                            <td colspan="2"><asp:Label ID="Elevatortotal" runat="server" ClientIDMode="Static" Width="90%"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>设 计 概 算</td>
                            <td colspan="2"><asp:Label ID="Designestimate" runat="server" ClientIDMode="Static" Width="80%"></asp:Label> 万元</td>
                            <td colspan="2">竣工结算</td>
                            <td colspan="2"><asp:Label ID="Finalsettlement" runat="server" ClientIDMode="Static" Width="80%"></asp:Label> 万元</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                住宅单方工程造价
                            </td>
                            <td colspan="4">
                                <asp:Label ID="Residentialunilateral" runat="server" ClientIDMode="Static" Width="90%"></asp:Label> 元/m2
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                               概算变更<br/>主要原因
                            </td>
                            <td colspan="5">
                                <asp:TextBox ID="Mainreasonforchange" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="MainreasonforchangeTextBox" class="review" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                               项目的主要优<br/>缺点及社会经<br/>济效益
                            </td>
                            <td colspan="5">
                                <p>（规划结构、交通组织、公建配套、环境景观、住宅设计、科技含量及各专业简要描述等，不少于1500字）</p>                               
                                <asp:TextBox ID="Mainadvantagesanddisadvantages" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="MainadvantagesanddisadvantagesTextBox" class="review" type="text/plain" style="height: 300px;"></script>
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
                 <asp:Panel ID="panelPart_0203" runat="server" GroupingText="审核意见">
                      <table>                       
                        <tr>
                            <td>曾获奖项
                            </td>
                            <td>
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="AwardsTextBox" class="review" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                意   见
                            </td>
                            <td>
                                <asp:TextBox ID="UnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="UnitOpinionTextBox" class="review" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>地方、部门勘察设计同业协会推荐意见
                            </td>
                            <td>
                                <asp:TextBox ID="RecommendOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="RecommendOpinionTextBox" class="review" type="text/plain" style="height: 300px;"></script>
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
                <uc:Appendix runat="server" ID="AppendixReview"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab6">
                <uc:LegalStates runat="server" ID="LegalStatesReview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab7">
                <uc:Certificate runat="server" ID="CertificateReview"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab8">
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
                $(element).html(oval.replace(new RegExp("\n", "gm"), "<br />"));
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

            InitUEditor('MainreasonforchangeTextBox', 1000);
            InitUEditor('MainadvantagesanddisadvantagesTextBox', 1500);
            InitUEditor('AwardsTextBox', 1000);
            InitUEditor('UnitOpinionTextBox', 1000);
            InitUEditor('RecommendOpinionTextBox', 1000);

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
