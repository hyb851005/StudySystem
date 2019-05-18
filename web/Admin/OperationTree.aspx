<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OperationTree.aspx.cs" Inherits="Admin_OperationTree" StylesheetTheme="Default" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>在线考试系统后台管理页面</title>    
</head>
<body background="../App_Themes/Default/Images/l_b_bg.jpg">
    <form id="form1" runat="server">
    <table width="150" border="0" height="100%" cellspacing="0" cellpadding="0">
		<tr> 
			<td height="5" colspan="3"><img src="../App_Themes/Default/Images/l_left_line_t.jpg" width="150" height="5"></td>
		</tr>
		<tr height="100%"> 
			<td width="1" bgcolor="#FFFFFF"><img src="../App_Themes/Default/Images/tm.gif" width="1" height="1"></td>
			<td width="148" height="100%" valign="top" bgcolor="#D7DEF8">
				<table width="100%" border="0" cellspacing="0" cellpadding="0">
					<tr> 
						<td height="1" align="center"><img src="../App_Themes/Default/Images/l_left_line_c.jpg" width="131" height="1"></td>
					</tr>
					<tr>
						<td align="center" valign="top">
							<table width="100%" border="0" cellspacing="0" cellpadding="0">
								<tr> 
									<td height="10" colspan="2"><img src="../App_Themes/Default/Images/tm.gif" width="1" height="10"></td>
								</tr>
								<tr align="center"> 
									<td width="100%" align="left" valign="top" class="l-l-font2"> 
										<asp:TreeView ID="tvOperation" CssClass="l-l-font2" runat="server" EnableTheming="True" NodeIndent="10" ShowLines="True">
											<Nodes>
												<asp:TreeNode Text="后台管理页面" Value="0" SelectAction="Expand">
                                                <asp:TreeNode Text="试题库管理" Value="1" Target="Desktop" NavigateUrl="~/Admin/SubjectManage.aspx"></asp:TreeNode>
													<asp:TreeNode Text="试题内容管理" Value="2" Target="Desktop" NavigateUrl="~/Admin/QuestionManage.aspx"></asp:TreeNode>
													<asp:TreeNode Text="退出" Value="99" Target="_top" NavigateUrl="~/Admin/AdminLogin.aspx"></asp:TreeNode>													
												</asp:TreeNode>
											</Nodes>
										</asp:TreeView>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
			<td width="1" bgcolor="#FFFFFF"><img src="../App_Themes/Default/Images/tm.gif" width="1" height="1"></td>
		</tr>
		<tr> 
			<td height="5" colspan="3"><img src="../App_Themes/Default/Images/l_left_line_b.jpg" width="150" height="5"></td>
		</tr>
	</table>
    </form>
</body>
</html>

