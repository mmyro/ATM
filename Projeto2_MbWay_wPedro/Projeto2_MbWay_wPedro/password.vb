Public Class password

    Dim ok As Boolean = False
    Sub confirmar()
        If TxtNew.Text.Length = 4 Then
            ok = True
        End If
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        MsgBox(TxtNew.Text)
        If Val(TxtNew.Text) = Val(TxtConfirm.Text) Then
            ok = False
            clientes(User, 1) = Val(TxtNew.Text)
            TxtConfirm.Clear()
            TxtNew.Clear()
            Definicoes.TxtBoxOldPassword.Clear()
            Form2.trocarPainel(Consultas)
            Consultas.LblDinheiro.Text = "Saldo atual:" & vbCrLf & "-------------" & vbCrLf & clientes(Val(FrmLogin.TxtBoxUsername.Text), 0) & " EUR"
        Else
            MsgBox("Palavra passe não coincide!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub password_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If TxtNew.Text.Length > 0 And ok = False Then
            TxtNew.Text = TxtNew.Text.Remove(TxtNew.Text.Length - 1, 1)
        End If
        If TxtConfirm.Text.Length > 0 And ok = True Then
            TxtConfirm.Text = TxtConfirm.Text.Remove(TxtConfirm.Text.Length - 1, 1)
        ElseIf TxtConfirm.Text.Length = 0 And ok = True Then
            ok = False
        End If
    End Sub

    Private Sub password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If ok = False And TxtNew.Text.Length < 4 Then
            TxtNew.Text &= sender.text
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= sender.text
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