﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSLinqToSQL.Designer
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="SQLServer2005DB")]
	public partial class SchoolDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPerson(Student instance);
    partial void UpdatePerson(Student instance);
    partial void DeletePerson(Student instance);
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertCourseGrade(CourseGrade instance);
    partial void UpdateCourseGrade(CourseGrade instance);
    partial void DeleteCourseGrade(CourseGrade instance);
    #endregion
		
		public SchoolDataContext() : 
				base(global::CSLinqToSQL.Properties.Settings.Default.SQLServer2005DBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SchoolDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchoolDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchoolDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchoolDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<CourseGrade> CourseGrades
		{
			get
			{
				return this.GetTable<CourseGrade>();
			}
		}
	}
	
	[Table(Name="dbo.Person")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PersonID;
		
		private string _LastName;
		
		private string _FirstName;
		
		private System.Nullable<System.DateTime> _HireDate;
		
		private System.Nullable<System.DateTime> _EnrollmentDate;
		
		private System.Data.Linq.Binary _Picture;
		
		private short _PersonCategory;
		
		private EntitySet<CourseGrade> _CourseGrades;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPersonIDChanging(int value);
    partial void OnPersonIDChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnHireDateChanging(System.Nullable<System.DateTime> value);
    partial void OnHireDateChanged();
    partial void OnEnrollmentDateChanging(System.Nullable<System.DateTime> value);
    partial void OnEnrollmentDateChanged();
    partial void OnPictureChanging(System.Data.Linq.Binary value);
    partial void OnPictureChanged();
    partial void OnPersonCategoryChanging(short value);
    partial void OnPersonCategoryChanged();
    #endregion
		
		public Student()
		{
			this._CourseGrades = new EntitySet<CourseGrade>(new Action<CourseGrade>(this.attach_CourseGrades), new Action<CourseGrade>(this.detach_CourseGrades));
			OnCreated();
		}
		
		[Column(Storage="_PersonID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PersonID
		{
			get
			{
				return this._PersonID;
			}
			set
			{
				if ((this._PersonID != value))
				{
					this.OnPersonIDChanging(value);
					this.SendPropertyChanging();
					this._PersonID = value;
					this.SendPropertyChanged("PersonID");
					this.OnPersonIDChanged();
				}
			}
		}
		
		[Column(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[Column(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_HireDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> HireDate
		{
			get
			{
				return this._HireDate;
			}
			set
			{
				if ((this._HireDate != value))
				{
					this.OnHireDateChanging(value);
					this.SendPropertyChanging();
					this._HireDate = value;
					this.SendPropertyChanged("HireDate");
					this.OnHireDateChanged();
				}
			}
		}
		
		[Column(Storage="_EnrollmentDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> EnrollmentDate
		{
			get
			{
				return this._EnrollmentDate;
			}
			set
			{
				if ((this._EnrollmentDate != value))
				{
					this.OnEnrollmentDateChanging(value);
					this.SendPropertyChanging();
					this._EnrollmentDate = value;
					this.SendPropertyChanged("EnrollmentDate");
					this.OnEnrollmentDateChanged();
				}
			}
		}
		
		[Column(Storage="_Picture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[Column(Storage="_PersonCategory", DbType="SmallInt NOT NULL")]
		public short PersonCategory
		{
			get
			{
				return this._PersonCategory;
			}
			set
			{
				if ((this._PersonCategory != value))
				{
					this.OnPersonCategoryChanging(value);
					this.SendPropertyChanging();
					this._PersonCategory = value;
					this.SendPropertyChanged("PersonCategory");
					this.OnPersonCategoryChanged();
				}
			}
		}
		
		[Association(Name="Person_CourseGrade", Storage="_CourseGrades", ThisKey="PersonID", OtherKey="StudentID")]
		public EntitySet<CourseGrade> CourseGrades
		{
			get
			{
				return this._CourseGrades;
			}
			set
			{
				this._CourseGrades.Assign(value);
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
		
		private void attach_CourseGrades(CourseGrade entity)
		{
			this.SendPropertyChanging();
			entity.Person = this;
		}
		
		private void detach_CourseGrades(CourseGrade entity)
		{
			this.SendPropertyChanging();
			entity.Person = null;
		}
	}
	
	[Table(Name="dbo.Course")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CourseID;
		
		private string _Title;
		
		private int _Credits;
		
		private int _DepartmentID;
		
		private EntitySet<CourseGrade> _CourseGrades;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCourseIDChanging(int value);
    partial void OnCourseIDChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnCreditsChanging(int value);
    partial void OnCreditsChanged();
    partial void OnDepartmentIDChanging(int value);
    partial void OnDepartmentIDChanged();
    #endregion
		
		public Course()
		{
			this._CourseGrades = new EntitySet<CourseGrade>(new Action<CourseGrade>(this.attach_CourseGrades), new Action<CourseGrade>(this.detach_CourseGrades));
			OnCreated();
		}
		
		[Column(Storage="_CourseID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CourseID
		{
			get
			{
				return this._CourseID;
			}
			set
			{
				if ((this._CourseID != value))
				{
					this.OnCourseIDChanging(value);
					this.SendPropertyChanging();
					this._CourseID = value;
					this.SendPropertyChanged("CourseID");
					this.OnCourseIDChanged();
				}
			}
		}
		
		[Column(Storage="_Title", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[Column(Storage="_Credits", DbType="Int NOT NULL")]
		public int Credits
		{
			get
			{
				return this._Credits;
			}
			set
			{
				if ((this._Credits != value))
				{
					this.OnCreditsChanging(value);
					this.SendPropertyChanging();
					this._Credits = value;
					this.SendPropertyChanged("Credits");
					this.OnCreditsChanged();
				}
			}
		}
		
		[Column(Storage="_DepartmentID", DbType="Int NOT NULL")]
		public int DepartmentID
		{
			get
			{
				return this._DepartmentID;
			}
			set
			{
				if ((this._DepartmentID != value))
				{
					this.OnDepartmentIDChanging(value);
					this.SendPropertyChanging();
					this._DepartmentID = value;
					this.SendPropertyChanged("DepartmentID");
					this.OnDepartmentIDChanged();
				}
			}
		}
		
		[Association(Name="Course_CourseGrade", Storage="_CourseGrades", ThisKey="CourseID", OtherKey="CourseID")]
		public EntitySet<CourseGrade> CourseGrades
		{
			get
			{
				return this._CourseGrades;
			}
			set
			{
				this._CourseGrades.Assign(value);
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
		
		private void attach_CourseGrades(CourseGrade entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_CourseGrades(CourseGrade entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
	}
	
	[Table(Name="dbo.CourseGrade")]
	public partial class CourseGrade : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EnrollmentID;
		
		private int _CourseID;
		
		private int _StudentID;
		
		private System.Nullable<decimal> _Grade;
		
		private EntityRef<Course> _Course;
		
		private EntityRef<Student> _Person;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEnrollmentIDChanging(int value);
    partial void OnEnrollmentIDChanged();
    partial void OnCourseIDChanging(int value);
    partial void OnCourseIDChanged();
    partial void OnStudentIDChanging(int value);
    partial void OnStudentIDChanged();
    partial void OnGradeChanging(System.Nullable<decimal> value);
    partial void OnGradeChanged();
    #endregion
		
		public CourseGrade()
		{
			this._Course = default(EntityRef<Course>);
			this._Person = default(EntityRef<Student>);
			OnCreated();
		}
		
		[Column(Storage="_EnrollmentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EnrollmentID
		{
			get
			{
				return this._EnrollmentID;
			}
			set
			{
				if ((this._EnrollmentID != value))
				{
					this.OnEnrollmentIDChanging(value);
					this.SendPropertyChanging();
					this._EnrollmentID = value;
					this.SendPropertyChanged("EnrollmentID");
					this.OnEnrollmentIDChanged();
				}
			}
		}
		
		[Column(Storage="_CourseID", DbType="Int NOT NULL")]
		public int CourseID
		{
			get
			{
				return this._CourseID;
			}
			set
			{
				if ((this._CourseID != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCourseIDChanging(value);
					this.SendPropertyChanging();
					this._CourseID = value;
					this.SendPropertyChanged("CourseID");
					this.OnCourseIDChanged();
				}
			}
		}
		
		[Column(Storage="_StudentID", DbType="Int NOT NULL")]
		public int StudentID
		{
			get
			{
				return this._StudentID;
			}
			set
			{
				if ((this._StudentID != value))
				{
					if (this._Person.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentIDChanging(value);
					this.SendPropertyChanging();
					this._StudentID = value;
					this.SendPropertyChanged("StudentID");
					this.OnStudentIDChanged();
				}
			}
		}
		
		[Column(Storage="_Grade", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> Grade
		{
			get
			{
				return this._Grade;
			}
			set
			{
				if ((this._Grade != value))
				{
					this.OnGradeChanging(value);
					this.SendPropertyChanging();
					this._Grade = value;
					this.SendPropertyChanged("Grade");
					this.OnGradeChanged();
				}
			}
		}
		
		[Association(Name="Course_CourseGrade", Storage="_Course", ThisKey="CourseID", OtherKey="CourseID", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.CourseGrades.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.CourseGrades.Add(this);
						this._CourseID = value.CourseID;
					}
					else
					{
						this._CourseID = default(int);
					}
					this.SendPropertyChanged("Course");
				}
			}
		}
		
		[Association(Name="Person_CourseGrade", Storage="_Person", ThisKey="StudentID", OtherKey="PersonID", IsForeignKey=true)]
		public Student Person
		{
			get
			{
				return this._Person.Entity;
			}
			set
			{
				Student previousValue = this._Person.Entity;
				if (((previousValue != value) 
							|| (this._Person.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Person.Entity = null;
						previousValue.CourseGrades.Remove(this);
					}
					this._Person.Entity = value;
					if ((value != null))
					{
						value.CourseGrades.Add(this);
						this._StudentID = value.PersonID;
					}
					else
					{
						this._StudentID = default(int);
					}
					this.SendPropertyChanged("Person");
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
}
#pragma warning restore 1591
