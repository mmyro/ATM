Public Class password
    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        If Val(TxtBox1.Text) = Val(TxtBox2.Text) Then
            clientes(FrmLogin.User, 1) = Val(TxtBox1.Text)
            Form2.trocarPainel(Consultas)
        Else
            MsgBox("Palavra passe não coincide!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class