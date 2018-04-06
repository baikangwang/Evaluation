<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DivisionTable.ascx.cs" Inherits="Evaluation.View.Declaration.DivisionTable" %>

 <asp:Panel ID="PanelDivision" runat="server" GroupingText="合作设计项目分工表">
        <table id="DivisionTable">
            <tr>
                <td colspan="13" style="text-align: center;font-size:18px;">合作设计项目分工表</td>
            </tr>
            <tr>
                <td style="width:50px;">排序</td>
                <td style="width:170px">勘察设计单位（全称）</td>
                <td>概念性方案设计</td>
                <td>方案设计(建筑)</td>
                <td>方案设计(结构)</td>
                <td>初步设计(建筑)</td>
                <td>初步设计(结构)</td>
                <td>初步设计(设备)</td>
                <td>初步设计(电气)</td>
                <td>施工图设计<br />(建筑)</td>
                <td>施工图设计<br />(结构)</td>
                <td>施工图设计<br />(设备)</td>
                <td>施工图设计<br />(电气)</td>
            </tr>
            <tr>
                <td>1</td>
                <td>
                    <asp:Literal ID="DeclarationUnit" runat="server" ClientIDMode="Static" ></asp:Literal></td>
                <td>
                    <asp:TextBox ID="TextBox301" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox302" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox303" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox304" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox305" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox306" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox307" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox308" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox309" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox310" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox311" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>2</td>
                <td>
                    <asp:Literal ID="DeclarationUnit2" runat="server" ClientIDMode="Static" ></asp:Literal></td>
                <td>
                    <asp:TextBox ID="TextBox314" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox315" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td> 
                    <asp:TextBox ID="TextBox316" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox317" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox318" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox319" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox320" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox321" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox322" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox323" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox324" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>3</td>
                <td>
                    <asp:Literal ID="DeclarationUnit3" runat="server" ClientIDMode="Static" ></asp:Literal></td>
                <td>
                    <asp:TextBox ID="TextBox327" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox328" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox329" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox330" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox331" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox332" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox333" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox334" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox335" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox312" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox336" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>4</td>
                <td>
                    <asp:Literal ID="DeclarationUnit4" runat="server" ClientIDMode="Static" ></asp:Literal></td>
                <td>
                    <asp:TextBox ID="TextBox340" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox341" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox342" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox343" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox344" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox345" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox346" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox347" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox348" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox349" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox350" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>5</td>
                <td>
                    <asp:Literal ID="DeclarationUnit5" runat="server" ClientIDMode="Static" >111</asp:Literal></td>
                <td>
                    <asp:TextBox ID="TextBox353" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox354" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox355" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox356" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox357" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox358" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox359" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox360" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox361" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox362" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
                <td>
                    <asp:TextBox ID="TextBox363" runat="server" ClientIDMode="Static" width="50%"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="13">
                    <label>（此表为建筑类奖项填写，其它专业奖项可参照此表根据不同专业实际情况填写）</label>
                    <br />
                    <br />
                    <label style="color:orange;">注：1. 排序应以承担工作为依据，主申报单位列在首位。合作单位签名盖章表的排序与此表排序相对应。</label>
                    <br />
                    <label style="color:orange;">    2. 在承担的栏中填写“√”，在未承担的栏中填写“×”，不应空白。</label>
                </td>
            </tr>
        </table>
        <asp:Button runat="server" ID="btn_017Prev" ClientIDMode="Static" Text="上一步" OnClick="btnDivisionTablePrev_Click" />
        <asp:Button runat="server" ID="btn_017Next" ClientIDMode="Static" Text="下一步" OnClick="btnDivisionTableNext_Click" />             
</asp:Panel>


<script>
    $(function () {
        $("#DivisionTable tr td input").each(function () {
            $(this).attr("readonly", "readonly");
        })

    })
</script>





