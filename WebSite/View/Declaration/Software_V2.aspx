<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="Software_V2.aspx.cs" Inherits="Evaluation.View.Declaration.Software_V2"  validateRequest="false"%>

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
        table{border:none; border-collapse: collapse;width:90%;margin:0px auto}
        table tr{border:none;}
        table tr td{border:1px solid;padding:10px 2px 5px 5px;text-align:center;line-height:25px;height:25px;}
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

        #content #test{
            height:2500px!important;
        }
        .textmargin{
            margin-left: 5px;
            float: none!important;
        }
        #AwardsTextBox,#OpinionTextBox,#RecommendOpinionTextBox{
            width:88%;text-align:left;margin-left:10px;
        }
        #PurposeTextBox{
            width:67%;text-align:left;margin-left:10px;
        }
         #MainFunctionsTextBox,#ComparisonTextBox,#BenefitsTextBox{
             width:96%;text-align:left;margin-left:10px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=160000" id="nav02" runat="server" clientidmode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
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
    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、项目特点</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、附件目录</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、法人声明</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、合作声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab" class="ExpertReviewList2" style="display: none;">7、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_1601" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 150px;">项目名称
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareDeclarationName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>主要设计<br />
                                单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareDeclarationUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">合作单位</td>
                            <td>单位名称</td>
                            <td colspan="2">承担工作</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="CooperativeUnit1" runat="server" ClientIDMode="Static" Width="92%" onblur="Sensitize('CooperativeUnit1','UndertakeWork1')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit1','UndertakeWork1')">
                                <asp:TextBox ID="UndertakeWork1" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td onclick="Sensitize2('CooperativeUnit2','UndertakeWork1')">
                                <asp:TextBox ID="CooperativeUnit2" runat="server" ClientIDMode="Static" Width="92%" onblur="Sensitize('CooperativeUnit2','UndertakeWork2')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit2','UndertakeWork2')">
                                <asp:TextBox ID="UndertakeWork2" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td onclick="Sensitize2('CooperativeUnit3','UndertakeWork2')">
                                <asp:TextBox ID="CooperativeUnit3" runat="server" ClientIDMode="Static" Width="92%" onblur="Sensitize('CooperativeUnit3','UndertakeWork3')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit3','UndertakeWork3')">
                                <asp:TextBox ID="UndertakeWork3" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td onclick="Sensitize2('CooperativeUnit4','UndertakeWork3')">
                                <asp:TextBox ID="CooperativeUnit4" runat="server" ClientIDMode="Static" Width="92%" onblur="Sensitize('CooperativeUnit4','UndertakeWork4')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit4','UndertakeWork4')">
                                <asp:TextBox ID="UndertakeWork4" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                通讯地址
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwarePostalAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>单位资质
                            </td>
                            <td style="width: 35%">
                                <asp:TextBox ID="Qualification" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareQualification" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="width: 150px;">证书编号
                            </td>
                            <td>
                                <asp:TextBox ID="CertificateNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCertificateNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                联系人
                            </td>
                            <td>
                                <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareLinkman" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>电话
                            </td>
                            <td>
                                <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareTelephoneNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwarePostcode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>手机
                            </td>
                            <td>
                                <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareMobileNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareEmailAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>传真
                            </td>
                            <td>
                                <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareFaxNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>软件开发模式：
                            </td>
                            <td colspan="3">
                                <div class="DeclarationList">
                                    <asp:DropDownList ID="DevelopmentModel" runat="server" ClientIDMode="Static" Width="97%"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtDevelopmentModel" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsSoftwareDevelopmentModel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>软件类别： 
                            </td>
                            <td colspan="3">
                                <div class="DeclarationList">
                                    <asp:DropDownList ID="SoftwareCategory" runat="server" ClientIDMode="Static" Width="97%"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtSoftwareCategory" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsSoftwareSoftwareCategory" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>软件符合哪类现行<br />
                                国家规范
                            </td>
                            <td>
                                <asp:TextBox ID="ConformityNationalNorms" runat="server" ClientIDMode="Static" Width="93%" class="textmargin"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareConformityNationalNorms" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>任务来源
                            </td>
                            <td>
                                <asp:TextBox ID="ProjectSource" runat="server" ClientIDMode="Static" Width="93%" class="textmargin"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsProjectSource" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>开发起止年月
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="StartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择开发起始日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="EndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择开发结束日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsSoftwareEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>试用年月
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="TrialDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择试用日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsSoftwareTrialDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>鉴定部门
                            </td>
                            <td>
                                <asp:TextBox ID="IdentificationDepartment" runat="server" ClientIDMode="Static" Width="93%" class="textmargin"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareIdentificationDepartment" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>鉴定时间
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="IdentificationDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择鉴定日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsSoftwareIdentificationDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
<%--                        <tr>
                            <td>验收部门
                            </td>
                            <td>
                                <asp:TextBox ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="92%" class="textmargin"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareAcceptanceDepartment" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>验收时间
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择验收日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsSoftwareAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>--%>
                        <tr>
                            <td>评测公司
                            </td>
                            <td>
                                <asp:TextBox ID="EvaluationCompany" runat="server" ClientIDMode="Static" Width="93%" class="textmargin" Style="margin-right:10px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareEvaluationCompany" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>评测时间
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="EvaluationDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择评测日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsSoftwareEvaluationDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
<%--                        <tr>
                            <td>软件著作权登记号
                            </td>
                            <td>
                                <asp:TextBox ID="CopyrightRegistrationNumber" runat="server" ClientIDMode="Static" Width="93%" class="textmargin"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCopyrightRegistrationNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>著作权人
                            </td>
                            <td>
                                <asp:TextBox ID="CopyrightOwner" runat="server" ClientIDMode="Static" Width="92%" class="textmargin"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCopyrightOwner" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>--%>
                        <tr>
                            <td>保密级别：
                            </td>
                            <td colspan="3">
                                <div class="DeclarationList">
                                    <asp:DropDownList ID="SecurityLevel" runat="server" ClientIDMode="Static" Width="97%"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtSecurityLevel" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsSoftwareSecurityLevel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                    <div style="display: none"><a onclick="javascript:onSave('Template_1601')" id="Save_1601">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1601','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" ID="ucParticipant"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_1602" runat="server" ClientIDMode="Static" GroupingText="工程勘察设计计算机软件项目特点">
                    <table>
                        <tr>
                            <td rowspan="3" style="padding: 10px; width: 10%;">软件环境
                            </td>
                            <td style="padding: 10px; width: 15%;">运行操作系统名称及版本号
                            </td>
                            <td>
                                <asp:TextBox ID="OsVersion" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                <asp:CheckBox ID="IsSoftwareOsVersion" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>支撑环境名称
                                及 版 本 号
                            </td>
                            <td>
                                <asp:TextBox ID="SupportEnvironment" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                <asp:CheckBox ID="IsSoftwareSupportEnvironment" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>编程语言名称
                                及 版 本 号
                            </td>
                            <td>
                                <asp:TextBox ID="ProgrammingLanguage" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                <asp:CheckBox ID="IsSoftwareProgrammingLanguage" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">适用范围
                            </td>
                            <td>主要适用行业
                            </td>
                            <td>
                                <asp:TextBox ID="ApplicableIndustry" runat="server" ClientIDMode="Static" Width="96%"></asp:TextBox>
                                <asp:CheckBox ID="IsSoftwareApplicableIndustry" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>主要用途
                            </td>
                            <td>
                                <asp:TextBox ID="Purpose" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 96%; height: 300px;"></asp:TextBox>
                                <script id="PurposeTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsSoftwarePurpose" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: left; padding-left: 10px;">软件主要功能、技术架构及创新概述(限500字):</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:TextBox ID="MainFunctions" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="MainFunctionsTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsSoftwareMainFunctions" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: left; padding-left: 10px;">
                                该软件与当前国内外同类软件的综合比较（包括存在问题及改进措施,限1500字）:
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:TextBox ID="Comparison" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="ComparisonTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsSoftwareComparison" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" style="text-align: left; padding-left: 10px;">该软件的经济与社会效益(限500字):</td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <asp:TextBox ID="Benefits" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="BenefitsTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsSoftwareBenefits" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>               
                    <table>
                         <tr>
                          <td  colspan="11" style="border:none;">
                              <h3>审核意见</h3>
                          </td>
                       </tr>
                        <tr>
                            <td rowspan="1">曾获奖项
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="AwardsTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsSoftwareAwards" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td >申报单位<br />
                                意   见
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="Opinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                               <script id="OpinionTextBox" type="text/plain" style="height: 300px;"></script>                              
                            </td>
                        </tr>
                         <tr>
                            <td>
                                地方、部门勘察设计同业协会推荐意见
                            </td>
                            <td>
                                <asp:TextBox ID="RecommendOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="RecommendOpinionTextBox" type="text/plain" style="height: 300px;"></script>
                            </td> 
                        </tr>  
                    </table>

                    <div style="display: none"><a onclick="javascript:onSave('Template_1602')" id="Save_1602">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1602','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab4">
                <uc:Appendix runat="server" ID="Appendix"></uc:Appendix>
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

        $('#DevelopmentModel').ui_choose();
        $('#SoftwareCategory').ui_choose();
        $('#SecurityLevel').ui_choose();

        // 软件开发模式样式
        switch ($('#DevelopmentModel').val()) {
            case "2501":
                $('#txtDevelopmentModel').val("原创软件");
                break;
            case "2502":
                $('#txtDevelopmentModel').val("合作开发");
                break;
            case "2503":
                $('#txtDevelopmentModel').val("二次开发");
                break;
        }

        // 软件类别样式
        switch ($('#SoftwareCategory').val()) {
            case "2601":
                $('#txtSoftwareCategory').val("辅助设计");
                break;
            case "2602":
                $('#txtSoftwareCategory').val("信息管理");
                break;
            case "2603":
                $('#txtSoftwareCategory').val("通用平台");
                break;
            case "2604":
                $('#txtSoftwareCategory').val("其他");
                break;
        }

        // 保密级别样式
        switch ($('#SecurityLevel').val()) {
            case "2701":
                $('#txtSecurityLevel').val("绝密");
                break;
            case "2702":
                $('#txtSecurityLevel').val("机密");
                break;
            case "2703":
                $('#txtSecurityLevel').val("秘密");
                break;
            case "2704":
                $('#txtSecurityLevel').val("不限制");
                break;
        }

        //重置上下步顺序
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
        //页面跳转（保存）
        function onSave(PartCode, Tip) {
            // 富文本框取值
           $("#Purpose").val(EncodeUEditorContent(UE.getEditor('PurposeTextBox').getContent()));                              // 主要用途
           $("#MainFunctions").val(EncodeUEditorContent(UE.getEditor('MainFunctionsTextBox').getContent()));                  // 软件主要功能、技术架构及创新概述
           $("#Comparison").val(EncodeUEditorContent(UE.getEditor('ComparisonTextBox').getContent()));                        // 该软件与当前国内外同类软件的综合比较
           $("#Benefits").val(EncodeUEditorContent(UE.getEditor('BenefitsTextBox').getContent()));                            // 该软件的经济与社会效益
           $("#Awards").val(EncodeUEditorContent(UE.getEditor('AwardsTextBox').getContent()));                                // 曾获奖项
           $("#Opinion").val(EncodeUEditorContent(UE.getEditor('OpinionTextBox').getContent()));                              // 申报单位意见
           $("#RecommendOpinion").val(EncodeUEditorContent(UE.getEditor('RecommendOpinionTextBox').getContent()));
           if (!checkUEditor('PurposeTextBox')
               || !checkUEditor('MainFunctionsTextBox')
               || !checkUEditor('ComparisonTextBox')
               || !checkUEditor('OpinionTextBox')
               || !checkUEditor('BenefitsTextBox')
               || !checkUEditor('AwardsTextBox')
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
                },
            });
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
            //                $("#txtCooperationUnit2").val(data[0]["Data"]);
            //            }
            //            else {
            //                $("#txtCooperationUnit2").val("");
            //            }
            //            if (data[1]) {
            //                $("#txtUndertakeWork2").val(data[2]["Data"]);
            //            }
            //            else {
            //                $("#txtUndertakeWork2").val("");
            //            }
            //            if (data[2]) {
            //                $("#txtCooperationUnit3").val(data[3]["Data"]);
            //            }
            //            else {
            //                $("#txtCooperationUnit3").val("");
            //            }
            //            if (data[3]) {
            //                $("#txtUndertakeWork3").val(data[5]["Data"]);
            //            }
            //            else {
            //                $("#txtUndertakeWork3").val("");
            //            }
            //            if (data[4]) {
            //                $("#txtCooperationUnit4").val(data[6]["Data"]);
            //            }
            //            else {
            //                $("#txtCooperationUnit4").val("");
            //            }
            //            if (data[5]) {
            //                $("#txtUndertakeWork4").val(data[8]["Data"]);
            //            }
            //            else {
            //                $("#txtUndertakeWork4").val("");
            //            }
            //            if (data[6]) {
            //                $("#txtCooperationUnit5").val(data[9]["Data"]);
            //            }
            //            else {
            //                $("#txtCooperationUnit5").val("");
            //            }
            //            if (data[7]) {
            //                $("#txtUndertakeWork5").val(data[11]["Data"]);
            //            }
            //            else {
            //                $("#txtUndertakeWork5").val("");
            //            }
            //        }
            //        else {
            //            $("#txtCooperationUnit2").val("");
            //            $("#txtCooperationUnit3").val("");
            //            $("#txtCooperationUnit4").val("");
            //            $("#txtCooperationUnit5").val("");
            //            $("#txtUndertakeWork2").val("");
            //            $("#txtUndertakeWork3").val("");
            //            $("#txtUndertakeWork4").val("");
            //            $("#txtUndertakeWork5").val("");
            //        }
            //    },
            //});
            SetCollaborationInfo2();
        }

        $(function () {
            SetCollaborationInfo2();
            $('#IdentificationDepartment').parent().css({ 'text-align': 'center' });
            $('#EvaluationCompany').parent().css({ 'text-align': 'center' });
            $('#CopyrightRegistrationNumber').parent().css({ 'text-align': 'center' });
            $('#CopyrightOwner').parent().css({ 'text-align': 'center' })
            notBackspace();
            // 富文本框

           InitUEditor('PurposeTextBox', 500);                            // 主要用途
           InitUEditor('MainFunctionsTextBox', 500);                      // 软件主要功能、技术架构及创新概述
           InitUEditor('ComparisonTextBox', 1500);                        // 该软件与当前国内外同类软件的综合比较
           InitUEditor('BenefitsTextBox', 500);                           // 该软件的经济与社会效益
           InitUEditor('AwardsTextBox', 1000);                            // 曾获奖项
           InitUEditor('OpinionTextBox', 1000);                           // 申报单位意见
           InitUEditor('RecommendOpinionTextBox', 1000);

           $("#tabfather li a[data-toggle='tab']").click(function () {
                var TabsId = getCookie('TabId');
                var n = TabsId.substr(-2, 2);
                var id = $(this).attr("id").substr(-2, 2);             
                //if (n == "01") {
                //    //$("#Save_1601").click();
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
                //        //("#Save_160" + n).click();
                //    }
                //    else {
                //        //$("#Save_16" + n).click();
                //    }
                //}
                ShowTab(id);
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
