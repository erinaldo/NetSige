﻿Imports ControlLibrary
Public Class FrmItemUnit
    Private _Unit As ItemUnit
    Private _FormGrid As FrmItemUnitsGrid
    Private _Grid As DataGridView
    Private _Filter As ItemUnit.Filter

    Public Sub New(ByVal Unit As ItemUnit, ByVal FormGrid As FrmItemUnitsGrid)
        InitializeComponent()
        _Unit = Unit
        _FormGrid = FormGrid
        _Grid = _FormGrid.DgvData
        _Filter = CType(_FormGrid.PgFilter.SelectedObject, ItemUnit.Filter)
        TxtName.Select()
    End Sub

    Public Sub New(ByVal Unit As ItemUnit)
        InitializeComponent()
        BtnFirst.Enabled = False
        BtnPrevious.Enabled = False
        BtnNext.Enabled = False
        BtnLast.Enabled = False
        _Unit = Unit
        TxtName.Select()
    End Sub

    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadUnit()
    End Sub

    Private Sub LoadUnit()
        LblIDValue.Text = _Unit.ID
        BtnStatusValue.Text = _Unit.Status
        LblCreationDateValue.Text = _Unit.CreationDate.ToString("dd/MM/yyyy")
        TxtName.Text = _Unit.Name
        TxtInitials.Text = _Unit.Initials
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
                                                                  TxtInitials.TextChanged
        BtnSave.Enabled = True
    End Sub

    Private Function IsValidFields() As Boolean
        If TxtName.Text = Nothing Then
            CMessageBox.Show("Por favor informe o nome.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcCustomer.SelectedTab = TpMain
            TxtName.Select()
            Return False
        ElseIf TxtInitials.Text = Nothing Then
            CMessageBox.Show("Por favor informe a sigla.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcCustomer.SelectedTab = TpMain
            TxtInitials.Select()
            Return False
        End If
        Return True
    End Function

    Private Sub BtnStatusValue_Click(sender As Object, e As EventArgs) Handles BtnStatusValue.Click
        If BtnStatusValue.Text = "Ativo" Then
            BtnStatusValue.Text = "Inativo"
            If _Unit.Status = "Ativo" Then CMessageBox.Show("O registro foi marcado para ser inativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
        ElseIf BtnStatusValue.Text = "Inativo" Then
            BtnStatusValue.Text = "Ativo"
            If _Unit.Status = "Inativo" Then CMessageBox.Show("O registro foi marcado para ser ativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
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
                _Unit.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadUnit()
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
                _Unit.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadUnit()
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
                _Unit.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadUnit()
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
                _Unit.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadUnit()
            End If
        End If
    End Sub

    Private Sub BtnStatusValue_TextChanged(sender As Object, e As EventArgs) Handles BtnStatusValue.TextChanged
        BtnStatusValue.ForeColor = If(BtnStatusValue.Text = "Ativo", Color.DarkBlue, Color.DarkRed)
    End Sub

    Private Function Save() As Boolean
        Dim FirstDisplayedRow As Long
        If IsValidFields() Then
            _Unit.Status = BtnStatusValue.Text
            _Unit.Name = TxtName.Text
            _Unit.Initials = TxtInitials.Text
            Try
                _Unit.Save()
                LblIDValue.Text = _Unit.ID
                BtnStatusValue.Text = _Unit.Status
                BtnStatusValue.Enabled = True
                LblCreationDateValue.Text = _Unit.CreationDate.ToString("dd/MM/yyyy")
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
                    TxtName.Select()
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
        _Unit = New ItemUnit
        LoadUnit()
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
        If _Unit.ID <> 0 Then
            If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    _Unit.Delete()
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
        Dim Form As New FrmLog(Common.Routines.ItemUnit, _Unit.ID)
        Form.ShowDialog()
    End Sub


End Class