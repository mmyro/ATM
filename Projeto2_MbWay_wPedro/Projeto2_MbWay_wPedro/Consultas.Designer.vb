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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultas))
        Me.LblDinheiro = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        'LblTitulo
        '
        Me.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(-2, -2)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(220, 53)
        Me.LblTitulo.TabIndex = 2
        Me.LblTitulo.Text = "Consultas:"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-5, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(566, 23)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 407)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.LblDinheiro)
        Me.Name = "Consultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "As suas consultas:"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblDinheiro As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents Label1 As Label
End Class
