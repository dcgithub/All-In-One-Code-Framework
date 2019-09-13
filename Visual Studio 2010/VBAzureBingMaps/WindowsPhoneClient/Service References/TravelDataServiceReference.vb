'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On


'Original file name:
'Generation date: 2010/12/28 16:07:10
Namespace AzureBingMaps.DAL
    '''<summary>
    '''There are no comments for TravelDataServiceContext in the schema.
    '''</summary>
    Partial Public Class TravelDataServiceContext
        Inherits Global.System.Data.Services.Client.DataServiceContext
        '''<summary>
        '''Initialize a new TravelDataServiceContext object.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Sub New(ByVal serviceRoot As Global.System.Uri)
            MyBase.New(serviceRoot)
            Me.OnContextCreated()
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        '''<summary>
        '''There are no comments for Travels in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Sub AddToTravels(ByVal travel As Travel)
            MyBase.AddObject("Travels", travel)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for AzureBingMaps.DAL.Travel in the schema.
    '''</summary>
    '''<KeyProperties>
    '''PartitionKey
    '''RowKey
    '''</KeyProperties>
    <Global.System.Data.Services.Common.EntitySetAttribute("Travels"), _
     Global.System.Data.Services.Common.DataServiceKeyAttribute("PartitionKey", "RowKey")> _
    Partial Public Class Travel
        Implements Global.System.ComponentModel.INotifyPropertyChanged
        '''<summary>
        '''Create a new Travel object.
        '''</summary>
        '''<param name="partitionKey">Initial value of PartitionKey.</param>
        '''<param name="rowKey">Initial value of RowKey.</param>
        '''<param name="time">Initial value of Time.</param>
        '''<param name="latitude">Initial value of Latitude.</param>
        '''<param name="longitude">Initial value of Longitude.</param>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Shared Function CreateTravel(ByVal partitionKey As String, ByVal rowKey As Global.System.Guid, ByVal time As Date, ByVal latitude As Double, ByVal longitude As Double) As Travel
            Dim travel As Travel = New Travel()
            travel.PartitionKey = partitionKey
            travel.RowKey = rowKey
            travel.Time = time
            travel.Latitude = latitude
            travel.Longitude = longitude
            Return travel
        End Function
        '''<summary>
        '''There are no comments for Property PartitionKey in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property PartitionKey() As String
            Get
                Return Me._PartitionKey
            End Get
            Set(ByVal value As String)
                Me.OnPartitionKeyChanging(Value)
                Me._PartitionKey = Value
                Me.OnPartitionKeyChanged()
                Me.OnPropertyChanged("PartitionKey")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _PartitionKey As String
        Partial Private Sub OnPartitionKeyChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnPartitionKeyChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property RowKey in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property RowKey() As Global.System.Guid
            Get
                Return Me._RowKey
            End Get
            Set(ByVal value As Global.System.Guid)
                Me.OnRowKeyChanging(Value)
                Me._RowKey = Value
                Me.OnRowKeyChanged()
                Me.OnPropertyChanged("RowKey")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _RowKey As Global.System.Guid
        Partial Private Sub OnRowKeyChanging(ByVal value As Global.System.Guid)
        End Sub
        Partial Private Sub OnRowKeyChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Place in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property Place() As String
            Get
                Return Me._Place
            End Get
            Set(ByVal value As String)
                Me.OnPlaceChanging(Value)
                Me._Place = Value
                Me.OnPlaceChanged()
                Me.OnPropertyChanged("Place")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _Place As String
        Partial Private Sub OnPlaceChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnPlaceChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Time in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property Time() As Date
            Get
                Return Me._Time
            End Get
            Set(ByVal value As Date)
                Me.OnTimeChanging(Value)
                Me._Time = Value
                Me.OnTimeChanged()
                Me.OnPropertyChanged("Time")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _Time As Date
        Partial Private Sub OnTimeChanging(ByVal value As Date)
        End Sub
        Partial Private Sub OnTimeChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property GeoLocationText in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property GeoLocationText() As String
            Get
                Return Me._GeoLocationText
            End Get
            Set(ByVal value As String)
                Me.OnGeoLocationTextChanging(Value)
                Me._GeoLocationText = Value
                Me.OnGeoLocationTextChanged()
                Me.OnPropertyChanged("GeoLocationText")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _GeoLocationText As String
        Partial Private Sub OnGeoLocationTextChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnGeoLocationTextChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Latitude in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property Latitude() As Double
            Get
                Return Me._Latitude
            End Get
            Set(ByVal value As Double)
                Me.OnLatitudeChanging(Value)
                Me._Latitude = Value
                Me.OnLatitudeChanged()
                Me.OnPropertyChanged("Latitude")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _Latitude As Double
        Partial Private Sub OnLatitudeChanging(ByVal value As Double)
        End Sub
        Partial Private Sub OnLatitudeChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Longitude in the schema.
        '''</summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property Longitude() As Double
            Get
                Return Me._Longitude
            End Get
            Set(ByVal value As Double)
                Me.OnLongitudeChanging(Value)
                Me._Longitude = Value
                Me.OnLongitudeChanged()
                Me.OnPropertyChanged("Longitude")
            End Set
        End Property
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _Longitude As Double
        Partial Private Sub OnLongitudeChanging(ByVal value As Double)
        End Sub
        Partial Private Sub OnLongitudeChanged()
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements Global.System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
            If (Not (Me.PropertyChangedEvent) Is Nothing) Then
                RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
            End If
        End Sub
    End Class
End Namespace
