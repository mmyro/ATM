Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub Admin_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Unblock()
    End Sub

    Private Sub BtnDesbloqCartoes_Click(sender As Object, e As EventArgs) Handles BtnDesbloqCartoes.Click
        bloqueio(LstBoxBlock.SelectedItem) = 1
        clientes(LstBoxBlock.SelectedItem, 1) = 1111
        Unblock()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Hide()
        FrmLogin.Show()
    End Sub
End Class