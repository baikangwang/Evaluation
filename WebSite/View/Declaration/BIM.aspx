<%@ Page Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="BIM.aspx.cs" Inherits="Evaluation.View.Declaration.BIM" validateRequest="false"%>

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
        input{
            text-align:center;
        }
        .ui-choose{
            margin-left:15px;
        }
        tbody > tr > td:nth-child(2) > div {
            left: -13px !important;
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
        #BIM_TechnologyTextBox,#InnovationHighlightsTextBox,#BIM_Technology_ValueTextBox,#ExperienceSummaryTextBox{
            width:90%
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
        #BIM_TechnologyTextBox,#InnovationHighlightsTextBox,#BIM_Technology_ValueTextBox,#ExperienceSummaryTextBox{
            text-align:left;margin-left:10px;width:81%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <ul class="navs">
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=050000" id="nav02" runat="server" ClientIDMode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
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
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、建筑专业</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、附件目录</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、法人声明</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、合作声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab" class="ExpertReviewList2" style="display: none;">7、评审意见</a></li>
        </ul>

        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_0501" runat="server" ClientIDMode="Static" GroupingText="项目基本情况">
                    <table>
                        <tr>
                            <td style="width: 100px;">项目名称</td>
                            <td colspan="4">
                                <asp:TextBox ID="DeclarationName" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMDeclarationName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">申报单位</td>
                            <td style="width: 100px;">申报单位</td>
                            <td colspan="3">
                                <asp:TextBox ID="DeclarationUnit" runat="server" ClientIDMode="Static" Width="96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMDeclarationUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>通讯地址</td>
                            <td colspan="3">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMPostalAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />

                            </td>
                        </tr>
                        <tr>
                            <td>联系人</td>
                            <td style="width: 30%">
                                <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="91.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsBIMLinkman" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>手机</td>
                            <td>
                                <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static"  Width="93.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMMobileNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>电话</td>
                            <td>
                                <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="91.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsBIMTelephoneNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>邮政编码</td>
                            <td>
                                <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="93.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMPostcode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>传真</td>
                            <td>
                                <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="91.5%"></asp:TextBox>
                                <asp:CheckBox ID="IsBIMFaxNumber" runat="server" Checked="true" ClientIDMode="Static" ToolTip="公开" />
                            </td>
                            <td>电子邮箱</td>
                            <td>
                                <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="93.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMEmailAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                            <td>建设单位</td>
                            <td colspan="4">
                                <asp:TextBox ID="DevelopmentOrganization" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMDevelopmentOrganization" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>施工单位</td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionOrganization" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMConstructionOrganization" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>建设地点</td>
                            <td colspan="4">
                                <asp:TextBox ID="ConstructionLocation" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMConstructionLocation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>设计类别</td>
                            <td colspan="2">
                                <div class="DeclarationList">
                                    <asp:DropDownList runat="server" ID="DesignCategory" ClientIDMode="Static"></asp:DropDownList>
                                </div>
                                <div class="ExpertReviewList" style="display:none">
                                    <asp:TextBox ID="txtDesignCategory" runat="server" Width="90%" ClientIDMode="Static"></asp:TextBox>
                                </div>
                                <asp:CheckBox runat="server" ID="IsBIMDesignCategory" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="width: 100px;">设计起止时间</td>
                            <td style="margin-left:2.5%;">
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="DesignStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计起始日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                               
                                <div class="datepicker input-group date" >
                                    <asp:TextBox ID="DesignEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计终止日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="CheckBox2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>建设时间</td>
                            <td colspan="2">
                                <div class="datepicker input-group date" style="margin:0px auto">
                                    <asp:TextBox ID="ConstructionStartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择建设日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsBIMConstructionStartDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>交付使用时间</td>
                            <td>
                                <div class="datepicker input-group date" style="margin:0px auto">
                                    <asp:TextBox ID="DeliveryDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择交付使用日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsBIMDeliveryDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>竣工时间</td>
                            <td colspan="2">
                                <div class="datepicker input-group date" style="margin:0px auto">
                                    <asp:TextBox ID="ConstructionEndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择竣工日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsBIMConstructionEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>验收时间</td>
                            <td>
                                <div class="datepicker input-group date" style="margin:0px auto">
                                    <asp:TextBox ID="AcceptanceDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择验收日期"></asp:TextBox>
                                    <span class="input-group-addon" ><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsBIMAcceptanceDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>验收部门</td>
                            <td colspan="2">
                                <asp:TextBox ID="AcceptanceDepartment" runat="server" ClientIDMode="Static" Width="94%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMAcceptanceDepartment" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>建筑规模</td>
                            <td>
                                <asp:TextBox ID="BuildingScale" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMBuildingScale" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>建筑用途<br />
                                （性质）</td>
                            <td colspan="2">
                                <asp:TextBox ID="UseProperty" runat="server" ClientIDMode="Static" Width="94%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMUseProperty" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>建筑高度</td>
                            <td>
                                <asp:TextBox ID="BuildingHeight" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMBuildingHeight" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>地上层数</td>
                            <td colspan="2">
                                <asp:TextBox ID="Layer_Ground" runat="server" ClientIDMode="Static" Width="94%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMLayer_Ground" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>地下层数</td>
                            <td>
                                <asp:TextBox ID="Layer_Underground" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMLayer_Underground" ClientIDMode="Static" ToolTip="公开" Checked="true" />
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
                    <div style="display:none"><a onclick="javascript:onSave('Template_0501')" id="Save_0501">保存</a></div> 
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0501','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" id="ucParticipant"></uc:Participant>
            </div> 
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_0502" runat="server" ClientIDMode="Static" GroupingText="技术申报内容（建筑专业）">
                    <table>
                        <tr>
                            <td style="padding:10px;width:150px;">BIM软件名称
                            </td>
                            <td colspan="5">
                                <asp:TextBox ID="BIMName" runat="server" ClientIDMode="Static" Width="97.3%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMBIMName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>专业
                            </td>
                            <td>规划方案
                            </td>
                            <td>初步设计
                            </td>
                            <td>施工图
                            </td>
                            <td>施工
                            </td>
                            <td>运营维护
                            </td>
                        </tr>
                        <tr>
                            <td>建筑
                            </td>
                            <td>
                                <asp:TextBox ID="Building_PlanningScheme" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMBuilding_PlanningScheme" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Building_PreliminaryDesign" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMBuilding_PreliminaryDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Building_Construction_Plans" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMBuilding_Construction_Plans" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Building_Construction" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMBuilding_Construction" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Building_Operation" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMBuilding_Operation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>结构
                            </td>
                            <td>
                                <asp:TextBox ID="Architecture_PlanningScheme" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMArchitecture_PlanningScheme" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Architecture_PreliminaryDesign" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMArchitecture_PreliminaryDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Architecture_Construction_Plans" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMArchitecture_Construction_Plans" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Architecture_Construction" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMArchitecture_Construction" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Architecture_Operation" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMArchitecture_Operation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>水
                            </td>
                            <td>
                                <asp:TextBox ID="Water_PlanningScheme" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMWater_PlanningScheme" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Water_PreliminaryDesign" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMWater_PreliminaryDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Water_Construction_Plans" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMWater_Construction_Plans" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Water_Construction" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMWater_Construction" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Water_Operation" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMWater_Operation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>电气
                            </td>
                            <td>
                                <asp:TextBox ID="Electric_PlanningScheme" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMElectric_PlanningScheme" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Electric_PreliminaryDesign" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMElectric_PreliminaryDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Electric_Construction_Plans" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMElectric_Construction_Plans" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Electric_Construction" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMElectric_Construction" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Electric_Operation" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMElectric_Operation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>暖通
                            </td>
                            <td>
                                <asp:TextBox ID="HVAC_PlanningScheme" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMHVAC_PlanningScheme" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="HVAC_PreliminaryDesign" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMHVAC_PreliminaryDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="HVAC_Construction_Plans" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMHVAC_Construction_Plans" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="HVAC_Construction" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMHVAC_Construction" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="HVAC_Operation" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMHVAC_Operation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>总图
                            </td>
                            <td>
                                <asp:TextBox ID="GeneralPlan_PlanningScheme" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMGeneralPlan_PlanningScheme" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="GeneralPlan_PreliminaryDesign" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMGeneralPlan_PreliminaryDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="GeneralPlan_Construction_Plans" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMGeneralPlan_Construction_Plans" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="GeneralPlan_Construction" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMGeneralPlan_Construction" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="GeneralPlan_Operation" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMGeneralPlan_Operation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>经济
                            </td>
                            <td>
                                <asp:TextBox ID="Economics_PlanningScheme" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMEconomics_PlanningScheme" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Economics_PreliminaryDesign" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMEconomics_PreliminaryDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Economics_Construction_Plans" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMEconomics_Construction_Plans" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Economics_Construction" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMEconomics_Construction" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Economics_Operation" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMEconomics_Operation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>规划
                            </td>
                            <td>
                                <asp:TextBox ID="Planning_PlanningScheme" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMPlanning_PlanningScheme" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Planning_PreliminaryDesign" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMPlanning_PreliminaryDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Planning_Construction_Plans" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMPlanning_Construction_Plans" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Planning_Construction" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMPlanning_Construction" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Planning_Operation" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMPlanning_Operation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>景观
                            </td>
                            <td>
                                <asp:TextBox ID="Scenery_PlanningScheme" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMScenery_PlanningScheme" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Scenery_PreliminaryDesign" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMScenery_PreliminaryDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Scenery_Construction_Plans" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMScenery_Construction_Plans" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Scenery_Construction" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMScenery_Construction" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Scenery_Operation" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMScenery_Operation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>市内
                            </td>
                            <td>
                                <asp:TextBox ID="Inside_PlanningScheme" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMInside_PlanningScheme" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Inside_PreliminaryDesign" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMInside_PreliminaryDesign" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Inside_Construction_Plans" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMInside_Construction_Plans" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Inside_Construction" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMInside_Construction" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>
                                <asp:TextBox ID="Inside_Operation" runat="server" ClientIDMode="Static" Width="86%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsBIMInside_Operation" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" style="text-align: left;padding-left:10px;">
                                <p>请在相应的BIM应用阶段与应用专业的节点处选出应用的领域，可多选（数目不限）；</p>

                                <p>例如在施工图阶段，电气专业应用了BIM模型维护及场地分析，在相应空格处填写A、B。</p>

                                <p>A. BIM模型维护</p>

                                <p>B. 场地分析</p>

                                <p>C. 建筑策划</p>

                                <p>D. 方案论证</p>

                                <p>E. 可视化设计</p>

                                <p>F. 协同设计</p>

                                <p>G. 性能化分析</p>

                                <p>H. 工程量统计</p>

                                <p>I. 管线综合</p>

                                <p>J. 施工进度模拟</p>

                                <p>K. 施工组织模拟</p>

                                <p>L. 数字化建造</p>

                                <p>M. 物料跟踪</p>

                                <p>N. 施工现场配合</p>

                                <p>O. 竣工模型交付</p>

                                <p>P. 维护计划</p>

                                <p>Q. 资产管理</p>

                                <p>R. 空间管理</p>

                                <p>S. 建筑系统分析</p>

                                <p>T. 灾害应急模拟</p>
                            </td>
                        </tr>
                        <tr>
                            <td>项目设计中BIM
                                技术的应用
                            </td>
                            <td colspan="5">
                                <asp:TextBox ID="BIM_Technology" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:98%;height:300px;">
                                </asp:TextBox>                          
                                <asp:CheckBox runat="server" ID="IsBIMBIM_Technology" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="BIM_TechnologyTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>项目设计及软
                                件应用中的
                                创新亮点
                            </td>
                            <td colspan="5">
                                <asp:TextBox ID="InnovationHighlights" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:98%;height:300px;">
                                </asp:TextBox>                          
                                <asp:CheckBox runat="server" ID="IsBIMInnovationHighlights" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="InnovationHighlightsTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>应用BIM技术的
                                价值
                            </td>
                            <td colspan="5">
                                <asp:TextBox ID="BIM_Technology_Value" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:98%;height:300px;">
                                </asp:TextBox>                          
                                <asp:CheckBox runat="server" ID="IsBIMBIM_Technology_Value" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="BIM_Technology_ValueTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                        <tr>
                            <td>应用心得总结
                            </td>
                            <td colspan="5">
                                <asp:TextBox ID="ExperienceSummary" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:98%;height:300px;">
                                </asp:TextBox>                          
                                <asp:CheckBox runat="server" ID="IsBIMExperienceSummary" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <script id="ExperienceSummaryTextBox" type="text/plain" style=" height: 300px;"></script>
                            </td>
                        </tr>
                    </table>
                    <div style="display:none"><a onclick="javascript:onSave('Template_0502')" id="Save_0502">保存</a></div> 
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_0502','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onPrev('03')" class="btnt up" style="margin-left:20px;">上 一 步</a>
                        <a onclick="javascript:onNext('03')" class="btnt up" style="margin-left:20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div> 
            <div class="tab-pane" id="btab4">
                <uc:Appendix runat="server" id="Appendix"></uc:Appendix>
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
          $("#BIM_Technology").val(EncodeUEditorContent(UE.getEditor('BIM_TechnologyTextBox').getContent()));                     // 项目设计中BIM技术的应用
          $("#InnovationHighlights").val(EncodeUEditorContent(UE.getEditor('InnovationHighlightsTextBox').getContent()));         // 项目设计及软件应用中的创新亮点
          $("#BIM_Technology_Value").val(EncodeUEditorContent(UE.getEditor('BIM_Technology_ValueTextBox').getContent()));         // 应用BIM技术的价值
          $("#ExperienceSummary").val(EncodeUEditorContent(UE.getEditor('ExperienceSummaryTextBox').getContent()));               // 应用心得总结 

          if (!checkUEditor('BIM_TechnologyTextBox')
                || !checkUEditor('InnovationHighlightsTextBox')
                || !checkUEditor('BIM_Technology_ValueTextBox')
                || !checkUEditor('ExperienceSummaryTextBox')
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
          //                if (data[2]["Data"]!=null) {
          //                strs = data[2]["Data"].split(",");
          //                for (i = 0; i < strs.length; i++) {
          //                    var ee = strs[i].substring(2, 4);
          //                    $("#CollaborativePhase2_" + ee).val("√");
          //                 }
          //               }
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
          //                if (data[5]["Data"]!=null) { 
          //                strs = data[5]["Data"].split(",");
          //                for (i = 0; i < strs.length; i++) {
          //                    var ee = strs[i].substring(2, 4);
          //                    $("#CollaborativePhase3_" + ee).val("√");
          //                  }
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
          //                if (data[8]["Data"]!=null) { 
          //                strs = data[8]["Data"].split(",");
          //                for (i = 0; i < strs.length; i++) {
          //                    var ee = strs[i].substring(2, 4);
          //                    $("#CollaborativePhase4_" + ee).val("√");
          //                 }
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
          SetCollaborationInfo();
          notBackspace();
          // 富文本框
          InitUEditor('BIM_TechnologyTextBox',2000);                 // 项目设计中BIM技术的应用
          InitUEditor('InnovationHighlightsTextBox',2000);           // 项目设计及软件应用中的创新亮点
          InitUEditor('BIM_Technology_ValueTextBox',2000);           // 应用BIM技术的价值
          InitUEditor('ExperienceSummaryTextBox',2000);              // 应用心得总结

          //保存上个pannel编辑内容
          $("#tabfather li a[data-toggle='tab']").click(function () {
              var TabsId = getCookie('TabId');
              var n = TabsId.substr(-2, 2);
              var id = $(this).attr("id").substr(-2, 2);
              ShowTab(id);
              //alert(n);
              //if (n == "01") {
              //    //$("#Save_0501").click();
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
              //        //$("#Save_050" + n).click();
              //    }
              //    else {
              //        //$("#Save_05" + n).click();
              //    }
              //}
              //点击存储本次Tab的ID
              addCookie('TabId', $(this).attr("id"), 1);
              //alert($(this).attr("id"));
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