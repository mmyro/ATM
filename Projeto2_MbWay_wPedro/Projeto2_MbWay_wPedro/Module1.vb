Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Module codigoAtm
    Public Const LIN As Integer = 5
    Public Const COL As Integer = 1
    Public notas = {20, 20, 20, 20, 20}
    Public clientes(LIN, COL) As Single
    Public bloqueio(LIN) As Integer

    Sub IniciarClientes()
        For i = 0 To LIN
            clientes(i, 0) = 2000
            clientes(i, 1) = 1111
            bloqueio(i) = 1
        Next
    End Sub
End Module
