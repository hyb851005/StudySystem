<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="PgMenu.ascx" TagName="PgMenu" TagPrefix="uc4" %>
<%@ Register Src="PageTop.ascx" TagName="PageTop" TagPrefix="uc3" %>
<%@ Register Src="PageDown.ascx" TagName="PageDown" TagPrefix="uc2" %>
<%@ Register Src="UserLogin.ascx" TagName="UserLogin" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>首页 --
        <%=SystemMgr .BLL.Common.GetWebTitle() %>
    </title>
    <link href="style/css.css" rel="stylesheet" type="text/css" />
</head>
<body style="background-image: url(img/bg.jpg);">
    <form id="form1" runat="server">
        <table border="0" align="center" style="background-color: #ffffff;">
            <tr>
                <td>
                    <uc3:PageTop ID="PageTop1" runat="server" />
                    <div class="topmenu w_980">
                        <uc4:PgMenu ID="PgMenu1" runat="server" />
                    </div>
                    <div class="w_980">
                        <div class="w_260 fl">
                            <div class="t_1">
                                <div>
                                    <a href="UserHome.aspx">用户中心</a></div>
                            </div>
                            <div class="f_1 pa20 h26 mb10" style="font-size: 14px;">
                                <uc1:UserLogin ID="UserLogin1" runat="server" />
                            </div>
                            <div class="t_1">
                                <div>
                                    <a href="NewsList.aspx">多媒体课件&gt;&gt;</a></div>
                            </div>
                            <div class="f_2 pa15 mb10">
                                <ul class="list_2 list_ico_1">
                                    <asp:DataList ID="DataList1" runat="server" ForeColor="#333333" Width="211px">
                                        <ItemTemplate>
                                            <a href='<%#Eval("id","FileInfo.aspx?id={0}")%>'>
                                                <%#Eval("TitleName").ToString().Length > 15 ? CutChar(Eval("TitleName").ToString(), 15) + "..." : Eval("TitleName")%>
                                            </a>
                                        </ItemTemplate>
                                    </asp:DataList></ul>
                            </div>
                            <div class="t_1">
                                <div>
                                    <a href="#">最新视频&gt;&gt;</a></div>
                            </div>
                            <div class="f_2 pa15 mb10">
                                <ul class="list_2 list_ico_1">
                                    <asp:DataList ID="DataList2" runat="server" ForeColor="#333333" Width="211px">
                                        <ItemTemplate>
                                            <a href='<%#Eval("id","ShowVideo.aspx?id={0}")%>'>
                                                <%#Eval("VideoName").ToString().Length > 25 ? CutChar(Eval("VideoName").ToString(), 32) + "..." : Eval("VideoName")%>
                                            </a>
                                        </ItemTemplate>
                                    </asp:DataList></ul>
                            </div>
                        </div>
                        <div class="w_710 fr" style="font-size: 14px;">
                            <div class="t_2">
                                <a href="About.aspx">课程简介</a></div>
                            <p class="h25" style="font-size: 14px;">
                            </p>
                            <div runat="server" id="About">
                            </div>
                            <div class="clear_all">
                            </div>
                            <div class="w_350 clear fl">
                                <div class="t_2">
                                    <a href="NewsList.aspx">最新公告</a></div>
                                <div style="height: 163px; overflow: hidden;">
                                    <ul class="list_2 list_ico_1">
                                        <asp:DataList ID="dlNews" runat="server" ForeColor="#333333">
                                            <ItemTemplate>
                                                <li style="left: 0px; top: 0px"><a href='<%#Eval("id","NewsInfo.aspx?id={0}")%>'>
                                                    <%#Eval("name").ToString().Length > 18 ? CutChar(Eval("name").ToString(), 28) + "..." : Eval("name")%>
                                                </a></li>
                                            </ItemTemplate>
                                        </asp:DataList>
                                    </ul>
                                </div>
                                <div class="t_2 clear mt10">
                                    <a href="RuankaoList.aspx">课程习题</a></div>
                                <div style="height: 163px; overflow: hidden;">
                                    <ul class="list_2 list_ico_1">
                                        <asp:DataList ID="DlZN" runat="server" ForeColor="#333333">
                                            <ItemTemplate>
                                                <li style="left: 0px; top: 0px"><a href='<%#Eval("id","NewsInfo.aspx?id={0}")%>'>
                                                    <%#Eval("name").ToString().Length > 24 ? CutChar(Eval("name").ToString(), 28) + "..." : Eval("name")%>
                                                </a></li>
                                            </ItemTemplate>
                                        </asp:DataList>
                                    </ul>
                                </div>
                            </div>
                            <div class="w_350 fr">
                                <div class="t_2">
                                    <a href="DengjikaoshiList.aspx">教学大纲</a></div>
                                <div style="height: 163px; overflow: hidden;">
                                    <ul class="list_2 list_ico_1">
                                        <asp:DataList ID="dlXinDe" runat="server" ForeColor="#333333">
                                            <ItemTemplate>
                                                <li style="left: 0px; top: 0px"><a href='<%#Eval("id","NewsInfo.aspx?id={0}")%>'>
                                                    <%#Eval("name").ToString().Length > 16 ? CutChar(Eval("name").ToString(), 28) + "..." : Eval("name")%>
                                                </a></li>
                                            </ItemTemplate>
                                        </asp:DataList></ul>
                                </div>
                                <div class="t_2 mt10">
                                    <a href="ItList.aspx">文献参考</a></div>
                                <div style="height: 163px; overflow: hidden;">
                                    <ul class="list_2 list_ico_1">
                                        <asp:DataList ID="dlKC" runat="server" ForeColor="#333333">
                                            <ItemTemplate>
                                                <li style="left: 0px; top: 0px"><a href='<%#Eval("id","NewsInfo.aspx?id={0}")%>'>
                                                    <%#Eval("name").ToString().Length > 24 ? CutChar(Eval("name").ToString(), 28) + "..." : Eval("name")%>
                                                </a></li>
                                            </ItemTemplate>
                                        </asp:DataList>
                                    </ul>
                                </div>
                            </div>
                            <div class="clear">
                            </div>
                            <div class="t_2 mt10 clear">
                                <a href="TList.aspx">热门视频</a></div>
                            <ul class="list_img_1">
                                <asp:DataList ID="DataList3" Width="98%" runat="server" Height="80" RepeatColumns="4"
                                    RepeatDirection="Horizontal">
                                    <ItemTemplate>
                                        <li><a href='<%#Eval("id","ShowVideo.aspx?id={0}")%>'>
                                            <asp:Image ID="Image1" runat="server" Width="140" Height="80" ImageUrl='<%# "files/"+ DataBinder.Eval(Container.DataItem,"Photo") %>'>
                                            </asp:Image>
                                        </a></li>
                                    </ItemTemplate>
                                </asp:DataList>
                            </ul>
                            <div class="clear">
                            </div> 
                        </div>
                    </div>
                    <uc2:PageDown ID="PageDown1" runat="server" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
