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

public partial class Admin_AddNews : System.Web.UI.Page
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //加载 信息类别
            DropDownList1.DataSource = SystemMgr.BLL.Common.GetDataReader("select * from Infotype");
            DropDownList1.DataValueField = "id";
            DropDownList1.DataTextField = "name";
            DropDownList1.DataBind();

        }
    }

    //保存添加的信息
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text.Trim() == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请上传展示图片');</script>");
            return;
        }
        string sql = "insert into News(name,content,typeid,TypeName,imgurl) values('" + title.Text.ToString().Trim() + "','" + FCKeditor1.Value + "','" + DropDownList1.SelectedValue + "','" + DropDownList1.SelectedItem.Text + "','" + TextBox2.Text + "')";
         bool b = SystemMgr.BLL.Common.RunSqlBool(sql);
        Alert.AlertAndRedirect("添加成功", "addnews.aspx");


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
