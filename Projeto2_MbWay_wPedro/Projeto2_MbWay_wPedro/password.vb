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
            clientes(FrmLogin.User, 1) = Val(TxtNew.Text)
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

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 0
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 0
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 5
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 5
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 1
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 1
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 3
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 3
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 6
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 6
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 8
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 8
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 4
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 4
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 9
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 9
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 7
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 7
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 2
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 2
        End If
    End Sub

    Private Sub Btn00_Click(sender As Object, e As EventArgs) Handles Btn00.Click
        confirmar()
        If ok = False Then
            TxtNew.Text &= 0
        ElseIf ok = True And TxtConfirm.Text.Length < 4 Then
            TxtConfirm.Text &= 0
        End If
    End Sub
End Class