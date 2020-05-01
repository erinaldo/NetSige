Imports ControlLibrary
Public Class FrmCostSharingLocal
    Private _CostSharing As CostSharing
    Private _Local As CostSharing.Local
    Private __CostSharingForm As FrmCostSharing
    Private _LocalSaved As Boolean
    Private _Deleting As Boolean
    Public Sub New(ByVal CostSharing As CostSharing, ByVal Local As CostSharing.Local, ByVal ParentForm As FrmCostSharing)
        InitializeComponent()
        _CostSharing = CostSharing
        _Local = Local
        __CostSharingForm = ParentForm
    End Sub
    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadLocal()
    End Sub
    Private Sub LoadLocal()
        If _Local.ID > 0 Then
            _LocalSaved = True
        Else
            _LocalSaved = False
        End If
        LblSeqValue.Text = _Local.Seq
        TxtName.Text = _Local.Name
        TxtZipCode.Text = _Local.ZipCode
        TxtAddress.Text = _Local.Address
        TxtNumber.Text = _Local.Number
        TxtComplement.Text = _Local.Complement
        TxtDistrict.Text = _Local.District
        TxtCity.Text = _Local.City
        CbxState.Text = _Local.State
        BtnSave.Enabled = False
        RefreshNavigation()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        PreSave()
    End Sub
    Private Function PreSave() As Boolean
        If IsValidFields() Then
            If _Local.Seq > 0 Then _LocalSaved = True
            If Not _LocalSaved Then
                _Local = New CostSharing.Local With {
                    .Name = TxtName.Text,
                    .ZipCode = TxtZipCode.Text,
                    .Address = TxtAddress.Text,
                    .Number = TxtNumber.Text,
                    .Complement = TxtComplement.Text,
                    .District = TxtDistrict.Text,
                    .City = TxtCity.Text,
                    .State = CbxState.Text
                }
                _CostSharing.Locals.Add(_Local)
                LblSeqValue.Text = _Local.Seq
                _LocalSaved = True
            Else
                _Local.Name = TxtName.Text
                _Local.ZipCode = TxtZipCode.Text
                _Local.Address = TxtAddress.Text
                _Local.Number = TxtNumber.Text
                _Local.Complement = TxtComplement.Text
                _Local.District = TxtDistrict.Text
                _Local.City = TxtCity.Text
                _Local.State = CbxState.Text
            End If
            _CostSharing.GetLocals(__CostSharingForm.DgvLocals, LblSeqValue.Text)
            TxtZipCode.Select()
            RefreshNavigation()
            BtnSave.Enabled = False
            __CostSharingForm.BtnSave.Enabled = True
            Return True
        Else
            Return False
        End If
    End Function

    Private Function IsValidFields() As Boolean
        If TxtName.Text = Nothing Then
            CMessageBox.Show("Por favor, informe o nome.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtName.Select()
            Return False
        ElseIf TxtZipCode.Text = Nothing Then
            CMessageBox.Show("Por favor, informe o CEP.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtZipCode.Select()
            Return False
        ElseIf TxtAddress.Text = Nothing Then
            CMessageBox.Show("Por favor, informe o endereço.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtAddress.Select()
            Return False
        ElseIf TxtDistrict.Text = Nothing Then
            CMessageBox.Show("Por favor, informe o bairro.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtDistrict.Select()
            Return False
        ElseIf TxtCity.Text = Nothing Then
            CMessageBox.Show("Por favor, informe a cidade.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtCity.Select()
            Return False
        ElseIf CbxState.Text = Nothing Then
            CMessageBox.Show("Por favor, informe o Estado.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            CbxState.Select()
            Return False
        End If
        Return True
    End Function
    Public Sub RefreshNavigation()
        If __CostSharingForm.DgvLocals.SelectedRows.Count = 1 Then
            If __CostSharingForm.DgvLocals.Rows(0).Selected And __CostSharingForm.DgvLocals.Rows.Count > 1 Then
                If __CostSharingForm.DgvLocals.SelectedRows(0).Displayed = False Then
                    __CostSharingForm.DgvLocals.FirstDisplayedScrollingRowIndex = __CostSharingForm.DgvLocals.SelectedRows(0).Index
                End If
                BtnFirst.Enabled = False
                BtnPrevious.Enabled = False
                BtnNext.Enabled = True
                BtnLast.Enabled = True
            ElseIf __CostSharingForm.DgvLocals.Rows(0).Selected And __CostSharingForm.DgvLocals.Rows.Count = 1 Then
                If __CostSharingForm.DgvLocals.SelectedRows(0).Displayed = False Then
                    __CostSharingForm.DgvLocals.FirstDisplayedScrollingRowIndex = __CostSharingForm.DgvLocals.SelectedRows(0).Index
                End If
                BtnFirst.Enabled = False
                BtnPrevious.Enabled = False
                BtnNext.Enabled = False
                BtnLast.Enabled = False
            ElseIf __CostSharingForm.DgvLocals.Rows(__CostSharingForm.DgvLocals.Rows.Count - 1).Selected Then
                If __CostSharingForm.DgvLocals.SelectedRows(0).Displayed = False Then
                    __CostSharingForm.DgvLocals.FirstDisplayedScrollingRowIndex = __CostSharingForm.DgvLocals.RowCount - 1
                End If
                BtnFirst.Enabled = True
                BtnPrevious.Enabled = True
                BtnNext.Enabled = False
                BtnLast.Enabled = False
            Else
                If __CostSharingForm.DgvLocals.SelectedRows(0).Displayed = False Then
                    __CostSharingForm.DgvLocals.FirstDisplayedScrollingRowIndex = __CostSharingForm.DgvLocals.SelectedRows(0).Index
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
    End Sub
    Private Sub Changes(sender As Object, e As EventArgs) Handles TxtZipCode.TextChanged,
                                                                  TxtAddress.TextChanged,
                                                                  TxtNumber.TextChanged,
                                                                  TxtComplement.TextChanged,
                                                                  TxtDistrict.TextChanged,
                                                                  TxtCity.TextChanged,
                                                                  CbxState.SelectedIndexChanged,
                                                                  TxtName.TextChanged
        BtnSave.Enabled = True
    End Sub

    Private Sub TxtZipCode_LostFocus(sender As Object, e As EventArgs) Handles TxtZipCode.LostFocus
        Dim ZipCode As String = TxtZipCode.Text.Replace(".", "").Replace("-", "")
        If ZipCode.Length = 8 Then
            ZipCode = ZipCode.Substring(0, 2) & "." & ZipCode.Substring(2, 3) & "-" & ZipCode.Substring(5, 3)
            TxtZipCode.Text = ZipCode
        End If
    End Sub

    Private Sub BtnZipCode_Click(sender As Object, e As EventArgs) Handles BtnZipCode.Click
        Dim FindZipCode As New ZipCodeFinder.AtendeClienteClient
        Dim ZipCodeData As ZipCodeFinder.enderecoERP
        Dim Person As Person
        Dim FormSearh As FrmZipCode
        Try
            Cursor = Cursors.WaitCursor
            ZipCodeData = FindZipCode.consultaCEP(TxtZipCode.Text)

            Person = New Person With {
                .ZipCode = TxtZipCode.Text,
                .Address = ZipCodeData.end & " " & ZipCodeData.complemento2,
                .District = ZipCodeData.bairro,
                .City = ZipCodeData.cidade,
                .State = ZipCodeData.uf
            }
            FormSearh = New FrmZipCode(Person)
            If FormSearh.ShowDialog() = DialogResult.OK Then
                TxtAddress.Text = If(Person.Address <> Nothing, Person.Address, Nothing)
                TxtDistrict.Text = If(Person.District <> Nothing, Person.District, Nothing)
                TxtCity.Text = If(Person.City <> Nothing, Person.City, Nothing)
                CbxState.Text = If(Person.State <> Nothing, Person.State, Nothing)
            End If
        Catch ex As Exception
            CMessageBox.Show("ERRO0000", "Ocorreu um erro ao consultar o CEP.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If __CostSharingForm.DgvLocals.SelectedRows.Count = 1 Then
            If __CostSharingForm.DgvLocals.SelectedRows(0).Index > 0 Then
                __CostSharingForm.DgvLocals.Rows(0).Selected = True
                _Local = New CostSharing.Local With {
                    .Seq = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("SEQ").Value,
                    .ID = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ID").Value,
                    .Name = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("NAME").Value,
                    .ZipCode = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ZIPCODE").Value,
                    .Address = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ADDRESS").Value,
                    .Number = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("NUMBER").Value,
                    .Complement = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("COMPLEMENT").Value,
                    .District = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("DISTRICT").Value,
                    .City = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("CITY").Value,
                    .State = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("STATE").Value
                }
                LoadLocal()
            End If
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If __CostSharingForm.DgvLocals.SelectedRows.Count = 1 Then
            If __CostSharingForm.DgvLocals.SelectedRows(0).Index > 0 Then
                __CostSharingForm.DgvLocals.Rows(__CostSharingForm.DgvLocals.SelectedRows(0).Index - 1).Selected = True
                _Local = New CostSharing.Local With {
                    .Seq = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("SEQ").Value,
                    .ID = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ID").Value,
                    .Name = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("NAME").Value,
                    .ZipCode = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ZIPCODE").Value,
                    .Address = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ADDRESS").Value,
                    .Number = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("NUMBER").Value,
                    .Complement = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("COMPLEMENT").Value,
                    .District = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("DISTRICT").Value,
                    .City = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("CITY").Value,
                    .State = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("STATE").Value
                }
                LoadLocal()
            End If
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If __CostSharingForm.DgvLocals.SelectedRows.Count = 1 Then
            If __CostSharingForm.DgvLocals.SelectedRows(0).Index < __CostSharingForm.DgvLocals.Rows.Count - 1 Then
                __CostSharingForm.DgvLocals.Rows(__CostSharingForm.DgvLocals.SelectedRows(0).Index + 1).Selected = True
                _Local = New CostSharing.Local With {
                    .Seq = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("SEQ").Value,
                    .ID = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ID").Value,
                    .Name = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("NAME").Value,
                    .ZipCode = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ZIPCODE").Value,
                    .Address = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ADDRESS").Value,
                    .Number = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("NUMBER").Value,
                    .Complement = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("COMPLEMENT").Value,
                    .District = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("DISTRICT").Value,
                    .City = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("CITY").Value,
                    .State = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("STATE").Value
                }
                LoadLocal()
            End If
        End If
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If __CostSharingForm.DgvLocals.SelectedRows.Count = 1 Then
            If __CostSharingForm.DgvLocals.SelectedRows(0).Index < __CostSharingForm.DgvLocals.Rows.Count - 1 Then
                __CostSharingForm.DgvLocals.Rows(__CostSharingForm.DgvLocals.Rows.Count - 1).Selected = True
                _Local = New CostSharing.Local With {
                    .Seq = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("SEQ").Value,
                    .ID = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ID").Value,
                    .Name = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("NAME").Value,
                    .ZipCode = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ZIPCODE").Value,
                    .Address = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("ADDRESS").Value,
                    .Number = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("NUMBER").Value,
                    .Complement = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("COMPLEMENT").Value,
                    .District = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("DISTRICT").Value,
                    .City = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("CITY").Value,
                    .State = __CostSharingForm.DgvLocals.SelectedRows(0).Cells("STATE").Value
                }
                LoadLocal()
            End If
        End If

    End Sub
    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        _Local = New CostSharing.Local
        LoadLocal()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each Local As CostSharing.Local In _CostSharing.Locals
                If Local.ID = _Local.ID Then
                    _CostSharing.Locals.Remove(Local)
                    _CostSharing.GetLocals(__CostSharingForm.DgvLocals)
                    _Deleting = True
                    Dispose()
                    __CostSharingForm.BtnSave.Enabled = True
                    Exit For
                End If
            Next Local
        End If
    End Sub


    Private Sub FrmFormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not _Deleting AndAlso BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then e.Cancel = True
            End If
        End If
        _Deleting = False
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
End Class