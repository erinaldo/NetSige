<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItem
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItem))
        Me.TcCustomer = New System.Windows.Forms.TabControl()
        Me.TpMain = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtInternalCode = New System.Windows.Forms.TextBox()
        Me.TxtManufacturerCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtManufacturer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QtbItemGroup = New ControlLibrary.QueriedBox()
        Me.PbxPhoto = New System.Windows.Forms.PictureBox()
        Me.QtbItemUnit = New ControlLibrary.QueriedBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TpNote = New System.Windows.Forms.TabPage()
        Me.TxtNote = New System.Windows.Forms.RichTextBox()
        Me.TsData = New System.Windows.Forms.ToolStrip()
        Me.LblID = New System.Windows.Forms.ToolStripLabel()
        Me.LblIDValue = New System.Windows.Forms.ToolStripLabel()
        Me.LblStatus = New System.Windows.Forms.ToolStripLabel()
        Me.BtnStatusValue = New System.Windows.Forms.ToolStripButton()
        Me.LblCreationDate = New System.Windows.Forms.ToolStripLabel()
        Me.LblCreationDateValue = New System.Windows.Forms.ToolStripLabel()
        Me.TsMain = New System.Windows.Forms.ToolStrip()
        Me.BtnInclude = New System.Windows.Forms.ToolStripButton()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.BtnFirst = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrevious = New System.Windows.Forms.ToolStripButton()
        Me.BtnNext = New System.Windows.Forms.ToolStripButton()
        Me.BtnLast = New System.Windows.Forms.ToolStripButton()
        Me.BtnAttach = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BtnHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.OfdPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.CmsImage = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnChoseImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnDeleteImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExportImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.SfdPhoto = New System.Windows.Forms.SaveFileDialog()
        Me.TcCustomer.SuspendLayout()
        Me.TpMain.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PbxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpNote.SuspendLayout()
        Me.TsData.SuspendLayout()
        Me.TsMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.CmsImage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TcCustomer
        '
        Me.TcCustomer.Controls.Add(Me.TpMain)
        Me.TcCustomer.Controls.Add(Me.TpNote)
        Me.TcCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcCustomer.Location = New System.Drawing.Point(0, 50)
        Me.TcCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TcCustomer.Multiline = True
        Me.TcCustomer.Name = "TcCustomer"
        Me.TcCustomer.SelectedIndex = 0
        Me.TcCustomer.Size = New System.Drawing.Size(465, 239)
        Me.TcCustomer.TabIndex = 2
        '
        'TpMain
        '
        Me.TpMain.Controls.Add(Me.GroupBox2)
        Me.TpMain.Controls.Add(Me.GroupBox1)
        Me.TpMain.Location = New System.Drawing.Point(4, 26)
        Me.TpMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TpMain.Name = "TpMain"
        Me.TpMain.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TpMain.Size = New System.Drawing.Size(457, 209)
        Me.TpMain.TabIndex = 0
        Me.TpMain.Text = "Principal"
        Me.TpMain.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtInternalCode)
        Me.GroupBox2.Controls.Add(Me.TxtManufacturerCode)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtManufacturer)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 70)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Catalogação"
        '
        'TxtInternalCode
        '
        Me.TxtInternalCode.Location = New System.Drawing.Point(9, 39)
        Me.TxtInternalCode.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtInternalCode.MaxLength = 100
        Me.TxtInternalCode.Name = "TxtInternalCode"
        Me.TxtInternalCode.Size = New System.Drawing.Size(123, 23)
        Me.TxtInternalCode.TabIndex = 3
        '
        'TxtManufacturerCode
        '
        Me.TxtManufacturerCode.Location = New System.Drawing.Point(316, 39)
        Me.TxtManufacturerCode.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtManufacturerCode.MaxLength = 100
        Me.TxtManufacturerCode.Name = "TxtManufacturerCode"
        Me.TxtManufacturerCode.Size = New System.Drawing.Size(123, 23)
        Me.TxtManufacturerCode.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Cod.  Interno"
        '
        'TxtManufacturer
        '
        Me.TxtManufacturer.Location = New System.Drawing.Point(138, 39)
        Me.TxtManufacturer.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtManufacturer.MaxLength = 100
        Me.TxtManufacturer.Name = "TxtManufacturer"
        Me.TxtManufacturer.Size = New System.Drawing.Size(172, 23)
        Me.TxtManufacturer.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Cod. Fabricante"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(135, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Fabricante"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.QtbItemGroup)
        Me.GroupBox1.Controls.Add(Me.PbxPhoto)
        Me.GroupBox1.Controls.Add(Me.QtbItemUnit)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificação"
        '
        'QtbItemGroup
        '
        Me.QtbItemGroup.CharactersToQuery = 1
        Me.QtbItemGroup.ConnectionString = Nothing
        Me.QtbItemGroup.DbProvider = Nothing
        Me.QtbItemGroup.DecimalOnly = False
        Me.QtbItemGroup.DecimalPlaces = 2
        Me.QtbItemGroup.DropDownAutoStretchRight = False
        Me.QtbItemGroup.DropDownStretchLeft = 95
        Me.QtbItemGroup.FieldHeader = "Grupo"
        Me.QtbItemGroup.JoinField = Nothing
        Me.QtbItemGroup.JoinPKField = Nothing
        Me.QtbItemGroup.JoinTable = Nothing
        Me.QtbItemGroup.Location = New System.Drawing.Point(202, 91)
        Me.QtbItemGroup.MainField = "NAME"
        Me.QtbItemGroup.MainPKField = "ID"
        Me.QtbItemGroup.MainTable = "ITEMGROUP"
        Me.QtbItemGroup.Name = "QtbItemGroup"
        Me.QtbItemGroup.Size = New System.Drawing.Size(237, 23)
        Me.QtbItemGroup.TabIndex = 8
        '
        'PbxPhoto
        '
        Me.PbxPhoto.BackColor = System.Drawing.Color.Transparent
        Me.PbxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbxPhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxPhoto.Location = New System.Drawing.Point(6, 22)
        Me.PbxPhoto.Name = "PbxPhoto"
        Me.PbxPhoto.Size = New System.Drawing.Size(92, 92)
        Me.PbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxPhoto.TabIndex = 14
        Me.PbxPhoto.TabStop = False
        '
        'QtbItemUnit
        '
        Me.QtbItemUnit.CharactersToQuery = 1
        Me.QtbItemUnit.ConnectionString = Nothing
        Me.QtbItemUnit.DbProvider = Nothing
        Me.QtbItemUnit.DecimalOnly = False
        Me.QtbItemUnit.DecimalPlaces = 2
        Me.QtbItemUnit.DropDownAutoStretchRight = False
        Me.QtbItemUnit.DropDownStretchRight = 243
        Me.QtbItemUnit.FieldHeader = "Unidade"
        Me.QtbItemUnit.JoinField = Nothing
        Me.QtbItemUnit.JoinPKField = Nothing
        Me.QtbItemUnit.JoinTable = Nothing
        Me.QtbItemUnit.Location = New System.Drawing.Point(107, 91)
        Me.QtbItemUnit.MainField = "INITIALS"
        Me.QtbItemUnit.MainPKField = "ID"
        Me.QtbItemUnit.MainTable = "ITEMUNIT"
        Me.QtbItemUnit.Name = "QtbItemUnit"
        Me.QtbItemUnit.Size = New System.Drawing.Size(89, 23)
        Me.QtbItemUnit.TabIndex = 7
        Me.QtbItemUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(299, 71)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(161, 71)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(147, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "*"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(107, 42)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtName.MaxLength = 200
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(332, 23)
        Me.TxtName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Grupo de Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(104, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Unidade"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(104, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'TpNote
        '
        Me.TpNote.Controls.Add(Me.TxtNote)
        Me.TpNote.Location = New System.Drawing.Point(4, 26)
        Me.TpNote.Name = "TpNote"
        Me.TpNote.Padding = New System.Windows.Forms.Padding(3)
        Me.TpNote.Size = New System.Drawing.Size(457, 209)
        Me.TpNote.TabIndex = 6
        Me.TpNote.Text = "Informações Adicionais"
        Me.TpNote.UseVisualStyleBackColor = True
        '
        'TxtNote
        '
        Me.TxtNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtNote.Location = New System.Drawing.Point(3, 3)
        Me.TxtNote.MaxLength = 1000000
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(451, 203)
        Me.TxtNote.TabIndex = 2
        Me.TxtNote.Text = ""
        '
        'TsData
        '
        Me.TsData.BackColor = System.Drawing.Color.White
        Me.TsData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblID, Me.LblIDValue, Me.LblStatus, Me.BtnStatusValue, Me.LblCreationDate, Me.LblCreationDateValue})
        Me.TsData.Location = New System.Drawing.Point(0, 25)
        Me.TsData.Name = "TsData"
        Me.TsData.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsData.Size = New System.Drawing.Size(465, 25)
        Me.TsData.TabIndex = 1
        Me.TsData.Text = "ToolStrip1"
        '
        'LblID
        '
        Me.LblID.BackColor = System.Drawing.Color.White
        Me.LblID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(25, 22)
        Me.LblID.Text = "ID:"
        '
        'LblIDValue
        '
        Me.LblIDValue.BackColor = System.Drawing.Color.White
        Me.LblIDValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIDValue.Name = "LblIDValue"
        Me.LblIDValue.Size = New System.Drawing.Size(32, 22)
        Me.LblIDValue.Text = "      "
        '
        'LblStatus
        '
        Me.LblStatus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatus.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(50, 22)
        Me.LblStatus.Text = "Status:"
        '
        'BtnStatusValue
        '
        Me.BtnStatusValue.AutoToolTip = False
        Me.BtnStatusValue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnStatusValue.ForeColor = System.Drawing.Color.DarkBlue
        Me.BtnStatusValue.Image = CType(resources.GetObject("BtnStatusValue.Image"), System.Drawing.Image)
        Me.BtnStatusValue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStatusValue.Name = "BtnStatusValue"
        Me.BtnStatusValue.Size = New System.Drawing.Size(44, 22)
        Me.BtnStatusValue.Text = "        "
        '
        'LblCreationDate
        '
        Me.LblCreationDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCreationDate.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.LblCreationDate.Name = "LblCreationDate"
        Me.LblCreationDate.Size = New System.Drawing.Size(43, 22)
        Me.LblCreationDate.Text = "Data:"
        '
        'LblCreationDateValue
        '
        Me.LblCreationDateValue.BackColor = System.Drawing.Color.White
        Me.LblCreationDateValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCreationDateValue.Name = "LblCreationDateValue"
        Me.LblCreationDateValue.Size = New System.Drawing.Size(32, 22)
        Me.LblCreationDateValue.Text = "      "
        '
        'TsMain
        '
        Me.TsMain.BackColor = System.Drawing.Color.White
        Me.TsMain.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnInclude, Me.BtnDelete, Me.BtnFirst, Me.BtnPrevious, Me.BtnNext, Me.BtnLast, Me.BtnAttach})
        Me.TsMain.Location = New System.Drawing.Point(0, 0)
        Me.TsMain.Name = "TsMain"
        Me.TsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsMain.Size = New System.Drawing.Size(465, 25)
        Me.TsMain.TabIndex = 0
        Me.TsMain.Text = "ToolStrip2"
        '
        'BtnInclude
        '
        Me.BtnInclude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnInclude.Image = Global.NetSige.My.Resources.Resources.IncludeSmall
        Me.BtnInclude.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnInclude.Name = "BtnInclude"
        Me.BtnInclude.Size = New System.Drawing.Size(23, 22)
        Me.BtnInclude.Text = "Incluir"
        '
        'BtnDelete
        '
        Me.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDelete.Image = Global.NetSige.My.Resources.Resources.DeleteSmall
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(0, 1, 10, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(23, 22)
        Me.BtnDelete.Text = "Excluir"
        '
        'BtnFirst
        '
        Me.BtnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFirst.Image = Global.NetSige.My.Resources.Resources.NavFirst
        Me.BtnFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(23, 22)
        Me.BtnFirst.Text = "Primeiro"
        '
        'BtnPrevious
        '
        Me.BtnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrevious.Image = Global.NetSige.My.Resources.Resources.NavPrevious
        Me.BtnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrevious.Text = "Voltar"
        '
        'BtnNext
        '
        Me.BtnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNext.Image = Global.NetSige.My.Resources.Resources.NavNext
        Me.BtnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(23, 22)
        Me.BtnNext.Text = "Avançar"
        '
        'BtnLast
        '
        Me.BtnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnLast.Image = Global.NetSige.My.Resources.Resources.NavLast
        Me.BtnLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(23, 22)
        Me.BtnLast.Text = "Último"
        '
        'BtnAttach
        '
        Me.BtnAttach.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnAttach.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnAttach.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnHistory})
        Me.BtnAttach.Image = Global.NetSige.My.Resources.Resources.Attach
        Me.BtnAttach.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAttach.Name = "BtnAttach"
        Me.BtnAttach.Size = New System.Drawing.Size(29, 22)
        Me.BtnAttach.Text = "Histórico"
        '
        'BtnHistory
        '
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(131, 22)
        Me.BtnHistory.Text = "Histórico"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 289)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 44)
        Me.Panel1.TabIndex = 3
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(257, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(95, 30)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Salvar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(358, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(95, 30)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Fechar"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'OfdPhoto
        '
        Me.OfdPhoto.Filter = "Imagens|*.bmp;*.jpg;*.jpeg;*.png"
        Me.OfdPhoto.RestoreDirectory = True
        Me.OfdPhoto.Title = "Escolha a foto do item"
        '
        'CmsImage
        '
        Me.CmsImage.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnChoseImage, Me.BtnDeleteImage, Me.BtnExportImage})
        Me.CmsImage.Name = "CmsImage"
        Me.CmsImage.Size = New System.Drawing.Size(122, 70)
        '
        'BtnChoseImage
        '
        Me.BtnChoseImage.Name = "BtnChoseImage"
        Me.BtnChoseImage.Size = New System.Drawing.Size(121, 22)
        Me.BtnChoseImage.Text = "Escolher"
        '
        'BtnDeleteImage
        '
        Me.BtnDeleteImage.Name = "BtnDeleteImage"
        Me.BtnDeleteImage.Size = New System.Drawing.Size(121, 22)
        Me.BtnDeleteImage.Text = "Remover"
        '
        'BtnExportImage
        '
        Me.BtnExportImage.Name = "BtnExportImage"
        Me.BtnExportImage.Size = New System.Drawing.Size(121, 22)
        Me.BtnExportImage.Text = "Exportar"
        '
        'SfdPhoto
        '
        Me.SfdPhoto.DefaultExt = "png"
        Me.SfdPhoto.Filter = "Arquivo .png|*.png"
        Me.SfdPhoto.Title = "Exportar Foto do Item"
        '
        'FrmItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(465, 333)
        Me.Controls.Add(Me.TcCustomer)
        Me.Controls.Add(Me.TsData)
        Me.Controls.Add(Me.TsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Item"
        Me.TcCustomer.ResumeLayout(False)
        Me.TpMain.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PbxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpNote.ResumeLayout(False)
        Me.TsData.ResumeLayout(False)
        Me.TsData.PerformLayout()
        Me.TsMain.ResumeLayout(False)
        Me.TsMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.CmsImage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TcCustomer As TabControl
    Friend WithEvents TpMain As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtManufacturerCode As TextBox
    Friend WithEvents TxtManufacturer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PbxPhoto As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TsData As ToolStrip
    Friend WithEvents LblID As ToolStripLabel
    Friend WithEvents LblIDValue As ToolStripLabel
    Friend WithEvents LblStatus As ToolStripLabel
    Friend WithEvents BtnStatusValue As ToolStripButton
    Friend WithEvents LblCreationDate As ToolStripLabel
    Friend WithEvents LblCreationDateValue As ToolStripLabel
    Friend WithEvents TsMain As ToolStrip
    Friend WithEvents BtnInclude As ToolStripButton
    Friend WithEvents BtnDelete As ToolStripButton
    Friend WithEvents BtnFirst As ToolStripButton
    Friend WithEvents BtnPrevious As ToolStripButton
    Friend WithEvents BtnNext As ToolStripButton
    Friend WithEvents BtnLast As ToolStripButton
    Friend WithEvents BtnAttach As ToolStripDropDownButton
    Friend WithEvents BtnHistory As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents TxtInternalCode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TpNote As TabPage
    Friend WithEvents TxtNote As RichTextBox
    Friend WithEvents QtbItemGroup As ControlLibrary.QueriedBox
    Friend WithEvents QtbItemUnit As ControlLibrary.QueriedBox
    Friend WithEvents OfdPhoto As OpenFileDialog
    Friend WithEvents CmsImage As ContextMenuStrip
    Friend WithEvents BtnChoseImage As ToolStripMenuItem
    Friend WithEvents BtnDeleteImage As ToolStripMenuItem
    Friend WithEvents BtnExportImage As ToolStripMenuItem
    Friend WithEvents SfdPhoto As SaveFileDialog
End Class
