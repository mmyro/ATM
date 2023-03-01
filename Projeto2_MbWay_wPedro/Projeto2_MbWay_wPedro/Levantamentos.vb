Public Class Levantamentos
    Private Sub Levantamentos_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub
    Sub Nota(cash As Integer, Contar() As Integer)
        Dim aux As Integer
        aux = notas(0) * 100 + notas(1) * 50 + notas(2) * 20 + notas(3) * 10 + notas(4) * 5
        If cash > 250 Then
            MsgBox("A caixa so permite retirar ate 250 EUR")
            Levantar = True
        ElseIf cash <= aux Then
            Do While cash <> 0
                If (cash - 100) >= 0 And notas(0) > 0 Then
                    cash -= 100
                    notas(0) -= 1
                    Contar(0) += 1
                ElseIf (cash - 50) >= 0 And notas(1) > 0 Then
                    cash -= 50
                    notas(1) -= 1
                    Contar(1) += 1
                ElseIf (cash - 20) >= 0 And notas(2) > 0 Then
                    cash -= 20
                    notas(2) -= 1
                    Contar(2) += 1
                ElseIf (cash - 10) >= 0 And notas(3) > 0 Then
                    cash -= 10
                    notas(3) -= 1
                    Contar(3) += 1
                ElseIf (cash - 5) >= 0 And notas(4) > 0 Then
                    cash -= 5
                    notas(4) -= 1
                    Contar(4) += 1
                End If
            Loop
        Else
            MsgBox("Notas insuficientes")
            Levantar = True
        End If
    End Sub
    Private Sub Btn100euros_Click(sender As Object, e As EventArgs) Handles Btn100euros.Click
        Dim contar() As Integer = {0, 0, 0, 0, 0}
        Nota(100, contar)
        If clientes(User, 0) >= 100 And Levantar = False Then
            clientes(User, 0) -= 100
            MsgBox("Nota 100 x " & contar(0) & " Nota 50 x " & contar(1) & " Nota 20 x " & contar(2) & " Nota 10 x " & contar(3) & " Nota 5 x " & contar(4))
        ElseIf clientes(User, 0) < 100 Then
            MsgBox("Dinheiro Insuficiente")
        End If
        Levantar = False
    End Sub

    Private Sub Btn50euros_Click(sender As Object, e As EventArgs) Handles Btn50euros.Click
        Dim contar() As Integer = {0, 0, 0, 0, 0}
        Nota(50, contar)
        If clientes(User, 0) >= 50 And Levantar = False Then
            clientes(User, 0) -= 50
            MsgBox(" Nota 50 x " & contar(1) & " Nota 20 x " & contar(2) & " Nota 10 x " & contar(3) & " Nota 5 x " & contar(4))
        ElseIf clientes(User, 0) < 50 Then
            MsgBox("Dinheiro Insuficiente")
        End If
        Levantar = False
    End Sub

    Private Sub Btn10euros_Click(sender As Object, e As EventArgs) Handles Btn10euros.Click
        Dim contar() As Integer = {0, 0, 0, 0, 0}
        Nota(10, contar)
        If clientes(User, 0) >= 10 And Levantar = False Then
            clientes(User, 0) -= 10
            MsgBox(" Nota 10 x " & contar(3) & " Nota 5 x " & contar(4))
        ElseIf clientes(User, 0) < 10 Then
            MsgBox("Dinheiro Insuficiente")
        End If
        Levantar = False
    End Sub

    Private Sub Btn20euros_Click(sender As Object, e As EventArgs) Handles Btn20euros.Click
        Dim contar() As Integer = {0, 0, 0, 0, 0}
        Nota(20, contar)
        If clientes(User, 0) >= 20 And Levantar = False Then
            clientes(User, 0) -= 20
            MsgBox("Nota 20 x " & contar(2) & " Nota 10 x " & contar(3) & " Nota 5 x " & contar(4))
        ElseIf clientes(User, 0) < 20 Then
            MsgBox("Dinheiro Insuficiente")
        End If
        Levantar = False
    End Sub

    Private Sub Btn5euros_Click(sender As Object, e As EventArgs) Handles Btn5euros.Click
        Dim contar() As Integer = {0, 0, 0, 0, 0}
        Nota(5, contar)
        If clientes(User, 0) >= 5 And Levantar = False Then
            clientes(User, 0) -= 5
            MsgBox("Nota 5 x " & contar(4))
        ElseIf clientes(User, 0) < 5 Then
            MsgBox("Dinheiro Insuficiente")
        End If
        Levantar = False
    End Sub

    Private Sub BtnLevantar_Click(sender As Object, e As EventArgs) Handles BtnLevantar.Click
        Dim contar() As Integer = {0, 0, 0, 0, 0}
        Nota(Val(TxtBoxDinheiro.Text), contar)
        If clientes(User, 0) >= Val(TxtBoxDinheiro.Text) And Val(TxtBoxDinheiro.Text) Mod 5 = 0 And Levantar = False And Val(TxtBoxDinheiro.Text) <= 250 Then
            clientes(User, 0) -= Val(TxtBoxDinheiro.Text)
            MsgBox("Nota 100 x " & contar(0) & " Nota 50 x " & contar(1) & " Nota 20 x " & contar(2) & " Nota 10 x " & contar(3) & " Nota 5 x " & contar(4))
            TxtBoxDinheiro.Clear()
        ElseIf clientes(User, 0) < Val(TxtBoxDinheiro.Text) And Val(TxtBoxDinheiro.Text) <= 250 Then
            MsgBox("Dinheiro insuficiente")
            TxtBoxDinheiro.Clear()
        End If
        Levantar = False
    End Sub

    Private Sub TxtBoxDinheiro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxDinheiro.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class