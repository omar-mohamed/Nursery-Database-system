﻿
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports __Schedule_Session = LightSwitchApplication.Schedule_Session

Namespace LightSwitchApplication

    #Region "Entities"
    
    ''' <summary>
    ''' No Modeled Description Available
    ''' </summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
    Public NotInheritable Partial Class Schedule_Session
        Inherits Global.Microsoft.LightSwitch.Framework.Base.EntityObject(Of __Schedule_Session, __Schedule_Session.DetailsClass)
    
        #Region "Constructors"
    
        ''' <summary>
        ''' Initializes a new instance of the Schedule_Session entity.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New()
            Me.New(Nothing)
        End Sub
    
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Sub New(entitySet As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Schedule_Session))
            MyBase.New(entitySet)
            
            __Schedule_Session.DetailsClass.Initialize(Me)
        End Sub
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Schedule_Session_Created()
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Schedule_Session_AllowSaveWithErrors(ByRef result As Boolean)
        End Sub
    
        #End Region
    
        #Region "Private Properties"
        
        ''' <summary>
        ''' Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property Application As Global.Microsoft.LightSwitch.IApplication(Of Global.LightSwitchApplication.DataWorkspace)
            Get
                Return Global.LightSwitchApplication.Application.Current
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Private ReadOnly Property DataWorkspace As Global.LightSwitchApplication.DataWorkspace
            Get
                Return DirectCast(Me.Details.EntitySet.Details.DataService.Details.DataWorkspace, Global.LightSwitchApplication.DataWorkspace)
            End Get
        End Property
        
        #End Region
    
        #Region "Public Properties"
    
        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property ID_Session As Integer
            Get
                Return __Schedule_Session.DetailsClass.GetValue(Me, __Schedule_Session.DetailsClass.PropertySetProperties.ID_Session)
            End Get
            Set
                __Schedule_Session.DetailsClass.SetValue(Me, __Schedule_Session.DetailsClass.PropertySetProperties.ID_Session, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ID_Session_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ID_Session_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ID_Session_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property ID_Schedule As Integer
            Get
                Return __Schedule_Session.DetailsClass.GetValue(Me, __Schedule_Session.DetailsClass.PropertySetProperties.ID_Schedule)
            End Get
            Set
                __Schedule_Session.DetailsClass.SetValue(Me, __Schedule_Session.DetailsClass.PropertySetProperties.ID_Schedule, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ID_Schedule_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ID_Schedule_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub ID_Schedule_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Day As String
            Get
                Return __Schedule_Session.DetailsClass.GetValue(Me, __Schedule_Session.DetailsClass.PropertySetProperties.Day)
            End Get
            Set
                __Schedule_Session.DetailsClass.SetValue(Me, __Schedule_Session.DetailsClass.PropertySetProperties.Day, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Day_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Day_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Day_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Schedule As Global.LightSwitchApplication.Schedule
            Get
                Return __Schedule_Session.DetailsClass.GetValue(Me, __Schedule_Session.DetailsClass.PropertySetProperties.Schedule)
            End Get
            Set
                __Schedule_Session.DetailsClass.SetValue(Me, __Schedule_Session.DetailsClass.PropertySetProperties.Schedule, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Schedule_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Schedule_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Schedule_Changed()
        End Sub

        ''' <summary>
        ''' No Modeled Description Available
        ''' </summary>
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public Property Session As Global.LightSwitchApplication.Session
            Get
                Return __Schedule_Session.DetailsClass.GetValue(Me, __Schedule_Session.DetailsClass.PropertySetProperties.Session)
            End Get
            Set
                __Schedule_Session.DetailsClass.SetValue(Me, __Schedule_Session.DetailsClass.PropertySetProperties.Session, Value)
            End Set
        End Property
        
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Session_IsReadOnly(ByRef result As Boolean)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Session_Validate(ByVal results As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
        End Sub
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Private Partial Sub Session_Changed()
        End Sub

        #End Region
    
        #Region "Details Class"
    
        <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
        Public NotInheritable Class DetailsClass
            Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of _
                __Schedule_Session, _
                __Schedule_Session.DetailsClass, _
                __Schedule_Session.DetailsClass.IImplementation, _
                __Schedule_Session.DetailsClass.PropertySet, _
                Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Schedule_Session, __Schedule_Session.DetailsClass), _
                Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Schedule_Session, __Schedule_Session.DetailsClass))
    
            Shared Sub New()
                Dim initializeEntry = __Schedule_Session.DetailsClass.PropertySetProperties.ID_Session
            End Sub
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private Shared ReadOnly __Schedule_SessionEntry As Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Schedule_Session, __Schedule_Session.DetailsClass).Entry = _
                New Global.Microsoft.LightSwitch.Details.Framework.Base.EntityDetails(Of __Schedule_Session, __Schedule_Session.DetailsClass).Entry( _
                    AddressOf __Schedule_Session.DetailsClass.__Schedule_Session_CreateNew, _
                    AddressOf __Schedule_Session.DetailsClass.__Schedule_Session_Created, _
                    AddressOf __Schedule_Session.DetailsClass.__Schedule_Session_AllowSaveWithErrors)
            Private Shared Function __Schedule_Session_CreateNew(es As Global.Microsoft.LightSwitch.Framework.EntitySet(Of __Schedule_Session)) As __Schedule_Session
                Return New __Schedule_Session(es)
            End Function
            Private Shared Sub __Schedule_Session_Created(e As __Schedule_Session)
                e.Schedule_Session_Created()
            End Sub
            Private Shared Function __Schedule_Session_AllowSaveWithErrors(e As __Schedule_Session) As Boolean
                Dim result As Boolean = False
                e.Schedule_Session_AllowSaveWithErrors(result)
                Return result
            End Function
    
            Public Sub New()
                MyBase.New()
            End Sub
    
            Public ReadOnly Shadows Property Commands As Global.Microsoft.LightSwitch.Details.Framework.EntityCommandSet(Of __Schedule_Session, __Schedule_Session.DetailsClass)
                Get
                    Return MyBase.Commands
                End Get
            End Property
    
            Public ReadOnly Shadows Property Methods As Global.Microsoft.LightSwitch.Details.Framework.EntityMethodSet(Of __Schedule_Session, __Schedule_Session.DetailsClass)
                Get
                    Return MyBase.Methods
                End Get
            End Property
    
            Public ReadOnly Shadows Property Properties As __Schedule_Session.DetailsClass.PropertySet
                Get
                    Return MyBase.Properties
                End Get
            End Property
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Public NotInheritable Class PropertySet
                Inherits Global.Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet(Of __Schedule_Session, __Schedule_Session.DetailsClass)
    
                Public Sub New()
                    MyBase.New()
                End Sub
    
                Public ReadOnly Property ID_Session As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Schedule_Session.DetailsClass.PropertySetProperties.ID_Session),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property ID_Schedule As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Schedule_Session.DetailsClass.PropertySetProperties.ID_Schedule),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer))
                    End Get
                End Property
                
                Public ReadOnly Property Day As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, String)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Schedule_Session.DetailsClass.PropertySetProperties.Day),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, String))
                    End Get
                End Property
                
                Public ReadOnly Property Schedule As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Schedule)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Schedule_Session.DetailsClass.PropertySetProperties.Schedule),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Schedule))
                    End Get
                End Property
                
                Public ReadOnly Property Session As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Session)
                    Get
                        Return TryCast(
                            MyBase.GetItem(__Schedule_Session.DetailsClass.PropertySetProperties.Session),
                            Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Session))
                    End Get
                End Property
                
            End Class
    
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")> _
            Public Interface IImplementation
                Inherits Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
                Shadows Property ID_Session As Integer
                Shadows Property ID_Schedule As Integer
                Shadows Property Day As String
                Shadows Property Schedule As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                Shadows Property Session As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
    
            End Interface
    
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")> _
            <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
            Friend Class PropertySetProperties
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly ID_Session As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer).Entry( _
                        "ID_Session", _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Session_Stub, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Session_ComputeIsReadOnly, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Session_Validate, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Session_GetImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Session_SetImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Session_OnValueChanged)
                Private Shared Sub _ID_Session_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Schedule_Session.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer).Data), d As __Schedule_Session.DetailsClass, sf As Object)
                    c(d, d._ID_Session, sf)
                End Sub
                Private Shared Function _ID_Session_ComputeIsReadOnly(e As __Schedule_Session) As Boolean
                    Dim result As Boolean = False
                    e.ID_Session_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _ID_Session_Validate(e As __Schedule_Session, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.ID_Session_Validate(r)
                End Sub
                Private Shared Function _ID_Session_GetImplementationValue(d As __Schedule_Session.DetailsClass) As Integer
                    Return d.ImplementationEntity.ID_Session
                End Function
                Private Shared Sub _ID_Session_SetImplementationValue(d As __Schedule_Session.DetailsClass, v As Integer)
                    d.ImplementationEntity.ID_Session = v
                End Sub
                Private Shared Sub _ID_Session_OnValueChanged(e As __Schedule_Session)
                    e.ID_Session_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly ID_Schedule As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer).Entry( _
                        "ID_Schedule", _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Schedule_Stub, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Schedule_ComputeIsReadOnly, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Schedule_Validate, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Schedule_GetImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Schedule_SetImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._ID_Schedule_OnValueChanged)
                Private Shared Sub _ID_Schedule_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Schedule_Session.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer).Data), d As __Schedule_Session.DetailsClass, sf As Object)
                    c(d, d._ID_Schedule, sf)
                End Sub
                Private Shared Function _ID_Schedule_ComputeIsReadOnly(e As __Schedule_Session) As Boolean
                    Dim result As Boolean = False
                    e.ID_Schedule_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _ID_Schedule_Validate(e As __Schedule_Session, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.ID_Schedule_Validate(r)
                End Sub
                Private Shared Function _ID_Schedule_GetImplementationValue(d As __Schedule_Session.DetailsClass) As Integer
                    Return d.ImplementationEntity.ID_Schedule
                End Function
                Private Shared Sub _ID_Schedule_SetImplementationValue(d As __Schedule_Session.DetailsClass, v As Integer)
                    d.ImplementationEntity.ID_Schedule = v
                End Sub
                Private Shared Sub _ID_Schedule_OnValueChanged(e As __Schedule_Session)
                    e.ID_Schedule_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Day As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, String).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, String).Entry( _
                        "Day", _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Day_Stub, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Day_ComputeIsReadOnly, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Day_Validate, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Day_GetImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Day_SetImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Day_OnValueChanged)
                Private Shared Sub _Day_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Schedule_Session.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, String).Data), d As __Schedule_Session.DetailsClass, sf As Object)
                    c(d, d._Day, sf)
                End Sub
                Private Shared Function _Day_ComputeIsReadOnly(e As __Schedule_Session) As Boolean
                    Dim result As Boolean = False
                    e.Day_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Day_Validate(e As __Schedule_Session, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Day_Validate(r)
                End Sub
                Private Shared Function _Day_GetImplementationValue(d As __Schedule_Session.DetailsClass) As String
                    Return d.ImplementationEntity.Day
                End Function
                Private Shared Sub _Day_SetImplementationValue(d As __Schedule_Session.DetailsClass, v As String)
                    d.ImplementationEntity.Day = v
                End Sub
                Private Shared Sub _Day_OnValueChanged(e As __Schedule_Session)
                    e.Day_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Schedule As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Schedule).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Schedule).Entry( _
                        "Schedule", _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Schedule_Stub, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Schedule_ComputeIsReadOnly, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Schedule_Validate, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Schedule_GetCoreImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Schedule_GetImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Schedule_SetImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Schedule_Refresh, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Schedule_OnValueChanged)
                Private Shared Sub _Schedule_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Schedule_Session.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Schedule).Data), d As __Schedule_Session.DetailsClass, sf As Object)
                    c(d, d._Schedule, sf)
                End Sub
                Private Shared Function _Schedule_ComputeIsReadOnly(e As __Schedule_Session) As Boolean
                    Dim result As Boolean = False
                    e.Schedule_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Schedule_Validate(e As __Schedule_Session, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Schedule_Validate(r)
                End Sub
                Private Shared Function _Schedule_GetCoreImplementationValue(d as __Schedule_Session.DetailsClass) As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                    Return d.ImplementationEntity.Schedule
                End Function
                Private Shared Function _Schedule_GetImplementationValue(d as __Schedule_Session.DetailsClass) As Global.LightSwitchApplication.Schedule
                    Return d.GetImplementationValue(Of Global.LightSwitchApplication.Schedule, Global.LightSwitchApplication.Schedule.DetailsClass)(__Schedule_Session.DetailsClass.PropertySetProperties.Schedule, d._Schedule)
                End Function
                Private Shared Sub _Schedule_SetImplementationValue(d As __Schedule_Session.DetailsClass, v As Global.LightSwitchApplication.Schedule)
                    d.SetImplementationValue(__Schedule_Session.DetailsClass.PropertySetProperties.Schedule, d._Schedule, Sub(i, ev) i.Schedule = ev, v)
                End Sub
                Private Shared Sub _Schedule_Refresh(d As __Schedule_Session.DetailsClass)
                    d.RefreshNavigationProperty(__Schedule_Session.DetailsClass.PropertySetProperties.Schedule, d._Schedule)
                End Sub
                Private Shared Sub _Schedule_OnValueChanged(e As __Schedule_Session)
                    e.Schedule_Changed()
                End Sub
    
                <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
                Public Shared ReadOnly Session As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Session).Entry = _
                    New Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Session).Entry( _
                        "Session", _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Session_Stub, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Session_ComputeIsReadOnly, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Session_Validate, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Session_GetCoreImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Session_GetImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Session_SetImplementationValue, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Session_Refresh, _
                        AddressOf __Schedule_Session.DetailsClass.PropertySetProperties._Session_OnValueChanged)
                Private Shared Sub _Session_Stub(c As Global.Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback(Of __Schedule_Session.DetailsClass, Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Session).Data), d As __Schedule_Session.DetailsClass, sf As Object)
                    c(d, d._Session, sf)
                End Sub
                Private Shared Function _Session_ComputeIsReadOnly(e As __Schedule_Session) As Boolean
                    Dim result As Boolean = False
                    e.Session_IsReadOnly(result)
                    Return result
                End Function
                Private Shared Sub _Session_Validate(e As __Schedule_Session, r As Global.Microsoft.LightSwitch.EntityValidationResultsBuilder)
                    e.Session_Validate(r)
                End Sub
                Private Shared Function _Session_GetCoreImplementationValue(d as __Schedule_Session.DetailsClass) As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
                    Return d.ImplementationEntity.Session
                End Function
                Private Shared Function _Session_GetImplementationValue(d as __Schedule_Session.DetailsClass) As Global.LightSwitchApplication.Session
                    Return d.GetImplementationValue(Of Global.LightSwitchApplication.Session, Global.LightSwitchApplication.Session.DetailsClass)(__Schedule_Session.DetailsClass.PropertySetProperties.Session, d._Session)
                End Function
                Private Shared Sub _Session_SetImplementationValue(d As __Schedule_Session.DetailsClass, v As Global.LightSwitchApplication.Session)
                    d.SetImplementationValue(__Schedule_Session.DetailsClass.PropertySetProperties.Session, d._Session, Sub(i, ev) i.Session = ev, v)
                End Sub
                Private Shared Sub _Session_Refresh(d As __Schedule_Session.DetailsClass)
                    d.RefreshNavigationProperty(__Schedule_Session.DetailsClass.PropertySetProperties.Session, d._Session)
                End Sub
                Private Shared Sub _Session_OnValueChanged(e As __Schedule_Session)
                    e.Session_Changed()
                End Sub
    
            End Class
    
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _ID_Session As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _ID_Schedule As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Integer).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Day As Global.Microsoft.LightSwitch.Details.Framework.EntityStorageProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, String).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Schedule As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Schedule).Data
            
            <Global.System.Diagnostics.DebuggerBrowsable(Global.System.Diagnostics.DebuggerBrowsableState.Never)> _
            Private _Session As Global.Microsoft.LightSwitch.Details.Framework.EntityReferenceProperty(Of __Schedule_Session, __Schedule_Session.DetailsClass, Global.LightSwitchApplication.Session).Data
            
        End Class
    
        #End Region
    
    End Class
    
    #End Region
End Namespace
