<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddVideo.aspx.cs"  ValidateRequest="false" EnableEventValidation="false"  Inherits="Admin_AddVideo" %>

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
      添加视频</td>
 </tr>
</table>
</td>
</tr>
</table>
    </div>
        <table align="center" bgcolor="#e3ebfe" border="0" cellpadding="2" cellspacing="1"
            style="margin-top: 8px" width="98%">
                <tr>
               
               <td style="WIDTH: 100px; HEIGHT: 21px" class="td2" align="center">
                   视频名称：</td>
               <td style="HEIGHT: 21px" class="td2" colspan="3">
              <asp:TextBox ID="TextBox1" runat="server" CssClass="label" Width="558px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="请输入视频名称"></asp:RequiredFieldValidator>
              </td>
               
               </tr>
             <tr>
                 <td align="center" class="td2" style=" height: 50px">
                     上传视频：</td>
                 <td align="left" class="td2" colspan="3" style="height: 50px">
                 <div style="padding:5px; border:1px dashed #ccc; clear:both;">
                    <div  style="clear:both;">
                    <div style="float:left;">
                  请选择视频：   <input id="file1" runat="server" class="inputBox" style1="width: 141px" type="file" />
                     </div>
                    <div style="float:left; margin-left:5px;">
                     <asp:Button ID="Button2" runat="server" CausesValidation="False" CssClass="formbutton" Height="22px"
                             OnClick="Button1_Click" Text="上传视频" />
                            </div>
                    <div style="float:left;margin-left:5px; color:#ff0000;">     
                             <asp:Label ID="Label1" runat="server"
                                 Visible="False"   ></asp:Label>注：请上传SWF格式文件<input id="Hidden1" runat="server" type="hidden" />
                                 
                     </div>   
                     </div>
                     <div style="clear:both; margin-top:5px;">
                     上传文件名：
                     <asp:TextBox ID="pic"  runat="server" CssClass="inputBox" ReadOnly="True" Width="200px"></asp:TextBox>
                     </div></div>
                     
                     <br /> 
                </td>
             </tr>
            <tr>
                <td align="center" class="td2" >
                    上传视频截图：</td>
                <td align="left" class="td2" colspan="3" >
                
                 <div style="padding:5px; border:1px dashed #ccc; clear:both;">
                请选择图片：<input id="File2" runat="server" class="inputBox" type="file" />
                &nbsp;&nbsp;<asp:Button ID="Button3" runat="server" CausesValidation="False" CssClass="formbutton" Height="22px"
                            OnClick="Button3_Click" Text="上传图片" Width="89px" />
                <asp:Label ID="Label2" runat="server" Visible="False"   ></asp:Label><br />
                </div>
                <div style="margin-top:5px;">
                  上传文件名：  <asp:TextBox ID="TextBox2" runat="server" CssClass="inputBox" ReadOnly="True" Width="200px"></asp:TextBox>
                  </div>
                    <asp:Image ID="Image1" runat="server" Width="134px" Visible="false" />
                    <br /> 
                </td>
            </tr>
               
                <tr>
           
               <td style=" HEIGHT: 54px" class="td2" align="center">
                   视频说明：</td>
               <td style="WIDTH: 23%; HEIGHT: 54px" class="td2"  colspan="7">
                   <FCKeditorV2:FCKeditor ID="ArticleContent" runat="server" BasePath="~/FCKeditor/">
                       &nbsp;</FCKeditorV2:FCKeditor>
               </td>       
            
             </tr>
            <tr bgcolor="#e7e7e7">
                <td align="center" colspan="10" height="24">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="添加" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
