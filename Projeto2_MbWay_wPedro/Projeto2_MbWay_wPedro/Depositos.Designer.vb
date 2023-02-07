<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Depositos
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
        Me.TxtDepositar = New System.Windows.Forms.TextBox()
        Me.BtnDepositar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(217, 46)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Depostar dinheiro:"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDepositar
        '
        Me.TxtDepositar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepositar.Location = New System.Drawing.Point(174, 133)
        Me.TxtDepositar.Multiline = True
        Me.TxtDepositar.Name = "TxtDepositar"
        Me.TxtDepositar.Size = New System.Drawing.Size(175, 47)
        Me.TxtDepositar.TabIndex = 1
        Me.TxtDepositar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnDepositar
        '
        Me.BtnDepositar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnDepositar.Location = New System.Drawing.Point(185, 186)
        Me.BtnDepositar.Name = "BtnDepositar"
        Me.BtnDepositar.Size = New System.Drawing.Size(151, 31)
        Me.BtnDepositar.TabIndex = 2
        Me.BtnDepositar.Text = "Depositar"
        Me.BtnDepositar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(144, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 128)
        Me.Label1.TabIndex = 3
        '
        'Depositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(532, 407)
        Me.Controls.Add(Me.BtnDepositar)
        Me.Controls.Add(Me.TxtDepositar)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Depositos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Depositos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtDepositar As TextBox
    Friend WithEvents BtnDepositar As Button
    Friend WithEvents Label1 As Label
End Class
