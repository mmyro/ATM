Public Class Depositos
    Private Sub BtnDepositar_Click(sender As Object, e As EventArgs) Handles BtnDepositar.Click
        clientes(FrmLogin.User, 0) += Val(TxtDepositar.Text)
        MsgBox("Depositado com sucesso")
        TxtDepositar.Text = ""
    End Sub

    Private Sub Depositos_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit
    End Sub

    Private Sub TxtDepositar_TextChanged(sender As Object, e As EventArgs) Handles TxtDepositar.TextChanged
        If TxtDepositar.Text <> "" Then
            BtnDepositar.Enabled = True
        End If
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        TxtDepositar.Text &= 0
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TxtDepositar.Text &= 1
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        TxtDepositar.Text &= 2
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        TxtDepositar.Text &= 3
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        TxtDepositar.Text &= 4
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        TxtDepositar.Text &= 5
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        TxtDepositar.Text &= 6
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        TxtDepositar.Text &= 7
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        TxtDepositar.Text &= 8
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        TxtDepositar.Text &= 9
    End Sub

    Private Sub Btn00_Click(sender As Object, e As EventArgs) Handles Btn00.Click
        TxtDepositar.Text &= 0
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If TxtDepositar.Text.Length > 0 Then
            TxtDepositar.Text = TxtDepositar.Text.Remove(TxtDepositar.Text.Length - 1, 1)
        End If
    End Sub
End Class