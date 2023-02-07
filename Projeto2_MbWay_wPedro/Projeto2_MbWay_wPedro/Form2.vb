Public Class Form2

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Sub trocarPainel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub BtnConsultas_Click(sender As Object, e As EventArgs) Handles BtnConsultas.Click
        trocarPainel(Consultas)
    End Sub

    Private Sub BtnDepositos_Click(sender As Object, e As EventArgs) Handles BtnDepositos.Click
        trocarPainel(Depositos)
    End Sub

    Private Sub BtnPagamentos_Click(sender As Object, e As EventArgs) Handles BtnPagamentos.Click
        trocarPainel(Pagamentos)
    End Sub

    Private Sub BtnTransferencias_Click(sender As Object, e As EventArgs) Handles BtnTransferencias.Click
        trocarPainel(Transferencias)
    End Sub

    Private Sub BtnLevantamentos_Click(sender As Object, e As EventArgs) Handles BtnLevantamentos.Click
        trocarPainel(Levantamentos)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        trocarPainel(Definicoes)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class