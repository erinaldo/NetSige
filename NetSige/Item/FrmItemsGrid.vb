Imports ControlLibrary
Imports System.IO
Public Class FrmItemsGrid
    Private _Item As New Item
    Private _Filter As Item.Filter
    Public Sub New()
        InitializeComponent()
        SplitContainer1.Panel1Collapsed = True
        SplitContainer1.SplitterDistance = 250
        SplitContainer2.Panel1Collapsed = True
        SplitContainer2.SplitterDistance = 300
        _Filter = New Item.Filter(DgvData)
        _Filter.Filter()
        PgFilter.SelectedObject = _Filter
        PgFilter.ExpandAllGridItems()
        Common.DataGridViewDoubleBuffered(DgvData, True)
    End Sub
    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        Dim Form As New FrmItem(New Item, Me)
        Form.ShowDialog()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim Form As FrmItem
        If DgvData.SelectedRows.Count = 1 Then
            Try
                _Item = New Item(DgvData.SelectedRows(0).Cells("ID").Value)
                Form = New FrmItem(_Item, Me)
                Form.ShowDialog()
            Catch ex As Exception
                CMessageBox.Show("ERRO0000", "Ocorreu um erro ao carregar o registro.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
            End Try
        End If
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DgvData.SelectedRows.Count = 1 Then
            If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    _Item.Load((DgvData.SelectedRows(0).Cells("ID").Value))
                    Try
                        _Item.Delete()
                        _Filter.Filter(DgvData.SelectedRows(0).Index)
                    Catch ex As Exception
                        If ex.Message = "constraint failed" & vbCrLf & "FOREIGN KEY constraint failed" Then
                            ex = New Exception("Esse registro está vinculado a outro registro.")
                        End If
                        CMessageBox.Show("ERRO0000", "Ocorreu um erro ao excluir o registro.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
                    End Try
                Catch ex As Exception
                    CMessageBox.Show("ERRO0000", "Ocorreu um erro ao excluir o registro.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
                End Try
            End If
        End If
    End Sub
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Dim SelectedRow As Integer = 0
        If DgvData.SelectedRows.Count = 1 Then
            SelectedRow = DgvData.SelectedRows(0).Index
        End If
        _Filter.Filter(SelectedRow)
    End Sub
    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        SplitContainer1.Panel1Collapsed = If(BtnFilter.Checked, False, True)
        SplitContainer1.SplitterDistance = 350
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim Index As Integer = FrmMain.TabCtrlWindows.SelectedIndex
        FrmMain.TabCtrlWindows.TabPages.Remove(FrmMain.TabCtrlWindows.SelectedTab)
        If Index > 0 Then
            FrmMain.TabCtrlWindows.SelectTab(Index - 1)
        End If
    End Sub
    Private Sub BtnCloseFilter_Click(sender As Object, e As EventArgs) Handles BtnCloseFilter.Click
        SplitContainer1.Panel1Collapsed = True
        BtnFilter.Checked = False
    End Sub
    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        _Filter.Clean()
        PgFilter.Refresh()
        With LblStatus
            .Text = Nothing
            .ForeColor = Color.Black
            .Font = New Font(.Font, FontStyle.Regular)
        End With
    End Sub
    Private Sub BtnFilter2_Click(sender As Object, e As EventArgs) Handles BtnFilter2.Click
        If _Filter.Filter() = True Then
            With LblStatus
                .Text = "Filtro Ativo"
                .ForeColor = Color.DarkRed
                .Font = New Font(.Font, FontStyle.Bold)
            End With
        Else
            With LblStatus
                .Text = Nothing
                .ForeColor = Color.Black
                .Font = New Font(.Font, FontStyle.Regular)
            End With
        End If
    End Sub
    Private Sub DgvData_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DgvData.MouseDoubleClick
        Dim ClickPlace As DataGridView.HitTestInfo = DgvData.HitTest(e.X, e.Y)
        If ClickPlace.Type = DataGridViewHitTestType.Cell Then
            BtnEdit.PerformClick()
        End If
    End Sub
    Private Sub DgvData_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvData.CellFormatting
        If e.ColumnIndex = DgvData.Columns("STATUS").Index Then
            Select Case e.Value
                Case Is = "Pendente"
                    e.CellStyle.ForeColor = Color.DarkBlue
                Case Is = "Cancelado"
                    e.CellStyle.ForeColor = Color.DarkRed
                Case Is = "Parc. Recebido"
                    e.CellStyle.ForeColor = Color.DarkOrange
                Case Is = "Recebido"
                    e.CellStyle.ForeColor = Color.DarkGreen
            End Select
        End If
    End Sub
    Private Sub DgvData_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvData.KeyDown
        If e.KeyCode = Keys.Enter And DgvData.SelectedRows.Count = 1 Then
            BtnEdit.PerformClick()
        ElseIf e.KeyCode = Keys.F Then
            BtnFilter.PerformClick()
        ElseIf e.KeyCode = Keys.Insert Then
            BtnInclude.PerformClick()
        ElseIf e.KeyCode = Keys.Delete Then
            BtnDelete.PerformClick()
        ElseIf e.KeyCode = Keys.A Then
            BtnRefresh.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            BtnClose.PerformClick()
        ElseIf e.KeyCode = Keys.D Then
            BtnDetails.PerformClick()
        End If
    End Sub

    Private Sub LoadDetails()
        Dim Item As Item
        If BtnDetails.Checked Then
            Try
                If DgvData.SelectedRows.Count = 1 Then
                    Item = New Item(DgvData.SelectedRows(0).Cells("ID").Value)
                    If Item.PhotoPath <> Nothing AndAlso File.Exists(Item.PhotoPath) Then
                        PbxPhoto.Image = GetCopyImage(Item.PhotoPath)
                    Else
                        PbxPhoto.Image = Nothing
                    End If
                    Item.GetTransactions(DgvTransactions)
                Else
                    PbxPhoto.Image = Nothing
                    DgvTransactions.DataSource = Nothing
                End If
            Catch ex As Exception
                CMessageBox.Show("ERRO0000", "Ocorreu um erro ao consultar o item selecionado.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
            End Try
        End If
    End Sub

    Private Sub BtnDetails_Click(sender As Object, e As EventArgs) Handles BtnDetails.Click
        SplitContainer2.Panel1Collapsed = If(BtnDetails.Checked, False, True)
        LoadDetails()
    End Sub
    Private Sub BtnCloseDetails_Click(sender As Object, e As EventArgs) Handles BtnCloseDetails.Click, BtnCloseDetails2.Click
        SplitContainer2.Panel1Collapsed = True
        BtnDetails.Checked = False
    End Sub


    Private Sub DgvData_SelectionChanged(sender As Object, e As EventArgs) Handles DgvData.SelectionChanged
        LoadDetails()
    End Sub
    Private Function GetCopyImage(ByVal path As String) As Image
        Using image As Image = Image.FromFile(path)
            Dim bitmap As Bitmap = New Bitmap(image)
            Return bitmap
        End Using
    End Function
    Private Sub PgFilter_PropertyValueChanged(s As Object, e As PropertyValueChangedEventArgs) Handles PgFilter.PropertyValueChanged
        BtnFilter2.PerformClick()
    End Sub
End Class