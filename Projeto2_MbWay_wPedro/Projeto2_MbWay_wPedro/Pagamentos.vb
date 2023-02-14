Public Class Pagamentos
    Private Sub Pagamentos_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If TxtBoxEntidade.Text.Length > 0 Then
            TxtBoxEntidade.Text = TxtBoxEntidade.Text.Remove(TxtBoxEntidade.Text.Length - 1, 1)
        ElseIf TxtBoxMontante.Text.Length > 0 Then
            TxtBoxMontante.Text = TxtBoxMontante.Text.Remove(TxtBoxMontante.Text.Length - 1, 1)
        ElseIf TxtBoxReferencia.Text.Length > 0 Then
            TxtBoxReferencia.Text = TxtBoxReferencia.Text.Remove(TxtBoxReferencia.Text.Length - 1, 1)
        End If
    End Sub
End Class