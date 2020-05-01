<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocument
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtZipCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtState = New System.Windows.Forms.TextBox()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.TxtDistrict = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.TxtNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtComplement = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 322)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 44)
        Me.Panel1.TabIndex = 8
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnSave.Location = New System.Drawing.Point(276, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(95, 30)
        Me.BtnSave.TabIndex = 3
        Me.BtnSave.Text = "Importar"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(377, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(95, 30)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "Fechar"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtComplement)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtNumber)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtZipCode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtState)
        Me.GroupBox2.Controls.Add(Me.TxtCity)
        Me.GroupBox2.Controls.Add(Me.TxtDistrict)
        Me.GroupBox2.Controls.Add(Me.TxtAddress)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 170)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço"
        '
        'TxtZipCode
        '
        Me.TxtZipCode.Location = New System.Drawing.Point(6, 39)
        Me.TxtZipCode.MaxLength = 10
        Me.TxtZipCode.Name = "TxtZipCode"
        Me.TxtZipCode.ReadOnly = True
        Me.TxtZipCode.Size = New System.Drawing.Size(73, 23)
        Me.TxtZipCode.TabIndex = 2
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
        'TxtState
        '
        Me.TxtState.Location = New System.Drawing.Point(382, 138)
        Me.TxtState.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtState.Name = "TxtState"
        Me.TxtState.ReadOnly = True
        Me.TxtState.Size = New System.Drawing.Size(72, 23)
        Me.TxtState.TabIndex = 9
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(205, 138)
        Me.TxtCity.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.ReadOnly = True
        Me.TxtCity.Size = New System.Drawing.Size(171, 23)
        Me.TxtCity.TabIndex = 9
        '
        'TxtDistrict
        '
        Me.TxtDistrict.Location = New System.Drawing.Point(6, 138)
        Me.TxtDistrict.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtDistrict.Name = "TxtDistrict"
        Me.TxtDistrict.ReadOnly = True
        Me.TxtDistrict.Size = New System.Drawing.Size(193, 23)
        Me.TxtDistrict.TabIndex = 8
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(85, 39)
        Me.TxtAddress.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.ReadOnly = True
        Me.TxtAddress.Size = New System.Drawing.Size(300, 23)
        Me.TxtAddress.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(379, 118)
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
        Me.Label7.Location = New System.Drawing.Point(82, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Endereço"
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 119)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identificação"
        '
        'TxtDocument1
        '
        Me.TxtDocument1.Location = New System.Drawing.Point(6, 88)
        Me.TxtDocument1.Name = "TxtDocument1"
        Me.TxtDocument1.ReadOnly = True
        Me.TxtDocument1.Size = New System.Drawing.Size(136, 23)
        Me.TxtDocument1.TabIndex = 9
        '
        'TxtDocument3
        '
        Me.TxtDocument3.Location = New System.Drawing.Point(304, 88)
        Me.TxtDocument3.Name = "TxtDocument3"
        Me.TxtDocument3.ReadOnly = True
        Me.TxtDocument3.Size = New System.Drawing.Size(150, 23)
        Me.TxtDocument3.TabIndex = 11
        '
        'TxtDocument2
        '
        Me.TxtDocument2.Location = New System.Drawing.Point(148, 88)
        Me.TxtDocument2.Name = "TxtDocument2"
        Me.TxtDocument2.ReadOnly = True
        Me.TxtDocument2.Size = New System.Drawing.Size(150, 23)
        Me.TxtDocument2.TabIndex = 10
        '
        'TxtBusinessName
        '
        Me.TxtBusinessName.Location = New System.Drawing.Point(287, 39)
        Me.TxtBusinessName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtBusinessName.Name = "TxtBusinessName"
        Me.TxtBusinessName.ReadOnly = True
        Me.TxtBusinessName.Size = New System.Drawing.Size(167, 23)
        Me.TxtBusinessName.TabIndex = 4
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(5, 39)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(276, 23)
        Me.TxtName.TabIndex = 1
        '
        'LblDocument3
        '
        Me.LblDocument3.AutoSize = True
        Me.LblDocument3.Location = New System.Drawing.Point(301, 68)
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
        Me.LblDocument2.Location = New System.Drawing.Point(145, 68)
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
        Me.LblDocument1.TabIndex = 6
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
        'TxtNumber
        '
        Me.TxtNumber.Location = New System.Drawing.Point(391, 39)
        Me.TxtNumber.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtNumber.MaxLength = 100
        Me.TxtNumber.Name = "TxtNumber"
        Me.TxtNumber.ReadOnly = True
        Me.TxtNumber.Size = New System.Drawing.Size(63, 23)
        Me.TxtNumber.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Número"
        '
        'TxtComplement
        '
        Me.TxtComplement.Location = New System.Drawing.Point(5, 89)
        Me.TxtComplement.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.TxtComplement.MaxLength = 100
        Me.TxtComplement.Name = "TxtComplement"
        Me.TxtComplement.ReadOnly = True
        Me.TxtComplement.Size = New System.Drawing.Size(451, 23)
        Me.TxtComplement.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Complemento"
        '
        'FrmDocument
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 366)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocument"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Consulta de CNPJ"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtZipCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtState As TextBox
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents TxtDistrict As TextBox
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
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
    Friend WithEvents TxtNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtComplement As TextBox
    Friend WithEvents Label5 As Label
End Class
