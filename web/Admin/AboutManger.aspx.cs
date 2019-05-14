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
public partial class Admin_AboutManger : System.Web.UI.Page
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           string  sql = "select top 1  * from AboutInfo ";
            SqlDataReader dr = SystemMgr.BLL.Common.GetDataReader(sql);
            if (dr.Read())
            {
                this.FCKeditor1.Value = dr["AboutInfo"].ToString();
            }
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

     
         bool b = SystemMgr.BLL.Common.RunSqlBool("update AboutInfo set AboutInfo='"+FCKeditor1.Value+"' ");
        Alert.AlertAndRedirect("操作成功", "AboutManger.aspx");
    }
}
