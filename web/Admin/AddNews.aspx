<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNews.aspx.cs" ValidateRequest="false"
    EnableEventValidation="false" Inherits="Admin_AddNews" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>无标题页</title>
    <link rel="stylesheet" type="text/css" href="skin/css/base.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="98%" border="0" cellpadding="0" cellspacing="1" bgcolor="#e3ebfe" align="center">
                <tr>
                    <td height="26">
                        <table width="98%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                                <td align="center" style="height: 22px">
                                    添加新闻公告</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <table align="center" bgcolor="#e3ebfe" border="0" cellpadding="2" cellspacing="1"
            style="margin-top: 8px" width="98%">
            <tr>
                <td align="center" class="td2">
                    新闻公告标题：</td>
                <td align="left" class="td2" colspan="3"> 
                    <asp:TextBox ID="title" runat="server" Style="border-right: #ffcc00 1px solid;
                        border-top: #ffcc00 1px solid; border-left: #ffcc00 1px solid; border-bottom: #ffcc00 1px solid"
                        Width="598px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="title"
                        ErrorMessage="请输入新闻公告标题"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="center" class="td2">
                    新闻公告类别：</td>
                <td align="left" class="td2" colspan="3"> 
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="213px">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td align="center" class="td2">
                    展示图片：</td>
                <td align="left" class="td2" colspan="3">
                    <div style="padding: 5px; border: 1px dashed #ccc; clear: both;">
                        请选择图片：<input id="File2" runat="server" class="inputBox" type="file" />
                        &nbsp;&nbsp;<asp:Button ID="Button3" runat="server" CausesValidation="False" CssClass="formbutton"
                            Height="22px" OnClick="Button3_Click" Text="上传图片" Width="89px" />
                        <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label><br />
                    </div>
                    <div style="margin-top: 5px;">
                        上传文件名：
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="inputBox" ReadOnly="True" Width="200px"></asp:TextBox>
                    </div>
                    <asp:Image ID="Image1" runat="server" Width="134px" Visible="false" />
                    <br />
                </td>
            </tr>
            <tr>
                <td align="center" colspan="10" height="24">
                    新闻公告内容</td>
            </tr>
            <tr>
                <td align="left" colspan="10" height="24">
                    <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="400px">
                    </FCKeditorV2:FCKeditor>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="10" height="24">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="添加" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
