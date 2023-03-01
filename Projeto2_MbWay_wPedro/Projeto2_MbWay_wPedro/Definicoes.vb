Public Class Definicoes

    Dim ok As Boolean = False
    Sub confirmar()
        If TxtBoxOldPassword.Text.Length = 4 Then
            ok = True
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If clientes(User, 1) = Val(TxtBoxOldPassword.Text) Then
            Form2.trocarPainel(password)
        End If
    End Sub

    Private Sub Definicoes_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If TxtBoxOldPassword.Text.Length > 0 And ok = False Then
            TxtBoxOldPassword.Text = TxtBoxOldPassword.Text.Remove(TxtBoxOldPassword.Text.Length - 1, 1)
        End If
        If TxtBoxOldPassword.Text = "" Then
            TxtBoxOldPassword.Text = ""
        End If
    End Sub

    Private Sub Definicoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            TxtBoxOldPassword.Text &= sender.text
        End If
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If ok = False Then
            ok = True
        Else
            ok = False
        End If
    End Sub
End Class