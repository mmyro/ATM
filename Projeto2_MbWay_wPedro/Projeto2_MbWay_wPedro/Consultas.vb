Public Class Consultas
    Private Sub LblDinheiro_Click(sender As Object, e As EventArgs) Handles LblDinheiro.Click

        LblDinheiro.Text = "Dinheiro:" & vbCrLf & "----------" & vbCrLf & clientes(4, 0)

    End Sub
End Class