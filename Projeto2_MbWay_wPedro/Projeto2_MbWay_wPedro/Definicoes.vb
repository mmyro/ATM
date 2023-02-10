Public Class Definicoes


    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If clientes(FrmLogin.User, 1) = Val(TxtBoxOldPassword.Text) Then
            Form2.trocarPainel(password)
        End If
    End Sub

    Private Sub Definicoes_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub
End Class