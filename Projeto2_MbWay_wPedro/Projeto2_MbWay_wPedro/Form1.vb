Public Class FrmLogin
    Dim ok As Boolean = False

    Private Sub FrmLogin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub Teclas(sender As Object, e As EventArgs)
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= sender.text
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= sender.text
        End If
    End Sub

    Private Sub BntOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        User = Val(TxtBoxUsername.Text)
        If ok = False Then
            If User >= 0 And User <= 6 Or User = 99 Then
                ok = True
            Else
                MsgBox("Codigo Cliente inexistente!", MsgBoxStyle.Critical)
                TxtBoxUsername.Text = ""
            End If
        ElseIf ok = True Then
            If User = 99 And TxtBoxPassword.Text = "0000" Then
                TxtBoxPassword.Clear()
                TxtBoxUsername.Clear()
                ok = False
                Me.Hide()
                Admin.Show()
                Admin.PicBoxCartao.Image = My.Resources.Admin
            ElseIf clientes(User, 1) = Val(TxtBoxPassword.Text) And bloqueio(User) < 3 Then
                TxtBoxPassword.Clear()
                TxtBoxUsername.Clear()
                ok = False
                Me.Hide()
                Form2.Show()
                Form2.PicBoxCartao.Image = My.Resources.Clientes
            ElseIf bloqueio(User) = 3 Then
                ok = False
                TxtBoxUsername.Clear()
                TxtBoxPassword.Clear()
                clientes(User, 1) = 11111
                MsgBox("Erro apos as 3 tentataivas" & vbCrLf& & "Tente outra vez ou mais tarde!", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Password Inválida!" & vbCrLf & 3 - bloqueio(User) & " Restantes", MsgBoxStyle.Information)
                bloqueio(User) += 1
                TxtBoxPassword.Clear()
            End If
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If TxtBoxUsername.Text.Length > 0 And ok = False Then
            TxtBoxUsername.Text = TxtBoxUsername.Text.Remove(TxtBoxUsername.Text.Length - 1, 1)
        End If
        If TxtBoxPassword.Text.Length > 0 And ok = True Then
            TxtBoxPassword.Text = TxtBoxPassword.Text.Remove(TxtBoxPassword.Text.Length - 1, 1)
        ElseIf TxtBoxPassword.Text.Length = 0 And ok = True Then
            ok = False
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Unblock()
        Block()
        IniciarClientes()
    End Sub
End Class
