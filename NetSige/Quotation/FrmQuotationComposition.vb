Imports ControlLibrary
Public Class FrmQuotationComposition
    Private BtnA As New Point(131, 8)
    Private BtnB As New Point(232, 8)
    Private BtnC As New Point(333, 8)
    Private BtnD As New Point(434, 8)
    Private [Step] As Integer = 1
    Private UcChoseProviders As New UcCompositionProviders With {.Dock = DockStyle.Fill, .Visible = True}
    Private UcChoseItems As New UcCompositionItems With {.Dock = DockStyle.Fill, .Visible = False}
    Private UcGeneral As New UcCompositionGeneral With {.Dock = DockStyle.Fill, .Visible = False}

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If [Step] = 1 Then
            If UcChoseProviders.DgvProviders.Rows.Count = 0 Then
                CMessageBox.Show("Não é possível compor uma cotação sem fornecedores.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
            Else
                If [Step] = 1 Then
                    BtnPrevious.Visible = True
                    UcChoseProviders.Visible = False
                    UcChoseItems.Visible = True
                    UcChoseItems.DtbQtd.Select()
                    BtnCancel.Location = BtnB
                    BtnPrevious.Location = BtnC
                    BtnNext.Location = BtnD
                    [Step] = 2
                End If
            End If
        ElseIf [Step] = 2 Then
            If UcChoseItems.DgvItems.Rows.Count = 0 Then
                CMessageBox.Show("Não é possível compor uma cotação sem itens.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
            Else
                BtnNext.Visible = False
                BtnDone.Visible = True
                BtnDone.Location = BtnD
                UcChoseItems.Visible = False
                UcGeneral.Visible = True
                [Step] = 3
            End If
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If [Step] = 2 Then
            BtnPrevious.Visible = False
            UcChoseProviders.Visible = True
            UcChoseItems.Visible = False
            BtnCancel.Location = BtnC
            BtnNext.Location = BtnD
            [Step] = 1
        ElseIf [Step] = 3 Then
            UcChoseItems.Visible = True
            UcChoseItems.DtbQtd.Select()
            UcGeneral.Visible = False
            BtnDone.Visible = False
            BtnNext.Visible = True
            [Step] = 2
        End If
    End Sub

    Private Sub FrmQuotationComposition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controls.AddRange({UcChoseProviders, UcChoseItems, UcGeneral})
        BtnCancel.Location = BtnC
        BtnNext.Location = BtnD
        UcChoseProviders.QtbDocument.Select()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Dispose()
    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click
        Dim Quotation As New Quotation
        Dim Answer As Quotation.Answer
        Dim QuotProv As Quotation.QuotationProvider
        Dim QuotItem As Quotation.QuotationItem


        Quotation.Note = UcGeneral.TxtNote.Text

        For Provider = 0 To UcChoseProviders.DgvProviders.Rows.Count - 1
            For Item = 0 To UcChoseItems.DgvItems.Rows.Count - 1
                Answer = New Quotation.Answer
                QuotProv = New Quotation.QuotationProvider
                QuotProv.Provider = New Person(UcChoseProviders.DgvProviders.Rows(Provider).Tag)
                QuotItem = New Quotation.QuotationItem
                QuotItem.Item = New Item(UcChoseItems.DgvItems.Rows(Item).Tag)
                'Answer.Item = QuotItem
                'Answer.Provider = QuotProv
                Quotation.Answers.Add(Answer)
            Next Item
        Next Provider





    End Sub
End Class