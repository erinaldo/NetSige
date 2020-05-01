<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLog
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
        Me.DgvLog = New System.Windows.Forms.DataGridView()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.TsMenu = New System.Windows.Forms.ToolStrip()
        Me.BtnClean = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DgvLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvLog
        '
        Me.DgvLog.AllowUserToAddRows = False
        Me.DgvLog.AllowUserToDeleteRows = False
        Me.DgvLog.AllowUserToOrderColumns = True
        Me.DgvLog.AllowUserToResizeRows = False
        Me.DgvLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvLog.BackgroundColor = System.Drawing.Color.White
        Me.DgvLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvLog.Location = New System.Drawing.Point(0, 25)
        Me.DgvLog.MultiSelect = False
        Me.DgvLog.Name = "DgvLog"
        Me.DgvLog.ReadOnly = True
        Me.DgvLog.RowHeadersVisible = False
        Me.DgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvLog.Size = New System.Drawing.Size(707, 289)
        Me.DgvLog.TabIndex = 2
        '
        'BtnOK
        '
        Me.BtnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnOK.Location = New System.Drawing.Point(600, 324)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(95, 30)
        Me.BtnOK.TabIndex = 10
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'TsMenu
        '
        Me.TsMenu.BackColor = System.Drawing.SystemColors.Control
        Me.TsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnClean})
        Me.TsMenu.Location = New System.Drawing.Point(0, 0)
        Me.TsMenu.Name = "TsMenu"
        Me.TsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsMenu.Size = New System.Drawing.Size(707, 25)
        Me.TsMenu.TabIndex = 11
        Me.TsMenu.Text = "ToolStrip1"
        '
        'BtnClean
        '
        Me.BtnClean.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnClean.Image = Global.NetSige.My.Resources.Resources.Clean
        Me.BtnClean.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.Size = New System.Drawing.Size(23, 22)
        Me.BtnClean.Text = "Limpar Histórico"
        Me.BtnClean.ToolTipText = "Limpar Histórico"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 314)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 47)
        Me.Panel1.TabIndex = 12
        '
        'FrmLog
        '
        Me.AcceptButton = Me.BtnOK
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.BtnOK
        Me.ClientSize = New System.Drawing.Size(707, 361)
        Me.Controls.Add(Me.DgvLog)
        Me.Controls.Add(Me.TsMenu)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "FrmLog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Histórico"
        CType(Me.DgvLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvLog As DataGridView
    Friend WithEvents BtnOK As Button
    Friend WithEvents TsMenu As ToolStrip
    Friend WithEvents BtnClean As ToolStripButton
    Friend WithEvents Panel1 As Panel
End Class
