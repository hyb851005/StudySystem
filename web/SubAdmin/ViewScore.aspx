<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewScore.aspx.cs" Inherits="Admin_ViewScore" StyleSheetTheme="Default" %>
<%@ Register Src="../UserControls/TitleUC.ascx" TagName="TitleUC" TagPrefix="ucTitle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>查看考生成绩</title>
</head>
<body background="../App_Themes/Default/Images/l_b_bg.jpg" class="body">
	<form id="form2" runat="server">
	<ucTitle:TitleUC ID="TitleUC1" runat="server" Title="查看考生成绩" />
    <table width="100%" height="89%" border="0" cellspacing="0" cellpadding="0">		
		<tr valign="top"> 
			<td height="100%" colspan="3" bgcolor="#FFFFFF" class="l-r-space">
				<table width="100%" border="0" cellpadding="1" cellspacing="1" bgcolor="#009DE9">
					<tr>
						<td bgcolor="#FFFFFF">
							<asp:GridView ID="gvScore" runat="server" SkinID="GridViewSkin" 
								onrowdatabound="gvScore_RowDataBound">
								<Columns>
									<asp:TemplateField HeaderText="序号" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black">
										<ItemTemplate>
											<asp:Label ID="lbIndex" runat="server"></asp:Label>
										</ItemTemplate>
									</asp:TemplateField>
									<asp:TemplateField HeaderText="姓名" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="20%" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black">
										<ItemTemplate>
											<%# Eval("Username") %>
										</ItemTemplate>
									</asp:TemplateField>
									<asp:TemplateField HeaderText="考试科目" ItemStyle-HorizontalAlign="Left" ItemStyle-Width="35%" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black">
										<ItemTemplate>
											<%# Eval("SubjectName") %>
										</ItemTemplate>
									</asp:TemplateField>
									<asp:TemplateField HeaderText="分数" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="10%" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black">
										<ItemTemplate>
											<%# Eval("Score") %>
										</ItemTemplate>
									</asp:TemplateField>
									<asp:TemplateField HeaderText="考试时间" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="25%" ItemStyle-BorderWidth="1" ItemStyle-BorderColor="Black">
										<ItemTemplate>
											<%# Eval("StartTime") %>
										</ItemTemplate>
									</asp:TemplateField>									
								</Columns>
							</asp:GridView>
						</td>
					</tr>
				</table>
			</td>
		</tr>		
    </table>    
    </form>
</body>
</html>



