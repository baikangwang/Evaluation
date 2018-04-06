<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CertificateReview.ascx.cs" Inherits="Evaluation.View.Declaration.CertificateReview" %>
<asp:Panel runat="server" ClientIDMode="Static" ID="PanelCertificate">
    <h2 style="text-align:center">合作勘察设计项目合作声明</h2>
    <table style="width: 90%" id="CertificateTable">
        <tr>
            <td>
                <div style="width: 85%; height: 200px; margin: 30px auto 0 auto; text-align: left; line-height: 35px; font-size: 14px;">
                    <u>
                        <span ID="DeclarationName6"  ></span>

                    </u>
                    工程项目为我们合作完成，我们各方均同意以
                    <u>
                        <span ID="DeclarationUnit6"  ></span>

                    </u> （单位）
                    为主申报单位，参加
                    <u id="uPrize6" >
                    </u> 
                    评选。
                    <br />
                    <br />
                    特此声明。
                </div>
            </td>
        </tr>
    </table>
</asp:Panel>
<br />

<asp:Panel runat="server" ClientIDMode="Static" ID="PanelDivision" >
    <div style="display: none;">
        <input id="Division2" type="text"   /></div>
    <div style="display: none;">
        <input id="Division3" type="text"   /></div>
    <div style="display: none;">
        <input id="Division4" type="text"   /></div>
    <div style="display: none;">
        <input id="Division5" type="text"   /></div>
    <div style="display: none;">
        <input id="TemplateCode" type="text"   /></div>
    <div style="display: none;">
        <input id="IsAllowUpdate" type="text"   /></div>
    <div class="TopFifteen" id="DivisionTablewarp">
        <table id="DivisionTable">
            <tr>
                <td colspan="13" style="text-align: center; font-size:18px; font-weight:700">合作设计项目分工表</td>
            </tr>
            <tr>
                <td style="width: 50px;">排序</td>
                <td style="width: 170px">勘察设计单位（全称）</td>
                <td>概念性方案设计</td>
                <td>方案设计(建筑)</td>
                <td>方案设计(结构)</td>
                <td>初步设计(建筑)</td>
                <td>初步设计(结构)</td>
                <td>初步设计(设备)</td>
                <td>初步设计(电气)</td>
                <td>施工图设计<br />
                    (建筑)</td>
                <td>施工图设计<br />
                    (结构)</td>
                <td>施工图设计<br />
                    (设备)</td>
                <td>施工图设计<br />
                    (电气)</td>
            </tr>
            <tbody id="Divisiontable">

            </tbody>
            
            
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
    <div class="Survey" id="DivisionTable3warp" style="display: none; text-align:center">
        <table id="DivisionTable3">
            <tr>
                <td colspan="7" style="text-align: center; font-size:18px; font-weight:700">合作设计项目分工表</td>
            </tr>
            <tr>
                <td style="width: 50px;">排序</td>
                <td style="width: 170px">勘察设计单位（全称）</td>
                <td>岩土工程勘察</td>
                <td>岩土工程设计</td>
                <td>岩土工程检测</td>
                <td>岩土工程监测</td>
                <td>岩土工程咨询</td>              
            </tr>
            <tbody id="Divisiontable3">

            </tbody>
            
            
            <tr>
                <td colspan="7">
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
    <div class="LastTwo" id="DivisionTable2warp" style="display: none; text-align:center">
        <span style="font-size:20px; display:inline-block;padding-bottom:20px;">合作设计项目分工表 </span>
        <table id="DivisionTable2">
            <tr>
                <td>排序
                </td>
                <td>申报单位
                </td>
                <td>承担工作
                </td>
            </tr>
            <tr>
                <td>1
                </td>
                <td>
                    <asp:Label runat="server" ClientIDMode="Static" ID="txtCooperationUnit1"  ></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ClientIDMode="Static" ID="txtUndertakeWork1"  >/</asp:Label>
                </td>
            </tr>
            <tr>
                <td>2
                </td>
                <td>
                    <asp:Label runat="server" ClientIDMode="Static" ID="txtCooperationUnit2"  ></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ClientIDMode="Static" ID="txtUndertakeWork2"  ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>3
                </td>
                <td>
                    <asp:Label runat="server" ClientIDMode="Static" ID="txtCooperationUnit3"  ></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ClientIDMode="Static" ID="txtUndertakeWork3"  ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>4
                </td>
                <td>
                    <asp:Label runat="server" ClientIDMode="Static" ID="txtCooperationUnit4"  ></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ClientIDMode="Static" ID="txtUndertakeWork4"  ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>5
                </td>
                <td>
                    <asp:Label runat="server" ClientIDMode="Static" ID="txtCooperationUnit5"  ></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ClientIDMode="Static" ID="txtUndertakeWork5"  ></asp:Label>
                </td>
            </tr>
        </table>
    </div>
</asp:Panel>


<br />
<asp:Panel runat="server" ClientIDMode="Static" ID="PanelSignarure" >
    <asp:HiddenField  runat="server" ClientIDMode="Static" ID="hdMsg"  />
    <table style="width: 90%">
        <tr>
            <td colspan="5" style="font-size:18px; font-weight:700">合作单位（机构）签名盖章</td>
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
        <a  id="backPrevPage" class="btnt up" style="margin-left: 20px;">返 &nbsp;&nbsp;&nbsp; 回</a>
        <input id="btnSubmit" type="button" value="提 &nbsp;&nbsp;交" class="btnt up" style="margin-right:20px; margin-left: 20px; line-height: 26px;">       
    </div>
    <script type="text/javascript">
        var currentcolumn = JSON.parse($.cookie('currentPage'))
        if (currentcolumn && currentcolumn.column2Link) {
            $("#backPrevPage").attr("href", currentcolumn.column2Link)
        } else {
            $("#backPrevPage").attr("href", "../../View/Mutual/HomePage");
        }
    </script>
</asp:Panel>