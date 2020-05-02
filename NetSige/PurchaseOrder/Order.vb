Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.SQLite
Public Class Order
    Public Class Filter
        <Browsable(False)>
        Public Property DataGrid As New DataGridView
        Public Property ID As String
        <TypeConverter(GetType(StatusFilterCollection))>
        <DisplayName("Status")>
        Public Property Status As String


        <TypeConverter(GetType(SituationFilterCollection))>
        <DisplayName("Situação")>
        Public Property Situation As String


        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Data de Criação")>
        Public Property CreationDate As New DateFilter
        <DisplayName("Cotação")>
        Public Property Quotation As String
        <DisplayName("Centro de Custo")>
        Public Property CostSharing As String
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Fornecedor")>
        Public Property Provider As New ProviderFilter
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Item")>
        Public Property Item As New ItemFilter
        <DisplayName("Pagamento")>
        Public Property PaymentTerm As String
        <TypeConverter(GetType(CarrierFilterCollection))>
        <DisplayName("Tipo Frete")>
        Public Property CarrierType As String
        <DisplayName("Transportadora")>
        Public Property Carrier As String
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Valor Líquido")>
        Public Property OrderValue As New ValueFilter
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Inicio da Entrega")>
        Public Property InitialDelivery As New DateFilter
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Fim da Entrega")>
        Public Property FinalDelivery As New DateFilter
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Observação")>
        Public Property Note As New NoteFilter
        Public Sub New(ByVal Grid As DataGridView)
            DataGrid = Grid
        End Sub
        Public Sub New()
        End Sub
        Public Function Filter(Optional ByVal SelectedRow As Integer = 0) As Boolean
            Dim Table As New DataTable
            Dim Filtering As Boolean
            Using Con As New SQLiteConnection(Common.ConnectionString)
                Con.Open()
                Using Com As New SQLiteCommand(My.Resources.PurchaseOrderFilter, Con)
                    If ID <> Nothing Then Com.Parameters.AddWithValue("@ID", ID) : Filtering = True Else Com.Parameters.AddWithValue("@ID", "%")
                    If Status <> Nothing Then Com.Parameters.AddWithValue("@STATUSID", Common.OrderStatusTypes.IndexOf(Status)) : Filtering = True Else Com.Parameters.AddWithValue("@STATUSID", "%")
                    If Situation <> Nothing Then Com.Parameters.AddWithValue("@SITUATIONID", Common.OrderStatusTypes.IndexOf(Situation)) : Filtering = True Else Com.Parameters.AddWithValue("@SITUATIONID", "%")
                    If Quotation <> Nothing Then Com.Parameters.AddWithValue("@QUOTATION", Quotation) : Filtering = True : Else Com.Parameters.AddWithValue("@QUOTATION", "%")
                    If CostSharing <> Nothing Then Com.Parameters.AddWithValue("@COSTSHARING", CostSharing) : Filtering = True : Else Com.Parameters.AddWithValue("@COSTSHARING", "%")
                    If Provider.ID <> Nothing Then Com.Parameters.AddWithValue("@PERSONID", Provider.ID) : Filtering = True : Else Com.Parameters.AddWithValue("@PERSONID", "%")
                    If Provider.Document <> Nothing Then Com.Parameters.AddWithValue("@PERSONDOCUMENT", Provider.Document) : Filtering = True : Else Com.Parameters.AddWithValue("@PERSONDOCUMENT", "%")
                    If Provider.Name <> Nothing Then Com.Parameters.AddWithValue("@PERSONNAME", Provider.Name) : Filtering = True : Else Com.Parameters.AddWithValue("@PERSONNAME", "%")
                    If Provider.Contact <> Nothing Then Com.Parameters.AddWithValue("@PERSONCONTACT", Provider.Contact) : Filtering = True : Else Com.Parameters.AddWithValue("@PERSONCONTACT", "%")
                    If Provider.Phone <> Nothing Then Com.Parameters.AddWithValue("@PERSONPHONE", Provider.Phone) : Filtering = True : Else Com.Parameters.AddWithValue("@PERSONPHONE", "%")
                    If Provider.Email <> Nothing Then Com.Parameters.AddWithValue("@PERSONEMAIL", Provider.Email) : Filtering = True : Else Com.Parameters.AddWithValue("@PERSONEMAIL", "%")
                    If PaymentTerm <> Nothing Then Com.Parameters.AddWithValue("@PAYMENTTERM", PaymentTerm) : Filtering = True : Else Com.Parameters.AddWithValue("@PAYMENTTERM", "%")
                    If CarrierType <> Nothing Then Com.Parameters.AddWithValue("@CARRIERTYPE", Common.CarrierTypes.IndexOf(CarrierType)) : Filtering = True : Else Com.Parameters.AddWithValue("@CARRIERTYPE", "%")
                    If Carrier <> Nothing Then Com.Parameters.AddWithValue("@CARRIER", Carrier) : Filtering = True : Else Com.Parameters.AddWithValue("@CARRIER", "%")
                    If OrderValue.MinimumValue <> Nothing Then Com.Parameters.AddWithValue("@ORDERVALUEMIN", CDec(OrderValue.MinimumValue)) : Filtering = True : Else Com.Parameters.AddWithValue("@ORDERVALUEMIN", 0)
                    If OrderValue.MaximumValue <> Nothing Then Com.Parameters.AddWithValue("@ORDERVALUEMAX", CDec(OrderValue.MaximumValue)) : Filtering = True : Else Com.Parameters.AddWithValue("@ORDERVALUEMAX", 9999999999)
                    If Item.ID <> Nothing Then Com.Parameters.AddWithValue("@ITEMID", Item.ID) : Filtering = True : Else Com.Parameters.AddWithValue("@ITEMID", "%")
                    If Item.Name <> Nothing Then Com.Parameters.AddWithValue("@ITEMNAME", Item.Name) : Filtering = True : Else Com.Parameters.AddWithValue("@ITEMNAME", "%")
                    If Item.Complement <> Nothing Then Com.Parameters.AddWithValue("@ITEMCOMPLEMENT", Item.Complement) : Filtering = True : Else Com.Parameters.AddWithValue("@ITEMCOMPLEMENT", "%")
                    If Note.External <> Nothing Then Com.Parameters.AddWithValue("@EXTERNALNOTE", Note.External) : Filtering = True : Else Com.Parameters.AddWithValue("@EXTERNALNOTE", "%")
                    If Note.Internal <> Nothing Then Com.Parameters.AddWithValue("@INTERNALNOTE", Note.Internal) : Filtering = True : Else Com.Parameters.AddWithValue("@INTERNALNOTE", "%")
                    If InitialDelivery.MinimumDate <> Nothing Then Com.Parameters.AddWithValue("@INITIALDELIVERYI", InitialDelivery.MinimumDate) : Filtering = True Else Com.Parameters.AddWithValue("@INITIALDELIVERYI", "1000-01-01")
                    If InitialDelivery.MaximumDate <> Nothing Then Com.Parameters.AddWithValue("@INITIALDELIVERYF", InitialDelivery.MaximumDate) : Filtering = True Else Com.Parameters.AddWithValue("@INITIALDELIVERYF", "9999-12-31")
                    If FinalDelivery.MinimumDate <> Nothing Then Com.Parameters.AddWithValue("@FINALDELIVERYI", FinalDelivery.MinimumDate) : Filtering = True Else Com.Parameters.AddWithValue("@FINALDELIVERYI", "1000-01-01")
                    If FinalDelivery.MaximumDate <> Nothing Then Com.Parameters.AddWithValue("@FINALDELIVERYF", FinalDelivery.MaximumDate) : Filtering = True Else Com.Parameters.AddWithValue("@FINALDELIVERYF", "9999-12-31")
                    If CreationDate.MinimumDate <> Nothing Then Com.Parameters.AddWithValue("@CREATIONDATEI", CreationDate.MinimumDate) : Filtering = True Else Com.Parameters.AddWithValue("@CREATIONDATEI", Today.AddMonths(-3))
                    If CreationDate.MaximumDate <> Nothing Then Com.Parameters.AddWithValue("@CREATIONDATEF", CreationDate.MaximumDate) : Filtering = True Else Com.Parameters.AddWithValue("@CREATIONDATEF", "9999-12-31")
                    Common.DebugQuery(Com)
                    Using Adp As New SQLiteDataAdapter(Com)
                        Adp.Fill(Table)
                        DataGrid.DataSource = Table
                    End Using
                End Using
            End Using
            If DataGrid.Rows.Count > 0 Then
                If SelectedRow < DataGrid.Rows.Count Then
                    DataGrid.Rows(SelectedRow).Selected = True
                ElseIf SelectedRow >= DataGrid.Rows.Count Then
                    DataGrid.Rows(DataGrid.Rows.Count - 1).Selected = True
                End If
            End If
            Return Filtering
        End Function
        Public Sub Clean()
            ID = Nothing
            Status = Nothing
            Situation = Nothing
            Provider.ID = Nothing
            Provider.Document = Nothing
            Provider.Name = Nothing
            Provider.Contact = Nothing
            Provider.Phone = Nothing
            Provider.Email = Nothing
            PaymentTerm = Nothing
            CarrierType = Nothing
            Carrier = Nothing
            OrderValue.MinimumValue = Nothing
            OrderValue.MaximumValue = Nothing
            Quotation = Nothing
            CostSharing = Nothing
            Item.ID = Nothing
            Item.Name = Nothing
            Item.Complement = Nothing
            Note.External = Nothing
            Note.Internal = Nothing
            InitialDelivery.MinimumDate = Nothing
            InitialDelivery.MaximumDate = Nothing
            FinalDelivery.MinimumDate = Nothing
            FinalDelivery.MaximumDate = Nothing
            CreationDate.MinimumDate = Nothing
            CreationDate.MaximumDate = Nothing
        End Sub
        Private Class StatusFilterCollection
            Inherits StringConverter
            Public Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValues(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
                Return New StandardValuesCollection(Common.OrderStatusTypes)
            End Function
        End Class
        Private Class SituationFilterCollection
            Inherits StringConverter
            Public Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValues(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
                Return New StandardValuesCollection(Common.OrderSituationTypes)
            End Function
        End Class

        Private Class CarrierFilterCollection
            Inherits StringConverter
            Public Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValues(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
                Return New StandardValuesCollection(Common.CarrierTypes)
            End Function
        End Class
        Public Class ProviderFilter
            <DisplayName("ID")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property ID As String
            <DisplayName("CPF/CNPJ")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property Document As String
            <DisplayName("Nome")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property Name As String
            <DisplayName("Contato")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property Contact As String
            <DisplayName("Telefone")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property Phone As String
            <DisplayName("E-Mail")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property Email As String
            Public Overrides Function ToString() As String
                Return Nothing
            End Function
            Public Sub New()
                ID = Nothing
                Document = Nothing
                Name = Nothing
            End Sub
        End Class
        Public Class ItemFilter
            <DisplayName("ID")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property ID As String
            <DisplayName("Nome")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property Name As String
            <DisplayName("Complemento")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property Complement As String
            Public Overrides Function ToString() As String
                Return Nothing
            End Function
            Public Sub New()
                ID = Nothing
                Name = Nothing
                Complement = Nothing
            End Sub
        End Class
        Public Class NoteFilter
            <DisplayName("Externa")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property External As String
            <DisplayName("Interna")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property Internal As String
            Public Overrides Function ToString() As String
                Return Nothing
            End Function
            Public Sub New()
                External = Nothing
                Internal = Nothing
            End Sub
        End Class
        Public Class ValueFilter
            Private _MinimumValue As String
            Private _MaximumValue As String
            <DisplayName("Mínimo")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property MinimumValue As String
                Get
                    Return _MinimumValue
                End Get
                Set(value As String)
                    If IsNumeric(value) Then
                        _MinimumValue = FormatNumber(value, 2, TriState.True)
                    Else
                        _MinimumValue = Nothing
                    End If
                End Set
            End Property
            <DisplayName("Máximo")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property MaximumValue As String
                Get
                    Return _MaximumValue
                End Get
                Set(value As String)
                    If IsNumeric(value) Then
                        _MaximumValue = FormatNumber(value, 2, TriState.True)
                    Else
                        _MaximumValue = Nothing
                    End If
                End Set
            End Property
            Public Overrides Function ToString() As String
                If MinimumValue <> Nothing And MaximumValue = Nothing Then
                    Return String.Format("Maior ou igual a R$ {0}", MinimumValue)
                ElseIf MinimumValue <> Nothing And MaximumValue <> Nothing Then
                    Return String.Format("R$ {0} a R$ {1}", MinimumValue, MaximumValue)
                ElseIf MinimumValue = Nothing And MaximumValue <> Nothing Then
                    Return String.Format("Menor ou igual a R$ {0}", MaximumValue)
                End If
                Return Nothing
            End Function
            Public Sub New()
                MinimumValue = Nothing
                MaximumValue = Nothing
            End Sub
        End Class
        Public Class DateFilter
            Private _MinimumDate As String
            Private _MaximumDate As String
            <DisplayName("Mínimo")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property MinimumDate As Date
                Get
                    Return _MinimumDate
                End Get
                Set(value As Date)
                    If IsDate(value) Then
                        _MinimumDate = value.ToString("dd/MM/yyyy")
                    Else
                        _MinimumDate = Nothing
                    End If
                End Set
            End Property
            <DisplayName("Máximo")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property MaximumDate As Date
                Get
                    Return _MaximumDate
                End Get
                Set(value As Date)
                    If IsDate(value) Then
                        _MaximumDate = value.ToString("dd/MM/yyyy")
                    Else
                        _MaximumDate = Nothing
                    End If
                End Set
            End Property
            Public Overrides Function ToString() As String
                If MinimumDate <> Nothing And MaximumDate = Nothing Then
                    Return String.Format("Maior ou igual a {0}", MinimumDate.ToString("dd/MM/yyyy"))
                ElseIf MinimumDate <> Nothing And MaximumDate <> Nothing Then
                    Return String.Format("{0} a {1}", MinimumDate.ToString("dd/MM/yyyy"), MaximumDate.ToString("dd/MM/yyyy"))
                ElseIf MinimumDate = Nothing And MaximumDate <> Nothing Then
                    Return String.Format("Menor ou igual a {0}", MaximumDate.ToString("dd/MM/yyyy"))
                End If
                Return Nothing
            End Function
            Public Sub New()
                MinimumDate = Nothing
                MaximumDate = Nothing
            End Sub
        End Class
    End Class
    Public Class OrderItem
        Public Property ID As Long
        Public Property Seq As Long
        Public Property DeliveryDate As String
        <DisplayName("Und.")>
        Public Property Unit As New ItemUnit
        Public Property Item As New Item
        <DisplayName("Qtd.")>
        Public Property Quantity As Decimal
        <DisplayName("Preço")>
        Public Property Price As Decimal
        <DisplayName("Desconto")>
        Public Property Discount As Decimal
        <DisplayName("Complemento")>
        Public Property Complement As String
        Public Property IPI As Decimal
        Public Property ICMS As Decimal

    End Class
    Public Class OrderItemCollection
        Inherits Collection(Of OrderItem)
        Public Function GetLastSeq() As Long
            Return If(Items.Count = 0, 0, Items.Max(Function(x) x.Seq))
        End Function
        Protected Overrides Sub InsertItem(index As Integer, item As OrderItem)
            If Items.Count = 0 Then
                item.Seq = 1
            Else
                item.Seq = GetLastSeq() + 1
            End If
            MyBase.InsertItem(index, item)
        End Sub
    End Class
    Public Sub GetItems(ByVal Dgv As DataGridView, Optional ByVal SeqToSelect As Long = 0)
        Dim SelectedRow As Long = If(Dgv.SelectedRows.Count = 1, Dgv.SelectedRows(0).Index, 0)
        Dgv.Rows.Clear()
        Dgv.Columns.Clear()
        Dgv.Columns.Add("ID", "ID")
        Dgv.Columns.Add("SEQ", "Seq.")
        Dgv.Columns.Add("PURCHASEORDERID", "PURCHASEORDERID")
        Dgv.Columns.Add("ITEMUNITID", "ITEMUNITID")
        Dgv.Columns.Add("ITEMID", "ITEMID")
        Dgv.Columns.Add("QUANTITY", "Qtd.")
        Dgv.Columns.Add("UNITINITIALS", "Und.")
        Dgv.Columns.Add("ITEMNAME", "Item")
        Dgv.Columns.Add("PRICE", "Preço")
        Dgv.Columns.Add("DISCOUNT", "Desconto")
        Dgv.Columns.Add("COMPLEMENT", "Complemento")
        Dgv.Columns.Add("IPI", "IPI")
        Dgv.Columns.Add("ICMS", "ICMS")
        Dgv.Columns.Add("DELIVERYDATE", "Data Entrega")
        Dgv.Columns("ID").Visible = False
        Dgv.Columns("PURCHASEORDERID").Visible = False
        Dgv.Columns("ITEMUNITID").Visible = False
        Dgv.Columns("ITEMID").Visible = False
        Dgv.Columns("QUANTITY").DefaultCellStyle.Format = "N2"
        Dgv.Columns("QUANTITY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dgv.Columns("PRICE").DefaultCellStyle.Format = "N2"
        Dgv.Columns("PRICE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dgv.Columns("DISCOUNT").DefaultCellStyle.Format = "N2"
        Dgv.Columns("DISCOUNT").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dgv.Columns("IPI").DefaultCellStyle.Format = "#0%"
        Dgv.Columns("IPI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dgv.Columns("ICMS").DefaultCellStyle.Format = "#0%"
        Dgv.Columns("ICMS").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        For Each Item As OrderItem In Items
            Dgv.Rows.Add({Item.ID, Item.Seq, ID, Item.Unit.ID, Item.Item.ID, Item.Quantity, Item.Unit.Initials, Item.Item.Name, Item.Price, Item.Discount, Item.Complement, Item.IPI, Item.ICMS, Item.DeliveryDate})
        Next Item
        If Dgv.Rows.Count > 0 Then
            If SelectedRow < Dgv.Rows.Count Then
                Dgv.Rows(SelectedRow).Selected = True
            ElseIf SelectedRow >= Dgv.Rows.Count Then
                Dgv.Rows(Dgv.Rows.Count - 1).Selected = True
            End If

            If SeqToSelect > 0 Then
                For i = 0 To Dgv.Rows.Count - 1
                    If Dgv.Rows(i).Cells("SEQ").Value = SeqToSelect Then
                        Dgv.Rows(i).Selected = True
                    End If
                Next i
            End If
        End If
    End Sub
    Private _ID As Long
    Public ReadOnly Property ID As Long
        Get
            Return _ID
        End Get
    End Property
    Public Property Status As String = "Pendente"
    Public Property Situation As String = "Não Aprovado"
    Private _CreationDate As Date = Today
    Public ReadOnly Property CreationDate As Date
        Get
            Return _CreationDate
        End Get
    End Property
    Public Property Quotation As New Quotation
    Public Property CostSharing As New CostSharing
    Public Property CostSharingLocalID As Long
    Public Property Provider As New Person
    Public Property Contact As String
    Public Property Phone As String
    Public Property Email As String
    Public Property Payment As New PaymentTerm
    Public Property Carrier As New Person
    Public Property CarrierType As String = "Sem Frete"
    Public Property CarrierPrice As Decimal
    Public Property Discount As Decimal
    Public Property Expense As Decimal
    Public Property ICMSST As Decimal
    Public Property InitialDelivery As Date = Today
    Public Property FinalDelivery As Date = Today
    Public Property ExternalNote As String
    Public Property InternalNote As String
    Public Property Items As New OrderItemCollection
    Public Property LastItemSeq As Long = 0
    Private _UserID As Long = Session.User.ID
    Public ReadOnly Property UserID As Long
        Get
            Return _UserID
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub New(ByVal Identifier As Long)
        Load(Identifier)
    End Sub
    Public Sub Load(ByVal Identifier As Long)
        Dim TableOrder As New DataTable
        Dim TempItemsTable As New DataTable
        Dim OItem As New OrderItem
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Tran As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComOrder As New SQLiteCommand(My.Resources.PurchaseOrderSelect, Con)
                    ComOrder.Parameters.AddWithValue("@ID", Identifier)
                    ComOrder.Transaction = Tran
                    Using Adp As New SQLiteDataAdapter(ComOrder)
                        Adp.Fill(TableOrder)
                    End Using
                End Using
                Using ComOrderItem As New SQLiteCommand(My.Resources.PurchaseOrderItemSelect, Con)
                    ComOrderItem.Parameters.AddWithValue("@ID", Identifier)
                    ComOrderItem.Transaction = Tran
                    Using Adp As New SQLiteDataAdapter(ComOrderItem)
                        Adp.Fill(TempItemsTable)
                    End Using
                End Using
                Tran.Commit()
            End Using
        End Using
        If TableOrder.Rows.Count = 1 Then
            _ID = TableOrder.Rows(0).Item("ID").ToString
            Status = Common.OrderStatusTypes(TableOrder.Rows(0).Item("STATUSID"))
            Situation = Common.OrderSituationTypes(TableOrder.Rows(0).Item("SITUATIONID"))
            _CreationDate = TableOrder.Rows(0).Item("CREATIONDATE")
            Quotation = If(TableOrder.Rows(0).Item("QUOTATIONID") Is DBNull.Value, New Quotation, New Quotation(TableOrder.Rows(0).Item("QUOTATIONID")))
            CostSharing = New CostSharing(TableOrder.Rows(0).Item("COSTSHARINGID"))
            CostSharingLocalID = TableOrder.Rows(0).Item("COSTSHARINGLOCALID")
            Provider = New Person(TableOrder.Rows(0).Item("PERSONID"))
            Contact = TableOrder.Rows(0).Item("CONTACT").ToString
            Phone = TableOrder.Rows(0).Item("PHONE").ToString
            Email = TableOrder.Rows(0).Item("EMAIL").ToString
            Payment = New PaymentTerm(TableOrder.Rows(0).Item("PAYMENTTERMID"))
            Carrier = If(TableOrder.Rows(0).Item("CARRIERID") Is DBNull.Value, New Person, New Person(TableOrder.Rows(0).Item("CARRIERID")))
            CarrierType = Common.CarrierTypes(TableOrder.Rows(0).Item("CARRIERTYPEID"))
            CarrierPrice = TableOrder.Rows(0).Item("CARRIERPRICE") / 100
            Discount = TableOrder.Rows(0).Item("DISCOUNT") / 100
            Expense = TableOrder.Rows(0).Item("EXPENSE") / 100
            ICMSST = TableOrder.Rows(0).Item("ICMSST") / 100
            InitialDelivery = TableOrder.Rows(0).Item("INITIALDELIVERY")
            FinalDelivery = TableOrder.Rows(0).Item("FINALDELIVERY")
            ExternalNote = TableOrder.Rows(0).Item("EXTERNALNOTE").ToString
            InternalNote = TableOrder.Rows(0).Item("INTERNALNOTE").ToString
            _UserID = TableOrder.Rows(0).Item("USERID")
            For Each RowItem As DataRow In TempItemsTable.Rows
                OItem = New OrderItem With {
                    .ID = RowItem.Item("ID"),
                    .DeliveryDate = If(IsDate(RowItem.Item("DELIVERYDATE")), CDate(RowItem.Item("DELIVERYDATE")).ToString("dd/MM/yyyy"), Nothing),
                    .Quantity = RowItem.Item("QUANTITY") / 100,
                    .Unit = New ItemUnit(RowItem.Item("ITEMUNITID")),
                    .Item = New Item(RowItem.Item("ITEMID")),
                    .Price = RowItem.Item("PRICE") / 100,
                    .Discount = RowItem.Item("DISCOUNT") / 100,
                    .Complement = RowItem.Item("COMPLEMENT").ToString,
                    .IPI = RowItem.Item("IPI") / 100,
                    .ICMS = RowItem.Item("ICMS") / 100
                }
                Items.Add(OItem)
            Next
        Else
            Throw New Exception(String.Format("O registro de ID {0} não foi encontrado.", Identifier))
        End If
    End Sub
    Public Sub Save()
        If ID = 0 Then
            SaveNew()
        Else
            SaveChanges()
        End If
    End Sub
    Private Sub SaveNew()
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Tran As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComOrderSave As New SQLiteCommand(My.Resources.PurchaseOrderInsert, Con)
                    ComOrderSave.Transaction = Tran
                    ComOrderSave.Parameters.AddWithValue("@STATUSID", Common.OrderStatusTypes.IndexOf(Status))
                    ComOrderSave.Parameters.AddWithValue("@CREATIONDATE", Now.ToString("yyyy-MM-dd"))
                    ComOrderSave.Parameters.AddWithValue("@QUOTATIONID", If(Quotation.ID = 0, DBNull.Value, Quotation.ID))
                    ComOrderSave.Parameters.AddWithValue("@COSTSHARINGID", CostSharing.ID)
                    ComOrderSave.Parameters.AddWithValue("@COSTSHARINGLOCALID", CostSharingLocalID)
                    ComOrderSave.Parameters.AddWithValue("@PERSONID", Provider.ID)
                    ComOrderSave.Parameters.AddWithValue("@CONTACT", Contact)
                    ComOrderSave.Parameters.AddWithValue("@PHONE", Phone)
                    ComOrderSave.Parameters.AddWithValue("@EMAIL", Email)
                    ComOrderSave.Parameters.AddWithValue("@PAYMENTTERMID", Payment.ID)
                    ComOrderSave.Parameters.AddWithValue("@CARRIERID", If(Carrier.ID = 0, DBNull.Value, Carrier.ID))
                    ComOrderSave.Parameters.AddWithValue("@CARRIERTYPEID", Common.CarrierTypes.IndexOf(CarrierType))
                    ComOrderSave.Parameters.AddWithValue("@CARRIERPRICE", CarrierPrice * 100)
                    ComOrderSave.Parameters.AddWithValue("@DISCOUNT", Discount * 100)
                    ComOrderSave.Parameters.AddWithValue("@EXPENSE", Expense * 100)
                    ComOrderSave.Parameters.AddWithValue("@ICMSST", ICMSST * 100)
                    ComOrderSave.Parameters.AddWithValue("@INITIALDELIVERY", InitialDelivery.ToString("yyyy-MM-dd"))
                    ComOrderSave.Parameters.AddWithValue("@FINALDELIVERY", FinalDelivery.ToString("yyyy-MM-dd"))
                    ComOrderSave.Parameters.AddWithValue("@EXTERNALNOTE", ExternalNote)
                    ComOrderSave.Parameters.AddWithValue("@INTERNALNOTE", InternalNote)
                    ComOrderSave.Parameters.AddWithValue("@USERID", Session.User.ID)
                    ComOrderSave.ExecuteNonQuery()
                End Using
                Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                    ComReturnID.Transaction = Tran
                    _ID = ComReturnID.ExecuteScalar
                    _CreationDate = Today
                End Using
                For Each Item As OrderItem In Items
                    Using ComItemSave As New SQLiteCommand(My.Resources.PurchaseOrderItemInsert, Con)
                        ComItemSave.Transaction = Tran
                        ComItemSave.Parameters.AddWithValue("@SEQ", Item.Seq)
                        ComItemSave.Parameters.AddWithValue("@PURCHASEORDERID", ID)
                        ComItemSave.Parameters.AddWithValue("@ITEMID", Item.Item.ID)
                        ComItemSave.Parameters.AddWithValue("@QUANTITY", Item.Quantity * 100)
                        ComItemSave.Parameters.AddWithValue("@ITEMUNITID", Item.Unit.ID)
                        ComItemSave.Parameters.AddWithValue("@PRICE", Item.Price * 100)
                        ComItemSave.Parameters.AddWithValue("@DISCOUNT", Item.Discount * 100)
                        ComItemSave.Parameters.AddWithValue("@COMPLEMENT", Item.Complement)
                        ComItemSave.Parameters.AddWithValue("@IPI", Item.IPI * 100)
                        ComItemSave.Parameters.AddWithValue("@ICMS", Item.ICMS * 100)
                        ComItemSave.ExecuteNonQuery()
                    End Using
                    Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                        ComReturnID.Transaction = Tran
                        Item.ID = ComReturnID.ExecuteScalar
                    End Using
                Next Item
                Tran.Commit()
            End Using
        End Using
    End Sub
    Private Sub SaveChanges()
        Dim Table As New DataTable
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Trans As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComUpdateOrder As New SQLiteCommand(My.Resources.PurchaseOrderUpdate, Con)
                    ComUpdateOrder.Transaction = Trans
                    ComUpdateOrder.Parameters.AddWithValue("@ID", ID)
                    ComUpdateOrder.Parameters.AddWithValue("@STATUSID", Common.OrderStatusTypes.IndexOf(Status))
                    ComUpdateOrder.Parameters.AddWithValue("@COSTSHARINGID", CostSharing.ID)
                    ComUpdateOrder.Parameters.AddWithValue("@COSTSHARINGLOCALID", CostSharingLocalID)
                    ComUpdateOrder.Parameters.AddWithValue("@PERSONID", Provider.ID)
                    ComUpdateOrder.Parameters.AddWithValue("@CONTACT", Contact)
                    ComUpdateOrder.Parameters.AddWithValue("@PHONE", Phone)
                    ComUpdateOrder.Parameters.AddWithValue("@EMAIL", Email)
                    ComUpdateOrder.Parameters.AddWithValue("@PAYMENTTERMID", Payment.ID)
                    ComUpdateOrder.Parameters.AddWithValue("@CARRIERID", If(Carrier.ID = 0, DBNull.Value, Carrier.ID))
                    ComUpdateOrder.Parameters.AddWithValue("@CARRIERTYPEID", Common.CarrierTypes.IndexOf(CarrierType))
                    ComUpdateOrder.Parameters.AddWithValue("@CARRIERPRICE", CarrierPrice * 100)
                    ComUpdateOrder.Parameters.AddWithValue("@DISCOUNT", Discount * 100)
                    ComUpdateOrder.Parameters.AddWithValue("@EXPENSE", Expense * 100)
                    ComUpdateOrder.Parameters.AddWithValue("@ICMSST", ICMSST * 100)
                    ComUpdateOrder.Parameters.AddWithValue("@INITIALDELIVERY", InitialDelivery.ToString("yyyy-MM-dd"))
                    ComUpdateOrder.Parameters.AddWithValue("@FINALDELIVERY", FinalDelivery.ToString("yyyy-MM-dd"))
                    ComUpdateOrder.Parameters.AddWithValue("@EXTERNALNOTE", ExternalNote)
                    ComUpdateOrder.Parameters.AddWithValue("@INTERNALNOTE", InternalNote)
                    ComUpdateOrder.Parameters.AddWithValue("@USERID", UserID)
                    ComUpdateOrder.ExecuteNonQuery()
                End Using
                Using ComSelectOrderItems As New SQLiteCommand(My.Resources.PurchaseOrderItemSelect, Con)
                    ComSelectOrderItems.Parameters.AddWithValue("@ID", ID)
                    ComSelectOrderItems.Transaction = Trans
                    Using Adp As New SQLiteDataAdapter(ComSelectOrderItems)
                        Adp.Fill(Table)
                    End Using
                End Using
                For Each RowDb As DataRow In Table.Rows
                    If Not Items.AsEnumerable().Where(Function(c) c.ID.Equals(RowDb.Item("ID"))).Count() > 0 Then
                        Using ConDeleteContact As New SQLiteCommand(My.Resources.PurchaseOrderItemDelete, Con)
                            ConDeleteContact.Transaction = Trans
                            ConDeleteContact.Parameters.AddWithValue("@ID", RowDb.Item("ID"))
                            ConDeleteContact.Parameters.AddWithValue("@PURCHASEORDERID", RowDb.Item("PURCHASEORDERID"))
                            ConDeleteContact.ExecuteNonQuery()
                        End Using
                    End If
                Next
                For Each Item As OrderItem In Items
                    If Item.ID = 0 Then
                        Using ComOrderItemSave As New SQLiteCommand(My.Resources.PurchaseOrderItemInsert, Con)
                            ComOrderItemSave.Transaction = Trans
                            ComOrderItemSave.Parameters.AddWithValue("@SEQ", Item.Seq)
                            ComOrderItemSave.Parameters.AddWithValue("@PURCHASEORDERID", ID)
                            ComOrderItemSave.Parameters.AddWithValue("@ITEMID", Item.Item.ID)
                            ComOrderItemSave.Parameters.AddWithValue("@QUANTITY", Item.Quantity * 100)
                            ComOrderItemSave.Parameters.AddWithValue("@ITEMUNITID", Item.Unit.ID)
                            ComOrderItemSave.Parameters.AddWithValue("@PRICE", Item.Price * 100)
                            ComOrderItemSave.Parameters.AddWithValue("@DISCOUNT", Item.Discount * 100)
                            ComOrderItemSave.Parameters.AddWithValue("@COMPLEMENT", Item.Complement)
                            ComOrderItemSave.Parameters.AddWithValue("@IPI", Item.IPI * 100)
                            ComOrderItemSave.Parameters.AddWithValue("@ICMS", Item.ICMS * 100)
                            ComOrderItemSave.ExecuteNonQuery()
                        End Using
                        Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                            ComReturnID.Transaction = Trans
                            Item.ID = ComReturnID.ExecuteScalar
                        End Using
                        Using ComProviderLastSeqUpdate As New SQLiteCommand(My.Resources.PurchaseOrderLastItemSeqUpdate, Con)
                            ComProviderLastSeqUpdate.Transaction = Trans
                            ComProviderLastSeqUpdate.Parameters.AddWithValue("@ID", ID)
                            ComProviderLastSeqUpdate.Parameters.AddWithValue("@LASTITEMSEQ", Item.Seq)
                            ComProviderLastSeqUpdate.ExecuteNonQuery()
                        End Using
                    Else
                        Using ComOrderItemUpdate As New SQLiteCommand(My.Resources.PurchaseOrderItemUpdate, Con)
                            ComOrderItemUpdate.Transaction = Trans
                            ComOrderItemUpdate.Parameters.AddWithValue("@ID", Item.ID)
                            ComOrderItemUpdate.Parameters.AddWithValue("@PURCHASEORDERID", ID)
                            ComOrderItemUpdate.Parameters.AddWithValue("@ITEMID", Item.Item.ID)
                            ComOrderItemUpdate.Parameters.AddWithValue("@QUANTITY", Item.Quantity * 100)
                            ComOrderItemUpdate.Parameters.AddWithValue("@ITEMUNITID", Item.Unit.ID)
                            ComOrderItemUpdate.Parameters.AddWithValue("@PRICE", Item.Price * 100)
                            ComOrderItemUpdate.Parameters.AddWithValue("@DISCOUNT", Item.Discount * 100)
                            ComOrderItemUpdate.Parameters.AddWithValue("@COMPLEMENT", Item.Complement)
                            ComOrderItemUpdate.Parameters.AddWithValue("@IPI", Item.IPI * 100)
                            ComOrderItemUpdate.Parameters.AddWithValue("@ICMS", Item.ICMS * 100)
                            ComOrderItemUpdate.ExecuteNonQuery()
                        End Using
                    End If
                Next item
                Trans.Commit()
            End Using
        End Using
    End Sub
    Public Sub Delete()
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.PurchaseOrderDelete, Con)
                Com.Parameters.AddWithValue("@ID", ID)
                Com.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub ChangeSituation()
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Using Com As New SQLiteCommand(My.Resources.PurchaseOrderChangeSituation, Con)
                Com.Parameters.AddWithValue("@ID", ID)
                Com.Parameters.AddWithValue("SITUATIONID", If(Situation = "Aprovado", 0, 1))
                Con.Open()
                Com.ExecuteNonQuery()
                Situation = If(Situation = "Aprovado", "Não Aprovado", "Aprovado")
            End Using
        End Using

    End Sub
End Class