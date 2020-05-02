<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCostSharing
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCostSharing))
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TcCustomer = New System.Windows.Forms.TabControl()
        Me.TpMain = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbxState = New System.Windows.Forms.ComboBox()
        Me.TxtZipCode = New System.Windows.Forms.TextBox()
        Me.BtnZipCode = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.TxtDistrict = New System.Windows.Forms.TextBox()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.TxtComplement = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnDocument = New System.Windows.Forms.Button()
        Me.TxtDocument1 = New System.Windows.Forms.TextBox()
        Me.TxtDocument3 = New System.Windows.Forms.TextBox()
        Me.TxtDocument2 = New System.Windows.Forms.TextBox()
        Me.TxtBusinessName = New System.Windows.Forms.TextBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LblDocument3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblDocument2 = New System.Windows.Forms.Label()
        Me.LblDocument1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TpLocals = New System.Windows.Forms.TabPage()
        Me.DgvLocals = New System.Windows.Forms.DataGridView()
        Me.TsContact = New System.Windows.Forms.ToolStrip()
        Me.BtnIncludeLocal = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditLocal = New System.Windows.Forms.ToolStripButton()
        Me.BtnDeleteLocal = New System.Windows.Forms.ToolStripButton()
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
        Me.OfdPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.SfdPhoto = New System.Windows.Forms.SaveFileDialog()
        Me.CmsImage = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnChoseImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnDeleteImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExportImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TcCustomer.SuspendLayout()
        Me.TpMain.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpLocals.SuspendLayout()
        CType(Me.DgvLocals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsContact.SuspendLayout()
        Me.TpNote.SuspendLayout()
        Me.TsData.SuspendLayout()
        Me.TsMain.SuspendLayout()
        Me.CmsImage.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(380, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(95, 30)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "Fechar"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Enabled = False
        Me.BtnSave.Location = New System.Drawing.Point(279, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(95, 30)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Salvar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 436)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 44)
        Me.Panel1.TabIndex = 3
        '
        'TcCustomer
        '
        Me.TcCustomer.Controls.Add(Me.TpMain)
        Me.TcCustomer.Controls.Add(Me.TpLocals)
        Me.TcCustomer.Controls.Add(Me.TpNote)
        Me.TcCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcCustomer.Location = New System.Drawing.Point(0, 50)
        Me.TcCustomer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TcCustomer.Multiline = True
        Me.TcCustomer.Name = "TcCustomer"
        Me.TcCustomer.SelectedIndex = 0
        Me.TcCustomer.Size = New System.Drawing.Size(487, 386)
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
        Me.TpMain.Size = New System.Drawing.Size(479, 356)
        Me.TpMain.TabIndex = 0
        Me.TpMain.Text = "Principal"
        Me.TpMain.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.CbxState)
        Me.GroupBox2.Controls.Add(Me.TxtZipCode)
        Me.GroupBox2.Controls.Add(Me.BtnZipCode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtCity)
        Me.GroupBox2.Controls.Add(Me.TxtDistrict)
        Me.GroupBox2.Controls.Add(Me.TxtNumber)
        Me.GroupBox2.Controls.Add(Me.TxtComplement)
        Me.GroupBox2.Controls.Add(Me.TxtAddress)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 170)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço"
        '
        'CbxState
        '
        Me.CbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxState.FormattingEnabled = True
        Me.CbxState.Items.AddRange(New Object() {"", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.CbxState.Location = New System.Drawing.Point(407, 132)
        Me.CbxState.Name = "CbxState"
        Me.CbxState.Size = New System.Drawing.Size(50, 25)
        Me.CbxState.TabIndex = 14
        '
        'TxtZipCode
        '
        Me.TxtZipCode.Location = New System.Drawing.Point(6, 39)
        Me.TxtZipCode.MaxLength = 10
        Me.TxtZipCode.Name = "TxtZipCode"
        Me.TxtZipCode.Size = New System.Drawing.Size(73, 23)
        Me.TxtZipCode.TabIndex = 3
        '
        'BtnZipCode
        '
        Me.BtnZipCode.BackgroundImage = Global.NetSige.My.Resources.Resources.ZipCode
        Me.BtnZipCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnZipCode.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnZipCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnZipCode.Location = New System.Drawing.Point(78, 39)
        Me.BtnZipCode.Name = "BtnZipCode"
        Me.BtnZipCode.Size = New System.Drawing.Size(23, 23)
        Me.BtnZipCode.TabIndex = 4
        Me.BtnZipCode.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CEP"
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(205, 134)
        Me.TxtCity.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtCity.MaxLength = 100
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(196, 23)
        Me.TxtCity.TabIndex = 13
        '
        'TxtDistrict
        '
        Me.TxtDistrict.Location = New System.Drawing.Point(6, 134)
        Me.TxtDistrict.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtDistrict.MaxLength = 100
        Me.TxtDistrict.Name = "TxtDistrict"
        Me.TxtDistrict.Size = New System.Drawing.Size(193, 23)
        Me.TxtDistrict.TabIndex = 12
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(394, 39)
        Me.TxtNumber.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtNumber.MaxLength = 100
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(63, 23)
        Me.TxtNumber.TabIndex = 6
        '
        'TxtComplement
        '
        Me.TxtComplement.Location = New System.Drawing.Point(6, 85)
        Me.TxtComplement.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtComplement.MaxLength = 100
        Me.TxtComplement.Name = "TxtComplement"
        Me.TxtComplement.Size = New System.Drawing.Size(451, 23)
        Me.TxtComplement.TabIndex = 8
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(107, 39)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtAddress.MaxLength = 100
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(281, 23)
        Me.TxtAddress.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(406, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "UF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(202, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Cidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Número"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Complemento"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Bairro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(104, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Endereço"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.PbxLogo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnDocument)
        Me.GroupBox1.Controls.Add(Me.TxtDocument1)
        Me.GroupBox1.Controls.Add(Me.TxtDocument3)
        Me.GroupBox1.Controls.Add(Me.TxtDocument2)
        Me.GroupBox1.Controls.Add(Me.TxtBusinessName)
        Me.GroupBox1.Controls.Add(Me.TxtName)
        Me.GroupBox1.Controls.Add(Me.LblDocument3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblDocument2)
        Me.GroupBox1.Controls.Add(Me.LblDocument1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificação"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(45, 113)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "*"
        '
        'PbxLogo
        '
        Me.PbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbxLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxLogo.Location = New System.Drawing.Point(6, 18)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(167, 92)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxLogo.TabIndex = 15
        Me.PbxLogo.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(222, 18)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "*"
        '
        'BtnDocument
        '
        Me.BtnDocument.BackgroundImage = Global.NetSige.My.Resources.Resources.ZipCode
        Me.BtnDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnDocument.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.BtnDocument.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDocument.Location = New System.Drawing.Point(144, 133)
        Me.BtnDocument.Name = "BtnDocument"
        Me.BtnDocument.Size = New System.Drawing.Size(23, 23)
        Me.BtnDocument.TabIndex = 10
        Me.BtnDocument.UseVisualStyleBackColor = True
        '
        'TxtDocument1
        '
        Me.TxtDocument1.Location = New System.Drawing.Point(9, 133)
        Me.TxtDocument1.MaxLength = 20
        Me.TxtDocument1.Name = "TxtDocument1"
        Me.TxtDocument1.Size = New System.Drawing.Size(136, 23)
        Me.TxtDocument1.TabIndex = 9
        '
        'TxtDocument3
        '
        Me.TxtDocument3.Location = New System.Drawing.Point(329, 133)
        Me.TxtDocument3.MaxLength = 20
        Me.TxtDocument3.Name = "TxtDocument3"
        Me.TxtDocument3.Size = New System.Drawing.Size(128, 23)
        Me.TxtDocument3.TabIndex = 12
        '
        'TxtDocument2
        '
        Me.TxtDocument2.Location = New System.Drawing.Point(173, 133)
        Me.TxtDocument2.MaxLength = 20
        Me.TxtDocument2.Name = "TxtDocument2"
        Me.TxtDocument2.Size = New System.Drawing.Size(150, 23)
        Me.TxtDocument2.TabIndex = 11
        '
        'TxtBusinessName
        '
        Me.TxtBusinessName.Location = New System.Drawing.Point(182, 87)
        Me.TxtBusinessName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtBusinessName.MaxLength = 100
        Me.TxtBusinessName.Name = "TxtBusinessName"
        Me.TxtBusinessName.Size = New System.Drawing.Size(275, 23)
        Me.TxtBusinessName.TabIndex = 4
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(181, 38)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtName.MaxLength = 100
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(276, 23)
        Me.TxtName.TabIndex = 2
        '
        'LblDocument3
        '
        Me.LblDocument3.AutoSize = True
        Me.LblDocument3.Location = New System.Drawing.Point(326, 113)
        Me.LblDocument3.Name = "LblDocument3"
        Me.LblDocument3.Size = New System.Drawing.Size(102, 17)
        Me.LblDocument3.TabIndex = 8
        Me.LblDocument3.Text = "Insc. Municipal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(179, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fantasia"
        '
        'LblDocument2
        '
        Me.LblDocument2.AutoSize = True
        Me.LblDocument2.Location = New System.Drawing.Point(170, 113)
        Me.LblDocument2.Name = "LblDocument2"
        Me.LblDocument2.Size = New System.Drawing.Size(95, 17)
        Me.LblDocument2.TabIndex = 7
        Me.LblDocument2.Text = "Insc. Estadual"
        '
        'LblDocument1
        '
        Me.LblDocument1.AutoSize = True
        Me.LblDocument1.Location = New System.Drawing.Point(6, 113)
        Me.LblDocument1.Name = "LblDocument1"
        Me.LblDocument1.Size = New System.Drawing.Size(43, 17)
        Me.LblDocument1.TabIndex = 5
        Me.LblDocument1.Text = "CNPJ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'TpLocals
        '
        Me.TpLocals.Controls.Add(Me.DgvLocals)
        Me.TpLocals.Controls.Add(Me.TsContact)
        Me.TpLocals.Location = New System.Drawing.Point(4, 26)
        Me.TpLocals.Name = "TpLocals"
        Me.TpLocals.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLocals.Size = New System.Drawing.Size(479, 356)
        Me.TpLocals.TabIndex = 6
        Me.TpLocals.Text = "Locais de Entrega"
        Me.TpLocals.UseVisualStyleBackColor = True
        '
        'DgvLocals
        '
        Me.DgvLocals.AllowUserToAddRows = False
        Me.DgvLocals.AllowUserToDeleteRows = False
        Me.DgvLocals.AllowUserToOrderColumns = True
        Me.DgvLocals.AllowUserToResizeRows = False
        Me.DgvLocals.BackgroundColor = System.Drawing.Color.White
        Me.DgvLocals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvLocals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLocals.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvLocals.Location = New System.Drawing.Point(3, 28)
        Me.DgvLocals.MultiSelect = False
        Me.DgvLocals.Name = "DgvLocals"
        Me.DgvLocals.ReadOnly = True
        Me.DgvLocals.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvLocals.RowHeadersVisible = False
        Me.DgvLocals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvLocals.Size = New System.Drawing.Size(473, 325)
        Me.DgvLocals.TabIndex = 5
        '
        'TsContact
        '
        Me.TsContact.BackColor = System.Drawing.Color.White
        Me.TsContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsContact.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsContact.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnIncludeLocal, Me.BtnEditLocal, Me.BtnDeleteLocal})
        Me.TsContact.Location = New System.Drawing.Point(3, 3)
        Me.TsContact.Name = "TsContact"
        Me.TsContact.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsContact.Size = New System.Drawing.Size(473, 25)
        Me.TsContact.TabIndex = 4
        Me.TsContact.Text = "ToolStrip2"
        '
        'BtnIncludeLocal
        '
        Me.BtnIncludeLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnIncludeLocal.Image = Global.NetSige.My.Resources.Resources.IncludeSmall
        Me.BtnIncludeLocal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnIncludeLocal.Name = "BtnIncludeLocal"
        Me.BtnIncludeLocal.Size = New System.Drawing.Size(23, 22)
        Me.BtnIncludeLocal.Text = "Incluir"
        '
        'BtnEditLocal
        '
        Me.BtnEditLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditLocal.Image = Global.NetSige.My.Resources.Resources.EditSmall
        Me.BtnEditLocal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditLocal.Name = "BtnEditLocal"
        Me.BtnEditLocal.Size = New System.Drawing.Size(23, 22)
        Me.BtnEditLocal.Text = "Editar"
        Me.BtnEditLocal.ToolTipText = "Editar"
        '
        'BtnDeleteLocal
        '
        Me.BtnDeleteLocal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDeleteLocal.Image = Global.NetSige.My.Resources.Resources.DeleteSmall
        Me.BtnDeleteLocal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteLocal.Name = "BtnDeleteLocal"
        Me.BtnDeleteLocal.Size = New System.Drawing.Size(23, 22)
        Me.BtnDeleteLocal.Text = "Excluir"
        '
        'TpNote
        '
        Me.TpNote.Controls.Add(Me.TxtNote)
        Me.TpNote.Location = New System.Drawing.Point(4, 26)
        Me.TpNote.Name = "TpNote"
        Me.TpNote.Padding = New System.Windows.Forms.Padding(3)
        Me.TpNote.Size = New System.Drawing.Size(479, 356)
        Me.TpNote.TabIndex = 5
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
        Me.TxtNote.Size = New System.Drawing.Size(473, 350)
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
        Me.TsData.Size = New System.Drawing.Size(487, 25)
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
        Me.TsMain.Size = New System.Drawing.Size(487, 25)
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
        'OfdPhoto
        '
        Me.OfdPhoto.Filter = "Imagens|*.bmp;*.jpg;*.jpeg;*.png"
        Me.OfdPhoto.RestoreDirectory = True
        Me.OfdPhoto.Title = "Escolher Logotipo"
        '
        'SfdPhoto
        '
        Me.SfdPhoto.DefaultExt = "png"
        Me.SfdPhoto.Filter = "Arquivo .png|*.png"
        Me.SfdPhoto.Title = "Exportar Foto do Item"
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(33, 19)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(167, 19)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 17)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(42, 114)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 17)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.DarkRed
        Me.Label15.Location = New System.Drawing.Point(254, 114)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 17)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.DarkRed
        Me.Label16.Location = New System.Drawing.Point(423, 114)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 17)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "*"
        '
        'FrmCostSharing
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(487, 480)
        Me.Controls.Add(Me.TcCustomer)
        Me.Controls.Add(Me.TsData)
        Me.Controls.Add(Me.TsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCostSharing"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Centro de Custo"
        Me.Panel1.ResumeLayout(False)
        Me.TcCustomer.ResumeLayout(False)
        Me.TpMain.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpLocals.ResumeLayout(False)
        Me.TpLocals.PerformLayout()
        CType(Me.DgvLocals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsContact.ResumeLayout(False)
        Me.TsContact.PerformLayout()
        Me.TpNote.ResumeLayout(False)
        Me.TsData.ResumeLayout(False)
        Me.TsData.PerformLayout()
        Me.TsMain.ResumeLayout(False)
        Me.TsMain.PerformLayout()
        Me.CmsImage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TcCustomer As TabControl
    Friend WithEvents TpMain As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CbxState As ComboBox
    Friend WithEvents TxtZipCode As TextBox
    Friend WithEvents BtnZipCode As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents TxtDistrict As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnDocument As Button
    Friend WithEvents TxtDocument1 As TextBox
    Friend WithEvents TxtDocument3 As TextBox
    Friend WithEvents TxtDocument2 As TextBox
    Friend WithEvents TxtBusinessName As TextBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblDocument3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblDocument2 As Label
    Friend WithEvents LblDocument1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TpNote As TabPage
    Friend WithEvents TxtNote As RichTextBox
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
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents OfdPhoto As OpenFileDialog
    Friend WithEvents SfdPhoto As SaveFileDialog
    Friend WithEvents CmsImage As ContextMenuStrip
    Friend WithEvents BtnChoseImage As ToolStripMenuItem
    Friend WithEvents BtnDeleteImage As ToolStripMenuItem
    Friend WithEvents BtnExportImage As ToolStripMenuItem
    Friend WithEvents TpLocals As TabPage
    Friend WithEvents TsContact As ToolStrip
    Friend WithEvents BtnIncludeLocal As ToolStripButton
    Friend WithEvents BtnEditLocal As ToolStripButton
    Friend WithEvents BtnDeleteLocal As ToolStripButton
    Friend WithEvents DgvLocals As DataGridView
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents TxtComplement As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
End Class
