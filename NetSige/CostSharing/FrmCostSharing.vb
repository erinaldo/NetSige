Imports ControlLibrary
Public Class FrmCostSharing
    Private _CostSharing As CostSharing
    Private _FormGrid As FrmCostSharingGrid
    Private _Grid As DataGridView
    Private _Filter As CostSharing.Filter
    Private _DefaultLogoPath As String
    Private _Deleting As Boolean
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
                    TxtAddress.Text = If(Person.Address <> Nothing, Person.Address, Nothing)
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



    Public Sub New(ByVal CostSharing As CostSharing, ByVal FormGrid As FrmCostSharingGrid)
        InitializeComponent()
        _CostSharing = CostSharing
        _FormGrid = FormGrid
        _Grid = _FormGrid.DgvData
        _Filter = CType(_FormGrid.PgFilter.SelectedObject, CostSharing.Filter)
        TxtName.Select()
    End Sub

    Public Sub New(ByVal CostSharing As CostSharing)
        InitializeComponent()
        BtnFirst.Enabled = False
        BtnPrevious.Enabled = False
        BtnNext.Enabled = False
        BtnLast.Enabled = False
        _CostSharing = CostSharing
        TxtName.Select()
    End Sub

    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadCostSharing()
    End Sub

    Private Sub LoadCostSharing()
        LblIDValue.Text = _CostSharing.ID
        BtnStatusValue.Text = _CostSharing.Status
        LblCreationDateValue.Text = _CostSharing.CreationDate.ToString("dd/MM/yyyy")
        _DefaultLogoPath = _CostSharing.LogoPath
        PbxLogo.Image = If(IO.File.Exists(_CostSharing.LogoPath), GetCopyImage(_CostSharing.LogoPath), Nothing)
        TxtName.Text = _CostSharing.Name
        TxtBusinessName.Text = _CostSharing.Businessname
        TxtDocument1.Text = _CostSharing.Document1
        TxtDocument2.Text = _CostSharing.Document2
        TxtDocument3.Text = _CostSharing.Document3
        TxtZipCode.Text = _CostSharing.ZipCode
        TxtAddress.Text = _CostSharing.Address
        TxtNumber.Text = _CostSharing.Number
        TxtComplement.Text = _CostSharing.Complement
        TxtDistrict.Text = _CostSharing.District
        TxtCity.Text = _CostSharing.City
        CbxState.Text = _CostSharing.State
        TxtNote.Text = _CostSharing.Note
        _CostSharing.GetLocals(DgvLocals)
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
                                                                  TxtComplement.TextChanged,
                                                                  TxtNumber.TextChanged
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

    Private Function IsValidFields() As Boolean
        If TxtName.Text = Nothing Then
            CMessageBox.Show("Por favor informe o nome.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcCustomer.SelectedTab = TpMain
            TxtName.Select()
            Return False
        ElseIf TxtDocument1.Text <> Nothing And Not Common.IsDocumentValid(TxtDocument1.Text, "CNPJ") Then
            CMessageBox.Show("Por favor informe um CNPJ válido.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcCustomer.SelectedTab = TpMain
            TxtDocument1.Select()
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

    Private Sub BtnStatusValue_Click(sender As Object, e As EventArgs) Handles BtnStatusValue.Click
        If BtnStatusValue.Text = "Ativo" Then
            BtnStatusValue.Text = "Inativo"
            If _CostSharing.Status = "Ativo" Then CMessageBox.Show("O registro foi marcado para ser inativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
        ElseIf BtnStatusValue.Text = "Inativo" Then
            BtnStatusValue.Text = "Ativo"
            If _CostSharing.Status = "Inativo" Then CMessageBox.Show("O registro foi marcado para ser ativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
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
                _CostSharing.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadCostSharing()
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
                _CostSharing.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadCostSharing()
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
                _CostSharing.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadCostSharing()
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
                _CostSharing.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadCostSharing()
            End If
        End If
    End Sub

    Private Sub BtnStatusValue_TextChanged(sender As Object, e As EventArgs) Handles BtnStatusValue.TextChanged
        BtnStatusValue.ForeColor = If(BtnStatusValue.Text = "Ativo", Color.DarkBlue, Color.DarkRed)
    End Sub

    Private Function Save() As Boolean
        Dim FirstDisplayedRow As Long
        Dim Filename As String
        Do
            Filename = IO.Path.GetRandomFileName()
        Loop Until Not IO.File.Exists(Common.LogoImagesPath & "\" & Filename)
        Filename = Common.LogoImagesPath & "\" & Filename
        If IsValidFields() Then
            Try
                If _DefaultLogoPath <> Nothing And _CostSharing.LogoPath <> Nothing Then
                    If _DefaultLogoPath <> _CostSharing.LogoPath Then
                        If IO.File.Exists(_DefaultLogoPath) Then IO.File.Delete(_DefaultLogoPath)
                    End If
                End If
                If _DefaultLogoPath <> Nothing And _CostSharing.LogoPath = Nothing Then
                    If IO.File.Exists(_DefaultLogoPath) Then IO.File.Delete(_DefaultLogoPath)
                End If


                If _CostSharing.LogoPath <> Nothing Then
                    IO.File.Copy(_CostSharing.LogoPath, Filename)
                    _CostSharing.LogoPath = Filename
                    _DefaultLogoPath = Filename
                Else
                    _CostSharing.LogoPath = Nothing
                    _DefaultLogoPath = Nothing
                End If
                _CostSharing.Status = BtnStatusValue.Text
                _CostSharing.Name = TxtName.Text
                _CostSharing.Businessname = TxtBusinessName.Text
                _CostSharing.Document1 = TxtDocument1.Text
                _CostSharing.Document2 = TxtDocument2.Text
                _CostSharing.Document3 = TxtDocument3.Text
                _CostSharing.ZipCode = TxtZipCode.Text
                _CostSharing.Address = TxtAddress.Text
                _CostSharing.Number = TxtNumber.Text
                _CostSharing.Complement = TxtComplement.Text
                _CostSharing.District = TxtDistrict.Text
                _CostSharing.City = TxtCity.Text
                _CostSharing.State = CbxState.Text
                _CostSharing.Note = TxtNote.Text
                _CostSharing.Save()
                LblIDValue.Text = _CostSharing.ID
                BtnStatusValue.Text = _CostSharing.Status
                BtnStatusValue.Enabled = True
                LblCreationDateValue.Text = _CostSharing.CreationDate.ToString("dd/MM/yyyy")
                _CostSharing.GetLocals(DgvLocals)
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
                If ex.Message = "constraint failed" & vbCrLf & "UNIQUE constraint failed: COSTSHARING.DOCUMENT1" Then
                    CMessageBox.Show("Esse CNPJ já está cadastrado.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK, ex)
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
        _CostSharing = New CostSharing
        LoadCostSharing()
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

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim FirstDisplayedRow As Integer
        If _CostSharing.ID <> 0 Then
            If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    _CostSharing.Delete()
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

    Private Sub FrmCostSharing_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
        Dim Form As New FrmLog(Common.Routines.CostSharing, _CostSharing.ID)
        Form.ShowDialog()
    End Sub

    Private Sub TcCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TcCustomer.SelectedIndexChanged
        If TcCustomer.SelectedIndex = 0 Then
            Size = New Size(500, 450)
            FormBorderStyle = FormBorderStyle.FixedSingle
            WindowState = FormWindowState.Normal
            MaximizeBox = False
        Else
            WindowState = FormWindowState.Maximized
            MaximizeBox = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub BtnExportImage_Click(sender As Object, e As EventArgs) Handles BtnExportImage.Click

        If _CostSharing.LogoPath <> Nothing And IO.File.Exists(_CostSharing.LogoPath) Then
            SfdPhoto.FileName = _CostSharing.Name
            If SfdPhoto.ShowDialog = DialogResult.OK Then
                Using b = GetCopyImage(_CostSharing.LogoPath)
                    b.Save(SfdPhoto.FileName, Imaging.ImageFormat.Png)
                End Using
            End If
        End If
    End Sub


    Private Sub PbxLogo_MouseUp(sender As Object, e As MouseEventArgs) Handles PbxLogo.MouseUp
        OfdPhoto.FileName = OfdPhoto.SafeFileName
        If e.Button = MouseButtons.Right Then
            CmsImage.Show(PbxLogo.PointToScreen(e.Location))
        ElseIf e.Button = MouseButtons.Left And OfdPhoto.ShowDialog = DialogResult.OK Then
            PbxLogo.Image = GetCopyImage(OfdPhoto.FileName)
            _CostSharing.LogoPath = OfdPhoto.FileName
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub BtnChoseImage_Click(sender As Object, e As EventArgs) Handles BtnChoseImage.Click
        If OfdPhoto.ShowDialog = DialogResult.OK Then
            PbxLogo.Image = GetCopyImage(OfdPhoto.FileName)
            _CostSharing.LogoPath = OfdPhoto.FileName
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub BtnDeleteImage_Click(sender As Object, e As EventArgs) Handles BtnDeleteImage.Click
        PbxLogo.Image = Nothing
        _CostSharing.LogoPath = Nothing
        BtnSave.Enabled = True
    End Sub

    Private Function GetCopyImage(ByVal path As String) As Image
        Using image As Image = Image.FromFile(path)
            Dim bitmap As Bitmap = New Bitmap(image)
            Return bitmap
        End Using
    End Function
    Private Sub DgvLocals_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DgvLocals.MouseDoubleClick
        Dim ClickPlace As DataGridView.HitTestInfo = DgvLocals.HitTest(e.X, e.Y)
        If ClickPlace.Type = DataGridViewHitTestType.Cell Then
            BtnEditLocal.PerformClick()
        End If
    End Sub
    Private Sub BtnIncludeLocal_Click(sender As Object, e As EventArgs) Handles BtnIncludeLocal.Click
        Dim Form As New FrmCostSharingLocal(_CostSharing, New CostSharing.Local, Me)
        Form.ShowDialog()
    End Sub
    Private Sub BtnDeleteLocal_Click(sender As Object, e As EventArgs) Handles BtnDeleteLocal.Click
        Dim LocalID As Long
        If DgvLocals.SelectedRows.Count = 1 Then
            If CMessageBox.Show("O local selecionado será excluído. Deseja continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                LocalID = DgvLocals.SelectedRows(0).Cells("ID").Value
                For Each Local As CostSharing.Local In _CostSharing.Locals
                    If Local.ID = LocalID Then
                        _CostSharing.Locals.Remove(Local)
                        _CostSharing.GetLocals(DgvLocals)
                        BtnSave.Enabled = True
                        Exit For
                    End If
                Next Local
            End If
        End If
    End Sub
    Private Sub BtnEditLocal_Click(sender As Object, e As EventArgs) Handles BtnEditLocal.Click
        Dim LocalSeq As Long
        If DgvLocals.SelectedRows.Count = 1 Then
            LocalSeq = DgvLocals.SelectedRows(0).Cells("SEQ").Value
            For Each Local As CostSharing.Local In _CostSharing.Locals
                If Local.Seq = LocalSeq Then
                    Dim Form As New FrmCostSharingLocal(_CostSharing, Local, Me)
                    Form.ShowDialog()
                    Exit For
                End If
            Next Local
        End If
    End Sub


End Class