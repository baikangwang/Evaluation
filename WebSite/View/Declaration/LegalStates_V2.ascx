<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LegalStates_V2.ascx.cs" Inherits="Evaluation.View.Declaration.LegalStates_V2" %>
<asp:Panel ID="PanelLegalStates" runat="server" GroupingText="申报单位法人代表人声明">
        <table style="width:90%">
            <tr>
                <td colspan="4">
                         <div style="width:85%;height:200px;margin:30px auto 0 auto;text-align:left;line-height:35px;font-size:14px;">
                         本人 <u>　<asp:Literal ID="LegalPeopleName" runat="server" ClientIDMode="Static"></asp:Literal>　</u>（法定代表人）&nbsp;&nbsp;&nbsp;
                              <u>　<asp:Literal ID="LegalPeopleNumber" runat="server" ClientIDMode="Static"></asp:Literal>　</u>
                       （身份证号码）郑重声明，本单位申请参加 
                        <u>　<asp:Literal ID="PriceName" runat="server" ClientIDMode="Static"></asp:Literal>　</u> 奖项的评选，其申报表及附件材料填报的全部数据、内容真实，纸质、光盘等媒介资料相符。
                        申报资料如有虚假，本单位将自动退出<asp:Literal runat="server" ID="litAwardName"></asp:Literal> 的评选，并愿接受主管部门根据《全国工程勘察设计行业优秀工程勘察设计行业奖评选办法》所做的处理。<br />
                        
                        </div> 
                </td>
            </tr>
<%--            <tr>
                <td style="width:45%;border-right:none;text-align:left;">　　单位法定代表人（签名）：</td>
                <td style="border:none;">
                    
                </td>
                <td>单位公章：</td>
                <td>
                    
                </td>
            </tr>--%>
           <%-- <tr>
                <td colspan="2">
                    
                </td>
                <td>
                    日期：
                </td> 
                <td>
                    <div class="datepicker input-group date" >
                        <asp:TextBox ID="DeliveryDate" class="form-control" runat="server" ClientIDMode="Static" placeholder="请选择声明日期" style="margin-left:11px;"></asp:TextBox>
                        <span class="input-group-addon" style="width:60px;">　<i class="fa fa-calendar" aria-hidden="true"></i></span> 
                        <asp:CheckBox runat="server" ID="IsPublicDeliveryDate" ClientIDMode="Static" ToolTip="公开" Checked="true" />                                      
                    </div>
                </td> 
           </tr>--%>
        </table>
         <div style="text-align: center; margin-top: 40px;">
             <a  id="LegalStatesPrev" class="btnt up" >上 一 步</a>
             <a  id="LegalStatesNext" class="btnt up" style="margin:0 20px;">下 一 步</a>           
         </div>
         <div style="z-index:1;bottom:10px;right:10px; position:fixed;" id="TOPP"><a href="#top" >置顶</a></div> 
 </asp:Panel>