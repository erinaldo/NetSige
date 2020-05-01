Imports ControlLibrary
Public Class FrmUser
    Private _User As User
    Private _FormGrid As FrmUsersGrid
    Private _Grid As DataGridView
    Private _Filter As User.Filter

    Public Sub New(ByVal User As User, ByVal FormGrid As FrmUsersGrid)
        InitializeComponent()
        _User = User
        _FormGrid = FormGrid
        _Grid = _FormGrid.DgvData
        _Filter = CType(_FormGrid.PgFilter.SelectedObject, User.Filter)
        TxtName.Select()
    End Sub

    Public Sub New(ByVal User As User)
        InitializeComponent()
        BtnFirst.Enabled = False
        BtnPrevious.Enabled = False
        BtnNext.Enabled = False
        BtnLast.Enabled = False
        _User = User
        TxtName.Select()
    End Sub

    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadUser()
        Tip.SetToolTip(TxtPhone, "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000" & vbNewLine & "Com ou sem mascara.")
    End Sub

    Private Sub LoadUser()
        LblIDValue.Text = _User.ID
        BtnStatusValue.Text = _User.Status
        LblCreationDateValue.Text = _User.CreationDate.ToString("dd/MM/yyyy")
        TxtName.Text = _User.Name
        TxtUsername.Text = _User.Username
        TxtPhone.Text = _User.Phone
        TxtEmail.Text = _User.Email
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

    Private Sub TextsChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged,
                                                                       TxtUsername.TextChanged,
                                                                       TxtPhone.TextChanged,
                                                                       TxtEmail.TextChanged
        BtnSave.Enabled = True
    End Sub

    Private Function IsValidFields() As Boolean
        If TxtName.Text = Nothing Then
            CMessageBox.Show("Por favor informe o nome.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtName.Select()
            Return False
        ElseIf TxtUsername.Text = Nothing Then
            CMessageBox.Show("Por favor informe o usuário.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtUsername.Select()
            Return False
        ElseIf TxtPhone.Text = Nothing Then
            CMessageBox.Show("Por favor informe o telefone.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtPhone.Select()
            Return False
        ElseIf TxtEmail.Text = Nothing Then
            CMessageBox.Show("Por favor informe o e-mail.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtEmail.Select()
            Return False
        End If
        Return True
    End Function

    Private Sub BtnStatusValue_Click(sender As Object, e As EventArgs) Handles BtnStatusValue.Click
        If BtnStatusValue.Text = "Ativo" Then
            BtnStatusValue.Text = "Inativo"
            If _User.Status = "Ativo" Then CMessageBox.Show("O Registro foi marcado para ser inativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
        ElseIf BtnStatusValue.Text = "Inativo" Then
            BtnStatusValue.Text = "Ativo"
            If _User.Status = "Inativo" Then CMessageBox.Show("O Registro foi marcado para ser ativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
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
                _User.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadUser()
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
                _User.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadUser()
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
                _User.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadUser()
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
                _User.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadUser()
            End If
        End If
    End Sub

    Private Sub BtnStatusValue_TextChanged(sender As Object, e As EventArgs) Handles BtnStatusValue.TextChanged
        BtnStatusValue.ForeColor = If(BtnStatusValue.Text = "Ativo", Color.DarkBlue, Color.DarkRed)
    End Sub

    Private Function Save() As Boolean
        Dim FirstDisplayedRow As Long
        If IsValidFields() Then
            _User.Status = BtnStatusValue.Text
            _User.Name = TxtName.Text
            _User.Username = TxtUsername.Text
            _User.Phone = TxtPhone.Text
            _User.Email = TxtEmail.Text
            Try
                _User.Save()
                LblIDValue.Text = _User.ID
                BtnStatusValue.Text = _User.Status
                BtnStatusValue.Enabled = True
                LblCreationDateValue.Text = _User.CreationDate.ToString("dd/MM/yyyy")
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

    Private Sub TxtPhone_LostFocus(sender As Object, e As EventArgs) Handles TxtPhone.LostFocus
        Dim Phone As String = TxtPhone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "")
        If IsNumeric(Phone) Then
            If Phone.Length = 10 Then
                Phone = "(" & Phone.Substring(0, 2) & ") " & Phone.Substring(2, 4) & "-" & Phone.Substring(6, 4)
            ElseIf Phone.Length = 11 Then
                If Strings.Left(Phone, 4) = "0300" Or Strings.Left(Phone, 4) = "0500" Or
                               Strings.Left(Phone, 4) = "0800" Or Strings.Left(Phone, 4) = "0900" Then
                    Phone = Phone.Substring(0, 4) & "-" & Phone.Substring(4, 3) & "-" & Phone.Substring(7, 4)
                Else
                    Phone = "(" & Phone.Substring(0, 2) & ") " & Phone.Substring(2, 1) & " " & Phone.Substring(3, 4) & "-" & Phone.Substring(7, 4)
                End If
            Else
                Phone = Nothing
            End If
        Else
            Phone = Nothing
        End If
        TxtPhone.Text = Phone
    End Sub

    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        _User = New User
        LoadUser()
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
        If _User.ID <> 0 Then
            If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    _User.Delete()
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
        Dim Form As New FrmLog(Common.Routines.User, _User.ID)
        Form.ShowDialog()
    End Sub


End Class