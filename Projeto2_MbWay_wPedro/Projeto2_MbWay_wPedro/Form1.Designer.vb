<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBoxUsername = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtBoxPassword = New System.Windows.Forms.TextBox()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogin.ForeColor = System.Drawing.Color.White
        Me.LblLogin.Location = New System.Drawing.Point(34, 30)
        Me.LblLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(53, 21)
        Me.LblLogin.TabIndex = 0
        Me.LblLogin.Text = "Login"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TxtBoxUsername)
        Me.Panel1.Location = New System.Drawing.Point(65, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 43)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TxtBoxUsername
        '
        Me.TxtBoxUsername.Location = New System.Drawing.Point(54, 7)
        Me.TxtBoxUsername.Name = "TxtBoxUsername"
        Me.TxtBoxUsername.ReadOnly = True
        Me.TxtBoxUsername.Size = New System.Drawing.Size(180, 29)
        Me.TxtBoxUsername.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtBoxPassword)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(65, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 43)
        Me.Panel2.TabIndex = 3
        '
        'TxtBoxPassword
        '
        Me.TxtBoxPassword.Location = New System.Drawing.Point(54, 8)
        Me.TxtBoxPassword.Name = "TxtBoxPassword"
        Me.TxtBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBoxPassword.ReadOnly = True
        Me.TxtBoxPassword.Size = New System.Drawing.Size(180, 29)
        Me.TxtBoxPassword.TabIndex = 3
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnEntrar.Enabled = False
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.ForeColor = System.Drawing.Color.Black
        Me.BtnEntrar.Location = New System.Drawing.Point(227, 301)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(75, 40)
        Me.BtnEntrar.TabIndex = 4
        Me.BtnEntrar.Text = "Entrar"
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'Btn7
        '
        Me.Btn7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn7.Location = New System.Drawing.Point(65, 163)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(75, 40)
        Me.Btn7.TabIndex = 5
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn9.Location = New System.Drawing.Point(227, 163)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(75, 40)
        Me.Btn9.TabIndex = 6
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn4.Location = New System.Drawing.Point(65, 209)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(75, 40)
        Me.Btn4.TabIndex = 7
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn8.Location = New System.Drawing.Point(146, 163)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(75, 40)
        Me.Btn8.TabIndex = 8
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn6.Location = New System.Drawing.Point(227, 209)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(75, 40)
        Me.Btn6.TabIndex = 9
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn3.Location = New System.Drawing.Point(227, 255)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 40)
        Me.Btn3.TabIndex = 10
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Location = New System.Drawing.Point(65, 255)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 40)
        Me.Btn1.TabIndex = 11
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Btn5
        '
        Me.Btn5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn5.Location = New System.Drawing.Point(146, 209)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(75, 40)
        Me.Btn5.TabIndex = 12
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Location = New System.Drawing.Point(146, 255)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 40)
        Me.Btn2.TabIndex = 13
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn0
        '
        Me.Btn0.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn0.Location = New System.Drawing.Point(65, 301)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(75, 40)
        Me.Btn0.TabIndex = 14
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.ForeColor = System.Drawing.Color.Black
        Me.BtnOk.Location = New System.Drawing.Point(146, 301)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 40)
        Me.BtnOk.TabIndex = 15
        Me.BtnOk.Text = "OK"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.Location = New System.Drawing.Point(250, 19)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(52, 40)
        Me.BtnLimpar.TabIndex = 16
        Me.BtnLimpar.Text = "C"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(372, 363)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Btn0)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn5)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn6)
        Me.Controls.Add(Me.Btn8)
        Me.Controls.Add(Me.Btn4)
        Me.Controls.Add(Me.Btn9)
        Me.Controls.Add(Me.Btn7)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblLogin)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblLogin As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBoxUsername As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtBoxPassword As TextBox
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnLimpar As Button
End Class
