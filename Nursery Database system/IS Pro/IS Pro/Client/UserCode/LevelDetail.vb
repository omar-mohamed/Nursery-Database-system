
Namespace LightSwitchApplication

    Public Class LevelDetail

        Private Sub Level_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Level)
        End Sub

        Private Sub Level_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Level)
        End Sub

        Private Sub LevelDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Level)
        End Sub

    End Class

End Namespace