
Namespace LightSwitchApplication

    Public Class PaymentDetail

        Private Sub Payment_Loaded(succeeded As Boolean)
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Payment)
        End Sub

        Private Sub Payment_Changed()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Payment)
        End Sub

        Private Sub PaymentDetail_Saved()
            ' Write your code here.
            Me.SetDisplayNameFromEntity(Me.Payment)
        End Sub

    End Class

End Namespace