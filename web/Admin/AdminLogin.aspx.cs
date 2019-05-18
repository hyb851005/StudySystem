using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Linq;
using System.Data.Linq;

public partial class Admin_AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void ibtLogin_Click(object sender,ImageClickEventArgs e)
	{   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
		///查询Examinee表
		var query = from ex in db.AdminUser
					where ex.Username == tbUsername.Text.Trim() && ex.Password == tbPassword.Text.Trim()
					select ex;
		///获取用户信息，并判断用户登录是否成功
		if(query.Count() > 0)
		{   ///保存用户登录信息
			Session["UserID"] = query.First().ID.ToString();
			Session["Username"] = query.First().Username;

			///跳转到Select.aspx页面
			Response.Redirect("~/Admin/Main.aspx");
		}
	}
}
