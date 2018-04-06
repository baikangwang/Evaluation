<%@ Page Title="申报申明" Language="C#"  MasterPageFile="~/View/Mutual/Site.Master" AutoEventWireup="true" CodeBehind="Declare.aspx.cs" Inherits="Evaluation.View.Declaration.Declare" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #declare{text-align:center;font-size:14px;}   
        #cbOK{margin-top:20px;} 

        .btn-primary{background-color:#35B4BF;border-color:#35B4BF; width:80px;}
        .btn-primary:hover, .btn-primary:focus, .btn-primary:active, .btn-primary.active, .open .dropdown-toggle.btn-primary{
            background-color:#35B4BF;border-color:#35B4BF;}

        #ContentPlaceHolder1_Button1:focus{
            background-color: #35B4BF;
         
            color:#fff;
        }
        #ContentPlaceHolder1_Button1{
            width:78px;height:25px;padding:1px 9px;
        }
        label{
            font-size:16px!important;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div  style="display:none"><input type="text" runat="server" id="txtSepcCode" ClientIDMode="Static"/></div> 
      <div id="declare">
          <div style="padding-top:140px;">
        <p style="color:red;font-size:21px;padding:0 50px;" id="about">          
         
        </p>
        <br />
        <br />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="&nbsp;&nbsp;同意"/>
        <p style="margin-top:50px">
           <asp:Button ID="Button1" runat="server" Text="下 一 步" OnClientClick="return agreement()" class="btnt" OnClick="btnNext_Click" />
        </p>
    </div>
 </div>
    <script>
        var strActivityType = '<%=Session["ActivityType"].ToString() %>';
        if (strActivityType == "0101") {
            $('#about').text("声明：本次申报活动，以网上申报内容为准，敬请留意 。");          
        } else {
            $('#about').text("声明：本次行业优评选，以网上申报内容为准，申报单位对填报信息准确性、真实性负责，组织和评审人员无权修改数据。");
        }
        function agreement()
        {
            
            if (document.getElementById("ContentPlaceHolder1_CheckBox1").checked) {
                var flag = true;
                $.ajax({
                    url: '../Mutual/Declaration.ashx',
                    type: "post",
                    async: false,
                    data: { "Action": "GetPrize", "SepcCode": $("#txtSepcCode").val() },
                    success: function (data) {
                            data = JSON.parse(data);
                            ShowMessag(data);
                            flag = false;                   
                        },              
                    error: function (e) {
                        flag = true;
                    }
                })
                if (flag) {
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                ShowMessag("请确认本次申报活动，以网上申报内容为准。");
                return false;
            }
        }
    </script>
</asp:Content>
