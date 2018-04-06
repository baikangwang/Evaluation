<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Certificate.ascx.cs" Inherits="Evaluation.View.Declaration.Certificate" %>
<div style="display: none">
    <asp:TextBox ID="txtdeclID" runat="server" ClientIDMode="Static"></asp:TextBox>
    <asp:TextBox ID="txtUserType" runat="server" ClientIDMode="Static"></asp:TextBox>
</div>
<asp:Panel ID="PanelCertificate" runat="server" GroupingText="合作勘察设计项目合作声明">
    <table style="width: 90%" id="CertificateTable">
        <tr>
            <td>
                <div style="width: 85%; height: 200px; margin: 30px auto 0 auto; text-align: left; line-height: 35px; font-size: 14px;">
                    <u>
                        <asp:Literal ID="DeclarationName" runat="server" ClientIDMode="Static"></asp:Literal></u>
                    工程项目为我们合作完成，我们各方均同意以
                    <u>
                        <asp:Literal ID="DeclarationUnit" runat="server" ClientIDMode="Static"></asp:Literal></u> （单位）
                    为主申报单位，参加<u id="uPrize" runat="server"></u> 评选。
                    <br />
                    <br />
                    特此声明。
                </div>
            </td>
        </tr>
    </table>
</asp:Panel>
<br />

<asp:Panel ID="PanelDivision" runat="server" GroupingText="合作设计项目分工表">
    <div style="display: none;">
        <input id="Division2" type="text" runat="server" clientidmode="Static" /></div>
    <div style="display: none;">
        <input id="Division3" type="text" runat="server" clientidmode="Static" /></div>
    <div style="display: none;">
        <input id="Division4" type="text" runat="server" clientidmode="Static" /></div>
    <div style="display: none;">
        <input id="Division5" type="text" runat="server" clientidmode="Static" /></div>
    <div style="display: none;">
        <input id="TemplateCode" type="text" runat="server" clientidmode="Static" /></div>
    <div style="display: none;">
        <input id="IsAllowUpdate" type="text" runat="server" clientidmode="Static" /></div>
    <div class="TopFifteen">
        <table id="DivisionTable">
            <tr>
                <td colspan="13" style="text-align: center; font-size: 18px;">合作设计项目分工表</td>
            </tr>
            <tr>
                <td style="width: 50px;">排序</td>
                <td style="width: 170px">勘察设计单位（全称）</td>
                <td data-v="2001">概念性方案设计</td>
                <td data-v="2002">方案设计(建筑)</td>
                <td data-v="2003">方案设计(结构)</td>
                <td data-v="2004">初步设计(建筑)</td>
                <td data-v="2005">初步设计(结构)</td>
                <td data-v="2006">初步设计(设备)</td>
                <td data-v="2007">初步设计(电气)</td>
                <td data-v="2008">施工图设计<br />
                    (建筑)</td>
                <td data-v="2009">施工图设计<br />
                    (结构)</td>
                <td data-v="2010">施工图设计<br />
                    (设备)</td>
                <td data-v="2011">施工图设计<br />
                    (电气)</td>
            </tr>
            <tr>
                <td>1</td>
                <td>
                    <asp:Literal ID="litDeclarationUnit" runat="server" ClientIDMode="Static"></asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal1" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal2" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal3" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal4" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal5" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal6" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal7" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal8" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal9" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal10" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal11" runat="server" ClientIDMode="Static">√</asp:Literal></td>
            </tr>
            <tr>
                <td>2</td>
                <td>
                    <asp:TextBox ID="txtDeclarationUnit2" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_01" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_02" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_03" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_04" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_05" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_06" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_07" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_08" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_09" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_10" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase2_11" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
            </tr>
            <tr>
                <td>3</td>
                <td>
                    <asp:TextBox ID="txtDeclarationUnit3" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_01" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_02" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_03" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_04" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_05" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_06" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_07" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_08" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_09" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_10" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase3_11" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
            </tr>
            <tr>
                <td>4</td>
                <td>
                    <asp:TextBox ID="txtDeclarationUnit4" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_01" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_02" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_03" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_04" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_05" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_06" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_07" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_08" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_09" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_10" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase4_11" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
            </tr>
            <tr>
                <td>5</td>
                <td>
                    <asp:TextBox ID="txtDeclarationUnit5" runat="server" ClientIDMode="Static"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_01" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_02" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_03" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_04" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_05" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_06" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_07" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_08" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_09" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_10" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
                <td>
                    <asp:TextBox ID="CollaborativePhase5_11" runat="server" ClientIDMode="Static" Style="width: 50%">×</asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="13">
                    <label>（此表为建筑类奖项填写，其它专业奖项可参照此表根据不同专业实际情况填写）</label>
                    <br />
                    <br />
                    <label style="color: orange;">注：1. 排序应以承担工作为依据，主申报单位列在首位。合作单位签名盖章表的排序与此表排序相对应。</label>
                    <br />
                    <label style="color: orange;">2. 在承担的栏中填写“√”，在未承担的栏中填写“×”，不应空白。</label>
                </td>
            </tr>
        </table>
    </div>
    <div class="LastTwo" style="display: none">
        <table id="DivisionTable2">
            <tr>
                <td style="width:6%;">排序
                </td>
                <td style="width:46%;">申报单位
                </td>
                <td>承担工作
                </td>
            </tr>
            <tr>
                <td>1
                </td>
                <td>
                    <asp:TextBox ID="txtMaiDeclarationUnit" runat="server" ClientIDMode="Static" style="width:94%;"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtUndertakeWork1" runat="server" ClientIDMode="Static" style="width:94%;">/</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>2
                </td>
                <td>
                    <asp:TextBox ID="txtCooperationUnit2" runat="server" ClientIDMode="Static" Style="width:94%;"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtUndertakeWork2" runat="server" ClientIDMode="Static" Style="width:94%;"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>3
                </td>
                <td>
                    <asp:TextBox ID="txtCooperationUnit3" runat="server" ClientIDMode="Static" Style="width:94%;"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtUndertakeWork3" runat="server" ClientIDMode="Static" Style="width:94%;"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>4
                </td>
                <td>
                    <asp:TextBox ID="txtCooperationUnit4" runat="server" ClientIDMode="Static" Style="width:94%;"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtUndertakeWork4" runat="server" ClientIDMode="Static" Style="width:94%;"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>5
                </td>
                <td>
                    <asp:TextBox ID="txtCooperationUnit5" runat="server" ClientIDMode="Static" Style="width:94%;"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="txtUndertakeWork5" runat="server" ClientIDMode="Static" Style="width:94%;"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    <div class="SurveyTable" style="display: none">
        <table id="DivisionTable3">
             <tr>
                <td colspan="13" style="text-align: center; font-size: 18px;">合作设计项目分工表</td>
            </tr>
            <tr>
                <td style="width: 50px;">排序</td>
                <td style="width: 170px">勘察设计单位（全称）</td>
                <td data-v="2101">岩土工程勘察</td>
                <td data-v="2102">岩土工程设计</td>
                <td data-v="2103">岩土工程检测</td>
                <td data-v="2104">岩土工程监测</td>
                <td data-v="2105">岩土工程咨询</td>               
            </tr>
            <tr>
                <td>1</td>
                <td>
                    <asp:Literal ID="SurveylitDeclarationUnit" runat="server" ClientIDMode="Static"></asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal12" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal13" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal14" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal15" runat="server" ClientIDMode="Static">√</asp:Literal></td>
                <td>
                    <asp:Literal ID="Literal16" runat="server" ClientIDMode="Static">√</asp:Literal></td>
            </tr>
            <tr>
                <td>2</td>
                <td>
                    <asp:Literal ID="SurveylitDeclarationUnit2" runat="server" ClientIDMode="Static"></asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase2_01" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase2_02" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase2_03" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase2_04" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase2_05" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
            </tr>
            <tr>
                <td>3</td>
                <td>
                    <asp:Literal ID="SurveylitDeclarationUnit3" runat="server" ClientIDMode="Static"></asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase3_01" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase3_02" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase3_03" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase3_04" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase3_05" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
            </tr>
            <tr>
                <td>4</td>
                <td>
                    <asp:Literal ID="SurveylitDeclarationUnit4" runat="server" ClientIDMode="Static"></asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase4_01" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase4_02" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase4_03" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase4_04" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase4_05" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
            </tr>
            <tr>
                <td>5</td>
                <td>
                    <asp:Literal ID="SurveylitDeclarationUnit5" runat="server" ClientIDMode="Static"></asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase5_01" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase5_02" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase5_03" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase5_04" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
                <td>
                    <asp:Literal ID="SurveyCollaborativePhase5_05" runat="server" ClientIDMode="Static" >×</asp:Literal></td>
            </tr>
            <tr>
                <td colspan="13">
                    <label>（此表为建筑类奖项填写，其它专业奖项可参照此表根据不同专业实际情况填写）</label>
                    <br />
                    <br />
                    <label style="color: orange;">注：1. 排序应以承担工作为依据，主申报单位列在首位。合作单位签名盖章表的排序与此表排序相对应。</label>
                    <br />
                    <label style="color: orange;">2. 在承担的栏中填写“√”，在未承担的栏中填写“×”，不应空白。</label>
                </td>
            </tr>
        </table>
    </div> 
</asp:Panel>


<br />
<asp:Panel ID="PanelSignarure" runat="server" GroupingText="合作单位（机构）签名盖章">
    <asp:HiddenField runat="server" ID="hdMsg" ClientIDMode="Static" />
    <table style="width: 90%">
        <tr>
            <td colspan="5" style="font-size: 16px;">合作单位（机构）签名盖章</td>
        </tr>
        <tr>
            <td style="padding-top: 20px;">1</td>
            <td style="padding-top: 20px;">2</td>
            <td style="padding-top: 20px;">3</td>
            <td style="padding-top: 20px;">4</td>
            <td style="padding-top: 20px;">5</td>
        </tr>
        <tr>
            <td style="height: 200px; padding-top: 30px">
                <label>单位法定代表人（签名）：</label>
                <br />
                <br />
                <br />
                <br />
                <label>（单位公章）</label>
                <br />
                <br />
                <br />
            </td>
            <td style="padding-top: 30px">
                <label>单位法定代表人（签名）：</label>
                <br />
                <br />
                <br />
                <br />
                <label>（单位公章）</label>
                <br />
                <br />
                <br />
            </td>
            <td style="padding-top: 30px">
                <label>单位法定代表人（签名）：</label>
                <br />
                <br />
                <br />
                <br />
                <label>（单位公章）</label>
                <br />
                <br />
                <br />
            </td>
            <td style="padding-top: 30px">
                <label>单位法定代表人（签名）：</label>
                <br />
                <br />
                <br />
                <br />
                <label>（单位公章）</label>
                <br />
                <br />
                <br />
            </td>
            <td style="padding-top: 30px">
                <label>单位法定代表人（签名）：</label>
                <br />
                <br />
                <br />
                <br />
                <label>（单位公章）</label>
                <br />
                <br />
                <br />
            </td>
        </tr>
    </table>
    <br />
    <div style="text-align: center; margin-top: 40px;" class="kc">
        <a id="CertificatePrev" class="btnt up">上 一 步</a>
        <a id="CertificateNext" class="btnt up" style="display: none; margin-left: 20px;">下 一 步</a>
        <a id="backPrevPage" href="#" class="btnt up" style="display: none; margin-left: 20px;">返  回</a>           
        <input id="btnSubmit" type="button" value="提 &nbsp;&nbsp;&nbsp;交" class="btnt up" style="margin-right:20px; margin-left: 20px; line-height: 26px;">
    </div>
</asp:Panel>
<script>  
    $(function () {
        $("#CertificateTable tr td input").each(function () {
            $(this).attr("readonly", "readonly");
        })

        var msg = $("#hdMsg").val();
        if (msg != "") {
            ShowMessag(msg);
        }

        var user = $("#txtUserType").val();
        if (user == "0807") {
            $("#btnSubmit").css("display", "none");
            $("#backPrevPage").css("display", "inline-block");
            var backlink = $("#nav02").attr("href")
            //console.log("backlink==" + backlink)
            $("#backPrevPage").attr("href", backlink)
        }
    })
  
    $("#DivisionTable").each(function () {
        $(this).find("input").css("border", "none");
        $(this).find("input").css("background", "#EEEEEE");
        $(this).find("input").attr('disabled', "true");
        $(this).find("input").css("color", "black");
    })
    $("#DivisionTable2").each(function () {
        $(this).find("input").css("border", "none");
        $(this).find("input").css("background", "#EEEEEE");
        $(this).find("input").attr('disabled', "true");
        $(this).find("input").css("color", "black");
    })
    var Division2 = $("#Division2").val();
    var Division3 = $("#Division3").val();
    var Division4 = $("#Division4").val();
    var Division5 = $("#Division5").val();
    var TemplateCode = $("#TemplateCode").val();

    if (TemplateCode == "0216" || TemplateCode == "0217"||TemplateCode == "0218") {
        $(".LastTwo").css("display", "block");
        $(".TopFifteen").css("display", "none");
    }
    if (TemplateCode == "0214")
    {
        $(".TopFifteen").css("display", "none");
        $(".SurveyTable").css("display", "block");
    }
    if (Division2 != "") {
        var strs = new Array();
        strs = Division2.split(",");        
        for (i = 0; i < strs.length; i++) {
            var ee = strs[i].substring(2, 4);
            $("#CollaborativePhase2_" + ee).val("√");           
        }
    }
    if ($("#txtDeclarationUnit2").val() == "") {
        for (i = 1; i < 10; i++) {
            $("#CollaborativePhase2_0" + i).val("");
            $("#CollaborativePhase2_10").val("");
            $("#CollaborativePhase2_11").val("");
        }
    }
    if (Division3 != "") {
        var strs = new Array();
        strs = Division3.split(",");
        for (i = 0; i < strs.length; i++) {
            var ee = strs[i].substring(2, 4);
            $("#CollaborativePhase3_" + ee).val("√");
        }
    }
    if ($("#txtDeclarationUnit3").val() == "") {
        for (i = 1; i < 10; i++) {
            $("#CollaborativePhase3_0" + i).val("");
            $("#CollaborativePhase3_10").val("");
            $("#CollaborativePhase3_11").val("");
        }
    }
    if (Division4 != "") {
        var strs = new Array();
        strs = Division4.split(",");
        for (i = 0; i < strs.length; i++) {
            var ee = strs[i].substring(2, 4);
            $("#CollaborativePhase4_" + ee).val("√");
        }
    }
    if ($("#txtDeclarationUnit4").val() == "") {
        for (i = 1; i < 10; i++) {
            $("#CollaborativePhase4_0" + i).val("");
            $("#CollaborativePhase4_10").val("");
            $("#CollaborativePhase4_11").val("");
        }
    }
    if (Division5 != "") {
        var strs = new Array();
        strs = Division5.split(",");
        for (i = 0; i < strs.length; i++) {
            var ee = strs[i].substring(2, 4);
            $("#CollaborativePhase5_" + ee).val("√");
        }
    }
    if ($("#txtDeclarationUnit5").val() == "") {
        for (i = 1; i < 10; i++) {
            $("#CollaborativePhase5_0" + i).val("");
            $("#CollaborativePhase5_10").val("");
            $("#CollaborativePhase5_11").val("");
        }
    }
</script>
