Imports ControlLibrary

Public Class FrmPersonContact
    Private _Person As Person
    Private _PersonContact As Person.Contact
    Private _PersonForm As FrmPerson
    Private _ContactSaved As Boolean
    Private _Deleting As Boolean
    Public Sub New(ByVal Person As Person, ByVal PersonContact As Person.Contact, ByVal ParentForm As FrmPerson)
        InitializeComponent()
        _Person = Person
        _PersonContact = PersonContact
        _PersonForm = ParentForm
    End Sub
    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadContact()
        Tip.SetToolTip(TxtPhone1, "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000" & vbNewLine & "Com ou sem mascara.")
        Tip.SetToolTip(TxtPhone2, "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000" & vbNewLine & "Com ou sem mascara.")
        Tip.SetToolTip(TxtPhone3, "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000" & vbNewLine & "Com ou sem mascara.")
    End Sub
    Private Sub LoadContact()
        If _PersonContact.ID > 0 Then
            _ContactSaved = True
        Else
            _ContactSaved = False
        End If
        LblSeqValue.Text = _PersonContact.Seq
        TxtName.Text = _PersonContact.Name
        TxtJobTitle.Text = _PersonContact.JobTitle
        TxtPhone1.Text = _PersonContact.Phone1
        TxtPhone2.Text = _PersonContact.Phone2
        TxtPhone3.Text = _PersonContact.Phone3
        TxtEmail1.Text = _PersonContact.Email1
        TxtEmail2.Text = _PersonContact.Email2
        BtnSave.Enabled = False
        RefreshNavigation()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        PreSave()
    End Sub
    Private Function PreSave() As Boolean
        If IsValidFields() Then
            If _PersonContact.Seq > 0 Then _ContactSaved = True
            If Not _ContactSaved Then
                _PersonContact = New Person.Contact With {
                    .Name = TxtName.Text,
                    .JobTitle = TxtJobTitle.Text,
                    .Phone1 = TxtPhone1.Text,
                    .Phone2 = TxtPhone2.Text,
                    .Phone3 = TxtPhone3.Text,
                    .Email1 = TxtEmail1.Text,
                    .Email2 = TxtEmail2.Text
                }
                _Person.Contacts.Add(_PersonContact)
                LblSeqValue.Text = _PersonContact.Seq
                _ContactSaved = True
            Else
                _PersonContact.Name = TxtName.Text
                _PersonContact.JobTitle = TxtJobTitle.Text
                _PersonContact.Phone1 = TxtPhone1.Text
                _PersonContact.Phone2 = TxtPhone2.Text
                _PersonContact.Phone3 = TxtPhone3.Text
                _PersonContact.Email1 = TxtEmail1.Text
                _PersonContact.Email2 = TxtEmail2.Text
            End If
            _Person.GetContacts(_PersonForm.DgvContacts, LblSeqValue.Text)
            TxtName.Select()
            RefreshNavigation()
            BtnSave.Enabled = False
            _PersonForm.BtnSave.Enabled = True
            Return True
        Else
            Return False
        End If
    End Function

    Private Function IsValidFields() As Boolean
        Dim Phone1 As String
        Dim Phone2 As String
        Dim Phone3 As String
        Dim Email1 As String
        Dim Email2 As String
        Dim RegexEmail As Text.RegularExpressions.Regex
        Phone1 = TxtPhone1.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
        Phone2 = TxtPhone2.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
        Phone3 = TxtPhone3.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
        RegexEmail = New Text.RegularExpressions.Regex("^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$")
        Email1 = TxtEmail1.Text
        Email2 = TxtEmail2.Text
        If Phone1.Length > 0 AndAlso Not IsNumeric(Phone1) Then
            'CMessageBox.CMessageBoxStyle.SmallDialogSize = New Size(CMessageBox.CMessageBoxStyle.SmallDialogSize.Width, CMessageBox.CMessageBoxStyle.SmallDialogSize.Height + 50)
            CMessageBox.Show("Telefone inválido, utilize um dos formatos abaixo, com ou sem mascara." & vbNewLine &
                                  "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000",
                                  CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            'CMessageBox.CMessageBoxStyle.Reset()
            TxtPhone1.Select()
            Return False
        ElseIf Phone2.Length > 0 AndAlso Not IsNumeric(Phone2) Then
            'CMessageBox.CMessageBoxStyle.SmallDialogSize = New Size(CMessageBox.CMessageBoxStyle.SmallDialogSize.Width, CMessageBox.CMessageBoxStyle.SmallDialogSize.Height + 50)
            CMessageBox.Show("Telefone inválido, utilize um dos formatos abaixo, com ou sem mascara." & vbNewLine &
                                  "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000",
                                  CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            'CMessageBox.CMessageBoxStyle.Reset()
            TxtPhone2.Select()
            Return False
        ElseIf Phone3.Length > 0 AndAlso Not IsNumeric(Phone3) Then
            'CMessageBox.CMessageBoxStyle.SmallDialogSize = New Size(CMessageBox.CMessageBoxStyle.SmallDialogSize.Width, CMessageBox.CMessageBoxStyle.SmallDialogSize.Height + 50)
            CMessageBox.Show("Telefone inválido, utilize um dos formatos abaixo, com ou sem mascara." & vbNewLine &
                                  "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000",
                                  CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            'CMessageBox.CMessageBoxStyle.Reset()
            TxtPhone3.Select()
            Return False
        ElseIf Phone1.Length > 0 AndAlso Phone1.Length < 10 Or Phone1.Length > 11 Then
            'CMessageBox.CMessageBoxStyle.SmallDialogSize = New Size(CMessageBox.CMessageBoxStyle.SmallDialogSize.Width, CMessageBox.CMessageBoxStyle.SmallDialogSize.Height + 50)
            CMessageBox.Show("Telefone inválido, utilize um dos formatos abaixo, com ou sem mascara." & vbNewLine &
                                  "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000",
                                  CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            'CMessageBox.CMessageBoxStyle.Reset()
            TxtPhone1.Select()
            Return False
        ElseIf Phone2.Length > 0 AndAlso Phone2.Length < 10 Or Phone2.Length > 11 Then
            'CMessageBox.CMessageBoxStyle.SmallDialogSize = New Size(CMessageBox.CMessageBoxStyle.SmallDialogSize.Width, CMessageBox.CMessageBoxStyle.SmallDialogSize.Height + 50)
            CMessageBox.Show("Telefone inválido, utilize um dos formatos abaixo, com ou sem mascara." & vbNewLine &
                                  "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000",
                                  CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            'CMessageBox.CMessageBoxStyle.Reset()
            TxtPhone2.Select()
            Return False
        ElseIf Phone3.Length > 0 AndAlso Phone3.Length < 10 Or Phone3.Length > 11 Then
            'CMessageBox.CMessageBoxStyle.SmallDialogSize = New Size(CMessageBox.CMessageBoxStyle.SmallDialogSize.Width, CMessageBox.CMessageBoxStyle.SmallDialogSize.Height + 50)
            CMessageBox.Show("Telefone inválido, utilize um dos formatos abaixo, com ou sem mascara." & vbNewLine &
                                  "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000",
                                  CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            'CMessageBox.CMessageBoxStyle.Reset()
            TxtPhone3.Select()
            Return False
        ElseIf Email1.Length > 0 AndAlso Not RegexEmail.IsMatch(Email1) Then
            CMessageBox.Show("E-mail inválido.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtEmail1.Select()
            Return False
        ElseIf Email2.Length > 0 AndAlso Not RegexEmail.IsMatch(Email2) Then
            CMessageBox.Show("E-mail inválido.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtEmail2.Select()
            Return False
        End If
        Return True
    End Function
    Public Sub RefreshNavigation()
        If _PersonForm.DgvContacts.SelectedRows.Count = 1 Then
            If _PersonForm.DgvContacts.Rows(0).Selected And _PersonForm.DgvContacts.Rows.Count > 1 Then
                If _PersonForm.DgvContacts.SelectedRows(0).Displayed = False Then
                    _PersonForm.DgvContacts.FirstDisplayedScrollingRowIndex = _PersonForm.DgvContacts.SelectedRows(0).Index
                End If
                BtnFirst.Enabled = False
                BtnPrevious.Enabled = False
                BtnNext.Enabled = True
                BtnLast.Enabled = True
            ElseIf _PersonForm.DgvContacts.Rows(0).Selected And _PersonForm.DgvContacts.Rows.Count = 1 Then
                If _PersonForm.DgvContacts.SelectedRows(0).Displayed = False Then
                    _PersonForm.DgvContacts.FirstDisplayedScrollingRowIndex = _PersonForm.DgvContacts.SelectedRows(0).Index
                End If
                BtnFirst.Enabled = False
                BtnPrevious.Enabled = False
                BtnNext.Enabled = False
                BtnLast.Enabled = False
            ElseIf _PersonForm.DgvContacts.Rows(_PersonForm.DgvContacts.Rows.Count - 1).Selected Then
                If _PersonForm.DgvContacts.SelectedRows(0).Displayed = False Then
                    _PersonForm.DgvContacts.FirstDisplayedScrollingRowIndex = _PersonForm.DgvContacts.RowCount - 1
                End If
                BtnFirst.Enabled = True
                BtnPrevious.Enabled = True
                BtnNext.Enabled = False
                BtnLast.Enabled = False
            Else
                If _PersonForm.DgvContacts.SelectedRows(0).Displayed = False Then
                    _PersonForm.DgvContacts.FirstDisplayedScrollingRowIndex = _PersonForm.DgvContacts.SelectedRows(0).Index
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
    Private Sub Changes(sender As Object, e As EventArgs) Handles TxtName.TextChanged,
                                                                  TxtJobTitle.TextChanged,
                                                                  TxtPhone1.TextChanged,
                                                                  TxtPhone2.TextChanged,
                                                                  TxtPhone3.TextChanged,
                                                                  TxtEmail1.TextChanged,
                                                                  TxtEmail2.TextChanged
        BtnSave.Enabled = True
    End Sub
    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If _PersonForm.DgvContacts.SelectedRows.Count = 1 Then
            If _PersonForm.DgvContacts.SelectedRows(0).Index > 0 Then
                _PersonForm.DgvContacts.Rows(0).Selected = True
                _PersonContact = New Person.Contact With {
                    .Seq = _PersonForm.DgvContacts.SelectedRows(0).Cells("SEQ").Value,
                    .ID = _PersonForm.DgvContacts.SelectedRows(0).Cells("ID").Value,
                    .Name = _PersonForm.DgvContacts.SelectedRows(0).Cells("NAME").Value,
                    .JobTitle = _PersonForm.DgvContacts.SelectedRows(0).Cells("JOBTITLE").Value,
                    .Phone1 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE1").Value,
                    .Phone2 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE2").Value,
                    .Phone3 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE3").Value,
                    .Email1 = _PersonForm.DgvContacts.SelectedRows(0).Cells("EMAIL1").Value,
                    .Email2 = _PersonForm.DgvContacts.SelectedRows(0).Cells("EMAIL2").Value
                }
                LoadContact()
            End If
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If _PersonForm.DgvContacts.SelectedRows.Count = 1 Then
            If _PersonForm.DgvContacts.SelectedRows(0).Index > 0 Then
                _PersonForm.DgvContacts.Rows(_PersonForm.DgvContacts.SelectedRows(0).Index - 1).Selected = True
                _PersonContact = New Person.Contact With {
                    .Seq = _PersonForm.DgvContacts.SelectedRows(0).Cells("SEQ").Value,
                    .ID = _PersonForm.DgvContacts.SelectedRows(0).Cells("ID").Value,
                    .Name = _PersonForm.DgvContacts.SelectedRows(0).Cells("NAME").Value,
                    .JobTitle = _PersonForm.DgvContacts.SelectedRows(0).Cells("JOBTITLE").Value,
                    .Phone1 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE1").Value,
                    .Phone2 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE2").Value,
                    .Phone3 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE3").Value,
                    .Email1 = _PersonForm.DgvContacts.SelectedRows(0).Cells("EMAIL1").Value,
                    .Email2 = _PersonForm.DgvContacts.SelectedRows(0).Cells("EMAIL2").Value
                }
                LoadContact()
            End If
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If _PersonForm.DgvContacts.SelectedRows.Count = 1 Then
            If _PersonForm.DgvContacts.SelectedRows(0).Index < _PersonForm.DgvContacts.Rows.Count - 1 Then
                _PersonForm.DgvContacts.Rows(_PersonForm.DgvContacts.SelectedRows(0).Index + 1).Selected = True
                _PersonContact = New Person.Contact With {
                    .Seq = _PersonForm.DgvContacts.SelectedRows(0).Cells("SEQ").Value,
                    .ID = _PersonForm.DgvContacts.SelectedRows(0).Cells("ID").Value,
                    .Name = _PersonForm.DgvContacts.SelectedRows(0).Cells("NAME").Value,
                    .JobTitle = _PersonForm.DgvContacts.SelectedRows(0).Cells("JOBTITLE").Value,
                    .Phone1 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE1").Value,
                    .Phone2 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE2").Value,
                    .Phone3 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE3").Value,
                    .Email1 = _PersonForm.DgvContacts.SelectedRows(0).Cells("EMAIL1").Value,
                    .Email2 = _PersonForm.DgvContacts.SelectedRows(0).Cells("EMAIL2").Value
                }
                LoadContact()
            End If
        End If
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If _PersonForm.DgvContacts.SelectedRows.Count = 1 Then
            If _PersonForm.DgvContacts.SelectedRows(0).Index < _PersonForm.DgvContacts.Rows.Count - 1 Then
                _PersonForm.DgvContacts.Rows(_PersonForm.DgvContacts.Rows.Count - 1).Selected = True
                _PersonContact = New Person.Contact With {
                    .Seq = _PersonForm.DgvContacts.SelectedRows(0).Cells("SEQ").Value,
                    .ID = _PersonForm.DgvContacts.SelectedRows(0).Cells("ID").Value,
                    .Name = _PersonForm.DgvContacts.SelectedRows(0).Cells("NAME").Value,
                    .JobTitle = _PersonForm.DgvContacts.SelectedRows(0).Cells("JOBTITLE").Value,
                    .Phone1 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE1").Value,
                    .Phone2 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE2").Value,
                    .Phone3 = _PersonForm.DgvContacts.SelectedRows(0).Cells("PHONE3").Value,
                    .Email1 = _PersonForm.DgvContacts.SelectedRows(0).Cells("EMAIL1").Value,
                    .Email2 = _PersonForm.DgvContacts.SelectedRows(0).Cells("EMAIL2").Value
                }
                LoadContact()
            End If
        End If

    End Sub


    Private Sub TxtPhone_LostFocus(sender As Object, e As EventArgs) Handles TxtPhone1.LostFocus, TxtPhone2.LostFocus, TxtPhone3.LostFocus
        Dim TxtBox As TextBox = CType(sender, TextBox)
        Dim Txt As String = TxtBox.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")
        If IsNumeric(Txt) Then
            Select Case Txt.Length
                Case Is = 11
                    If Strings.Left(Txt, 4) = "0300" Or Strings.Left(Txt, 4) = "0500" Or
                       Strings.Left(Txt, 4) = "0800" Or Strings.Left(Txt, 4) = "0900" Then
                        Txt = Txt.Substring(0, 4) & "-" & Txt.Substring(4, 3) & "-" & Txt.Substring(7, 4)
                    Else
                        Txt = "(" & Txt.Substring(0, 2) & ") " & Txt.Substring(2, 1) & " " & Txt.Substring(3, 4) & "-" & Txt.Substring(7, 4)
                    End If
                    TxtBox.Text = Txt
                Case Is = 10
                    Txt = "(" & Txt.Substring(0, 2) & ") " & Txt.Substring(2, 4) & "-" & Txt.Substring(6, 4)
                    TxtBox.Text = Txt
            End Select
        End If
    End Sub
    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        _PersonContact = New Person.Contact
        LoadContact()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each Contact As Person.Contact In _Person.Contacts
                If Contact.ID = _PersonContact.ID Then
                    _Person.Contacts.Remove(Contact)
                    _Person.GetContacts(_PersonForm.DgvContacts)
                    _Deleting = True
                    Dispose()
                    _PersonForm.BtnSave.Enabled = True
                    Exit For
                End If
            Next Contact
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