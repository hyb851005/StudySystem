<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserLogin.ascx.cs" Inherits="UserLogin" %>
<%--<table width="100%">
    <tr>
        <td colspan="3" style="text-align: center; height: 20px;">
            <table id="Login2" runat="server" align="center" border="0" cellpadding="1" cellspacing="0"
                style="width: 183px">
                <tr>
                    <td height="40" style="font-size: 14px; font-weight: bold;" colspan="2">
                        注册用户登录
                    </td>
                </tr>
                <tr>
                    <td nowrap="nowrap">
                        <div align="right">
                            <span>帐号: </span>
                        </div>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TxtUserName" runat="server" ValidationGroup="3" Width="144px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td align="left">
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <span>密码: </span>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" ValidationGroup="3"
                            Width="142px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td align="left">
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" style="height: 26px">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="用户登陆" ValidationGroup="3" />&nbsp;
                    </td>
                </tr>
            </table>
            <table id="Login1" runat="server" align="center" border="0" cellpadding="1" cellspacing="0"
                style="width: 191px">
                <tr>
                    <td style="width: 52px">
                    </td>
                    <td align="middle" style="width: 166px">
                    </td>
                </tr>
                <tr>
                    <td nowrap="nowrap" style="width: 52px">
                        <div align="right">
                            <span>欢迎: </span>
                        </div>
                    </td>
                    <td align="left" style="width: 166px">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" style="height: 26px">
                        <asp:Button ID="Button4" runat="server" CausesValidation="False" class="btn" OnClick="Button4_Click"
                            Text="注销" />
                        <asp:Button ID="Button1" runat="server" CausesValidation="False" OnClick="Button1_Click"
                            Text="用户中心" /></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="3" style="text-align: center">
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" CausesValidation="False">学生用户注册</asp:LinkButton></td>
    </tr>
</table>
--%>

<table width="100%">
    <tr>
        <td colspan="3" style="text-align: center; height: 20px;">
            <table id="Login2" runat="server" align="center" border="0" cellpadding="1" cellspacing="0"
                style="width: 183px">
                <tr>
                    <td height="40" style="font-size: 14px; font-weight: bold;" colspan="2">
                        教师用户/学生用户登录
                    </td>
                </tr>
                <tr>
                    <td nowrap="nowrap">
                        <div align="right">
                            <span>帐号: </span>
                        </div>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TxtUserName" runat="server" ValidationGroup="3" Width="144px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td align="left">
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <span>密码: </span>
                    </td>
                    <td align="left">
                        <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" ValidationGroup="3"
                            Width="142px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td align="left">
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" style="height: 26px">
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="用户登陆" ValidationGroup="3" />&nbsp;
                    </td>
                </tr>
            </table>
            <table id="Login1" runat="server" align="center" border="0" cellpadding="1" cellspacing="0"
                style="width: 191px">
                <tr>
                    <td style="width: 52px">
                    </td>
                    <td align="middle" style="width: 166px">
                    </td>
                </tr>
                <tr>
                    <td nowrap="nowrap" style="width: 52px">
                        <div align="right">
                            <span>欢迎: </span>
                        </div>
                    </td>
                    <td align="left" style="width: 166px">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2" style="height: 26px">
                        <asp:Button ID="Button4" runat="server" CausesValidation="False" class="btn" OnClick="Button4_Click"
                            Text="注销" />
                        <asp:Button ID="Button1" runat="server" CausesValidation="False" OnClick="Button1_Click"
                            Text="用户中心" /></td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td colspan="3" style="text-align: center">
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" CausesValidation="False">学生用户注册</asp:LinkButton></td>
    </tr>
</table>