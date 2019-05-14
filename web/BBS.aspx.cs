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

public partial class BBS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Title = SystemMgr .BLL.Common.GetWebTitle ();
        this.PageCtrl1.gridView = GridView1;

        string Sql = ""; //查询语句

        Sql = " select * from Topic   ORDER BY Addtime DESC ";

        SqlDataSource1.SelectCommand = Sql;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddTopic.aspx");
    }
}
