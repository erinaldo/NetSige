Imports ControlLibrary
Public Class FrmOrderItem
    Private _Order As Order
    Private _OrderItem As Order.OrderItem
    Private _OrderForm As FrmOrder
    Private _ItemSaved As Boolean
    Public Sub New(ByVal Order As Order, ByVal OrderItem As Order.OrderItem, ByVal OrderForm As FrmOrder)
        InitializeComponent()
        _Order = Order
        _OrderItem = OrderItem
        _OrderForm = OrderForm
    End Sub
    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadOrderItem()
    End Sub
    Private Sub LoadOrderItem()
        If _OrderItem.ID > 0 Then
            _ItemSaved = True
        Else
            _ItemSaved = False
        End If
        LblSeqValue.Text = _OrderItem.Seq
        If _OrderItem.DeliveryDate IsNot Nothing Then
            LblDeliveryDateValue.Text = _OrderItem.DeliveryDate
        Else
            LblDeliveryDateValue.Visible = False
            LblDeliveryDateValue.Visible = False
        End If
        QtbItemID.Unfreeze(True)
        QtbItemUnit.Unfreeze(True)
        QtbItemID.Freeze(_OrderItem.Item.ID, True)
        QtbItemUnit.Freeze(_OrderItem.Unit.ID)
        DtbQuantity.Text = _OrderItem.Quantity
        DtbPrice.Text = _OrderItem.Price
        DtbDiscount.Text = _OrderItem.Discount
        PboxIPI.Text = _OrderItem.IPI * 100
        PboxICMS.Text = _OrderItem.ICMS * 100
        TxtComplement.Text = _OrderItem.Complement
        BtnSave.Enabled = False
        RefreshNavigation()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        PreSave()
    End Sub
    Private Function PreSave() As Boolean
        If IsValidFields() Then
            If _OrderItem.Seq > 0 Then _ItemSaved = True
            If Not _ItemSaved Then
                _OrderItem = New Order.OrderItem With {
                    .Item = New Item(QtbItemID.FreezedPrimaryKey),
                    .Unit = New ItemUnit(QtbItemUnit.FreezedPrimaryKey),
                    .Quantity = DtbQuantity.DecimalValue,
                    .Price = DtbPrice.DecimalValue,
                    .Discount = DtbDiscount.DecimalValue,
                    .IPI = PboxIPI.PercentageValue,
                    .ICMS = PboxICMS.PercentageValue,
                    .Complement = TxtComplement.Text
                }
                _Order.Items.Add(_OrderItem)
                LblSeqValue.Text = _OrderItem.Seq
                _ItemSaved = True
            Else
                _OrderItem.Item = New Item(QtbItemID.FreezedPrimaryKey)
                _OrderItem.Unit = New ItemUnit(QtbItemUnit.FreezedPrimaryKey)
                _OrderItem.Quantity = DtbQuantity.DecimalValue
                _OrderItem.Price = DtbPrice.DecimalValue
                _OrderItem.Discount = DtbDiscount.DecimalValue
                _OrderItem.IPI = PboxIPI.PercentageValue
                _OrderItem.ICMS = PboxICMS.PercentageValue
                _OrderItem.Complement = TxtComplement.Text
            End If
            _Order.GetItems(_OrderForm.DgvItems, LblSeqValue.Text)
            QtbItemID.Select()
            RefreshNavigation()
            _OrderForm.RefreshTotals()
            BtnSave.Enabled = False
            _OrderForm.BtnSave.Enabled = True
            Return True
        Else
            Return False
        End If
    End Function
    Private Function IsValidFields() As Boolean
        If Not QtbItemID.IsFreezed And Not QtbItemName.IsFreezed Then
            CMessageBox.Show("Por favor informe o item.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            QtbItemName.Select()
            Return False
        ElseIf Not QtbItemUnit.IsFreezed Then
            CMessageBox.Show("Por favor informe a unidade de medida do item.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            QtbItemUnit.Select()
            Return False
        ElseIf DtbQuantity.DecimalValue < 0 Then
            CMessageBox.Show("A quantidade do item não pode ser negativa.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            DtbQuantity.Select()
            Return False
        ElseIf DtbQuantity.DecimalValue = 0 Then
            CMessageBox.Show("A quantidade do item não pode ser igual a zero.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            DtbQuantity.Select()
            Return False
        ElseIf DtbPrice.Text < 0 Then
            CMessageBox.Show("O valor do item não pode ser negativo.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            DtbPrice.Select()
            Return False
        ElseIf DtbPrice.Text = 0 Then
            CMessageBox.Show("O valor do item não pode ser igual a zero.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            DtbPrice.Select()
            Return False
        End If
        Return True
    End Function
    Public Sub RefreshNavigation()
        If _OrderForm.DgvItems.SelectedRows.Count = 1 Then
            If _OrderForm.DgvItems.Rows(0).Selected And _OrderForm.DgvItems.Rows.Count > 1 Then
                If _OrderForm.DgvItems.SelectedRows(0).Displayed = False Then
                    _OrderForm.DgvItems.FirstDisplayedScrollingRowIndex = _OrderForm.DgvItems.SelectedRows(0).Index
                End If
                BtnFirst.Enabled = False
                BtnPrevious.Enabled = False
                BtnNext.Enabled = True
                BtnLast.Enabled = True
            ElseIf _OrderForm.DgvItems.Rows(0).Selected And _OrderForm.DgvItems.Rows.Count = 1 Then
                If _OrderForm.DgvItems.SelectedRows(0).Displayed = False Then
                    _OrderForm.DgvItems.FirstDisplayedScrollingRowIndex = _OrderForm.DgvItems.SelectedRows(0).Index
                End If
                BtnFirst.Enabled = False
                BtnPrevious.Enabled = False
                BtnNext.Enabled = False
                BtnLast.Enabled = False
            ElseIf _OrderForm.DgvItems.Rows(_OrderForm.DgvItems.Rows.Count - 1).Selected Then
                If _OrderForm.DgvItems.SelectedRows(0).Displayed = False Then
                    _OrderForm.DgvItems.FirstDisplayedScrollingRowIndex = _OrderForm.DgvItems.RowCount - 1
                End If
                BtnFirst.Enabled = True
                BtnPrevious.Enabled = True
                BtnNext.Enabled = False
                BtnLast.Enabled = False
            Else
                If _OrderForm.DgvItems.SelectedRows(0).Displayed = False Then
                    _OrderForm.DgvItems.FirstDisplayedScrollingRowIndex = _OrderForm.DgvItems.SelectedRows(0).Index
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
    Private Sub Changes(sender As Object, e As EventArgs) Handles QtbItemID.TextChanged,
                                                                  QtbItemName.TextChanged,
                                                                  QtbItemUnit.TextChanged,
                                                                  DtbQuantity.TextChanged,
                                                                  DtbPrice.TextChanged,
                                                                  PboxIPI.PercentageValueChanged,
                                                                  PboxICMS.PercentageValueChanged,
                                                                  TxtComplement.TextChanged,
                                                                  DtbDiscount.TextChanged
        BtnSave.Enabled = True
    End Sub
    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If _OrderForm.DgvItems.SelectedRows.Count = 1 Then
            If _OrderForm.DgvItems.SelectedRows(0).Index > 0 Then
                _OrderForm.DgvItems.Rows(0).Selected = True
                _OrderItem = New [Order].OrderItem With {
                    .Seq = _OrderForm.DgvItems.SelectedRows(0).Cells("SEQ").Value,
                    .ID = _OrderForm.DgvItems.SelectedRows(0).Cells("ID").Value,
                    .DeliveryDate = _OrderForm.DgvItems.SelectedRows(0).Cells("DELIVERYDATE").Value,
                    .Item = New Item(_OrderForm.DgvItems.SelectedRows(0).Cells("ITEMID").Value),
                    .Unit = New ItemUnit(_OrderForm.DgvItems.SelectedRows(0).Cells("ITEMUNITID").Value),
                    .Quantity = _OrderForm.DgvItems.SelectedRows(0).Cells("QUANTITY").Value,
                    .Price = _OrderForm.DgvItems.SelectedRows(0).Cells("PRICE").Value,
                    .IPI = _OrderForm.DgvItems.SelectedRows(0).Cells("IPI").Value,
                    .ICMS = _OrderForm.DgvItems.SelectedRows(0).Cells("ICMS").Value,
                    .Complement = _OrderForm.DgvItems.SelectedRows(0).Cells("COMPLEMENT").Value
                }
                LoadOrderItem()
            End If
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If _OrderForm.DgvItems.SelectedRows.Count = 1 Then
            If _OrderForm.DgvItems.SelectedRows(0).Index > 0 Then
                _OrderForm.DgvItems.Rows(_OrderForm.DgvItems.SelectedRows(0).Index - 1).Selected = True
                _OrderItem = New [Order].OrderItem With {
                    .Seq = _OrderForm.DgvItems.SelectedRows(0).Cells("SEQ").Value,
                    .ID = _OrderForm.DgvItems.SelectedRows(0).Cells("ID").Value,
                    .DeliveryDate = _OrderForm.DgvItems.SelectedRows(0).Cells("DELIVERYDATE").Value,
                    .Item = New Item(_OrderForm.DgvItems.SelectedRows(0).Cells("ITEMID").Value),
                    .Unit = New ItemUnit(_OrderForm.DgvItems.SelectedRows(0).Cells("ITEMUNITID").Value),
                    .Quantity = _OrderForm.DgvItems.SelectedRows(0).Cells("QUANTITY").Value,
                    .Price = _OrderForm.DgvItems.SelectedRows(0).Cells("PRICE").Value,
                    .IPI = _OrderForm.DgvItems.SelectedRows(0).Cells("IPI").Value,
                    .ICMS = _OrderForm.DgvItems.SelectedRows(0).Cells("ICMS").Value,
                    .Complement = _OrderForm.DgvItems.SelectedRows(0).Cells("COMPLEMENT").Value
                }
                LoadOrderItem()
            End If
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If _OrderForm.DgvItems.SelectedRows.Count = 1 Then
            If _OrderForm.DgvItems.SelectedRows(0).Index < _OrderForm.DgvItems.Rows.Count - 1 Then
                _OrderForm.DgvItems.Rows(_OrderForm.DgvItems.SelectedRows(0).Index + 1).Selected = True
                _OrderItem = New [Order].OrderItem With {
                    .Seq = _OrderForm.DgvItems.SelectedRows(0).Cells("SEQ").Value,
                    .ID = _OrderForm.DgvItems.SelectedRows(0).Cells("ID").Value,
                    .DeliveryDate = _OrderForm.DgvItems.SelectedRows(0).Cells("DELIVERYDATE").Value,
                    .Item = New Item(_OrderForm.DgvItems.SelectedRows(0).Cells("ITEMID").Value),
                    .Unit = New ItemUnit(_OrderForm.DgvItems.SelectedRows(0).Cells("ITEMUNITID").Value),
                    .Quantity = _OrderForm.DgvItems.SelectedRows(0).Cells("QUANTITY").Value,
                    .Price = _OrderForm.DgvItems.SelectedRows(0).Cells("PRICE").Value,
                    .IPI = _OrderForm.DgvItems.SelectedRows(0).Cells("IPI").Value,
                    .ICMS = _OrderForm.DgvItems.SelectedRows(0).Cells("ICMS").Value,
                    .Complement = _OrderForm.DgvItems.SelectedRows(0).Cells("COMPLEMENT").Value
                }
                LoadOrderItem()
            End If
        End If
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        If _OrderForm.DgvItems.SelectedRows.Count = 1 Then
            If _OrderForm.DgvItems.SelectedRows(0).Index < _OrderForm.DgvItems.Rows.Count - 1 Then
                _OrderForm.DgvItems.Rows(_OrderForm.DgvItems.Rows.Count - 1).Selected = True
                _OrderItem = New [Order].OrderItem With {
                    .Seq = _OrderForm.DgvItems.SelectedRows(0).Cells("SEQ").Value,
                    .ID = _OrderForm.DgvItems.SelectedRows(0).Cells("ID").Value,
                    .DeliveryDate = _OrderForm.DgvItems.SelectedRows(0).Cells("DELIVERYDATE").Value,
                    .Item = New Item(_OrderForm.DgvItems.SelectedRows(0).Cells("ITEMID").Value),
                    .Unit = New ItemUnit(_OrderForm.DgvItems.SelectedRows(0).Cells("ITEMUNITID").Value),
                    .Quantity = _OrderForm.DgvItems.SelectedRows(0).Cells("QUANTITY").Value,
                    .Price = _OrderForm.DgvItems.SelectedRows(0).Cells("PRICE").Value,
                    .IPI = _OrderForm.DgvItems.SelectedRows(0).Cells("IPI").Value,
                    .ICMS = _OrderForm.DgvItems.SelectedRows(0).Cells("ICMS").Value,
                    .Complement = _OrderForm.DgvItems.SelectedRows(0).Cells("COMPLEMENT").Value
                }
                LoadOrderItem()
            End If
        End If
    End Sub
    Private Sub QtbItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles QtbItemID.KeyDown, QtbItemName.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Form As New FrmFilter(_OrderItem.Item, New DataSearch.ItemFilter, CType(sender, QueriedBox))
            Form.Text = "Filtro de Itens"
            Form.ShowDialog()
        End If
    End Sub
    Private Sub QtbItemUnit_KeyDown(sender As Object, e As KeyEventArgs) Handles QtbItemUnit.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Form As New FrmFilter(_OrderItem.Unit, New DataSearch.ItemUnitFilter, CType(sender, QueriedBox))
            Form.Text = "Filtro de Unidades"
            Form.ShowDialog()
        End If
    End Sub
    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        If BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then Exit Sub
            End If
        End If
        _OrderItem = New Order.OrderItem
        LoadOrderItem()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If CMessageBox.Show("Deseja excluir o registro selecionado?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
            For Each Item As Order.OrderItem In _Order.Items
                If Item.ID = _OrderItem.ID Then
                    _Order.Items.Remove(Item)
                    _Order.GetItems(_OrderForm.DgvItems)
                    _Deleting = True
                    Dispose()
                    _OrderForm.BtnSave.Enabled = True
                    Exit For
                End If
            Next Item
        End If
    End Sub

    Private _Deleting As Boolean
    Private Sub FrmFormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not _Deleting AndAlso BtnSave.Enabled Then
            If CMessageBox.Show("Houve alterações que ainda não foram salvas. Deseja salvar antes de continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
                If Not PreSave() Then e.Cancel = True
            End If
        End If
        _Deleting = False
    End Sub

    Private Sub QtbItemID_FreezedPrimaryKeyChanged(sender As Object) Handles QtbItemID.FreezedPrimaryKeyChanged
        Dim Item As Item
        If QtbItemID.FreezedPrimaryKey > 0 Then
            Item = New Item(QtbItemID.FreezedPrimaryKey)
            QtbItemUnit.Freeze(Item.ItemUnit.ID)
        End If
    End Sub

    Private Sub QtbItemID_HyperlinkClicked(sender As Object) Handles QtbItemID.HyperlinkClicked, QtbItemName.HyperlinkClicked
        Dim Form As New FrmItem(New Item(QtbItemID.FreezedPrimaryKey))
        Form.ShowDialog()
        QtbItemID.Freeze(QtbItemID.FreezedPrimaryKey, True)
    End Sub

    Private Sub QtbItemUnit_HyperlinkClicked(sender As Object) Handles QtbItemUnit.HyperlinkClicked
        Dim Form As New FrmItemUnit(New ItemUnit(QtbItemUnit.FreezedPrimaryKey))
        Form.ShowDialog()
        QtbItemUnit.Freeze(QtbItemID.FreezedPrimaryKey)
    End Sub
End Class