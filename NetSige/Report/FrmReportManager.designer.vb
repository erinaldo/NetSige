<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReportManager
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnInclude = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.OfdReport = New System.Windows.Forms.OpenFileDialog()
        Me.DgvReports = New System.Windows.Forms.DataGridView()
        CType(Me.DgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.Location = New System.Drawing.Point(493, 358)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(95, 30)
        Me.BtnOK.TabIndex = 4
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnInclude
        '
        Me.BtnInclude.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInclude.Location = New System.Drawing.Point(12, 358)
        Me.BtnInclude.Name = "BtnInclude"
        Me.BtnInclude.Size = New System.Drawing.Size(95, 30)
        Me.BtnInclude.TabIndex = 4
        Me.BtnInclude.Text = "Adicionar"
        Me.BtnInclude.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRemove.Location = New System.Drawing.Point(113, 358)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(95, 30)
        Me.BtnRemove.TabIndex = 4
        Me.BtnRemove.Text = "Remover"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'OfdReport
        '
        Me.OfdReport.Filter = "Relatórios|*.rep;"
        Me.OfdReport.Multiselect = True
        Me.OfdReport.Title = "Selecionar Relatórios"
        '
        'DgvReports
        '
        Me.DgvReports.AllowUserToAddRows = False
        Me.DgvReports.AllowUserToDeleteRows = False
        Me.DgvReports.AllowUserToOrderColumns = True
        Me.DgvReports.AllowUserToResizeRows = False
        Me.DgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvReports.BackgroundColor = System.Drawing.Color.White
        Me.DgvReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReports.Location = New System.Drawing.Point(12, 12)
        Me.DgvReports.MultiSelect = False
        Me.DgvReports.Name = "DgvReports"
        Me.DgvReports.ReadOnly = True
        Me.DgvReports.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvReports.RowHeadersVisible = False
        Me.DgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvReports.Size = New System.Drawing.Size(576, 340)
        Me.DgvReports.TabIndex = 5
        '
        'FrmReportManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.DgvReports)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnInclude)
        Me.Controls.Add(Me.BtnOK)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportManager"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Gerenciar Relatórios"
        CType(Me.DgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnInclude As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents OfdReport As OpenFileDialog
    Friend WithEvents DgvReports As DataGridView
End Class
