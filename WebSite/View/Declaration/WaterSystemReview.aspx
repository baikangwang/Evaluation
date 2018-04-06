<%@ Page Title="" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="WaterSystemReview.aspx.cs" Inherits="Evaluation.View.Declaration.WaterSystemReview" ValidateRequest="false" %>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/ParticipantReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/AppendixReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStatesReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Certificate" Src="~/View/Declaration/CertificateReview.ascx" %>
<%@ Register TagPrefix="uc" TagName="Comments" Src="~/View/Declaration/Comments.ascx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" charset="utf-8" src="../../Content/Javascript/DeclarationReview.js"></script>
    <!--tabdrop-->
    <link rel="stylesheet" type="text/css" href="../../Content/plugins/tabdrop/css/tabdrop.css" />
    <script type="text/javascript" src="../../Content/plugins/tabdrop/js/bootstrap-tabdrop.js"></script>

    <%--UEditor--%>
    <script src="../../Content/plugins/ueditor/ueditor.config.js"></script>
    <script src="../../Content/plugins/ueditor/ueditor.all.js"></script>
    <script src="../../Content/plugins/ueditor/lang/zh-cn/zh-cn.js"></script>

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

        tbody > tr > td:nth-child(2) > div {
            left: -13px !important;
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

        #AcceptanceDepartment {
            margin-left: 6px;
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
       
        #tbReview {
            position: relative;
        }

        a:hover {
            cursor: pointer;
        }
         #AppendixTable  td a,#AtlasTable  td a{
            margin:0 0.5em
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
            <a href="#" id="nav01"></a><a href="../Declaration/Declare.aspx?SepcCode=030000" id="nav02" runat="server" clientidmode="Static"></a><a href="#" id="nav03"></a>
        </li>
    </ul>
      <div style="display: none">
          <asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox>
    </div>
    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、项目特点</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、建设内容</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、审核意见</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、使用单位反馈意见</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab">7、施工单位反馈意见</a></li>
            <li><a id="tab_08" href="#btab8" data-toggle="tab">8、附件目录</a></li>
            <li><a id="tab_09" href="#btab9" data-toggle="tab">9、法人声明</a></li>
            <li><a id="tab_10" href="#btab10" data-toggle="tab">10、合作声明</a></li>
            <li><a id="tab_11" href="#btab11" data-toggle="tab" class="ExpertReviewList2" style="display: none;">11、评审意见</a></li>
        </ul>

        <div class="tab-content" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_1801" GroupingText="项目基本情况" class="panelPart">
                    <table>
                        <tr>
                            <td style="width: 150px;">项目名称</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationName" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">项目类别</td>
                            <td colspan="3">
                                <%--<div class="DeclarationList">--%>
                                <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationCategory" class="ddlProjectSource">
                                </asp:Label>
                                <%--</div>--%>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:Label runat="server" ClientIDMode="Static" ID="txtDeclarationCategory" Style="width: 88%;"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">申报单位</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="DeclarationUnit" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">合作单位</td>
                            <td>单位名称</td>
                            <td colspan="2">承担工作</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit1" Width="91%" onblur="Sensitize('CooperativeUnit1','UndertakeWork1')"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="IsSoftwareCooperativeUnit1" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit1','UndertakeWork1')">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UndertakeWork1" Width="95%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="IsSoftwareUndertakeWork1" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit2" Width="91%" onblur="Sensitize('CooperativeUnit2','UndertakeWork2')"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="IsSoftwareCooperativeUnit2" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit2','UndertakeWork2')">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UndertakeWork2" Width="95%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="IsSoftwareUndertakeWork2" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit3" Width="91%" onblur="Sensitize('CooperativeUnit3','UndertakeWork3')"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="IsSoftwareCooperativeUnit3" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit3','UndertakeWork3')">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UndertakeWork3" Width="95%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="IsSoftwareUndertakeWork3" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="CooperativeUnit4" Width="91%" onblur="Sensitize('CooperativeUnit4','UndertakeWork4')"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="IsSoftwareCooperativeUnit4" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit4','UndertakeWork4')">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UndertakeWork4" Width="95%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="IsSoftwareUndertakeWork4" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计单位</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="DesignUnit" Width="91%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="CheckBox2" ToolTip="公开" Checked="true" /></td>
                            <td>施工单位</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionUnit" Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="CheckBox5" ToolTip="公开" Checked="true" /></td>
                        </tr>
                        <tr>
                            <td>工程起止时间</td>
                            <td>
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="StartDate"></asp:Label><span style="padding: 0 0.5em">至</span>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="EndDate"></asp:Label>

                                </div>

                            </td>
                            <td>竣工验收时间</td>
                            <td>
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="AcceptanceDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">验收部门</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="AcceptanceDepartment" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">申报单位通讯地址</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="PostalAddress" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>单位资质</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="UnitQualification" Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="CheckBox6" ToolTip="公开" Checked="true" />
                            </td>
                            <td>证书编号</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="CertificateNumber" Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="CheckBox7" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位联系人</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Linkman" Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="CheckBox8" ToolTip="公开" Checked="true" />
                            </td>
                            <td>电话</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="TelephoneNumber" Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="CheckBox9" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>邮政编码</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="Postcode" Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="CheckBox10" ToolTip="公开" Checked="true" />
                            </td>
                            <td>手机</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="MobileNumber" Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="CheckBox11" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>电子邮箱</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="EmailAddress" Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="CheckBox12" ToolTip="公开" Checked="true" />
                            </td>
                            <td>传真</td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FaxNumber" Width="92%"></asp:Label>
                                <asp:CheckBox runat="server" ClientIDMode="Static" Style="display: none" ID="CheckBox13" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>

            <div class="tab-pane" id="btab2">
                <uc:Participant ID="ParticipantReview" runat="server"></uc:Participant>
            </div>

            <div class="tab-pane" id="btab3">
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_1802" GroupingText="水系统工程项目特点">
                    <table>
                        <tr>
                            <td style="text-align: center; padding-left: 10px; width: 20%">项目概况</td>
                        </tr>
                        <tr>
                            <td>
                                <p>（项目总体介绍、项目规模、复杂程度及影响程度等，限500字）</p>
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="ProjectOverviewTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center; padding-left: 10px; width: 20%">技术特色</td>
                        </tr>
                        <tr>
                            <td>
                                <p>（项目特色及主要的技术成果指标，限1500字）</p>
                                <asp:TextBox ID="TechnicalFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="TechnicalFeaturesTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center; padding-left: 10px; width: 20%">技术成效与深度</td>
                        </tr>
                        <tr>
                            <td>
                                <p>（解决的技术难题、工程问题的成效与深度，限1500字）</p>
                                <asp:TextBox ID="TechnicalEffectiveness" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="TechnicalEffectivenessTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center; padding-left: 10px; width: 20%">综合效益</td>
                        </tr>
                        <tr>
                            <td>
                                <p>（项目产生的经济、社会、环境效益，限500字）</p>
                                <asp:TextBox ID="ComprehensiveBenefit" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;">
                                </asp:TextBox>
                                <script id="ComprehensiveBenefitTextBox" type="text/plain" style="height: 300px;"></script>
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
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_1803" GroupingText="水系统工程项目建设内容">
                    <table>
                        <tr>
                            <td style="width:33%;">系统类别或分项内容</td>
                            <td style="width:33%;">形式及设置范围</td>
                            <td style="width:33%;">特 点</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown1" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope1" Style="width: 98%; height: 100px;"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics1" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown2" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope2" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics2" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown3" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope3" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics3" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown4" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope4" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics4" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown5" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope5" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics5" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown6" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope6" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics6" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown7" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope7" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics7" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown8" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope8" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics8" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown9" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope9" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics9" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown10" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope10" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics10" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown11" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope11" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics11" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown12" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope12" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics12" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="SystemBreakdown13" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="FormAndScope13" Style="width: 98%; height: 100px; display: block"></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionCharacteristics13" Style="width: 98%; height: 100px; display: block"></asp:Label>
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
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_1804" GroupingText="审核意见">
                    <table>
                        <tr>
                            <td style="text-align: center;">曾获奖项</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;">
                                </asp:TextBox>
                                <script id="AwardsTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位意见</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="DeclarationUnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;">
                                </asp:TextBox>
                                <script id="DeclarationUnitOpinionTextBox" type="text/plain" style="height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: center; padding-left: 10px; width: 20%">地方、部门勘察设计同业协会推荐意见</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="Recommendation" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;">
                                </asp:TextBox>
                                <script id="RecommendationTextBox" type="text/plain" style="height: 300px;"></script>
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
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_1805" GroupingText="使用单位反馈意见">
                    <table>
                        <tr>
                            <td style="width: 150px;">项目名称</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseDeclarationName" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">使用单位</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseUnit" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">通讯地址</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="UseUnitAddress" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">开始使用时间</td>
                            <td colspan="3">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="UseStartDate"></asp:Label>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <p>反馈意见：</p>
                                <asp:TextBox ID="UsingUnitFeedback" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="UsingUnitFeedbackTextBox" type="text/plain" style="height: 300px;"></script>
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
                <asp:Panel runat="server" ClientIDMode="Static" ID="panelPart_1806" GroupingText="施工单位反馈意见">
                    <table>
                        <tr>
                            <td style="width: 150px;">项目名称</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionDeclarationName" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">施工单位</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="NewConstructionUnit" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">通讯地址</td>
                            <td colspan="3">
                                <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionUnitAddress" Width="97%"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">施工起止时间</td>
                            <td colspan="3">
                                <div>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionStartDate"></asp:Label><span style="padding: 0 0.5em">至</span>
                                    <asp:Label runat="server" ClientIDMode="Static" ID="ConstructionEndDate"></asp:Label>

                                </div>

                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <p>反馈意见：</p>
                                <asp:TextBox ID="ConstructionUnitFeedback" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="ConstructionUnitFeedbackTextBox" type="text/plain" style="height: 300px;"></script>
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
                <uc:LegalStates runat="server" ID="ucLegalStatesReview"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab10">
                <uc:Certificate runat="server" ID="ucCertificateReview"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab11">
                <uc:Comments runat="server" ID="ucComments"></uc:Comments>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        function setData(data) {
            var projectName = JSON.parse(data)[0].DeclarationName;
            $("#ConstructionDeclarationName").text(projectName)
            $("#UseDeclarationName").text(projectName)
            data = JSON.parse(data)[1];         
            for (var i = 0; i < data.length; i++) {
                var oval;
                if (data[i].RecordType == "select") {
                    oval = data[i].ConstantValue ? data[i].ConstantValue : "--- ";
                } else {
                    oval = data[i].Data ? data[i].Data : "--- ";
                }

                var element = "#" + data[i].RecordNameEn;
                if (data[i].RecordNameEn.indexOf('SystemBreakdown') != -1
                    || data[i].RecordNameEn.indexOf('FormAndScope') != -1
                    || data[i].RecordNameEn.indexOf('ConstructionCharacteristics') != -1) {
                    $(element).hide();
                    $(element).closest('td').html(oval);
                }
                else {
                    $(element).html(oval);
                }
            }
        }

        function setPart5Data(data) {
            data = JSON.parse(data)[0];
            var LegalPeopleName = data.LegalPersonName ? data.LegalPersonName : "";
            var LegalPeopleNumber = data.LegalPersonIDNo ? data.LegalPersonIDNo : "";  
            $("#LegalPeopleName").text(LegalPeopleName);
            $("#LegalPeopleNumber").text(LegalPeopleNumber);
        }
        function setPart6Data(data) {
            var data1 = JSON.parse(data)[0];
            //console.log(data1);

            var data2 = JSON.parse(data)[5];
            //console.log(data2);
            $("#DivisionTablewarp").hide()
            $("#DivisionTable2warp").show()
            //合作勘察设计项目合作声明
            $("#DeclarationName6").text(data1.DeclarationName);
            $("#DeclarationUnit6").text(data1.OrganizationName);
            $("#uPrize6").text(data1.PrizeName);

            for (var i = 0; i < data2.length; i++) {
                var index = i + 1
                var oUnittext = data2[i].勘察设计单位
                var oWorktext = data2[i].承担工作
                $("#txtCooperationUnit" + index).text(oUnittext);
                $("#txtUndertakeWork" + index).text(oWorktext)
            }
        }
        //附件目录
        //function setPart8Data(data) {
        //    var EnclosureData = JSON.parse(data)[3];          
        //    var ImageData = JSON.parse(data)[4];         
        //    //附件
        //    if (EnclosureData.length > 0) {
        //        $("#Enclosurelist").empty()
        //        for (var i = 0; i < EnclosureData.length; i++) {
        //            var index = i + 1;
        //            if (EnclosureData[i].URL) {
        //                var oUrl = "../../" + EnclosureData[i].URL.replace(/\\/g, "/")
        //            } else {
        //                var oUrl = ""
        //            }
        //            if (EnclosureData[i].FileName) {
        //                var fileName = EnclosureData[i].FileName
        //                var oIcon = "<i class='fa fa-download'></i>"
        //            } else {
        //                var fileName = "---"
        //                var oIcon = ""
        //            }
        //            var item = "<tr>" +
        //                  "<td>" + index + "</td>" +
        //                  "<td>" + fileName + "</td>" +
        //                  "<td>" +
        //                  "<a href= '" + oUrl + "' download=" + fileName + ">" + fileName + "</a>" +
        //                  "<a href='" + oUrl + "' download=" + fileName + ">" + oIcon + "</a>" +
        //                  "</td>" +
        //                  "<tr>"
        //            $("#Enclosurelist").append(item);
        //        }
        //    } else {
        //        $("#Appendix").hide();
        //        $("#AppendixTable").append("<div style='border:1px solid #777; text-align:center;width:90%;padding:5px'>该专业下暂无附件集目录！</div>")
        //    }

        //    //图集
        //    if (ImageData.length > 0) {
        //        $("#Imagelist").empty()
        //        var orderNum = 0;
        //        for (var i = 0; i < ImageData.length; i++) {
        //            var CorrelationID = ImageData[i].CorrelationID ? "Correlation" + ImageData[i].CorrelationID : "CorrelationID_" + i;
        //            var element = $("#" + CorrelationID)
        //            if (ImageData[i].URL) {
        //                var oUrl = "<br/><img src='../../" + ImageData[i].URL.replace(/\\/g, "/") + "' width='150px'/><br/>" +
        //                "<span>" + ImageData[i].FileName + "</span>" +
        //                "<a href='../../" + ImageData[i].URL.replace(/\\/g, "/") + "' download=" + ImageData[i].FileName + "><i class='fa fa-download'></i></a>"
        //            } else {
        //                var oUrl = "--"
        //            }
        //            if (element && element.length >= 1) {
        //                $("#" + CorrelationID).append(item);
        //            } else {
        //                orderNum = orderNum + 1;
        //                var item = "<tr>" +
        //                    "<td>" + orderNum + "</td>" +
        //                    "<td>" + ImageData[i].CorrelationName + "</td>" +
        //                    "<td id=" + CorrelationID + ">" + oUrl + "</td>" +
        //                "<tr>"
        //                $("#Imagelist").append(item);
        //            }
        //        }
        //    } else {
        //        $("#Atlas").hide();
        //        $("#AtlasTable").append("<div style='border:1px solid #777; text-align:center;width:90%;padding:5px'>该专业下暂无图集目录！</div>")
        //    }
        //}
       
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
                    setPart2Data(data);
                    setPart5Data(data);
                    setPart6Data(data);
                    setPart8Data(data)
                }
            });

            InitUEditor('ProjectOverviewTextBox', 500);              // 设计主要特点
            InitUEditor('TechnicalFeaturesTextBox', 1500);
            InitUEditor('TechnicalEffectivenessTextBox', 1500);
            InitUEditor('ComprehensiveBenefitTextBox', 500);

            InitUEditor('AwardsTextBox', 3500);
            InitUEditor('DeclarationUnitOpinionTextBox', 3500);
            InitUEditor('RecommendationTextBox', 3500);
            InitUEditor('UsingUnitFeedbackTextBox', 3500);
            InitUEditor('ConstructionUnitFeedbackTextBox', 3500);
        })
        // 初始化富文本框
        function InitUEditor(container, max) {
            var text = $("#" + container.replace("TextBox", ""));
            text.hide();
            var ue = UE.getEditor(container, {
                wordCount: false,
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
