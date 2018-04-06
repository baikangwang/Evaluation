<%@ Page Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="CivilAirDefence_V2.aspx.cs" Inherits="Evaluation.View.Declaration.CivilAirDefence_V2" validateRequest="false" %>

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
      
        #ContentPlaceHolder1_LegalStates_TextBox273{
            margin-left: 28px;
            width: 56%;
            
        }
        #GroundLayer_Less6,#UndergroundLayer_Less6,#Height_Less6,#Count_Less6{
            float:none;
        }
        #edui1_iframeholder{
            height:300px;
        }
        #btn_018Prev{
            margin-left: 43%;
            margin-top:40px; 
        }
        #AcceptanceDepartment{
            float:none!important; margin-left:4px;
        }
        #ProjectOverviewTextBox,
        #TechnologyFeatureTextBox,
        #EffectTextBox,
        #BenefitTextBox,
        #Indicators_ConstructTextBox,
        #Indicators_StructureTextBox,
        #Indicators_HVACTextBox,
        #Indicators_SupplyAndDrainageTextBox,
        #Indicators_ElectricTextBox,
        #Indicators_AntichemicalTextBox{
            width:77%;text-align:left;margin-left:10px;
        }
      
        #content #test{
            height:2500px!important;
        }
        #tab{
            margin-top:-20px;
        }
        #AwardsTextBox,#UnitOpinionTextBox,#RecommendOpinionTextBox{
             width:79%;  text-align:left;margin-left:10px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display:none"><asp:TextBox ID="txtSituation" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox ID="txtUser" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox ID="txtDeclarationID" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <div style="display:none"><asp:TextBox ID="txtTemplate" runat="server" ClientIDMode="Static"></asp:TextBox></div>
    <ul class="navs">
        <li class="nav1" style="float: left; padding-right: 5px;">
            <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=100000" id="nav02" runat="server" clientidmode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
        </li>
    </ul>
    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、申报内容</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、附件目录</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、法人声明</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、合作声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab" class="ExpertReviewList2" style="display: none;">7、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_1001" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
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
                            <td style="margin-left:2.5%;">
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
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsCivilAirDefenceAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>

                        </tr>
                        <tr>
                            <td>
                                验收部门
                            </td> 
                            <td colspan="4">
                                <asp:TextBox ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                            </td> 
                        </tr> 
                        <tr>
                            <td>申报单位<br />通讯地址
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox ID="IsCivilAirDefencePostalAddress" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                单位资质
                            </td>
                            <td>
                                <asp:TextBox ID="Qualification" runat="server" ClientIDMode="Static" Width="87%"></asp:TextBox>
                            </td>
                            <td>
                                证书编号
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
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1001')" id="Save_1001">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1001','Save')" class="btnt">保 &nbsp;&nbsp;存</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane " id="btab2">
                <uc:Participant runat="server" ID="ucParticipant"></uc:Participant>
            </div>
            <div class="tab-pane " id="btab3">
                <asp:Panel ID="panelPart_1002" runat="server" ClientIDMode="Static" GroupingText="技术申报内容">
                    <table id="tab">
                        <tr>
                            <td colspan="2" style="border: 0;">
                                <h3>人防工程设计项目特点</h3>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td style="padding:10px;">项目概况
                            </td>
                            <td>
                                <p>（项目总体介绍、项目规模、影响程度等，限500字）</p>
                                <asp:TextBox ID="ProjectOverview" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsCivilAirDefenceProjectOverview" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="ProjectOverviewTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td style="width: 20%">技术特色
                            </td>
                            <td>
                                <p>（技术特色，主要的技术成果指标水平，限1500字）</p>
                                <asp:TextBox ID="TechnologyFeature" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsCivilAirDefenceTechnologyFeature" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="TechnologyFeatureTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td style="width: 20%">技术成效<br />
                                与深度
                            </td>
                            <td>
                                <p>（解决技术难题、工程问题的成效与深度，限1500字）</p>
                                <asp:TextBox ID="Effect" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsCivilAirDefenceEffect" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="EffectTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td style="width: 20%">综合效益
                            </td>
                            <td>
                                <p>（项目产生的经济、社会、环境效益，限500字）</p>
                                <asp:TextBox ID="Benefit" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsCivilAirDefenceBenefit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="BenefitTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="border: 0;">
                                <h3>技术指标及先进性</h3>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td style="width: 20%">建筑专业
                            </td>
                            <td>
                                <p>（限800字）</p>
                                <asp:TextBox ID="Indicators_Construct" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsCivilAirDefenceIndicators_Construct" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="Indicators_ConstructTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td style="width: 20%">结构专业
                            </td>
                            <td>
                                 <p>（限600字）</p>
                                <asp:TextBox ID="Indicators_Structure" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsCivilAirDefenceIndicators_Structure" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="Indicators_StructureTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td style="width: 20%">暖通空调专业
                            </td>
                            <td>
                                <p>（限600字）</p>
                                <asp:TextBox ID="Indicators_HVAC" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsCivilAirDefenceIndicators_HVAC" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="Indicators_HVACTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td style="width: 20%">给排水专业
                            </td>
                            <td>
                                <p>（限600字）</p>
                                <asp:TextBox ID="Indicators_SupplyAndDrainage" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsCivilAirDefenceIndicators_SupplyAndDrainage" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="Indicators_SupplyAndDrainageTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td style="width: 20%">电气专业
                            </td>
                            <td>
                                <p>（限600字）</p>
                                <asp:TextBox ID="Indicators_Electric" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsCivilAirDefenceIndicators_Electric" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="Indicators_ElectricTextBox" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr style="height: 200px;">
                            <td style="width: 20%">防护和防化专业
                            </td>
                            <td>
                                <p>（限600字）</p>
                                <asp:TextBox ID="Indicators_Antichemical" runat="server" TextMode="MultiLine" Style="width: 97%; height: 100%;"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsCivilAirDefenceIndicators_Antichemical" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="Indicators_AntichemicalTextBox" style=" height: 300px;"></script>
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
                            <td>
                                曾获奖项
                            </td>
                            <td>
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="AwardsTextBox" type="text/plain" style="height: 300px;"></script>
                            </td> 
                        </tr>
                        <tr>
                            <td>
                                申报单位<br />意   见
                            </td>
                            <td>
                                <asp:TextBox ID="UnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="UnitOpinionTextBox" type="text/plain" style="height: 300px;"></script>
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
                    <div style="display: none"><a onclick="javascript:onSave('Template_1002')" id="Save_1002">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1002','Save')" class="btnt">保 &nbsp;&nbsp;存</a>
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane " id="btab4">
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
      $('#ProfessionalCategories').ui_choose();
      for (i = 1; i < 16; i++) {
          if ($("#ParticipantName" + i).val() == "") {
              $("#IDNumber" + i).attr('disabled', true);
          }
      }
      //重置附件顺序
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
          var selectPrize1 = $("#CollaborativePhase01").multipleSelect("getSelects").toString();
          var selectPrize2 = $("#CollaborativePhase02").multipleSelect("getSelects").toString();
          var selectPrize3 = $("#CollaborativePhase03").multipleSelect("getSelects").toString();
          var selectPrize4 = $("#CollaborativePhase04").multipleSelect("getSelects").toString();

          $("#CollaborativePhase1").val(selectPrize1);
          $("#CollaborativePhase2").val(selectPrize2);
          $("#CollaborativePhase3").val(selectPrize3);
          $("#CollaborativePhase4").val(selectPrize4);

          // 富文本框取值
          $("#ProjectOverview").val(EncodeUEditorContent(UE.getEditor('ProjectOverviewTextBox').getContent()));                           // 项目概况
          $("#TechnologyFeature").val(EncodeUEditorContent(UE.getEditor('TechnologyFeatureTextBox').getContent()));                         // 技术特色
          $("#Effect").val(EncodeUEditorContent(UE.getEditor('EffectTextBox').getContent()));                                               // 技术成效与深度
          $("#Benefit").val(EncodeUEditorContent(UE.getEditor('BenefitTextBox').getContent()));                                                 // 综合效益
          $("#Indicators_Construct").val(EncodeUEditorContent(UE.getEditor('Indicators_ConstructTextBox').getContent()));                        // 建筑专业
          $("#Indicators_Structure").val(EncodeUEditorContent(UE.getEditor('Indicators_StructureTextBox').getContent()));                         // 结构专业
          $("#Indicators_HVAC").val(EncodeUEditorContent(UE.getEditor('Indicators_HVACTextBox').getContent()));                                  // 暖通空调专业
          $("#Indicators_SupplyAndDrainage").val(EncodeUEditorContent(UE.getEditor('Indicators_SupplyAndDrainageTextBox').getContent()));        // 给排水专业
          $("#Indicators_Electric").val(EncodeUEditorContent(UE.getEditor('Indicators_ElectricTextBox').getContent()));                         // 电气专业
          $("#Indicators_Antichemical").val(EncodeUEditorContent(UE.getEditor('Indicators_AntichemicalTextBox').getContent()));               // 防护和防化专业
          $("#Awards").val(EncodeUEditorContent(UE.getEditor('AwardsTextBox').getContent()));
          $("#UnitOpinion").val(EncodeUEditorContent(UE.getEditor('UnitOpinionTextBox').getContent()));
          $("#RecommendOpinion").val(EncodeUEditorContent(UE.getEditor('RecommendOpinionTextBox').getContent()));
          if (!checkUEditor('ProjectOverviewTextBox')
                || !checkUEditor('TechnologyFeatureTextBox')
                || !checkUEditor('EffectTextBox')
                || !checkUEditor('BenefitTextBox')
                || !checkUEditor('Indicators_ConstructTextBox')
                || !checkUEditor('Indicators_StructureTextBox')
                || !checkUEditor('Indicators_HVACTextBox')
                || !checkUEditor('Indicators_SupplyAndDrainageTextBox')
                || !checkUEditor('Indicators_ElectricTextBox')
                || !checkUEditor('Indicators_AntichemicalTextBox')
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
          SetCollaborationInfo();
      }
     
      $(function () {
          SetCollaborationInfo();
          notBackspace();
          // 富文本框
          InitUEditor('ProjectOverviewTextBox', 500);              // 项目概况
          InitUEditor('TechnologyFeatureTextBox', 1500);            // 技术特色
          InitUEditor('EffectTextBox', 1500);                       // 技术成效与深度
          InitUEditor('BenefitTextBox', 500);                      // 综合效益
          InitUEditor('Indicators_ConstructTextBox', 800);         // 建筑专业
          InitUEditor('Indicators_StructureTextBox', 600);         // 结构专业
          InitUEditor('Indicators_HVACTextBox', 600);              // 暖通空调专业
          InitUEditor('Indicators_SupplyAndDrainageTextBox', 600); // 给排水专业
          InitUEditor('Indicators_ElectricTextBox', 600);          // 电气专业
          InitUEditor('Indicators_AntichemicalTextBox',600);      // 防护和防化专业
          InitUEditor('AwardsTextBox', 1000);
          InitUEditor('UnitOpinionTextBox', 1000);
          InitUEditor('RecommendOpinionTextBox', 1000);

          //保存上个pannel编辑内容
         $("#tabfather li a[data-toggle='tab']").click(function () {
              var TabsId = getCookie('TabId');
              var n = TabsId.substr(-2, 2);
              var id = $(this).attr("id").substr(-2, 2);
              //ShowMessag(n);
              //if (n == "01") {
              //    //$("#Save_1001").click();
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
              //        //$("#Save_100" + n).click();
              //    }
              //    else {
              //        //$("#Save_010" + n).click();
              //    }
              //}
               ShowTab(id);
              //点击存储本次Tab的ID
              addCookie('TabId', $(this).attr("id"), 1);            
          })
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