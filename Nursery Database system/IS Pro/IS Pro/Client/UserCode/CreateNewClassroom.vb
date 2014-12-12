
Namespace LightSwitchApplication

    Public Class CreateNewClassroom

        Private Sub CreateNewClassroom_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.ClassroomProperty = New Classroom()
        End Sub

        Private Sub CreateNewClassroom_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.ClassroomProperty)
        End Sub

    End Class

End Namespace