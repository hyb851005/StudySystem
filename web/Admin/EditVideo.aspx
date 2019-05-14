<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditVideo.aspx.cs" ValidateRequest="false" EnableEventValidation="false"  Inherits="Admin_EditVideo" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link rel="stylesheet" type="text/css" href="skin/css/base.css"/>
</head>
<body >
    <form id="form1" runat="server">
    <div>
    <table width="98%" border="0" cellpadding="0" cellspacing="1" bgcolor="#e3ebfe" align="center">
<tr>
 <td height="26" >
  <table width="98%" border="0" cellspacing="0" cellpadding="0">
  <tr>
  <td align="center" style="height: 22px">
      修改视频</td>
 </tr>
</table>
</td>
</tr>
</table>
    </div>
        <table align="center" bgcolor="#e3ebfe" border="0" cellpadding="2" cellspacing="1"
            style="margin-top: 8px" width="98%">
                <tr>
               
               <td style="WIDTH: 3%; HEIGHT: 21px" class="td2" align="center">
                   视频名称：</td>
               <td style="HEIGHT: 21px" class="td2" colspan="3">
              <asp:TextBox ID="TextBox1" runat="server" CssClass="label" Width="558px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="请输入视频名称"></asp:RequiredFieldValidator>
              </td>
               
               </tr>
             <tr>
                 <td align="center" class="td2" style="width: 3%; height: 21px">
                     上传视频：</td>
                 <td align="left" class="td2" colspan="3" style="height: 21px">
                     <asp:TextBox ID="pic" runat="server" CssClass="inputBox" ReadOnly="True" Width="72px"></asp:TextBox><input
                         id="file1" runat="server" class="inputBox" style="width: 141px" type="file" /><asp:Button
                             ID="Button2" runat="server" CausesValidation="False" CssClass="formbutton" Height="22px"
                             OnClick="Button1_Click" Text="上传视频" Width="58px" /><asp:Label ID="Label1" runat="server"
                                 Visible="False"   ></asp:Label>SWF格式<input id="Hidden1" runat="server" type="hidden" /></td>
             </tr>
               
                     <tr>
                <td align="center" class="td2" style="width: 3%; height: 105px">
                    上传视频截图：</td>
                <td align="left" class="td2" colspan="3" style="height: 105px">
                    <asp:Image ID="Image1" runat="server" Width="134px" /><br />
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="inputBox" ReadOnly="True" Width="72px"></asp:TextBox><input
                        id="File2" runat="server" class="inputBox" style="width: 141px" type="file" /><asp:Button
                            ID="Button3" runat="server" CausesValidation="False" CssClass="formbutton" Height="22px"
                            OnClick="Button3_Click" Text="上传图片" Width="89px" /><asp:Label ID="Label2" runat="server"
                                Visible="False"   ></asp:Label>
                </td>
            </tr>
                <tr>
           
               <td style="WIDTH: 3%; HEIGHT: 54px" class="td2" align="center">
                   视频说明：</td>
               <td style="WIDTH: 23%; HEIGHT: 54px" class="td2"  colspan="7">
                   <FCKeditorV2:FCKeditor ID="ArticleContent" runat="server" BasePath="~/FCKeditor/">
                       &nbsp;</FCKeditorV2:FCKeditor>
               </td>       
            
             </tr>
            <tr bgcolor="#e7e7e7">
                <td align="center" colspan="10" height="24">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="修改" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
