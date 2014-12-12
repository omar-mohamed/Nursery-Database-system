
Namespace LightSwitchApplication

    Public Class CreateNewParent

        Private Sub CreateNewParent_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.ParentProperty = New Parent()
        End Sub

        Private Sub CreateNewParent_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.ParentProperty)
        End Sub

    End Class

End Namespace