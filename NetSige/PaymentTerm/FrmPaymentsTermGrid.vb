Imports ControlLibrary
Public Class FrmPaymentsTermGrid
    Private _Payment As New PaymentTerm
    Private _Filter As PaymentTerm.Filter
    Public Sub New()
        InitializeComponent()
        SplitContainer1.Panel1Collapsed = True
        SplitContainer1.SplitterDistance = 250
        _Filter = New PaymentTerm.Filter(DgvData)
        _Filter.Filter()
        PgFilter.SelectedObject = _Filter
        PgFilter.ExpandAllGridItems()
        Common.DataGridViewDoubleBuffered(DgvData, True)
    End Sub
    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        Dim Form As New FrmPaymentTerm(New PaymentTerm, Me)
        Form.ShowDialog()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim Form As FrmPaymentTerm
        If DgvData.SelectedRows.Count = 1 Then
            Try
                _Payment = New PaymentTerm(DgvData.SelectedRows(0).Cells("ID").Value)
                Form = New FrmPaymentTerm(_Payment, Me)
                Form.DgvDays.DataSource = _Payment.CompositionTable
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
                    _Payment.Load((DgvData.SelectedRows(0).Cells("ID").Value))
                    Try
                        _Payment.Delete()
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
    End Sub
    Private Sub BtnFilter2_Click(sender As Object, e As EventArgs) Handles BtnFilter2.Click
        _Filter.Filter()
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
                Case Is = "Ativo"
                    e.CellStyle.ForeColor = Color.DarkBlue
                Case Is = "Bloqueado"
                    e.CellStyle.ForeColor = Color.DarkRed
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
        End If
    End Sub
    Private Sub PgFilter_PropertyValueChanged(s As Object, e As PropertyValueChangedEventArgs) Handles PgFilter.PropertyValueChanged
        BtnFilter2.PerformClick()
    End Sub
End Class