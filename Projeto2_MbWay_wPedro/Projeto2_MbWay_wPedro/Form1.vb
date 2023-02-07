Public Class FrmLogin
    Dim ok As Boolean = False
    Dim Tentativas As Integer = 3
    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Dim User As Integer = Val(TxtBoxUsername.Text)
        IniciarClientes()
        If clientes(User, 1) = Val(TxtBoxPassword.Text) Then
            Me.Hide()
            Form2.Show()
        ElseIf Tentativas = 0 Then
            TxtBoxPassword.Clear()
            TxtBoxUsername.Clear()
            BtnEntrar.Enabled = False
            Tentativas = 3
            MsgBox("Erro apos as 3 tentataivas" & vbCrLf& & "Tente outra vez ou mais tarde!", MsgBoxStyle.Exclamation)
            ok = False
        Else
            MsgBox("Password Inválida!" & vbCrLf & Tentativas & " Restantes", MsgBoxStyle.Information)
            Tentativas -= 1
            TxtBoxPassword.Clear()
            BtnEntrar.Enabled = False
        End If

    End Sub

    Private Sub FrmLogin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= 0
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= 0
        End If
        If ok = True And TxtBoxPassword.TextLength = 4 Then
            BtnEntrar.Enabled = True
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= 1
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= 1
        End If
        If ok = True And TxtBoxPassword.TextLength = 4 Then
            BtnEntrar.Enabled = True
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= 2
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= 2
        End If
        If ok = True And TxtBoxPassword.TextLength = 4 Then
            BtnEntrar.Enabled = True
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= 3
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= 3
        End If
        If ok = True And TxtBoxPassword.TextLength = 4 Then
            BtnEntrar.Enabled = True
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= 4
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= 4
        End If
        If ok = True And TxtBoxPassword.TextLength = 4 Then
            BtnEntrar.Enabled = True
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= 5
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= 5
        End If
        If ok = True And TxtBoxPassword.TextLength = 4 Then
            BtnEntrar.Enabled = True
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= 6
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= 6
        End If
        If ok = True And TxtBoxPassword.TextLength = 4 Then
            BtnEntrar.Enabled = True
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= 7
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= 7
        End If
        If ok = True And TxtBoxPassword.TextLength = 4 Then
            BtnEntrar.Enabled = True
        End If

    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= 8
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= 8
        End If
        If ok = True And TxtBoxPassword.TextLength = 4 Then
            BtnEntrar.Enabled = True
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        If ok = False And TxtBoxUsername.Text.Length < 2 Then
            TxtBoxUsername.Text &= 9
        ElseIf ok = True And TxtBoxPassword.Text.Length < 4 Then
            TxtBoxPassword.Text &= 9
        End If
        If ok = True And TxtBoxPassword.TextLength = 4 Then
            BtnEntrar.Enabled = True
        End If
    End Sub

    Private Sub BntOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim User As Integer = Val(TxtBoxUsername.Text)
        If User >= 0 And User <= 6 Then
            ok = True

        Else
            MsgBox("Codigo Cliente inexistente!", MsgBoxStyle.Critical)
            TxtBoxUsername.Text = ""
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If TxtBoxPassword.Text.Length > 0 Then
            TxtBoxPassword.Text = TxtBoxPassword.Text.Remove(TxtBoxPassword.Text.Length - 1, 1)
        End If
        If TxtBoxPassword.Text Then
            TxtBoxPassword.Text = ""
        End If
    End Sub
End Class
