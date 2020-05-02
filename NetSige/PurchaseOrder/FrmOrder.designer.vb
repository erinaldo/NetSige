<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrder
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
        Dim Condition18 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Condition19 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter22 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Parameter23 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition20 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Condition21 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter20 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Parameter21 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition22 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Condition23 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter18 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Parameter19 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition24 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter25 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition25 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter24 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition26 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter28 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition27 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter27 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition28 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter26 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition29 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Condition30 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter33 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Parameter34 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition31 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Condition32 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter31 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Parameter32 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition33 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Condition34 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter29 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Parameter30 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrder))
        Me.TcOrder = New System.Windows.Forms.TabControl()
        Me.TpMain = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnFinalDelivery = New System.Windows.Forms.Button()
        Me.BtnInitialDelivery = New System.Windows.Forms.Button()
        Me.TxtFinalDelivery = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtInitialDelivery = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.QtbCarrierName = New ControlLibrary.QueriedBox()
        Me.QtbCarrierDocument = New ControlLibrary.QueriedBox()
        Me.QtbCarrierID = New ControlLibrary.QueriedBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.QtbPaymentID = New ControlLibrary.QueriedBox()
        Me.QtbPaymentName = New ControlLibrary.QueriedBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.CbxCarrierType = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DtbCarrierPrice = New ControlLibrary.DecimalBox()
        Me.DtbExpense = New ControlLibrary.DecimalBox()
        Me.DtbICMSST = New ControlLibrary.DecimalBox()
        Me.DtbDiscount = New ControlLibrary.DecimalBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.QtbCostSharingName = New ControlLibrary.QueriedBox()
        Me.QtbCostSharingDocument = New ControlLibrary.QueriedBox()
        Me.QtbCostSharingID = New ControlLibrary.QueriedBox()
        Me.CbxLocals = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.QtbProviderName = New ControlLibrary.QueriedBox()
        Me.QtbProviderID = New ControlLibrary.QueriedBox()
        Me.QtbProviderDocument = New ControlLibrary.QueriedBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtContact = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TpItems = New System.Windows.Forms.TabPage()
        Me.DgvItems = New System.Windows.Forms.DataGridView()
        Me.TsItems = New System.Windows.Forms.ToolStrip()
        Me.BtnIncludeItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnEditItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TpNote = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TxtExternalNote = New System.Windows.Forms.RichTextBox()
        Me.TsExternalNote = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TxtInternalNote = New System.Windows.Forms.RichTextBox()
        Me.TsInternalNote = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TsData = New System.Windows.Forms.ToolStrip()
        Me.LblID = New System.Windows.Forms.ToolStripLabel()
        Me.LblIDValue = New System.Windows.Forms.ToolStripLabel()
        Me.LblStatus = New System.Windows.Forms.ToolStripLabel()
        Me.BtnStatusValue = New System.Windows.Forms.ToolStripButton()
        Me.LblCancel = New System.Windows.Forms.ToolStripLabel()
        Me.LblCreationDate = New System.Windows.Forms.ToolStripLabel()
        Me.LblCreationDateValue = New System.Windows.Forms.ToolStripLabel()
        Me.LblQuotation = New System.Windows.Forms.ToolStripLabel()
        Me.LblQuotationValue = New System.Windows.Forms.ToolStripLabel()
        Me.LblSituation = New System.Windows.Forms.ToolStripLabel()
        Me.TsMain = New System.Windows.Forms.ToolStrip()
        Me.BtnInclude = New System.Windows.Forms.ToolStripButton()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.BtnFirst = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrevious = New System.Windows.Forms.ToolStripButton()
        Me.BtnNext = New System.Windows.Forms.ToolStripButton()
        Me.BtnLast = New System.Windows.Forms.ToolStripButton()
        Me.BtnHistory = New System.Windows.Forms.ToolStripButton()
        Me.BtnApprove = New System.Windows.Forms.ToolStripButton()
        Me.BtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.BtnFinalizeItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TsTotal = New System.Windows.Forms.ToolStrip()
        Me.LblTotalNetValue = New System.Windows.Forms.ToolStripLabel()
        Me.LblTotalNet = New System.Windows.Forms.ToolStripLabel()
        Me.LblTotalGrossValue = New System.Windows.Forms.ToolStripLabel()
        Me.LblTotalGross = New System.Windows.Forms.ToolStripLabel()
        Me.CcoInitialDelivery = New ControlLibrary.ControlContainer()
        Me.Tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.CcoFinalDelivery = New ControlLibrary.ControlContainer()
        Me.TcOrder.SuspendLayout()
        Me.TpMain.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TpItems.SuspendLayout()
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsItems.SuspendLayout()
        Me.TpNote.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TsExternalNote.SuspendLayout()
        Me.TsInternalNote.SuspendLayout()
        Me.TsData.SuspendLayout()
        Me.TsMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TsTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'TcOrder
        '
        Me.TcOrder.Controls.Add(Me.TpMain)
        Me.TcOrder.Controls.Add(Me.TpItems)
        Me.TcOrder.Controls.Add(Me.TpNote)
        Me.TcOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcOrder.Location = New System.Drawing.Point(0, 50)
        Me.TcOrder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TcOrder.Multiline = True
        Me.TcOrder.Name = "TcOrder"
        Me.TcOrder.SelectedIndex = 0
        Me.TcOrder.Size = New System.Drawing.Size(540, 566)
        Me.TcOrder.TabIndex = 2
        '
        'TpMain
        '
        Me.TpMain.BackColor = System.Drawing.Color.White
        Me.TpMain.Controls.Add(Me.GroupBox3)
        Me.TpMain.Controls.Add(Me.GroupBox5)
        Me.TpMain.Controls.Add(Me.GroupBox2)
        Me.TpMain.Controls.Add(Me.GroupBox7)
        Me.TpMain.Controls.Add(Me.GroupBox4)
        Me.TpMain.Controls.Add(Me.GroupBox6)
        Me.TpMain.Controls.Add(Me.GroupBox1)
        Me.TpMain.Location = New System.Drawing.Point(4, 26)
        Me.TpMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TpMain.Name = "TpMain"
        Me.TpMain.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TpMain.Size = New System.Drawing.Size(532, 536)
        Me.TpMain.TabIndex = 0
        Me.TpMain.Text = "Principal"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnFinalDelivery)
        Me.GroupBox3.Controls.Add(Me.BtnInitialDelivery)
        Me.GroupBox3.Controls.Add(Me.TxtFinalDelivery)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtInitialDelivery)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 334)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(123, 116)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Entrega"
        '
        'BtnFinalDelivery
        '
        Me.BtnFinalDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFinalDelivery.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalDelivery.Image = Global.NetSige.My.Resources.Resources.Calendar
        Me.BtnFinalDelivery.Location = New System.Drawing.Point(88, 83)
        Me.BtnFinalDelivery.Name = "BtnFinalDelivery"
        Me.BtnFinalDelivery.Size = New System.Drawing.Size(28, 23)
        Me.BtnFinalDelivery.TabIndex = 5
        Me.BtnFinalDelivery.UseVisualStyleBackColor = True
        '
        'BtnInitialDelivery
        '
        Me.BtnInitialDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInitialDelivery.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInitialDelivery.Image = Global.NetSige.My.Resources.Resources.Calendar
        Me.BtnInitialDelivery.Location = New System.Drawing.Point(88, 38)
        Me.BtnInitialDelivery.Name = "BtnInitialDelivery"
        Me.BtnInitialDelivery.Size = New System.Drawing.Size(28, 23)
        Me.BtnInitialDelivery.TabIndex = 2
        Me.BtnInitialDelivery.UseVisualStyleBackColor = True
        '
        'TxtFinalDelivery
        '
        Me.TxtFinalDelivery.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFinalDelivery.Location = New System.Drawing.Point(8, 83)
        Me.TxtFinalDelivery.Mask = "00/00/0000"
        Me.TxtFinalDelivery.Name = "TxtFinalDelivery"
        Me.TxtFinalDelivery.Size = New System.Drawing.Size(81, 23)
        Me.TxtFinalDelivery.TabIndex = 4
        Me.TxtFinalDelivery.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Fim"
        '
        'TxtInitialDelivery
        '
        Me.TxtInitialDelivery.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInitialDelivery.Location = New System.Drawing.Point(8, 38)
        Me.TxtInitialDelivery.Mask = "00/00/0000"
        Me.TxtInitialDelivery.Name = "TxtInitialDelivery"
        Me.TxtInitialDelivery.Size = New System.Drawing.Size(81, 23)
        Me.TxtInitialDelivery.TabIndex = 1
        Me.TxtInitialDelivery.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 17)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Inicio"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.QtbCarrierName)
        Me.GroupBox5.Controls.Add(Me.QtbCarrierDocument)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.QtbCarrierID)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 456)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(518, 72)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Transportadora"
        '
        'QtbCarrierName
        '
        Condition18.FieldName = "STATUSID"
        Condition18.Operator = "="
        Condition18.TableName = "PERSON"
        Condition18.Value = "@STATUS"
        Condition19.FieldName = "ISCARRIER"
        Condition19.Operator = "="
        Condition19.TableName = "PERSON"
        Condition19.Value = "@ISCARRIER"
        Me.QtbCarrierName.Conditions.Add(Condition18)
        Me.QtbCarrierName.Conditions.Add(Condition19)
        Me.QtbCarrierName.ConnectionString = Nothing
        Me.QtbCarrierName.DbProvider = Nothing
        Me.QtbCarrierName.DecimalOnly = False
        Me.QtbCarrierName.DecimalPlaces = 2
        Me.QtbCarrierName.Dependents.Add(Me.QtbCarrierDocument)
        Me.QtbCarrierName.Dependents.Add(Me.QtbCarrierID)
        Me.QtbCarrierName.DropDownAutoStretchRight = False
        Me.QtbCarrierName.DropDownStretchRight = 200
        Me.QtbCarrierName.FieldHeader = "Nome"
        Me.QtbCarrierName.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbCarrierName.JoinField = Nothing
        Me.QtbCarrierName.JoinPKField = Nothing
        Me.QtbCarrierName.JoinTable = Nothing
        Me.QtbCarrierName.Location = New System.Drawing.Point(234, 39)
        Me.QtbCarrierName.MainField = "NAME"
        Me.QtbCarrierName.MainPKField = "ID"
        Me.QtbCarrierName.MainTable = "PERSON"
        Me.QtbCarrierName.Name = "QtbCarrierName"
        Parameter22.ParameterName = "@STATUS"
        Parameter22.ParameterValue = "0"
        Parameter23.ParameterName = "@ISCARRIER"
        Parameter23.ParameterValue = "1"
        Me.QtbCarrierName.Parameters.Add(Parameter22)
        Me.QtbCarrierName.Parameters.Add(Parameter23)
        Me.QtbCarrierName.Size = New System.Drawing.Size(278, 23)
        Me.QtbCarrierName.TabIndex = 5
        '
        'QtbCarrierDocument
        '
        Me.QtbCarrierDocument.CharactersToQuery = 2
        Condition20.FieldName = "STATUSID"
        Condition20.Operator = "="
        Condition20.TableName = "PERSON"
        Condition20.Value = "@STATUS"
        Condition21.FieldName = "ISPROVIDER"
        Condition21.Operator = "="
        Condition21.TableName = "PERSON"
        Condition21.Value = "@ISPROVIDER"
        Me.QtbCarrierDocument.Conditions.Add(Condition20)
        Me.QtbCarrierDocument.Conditions.Add(Condition21)
        Me.QtbCarrierDocument.ConnectionString = Nothing
        Me.QtbCarrierDocument.DbProvider = Nothing
        Me.QtbCarrierDocument.DecimalOnly = False
        Me.QtbCarrierDocument.DecimalPlaces = 2
        Me.QtbCarrierDocument.Dependents.Add(Me.QtbCarrierID)
        Me.QtbCarrierDocument.Dependents.Add(Me.QtbCarrierName)
        Me.QtbCarrierDocument.DropDownAutoStretchRight = False
        Me.QtbCarrierDocument.DropDownStretchLeft = 86
        Me.QtbCarrierDocument.DropDownStretchRight = 282
        Me.QtbCarrierDocument.FieldHeader = "CPF/CNPJ"
        Me.QtbCarrierDocument.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbCarrierDocument.JoinField = Nothing
        Me.QtbCarrierDocument.JoinPKField = Nothing
        Me.QtbCarrierDocument.JoinTable = Nothing
        Me.QtbCarrierDocument.Location = New System.Drawing.Point(92, 39)
        Me.QtbCarrierDocument.MainField = "DOCUMENT1"
        Me.QtbCarrierDocument.MainPKField = "ID"
        Me.QtbCarrierDocument.MainTable = "PERSON"
        Me.QtbCarrierDocument.Name = "QtbCarrierDocument"
        Parameter20.ParameterName = "@STATUS"
        Parameter20.ParameterValue = "0"
        Parameter21.ParameterName = "@ISCARRIER"
        Parameter21.ParameterValue = "1"
        Me.QtbCarrierDocument.Parameters.Add(Parameter20)
        Me.QtbCarrierDocument.Parameters.Add(Parameter21)
        Me.QtbCarrierDocument.Size = New System.Drawing.Size(136, 23)
        Me.QtbCarrierDocument.TabIndex = 4
        '
        'QtbCarrierID
        '
        Me.QtbCarrierID.CharactersToQuery = 1
        Condition22.FieldName = "STATUSID"
        Condition22.Operator = "="
        Condition22.TableName = "PERSON"
        Condition22.Value = "@STATUS"
        Condition23.FieldName = "ISCARRIER"
        Condition23.Operator = "="
        Condition23.TableName = "PERSON"
        Condition23.Value = "@ISCARRIER"
        Me.QtbCarrierID.Conditions.Add(Condition22)
        Me.QtbCarrierID.Conditions.Add(Condition23)
        Me.QtbCarrierID.ConnectionString = Nothing
        Me.QtbCarrierID.DbProvider = Nothing
        Me.QtbCarrierID.DecimalOnly = False
        Me.QtbCarrierID.DecimalPlaces = 2
        Me.QtbCarrierID.Dependents.Add(Me.QtbCarrierDocument)
        Me.QtbCarrierID.Dependents.Add(Me.QtbCarrierName)
        Me.QtbCarrierID.DropDownAutoStretchRight = False
        Me.QtbCarrierID.DropDownStretchRight = 424
        Me.QtbCarrierID.FieldHeader = "ID"
        Me.QtbCarrierID.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbCarrierID.JoinField = Nothing
        Me.QtbCarrierID.JoinPKField = Nothing
        Me.QtbCarrierID.JoinTable = Nothing
        Me.QtbCarrierID.Location = New System.Drawing.Point(6, 39)
        Me.QtbCarrierID.MainField = "ID"
        Me.QtbCarrierID.MainPKField = "ID"
        Me.QtbCarrierID.MainTable = "PERSON"
        Me.QtbCarrierID.Name = "QtbCarrierID"
        Parameter18.ParameterName = "@STATUS"
        Parameter18.ParameterValue = "0"
        Parameter19.ParameterName = "@ISCARRIER"
        Parameter19.ParameterValue = "1"
        Me.QtbCarrierID.Parameters.Add(Parameter18)
        Me.QtbCarrierID.Parameters.Add(Parameter19)
        Me.QtbCarrierID.Size = New System.Drawing.Size(80, 23)
        Me.QtbCarrierID.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(231, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 17)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Nome"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "ID"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(90, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(74, 17)
        Me.Label29.TabIndex = 1
        Me.Label29.Text = "CPF/CNPJ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.QtbPaymentID)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.QtbPaymentName)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(518, 71)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cond. Pagamento"
        '
        'QtbPaymentID
        '
        Me.QtbPaymentID.CharactersToQuery = 1
        Condition24.FieldName = "STATUSID"
        Condition24.Operator = "="
        Condition24.TableName = "PAYMENTTERM"
        Condition24.Value = "@STATUS"
        Me.QtbPaymentID.Conditions.Add(Condition24)
        Me.QtbPaymentID.ConnectionString = Nothing
        Me.QtbPaymentID.DbProvider = Nothing
        Me.QtbPaymentID.DecimalOnly = False
        Me.QtbPaymentID.DecimalPlaces = 2
        Me.QtbPaymentID.Dependents.Add(Me.QtbPaymentName)
        Me.QtbPaymentID.DropDownAutoStretchRight = False
        Me.QtbPaymentID.DropDownStretchRight = 424
        Me.QtbPaymentID.FieldHeader = "ID"
        Me.QtbPaymentID.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbPaymentID.JoinField = Nothing
        Me.QtbPaymentID.JoinPKField = Nothing
        Me.QtbPaymentID.JoinTable = Nothing
        Me.QtbPaymentID.Location = New System.Drawing.Point(9, 38)
        Me.QtbPaymentID.MainField = "ID"
        Me.QtbPaymentID.MainPKField = "ID"
        Me.QtbPaymentID.MainTable = "PAYMENTTERM"
        Me.QtbPaymentID.Name = "QtbPaymentID"
        Parameter25.ParameterName = "@STATUS"
        Parameter25.ParameterValue = "0"
        Me.QtbPaymentID.Parameters.Add(Parameter25)
        Me.QtbPaymentID.Size = New System.Drawing.Size(80, 23)
        Me.QtbPaymentID.TabIndex = 4
        '
        'QtbPaymentName
        '
        Me.QtbPaymentName.CharactersToQuery = 1
        Condition25.FieldName = "STATUSID"
        Condition25.Operator = "="
        Condition25.TableName = "PAYMENTTERM"
        Condition25.Value = "@STATUS"
        Me.QtbPaymentName.Conditions.Add(Condition25)
        Me.QtbPaymentName.ConnectionString = Nothing
        Me.QtbPaymentName.DbProvider = Nothing
        Me.QtbPaymentName.DecimalOnly = False
        Me.QtbPaymentName.DecimalPlaces = 2
        Me.QtbPaymentName.Dependents.Add(Me.QtbPaymentID)
        Me.QtbPaymentName.DropDownAutoStretchRight = False
        Me.QtbPaymentName.FieldHeader = "Nome"
        Me.QtbPaymentName.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbPaymentName.JoinField = Nothing
        Me.QtbPaymentName.JoinPKField = Nothing
        Me.QtbPaymentName.JoinTable = Nothing
        Me.QtbPaymentName.Location = New System.Drawing.Point(93, 38)
        Me.QtbPaymentName.MainField = "NAME"
        Me.QtbPaymentName.MainPKField = "ID"
        Me.QtbPaymentName.MainTable = "PAYMENTTERM"
        Me.QtbPaymentName.Name = "QtbPaymentName"
        Parameter24.ParameterName = "@STATUS"
        Parameter24.ParameterValue = "0"
        Me.QtbPaymentName.Parameters.Add(Parameter24)
        Me.QtbPaymentName.Size = New System.Drawing.Size(419, 23)
        Me.QtbPaymentName.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(90, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Nome"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.DarkRed
        Me.Label28.Location = New System.Drawing.Point(22, 19)
        Me.Label28.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(14, 17)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(134, 19)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "ID"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.CbxCarrierType)
        Me.GroupBox7.Location = New System.Drawing.Point(404, 334)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(120, 116)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Frete"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Tipo"
        '
        'CbxCarrierType
        '
        Me.CbxCarrierType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCarrierType.FormattingEnabled = True
        Me.CbxCarrierType.Items.AddRange(New Object() {"Sem Frete", "CIF", "FOB", "Terceiro"})
        Me.CbxCarrierType.Location = New System.Drawing.Point(6, 39)
        Me.CbxCarrierType.Name = "CbxCarrierType"
        Me.CbxCarrierType.Size = New System.Drawing.Size(108, 25)
        Me.CbxCarrierType.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DtbCarrierPrice)
        Me.GroupBox4.Controls.Add(Me.DtbExpense)
        Me.GroupBox4.Controls.Add(Me.DtbICMSST)
        Me.GroupBox4.Controls.Add(Me.DtbDiscount)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(135, 334)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(263, 116)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valores"
        '
        'DtbCarrierPrice
        '
        Me.DtbCarrierPrice.DecimalOnly = True
        Me.DtbCarrierPrice.DecimalPlaces = 2
        Me.DtbCarrierPrice.Location = New System.Drawing.Point(134, 39)
        Me.DtbCarrierPrice.MaxLength = 15
        Me.DtbCarrierPrice.Name = "DtbCarrierPrice"
        Me.DtbCarrierPrice.Size = New System.Drawing.Size(122, 23)
        Me.DtbCarrierPrice.TabIndex = 3
        Me.DtbCarrierPrice.Text = "0,00"
        Me.DtbCarrierPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtbExpense
        '
        Me.DtbExpense.DecimalOnly = True
        Me.DtbExpense.DecimalPlaces = 2
        Me.DtbExpense.Location = New System.Drawing.Point(6, 85)
        Me.DtbExpense.MaxLength = 15
        Me.DtbExpense.Name = "DtbExpense"
        Me.DtbExpense.Size = New System.Drawing.Size(122, 23)
        Me.DtbExpense.TabIndex = 6
        Me.DtbExpense.Text = "0,00"
        Me.DtbExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtbICMSST
        '
        Me.DtbICMSST.DecimalOnly = True
        Me.DtbICMSST.DecimalPlaces = 2
        Me.DtbICMSST.Location = New System.Drawing.Point(134, 85)
        Me.DtbICMSST.MaxLength = 15
        Me.DtbICMSST.Name = "DtbICMSST"
        Me.DtbICMSST.Size = New System.Drawing.Size(122, 23)
        Me.DtbICMSST.TabIndex = 7
        Me.DtbICMSST.Text = "0,00"
        Me.DtbICMSST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtbDiscount
        '
        Me.DtbDiscount.DecimalOnly = True
        Me.DtbDiscount.DecimalPlaces = 2
        Me.DtbDiscount.Location = New System.Drawing.Point(6, 39)
        Me.DtbDiscount.MaxLength = 15
        Me.DtbDiscount.Name = "DtbDiscount"
        Me.DtbDiscount.Size = New System.Drawing.Size(122, 23)
        Me.DtbDiscount.TabIndex = 2
        Me.DtbDiscount.Text = "0,00"
        Me.DtbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(131, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 17)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "ICMS ST"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Frete"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Despesa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desconto"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.QtbCostSharingName)
        Me.GroupBox6.Controls.Add(Me.QtbCostSharingDocument)
        Me.GroupBox6.Controls.Add(Me.QtbCostSharingID)
        Me.GroupBox6.Controls.Add(Me.CbxLocals)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(518, 119)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Centro de Custo"
        '
        'QtbCostSharingName
        '
        Condition26.FieldName = "STATUSID"
        Condition26.Operator = "="
        Condition26.TableName = "COSTSHARING"
        Condition26.Value = "@STATUS"
        Me.QtbCostSharingName.Conditions.Add(Condition26)
        Me.QtbCostSharingName.ConnectionString = Nothing
        Me.QtbCostSharingName.DbProvider = Nothing
        Me.QtbCostSharingName.DecimalOnly = False
        Me.QtbCostSharingName.DecimalPlaces = 2
        Me.QtbCostSharingName.Dependents.Add(Me.QtbCostSharingDocument)
        Me.QtbCostSharingName.Dependents.Add(Me.QtbCostSharingID)
        Me.QtbCostSharingName.DropDownAutoStretchRight = False
        Me.QtbCostSharingName.DropDownStretchLeft = 86
        Me.QtbCostSharingName.FieldHeader = "Nome"
        Me.QtbCostSharingName.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbCostSharingName.JoinField = Nothing
        Me.QtbCostSharingName.JoinPKField = Nothing
        Me.QtbCostSharingName.JoinTable = Nothing
        Me.QtbCostSharingName.Location = New System.Drawing.Point(234, 38)
        Me.QtbCostSharingName.MainField = "NAME"
        Me.QtbCostSharingName.MainPKField = "ID"
        Me.QtbCostSharingName.MainTable = "COSTSHARING"
        Me.QtbCostSharingName.Name = "QtbCostSharingName"
        Parameter28.ParameterName = "@STATUS"
        Parameter28.ParameterValue = "0"
        Me.QtbCostSharingName.Parameters.Add(Parameter28)
        Me.QtbCostSharingName.Size = New System.Drawing.Size(276, 23)
        Me.QtbCostSharingName.TabIndex = 7
        '
        'QtbCostSharingDocument
        '
        Me.QtbCostSharingDocument.CharactersToQuery = 2
        Condition27.FieldName = "STATUSID"
        Condition27.Operator = "="
        Condition27.TableName = "COSTSHARING"
        Condition27.Value = "@STATUS"
        Me.QtbCostSharingDocument.Conditions.Add(Condition27)
        Me.QtbCostSharingDocument.ConnectionString = Nothing
        Me.QtbCostSharingDocument.DbProvider = Nothing
        Me.QtbCostSharingDocument.DecimalOnly = False
        Me.QtbCostSharingDocument.DecimalPlaces = 2
        Me.QtbCostSharingDocument.Dependents.Add(Me.QtbCostSharingID)
        Me.QtbCostSharingDocument.Dependents.Add(Me.QtbCostSharingName)
        Me.QtbCostSharingDocument.DropDownAutoStretchRight = False
        Me.QtbCostSharingDocument.DropDownStretchLeft = 86
        Me.QtbCostSharingDocument.DropDownStretchRight = 282
        Me.QtbCostSharingDocument.FieldHeader = "CPF/CNPJ"
        Me.QtbCostSharingDocument.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbCostSharingDocument.JoinField = Nothing
        Me.QtbCostSharingDocument.JoinPKField = Nothing
        Me.QtbCostSharingDocument.JoinTable = Nothing
        Me.QtbCostSharingDocument.Location = New System.Drawing.Point(92, 38)
        Me.QtbCostSharingDocument.MainField = "DOCUMENT1"
        Me.QtbCostSharingDocument.MainPKField = "ID"
        Me.QtbCostSharingDocument.MainTable = "COSTSHARING"
        Me.QtbCostSharingDocument.Name = "QtbCostSharingDocument"
        Parameter27.ParameterName = "@STATUS"
        Parameter27.ParameterValue = "0"
        Me.QtbCostSharingDocument.Parameters.Add(Parameter27)
        Me.QtbCostSharingDocument.Size = New System.Drawing.Size(136, 23)
        Me.QtbCostSharingDocument.TabIndex = 6
        '
        'QtbCostSharingID
        '
        Me.QtbCostSharingID.CharactersToQuery = 1
        Condition28.FieldName = "STATUSID"
        Condition28.Operator = "="
        Condition28.TableName = "COSTSHARING"
        Condition28.Value = "@STATUS"
        Me.QtbCostSharingID.Conditions.Add(Condition28)
        Me.QtbCostSharingID.ConnectionString = Nothing
        Me.QtbCostSharingID.DbProvider = Nothing
        Me.QtbCostSharingID.DecimalOnly = False
        Me.QtbCostSharingID.DecimalPlaces = 2
        Me.QtbCostSharingID.Dependents.Add(Me.QtbCostSharingDocument)
        Me.QtbCostSharingID.Dependents.Add(Me.QtbCostSharingName)
        Me.QtbCostSharingID.DropDownAutoStretchRight = False
        Me.QtbCostSharingID.DropDownStretchRight = 424
        Me.QtbCostSharingID.FieldHeader = "ID"
        Me.QtbCostSharingID.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbCostSharingID.JoinField = Nothing
        Me.QtbCostSharingID.JoinPKField = Nothing
        Me.QtbCostSharingID.JoinTable = Nothing
        Me.QtbCostSharingID.Location = New System.Drawing.Point(6, 38)
        Me.QtbCostSharingID.MainField = "ID"
        Me.QtbCostSharingID.MainPKField = "ID"
        Me.QtbCostSharingID.MainTable = "COSTSHARING"
        Me.QtbCostSharingID.Name = "QtbCostSharingID"
        Parameter26.ParameterName = "@STATUS"
        Parameter26.ParameterValue = "0"
        Me.QtbCostSharingID.Parameters.Add(Parameter26)
        Me.QtbCostSharingID.Size = New System.Drawing.Size(80, 23)
        Me.QtbCostSharingID.TabIndex = 5
        '
        'CbxLocals
        '
        Me.CbxLocals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxLocals.FormattingEnabled = True
        Me.CbxLocals.Location = New System.Drawing.Point(6, 86)
        Me.CbxLocals.Name = "CbxLocals"
        Me.CbxLocals.Size = New System.Drawing.Size(504, 25)
        Me.CbxLocals.TabIndex = 9
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.DarkRed
        Me.Label30.Location = New System.Drawing.Point(159, 18)
        Me.Label30.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(14, 17)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.DarkRed
        Me.Label27.Location = New System.Drawing.Point(274, 18)
        Me.Label27.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(14, 17)
        Me.Label27.TabIndex = 4
        Me.Label27.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.DarkRed
        Me.Label19.Location = New System.Drawing.Point(19, 19)
        Me.Label19.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 17)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 17)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Local de Entrega"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(231, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 17)
        Me.Label26.TabIndex = 3
        Me.Label26.Text = "Nome"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(21, 17)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "ID"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(90, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 17)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "CPF/CNPJ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.QtbProviderName)
        Me.GroupBox1.Controls.Add(Me.QtbProviderDocument)
        Me.GroupBox1.Controls.Add(Me.QtbProviderID)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.TxtPhone)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtContact)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 119)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fornecedor"
        '
        'QtbProviderName
        '
        Condition29.FieldName = "STATUSID"
        Condition29.Operator = "="
        Condition29.TableName = "PERSON"
        Condition29.Value = "@STATUS"
        Condition30.FieldName = "ISPROVIDER"
        Condition30.Operator = "="
        Condition30.TableName = "PERSON"
        Condition30.Value = "@ISPROVIDER"
        Me.QtbProviderName.Conditions.Add(Condition29)
        Me.QtbProviderName.Conditions.Add(Condition30)
        Me.QtbProviderName.ConnectionString = Nothing
        Me.QtbProviderName.DbProvider = Nothing
        Me.QtbProviderName.DecimalOnly = False
        Me.QtbProviderName.DecimalPlaces = 2
        Me.QtbProviderName.Dependents.Add(Me.QtbProviderID)
        Me.QtbProviderName.Dependents.Add(Me.QtbProviderDocument)
        Me.QtbProviderName.DropDownAutoStretchRight = False
        Me.QtbProviderName.DropDownStretchLeft = 228
        Me.QtbProviderName.FieldHeader = "Nome"
        Me.QtbProviderName.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbProviderName.JoinField = Nothing
        Me.QtbProviderName.JoinPKField = Nothing
        Me.QtbProviderName.JoinTable = Nothing
        Me.QtbProviderName.Location = New System.Drawing.Point(234, 38)
        Me.QtbProviderName.MainField = "NAME"
        Me.QtbProviderName.MainPKField = "ID"
        Me.QtbProviderName.MainTable = "PERSON"
        Me.QtbProviderName.Name = "QtbProviderName"
        Parameter33.ParameterName = "@STATUS"
        Parameter33.ParameterValue = "0"
        Parameter34.ParameterName = "@ISPROVIDER"
        Parameter34.ParameterValue = "1"
        Me.QtbProviderName.Parameters.Add(Parameter33)
        Me.QtbProviderName.Parameters.Add(Parameter34)
        Me.QtbProviderName.Size = New System.Drawing.Size(278, 23)
        Me.QtbProviderName.TabIndex = 8
        '
        'QtbProviderID
        '
        Me.QtbProviderID.CharactersToQuery = 1
        Condition31.FieldName = "STATUSID"
        Condition31.Operator = "="
        Condition31.TableName = "PERSON"
        Condition31.Value = "@STATUS"
        Condition32.FieldName = "ISPROVIDER"
        Condition32.Operator = "="
        Condition32.TableName = "PERSON"
        Condition32.Value = "@ISPROVIDER"
        Me.QtbProviderID.Conditions.Add(Condition31)
        Me.QtbProviderID.Conditions.Add(Condition32)
        Me.QtbProviderID.ConnectionString = Nothing
        Me.QtbProviderID.DbProvider = Nothing
        Me.QtbProviderID.DecimalOnly = False
        Me.QtbProviderID.DecimalPlaces = 2
        Me.QtbProviderID.Dependents.Add(Me.QtbProviderDocument)
        Me.QtbProviderID.Dependents.Add(Me.QtbProviderName)
        Me.QtbProviderID.DropDownAutoStretchRight = False
        Me.QtbProviderID.DropDownStretchRight = 424
        Me.QtbProviderID.FieldHeader = "ID"
        Me.QtbProviderID.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbProviderID.JoinField = Nothing
        Me.QtbProviderID.JoinPKField = Nothing
        Me.QtbProviderID.JoinTable = Nothing
        Me.QtbProviderID.Location = New System.Drawing.Point(6, 38)
        Me.QtbProviderID.MainField = "ID"
        Me.QtbProviderID.MainPKField = "ID"
        Me.QtbProviderID.MainTable = "PERSON"
        Me.QtbProviderID.Name = "QtbProviderID"
        Parameter31.ParameterName = "@STATUS"
        Parameter31.ParameterValue = "0"
        Parameter32.ParameterName = "@ISPROVIDER"
        Parameter32.ParameterValue = "1"
        Me.QtbProviderID.Parameters.Add(Parameter31)
        Me.QtbProviderID.Parameters.Add(Parameter32)
        Me.QtbProviderID.Size = New System.Drawing.Size(80, 23)
        Me.QtbProviderID.TabIndex = 6
        '
        'QtbProviderDocument
        '
        Me.QtbProviderDocument.CharactersToQuery = 2
        Condition33.FieldName = "STATUSID"
        Condition33.Operator = "="
        Condition33.TableName = "PERSON"
        Condition33.Value = "@STATUS"
        Condition34.FieldName = "ISPROVIDER"
        Condition34.Operator = "="
        Condition34.TableName = "PERSON"
        Condition34.Value = "@ISPROVIDER"
        Me.QtbProviderDocument.Conditions.Add(Condition33)
        Me.QtbProviderDocument.Conditions.Add(Condition34)
        Me.QtbProviderDocument.ConnectionString = Nothing
        Me.QtbProviderDocument.DbProvider = Nothing
        Me.QtbProviderDocument.DecimalOnly = False
        Me.QtbProviderDocument.DecimalPlaces = 2
        Me.QtbProviderDocument.Dependents.Add(Me.QtbProviderID)
        Me.QtbProviderDocument.Dependents.Add(Me.QtbProviderName)
        Me.QtbProviderDocument.DropDownAutoStretchRight = False
        Me.QtbProviderDocument.DropDownStretchLeft = 86
        Me.QtbProviderDocument.DropDownStretchRight = 282
        Me.QtbProviderDocument.FieldHeader = "CPF/CNPJ"
        Me.QtbProviderDocument.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbProviderDocument.JoinField = Nothing
        Me.QtbProviderDocument.JoinPKField = Nothing
        Me.QtbProviderDocument.JoinTable = Nothing
        Me.QtbProviderDocument.Location = New System.Drawing.Point(92, 38)
        Me.QtbProviderDocument.MainField = "DOCUMENT1"
        Me.QtbProviderDocument.MainPKField = "ID"
        Me.QtbProviderDocument.MainTable = "PERSON"
        Me.QtbProviderDocument.Name = "QtbProviderDocument"
        Parameter29.ParameterName = "@STATUS"
        Parameter29.ParameterValue = "0"
        Parameter30.ParameterName = "@ISPROVIDER"
        Parameter30.ParameterValue = "1"
        Me.QtbProviderDocument.Parameters.Add(Parameter29)
        Me.QtbProviderDocument.Parameters.Add(Parameter30)
        Me.QtbProviderDocument.Size = New System.Drawing.Size(136, 23)
        Me.QtbProviderDocument.TabIndex = 7
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.Color.DarkRed
        Me.Label25.Location = New System.Drawing.Point(274, 19)
        Me.Label25.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 17)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "*"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.DarkRed
        Me.Label23.Location = New System.Drawing.Point(19, 18)
        Me.Label23.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(14, 17)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(161, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "*"
        '
        'TxtEmail
        '
        Me.TxtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtEmail.Location = New System.Drawing.Point(277, 87)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(235, 23)
        Me.TxtEmail.TabIndex = 14
        '
        'TxtPhone
        '
        Me.TxtPhone.Location = New System.Drawing.Point(164, 87)
        Me.TxtPhone.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(107, 23)
        Me.TxtPhone.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(274, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "E-Mail"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(164, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Telefone"
        '
        'TxtContact
        '
        Me.TxtContact.Location = New System.Drawing.Point(6, 87)
        Me.TxtContact.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtContact.Name = "TxtContact"
        Me.TxtContact.Size = New System.Drawing.Size(152, 23)
        Me.TxtContact.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Contato"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(231, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 17)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Nome"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(89, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 17)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "CPF/CNPJ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'TpItems
        '
        Me.TpItems.BackColor = System.Drawing.Color.White
        Me.TpItems.Controls.Add(Me.DgvItems)
        Me.TpItems.Controls.Add(Me.TsItems)
        Me.TpItems.Location = New System.Drawing.Point(4, 26)
        Me.TpItems.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TpItems.Name = "TpItems"
        Me.TpItems.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TpItems.Size = New System.Drawing.Size(532, 536)
        Me.TpItems.TabIndex = 1
        Me.TpItems.Text = "Itens"
        '
        'DgvItems
        '
        Me.DgvItems.AllowUserToAddRows = False
        Me.DgvItems.AllowUserToDeleteRows = False
        Me.DgvItems.AllowUserToOrderColumns = True
        Me.DgvItems.AllowUserToResizeRows = False
        Me.DgvItems.BackgroundColor = System.Drawing.Color.White
        Me.DgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvItems.Location = New System.Drawing.Point(3, 29)
        Me.DgvItems.MultiSelect = False
        Me.DgvItems.Name = "DgvItems"
        Me.DgvItems.ReadOnly = True
        Me.DgvItems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvItems.RowHeadersVisible = False
        Me.DgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItems.Size = New System.Drawing.Size(526, 503)
        Me.DgvItems.TabIndex = 1
        '
        'TsItems
        '
        Me.TsItems.BackColor = System.Drawing.Color.White
        Me.TsItems.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnIncludeItem, Me.BtnEditItem, Me.BtnDeleteItem})
        Me.TsItems.Location = New System.Drawing.Point(3, 4)
        Me.TsItems.Name = "TsItems"
        Me.TsItems.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsItems.Size = New System.Drawing.Size(526, 25)
        Me.TsItems.TabIndex = 0
        Me.TsItems.Text = "ToolStrip2"
        '
        'BtnIncludeItem
        '
        Me.BtnIncludeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnIncludeItem.Image = Global.NetSige.My.Resources.Resources.IncludeSmall
        Me.BtnIncludeItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnIncludeItem.Name = "BtnIncludeItem"
        Me.BtnIncludeItem.Size = New System.Drawing.Size(23, 22)
        Me.BtnIncludeItem.Text = "Incluir"
        '
        'BtnEditItem
        '
        Me.BtnEditItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnEditItem.Image = Global.NetSige.My.Resources.Resources.EditSmall
        Me.BtnEditItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEditItem.Name = "BtnEditItem"
        Me.BtnEditItem.Size = New System.Drawing.Size(23, 22)
        Me.BtnEditItem.Text = "Editar"
        '
        'BtnDeleteItem
        '
        Me.BtnDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnDeleteItem.Image = Global.NetSige.My.Resources.Resources.DeleteSmall
        Me.BtnDeleteItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteItem.Name = "BtnDeleteItem"
        Me.BtnDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BtnDeleteItem.Text = "Excluir"
        '
        'TpNote
        '
        Me.TpNote.BackColor = System.Drawing.Color.White
        Me.TpNote.Controls.Add(Me.SplitContainer1)
        Me.TpNote.Location = New System.Drawing.Point(4, 26)
        Me.TpNote.Name = "TpNote"
        Me.TpNote.Padding = New System.Windows.Forms.Padding(3)
        Me.TpNote.Size = New System.Drawing.Size(532, 536)
        Me.TpNote.TabIndex = 5
        Me.TpNote.Text = "Informações Adicionais"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtExternalNote)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TsExternalNote)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TxtInternalNote)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TsInternalNote)
        Me.SplitContainer1.Size = New System.Drawing.Size(526, 530)
        Me.SplitContainer1.SplitterDistance = 279
        Me.SplitContainer1.TabIndex = 0
        '
        'TxtExternalNote
        '
        Me.TxtExternalNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtExternalNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtExternalNote.Location = New System.Drawing.Point(0, 25)
        Me.TxtExternalNote.Name = "TxtExternalNote"
        Me.TxtExternalNote.Size = New System.Drawing.Size(526, 254)
        Me.TxtExternalNote.TabIndex = 1
        Me.TxtExternalNote.Text = ""
        '
        'TsExternalNote
        '
        Me.TsExternalNote.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsExternalNote.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsExternalNote.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.TsExternalNote.Location = New System.Drawing.Point(0, 0)
        Me.TsExternalNote.Name = "TsExternalNote"
        Me.TsExternalNote.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsExternalNote.Size = New System.Drawing.Size(526, 25)
        Me.TsExternalNote.TabIndex = 0
        Me.TsExternalNote.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel1.Text = "Externa"
        '
        'TxtInternalNote
        '
        Me.TxtInternalNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtInternalNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtInternalNote.Location = New System.Drawing.Point(0, 25)
        Me.TxtInternalNote.Name = "TxtInternalNote"
        Me.TxtInternalNote.Size = New System.Drawing.Size(526, 222)
        Me.TxtInternalNote.TabIndex = 1
        Me.TxtInternalNote.Text = ""
        '
        'TsInternalNote
        '
        Me.TsInternalNote.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsInternalNote.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsInternalNote.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.TsInternalNote.Location = New System.Drawing.Point(0, 0)
        Me.TsInternalNote.Name = "TsInternalNote"
        Me.TsInternalNote.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsInternalNote.Size = New System.Drawing.Size(526, 25)
        Me.TsInternalNote.TabIndex = 0
        Me.TsInternalNote.Text = "ToolStrip2"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel2.Text = "Interna"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripLabel3.Text = "Observação Externa"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripLabel4.Text = "Observação Interna"
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(433, 7)
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
        Me.BtnSave.Location = New System.Drawing.Point(332, 7)
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
        Me.TsData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblID, Me.LblIDValue, Me.LblStatus, Me.BtnStatusValue, Me.LblCancel, Me.LblCreationDate, Me.LblCreationDateValue, Me.LblQuotation, Me.LblQuotationValue, Me.LblSituation})
        Me.TsData.Location = New System.Drawing.Point(0, 25)
        Me.TsData.Name = "TsData"
        Me.TsData.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsData.Size = New System.Drawing.Size(540, 25)
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
        'LblCancel
        '
        Me.LblCancel.ForeColor = System.Drawing.Color.DarkRed
        Me.LblCancel.Name = "LblCancel"
        Me.LblCancel.Size = New System.Drawing.Size(82, 22)
        Me.LblCancel.Text = "Cancelado"
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
        'LblQuotation
        '
        Me.LblQuotation.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuotation.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.LblQuotation.Name = "LblQuotation"
        Me.LblQuotation.Size = New System.Drawing.Size(68, 22)
        Me.LblQuotation.Text = "Cotação:"
        '
        'LblQuotationValue
        '
        Me.LblQuotationValue.BackColor = System.Drawing.Color.White
        Me.LblQuotationValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuotationValue.Name = "LblQuotationValue"
        Me.LblQuotationValue.Size = New System.Drawing.Size(15, 22)
        Me.LblQuotationValue.Text = "0"
        '
        'LblSituation
        '
        Me.LblSituation.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LblSituation.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSituation.ForeColor = System.Drawing.Color.DarkRed
        Me.LblSituation.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.LblSituation.Name = "LblSituation"
        Me.LblSituation.Size = New System.Drawing.Size(153, 16)
        Me.LblSituation.Text = "Pedido Não Aprovado"
        '
        'TsMain
        '
        Me.TsMain.BackColor = System.Drawing.Color.White
        Me.TsMain.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnInclude, Me.BtnDelete, Me.BtnFirst, Me.BtnPrevious, Me.BtnNext, Me.BtnLast, Me.BtnHistory, Me.BtnApprove, Me.BtnPrint, Me.BtnFinalizeItem})
        Me.TsMain.Location = New System.Drawing.Point(0, 0)
        Me.TsMain.Name = "TsMain"
        Me.TsMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsMain.Size = New System.Drawing.Size(540, 25)
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
        'BtnHistory
        '
        Me.BtnHistory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnHistory.Image = Global.NetSige.My.Resources.Resources.History
        Me.BtnHistory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(23, 22)
        Me.BtnHistory.Text = "Histórico"
        Me.BtnHistory.ToolTipText = "Histórico"
        '
        'BtnApprove
        '
        Me.BtnApprove.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnApprove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnApprove.Image = Global.NetSige.My.Resources.Resources.Approve
        Me.BtnApprove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnApprove.Name = "BtnApprove"
        Me.BtnApprove.Size = New System.Drawing.Size(23, 22)
        Me.BtnApprove.Text = "Aprovar"
        Me.BtnApprove.ToolTipText = "Aprovar"
        '
        'BtnPrint
        '
        Me.BtnPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnPrint.Image = Global.NetSige.My.Resources.Resources.Print
        Me.BtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(23, 22)
        Me.BtnPrint.Text = "ToolStripButton1"
        Me.BtnPrint.ToolTipText = "Gerar Relatório"
        '
        'BtnFinalizeItem
        '
        Me.BtnFinalizeItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnFinalizeItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnFinalizeItem.Image = Global.NetSige.My.Resources.Resources.FinalizeItem
        Me.BtnFinalizeItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnFinalizeItem.Name = "BtnFinalizeItem"
        Me.BtnFinalizeItem.Size = New System.Drawing.Size(23, 22)
        Me.BtnFinalizeItem.Text = "ToolStripButton1"
        Me.BtnFinalizeItem.ToolTipText = "Baixa de Item"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 641)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 44)
        Me.Panel1.TabIndex = 4
        '
        'TsTotal
        '
        Me.TsTotal.BackColor = System.Drawing.Color.White
        Me.TsTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TsTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsTotal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsTotal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblTotalNetValue, Me.LblTotalNet, Me.LblTotalGrossValue, Me.LblTotalGross})
        Me.TsTotal.Location = New System.Drawing.Point(0, 616)
        Me.TsTotal.Name = "TsTotal"
        Me.TsTotal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsTotal.Size = New System.Drawing.Size(540, 25)
        Me.TsTotal.TabIndex = 3
        Me.TsTotal.Text = "ToolStrip1"
        '
        'LblTotalNetValue
        '
        Me.LblTotalNetValue.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LblTotalNetValue.BackColor = System.Drawing.Color.White
        Me.LblTotalNetValue.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.LblTotalNetValue.Margin = New System.Windows.Forms.Padding(0, 1, 10, 2)
        Me.LblTotalNetValue.Name = "LblTotalNetValue"
        Me.LblTotalNetValue.Size = New System.Drawing.Size(37, 22)
        Me.LblTotalNetValue.Text = "0,00"
        '
        'LblTotalNet
        '
        Me.LblTotalNet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LblTotalNet.BackColor = System.Drawing.Color.White
        Me.LblTotalNet.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.LblTotalNet.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.LblTotalNet.Name = "LblTotalNet"
        Me.LblTotalNet.Size = New System.Drawing.Size(104, 22)
        Me.LblTotalNet.Text = "Total Líquido:"
        '
        'LblTotalGrossValue
        '
        Me.LblTotalGrossValue.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LblTotalGrossValue.BackColor = System.Drawing.Color.White
        Me.LblTotalGrossValue.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.LblTotalGrossValue.Name = "LblTotalGrossValue"
        Me.LblTotalGrossValue.Size = New System.Drawing.Size(37, 22)
        Me.LblTotalGrossValue.Text = "0,00"
        '
        'LblTotalGross
        '
        Me.LblTotalGross.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LblTotalGross.BackColor = System.Drawing.Color.White
        Me.LblTotalGross.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalGross.Name = "LblTotalGross"
        Me.LblTotalGross.Size = New System.Drawing.Size(87, 22)
        Me.LblTotalGross.Text = "Total Bruto:"
        '
        'CcoInitialDelivery
        '
        Me.CcoInitialDelivery.DropDownBorderColor = System.Drawing.SystemColors.HotTrack
        Me.CcoInitialDelivery.DropDownControl = Nothing
        Me.CcoInitialDelivery.DropDownEnabled = True
        Me.CcoInitialDelivery.HostControl = Me.BtnInitialDelivery
        '
        'CcoFinalDelivery
        '
        Me.CcoFinalDelivery.DropDownBorderColor = System.Drawing.SystemColors.HotTrack
        Me.CcoFinalDelivery.DropDownControl = Nothing
        Me.CcoFinalDelivery.DropDownEnabled = True
        Me.CcoFinalDelivery.HostControl = Me.BtnFinalDelivery
        '
        'FrmOrder
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(540, 685)
        Me.Controls.Add(Me.TcOrder)
        Me.Controls.Add(Me.TsTotal)
        Me.Controls.Add(Me.TsData)
        Me.Controls.Add(Me.TsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(554, 626)
        Me.Name = "FrmOrder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Pedido de Compra"
        Me.TcOrder.ResumeLayout(False)
        Me.TpMain.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TpItems.ResumeLayout(False)
        Me.TpItems.PerformLayout()
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsItems.ResumeLayout(False)
        Me.TsItems.PerformLayout()
        Me.TpNote.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TsExternalNote.ResumeLayout(False)
        Me.TsExternalNote.PerformLayout()
        Me.TsInternalNote.ResumeLayout(False)
        Me.TsInternalNote.PerformLayout()
        Me.TsData.ResumeLayout(False)
        Me.TsData.PerformLayout()
        Me.TsMain.ResumeLayout(False)
        Me.TsMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TsTotal.ResumeLayout(False)
        Me.TsTotal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TcOrder As TabControl
    Friend WithEvents TpItems As TabPage
    Friend WithEvents TpNote As TabPage
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSave As Button
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
    Friend WithEvents TsItems As ToolStrip
    Friend WithEvents DgvItems As DataGridView
    Friend WithEvents LblQuotation As ToolStripLabel
    Friend WithEvents LblQuotationValue As ToolStripLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TxtExternalNote As RichTextBox
    Friend WithEvents TsExternalNote As ToolStrip
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents TxtInternalNote As RichTextBox
    Friend WithEvents TsInternalNote As ToolStrip
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TsTotal As ToolStrip
    Friend WithEvents LblTotalNetValue As ToolStripLabel
    Friend WithEvents LblTotalNet As ToolStripLabel
    Friend WithEvents LblTotalGrossValue As ToolStripLabel
    Friend WithEvents LblTotalGross As ToolStripLabel
    Friend WithEvents CcoInitialDelivery As ControlLibrary.ControlContainer
    Friend WithEvents BtnIncludeItem As ToolStripButton
    Friend WithEvents BtnEditItem As ToolStripButton
    Friend WithEvents BtnDeleteItem As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Tip As ToolTip
    Friend WithEvents CcoFinalDelivery As ControlLibrary.ControlContainer
    Friend WithEvents LblCancel As ToolStripLabel
    Friend WithEvents TpMain As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnFinalDelivery As Button
    Friend WithEvents BtnInitialDelivery As Button
    Friend WithEvents TxtFinalDelivery As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtInitialDelivery As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents QtbCarrierName As ControlLibrary.QueriedBox
    Friend WithEvents Label18 As Label
    Friend WithEvents QtbCarrierID As ControlLibrary.QueriedBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents QtbPaymentID As ControlLibrary.QueriedBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents QtbPaymentName As ControlLibrary.QueriedBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents CbxCarrierType As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DtbCarrierPrice As ControlLibrary.DecimalBox
    Friend WithEvents DtbExpense As ControlLibrary.DecimalBox
    Friend WithEvents DtbICMSST As ControlLibrary.DecimalBox
    Friend WithEvents DtbDiscount As ControlLibrary.DecimalBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents QtbCostSharingName As ControlLibrary.QueriedBox
    Friend WithEvents QtbCostSharingID As ControlLibrary.QueriedBox
    Friend WithEvents CbxLocals As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents QtbProviderName As ControlLibrary.QueriedBox
    Friend WithEvents QtbProviderID As ControlLibrary.QueriedBox
    Friend WithEvents QtbProviderDocument As ControlLibrary.QueriedBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents QtbCarrierDocument As ControlLibrary.QueriedBox
    Friend WithEvents Label29 As Label
    Friend WithEvents QtbCostSharingDocument As ControlLibrary.QueriedBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents BtnPrint As ToolStripButton
    Friend WithEvents BtnFinalizeItem As ToolStripButton
    Friend WithEvents BtnHistory As ToolStripButton
    Friend WithEvents LblSituation As ToolStripLabel
    Friend WithEvents BtnApprove As ToolStripButton
End Class
