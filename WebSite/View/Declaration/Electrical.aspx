<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/View/Mutual/Site.Master" CodeBehind="Electrical.aspx.cs" Inherits="Evaluation.View.Declaration.Electrical" validateRequest="false" %>

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

        #ComprehensiveBenefitTextBox {
            width: 80%;
        }

       
        #ueditor, #ueditor2, #ueditor7, #ueditor8 {
            text-align: left;
        }

        #edui1_iframeholder {
            height: 300px;
        }
        
        #btn_018Prev{
            margin-left: 43%;
            margin-top:40px; 
        }
        #AcceptanceDepartment{
            float:none!important;
        }

        #AcceptanceDepartment{
            margin-left:4px;
        }


        #content #test{
            height:2500px!important;
        }
        #ProjectOverviewTextBox,#TechnologyFeatureTextBox{
            text-align:left;margin-left:8px;width:89%;
        }
        #ComprehensiveBenefitTextBox{
              text-align:left;margin-left:8px;width:77%;
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
            <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=070000" id="nav02" runat="server" clientidmode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
        </li>
    </ul>

    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、基本情况</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、申报内容</a></li>            
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、附件目录</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、代表声明</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、合作声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab" class="ExpertReviewList2" style="display: none;">7、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_0701" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 130px;">项目报优名称
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalDeclarationName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>立项名称
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="ApprovalName" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalApprovalName" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">申报单位<br />
                                （主申报）
                            </td>
                            <td style="width: 120px;">申报单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="94.8%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalDeclarationUnit" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>通讯地址
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="94.8%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalPostalAddress" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>联 系 人
                            </td>
                            <td style="width: 30%">
                                <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalLinkman" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>手    机
                            </td>
                            <td>
                                <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalMobileNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>电    话
                            </td>
                            <td>
                                <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalTelephoneNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalPostcode" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>传    真
                            </td>
                            <td>
                                <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalFaxNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalEmailAddress" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
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
                            <td>建设单位
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="DevelopmentOrganization" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalDevelopmentOrganization" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>施工单位
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionOrganization" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalConstructionOrganization" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>使用单位
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="UseUnit" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalUseUnit" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点
                            </td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionLocation" runat="server" ClientIDMode="Static" Width="95.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalConstructionLocation" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">建筑功能<br />
                                （使用性质）
                            </td>
                            <td>地上
                            </td>
                            <td>
                                <asp:TextBox ID="UseProperty_Overground" runat="server" ClientIDMode="Static" Width="84%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalUseProperty_Overground" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td style="width: 120px;">用地性质
                            </td>
                            <td>
                                <asp:TextBox ID="LandNature" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalLandNature" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>地下
                            </td>
                            <td>
                                <asp:TextBox ID="UseProperty_Underground" runat="server" ClientIDMode="Static" Width="84%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalUseProperty_Underground" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>设计使用年限
                            </td>
                            <td>
                                <asp:TextBox ID="DesignServiceLife" runat="server" ClientIDMode="Static" style="width:82%;margin-left:5%;"></asp:TextBox> 年
                        <asp:CheckBox ID="IsElectricalDesignServiceLife" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>总建筑面积
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="OverallFloorage" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                m<sup>2</sup>
                                <asp:CheckBox ID="IsElectricalOverallFloorage" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />

                            </td>
                            <td>用地面积
                            </td>
                            <td>
                                <asp:TextBox ID="TotalLandArea" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalTotalLandArea" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建筑高度
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="BuildingHeight" runat="server" ClientIDMode="Static" style="width:88%;margin-left:-2%;"></asp:TextBox> m
                        <asp:CheckBox ID="IsElectricalBuildingHeight" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />

                            </td>
                            <td>建筑层数
                            </td>
                            <td>
                                <asp:TextBox ID="LayerCount" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalLayerCount" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计类别
                            </td>
                            <td colspan="2">
                                <div class="DeclarationList">
                                    <asp:DropDownList runat="server" ID="DesignCategory" ClientIDMode="Static"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display:none">
                                    <asp:TextBox ID="txtDesignCategory" runat="server" Width="90%" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsElectricalDesignCategory" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <%--                        <asp:TextBox ID="DesignCategory" runat="server" ClientIDMode="Static" Width="80%"></asp:TextBox>
                        <asp:CheckBox ID="IsElectricalDesignCategory" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />--%>
                            </td>
                            <td>设计起止时间
                            </td>
                            <td style="margin-left:2.5%;">
                                <div class="datepicker input-group date" >
                                    <asp:TextBox ID="DesignStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计开始日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                                
                                <div class="datepicker input-group date" >
                                    <asp:TextBox ID="DesignEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计终止日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsElectricalDesignEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>开工时间
                            </td>
                            <td colspan="2">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="ConstructionStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择开工日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsElectricalConstructionStartDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>竣工时间
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="ConstructionEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsElectricalConstructionEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>竣工验收时间
                            </td>
                            <td colspan="2">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工验收日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsElectricalAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>竣工验收部门
                            </td>
                            <td>
                                <asp:TextBox ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="65%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalAcceptanceDepartment" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>消防备案时间
                            </td>
                            <td colspan="2">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="FireControlRecordDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择消防备案日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsElectricalFireControlRecordDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>交付使用时间
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="DeliveryDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择交付使用日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsElectricalDeliveryDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
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
                    <div style="display:none"><a onclick="javascript:onSave('Template_0701')" id="Save_0701">保存</a></div> 
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0701','Save')" class="btnt">保 &nbsp; &nbsp; 存</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" id="ucParticipant"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_0702" runat="server" ClientIDMode="Static" GroupingText="技术申报内容">
                    <table>
                        <tr style="height: 200px;">
                            <td colspan="1">项目概况</td>
                            <td colspan="4">
                                <p style="padding-left:10px;">（项目总体介绍、项目规模、复杂程度及影响程度等，限500字）</p>
                                <asp:TextBox ID="ProjectOverview" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 200px;"></asp:TextBox>
                                <script id="ProjectOverviewTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsElectricalProjectOverview" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="13" colspan="1" style="padding:10px;">技术特点</td>
                            <td colspan="4" style="height: 300px;">
                                <p style="padding-left:10px;">（技术特点、先进性与创新性，主要的技术指标，采用节能技术与效果，限1500字)</p>
                                <asp:TextBox ID="TechnologyFeature" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 500px;"></asp:TextBox>
                                <script id="TechnologyFeatureTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsElectricalTechnologyFeature" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td style="padding:7px;">系统类别
                            </td>
                            <td colspan="2">规模
                            </td>
                            <td>特点（安全性、可靠性、灵活性）
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="3" style="width: 120px;">供配电系统
                            </td>
                            <td style="width: 120px;">电力总用<br />
                                电负荷
                            </td>
                            <td>
                                <asp:TextBox ID="TotalElectricityload" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox>
                                kW
                                <asp:CheckBox ID="IsElectricalTotalElectricityload" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />

                            </td>
                            <td rowspan="3">
                                <asp:TextBox ID="PowerSupplySystemTrait" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 91%; height: 300px;display:block;"></asp:TextBox>
                             <%--   <script id="PowerSupplySystemTraitTextBox" type="text/plain" style="height: 300px;"></script>--%>
                                <asp:CheckBox runat="server" ID="IsElectricalPowerSupplySystemTrait" ClientIDMode="Static" ToolTip="公开" Checked="true" />                                                              
                            </td>
                        </tr>
                        <tr>
                            <td>变压器装<br />
                                机密度
                            </td>
                            <td style="width:20%;">
                                <asp:TextBox ID="TransformerDensity" runat="server" ClientIDMode="Static" Width="78%"></asp:TextBox>
                                kVA/㎡
                                <asp:CheckBox ID="IsElectricalTransformerDensity" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />

                            </td>
                        </tr>
                        <tr>
                            <td>备用电源<br />
                                装机密度
                            </td>
                           <td>
                                <asp:TextBox ID="StandbyElectricityDensity" runat="server" ClientIDMode="Static" Style="width: 25%"></asp:TextBox>
                                KVA/㎡    或<asp:TextBox ID="StandbyElectricityDensityKW" runat="server" ClientIDMode="Static" Style="width: 25%"></asp:TextBox> KW/㎡
                            <asp:CheckBox runat="server" ID="IsElectricalStandbyElectricityDensity" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>配变电所
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="Substation_Scale" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalSubstation_Scale" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Substation_Trait" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalSubstation_Trait" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>自备应急电源供配电系统特点
                                </td>
                            
                            <td colspan="2">
                                <asp:TextBox ID="EmergencyPowerSupply_Scale" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalEmergencyPowerSupply_Scale" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="EmergencyPowerSupply_Trait" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalEmergencyPowerSupply_Trait" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>低压配电系统
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="LowVoltageDistributionSystem_Scale" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalLowVoltageDistributionSystem_Scale" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="LowVoltageDistributionSystem_Trait" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalLowVoltageDistributionSystem_Trait" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>配电线路布线<br />
                                系统
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="WiringSystem_Scale" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalWiringSystem_Scale" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="WiringSystem_Trait" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalWiringSystem_Trait" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>电气照明系统
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="Lighting_Scale" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalLighting_Scale" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Lighting_Trait" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalLighting_Trait" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>建筑物防雷及<br />
                                接地系统
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="Grounding_Scale" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalGrounding_Scale" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="Grounding_Trait" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalGrounding_Trait" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>电气消防系统
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="FireFightingSystem_Scale" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalFireFightingSystem_Scale" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="FireFightingSystem_Trait" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalFireFightingSystem_Trait" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr>
                            <td>其他相关电气<br />
                                系统
                            </td>
                            <td colspan="2">
                                <asp:TextBox ID="OtherElectricalSystems_Scale" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalOtherElectricalSystems_Scale" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>
                                <asp:TextBox ID="OtherElectricalSystems_Trait" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox ID="IsElectricalOtherElectricalSystems_Trait" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                        </tr>
                        <tr style="height: 300px;">
                            <td colspan="2">综合效益
                            </td>
                            <td colspan="3">
                                <p style="padding-left:10px;">（项目产生的经济、社会、环境效益，限500字）</p>
                                <asp:TextBox ID="ComprehensiveBenefit" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="ComprehensiveBenefitTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsElectricalComprehensiveBenefit" ClientIDMode="Static" ToolTip="公开" Checked="true" />                               
                            </td>
                        </tr>
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_0702')" id="Save_0702">保存</a></div> 
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0702','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left: 20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>  
            <div class="tab-pane" id="btab4">
                <uc:Appendix runat="server" ID="Appendix"></uc:Appendix>
            </div>
            <div class="tab-pane" id="btab5">
              <uc:LegalStates runat="server" id="ucLegalStates"></uc:LegalStates>
            </div>
            <div class="tab-pane" id="btab6">
              <uc:Certificate runat="server" id="ucCertificate"></uc:Certificate>
            </div>
            <div class="tab-pane" id="btab7">
              <uc:Comments runat="server" id="ucComments"></uc:Comments>
            </div>
        </div>
    </div>
    
    

  <script type="text/javascript">
      $('#ProfessionalCategories').ui_choose();
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
          $("#ProjectOverview").val(EncodeUEditorContent(UE.getEditor('ProjectOverviewTextBox').getContent()));                        // 项目概况
          $("#TechnologyFeature").val(EncodeUEditorContent(UE.getEditor('TechnologyFeatureTextBox').getContent()));                    // 技术特点
          $("#ComprehensiveBenefit").val(EncodeUEditorContent(UE.getEditor('ComprehensiveBenefitTextBox').getContent()));              // 综合效益

          if (!checkUEditor('ProjectOverviewTextBox')
                || !checkUEditor('TechnologyFeatureTextBox')
                || !checkUEditor('ComprehensiveBenefitTextBox')               
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
      }
    
      $(function () {
          for (i = 1; i < 16; i++) {
              if ($("#ParticipantName" + i).val() == "") {
                  $("#IDNumber" + i).attr('disabled', true);
              }
          }
          SetCollaborationInfo();
          notBackspace();
          // 富文本框
          InitUEditor('ProjectOverviewTextBox', 500);              // 项目概况
          InitUEditor('TechnologyFeatureTextBox', 1500);           // 技术特点
          InitUEditor('ComprehensiveBenefitTextBox', 500);         // 综合效益

          //$("#edui-editor").width(880)
          //保存上个pannel编辑内容
          $("#tabfather li a[data-toggle='tab']").click(function () {
              var TabsId = getCookie('TabId');
              var n = TabsId.substr(-2, 2);
              var id = $(this).attr("id").substr(-2, 2);
              ShowTab(id);
              //ShowMessag(n);
              //if (n == "01") {
              //    //$("#Save_0701").click();
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
              //    n = parseInt(n) - 1;
              //    if (String(n).length == 1) {
              //        //$("#Save_070" + n).click();
              //    }
              //    else {
              //        //$("#Save_07" + n).click();
              //    }
              //}           
              //点击存储本次Tab的ID
              addCookie('TabId', $(this).attr("id"), 1);
              //ShowMessag($(this).attr("id"));
          })
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
