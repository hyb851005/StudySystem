<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" StylesheetTheme="Default" Inherits="Admin_Main" %>


<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>在线考试系统后台管理页面</title>   
</head>
	<frameset id="MainFrame" cols="170,*" rows="*" border="0" framespacing="0">
		<frame name="Left" src="OperationTree.aspx" scrolling="auto" frameborder="0" noresize>
		<frame name="Desktop" src="QuestionManage.aspx" scrolling="auto" frameborder="0">
	</frameset>
</html>
