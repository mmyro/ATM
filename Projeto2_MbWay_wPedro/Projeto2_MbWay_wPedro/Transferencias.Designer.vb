<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transferencias
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transferencias))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblBarra = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(-2, -2)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(220, 53)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Transferências"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBarra
        '
        Me.LblBarra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LblBarra.Location = New System.Drawing.Point(-5, 42)
        Me.LblBarra.Name = "LblBarra"
        Me.LblBarra.Size = New System.Drawing.Size(566, 23)
        Me.LblBarra.TabIndex = 32
        Me.LblBarra.Text = resources.GetString("LblBarra.Text")
        '
        'Transferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 407)
        Me.Controls.Add(Me.LblBarra)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Transferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencias"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblBarra As Label
End Class
