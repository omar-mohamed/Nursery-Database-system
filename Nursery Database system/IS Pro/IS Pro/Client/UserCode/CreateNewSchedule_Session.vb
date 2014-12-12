
Namespace LightSwitchApplication

    Public Class CreateNewSchedule_Session

        Private Sub CreateNewSchedule_Session_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.Schedule_SessionProperty = New Schedule_Session()
        End Sub

        Private Sub CreateNewSchedule_Session_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.Schedule_SessionProperty)
        End Sub

    End Class

End Namespace