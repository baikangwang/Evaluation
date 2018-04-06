<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ParticipantReview.ascx.cs" Inherits="Evaluation.View.Declaration.ParticipantReview1" %>
<style>
    #ContentPlaceHolder1_ucParticipant_tblParticipant .ms-parent {
    width:100px !important;
    height:25px!important;
    margin-bottom:3px;
}
   .ms-parent input {
    width:20%!important;
}
   input::-ms-clear{display:none;}
</style>
   <asp:Panel runat="server"  ClientIDMode="Static" ID="panelParticipant" >
       <h2 style="text-align:center">在本项目中做出贡献的主要人员情况表</h2>
        <table id="tblParticipant" style="width:90%">
            <tr>
                <td >序号</td>
                <td >姓名</td>
                <td >职称</td>
                <td >专业</td>
                <td>设计职务及设计中<br />主要负责何项工作</td>
                <td style="width:13%;">证件类别</td>
                <td>证件号</td>
                <td>工作单位</td>
            </tr>
            <tbody id="tblist"></tbody>
            
        </table>
       <br />
       <br />
       <p style="margin:0 0 0 58px;">
           注：<br />
           1、主要设计人员排序按照设计中所起作用的原则，不按技术职务职称；<br />
           2、境外设计人员可不填写此表；<br />
           3、项目人员总数原则上不超过<asp:Label ID="PeopleNum" runat="server" ClientIDMode="Static"></asp:Label>人。
       </p> 
       <div style="text-align: center; margin-top: 40px;">
           <a onclick="javascript:onPrev('02')" href="#tab_03" class="btnt up" style="margin-left: 20px;">上 一 步</a>
           <a onclick="javascript:onNext('02')" href="#tab_03" class="btnt up" style="margin:0 20px;">下 一 步</a>          
       </div>
       <script>
           function setPart2Data(data) {
               var ParticipantLimit = JSON.parse(data)[0].ParticipantLimit
               $("#PeopleNum").text(ParticipantLimit)
               data = JSON.parse(data)[2];             
               if (data) {
                   var times = ParticipantLimit ? ParticipantLimit : data.length;
                   $("#tblist").empty();
                   for (var i = 0; i < times; i++) {
                       var index = i + 1;
                       var ParticipantName = data[i] ? data[i].ParticipantName : "";
                       var AcademicTitle = data[i] ? data[i].AcademicTitle : "";
                       var Speciality = data[i] ? data[i].Speciality : "";
                       var Duties = data[i] ? data[i].Duties : "";
                       var IDTypeName = data[i] ? data[i].IDTypeName : "";
                       var IDNumber = data[i] ? data[i].IDNumber : "";
                       var Workplace = data[i] ? data[i].Workplace : "";
                       var item = "<tr>" +
                           "<td>" + index + "</td>" +
                           "<td>" + ParticipantName + "</td>" +
                           "<td>" + AcademicTitle + "</td>" +
                           "<td>" + Speciality + "</td>" +
                           "<td>" + Duties + "</td>" +
                           "<td>" + IDTypeName + "</td>" +
                           "<td>" + IDNumber + "</td>" +
                           "<td>" + Workplace + "</td>" +
                           "<tr>"
                       $("#tblist").append(item);

                   }
               }
           }
       </script>
    </asp:Panel>