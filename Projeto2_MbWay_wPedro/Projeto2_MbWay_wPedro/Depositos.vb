Public Class Depositos
    Private Sub BtnDepositar_Click(sender As Object, e As EventArgs) Handles BtnDepositar.Click
        clientes(FrmLogin.User, 0) += Val(TxtDepositar.Text)
        MsgBox("Depositado com sucesso")
    End Sub

    Private Sub Depositos_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit
    End Sub
End Class