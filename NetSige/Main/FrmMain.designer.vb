<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TsBotMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.PbxBack = New System.Windows.Forms.PictureBox()
        Me.TabCtrlWindows = New System.Windows.Forms.TabControl()
        Me.TsRegistration = New System.Windows.Forms.ToolStrip()
        Me.BtnOrders = New System.Windows.Forms.ToolStripButton()
        Me.BtnQuotations = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPersons = New System.Windows.Forms.ToolStripButton()
        Me.BtnItems = New System.Windows.Forms.ToolStripSplitButton()
        Me.BtnGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUnit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnTables = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BtnCostSharing = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnPayments = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUsers = New System.Windows.Forms.ToolStripSplitButton()
        Me.PermissõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnLogout = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnReports = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BtnReportManager = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPanels = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TsBotMenu.SuspendLayout()
        CType(Me.PbxBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsRegistration.SuspendLayout()
        Me.SuspendLayout()
        '
        'TsBotMenu
        '
        Me.TsBotMenu.BackColor = System.Drawing.Color.Gainsboro
        Me.TsBotMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TsBotMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsBotMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2})
        Me.TsBotMenu.Location = New System.Drawing.Point(0, 463)
        Me.TsBotMenu.Name = "TsBotMenu"
        Me.TsBotMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsBotMenu.Size = New System.Drawing.Size(1275, 25)
        Me.TsBotMenu.TabIndex = 2
        Me.TsBotMenu.Text = "     "
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.NetSige.My.Resources.Resources.Preferences
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        '
        'PbxBack
        '
        Me.PbxBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxBack.Location = New System.Drawing.Point(0, 10)
        Me.PbxBack.Name = "PbxBack"
        Me.PbxBack.Size = New System.Drawing.Size(1275, 453)
        Me.PbxBack.TabIndex = 3
        Me.PbxBack.TabStop = False
        '
        'TabCtrlWindows
        '
        Me.TabCtrlWindows.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCtrlWindows.Location = New System.Drawing.Point(0, 68)
        Me.TabCtrlWindows.Name = "TabCtrlWindows"
        Me.TabCtrlWindows.SelectedIndex = 0
        Me.TabCtrlWindows.Size = New System.Drawing.Size(1275, 395)
        Me.TabCtrlWindows.TabIndex = 4
        '
        'TsRegistration
        '
        Me.TsRegistration.BackColor = System.Drawing.Color.White
        Me.TsRegistration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TsRegistration.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsRegistration.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsRegistration.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnOrders, Me.BtnQuotations, Me.ToolStripSeparator2, Me.BtnPersons, Me.BtnItems, Me.BtnTables, Me.BtnUsers, Me.BtnLogout, Me.ToolStripSeparator1, Me.BtnReports, Me.BtnPanels})
        Me.TsRegistration.Location = New System.Drawing.Point(0, 10)
        Me.TsRegistration.Name = "TsRegistration"
        Me.TsRegistration.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsRegistration.Size = New System.Drawing.Size(1275, 58)
        Me.TsRegistration.TabIndex = 5
        Me.TsRegistration.Text = "ToolStrip1"
        '
        'BtnOrders
        '
        Me.BtnOrders.AutoSize = False
        Me.BtnOrders.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrders.Image = Global.NetSige.My.Resources.Resources.Purchase_Order
        Me.BtnOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnOrders.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnOrders.Name = "BtnOrders"
        Me.BtnOrders.Size = New System.Drawing.Size(120, 55)
        Me.BtnOrders.Text = "Pedidos"
        Me.BtnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnQuotations
        '
        Me.BtnQuotations.AutoSize = False
        Me.BtnQuotations.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuotations.Image = Global.NetSige.My.Resources.Resources.Quotation
        Me.BtnQuotations.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnQuotations.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnQuotations.Name = "BtnQuotations"
        Me.BtnQuotations.Size = New System.Drawing.Size(120, 55)
        Me.BtnQuotations.Text = "Cotações"
        Me.BtnQuotations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 58)
        '
        'BtnPersons
        '
        Me.BtnPersons.AutoSize = False
        Me.BtnPersons.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPersons.Image = Global.NetSige.My.Resources.Resources.Person
        Me.BtnPersons.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnPersons.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPersons.Name = "BtnPersons"
        Me.BtnPersons.Size = New System.Drawing.Size(120, 55)
        Me.BtnPersons.Text = "Pessoas"
        Me.BtnPersons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnItems
        '
        Me.BtnItems.AutoSize = False
        Me.BtnItems.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnGroup, Me.BtnUnit})
        Me.BtnItems.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItems.Image = Global.NetSige.My.Resources.Resources.Item
        Me.BtnItems.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnItems.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnItems.Name = "BtnItems"
        Me.BtnItems.Size = New System.Drawing.Size(120, 55)
        Me.BtnItems.Text = "Itens"
        Me.BtnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnGroup
        '
        Me.BtnGroup.Image = Global.NetSige.My.Resources.Resources.ItemGroup
        Me.BtnGroup.Name = "BtnGroup"
        Me.BtnGroup.Size = New System.Drawing.Size(176, 22)
        Me.BtnGroup.Text = "Grupos de Item"
        '
        'BtnUnit
        '
        Me.BtnUnit.Image = Global.NetSige.My.Resources.Resources.ItemUnit
        Me.BtnUnit.Name = "BtnUnit"
        Me.BtnUnit.Size = New System.Drawing.Size(176, 22)
        Me.BtnUnit.Text = "Unidades"
        '
        'BtnTables
        '
        Me.BtnTables.AutoSize = False
        Me.BtnTables.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnCostSharing, Me.BtnPayments})
        Me.BtnTables.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTables.Image = Global.NetSige.My.Resources.Resources.Tables
        Me.BtnTables.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnTables.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnTables.Name = "BtnTables"
        Me.BtnTables.Size = New System.Drawing.Size(120, 55)
        Me.BtnTables.Text = "Tabelas"
        Me.BtnTables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnCostSharing
        '
        Me.BtnCostSharing.Image = Global.NetSige.My.Resources.Resources.CostSharing
        Me.BtnCostSharing.Name = "BtnCostSharing"
        Me.BtnCostSharing.Size = New System.Drawing.Size(216, 22)
        Me.BtnCostSharing.Text = "Centros de Custo"
        '
        'BtnPayments
        '
        Me.BtnPayments.Image = Global.NetSige.My.Resources.Resources.PaymentTerm
        Me.BtnPayments.Name = "BtnPayments"
        Me.BtnPayments.Size = New System.Drawing.Size(216, 22)
        Me.BtnPayments.Text = "Prazos de Pagamento"
        '
        'BtnUsers
        '
        Me.BtnUsers.AutoSize = False
        Me.BtnUsers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermissõesToolStripMenuItem})
        Me.BtnUsers.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsers.Image = Global.NetSige.My.Resources.Resources.Users
        Me.BtnUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnUsers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUsers.Name = "BtnUsers"
        Me.BtnUsers.Size = New System.Drawing.Size(120, 55)
        Me.BtnUsers.Text = "Usuários"
        Me.BtnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PermissõesToolStripMenuItem
        '
        Me.PermissõesToolStripMenuItem.Name = "PermissõesToolStripMenuItem"
        Me.PermissõesToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PermissõesToolStripMenuItem.Text = "Permissões"
        '
        'BtnLogout
        '
        Me.BtnLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnLogout.AutoSize = False
        Me.BtnLogout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Image = Global.NetSige.My.Resources.Resources.Logoff
        Me.BtnLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnLogout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(85, 55)
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 58)
        Me.ToolStripSeparator1.Visible = False
        '
        'BtnReports
        '
        Me.BtnReports.AutoSize = False
        Me.BtnReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnReportManager, Me.ToolStripSeparator3})
        Me.BtnReports.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReports.Image = Global.NetSige.My.Resources.Resources.Report
        Me.BtnReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnReports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReports.Name = "BtnReports"
        Me.BtnReports.Size = New System.Drawing.Size(90, 55)
        Me.BtnReports.Text = "Relatórios"
        Me.BtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnReportManager
        '
        Me.BtnReportManager.Name = "BtnReportManager"
        Me.BtnReportManager.Size = New System.Drawing.Size(210, 22)
        Me.BtnReportManager.Text = "Gerenciar Relatórios"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(207, 6)
        '
        'BtnPanels
        '
        Me.BtnPanels.AutoSize = False
        Me.BtnPanels.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPanels.Image = Global.NetSige.My.Resources.Resources.Panels
        Me.BtnPanels.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnPanels.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPanels.Name = "BtnPanels"
        Me.BtnPanels.Size = New System.Drawing.Size(90, 55)
        Me.BtnPanels.Text = "Paineis"
        Me.BtnPanels.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1275, 488)
        Me.Controls.Add(Me.TabCtrlWindows)
        Me.Controls.Add(Me.TsRegistration)
        Me.Controls.Add(Me.PbxBack)
        Me.Controls.Add(Me.TsBotMenu)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMain"
        Me.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Text = "Gerenciador de Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TsBotMenu.ResumeLayout(False)
        Me.TsBotMenu.PerformLayout()
        CType(Me.PbxBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsRegistration.ResumeLayout(False)
        Me.TsRegistration.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TsBotMenu As ToolStrip
    Friend WithEvents PbxBack As PictureBox
    Friend WithEvents TabCtrlWindows As TabControl
    Friend WithEvents TsRegistration As ToolStrip
    Friend WithEvents BtnQuotations As ToolStripButton
    Friend WithEvents BtnLogout As ToolStripButton
    Friend WithEvents BtnItems As ToolStripSplitButton
    Friend WithEvents BtnGroup As ToolStripMenuItem
    Friend WithEvents BtnUnit As ToolStripMenuItem
    Friend WithEvents BtnUsers As ToolStripSplitButton
    Friend WithEvents PermissõesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnTables As ToolStripDropDownButton
    Friend WithEvents BtnCostSharing As ToolStripMenuItem
    Friend WithEvents BtnPayments As ToolStripMenuItem
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents BtnOrders As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnPersons As ToolStripButton
    Friend WithEvents BtnReports As ToolStripDropDownButton
    Friend WithEvents BtnReportManager As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BtnPanels As ToolStripDropDownButton
End Class
