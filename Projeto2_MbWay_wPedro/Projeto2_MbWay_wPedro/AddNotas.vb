Public Class AddNotas
    Private Sub Btn100euros_Click(sender As Object, e As EventArgs) Handles Btn100euros.Click
        Dim Cont As Integer
        Cont = InputBox("Insira a quantidade de notas a inserir:")
        notas(0) += Cont
        MsgBox(notas(0) & " notas de 100")
    End Sub

    Private Sub Btn50euros_Click(sender As Object, e As EventArgs) Handles Btn50euros.Click
        Dim Cont As Integer
        Cont = InputBox("Insira a quantidade de notas a inserir:")
        notas(1) += Cont
        MsgBox(notas(1) & " notas de 50")
    End Sub

    Private Sub Btn10euros_Click(sender As Object, e As EventArgs) Handles Btn10euros.Click
        Dim Cont As Integer
        Cont = InputBox("Insira a quantidade de notas a inserir:")
        notas(3) += Cont
        MsgBox(notas(3) & " notas de 10")
    End Sub

    Private Sub Btn20euros_Click(sender As Object, e As EventArgs) Handles Btn20euros.Click
        Dim Cont As Integer
        Cont += InputBox("Insira a quantidade de notas a inserir:")
        notas(2) += Cont
        MsgBox(notas(2) & " notas de 20")
    End Sub

    Private Sub Btn5euros_Click(sender As Object, e As EventArgs) Handles Btn5euros.Click
        Dim Cont As Integer
        Cont = InputBox("Insira a quantidade de notas a inserir:")
        notas(4) += Cont
        MsgBox(notas(4) & " notas de 5")
    End Sub

    Private Sub AddNotas_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Me.Hide()
    End Sub
End Class