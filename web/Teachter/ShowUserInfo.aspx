﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowUserInfo.aspx.cs" Inherits="Admin_ShowUserInfo" %>

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
      用户信息</td>
 </tr>
</table>
</td>
</tr>
</table>
    </div>
        <table align="center" bgcolor="#e3ebfe" border="0" cellpadding="2" cellspacing="1"
            style="margin-top: 8px" width="98%">
            <tr align="right" bgcolor="#eef4ea">
               <td align="left" colspan="10" style="min-height:40px; padding:5px;" >
                    <table cellpadding="2" class="registeInfo" width="100%">
                        <tr>
                            <td align="right" style="height: 35px" width="120">
                                登录帐号：</td>
                            <td style="height: 35px">
                                <asp:TextBox ID="txtname" runat="server" Width="109px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname"
                                    ErrorMessage="必填"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr style="color: #000000">
                            <td align="right" style="height: 28px">
                                毕业学校：</td>
                            <td style="height: 28px">
                                <asp:TextBox ID="XueXiao" runat="server" Width="166px"></asp:TextBox></td>
                        </tr>
                        <tr style="color: #000000">
                            <td align="right">
                                姓名：</td>
                            <td>
                                <asp:TextBox ID="XingMing" runat="server" Width="166px"></asp:TextBox></td>
                        </tr>
                        <tr style="color: #000000">
                            <td align="right">
                                性别：</td>
                            <td>
                                <asp:DropDownList ID="DropDownList1" runat="server" Width="89px">
                                    <asp:ListItem>男</asp:ListItem>
                                    <asp:ListItem>女</asp:ListItem>
                                </asp:DropDownList></td>
                        </tr>
                        <tr>
                            <td align="right">
                                年龄：</td>
                            <td>
                                <asp:TextBox ID="Age" runat="server" Width="58px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="right">
                                电子邮件：</td>
                            <td>
                                <label for="ksIDType3">
                                    <asp:TextBox ID="txtemal" runat="server" Width="166px"></asp:TextBox>
                                    </label></td>
                        </tr>
                        <tr>
                            <td align="right">
                                联系电话：</td>
                            <td>
                                <asp:TextBox ID="Tel" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td align="right">
                                用户头像：</td>
                            <td>
                                <asp:Image ID="Image1" runat="server" Width="134px" /></td>
                        </tr>
                        <tr>
                            <td align="right" style="height: 127px">
                                用户描述：</td>
                            <td style="height: 127px">
                                <asp:TextBox ID="txtds" runat="server" Height="115px" TextMode="MultiLine" Width="701px"></asp:TextBox></td>
                        </tr>
                    </table>
                    </td>
            </tr>
        </table>
    </form>
</body>
</html>
