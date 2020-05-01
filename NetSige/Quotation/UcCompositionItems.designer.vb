<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UcCompositionItems
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
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
        Me.DgvItems = New System.Windows.Forms.DataGridView()
        Me.ColQtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColComp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TsItems = New System.Windows.Forms.ToolStrip()
        Me.BtnInclude = New System.Windows.Forms.ToolStripButton()
        Me.BtnRemove = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtComplement = New System.Windows.Forms.TextBox()
        Me.DtbQtd = New ControlLibrary.DecimalBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QtbName = New ControlLibrary.QueriedBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TsItems.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DgvItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColQtd, Me.ColName, Me.ColComp})
        Me.DgvItems.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvItems.Location = New System.Drawing.Point(10, 129)
        Me.DgvItems.MultiSelect = False
        Me.DgvItems.Name = "DgvItems"
        Me.DgvItems.ReadOnly = True
        Me.DgvItems.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DgvItems.RowHeadersVisible = False
        Me.DgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvItems.Size = New System.Drawing.Size(527, 171)
        Me.DgvItems.TabIndex = 3
        '
        'ColQtd
        '
        Me.ColQtd.HeaderText = "Qtd."
        Me.ColQtd.Name = "ColQtd"
        Me.ColQtd.ReadOnly = True
        Me.ColQtd.Width = 80
        '
        'ColName
        '
        Me.ColName.HeaderText = "Nome"
        Me.ColName.Name = "ColName"
        Me.ColName.ReadOnly = True
        Me.ColName.Width = 300
        '
        'ColComp
        '
        Me.ColComp.HeaderText = "Complemento"
        Me.ColComp.Name = "ColComp"
        Me.ColComp.ReadOnly = True
        Me.ColComp.Width = 140
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TxtComplement)
        Me.Panel1.Controls.Add(Me.DtbQtd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.QtbName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 53)
        Me.Panel1.TabIndex = 1
        '
        'TxtComplement
        '
        Me.TxtComplement.Location = New System.Drawing.Point(359, 22)
        Me.TxtComplement.Name = "TxtComplement"
        Me.TxtComplement.Size = New System.Drawing.Size(160, 23)
        Me.TxtComplement.TabIndex = 5
        '
        'DtbQtd
        '
        Me.DtbQtd.DecimalOnly = True
        Me.DtbQtd.DecimalPlaces = 2
        Me.DtbQtd.Location = New System.Drawing.Point(4, 22)
        Me.DtbQtd.Name = "DtbQtd"
        Me.DtbQtd.Size = New System.Drawing.Size(81, 23)
        Me.DtbQtd.TabIndex = 3
        Me.DtbQtd.Text = "0,00"
        Me.DtbQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(356, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Complemento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 5)
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
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Qtd."
        '
        'QtbName
        '
        Me.QtbName.CharactersToQuery = 2
        Me.QtbName.ConnectionString = Nothing
        Me.QtbName.DbProvider = Nothing
        Me.QtbName.DecimalOnly = False
        Me.QtbName.DecimalPlaces = 2
        Me.QtbName.DropDownAutoStretchRight = False
        Me.QtbName.DropDownStretchLeft = 87
        Me.QtbName.FieldHeader = "Nome"
        Me.QtbName.JoinField = Nothing
        Me.QtbName.JoinPKField = Nothing
        Me.QtbName.JoinTable = Nothing
        Me.QtbName.Location = New System.Drawing.Point(91, 22)
        Me.QtbName.MainField = "NAME"
        Me.QtbName.MainPKField = "ID"
        Me.QtbName.MainTable = "ITEM"
        Me.QtbName.Name = "QtbName"
        Me.QtbName.Size = New System.Drawing.Size(262, 23)
        Me.QtbName.TabIndex = 4
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
        Me.Label3.Text = "Escolha os itens dessa cotação."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UcCompositionItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DgvItems)
        Me.Controls.Add(Me.TsItems)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcCompositionItems"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(547, 350)
        CType(Me.DgvItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TsItems.ResumeLayout(False)
        Me.TsItems.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvItems As DataGridView
    Friend WithEvents TsItems As ToolStrip
    Friend WithEvents BtnInclude As ToolStripButton
    Friend WithEvents BtnRemove As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents QtbName As ControlLibrary.QueriedBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DtbQtd As ControlLibrary.DecimalBox
    Friend WithEvents TxtComplement As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ColQtd As DataGridViewTextBoxColumn
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents ColComp As DataGridViewTextBoxColumn
End Class
