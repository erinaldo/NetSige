<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UcCompositionGeneral
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.QueriedTextBox1 = New ControlLibrary.QueriedBox()
        Me.SuspendLayout()
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
        Me.Label3.Text = "Geral"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNote
        '
        Me.TxtNote.Location = New System.Drawing.Point(13, 122)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(512, 163)
        Me.TxtNote.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Observação"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Centro de Custo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo de Oferta"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(14, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 6
        '
        'QueriedTextBox1
        '
        Me.QueriedTextBox1.ConnectionString = Nothing
        Me.QueriedTextBox1.DbProvider = Nothing
        Me.QueriedTextBox1.DecimalOnly = False
        Me.QueriedTextBox1.DecimalPlaces = 2
        Me.QueriedTextBox1.DropDownAutoStretchRight = False
        Me.QueriedTextBox1.FieldHeader = Nothing
        Me.QueriedTextBox1.JoinField = Nothing
        Me.QueriedTextBox1.JoinPKField = Nothing
        Me.QueriedTextBox1.JoinTable = Nothing
        Me.QueriedTextBox1.Location = New System.Drawing.Point(138, 74)
        Me.QueriedTextBox1.MainField = Nothing
        Me.QueriedTextBox1.MainPKField = Nothing
        Me.QueriedTextBox1.MainTable = Nothing
        Me.QueriedTextBox1.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.QueriedTextBox1.Name = "QueriedTextBox1"
        Me.QueriedTextBox1.Size = New System.Drawing.Size(388, 23)
        Me.QueriedTextBox1.TabIndex = 7
        '
        'UcCompositionGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.QueriedTextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNote)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UcCompositionGeneral"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(547, 350)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNote As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents QueriedTextBox1 As ControlLibrary.QueriedBox
End Class
