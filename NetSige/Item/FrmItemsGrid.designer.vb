<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmItemsGrid
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
        Me.TsMenu = New System.Windows.Forms.ToolStrip()
        Me.BtnInclude = New System.Windows.Forms.ToolStripButton()
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.BtnFilter = New System.Windows.Forms.ToolStripButton()
        Me.BtnClose = New System.Windows.Forms.ToolStripButton()
        Me.BtnDetails = New System.Windows.Forms.ToolStripButton()
        Me.SsInformation = New System.Windows.Forms.StatusStrip()
        Me.LblInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PgFilter = New System.Windows.Forms.PropertyGrid()
        Me.TsFilterTop = New System.Windows.Forms.ToolStrip()
        Me.BtnCloseFilter = New System.Windows.Forms.ToolStripButton()
        Me.LblFilter = New System.Windows.Forms.ToolStripLabel()
        Me.TsFilterBot = New System.Windows.Forms.ToolStrip()
        Me.BtnFilter2 = New System.Windows.Forms.ToolStripButton()
        Me.BtnClean = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TcDetails = New System.Windows.Forms.TabControl()
        Me.TpOrders = New System.Windows.Forms.TabPage()
        Me.DgvTransactions = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnCloseDetails2 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PbxPhoto = New System.Windows.Forms.PictureBox()
        Me.TsViewItems = New System.Windows.Forms.ToolStrip()
        Me.BtnCloseDetails = New System.Windows.Forms.ToolStripButton()
        Me.DgvData = New System.Windows.Forms.DataGridView()
        Me.TsMenu.SuspendLayout()
        Me.SsInformation.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TsFilterTop.SuspendLayout()
        Me.TsFilterBot.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TcDetails.SuspendLayout()
        Me.TpOrders.SuspendLayout()
        CType(Me.DgvTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PbxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsViewItems.SuspendLayout()
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TsMenu
        '
        Me.TsMenu.BackColor = System.Drawing.Color.White
        Me.TsMenu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnInclude, Me.BtnEdit, Me.BtnDelete, Me.BtnRefresh, Me.BtnFilter, Me.BtnClose, Me.BtnDetails})
        Me.TsMenu.Location = New System.Drawing.Point(0, 0)
        Me.TsMenu.Name = "TsMenu"
        Me.TsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsMenu.Size = New System.Drawing.Size(800, 39)
        Me.TsMenu.TabIndex = 0
        '
        'BtnInclude
        '
        Me.BtnInclude.Image = Global.NetSige.My.Resources.Resources.Include
        Me.BtnInclude.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnInclude.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnInclude.Name = "BtnInclude"
        Me.BtnInclude.Size = New System.Drawing.Size(81, 36)
        Me.BtnInclude.Text = "Incluir"
        Me.BtnInclude.ToolTipText = "Incluir (Insert)"
        '
        'BtnEdit
        '
        Me.BtnEdit.Image = Global.NetSige.My.Resources.Resources.Edit
        Me.BtnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(81, 36)
        Me.BtnEdit.Text = "Editar"
        Me.BtnEdit.ToolTipText = "Editar (Enter)"
        '
        'BtnDelete
        '
        Me.BtnDelete.Image = Global.NetSige.My.Resources.Resources.Delete
        Me.BtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(83, 36)
        Me.BtnDelete.Text = "Excluir"
        Me.BtnDelete.ToolTipText = "Excluir (Delete)"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = Global.NetSige.My.Resources.Resources.Refresh
        Me.BtnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(100, 36)
        Me.BtnRefresh.Text = "Atualizar"
        Me.BtnRefresh.ToolTipText = "Atualizar (A)"
        '
        'BtnFilter
        '
        Me.BtnFilter.CheckOnClick = True
        Me.BtnFilter.Image = Global.NetSige.My.Resources.Resources.Filter
        Me.BtnFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(74, 36)
        Me.BtnFilter.Text = "Filtro"
        Me.BtnFilter.ToolTipText = "Filtro (F)"
        '
        'BtnClose
        '
        Me.BtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnClose.Image = Global.NetSige.My.Resources.Resources.Close
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.BtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(36, 36)
        Me.BtnClose.Text = "Fechar"
        '
        'BtnDetails
        '
        Me.BtnDetails.CheckOnClick = True
        Me.BtnDetails.Image = Global.NetSige.My.Resources.Resources.View
        Me.BtnDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnDetails.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDetails.Name = "BtnDetails"
        Me.BtnDetails.Size = New System.Drawing.Size(100, 36)
        Me.BtnDetails.Text = "Detalhes"
        Me.BtnDetails.ToolTipText = "Detalhes (D)"
        '
        'SsInformation
        '
        Me.SsInformation.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SsInformation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblInfo, Me.LblStatus})
        Me.SsInformation.Location = New System.Drawing.Point(0, 478)
        Me.SsInformation.Name = "SsInformation"
        Me.SsInformation.Size = New System.Drawing.Size(800, 22)
        Me.SsInformation.SizingGrip = False
        Me.SsInformation.Stretch = False
        Me.SsInformation.TabIndex = 2
        Me.SsInformation.Text = "StatusStrip1"
        '
        'LblInfo
        '
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(0, 17)
        '
        'LblStatus
        '
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(36, 17)
        Me.LblStatus.Text = "       "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.PgFilter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TsFilterTop)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TsFilterBot)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 439)
        Me.SplitContainer1.SplitterDistance = 192
        Me.SplitContainer1.TabIndex = 4
        '
        'PgFilter
        '
        Me.PgFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PgFilter.HelpVisible = False
        Me.PgFilter.Location = New System.Drawing.Point(0, 25)
        Me.PgFilter.Name = "PgFilter"
        Me.PgFilter.PropertySort = System.Windows.Forms.PropertySort.NoSort
        Me.PgFilter.Size = New System.Drawing.Size(190, 379)
        Me.PgFilter.TabIndex = 0
        Me.PgFilter.ToolbarVisible = False
        '
        'TsFilterTop
        '
        Me.TsFilterTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsFilterTop.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnCloseFilter, Me.LblFilter})
        Me.TsFilterTop.Location = New System.Drawing.Point(0, 0)
        Me.TsFilterTop.Name = "TsFilterTop"
        Me.TsFilterTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsFilterTop.Size = New System.Drawing.Size(190, 25)
        Me.TsFilterTop.TabIndex = 1
        Me.TsFilterTop.Text = "ToolStrip1"
        '
        'BtnCloseFilter
        '
        Me.BtnCloseFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnCloseFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCloseFilter.Image = Global.NetSige.My.Resources.Resources.Close
        Me.BtnCloseFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCloseFilter.Name = "BtnCloseFilter"
        Me.BtnCloseFilter.Size = New System.Drawing.Size(23, 22)
        Me.BtnCloseFilter.Text = "Fechar"
        '
        'LblFilter
        '
        Me.LblFilter.BackColor = System.Drawing.SystemColors.Control
        Me.LblFilter.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFilter.Name = "LblFilter"
        Me.LblFilter.Size = New System.Drawing.Size(123, 22)
        Me.LblFilter.Text = "Parâmetros do Filtro"
        '
        'TsFilterBot
        '
        Me.TsFilterBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TsFilterBot.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsFilterBot.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnFilter2, Me.BtnClean})
        Me.TsFilterBot.Location = New System.Drawing.Point(0, 404)
        Me.TsFilterBot.Name = "TsFilterBot"
        Me.TsFilterBot.Size = New System.Drawing.Size(190, 33)
        Me.TsFilterBot.TabIndex = 2
        Me.TsFilterBot.Text = "ToolStrip1"
        '
        'BtnFilter2
        '
        Me.BtnFilter2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnFilter2.AutoSize = False
        Me.BtnFilter2.Image = Global.NetSige.My.Resources.Resources.FilterSmall
        Me.BtnFilter2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFilter2.Name = "BtnFilter2"
        Me.BtnFilter2.Size = New System.Drawing.Size(60, 30)
        Me.BtnFilter2.Text = "Filtrar"
        '
        'BtnClean
        '
        Me.BtnClean.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnClean.Image = Global.NetSige.My.Resources.Resources.Clean
        Me.BtnClean.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.Size = New System.Drawing.Size(64, 30)
        Me.BtnClean.Text = "Limpar"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TcDetails)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DgvData)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Size = New System.Drawing.Size(604, 439)
        Me.SplitContainer2.SplitterDistance = 200
        Me.SplitContainer2.TabIndex = 0
        '
        'TcDetails
        '
        Me.TcDetails.Controls.Add(Me.TpOrders)
        Me.TcDetails.Controls.Add(Me.TabPage2)
        Me.TcDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcDetails.Location = New System.Drawing.Point(0, 0)
        Me.TcDetails.Name = "TcDetails"
        Me.TcDetails.SelectedIndex = 0
        Me.TcDetails.Size = New System.Drawing.Size(198, 437)
        Me.TcDetails.TabIndex = 0
        '
        'TpOrders
        '
        Me.TpOrders.Controls.Add(Me.DgvTransactions)
        Me.TpOrders.Controls.Add(Me.ToolStrip1)
        Me.TpOrders.Location = New System.Drawing.Point(4, 26)
        Me.TpOrders.Name = "TpOrders"
        Me.TpOrders.Padding = New System.Windows.Forms.Padding(3)
        Me.TpOrders.Size = New System.Drawing.Size(190, 407)
        Me.TpOrders.TabIndex = 0
        Me.TpOrders.Text = "Pedidos"
        Me.TpOrders.UseVisualStyleBackColor = True
        '
        'DgvTransactions
        '
        Me.DgvTransactions.AllowUserToAddRows = False
        Me.DgvTransactions.AllowUserToDeleteRows = False
        Me.DgvTransactions.AllowUserToOrderColumns = True
        Me.DgvTransactions.AllowUserToResizeRows = False
        Me.DgvTransactions.BackgroundColor = System.Drawing.Color.White
        Me.DgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvTransactions.Location = New System.Drawing.Point(3, 28)
        Me.DgvTransactions.MultiSelect = False
        Me.DgvTransactions.Name = "DgvTransactions"
        Me.DgvTransactions.ReadOnly = True
        Me.DgvTransactions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvTransactions.RowHeadersVisible = False
        Me.DgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvTransactions.Size = New System.Drawing.Size(184, 376)
        Me.DgvTransactions.TabIndex = 22
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnCloseDetails2})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(184, 25)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'BtnCloseDetails2
        '
        Me.BtnCloseDetails2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCloseDetails2.Image = Global.NetSige.My.Resources.Resources.Close
        Me.BtnCloseDetails2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCloseDetails2.Name = "BtnCloseDetails2"
        Me.BtnCloseDetails2.Size = New System.Drawing.Size(23, 22)
        Me.BtnCloseDetails2.Text = "Fechar"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PbxPhoto)
        Me.TabPage2.Controls.Add(Me.TsViewItems)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(190, 407)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Foto"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PbxPhoto
        '
        Me.PbxPhoto.BackColor = System.Drawing.Color.Transparent
        Me.PbxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PbxPhoto.Cursor = System.Windows.Forms.Cursors.Default
        Me.PbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxPhoto.Location = New System.Drawing.Point(3, 28)
        Me.PbxPhoto.Name = "PbxPhoto"
        Me.PbxPhoto.Size = New System.Drawing.Size(184, 376)
        Me.PbxPhoto.TabIndex = 21
        Me.PbxPhoto.TabStop = False
        '
        'TsViewItems
        '
        Me.TsViewItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsViewItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnCloseDetails})
        Me.TsViewItems.Location = New System.Drawing.Point(3, 3)
        Me.TsViewItems.Name = "TsViewItems"
        Me.TsViewItems.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsViewItems.Size = New System.Drawing.Size(184, 25)
        Me.TsViewItems.TabIndex = 20
        Me.TsViewItems.Text = "ToolStrip2"
        '
        'BtnCloseDetails
        '
        Me.BtnCloseDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCloseDetails.Image = Global.NetSige.My.Resources.Resources.Close
        Me.BtnCloseDetails.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCloseDetails.Name = "BtnCloseDetails"
        Me.BtnCloseDetails.Size = New System.Drawing.Size(23, 22)
        Me.BtnCloseDetails.Text = "Fechar"
        '
        'DgvData
        '
        Me.DgvData.AllowUserToAddRows = False
        Me.DgvData.AllowUserToDeleteRows = False
        Me.DgvData.AllowUserToOrderColumns = True
        Me.DgvData.AllowUserToResizeRows = False
        Me.DgvData.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DgvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvData.Location = New System.Drawing.Point(0, 0)
        Me.DgvData.MultiSelect = False
        Me.DgvData.Name = "DgvData"
        Me.DgvData.ReadOnly = True
        Me.DgvData.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvData.RowHeadersVisible = False
        Me.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvData.Size = New System.Drawing.Size(398, 437)
        Me.DgvData.TabIndex = 3
        '
        'FrmItemsGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TsMenu)
        Me.Controls.Add(Me.SsInformation)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmItemsGrid"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TsMenu.ResumeLayout(False)
        Me.TsMenu.PerformLayout()
        Me.SsInformation.ResumeLayout(False)
        Me.SsInformation.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TsFilterTop.ResumeLayout(False)
        Me.TsFilterTop.PerformLayout()
        Me.TsFilterBot.ResumeLayout(False)
        Me.TsFilterBot.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TcDetails.ResumeLayout(False)
        Me.TpOrders.ResumeLayout(False)
        Me.TpOrders.PerformLayout()
        CType(Me.DgvTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PbxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsViewItems.ResumeLayout(False)
        Me.TsViewItems.PerformLayout()
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TsMenu As ToolStrip
    Friend WithEvents BtnInclude As ToolStripButton
    Friend WithEvents BtnEdit As ToolStripButton
    Friend WithEvents BtnDelete As ToolStripButton
    Friend WithEvents BtnRefresh As ToolStripButton
    Friend WithEvents BtnClose As ToolStripButton
    Friend WithEvents BtnFilter As ToolStripButton
    Friend WithEvents SsInformation As StatusStrip
    Friend WithEvents LblInfo As ToolStripStatusLabel
    Friend WithEvents FffffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblStatus As ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PgFilter As PropertyGrid
    Friend WithEvents TsFilterTop As ToolStrip
    Friend WithEvents BtnCloseFilter As ToolStripButton
    Friend WithEvents LblFilter As ToolStripLabel
    Friend WithEvents TsFilterBot As ToolStrip
    Friend WithEvents BtnFilter2 As ToolStripButton
    Friend WithEvents BtnClean As ToolStripButton
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents DgvData As DataGridView
    Friend WithEvents BtnDetails As ToolStripButton
    Friend WithEvents TcDetails As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PbxPhoto As PictureBox
    Friend WithEvents TsViewItems As ToolStrip
    Friend WithEvents BtnCloseDetails As ToolStripButton
    Friend WithEvents TpOrders As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnCloseDetails2 As ToolStripButton
    Friend WithEvents DgvTransactions As DataGridView
End Class
