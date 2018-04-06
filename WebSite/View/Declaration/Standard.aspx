<%@ Page Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="Standard.aspx.cs" Inherits="Evaluation.View.Declaration.Standard" validateRequest="false"%>

<%@ Register TagPrefix="uc" TagName="Participant" Src="~/View/Declaration/Participant.ascx" %>
<%@ Register TagPrefix="uc" TagName="Appendix" Src="~/View/Declaration/Appendix.ascx" %>
<%@ Register TagPrefix="uc" TagName="LegalStates" Src="~/View/Declaration/LegalStates.ascx" %>
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
            margin-left: 26px;
        }

        #ContentPlaceHolder1_ddlProjectSource {
            width: 92%;
            margin-left: 10px;
            height: 25px;
            margin-bottom: 7px;
        }

        #content #test {
            height: 2500px !important;
        }

        #PrimaryCoverageTextBox, #BenefitsTextBox, #AwardsTextBox{
            text-align: left;width:81%;margin-left:10px;
        }
        #AwardsTextBox{
            width:83%;
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
            <a href="#" id="nav01"></a>&nbsp;>&nbsp;<a href="../Declaration/Declare.aspx?SepcCode=170000" id="nav02" runat="server" clientidmode="Static"></a>&nbsp;>&nbsp;<a href="#" id="nav03"></a>
        </li>
    </ul>

    <div class="tabbable">
        <ul class="nav nav-tabs" id="tabfather">
            <li class="active"><a id="tab_01" href="#btab1" data-toggle="tab">1、申报表</a></li>
            <li><a id="tab_02" href="#btab2" data-toggle="tab">2、人员情况</a></li>
            <li><a id="tab_03" href="#btab3" data-toggle="tab">3、项目特点</a></li>
            <li><a id="tab_04" href="#btab4" data-toggle="tab">4、附件目录</a></li>
            <li><a id="tab_05" href="#btab5" data-toggle="tab">5、法人声明</a></li>
            <li><a id="tab_06" href="#btab6" data-toggle="tab">6、合作声明</a></li>
            <li><a id="tab_07" href="#btab7" data-toggle="tab" class="ExpertReviewList2" style="display: none;">7、评审意见</a></li>
        </ul>
        <div class="tab-content" runat="server" id="divfather">
            <div class="tab-pane active" id="btab1">
                <asp:Panel ID="panelPart_1701" runat="server" ClientIDMode="Static" GroupingText="北京市优秀工程勘察设计地方标准（标准设计）申报表">
                    <table>
                        <tr>
                            <td style="width: 150px">标准（标准设计）名称
                            </td>
                            <td>
                                <asp:TextBox ID="StandardName" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardStandardName" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td style="width: 150px">标准（标准设计）编号
                            </td>
                            <td>
                                <asp:TextBox ID="StandardCode" runat="server" ClientIDMode="Static" Width="93%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardStandardCode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>主编单位
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="ChiefEditorUnit" runat="server" ClientIDMode="Static" Width="97%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardChiefEditorUnit" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="5">参编单位</td>
                            <td>单位名称</td>
                            <td colspan="2">承担工作</td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="CooperativeUnit1" runat="server" ClientIDMode="Static" Width="90%" onblur="Sensitize('CooperativeUnit1','UndertakeWork1')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit1','UndertakeWork1')">
                                <asp:TextBox ID="UndertakeWork1" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td onclick="Sensitize2('CooperativeUnit2','UndertakeWork1')">
                                <asp:TextBox ID="CooperativeUnit2" runat="server" ClientIDMode="Static" Width="90%" onblur="Sensitize('CooperativeUnit2','UndertakeWork2')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit2','UndertakeWork2')">
                                <asp:TextBox ID="UndertakeWork2" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td onclick="Sensitize2('CooperativeUnit3','UndertakeWork2')">
                                <asp:TextBox ID="CooperativeUnit3" runat="server" ClientIDMode="Static" Width="90%" onblur="Sensitize('CooperativeUnit3','UndertakeWork3')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit3','UndertakeWork3')">
                                <asp:TextBox ID="UndertakeWork3" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td onclick="Sensitize2('CooperativeUnit4','UndertakeWork3')">
                                <asp:TextBox ID="CooperativeUnit4" runat="server" ClientIDMode="Static" Width="90%" onblur="Sensitize('CooperativeUnit4','UndertakeWork4')"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareCooperativeUnit4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td colspan="2" onclick="Sensitize('CooperativeUnit4','UndertakeWork4')">
                                <asp:TextBox ID="UndertakeWork4" runat="server" ClientIDMode="Static" Width="95%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsSoftwareUndertakeWork4" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>编制起止时间
                            </td>
                            <td>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="StartDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计起始日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="EndDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择设计结束日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                    <asp:CheckBox runat="server" ID="IsStandardEndDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                            <td>项目来源
                            </td>
                            <td id="tdProjectSource">
                                <div class="DeclarationList" >
                                <asp:DropDownList runat="server" ID="ProjectSource" class="ddlProjectSource" ClientIDMode="Static">
                                </asp:DropDownList>
                                </div>
                                 <div class="ExpertReviewList" style="display: none">
                                     <asp:TextBox ID="txtProjectSource" runat="server" ClientIDMode="Static" Style="width: 88%;"></asp:TextBox>
                                 </div>  
                                <div id="Others" style="display: none;" runat="server" clientidmode="Static">
                                    <asp:TextBox ID="ProjectSourceOther" runat="server" ClientIDMode="Static" Width="88%"></asp:TextBox>
                                    <asp:CheckBox runat="server" ID="IsStandardProjectSource" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>批准立项文件号
                            </td>
                            <td>
                                <asp:TextBox ID="ApprovalNumber" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardApprovalNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>批准实施文件号
                            </td>
                            <td>
                                <asp:TextBox ID="ImplementNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardImplementNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位通讯地址
                            </td>
                            <td colspan="3">
                                <asp:TextBox ID="PostalAddress" runat="server" ClientIDMode="Static" Width="96.5%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardPostalAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位联系人
                            </td>
                            <td>
                                <asp:TextBox ID="Linkman" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardLinkman" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>手机
                            </td>
                            <td>
                                <asp:TextBox ID="MobileNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardMobileNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>电话号码
                            </td>
                            <td>
                                <asp:TextBox ID="TelephoneNumber" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardTelephoneNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>传真号码
                            </td>
                            <td>
                                <asp:TextBox ID="FaxNumber" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardFaxNumber" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>邮政编码
                            </td>
                            <td>
                                <asp:TextBox ID="Postcode" runat="server" ClientIDMode="Static" Width="90%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardPostcode" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                            <td>电子邮箱
                            </td>
                            <td>
                                <asp:TextBox ID="EmailAddress" runat="server" ClientIDMode="Static" Width="92%"></asp:TextBox>
                                <asp:CheckBox runat="server" ID="IsStandardEmailAddress" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 200px">曾获奖项
                            </td>
                            <td colspan="3">
                               <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                               <script id="AwardsTextBox" type="text/plain" style="height: 300px;"></script>
                               <asp:CheckBox runat="server" ID="IsStandardAwards" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1701')" id="Save_1701">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1701','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
                        <a onclick="javascript:onNext('01')" class="btnt up" style="margin-left: 20px;">下 一 步</a>
                    </div>
                </asp:Panel>
            </div>
            <div class="tab-pane" id="btab2">
                <uc:Participant runat="server" ID="ucParticipant"></uc:Participant>
            </div>
            <div class="tab-pane" id="btab3">
                <asp:Panel ID="panelPart_1702" runat="server" ClientIDMode="Static" GroupingText="标准（标准设计）项目特点">
                    <table>
                        <tr>
                            <td style="width: 150px;">标准（标准设计）主要内容
                            </td>
                            <td>
                                <asp:TextBox ID="PrimaryCoverage" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="PrimaryCoverageTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsStandardPrimaryCoverage" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>标准（标准设计）主要优缺点和效益
                            </td>
                            <td>
                                <asp:TextBox ID="Benefits" runat="server" ClientIDMode="Static" TextMode="MultiLine" Style="width: 97%; height: 300px;"></asp:TextBox>
                                <script id="BenefitsTextBox" type="text/plain" style="height: 300px;"></script>
                                <asp:CheckBox runat="server" ID="IsStandardBenefits" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                    </table>
                    <%-- <h3 style="padding-left:51px;">审批意见</h3>
                    <table>
                        <tr>
                            <td style="width: 200px">曾获奖项
                            </td>
                            <td>
                                <asp:TextBox ID="Awards" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>--%>
                    <%--                                <script id="AwardsTextBox" type="text/plain" style="height: 300px;"></script>--%>
                    <%--  <asp:CheckBox runat="server" ID="IsStandardAwards" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                            </td>
                        </tr>
                        <tr>
                            <td>申报单位意见
                            </td>
                            <td>
                                <asp:TextBox ID="UnitOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>--%>
                    <%--                                <script id="UnitOpinionTextBox" type="text/plain" style="height: 300px;"></script>--%>
                    <%-- <asp:CheckBox runat="server" ID="IsStandardUnitOpinion" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="UnitOpinionDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择填写日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width:35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>省、自治区、直辖市建设行政主管部门、国务院有关主管部门或行业协会推荐意见
                            </td>
                            <td>
                                <asp:TextBox ID="RecommendOpinion" runat="server" ClientIDMode="Static" TextMode="MultiLine" style="width:97%;height:300px;"></asp:TextBox>--%>
                    <%--<script id="RecommendOpinionTextBox" type="text/plain" style="height: 300px;"></script>--%>
                    <%-- <asp:CheckBox runat="server" ID="IsStandardRecommendOpinion" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                                <div class="datepicker input-group date">
                                    <asp:TextBox ID="RecommendOpinionDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择填写日期"></asp:TextBox>
                                    <span class="input-group-addon" style="width: 35px;"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                                </div>
                            </td>
                        </tr>
                    </table>--%>
                    <div style="display: none"><a onclick="javascript:onSave('Template_1702')" id="Save_1702">保存</a></div>
                    <div style="text-align: center; margin-top: 40px;">
                        <a onclick="javascript:onSave('Template_1702','Save')" class="btnt">保 &nbsp;&nbsp; 存</a>
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
        $('#ProjectSource').ui_choose();
        for (i = 1; i < 16; i++) {
            if ($("#ParticipantName" + i).val() == "") {
                $("#IDNumber" + i).attr('disabled', true);
            }
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
           $("#PrimaryCoverage").val(EncodeUEditorContent(UE.getEditor('PrimaryCoverageTextBox').getContent()));                              // 标准（标准设计）主要内容
           $("#Benefits").val(EncodeUEditorContent(UE.getEditor('BenefitsTextBox').getContent()));                                            // 标准（标准设计）主要优缺点和效益
           $("#Awards").val(EncodeUEditorContent(UE.getEditor('AwardsTextBox').getContent()));                                                // 曾获奖项                                
           if (!checkUEditor('PrimaryCoverageTextBox')
               || !checkUEditor('BenefitsTextBox')
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
            SetCollaborationInfo2();
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
            //                $("#txtUndertakeWork2").val(data[1]["Data"]);
            //            }
            //            else {
            //                $("#txtUndertakeWork2").val("");
            //            }
            //            if (data[2]) {
            //                $("#txtCooperationUnit3").val(data[2]["Data"]);
            //            }
            //            else {
            //                $("#txtCooperationUnit3").val("");
            //            }
            //            if (data[3]) {
            //                $("#txtUndertakeWork3").val(data[3]["Data"]);
            //            }
            //            else {
            //                $("#txtUndertakeWork3").val("");
            //            }
            //            if (data[4]) {
            //                $("#txtCooperationUnit4").val(data[4]["Data"]);
            //            }
            //            else {
            //                $("#txtCooperationUnit4").val("");
            //            }
            //            if (data[5]) {
            //                $("#txtUndertakeWork4").val(data[5]["Data"]);
            //            }
            //            else {
            //                $("#txtUndertakeWork4").val("");
            //            }
            //            if (data[6]) {
            //                $("#txtCooperationUnit5").val(data[6]["Data"]);
            //            }
            //            else {
            //                $("#txtCooperationUnit5").val("");
            //            }
            //            if (data[7]) {
            //                $("#txtUndertakeWork5").val(data[7]["Data"]);
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
        }
        // 项目来源样式 
        switch ($('#ProjectSource').val()) {
            case "2401":
                $('#txtProjectSource').val("行业");
                break;
            case "2402":
                $('#txtProjectSource').val("地方");
                break;
            case "2403":
                $('#txtProjectSource').val("国家");
                break;
            case "2404":
                $('#txtProjectSource').val("");
                break;
        }
        $(function () {
            SetCollaborationInfo2();
            var uc_02 = $('#ProjectSource').data('ui-choose');
            uc_02.click = function (value, item) {
                if (value == "2404") {
                    $('#Others').css("display", "block");
                }
                else {
                    $('#Others').css("display", "none");
                    $('#ProjectSourceOther').val("");

                }
            }

            if ($("#ProjectSource").find("option:selected").val() == "2404") {
                $('#Others').css("display", "block");
            }
            else {
                $('#Others').css("display", "none");
            }
            notBackspace();
            // 富文本框
           InitUEditor('PrimaryCoverageTextBox', 1000);                               // 标准（标准设计）主要内容
           InitUEditor('BenefitsTextBox', 1000);                                      // 标准（标准设计）主要优缺点和效益
           InitUEditor('AwardsTextBox', 500);                                        // 曾获奖项
          
           $("#tabfather li a[data-toggle='tab']").click(function () {
                var TabsId = getCookie('TabId');
                var n = TabsId.substr(-2, 2);
                var id = $(this).attr("id").substr(-2, 2);
                ShowTab(id);
                //ShowMessag(n);
                //if (n == "01") {
                //    //$("#Save_1701").click();
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
                //        //$("#Save_170" + n).click();
                //    }
                //    else {
                //        //$("#Save_17" + n).click();
                //    }
                //}               
                //点击存储本次Tab的ID
                addCookie('TabId', $(this).attr("id"), 1);
                //ShowMessag($(this).attr("id"));
           })
           $('#nav03').text($('#StandardName').val())
        });
        //CooperativeUnit1 UndertakeWork1
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
