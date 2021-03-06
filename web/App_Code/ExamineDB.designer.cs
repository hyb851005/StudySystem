﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18052
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ExamineDB")]
public partial class ExamineDBDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region 可扩展性方法定义
  partial void OnCreated();
  partial void InsertExaminee(Examinee instance);
  partial void UpdateExaminee(Examinee instance);
  partial void DeleteExaminee(Examinee instance);
  partial void InsertOnlineExamine(OnlineExamine instance);
  partial void UpdateOnlineExamine(OnlineExamine instance);
  partial void DeleteOnlineExamine(OnlineExamine instance);
  partial void InsertQuestion(Question instance);
  partial void UpdateQuestion(Question instance);
  partial void DeleteQuestion(Question instance);
  partial void InsertSubject(Subject instance);
  partial void UpdateSubject(Subject instance);
  partial void DeleteSubject(Subject instance);
  partial void InsertAnswer(Answer instance);
  partial void UpdateAnswer(Answer instance);
  partial void DeleteAnswer(Answer instance);
  partial void InsertAdminUser(AdminUser instance);
  partial void UpdateAdminUser(AdminUser instance);
  partial void DeleteAdminUser(AdminUser instance);
  partial void InsertExamineeAnswer(ExamineeAnswer instance);
  partial void UpdateExamineeAnswer(ExamineeAnswer instance);
  partial void DeleteExamineeAnswer(ExamineeAnswer instance);
  #endregion
	
	public ExamineDBDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ExamineDBConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public ExamineDBDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ExamineDBDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ExamineDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public ExamineDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Examinee> Examinee
	{
		get
		{
			return this.GetTable<Examinee>();
		}
	}
	
	public System.Data.Linq.Table<OnlineExamine> OnlineExamine
	{
		get
		{
			return this.GetTable<OnlineExamine>();
		}
	}
	
	public System.Data.Linq.Table<Question> Question
	{
		get
		{
			return this.GetTable<Question>();
		}
	}
	
	public System.Data.Linq.Table<Subject> Subject
	{
		get
		{
			return this.GetTable<Subject>();
		}
	}
	
	public System.Data.Linq.Table<Answer> Answer
	{
		get
		{
			return this.GetTable<Answer>();
		}
	}
	
	public System.Data.Linq.Table<AdminUser> AdminUser
	{
		get
		{
			return this.GetTable<AdminUser>();
		}
	}
	
	public System.Data.Linq.Table<ExamineeAnswer> ExamineeAnswer
	{
		get
		{
			return this.GetTable<ExamineeAnswer>();
		}
	}
	
	[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Pr_GetScores")]
	public ISingleResult<Pr_GetScoresResult> Pr_GetScores()
	{
		IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
		return ((ISingleResult<Pr_GetScoresResult>)(result.ReturnValue));
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Examinee")]
public partial class Examinee : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Username;
	
	private string _Password;
	
	private System.Nullable<byte> _Status;
	
	private EntitySet<OnlineExamine> _OnlineExamine;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnStatusChanging(System.Nullable<byte> value);
    partial void OnStatusChanged();
    #endregion
	
	public Examinee()
	{
		this._OnlineExamine = new EntitySet<OnlineExamine>(new Action<OnlineExamine>(this.attach_OnlineExamine), new Action<OnlineExamine>(this.detach_OnlineExamine));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50)")]
	public string Username
	{
		get
		{
			return this._Username;
		}
		set
		{
			if ((this._Username != value))
			{
				this.OnUsernameChanging(value);
				this.SendPropertyChanging();
				this._Username = value;
				this.SendPropertyChanged("Username");
				this.OnUsernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(255)")]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="TinyInt")]
	public System.Nullable<byte> Status
	{
		get
		{
			return this._Status;
		}
		set
		{
			if ((this._Status != value))
			{
				this.OnStatusChanging(value);
				this.SendPropertyChanging();
				this._Status = value;
				this.SendPropertyChanged("Status");
				this.OnStatusChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Examinee_OnlineExamine", Storage="_OnlineExamine", ThisKey="ID", OtherKey="ExamineeID")]
	public EntitySet<OnlineExamine> OnlineExamine
	{
		get
		{
			return this._OnlineExamine;
		}
		set
		{
			this._OnlineExamine.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_OnlineExamine(OnlineExamine entity)
	{
		this.SendPropertyChanging();
		entity.Examinee = this;
	}
	
	private void detach_OnlineExamine(OnlineExamine entity)
	{
		this.SendPropertyChanging();
		entity.Examinee = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.OnlineExamine")]
public partial class OnlineExamine : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private System.Nullable<int> _ExamineeID;
	
	private System.Nullable<int> _SubjectID;
	
	private System.Nullable<System.DateTime> _StartTime;
	
	private System.Nullable<System.DateTime> _EndTime;
	
	private System.Nullable<int> _Score;
	
	private EntitySet<ExamineeAnswer> _ExamineeAnswer;
	
	private EntityRef<Examinee> _Examinee;
	
	private EntityRef<Subject> _Subject;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnExamineeIDChanging(System.Nullable<int> value);
    partial void OnExamineeIDChanged();
    partial void OnSubjectIDChanging(System.Nullable<int> value);
    partial void OnSubjectIDChanged();
    partial void OnStartTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnStartTimeChanged();
    partial void OnEndTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnEndTimeChanged();
    partial void OnScoreChanging(System.Nullable<int> value);
    partial void OnScoreChanged();
    #endregion
	
	public OnlineExamine()
	{
		this._ExamineeAnswer = new EntitySet<ExamineeAnswer>(new Action<ExamineeAnswer>(this.attach_ExamineeAnswer), new Action<ExamineeAnswer>(this.detach_ExamineeAnswer));
		this._Examinee = default(EntityRef<Examinee>);
		this._Subject = default(EntityRef<Subject>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExamineeID", DbType="Int")]
	public System.Nullable<int> ExamineeID
	{
		get
		{
			return this._ExamineeID;
		}
		set
		{
			if ((this._ExamineeID != value))
			{
				if (this._Examinee.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnExamineeIDChanging(value);
				this.SendPropertyChanging();
				this._ExamineeID = value;
				this.SendPropertyChanged("ExamineeID");
				this.OnExamineeIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectID", DbType="Int")]
	public System.Nullable<int> SubjectID
	{
		get
		{
			return this._SubjectID;
		}
		set
		{
			if ((this._SubjectID != value))
			{
				if (this._Subject.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnSubjectIDChanging(value);
				this.SendPropertyChanging();
				this._SubjectID = value;
				this.SendPropertyChanged("SubjectID");
				this.OnSubjectIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="DateTime")]
	public System.Nullable<System.DateTime> StartTime
	{
		get
		{
			return this._StartTime;
		}
		set
		{
			if ((this._StartTime != value))
			{
				this.OnStartTimeChanging(value);
				this.SendPropertyChanging();
				this._StartTime = value;
				this.SendPropertyChanged("StartTime");
				this.OnStartTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndTime", DbType="DateTime")]
	public System.Nullable<System.DateTime> EndTime
	{
		get
		{
			return this._EndTime;
		}
		set
		{
			if ((this._EndTime != value))
			{
				this.OnEndTimeChanging(value);
				this.SendPropertyChanging();
				this._EndTime = value;
				this.SendPropertyChanged("EndTime");
				this.OnEndTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Score", DbType="Int")]
	public System.Nullable<int> Score
	{
		get
		{
			return this._Score;
		}
		set
		{
			if ((this._Score != value))
			{
				this.OnScoreChanging(value);
				this.SendPropertyChanging();
				this._Score = value;
				this.SendPropertyChanged("Score");
				this.OnScoreChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OnlineExamine_ExamineeAnswer", Storage="_ExamineeAnswer", ThisKey="ID", OtherKey="OnlineExamineID")]
	public EntitySet<ExamineeAnswer> ExamineeAnswer
	{
		get
		{
			return this._ExamineeAnswer;
		}
		set
		{
			this._ExamineeAnswer.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Examinee_OnlineExamine", Storage="_Examinee", ThisKey="ExamineeID", OtherKey="ID", IsForeignKey=true)]
	public Examinee Examinee
	{
		get
		{
			return this._Examinee.Entity;
		}
		set
		{
			Examinee previousValue = this._Examinee.Entity;
			if (((previousValue != value) 
						|| (this._Examinee.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Examinee.Entity = null;
					previousValue.OnlineExamine.Remove(this);
				}
				this._Examinee.Entity = value;
				if ((value != null))
				{
					value.OnlineExamine.Add(this);
					this._ExamineeID = value.ID;
				}
				else
				{
					this._ExamineeID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Examinee");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_OnlineExamine", Storage="_Subject", ThisKey="SubjectID", OtherKey="ID", IsForeignKey=true)]
	public Subject Subject
	{
		get
		{
			return this._Subject.Entity;
		}
		set
		{
			Subject previousValue = this._Subject.Entity;
			if (((previousValue != value) 
						|| (this._Subject.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Subject.Entity = null;
					previousValue.OnlineExamine.Remove(this);
				}
				this._Subject.Entity = value;
				if ((value != null))
				{
					value.OnlineExamine.Add(this);
					this._SubjectID = value.ID;
				}
				else
				{
					this._SubjectID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Subject");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_ExamineeAnswer(ExamineeAnswer entity)
	{
		this.SendPropertyChanging();
		entity.OnlineExamine = this;
	}
	
	private void detach_ExamineeAnswer(ExamineeAnswer entity)
	{
		this.SendPropertyChanging();
		entity.OnlineExamine = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Question")]
public partial class Question : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Title;
	
	private System.Nullable<int> _Score;
	
	private string _Answer;
	
	private System.Nullable<int> _SubjectID;
	
	private EntitySet<Answer> _Answer1;
	
	private EntitySet<ExamineeAnswer> _ExamineeAnswer;
	
	private EntityRef<Subject> _Subject;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnScoreChanging(System.Nullable<int> value);
    partial void OnScoreChanged();
    partial void OnAnswerChanging(string value);
    partial void OnAnswerChanged();
    partial void OnSubjectIDChanging(System.Nullable<int> value);
    partial void OnSubjectIDChanged();
    #endregion
	
	public Question()
	{
		this._Answer1 = new EntitySet<Answer>(new Action<Answer>(this.attach_Answer1), new Action<Answer>(this.detach_Answer1));
		this._ExamineeAnswer = new EntitySet<ExamineeAnswer>(new Action<ExamineeAnswer>(this.attach_ExamineeAnswer), new Action<ExamineeAnswer>(this.detach_ExamineeAnswer));
		this._Subject = default(EntityRef<Subject>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(2000)")]
	public string Title
	{
		get
		{
			return this._Title;
		}
		set
		{
			if ((this._Title != value))
			{
				this.OnTitleChanging(value);
				this.SendPropertyChanging();
				this._Title = value;
				this.SendPropertyChanged("Title");
				this.OnTitleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Score", DbType="Int")]
	public System.Nullable<int> Score
	{
		get
		{
			return this._Score;
		}
		set
		{
			if ((this._Score != value))
			{
				this.OnScoreChanging(value);
				this.SendPropertyChanging();
				this._Score = value;
				this.SendPropertyChanged("Score");
				this.OnScoreChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer", DbType="Char(2)")]
	public string Answer
	{
		get
		{
			return this._Answer;
		}
		set
		{
			if ((this._Answer != value))
			{
				this.OnAnswerChanging(value);
				this.SendPropertyChanging();
				this._Answer = value;
				this.SendPropertyChanged("Answer");
				this.OnAnswerChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectID", DbType="Int")]
	public System.Nullable<int> SubjectID
	{
		get
		{
			return this._SubjectID;
		}
		set
		{
			if ((this._SubjectID != value))
			{
				if (this._Subject.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnSubjectIDChanging(value);
				this.SendPropertyChanging();
				this._SubjectID = value;
				this.SendPropertyChanged("SubjectID");
				this.OnSubjectIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Question_Answer", Storage="_Answer1", ThisKey="ID", OtherKey="QuestionID")]
	public EntitySet<Answer> Answer1
	{
		get
		{
			return this._Answer1;
		}
		set
		{
			this._Answer1.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Question_ExamineeAnswer", Storage="_ExamineeAnswer", ThisKey="ID", OtherKey="QuestionID")]
	public EntitySet<ExamineeAnswer> ExamineeAnswer
	{
		get
		{
			return this._ExamineeAnswer;
		}
		set
		{
			this._ExamineeAnswer.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_Question", Storage="_Subject", ThisKey="SubjectID", OtherKey="ID", IsForeignKey=true)]
	public Subject Subject
	{
		get
		{
			return this._Subject.Entity;
		}
		set
		{
			Subject previousValue = this._Subject.Entity;
			if (((previousValue != value) 
						|| (this._Subject.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Subject.Entity = null;
					previousValue.Question.Remove(this);
				}
				this._Subject.Entity = value;
				if ((value != null))
				{
					value.Question.Add(this);
					this._SubjectID = value.ID;
				}
				else
				{
					this._SubjectID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Subject");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_Answer1(Answer entity)
	{
		this.SendPropertyChanging();
		entity.Question = this;
	}
	
	private void detach_Answer1(Answer entity)
	{
		this.SendPropertyChanging();
		entity.Question = null;
	}
	
	private void attach_ExamineeAnswer(ExamineeAnswer entity)
	{
		this.SendPropertyChanging();
		entity.Question = this;
	}
	
	private void detach_ExamineeAnswer(ExamineeAnswer entity)
	{
		this.SendPropertyChanging();
		entity.Question = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Subject")]
public partial class Subject : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Name;
	
	private EntitySet<OnlineExamine> _OnlineExamine;
	
	private EntitySet<Question> _Question;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
	
	public Subject()
	{
		this._OnlineExamine = new EntitySet<OnlineExamine>(new Action<OnlineExamine>(this.attach_OnlineExamine), new Action<OnlineExamine>(this.detach_OnlineExamine));
		this._Question = new EntitySet<Question>(new Action<Question>(this.attach_Question), new Action<Question>(this.detach_Question));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
	public string Name
	{
		get
		{
			return this._Name;
		}
		set
		{
			if ((this._Name != value))
			{
				this.OnNameChanging(value);
				this.SendPropertyChanging();
				this._Name = value;
				this.SendPropertyChanged("Name");
				this.OnNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_OnlineExamine", Storage="_OnlineExamine", ThisKey="ID", OtherKey="SubjectID")]
	public EntitySet<OnlineExamine> OnlineExamine
	{
		get
		{
			return this._OnlineExamine;
		}
		set
		{
			this._OnlineExamine.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subject_Question", Storage="_Question", ThisKey="ID", OtherKey="SubjectID")]
	public EntitySet<Question> Question
	{
		get
		{
			return this._Question;
		}
		set
		{
			this._Question.Assign(value);
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
	
	private void attach_OnlineExamine(OnlineExamine entity)
	{
		this.SendPropertyChanging();
		entity.Subject = this;
	}
	
	private void detach_OnlineExamine(OnlineExamine entity)
	{
		this.SendPropertyChanging();
		entity.Subject = null;
	}
	
	private void attach_Question(Question entity)
	{
		this.SendPropertyChanging();
		entity.Subject = this;
	}
	
	private void detach_Question(Question entity)
	{
		this.SendPropertyChanging();
		entity.Subject = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Answer")]
public partial class Answer : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Tag;
	
	private string _Body;
	
	private System.Nullable<int> _QuestionID;
	
	private EntityRef<Question> _Question;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTagChanging(string value);
    partial void OnTagChanged();
    partial void OnBodyChanging(string value);
    partial void OnBodyChanged();
    partial void OnQuestionIDChanging(System.Nullable<int> value);
    partial void OnQuestionIDChanged();
    #endregion
	
	public Answer()
	{
		this._Question = default(EntityRef<Question>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tag", DbType="Char(2)")]
	public string Tag
	{
		get
		{
			return this._Tag;
		}
		set
		{
			if ((this._Tag != value))
			{
				this.OnTagChanging(value);
				this.SendPropertyChanging();
				this._Tag = value;
				this.SendPropertyChanged("Tag");
				this.OnTagChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Body", DbType="VarChar(1000)")]
	public string Body
	{
		get
		{
			return this._Body;
		}
		set
		{
			if ((this._Body != value))
			{
				this.OnBodyChanging(value);
				this.SendPropertyChanging();
				this._Body = value;
				this.SendPropertyChanged("Body");
				this.OnBodyChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionID", DbType="Int")]
	public System.Nullable<int> QuestionID
	{
		get
		{
			return this._QuestionID;
		}
		set
		{
			if ((this._QuestionID != value))
			{
				if (this._Question.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnQuestionIDChanging(value);
				this.SendPropertyChanging();
				this._QuestionID = value;
				this.SendPropertyChanged("QuestionID");
				this.OnQuestionIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Question_Answer", Storage="_Question", ThisKey="QuestionID", OtherKey="ID", IsForeignKey=true)]
	public Question Question
	{
		get
		{
			return this._Question.Entity;
		}
		set
		{
			Question previousValue = this._Question.Entity;
			if (((previousValue != value) 
						|| (this._Question.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Question.Entity = null;
					previousValue.Answer1.Remove(this);
				}
				this._Question.Entity = value;
				if ((value != null))
				{
					value.Answer1.Add(this);
					this._QuestionID = value.ID;
				}
				else
				{
					this._QuestionID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Question");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AdminUser")]
public partial class AdminUser : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private string _Username;
	
	private string _Password;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
	
	public AdminUser()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50)")]
	public string Username
	{
		get
		{
			return this._Username;
		}
		set
		{
			if ((this._Username != value))
			{
				this.OnUsernameChanging(value);
				this.SendPropertyChanging();
				this._Username = value;
				this.SendPropertyChanged("Username");
				this.OnUsernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(255)")]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExamineeAnswer")]
public partial class ExamineeAnswer : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ID;
	
	private System.Nullable<int> _OnlineExamineID;
	
	private System.Nullable<int> _QuestionID;
	
	private string _Answer;
	
	private EntityRef<OnlineExamine> _OnlineExamine;
	
	private EntityRef<Question> _Question;
	
    #region 可扩展性方法定义
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnOnlineExamineIDChanging(System.Nullable<int> value);
    partial void OnOnlineExamineIDChanged();
    partial void OnQuestionIDChanging(System.Nullable<int> value);
    partial void OnQuestionIDChanged();
    partial void OnAnswerChanging(string value);
    partial void OnAnswerChanged();
    #endregion
	
	public ExamineeAnswer()
	{
		this._OnlineExamine = default(EntityRef<OnlineExamine>);
		this._Question = default(EntityRef<Question>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this.OnIDChanging(value);
				this.SendPropertyChanging();
				this._ID = value;
				this.SendPropertyChanged("ID");
				this.OnIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OnlineExamineID", DbType="Int")]
	public System.Nullable<int> OnlineExamineID
	{
		get
		{
			return this._OnlineExamineID;
		}
		set
		{
			if ((this._OnlineExamineID != value))
			{
				if (this._OnlineExamine.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnOnlineExamineIDChanging(value);
				this.SendPropertyChanging();
				this._OnlineExamineID = value;
				this.SendPropertyChanged("OnlineExamineID");
				this.OnOnlineExamineIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QuestionID", DbType="Int")]
	public System.Nullable<int> QuestionID
	{
		get
		{
			return this._QuestionID;
		}
		set
		{
			if ((this._QuestionID != value))
			{
				if (this._Question.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnQuestionIDChanging(value);
				this.SendPropertyChanging();
				this._QuestionID = value;
				this.SendPropertyChanged("QuestionID");
				this.OnQuestionIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer", DbType="Char(2)")]
	public string Answer
	{
		get
		{
			return this._Answer;
		}
		set
		{
			if ((this._Answer != value))
			{
				this.OnAnswerChanging(value);
				this.SendPropertyChanging();
				this._Answer = value;
				this.SendPropertyChanged("Answer");
				this.OnAnswerChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="OnlineExamine_ExamineeAnswer", Storage="_OnlineExamine", ThisKey="OnlineExamineID", OtherKey="ID", IsForeignKey=true)]
	public OnlineExamine OnlineExamine
	{
		get
		{
			return this._OnlineExamine.Entity;
		}
		set
		{
			OnlineExamine previousValue = this._OnlineExamine.Entity;
			if (((previousValue != value) 
						|| (this._OnlineExamine.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OnlineExamine.Entity = null;
					previousValue.ExamineeAnswer.Remove(this);
				}
				this._OnlineExamine.Entity = value;
				if ((value != null))
				{
					value.ExamineeAnswer.Add(this);
					this._OnlineExamineID = value.ID;
				}
				else
				{
					this._OnlineExamineID = default(Nullable<int>);
				}
				this.SendPropertyChanged("OnlineExamine");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Question_ExamineeAnswer", Storage="_Question", ThisKey="QuestionID", OtherKey="ID", IsForeignKey=true)]
	public Question Question
	{
		get
		{
			return this._Question.Entity;
		}
		set
		{
			Question previousValue = this._Question.Entity;
			if (((previousValue != value) 
						|| (this._Question.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Question.Entity = null;
					previousValue.ExamineeAnswer.Remove(this);
				}
				this._Question.Entity = value;
				if ((value != null))
				{
					value.ExamineeAnswer.Add(this);
					this._QuestionID = value.ID;
				}
				else
				{
					this._QuestionID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Question");
			}
		}
	}
	
	public event PropertyChangingEventHandler PropertyChanging;
	
	public event PropertyChangedEventHandler PropertyChanged;
	
	protected virtual void SendPropertyChanging()
	{
		if ((this.PropertyChanging != null))
		{
			this.PropertyChanging(this, emptyChangingEventArgs);
		}
	}
	
	protected virtual void SendPropertyChanged(String propertyName)
	{
		if ((this.PropertyChanged != null))
		{
			this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

public partial class Pr_GetScoresResult
{
	
	private int _ID;
	
	private System.Nullable<int> _ExamineeID;
	
	private System.Nullable<int> _SubjectID;
	
	private System.Nullable<System.DateTime> _StartTime;
	
	private System.Nullable<System.DateTime> _EndTime;
	
	private System.Nullable<int> _Score;
	
	private string _Username;
	
	private string _SubjectName;
	
	public Pr_GetScoresResult()
	{
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL")]
	public int ID
	{
		get
		{
			return this._ID;
		}
		set
		{
			if ((this._ID != value))
			{
				this._ID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExamineeID", DbType="Int")]
	public System.Nullable<int> ExamineeID
	{
		get
		{
			return this._ExamineeID;
		}
		set
		{
			if ((this._ExamineeID != value))
			{
				this._ExamineeID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectID", DbType="Int")]
	public System.Nullable<int> SubjectID
	{
		get
		{
			return this._SubjectID;
		}
		set
		{
			if ((this._SubjectID != value))
			{
				this._SubjectID = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="DateTime")]
	public System.Nullable<System.DateTime> StartTime
	{
		get
		{
			return this._StartTime;
		}
		set
		{
			if ((this._StartTime != value))
			{
				this._StartTime = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndTime", DbType="DateTime")]
	public System.Nullable<System.DateTime> EndTime
	{
		get
		{
			return this._EndTime;
		}
		set
		{
			if ((this._EndTime != value))
			{
				this._EndTime = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Score", DbType="Int")]
	public System.Nullable<int> Score
	{
		get
		{
			return this._Score;
		}
		set
		{
			if ((this._Score != value))
			{
				this._Score = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50)")]
	public string Username
	{
		get
		{
			return this._Username;
		}
		set
		{
			if ((this._Username != value))
			{
				this._Username = value;
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectName", DbType="VarChar(50)")]
	public string SubjectName
	{
		get
		{
			return this._SubjectName;
		}
		set
		{
			if ((this._SubjectName != value))
			{
				this._SubjectName = value;
			}
		}
	}
}
#pragma warning restore 1591
