<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class password
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
        Me.TxtBox1 = New System.Windows.Forms.TextBox()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TxtBox2 = New System.Windows.Forms.TextBox()
        Me.LblNewPassword = New System.Windows.Forms.Label()
        Me.LblConfirmPassword = New System.Windows.Forms.Label()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtBox1
        '
        Me.TxtBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox1.Location = New System.Drawing.Point(199, 100)
        Me.TxtBox1.Name = "TxtBox1"
        Me.TxtBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBox1.Size = New System.Drawing.Size(122, 35)
        Me.TxtBox1.TabIndex = 2
        '
        'LblTitulo
        '
        Me.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(217, 46)
        Me.LblTitulo.TabIndex = 3
        Me.LblTitulo.Text = "Definições:"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBox2
        '
        Me.TxtBox2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBox2.Location = New System.Drawing.Point(199, 139)
        Me.TxtBox2.Name = "TxtBox2"
        Me.TxtBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBox2.Size = New System.Drawing.Size(122, 35)
        Me.TxtBox2.TabIndex = 4
        '
        'LblNewPassword
        '
        Me.LblNewPassword.AutoSize = True
        Me.LblNewPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNewPassword.ForeColor = System.Drawing.Color.White
        Me.LblNewPassword.Location = New System.Drawing.Point(42, 107)
        Me.LblNewPassword.Name = "LblNewPassword"
        Me.LblNewPassword.Size = New System.Drawing.Size(141, 25)
        Me.LblNewPassword.TabIndex = 5
        Me.LblNewPassword.Text = "Nova password"
        '
        'LblConfirmPassword
        '
        Me.LblConfirmPassword.AutoSize = True
        Me.LblConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConfirmPassword.ForeColor = System.Drawing.Color.White
        Me.LblConfirmPassword.Location = New System.Drawing.Point(12, 146)
        Me.LblConfirmPassword.Name = "LblConfirmPassword"
        Me.LblConfirmPassword.Size = New System.Drawing.Size(182, 25)
        Me.LblConfirmPassword.TabIndex = 6
        Me.LblConfirmPassword.Text = "Confirmar password"
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.Location = New System.Drawing.Point(428, 368)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(92, 27)
        Me.BtnConfirmar.TabIndex = 7
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(532, 407)
        Me.Controls.Add(Me.BtnConfirmar)
        Me.Controls.Add(Me.LblConfirmPassword)
        Me.Controls.Add(Me.LblNewPassword)
        Me.Controls.Add(Me.TxtBox2)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.TxtBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBox1 As TextBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtBox2 As TextBox
    Friend WithEvents LblNewPassword As Label
    Friend WithEvents LblConfirmPassword As Label
    Friend WithEvents BtnConfirmar As Button
End Class
