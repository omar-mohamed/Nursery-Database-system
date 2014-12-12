
Namespace LightSwitchApplication

    Public Class CreateNewPayment

        Private Sub CreateNewPayment_InitializeDataWorkspace(ByVal saveChangesTo As Global.System.Collections.Generic.List(Of Global.Microsoft.LightSwitch.IDataService))
            ' Write your code here.
            Me.PaymentProperty = New Payment()
        End Sub

        Private Sub CreateNewPayment_Saved()
            ' Write your code here.
            Me.Close(False)
            Application.Current.ShowDefaultScreen(Me.PaymentProperty)
        End Sub

    End Class

End Namespace