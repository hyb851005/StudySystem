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

using System.Data.Linq;
using System.Linq;

public partial class Admin_AddQuestion : System.Web.UI.Page
{
	int subjectID = -1;
    protected void Page_Load(object sender, EventArgs e)
	{
		if(Request.Params["SubjectID"] != null)
		{
			subjectID = Int32.Parse(Request.Params["SubjectID"].ToString());
		}

    }
	
	protected void ibtCommit_Click(object sender,ImageClickEventArgs e)
	{   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
		///创建Question类的实例
		Question q = new Question();
		q.Score = Int32.Parse(tbScore.Text);
		q.SubjectID = subjectID;
		q.Title = tbTitle.Text;
		q.Answer = ddlAnswer.SelectedValue;
		///插入到数据库中
		db.Question.InsertOnSubmit(q);
		db.SubmitChanges();
		///查询最近被插入的问题，并获取其ID值
		var query = from qe in db.Question
					orderby qe.ID descending
					select qe;
		if(query.Count() > 0)
		{   ///获取问题的ID值，并添加它的答案
			int questionID = query.First().ID;
			AddAnswer(db,questionID,"A",tbAnswerA.Text);
			AddAnswer(db,questionID,"B",tbAnswerB.Text);
			AddAnswer(db,questionID,"C",tbAnswerC.Text);
			AddAnswer(db,questionID,"D",tbAnswerD.Text);			
		}
		///将修改保存到数据库
		db.SubmitChanges();
		///跳转到考题管理页面
		Response.Redirect("~/Admin/QuestionManage.aspx");
	}

	private void AddAnswer(ExamineDBDataContext db,int questionID,string tag,string body)
	{   ///创建Answer类的实例，并插入到数据库中
		Answer a = new Answer();
		a.Tag = tag;
		a.Body = body;
		a.QuestionID = questionID;
		db.Answer.InsertOnSubmit(a);
	}
}
