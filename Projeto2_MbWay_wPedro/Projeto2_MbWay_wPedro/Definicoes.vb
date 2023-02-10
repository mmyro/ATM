Public Class Definicoes

    Dim ok As Boolean = False
    Sub confirmar()
        If TxtBoxOldPassword.Text.Length = 4 Then
            ok = True
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If clientes(FrmLogin.User, 1) = Val(TxtBoxOldPassword.Text) Then
            Form2.trocarPainel(password)
        End If
    End Sub

    Private Sub Definicoes_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 0
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 0
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 1
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 1
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 2
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 2
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 3
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 3
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 4
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 4
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 5
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 5
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 6
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 6
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 7
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 7
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 8
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 8
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 9
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 9
        End If
    End Sub

    Private Sub Btn00_Click(sender As Object, e As EventArgs) Handles Btn00.Click
        confirmar()
        If ok = False Then
            TxtBoxOldPassword.Text &= 0
        ElseIf ok = True And TxtBoxOldPassword.Text.Length < 4 Then
            TxtBoxOldPassword.Text &= 0
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If TxtBoxOldPassword.Text.Length > 0 And ok = False Then
            TxtBoxOldPassword.Text = TxtBoxOldPassword.Text.Remove(TxtBoxOldPassword.Text.Length - 1, 1)
        End If
        If TxtBoxOldPassword.Text = "" Then
            TxtBoxOldPassword.Text = ""
        End If
    End Sub
End Class