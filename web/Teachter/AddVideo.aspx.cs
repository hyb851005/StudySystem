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

public partial class Admin_AddVideo : System.Web.UI.Page
{
    SystemMgr.BLL.Common data = new SystemMgr.BLL.Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
       
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string res;
        upload up = new upload();
        res = up.Up(file1, "../files/");

        this.Label1.Visible = true;
        this.Label1.Text = up.Resup[Convert.ToInt32(res)];
        this.pic.Text = up.s;
        Hidden1.Value = up.fname;
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string filename = Hidden1.Value;
        int i = this.pic.Text.LastIndexOf(".");
        string newname = this.pic.Text.Substring(i);//获取文件的扩展名

        string sql = "insert into Video(VideoName,VideoDs,VideoPath,Ename,FileName)values('" + TextBox1.Text.Trim() + "','" + ArticleContent.Value + "','" + pic.Text + "','" + newname + "','" + filename + "')";
         bool b = SystemMgr.BLL.Common.RunSqlBool(sql);

        Alert.AlertAndRedirect("添加成功继续添加", "AddVideo.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        string res;
        upload up = new upload();
        res = up.Up(File2, "../files/");

        this.Label2.Visible = true;
        this.Label2.Text = up.Resup[Convert.ToInt32(res)];
        this.TextBox2.Text = up.s;
    Image1.ImageUrl="../files/"+ up.s;
    }
}
