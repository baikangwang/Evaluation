<%@ Page Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="WaterSystem_V2.aspx.cs" Inherits="Evaluation.View.Declaration.WaterSystem_V2"  validateRequest="false"%>

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
      #ProjectOverviewTextBox,#TechnicalFeaturesTextBox,#TechnicalEffectivenessTextBox,#ComprehensiveBenefitTextBox,#AwardsTextBox,#DeclarationUnitOpinionTextBox,#RecommendationTextBox
        {
            width:77%;text-align:left;margin-left:10px;
        }
       #UsingUnitFeedbackTextBox,#ConstructionUnitFeedbackTextBox{
           width:97%;margin-left:10px;text-align:center;
       }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=030000" id="nav02" runat="server" clientidmode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
        </li>
    </ul>
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
            <li><a id="tab_09" href="#btab9" data-toggle="tab">9、代表声明</a></li>
            <li><a id="tab_10" href="#btab10" data-toggle="tab">10、合作声明</a></li>
            <li><a id="tab_11" href="#btab11" data-toggle="tab" class="ExpertReviewList2" style="display: none;">11、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_1801" runat="server" ClientIDMode="Static" GroupingText="项目基本情况" class="panelPart">
                    <table>
                        <tr>
                            <td  style="width: 150px;">项目名称</td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">项目类别</td>
                            <td colspan="3">
                                <%--<div class="DeclarationList">--%>
                                    <asp:DropDownList runat="server" ID="DeclarationCategory" class="ddlProjectSource" ClientIDMode="Static">
                                    </asp:DropDownList>
                                <%--</div>--%>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtDeclarationCategory" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px;">申报单位</td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr> 
                         <tr>
                            <td rowspan="5">合作单位</td>
                            <td>单位名称</td>
                            <td colspan="2">承担工作</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="CooperativeUnit1" runat="server" ClientIDMode="Static" Width="91%" onblur="Sensitize('CooperativeUnit1','UndertakeWork1')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td  colspan="2" onclick="Sensitize('CooperativeUnit1','UndertakeWork1')">
                                <asp:TextBox ID="UndertakeWork1" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td onclick="Sensitize2('CooperativeUnit2','UndertakeWork1')">
                                <asp:TextBox ID="CooperativeUnit2" runat="server" ClientIDMode="Static" Width="91%" onblur="Sensitize('CooperativeUnit2','UndertakeWork2')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit2','UndertakeWork2')">
                                <asp:TextBox ID="UndertakeWork2" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td onclick="Sensitize2('CooperativeUnit3','UndertakeWork2')">
                                <asp:TextBox ID="CooperativeUnit3" runat="server" ClientIDMode="Static" Width="91%" onblur="Sensitize('CooperativeUnit3','UndertakeWork3')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit3','UndertakeWork3')">
                                <asp:TextBox ID="UndertakeWork3" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td onclick="Sensitize2('CooperativeUnit4','UndertakeWork3')">
                                <asp:TextBox ID="CooperativeUnit4" runat="server" ClientIDMode="Static" Width="91%" onblur="Sensitize('CooperativeUnit4','UndertakeWork4')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit4','UndertakeWork4')">
                                <asp:TextBox ID="UndertakeWork4" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr> 
                        <tr>
                            <td>设计单位</td> 
                            <td> <asp:TextBox ID="DesignUnit" runat="server" ClientIDMode="Static" Width="91%"></asp:TextBox>
                             <asp:CheckBox runat="server" ID="CheckBox2" ClientIDMode="Static" ToolTip="公开" Checked="true" /></td> 
                            <td>施工单位</td> 
                            <td><asp:TextBox ID="ConstructionUnit" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox> 
                             <asp:CheckBox runat="server" ID="CheckBox5" ClientIDMode="Static" ToolTip="公开" Checked="true" /></td>
                        </tr>
                        <tr>
                            <td>工程起止时间</td> 
                            <td> 
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="StartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择工程起始日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="EndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择工程结束日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsStandardEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td> 
                            <td>竣工验收时间</td> 
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计结束日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="CheckBox1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td> 
                        </tr>
                        <tr>
                            <td  style="width: 150px;">验收部门</td>
                            <td colspan="3">
                                <asp:TextBox ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td  style="width: 150px;">申报单位通讯地址</td>
                            <td colspan="3">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>单位资质</td> 
                            <td> <asp:TextBox ID="UnitQualification" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                 <asp:CheckBox runat="server" ID="CheckBox6" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td> 
                            <td>证书编号</td> 
                            <td><asp:TextBox ID="CertificateNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                 <asp:CheckBox runat="server" ID="CheckBox7" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td> 
                        </tr>
                        <tr>
                            <td>申报单位联系人</td> 
                            <td> <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                 <asp:CheckBox runat="server" ID="CheckBox8" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td> 
                            <td>电话</td> 
                            <td><asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                 <asp:CheckBox runat="server" ID="CheckBox9" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td> 
                        </tr>
                        <tr>
                            <td>邮政编码</td> 
                            <td> <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                 <asp:CheckBox runat="server" ID="CheckBox10" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td> 
                            <td>手机</td> 
                            <td><asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                 <asp:CheckBox runat="server" ID="CheckBox11" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td> 
                        </tr>
                        <tr>
                            <td>电子邮箱</td> 
                            <td> <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                 <asp:CheckBox runat="server" ID="CheckBox12" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td> 
                            <td>传真</td> 
                            <td><asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                 <asp:CheckBox runat="server" ID="CheckBox13" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td> 
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1801')" id="Save_1801">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1801','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>

            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" id="ucParticipant"></uc:Participant>
            </div> 

            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_1802" runat="server" GroupingText="水系统工程项目特点">
                    <table>
                        <tr>
                            <td style="text-align: left; padding-left: 10px; width:20%">项目概况</td>
                            <td>
                                <p>（项目总体介绍、项目规模、复杂程度及影响程度等，限500字）</p> 
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="ProjectOverviewTextBox" type="text/plain" style=" height: 300px;"></script>                                
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: left; padding-left: 10px; width:20%">技术特色</td>
                            <td>
                                <p>（项目特色及主要的技术成果指标，限1500字）</p> 
                                <asp:TextBox ID="TechnicalFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="TechnicalFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>                               
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: left; padding-left: 10px; width:20%">技术成效与深度</td>
                            <td>
                                <p>（解决的技术难题、工程问题的成效与深度，限1500字）</p> 
                                <asp:TextBox ID="TechnicalEffectiveness" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox>
                                <script id="TechnicalEffectivenessTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: left; padding-left: 10px; width:20%">综合效益</td>
                            <td>
                                <p>（项目产生的经济、社会、环境效益，限500字）</p> 
                                <asp:TextBox ID="ComprehensiveBenefit" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;">
                                </asp:TextBox>
                                <script id="ComprehensiveBenefitTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1802')" id="Save_1802">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1802','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>

            <div class="tab-pane" id="btab4">
                <asp:Panel ID="panelPart_1803" runat="server" GroupingText="水系统工程项目建设内容">
                    <table>
                        <tr>
                            <td>
                                系统类别或分项内容
                            </td>
                            <td>
                                形式及设置范围
                            </td>
                            <td>
                                特 点
                            </td>
                        </tr>
                         <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown1" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope1" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics1" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown2" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope2" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics2" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown3" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope3" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics3" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown4" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope4" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics4" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown5" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope5" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics5" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown6" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope6" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics6" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown7" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope7" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics7" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown8" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope8" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics8" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown9" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope9" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics9" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown10" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope10" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics10" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown11" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope11" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics11" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown12" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope12" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics12" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                        <tr>
                            <td>
                                <asp:TextBox ID="SystemBreakdown13" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="FormAndScope13" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionCharacteristics13" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 100px;display:block;"></asp:TextBox> 
                            </td>
                        </tr> 
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1803')" id="Save_1803">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1803','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('04')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('04')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 

            <div class="tab-pane" id="btab5">
                <asp:Panel ID="panelPart_1804" runat="server" GroupingText="审核意见">
                    <table>
                         <tr>
                            <td style="text-align: left; padding-left: 10px; width:20%">曾获奖项</td>
                            <td>
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;">
                                </asp:TextBox>
                                <script id="AwardsTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                         <tr>
                            <td style="text-align: left; padding-left: 10px; width:20%">申报单位意见</td>
                            <td>
                                <asp:TextBox ID="DeclarationUnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;">
                                </asp:TextBox>
                                <script id="DeclarationUnitOpinionTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                         <tr>
                            <td style="text-align: left; padding-left: 10px; width:20%">地方、部门勘察设计同业协会推荐意见</td>
                            <td>
                                <asp:TextBox ID="Recommendation" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;">
                                </asp:TextBox>
                                <script id="RecommendationTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1804')" id="Save_1804">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1804','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('05')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('05')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>

            <div class="tab-pane" id="btab6">
                <asp:Panel ID="panelPart_1805" runat="server" GroupingText="使用单位反馈意见">
                    <table>
                        <tr>
                            <td  style="width: 150px;">项目名称</td>
                            <td colspan="3">
                                <asp:TextBox ID="UseDeclarationName" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td  style="width: 150px;">使用单位</td>
                            <td colspan="3">
                                <asp:TextBox ID="UseUnit" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td  style="width: 150px;">通讯地址</td>
                            <td colspan="3">
                                <asp:TextBox ID="UseUnitAddress" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td  style="width: 150px;">开始使用时间</td>
                            <td colspan="3">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="UseStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择开始使用日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                            </td>                        
                        </tr>
                        <tr>
                            <td colspan="2">
                                <p>反馈意见：</p> 
                                <asp:TextBox ID="UsingUnitFeedback" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox> 
                                <script id="UsingUnitFeedbackTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td> 
                        </tr> 
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1805')" id="Save_1805">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1805','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('06')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('06')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel> 
            </div>

            <div class="tab-pane" id="btab7">
                <asp:Panel ID="panelPart_1806" runat="server" GroupingText="施工单位反馈意见">
                    <table>
                        <tr>
                            <td  style="width: 150px;">项目名称</td>
                            <td colspan="3">
                                <asp:TextBox ID="ConstructionDeclarationName" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td  style="width: 150px;">施工单位</td>
                            <td colspan="3">
                                <asp:TextBox ID="NewConstructionUnit" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td  style="width: 150px;">通讯地址</td>
                            <td colspan="3">
                                <asp:TextBox ID="ConstructionUnitAddress" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td  style="width: 150px;">施工起止时间</td>
                            <td colspan="3">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="ConstructionStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择开始施工日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="CheckBox3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="ConstructionEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择开始施工日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="CheckBox4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>                        
                        </tr>
                        <tr>
                            <td colspan="2">
                                <p>反馈意见：</p> 
                                <asp:TextBox ID="ConstructionUnitFeedback" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 98%; height: 300px;"></asp:TextBox> 
                                <script id="ConstructionUnitFeedbackTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td> 
                        </tr> 
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1806')" id="Save_1806">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1806','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('07')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('07')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel> 
            </div>


            <div class="tab-pane" id="btab8">
                <uc:Appendix runat="server" ID="Appendix"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab9">
              <uc:LegalStates runat="server" id="ucLegalStates"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab10">
              <uc:Certificate runat="server" id="ucCertificate"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab11">
              <uc:Comments runat="server" id="ucComments"></uc:Comments>
            </div>   
    </div>
    </div>
    <script type="text/javascript">
        $('#DeclarationCategory').ui_choose();
        $('#UseDeclarationName').attr('disabled', true);
        $('#ConstructionDeclarationName').attr('disabled', true);
        for (i = 1; i < 16; i++) {
            if ($("#ParticipantName" + i).val() == "") {
                $("#IDNumber" + i).attr('disabled', true);
            }
        }
        //重置附件顺序
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
            $("#ProjectOverview").val(EncodeUEditorContent(UE.getEditor('ProjectOverviewTextBox').getContent()));
            $("#TechnicalFeatures").val(EncodeUEditorContent(UE.getEditor('TechnicalFeaturesTextBox').getContent()));
            $("#TechnicalEffectiveness").val(EncodeUEditorContent(UE.getEditor('TechnicalEffectivenessTextBox').getContent()));
            $("#ComprehensiveBenefit").val(EncodeUEditorContent(UE.getEditor('ComprehensiveBenefitTextBox').getContent()));

            $("#Awards").val(EncodeUEditorContent(UE.getEditor('AwardsTextBox').getContent()));
            $("#DeclarationUnitOpinion").val(EncodeUEditorContent(UE.getEditor('DeclarationUnitOpinionTextBox').getContent()));
            $("#Recommendation").val(EncodeUEditorContent(UE.getEditor('RecommendationTextBox').getContent()));
            $("#UsingUnitFeedback").val(EncodeUEditorContent(UE.getEditor('UsingUnitFeedbackTextBox').getContent()));
            $("#ConstructionUnitFeedback").val(EncodeUEditorContent(UE.getEditor('ConstructionUnitFeedbackTextBox').getContent()));
           if (!checkUEditor('ProjectOverviewTextBox')
                 || !checkUEditor('TechnicalFeaturesTextBox')
                 || !checkUEditor('TechnicalEffectivenessTextBox')
                 || !checkUEditor('ComprehensiveBenefitTextBox')

                 || !checkUEditor('AwardsTextBox')
                 || !checkUEditor('DeclarationUnitOpinionTextBox')
                 || !checkUEditor('RecommendationTextBox')
                 || !checkUEditor('UsingUnitFeedbackTextBox')
                 || !checkUEditor('ConstructionUnitFeedbackTextBox')
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
                        ShowMessag("保存成功");                      
                    }
                },
                error: function (data) {
                    ShowMessag("保存失败, 请重新保存！");
                },
            });          
            SetCollaborationInfo2();
        }

        $(function () {
            SetCollaborationInfo2();
            notBackspace();
            // 富文本框
            InitUEditor('ProjectOverviewTextBox', 500);              // 设计主要特点
            InitUEditor('TechnicalFeaturesTextBox', 1500);
            InitUEditor('TechnicalEffectivenessTextBox', 1500);
            InitUEditor('ComprehensiveBenefitTextBox', 500);

            InitUEditor('AwardsTextBox', 1000);
            InitUEditor('DeclarationUnitOpinionTextBox', 1000);
            InitUEditor('RecommendationTextBox', 1000);
            InitUEditor('UsingUnitFeedbackTextBox', 2000);
            InitUEditor('ConstructionUnitFeedbackTextBox', 2000);
            ////设置cookie初始值
            //addCookie('TabId', 'tab_01', 1);

            $("#tabfather li a[data-toggle='tab']").click(function () {
                var TabsId = getCookie('TabId');
                var n = TabsId.substr(-2, 2);
                var id = $(this).attr("id").substr(-2, 2);
                ShowTab(id);           
                //if (n == "01") {
                //    //$("#Save_1801").click();
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
                //       // $("#Save_180" + n).click();
                //    }
                //    else {
                //       // $("#Save_18" + n).click();
                //    }
                //}
               
                //点击存储本次Tab的ID
                addCookie('TabId', $(this).attr("id"), 1);             
            })
        });
     
        for (d = 2; d < 5; d++) {
            if ($("#CooperativeUnit" + d).val() == "") {
                $("#CooperativeUnit" + d).attr('disabled', true);
            }
            if ($("#UndertakeWork" + d).val() == "") {
                $("#UndertakeWork" + d).attr('disabled', true);
            }
        }
        if ($("#UndertakeWork1").val() == "") {
            $("#UndertakeWork1").attr('disabled', true);
        }
        function Sensitize(CooperativeUnit, UndertakeWork) {
            if ($("#" + CooperativeUnit).val().trim() != "") {
                $("#" + UndertakeWork).attr('disabled', false);
            }
            else {
                $("#" + UndertakeWork).val("");
                $("#" + UndertakeWork).attr('disabled', true);
            }
        }
        function Sensitize2(CooperativeUnit, UndertakeWork) {
            if ($("#" + UndertakeWork).val().trim() != "") {
                $("#" + CooperativeUnit).attr('disabled', false);
            }
        }
        $("#UndertakeWork1").change(function () {
            if ($("#UndertakeWork1").val() == "") {
                $("#CooperativeUnit1").val("");
            }
        })
        $("#UndertakeWork2").change(function () {
            if ($("#UndertakeWork2").val() == "") {
                $("#CooperativeUnit2").val("");
            }
        })
        $("#UndertakeWork3").change(function () {
            if ($("#UndertakeWork3").val() == "") {
                $("#CooperativeUnit3").val("");
            }
        })
        $("#UndertakeWork4").change(function () {
            if ($("#UndertakeWork4").val() == "") {
                $("#CooperativeUnit4").val("");
            }
        })
    </script>
</asp:Content>