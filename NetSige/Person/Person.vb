Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports System.Data.SQLite
Public Class Person
    Public Class Filter
        <Browsable(False)>
        Public Property DataGrid As New DataGridView
        Public Property ID As String
        <DisplayName("Status")>
        <TypeConverter(GetType(StatusFilterCollection))>
        Public Overridable Property Status As String
        <DisplayName("Entidade")>
        <TypeConverter(GetType(EntityFilterCollection))>
        Public Property EntityType As String
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Categoria")>
        Public Overridable Property Category As New PersonCategoryFilter
        <DisplayName("Nome")>
        Public Property Name As String
        <DisplayName("Nome Fantasia")>
        Public Property BusinessName As String
        <DisplayName("CPF/CNPJ")>
        Public Property Document1 As String
        <DisplayName("Insc. Estadual")>
        Public Property Document2 As String
        <DisplayName("Insc. Municipal")>
        Public Property Document3 As String
        <DisplayName("Cep")>
        Public Property ZipCode As String
        <DisplayName("Endereço")>
        Public Property Address As String
        <DisplayName("Número")>
        Public Property Number As String
        <DisplayName("Complemento")>
        Public Property Complement As String
        <DisplayName("Bairro")>
        Public Property District As String
        <DisplayName("Cidade")>
        Public Property City As String
        <DisplayName("Estado")>
        Public Property State As String
        <DisplayName("Observação")>
        Public Property Note As String
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Contato")>
        Public Property Contact As New PersonContactFilter
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Data de Criação")>
        Public Property CreationDate As New DateFilter
        Public Sub New(ByVal Grid As DataGridView)
            DataGrid = Grid
        End Sub
        Public Sub New()
        End Sub
        Public Overridable Function Filter(Optional ByVal SelectedRow As Integer = 0) As Boolean
            Dim Table As New DataTable
            Dim Filtering As Boolean
            Using Con As New SQLiteConnection(Common.ConnectionString)
                Con.Open()
                Using Com As New SQLiteCommand(My.Resources.PersonFilter, Con)
                    If ID <> Nothing Then Com.Parameters.AddWithValue("@ID", ID) : Filtering = True Else Com.Parameters.AddWithValue("@ID", "%")
                    If Status <> Nothing Then Com.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status)) : Filtering = True Else Com.Parameters.AddWithValue("@STATUSID", "%")
                    If EntityType <> Nothing Then Com.Parameters.AddWithValue("@ENTITYTYPEID", Common.PersonEntityTypes.IndexOf(EntityType)) : Filtering = True Else Com.Parameters.AddWithValue("@ENTITYTYPEID", "%")
                    If Category.Provider <> Nothing Then Com.Parameters.AddWithValue("@ISPROVIDER", If(Category.Provider = "Não", 0, 1)) : Filtering = True Else Com.Parameters.AddWithValue("@ISPROVIDER", "%")
                    If Category.Customer <> Nothing Then Com.Parameters.AddWithValue("@ISCUSTOMER", If(Category.Customer = "Não", 0, 1)) : Filtering = True Else Com.Parameters.AddWithValue("@ISCUSTOMER", "%")
                    If Category.Carrier <> Nothing Then Com.Parameters.AddWithValue("@ISCARRIER", If(Category.Carrier = "Não", 0, 1)) : Filtering = True Else Com.Parameters.AddWithValue("@ISCARRIER", "%")
                    If Name <> Nothing Then Com.Parameters.AddWithValue("@NAME", Name) : Filtering = True Else Com.Parameters.AddWithValue("@NAME", "%")
                    If BusinessName <> Nothing Then Com.Parameters.AddWithValue("@BUSINESSNAME", BusinessName) : Filtering = True Else Com.Parameters.AddWithValue("@BUSINESSNAME", "%")
                    If Document1 <> Nothing Then Com.Parameters.AddWithValue("@FIRSTDOCUMENT", Document1) : Filtering = True Else Com.Parameters.AddWithValue("@FIRSTDOCUMENT", "%")
                    If Document2 <> Nothing Then Com.Parameters.AddWithValue("@SECONDDOCUMENT", Document2) : Filtering = True Else Com.Parameters.AddWithValue("@SECONDDOCUMENT", "%")
                    If Document3 <> Nothing Then Com.Parameters.AddWithValue("@THIRDDOCUMENT", Document3) : Filtering = True Else Com.Parameters.AddWithValue("@THIRDDOCUMENT", "%")
                    If ZipCode <> Nothing Then Com.Parameters.AddWithValue("@ZIPCODE", ZipCode) : Filtering = True Else Com.Parameters.AddWithValue("@ZIPCODE", "%")
                    If Address <> Nothing Then Com.Parameters.AddWithValue("@ADDRESS", Address) : Filtering = True Else Com.Parameters.AddWithValue("@ADDRESS", "%")
                    If Number <> Nothing Then Com.Parameters.AddWithValue("@NUMBER", Number) : Filtering = True Else Com.Parameters.AddWithValue("@NUMBER", "%")
                    If Complement <> Nothing Then Com.Parameters.AddWithValue("@COMPLEMENT", Complement) : Filtering = True Else Com.Parameters.AddWithValue("@COMPLEMENT", "%")
                    If District <> Nothing Then Com.Parameters.AddWithValue("@DISTRICT", District) : Filtering = True Else Com.Parameters.AddWithValue("@DISTRICT", "%")
                    If City <> Nothing Then Com.Parameters.AddWithValue("@CITY", City) : Filtering = True Else Com.Parameters.AddWithValue("@CITY", "%")
                    If State <> Nothing Then Com.Parameters.AddWithValue("@STATE", State) : Filtering = True Else Com.Parameters.AddWithValue("@STATE", "%")
                    If Note <> Nothing Then Com.Parameters.AddWithValue("@NOTE", Note) : Filtering = True Else Com.Parameters.AddWithValue("@NOTE", "%")
                    If Contact.Name <> Nothing Then Com.Parameters.AddWithValue("@CONTACTNAME", Contact.Name) : Filtering = True Else Com.Parameters.AddWithValue("@CONTACTNAME", "%")
                    If Contact.JobTitle <> Nothing Then Com.Parameters.AddWithValue("@CONTACTJOBTITLE", Contact.JobTitle) : Filtering = True Else Com.Parameters.AddWithValue("@CONTACTJOBTITLE", "%")
                    If Contact.Phone <> Nothing Then Com.Parameters.AddWithValue("@CONTACTPHONE", Contact.Phone) : Filtering = True Else Com.Parameters.AddWithValue("@CONTACTPHONE", "%")
                    If Contact.Email <> Nothing Then Com.Parameters.AddWithValue("@CONTACTEMAIL", Contact.Email) : Filtering = True Else Com.Parameters.AddWithValue("@CONTACTEMAIL", "%")
                    If CreationDate.MinimumDate <> Nothing Then Com.Parameters.AddWithValue("@CREATIONDATEI", CreationDate.MinimumDate) : Filtering = True Else Com.Parameters.AddWithValue("@CREATIONDATEI", "1000-01-01")
                    If CreationDate.MaximumDate <> Nothing Then Com.Parameters.AddWithValue("@CREATIONDATEF", CreationDate.MaximumDate) : Filtering = True Else Com.Parameters.AddWithValue("@CREATIONDATEF", "9999-12-31")
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
            EntityType = Nothing
            Category.Carrier = Nothing
            Category.Customer = Nothing
            Category.Provider = Nothing
            Name = Nothing
            BusinessName = Nothing
            Document1 = Nothing
            Document2 = Nothing
            Document3 = Nothing
            ZipCode = Nothing
            Address = Nothing
            District = Nothing
            City = Nothing
            State = Nothing
            Note = Nothing
            Contact.Name = Nothing
            Contact.JobTitle = Nothing
            Contact.Phone = Nothing
            Contact.Email = Nothing
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
                Return New StandardValuesCollection(Common.SimpleStatusTypes)
            End Function
        End Class
        Private Class EntityFilterCollection
            Inherits StringConverter
            Public Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValues(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
                Return New StandardValuesCollection(Common.PersonEntityTypes)
            End Function
        End Class
        Private Class YesNoFilterCollection
            Inherits StringConverter
            Public Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValues(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
                Return New StandardValuesCollection(Common.YesNoTypes)
            End Function
        End Class
        Public Class PersonContactFilter
            <DisplayName("Nome")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property Name As String
            <DisplayName("Cargo")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            Public Property JobTitle As String
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
        End Class
        Public Class PersonCategoryFilter
            <DisplayName("Cliente")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            <TypeConverter(GetType(YesNoFilterCollection))>
            Public Property Customer As String
            <DisplayName("Fornecedor")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            <TypeConverter(GetType(YesNoFilterCollection))>
            Public Property Provider As String
            <DisplayName("Transportadora")>
            <NotifyParentProperty(True)>
            <RefreshProperties(RefreshProperties.All)>
            <TypeConverter(GetType(YesNoFilterCollection))>
            Public Property Carrier As String
            Public Overrides Function ToString() As String
                Return Nothing
            End Function
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

    Public Class Contact
        Public Property ID As Long
        Public Property Seq As Long
        <DisplayName("Nome")>
        Public Property Name As String
        <DisplayName("Cargo")>
        Public Property JobTitle As String
        <DisplayName("Telefone 1")>
        Public Property Phone1 As String
        <DisplayName("Telefone 2")>
        Public Property Phone2 As String
        <DisplayName("Telefone 3")>
        Public Property Phone3 As String
        <DisplayName("E-Mail 1")>
        Public Property Email1 As String
        <DisplayName("E-Mail 2")>
        Public Property Email2 As String
    End Class

    Public Class ContactCollection
        Inherits Collection(Of Contact)

        Public Function GetLastSeq() As Long
            Return If(Items.Count = 0, 0, Items.Max(Function(x) x.Seq))
        End Function
        Protected Overrides Sub InsertItem(index As Integer, item As Contact)
            If Items.Count = 0 Then
                item.Seq = 1
            Else
                item.Seq = GetLastSeq() + 1
            End If
            MyBase.InsertItem(index, item)
        End Sub
    End Class

    Public Sub GetContacts(ByVal Dgv As DataGridView, Optional ByVal SeqToSelect As Long = 0)
        Dim SelectedRow As Long = If(Dgv.SelectedRows.Count = 1, Dgv.SelectedRows(0).Index, 0)
        Dgv.Rows.Clear()
        Dgv.Columns.Clear()
        Dgv.Columns.Add("ID", "ID")
        Dgv.Columns.Add("SEQ", "Seq.")
        Dgv.Columns.Add("PROVIDERID", "PROVIDERID")
        Dgv.Columns.Add("NAME", "Nome")
        Dgv.Columns.Add("JOBTITLE", "Cargo")
        Dgv.Columns.Add("PHONE1", "Telefone 1")
        Dgv.Columns.Add("PHONE2", "Telefone 2")
        Dgv.Columns.Add("PHONE3", "Telefone 3")
        Dgv.Columns.Add("EMAIL1", "E-Mail 1")
        Dgv.Columns.Add("EMAIL2", "E-Mail 2")
        Dgv.Columns("ID").Visible = False
        Dgv.Columns("PROVIDERID").Visible = False
        For Each Contact As Contact In Contacts
            Dgv.Rows.Add({Contact.ID, Contact.Seq, ID, Contact.Name, Contact.JobTitle, Contact.Phone1, Contact.Phone2, Contact.Phone3, Contact.Email1, Contact.Email2})
        Next Contact
        If DefaultContactID > 0 Then
            For Each Row As DataGridViewRow In Dgv.Rows
                If Row.Cells("ID").Value = DefaultContactID Then
                    Row.DefaultCellStyle.Font = New Font(Dgv.DefaultCellStyle.Font, FontStyle.Bold)
                End If
            Next Row
        End If
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
    Public Property Status As String = "Ativo"
    Public Property EntityType As String = "Pessoa Jurídica"
    Public Property IsProvider As Boolean
    Public Property IsCustomer As Boolean
    Public Property IsCarrier As Boolean
    Private _CreationDate As Date = Today
    Public ReadOnly Property CreationDate As Date
        Get
            Return _CreationDate
        End Get
    End Property
    Public Property Name As String
    Public Property Businessname As String
    Public Property Document1 As String
    Public Property Document2 As String
    Public Property Document3 As String
    Public Property ZipCode As String
    Public Property Address As String
    Public Property Number As String
    Public Property Complement As String
    Public Property District As String
    Public Property City As String
    Public Property State As String
    Public Property Note As String
    Public Property Contacts As New ContactCollection
    Public Property DefaultContactID As Long = 0
    Public Property LastContactSeq As Long = 0
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
        Dim TableProvider As New DataTable
        Dim TableContact As New DataTable
        Dim Contact As New Contact
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Tran As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComProvider As New SQLiteCommand(My.Resources.PersonSelect, Con)
                    ComProvider.Parameters.AddWithValue("@ID", Identifier)
                    ComProvider.Transaction = Tran
                    Using Adp As New SQLiteDataAdapter(ComProvider)
                        Adp.Fill(TableProvider)
                    End Using
                End Using
                Using ComProviderContact As New SQLiteCommand(My.Resources.PersonContactSelect, Con)
                    ComProviderContact.Parameters.AddWithValue("@ID", Identifier)
                    ComProviderContact.Transaction = Tran
                    Using Adp As New SQLiteDataAdapter(ComProviderContact)
                        Adp.Fill(TableContact)
                    End Using
                End Using
                Tran.Commit()
            End Using
        End Using
        If TableProvider.Rows.Count = 1 Then
            _ID = TableProvider.Rows(0).Item("ID").ToString
            Status = Common.SimpleStatusTypes(TableProvider.Rows(0).Item("STATUSID"))
            _CreationDate = TableProvider.Rows(0).Item("CREATIONDATE").ToString
            EntityType = Common.PersonEntityTypes(TableProvider.Rows(0).Item("ENTITYTYPEID"))
            IsProvider = TableProvider.Rows(0).Item("ISPROVIDER")
            IsCustomer = TableProvider.Rows(0).Item("ISCUSTOMER")
            IsCarrier = TableProvider.Rows(0).Item("ISCARRIER")
            Name = TableProvider.Rows(0).Item("NAME").ToString
            Businessname = TableProvider.Rows(0).Item("BUSINESSNAME").ToString
            Document1 = TableProvider.Rows(0).Item("DOCUMENT1").ToString
            Document2 = TableProvider.Rows(0).Item("DOCUMENT2").ToString
            Document3 = TableProvider.Rows(0).Item("DOCUMENT3").ToString
            ZipCode = TableProvider.Rows(0).Item("ZIPCODE").ToString
            Address = TableProvider.Rows(0).Item("ADDRESS").ToString
            Number = TableProvider.Rows(0).Item("NUMBER").ToString
            Complement = TableProvider.Rows(0).Item("COMPLEMENT").ToString
            District = TableProvider.Rows(0).Item("DISTRICT").ToString
            City = TableProvider.Rows(0).Item("CITY").ToString
            State = TableProvider.Rows(0).Item("STATE").ToString
            Note = TableProvider.Rows(0).Item("NOTE").ToString
            DefaultContactID = TableProvider.Rows(0).Item("DEFAULTCONTACTID")
            LastContactSeq = TableProvider.Rows(0).Item("LASTCONTACTSEQ")
            _UserID = TableProvider.Rows(0).Item("USERID")
            For Each RowContact As DataRow In TableContact.Rows
                Contact = New Contact With {
                    .ID = RowContact.Item("ID"),
                    .Seq = RowContact.Item("SEQ"),
                    .Name = RowContact.Item("NAME").ToString,
                    .JobTitle = RowContact.Item("JOBTITLE").ToString,
                    .Phone1 = RowContact.Item("PHONE1").ToString,
                    .Phone2 = RowContact.Item("PHONE2").ToString,
                    .Phone3 = RowContact.Item("PHONE3").ToString,
                    .Email1 = RowContact.Item("EMAIL1").ToString,
                    .Email2 = RowContact.Item("EMAIL2").ToString
                }
                Contacts.Add(Contact)
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
        Dim DefaultContactAdded As Boolean
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Tran As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComSave As New SQLiteCommand(My.Resources.PersonInsert, Con)
                    ComSave.Transaction = Tran
                    ComSave.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                    ComSave.Parameters.AddWithValue("@CREATIONDATE", Now.ToString("yyyy-MM-dd"))
                    ComSave.Parameters.AddWithValue("@ENTITYTYPEID", Common.PersonEntityTypes.IndexOf(EntityType))
                    ComSave.Parameters.AddWithValue("@ISPROVIDER", If(IsProvider, 1, 0))
                    ComSave.Parameters.AddWithValue("@ISCUSTOMER", If(IsCustomer, 1, 0))
                    ComSave.Parameters.AddWithValue("@ISCARRIER", If(IsCarrier, 1, 0))
                    ComSave.Parameters.AddWithValue("@NAME", Name)
                    ComSave.Parameters.AddWithValue("@BUSINESSNAME", Businessname)
                    ComSave.Parameters.AddWithValue("@DOCUMENT1", Document1)
                    ComSave.Parameters.AddWithValue("@DOCUMENT2", Document2)
                    ComSave.Parameters.AddWithValue("@DOCUMENT3", Document3)
                    ComSave.Parameters.AddWithValue("@ZIPCODE", ZipCode)
                    ComSave.Parameters.AddWithValue("@ADDRESS", Address)
                    ComSave.Parameters.AddWithValue("@NUMBER", Number)
                    ComSave.Parameters.AddWithValue("@COMPLEMENT", Complement)
                    ComSave.Parameters.AddWithValue("@DISTRICT", District)
                    ComSave.Parameters.AddWithValue("@CITY", City)
                    ComSave.Parameters.AddWithValue("@STATE", State)
                    ComSave.Parameters.AddWithValue("@NOTE", Note)
                    ComSave.Parameters.AddWithValue("@DEFAULTCONTACTID", DefaultContactID)
                    ComSave.Parameters.AddWithValue("@USERID", Session.User.ID)
                    ComSave.ExecuteNonQuery()
                End Using
                Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                    ComReturnID.Transaction = Tran
                    _ID = ComReturnID.ExecuteScalar
                    _CreationDate = Today
                End Using
                For Each Contact In Contacts
                    Using ComContactSave As New SQLiteCommand(My.Resources.PersonContactInsert, Con)
                        ComContactSave.Transaction = Tran
                        ComContactSave.Parameters.AddWithValue("@SEQ", Contact.Seq)
                        ComContactSave.Parameters.AddWithValue("@PERSONID", ID)
                        ComContactSave.Parameters.AddWithValue("@NAME", Contact.Name)
                        ComContactSave.Parameters.AddWithValue("@JOBTITLE", Contact.JobTitle)
                        ComContactSave.Parameters.AddWithValue("@PHONE1", Contact.Phone1)
                        ComContactSave.Parameters.AddWithValue("@PHONE2", Contact.Phone2)
                        ComContactSave.Parameters.AddWithValue("@PHONE3", Contact.Phone3)
                        ComContactSave.Parameters.AddWithValue("@EMAIL1", Contact.Email1)
                        ComContactSave.Parameters.AddWithValue("@EMAIL2", Contact.Email2)
                        ComContactSave.ExecuteNonQuery()
                    End Using
                    Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                        ComReturnID.Transaction = Tran
                        Contact.ID = ComReturnID.ExecuteScalar
                        If Not DefaultContactAdded Then
                            Using ComDefaultContactUpdate As New SQLiteCommand(My.Resources.PersonDefaultContactUpdate, Con)
                                ComDefaultContactUpdate.Transaction = Tran
                                ComDefaultContactUpdate.Parameters.AddWithValue("@DEFAULTCONTACTID", Contact.ID)
                                ComDefaultContactUpdate.Parameters.AddWithValue("@PERSONID", ID)
                                ComDefaultContactUpdate.ExecuteNonQuery()
                            End Using
                            DefaultContactID = Contact.ID
                            DefaultContactAdded = True
                        End If
                    End Using
                Next Contact
                Using ComLastSeq As New SQLiteCommand(My.Resources.PersonLastContactSeqUpdate, Con)
                    ComLastSeq.Transaction = Tran
                    ComLastSeq.Parameters.AddWithValue("@ID", ID)
                    ComLastSeq.Parameters.AddWithValue("@LASTCONTACTSEQ", Contacts.GetLastSeq)
                    ComLastSeq.ExecuteNonQuery()
                End Using
                Tran.Commit()
            End Using
        End Using
    End Sub

    Private Sub SaveChanges()
        Dim Table As New DataTable
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Tran As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComUpdateProvider As New SQLiteCommand(My.Resources.PersonUpdate, Con)
                    ComUpdateProvider.Transaction = Tran
                    ComUpdateProvider.Parameters.AddWithValue("@ID", ID)
                    ComUpdateProvider.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                    ComUpdateProvider.Parameters.AddWithValue("@ENTITYTYPEID", Common.PersonEntityTypes.IndexOf(EntityType))
                    ComUpdateProvider.Parameters.AddWithValue("@ISPROVIDER", If(IsProvider, 1, 0))
                    ComUpdateProvider.Parameters.AddWithValue("@ISCUSTOMER", If(IsCustomer, 1, 0))
                    ComUpdateProvider.Parameters.AddWithValue("@ISCARRIER", If(IsCarrier, 1, 0))
                    ComUpdateProvider.Parameters.AddWithValue("@NAME", Name)
                    ComUpdateProvider.Parameters.AddWithValue("@BUSINESSNAME", Businessname)
                    ComUpdateProvider.Parameters.AddWithValue("@DOCUMENT1", Document1)
                    ComUpdateProvider.Parameters.AddWithValue("@DOCUMENT2", Document2)
                    ComUpdateProvider.Parameters.AddWithValue("@DOCUMENT3", Document3)
                    ComUpdateProvider.Parameters.AddWithValue("@ZIPCODE", ZipCode)
                    ComUpdateProvider.Parameters.AddWithValue("@ADDRESS", Address)
                    ComUpdateProvider.Parameters.AddWithValue("@NUMBER", Number)
                    ComUpdateProvider.Parameters.AddWithValue("@COMPLEMENT", Complement)
                    ComUpdateProvider.Parameters.AddWithValue("@DISTRICT", District)
                    ComUpdateProvider.Parameters.AddWithValue("@CITY", City)
                    ComUpdateProvider.Parameters.AddWithValue("@STATE", State)
                    ComUpdateProvider.Parameters.AddWithValue("@NOTE", Note)
                    ComUpdateProvider.Parameters.AddWithValue("@DEFAULTCONTACTID", DefaultContactID)
                    ComUpdateProvider.Parameters.AddWithValue("@USERID", UserID)
                    ComUpdateProvider.ExecuteNonQuery()
                End Using
                Using ComSelectContacts As New SQLiteCommand(My.Resources.PersonContactSelect, Con)
                    ComSelectContacts.Transaction = Tran
                    ComSelectContacts.Parameters.AddWithValue("@ID", ID)
                    Using Adp As New SQLiteDataAdapter(ComSelectContacts)
                        Adp.Fill(Table)
                    End Using
                End Using

                For Each RowDb As DataRow In Table.Rows
                    If Not Contacts.AsEnumerable().Where(Function(c) c.ID.Equals(RowDb.Item("ID"))).Count() > 0 Then
                        Using ConDeleteContact As New SQLiteCommand(My.Resources.PersonContactDelete, Con)
                            ConDeleteContact.Transaction = Tran
                            ConDeleteContact.Parameters.AddWithValue("@ID", RowDb.Item("ID"))
                            ConDeleteContact.Parameters.AddWithValue("@PERSONID", RowDb.Item("PERSONID"))
                            ConDeleteContact.ExecuteNonQuery()
                        End Using
                    End If
                Next
                For Each Contact As Contact In Contacts
                    If Contact.ID = 0 Then
                        Using ComContactSave As New SQLiteCommand(My.Resources.PersonContactInsert, Con)
                            ComContactSave.Transaction = Tran
                            ComContactSave.Parameters.AddWithValue("@SEQ", Contact.Seq)
                            ComContactSave.Parameters.AddWithValue("@PERSONID", ID)
                            ComContactSave.Parameters.AddWithValue("@NAME", Contact.Name)
                            ComContactSave.Parameters.AddWithValue("@JOBTITLE", Contact.JobTitle)
                            ComContactSave.Parameters.AddWithValue("@PHONE1", Contact.Phone1)
                            ComContactSave.Parameters.AddWithValue("@PHONE2", Contact.Phone2)
                            ComContactSave.Parameters.AddWithValue("@PHONE3", Contact.Phone3)
                            ComContactSave.Parameters.AddWithValue("@EMAIL1", Contact.Email1)
                            ComContactSave.Parameters.AddWithValue("@EMAIL2", Contact.Email2)
                            ComContactSave.ExecuteNonQuery()
                        End Using
                        Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                            ComReturnID.Transaction = Tran
                            Contact.ID = ComReturnID.ExecuteScalar
                        End Using
                        Using ComProviderLastSeqUpdate As New SQLiteCommand(My.Resources.PersonLastContactSeqUpdate, Con)
                            ComProviderLastSeqUpdate.Transaction = Tran
                            ComProviderLastSeqUpdate.Parameters.AddWithValue("@ID", ID)
                            ComProviderLastSeqUpdate.Parameters.AddWithValue("@LASTCONTACTSEQ", Contact.Seq)
                            ComProviderLastSeqUpdate.ExecuteNonQuery()
                        End Using
                    Else
                        Using ComContactUpdate As New SQLiteCommand(My.Resources.PersonContactUpdate, Con)
                            ComContactUpdate.Transaction = Tran
                            ComContactUpdate.Parameters.AddWithValue("@ID", Contact.ID)
                            ComContactUpdate.Parameters.AddWithValue("@PERSONID", ID)
                            ComContactUpdate.Parameters.AddWithValue("@NAME", Contact.Name)
                            ComContactUpdate.Parameters.AddWithValue("@JOBTITLE", Contact.JobTitle)
                            ComContactUpdate.Parameters.AddWithValue("@PHONE1", Contact.Phone1)
                            ComContactUpdate.Parameters.AddWithValue("@PHONE2", Contact.Phone2)
                            ComContactUpdate.Parameters.AddWithValue("@PHONE3", Contact.Phone3)
                            ComContactUpdate.Parameters.AddWithValue("@EMAIL1", Contact.Email1)
                            ComContactUpdate.Parameters.AddWithValue("@EMAIL2", Contact.Email2)
                            ComContactUpdate.ExecuteNonQuery()
                        End Using
                    End If
                Next Contact
                Tran.Commit()
            End Using
        End Using
    End Sub


    Public Sub Delete()
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.PersonDelete, Con)
                Com.Parameters.AddWithValue("@ID", ID)
                Com.ExecuteNonQuery()
            End Using
        End Using
    End Sub



End Class
