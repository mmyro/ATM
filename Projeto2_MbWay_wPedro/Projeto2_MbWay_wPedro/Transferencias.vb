Imports System.Security.Cryptography

Public Class Transferencias
    Private Sub Transferencias_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        If clientes(FrmLogin.User, 0) >= Val(TxtBoxMontante.Text) And TxtBoxNmeConta.Text <> "" And TxtBoxMontante.Text <> "" Then
            clientes(FrmLogin.User, 0) -= Val(TxtBoxMontante.Text)
            MsgBox("Transferencia efetuada com sucesso")
            TxtBoxMontante.Text = ""
            TxtBoxNmeConta.Text = ""
        ElseIf TxtBoxNmeConta.Text = "" Or TxtBoxMontante.Text = "" Then
            MsgBox("Transferencia não foi efetuada com sucesso")
        Else
            MsgBox("Dinheiro Insuficiente")

        End If
    End Sub
End Class