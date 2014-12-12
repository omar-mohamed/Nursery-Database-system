
Namespace LightSwitchApplication

    Public Class CreateNewSchedule

        Private Sub CreateNewSchedule_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.ScheduleProperty = New Schedule()
        End Sub

        Private Sub CreateNewSchedule_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.ScheduleProperty)
        End Sub

    End Class

End Namespace