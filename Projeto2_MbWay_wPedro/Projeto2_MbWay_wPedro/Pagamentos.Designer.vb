<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagamentos))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblBarra = New System.Windows.Forms.Label()
        Me.LblInformacao = New System.Windows.Forms.Label()
        Me.TxtBoxEntidade = New System.Windows.Forms.TextBox()
        Me.TxtBoxReferencia = New System.Windows.Forms.TextBox()
        Me.TxtBoxMontante = New System.Windows.Forms.TextBox()
        Me.LblEntidade = New System.Windows.Forms.Label()
        Me.LblReferências = New System.Windows.Forms.Label()
        Me.LblMontante = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(-2, -2)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(220, 53)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "Pagamentos"
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
        'LblInformacao
        '
        Me.LblInformacao.AutoSize = True
        Me.LblInformacao.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInformacao.ForeColor = System.Drawing.Color.White
        Me.LblInformacao.Location = New System.Drawing.Point(150, 65)
        Me.LblInformacao.Name = "LblInformacao"
        Me.LblInformacao.Size = New System.Drawing.Size(209, 30)
        Me.LblInformacao.TabIndex = 33
        Me.LblInformacao.Text = "Elementos da factura"
        '
        'TxtBoxEntidade
        '
        Me.TxtBoxEntidade.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxEntidade.Location = New System.Drawing.Point(270, 178)
        Me.TxtBoxEntidade.Name = "TxtBoxEntidade"
        Me.TxtBoxEntidade.Size = New System.Drawing.Size(100, 33)
        Me.TxtBoxEntidade.TabIndex = 34
        '
        'TxtBoxReferencia
        '
        Me.TxtBoxReferencia.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxReferencia.Location = New System.Drawing.Point(296, 228)
        Me.TxtBoxReferencia.Name = "TxtBoxReferencia"
        Me.TxtBoxReferencia.Size = New System.Drawing.Size(100, 33)
        Me.TxtBoxReferencia.TabIndex = 35
        '
        'TxtBoxMontante
        '
        Me.TxtBoxMontante.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxMontante.Location = New System.Drawing.Point(293, 267)
        Me.TxtBoxMontante.Name = "TxtBoxMontante"
        Me.TxtBoxMontante.Size = New System.Drawing.Size(100, 33)
        Me.TxtBoxMontante.TabIndex = 36
        '
        'LblEntidade
        '
        Me.LblEntidade.AutoSize = True
        Me.LblEntidade.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEntidade.ForeColor = System.Drawing.Color.White
        Me.LblEntidade.Location = New System.Drawing.Point(132, 133)
        Me.LblEntidade.Name = "LblEntidade"
        Me.LblEntidade.Size = New System.Drawing.Size(70, 21)
        Me.LblEntidade.TabIndex = 37
        Me.LblEntidade.Text = "Entidade"
        '
        'LblReferências
        '
        Me.LblReferências.AutoSize = True
        Me.LblReferências.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReferências.ForeColor = System.Drawing.Color.White
        Me.LblReferências.Location = New System.Drawing.Point(167, 204)
        Me.LblReferências.Name = "LblReferências"
        Me.LblReferências.Size = New System.Drawing.Size(90, 21)
        Me.LblReferências.TabIndex = 38
        Me.LblReferências.Text = "Referências"
        '
        'LblMontante
        '
        Me.LblMontante.AutoSize = True
        Me.LblMontante.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontante.ForeColor = System.Drawing.Color.White
        Me.LblMontante.Location = New System.Drawing.Point(145, 243)
        Me.LblMontante.Name = "LblMontante"
        Me.LblMontante.Size = New System.Drawing.Size(77, 21)
        Me.LblMontante.TabIndex = 39
        Me.LblMontante.Text = "Montante"
        '
        'Pagamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 407)
        Me.Controls.Add(Me.LblMontante)
        Me.Controls.Add(Me.LblReferências)
        Me.Controls.Add(Me.LblEntidade)
        Me.Controls.Add(Me.TxtBoxMontante)
        Me.Controls.Add(Me.TxtBoxReferencia)
        Me.Controls.Add(Me.TxtBoxEntidade)
        Me.Controls.Add(Me.LblInformacao)
        Me.Controls.Add(Me.LblBarra)
        Me.Controls.Add(Me.LblTitulo)
        Me.Name = "Pagamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblBarra As Label
    Friend WithEvents LblInformacao As Label
    Friend WithEvents TxtBoxEntidade As TextBox
    Friend WithEvents TxtBoxReferencia As TextBox
    Friend WithEvents TxtBoxMontante As TextBox
    Friend WithEvents LblEntidade As Label
    Friend WithEvents LblReferências As Label
    Friend WithEvents LblMontante As Label
End Class
