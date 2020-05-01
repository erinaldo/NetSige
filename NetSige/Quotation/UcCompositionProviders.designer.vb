<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcCompositionProviders
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Dim OtherField1 As ControlLibrary.QueriedBox.OtherField = New ControlLibrary.QueriedBox.OtherField()
        Dim OtherField2 As ControlLibrary.QueriedBox.OtherField = New ControlLibrary.QueriedBox.OtherField()
        Dim Parameter1 As ControlLibrary.QueriedBox.Parameter = New ControlLibrary.QueriedBox.Parameter()
        Me.QtbName = New ControlLibrary.QueriedBox()
        Me.QtbDocument = New ControlLibrary.QueriedBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvProviders = New System.Windows.Forms.DataGridView()
        Me.ColDocument = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TsItems = New System.Windows.Forms.ToolStrip()
        Me.BtnInclude = New System.Windows.Forms.ToolStripButton()
        Me.BtnRemove = New System.Windows.Forms.ToolStripButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvProviders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'QtbName
        '
        Me.QtbName.ConnectionString = Nothing
        Me.QtbName.DbProvider = Nothing
        Me.QtbName.DecimalOnly = False
        Me.QtbName.DecimalPlaces = 2
        Me.QtbName.DropDownAutoStretchRight = False
        Me.QtbName.DropDownStretchLeft = 135
        Me.QtbName.FieldHeader = "Nome"
        Me.QtbName.JoinField = Nothing
        Me.QtbName.JoinPKField = Nothing
        Me.QtbName.JoinTable = Nothing
        Me.QtbName.Location = New System.Drawing.Point(138, 22)
        Me.QtbName.MainField = "NAME"
        Me.QtbName.MainPKField = "ID"
        Me.QtbName.MainTable = "PROVIDER"
        Me.QtbName.Name = "QtbName"
        Me.QtbName.Size = New System.Drawing.Size(383, 23)
        Me.QtbName.TabIndex = 3
        '
        'QtbDocument
        '
        Me.QtbDocument.CharactersToQuery = 2
        Condition1.FieldName = "STATUSID"
        Condition1.Operator = "="
        Condition1.TableName = "PROVIDER"
        Condition1.Value = "@STATUSID"
        Me.QtbDocument.Conditions.Add(Condition1)
        Me.QtbDocument.ConnectionString = Nothing
        Me.QtbDocument.DbProvider = Nothing
        Me.QtbDocument.DecimalOnly = False
        Me.QtbDocument.DecimalPlaces = 2
        Me.QtbDocument.DropDownAutoStretchRight = False
        Me.QtbDocument.DropDownStretchDown = 200
        Me.QtbDocument.DropDownStretchRight = 389
        Me.QtbDocument.FieldHeader = "CPF/CNPJ"
        Me.QtbDocument.JoinField = Nothing
        Me.QtbDocument.JoinPKField = Nothing
        Me.QtbDocument.JoinTable = Nothing
        Me.QtbDocument.Location = New System.Drawing.Point(3, 22)
        Me.QtbDocument.MainField = "DOCUMENT1"
        Me.QtbDocument.MainPKField = "ID"
        Me.QtbDocument.MainTable = "PROVIDER"
        Me.QtbDocument.Name = "QtbDocument"
        OtherField1.FieldHeader = "CIDADE"
        OtherField1.JoinField = Nothing
        OtherField1.JoinPKField = Nothing
        OtherField1.JoinTable = Nothing
        OtherField1.MainField = "CITY"
        OtherField2.FieldHeader = "UF"
        OtherField2.JoinField = Nothing
        OtherField2.JoinPKField = Nothing
        OtherField2.JoinTable = Nothing
        OtherField2.MainField = "STATE"
        Me.QtbDocument.OtherFields.Add(OtherField1)
        Me.QtbDocument.OtherFields.Add(OtherField2)
        Parameter1.ParameterName = "@STATUSID"
        Parameter1.ParameterValue = "0"
        Me.QtbDocument.Parameters.Add(Parameter1)
        Me.QtbDocument.Size = New System.Drawing.Size(129, 23)
        Me.QtbDocument.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.QtbDocument)
        Me.Panel1.Controls.Add(Me.QtbName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 53)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPF/CNPJ"
        '
        'DgvProviders
        '
        Me.DgvProviders.AllowUserToAddRows = False
        Me.DgvProviders.AllowUserToDeleteRows = False
        Me.DgvProviders.AllowUserToOrderColumns = True
        Me.DgvProviders.AllowUserToResizeRows = False
        Me.DgvProviders.BackgroundColor = System.Drawing.Color.White
        Me.DgvProviders.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProviders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColDocument, Me.ColName, Me.ColCity, Me.ColState})
        Me.DgvProviders.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvProviders.Location = New System.Drawing.Point(10, 129)
        Me.DgvProviders.MultiSelect = False
        Me.DgvProviders.Name = "DgvProviders"
        Me.DgvProviders.ReadOnly = True
        Me.DgvProviders.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvProviders.RowHeadersVisible = False
        Me.DgvProviders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProviders.Size = New System.Drawing.Size(527, 171)
        Me.DgvProviders.TabIndex = 3
        '
        'ColDocument
        '
        Me.ColDocument.HeaderText = "CPF/CNPJ"
        Me.ColDocument.Name = "ColDocument"
        Me.ColDocument.ReadOnly = True
        Me.ColDocument.Width = 140
        '
        'ColName
        '
        Me.ColName.HeaderText = "Nome"
        Me.ColName.Name = "ColName"
        Me.ColName.ReadOnly = True
        Me.ColName.Width = 197
        '
        'ColCity
        '
        Me.ColCity.HeaderText = "Cidade"
        Me.ColCity.Name = "ColCity"
        Me.ColCity.ReadOnly = True
        Me.ColCity.Width = 151
        '
        'ColState
        '
        Me.ColState.HeaderText = "UF"
        Me.ColState.Name = "ColState"
        Me.ColState.ReadOnly = True
        Me.ColState.Width = 32
        '
        'TsItems
        '
        Me.TsItems.BackColor = System.Drawing.Color.White
        Me.TsItems.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TsItems.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TsItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnInclude, Me.BtnRemove})
        Me.TsItems.Location = New System.Drawing.Point(10, 104)
        Me.TsItems.Name = "TsItems"
        Me.TsItems.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TsItems.Size = New System.Drawing.Size(527, 25)
        Me.TsItems.TabIndex = 2
        Me.TsItems.Text = "ToolStrip2"
        '
        'BtnInclude
        '
        Me.BtnInclude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnInclude.Enabled = False
        Me.BtnInclude.Image = Global.NetSige.My.Resources.Resources.IncludeSmall
        Me.BtnInclude.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnInclude.Name = "BtnInclude"
        Me.BtnInclude.Size = New System.Drawing.Size(23, 22)
        Me.BtnInclude.Text = "Incluir"
        '
        'BtnRemove
        '
        Me.BtnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnRemove.Enabled = False
        Me.BtnRemove.Image = Global.NetSige.My.Resources.Resources.DeleteSmall
        Me.BtnRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRemove.Margin = New System.Windows.Forms.Padding(0, 1, 10, 2)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(23, 22)
        Me.BtnRemove.Text = "Excluir"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(527, 41)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Escolha os fornecedores que participarão dessa cotação."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcCompositionProviders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DgvProviders)
        Me.Controls.Add(Me.TsItems)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcCompositionProviders"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(547, 350)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvProviders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsItems.ResumeLayout(False)
        Me.TsItems.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QtbName As ControlLibrary.QueriedBox
    Friend WithEvents QtbDocument As ControlLibrary.QueriedBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvProviders As DataGridView
    Friend WithEvents TsItems As ToolStrip
    Friend WithEvents BtnInclude As ToolStripButton
    Friend WithEvents BtnRemove As ToolStripButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ColDocument As DataGridViewTextBoxColumn
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents ColCity As DataGridViewTextBoxColumn
    Friend WithEvents ColState As DataGridViewTextBoxColumn
End Class
