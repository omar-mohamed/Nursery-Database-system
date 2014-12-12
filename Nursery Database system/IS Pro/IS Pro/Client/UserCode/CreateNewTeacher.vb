
Namespace LightSwitchApplication

    Public Class CreateNewTeacher

        Private Sub CreateNewTeacher_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.TeacherProperty = New Teacher()
        End Sub

        Private Sub CreateNewTeacher_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.TeacherProperty)
        End Sub

    End Class

End Namespace