<%@ Page Title="会员投票" MasterPageFile="~/View/Mutual/Site.Master" Language="C#"  AutoEventWireup="true" CodeBehind="LeaguerVote.aspx.cs" Inherits="Evaluation.View.LeaguerElect.LeaguerVote" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="navs">
        <li class="nav1" id="main" style="float:left;padding-right:5px;">           
          <a href="#">会员海选</a>
          <span style="padding-left:5px;">&gt;</span>
         </li>
        <li class="nav1" style="float:left;padding-right:5px;">           
          <a href="#">会员投票</a>
        </li>        
    </ul>
    <div class="LeaguerVote">
        <div class="but">
            <input type="button" value="会员投票" />
            <input type="button" value="已投项目" />
            <input type="button" value="未投项目" />
        </div>

        <div class="select">
            <span>请选择要投票的奖项：
			    <select name="" id="professional">
                    <option value="">请选择</option>
                    <option value="">建筑</option>
                    <option value="">市政</option>
                </select>
            </span>

            <span>
                <input type="submit" name="" id="" value="查询" /></span>
        </div>
        <div class="prompt">
            <i class="fa fa-bell " style="font-size: 18px;"></i>
            <span>您有50张票，已投30张</span>
        </div>
        <div class="table-responsive">
            <table class="table table-bordered">
                <tr>
                    <th>序号</th>
                    <th>项目名称</th>
                    <th>申报单位</th>
                    <th>奖项</th>
                    <th>推荐</th>
                </tr>
                <tr>
                    <td>1</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京北林地景园林规划设计院有限责任公司</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class=" fa fa-gittip" style="color: red; font-size: 20px;"></i>
                    </td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京北林地景园林规划设计院有限责任公司</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class=" fa fa-gittip" style="color: #999999; font-size: 20px;"></i>
                    </td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京北林地景园林规划设计院有限责任公司</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class=" fa fa-gittip" style="color: red; font-size: 20px;"></i>
                    </td>
                </tr>
                <tr>
                    <td>4</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京北林地景园林规划设计院有限责任公司</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class=" fa fa-gittip" style="color: red; font-size: 20px;"></i>
                    </td>
                </tr>
                <tr>
                    <td>5</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京北林地景园林规划设计院有限责任公司</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class=" fa fa-gittip" style="color: red; font-size: 20px;"></i>
                    </td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京北林地景园林规划设计院有限责任公司</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class=" fa fa-gittip" style="color: #999999; font-size: 20px;"></i>
                    </td>
                </tr>
                <tr>
                    <td>1</td>
                    <td>
                        <a href="##">翠湖国家城市湿地公园</a>
                    </td>
                    <td>北京北林地景园林规划设计院有限责任公司</td>
                    <td>综合奖-公共建筑</td>
                    <td>
                        <i class=" fa fa-gittip" style="color: red; font-size: 20px;"></i>
                    </td>
                </tr>
            </table>
        </div>
        <div class="footer">
            <div class="footerLeft">
                <span>共500，条当前显示条数：</span>
                <select name="" id="">
                    <option value="">10条</option>
                    <option value="">20条</option>
                    <option value="">50条</option>
                    <option value="">100条</option>
                </select>
            </div>
            <div class="footerRight">
                <span>首页</span>
                <span>上一页</span>
                <span>共一页</span>
                <span>下一页</span>
                <span>尾页</span>
            </div>
        </div>
        <div class="foot">
            <input type="submit" name="name" value="提交 " />
        </div>
    </div>
</asp:Content>
