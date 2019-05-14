<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="BookList.aspx.cs" Inherits="BookList" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td align="left" bgcolor="#fbfbfb" class="middle_border_1 margin_middle1">
                <div class="t_2">
                    <a href="javascript:void(0);">课外阅读</a></div>
                            <div style="clear: both;">
                        <table border="0" width="99%" cellspacing="5">
                            <tr>
                                <td>
                                    数据查询：<asp:TextBox ID="txtkey" runat="server"></asp:TextBox>
                                    <asp:Button ID="btn_search" runat="server" Text="搜索" 
                                        onclick="btn_search_Click" />
                                </td>
                                <td align="right">
                                    当前共
                                    <asp:Label ID="lab_all_count" runat="server" Text="0"></asp:Label>
                                    条数据记录
                                </td>
                            </tr>
                        </table>
                    </div>
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" RepeatDirection="Horizontal"
                    Width="682px" CaptionAlign="Top">
                    <ItemTemplate>
                        <table id="Table1" align="center" runat="server" border="0" cellpadding="0" cellspacing="0" width="150">
                            <tr>
                                <td align="center" height="30"  >
                                    <li style="left: 0px; top: 0px">
                                        <img src='files/<%#Eval("imgurl") %>' width="140" height="180" style="border:1px solid #cccccc;"/>
                                    </li>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" height="30"  >
                                    <li style="left: 0px; top: 0px">&nbsp;&nbsp; <a href='<%#Eval("id","NewsInfo.aspx?id={0}")%>'>
                                        <%#Eval("name").ToString().Length > 25 ? CutChar(Eval("name").ToString(), 32) + "..." : Eval("name")%>
                                    </a></li>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <ItemStyle VerticalAlign="top" />
                </asp:DataList></td>
        </tr>
            <tr runat="server" visible="false" id="trFenye">
            <td align="center" bgcolor="#fbfbfb" class="middle_border_1 margin_middle1" style="width: 661px;
                height: 38px">
                共【<asp:Label ID="lblSumPage" runat="server"></asp:Label>】页 &nbsp; &nbsp; &nbsp;
                当前第【<asp:Label ID="lblCurrentPage" runat="server"></asp:Label>】页&nbsp;
                <asp:HyperLink ID="hyfirst" runat="server">首页</asp:HyperLink>
                &nbsp; &nbsp; &nbsp;<asp:HyperLink ID="lnkPrev" runat="server">上一页</asp:HyperLink>
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                <asp:HyperLink ID="lnkNext" runat="server">下一页</asp:HyperLink>
                &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
                <asp:HyperLink ID="hylastpage" runat="server">尾页</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>
