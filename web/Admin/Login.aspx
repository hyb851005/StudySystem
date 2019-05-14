<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Admin_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        <%=SystemMgr .BLL.Common.GetWebTitle() %>
        -- 后台管理系统</title>
    <link href="skin/css/index.css" rel="stylesheet" type="text/css" />
</head>
<body bgcolor="#fbbd51">
    <form id="form1" runat="server">
        <table align="center" width="1000" height="700" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    <img src="images/loginpage_01.jpg" width="346" height="270" alt=""></td>
                <td>
                    <img src="images/loginpage_02.jpg" width="308" height="270" alt=""></td>
                <td>
                    <img src="images/loginpage_03.jpg" width="346" height="270" alt=""></td>
            </tr>
            <tr>
                <td>
                    <img src="images/loginpage_04.jpg" width="346" height="151" alt=""></td>
                <td width="308" height="151" style="background-image: url(images/loginpage_05.jpg);"
                    align="center" valign="middle">
                    <table width="90%" border="0" cellspacing="8" cellpadding="0" style="height: 112px">
                        <tr>
                            <td width="70" align="center" style="height: 27px">
                                用户名:</td>
                            <td style="height: 27px">
                                <input id="txtname" runat="server" class="l_input" name="username" type="text" style="width: 146px" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname"
                                    ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td width="70" align="center">
                                密&nbsp;&nbsp;码:</td>
                            <td>
                                <input id="txtpwd" runat="server" class="l_input" name="password" type="password"
                                    style="width: 146px" />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpwd"
                                    ErrorMessage="*"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td align="center" width="70">
                                验证码：</td>
                            <td>
                                <asp:TextBox ID="TextBox3" runat="server" Width="89px"></asp:TextBox>
                                <asp:Image ID="Image1" runat="server" ImageUrl="../VaildImg.aspx" onclick="this.src=this.src+'?'" /></td>
                        </tr>
                    </table>
                </td>
                <td>
                    <img src="images/loginpage_06.jpg" width="346" height="151" alt=""></td>
            </tr>
            <tr>
                <td>
                    <img src="images/loginpage_07.jpg" width="346" height="279" alt=""></td>
                <td width="308" height="279" style="background-image: url(images/loginpage_08.jpg);"
                    align="center" valign="top">
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="用户登录" Height="39px" Width="76px" OnClick="Button1_Click" /></td>
                <td>
                    <img src="images/loginpage_09.jpg" width="346" height="279" alt=""></td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
