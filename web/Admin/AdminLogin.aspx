<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="Admin_AdminLogin" StyleSheetTheme="Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>管理员登录</title>
</head>
<body class="Text">
    <form id="form1" runat="server" defaultbutton="ibtLogin">    
    <table width="100%" height="100%" border="0" cellpadding="0" cellspacing="0" class="Text">
		<tr>
			<td align="center" valign="middle">
				<table width="681" border="0" cellpadding="1" cellspacing="1" bgcolor="#000000" class="Text">
					<tr>
						<td bgcolor="#FFFFFF">
							<table width="100%" border="0" cellspacing="0" cellpadding="0" class="Text">
								<tr>
									<td><img src="../App_Themes/Default/Images/i_logo.jpg" width="681" height="89"></td>
								</tr>
								<tr> 
									<td height="308" valign="top" background="../App_Themes/Default/Images/i_center.jpg">
										<table width="100%" border="0" cellspacing="0" cellpadding="0" class="Text">
											<tr>
												<td width="9%" height="114">&nbsp;</td>
												<td width="91%">&nbsp;</td>
											</tr>
											<tr>
												<td>&nbsp;</td>
												<td>
													<table width="313" border="0" cellpadding="0" cellspacing="0" class="i-font1">
														<tr> 
															<td width="83" height="39" class="Text" style="font-size:9pt;color: #343A78;">用户名称：</td>
															<td width="160"><asp:TextBox ID="tbUsername" runat="server" MaxLength="50" Width="153px" Font-Names="Tahoma" Font-Size="9pt" TabIndex="1"></asp:TextBox>
																<asp:RequiredFieldValidator ID="rfName" runat="server" 
																	ControlToValidate="tbUsername" ErrorMessage="不能为空。" Display="Dynamic"></asp:RequiredFieldValidator></td>
															<td width="98" rowspan="2" align="center">
																<asp:ImageButton ID="ibtLogin" runat="server" 
																	ImageUrl="../App_Themes/Default/Images/login.gif" OnClick="ibtLogin_Click" 
																	ImageAlign="TextTop" TabIndex="3"/>
															</td>
														</tr>
														<tr> 
															<td width="83" height="39" class="Text" style="font-size:9pt;color: #343A78;">用户密码：</td>
															<td width="160"><asp:TextBox ID="tbPassword" runat="server" MaxLength="255" Width="153px" TextMode="Password" Font-Names="Tahoma" Font-Size="9pt" TabIndex="2"></asp:TextBox><asp:RequiredFieldValidator ID="rfPassword" runat="server" ControlToValidate="tbPassword" Display="Dynamic" ErrorMessage="不能为空。"></asp:RequiredFieldValidator></td>
														</tr>
													</table>
												</td>
											</tr>
										</table>
									</td>
								</tr>
								<tr> 
									<td height="4"><img src="../App_Themes/Default/Images/i_b_line1.jpg" width="681" height="4"></td>
								</tr>
								<tr> 
									<td height="2"><img src="../App_Themes/Default/Images/tm.gif" width="1" height="2"></td>
								</tr>
								<tr>
									<td height="30" align="center" background="../App_Themes/Default/Images/i_b_line2.jpg" class="i-font2">
										&nbsp;</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
    </form>
</body>
</html>

