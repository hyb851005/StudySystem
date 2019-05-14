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

    //选择上传视频
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


    // 保存视频信息
    protected void Button1_Click1(object sender, EventArgs e)
    {
        //验证输入
        if (TextBox1.Text.Trim() == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请输入视频名称');</script>");
            TextBox1.Focus();
            return;
        }
        if (pic.Text.Trim() == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请上传视频');</script>");
            return;
        }
        if (TextBox2.Text.Trim() == "")
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "", "<script>alert('请上传视频截图');</script>");
            return;
        }

        string filename = Hidden1.Value;
        int i = this.pic.Text.LastIndexOf(".");
        string newname = this.pic.Text.Substring(i);//获取文件的扩展名

        string sql = "insert into Video(VideoName,VideoDs,VideoPath,Ename,FileName,Photo)values('" + TextBox1.Text.Trim() + "','" + ArticleContent.Value + "','" + pic.Text + "','" + newname + "','" + filename + "','" + TextBox2.Text + "')";
         bool b = SystemMgr.BLL.Common.RunSqlBool(sql);

        Alert.AlertAndRedirect("添加成功继续添加", "AddVideo.aspx");
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
    Image1.ImageUrl="../files/"+ up.s;
    Image1.Visible = true;
    }
}
