
Namespace LightSwitchApplication

    Public Class CreateNewLevel

        Private Sub CreateNewLevel_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.LevelProperty = New Level()
        End Sub

        Private Sub CreateNewLevel_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.LevelProperty)
        End Sub

    End Class

End Namespace