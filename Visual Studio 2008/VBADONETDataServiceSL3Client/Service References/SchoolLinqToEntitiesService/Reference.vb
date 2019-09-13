'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4927
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


'Original file name:
'Generation date: 9/16/2009 7:26:20 PM
Namespace SchoolLinqToEntitiesService
    '''<summary>
    '''There are no comments for SQLServer2005DBEntities in the schema.
    '''</summary>
    Partial Public Class SQLServer2005DBEntities
        Inherits Global.System.Data.Services.Client.DataServiceContext
        '''<summary>
        '''Initialize a new SQLServer2005DBEntities object.
        '''</summary>
        Public Sub New(ByVal serviceRoot As Global.System.Uri)
            MyBase.New(serviceRoot)
            Me.ResolveName = AddressOf Me.ResolveNameFromType
            Me.ResolveType = AddressOf Me.ResolveTypeFromName
            Me.OnContextCreated
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        Private Shared ROOTNAMESPACE As String = GetType(SchoolLinqToEntitiesService.SQLServer2005DBEntities).Namespace.Remove(GetType(SchoolLinqToEntitiesService.SQLServer2005DBEntities).Namespace.LastIndexOf("SchoolLinqToEntitiesService"))
        '''<summary>
        '''Since the namespace configured for this service reference
        '''in Visual Studio is different from the one indicated in the
        '''server schema, use type-mappers to map between the two.
        '''</summary>
        Protected Function ResolveTypeFromName(ByVal typeName As String) As Global.System.Type
            If typeName.StartsWith("SQLServer2005DBModel", Global.System.StringComparison.OrdinalIgnoreCase) Then
                Return Me.GetType.Assembly.GetType(String.Concat(String.Concat(ROOTNAMESPACE, "SchoolLinqToEntitiesService"), typeName.Substring(20)), true)
            End If
            Return Nothing
        End Function
        '''<summary>
        '''Since the namespace configured for this service reference
        '''in Visual Studio is different from the one indicated in the
        '''server schema, use type-mappers to map between the two.
        '''</summary>
        Protected Function ResolveNameFromType(ByVal clientType As Global.System.Type) As String
            If clientType.Namespace.Equals(String.Concat(ROOTNAMESPACE, "SchoolLinqToEntitiesService"), Global.System.StringComparison.OrdinalIgnoreCase) Then
                Return String.Concat("SQLServer2005DBModel.", clientType.Name)
            End If
            Return Nothing
        End Function
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        Public ReadOnly Property Course() As Global.System.Data.Services.Client.DataServiceQuery(Of Course)
            Get
                If (Me._Course Is Nothing) Then
                    Me._Course = MyBase.CreateQuery(Of Course)("Course")
                End If
                Return Me._Course
            End Get
        End Property
        Private _Course As Global.System.Data.Services.Client.DataServiceQuery(Of Course)
        '''<summary>
        '''There are no comments for CourseGrade in the schema.
        '''</summary>
        Public ReadOnly Property CourseGrade() As Global.System.Data.Services.Client.DataServiceQuery(Of CourseGrade)
            Get
                If (Me._CourseGrade Is Nothing) Then
                    Me._CourseGrade = MyBase.CreateQuery(Of CourseGrade)("CourseGrade")
                End If
                Return Me._CourseGrade
            End Get
        End Property
        Private _CourseGrade As Global.System.Data.Services.Client.DataServiceQuery(Of CourseGrade)
        '''<summary>
        '''There are no comments for Person in the schema.
        '''</summary>
        Public ReadOnly Property Person() As Global.System.Data.Services.Client.DataServiceQuery(Of Person)
            Get
                If (Me._Person Is Nothing) Then
                    Me._Person = MyBase.CreateQuery(Of Person)("Person")
                End If
                Return Me._Person
            End Get
        End Property
        Private _Person As Global.System.Data.Services.Client.DataServiceQuery(Of Person)
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        Public Sub AddToCourse(ByVal course As Course)
            MyBase.AddObject("Course", course)
        End Sub
        '''<summary>
        '''There are no comments for CourseGrade in the schema.
        '''</summary>
        Public Sub AddToCourseGrade(ByVal courseGrade As CourseGrade)
            MyBase.AddObject("CourseGrade", courseGrade)
        End Sub
        '''<summary>
        '''There are no comments for Person in the schema.
        '''</summary>
        Public Sub AddToPerson(ByVal person As Person)
            MyBase.AddObject("Person", person)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for SQLServer2005DBModel.Course in the schema.
    '''</summary>
    '''<KeyProperties>
    '''CourseID
    '''</KeyProperties>
    <Global.System.Data.Services.Common.DataServiceKeyAttribute("CourseID")>  _
    Partial Public Class Course
        '''<summary>
        '''Create a new Course object.
        '''</summary>
        '''<param name="courseID">Initial value of CourseID.</param>
        '''<param name="title">Initial value of Title.</param>
        '''<param name="credits">Initial value of Credits.</param>
        '''<param name="departmentID">Initial value of DepartmentID.</param>
        Public Shared Function CreateCourse(ByVal courseID As Integer, ByVal title As String, ByVal credits As Integer, ByVal departmentID As Integer) As Course
            Dim course As Course = New Course
            course.CourseID = courseID
            course.Title = title
            course.Credits = credits
            course.DepartmentID = departmentID
            Return course
        End Function
        '''<summary>
        '''There are no comments for Property CourseID in the schema.
        '''</summary>
        Public Property CourseID() As Integer
            Get
                Return Me._CourseID
            End Get
            Set
                Me.OnCourseIDChanging(value)
                Me._CourseID = value
                Me.OnCourseIDChanged
            End Set
        End Property
        Private _CourseID As Integer
        Partial Private Sub OnCourseIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnCourseIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Title in the schema.
        '''</summary>
        Public Property Title() As String
            Get
                Return Me._Title
            End Get
            Set
                Me.OnTitleChanging(value)
                Me._Title = value
                Me.OnTitleChanged
            End Set
        End Property
        Private _Title As String
        Partial Private Sub OnTitleChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnTitleChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Credits in the schema.
        '''</summary>
        Public Property Credits() As Integer
            Get
                Return Me._Credits
            End Get
            Set
                Me.OnCreditsChanging(value)
                Me._Credits = value
                Me.OnCreditsChanged
            End Set
        End Property
        Private _Credits As Integer
        Partial Private Sub OnCreditsChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnCreditsChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property DepartmentID in the schema.
        '''</summary>
        Public Property DepartmentID() As Integer
            Get
                Return Me._DepartmentID
            End Get
            Set
                Me.OnDepartmentIDChanging(value)
                Me._DepartmentID = value
                Me.OnDepartmentIDChanged
            End Set
        End Property
        Private _DepartmentID As Integer
        Partial Private Sub OnDepartmentIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnDepartmentIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for CourseGrade in the schema.
        '''</summary>
        Public Property CourseGrade() As Global.System.Collections.ObjectModel.Collection(Of CourseGrade)
            Get
                Return Me._CourseGrade
            End Get
            Set
                If (Not (value) Is Nothing) Then
                    Me._CourseGrade = value
                End If
            End Set
        End Property
        Private _CourseGrade As Global.System.Collections.ObjectModel.Collection(Of CourseGrade) = New Global.System.Collections.ObjectModel.Collection(Of CourseGrade)
        '''<summary>
        '''There are no comments for Person in the schema.
        '''</summary>
        Public Property Person() As Global.System.Collections.ObjectModel.Collection(Of Person)
            Get
                Return Me._Person
            End Get
            Set
                If (Not (value) Is Nothing) Then
                    Me._Person = value
                End If
            End Set
        End Property
        Private _Person As Global.System.Collections.ObjectModel.Collection(Of Person) = New Global.System.Collections.ObjectModel.Collection(Of Person)
    End Class
    '''<summary>
    '''There are no comments for SQLServer2005DBModel.CourseGrade in the schema.
    '''</summary>
    '''<KeyProperties>
    '''EnrollmentID
    '''</KeyProperties>
    <Global.System.Data.Services.Common.DataServiceKeyAttribute("EnrollmentID")>  _
    Partial Public Class CourseGrade
        '''<summary>
        '''Create a new CourseGrade object.
        '''</summary>
        '''<param name="enrollmentID">Initial value of EnrollmentID.</param>
        Public Shared Function CreateCourseGrade(ByVal enrollmentID As Integer) As CourseGrade
            Dim courseGrade As CourseGrade = New CourseGrade
            courseGrade.EnrollmentID = enrollmentID
            Return courseGrade
        End Function
        '''<summary>
        '''There are no comments for Property EnrollmentID in the schema.
        '''</summary>
        Public Property EnrollmentID() As Integer
            Get
                Return Me._EnrollmentID
            End Get
            Set
                Me.OnEnrollmentIDChanging(value)
                Me._EnrollmentID = value
                Me.OnEnrollmentIDChanged
            End Set
        End Property
        Private _EnrollmentID As Integer
        Partial Private Sub OnEnrollmentIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnEnrollmentIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Grade in the schema.
        '''</summary>
        Public Property Grade() As Global.System.Nullable(Of Decimal)
            Get
                Return Me._Grade
            End Get
            Set
                Me.OnGradeChanging(value)
                Me._Grade = value
                Me.OnGradeChanged
            End Set
        End Property
        Private _Grade As Global.System.Nullable(Of Decimal)
        Partial Private Sub OnGradeChanging(ByVal value As Global.System.Nullable(Of Decimal))
        End Sub
        Partial Private Sub OnGradeChanged()
        End Sub
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        Public Property Course() As Course
            Get
                Return Me._Course
            End Get
            Set
                Me._Course = value
            End Set
        End Property
        Private _Course As Course
        '''<summary>
        '''There are no comments for Person in the schema.
        '''</summary>
        Public Property Person() As Person
            Get
                Return Me._Person
            End Get
            Set
                Me._Person = value
            End Set
        End Property
        Private _Person As Person
    End Class
    '''<summary>
    '''There are no comments for SQLServer2005DBModel.Person in the schema.
    '''</summary>
    '''<KeyProperties>
    '''PersonID
    '''</KeyProperties>
    <Global.System.Data.Services.Common.DataServiceKeyAttribute("PersonID")>  _
    Partial Public Class Person
        '''<summary>
        '''Create a new Person object.
        '''</summary>
        '''<param name="personID">Initial value of PersonID.</param>
        '''<param name="lastName">Initial value of LastName.</param>
        '''<param name="firstName">Initial value of FirstName.</param>
        '''<param name="personCategory">Initial value of PersonCategory.</param>
        Public Shared Function CreatePerson(ByVal personID As Integer, ByVal lastName As String, ByVal firstName As String, ByVal personCategory As Short) As Person
            Dim person As Person = New Person
            person.PersonID = personID
            person.LastName = lastName
            person.FirstName = firstName
            person.PersonCategory = personCategory
            Return person
        End Function
        '''<summary>
        '''There are no comments for Property PersonID in the schema.
        '''</summary>
        Public Property PersonID() As Integer
            Get
                Return Me._PersonID
            End Get
            Set
                Me.OnPersonIDChanging(value)
                Me._PersonID = value
                Me.OnPersonIDChanged
            End Set
        End Property
        Private _PersonID As Integer
        Partial Private Sub OnPersonIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnPersonIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property LastName in the schema.
        '''</summary>
        Public Property LastName() As String
            Get
                Return Me._LastName
            End Get
            Set
                Me.OnLastNameChanging(value)
                Me._LastName = value
                Me.OnLastNameChanged
            End Set
        End Property
        Private _LastName As String
        Partial Private Sub OnLastNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnLastNameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property FirstName in the schema.
        '''</summary>
        Public Property FirstName() As String
            Get
                Return Me._FirstName
            End Get
            Set
                Me.OnFirstNameChanging(value)
                Me._FirstName = value
                Me.OnFirstNameChanged
            End Set
        End Property
        Private _FirstName As String
        Partial Private Sub OnFirstNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnFirstNameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property PersonCategory in the schema.
        '''</summary>
        Public Property PersonCategory() As Short
            Get
                Return Me._PersonCategory
            End Get
            Set
                Me.OnPersonCategoryChanging(value)
                Me._PersonCategory = value
                Me.OnPersonCategoryChanged
            End Set
        End Property
        Private _PersonCategory As Short
        Partial Private Sub OnPersonCategoryChanging(ByVal value As Short)
        End Sub
        Partial Private Sub OnPersonCategoryChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property HireDate in the schema.
        '''</summary>
        Public Property HireDate() As Global.System.Nullable(Of Date)
            Get
                Return Me._HireDate
            End Get
            Set
                Me.OnHireDateChanging(value)
                Me._HireDate = value
                Me.OnHireDateChanged
            End Set
        End Property
        Private _HireDate As Global.System.Nullable(Of Date)
        Partial Private Sub OnHireDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnHireDateChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property EnrollmentDate in the schema.
        '''</summary>
        Public Property EnrollmentDate() As Global.System.Nullable(Of Date)
            Get
                Return Me._EnrollmentDate
            End Get
            Set
                Me.OnEnrollmentDateChanging(value)
                Me._EnrollmentDate = value
                Me.OnEnrollmentDateChanged
            End Set
        End Property
        Private _EnrollmentDate As Global.System.Nullable(Of Date)
        Partial Private Sub OnEnrollmentDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnEnrollmentDateChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Picture in the schema.
        '''</summary>
        Public Property Picture() As Byte()
            Get
                If (Not (Me._Picture) Is Nothing) Then
                    Return CType(Me._Picture.Clone,Byte())
                Else
                    Return Nothing
                End If
            End Get
            Set
                Me.OnPictureChanging(value)
                Me._Picture = value
                Me.OnPictureChanged
            End Set
        End Property
        Private _Picture() As Byte
        Partial Private Sub OnPictureChanging(ByVal value() As Byte)
        End Sub
        Partial Private Sub OnPictureChanged()
        End Sub
        '''<summary>
        '''There are no comments for CourseGrade in the schema.
        '''</summary>
        Public Property CourseGrade() As Global.System.Collections.ObjectModel.Collection(Of CourseGrade)
            Get
                Return Me._CourseGrade
            End Get
            Set
                If (Not (value) Is Nothing) Then
                    Me._CourseGrade = value
                End If
            End Set
        End Property
        Private _CourseGrade As Global.System.Collections.ObjectModel.Collection(Of CourseGrade) = New Global.System.Collections.ObjectModel.Collection(Of CourseGrade)
        '''<summary>
        '''There are no comments for Course in the schema.
        '''</summary>
        Public Property Course() As Global.System.Collections.ObjectModel.Collection(Of Course)
            Get
                Return Me._Course
            End Get
            Set
                If (Not (value) Is Nothing) Then
                    Me._Course = value
                End If
            End Set
        End Property
        Private _Course As Global.System.Collections.ObjectModel.Collection(Of Course) = New Global.System.Collections.ObjectModel.Collection(Of Course)
    End Class
End Namespace
