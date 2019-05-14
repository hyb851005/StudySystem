<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Home.ascx.cs" Inherits="Home" %>
<table width="100%">
    <tr>
        <td style="height: 20px">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" CausesValidation="False">修改个人信息</asp:LinkButton></td>
        <td colspan="2" style="height: 20px">
            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" OnClick="LinkButton8_Click">修改登录密码</asp:LinkButton></td>
      
    </tr> 
    <tr>
     <td  style="height: 20px">
            <asp:LinkButton ID="LinkButton8" runat="server" CausesValidation="False" OnClick="LinkButton8_Click1"  >上传练习题</asp:LinkButton></td>
       <td colspan="2" style="height: 20px">
            <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" OnClick="LinkButton3_Click" >我上传的练习题</asp:LinkButton></td>
 
    </tr>
    
</table>
