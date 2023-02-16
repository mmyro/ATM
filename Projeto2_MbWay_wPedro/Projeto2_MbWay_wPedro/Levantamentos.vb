Public Class Levantamentos
    Private Sub Levantamentos_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub
    Function Nota()
        Dim cash As Integer = clientes(FrmLogin.User, 0)
        Dim contar() As Integer = {0, 0, 0, 0, 0}
        Do
            If cash Mod 100 = 0 Or cash - 100 > 0 And notas(0) > 0 Then
                notas(0) -= 1
                contar(0) += 1
            ElseIf cash Mod 50 = 0 Or cash - 50 > 0 And notas(1) > 0 Then
                notas(1) -= 1
                contar(1) += 1
            ElseIf cash Mod 20 = 0 Or cash - 20 > 0 And notas(2) > 0 Then
                notas(2) -= 1
                contar(2) += 1
            ElseIf cash Mod 10 = 0 Or cash - 10 > 0 And notas(3) > 0 Then
                notas(3) -= 1
                contar(3) += 1
            ElseIf cash Mod 5 = 0 Or cash - 5 > 0 And notas(4) > 0 Then
                notas(4) -= 1
                contar(4) += 1
            End If
        Loop While cash <> 0
        Return MsgBox("Nota 100 x " & contar(0) & " Nota 50 x " & contar(1) & " Nota 20 x " & contar(2) & " Nota 10 x " & contar(3) & " Nota 5 x " & contar(4))
    End Function
    Private Sub Btn100euros_Click(sender As Object, e As EventArgs) Handles Btn100euros.Click
        If clientes(FrmLogin.User, 0) >= 100 Then
            clientes(FrmLogin.User, 0) -= 100

        End If
    End Sub

    Private Sub Btn50euros_Click(sender As Object, e As EventArgs) Handles Btn50euros.Click
        If clientes(FrmLogin.User, 0) >= 50 Then
            clientes(FrmLogin.User, 0) -= 50

        End If
    End Sub

    Private Sub Btn10euros_Click(sender As Object, e As EventArgs) Handles Btn10euros.Click
        If clientes(FrmLogin.User, 0) >= 10 Then
            clientes(FrmLogin.User, 0) -= 10
        End If
    End Sub

    Private Sub Btn20euros_Click(sender As Object, e As EventArgs) Handles Btn20euros.Click
        If clientes(FrmLogin.User, 0) >= 20 Then
            clientes(FrmLogin.User, 0) -= 20
        End If
    End Sub

    Private Sub Btn5euros_Click(sender As Object, e As EventArgs) Handles Btn5euros.Click
        If clientes(FrmLogin.User, 0) >= 5 Then
            clientes(FrmLogin.User, 0) -= 5
        End If
    End Sub

    Private Sub BtnLevantar_Click(sender As Object, e As EventArgs) Handles BtnLevantar.Click
        If clientes(FrmLogin.User, 0) >= Val(TxtBosDinheiro.Text) And Val(TxtBosDinheiro.Text) Mod 5 = 0 Then
            clientes(FrmLogin.User, 0) -= Val(TxtBosDinheiro.Text)
            Nota()
        End If
    End Sub
End Class