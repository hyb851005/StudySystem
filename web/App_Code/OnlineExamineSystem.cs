using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public class OnlineExamineSystem
{
	/// <summary>
	/// 访问WebShoppingDB数据库的连接字符串
	/// </summary>
	public static string ExamineDBConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

	public OnlineExamineSystem()
	{
		
	}
}
