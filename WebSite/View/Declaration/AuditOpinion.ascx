<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AuditOpinion.ascx.cs" Inherits="Evaluation.View.Declaration.AuditOpinion" %>

<asp:Panel ID="PanelAuditOpinion" runat="server" GroupingText="审核意见">
        <table style="width:90%">
            <tr>
                <td style="width:200px">
                    曾获奖项
                </td> 
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Style="width: 90%; height: 300px;"></asp:TextBox>
                    <asp:CheckBox runat="server" ID="CheckBox2" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                </td> 
            </tr>
            <tr>
                <td>
                    申报单位<br />
                    意    见
                </td> 
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Style="width: 90%; height: 300px;"></asp:TextBox>
                    <asp:CheckBox runat="server" ID="CheckBox1" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                </td> 
            </tr>
            <tr>
                <td>
                    地方、部门勘察设计同业协会推荐意见
                </td> 
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Style="width: 90%; height: 300px;"></asp:TextBox>
                    <asp:CheckBox runat="server" ID="CheckBox3" ClientIDMode="Static" ToolTip="公开" Checked="true" />
                </td> 
            </tr> 
        </table>
        <asp:Button runat="server" ID="btn_019Prev" ClientIDMode="Static" Text="上 一 步" OnClick="btnAuditOpinionSave_Click" />
        <asp:Button runat="server" ID="btn_019Next" ClientIDMode="Static" Text="下 一 步" OnClick="btnAuditOpinionSave_Click" />      
    </asp:Panel>










