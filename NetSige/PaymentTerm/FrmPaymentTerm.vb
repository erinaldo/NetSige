Imports ControlLibrary
Public Class FrmPaymentTerm
    Private _Payment As PaymentTerm
    Private _FormGrid As FrmPaymentsTermGrid
    Private _Grid As DataGridView
    Private _Filter As PaymentTerm.Filter

    Public Sub New(ByVal Payment As PaymentTerm, ByVal FormGrid As FrmPaymentsTermGrid)
        InitializeComponent()
        _Payment = Payment
        _FormGrid = FormGrid
        _Grid = _FormGrid.DgvData
        _Filter = CType(_FormGrid.PgFilter.SelectedObject, PaymentTerm.Filter)
        TxtName.Select()
    End Sub

    Public Sub New(ByVal Payment As PaymentTerm)
        InitializeComponent()
        BtnFirst.Enabled = False
        BtnPrevious.Enabled = False
        BtnNext.Enabled = False
        BtnLast.Enabled = False
        _Payment = Payment
        TxtName.Select()
    End Sub

    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Common.DataGridViewDoubleBuffered(DgvDays, True)
        LoadPayment()
    End Sub



    Private Sub LoadPayment()
        LblIDValue.Text = _Payment.ID
        BtnStatusValue.Text = _Payment.Status
        LblCreationDateValue.Text = _Payment.CreationDate.ToString("dd/MM/yyyy")
        TxtName.Text = _Payment.Name
        CbxTypeOfDays.Text = _Payment.TypeOfDays
        DgvDays.DataSource = _Payment.CompositionTable
        BtnSave.Enabled = False
        RefreshNavigation()
    End Sub

    Public Sub RefreshNavigation()
        If _FormGrid IsNot Nothing Then
            If _Grid.SelectedRows.Count = 1 Then
                If _Grid.Rows(0).Selected And _Grid.Rows.Count > 1 Then
                    If _Grid.SelectedRows(0).Displayed = False Then
                        _Grid.FirstDisplayedScrollingRowIndex = _Grid.SelectedRows(0).Index
                    End If
                    BtnFirst.Enabled = False
                    BtnPrevious.Enabled = False
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
                ElseIf _Grid.Rows(0).Selected And _Grid.Rows.Count = 1 Then
                    If _Grid.SelectedRows(0).Displayed = False Then
                        _Grid.FirstDisplayedScrollingRowIndex = _Grid.SelectedRows(0).Index
                    End If
                    BtnFirst.Enabled = False
                    BtnPrevious.Enabled = False
                    BtnNext.Enabled = False
                    BtnLast.Enabled = False
                ElseIf _Grid.Rows(_Grid.Rows.Count - 1).Selected Then
                    If _Grid.SelectedRows(0).Displayed = False Then
                        _Grid.FirstDisplayedScrollingRowIndex = _Grid.RowCount - 1
                    End If
                    BtnFirst.Enabled = True
                    BtnPrevious.Enabled = True
                    BtnNext.Enabled = False
                    BtnLast.Enabled = False
                Else
                    If _Grid.SelectedRows(0).Displayed = False Then
                        _Grid.FirstDisplayedScrollingRowIndex = _Grid.SelectedRows(0).Index
                    End If
                    BtnFirst.Enabled = True
                    BtnPrevious.Enabled = True
                    BtnNext.Enabled = True
                    BtnLast.Enabled = True
                End If
            Else
                BtnFirst.Enabled = False
                BtnPrevious.Enabled = False
                BtnNext.Enabled = False
                BtnLast.Enabled = False
            End If
        End If
    End Sub

    Private Sub Changes(sender As Object, e As EventArgs) Handles TxtName.TextChanged,
                                                                  CbxTypeOfDays.SelectedIndexChanged
        BtnSave.Enabled = True
    End Sub



    Private Function IsValidFields() As Boolean
        If TxtName.Text = Nothing Then
            CMessageBox.Show("Por favor informe o nome.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcPayment.SelectedTab = TpMain
            TxtName.Select()
            Return False
        ElseIf CbxTypeOfDays.Text = Nothing Then
            CMessageBox.Show("Por favor informe o tipo de parcela", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcPayment.SelectedTab = TpMain
            CbxTypeOfDays.Select()
            Return False
        ElseIf DgvDays.Columns.count = 0 Then
            CMessageBox.Show("Por favor informe pelo menos uma parcela.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcPayment.SelectedTab = TpDays
            Return False
        End If

        For Each Cell As DataGridViewCell In DgvDays.Rows(0).Cells
            If Cell.Value Is Nothing Or Cell.Value Is DBNull.Value Then
                CMessageBox.Show("Não é possível salvar parcelas em branco.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
                TcPayment.SelectedTab = TpDays
                DgvDays.Rows(0).Cells(Cell.ColumnIndex).Selected = True
                Return False
            End If
        Next Cell

        If DgvDays.Columns.Count > 1 Then
            For Column = 0 To DgvDays.Columns.Count - 1
                If Column = 0 Then
                    If CInt(DgvDays.Rows(0).Cells(0).Value) >= CInt(DgvDays.Rows(0).Cells(1).Value) Then
                        CMessageBox.Show("As parcelas precisam devem ser compostas em ordem crescente e sem repetições.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
                        TcPayment.SelectedTab = TpDays
                        Return False
                    End If
                ElseIf Column = DgvDays.Columns.Count - 1 Then
                    If CInt(DgvDays.Rows(0).Cells(DgvDays.Columns.Count - 1).Value) <= CInt(DgvDays.Rows(0).Cells(Column - 1).Value) Then
                        CMessageBox.Show("As parcelas precisam devem ser compostas em ordem crescente e sem repetições.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
                        TcPayment.SelectedTab = TpDays
                        Return False
                    End If
                Else
                    If CInt(DgvDays.Rows(0).Cells(Column).Value) >= CInt(DgvDays.Rows(0).Cells(Column + 1).Value) Then
                        CMessageBox.Show("As parcelas precisam devem ser compostas em ordem crescente e sem repetições.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
                        TcPayment.SelectedTab = TpDays
                        Return False
                    End If
                End If
            Next Column
        End If


        Return True
    End Function




    Private Sub BtnStatusValue_Click(sender As Object, e As EventArgs) Handles BtnStatusValue.Click
        If BtnStatusValue.Text = "Ativo" Then
            BtnStatusValue.Text = "Inativo"
            If _Payment.Status = "Ativo" Then CMessageBox.Show("O registro foi marcado para ser inativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
        ElseIf BtnStatusValue.Text = "Inativo" Then
            BtnStatusValue.Text = "Ativo"
            If _Payment.Status = "Inativo" Then CMessageBox.Show("O registro foi marcado para ser ativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
        End If
        BtnSave.Enabled = True
    End Sub


    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        If _Grid.SelectedRows.Count = 1 Then
            If _Grid.SelectedRows(0).Index > 0 Then
                _Grid.Rows(0).Selected = True
                _Payment.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadPayment()
            End If
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        If _Grid.SelectedRows.Count = 1 Then
            If _Grid.SelectedRows(0).Index > 0 Then
                _Grid.Rows(_Grid.SelectedRows(0).Index - 1).Selected = True
                _Payment.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadPayment()
            End If
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        If _Grid.SelectedRows.Count = 1 Then
            If _Grid.SelectedRows(0).Index < _Grid.Rows.Count - 1 Then
                _Grid.Rows(_Grid.SelectedRows(0).Index + 1).Selected = True
                _Payment.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadPayment()
            End If
        End If
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        If _Grid.SelectedRows.Count = 1 Then
            If _Grid.SelectedRows(0).Index < _Grid.Rows.Count - 1 Then
                _Grid.Rows(_Grid.Rows.Count - 1).Selected = True
                _Payment.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadPayment()
            End If
        End If
    End Sub

    Private Sub BtnStatusValue_TextChanged(sender As Object, e As EventArgs) Handles BtnStatusValue.TextChanged
        BtnStatusValue.ForeColor = If(BtnStatusValue.Text = "Ativo", Color.DarkBlue, Color.DarkRed)
    End Sub

    Private Function Save() As Boolean
        Dim FirstDisplayedRow As Long
        If IsValidFields() Then
            _Payment.Status = BtnStatusValue.Text
            _Payment.Name = TxtName.Text
            _Payment.TypeOfDays = CbxTypeOfDays.Text
            Try
                _Payment.Save()
                LblIDValue.Text = _Payment.ID
                BtnStatusValue.Text = _Payment.Status
                BtnStatusValue.Enabled = True
                LblCreationDateValue.Text = _Payment.CreationDate.ToString("dd/MM/yyyy")
                BtnSave.Enabled = False
                If _FormGrid IsNot Nothing Then
                    FirstDisplayedRow = If(_Grid.FirstDisplayedScrollingRowIndex < 0, 0, _Grid.FirstDisplayedScrollingRowIndex)
                    _Filter.Filter(If(_Grid.SelectedRows.Count = 1, _Grid.SelectedRows(0).Index, 0))
                    For i = 0 To _Grid.Rows.Count - 1
                        If _Grid.Rows(i).Cells("ID").Value = LblIDValue.Text Then
                            _Grid.Rows(i).Selected = True
                            _Grid.FirstDisplayedScrollingRowIndex = FirstDisplayedRow
                        End If
                    Next i
                    RefreshNavigation()
                End If
                Return True
            Catch ex As Exception
                CMessageBox.Show("ERRO0000", "Ocorreu um erro salvar o registro.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Save()
    End Sub


    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        _Payment = New PaymentTerm
        LoadPayment()
    End Sub

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Insert And e.Control Then
            If BtnInclude.Enabled Then BtnInclude.PerformClick()
        ElseIf e.KeyCode = Keys.Delete And e.Control Then
            If BtnDelete.Enabled Then BtnDelete.PerformClick()
        ElseIf e.KeyCode = Keys.S And e.Control Then
            If BtnSave.Enabled Then BtnSave.PerformClick()
        End If
    End Sub

    Private _Deleting As Boolean
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim FirstDisplayedRow As Integer
        If _Payment.ID <> 0 Then
            If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    _Payment.Delete()
                    If _Grid IsNot Nothing Then
                        FirstDisplayedRow = _Grid.FirstDisplayedScrollingRowIndex
                        _Filter.Filter(_Grid.SelectedRows(0).Index)
                        If FirstDisplayedRow > 0 Then
                            _Grid.FirstDisplayedScrollingRowIndex = FirstDisplayedRow
                        End If
                    End If
                    _Deleting = True
                    Dispose()
                Catch ex As Exception
                    If ex.Message = "constraint failed" & vbCrLf & "FOREIGN KEY constraint failed" Then
                        ex = New Exception("Esse registro está vinculado a outro registro.")
                    End If
                    CMessageBox.Show("ERRO0000", "Ocorreu um erro ao excluir o registro.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
                End Try
            End If
        End If
    End Sub

    Private Sub FrmCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not _Deleting AndAlso BtnSave.Enabled Then
            If BtnSave.Enabled Then
                If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If Not Save() Then e.Cancel = True
                End If
            End If
        End If
        _Deleting = False
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        Dim Form As New FrmLog(Common.Routines.PaymentTerm, _Payment.ID)
        Form.ShowDialog()
    End Sub

    Private Sub BtnIncludeDays_Click(sender As Object, e As EventArgs) Handles BtnIncludeDays.Click
        Dim Column As New DataColumn With {
            .ColumnName = _Payment.CompositionTable.Columns.Count + 1 & " º Prazo",
            .Caption = "0"
        }
        _Payment.CompositionTable.Columns.Add(Column)
        DgvDays.FirstDisplayedScrollingRowIndex = DgvDays.Rows.Count - 1
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnDeleteDays_Click(sender As Object, e As EventArgs) Handles BtnDeleteDays.Click
        If DgvDays.SelectedCells.Count = 1 Then
            If CMessageBox.Show("O prazo selecionado será excluído. Deseja continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                _Payment.CompositionTable.Columns.RemoveAt(DgvDays.SelectedCells(0).ColumnIndex)
                For i = 0 To _Payment.CompositionTable.Columns.Count - 1
                    _Payment.CompositionTable.Columns(i).ColumnName = i + 1 & "ª Parcela"
                Next i
                _Payment.CompositionTable.AcceptChanges()
                BtnSave.Enabled = True
            End If
        End If
    End Sub

    Private Sub DgvContacts_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDays.CellEndEdit
        Dim CellValue As String

        If DgvDays.Rows(e.RowIndex).Cells(e.ColumnIndex).Value IsNot DBNull.Value Then
            CellValue = DgvDays.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            If Not IsNumeric(CellValue) Then
                CMessageBox.Show("Por favor, digite um número que represente a quantidade de dias (prazo) da parcela.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
                CellValue = Nothing
            End If
            DgvDays.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CInt(CellValue)
            BtnSave.Enabled = True
        End If


    End Sub

    Private Sub TcCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TcPayment.SelectedIndexChanged
        If TcPayment.SelectedIndex = 0 Then
            Size = New Size(439, 249)
            FormBorderStyle = FormBorderStyle.FixedSingle
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub


End Class