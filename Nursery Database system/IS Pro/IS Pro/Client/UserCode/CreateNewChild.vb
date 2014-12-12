
Namespace LightSwitchApplication

    Public Class CreateNewChild

        Private Sub CreateNewChild_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.ChildProperty = New Child()
        End Sub

        Private Sub CreateNewChild_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.ChildProperty)
        End Sub

    End Class

End Namespace