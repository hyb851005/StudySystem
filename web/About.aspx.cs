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
using System.Data.SqlClient;

public partial class About : System.Web.UI.Page
{
    public string sql, dID;
 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            sql = "select top 1  * from AboutInfo ";
            getdata(sql);
        }
    }

    //通过执行SQL语句获取相应的数据记录
    private void getdata(string sql)
    {
        SqlDataReader dr = SystemMgr.BLL.Common.GetDataReader(sql);
        if (dr.Read())
        {
            this.DIV1.InnerHtml = dr["AboutInfo"].ToString();
        }

    }

}
