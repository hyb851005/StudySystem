﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditFile.aspx.cs"  ValidateRequest="false" EnableEventValidation="false" Inherits="Admin_EditFile" %>
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
     修改多媒体课件</td>
 </tr>
</table>
</td>
</tr>
</table>
    </div>
        <table align="center" bgcolor="#e3ebfe" border="0" cellpadding="2" cellspacing="1"
            style="margin-top: 8px" width="98%">
                <tr>
               
               <td style="WIDTH:100px; HEIGHT: 21px" class="td2" align="center">
                   多媒体课件名称：</td>
               <td style="HEIGHT: 21px" class="td2" colspan="3">
              <asp:TextBox ID="TextBox1" runat="server" CssClass="label" Width="558px"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="请输入多媒体课件名称"></asp:RequiredFieldValidator>
              </td>
               
               </tr>
             <tr>
                 <td align="center" class="td2" style=" height: 21px">
                     上传多媒体课件：</td>
                 <td align="left" class="td2" colspan="3" style="height: 21px">
                 
                      <div>
                    请选择文件：
                     <input
                         id="file1" runat="server" class="inputBox" type="file" /><asp:Button
                             ID="Button2" runat="server" CausesValidation="False" CssClass="formbutton"  
                             OnClick="Button1_Click" Text="上传" /><asp:Label ID="Label1" runat="server"
                                 Visible="False" ></asp:Label><input id="Hidden1" runat="server" type="hidden" />
                    </div>
                    <div>
                   上传文件名：  <asp:TextBox ID="pic" runat="server" CssClass="inputBox" ReadOnly="True" ></asp:TextBox> （注：上传浏览文件后自动生成文件名称，不需要填写此项）
                     
                    </div>
                                 
                                 </td>
             </tr>
               
                <tr>
           
               <td style=" HEIGHT: 54px" class="td2" align="center">
                   内容说明：</td>
               <td class="td2"  colspan="7">
                   <FCKeditorV2:FCKeditor ID="ArticleContent" Height="400" runat="server" BasePath="~/FCKeditor/">
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
