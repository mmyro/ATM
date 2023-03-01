Public Class Depositos

    Dim ok As Boolean = False
    Private Sub BtnDepositar_Click(sender As Object, e As EventArgs) Handles BtnDepositar.Click
        clientes(FrmLogin.User, 0) += Val(TxtDepositar.Text)
        MsgBox("Depositado com sucesso")
        TxtDepositar.Text = ""
    End Sub

    Private Sub Depositos_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    'Private Sub TxtDepositar_TextChanged(sender As Object, e As EventArgs) Handles TxtDepositar.TextChanged
    'If TxtDepositar.Text <> "" Then
    ' BtnDepositar.Enabled = True
    '   End If
    ' End Sub

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
        If ok = False Then
            TxtDepositar.Text &= sender.text
        End If
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        If TxtDepositar.Text.Length > 0 Then
            TxtDepositar.Text = TxtDepositar.Text.Remove(TxtDepositar.Text.Length - 1, 1)
        End If
    End Sub
End Class