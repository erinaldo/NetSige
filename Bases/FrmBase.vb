Imports ControlLibrary
Public Class FrmBase
    Private _Provider As Provider
    Private _FormGrid As FrmProvidersGrid
    Private _Grid As DataGridView
    Private _Filter As Provider.Filter

    Public Sub New(ByVal Provider As Provider, ByVal FormGrid As FrmProvidersGrid)
        InitializeComponent()
        _Provider = Provider
        _FormGrid = FormGrid
        _Grid = _FormGrid.DgvData
        _Filter = CType(_FormGrid.PgFilter.SelectedObject, Provider.Filter)
        TxtName.Select()
    End Sub

    Public Sub New(ByVal Provider As Provider)
        InitializeComponent()
        BtnFirst.Enabled = False
        BtnPrevious.Enabled = False
        BtnNext.Enabled = False
        BtnLast.Enabled = False
        _Provider = Provider
        TxtName.Select()
    End Sub

    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Common.DataGridViewDoubleBuffered(DgvContacts, True)
        LoadProvider()
    End Sub

    Private Sub LoadProvider()
        LblIDValue.Text = _Provider.ID
        BtnStatusValue.Text = _Provider.Status
        LblCreationDateValue.Text = _Provider.CreationDate.ToString("dd/MM/yyyy")
        RbCategoryPF.Checked = If(_Provider.Category = "PF", True, False)
        RbCategoryPJ.Checked = If(_Provider.Category = "PJ", True, False)
        TxtName.Text = _Provider.Name
        TxtBusinessName.Text = _Provider.Businessname
        TxtDocument1.Text = _Provider.Document1
        TxtDocument2.Text = _Provider.Document2
        TxtDocument3.Text = _Provider.Document3
        TxtZipCode.Text = _Provider.ZipCode
        TxtAddress.Text = _Provider.Address
        TxtDistrict.Text = _Provider.District
        TxtCity.Text = _Provider.City
        CbxState.Text = _Provider.State
        TxtNote.Text = _Provider.Note
        DgvContacts.DataSource = _Provider.ContactsTable
        DgvContacts.Columns(0).HeaderText = "Nome"
        DgvContacts.Columns(1).HeaderText = "Cargo"
        DgvContacts.Columns(2).HeaderText = "Telefone 1"
        DgvContacts.Columns(3).HeaderText = "Telefone 2"
        DgvContacts.Columns(4).HeaderText = "Telefone 3"
        DgvContacts.Columns(5).HeaderText = "E-Mail 1"
        DgvContacts.Columns(6).HeaderText = "E-Mail 2"
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
                                                                  TxtBusinessName.TextChanged,
                                                                  TxtDocument1.TextChanged,
                                                                  TxtDocument2.TextChanged,
                                                                  TxtDocument3.TextChanged,
                                                                  TxtZipCode.TextChanged,
                                                                  TxtAddress.TextChanged,
                                                                  TxtDistrict.TextChanged,
                                                                  TxtCity.TextChanged,
                                                                  CbxState.SelectedIndexChanged,
                                                                  TxtNote.TextChanged,
                                                                  DgvContacts.CellBeginEdit
        BtnSave.Enabled = True
    End Sub

    Private Sub TxtDocument1_LostFocus(sender As Object, e As EventArgs) Handles TxtDocument1.LostFocus
        Dim Doc As String = TxtDocument1.Text.Replace(".", "").Replace("-", "").Replace("/", "")
        If Doc.Length = 14 Then
            Doc = Doc.Substring(0, 2) & "." & Doc.Substring(2, 3) & "." & Doc.Substring(5, 3) & "/" & Doc.Substring(8, 4) & "-" & Doc.Substring(12, 2)
        ElseIf Doc.Length = 11 Then
            Doc = Doc.Substring(0, 3) & "." & Doc.Substring(3, 3) & "." & Doc.Substring(6, 3) & "-" & Doc.Substring(9, 2)
        End If
        TxtDocument1.Text = Doc
    End Sub

    Private Sub TxtZipCode_LostFocus(sender As Object, e As EventArgs) Handles TxtZipCode.LostFocus
        Dim ZipCode As String = TxtZipCode.Text.Replace(".", "").Replace("-", "")
        If ZipCode.Length = 8 Then
            ZipCode = ZipCode.Substring(0, 2) & "." & ZipCode.Substring(2, 3) & "-" & ZipCode.Substring(5, 3)
            TxtZipCode.Text = ZipCode
        End If
    End Sub

    Private Sub Changes2(sender As Object, e As EventArgs) Handles RbCategoryPJ.CheckedChanged,
                                                                   RbCategoryPF.CheckedChanged
        LblDocument1.Text = If(RbCategoryPF.Checked, "CPF", "CNPJ")
        TxtDocument1.Text = Nothing
        TxtDocument1.MaxLength = If(RbCategoryPF.Checked, 11, 14)
        LblDocument2.Text = If(RbCategoryPF.Checked, "RG", "Insc. Estadual")
        LblDocument2.Location = If(RbCategoryPJ.Checked, New Point(167, 68), New Point(145, 68))
        TxtDocument2.Text = Nothing
        TxtDocument2.Location = If(RbCategoryPJ.Checked, New Point(170, 88), New Point(148, 88))
        TxtDocument2.Size = If(RbCategoryPJ.Checked, New Size(150, 23), New Size(172, 23))
        LblDocument3.Text = If(RbCategoryPF.Checked, "Título de Eleitor", "Insc. Municipal")
        TxtDocument3.Text = Nothing
        LblDocument1Star.Location = If(RbCategoryPF.Checked, New Point(31, 68), New Point(41, 68))
        BtnDocument.Visible = If(RbCategoryPJ.Checked, True, False)

        BtnSave.Enabled = True
    End Sub


    Private Function IsValidFields() As Boolean
        If TxtName.Text = Nothing Then
            CustomMessageBox.Show("Por favor informe o nome.", CustomMessageBoxType.Warning, CustomMessageBoxButtons.OK)
            TcCustomer.SelectedTab = TpMain
            TxtName.Select()
            Return False
        ElseIf TxtDocument1.Text = Nothing Then
            CustomMessageBox.Show(String.Format("Por favor informe o {0}.", If(RbCategoryPF.Checked, "CPF", "CNPJ")), CustomMessageBoxType.Warning, CustomMessageBoxButtons.OK)
            TcCustomer.SelectedTab = TpMain
            TxtDocument1.Select()
            Return False
        ElseIf Not Common.IsDocumentValid(TxtDocument1.Text, If(RbCategoryPF.Checked, "CPF", "CNPJ")) Then
            CustomMessageBox.Show(String.Format("Por favor informe um {0} válido.", If(RbCategoryPF.Checked, "CPF", "CNPJ")), CustomMessageBoxType.Warning, CustomMessageBoxButtons.OK)
            TcCustomer.SelectedTab = TpMain
            TxtDocument1.Select()
            Return False
        End If

        For Each Row As DataGridViewRow In DgvContacts.Rows
            If Row.Cells("NAME").Value Is Nothing Or Row.Cells("NAME").Value Is DBNull.Value Then
                CustomMessageBox.Show("Por favor informe o nome do contato.", CustomMessageBoxType.Warning, CustomMessageBoxButtons.OK)
                TcCustomer.SelectedTab = TpContacts
                DgvContacts.Rows(Row.Index).Cells("NAME").Selected = True
                Return False
            End If
        Next Row
        Return True
    End Function




    Private Sub BtnStatusValue_Click(sender As Object, e As EventArgs) Handles BtnStatusValue.Click
        If BtnStatusValue.Text = "Ativo" Then
            BtnStatusValue.Text = "Inativo"
            If _Provider.Status = "Ativo" Then CustomMessageBox.Show("O registro foi marcado para ser inativado, salve para concluir a operação.", CustomMessageBoxType.Information, CustomMessageBoxButtons.OK)
        ElseIf BtnStatusValue.Text = "Inativo" Then
            BtnStatusValue.Text = "Ativo"
            If _Provider.Status = "Inativo" Then CustomMessageBox.Show("O registro foi marcado para ser ativado, salve para concluir a operação.", CustomMessageBoxType.Information, CustomMessageBoxButtons.OK)
        End If
        BtnSave.Enabled = True
    End Sub


    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        If BtnSave.Enabled Then
            If CustomMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CustomMessageBoxType.Question, CustomMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        If _Grid.SelectedRows.Count = 1 Then
            If _Grid.SelectedRows(0).Index > 0 Then
                _Grid.Rows(0).Selected = True
                _Provider.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadProvider()
            End If
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If BtnSave.Enabled Then
            If CustomMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CustomMessageBoxType.Question, CustomMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        If _Grid.SelectedRows.Count = 1 Then
            If _Grid.SelectedRows(0).Index > 0 Then
                _Grid.Rows(_Grid.SelectedRows(0).Index - 1).Selected = True
                _Provider.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadProvider()
            End If
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If BtnSave.Enabled Then
            If CustomMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CustomMessageBoxType.Question, CustomMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        If _Grid.SelectedRows.Count = 1 Then
            If _Grid.SelectedRows(0).Index < _Grid.Rows.Count - 1 Then
                _Grid.Rows(_Grid.SelectedRows(0).Index + 1).Selected = True
                _Provider.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadProvider()
            End If
        End If
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        If BtnSave.Enabled Then
            If CustomMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CustomMessageBoxType.Question, CustomMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        If _Grid.SelectedRows.Count = 1 Then
            If _Grid.SelectedRows(0).Index < _Grid.Rows.Count - 1 Then
                _Grid.Rows(_Grid.Rows.Count - 1).Selected = True
                _Provider.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadProvider()
            End If
        End If
    End Sub

    Private Sub BtnStatusValue_TextChanged(sender As Object, e As EventArgs) Handles BtnStatusValue.TextChanged
        BtnStatusValue.ForeColor = If(BtnStatusValue.Text = "Ativo", Color.Blue, Color.Red)
    End Sub

    Private Function Save() As Boolean
        If IsValidFields() Then
            _Provider.Status = BtnStatusValue.Text
            _Provider.Category = If(RbCategoryPF.Checked, "PF", "PJ")
            _Provider.Name = TxtName.Text
            _Provider.Businessname = TxtBusinessName.Text
            _Provider.Document1 = TxtDocument1.Text
            _Provider.Document2 = TxtDocument2.Text
            _Provider.Document3 = TxtDocument3.Text
            _Provider.ZipCode = TxtZipCode.Text
            _Provider.Address = TxtAddress.Text
            _Provider.District = TxtDistrict.Text
            _Provider.City = TxtCity.Text
            _Provider.State = CbxState.Text
            _Provider.Note = TxtNote.Text
            Try
                _Provider.Save()
                LblIDValue.Text = _Provider.ID
                BtnStatusValue.Text = _Provider.Status
                BtnStatusValue.Enabled = True
                LblCreationDateValue.Text = _Provider.CreationDate.ToString("dd/MM/yyyy")
                BtnSave.Enabled = False
                If _FormGrid IsNot Nothing Then
                    _Filter.Filter(If(_Grid.SelectedRows.Count = 1, _Grid.SelectedRows(0).Index, 0))
                    For i = 0 To _Grid.Rows.Count - 1
                        If _Grid.Rows(i).Cells("ID").Value = LblIDValue.Text Then
                            _Grid.Rows(i).Selected = True
                            _Grid.FirstDisplayedScrollingRowIndex = _Grid.SelectedRows(0).Index
                        End If
                    Next i
                    TxtName.Select()
                    RefreshNavigation()
                End If
                Return True
            Catch ex As Exception
                CustomMessageBox.Show("ERRO0000", "Ocorreu um erro salvar o registro.", CustomMessageBoxType.Error, CustomMessageBoxButtons.OK, ex)
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
            If CustomMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CustomMessageBoxType.Question, CustomMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not Save() Then Exit Sub
            End If
        End If
        _Provider = New Provider
        LoadProvider()
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
        If _Provider.ID <> 0 Then
            If CustomMessageBox.Show("Deseja excluir o registro selecionado?", CustomMessageBoxType.Question, CustomMessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    _Provider.Delete()
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
                    CustomMessageBox.Show("ERRO0000", "Ocorreu um erro ao excluir o registro.", CustomMessageBoxType.Error, CustomMessageBoxButtons.OK, ex)
                End Try
            End If
        End If
    End Sub

    Private Sub FrmCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not _Deleting AndAlso BtnSave.Enabled Then
            If BtnSave.Enabled Then
                If CustomMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CustomMessageBoxType.Question, CustomMessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If Not Save() Then e.Cancel = True
                End If
            End If
        End If
        _Deleting = False
    End Sub

    Private Sub TxtNote_LinkClicked(sender As Object, e As LinkClickedEventArgs)
        Process.Start(e.LinkText)
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        Dim Form As New FrmLog(Common.Routines.Provider, _Provider.ID)
        Form.ShowDialog()
    End Sub

    Private Sub BtnIncludeContact_Click(sender As Object, e As EventArgs) Handles BtnIncludeContact.Click
        _Provider.ContactsTable.Rows.Add({0, _Provider.ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing})
    End Sub

    Private Sub BtnDeleteContact_Click(sender As Object, e As EventArgs) Handles BtnDeleteContact.Click
        If DgvContacts.SelectedCells.Count = 1 Then
            If CustomMessageBox.Show("O contato selecionado será excluído. Deseja continuar?", CustomMessageBoxType.Question, CustomMessageBoxButtons.YesNo) = DialogResult.Yes Then
                _Provider.ContactsTable.Rows(DgvContacts.SelectedCells(0).RowIndex).Delete()
                _Provider.ContactsTable.AcceptChanges()
            End If
        End If
    End Sub

    Private Sub DgvContacts_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContacts.CellEndEdit
        Dim CellValue As String
        Dim Chars As HashSet(Of Char)
        Dim RegexEmail As Text.RegularExpressions.Regex
        If DgvContacts.Rows(e.RowIndex).Cells(e.ColumnIndex).Value IsNot DBNull.Value Then
            CellValue = DgvContacts.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
            Chars = New HashSet(Of Char)() From {"("c, ")"c, "-"c, " "c}
            If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Then
                CellValue = New String(CellValue.Where(Function(x) Not Chars.Contains(x)).ToArray())
                If IsNumeric(CellValue) Then
                    Select Case CellValue.Length
                        Case Is < 10
                            CustomMessageBox.Show("Telefone inválido, utilize um dos formatos abaixo, com ou sem mascara." & vbNewLine &
                                                      "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000",
                                                      CustomMessageBoxType.Warning, CustomMessageBoxButtons.OK)
                            CellValue = Nothing
                        Case Is = 11
                            If Strings.Left(CellValue, 4) = "0300" Or Strings.Left(CellValue, 4) = "0500" Or
                               Strings.Left(CellValue, 4) = "0800" Or Strings.Left(CellValue, 4) = "0900" Then
                                CellValue = CellValue.Substring(0, 4) & "-" & CellValue.Substring(4, 3) & "-" & CellValue.Substring(7, 4)
                            Else
                                CellValue = "(" & CellValue.Substring(0, 2) & ") " & CellValue.Substring(2, 1) & " " & CellValue.Substring(3, 4) & "-" & CellValue.Substring(7, 4)
                            End If
                        Case Is = 10
                            CellValue = "(" & CellValue.Substring(0, 2) & ") " & CellValue.Substring(2, 4) & "-" & CellValue.Substring(6, 4)
                    End Select
                Else
                    CustomMessageBox.Show("Telefone inválido, utilize um dos formatos abaixo, com ou sem mascara." & vbNewLine &
                                              "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000",
                                              CustomMessageBoxType.Warning, CustomMessageBoxButtons.OK)
                    CellValue = Nothing
                End If
            ElseIf e.ColumnIndex = 5 Or e.ColumnIndex = 6 Then
                RegexEmail = New Text.RegularExpressions.Regex("^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$")
                If Not RegexEmail.IsMatch(CellValue) Then
                    CustomMessageBox.Show("E-mail inválido", CustomMessageBoxType.Warning, CustomMessageBoxButtons.OK)
                    CellValue = Nothing
                End If
            End If
            DgvContacts.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CellValue
        End If
    End Sub

    Private Sub TcCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TcCustomer.SelectedIndexChanged
        If TcCustomer.SelectedIndex = 0 Then
            Size = New Size(500, 450)
            FormBorderStyle = FormBorderStyle.FixedSingle
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub BtnDefaultContact_Click(sender As Object, e As EventArgs) Handles BtnDefaultContact.Click
        Dim RowIndex As Integer = DgvContacts.SelectedCells(0).RowIndex
        If _Provider.ContactsTable.Rows(RowIndex).Item("ID") <> Nothing Then
            _Provider.DefaultContactID = _Provider.ContactsTable.Rows(RowIndex).Item("ID")
            For Each Row As DataGridViewRow In DgvContacts.Rows
                If Row.Index = RowIndex Then
                    Row.DefaultCellStyle.Font = New Font(DgvContacts.Font, FontStyle.Bold)
                Else
                    Row.DefaultCellStyle.Font = New Font(DgvContacts.Font, FontStyle.Regular)
                End If

            Next Row
            BtnSave.Enabled = True
        Else
            CustomMessageBox.Show("Esse contato ainda não foi salvo, salve o registro e tente novamente.", CustomMessageBoxType.Warning, CustomMessageBoxButtons.OK)
        End If

    End Sub

    Private Sub DgvContacts_MouseUp(sender As Object, e As MouseEventArgs) Handles DgvContacts.MouseUp
        Dim Click As DataGridView.HitTestInfo = DgvContacts.HitTest(e.X, e.Y)
        If Click.Type = DataGridViewHitTestType.Cell And e.Button = MouseButtons.Right Then
            DgvContacts.Rows(Click.RowIndex).Cells(Click.ColumnIndex).Selected = True
            CmsDefaultContact.Show(DgvContacts.PointToScreen(e.Location))
        End If
    End Sub

    Private Sub BtnZipCode_Click(sender As Object, e As EventArgs) Handles BtnZipCode.Click
        Dim FindZipCode As New ZipCodeFinder.AtendeClienteClient
        Dim ZipCodeData As ZipCodeFinder.enderecoERP
        Dim Provider As Provider
        Dim FormSearh As FrmZipCode
        Try
            Cursor = Cursors.WaitCursor
            ZipCodeData = FindZipCode.consultaCEP(TxtZipCode.Text)

            Provider = New Provider With {
                .ZipCode = TxtZipCode.Text,
                .Address = ZipCodeData.end & " " & ZipCodeData.complemento2,
                .District = ZipCodeData.bairro,
                .City = ZipCodeData.cidade,
                .State = ZipCodeData.uf
            }
            FormSearh = New FrmZipCode(Provider)
            If FormSearh.ShowDialog() = DialogResult.OK Then
                TxtAddress.Text = If(Provider.Address <> Nothing, Provider.Address, Nothing)
                TxtDistrict.Text = If(Provider.District <> Nothing, Provider.District, Nothing)
                TxtCity.Text = If(Provider.City <> Nothing, Provider.City, Nothing)
                CbxState.Text = If(Provider.State <> Nothing, Provider.State, Nothing)
            End If
        Catch ex As Exception
            CustomMessageBox.Show("ERRO0000", "Ocorreu um erro ao consultar o CEP.", CustomMessageBoxType.Error, CustomMessageBoxButtons.OK, ex)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub BtnDocument_Click(sender As Object, e As EventArgs) Handles BtnDocument.Click
        Dim DataSearch As Consulta.CNPJ.Services.CNPJService
        Dim SearchResult As Consulta.CNPJ.Models.CNPJResult
        Dim Provider As Provider
        Dim FormSearh As FrmDocument
        Try
            Cursor = Cursors.WaitCursor
            DataSearch = New Consulta.CNPJ.Services.CNPJService


            SearchResult = DataSearch.ConsultarCPNJ(TxtDocument1.Text.Replace(".", Nothing).Replace("-", Nothing).Replace("/", Nothing))

            If SearchResult IsNot Nothing Then
                Provider = New Provider With {
                .Document1 = TxtDocument1.Text,
                .Name = SearchResult.Nome,
                .Businessname = SearchResult.Fantasia,
                .ZipCode = SearchResult.Cep,
                .Address = SearchResult.Logradouro & If(SearchResult.Numero = Nothing, " ", ", " & SearchResult.Numero & " ") & SearchResult.Complemento,
                .District = SearchResult.Bairro,
                .City = SearchResult.Municipio,
                .State = SearchResult.Uf
            }
                FormSearh = New FrmDocument(Provider)
                If FormSearh.ShowDialog() = DialogResult.OK Then
                    TxtName.Text = If(Provider.Name <> Nothing, Provider.Name, Nothing)
                    TxtBusinessName.Text = If(Provider.Businessname <> Nothing, Provider.Businessname, Nothing)
                    TxtZipCode.Text = If(Provider.ZipCode <> Nothing, Provider.ZipCode, Nothing)
                    TxtAddress.Text = If(Provider.Address <> Nothing, Provider.Address, Nothing)
                    TxtDistrict.Text = If(Provider.District <> Nothing, Provider.District, Nothing)
                    TxtCity.Text = If(Provider.City <> Nothing, Provider.City, Nothing)
                    CbxState.Text = If(Provider.State <> Nothing, Provider.State, Nothing)
                End If
            Else
                CustomMessageBox.Show("A busca não retornou dados, verifique o número digitado e tente novamente em alguns minutos.", CustomMessageBoxType.Warning, CustomMessageBoxButtons.OK)
            End If
        Catch ex As Exception
            CustomMessageBox.Show("ERRO0000", "Ocorreu um erro ao consultar o CNPJ.", CustomMessageBoxType.Error, CustomMessageBoxButtons.OK, ex)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub


End Class