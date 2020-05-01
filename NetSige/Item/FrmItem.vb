Imports ControlLibrary
Imports System.IO
Public Class FrmItem
    Private _Item As Item
    Private _FormGrid As FrmItemsGrid
    Private _Grid As DataGridView
    Private _Filter As Item.Filter
    Private _DefaultPhotoPath As String
    Private _Deleting As Boolean
    Public Sub New(ByVal Item As Item, ByVal FormGrid As FrmItemsGrid)
        InitializeComponent()
        _Item = Item
        _FormGrid = FormGrid
        _Grid = _FormGrid.DgvData
        _Filter = CType(_FormGrid.PgFilter.SelectedObject, Item.Filter)
        TxtName.Select()
    End Sub

    Public Sub New(ByVal Item As Item)
        InitializeComponent()
        BtnFirst.Enabled = False
        BtnPrevious.Enabled = False
        BtnNext.Enabled = False
        BtnLast.Enabled = False
        _Item = Item
        TxtName.Select()
    End Sub

    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadItem()
    End Sub

    Private Sub LoadItem()
        QtbItemUnit.Unfreeze(True)
        QtbItemGroup.Unfreeze(True)
        LblIDValue.Text = _Item.ID
        BtnStatusValue.Text = _Item.Status
        LblCreationDateValue.Text = _Item.CreationDate.ToString("dd/MM/yyyy")
        _DefaultPhotoPath = _Item.PhotoPath
        PbxPhoto.Image = If(File.Exists(_Item.PhotoPath), GetCopyImage(_Item.PhotoPath), Nothing)
        TxtName.Text = _Item.Name
        QtbItemUnit.Freeze(_Item.ItemUnit.ID)
        QtbItemGroup.Freeze(_Item.ItemGroup.ID)
        TxtInternalCode.Text = _Item.InternalCode
        TxtManufacturer.Text = _Item.Manufacturer
        TxtManufacturerCode.Text = _Item.ManufacturerCode
        TxtNote.Text = _Item.Note
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
                                                                  QtbItemUnit.TextChanged,
                                                                  QtbItemGroup.TextChanged,
                                                                  TxtInternalCode.TextChanged,
                                                                  TxtManufacturer.TextChanged,
                                                                  TxtManufacturerCode.TextChanged,
                                                                  TxtNote.TextChanged


        BtnSave.Enabled = True
    End Sub

    Private Function IsValidFields() As Boolean
        If TxtName.Text = Nothing Then
            CMessageBox.Show("Por favor informe o nome.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcCustomer.SelectedTab = TpMain
            TxtName.Select()
            Return False
        ElseIf Not QtbItemUnit.IsFreezed Then
            CMessageBox.Show("Por favor informe a unidade.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcCustomer.SelectedTab = TpMain
            QtbItemUnit.Select()
            Return False
        ElseIf Not QtbItemGroup.IsFreezed Then
            CMessageBox.Show("Por favor informe o grupo.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcCustomer.SelectedTab = TpMain
            QtbItemGroup.Select()
            Return False
        End If
        Return True
    End Function

    Private Sub BtnStatusValue_Click(sender As Object, e As EventArgs) Handles BtnStatusValue.Click
        If BtnStatusValue.Text = "Ativo" Then
            BtnStatusValue.Text = "Inativo"
            If _Item.Status = "Ativo" Then CMessageBox.Show("O registro foi marcado para ser inativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
        ElseIf BtnStatusValue.Text = "Inativo" Then
            BtnStatusValue.Text = "Ativo"
            If _Item.Status = "Inativo" Then CMessageBox.Show("O registro foi marcado para ser ativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
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
                _Item.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadItem()
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
                _Item.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadItem()
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
                _Item.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadItem()
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
                _Item.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadItem()
            End If
        End If
    End Sub

    Private Sub BtnStatusValue_TextChanged(sender As Object, e As EventArgs) Handles BtnStatusValue.TextChanged
        BtnStatusValue.ForeColor = If(BtnStatusValue.Text = "Ativo", Color.DarkBlue, Color.DarkRed)
    End Sub

    Private Sub BtnExportImage_Click(sender As Object, e As EventArgs) Handles BtnExportImage.Click
        If _Item.PhotoPath <> Nothing And File.Exists(_Item.PhotoPath) Then
            SfdPhoto.FileName = _Item.Name
            If SfdPhoto.ShowDialog = DialogResult.OK Then
                Using b = GetCopyImage(_Item.PhotoPath)
                    b.Save(SfdPhoto.FileName, Imaging.ImageFormat.Png)
                End Using
            End If
        End If
    End Sub


    Private Sub PbxPhoto_MouseUp(sender As Object, e As MouseEventArgs) Handles PbxPhoto.MouseUp
        OfdPhoto.FileName = OfdPhoto.SafeFileName
        If e.Button = MouseButtons.Right Then
            CmsImage.Show(PbxPhoto.PointToScreen(e.Location))
        ElseIf e.Button = MouseButtons.Left And OfdPhoto.ShowDialog = DialogResult.OK Then
            PbxPhoto.Image = GetCopyImage(OfdPhoto.FileName)
            _Item.PhotoPath = OfdPhoto.FileName
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub BtnChoseImage_Click(sender As Object, e As EventArgs) Handles BtnChoseImage.Click
        If OfdPhoto.ShowDialog = DialogResult.OK Then
            PbxPhoto.Image = GetCopyImage(OfdPhoto.FileName)
            _Item.PhotoPath = OfdPhoto.FileName
            BtnSave.Enabled = True
        End If
    End Sub
    Private Sub BtnDeleteImage_Click(sender As Object, e As EventArgs) Handles BtnDeleteImage.Click
        PbxPhoto.Image = Nothing
        _Item.PhotoPath = Nothing
        BtnSave.Enabled = True
    End Sub

    Private Function GetCopyImage(ByVal path As String) As Image
        Using image As Image = Image.FromFile(path)
            Dim bitmap As Bitmap = New Bitmap(image)
            Return bitmap
        End Using
    End Function

    Private Sub QtbItemGroup_KeyDown(sender As Object, e As KeyEventArgs) Handles QtbItemGroup.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Form As New FrmFilter(_Item.ItemGroup, New DataSearch.ItemGroupFilter, CType(sender, QueriedBox))
            Form.Text = "Filtro de Grupos de Item"
            Form.ShowDialog()
        End If
    End Sub

    Private Sub QtbItemUnit_KeyDown(sender As Object, e As KeyEventArgs) Handles QtbItemUnit.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Form As New FrmFilter(_Item.ItemUnit, New DataSearch.ItemUnitFilter, CType(sender, QueriedBox))
            Form.Text = "Filtro de Unidades"
            Form.ShowDialog()
        End If
    End Sub

    Private Function Save() As Boolean
        Dim FirstDisplayedRow As Long
        Dim Filename As String
        Do
            Filename = IO.Path.GetRandomFileName()
        Loop Until Not IO.File.Exists(Common.ItemImagesPath & "\" & Filename)
        Filename = Common.ItemImagesPath & "\" & Filename
        If IsValidFields() Then
            Try

                If _DefaultPhotoPath <> Nothing And _Item.PhotoPath <> Nothing Then
                    If _DefaultPhotoPath <> _Item.PhotoPath Then
                        If IO.File.Exists(_DefaultPhotoPath) Then File.Delete(_DefaultPhotoPath)
                    End If
                End If
                If _DefaultPhotoPath <> Nothing And _Item.PhotoPath = Nothing Then
                    If IO.File.Exists(_DefaultPhotoPath) Then File.Delete(_DefaultPhotoPath)
                End If


                If _Item.PhotoPath <> Nothing Then
                    File.Copy(_Item.PhotoPath, Filename)
                    _Item.PhotoPath = Filename
                    _DefaultPhotoPath = Filename
                Else
                    _Item.PhotoPath = Nothing
                    _DefaultPhotoPath = Nothing
                End If

                _Item.Status = BtnStatusValue.Text
                _Item.Name = TxtName.Text
                _Item.ItemUnit = New ItemUnit(QtbItemUnit.FreezedPrimaryKey)
                _Item.ItemGroup = New ItemGroup(QtbItemGroup.FreezedPrimaryKey)
                _Item.InternalCode = TxtInternalCode.Text
                _Item.Manufacturer = TxtManufacturer.Text
                _Item.ManufacturerCode = TxtManufacturerCode.Text
                _Item.Note = TxtNote.Text
                _Item.Save()
                LblIDValue.Text = _Item.ID
                BtnStatusValue.Text = _Item.Status
                BtnStatusValue.Enabled = True
                LblCreationDateValue.Text = _Item.CreationDate.ToString("dd/MM/yyyy")
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
        _Item = New Item
        LoadItem()
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
        If _Item.ID <> 0 Then
            If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    _Item.Delete()
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

    Private Sub TxtNote_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles TxtNote.LinkClicked
        Process.Start(e.LinkText)
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        Dim Form As New FrmLog(Common.Routines.Item, _Item.ID)
        Form.ShowDialog()
    End Sub


End Class