
Namespace LightSwitchApplication

    Public Class ParentDetail

        Private Sub Parent_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Parent)
        End Sub

        Private Sub Parent_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Parent)
        End Sub

        Private Sub ParentDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Parent)
        End Sub

    End Class

End Namespace