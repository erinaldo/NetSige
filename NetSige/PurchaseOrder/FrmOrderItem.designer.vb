<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrderItem
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
        Dim Condition1 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter2 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition2 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter1 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Dim Condition3 As ControlLibrary.QueriedBox.Condition = New ControlLibrary.QueriedBox.Condition()
        Dim Parameter3 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PboxICMS = New ControlLibrary.PercentageBox()
        Me.PboxIPI = New ControlLibrary.PercentageBox()
        Me.TxtComplement = New System.Windows.Forms.TextBox()
        Me.DtbDiscount = New ControlLibrary.DecimalBox()
        Me.DtbPrice = New ControlLibrary.DecimalBox()
        Me.DtbQuantity = New ControlLibrary.DecimalBox()
        Me.QtbItemName = New ControlLibrary.QueriedBox()
        Me.QtbItemID = New ControlLibrary.QueriedBox()
        Me.QtbItemUnit = New ControlLibrary.QueriedBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TsData = New System.Windows.Forms.ToolStrip()
        Me.LblSeq = New System.Windows.Forms.ToolStripLabel()
        Me.LblSeqValue = New System.Windows.Forms.ToolStripLabel()
        Me.LblDeliveryDate = New System.Windows.Forms.ToolStripLabel()
        Me.LblDeliveryDateValue = New System.Windows.Forms.ToolStripLabel()
        Me.TsMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TsData.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(374, 7)
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
        Me.BtnSave.Location = New System.Drawing.Point(273, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(95, 30)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Text = "Salvar"
        Me.BtnSave.UseVisualStyleBackColor = True
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
        Me.TsMain.Size = New System.Drawing.Size(481, 25)
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
        Me.BtnInclude.Text = "Incluir Novo"
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
        Me.Panel1.Location = New System.Drawing.Point(0, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 44)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PboxICMS)
        Me.GroupBox1.Controls.Add(Me.PboxIPI)
        Me.GroupBox1.Controls.Add(Me.TxtComplement)
        Me.GroupBox1.Controls.Add(Me.DtbDiscount)
        Me.GroupBox1.Controls.Add(Me.DtbPrice)
        Me.GroupBox1.Controls.Add(Me.DtbQuantity)
        Me.GroupBox1.Controls.Add(Me.QtbItemName)
        Me.GroupBox1.Controls.Add(Me.QtbItemUnit)
        Me.GroupBox1.Controls.Add(Me.QtbItemID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 163)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item"
        '
        'PboxICMS
        '
        Me.PboxICMS.Location = New System.Drawing.Point(406, 85)
        Me.PboxICMS.Name = "PboxICMS"
        Me.PboxICMS.PercentageValueFormat = ControlLibrary.PercentageBox.ReturnFormat.Percent
        Me.PboxICMS.ShowPercentSymbol = True
        Me.PboxICMS.Size = New System.Drawing.Size(48, 23)
        Me.PboxICMS.TabIndex = 20
        Me.PboxICMS.Text = "0%"
        Me.PboxICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PboxIPI
        '
        Me.PboxIPI.Location = New System.Drawing.Point(353, 85)
        Me.PboxIPI.Name = "PboxIPI"
        Me.PboxIPI.PercentageValueFormat = ControlLibrary.PercentageBox.ReturnFormat.Percent
        Me.PboxIPI.ShowPercentSymbol = True
        Me.PboxIPI.Size = New System.Drawing.Size(47, 23)
        Me.PboxIPI.TabIndex = 19
        Me.PboxIPI.Text = "0%"
        Me.PboxIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtComplement
        '
        Me.TxtComplement.Location = New System.Drawing.Point(9, 131)
        Me.TxtComplement.Name = "TxtComplement"
        Me.TxtComplement.Size = New System.Drawing.Size(445, 23)
        Me.TxtComplement.TabIndex = 22
        '
        'DtbDiscount
        '
        Me.DtbDiscount.DecimalOnly = True
        Me.DtbDiscount.DecimalPlaces = 2
        Me.DtbDiscount.Location = New System.Drawing.Point(267, 85)
        Me.DtbDiscount.MaxLength = 15
        Me.DtbDiscount.Name = "DtbDiscount"
        Me.DtbDiscount.Size = New System.Drawing.Size(80, 23)
        Me.DtbDiscount.TabIndex = 18
        Me.DtbDiscount.Text = "0,00"
        Me.DtbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtbPrice
        '
        Me.DtbPrice.DecimalOnly = True
        Me.DtbPrice.DecimalPlaces = 2
        Me.DtbPrice.Location = New System.Drawing.Point(181, 85)
        Me.DtbPrice.MaxLength = 15
        Me.DtbPrice.Name = "DtbPrice"
        Me.DtbPrice.Size = New System.Drawing.Size(80, 23)
        Me.DtbPrice.TabIndex = 17
        Me.DtbPrice.Text = "0,00"
        Me.DtbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DtbQuantity
        '
        Me.DtbQuantity.DecimalOnly = True
        Me.DtbQuantity.DecimalPlaces = 2
        Me.DtbQuantity.Location = New System.Drawing.Point(95, 85)
        Me.DtbQuantity.MaxLength = 15
        Me.DtbQuantity.Name = "DtbQuantity"
        Me.DtbQuantity.Size = New System.Drawing.Size(80, 23)
        Me.DtbQuantity.TabIndex = 16
        Me.DtbQuantity.Text = "0,00"
        Me.DtbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'QtbItemName
        '
        Condition1.FieldName = "STATUSID"
        Condition1.Operator = "="
        Condition1.TableName = "ITEM"
        Condition1.Value = "@STATUS"
        Me.QtbItemName.Conditions.Add(Condition1)
        Me.QtbItemName.ConnectionString = Nothing
        Me.QtbItemName.DbProvider = Nothing
        Me.QtbItemName.DecimalOnly = False
        Me.QtbItemName.DecimalPlaces = 2
        Me.QtbItemName.Dependents.Add(Me.QtbItemID)
        Me.QtbItemName.DropDownAutoStretchRight = False
        Me.QtbItemName.DropDownStretchLeft = 86
        Me.QtbItemName.FieldHeader = "Nome"
        Me.QtbItemName.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbItemName.JoinField = Nothing
        Me.QtbItemName.JoinPKField = Nothing
        Me.QtbItemName.JoinTable = Nothing
        Me.QtbItemName.Location = New System.Drawing.Point(95, 39)
        Me.QtbItemName.MainField = "NAME"
        Me.QtbItemName.MainPKField = "ID"
        Me.QtbItemName.MainTable = "ITEM"
        Me.QtbItemName.Name = "QtbItemName"
        Parameter2.ParameterName = "@STATUS"
        Parameter2.ParameterValue = "0"
        Me.QtbItemName.Parameters.Add(Parameter2)
        Me.QtbItemName.Size = New System.Drawing.Size(359, 23)
        Me.QtbItemName.TabIndex = 5
        '
        'QtbItemID
        '
        Me.QtbItemID.CharactersToQuery = 1
        Condition2.FieldName = "STATUSID"
        Condition2.Operator = "="
        Condition2.TableName = "ITEM"
        Condition2.Value = "@STATUS"
        Me.QtbItemID.Conditions.Add(Condition2)
        Me.QtbItemID.ConnectionString = Nothing
        Me.QtbItemID.DbProvider = Nothing
        Me.QtbItemID.DecimalOnly = False
        Me.QtbItemID.DecimalPlaces = 2
        Me.QtbItemID.Dependents.Add(Me.QtbItemName)
        Me.QtbItemID.DropDownAutoStretchRight = False
        Me.QtbItemID.DropDownStretchRight = 365
        Me.QtbItemID.FieldHeader = "ID"
        Me.QtbItemID.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbItemID.JoinField = Nothing
        Me.QtbItemID.JoinPKField = Nothing
        Me.QtbItemID.JoinTable = Nothing
        Me.QtbItemID.Location = New System.Drawing.Point(9, 39)
        Me.QtbItemID.MainField = "ID"
        Me.QtbItemID.MainPKField = "ID"
        Me.QtbItemID.MainTable = "ITEM"
        Me.QtbItemID.Name = "QtbItemID"
        Parameter1.ParameterName = "@STATUS"
        Parameter1.ParameterValue = "0"
        Me.QtbItemID.Parameters.Add(Parameter1)
        Me.QtbItemID.QueryInterval = 100
        Me.QtbItemID.Size = New System.Drawing.Size(80, 23)
        Me.QtbItemID.TabIndex = 4
        '
        'QtbItemUnit
        '
        Me.QtbItemUnit.CharactersToQuery = 1
        Condition3.FieldName = "STATUSID"
        Condition3.Operator = "="
        Condition3.TableName = "UNIT"
        Condition3.Value = "@STATUS"
        Me.QtbItemUnit.Conditions.Add(Condition3)
        Me.QtbItemUnit.ConnectionString = Nothing
        Me.QtbItemUnit.DbProvider = Nothing
        Me.QtbItemUnit.DecimalOnly = False
        Me.QtbItemUnit.DecimalPlaces = 2
        Me.QtbItemUnit.DropDownAutoStretchRight = False
        Me.QtbItemUnit.DropDownStretchRight = 150
        Me.QtbItemUnit.FieldHeader = "Unidade"
        Me.QtbItemUnit.FreezeColor = System.Drawing.Color.DarkBlue
        Me.QtbItemUnit.JoinField = Nothing
        Me.QtbItemUnit.JoinPKField = Nothing
        Me.QtbItemUnit.JoinTable = Nothing
        Me.QtbItemUnit.Location = New System.Drawing.Point(9, 85)
        Me.QtbItemUnit.MainField = "INITIALS"
        Me.QtbItemUnit.MainPKField = "ID"
        Me.QtbItemUnit.MainTable = "ITEMUNIT"
        Me.QtbItemUnit.Name = "QtbItemUnit"
        Parameter3.ParameterName = "@STATUS"
        Parameter3.ParameterValue = "0"
        Me.QtbItemUnit.Parameters.Add(Parameter3)
        Me.QtbItemUnit.QueryInterval = 100
        Me.QtbItemUnit.Size = New System.Drawing.Size(80, 23)
        Me.QtbItemUnit.TabIndex = 15
        Me.QtbItemUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(218, 65)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(22, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(124, 65)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(403, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "ICMS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(38, 65)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 17)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Complemento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(350, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "IPI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(135, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(264, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 17)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Desconto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(178, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Preço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Qtd."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Und."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome"
        '
        'TsData
        '
        Me.TsData.BackColor = System.Drawing.Color.White
        Me.TsData.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsData.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LblSeq, Me.LblSeqValue, Me.LblDeliveryDate, Me.LblDeliveryDateValue})
        Me.TsData.Location = New System.Drawing.Point(0, 25)
        Me.TsData.Name = "TsData"
        Me.TsData.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsData.Size = New System.Drawing.Size(481, 25)
        Me.TsData.TabIndex = 1
        Me.TsData.Text = "ToolStrip1"
        '
        'LblSeq
        '
        Me.LblSeq.BackColor = System.Drawing.Color.White
        Me.LblSeq.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeq.Name = "LblSeq"
        Me.LblSeq.Size = New System.Drawing.Size(36, 22)
        Me.LblSeq.Text = "Seq:"
        '
        'LblSeqValue
        '
        Me.LblSeqValue.BackColor = System.Drawing.Color.White
        Me.LblSeqValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeqValue.Name = "LblSeqValue"
        Me.LblSeqValue.Size = New System.Drawing.Size(32, 22)
        Me.LblSeqValue.Text = "      "
        '
        'LblDeliveryDate
        '
        Me.LblDeliveryDate.BackColor = System.Drawing.Color.White
        Me.LblDeliveryDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeliveryDate.Name = "LblDeliveryDate"
        Me.LblDeliveryDate.Size = New System.Drawing.Size(69, 22)
        Me.LblDeliveryDate.Text = "Entregue:"
        '
        'LblDeliveryDateValue
        '
        Me.LblDeliveryDateValue.BackColor = System.Drawing.Color.White
        Me.LblDeliveryDateValue.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeliveryDateValue.Name = "LblDeliveryDateValue"
        Me.LblDeliveryDateValue.Size = New System.Drawing.Size(32, 22)
        Me.LblDeliveryDateValue.Text = "      "
        '
        'FrmOrderItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(481, 267)
        Me.Controls.Add(Me.TsData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TsMain)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrderItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Item do Pedido"
        Me.TsMain.ResumeLayout(False)
        Me.TsMain.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TsData.ResumeLayout(False)
        Me.TsData.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnSave As Button
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents QtbItemID As ControlLibrary.QueriedBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents QtbItemName As ControlLibrary.QueriedBox
    Friend WithEvents TxtComplement As TextBox
    Friend WithEvents DtbPrice As ControlLibrary.DecimalBox
    Friend WithEvents DtbQuantity As ControlLibrary.DecimalBox
    Friend WithEvents QtbItemUnit As ControlLibrary.QueriedBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PboxICMS As ControlLibrary.PercentageBox
    Friend WithEvents PboxIPI As ControlLibrary.PercentageBox
    Friend WithEvents DtbDiscount As ControlLibrary.DecimalBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TsData As ToolStrip
    Friend WithEvents LblSeq As ToolStripLabel
    Friend WithEvents LblSeqValue As ToolStripLabel
    Friend WithEvents LblDeliveryDate As ToolStripLabel
    Friend WithEvents LblDeliveryDateValue As ToolStripLabel
End Class
