<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Schedule.ascx.cs" Inherits="Evaluation.View.ActivityManage.Schedule" %>
    <div>
        <br />
        <label>请设置控制节点：</label>
        <table class="table table-bordered table-hover" id="Table" style="border:1px solid #ccc;">
            <tr>
                <th style="width:55px;height:40px;">编号</th>
                <th style="width:100px;">控制节点名称</th>
                <th>开始时间</th>
                <th>结束时间</th>
                <th style="width:170px;">阶段设置</th>
                <th style="width:200px;">是否自动开始</th>
                <th style="width:200px;">是否自动关闭</th>
            </tr>
            <tr style="background:#fff;">
                <td>1</td>
                <td>申报开关</td>
                <td>
                    <div class="datepicker input-group date">
                        <asp:TextBox ID="txtDeclarationBeginDate" ClientIDMode="Static" runat="server"
                            class="form-control" placeholder="请选择申报开始日期">
                        </asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                </td>
                <td>
                    <div class="datepicker input-group date">
                        <asp:TextBox ID="txtDeclarationEndDate" ClientIDMode="Static" runat="server"
                            class="form-control" placeholder="请选择申报结束日期">
                        </asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                </td>
                <td>
                    <label>开始申报：</label>
                     <%--<input type="checkbox" runat="server" id="cbIsDeclarationStart" ClientIDMode="Static" class="StartEnd" />--%>
                   <asp:DropDownList runat="server" ID="ddlIsDeclarationStart" ClientIDMode="Static">
                       <asp:ListItem Value="True">是</asp:ListItem>
                       <asp:ListItem Value="False">否</asp:ListItem>
                   </asp:DropDownList>
                </td>
                <td>
                    <label>自动开启申报：</label>
                    <%--<input type="checkbox" runat="server" id="cbIsDeclarationAutoStart" ClientIDMode="Static" class="OnOff" />--%>
                    <asp:DropDownList runat="server" ID="ddlIsDeclarationAutoStart" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>

                </td>
                <td>
                    <label>自动结束申报：</label>
                    <%--<input type="checkbox" runat="server" ID="cbIsDeclarationAutoEnd" ClientIDMode="Static" class="OnOff" />--%>
                    <asp:DropDownList runat="server" ID="ddlIsDeclarationAutoEnd" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="display:none">
                <td>2</td>
                <td>海选开关</td>
                <td>
                    <div class="datepicker input-group date">
                        <asp:TextBox ID="txtPrimaryElectionBeginDate" ClientIDMode="Static" runat="server"
                            class="form-control" placeholder="请选择海选开始日期">
                        </asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                </td>
                <td>
                    <div class="datepicker input-group date">
                        <asp:TextBox ID="txtPrimaryElectionEndDate" ClientIDMode="Static" runat="server"
                            class="form-control" placeholder="请选择海选结束日期">
                        </asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                </td>
                <td>
                    <label>开始海选：</label>
                     <%--<input type="checkbox" runat="server" ID="cbIsPrimaryElectionStart" ClientIDMode="Static" class="StartEnd" />--%>
                   <asp:DropDownList runat="server" ID="ddlIsPrimaryElectionStart" ClientIDMode="Static">
                       <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                   </asp:DropDownList>
                </td>
                <td>
                    <label>自动开始海选：</label>
                    <%--<input type="checkbox" runat="server" ID="cbIsPrimaryElectionAutoStart" ClientIDMode="Static" class="OnOff" />--%>
                    <asp:DropDownList runat="server" ID="ddlIsPrimaryElectionAutoStart" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <label>自动结束海选：</label>
                    <%--<input type="checkbox" runat="server" ID="cbIsPrimaryElectionAutoEnd" ClientIDMode="Static" class="OnOff" />--%>
                    <asp:DropDownList runat="server" ID="ddlIsPrimaryElectionAutoEnd" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background:#EDEDED;">
                <td>2</td>
                <td>专家评审开关</td>
                <td>
                    <div class="datepicker input-group date">
                        <asp:TextBox ID="txtExpertReviewBeginDate" ClientIDMode="Static" runat="server"
                            class="form-control" placeholder="请选择评审开始日期">
                        </asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                </td>
                <td>
                    <div class="datepicker input-group date">
                        <asp:TextBox ID="txtExpertReviewEndDate" ClientIDMode="Static" runat="server"
                            class="form-control" placeholder="请选择评审结束日期">
                        </asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                </td>
                <td>
                    <label>开始评审：</label>
                     <%--<input type="checkbox" runat="server" ID="cbIsExpertReviewStart" ClientIDMode="Static" class="StartEnd" />--%>
                   <asp:DropDownList runat="server" ID="ddlIsExpertReviewStart" ClientIDMode="Static">
                       <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                   </asp:DropDownList>
                </td>
                <td>
                    <label>自动开始评审：</label>
                    <%--<input type="checkbox" runat="server" ID="cbIsExpertReviewAutoStart" ClientIDMode="Static" class="OnOff" />--%>
                    <asp:DropDownList runat="server" ID="ddlIsExpertReviewAutoStart" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <label>自动结束评审：</label>
                    <%--<input type="checkbox" runat="server" ID="cbIsExpertReviewAutoEnd" ClientIDMode="Static" class="OnOff" />--%>
                    <asp:DropDownList runat="server" ID="ddlIsExpertReviewAutoEnd" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background:#fff;">
                <td>3</td>
                <td>下载开关</td>
                <td>
                    <div class="datepicker input-group date">
                        <asp:TextBox ID="txtDownloadBeginDate" ClientIDMode="Static" runat="server"
                            class="form-control" placeholder="请选择下载开始日期">
                        </asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                </td>
                <td>
                    <div class="datepicker input-group date">
                        <asp:TextBox ID="txtDownloadEndDate" ClientIDMode="Static" runat="server"
                            class="form-control" placeholder="请选择下载结束日期">
                        </asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                </td>
                <td>
                    <label>开始下载：</label>
                     <%--<input type="checkbox" runat="server" ID="cbIsDownloadStart" ClientIDMode="Static" class="StartEnd" />--%>
                   <asp:DropDownList runat="server" ID="ddlIsDownloadStart" ClientIDMode="Static">
                       <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                   </asp:DropDownList>
                </td>
                <td>
                    <label>自动开始下载：</label>
                    <%--<input type="checkbox" runat="server" ID="cbIsDownloadAutoStart" ClientIDMode="Static" class="OnOff" />--%>
                    <asp:DropDownList runat="server" ID="ddlIsDownloadAutoStart" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <label>自动结束下载：</label>
                    <%--<input type="checkbox" runat="server" ID="cbIsDownloadAutoEnd" ClientIDMode="Static" class="OnOff" />--%>
                    <asp:DropDownList runat="server" ID="ddlIsDownloadAutoEnd" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>4</td>
                <td>投票开关</td>
                <td>
                    <div class="datepicker input-group date">
                        <asp:TextBox ID="txtVoteBeginDate" ClientIDMode="Static" runat="server"
                            class="form-control" placeholder="请选择投票开始日期">
                        </asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                </td>
                <td>
                    <div class="datepicker input-group date">
                        <asp:TextBox ID="txtVoteEndDate" ClientIDMode="Static" runat="server"
                            class="form-control" placeholder="请选择投票结束日期">
                        </asp:TextBox>
                        <span class="input-group-addon"><i class="fa fa-calendar" aria-hidden="true"></i></span>
                    </div>
                </td>
                <td>
                    <label>开始投票：</label>
                   <asp:DropDownList runat="server" ID="ddlIsVoteStart" ClientIDMode="Static">
                       <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                   </asp:DropDownList>
                </td>
                <td>
                    <label>自动开始投票：</label>
                    <asp:DropDownList runat="server" ID="ddlIsVoteAutoStart" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <label>自动结束投票：</label>
                    <asp:DropDownList runat="server" ID="ddlIsVoteAutoEnd" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr style="background:#EDEDED;border-bottom:1px solid #ccc;">
                <td>5</td>
                <td>等票复投开关</td>
                <td></td>
                <td></td>
                <td>
                    <label>开始复投：</label>
                    <%--<input type="checkbox" runat="server" ID="cbIsReVoteStart" ClientIDMode="Static" class="StartEnd" />--%>
                    <asp:DropDownList runat="server" ID="ddlIsReVoteStart" ClientIDMode="Static">
                        <asp:ListItem Value="True">是</asp:ListItem>
                        <asp:ListItem Value="False">否</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td></td>
                <td></td>
            </tr> 
            <tr>  
                <td style="display:none;">       
                    <asp:Button ID="lkbSetSchedule" runat="server" ClientIDMode="Static" OnClick="btnSetSchedule_Click" Width="0px"/>
               </td> 
            </tr> 
            <tr>  
                 <td colspan="7"  class="inpcheck" style="background:#EDEDED;border:1px solid #eee;border-top:1px solid #ccc;"> 
           <input id="inpcheck" type="button" value="保 &nbsp;存" class="btnt" onclick="personalDate()" />
              </td> 
            </tr>                                         
        </table>
       
    <script>       
        function personalDate() {
         
            var pathname=window.location.pathname.split("/")                 
            var pagename=pathname.slice(pathname.length-1, pathname.length).toString(String);
            //console.log(pagename)         
            if(pagename=="SpecialtySet"){
                 ShowMessags("是否单独设置时间表？");
                 $(".layui-layer-btn0").click(function () {
                     //$("#lkbSetSchedule").click();
                     $("#<%=lkbSetSchedule.ClientID%>").click();
                   });
            } else {
               //console.log(<%=lkbSetSchedule.ClientID%>)
                $("#<%=lkbSetSchedule.ClientID%>").click();
            }

           
        }
    </script>
    </div>

