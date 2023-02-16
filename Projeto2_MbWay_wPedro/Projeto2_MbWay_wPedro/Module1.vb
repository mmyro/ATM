Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Module codigoAtm
    Public Const LIN As Integer = 5
    Public Const COL As Integer = 1
    Public notas = {5, 10, 20, 50, 100}
    Public clientes(LIN, COL) As Single

    Sub IniciarClientes()
        For i = 0 To LIN
            For j = 0 To COL
                If j = 0 Then
                    clientes(i, j) = 2000
                Else
                    clientes(i, j) = 1111
                End If
            Next
        Next
    End Sub
End Module
