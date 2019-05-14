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

public partial class Admin_AddTInfo : System.Web.UI.Page
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         bool b = SystemMgr.BLL.Common.RunSqlBool("insert into Users(emal,UserName,Sex,Age,Ds,UserType,XueXiao,XingMing,Photo,Tel,pwd)values('" + txtemal.Text + "','" + txtname.Text + "','" + DropDownList1.SelectedItem.Text + "','" + Age.Text + "','" + txtds.Text + "','教师','" + XueXiao.Text + "','" + XingMing.Text + "','" + pic.Text + "','" + Tel.Text + "','"+TextBox1.Text+"')");

        Alert.AlertAndRedirect("添加成功！", "TinfoManger.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string res;
        upload up = new upload();
        res = up.Up(file1, "../files/");
        this.Label1.Visible = true;
        this.Label1.Text = up.Resup[Convert.ToInt32(res)];
        this.pic.Text = up.s;
        Image1.ImageUrl ="../files/"+ pic.Text;

    }
}
