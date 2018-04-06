<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrderSheet.ascx.cs" Inherits="Evaluation.View.Declaration.OrderSheet" %>
 <asp:Panel ID="PanelOrderSheet" runat="server" GroupingText="申报项目次序表">
        <table style="width:90%" >
            <tr>
                <td colspan="3" style="font-size:16px;">申报项目次序表</td>
            </tr>
            <tr>
                <td colspan="3">
                    <p style="float:left; font-size:15px;">　奖项名称:</p>
                   <%-- <asp:RadioButtonList runat="server" ID="rdlPrize" Height="38px">
                    </asp:RadioButtonList>--%>
                    <u><p style="text-align:left; font-size:15px;"><asp:Literal ID="rdlPrize" runat="server" ClientIDMode="Static"></asp:Literal></p> </u> 
                </td>
            </tr>               
            <tr >               
                <td style="width:100px;">本奖项排序</td>
                <td colspan="2">项目名称</td>
            </tr>
            <tr>
                <td>1</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox277" runat="server" ClientIDMode="Static" Width="96.7%">中国网通科研中心（亦庄二期）</asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>2</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox279" runat="server" ClientIDMode="Static" Width="96.7%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>3</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox281" runat="server" ClientIDMode="Static" Width="96.7%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>4</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox283" runat="server" ClientIDMode="Static" Width="96.7%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>5</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox285" runat="server" ClientIDMode="Static" Width="96.7%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>6</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox287" runat="server" ClientIDMode="Static" Width="96.7%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>7</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox289" runat="server" ClientIDMode="Static" Width="96.7%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>8</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox291" runat="server" ClientIDMode="Static" Width="96.7%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>9</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox293" runat="server" ClientIDMode="Static" Width="96.7%"></asp:TextBox></td>
            </tr>
            <tr>
                <td>10</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox295" runat="server" ClientIDMode="Static" Width="96.7%"></asp:TextBox></td>
            </tr>
            <tr>                    
                <td colspan="2">单位公章：</td>
                <td><asp:TextBox ID="TextBox296" runat="server" Width="96.7%"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">日期：</td> 
                <td>
                    <div class="datepicker input-group date" >
                        <asp:TextBox ID="FireControlRecordDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择日期" style="margin-left:20px;"></asp:TextBox>
                        <span class="input-group-addon" style="width:60px;">　<i class="fa fa-calendar" aria-hidden="true"></i></span> 
                        <asp:CheckBox runat="server" ID="IsPublicFireControlRecordDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />                                      
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="3" style="text-align: left; padding-left:10px;">注：每个奖项填制一份表格。</td>
            </tr>
        </table>
        <div style="text-align: center; margin-top: 40px;">
            <a onclick="javascript:onSave('OrderSheet','Save')" class="btnt">保存</a>
            <a onclick="javascript:onSave('OrderSheet');onPrev('14')" id="OrderSheetPrev" class="btnt">上一步</a>           
        </div> 
        
    </asp:Panel>
