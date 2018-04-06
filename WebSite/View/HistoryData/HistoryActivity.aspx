<%@ Page Title="活动信息" Language="C#" MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="HistoryActivity.aspx.cs" Inherits="Evaluation.View.HistoryData.HistoryActivity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        input[type="text"]{
            padding: 5px 6px!important;
            border:none;
            border:1px solid #ccc;
            background:#fff;
            margin-right:30px;
        }
        .select{
            width:100%;
            border:1px solid #e1e1e1;
            border-radius:5px;
            padding:10px;
            margin-bottom:15px;

        }
        .ms-choice{
            height:25px;
        }
        .name {
            height:25px;
        }
        .btnH {
            height:25px;
            line-height:25px;
            border-radius:5px;
            padding:0;
            width:78px;
            text-align:center;
        }
        .footer {
          width:434px;margin:20px auto;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">历史数据</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#">活动信息</a>
        </li>        
    </ul>
    <div class="HistoryActivity">
        <div class="select">
            <span>专业：</span>
            <asp:DropDownList runat="server" ID="professional" Height="25px" ClientIDMode="Static" Style="width: 60%;"></asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span>申报奖项：</span>
            <asp:DropDownList runat="server" Height="25px" ID="selectprofessional" ClientIDMode="Static" Style="width: 60%;"></asp:DropDownList>
            <span>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span>项目名称/申报单位：</span>
                <input type="text" placeholder=" 项目名称/申报单位" class="name" /></span>
            <span class="inquire">
                <input type="submit" name="" id="" value="查询" class="btn btnH btn-primary" /></span>
        </div>
        <div class="table-responsive">
            <table class="table table-bordered">
                <tr>
                    <th>
                        <input type="checkbox" /></th>
                    <th>评选年份</th>
                    <th>项目名称</th>
                    <th>申报奖项</th>
                    <th>创建者</th>
                    <th>申报单位</th>
                    <th>最终奖项</th>
                    <th>评审组</th>
                    <th>查看</th>
                    <th>导出</th>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" /></td>
                    <td>北京市优秀建筑工程设计项目申报表</td>
                    <td>综合奖-公共建筑</td>
                    <td>马平</td>

                    <td>北京市设计研究院</td>
                    <td>2015年5月26日</td>
                    <td>2015年5月28日</td>
                    <td>公建一组</td>
                    <td>
                        <a href="#"><i class="fa fa-search" style="color: #008000; font-size: 20px;"></i></a>
                    </td>
                    <td>
                        <i class="fa fa-download" style="color: #FF9900; font-size: 20px;"></i>
                    </td>
                </tr>

                <tr>
                    <td>
                        <input type="checkbox" /></td>
                    <td>北京市优秀建筑工程设计项目申报表</td>
                    <td>综合奖-公共建筑</td>
                    <td>马平</td>

                    <td>北京市设计研究院</td>
                    <td>2015年5月26日</td>
                    <td>2015年5月28日</td>
                    <td>公建一组</td>
                    <td>
                        <a href="#"><i class="fa fa-search" style="color: #008000; font-size: 20px;"></i></a>
                    </td>
                    <td>
                        <i class="fa fa-download" style="color: #FF9900; font-size: 20px;"></i>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" /></td>
                    <td>北京市优秀建筑工程设计项目申报表</td>
                    <td>综合奖-公共建筑</td>
                    <td>马平</td>

                    <td>北京市设计研究院</td>
                    <td>2015年5月26日</td>
                    <td>2015年5月28日</td>
                    <td>公建一组</td>
                    <td>
                        <a href="#"><i class="fa fa-search" style="color: #008000; font-size: 20px;"></i></a>
                    </td>
                    <td>
                        <i class="fa fa-download" style="color: #FF9900; font-size: 20px;"></i>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input type="checkbox" /></td>
                    <td>北京市优秀建筑工程设计项目申报表</td>
                    <td>综合奖-公共建筑</td>
                    <td>马平</td>

                    <td>北京市设计研究院</td>
                    <td>2015年5月26日</td>
                    <td>2015年5月28日</td>
                    <td>公建一组</td>
                    <td>
                        <a href="#"><i class="fa fa-search" style="color: #008000; font-size: 20px;"></i></a>
                    </td>
                    <td>
                        <i class="fa fa-download" style="color: #FF9900; font-size: 20px;"></i>
                    </td>
                </tr>

            </table>
        </div>
        <div class="footer">
            <div class="footerLeft">
                <span>共500，条当前显示条数：</span>
                <select name="" id="">
                    <option value="">10条</option>
                    <option value="" selected = "selected">15条</option>
                    <option value="">20条</option>
                    <option value="">50条</option>
                    <option value="">100条</option>
                </select>
                <span>首页</span>
                <span>上一页</span>
                <span>共一页</span>
                <span>下一页</span>
                <span>尾页</span>
            </div>
            
        </div>
        <%--<div class="foot">
            <input type="submit" value="导出" />
        </div>--%>
    </div>
    <script>
        $("#professional,#selectprofessional").multipleSelect();
    </script>
</asp:Content>
