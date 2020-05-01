<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPerson
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPerson))
        Me.TcPerson = New System.Windows.Forms.TabControl()
        Me.TpMain = New System.Windows.Forms.TabPage()
        Me.CbxIsCarrier = New System.Windows.Forms.CheckBox()
        Me.CbxIsCustomer = New System.Windows.Forms.CheckBox()
        Me.CbxIsProvider = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtComplement = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbxState = New System.Windows.Forms.ComboBox()
        Me.TxtZipCode = New System.Windows.Forms.TextBox()
        Me.BtnZipCode = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.TxtDistrict = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RbEntityPJ = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblDocument1Star = New System.Windows.Forms.Label()
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
        Me.RbEntityPF = New System.Windows.Forms.RadioButton()
        Me.TpContacts = New System.Windows.Forms.TabPage()
        Me.DgvContacts = New System.Windows.Forms.DataGridView()
        Me.TsContact = New System.Windows.Forms.ToolStrip()
        Me.BtnIncludeContact = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditContact = New System.Windows.Forms.ToolStripButton()
        Me.BtnDeleteContact = New System.Windows.Forms.ToolStripButton()
        Me.TpTransactions = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.TpNote = New System.Windows.Forms.TabPage()
        Me.TxtNote = New System.Windows.Forms.RichTextBox()
        Me.CmsDefaultContact = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BtnDefaultContact = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
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
        Me.TcPerson.SuspendLayout()
        Me.TpMain.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TpContacts.SuspendLayout()
        CType(Me.DgvContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsContact.SuspendLayout()
        Me.TpTransactions.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TpNote.SuspendLayout()
        Me.CmsDefaultContact.SuspendLayout()
        Me.TsData.SuspendLayout()
        Me.TsMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TcPerson
        '
        Me.TcPerson.Controls.Add(Me.TpMain)
        Me.TcPerson.Controls.Add(Me.TpContacts)
        Me.TcPerson.Controls.Add(Me.TpTransactions)
        Me.TcPerson.Controls.Add(Me.TpNote)
        Me.TcPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcPerson.Location = New System.Drawing.Point(0, 50)
        Me.TcPerson.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TcPerson.Multiline = True
        Me.TcPerson.Name = "TcPerson"
        Me.TcPerson.SelectedIndex = 0
        Me.TcPerson.Size = New System.Drawing.Size(483, 390)
        Me.TcPerson.TabIndex = 2
        '
        'TpMain
        '
        Me.TpMain.Controls.Add(Me.CbxIsCarrier)
        Me.TpMain.Controls.Add(Me.CbxIsCustomer)
        Me.TpMain.Controls.Add(Me.CbxIsProvider)
        Me.TpMain.Controls.Add(Me.GroupBox2)
        Me.TpMain.Controls.Add(Me.RbEntityPJ)
        Me.TpMain.Controls.Add(Me.GroupBox1)
        Me.TpMain.Controls.Add(Me.RbEntityPF)
        Me.TpMain.Location = New System.Drawing.Point(4, 26)
        Me.TpMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TpMain.Name = "TpMain"
        Me.TpMain.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TpMain.Size = New System.Drawing.Size(475, 360)
        Me.TpMain.TabIndex = 0
        Me.TpMain.Text = "Principal"
        Me.TpMain.UseVisualStyleBackColor = True
        '
        'CbxIsCarrier
        '
        Me.CbxIsCarrier.AutoSize = True
        Me.CbxIsCarrier.Location = New System.Drawing.Point(191, 7)
        Me.CbxIsCarrier.Name = "CbxIsCarrier"
        Me.CbxIsCarrier.Size = New System.Drawing.Size(125, 21)
        Me.CbxIsCarrier.TabIndex = 4
        Me.CbxIsCarrier.Text = "Transportadora"
        Me.CbxIsCarrier.UseVisualStyleBackColor = True
        '
        'CbxIsCustomer
        '
        Me.CbxIsCustomer.AutoSize = True
        Me.CbxIsCustomer.Location = New System.Drawing.Point(112, 7)
        Me.CbxIsCustomer.Name = "CbxIsCustomer"
        Me.CbxIsCustomer.Size = New System.Drawing.Size(73, 21)
        Me.CbxIsCustomer.TabIndex = 4
        Me.CbxIsCustomer.Text = "Cliente"
        Me.CbxIsCustomer.UseVisualStyleBackColor = True
        '
        'CbxIsProvider
        '
        Me.CbxIsProvider.AutoSize = True
        Me.CbxIsProvider.Location = New System.Drawing.Point(6, 7)
        Me.CbxIsProvider.Name = "CbxIsProvider"
        Me.CbxIsProvider.Size = New System.Drawing.Size(100, 21)
        Me.CbxIsProvider.TabIndex = 4
        Me.CbxIsProvider.Text = "Fornecedor"
        Me.CbxIsProvider.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtComplement)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtNumber)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.CbxState)
        Me.GroupBox2.Controls.Add(Me.TxtZipCode)
        Me.GroupBox2.Controls.Add(Me.BtnZipCode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtCity)
        Me.GroupBox2.Controls.Add(Me.TxtDistrict)
        Me.GroupBox2.Controls.Add(Me.TxtAddress)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 170)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço"
        '
        'TxtComplement
        '
        Me.TxtComplement.Location = New System.Drawing.Point(6, 89)
        Me.TxtComplement.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtComplement.MaxLength = 100
        Me.TxtComplement.Name = "TxtComplement"
        Me.TxtComplement.Size = New System.Drawing.Size(448, 23)
        Me.TxtComplement.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Complemento"
        '
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(391, 39)
        Me.TxtNumber.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtNumber.MaxLength = 100
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.Size = New System.Drawing.Size(63, 23)
        Me.TxtNumber.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Número"
        '
        'CbxState
        '
        Me.CbxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxState.FormattingEnabled = True
        Me.CbxState.Items.AddRange(New Object() {"", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.CbxState.Location = New System.Drawing.Point(404, 136)
        Me.CbxState.Name = "CbxState"
        Me.CbxState.Size = New System.Drawing.Size(50, 25)
        Me.CbxState.TabIndex = 10
        '
        'TxtZipCode
        '
        Me.TxtZipCode.Location = New System.Drawing.Point(6, 39)
        Me.TxtZipCode.MaxLength = 10
        Me.TxtZipCode.Name = "TxtZipCode"
        Me.TxtZipCode.Size = New System.Drawing.Size(73, 23)
        Me.TxtZipCode.TabIndex = 2
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
        Me.BtnZipCode.TabIndex = 3
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
        Me.TxtCity.Location = New System.Drawing.Point(205, 138)
        Me.TxtCity.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtCity.MaxLength = 100
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(193, 23)
        Me.TxtCity.TabIndex = 9
        '
        'TxtDistrict
        '
        Me.TxtDistrict.Location = New System.Drawing.Point(6, 138)
        Me.TxtDistrict.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtDistrict.MaxLength = 100
        Me.TxtDistrict.Name = "TxtDistrict"
        Me.TxtDistrict.Size = New System.Drawing.Size(193, 23)
        Me.TxtDistrict.TabIndex = 8
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(107, 39)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtAddress.MaxLength = 100
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(278, 23)
        Me.TxtAddress.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(401, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(22, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "UF"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(202, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Cidade"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 5
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
        'RbEntityPJ
        '
        Me.RbEntityPJ.AutoSize = True
        Me.RbEntityPJ.Checked = True
        Me.RbEntityPJ.Location = New System.Drawing.Point(120, 28)
        Me.RbEntityPJ.Name = "RbEntityPJ"
        Me.RbEntityPJ.Size = New System.Drawing.Size(124, 21)
        Me.RbEntityPJ.TabIndex = 1
        Me.RbEntityPJ.TabStop = True
        Me.RbEntityPJ.Text = "Pessoa Jurídica"
        Me.RbEntityPJ.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblDocument1Star)
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
        Me.GroupBox1.Location = New System.Drawing.Point(6, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificação"
        '
        'LblDocument1Star
        '
        Me.LblDocument1Star.AutoSize = True
        Me.LblDocument1Star.ForeColor = System.Drawing.Color.DarkRed
        Me.LblDocument1Star.Location = New System.Drawing.Point(41, 68)
        Me.LblDocument1Star.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.LblDocument1Star.Name = "LblDocument1Star"
        Me.LblDocument1Star.Size = New System.Drawing.Size(14, 17)
        Me.LblDocument1Star.TabIndex = 6
        Me.LblDocument1Star.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(46, 19)
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
        Me.BtnDocument.Location = New System.Drawing.Point(141, 88)
        Me.BtnDocument.Name = "BtnDocument"
        Me.BtnDocument.Size = New System.Drawing.Size(23, 23)
        Me.BtnDocument.TabIndex = 10
        Me.BtnDocument.UseVisualStyleBackColor = True
        '
        'TxtDocument1
        '
        Me.TxtDocument1.Location = New System.Drawing.Point(6, 88)
        Me.TxtDocument1.MaxLength = 20
        Me.TxtDocument1.Name = "TxtDocument1"
        Me.TxtDocument1.Size = New System.Drawing.Size(136, 23)
        Me.TxtDocument1.TabIndex = 9
        '
        'TxtDocument3
        '
        Me.TxtDocument3.Location = New System.Drawing.Point(326, 88)
        Me.TxtDocument3.MaxLength = 20
        Me.TxtDocument3.Name = "TxtDocument3"
        Me.TxtDocument3.Size = New System.Drawing.Size(128, 23)
        Me.TxtDocument3.TabIndex = 12
        '
        'TxtDocument2
        '
        Me.TxtDocument2.Location = New System.Drawing.Point(170, 88)
        Me.TxtDocument2.MaxLength = 20
        Me.TxtDocument2.Name = "TxtDocument2"
        Me.TxtDocument2.Size = New System.Drawing.Size(150, 23)
        Me.TxtDocument2.TabIndex = 11
        '
        'TxtBusinessName
        '
        Me.TxtBusinessName.Location = New System.Drawing.Point(287, 39)
        Me.TxtBusinessName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtBusinessName.MaxLength = 100
        Me.TxtBusinessName.Name = "TxtBusinessName"
        Me.TxtBusinessName.Size = New System.Drawing.Size(167, 23)
        Me.TxtBusinessName.TabIndex = 4
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(5, 39)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtName.MaxLength = 100
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(276, 23)
        Me.TxtName.TabIndex = 3
        '
        'LblDocument3
        '
        Me.LblDocument3.AutoSize = True
        Me.LblDocument3.Location = New System.Drawing.Point(323, 68)
        Me.LblDocument3.Name = "LblDocument3"
        Me.LblDocument3.Size = New System.Drawing.Size(102, 17)
        Me.LblDocument3.TabIndex = 8
        Me.LblDocument3.Text = "Insc. Municipal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fantasia"
        '
        'LblDocument2
        '
        Me.LblDocument2.AutoSize = True
        Me.LblDocument2.Location = New System.Drawing.Point(167, 68)
        Me.LblDocument2.Name = "LblDocument2"
        Me.LblDocument2.Size = New System.Drawing.Size(95, 17)
        Me.LblDocument2.TabIndex = 7
        Me.LblDocument2.Text = "Insc. Estadual"
        '
        'LblDocument1
        '
        Me.LblDocument1.AutoSize = True
        Me.LblDocument1.Location = New System.Drawing.Point(3, 68)
        Me.LblDocument1.Name = "LblDocument1"
        Me.LblDocument1.Size = New System.Drawing.Size(43, 17)
        Me.LblDocument1.TabIndex = 5
        Me.LblDocument1.Text = "CNPJ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'RbEntityPF
        '
        Me.RbEntityPF.AutoSize = True
        Me.RbEntityPF.Location = New System.Drawing.Point(6, 28)
        Me.RbEntityPF.Name = "RbEntityPF"
        Me.RbEntityPF.Size = New System.Drawing.Size(108, 21)
        Me.RbEntityPF.TabIndex = 0
        Me.RbEntityPF.Text = "Pessoa Física"
        Me.RbEntityPF.UseVisualStyleBackColor = True
        '
        'TpContacts
        '
        Me.TpContacts.Controls.Add(Me.DgvContacts)
        Me.TpContacts.Controls.Add(Me.TsContact)
        Me.TpContacts.Location = New System.Drawing.Point(4, 26)
        Me.TpContacts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TpContacts.Name = "TpContacts"
        Me.TpContacts.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TpContacts.Size = New System.Drawing.Size(475, 360)
        Me.TpContacts.TabIndex = 1
        Me.TpContacts.Text = "Contatos"
        Me.TpContacts.UseVisualStyleBackColor = True
        '
        'DgvContacts
        '
        Me.DgvContacts.AllowUserToAddRows = False
        Me.DgvContacts.AllowUserToDeleteRows = False
        Me.DgvContacts.AllowUserToOrderColumns = True
        Me.DgvContacts.AllowUserToResizeRows = False
        Me.DgvContacts.BackgroundColor = System.Drawing.Color.White
        Me.DgvContacts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContacts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvContacts.Location = New System.Drawing.Point(3, 29)
        Me.DgvContacts.MultiSelect = False
        Me.DgvContacts.Name = "DgvContacts"
        Me.DgvContacts.ReadOnly = True
        Me.DgvContacts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvContacts.RowHeadersVisible = False
        Me.DgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvContacts.Size = New System.Drawing.Size(469, 327)
        Me.DgvContacts.TabIndex = 4
        '
        'TsContact
        '
        Me.TsContact.BackColor = System.Drawing.Color.White
        Me.TsContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsContact.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsContact.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnIncludeContact, Me.BtnEditContact, Me.BtnDeleteContact})
        Me.TsContact.Location = New System.Drawing.Point(3, 4)
        Me.TsContact.Name = "TsContact"
        Me.TsContact.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsContact.Size = New System.Drawing.Size(469, 25)
        Me.TsContact.TabIndex = 3
        Me.TsContact.Text = "ToolStrip2"
        '
        'BtnIncludeContact
        '
        Me.BtnIncludeContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnIncludeContact.Image = Global.NetSige.My.Resources.Resources.IncludeSmall
        Me.BtnIncludeContact.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnIncludeContact.Name = "BtnIncludeContact"
        Me.BtnIncludeContact.Size = New System.Drawing.Size(23, 22)
        Me.BtnIncludeContact.Text = "Incluir"
        '
        'BtnEditContact
        '
        Me.BtnEditContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditContact.Image = Global.NetSige.My.Resources.Resources.EditSmall
        Me.BtnEditContact.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditContact.Name = "BtnEditContact"
        Me.BtnEditContact.Size = New System.Drawing.Size(23, 22)
        Me.BtnEditContact.Text = "Editar"
        Me.BtnEditContact.ToolTipText = "Editar"
        '
        'BtnDeleteContact
        '
        Me.BtnDeleteContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDeleteContact.Image = Global.NetSige.My.Resources.Resources.DeleteSmall
        Me.BtnDeleteContact.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteContact.Name = "BtnDeleteContact"
        Me.BtnDeleteContact.Size = New System.Drawing.Size(23, 22)
        Me.BtnDeleteContact.Text = "Excluir"
        '
        'TpTransactions
        '
        Me.TpTransactions.Controls.Add(Me.DataGridView1)
        Me.TpTransactions.Controls.Add(Me.ToolStrip1)
        Me.TpTransactions.Location = New System.Drawing.Point(4, 26)
        Me.TpTransactions.Name = "TpTransactions"
        Me.TpTransactions.Padding = New System.Windows.Forms.Padding(3)
        Me.TpTransactions.Size = New System.Drawing.Size(475, 360)
        Me.TpTransactions.TabIndex = 6
        Me.TpTransactions.Text = "Movimentações"
        Me.TpTransactions.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 28)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(469, 329)
        Me.DataGridView1.TabIndex = 5
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripComboBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(469, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripButton1.Text = "Filtro:"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToolStripComboBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Tudo", "Compras", "Vendas"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(80, 25)
        '
        'TpNote
        '
        Me.TpNote.Controls.Add(Me.TxtNote)
        Me.TpNote.Location = New System.Drawing.Point(4, 26)
        Me.TpNote.Name = "TpNote"
        Me.TpNote.Padding = New System.Windows.Forms.Padding(3)
        Me.TpNote.Size = New System.Drawing.Size(475, 360)
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
        Me.TxtNote.Size = New System.Drawing.Size(469, 354)
        Me.TxtNote.TabIndex = 2
        Me.TxtNote.Text = ""
        '
        'CmsDefaultContact
        '
        Me.CmsDefaultContact.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmsDefaultContact.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDefaultContact})
        Me.CmsDefaultContact.Name = "CmsDefaultContact"
        Me.CmsDefaultContact.Size = New System.Drawing.Size(236, 26)
        '
        'BtnDefaultContact
        '
        Me.BtnDefaultContact.Name = "BtnDefaultContact"
        Me.BtnDefaultContact.Size = New System.Drawing.Size(235, 22)
        Me.BtnDefaultContact.Text = "Definir Contato Principal"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(376, 7)
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
        Me.BtnSave.Location = New System.Drawing.Point(275, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(95, 30)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Salvar"
        Me.BtnSave.UseVisualStyleBackColor = True
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
        Me.TsData.Size = New System.Drawing.Size(483, 25)
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
        Me.TsMain.Size = New System.Drawing.Size(483, 25)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 440)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 44)
        Me.Panel1.TabIndex = 3
        '
        'FrmPerson
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(483, 484)
        Me.Controls.Add(Me.TcPerson)
        Me.Controls.Add(Me.TsData)
        Me.Controls.Add(Me.TsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPerson"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Pessoa"
        Me.TcPerson.ResumeLayout(False)
        Me.TpMain.ResumeLayout(False)
        Me.TpMain.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TpContacts.ResumeLayout(False)
        Me.TpContacts.PerformLayout()
        CType(Me.DgvContacts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsContact.ResumeLayout(False)
        Me.TsContact.PerformLayout()
        Me.TpTransactions.ResumeLayout(False)
        Me.TpTransactions.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TpNote.ResumeLayout(False)
        Me.CmsDefaultContact.ResumeLayout(False)
        Me.TsData.ResumeLayout(False)
        Me.TsData.PerformLayout()
        Me.TsMain.ResumeLayout(False)
        Me.TsMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TcPerson As TabControl
    Friend WithEvents TpMain As TabPage
    Friend WithEvents TpContacts As TabPage
    Friend WithEvents GroupBox2 As GroupBox
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
    Friend WithEvents RbEntityPJ As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents RbEntityPF As RadioButton
    Friend WithEvents CmsDefaultContact As ContextMenuStrip
    Friend WithEvents BtnDefaultContact As ToolStripMenuItem
    Friend WithEvents TpNote As TabPage
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSave As Button
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
    Friend WithEvents LblDocument1Star As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbxState As ComboBox
    Friend WithEvents TsContact As ToolStrip
    Friend WithEvents BtnIncludeContact As ToolStripButton
    Friend WithEvents BtnDeleteContact As ToolStripButton
    Friend WithEvents DgvContacts As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDocument As Button
    Friend WithEvents BtnEditContact As ToolStripButton
    Friend WithEvents CbxIsCarrier As CheckBox
    Friend WithEvents CbxIsCustomer As CheckBox
    Friend WithEvents CbxIsProvider As CheckBox
    Friend WithEvents TpTransactions As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripButton1 As ToolStripLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtComplement As TextBox
    Friend WithEvents Label5 As Label
End Class
