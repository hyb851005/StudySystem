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

using System.Data.Linq;

public partial class Admin_UpdateQuestion : System.Web.UI.Page
{
	int questionID = -1;
    protected void Page_Load(object sender, EventArgs e)
    {
		if(Request.Params["QuestionID"] != null)
		{
			questionID = Int32.Parse(Request.Params["QuestionID"].ToString());
		}		
		if(!Page.IsPostBack)
		{
			BindPageData(questionID);
		}
    }

	private void BindPageData(int questionID)
	{   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
		///查询被显示的考题
		var query = from q in db.Question
					where q.ID == questionID
					select q;
		if(query.Count() > 0)
		{   ///获取考题，并显示
			Question curq = query.First();
			tbTitle.Text = curq.Title;
			tbScore.Text = curq.Score.Value.ToString();
			///显示正确的答案
			for(int i = 0; i < ddlAnswer1.Items.Count; i++)
			{
				if(ddlAnswer1.Items[i].Value == curq.Answer.Trim())
				{
					ddlAnswer1.SelectedIndex = i;
					break;
				}
			}
			///查询考题的答案
			var queryA = from a in db.Answer
						 where a.QuestionID == questionID
						 select a;
			///判断考题答案的数量是否为4个
			if(queryA.Count() != 4) return;
			///显示每一个答案
			foreach(Answer aw in queryA)
			{
				if(aw.Tag.Trim() == "A")
				{
					tbAnswerA.Text = aw.Body; continue;
				}
				if(aw.Tag.Trim() == "B")
				{
					tbAnswerB.Text = aw.Body; continue;
				}
				if(aw.Tag.Trim() == "C")
				{
					tbAnswerC.Text = aw.Body; continue;
				}
				if(aw.Tag.Trim() == "D")
				{
					tbAnswerD.Text = aw.Body; continue;
				}
			}
		}
	}
	protected void ibtCommit_Click(object sender,ImageClickEventArgs e)
	{   ///创建ExamineDB数据库的数据上下文
		ExamineDBDataContext db = new ExamineDBDataContext(OnlineExamineSystem.ExamineDBConnectionString);
		///查询被修改的考题
		var query = from q in db.Question
					where q.ID == questionID
					select q;
		///修改考题的信息
		foreach(Question qe in query)
		{
            //qe.Answer = ddlAnswer1.SelectedValue;
            string answer, a1, a2, a3, a4 = string.Empty;
            a1 = ddlAnswer1.SelectedValue;
            a2 = ddlAnswer2.SelectedValue;
            a3 = ddlAnswer3.SelectedValue;
            a4 = ddlAnswer4.SelectedValue;
            answer = a1;
            if (a2 != "无" && a2 != a1)
                answer += "/" + a2;
            if (a3 != "无" && a3 != a1 && a3 != a2)
                answer += "/" + a3;
            if (a4 != "无" && a4 != a1 && a4 != a2 && a4 != a3)
                answer += "/" + a4;
            qe.Answer = answer;
            qe.Score = Int32.Parse(tbScore.Text);
			qe.Title = tbTitle.Text;
		}
		///查询被修改的答案
		var queryA = from a in db.Answer
					 where a.QuestionID == questionID
					 select a;
		///修改答案的信息
		foreach(Answer aw in queryA)
		{
			if(aw.Tag.Trim() == "A") aw.Body = tbAnswerA.Text;
			if(aw.Tag.Trim() == "B") aw.Body = tbAnswerB.Text;
			if(aw.Tag.Trim() == "C") aw.Body = tbAnswerC.Text;
			if(aw.Tag.Trim() == "D") aw.Body = tbAnswerD.Text;
		}

		///将修改保存到数据库
		db.SubmitChanges();
		///跳转到考题管理页面
		Response.Redirect("~/Admin/QuestionManage.aspx");
	}	
}
