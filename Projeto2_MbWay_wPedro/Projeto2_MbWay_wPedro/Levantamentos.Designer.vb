<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Levantamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Levantamentos))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblBarra = New System.Windows.Forms.Label()
        Me.Btn10euros = New System.Windows.Forms.Button()
        Me.Btn20euros = New System.Windows.Forms.Button()
        Me.Btn5euros = New System.Windows.Forms.Button()
        Me.Btn50euros = New System.Windows.Forms.Button()
        Me.Btn100euros = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxDinheiro = New System.Windows.Forms.TextBox()
        Me.BtnLevantar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(-2, -2)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(234, 53)
        Me.LblTitulo.TabIndex = 0
        Me.LblTitulo.Text = "Levantar dinheiro"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblBarra
        '
        Me.LblBarra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.LblBarra.Location = New System.Drawing.Point(-5, 42)
        Me.LblBarra.Name = "LblBarra"
        Me.LblBarra.Size = New System.Drawing.Size(566, 23)
        Me.LblBarra.TabIndex = 31
        Me.LblBarra.Text = resources.GetString("LblBarra.Text")
        '
        'Btn10euros
        '
        Me.Btn10euros.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn10euros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn10euros.FlatAppearance.BorderSize = 2
        Me.Btn10euros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn10euros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn10euros.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn10euros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn10euros.Location = New System.Drawing.Point(223, 137)
        Me.Btn10euros.Name = "Btn10euros"
        Me.Btn10euros.Size = New System.Drawing.Size(75, 40)
        Me.Btn10euros.TabIndex = 50
        Me.Btn10euros.Text = "10"
        Me.Btn10euros.UseVisualStyleBackColor = False
        '
        'Btn20euros
        '
        Me.Btn20euros.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn20euros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn20euros.FlatAppearance.BorderSize = 2
        Me.Btn20euros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn20euros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn20euros.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn20euros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn20euros.Location = New System.Drawing.Point(304, 137)
        Me.Btn20euros.Name = "Btn20euros"
        Me.Btn20euros.Size = New System.Drawing.Size(75, 40)
        Me.Btn20euros.TabIndex = 49
        Me.Btn20euros.Text = "20"
        Me.Btn20euros.UseVisualStyleBackColor = False
        '
        'Btn5euros
        '
        Me.Btn5euros.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn5euros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn5euros.FlatAppearance.BorderSize = 2
        Me.Btn5euros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn5euros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn5euros.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5euros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn5euros.Location = New System.Drawing.Point(142, 137)
        Me.Btn5euros.Name = "Btn5euros"
        Me.Btn5euros.Size = New System.Drawing.Size(75, 40)
        Me.Btn5euros.TabIndex = 48
        Me.Btn5euros.Text = "5"
        Me.Btn5euros.UseVisualStyleBackColor = False
        '
        'Btn50euros
        '
        Me.Btn50euros.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn50euros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn50euros.FlatAppearance.BorderSize = 2
        Me.Btn50euros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn50euros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn50euros.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn50euros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn50euros.Location = New System.Drawing.Point(142, 183)
        Me.Btn50euros.Name = "Btn50euros"
        Me.Btn50euros.Size = New System.Drawing.Size(117, 40)
        Me.Btn50euros.TabIndex = 51
        Me.Btn50euros.Text = "50"
        Me.Btn50euros.UseVisualStyleBackColor = False
        '
        'Btn100euros
        '
        Me.Btn100euros.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn100euros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn100euros.FlatAppearance.BorderSize = 2
        Me.Btn100euros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn100euros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn100euros.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn100euros.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn100euros.Location = New System.Drawing.Point(262, 183)
        Me.Btn100euros.Name = "Btn100euros"
        Me.Btn100euros.Size = New System.Drawing.Size(117, 40)
        Me.Btn100euros.TabIndex = 52
        Me.Btn100euros.Text = "100"
        Me.Btn100euros.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(138, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Personalizado:"
        '
        'TxtBoxDinheiro
        '
        Me.TxtBoxDinheiro.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxDinheiro.Location = New System.Drawing.Point(142, 250)
        Me.TxtBoxDinheiro.Name = "TxtBoxDinheiro"
        Me.TxtBoxDinheiro.ReadOnly = True
        Me.TxtBoxDinheiro.Size = New System.Drawing.Size(237, 33)
        Me.TxtBoxDinheiro.TabIndex = 58
        '
        'BtnLevantar
        '
        Me.BtnLevantar.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnLevantar.FlatAppearance.BorderSize = 0
        Me.BtnLevantar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLevantar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLevantar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnLevantar.Location = New System.Drawing.Point(430, 368)
        Me.BtnLevantar.Name = "BtnLevantar"
        Me.BtnLevantar.Size = New System.Drawing.Size(90, 27)
        Me.BtnLevantar.TabIndex = 59
        Me.BtnLevantar.Text = "Levantar"
        Me.BtnLevantar.UseVisualStyleBackColor = False
        '
        'Levantamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 407)
        Me.Controls.Add(Me.BtnLevantar)
        Me.Controls.Add(Me.TxtBoxDinheiro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn100euros)
        Me.Controls.Add(Me.Btn50euros)
        Me.Controls.Add(Me.Btn10euros)
        Me.Controls.Add(Me.Btn20euros)
        Me.Controls.Add(Me.Btn5euros)
        Me.Controls.Add(Me.LblBarra)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Levantamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Levantamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblBarra As Label
    Friend WithEvents Btn10euros As Button
    Friend WithEvents Btn20euros As Button
    Friend WithEvents Btn5euros As Button
    Friend WithEvents Btn50euros As Button
    Friend WithEvents Btn100euros As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxDinheiro As TextBox
    Friend WithEvents BtnLevantar As Button
End Class
