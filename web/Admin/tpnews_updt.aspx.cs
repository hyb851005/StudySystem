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
public partial class Admin_tpnews_updt : System.Web.UI.Page
{
    public string sql, dID;

    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        dID = Request.QueryString["id"].ToString().Trim();
        if (!IsPostBack)
        {
            DropDownList1.DataSource = SystemMgr.BLL.Common.GetDataReader("select * from Infotype");
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "name";
            DropDownList1.DataBind();
            sql = "select * from News where id=" + dID;
            getdata(sql);
        }
    }

    //加载显示修改信息
    private void getdata(string sql)
    {
        SqlDataReader dr = SystemMgr.BLL.Common.GetDataReader(sql);
        if (dr.Read())
        {
            title.Text = dr["name"].ToString();
           FCKeditor1.Value = dr["content"].ToString();
           TextBox2.Text = dr["imgurl"].ToString(); 
           DropDownList1.Items.FindByValue(dr["typeid"].ToString()).Selected = true;
           DropDownList1.Items.FindByText(dr["TypeName"].ToString()).Selected = true; 
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text.Trim() == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请上传展示图片');</script>");
            return;
        }

        sql = "update News set name='" + title.Text.ToString().Trim() + "',content='" + FCKeditor1.Value + "',typeid='" + DropDownList1.SelectedValue + "',TypeName='"+DropDownList1.SelectedItem.Text+"',imgurl='"+ TextBox2.Text.Trim () +"' where id=" + dID;
         bool b = SystemMgr.BLL.Common.RunSqlBool(sql);
        Alert.AlertAndRedirect("修改成功", "NewsList.aspx");
    }

    //上传图片
    protected void Button3_Click(object sender, EventArgs e)
    {
        string res;
        upload up = new upload();
        res = up.Up(File2, "../files/");

        this.Label2.Visible = true;
        this.Label2.Text = up.Resup[Convert.ToInt32(res)];
        this.TextBox2.Text = up.s;
        Image1.ImageUrl = "../files/" + up.s;
        Image1.Visible = true;
    }
}
