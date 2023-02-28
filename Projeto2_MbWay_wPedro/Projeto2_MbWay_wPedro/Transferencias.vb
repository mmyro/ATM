Imports System.Security.Cryptography

Public Class Transferencias

    Dim ok As Boolean = False
    Private Sub Transferencias_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        If TxtBoxNmrConta.Text >= 0 And TxtBoxNmrConta.Text <= 6 Then
            If clientes(FrmLogin.User, 0) >= Val(TxtBoxMontante.Text) And TxtBoxNmrConta.Text <> "" And TxtBoxMontante.Text <> "" Then
                clientes(FrmLogin.User, 0) -= Val(TxtBoxMontante.Text)
                clientes(TxtBoxNmrConta.Text, 0) += Val(TxtBoxMontante.Text)
                MsgBox("Transferencia efetuada com sucesso")
                TxtBoxMontante.Text = ""
                TxtBoxNmrConta.Text = ""
            ElseIf TxtBoxNmrConta.Text = "" Or TxtBoxMontante.Text = "" Then
                MsgBox("Transferencia não foi efetuada com sucesso")
            Else
                MsgBox("Dinheiro Insuficiente")
            End If
        Else
            MsgBox("Numero da Conta Inválido")
            ok = True
            TxtBoxNmrConta.Text = ""
            TxtBoxMontante.Text = ""
        End If
    End Sub

    Private Sub Transferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Btn0.Click, AddressOf Teclas
        AddHandler Btn1.Click, AddressOf Teclas
        AddHandler Btn2.Click, AddressOf Teclas
        AddHandler Btn3.Click, AddressOf Teclas
        AddHandler Btn4.Click, AddressOf Teclas
        AddHandler Btn5.Click, AddressOf Teclas
        AddHandler Btn6.Click, AddressOf Teclas
        AddHandler Btn7.Click, AddressOf Teclas
        AddHandler Btn8.Click, AddressOf Teclas
        AddHandler Btn9.Click, AddressOf Teclas
    End Sub

    Private Sub Teclas(sender As Object, e As EventArgs)
        If ok = False Then
            TxtBoxNmrConta.Text &= sender.text
        Else
            TxtBoxMontante.Text &= sender.text
        End If

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If ok = False Then
            ok = True
        Else
            ok = False
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If TxtBoxNmrConta.Text.Length > 0 And ok = False Then
            TxtBoxNmrConta.Text = TxtBoxNmrConta.Text.Remove(TxtBoxNmrConta.Text.Length - 1, 1)
        End If
        If TxtBoxMontante.Text.Length > 0 And ok = True Then
            TxtBoxMontante.Text = TxtBoxMontante.Text.Remove(TxtBoxMontante.Text.Length - 1, 1)
        ElseIf TxtBoxMontante.Text.Length = 0 And ok = True Then
            ok = False
        End If
    End Sub

End Class