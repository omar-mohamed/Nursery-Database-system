
Namespace LightSwitchApplication

    Public Class CreateNewSession

        Private Sub CreateNewSession_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.SessionProperty = New Session()
        End Sub

        Private Sub CreateNewSession_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.SessionProperty)
        End Sub

    End Class

End Namespace