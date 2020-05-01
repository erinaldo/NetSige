Imports ControlLibrary
Public Class FrmPerson
    Private _Person As Person
    Private _FormGrid As FrmPersonsGrid
    Private _Grid As DataGridView
    Private _Filter As Person.Filter

    Public Sub New(ByVal Person As Person, ByVal FormGrid As FrmPersonsGrid)
        InitializeComponent()
        _Person = Person
        _FormGrid = FormGrid
        _Grid = _FormGrid.DgvData
        _Filter = CType(_FormGrid.PgFilter.SelectedObject, Person.Filter)
        TxtName.Select()
    End Sub

    Public Sub New(ByVal Person As Person)
        InitializeComponent()
        BtnFirst.Enabled = False
        BtnPrevious.Enabled = False
        BtnNext.Enabled = False
        BtnLast.Enabled = False
        _Person = Person
        TxtName.Select()
    End Sub

    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Common.DataGridViewDoubleBuffered(DgvContacts, True)
        LoadPerson()
    End Sub

    Private Sub LoadPerson()
        LblIDValue.Text = _Person.ID
        BtnStatusValue.Text = _Person.Status
        LblCreationDateValue.Text = _Person.CreationDate.ToString("dd/MM/yyyy")
        RbEntityPF.Checked = If(_Person.EntityType = "Pessoa Física", True, False)
        RbEntityPJ.Checked = If(_Person.EntityType = "Pessoa Jurídica", True, False)
        CbxIsProvider.Checked = _Person.IsProvider
        CbxIsCustomer.Checked = _Person.IsCustomer
        CbxIsCarrier.Checked = _Person.IsCarrier
        TxtName.Text = _Person.Name
        TxtBusinessName.Text = _Person.Businessname
        TxtDocument1.Text = _Person.Document1
        TxtDocument2.Text = _Person.Document2
        TxtDocument3.Text = _Person.Document3
        TxtZipCode.Text = _Person.ZipCode
        TxtAddress.Text = _Person.Address
        TxtNumber.Text = _Person.Number
        TxtComplement.Text = _Person.Complement
        TxtDistrict.Text = _Person.District
        TxtCity.Text = _Person.City
        CbxState.Text = _Person.State
        TxtNote.Text = _Person.Note
        _Person.GetContacts(DgvContacts)
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
                                                                   CbxIsProvider.CheckedChanged,
                                                                   CbxIsCustomer.CheckedChanged,
                                                                   CbxIsCarrier.CheckedChanged
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

    Private Sub Changes2(sender As Object, e As EventArgs) Handles RbEntityPJ.CheckedChanged,
                                                                   RbEntityPF.CheckedChanged
        LblDocument1.Text = If(RbEntityPF.Checked, "CPF", "CNPJ")
        TxtDocument1.Text = Nothing
        TxtDocument1.MaxLength = If(RbEntityPF.Checked, 11, 14)
        LblDocument2.Text = If(RbEntityPF.Checked, "RG", "Insc. Estadual")
        LblDocument2.Location = If(RbEntityPJ.Checked, New Point(167, 68), New Point(145, 68))
        TxtDocument2.Text = Nothing
        TxtDocument2.Location = If(RbEntityPJ.Checked, New Point(170, 88), New Point(148, 88))
        TxtDocument2.Size = If(RbEntityPJ.Checked, New Size(150, 23), New Size(172, 23))
        LblDocument3.Text = If(RbEntityPF.Checked, "Título de Eleitor", "Insc. Municipal")
        TxtDocument3.Text = Nothing
        LblDocument1Star.Location = If(RbEntityPF.Checked, New Point(31, 68), New Point(41, 68))
        BtnDocument.Visible = If(RbEntityPJ.Checked, True, False)
        BtnSave.Enabled = True
    End Sub



    Private Function IsValidFields() As Boolean
        If CbxIsProvider.Checked = False And CbxIsCustomer.Checked = False And CbxIsCarrier.Checked = False Then
            CMessageBox.Show("Por favor informe pelo menos uma categoria de entidade.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcPerson.SelectedTab = TpMain
            Return False
        ElseIf TxtName.Text = Nothing Then
            CMessageBox.Show("Por favor informe o nome.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcPerson.SelectedTab = TpMain
            TxtName.Select()
            Return False
        ElseIf TxtDocument1.Text = Nothing Then
            CMessageBox.Show(String.Format("Por favor informe o {0}.", If(RbEntityPF.Checked, "CPF", "CNPJ")), CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcPerson.SelectedTab = TpMain
            TxtDocument1.Select()
            Return False
        ElseIf Not Common.IsDocumentValid(TxtDocument1.Text, If(RbEntityPF.Checked, "CPF", "CNPJ")) Then
            CMessageBox.Show(String.Format("Por favor informe um {0} válido.", If(RbEntityPF.Checked, "CPF", "CNPJ")), CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcPerson.SelectedTab = TpMain
            TxtDocument1.Select()
            Return False
        End If
        For Each Row As DataGridViewRow In DgvContacts.Rows
            If Row.Cells("NAME").Value Is Nothing Or Row.Cells("NAME").Value Is DBNull.Value Then
                CMessageBox.Show("Por favor informe o nome do contato.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
                TcPerson.SelectedTab = TpContacts
                DgvContacts.Rows(Row.Index).Cells("NAME").Selected = True
                Return False
            End If
        Next Row
        Return True
    End Function




    Private Sub BtnStatusValue_Click(sender As Object, e As EventArgs) Handles BtnStatusValue.Click
        If BtnStatusValue.Text = "Ativo" Then
            BtnStatusValue.Text = "Inativo"
            If _Person.Status = "Ativo" Then CMessageBox.Show("O registro foi marcado para ser inativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
        ElseIf BtnStatusValue.Text = "Inativo" Then
            BtnStatusValue.Text = "Ativo"
            If _Person.Status = "Inativo" Then CMessageBox.Show("O registro foi marcado para ser ativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
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
                _Person.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadPerson()
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
                _Person.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadPerson()
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
                _Person.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadPerson()
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
                _Person.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadPerson()
            End If
        End If
    End Sub

    Private Sub BtnStatusValue_TextChanged(sender As Object, e As EventArgs) Handles BtnStatusValue.TextChanged
        BtnStatusValue.ForeColor = If(BtnStatusValue.Text = "Ativo", Color.DarkBlue, Color.DarkRed)
    End Sub

    Private Function Save() As Boolean
        Dim FirstDisplayedRow As Long
        If IsValidFields() Then
            _Person.Status = BtnStatusValue.Text
            _Person.EntityType = If(RbEntityPF.Checked, "Pessoa Física", "Pessoa Jurídica")
            _Person.IsProvider = CbxIsProvider.Checked
            _Person.IsCustomer = CbxIsCustomer.Checked
            _Person.IsCarrier = CbxIsCarrier.Checked
            _Person.Name = TxtName.Text
            _Person.Businessname = TxtBusinessName.Text
            _Person.Document1 = TxtDocument1.Text
            _Person.Document2 = TxtDocument2.Text
            _Person.Document3 = TxtDocument3.Text
            _Person.ZipCode = TxtZipCode.Text
            _Person.Address = TxtAddress.Text
            _Person.Number = TxtNumber.Text
            _Person.Complement = TxtComplement.Text
            _Person.District = TxtDistrict.Text
            _Person.City = TxtCity.Text
            _Person.State = CbxState.Text
            _Person.Note = TxtNote.Text
            If Not _Person.Contacts.Any(Function(x) x.ID = _Person.DefaultContactID) Then _Person.DefaultContactID = 0
            Try
                _Person.Save()
                LblIDValue.Text = _Person.ID
                BtnStatusValue.Text = _Person.Status
                BtnStatusValue.Enabled = True
                LblCreationDateValue.Text = _Person.CreationDate.ToString("dd/MM/yyyy")
                _Person.GetContacts(DgvContacts)
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
                If ex.Message = "constraint failed" & vbCrLf & "UNIQUE constraint failed: PERSON.DOCUMENT1" Then
                    If RbEntityPF.Checked Then
                        CMessageBox.Show("Esse CPF já está cadastrado.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK, ex)
                    Else
                        CMessageBox.Show("Esse CNPJ já está cadastrado.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK, ex)
                    End If
                Else
                    CMessageBox.Show("ERRO0000", "Ocorreu um erro salvar o registro.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
                End If
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
        _Person = New Person
        LoadPerson()
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
        If _Person.ID <> 0 Then
            If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    _Person.Delete()
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

    Private Sub FrmPerson_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not _Deleting AndAlso BtnSave.Enabled Then
            If BtnSave.Enabled Then
                If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If Not Save() Then e.Cancel = True
                End If
            End If
        End If
        _Deleting = False
    End Sub

    Private Sub TxtNote_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles TxtNote.LinkClicked
        Process.Start(e.LinkText)
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        Dim Form As New FrmLog(Common.Routines.Person, _Person.ID)
        Form.ShowDialog()
    End Sub

    Private Sub BtnIncludeContact_Click(sender As Object, e As EventArgs) Handles BtnIncludeContact.Click
        Dim Form As New FrmPersonContact(_Person, New Person.Contact, Me)
        Form.ShowDialog()
    End Sub

    Private Sub BtnDeleteContact_Click(sender As Object, e As EventArgs) Handles BtnDeleteContact.Click
        Dim ContactID As Long
        If DgvContacts.SelectedRows.Count = 1 Then
            If CMessageBox.Show("O contato selecionado será excluído. Deseja continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                ContactID = DgvContacts.SelectedRows(0).Cells("ID").Value
                For Each Contact As Person.Contact In _Person.Contacts
                    If Contact.ID = ContactID Then
                        _Person.Contacts.Remove(Contact)
                        _Person.GetContacts(DgvContacts)
                        BtnSave.Enabled = True
                        Exit For
                    End If
                Next Contact
            End If
        End If
    End Sub

    Private Sub BtnEditContact_Click(sender As Object, e As EventArgs) Handles BtnEditContact.Click
        Dim ContactSeq As Long
        If DgvContacts.SelectedRows.Count = 1 Then
            ContactSeq = DgvContacts.SelectedRows(0).Cells("SEQ").Value
            For Each Contact As Person.Contact In _Person.Contacts
                If Contact.Seq = ContactSeq Then
                    Dim Form As New FrmPersonContact(_Person, Contact, Me)
                    Form.ShowDialog()
                    Exit For
                End If
            Next Contact
        End If
    End Sub

    Private Sub TcPerson_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TcPerson.SelectedIndexChanged
        If TcPerson.SelectedTab Is TpMain Then
            Size = New Size(499, 523)
            FormBorderStyle = FormBorderStyle.FixedSingle
            WindowState = FormWindowState.Normal
            MaximizeBox = False
        Else
            WindowState = FormWindowState.Maximized
            MaximizeBox = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub BtnDefaultContact_Click(sender As Object, e As EventArgs) Handles BtnDefaultContact.Click
        Dim RowIndex As Integer = DgvContacts.SelectedCells(0).RowIndex
        If _Person.Contacts(RowIndex).ID <> Nothing Then
            _Person.DefaultContactID = _Person.Contacts(RowIndex).ID
            For Each Row As DataGridViewRow In DgvContacts.Rows
                If Row.Index = RowIndex Then
                    Row.DefaultCellStyle.Font = New Font(DgvContacts.Font, FontStyle.Bold)
                Else
                    Row.DefaultCellStyle.Font = New Font(DgvContacts.Font, FontStyle.Regular)
                End If

            Next Row
            BtnSave.Enabled = True
        Else
            CMessageBox.Show("Esse contato ainda não foi salvo, salve o registro e tente novamente.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
        End If
    End Sub

    Private Sub DgvContacts_MouseUp(sender As Object, e As MouseEventArgs) Handles DgvContacts.MouseUp
        Dim Click As DataGridView.HitTestInfo = DgvContacts.HitTest(e.X, e.Y)
        If Click.Type = DataGridViewHitTestType.Cell And e.Button = MouseButtons.Right Then
            DgvContacts.Rows(Click.RowIndex).Cells(Click.ColumnIndex).Selected = True
            CmsDefaultContact.Show(DgvContacts.PointToScreen(e.Location))
        End If
    End Sub

    Private Sub DgvContacts_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DgvContacts.MouseDoubleClick
        Dim ClickPlace As DataGridView.HitTestInfo = DgvContacts.HitTest(e.X, e.Y)
        If ClickPlace.Type = DataGridViewHitTestType.Cell Then
            BtnEditContact.PerformClick()
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

    Private Sub BtnDocument_Click(sender As Object, e As EventArgs) Handles BtnDocument.Click
        Dim DataSearch As Consulta.CNPJ.Services.CNPJService
        Dim SearchResult As Consulta.CNPJ.Models.CNPJResult
        Dim Person As Person
        Dim FormSearh As FrmDocument
        Try
            Cursor = Cursors.WaitCursor
            DataSearch = New Consulta.CNPJ.Services.CNPJService
            SearchResult = DataSearch.ConsultarCPNJ(TxtDocument1.Text.Replace(".", Nothing).Replace("-", Nothing).Replace("/", Nothing))
            If SearchResult IsNot Nothing Then
                Person = New Person With {
                .Document1 = TxtDocument1.Text,
                .Name = SearchResult.Nome,
                .Businessname = SearchResult.Fantasia,
                .ZipCode = SearchResult.Cep,
                .Address = SearchResult.Logradouro,
                .Number = SearchResult.Numero,
                .Complement = SearchResult.Complemento,
                .District = SearchResult.Bairro,
                .City = SearchResult.Municipio,
                .State = SearchResult.Uf
            }
                FormSearh = New FrmDocument(Person)
                If FormSearh.ShowDialog() = DialogResult.OK Then
                    TxtName.Text = If(Person.Name <> Nothing, Person.Name, Nothing)
                    TxtBusinessName.Text = If(Person.Businessname <> Nothing, Person.Businessname, Nothing)
                    TxtZipCode.Text = If(Person.ZipCode <> Nothing, Person.ZipCode, Nothing)
                    TxtAddress.Text = If(Person.Address <> Nothing, Person.Address, Nothing)
                    TxtNumber.Text = If(Person.Number <> Nothing, Person.Number, Nothing)
                    TxtComplement.Text = If(Person.Complement <> Nothing, Person.Complement, Nothing)
                    TxtDistrict.Text = If(Person.District <> Nothing, Person.District, Nothing)
                    TxtCity.Text = If(Person.City <> Nothing, Person.City, Nothing)
                    CbxState.Text = If(Person.State <> Nothing, Person.State, Nothing)
                End If
            Else
                CMessageBox.Show("A busca não retornou dados, verifique o número digitado e tente novamente em alguns minutos.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            End If
        Catch ex As Exception
            CMessageBox.Show("ERRO0000", "Ocorreu um erro ao consultar o CNPJ.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub


End Class