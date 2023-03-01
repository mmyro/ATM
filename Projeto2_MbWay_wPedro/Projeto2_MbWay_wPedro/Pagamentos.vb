Public Class Pagamentos
    Dim ok As Boolean = False
    Private Sub Pagamentos_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If TxtBoxMontante.Text.Length > 0 Then
            TxtBoxMontante.Text = TxtBoxMontante.Text.Remove(TxtBoxMontante.Text.Length - 1, 1)
        ElseIf TxtBoxReferencia.Text.Length > 0 Then
            TxtBoxReferencia.Text = TxtBoxReferencia.Text.Remove(TxtBoxReferencia.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        If clientes(FrmLogin.User, 0) >= Val(TxtBoxMontante.Text) And TxtBoxReferencia.Text <> "" And TxtBoxMontante.Text <> "" Then
            clientes(FrmLogin.User, 0) -= Val(TxtBoxMontante.Text)
            MsgBox("Transferencia efetuada com sucesso")
            TxtBoxMontante.Text = ""
            TxtBoxReferencia.Text = ""
        ElseIf TxtBoxReferencia.Text = "" Or TxtBoxMontante.Text = "" Then
            MsgBox("Transferencia não foi efetuada com sucesso")
        Else
            MsgBox("Dinheiro Insuficiente")
        End If
    End Sub

    Private Sub Pagamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            TxtBoxReferencia.Text &= sender.text
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

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click

    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click

    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click

    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click

    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click

    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click

    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click

    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click

    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click

    End Sub

    Private Sub LblMontante_Click(sender As Object, e As EventArgs) Handles LblMontante.Click

    End Sub

    Private Sub LblReferências_Click(sender As Object, e As EventArgs) Handles LblReferências.Click

    End Sub

    Private Sub TxtBoxMontante_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxMontante.TextChanged

    End Sub

    Private Sub TxtBoxReferencia_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxReferencia.TextChanged

    End Sub
End Class