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
        Me.LblNmrConta = New System.Windows.Forms.Label()
        Me.LblMontante = New System.Windows.Forms.Label()
        Me.TxtBoxNmrConta = New System.Windows.Forms.TextBox()
        Me.TxtBoxMontante = New System.Windows.Forms.TextBox()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.Btn0 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn5 = New System.Windows.Forms.Button()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Btn6 = New System.Windows.Forms.Button()
        Me.Btn8 = New System.Windows.Forms.Button()
        Me.Btn4 = New System.Windows.Forms.Button()
        Me.Btn9 = New System.Windows.Forms.Button()
        Me.Btn7 = New System.Windows.Forms.Button()
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
        'LblNmrConta
        '
        Me.LblNmrConta.AutoSize = True
        Me.LblNmrConta.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNmrConta.ForeColor = System.Drawing.Color.White
        Me.LblNmrConta.Location = New System.Drawing.Point(141, 51)
        Me.LblNmrConta.Name = "LblNmrConta"
        Me.LblNmrConta.Size = New System.Drawing.Size(159, 25)
        Me.LblNmrConta.TabIndex = 33
        Me.LblNmrConta.Text = "Numero da conta"
        '
        'LblMontante
        '
        Me.LblMontante.AutoSize = True
        Me.LblMontante.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontante.ForeColor = System.Drawing.Color.White
        Me.LblMontante.Location = New System.Drawing.Point(141, 117)
        Me.LblMontante.Name = "LblMontante"
        Me.LblMontante.Size = New System.Drawing.Size(94, 25)
        Me.LblMontante.TabIndex = 36
        Me.LblMontante.Text = "Montante"
        '
        'TxtBoxNmrConta
        '
        Me.TxtBoxNmrConta.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxNmrConta.Location = New System.Drawing.Point(146, 81)
        Me.TxtBoxNmrConta.Name = "TxtBoxNmrConta"
        Me.TxtBoxNmrConta.ReadOnly = True
        Me.TxtBoxNmrConta.Size = New System.Drawing.Size(239, 33)
        Me.TxtBoxNmrConta.TabIndex = 37
        '
        'TxtBoxMontante
        '
        Me.TxtBoxMontante.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxMontante.Location = New System.Drawing.Point(146, 145)
        Me.TxtBoxMontante.Name = "TxtBoxMontante"
        Me.TxtBoxMontante.ReadOnly = True
        Me.TxtBoxMontante.Size = New System.Drawing.Size(237, 33)
        Me.TxtBoxMontante.TabIndex = 38
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnConfirmar.FlatAppearance.BorderSize = 0
        Me.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnConfirmar.Location = New System.Drawing.Point(430, 368)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(90, 27)
        Me.BtnConfirmar.TabIndex = 39
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = False
        '
        'BtnOk
        '
        Me.BtnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnOk.FlatAppearance.BorderSize = 2
        Me.BtnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOk.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnOk.Location = New System.Drawing.Point(308, 322)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 40)
        Me.BtnOk.TabIndex = 67
        Me.BtnOk.Text = "Ok"
        Me.BtnOk.UseVisualStyleBackColor = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnLimpar.FlatAppearance.BorderSize = 2
        Me.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnLimpar.Location = New System.Drawing.Point(146, 321)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(75, 40)
        Me.BtnLimpar.TabIndex = 66
        Me.BtnLimpar.Text = "C"
        Me.BtnLimpar.UseVisualStyleBackColor = False
        '
        'Btn0
        '
        Me.Btn0.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn0.FlatAppearance.BorderSize = 2
        Me.Btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn0.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn0.Location = New System.Drawing.Point(227, 322)
        Me.Btn0.Name = "Btn0"
        Me.Btn0.Size = New System.Drawing.Size(75, 40)
        Me.Btn0.TabIndex = 65
        Me.Btn0.Text = "0"
        Me.Btn0.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn2.FlatAppearance.BorderSize = 2
        Me.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn2.Location = New System.Drawing.Point(227, 276)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(75, 40)
        Me.Btn2.TabIndex = 64
        Me.Btn2.Text = "2"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn5
        '
        Me.Btn5.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn5.FlatAppearance.BorderSize = 2
        Me.Btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn5.Location = New System.Drawing.Point(227, 230)
        Me.Btn5.Name = "Btn5"
        Me.Btn5.Size = New System.Drawing.Size(75, 40)
        Me.Btn5.TabIndex = 63
        Me.Btn5.Text = "5"
        Me.Btn5.UseVisualStyleBackColor = False
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn1.FlatAppearance.BorderSize = 2
        Me.Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn1.Location = New System.Drawing.Point(146, 276)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 40)
        Me.Btn1.TabIndex = 62
        Me.Btn1.Text = "1"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn3.FlatAppearance.BorderSize = 2
        Me.Btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn3.Location = New System.Drawing.Point(308, 276)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(75, 40)
        Me.Btn3.TabIndex = 61
        Me.Btn3.Text = "3"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Btn6
        '
        Me.Btn6.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn6.FlatAppearance.BorderSize = 2
        Me.Btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn6.Location = New System.Drawing.Point(308, 230)
        Me.Btn6.Name = "Btn6"
        Me.Btn6.Size = New System.Drawing.Size(75, 40)
        Me.Btn6.TabIndex = 60
        Me.Btn6.Text = "6"
        Me.Btn6.UseVisualStyleBackColor = False
        '
        'Btn8
        '
        Me.Btn8.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn8.FlatAppearance.BorderSize = 2
        Me.Btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn8.Location = New System.Drawing.Point(227, 184)
        Me.Btn8.Name = "Btn8"
        Me.Btn8.Size = New System.Drawing.Size(75, 40)
        Me.Btn8.TabIndex = 59
        Me.Btn8.Text = "8"
        Me.Btn8.UseVisualStyleBackColor = False
        '
        'Btn4
        '
        Me.Btn4.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn4.FlatAppearance.BorderSize = 2
        Me.Btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn4.Location = New System.Drawing.Point(146, 230)
        Me.Btn4.Name = "Btn4"
        Me.Btn4.Size = New System.Drawing.Size(75, 40)
        Me.Btn4.TabIndex = 58
        Me.Btn4.Text = "4"
        Me.Btn4.UseVisualStyleBackColor = False
        '
        'Btn9
        '
        Me.Btn9.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn9.FlatAppearance.BorderSize = 2
        Me.Btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn9.Location = New System.Drawing.Point(308, 184)
        Me.Btn9.Name = "Btn9"
        Me.Btn9.Size = New System.Drawing.Size(75, 40)
        Me.Btn9.TabIndex = 57
        Me.Btn9.Text = "9"
        Me.Btn9.UseVisualStyleBackColor = False
        '
        'Btn7
        '
        Me.Btn7.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn7.FlatAppearance.BorderSize = 2
        Me.Btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Btn7.Location = New System.Drawing.Point(146, 184)
        Me.Btn7.Name = "Btn7"
        Me.Btn7.Size = New System.Drawing.Size(75, 40)
        Me.Btn7.TabIndex = 56
        Me.Btn7.Text = "7"
        Me.Btn7.UseVisualStyleBackColor = False
        '
        'Transferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 407)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnLimpar)
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
        Me.Controls.Add(Me.BtnConfirmar)
        Me.Controls.Add(Me.TxtBoxMontante)
        Me.Controls.Add(Me.TxtBoxNmrConta)
        Me.Controls.Add(Me.LblMontante)
        Me.Controls.Add(Me.LblNmrConta)
        Me.Controls.Add(Me.LblBarra)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Transferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transferencias"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblBarra As Label
    Friend WithEvents LblNmrConta As Label
    Friend WithEvents LblMontante As Label
    Friend WithEvents TxtBoxNmrConta As TextBox
    Friend WithEvents TxtBoxMontante As TextBox
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn7 As Button
End Class
