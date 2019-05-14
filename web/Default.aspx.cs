using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page 
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
      
        if (!IsPostBack)
        {
            getAbot();
            dlNews.DataSource = SystemMgr.BLL.Common.GetDataReader("select top  5 * from  News where TypeName='新闻公告' order by  id desc ");
            dlNews.DataBind();
            dlXinDe.DataSource = SystemMgr.BLL.Common.GetDataReader("select top  5 * from  News where TypeName='教学大纲' order by  id desc ");
            dlXinDe.DataBind();
            DlZN.DataSource = SystemMgr.BLL.Common.GetDataReader("select top  5 * from  News where TypeName='课程习题' order by  id desc ");
            DlZN.DataBind();
            dlKC.DataSource = SystemMgr.BLL.Common.GetDataReader("select top  5 * from  News where TypeName='文献参考' order by  id desc ");
            dlKC.DataBind();
         

            DataList1.DataSource = SystemMgr.BLL.Common.GetDataReader("select top 12  * from  FileInfo  order by  id desc ");
            DataList1.DataBind();

            DataList2.DataSource = SystemMgr.BLL.Common.GetDataReader("select top  12 * from  Video   order by  id desc ");
            DataList2.DataBind();

            DataList3.DataSource = SystemMgr.BLL.Common.GetDataReader("select top 4 * from  Video   order by  Addtime asc  ");
            DataList3.DataBind();
        }

    }
    private void getAbot()
    {
        SqlDataReader dr;
        dr = SystemMgr.BLL.Common.GetDataReader("select top 1 * from  AboutInfo ");
        dr.Read();
        if (dr["AboutInfo"].ToString().Length > 170)
        {
            About.InnerHtml = dr["AboutInfo"].ToString().Substring(0, 170) + " ……<a href='About.aspx'>[详细]</a>";
        }
        else
        {
            About.InnerHtml = dr["AboutInfo"].ToString() + "<a href='About.aspx'>[详细]</a>";
        }
    }
    protected string CutChar(string strChar, int intLength)
    {
        //取得自定义长度的字符串
        if (strChar.Length > intLength)
        { return strChar.Substring(0, intLength); }
        else
        { return strChar; }

    }
   
}
