<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Definicoes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TxtBoxOldPassword = New System.Windows.Forms.TextBox()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.LblOldPassword = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(12, 9)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(217, 46)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Definições:"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBoxOldPassword
        '
        Me.TxtBoxOldPassword.Location = New System.Drawing.Point(199, 100)
        Me.TxtBoxOldPassword.Name = "TxtBoxOldPassword"
        Me.TxtBoxOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBoxOldPassword.Size = New System.Drawing.Size(122, 35)
        Me.TxtBoxOldPassword.TabIndex = 1
        '
        'BtnNext
        '
        Me.BtnNext.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.Location = New System.Drawing.Point(356, 368)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(80, 27)
        Me.BtnNext.TabIndex = 4
        Me.BtnNext.Text = "Proximo"
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'LblOldPassword
        '
        Me.LblOldPassword.AutoSize = True
        Me.LblOldPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOldPassword.ForeColor = System.Drawing.Color.White
        Me.LblOldPassword.Location = New System.Drawing.Point(51, 106)
        Me.LblOldPassword.Name = "LblOldPassword"
        Me.LblOldPassword.Size = New System.Drawing.Size(142, 25)
        Me.LblOldPassword.TabIndex = 6
        Me.LblOldPassword.Text = "Password atual:"
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(442, 368)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(78, 27)
        Me.BtnCancel.TabIndex = 7
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Definicoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(532, 407)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblOldPassword)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.TxtBoxOldPassword)
        Me.Controls.Add(Me.LblTitulo)
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Definicoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definicoes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents TxtBoxOldPassword As TextBox
    Friend WithEvents BtnNext As Button
    Friend WithEvents LblOldPassword As Label
    Friend WithEvents BtnCancel As Button
End Class
