Imports System.Data.SQLite
Imports System.IO
Public Class FrmMain
    Private LogoutClick As Boolean
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TableReports As New DataTable
        Dim TableGoups As New DataTable
        Dim Report As FileInfo
        Dim Button As ToolStripMenuItem

        Try
            Using Con As New SQLiteConnection(Common.ConnectionString)
                Con.Open()
                Using Com As New SQLiteCommand(My.Resources.ReportSelect, Con)
                    Using Adp As New SQLiteDataAdapter(Com)
                        Adp.Fill(TableReports)
                    End Using
                    'Using DbReader As SQLiteDataReader = Com.ExecuteReader
                    'If DbReader.HasRows Then
                    'Do While DbReader.Read
                    'Report = New FileInfo(DbReader.GetString(1))
                    'Using FileReader As StreamReader = Report.OpenText
                    '    Do Until FileReader.EndOfStream
                    '        Line = FileReader.ReadLine
                    '        If Strings.Left(Line, 3) = "GRP" Then Group = Strings.Right(Line, Line.Length - 4)
                    '        If Strings.Left(Line, 3) = "DSP" Then Path = Strings.Right(Line, Line.Length - 4)

                    '    Loop
                    'End Using
                    'Button = New ToolStripMenuItem()
                    'Button.Text = IO.Path.GetFileNameWithoutExtension(Report.Name)
                    'Button.Tag = Report.FullName
                    'BtnReports.DropDownItems.Add(Button)

                    'Loop
                    'End If
                    'End Using
                    'Com.ExecuteReader()
                End Using
            End Using
            If TableReports.Rows.Count > 0 Then
                TableGoups = TableReports.DefaultView.ToTable(True, "REPORTGROUP")
                For Each RowGroup As DataRow In TableGoups.Rows
                    Button = New ToolStripMenuItem
                    Button.Text = RowGroup.Item("REPORTGROUP").ToString
                    Button.Font = New Font(Button.Font, FontStyle.Regular)
                    BtnReports.DropDownItems.Add(Button)
                    For Each RowReport As DataRow In TableReports.Rows
                        If RowReport.Item("REPORTGROUP").ToString = RowGroup.Item("REPORTGROUP").ToString Then
                            For Each Item As ToolStripMenuItem In BtnReports.DropDownItems.OfType(Of ToolStripMenuItem)
                                If Item.Text = RowReport.Item("REPORTGROUP").ToString Then
                                    Button = New ToolStripMenuItem
                                    Button.Text = RowReport.Item("NAME").ToString
                                    Button.Tag = RowReport.Item("PATH").ToString
                                    Button.Font = New Font(Button.Font, FontStyle.Regular)
                                    Item.DropDownItems.Add(Button)
                                    AddHandler Button.Click, AddressOf BtnReport_Click
                                End If
                            Next Item
                        End If
                    Next RowReport
                Next RowGroup

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnReport_Click(sender As Object, e As EventArgs)
        Dim Frm As New FrmReportRunner(sender.Tag)
        Frm.ShowDialog()
    End Sub
    Private Sub FrmPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If Session.Logged Then Session.Logout()
        If Not LogoutClick Then Application.Exit()
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            BtnQuotations.PerformClick()
        ElseIf e.KeyCode = Keys.F2 Then
            BtnOrders.PerformClick()
        ElseIf e.KeyCode = Keys.F3 Then
            BtnPersons.PerformClick()
        ElseIf e.KeyCode = Keys.F4 Then
            BtnItems.PerformButtonClick()
        ElseIf e.KeyCode = Keys.F5 Then
            BtnUsers.PerformButtonClick()
        ElseIf e.KeyCode = Keys.F6 Then
            BtnTables.ShowDropDown()
        ElseIf e.KeyCode = Keys.F7 Then
            BtnReports.ShowDropDown()
        ElseIf e.KeyCode = Keys.F8 Then
            BtnPanels.ShowDropDown()
        ElseIf e.KeyCode = Keys.F9 Then
            BtnLogout.PerformClick()
        End If
    End Sub
    Private Sub BtnProviders_Click(sender As Object, e As EventArgs) Handles BtnPersons.Click
        Dim Form As New FrmPersonsGrid() With {
             .TopMost = False,
             .TopLevel = False,
             .Location = New Point(0, 0),
             .Height = Height - 170,
             .Width = Width - 25
        }
        Dim Page As New TabPage With {
            .Text = "Pessoas",
            .AutoScroll = True
        }
        Page.Controls.Add(Form)
        With TabCtrlWindows
            .Controls.Add(Page)
            .SelectTab(TabCtrlWindows.TabCount - 1)
        End With
        Form.Show()
    End Sub
    Private Sub BtnUsers_Click(sender As Object, e As EventArgs) Handles BtnUsers.ButtonClick
        Dim Form As New FrmUsersGrid() With {
            .TopMost = False,
            .TopLevel = False,
            .Location = New Point(0, 0),
            .Height = Height - 170,
            .Width = Width - 25
        }
        Dim Page As New TabPage With {
            .Text = "Usuários",
            .AutoScroll = True
        }
        Page.Controls.Add(Form)
        With TabCtrlWindows
            .Controls.Add(Page)
            .SelectTab(TabCtrlWindows.TabCount - 1)
        End With
        Form.Show()
    End Sub
    Private Sub BtnUnit_Click(sender As Object, e As EventArgs) Handles BtnUnit.Click
        Dim Form As New FrmItemUnitsGrid() With {
            .TopMost = False,
            .TopLevel = False,
            .Location = New Point(0, 0),
            .Height = Height - 170,
            .Width = Width - 25
        }
        Dim Page As New TabPage With {
            .Text = "Unidades de Medida",
            .AutoScroll = True
        }
        Page.Controls.Add(Form)
        With TabCtrlWindows
            .Controls.Add(Page)
            .SelectTab(TabCtrlWindows.TabCount - 1)
        End With
        Form.Show()
    End Sub
    Private Sub BtnGroup_Click(sender As Object, e As EventArgs) Handles BtnGroup.Click
        Dim Form As New FrmItemGroupsGrid() With {
            .TopMost = False,
            .TopLevel = False,
            .Location = New Point(0, 0),
            .Height = Height - 170,
            .Width = Width - 25
        }
        Dim Page As New TabPage With {
            .Text = "Grupos de Item",
            .AutoScroll = True
        }
        Page.Controls.Add(Form)
        With TabCtrlWindows
            .Controls.Add(Page)
            .SelectTab(TabCtrlWindows.TabCount - 1)
        End With
        Form.Show()
    End Sub
    Private Sub BtnItems_ButtonClick(sender As Object, e As EventArgs) Handles BtnItems.ButtonClick
        Dim Form As New FrmItemsGrid() With {
            .TopMost = False,
            .TopLevel = False,
            .Location = New Point(0, 0),
            .Height = Height - 170,
            .Width = Width - 25
        }
        Dim Page As New TabPage With {
            .Text = "Itens",
            .AutoScroll = True
        }
        Page.Controls.Add(Form)
        With TabCtrlWindows
            .Controls.Add(Page)
            .SelectTab(TabCtrlWindows.TabCount - 1)
        End With
        Form.Show()
    End Sub
    Private Sub BtnQuotations_Click(sender As Object, e As EventArgs) Handles BtnQuotations.Click
        Dim Form As New FrmQuotationsGrid() With {
            .TopMost = False,
            .TopLevel = False,
            .Location = New Point(0, 0),
            .Height = Height - 170,
            .Width = Width - 25
        }
        Dim Page As New TabPage With {
            .Text = "Cotações",
            .AutoScroll = True
        }
        Page.Controls.Add(Form)
        With TabCtrlWindows
            .Controls.Add(Page)
            .SelectTab(TabCtrlWindows.TabCount - 1)
        End With
        Form.Show()
    End Sub
    Private Sub BtnCostSharing_Click(sender As Object, e As EventArgs) Handles BtnCostSharing.Click
        Dim Form As New FrmCostSharingGrid() With {
            .TopMost = False,
            .TopLevel = False,
            .Location = New Point(0, 0),
            .Height = Height - 170,
            .Width = Width - 25
        }
        Dim Page As New TabPage With {
            .Text = "Centros de Custo",
            .AutoScroll = True
        }
        Page.Controls.Add(Form)
        With TabCtrlWindows
            .Controls.Add(Page)
            .SelectTab(TabCtrlWindows.TabCount - 1)
        End With
        Form.Show()
    End Sub
    Private Sub BtnPayments_Click(sender As Object, e As EventArgs) Handles BtnPayments.Click
        Dim Form As New FrmPaymentsTermGrid() With {
            .TopMost = False,
            .TopLevel = False,
            .Location = New Point(0, 0),
            .Height = Height - 170,
            .Width = Width - 25
        }
        Dim Page As New TabPage With {
            .Text = "Prazos de Pagamento",
            .AutoScroll = True
        }
        Page.Controls.Add(Form)
        With TabCtrlWindows
            .Controls.Add(Page)
            .SelectTab(TabCtrlWindows.TabCount - 1)
        End With
        Form.Show()
    End Sub
    Private Sub BtnOrders_Click(sender As Object, e As EventArgs) Handles BtnOrders.Click
        Dim Form As New FrmOrdersGrid() With {
            .TopMost = False,
            .TopLevel = False,
            .Location = New Point(0, 0),
            .Height = Height - 170,
            .Width = Width - 25
        }
        Dim Page As New TabPage With {
            .Text = "Pedidos de Compra",
            .AutoScroll = True
        }
        Page.Controls.Add(Form)
        With TabCtrlWindows
            .Controls.Add(Page)
            .SelectTab(TabCtrlWindows.TabCount - 1)
        End With
        Form.Show()
    End Sub
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        LogoutClick = True
        Session.Logout()
        Close()
        FrmLogin.Show()

    End Sub
    Private Sub BtnReportManager_Click(sender As Object, e As EventArgs) Handles BtnReportManager.Click
        FrmReportManager.ShowDialog()
    End Sub
End Class
