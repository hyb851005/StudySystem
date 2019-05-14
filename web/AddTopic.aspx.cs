using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class AddTopic : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title =  SystemMgr .BLL.Common.GetWebTitle();
        if (!IsPostBack)
        {
            if (Session["UserName"] == null)
            {
                Alert.AlertAndRedirect("对不起您还没有登录", "Default.aspx");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
         bool b = SystemMgr.BLL.Common.RunSqlBool("insert into Topic(Topic,AddUser,Content)values('" + tb_title.Text + "','" + Session["UserName"].ToString() + "','" + ArticleContent.Value + "')");
        Alert js = new Alert();
        js.Alertjs("发布成功");
        Response.Redirect("BBS.aspx");
    }
}
