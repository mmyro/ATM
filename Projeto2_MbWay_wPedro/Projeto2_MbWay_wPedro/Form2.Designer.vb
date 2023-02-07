<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.BtnConsultas = New System.Windows.Forms.Button()
        Me.BtnDepositos = New System.Windows.Forms.Button()
        Me.BtnPagamentos = New System.Windows.Forms.Button()
        Me.BtnTransferencias = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLevantamentos = New System.Windows.Forms.Button()
        Me.PixBox2 = New System.Windows.Forms.PictureBox()
        Me.PicBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PixBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnConsultas
        '
        Me.BtnConsultas.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnConsultas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConsultas.ForeColor = System.Drawing.Color.White
        Me.BtnConsultas.Location = New System.Drawing.Point(9, 63)
        Me.BtnConsultas.Name = "BtnConsultas"
        Me.BtnConsultas.Size = New System.Drawing.Size(130, 43)
        Me.BtnConsultas.TabIndex = 0
        Me.BtnConsultas.Text = "Consultas"
        Me.BtnConsultas.UseVisualStyleBackColor = False
        '
        'BtnDepositos
        '
        Me.BtnDepositos.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnDepositos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDepositos.ForeColor = System.Drawing.Color.White
        Me.BtnDepositos.Location = New System.Drawing.Point(9, 112)
        Me.BtnDepositos.Name = "BtnDepositos"
        Me.BtnDepositos.Size = New System.Drawing.Size(130, 43)
        Me.BtnDepositos.TabIndex = 1
        Me.BtnDepositos.Text = "Depositos"
        Me.BtnDepositos.UseVisualStyleBackColor = False
        '
        'BtnPagamentos
        '
        Me.BtnPagamentos.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnPagamentos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagamentos.ForeColor = System.Drawing.Color.White
        Me.BtnPagamentos.Location = New System.Drawing.Point(9, 161)
        Me.BtnPagamentos.Name = "BtnPagamentos"
        Me.BtnPagamentos.Size = New System.Drawing.Size(130, 43)
        Me.BtnPagamentos.TabIndex = 2
        Me.BtnPagamentos.Text = "Pagamentos"
        Me.BtnPagamentos.UseVisualStyleBackColor = False
        '
        'BtnTransferencias
        '
        Me.BtnTransferencias.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnTransferencias.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransferencias.ForeColor = System.Drawing.Color.White
        Me.BtnTransferencias.Location = New System.Drawing.Point(9, 210)
        Me.BtnTransferencias.Name = "BtnTransferencias"
        Me.BtnTransferencias.Size = New System.Drawing.Size(130, 43)
        Me.BtnTransferencias.TabIndex = 3
        Me.BtnTransferencias.Text = "Transferências"
        Me.BtnTransferencias.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnLevantamentos)
        Me.Panel1.Controls.Add(Me.PixBox2)
        Me.Panel1.Controls.Add(Me.BtnConsultas)
        Me.Panel1.Controls.Add(Me.PicBox1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.BtnTransferencias)
        Me.Panel1.Controls.Add(Me.BtnPagamentos)
        Me.Panel1.Controls.Add(Me.BtnDepositos)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 412)
        Me.Panel1.TabIndex = 4
        '
        'BtnLevantamentos
        '
        Me.BtnLevantamentos.BackColor = System.Drawing.Color.RoyalBlue
        Me.BtnLevantamentos.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLevantamentos.ForeColor = System.Drawing.Color.White
        Me.BtnLevantamentos.Location = New System.Drawing.Point(9, 259)
        Me.BtnLevantamentos.Name = "BtnLevantamentos"
        Me.BtnLevantamentos.Size = New System.Drawing.Size(130, 43)
        Me.BtnLevantamentos.TabIndex = 6
        Me.BtnLevantamentos.Text = "Levantamentos"
        Me.BtnLevantamentos.UseVisualStyleBackColor = False
        '
        'PixBox2
        '
        Me.PixBox2.Image = CType(resources.GetObject("PixBox2.Image"), System.Drawing.Image)
        Me.PixBox2.Location = New System.Drawing.Point(0, 0)
        Me.PixBox2.Name = "PixBox2"
        Me.PixBox2.Size = New System.Drawing.Size(145, 57)
        Me.PixBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PixBox2.TabIndex = 0
        Me.PixBox2.TabStop = False
        '
        'PicBox1
        '
        Me.PicBox1.Image = CType(resources.GetObject("PicBox1.Image"), System.Drawing.Image)
        Me.PicBox1.Location = New System.Drawing.Point(0, 0)
        Me.PicBox1.Name = "PicBox1"
        Me.PicBox1.Size = New System.Drawing.Size(145, 57)
        Me.PicBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicBox1.TabIndex = 5
        Me.PicBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(9, 357)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 43)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Definições"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(148, -4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(548, 418)
        Me.Panel2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(694, 414)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multibanco"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PixBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnConsultas As Button
    Friend WithEvents BtnDepositos As Button
    Friend WithEvents BtnPagamentos As Button
    Friend WithEvents BtnTransferencias As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PicBox1 As PictureBox
    Friend WithEvents PixBox2 As PictureBox
    Friend WithEvents BtnLevantamentos As Button
    Friend WithEvents Button1 As Button
End Class
