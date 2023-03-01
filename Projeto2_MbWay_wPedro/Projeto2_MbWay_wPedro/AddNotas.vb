Public Class AddNotas
    Private Sub Btn100euros_Click(sender As Object, e As EventArgs) Handles Btn100euros.Click
        Dim Cont As Integer
        Cont = InputBox("")
        notas(0) += Cont
        MsgBox(notas(0))
    End Sub

    Private Sub Btn50euros_Click(sender As Object, e As EventArgs) Handles Btn50euros.Click
        Dim Cont As Integer
        Cont = InputBox("")
        notas(1) += Cont
        MsgBox(notas(1))
    End Sub

    Private Sub Btn10euros_Click(sender As Object, e As EventArgs) Handles Btn10euros.Click
        Dim Cont As Integer
        Cont = InputBox("")
        notas(3) += Cont
        MsgBox(notas(3))
    End Sub

    Private Sub Btn20euros_Click(sender As Object, e As EventArgs) Handles Btn20euros.Click
        Dim Cont As Integer
        Cont += InputBox("")
        notas(2) += Cont
        MsgBox(notas(2))
    End Sub

    Private Sub Btn5euros_Click(sender As Object, e As EventArgs) Handles Btn5euros.Click
        Dim Cont As Integer
        Cont = InputBox("")
        notas(4) += Cont
        MsgBox(notas(4))
    End Sub

    Private Sub AddNotas_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class