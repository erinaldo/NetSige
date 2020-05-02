Imports System.IO
Imports ControlLibrary
Public Class FrmOrder
    Friend WithEvents InitialDeliveryCalendar As New MonthCalendar
    Friend WithEvents FinalDeliveryCalendar As New MonthCalendar
    Private _Order As Order
    Private _FormGrid As FrmOrdersGrid
    Private _Grid As DataGridView
    Private _Filter As Order.Filter
    Private _Deleting As Boolean
    Public Sub New(ByVal PurchaseOrder As Order, ByVal FormGrid As FrmOrdersGrid)
        InitializeComponent()
        _Order = PurchaseOrder
        _FormGrid = FormGrid
        _Grid = _FormGrid.DgvData
        _Filter = CType(_FormGrid.PgFilter.SelectedObject, Order.Filter)
        QtbCostSharingID.Select()
    End Sub
    Public Sub New(ByVal PurchaseOrder As Order)
        InitializeComponent()
        BtnFirst.Enabled = False
        BtnPrevious.Enabled = False
        BtnNext.Enabled = False
        BtnLast.Enabled = False
        _Order = PurchaseOrder
        QtbCostSharingID.Select()
    End Sub
    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadOrder()
        Common.DataGridViewDoubleBuffered(DgvItems, True)
        Tip.SetToolTip(TxtPhone, "Fixo: (00) 0000-0000" & vbNewLine & "Celular: (00) 0 0000-0000" & vbNewLine & "Não geograficos: 0000-000-0000" & vbNewLine & "Com ou sem mascara.")
    End Sub
    Private Sub LoadOrder()
        InitialDeliveryCalendar.Visible = False
        Controls.Add(InitialDeliveryCalendar)
        CcoInitialDelivery.DropDownControl = InitialDeliveryCalendar
        FinalDeliveryCalendar.Visible = False
        Controls.Add(FinalDeliveryCalendar)
        CcoFinalDelivery.DropDownControl = FinalDeliveryCalendar
        QtbCostSharingID.Unfreeze(True)
        QtbProviderID.Unfreeze(True)
        QtbPaymentID.Unfreeze(True)
        QtbCarrierID.Unfreeze(True)
        LblIDValue.Text = _Order.ID
        BtnStatusValue.Text = _Order.Status
        LblSituation.Text = "Pedido " & _Order.Situation
        BtnDelete.Enabled = If(_Order.Situation = "Aprovado", False, True)
        LblCreationDateValue.Text = _Order.CreationDate.ToString("dd/MM/yyyy")
        LblQuotation.Visible = If(_Order.Quotation.ID = 0, False, True)
        LblQuotationValue.Visible = If(_Order.Quotation.ID = 0, False, True)
        LblQuotationValue.Text = _Order.Quotation.ID
        QtbCostSharingID.Freeze(_Order.CostSharing.ID, True)
        CbxLocals.SelectedValue = _Order.CostSharingLocalID
        QtbProviderID.Freeze(_Order.Provider.ID, True)
        QtbProviderID.Select(0, 0)
        TxtContact.Text = _Order.Contact
        TxtPhone.Text = _Order.Phone
        TxtEmail.Text = _Order.Email
        QtbPaymentID.Freeze(_Order.Payment.ID, True)
        TxtInitialDelivery.Text = _Order.InitialDelivery
        TxtFinalDelivery.Text = _Order.FinalDelivery
        CbxCarrierType.Text = _Order.CarrierType
        QtbCarrierID.Freeze(_Order.Carrier.ID, True)
        DtbDiscount.Text = _Order.Discount
        DtbExpense.Text = _Order.Expense
        DtbCarrierPrice.Text = _Order.CarrierPrice
        DtbICMSST.Text = _Order.ICMSST
        TxtExternalNote.Text = _Order.ExternalNote
        TxtInternalNote.Text = _Order.InternalNote
        _Order.GetItems(DgvItems)
        BtnSave.Enabled = False
        RefreshTotals()
        ApplyFormStateStyle()
        RefreshNavigation()
    End Sub
    Private Sub BtnInitialDelivery_Click(sender As Object, e As EventArgs) Handles BtnInitialDelivery.Click
        InitialDeliveryCalendar.Visible = True
    End Sub
    Private Sub BtnFinalDelivery_Click(sender As Object, e As EventArgs) Handles BtnFinalDelivery.Click
        FinalDeliveryCalendar.Visible = True
    End Sub
    Private Sub InitialDeliveryCalendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles InitialDeliveryCalendar.DateSelected
        CcoInitialDelivery.CloseDropDown()
    End Sub
    Private Sub CcoInitialDelivery_Closed(sender As Object) Handles CcoInitialDelivery.Closed
        TxtInitialDelivery.Text = InitialDeliveryCalendar.SelectionStart
    End Sub
    Private Sub CcoInitialDelivery_Dropped(sender As Object) Handles CcoInitialDelivery.Dropped
        If Not IsDate(TxtInitialDelivery.Text) Then InitialDeliveryCalendar.SelectionStart = Today
    End Sub
    Private Sub FinalDeliveryCalendar_DateSelected(sender As Object, e As DateRangeEventArgs) Handles FinalDeliveryCalendar.DateSelected
        CcoFinalDelivery.CloseDropDown()
    End Sub
    Private Sub CcoFinalDelivery_Closed(sender As Object) Handles CcoFinalDelivery.Closed
        TxtFinalDelivery.Text = FinalDeliveryCalendar.SelectionStart
    End Sub
    Private Sub CcoFinalDelivery_Dropped(sender As Object) Handles CcoFinalDelivery.Dropped
        If Not IsDate(TxtFinalDelivery.Text) Then FinalDeliveryCalendar.SelectionStart = Today
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
    Private Sub Changes(sender As Object, e As EventArgs) Handles QtbCostSharingID.TextChanged,
                                                                  QtbCostSharingDocument.TextChanged,
                                                                  QtbCostSharingName.TextChanged,
                                                                  CbxLocals.SelectedIndexChanged,
                                                                  QtbProviderID.TextChanged,
                                                                  QtbProviderDocument.TextChanged,
                                                                  QtbProviderName.TextChanged,
                                                                  TxtContact.TextChanged,
                                                                  TxtPhone.TextChanged,
                                                                  TxtEmail.TextChanged,
                                                                  QtbPaymentID.TextChanged,
                                                                  QtbPaymentName.TextChanged,
                                                                  TxtInitialDelivery.TextChanged,
                                                                  TxtFinalDelivery.TextChanged,
                                                                  DtbDiscount.TextChanged,
                                                                  DtbCarrierPrice.TextChanged,
                                                                  DtbExpense.TextChanged,
                                                                  DtbICMSST.TextChanged,
                                                                  CbxCarrierType.SelectedIndexChanged,
                                                                  QtbCarrierID.TextChanged,
                                                                  QtbCarrierDocument.TextChanged,
                                                                  QtbCostSharingDocument.TextChanged,
                                                                  TxtExternalNote.TextChanged,
                                                                  TxtInternalNote.TextChanged
        If sender Is CbxCarrierType Then
            If CbxCarrierType.SelectedIndex = 3 Then
                QtbCarrierID.Enabled = True
                QtbCarrierDocument.Enabled = True
                QtbCarrierName.Enabled = True
            Else
                QtbCarrierID.Enabled = False
                QtbCarrierDocument.Enabled = False
                QtbCarrierName.Enabled = False
            End If
            QtbCarrierName.Unfreeze()
        End If
        BtnSave.Enabled = True
    End Sub
    Private Sub Changes2(sender As Object, e As EventArgs) Handles DtbDiscount.TextChanged,
                                                                   DtbExpense.TextChanged,
                                                                   DtbCarrierPrice.TextChanged,
                                                                   DtbICMSST.TextChanged
        RefreshTotals()
    End Sub
    Public Sub RefreshTotals()
        Dim ItemQuantity As Decimal
        Dim ItemPrice As Decimal
        Dim ItemIPI As Decimal
        Dim TotalItems As Decimal
        Dim ItemsDiscount As Decimal
        Dim OrderExpense As Decimal
        Dim OrderCarrier As Decimal
        Dim orderICMSST As Decimal
        Dim OrderDiscount As Decimal
        Dim OrderTotalGross As Decimal
        Dim OrderTotalNet As Decimal
        If _Order IsNot Nothing Then
            OrderTotalGross = 0
            For Each Row As DataGridViewRow In DgvItems.Rows
                ItemQuantity = Row.Cells("QUANTITY").Value
                ItemPrice = Row.Cells("PRICE").Value
                ItemIPI = Row.Cells("IPI").Value
                TotalItems += (ItemIPI * ItemPrice + ItemPrice) * ItemQuantity
                ItemsDiscount += Row.Cells("QUANTITY").Value * Row.Cells("DISCOUNT").Value
            Next Row
            OrderDiscount = DtbDiscount.DecimalValue
            OrderExpense = DtbExpense.DecimalValue
            OrderCarrier = DtbCarrierPrice.DecimalValue
            orderICMSST = DtbICMSST.DecimalValue
            OrderTotalGross = TotalItems + OrderExpense + OrderCarrier + orderICMSST
            OrderTotalNet = OrderTotalGross - ItemsDiscount - OrderDiscount
            LblTotalGrossValue.Text = FormatNumber(OrderTotalGross, 2, TriState.True)
            LblTotalNetValue.Text = FormatNumber(OrderTotalNet, 2, TriState.True)
        End If
    End Sub
    Private Function IsValidFields() As Boolean
        Dim RegexEmail As Text.RegularExpressions.Regex
        RegexEmail = New Text.RegularExpressions.Regex("^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$")
        If Not QtbCostSharingID.IsFreezed And Not QtbCostSharingName.IsFreezed Then
            CMessageBox.Show("Por favor informe o centro de custo.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcOrder.SelectedTab = TpMain
            QtbCostSharingName.Select()
            Return False
        ElseIf Not QtbProviderID.IsFreezed And Not QtbProviderDocument.IsFreezed And Not QtbProviderName.IsFreezed Then
            CMessageBox.Show("Por favor informe o fornecedor.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcOrder.SelectedTab = TpMain
            QtbProviderName.Select()
            Return False
        ElseIf TxtEmail.Text.Length > 0 AndAlso Not RegexEmail.IsMatch(TxtEmail.Text) Then
            CMessageBox.Show("E-mail inválido.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TxtEmail.Select()
            Return False
        ElseIf Not QtbPaymentName.IsFreezed Then
            CMessageBox.Show("Por favor informe a condição de pagamento.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcOrder.SelectedTab = TpMain
            QtbPaymentName.Select()
            Return False
        ElseIf TxtInitialDelivery.Text < _Order.CreationDate Then
            CMessageBox.Show("A previsão de entrega não pode ser anterior a data de criação do pedido de compra.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcOrder.SelectedTab = TpMain
            TxtInitialDelivery.Select()
            Return False
        ElseIf LblTotalNetValue.Text < 0 Then
            CMessageBox.Show("O valor líquido do pedido não pode ser menor que 0 (zero).", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            TcOrder.SelectedTab = TpMain
            Return False
        ElseIf DgvItems.Rows.Count = 0 Then
            TcOrder.SelectedTab = TpItems
            CMessageBox.Show("Por favor inclua pelo menos um item no pedido de compra.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            Return False
        ElseIf QtbCarrierName.FreezedPrimaryKey = 0 And QtbCarrierName.Text <> Nothing Then
            If CMessageBox.Show("Há dados no campo Transportadora, mas ela não foi definida. Deseja salvar o registro sem a transportadora?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.No Then
                QtbCarrierName.Select()
                Return False
            Else
                QtbCarrierName.Text = Nothing
            End If
        End If
        Return True
    End Function
    'REFAZER
    Private Sub BtnStatusValue_Click(sender As Object, e As EventArgs) Handles BtnStatusValue.Click
        If BtnStatusValue.Text = "Pendente" Then
            BtnStatusValue.Text = "Cancelado"
            If _Order.Status = "Pendente" Then CMessageBox.Show("O registro foi marcado para ser inativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
            BtnSave.Enabled = True
        ElseIf BtnStatusValue.Text = "Cancelado" Then
            BtnStatusValue.Text = "Pendente"
            If _Order.Status = "Cancelado" Then CMessageBox.Show("O registro foi marcado para ser ativado, salve para concluir a operação.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
            BtnSave.Enabled = True
        End If
    End Sub
    'REFAZER
    Private Sub BtnStatusValue_TextChanged(sender As Object, e As EventArgs) Handles BtnStatusValue.TextChanged
        Select Case BtnStatusValue.Text
            Case Is = "Pendente"
                BtnStatusValue.ForeColor = Color.DarkBlue
            Case Is = "Cancelado"
                BtnStatusValue.ForeColor = Color.DarkRed
            Case Is = "Parc. Recebido"
                BtnStatusValue.ForeColor = Color.DarkOrange
            Case Is = "Recebido"
                BtnStatusValue.ForeColor = Color.DarkGreen
        End Select
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
                _Order.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadOrder()
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
                _Order.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadOrder()
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
                _Order.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadOrder()
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
                _Order.Load(_Grid.SelectedRows(0).Cells("ID").Value)
                LoadOrder()
            End If
        End If
    End Sub
    Private Sub TxtPhone_LostFocus(sender As Object, e As EventArgs) Handles TxtPhone.LostFocus
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
    Public Sub ApplyFormStateStyle()
        If BtnStatusValue.Text = "Cancelado" Or LblSituation.Text = "Pedido Aprovado" Then
            BtnStatusValue.Visible = False
            LblCancel.Visible = True
            QtbCostSharingID.ReadOnly = True
            QtbCostSharingDocument.ReadOnly = True
            QtbCostSharingName.ReadOnly = True
            QtbProviderID.ReadOnly = True
            QtbProviderDocument.ReadOnly = True
            QtbProviderName.ReadOnly = True
            TxtContact.ReadOnly = True
            TxtPhone.ReadOnly = True
            TxtEmail.ReadOnly = True
            QtbPaymentID.ReadOnly = True
            QtbPaymentName.ReadOnly = True
            TxtInitialDelivery.ReadOnly = True
            BtnInitialDelivery.Enabled = False
            TxtFinalDelivery.ReadOnly = True
            BtnFinalDelivery.Enabled = False
            DtbDiscount.ReadOnly = True
            DtbExpense.ReadOnly = True
            DtbCarrierPrice.ReadOnly = True
            DtbICMSST.ReadOnly = True
            CbxCarrierType.Enabled = False
            QtbCarrierID.ReadOnly = True
            QtbCarrierDocument.ReadOnly = True
            QtbCarrierName.ReadOnly = True
            BtnIncludeItem.Enabled = False
            BtnEditItem.Enabled = False
            BtnDeleteItem.Enabled = False
            TxtExternalNote.ReadOnly = True
            TxtInternalNote.ReadOnly = True
        Else
            BtnStatusValue.Visible = True
            LblCancel.Visible = False
            QtbCostSharingID.ReadOnly = False
            QtbCostSharingDocument.ReadOnly = False
            QtbCostSharingName.ReadOnly = False
            QtbProviderID.ReadOnly = False
            QtbProviderDocument.ReadOnly = False
            QtbProviderName.ReadOnly = False
            TxtContact.ReadOnly = False
            TxtPhone.ReadOnly = False
            TxtEmail.ReadOnly = False
            QtbPaymentID.ReadOnly = False
            QtbPaymentName.ReadOnly = False
            TxtInitialDelivery.ReadOnly = False
            BtnInitialDelivery.Enabled = True
            TxtFinalDelivery.ReadOnly = False
            BtnFinalDelivery.Enabled = True
            DtbDiscount.ReadOnly = False
            DtbExpense.ReadOnly = False
            DtbCarrierPrice.ReadOnly = False
            DtbICMSST.ReadOnly = False
            CbxCarrierType.Enabled = True
            QtbCarrierID.ReadOnly = False
            QtbCarrierDocument.ReadOnly = False
            QtbCarrierName.ReadOnly = False
            BtnIncludeItem.Enabled = True
            BtnEditItem.Enabled = True
            BtnDeleteItem.Enabled = True
            TxtExternalNote.ReadOnly = False
            TxtInternalNote.ReadOnly = False
        End If
        BtnApprove.Enabled = If(_Order.ID > 0, True, False)
        BtnFinalizeItem.Enabled = If(_Order.Situation = "Aprovado", True, False)
        BtnPrint.Enabled = If(_Order.Situation = "Aprovado", True, False)

    End Sub
    Private Function Save() As Boolean
        Dim FirstDisplayedRow As Long
        If IsValidFields() Then
            _Order.Status = BtnStatusValue.Text
            _Order.Quotation = If(_Order.Quotation.ID = 0, New Quotation, New Quotation(LblQuotationValue.Text))
            _Order.CostSharing = New CostSharing(QtbCostSharingID.FreezedPrimaryKey)
            _Order.CostSharingLocalID = CbxLocals.SelectedValue
            _Order.Provider = New Person(QtbProviderID.FreezedPrimaryKey)
            _Order.Contact = TxtContact.Text
            _Order.Phone = TxtPhone.Text
            _Order.Email = TxtEmail.Text
            _Order.Payment = New PaymentTerm(QtbPaymentName.FreezedPrimaryKey)
            _Order.InitialDelivery = TxtInitialDelivery.Text
            _Order.CarrierType = CbxCarrierType.Text
            _Order.Carrier = If(QtbCarrierName.FreezedPrimaryKey > 0, New Person(QtbCarrierName.FreezedPrimaryKey), New Person())
            _Order.Discount = DtbDiscount.DecimalValue
            _Order.Expense = DtbExpense.DecimalValue
            _Order.CarrierPrice = DtbCarrierPrice.DecimalValue
            _Order.ICMSST = DtbICMSST.DecimalValue
            _Order.ExternalNote = TxtExternalNote.Text
            _Order.InternalNote = TxtInternalNote.Text
            Try
                _Order.Save()
                LblIDValue.Text = _Order.ID
                BtnStatusValue.Text = _Order.Status
                ApplyFormStateStyle()
                LblCreationDateValue.Text = _Order.CreationDate.ToString("dd/MM/yyyy")
                _Order.GetItems(DgvItems)
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
        _Order = New Order
        LoadOrder()
    End Sub
    Private Sub DgvItems_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DgvItems.MouseDoubleClick
        Dim ClickPlace As DataGridView.HitTestInfo = DgvItems.HitTest(e.X, e.Y)
        If ClickPlace.Type = DataGridViewHitTestType.Cell Then
            BtnEditItem.PerformClick()
        End If
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
        If _Order.ID <> 0 Then
            If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    _Order.Delete()
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
    Private Sub FrmOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not _Deleting AndAlso BtnSave.Enabled Then
            If BtnSave.Enabled Then
                If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If Not Save() Then e.Cancel = True
                End If
            End If
        End If
        _Deleting = False
    End Sub
    Private Sub TxtNote_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles TxtExternalNote.LinkClicked, TxtInternalNote.LinkClicked
        Process.Start(e.LinkText)
    End Sub
    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        Dim Form As New FrmLog(Common.Routines.Order, _Order.ID)
        Form.ShowDialog()
    End Sub
    Private Sub TcCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TcOrder.SelectedIndexChanged
        If TcOrder.SelectedIndex = 0 Then
            Size = New Size(556, 724)
            FormBorderStyle = FormBorderStyle.FixedSingle
            WindowState = FormWindowState.Normal
            MaximizeBox = False
        Else
            WindowState = FormWindowState.Maximized
            MaximizeBox = True
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub
    Private Sub QtbCostSharing_HyerlinkCliked(sender As Object) Handles QtbCostSharingID.HyperlinkClicked, QtbCostSharingDocument.HyperlinkClicked, QtbCostSharingName.HyperlinkClicked
        Dim Form As New FrmCostSharing(New CostSharing(QtbCostSharingID.FreezedPrimaryKey))
        Form.ShowDialog()
        QtbCostSharingID.Freeze(QtbCostSharingID.FreezedPrimaryKey, True)
    End Sub
    Private Sub QtbProvider_HyerlinkCliked(sender As Object) Handles QtbProviderID.HyperlinkClicked, QtbProviderDocument.HyperlinkClicked, QtbProviderName.HyperlinkClicked
        Dim Form As New FrmPerson(New Person(QtbProviderID.FreezedPrimaryKey))
        Form.ShowDialog()
        QtbProviderID.Freeze(QtbProviderID.FreezedPrimaryKey, True)
    End Sub
    Private Sub QtbPayment_HyerlinkCliked(sender As Object) Handles QtbPaymentID.HyperlinkClicked, QtbPaymentName.HyperlinkClicked
        Dim Form As New FrmPaymentTerm(New PaymentTerm(QtbPaymentName.FreezedPrimaryKey))
        Form.ShowDialog()
        QtbPaymentName.Freeze(QtbPaymentName.FreezedPrimaryKey, True)
    End Sub
    Private Sub QtbCarrier_HyerlinkCliked(sender As Object) Handles QtbCarrierID.HyperlinkClicked, QtbCarrierDocument.HyperlinkClicked, QtbCarrierName.HyperlinkClicked
        Dim Form As New FrmPerson(New Person(QtbCarrierName.FreezedPrimaryKey))
        Form.ShowDialog()
        QtbCarrierName.Freeze(QtbCarrierName.FreezedPrimaryKey, True)
    End Sub
    Private Sub QtbCostSharing_KeyDown(sender As Object, e As KeyEventArgs) Handles QtbCostSharingID.KeyDown, QtbCostSharingDocument.KeyDown, QtbCostSharingName.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Form As New FrmFilter(_Order.CostSharing, New DataSearch.CostSharingFilter, CType(sender, QueriedBox))
            Form.Text = "Filtro de Centros de Custo"
            Form.ShowDialog()
        End If
    End Sub
    Private Sub QtbProvider_KeyDown(sender As Object, e As KeyEventArgs) Handles QtbProviderID.KeyDown, QtbProviderDocument.KeyDown, QtbProviderName.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Form As New FrmFilter(_Order.Provider, New DataSearch.PersonProviderFilter, CType(sender, QueriedBox))
            Form.Text = "Filtro de Fornecedores"
            Form.ShowDialog()
        End If
    End Sub
    Private Sub QtbPayment_KeyDown(sender As Object, e As KeyEventArgs) Handles QtbPaymentID.KeyDown, QtbPaymentName.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Form As New FrmFilter(_Order.Payment, New DataSearch.PaymentTermFilter, CType(sender, QueriedBox))
            Form.Text = "Filtro de Condições de Pagamento"
            Form.ShowDialog()
        End If
    End Sub
    Private Sub QtbCarrier_KeyDown(sender As Object, e As KeyEventArgs) Handles QtbCarrierID.KeyDown, QtbCarrierDocument.KeyDown, QtbCarrierName.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Form As New FrmFilter(_Order.Carrier, New DataSearch.PersonCarrierFilter, CType(sender, QueriedBox))
            Form.Text = "Filtro de Transportadoras"
            Form.ShowDialog()
        End If
    End Sub
    Private Sub BtnIncludeItem_Click(sender As Object, e As EventArgs) Handles BtnIncludeItem.Click
        Dim Form As New FrmOrderItem(_Order, New Order.OrderItem, Me)
        Form.ShowDialog()
    End Sub
    Private Sub BtnDeleteItem_Click(sender As Object, e As EventArgs) Handles BtnDeleteItem.Click
        Dim ItemID As Long
        If DgvItems.SelectedRows.Count = 1 Then
            If CMessageBox.Show("O item selecionado será excluído. Deseja continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                ItemID = DgvItems.SelectedRows(0).Cells("ID").Value
                For Each Item As Order.OrderItem In _Order.Items
                    If Item.ID = ItemID Then
                        _Order.Items.Remove(Item)
                        _Order.GetItems(DgvItems)
                        RefreshTotals()
                        BtnSave.Enabled = True
                        Exit For
                    End If
                Next Item
            End If
        End If

    End Sub
    Private Sub BtnEditItem_Click(sender As Object, e As EventArgs) Handles BtnEditItem.Click
        Dim ItemSeq As Long
        If DgvItems.SelectedRows.Count = 1 Then
            ItemSeq = DgvItems.SelectedRows(0).Cells("SEQ").Value
            For Each Item As Order.OrderItem In _Order.Items
                If Item.Seq = ItemSeq Then
                    Dim Form As New FrmOrderItem(_Order, Item, Me)
                    Form.ShowDialog()
                    Exit For
                End If
            Next Item
        End If

    End Sub

    Private Sub QtbProviderID_FreezedPrimaryKeyChanged(sender As Object) Handles QtbProviderID.FreezedPrimaryKeyChanged, QtbCarrierID.FreezedPrimaryKeyChanged
        Dim Provider As Person
        If QtbProviderID.FreezedPrimaryKey > 0 Then
            Provider = New Person(QtbProviderID.FreezedPrimaryKey)
            If Provider.Contacts.Count > 0 Then
                If Provider.DefaultContactID > 0 Then
                    TxtContact.Text = Provider.Contacts.Where(Function(x) x.ID = Provider.DefaultContactID).ElementAt(0).Name
                    TxtPhone.Text = Provider.Contacts.Where(Function(x) x.ID = Provider.DefaultContactID).ElementAt(0).Phone1
                    TxtEmail.Text = Provider.Contacts.Where(Function(x) x.ID = Provider.DefaultContactID).ElementAt(0).Email1
                Else
                    TxtContact.Text = Provider.Contacts(0).Name
                    TxtPhone.Text = Provider.Contacts(0).Phone1
                    TxtEmail.Text = Provider.Contacts(0).Email1
                End If
            End If

        End If
    End Sub

    Private Sub QtbCostSharingID_FreezedPrimaryKeyChanged(sender As Object) Handles QtbCostSharingID.FreezedPrimaryKeyChanged
        Dim CostSharing As CostSharing
        If QtbCostSharingID.IsFreezed Then
            CostSharing = New CostSharing(QtbCostSharingID.FreezedPrimaryKey)
            CbxLocals.DataSource = CostSharing.Locals
            CbxLocals.DisplayMember = "NAME"
            CbxLocals.ValueMember = "ID"
        Else
            CbxLocals.DataSource = Nothing
        End If
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim ReportPath As String = Common.ReportPath & "\PurchaseOrder.rep"
        Cursor = Cursors.WaitCursor
        If File.Exists(ReportPath) Then
            Report.Compile(Common.ReportPath & "\PurchaseOrder.rep", New List(Of Object) From {LblIDValue.Text})
        Else
            CMessageBox.Show("O arquivo PurchaseOrder.rep não foi encontrado. Reinicie o sistema e tente novamente.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub LblIDValue_TextChanged(sender As Object, e As EventArgs) Handles LblIDValue.TextChanged
        If IsNumeric(LblIDValue.Text) Then
            BtnPrint.Enabled = If(LblIDValue.Text > 0, True, False)
            BtnHistory.Enabled = If(LblIDValue.Text > 0, True, False)
            BtnFinalizeItem.Enabled = If(LblIDValue.Text > 0, True, False)
        End If
    End Sub

    Private Sub LblSituation_TextChanged(sender As Object, e As EventArgs) Handles LblSituation.TextChanged
        BtnApprove.Image = If(LblSituation.Text = "Pedido Aprovado", My.Resources.Approve, My.Resources.Disapprove)
        BtnApprove.Text = If(LblSituation.Text = "Pedido Aprovado", "Desaprovar", "Aprovar")
        BtnApprove.ToolTipText = If(LblSituation.Text = "Pedido Aprovado", "Desaprovar", "Aprovar")
        LblSituation.ForeColor = If(LblSituation.Text = "Pedido Aprovado", Color.DarkBlue, Color.DarkRed)
    End Sub

    Private Sub BtnApprove_Click(sender As Object, e As EventArgs) Handles BtnApprove.Click
        Dim FirstDisplayedRow As Long
        If Not BtnSave.Enabled Then
            If _Order.Status = "Pendente" Then
                Try
                    _Order.ChangeSituation()
                    LblSituation.Text = "Pedido " & _Order.Situation
                    ApplyFormStateStyle()

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

                Catch ex As Exception
                    CMessageBox.Show(String.Format("ERRO0000", "Ocorreu um erro ao {0} o pedido.", If(_Order.Situation = "Aprovado", "desaprovar", "aprovar")), CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
                End Try
            Else
                CMessageBox.Show("Só é possível desaprovar pedidos com a situação 'Pendente'.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            End If
        Else
            CMessageBox.Show("Existem alterações não salvas, salve o pedido antes de aprovar.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
        End If
    End Sub
End Class