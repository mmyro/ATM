<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consultas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblDinheiro = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.RoyalBlue
        Me.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(217, 46)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Consultas:"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDinheiro
        '
        Me.LblDinheiro.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDinheiro.ForeColor = System.Drawing.Color.White
        Me.LblDinheiro.Location = New System.Drawing.Point(65, 85)
        Me.LblDinheiro.Name = "LblDinheiro"
        Me.LblDinheiro.Size = New System.Drawing.Size(404, 247)
        Me.LblDinheiro.TabIndex = 1
        Me.LblDinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(532, 407)
        Me.Controls.Add(Me.LblDinheiro)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Consultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "As suas consultas:"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblDinheiro As Label
End Class
