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

using System.Linq;
using System.Data.Linq;

public partial class Examine : System.Web.UI.Page
{
	int subjectID = 1;

    protected void Page_Load(object sender, EventArgs e)
    {
		if(Request.Params["SubjectID"] != null)
		{
			subjectID = Int32.Parse(Request.Params["SubjectID"].ToString());
		}
		if(!Page.IsPostBack)
		{
			BindPageData();
		}
    }

	private void BindPageData()
	{   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
		///获取考题的考题信息
		var query = from q in db.Question
					where q.SubjectID == subjectID
					select q;
		///显示考题
		gvQuestion.DataSource = query;		
		gvQuestion.DataBind();
	}

	private void BindAnswerData(RadioButtonList rbl,int questionID)
	{   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
		///获取考题的答案信息
		var query = from a in db.Answer
					where a.QuestionID == questionID
					select a;
		///绑定到指定的列表控件
		rbl.DataSource = query;
		rbl.DataTextField = "Body";
		rbl.DataValueField = "ID";
		rbl.DataBind();
	}

	protected void gvQuestion_RowDataBound(object sender,GridViewRowEventArgs e)
	{   ///显示题号
		Label lbIndex = (Label)e.Row.FindControl("lbIndex");
		if(lbIndex != null)
		{
			lbIndex.Text = (e.Row.RowIndex + 1).ToString();
		}
		///找到显示答案的列表，并显示考题的答案
		RadioButtonList rbl = (RadioButtonList)e.Row.FindControl("rblAnswer");
		if(rbl != null)
		{
			BindAnswerData(rbl,Int32.Parse(gvQuestion.DataKeys[e.Row.RowIndex]["ID"].ToString()));
		}
	}

	protected void ibtCommit_Click(object sender,ImageClickEventArgs e)
	{
		int totalScore = 0;
		///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
		///获取当前考生的在线考试的ID值
		//if(Session["OnlineExamineID"] == null) return;
		//int onlineExamineID = Int32.Parse(Session["OnlineExamineID"].ToString());

		foreach(GridViewRow row in gvQuestion.Rows)
		{
			RadioButtonList rbl = (RadioButtonList)row.FindControl("rblAnswer");
			if(rbl != null)
			{   ///获取考题ID值，考生的答案等信息
				int questionID = Int32.Parse(gvQuestion.DataKeys[row.RowIndex]["ID"].ToString());
				string answer = string.Empty;
				if(rbl.SelectedIndex > -1)
				{
					answer = ((char)(((int)'A') + rbl.SelectedIndex)).ToString();
				}
                ///将考生的答案添加到数据库中
                //ExamineeAnswer ea = new ExamineeAnswer();
                //ea.OnlineExamineID = onlineExamineID;
                //ea.QuestionID = questionID;
                //ea.Answer = answer;
                //db.ExamineeAnswer.InsertOnSubmit(ea);
                ///获取当前考题的正确答案，并得出考生的得分
                var query = from q in db.Question
							where q.ID == questionID
							select q;
				if(query.Count() > 0)
				{   ///比较考生的答案和该题的正确答案，如果正确，则计算分值
					Question cq = query.First();
					if(cq.Answer.ToUpper().Trim() == answer.ToUpper().Trim())
					{
						totalScore += cq.Score.Value;
					}
				}
			}
		}
		///将考试成绩保存到数据库
		//var queryoex = from oe in db.OnlineExamine
		//			  where oe.ID == onlineExamineID
		//			  select oe;
		//foreach(OnlineExamine oex in queryoex)
		//{
		//	oex.Score = totalScore;
		//}
		///讲考生答题保存到数据库
		//db.SubmitChanges();
		///显示考试成绩
		lbTotalScore.Text = "您本次考试的成绩为：" + totalScore.ToString() + "分";
	}
}
