<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportRunner
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnRun = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.TxtComment = New System.Windows.Forms.TextBox()
        Me.DgvParamaters = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvParamaters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.BtnRun)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 290)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 44)
        Me.Panel1.TabIndex = 2
        '
        'BtnRun
        '
        Me.BtnRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRun.Location = New System.Drawing.Point(149, 7)
        Me.BtnRun.Name = "BtnRun"
        Me.BtnRun.Size = New System.Drawing.Size(95, 30)
        Me.BtnRun.TabIndex = 0
        Me.BtnRun.Text = "Gerar"
        Me.BtnRun.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(250, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(95, 30)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Fechar"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'TxtComment
        '
        Me.TxtComment.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtComment.Location = New System.Drawing.Point(0, 238)
        Me.TxtComment.Multiline = True
        Me.TxtComment.Name = "TxtComment"
        Me.TxtComment.ReadOnly = True
        Me.TxtComment.Size = New System.Drawing.Size(357, 52)
        Me.TxtComment.TabIndex = 1
        '
        'DgvParamaters
        '
        Me.DgvParamaters.AllowUserToAddRows = False
        Me.DgvParamaters.AllowUserToDeleteRows = False
        Me.DgvParamaters.AllowUserToResizeRows = False
        Me.DgvParamaters.BackgroundColor = System.Drawing.Color.White
        Me.DgvParamaters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvParamaters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvParamaters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvParamaters.Location = New System.Drawing.Point(0, 0)
        Me.DgvParamaters.Name = "DgvParamaters"
        Me.DgvParamaters.RowHeadersVisible = False
        Me.DgvParamaters.Size = New System.Drawing.Size(357, 238)
        Me.DgvParamaters.TabIndex = 0
        '
        'FrmReportRunner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(357, 334)
        Me.Controls.Add(Me.DgvParamaters)
        Me.Controls.Add(Me.TxtComment)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportRunner"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Gerar Relatório"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DgvParamaters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRun As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents TxtComment As TextBox
    Friend WithEvents DgvParamaters As DataGridView
End Class
