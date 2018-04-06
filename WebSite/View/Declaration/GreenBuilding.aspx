<%@ Page Title="绿色建筑" Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="GreenBuilding.aspx.cs" Inherits="Evaluation.View.Declaration.GreenBuilding" validateRequest="false" %>

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
     <%--   tbody > tr > td:nth-child(2) > div {
            left: -13px !important;
        }--%>
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
     
        #AcceptanceDate{
            margin-left: 0px!important;
        }
        #ArchitectureMainFeaturesTextBox{
            text-align:left;
        }
        
        fieldset p{
           
            padding-left:10px;
        }
        #ProjectOverviewTextBox,#KeyTechnologyTextBox,#EffectTextBox,#BenefitTextBox,    
       #CompanyOpinionTextBox,#AssociationOpinionTextBox{
            text-align:left;width:82%;margin-left:10px;
        }
        #AwardsTextBox{
              text-align:left;width:83%;margin-left:10px;
        }
        #ArchitectureMainFeaturesTextBox,#StructureMainFeaturesTextBox,#MechanicalMainFeaturesTextBox,#ElectricalMainFeaturesTextBox, #EconomicsFeaturesTextBox{
               text-align:left;width:97%;margin-left:10px;
        }
        .isrequir b{
            position:relative;bottom:13px;
        }
    </style>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <ul class="navs">
        <li class="nav1" style="float:left;padding-right:5px;">           
            <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=040000" id="nav02" runat="server" ClientIDMode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
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
        <li><a id="tab_03" href="#btab3" data-toggle="tab">3、项目特点</a></li>
        <li><a id="tab_04" href="#btab4" data-toggle="tab">4、建筑专业</a></li>
        <li><a id="tab_05" href="#btab5" data-toggle="tab">5、结构专业</a></li>
        <li><a id="tab_06" href="#btab6" data-toggle="tab">6、设备专业</a></li>
        <li><a id="tab_07" href="#btab7" data-toggle="tab">7、电气专业</a></li>
        <li><a id="tab_08" href="#btab8" data-toggle="tab">8、经济指标</a></li>
        <li><a id="tab_09" href="#btab9" data-toggle="tab">9、附件目录</a></li>
        <li><a id="tab_10" href="#btab10" data-toggle="tab">10、法人声明</a></li>
        <li><a id="tab_11" href="#btab11" data-toggle="tab">11、合作声明</a></li>
        <li><a id="tab_12" href="#btab12" data-toggle="tab" class="ExpertReviewList2" style="display:none;">12、评审意见</a></li>                           

        </ul>
        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_0401" runat="server" ClientIDMode="Static" GroupingText="全国优秀工程勘察设计行业奖申报表">
                    <table>
                        <tr>
                            <td style="width: 15%">项目名称
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenDeclarationName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>主要设计单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenDeclarationUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                                            <asp:TextBox ID="CooperativeUnit1" runat="server" ClientIDMode="Static" Style="width: 88%;" required="required" onblur="Sensitize('CooperativeUnit1','CollaborativePhase01')"></asp:TextBox>
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
                            <td>绿建咨询单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="AdvisoryUnit" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenAdvisoryUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>工程设计<br />
                                起止时间
                            </td>
                            <td style="width: 35%">
                                <div class="datepicker input-group date" style="width:46%;">
                                    <asp:TextBox ID="ProjectStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择工程开始日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsGreenProjectStartDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            
                                <div class="datepicker input-group date" style="width:46%;">
                                    <asp:TextBox ID="ProjectEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择工程结束日期"></asp:TextBox>
                                    <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsGreenProjectEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>竣工验收时间
                            </td>
                            <td>
                                <div class="datepicker input-group date" style="margin:0px auto;">
                                    <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工验收日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 1px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsGreenAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>验收部门
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenAcceptanceDepartment" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位<br />
                                通讯地址
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenPostalAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>单位资质
                            </td>
                            <td>
                                <asp:TextBox ID="Qualification" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenQualification" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="width:12%;">证书编号
                            </td>
                            <td style="width:35%;">
                                <asp:TextBox ID="CertificateNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCertificateNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位联系人
                            </td>
                            <td>
                                <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenLinkman" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>电话
                            </td>
                            <td>
                                <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTelephoneNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenPostcode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>手机
                            </td>
                            <td>
                                <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenMobileNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenEmailAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>传真
                            </td>
                            <td>
                                <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenFaxNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                         <tr>
                            <td style="width:150px; padding:25px;">
                                曾获奖项
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 200px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenAwards" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="AwardsTextBox" type="text/plain" style=" height: 300px;"></script>
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
                    <div style="display:none"><a onclick="javascript:onSave('Template_0401')" id="Save_0401">保存</a></div> 
                    <div style="text-align:center;margin-top:40px;">
                        <a onclick="javascript:onSave('Template_0401','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" id="ucParticipant"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_0402" runat="server" ClientIDMode="Static" GroupingText="工程勘察设计项目特点">
                    <table style="height: 500px;">
                        <tr>
                            <td style="width: 15%;padding: 25px;">项目概况
                            </td>
                            <td>
                                <p>（项目总体介绍、工程性质、工程投资、项目规模、解决的主要技术问题、复杂程度及影响程度等，限500字）</p>
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 300px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenProjectOverview" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="ProjectOverviewTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>关键绿色策略与技术
                            </td>
                            <td>
                                <p>（项目主要绿色设计策略和技术措施，介绍项目的总体绿色设计目标和策略，并分别从节地与室外环境、节能与能源利用、节水与水资源利用、节材与材料资源利用、室外环境质量、运行管理等方面进行阐述，限1500字）</p>
                                <asp:TextBox ID="KeyTechnology" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 300px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenKeyTechnology" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="KeyTechnologyTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>技术成效
                        <br />
                                与深度
                            </td>
                            <td>
                                <p>（解决的关键技术难题，包括：被动式和主动式技术策略整合的成效与深度；绿色策略与技术和当地气候、社会、经济技术条件的适宜性、技术集成性和创新性；设计中建筑艺术与绿色策略与技术的有机结合等，对于有示范性的项目还包括达到示范性低碳、节能、环保指标的技术路线等，限1500字）</p>
                                <asp:TextBox ID="Effect" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 300px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenEffect" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="EffectTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>综合效益
                            </td>
                            <td>
                                <p>（项目产生的经济、社会、环境效益，以及示范推广价值，限500字）</p>
                                <asp:TextBox runat="server" ID="Benefit" ClientIDMode="Static" style="width: 95%; height: 300px;" TextMode="MultiLine"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenBenefit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="BenefitTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_0402')" id="Save_0402">保存</a></div> 
                    <div style="text-align:center;margin-top:40px;">
                        <a onclick="javascript:onSave('Template_0402','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab4">
                <asp:Panel ID="panelPart_0403" runat="server" ClientIDMode="Static" GroupingText="专业技术指标（建筑专业）"  >
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
                                            <asp:TextBox ID="ExpropriationArea" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> ha
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
                                            <asp:TextBox ID="ConstructionArea" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> ha
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
                                            <asp:TextBox ID="OvergroundArea" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> ㎡
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
                                            <asp:TextBox ID="UndergroundArea" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> ㎡
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
                                <asp:TextBox ID="BuildingArea" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> ㎡
                        <asp:CheckBox runat="server" ID="IsGreenBuildingArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>容 积 率
                            </td>
                            <td>
                                <asp:TextBox ID="PlotRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenPlotRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>绿 地 面 积
                            </td>
                            <td>
                                <asp:TextBox ID="GreenArea" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> ㎡
                        <asp:CheckBox runat="server" ID="IsGreenGreenArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>绿 化 率
                            </td>
                            <td>
                                <asp:TextBox ID="GreeningRate" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenGreeningRate" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>建筑高度 
                            </td>
                            <td>
                                <asp:TextBox ID="BuildingHeight" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> m 
                        <asp:CheckBox runat="server" ID="IsGreenBuildingHeight" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>建筑分类<br />
                                （高层建筑）
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
                                            <asp:TextBox ID="OvergroundLayerCount" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox> 层
                                    <asp:CheckBox runat="server" ID="IsGreenOvergroundLayerCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td rowspan="2">耐火等级
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
                                            <asp:TextBox ID="UndergroundLayerCount" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox> 层
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
                                            <asp:TextBox ID="LayerHeight_Overground" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox> m
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
                                            <asp:TextBox ID="ElevatorNumber_MainBuilding" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> 台
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
                                            <asp:TextBox ID="ElevatorNumber_PodiumBuilding" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox> 台
                                    <asp:CheckBox runat="server" ID="IsGreenElevatorNumber_PodiumBuilding" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>住宅类型<br />
                                （居住建筑）
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="HousingType" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenHousingType" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">住宅平均每套<br />
                                建筑面积<br />
                                （居住建筑）
                            </td>
                            <td rowspan="2">
                                <asp:TextBox ID="UnitConstructionArea" runat="server" ClientIDMode="Static" Width="79%"></asp:TextBox> ㎡/套
                                <asp:CheckBox runat="server" ID="IsGreenUnitConstructionArea" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td rowspan="2">总居住户数<br />
                                （居住建筑）
                            </td>
                            <td>
                                <asp:TextBox ID="TotalFamilies" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> 户
                                <asp:CheckBox runat="server" ID="IsGreenTotalFamilies" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="TotalPerson" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                人
                                <asp:CheckBox runat="server" ID="IsGreenTotalPerson" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                                <asp:TextBox ID="OvergroundAutoParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> 辆
                                <asp:CheckBox runat="server" ID="IsGreenOvergroundAutoParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:TextBox ID="UndergroundAutoParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> 辆
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
                                            <asp:TextBox ID="BicycleParkingCount" runat="server" ClientIDMode="Static" Width="77%"></asp:TextBox> 辆
                                            <asp:CheckBox runat="server" ID="IsGreenBicycleParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            <td>地上
                            </td>
                            <td>
                                <asp:TextBox ID="OvergroundBicycleParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> 辆
                                <asp:CheckBox runat="server" ID="IsGreenOvergroundBicycleParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:TextBox ID="UndergroundBicycleParkingCount" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> 辆
                                <asp:CheckBox runat="server" ID="IsGreenUndergroundBicycleParkingCount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 154px">周围道路宽度及性质：            
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="RoadWidth" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsGreenRoadWidth" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>地下建筑面积与总用地面<br />
                                积比（公共建筑）
                            </td>
                            <td>
                                <asp:TextBox ID="UndergroundAreaTotalAreaRatio" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> %
                                <asp:CheckBox runat="server" ID="IsGreenUndergroundAreaTotalAreaRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>地下建筑面积与地上建筑<br />
                                面积比（居住建筑）
                            </td>
                            <td>
                                <asp:TextBox ID="UndergroundAreaOvergroundAreaRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> %
                                <asp:CheckBox runat="server" ID="IsGreenUndergroundAreaOvergroundAreaRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>人均居住用地指标<br />
                                （居住建筑）
                            </td>
                            <td>
                                <asp:TextBox ID="AvgPersonLandIndication" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> ㎡
                                <asp:CheckBox runat="server" ID="IsGreenAvgPersonLandIndication" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>下凹式绿地率
                            </td>
                            <td>
                                <asp:TextBox ID="LowerConcaveGreenSpaceRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                %
                                <asp:CheckBox runat="server" ID="IsGreenLowerConcaveGreenSpaceRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>硬质铺装地面中透水铺装<br />
                                面积比例
                            </td>
                            <td>
                                <asp:TextBox ID="PermeablePavementRatio" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenPermeablePavementRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>屋顶绿化率
                            </td>
                            <td>
                                <asp:TextBox ID="RoofGreeningRate" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenRoofGreeningRate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>外窗可开启面积比例
                            </td>
                            <td>                   
                                <asp:TextBox ID="ExternalWindowOpenableAreaRatio" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenExternalWindowOpenableAreaRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>玻璃幕墙透明部分可开启<br />
                                面积比例
                            </td>
                            <td>
                                <asp:TextBox ID="TransparentPartOpenableAreaRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>%
                        <asp:CheckBox runat="server" ID="IsGreenTransparentPartOpenableAreaRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>围护结构热工性能比国家<br />
                                现行节能标准提高比例
                            </td>
                            <td>
                                <asp:TextBox ID="IncreaseRatio" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> %
                                <asp:CheckBox runat="server" ID="IsGreenIncreaseRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>建筑节能率
                            </td>
                            <td>
                                <asp:TextBox ID="EnergyEfficiency" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenEnergyEfficiency" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>主要功能房间室内噪声级<br />
                                指标是否满足标准
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsNoiseLevelQualified" runat="server" ClientIDMode="Static" Width="85%"></asp:DropDownList></div> 
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsNoiseLevelQualified" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsNoiseLevelQualified" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>主要功能房间构造隔声性<br />
                                能要求低限标准（满足标<br />
                                准）/高要求标准
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:DropDownList ID="SoundInsulation" runat="server" ClientIDMode="Static" Width="86.5%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtSoundInsulation" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenSoundInsulation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>主要功能房间采光系数达<br />
                                标面积比例（公共建筑）
                            </td>
                            <td>
                                <asp:TextBox ID="DaylightFactor" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenDaylightFactor" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>卧室、起居室的窗地面积比<br />
                                （居住建筑）                      
                            </td>
                            <td>
                                <asp:TextBox ID="WindowToGroundAreaRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenWindowToGroundAreaRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>主要功能房间平均自然通<br />
                                风换气次数不小于2次/h<br />
                                的面积比例（公共建筑）
                            </td>
                            <td>
                                <asp:TextBox ID="NaturalVentilationAreaRatio" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenNaturalVentilationAreaRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>通风开口面积占房间地板<br />
                                面积的比例（居住建筑）                      
                            </td>
                            <td>
                                <asp:TextBox ID="VentilationOpeningAreaRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> %
                                <asp:CheckBox runat="server" ID="IsGreenVentilationOpeningAreaRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>设有可控遮阳部分占外窗<br />
                                及玻璃幕墙面积的比例
                            </td>
                            <td>
                                <asp:TextBox ID="ShadingAreaRatio" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenShadingAreaRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>可再利用材料和可再循环<br />
                                材料用量比例                     
                            </td>
                            <td>
                                <asp:TextBox ID="RecycledMaterialsRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox>
                                %
                        <asp:CheckBox runat="server" ID="IsGreenRecycledMaterialsRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>装饰性构建造价占工程总<br />
                                建安造价的比例
                            </td>
                            <td>
                                <asp:TextBox ID="DecorativeRatio" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                %
                        <asp:CheckBox runat="server" ID="IsGreenDecorativeRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>可重复使用隔断（墙）比例                    
                            </td>
                            <td>
                                <asp:TextBox ID="ReusableWallRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenReusableWallRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>工业化生产预制构件用量<br />
                                比例
                            </td>
                            <td>
                                <asp:TextBox ID="PrefabricatedRatio" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenPrefabricatedRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>本地生产的建筑材料比例                  
                            </td>
                            <td>
                                <asp:TextBox ID="LocallyMaterialsRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenLocallyMaterialsRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>利废建材的种类
                            </td>
                            <td>
                                <asp:TextBox ID="WasteMaterialsKinds" runat="server" ClientIDMode="Static" Width="85%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenWasteMaterialsKinds" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>利废建材占同类建材用量<br />
                                的比例                 
                            </td>
                            <td>
                                <asp:TextBox ID="WasteMaterialsRatio" runat="server" ClientIDMode="Static" Width="86.5%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenWasteMaterialsRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">土建工程与装修工程一体化设计（是/否）</td>
                            <td colspan="2">
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsIntegratedDesign" runat="server" ClientIDMode="Static" Width="92%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsIntegratedDesign" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsIntegratedDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align:left;padding-left:10px;">建筑专业设计主要特点：（不少于500字）</td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:TextBox ID="ArchitectureMainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width: 95%; height: 300px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenArchitectureMainFeatures" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="ArchitectureMainFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_0403')" id="Save_0403">保存</a></div>
                    <div style="text-align:center;margin-top:40px;">
                        <a onclick="javascript:onSave('Template_0403','Save')"  class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('04')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('04')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>                
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab5">
                <asp:Panel ID="panelPart_0404" runat="server" ClientIDMode="Static" GroupingText="专业技术指标（结构专业）"  >
                    <table>
                        <tr>
                            <td colspan="3" style="width: 200px;">结构体系</td>
                            <td colspan="4">
                                <asp:TextBox ID="StructuralSystem" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenStructuralSystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="width:135px;">抗震设防烈度</td>
                            <td colspan="4">
                                <asp:TextBox ID="SeismicFortificationIntensity" runat="server" Width="80%"></asp:TextBox> 度
                        <asp:CheckBox runat="server" ID="IsGreenSeismicFortificationIntensity" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">抗震设防类别</td>
                            <td colspan="4">
                                <asp:TextBox ID="SeismicFortificationCategory" runat="server" style="width:90%;margin-left:4%;"></asp:TextBox> 类
                        <asp:CheckBox runat="server" ID="IsGreenSeismicFortificationCategory" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>设计基本地震加速度值</td>
                            <td colspan="4">
                                <asp:TextBox ID="BasicSeismicAcceleration" runat="server" Width="80%"></asp:TextBox>  g
                        <asp:CheckBox runat="server" ID="IsGreenBasicSeismicAcceleration" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">设计地震分组</td>
                            <td colspan="4">
                                <asp:TextBox ID="EarthquakeGrouping" runat="server" style="width:90%;margin-left:4%;"></asp:TextBox> 组
                        <asp:CheckBox runat="server" ID="IsGreenEarthquakeGrouping" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>场 地 类 别</td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionSiteSoilType" runat="server" Width="80%"></asp:TextBox> 类
                        <asp:CheckBox runat="server" ID="IsGreenConstructionSiteSoilType" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">基础类型</td>
                            <td colspan="4">
                                <asp:TextBox ID="BaseType" runat="server" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenBaseType" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>建筑形体规则性</td>
                            <td colspan="4">
                                <asp:TextBox ID="BuildingShape" runat="server" Width="80%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenBuildingShape" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">混凝土总用量</td>
                            <td colspan="4">
                                <asp:TextBox ID="ConcreteAmount" runat="server" style="width:89%;"></asp:TextBox> m³
                        <asp:CheckBox runat="server" ID="IsGreenConcreteAmount" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>每平方米混凝土折算厚度</td>
                            <td colspan="4">
                                <asp:TextBox ID="PerSqM_ConcreteReducedThickness" runat="server" Width="78%"></asp:TextBox> cm/㎡
                        <asp:CheckBox runat="server" ID="IsGreenPerSqM_ConcreteReducedThickness" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2" colspan="3">钢材总用量</td>                          
                            <td colspan="1">钢筋</td>
                            <td colspan="2">
                                <asp:TextBox ID="SteelAmount_rebar" runat="server" Style="width: 84%"></asp:TextBox> t
                            </td>

                            <td rowspan="2">每平方米<br />
                                钢材用量</td>                         
                            <td colspan="1">钢筋</td>
                            <td colspan="3">
                                <asp:TextBox ID="PerSqM_SteelAmount_rebar" runat="server" Style="width: 78%"></asp:TextBox> kg/㎡
                            </td>
                        </tr>
                        <tr>                         
                             <td colspan="1">型钢</td>
                            <td colspan="2">
                                <asp:TextBox ID="SteelAmount_SectionSteel" runat="server" Style="width: 84%"></asp:TextBox> t
                            </td>
                            <td colspan="1">型钢</td>
                            <td colspan="3">
                               <asp:TextBox ID="PerSqM_SteelAmount_SectionSteel" runat="server" Style="width: 78%"></asp:TextBox> kg/㎡
                            </td>                          
                        </tr>
                        <tr>
                            <td rowspan="13">抗<br />
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
                            <td rowspan="3">不<br />
                                考<br />
                                虑<br />
                                耦<br />
                                扭<br />
                                联<br />
                                转
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
                                <asp:TextBox ID="NoCoupling_H_Fek_Geq" runat="server" Style="width: 83%"></asp:TextBox> %
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
                                <asp:TextBox ID="NoCoupling_V_Fek_Geq" runat="server" Style="width: 83%"></asp:TextBox> %
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
                            <td rowspan="4">考<br />
                                虑<br />
                                耦<br />
                                扭<br />
                                转<br />
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
                           <%-- <td colspan="5" style="padding: 0">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 150px">地震作用最大方向：           
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="MaxActionDirection" runat="server" Style="width: 93.5%"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsGreenMaxActionDirection" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>--%>
                            <td>
                                地震作用最大方向
                            </td>  
                            <td colspan="4">
                                  <asp:TextBox ID="MaxActionDirection" runat="server" Style="width: 93.5%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                           <%-- <td colspan="10" style="padding: 0px;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 150px">时程分析程序名称：           
                                        </td>
                                        <td style="border-right: none">
                                            <asp:TextBox ID="TimeHistoryAnalysisProgramName" runat="server" Style="width: 96.6%"></asp:TextBox>
                                            <asp:CheckBox runat="server" ID="IsGreenTimeHistoryAnalysisProgramName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>--%>
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
                                <asp:TextBox ID="TimeHistory_Fek_Geq1" runat="server" Style="width: 82%"></asp:TextBox> %
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
                                <asp:TextBox ID="TimeHistory_Fek_Geq2" runat="server" Style="width: 82%"></asp:TextBox> %
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
                                <asp:TextBox ID="TimeHistory_Fek_Geq3" runat="server" Style="width: 82%"></asp:TextBox>
                                %
                        <asp:CheckBox runat="server" ID="IsGreenTimeHistory_Fek_Geq3" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>
                                <asp:TextBox ID="TimeHistory_U_h3" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTimeHistory_U_h3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">现浇混凝土采<br />
                                用预拌混凝土<br />
                                (是否)
                            </td>
                            <td colspan="3">
                                 <div class="DeclarationList">
                                <asp:DropDownList ID="ISReadyMixedConcrete" runat="server" Style="width: 90%"></asp:DropDownList></div> 
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtISReadyMixedConcrete" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenISReadyMixedConcrete" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="4">采用预拌砂浆比例
                            </td>
                            <td>
                                <asp:TextBox ID="ReadyMixedMortarRatio" runat="server" Style="width: 62%"></asp:TextBox>
                                %
                        <asp:CheckBox runat="server" ID="IsGreenReadyMixedMortarRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" rowspan="3">混凝土结构
                            </td>
                            <td colspan="7">400Mpa级及以上受力普通钢筋比例
                            </td>
                            <td>
                                <asp:TextBox ID="NormalSteelRatio" runat="server" Style="width: 62%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenNormalSteelRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>

                            <td colspan="7">C50混凝土用量占竖向承重结构中混凝土总量的比例
                            </td>
                            <td>
                                <asp:TextBox ID="C50ConcreteRatio" runat="server" Style="width: 62%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenC50ConcreteRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>

                            <td colspan="7">高耐久性混凝土占混凝土总量的比例
                            </td>
                            <td>
                                <asp:TextBox ID="HighDurabilityConcreteRatio" runat="server" Style="width: 62%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenHighDurabilityConcreteRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">钢结构
                            </td>
                            <td colspan="7">Q235及以上高强钢材用量占钢材总量的比例
                            </td>
                            <td>
                                <asp:TextBox ID="Q235SteelRatio" runat="server" Style="width: 62%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenQ235SteelRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td colspan="11" style="text-align: left;padding-left:10px;">结构专业设计主要特点：（不少于600字）</td>
                        </tr>
                        <tr>
                            <td colspan="11">
                                <asp:TextBox ID="StructureMainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width: 97%; height: 300px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenStructureMainFeatures" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="StructureMainFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_0404')" id="Save_0404">保存</a></div> 
                    <div style="text-align:center;margin-top:40px;">
                        <a onclick="javascript:onSave('Template_0404','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('05')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('05')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab6">
                <asp:Panel ID="panelPart_0405" runat="server" ClientIDMode="Static" GroupingText="专业技术指标（设备专业）"  >
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
                                <asp:TextBox ID="SpaceHeatingLoad" runat="server" Style="width: 82%"></asp:TextBox> kW
                        <asp:CheckBox runat="server" ID="IsGreenSpaceHeatingLoad" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>空调总冷负荷
                            </td>
                            <td>
                                <asp:TextBox ID="AirConCoolingLoad" runat="server" Style="width: 83%"></asp:TextBox> kW
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
                            <td colspan="3">供暖、空调末端装置可独立启停的主要功能房间数量比例
                            </td>
                            <td>
                                <asp:TextBox ID="IndependentRatio" runat="server" Style="width: 92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenIndependentRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">冷、热源机组能效指标比现行国家标准提高或降低幅度
                            </td>
                            <td>
                                <asp:TextBox ID="EnergyEfficiencyIndex" runat="server" Style="width: 92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenEnergyEfficiencyIndex" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">供暖、通风与空调系统能耗降低幅度
                            </td>
                            <td>
                                <asp:TextBox ID="EnergyConsumptionReductionRange" runat="server" Style="width: 92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenEnergyConsumptionReductionRange" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">由可再生能源提供的空调用冷量和热量比例
                            </td>
                            <td>
                                <asp:TextBox ID="RenewableEnergyForAirConRatio" runat="server" Style="width: 92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenRenewableEnergyForAirConRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">采用蓄冷蓄热系统（是/否）
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsUsingStorageSystem" runat="server" Style="width: 92%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsUsingStorageSystem" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsUsingStorageSystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">利用余热废热供给建筑蒸汽、供暖或生活热水需求（是/否）
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsUsingWasteHeat" runat="server" Style="width: 92%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsUsingWasteHeat" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsUsingWasteHeat" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">集中供暖系统热水循环泵的耗电输热比和通风空调系统风机的单<br />
                                位风量耗功率符合相关国家标准（是/否）
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsStandard" runat="server" Style="width: 92%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsStandard" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsStandard" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr class="isrequir">
                            <td colspan="3">空调冷热水系统循环水泵的耗电输冷（热）比<br />
                                比现行国家标准规定值降低的比率
                            </td>
                            <td>
                                <asp:TextBox ID="ConsumptionRatio" runat="server" Style="width: 86%;margin-bottom:5px;margin-left:7%;"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenConsumptionRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <b style="color:#FC7464;position:relative;top:3px;">*</b>
                              <br/>
                                <asp:TextBox ID="LowerThanStandardValueRatio" runat="server" Style="width: 86%;margin-left:7%;"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenLowerThanStandardValueRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>场地年径流总量控制率
                            </td>
                            <td>
                                <asp:TextBox ID="RunoffControlRate" runat="server" Style="width: 85%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenRunoffControlRate" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>非传统水源利用率
                            </td>
                            <td>
                                <asp:TextBox ID="NonTraditionalWaterUseRatio" runat="server" Style="width:86%;margin-left:7%;"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenNonTraditionalWaterUseRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>平均日用水量
                            </td>
                            <td>
                                <asp:TextBox ID="DailyWaterConsumption" runat="server" Style="width: 85%"></asp:TextBox> /d
                        <asp:CheckBox runat="server" ID="IsGreenDailyWaterConsumption" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>用水点供水压力
                            </td>
                            <td>
                                <asp:TextBox ID="WaterSupplyPressure" runat="server" Style="width: 80%;margin-left:5px;"></asp:TextBox> MPa
                        <asp:CheckBox runat="server" ID="IsGreenWaterSupplyPressure" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>卫生器具用水效率等级
                            </td>
                            <td>
                                <asp:TextBox ID="WaterEfficiencyRatingForSanitary" runat="server" Style="width: 85%"></asp:TextBox> 级
                        <asp:CheckBox runat="server" ID="IsGreenWaterEfficiencyRatingForSanitary" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>分类设置用水计量装置<br />
                                （是/否）
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsClassifyMeterage" runat="server" Style="width: 90%"></asp:DropDownList></div> 
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsClassifyMeterage" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsClassifyMeterage" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>绿化灌溉系统类别
                            </td>
                            <td>
                                <asp:TextBox ID="GreeningIrrigationSystemType" runat="server" Style="width: 88%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenGreeningIrrigationSystemType" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>由可再生能源提供的生<br />
                                活用热水比例
                            </td>
                            <td>
                                <asp:TextBox ID="RenewableEnergyForLivingHotWater" runat="server" Style="width: 86%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenRenewableEnergyForLivingHotWater" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>相关节水技术或措施
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="WaterSavingTechnology" runat="server" Style="width: 97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenWaterSavingTechnology" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4" style="text-align:left;padding-left:10px;">设备专业设计主要特点：</td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:TextBox ID="MechanicalMainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width: 98%; height: 300px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenMechanicalMainFeatures" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="MechanicalMainFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>                
                    <div style="display:none"><a onclick="javascript:onSave('Template_0405')" id="Save_0405">保存</a></div> 
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0405','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('06')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('06')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab7">
                <asp:Panel ID="panelPart_0406" runat="server" ClientIDMode="Static" GroupingText="专业技术指标（电气专业）"  >
                    <table>
                        <tr>
                            <td>动力总电负荷
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="PowerTotalElectricLoad" runat="server" Style="width: 83%"></asp:TextBox> kW
                        <asp:CheckBox runat="server" ID="IsGreenPowerTotalElectricLoad" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td> 
                            <td style="width:150px;">照明总电负荷
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
                                <asp:TextBox ID="DesignOfPowerSupply" runat="server" Style="width: 83%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenDesignOfPowerSupply" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>变压器装机台数
                            </td>
                            <td>
                                <asp:TextBox ID="TransformerInstalledNumber" runat="server" Style="width: 80%"></asp:TextBox> 台
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
                            <td>用电负荷等级确定情况
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="PowerLoadLevel" runat="server" Style="width: 96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenPowerLoadLevel" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>变压器装置指标
                            </td>
                            <td  colspan="2">
                                <asp:TextBox ID="TransformerIndex" runat="server" Style="width: 75%"></asp:TextBox> W/㎡
                        <asp:CheckBox runat="server" ID="IsGreenTransformerIndex" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>低压供电半径
                            </td>
                            <td>不大于 <asp:TextBox ID="LowVoltagePowerSupplyRadius" runat="server" Style="width: 57%"></asp:TextBox> m                      
                        <asp:CheckBox runat="server" ID="IsGreenLowVoltagePowerSupplyRadius" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>三相配电变压器能效等级
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="TransformerEnergyEfficiencyRating" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenTransformerEnergyEfficiencyRating" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                级能效
                            </td>
                            <td>电源侧功率因数
                            </td>
                            <td>
                                <asp:TextBox ID="PowerFactor" runat="server" Style="width: 86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenPowerFactor" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>主要谐波源
                            </td>
                            <td  colspan="2">
                                <asp:TextBox ID="HarmonicSource" runat="server" Style="width: 75%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenHarmonicSource" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>谐波治理措施
                            </td>
                            <td>
                                <asp:TextBox ID="HarmonicControl" runat="server" Style="width: 86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenHarmonicControl" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                            <td rowspan="3">照明功率密度值
                            </td>
                            <td colspan="3">所有区域均达到现行值(是/否)
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsAllAreasReachCurrentValue" runat="server" Style="width: 87%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsAllAreasReachCurrentValue" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsAllAreasReachCurrentValue" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">主要功能房间达到目标值(是/否)
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsMainRoomAchieveTargetValue" runat="server" Style="width: 87%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsMainRoomAchieveTargetValue" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsMainRoomAchieveTargetValue" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">所有区域均达到目标值(是/否)
                            </td>
                            <td>
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsAllAreasAchieveTargetValue" runat="server" Style="width: 87%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsAllAreasAchieveTargetValue" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsAllAreasAchieveTargetValue" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="4">主要照明灯具的效率
                            </td>
                            <td>灯具名称
                            </td>
                            <td>灯具效率
                            </td>
                            <td rowspan="2">显色指数<br />
                                是否全部<br />
                                达标
                            </td>
                            <td rowspan="2">
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsColorRenderingIndexUpToStandard" runat="server" Style="width: 87%"></asp:DropDownList></div>
                                <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsColorRenderingIndexUpToStandard" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsColorRenderingIndexUpToStandard" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="LampName1" runat="server" Style="width: 84%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenLampName1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="LampEfficiency1" runat="server" Style="width: 77%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenLampEfficiency1" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="LampName2" runat="server" Style="width: 84%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenLampName2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="LampEfficiency2" runat="server" Style="width: 77%"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenLampEfficiency2" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td rowspan="2">眩光值<br />
                                是否全部<br />
                                达标
                            </td>
                            <td rowspan="2">
                                <div class="DeclarationList">
                                <asp:DropDownList ID="IsGlareValueUpToStandard" runat="server" Style="width: 87%"></asp:DropDownList></div>
                                 <div class="ExpertReviewList" style="display: none">
                                    <asp:TextBox ID="txtIsGlareValueUpToStandard" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsGreenIsGlareValueUpToStandard" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="LampName3" runat="server" Style="width: 84%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenLampName3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="LampEfficiency3" runat="server" Style="width: 77%"></asp:TextBox>
                                %
                        <asp:CheckBox runat="server" ID="IsGreenLampEfficiency3" ClientIDMode="Static" ToolTip="公开" Checked="true" />

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
                            <td>采用独立分项计量
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="IndependentComponentMeasurement" runat="server" Style="width: 96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenIndependentComponentMeasurement" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                            <td>室内空气质量监控系统方式
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="IndoorAirQualityMonitoringSystem" runat="server" Style="width: 96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenIndoorAirQualityMonitoringSystem" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>由可再生能源提供的电量比例
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="RenewableEnergySourcesRatio" runat="server" Style="width: 94%;"></asp:TextBox> %
                        <asp:CheckBox runat="server" ID="IsGreenRenewableEnergySourcesRatio" ClientIDMode="Static" ToolTip="公开" Checked="true" />

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
                            <td colspan="5" style="text-align:left;padding-left:10px;">电气专业设计主要特点：</td>
                        </tr>
                        <tr>
                            <td colspan="5">
                                <asp:TextBox ID="ElectricalMainFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width: 97%; height: 300px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenElectricalMainFeatures" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="ElectricalMainFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_0406')" id="Save_0406">保存</a></div> 
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0406','Save')" class="btnt">保 &nbsp; &nbsp; 存</a>
                        <a onclick="javascript:onPrev('07')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('07')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab8">
                <asp:Panel ID="panelPart_0407" runat="server" ClientIDMode="Static" GroupingText="专业技术指标（技术经济指标）"  >
                    <table>
                        <tr>
                            <td>单位规模建筑面积指标
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="width: 75%; border-right: none;">
                                            <asp:TextBox ID="UnitAreaIndicators" runat="server" Style="width: 70%"></asp:TextBox> ㎡/ 
                                              <asp:TextBox ID="UnitAreaIndicatorsUnit" runat="server" Style="width: 10%; margin-left: 0px;"></asp:TextBox> 
                                        </td>                                                                    
                                            <asp:CheckBox runat="server" ID="IsGreenUnitAreaIndicatorsUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />                                     
                                    </tr>
                                </table>
                            </td>
                            <td>使用面积系数
                            </td>
                            <td>
                                <asp:TextBox ID="UseAreaCoefficient" runat="server" Style="width: 77%;margin-left: -6%;"></asp:TextBox>  %
                               
                        <asp:CheckBox runat="server" ID="IsGreenUseAreaCoefficient" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积耗热
                        量指标
                            </td>
                            <td>
                                <asp:TextBox ID="UnitAreaHotConsumption" runat="server" Width="73%"></asp:TextBox> W/㎡
                        <asp:CheckBox runat="server" ID="IsGreenUnitAreaHotConsumption" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>单位建筑面积耗
                        冷量指标
                            </td>
                            <td>
                                <asp:TextBox ID="UnitAreaColdConsumption" runat="server" Width="77%"></asp:TextBox> W/㎡
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
                                <asp:TextBox ID="DailyWaterSupply" runat="server" Width="77%"></asp:TextBox> m³/日
                        <asp:CheckBox runat="server" ID="IsGreenDailyWaterSupply" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>建筑总能耗
                            </td>
                            <td>
                                <asp:TextBox ID="ConstructionTotalEnergyConsumption" runat="server" Width="73%"></asp:TextBox> MJ/a
                        <asp:CheckBox runat="server" ID="IsGreenConstructionTotalEnergyConsumption" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>单位面积能耗
                            </td>
                            <td>
                                <asp:TextBox ID="UnitAreaEnergyConsumption" runat="server" Style="width: 74%;margin-left:5%;"></asp:TextBox> kWh/㎡a
                        <asp:CheckBox runat="server" ID="IsGreenUnitAreaEnergyConsumption" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>年用水总量
                            </td>
                            <td>
                                <asp:TextBox ID="PerYearTotalWaterConsumption" runat="server" Width="73%"></asp:TextBox> M³/a
                        <asp:CheckBox runat="server" ID="IsGreenPerYearTotalWaterConsumption" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>年节水量
                            </td>
                            <td>
                                <asp:TextBox ID="PerYearWaterSaving" runat="server" Style="width: 77%;margin-left:-7%;"></asp:TextBox>&nbsp;    t
                        <asp:CheckBox runat="server" ID="IsGreenPerYearWaterSaving" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>年节电量
                            </td>
                            <td>
                                <asp:TextBox ID="PerYearPowerSaving" runat="server" Style="width: 73%;margin-left:8%;"></asp:TextBox> 万kWh/a
                        <asp:CheckBox runat="server" ID="IsGreenPerYearPowerSaving" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>年节煤量
                            </td>
                            <td>
                                <asp:TextBox ID="PerYearCoalSaving" runat="server" Style="width: 77%;margin-left:-4%;"></asp:TextBox>
                                tce
                        <asp:CheckBox runat="server" ID="IsGreenPerYearCoalSaving" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>每年减排二氧化碳
                            </td>
                            <td colspan="3" >
                                <asp:TextBox ID="PerYaerCarbonEmissionReduction" runat="server" Width="91%"></asp:TextBox>
                                   &nbsp;t
                        <asp:CheckBox runat="server" ID="IsGreenPerYaerCarbonEmissionReduction" ClientIDMode="Static" ToolTip="公开" Checked="true" />

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
                                            <asp:TextBox ID="Estimate_RMB" runat="server" Width="75%"></asp:TextBox> 万元
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
                                            <asp:TextBox ID="Settlement_RMB" runat="server" Width="71%"></asp:TextBox>  万元
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
                                            <asp:TextBox ID="Estimate_ForeignCurrency" runat="server" Width="75%"></asp:TextBox> 美元
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
                                            <asp:TextBox ID="Settlement_ForeignCurrency" runat="server" Width="69%"></asp:TextBox> 万美元
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
                                            <asp:TextBox ID="Estimate_CivilEngineering" runat="server" Width="75%"></asp:TextBox>  %
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
                                            <asp:TextBox ID="Settlement_CivilEngineering" runat="server" Width="72%"></asp:TextBox>  %
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
                                            <asp:TextBox ID="Estimate_Install" runat="server" Width="75%"></asp:TextBox>  %
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
                                            <asp:TextBox ID="Settlement_Install" runat="server" Width="72%"></asp:TextBox>  %
                                    <asp:CheckBox runat="server" ID="IsGreenSettlement_Install" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>单位建筑面积<br />
                                造价
                            </td>
                            <td>
                                <asp:TextBox ID="Estimate_PerUnitAreaRMB" runat="server" Width="81%"></asp:TextBox> 元/㎡
                        <asp:CheckBox runat="server" ID="IsGreenEstimate_PerUnitAreaRMB" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>单位建筑面积<br />
                                造价
                            </td>
                            <td>
                                <asp:TextBox ID="Settlement_OneUnitAreaRMB" runat="server" Width="81%"></asp:TextBox> 元/㎡
                        <asp:CheckBox runat="server" ID="IsGreenSettlement_OneUnitAreaRMB" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>单位规模造价
                            </td>
                            <td style="padding: 0;">
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="border-right:none;">
                                            <asp:TextBox ID="Estimate_PerUnitScaleRMB" runat="server" Width="70%"></asp:TextBox> 元/ 
                                             <asp:TextBox ID="Estimate_PerUnitScaleRMBUnit" runat="server" Style="margin-left: 0; width: 10%;"></asp:TextBox>
                                        </td>                                       
                                            <asp:CheckBox runat="server" ID="IsGreenEstimate_PerUnitScaleRMBUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />                                     
                                    </tr>
                                </table>
                            </td>
                            <td>单位规模造价
                            </td>
                            <td>
                                <table style="width: 100%; height: 100%;">
                                    <tr>
                                        <td style="border-right: none;">
                                             <asp:TextBox ID="Settlement_OneUnitScaleRMB" runat="server" Width="70%"></asp:TextBox> 元/
                                              <asp:TextBox ID="Settlement_OneUnitScaleRMBUnit" runat="server" Style="margin-left: 0; width: 10%;"></asp:TextBox>
                                        </td>                                                                           
                                            <asp:CheckBox runat="server" ID="IsGreenSettlement_OneUnitScaleRMBUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />                                 
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>绿色建筑增量<br />
                                成本
                            </td>
                            <td>
                                <asp:TextBox ID="Estimate_IncrementalCost" runat="server" Width="72%"></asp:TextBox> 元/㎡
                        <asp:CheckBox runat="server" ID="IsGreenEstimate_IncrementalCost" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                            <td>绿色建筑增量<br />
                                成本
                            </td>
                            <td>
                                <asp:TextBox ID="Settlement_IncrementalCost" runat="server" Width="73%"></asp:TextBox> 元/㎡
                        <asp:CheckBox runat="server" ID="IsGreenSettlement_IncrementalCost" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
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
                            <td colspan="4" style="text-align:left;padding-left:10px;">
                                经济专业主要特点：（不少于100字）
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <asp:TextBox ID="EconomicsFeatures" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenEconomicsFeatures" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="EconomicsFeaturesTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>                
                    <div style="display:none"><a onclick="javascript:onSave('Template_0407')" id="Save_0407">保存</a></div> 
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0407','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('08')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('08')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 
           <%-- <div class="tab-pane " id="btab9">
                <asp:Panel ID="panelPart_0408" runat="server" ClientIDMode="Static" GroupingText="审核意见">
                    <table>
                        <tr>
                            <td style="width:150px; padding:25px;">
                                曾获奖项
                            </td>
                            <td>
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 200px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenAwards" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                <%--<script id="AwardsTextBox" type="text/plain" style=" height: 300px;"></script>--%>
                           <%-- </td> 
                        </tr>
                        <tr>
                            <td>
                                申报单位<br />
                                意    见
                            </td>
                            <td>
                                <asp:TextBox ID="CompanyOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 200px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenCompanyOpinion" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                <%--<script id="CompanyOpinionTextBox" type="text/plain" style=" height: 300px;"></script>--%>
                               <%-- <div class="datepicker input-group date" style="margin:0px auto">
                                    <asp:TextBox ID="CompanyOpinionDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择日期" ></asp:TextBox>
                                    <span class="input-group-addon" style="width:55px;text-align:left;">　<i class="fa fa-calendar" aria-hidden="true"></i></span>                                       
                                </div>
                            </td> 
                        </tr>
                        <tr>
                            <td>
                                地方、部门勘察设计同业协会<br />
                                推荐意见
                            </td>
                            <td>
                                <asp:TextBox ID="AssociationOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 95%; height: 200px;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsGreenAssociationOpinion" ClientIDMode="Static" ToolTip="公开" Checked="true" />--%>
                                <%--<script id="AssociationOpinionTextBox" type="text/plain" style=" height: 300px;"></script>--%>
                              <%--  <div class="datepicker input-group date" style="margin:0px auto">
                                    <asp:TextBox ID="AssociationOpinionDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择日期" ></asp:TextBox>
                                    <span class="input-group-addon" style="width:55px;text-align:left;">　<i class="fa fa-calendar" aria-hidden="true"></i></span>                                       
                                </div>
                            </td> 
                        </tr> 
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_0408')" id="Save_0408">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0408','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('09')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('09')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div> 
                </asp:Panel> 
            </div>--%>
            <div class="tab-pane" id="btab9">
              <uc:Appendix runat="server" id="Appendix"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab10">
              <uc:LegalStates runat="server" id="ucLegalStates"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab11">
              <uc:Certificate runat="server" id="ucCertificate"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab12">
              <uc:Comments runat="server" id="ucComments"></uc:Comments>
            </div>  
        </div>
    </div> 
     
  <script type="text/javascript">
      $('#ProfessionalCategories').ui_choose();
      $('#IsNoiseLevelQualified').ui_choose();      
      $('#SoundInsulation').ui_choose();
      $('#IsIntegratedDesign').ui_choose();
      $('#ISReadyMixedConcrete').ui_choose();
      $('#IsClassifyMeterage').ui_choose();

      $('#IsUsingStorageSystem').ui_choose();
      $('#IsUsingWasteHeat').ui_choose();
      $('#IsStandard').ui_choose();
      $('#IsAllAreasReachCurrentValue').ui_choose();
      $('#IsMainRoomAchieveTargetValue').ui_choose();

      $('#IsAllAreasAchieveTargetValue').ui_choose();
      $('#IsColorRenderingIndexUpToStandard').ui_choose();
      $('#IsGlareValueUpToStandard').ui_choose();
      //1
      switch ($('#IsNoiseLevelQualified').val()) {
          case "2901":
              $('#txtIsNoiseLevelQualified').val("是");
              break;
          case "2902":
              $('#txtIsNoiseLevelQualified').val("否");
              break;
      }
      //2
      switch ($('#SoundInsulation').val()) {
          case "3001":
              $('#txtSoundInsulation').val("高");
              break;
          case "3002":
              $('#txtSoundInsulation').val("低");
              break;
      }
      //3
      switch ($('#IsIntegratedDesign').val()) {
          case "2901":
              $('#txtIsIntegratedDesign').val("是");
              break;
          case "2902":
              $('#txtIsIntegratedDesign').val("否");
              break;
      }
      //4
      switch ($('#ISReadyMixedConcrete').val()) {
          case "2901":
              $('#txtISReadyMixedConcrete').val("是");
              break;
          case "2902":
              $('#txtISReadyMixedConcrete').val("否");
              break;
      }
      //5
      switch ($('#IsClassifyMeterage').val()) {
          case "2901":
              $('#txtIsClassifyMeterage').val("是");
              break;
          case "2902":
              $('#txtIsClassifyMeterage').val("否");
              break;
      }
      //6
      switch ($('#IsUsingStorageSystem').val()) {
          case "2901":
              $('#txtIsUsingStorageSystem').val("是");
              break;
          case "2902":
              $('#txtIsUsingStorageSystem').val("否");
              break;
      }
      //7
      switch ($('#IsUsingWasteHeat').val()) {
          case "2901":
              $('#txtIsUsingWasteHeat').val("是");
              break;
          case "2902":
              $('#txtIsUsingWasteHeat').val("否");
              break;
      }
      //8
      switch ($('#IsStandard').val()) {
          case "2901":
              $('#txtIsStandard').val("是");
              break;
          case "2902":
              $('#txtIsStandard').val("否");
              break;
      }
      //9
      switch ($('#IsAllAreasReachCurrentValue').val()) {
          case "2901":
              $('#txtIsAllAreasReachCurrentValue').val("是");
              break;
          case "2902":
              $('#txtIsAllAreasReachCurrentValue').val("否");
              break;
      }
      //10
      switch ($('#IsMainRoomAchieveTargetValue').val()) {
          case "2901":
              $('#txtIsMainRoomAchieveTargetValue').val("是");
              break;
          case "2902":
              $('#txtIsMainRoomAchieveTargetValue').val("否");
              break;
      }
      //11
      switch ($('#IsAllAreasAchieveTargetValue').val()) {
          case "2901":
              $('#txtIsAllAreasAchieveTargetValue').val("是");
              break;
          case "2902":
              $('#txtIsAllAreasAchieveTargetValue').val("否");
              break;
      }
      //12
      switch ($('#IsColorRenderingIndexUpToStandard').val()) {
          case "2901":
              $('#txtIsColorRenderingIndexUpToStandard').val("是");
              break;
          case "2902":
              $('#txtIsColorRenderingIndexUpToStandard').val("否");
              break;
      }
      //13
      switch ($('#IsGlareValueUpToStandard').val()) {
          case "2901":
              $('#txtIsGlareValueUpToStandard').val("是");
              break;
          case "2902":
              $('#txtIsGlareValueUpToStandard').val("否");
              break;
      }

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
          $("#ProjectOverview").val(EncodeUEditorContent(UE.getEditor('ProjectOverviewTextBox').getContent()));                     // 项目概况
          $("#KeyTechnology").val(EncodeUEditorContent(UE.getEditor('KeyTechnologyTextBox').getContent()));                         // 关键绿色策略与技术
          $("#Effect").val(EncodeUEditorContent(UE.getEditor('EffectTextBox').getContent()));                                       // 技术成效与深度
          $("#Benefit").val(EncodeUEditorContent(UE.getEditor('BenefitTextBox').getContent()));                                     // 综合效益
          $("#ArchitectureMainFeatures").val(EncodeUEditorContent(UE.getEditor('ArchitectureMainFeaturesTextBox').getContent()));   // 建筑专业设计主要特点
          $("#StructureMainFeatures").val(EncodeUEditorContent(UE.getEditor('StructureMainFeaturesTextBox').getContent()));         // 结构专业设计主要特点
          $("#MechanicalMainFeatures").val(EncodeUEditorContent(UE.getEditor('MechanicalMainFeaturesTextBox').getContent()));       // 设备专业设计主要特点
          $("#ElectricalMainFeatures").val(EncodeUEditorContent(UE.getEditor('ElectricalMainFeaturesTextBox').getContent()));       // 电气专业设计主要特点
          $("#EconomicsFeatures").val(EncodeUEditorContent(UE.getEditor('EconomicsFeaturesTextBox').getContent()));                 // 经济专业主要特点
          $("#Awards").val(EncodeUEditorContent(UE.getEditor('AwardsTextBox').getContent()));                                       // 曾获奖项
         // $("#CompanyOpinion").val(EncodeUEditorContent(UE.getEditor('CompanyOpinionTextBox').getContent()));                       // 申报单位意见
         // $("#AssociationOpinion").val(EncodeUEditorContent(UE.getEditor('AssociationOpinionTextBox').getContent()));               // 方、部门勘察设计同业协会意见

          if (!checkUEditor('ProjectOverviewTextBox')
                || !checkUEditor('KeyTechnologyTextBox')
                || !checkUEditor('EffectTextBox')
                || !checkUEditor('BenefitTextBox')
                || !checkUEditor('ArchitectureMainFeaturesTextBox')
                || !checkUEditor('StructureMainFeaturesTextBox')
                || !checkUEditor('MechanicalMainFeaturesTextBox')
                || !checkUEditor('ElectricalMainFeaturesTextBox')
                || !checkUEditor('EconomicsFeaturesTextBox')
                || !checkUEditor('AwardsTextBox')
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
          SetCollaborationInfo();
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
          //                        $("#CollaborativePhase2_" + ee).val("○");
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
          //                        $("#CollaborativePhase3_" + ee).val("○");
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
          //                        $("#CollaborativePhase4_" + ee).val("○");
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
          //                        $("#CollaborativePhase5_" + ee).val("○");
          //                    }
          //                }
          //            }
          //        }
          //    },
          //});
      }

      $(function () {
          SetCollaborationInfo();
          notBackspace();
          // 富文本框
          InitUEditor('ProjectOverviewTextBox', 500);           // 项目概况
          InitUEditor('KeyTechnologyTextBox', 1500);            // 关键绿色策略与技术
          InitUEditor('EffectTextBox', 1500);                   // 技术成效与深度
          InitUEditor('BenefitTextBox', 500);                   // 综合效益
          InitUEditor('ArchitectureMainFeaturesTextBox', 500);  // 建筑专业设计主要特点
          InitUEditor('StructureMainFeaturesTextBox', 600);     // 结构专业设计主要特点
          InitUEditor('MechanicalMainFeaturesTextBox', 2000);   // 设备专业设计主要特点
          InitUEditor('ElectricalMainFeaturesTextBox', 2000);   // 电气专业设计主要特点
          InitUEditor('EconomicsFeaturesTextBox', 2000);        // 经济专业主要特点
          InitUEditor('AwardsTextBox', 2000);                   // 曾获奖项
          //InitUEditor('CompanyOpinionTextBox', 2000);           // 申报单位意见
         // InitUEditor('AssociationOpinionTextBox', 2000);       // 地方、部门勘察设计同业协会

          ////设置cookie初始值
          addCookie('TabId', 'tab_01', 1);

          //重置附件顺序
          $("#AppendixPrev").click(function () {
              onPrev("9");
          });
          $("#AppendixNext").click(function () {
              onNext("9");
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
              //    //$("#Save_0401").click();
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
              //} else {
              //    n = parseInt(n) - 1;
              //    //$("#Save_04" + preZeroFill(n, 2)).click();
              //}              
              //点击存储本次Tab的ID
              addCookie('TabId', $(this).attr("id"), 1);
          });        
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
              $("#" +CollaborativePhase).multipleSelect("uncheckAll");
          }
      }

      for (d = 2; d < 5; d++)
      {
          if ($("#CooperativeUnit"+d).val() == "") {
              $("#CooperativeUnit"+d).attr('disabled', true);
          }
          if ($("#CollaborativePhase"+d).val() == "") {
              $("#CollaborativePhase0"+d).attr('disabled', true);
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


