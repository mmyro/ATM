<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblBarra = New System.Windows.Forms.Label()
        Me.BtnDesbloqCartoes = New System.Windows.Forms.Button()
        Me.BtnAddNotas = New System.Windows.Forms.Button()
        Me.LstBoxBlock = New System.Windows.Forms.ListBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.PicBoxCartao = New System.Windows.Forms.PictureBox()
        CType(Me.PicBoxCartao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTitulo
        '
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.Color.White
        Me.LblTitulo.Location = New System.Drawing.Point(-2, -2)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(220, 53)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "Administrador"
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
        'BtnDesbloqCartoes
        '
        Me.BtnDesbloqCartoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnDesbloqCartoes.FlatAppearance.BorderSize = 0
        Me.BtnDesbloqCartoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDesbloqCartoes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesbloqCartoes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnDesbloqCartoes.Location = New System.Drawing.Point(30, 120)
        Me.BtnDesbloqCartoes.Name = "BtnDesbloqCartoes"
        Me.BtnDesbloqCartoes.Size = New System.Drawing.Size(209, 47)
        Me.BtnDesbloqCartoes.TabIndex = 33
        Me.BtnDesbloqCartoes.Text = "Desbloquear Cartões"
        Me.BtnDesbloqCartoes.UseVisualStyleBackColor = False
        '
        'BtnAddNotas
        '
        Me.BtnAddNotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnAddNotas.FlatAppearance.BorderSize = 0
        Me.BtnAddNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddNotas.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNotas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnAddNotas.Location = New System.Drawing.Point(30, 206)
        Me.BtnAddNotas.Name = "BtnAddNotas"
        Me.BtnAddNotas.Size = New System.Drawing.Size(209, 50)
        Me.BtnAddNotas.TabIndex = 34
        Me.BtnAddNotas.Text = "Adicionar Notas"
        Me.BtnAddNotas.UseVisualStyleBackColor = False
        '
        'LstBoxBlock
        '
        Me.LstBoxBlock.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstBoxBlock.FormattingEnabled = True
        Me.LstBoxBlock.ItemHeight = 25
        Me.LstBoxBlock.Location = New System.Drawing.Point(282, 124)
        Me.LstBoxBlock.Name = "LstBoxBlock"
        Me.LstBoxBlock.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LstBoxBlock.Size = New System.Drawing.Size(129, 129)
        Me.LstBoxBlock.TabIndex = 35
        '
        'BtnSair
        '
        Me.BtnSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.BtnSair.FlatAppearance.BorderSize = 0
        Me.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSair.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BtnSair.Location = New System.Drawing.Point(430, 368)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(85, 31)
        Me.BtnSair.TabIndex = 36
        Me.BtnSair.Text = "Logout"
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'PicBoxCartao
        '
        Me.PicBoxCartao.Image = Global.Projeto2_MbWay_wPedro.My.Resources.Resources.Admin
        Me.PicBoxCartao.Location = New System.Drawing.Point(445, 55)
        Me.PicBoxCartao.Name = "PicBoxCartao"
        Me.PicBoxCartao.Size = New System.Drawing.Size(75, 76)
        Me.PicBoxCartao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicBoxCartao.TabIndex = 32
        Me.PicBoxCartao.TabStop = False
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 407)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.LstBoxBlock)
        Me.Controls.Add(Me.BtnAddNotas)
        Me.Controls.Add(Me.BtnDesbloqCartoes)
        Me.Controls.Add(Me.LblBarra)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.PicBoxCartao)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        CType(Me.PicBoxCartao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblBarra As Label
    Friend WithEvents PicBoxCartao As PictureBox
    Friend WithEvents BtnDesbloqCartoes As Button
    Friend WithEvents BtnAddNotas As Button
    Friend WithEvents LstBoxBlock As ListBox
    Friend WithEvents BtnSair As Button
End Class
