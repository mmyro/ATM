Public Class Definicoes
    Private Sub Definicoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If clientes(FrmLogin.User, 1) = Val(TxtBoxOldPassword.Text) Then
            Form2.trocarPainel(password)
        End If
    End Sub
End Class