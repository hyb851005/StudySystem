using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Admin_ViewScore : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if(!Page.IsPostBack)
		{
			BindPageData();
		}
    }

	private void BindPageData()
	{   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
		///获取所有考生成绩
		gvScore.DataSource = db.Pr_GetScores();
		gvScore.DataBind();
	}

	protected void gvScore_RowDataBound(object sender,GridViewRowEventArgs e)
	{
		if(e.Row.RowType == DataControlRowType.DataRow)
		{   ///显示考题的序号
			Label lbIndex = (Label)e.Row.FindControl("lbIndex");
			if(lbIndex != null)
			{
				lbIndex.Text = (e.Row.RowIndex + 1).ToString();
			}
		}
	}
}
