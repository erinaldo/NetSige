Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Provider
    Public Class Filter
        <Browsable(False)>
        Public Property DataGrid As New DataGridView
        Public Property ID As String
        <DisplayName("Status")>
        <TypeConverter(GetType(StatusFilterCollection))>
        Public Property Status As String
        <DisplayName("Tipo")>
        <TypeConverter(GetType(CategoryFilterCollection))>
        Public Property Category As String
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
        Public Property Contact As New ProviderContactFilter
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Data de Criação")>
        Public Property CreationDate As New DateFilter
        Public Sub New(ByVal Grid As DataGridView)
            DataGrid = Grid
        End Sub
        Public Sub New()
        End Sub
        Public Function Filter(Optional ByVal SelectedRow As Integer = 0) As Boolean
            Dim Table As New DataTable
            Dim Filtering As Boolean
            Using Con As New MySqlConnection(Common.ConnectionString)
                Con.Open()
                Using Com As New MySqlCommand(My.Resources.ProviderFilter, Con)
                    If ID <> Nothing Then Com.Parameters.AddWithValue("@ID", ID) : Filtering = True Else Com.Parameters.AddWithValue("@ID", "%")
                    If Status <> Nothing Then Com.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status)) : Filtering = True Else Com.Parameters.AddWithValue("@STATUSID", "%")
                    If Category <> Nothing Then Com.Parameters.AddWithValue("@CATEGORYID", Common.ProviderCategoryTypes.IndexOf(Category)) : Filtering = True Else Com.Parameters.AddWithValue("@CATEGORYID", "%")
                    If Name <> Nothing Then Com.Parameters.AddWithValue("@NAME", Name) : Filtering = True Else Com.Parameters.AddWithValue("@NAME", "%")
                    If BusinessName <> Nothing Then Com.Parameters.AddWithValue("@BUSINESSNAME", BusinessName) : Filtering = True Else Com.Parameters.AddWithValue("@BUSINESSNAME", "%")
                    If Document1 <> Nothing Then Com.Parameters.AddWithValue("@FIRSTDOCUMENT", Document1) : Filtering = True Else Com.Parameters.AddWithValue("@FIRSTDOCUMENT", "%")
                    If Document2 <> Nothing Then Com.Parameters.AddWithValue("@SECONDDOCUMENT", Document2) : Filtering = True Else Com.Parameters.AddWithValue("@SECONDDOCUMENT", "%")
                    If Document3 <> Nothing Then Com.Parameters.AddWithValue("@THIRDDOCUMENT", Document3) : Filtering = True Else Com.Parameters.AddWithValue("@THIRDDOCUMENT", "%")
                    If ZipCode <> Nothing Then Com.Parameters.AddWithValue("@ZIPCODE", ZipCode) : Filtering = True Else Com.Parameters.AddWithValue("@ZIPCODE", "%")
                    If Address <> Nothing Then Com.Parameters.AddWithValue("@ADDRESS", Address) : Filtering = True Else Com.Parameters.AddWithValue("@ADDRESS", "%")
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
                    Using Adp As New MySqlDataAdapter(Com)
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
            Category = Nothing
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

        Private Class CategoryFilterCollection
            Inherits StringConverter
            Public Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValues(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
                Return New StandardValuesCollection(Common.ProviderCategoryTypes)
            End Function
        End Class



        Public Class ProviderContactFilter
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





    Private _ID As Long
    Public ReadOnly Property ID As Long
        Get
            Return _ID
        End Get
    End Property
    Public Property Status As String = "Ativo"
    Public Property Category As String = "PJ"
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
    Public Property District As String
    Public Property City As String
    Public Property State As String
    Public Property Note As String
    Public Property Contacts As New List(Of Contact)
    Public Property ContactsTable As New DataTable

    Public Property DefaultContactID As Long = 0

    Private _LastModifiedUser As Long
    Public ReadOnly Property LastModifiedUser As Long
        Get
            Return _LastModifiedUser
        End Get
    End Property
    Private _LastModifiedTime As Date
    Public ReadOnly Property LastModifiedTime As Date
        Get
            Return _LastModifiedTime
        End Get
    End Property

    Public Sub New()
        Dim Table As New DataTable
        Using Con As New MySqlConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New MySqlCommand(My.Resources.ProviderContactSelect, Con)
                Com.Parameters.AddWithValue("@ID", 0)
                Using Adp As New MySqlDataAdapter(Com)
                    Adp.Fill(Table)
                    ContactsTable = Table
                End Using
            End Using
        End Using
        ContactsTable.Columns("ID").ColumnMapping = MappingType.Hidden
        ContactsTable.Columns("PROVIDERID").ColumnMapping = MappingType.Hidden
        ContactsTable.Columns("NAME").Caption = "Nome"
        ContactsTable.Columns("JOBTITLE").Caption = "Cargo"
        ContactsTable.Columns("PHONE1").Caption = "Telefone 1"
        ContactsTable.Columns("PHONE2").Caption = "Telefone 2"
        ContactsTable.Columns("PHONE3").Caption = "Telefone 3"
        ContactsTable.Columns("EMAIL1").Caption = "E-Mail 1"
        ContactsTable.Columns("EMAIL2").Caption = "E-Mail 2"
    End Sub

    Public Sub New(ByVal Identifier As Long)
        Load(Identifier)
    End Sub

    Public Sub Load(ByVal Identifier As Long)
        Dim TableProvider As New DataTable
        Dim TableContact As New DataTable
        Dim Contact As New Contact
        Using Con As New MySqlConnection(Common.ConnectionString)
            Con.Open()
            Using Tran As MySqlTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComProvider As New MySqlCommand(My.Resources.ProviderSelect, Con)
                    ComProvider.Parameters.AddWithValue("@ID", Identifier)
                    ComProvider.Transaction = Tran
                    Using Adp As New MySqlDataAdapter(ComProvider)
                        Adp.Fill(TableProvider)
                    End Using
                End Using
                Using ComProviderContact As New MySqlCommand(My.Resources.ProviderContactSelect, Con)
                    ComProviderContact.Parameters.AddWithValue("@ID", Identifier)
                    ComProviderContact.Transaction = Tran
                    Using Adp As New MySqlDataAdapter(ComProviderContact)
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
            Category = Common.ProviderCategoryTypes(TableProvider.Rows(0).Item("CATEGORYID"))
            Name = TableProvider.Rows(0).Item("NAME").ToString
            Businessname = TableProvider.Rows(0).Item("BUSINESSNAME").ToString
            Document1 = TableProvider.Rows(0).Item("DOCUMENT1").ToString
            Document2 = TableProvider.Rows(0).Item("DOCUMENT2").ToString
            Document3 = TableProvider.Rows(0).Item("DOCUMENT3").ToString
            ZipCode = TableProvider.Rows(0).Item("ZIPCODE").ToString
            Address = TableProvider.Rows(0).Item("ADDRESS").ToString
            District = TableProvider.Rows(0).Item("DISTRICT").ToString
            City = TableProvider.Rows(0).Item("CITY").ToString
            State = TableProvider.Rows(0).Item("STATE").ToString
            Note = TableProvider.Rows(0).Item("NOTE").ToString
            _DefaultContactID = TableProvider.Rows(0).Item("DEFAULTCONTACTID")
            _LastModifiedUser = TableProvider.Rows(0).Item("LASTMODIFIEDUSER")
            _LastModifiedTime = TableProvider.Rows(0).Item("LASTMODIFIEDTIME")
            For Each RowContact As DataRow In TableContact.Rows
                Contact = New Contact With {
                    .ID = RowContact.Item("ID"),
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
            ContactsTable = TableContact
            ContactsTable.Columns("ID").ColumnMapping = MappingType.Hidden
            ContactsTable.Columns("PROVIDERID").ColumnMapping = MappingType.Hidden
            ContactsTable.Columns("NAME").Caption = "Nome"
            ContactsTable.Columns("JOBTITLE").Caption = "Cargo"
            ContactsTable.Columns("PHONE1").Caption = "Telefone 1"
            ContactsTable.Columns("PHONE2").Caption = "Telefone 2"
            ContactsTable.Columns("PHONE3").Caption = "Telefone 3"
            ContactsTable.Columns("EMAIL1").Caption = "E-Mail 1"
            ContactsTable.Columns("EMAIL2").Caption = "E-Mail 2"
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
        Using Con As New MySqlConnection(Common.ConnectionString)
            Con.Open()
            Using Tran As MySqlTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComSave As New MySqlCommand(My.Resources.ProviderInsert, Con)
                    ComSave.Transaction = Tran
                    ComSave.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                    ComSave.Parameters.AddWithValue("@CREATIONDATE", Now.ToString("yyyy-MM-dd"))
                    ComSave.Parameters.AddWithValue("@CATEGORYID", Common.ProviderCategoryTypes.IndexOf(Category))
                    ComSave.Parameters.AddWithValue("@NAME", Name)
                    ComSave.Parameters.AddWithValue("@BUSINESSNAME", Businessname)
                    ComSave.Parameters.AddWithValue("@DOCUMENT1", Document1)
                    ComSave.Parameters.AddWithValue("@DOCUMENT2", Document2)
                    ComSave.Parameters.AddWithValue("@DOCUMENT3", Document3)
                    ComSave.Parameters.AddWithValue("@ZIPCODE", ZipCode)
                    ComSave.Parameters.AddWithValue("@ADDRESS", Address)
                    ComSave.Parameters.AddWithValue("@DISTRICT", District)
                    ComSave.Parameters.AddWithValue("@CITY", City)
                    ComSave.Parameters.AddWithValue("@STATE", State)
                    ComSave.Parameters.AddWithValue("@NOTE", Note)
                    ComSave.Parameters.AddWithValue("@DEFAULTCONTACTID", DefaultContactID)
                    ComSave.Parameters.AddWithValue("@LASTMODIFIEDUSER", Session.User.ID)
                    ComSave.Parameters.AddWithValue("@LASTMODIFIEDTIME", Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    ComSave.ExecuteNonQuery()
                End Using
                Using ComReturnID As New MySqlCommand(My.Resources.SqlLastID, Con)
                    ComReturnID.Transaction = Tran
                    _ID = ComReturnID.ExecuteScalar
                    _CreationDate = Today
                End Using

                Dim defaultcontactadded As Boolean

                For Each Row As DataRow In ContactsTable.Rows
                    Using ComContactSave As New MySqlCommand(My.Resources.ProviderContactInsert, Con)
                        ComContactSave.Transaction = Tran
                        ComContactSave.Parameters.AddWithValue("@PROVIDERID", ID)
                        ComContactSave.Parameters.AddWithValue("@NAME", Row.Item("NAME").ToString)
                        ComContactSave.Parameters.AddWithValue("@JOBTITLE", Row.Item("JOBTITLE").ToString)
                        ComContactSave.Parameters.AddWithValue("@PHONE1", Row.Item("PHONE1").ToString)
                        ComContactSave.Parameters.AddWithValue("@PHONE2", Row.Item("PHONE2").ToString)
                        ComContactSave.Parameters.AddWithValue("@PHONE3", Row.Item("PHONE3").ToString)
                        ComContactSave.Parameters.AddWithValue("@EMAIL1", Row.Item("EMAIL1").ToString)
                        ComContactSave.Parameters.AddWithValue("@EMAIL2", Row.Item("EMAIL2").ToString)
                        ComContactSave.ExecuteNonQuery()
                    End Using
                    Using ComReturnID As New MySqlCommand(My.Resources.SqlLastID, Con)
                        ComReturnID.Transaction = Tran
                        Row.Item("ID") = ComReturnID.ExecuteScalar
                        Row.Item("PROVIDERID") = ID

                        If Not defaultcontactadded Then
                            Using c As New MySqlCommand(My.Resources.ProviderDefaultContactUpdate, Con)
                                c.Transaction = Tran
                                c.Parameters.AddWithValue("@DEFAULTCONTACTID", Row.Item("ID"))
                                c.Parameters.AddWithValue("@PROVIDERID", ID)
                                c.ExecuteNonQuery()
                            End Using
                            DefaultContactID = Row.Item("ID")
                            defaultcontactadded = True
                        End If
                    End Using
                Next Row
                Tran.Commit()
            End Using
        End Using
    End Sub

    Private Sub SaveChanges()
        Dim Table As New DataTable
        Using Con As New MySqlConnection(Common.ConnectionString)
            Con.Open()
            Using Trans As MySqlTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComUpdateProvider As New MySqlCommand(My.Resources.ProviderUpdate, Con)
                    ComUpdateProvider.Transaction = Trans
                    ComUpdateProvider.Parameters.AddWithValue("@ID", ID)
                    ComUpdateProvider.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                    ComUpdateProvider.Parameters.AddWithValue("@CATEGORYID", Common.ProviderCategoryTypes.IndexOf(Category))
                    ComUpdateProvider.Parameters.AddWithValue("@NAME", Name)
                    ComUpdateProvider.Parameters.AddWithValue("@BUSINESSNAME", Businessname)
                    ComUpdateProvider.Parameters.AddWithValue("@DOCUMENT1", Document1)
                    ComUpdateProvider.Parameters.AddWithValue("@DOCUMENT2", Document2)
                    ComUpdateProvider.Parameters.AddWithValue("@DOCUMENT3", Document3)
                    ComUpdateProvider.Parameters.AddWithValue("@ZIPCODE", ZipCode)
                    ComUpdateProvider.Parameters.AddWithValue("@ADDRESS", Address)
                    ComUpdateProvider.Parameters.AddWithValue("@DISTRICT", District)
                    ComUpdateProvider.Parameters.AddWithValue("@CITY", City)
                    ComUpdateProvider.Parameters.AddWithValue("@STATE", State)
                    ComUpdateProvider.Parameters.AddWithValue("@NOTE", Note)
                    ComUpdateProvider.Parameters.AddWithValue("@DEFAULTCONTACTID", DefaultContactID)
                    ComUpdateProvider.Parameters.AddWithValue("@LASTMODIFIEDUSER", LastModifiedUser)
                    ComUpdateProvider.Parameters.AddWithValue("@LASTMODIFIEDTIME", LastModifiedTime)
                    ComUpdateProvider.ExecuteNonQuery()
                End Using
                Using ComSelectContacts As New MySqlCommand(My.Resources.ProviderContactSelect, Con)
                    ComSelectContacts.Parameters.AddWithValue("@ID", ID)
                    ComSelectContacts.Transaction = Trans
                    Using Adp As New MySqlDataAdapter(ComSelectContacts)
                        Adp.Fill(Table)
                    End Using
                End Using

                For Each RowDb As DataRow In Table.Rows
                    If Not ContactsTable.AsEnumerable().Where(Function(c) c.Field(Of Integer)("ID").Equals(RowDb.Item("ID"))).Count() > 0 Then
                        Using ConDeleteContact As New MySqlCommand(My.Resources.ProviderContactDelete, Con)
                            ConDeleteContact.Transaction = Trans
                            ConDeleteContact.Parameters.AddWithValue("@ID", RowDb.Item("ID"))
                            ConDeleteContact.Parameters.AddWithValue("@PROVIDERID", RowDb.Item("PROVIDERID"))
                            ConDeleteContact.ExecuteNonQuery()
                        End Using
                    End If
                Next


                For Each Row As DataRow In ContactsTable.Rows
                    If Row.Item("ID") = 0 Then
                        Using ComContactSave As New MySqlCommand(My.Resources.ProviderContactInsert, Con)
                            ComContactSave.Transaction = Trans
                            ComContactSave.Parameters.AddWithValue("@ID", ID)
                            ComContactSave.Parameters.AddWithValue("@PROVIDERID", ID)
                            ComContactSave.Parameters.AddWithValue("@NAME", Row.Item("NAME").ToString)
                            ComContactSave.Parameters.AddWithValue("@JOBTITLE", Row.Item("JOBTITLE").ToString)
                            ComContactSave.Parameters.AddWithValue("@PHONE1", Row.Item("PHONE1").ToString)
                            ComContactSave.Parameters.AddWithValue("@PHONE2", Row.Item("PHONE2").ToString)
                            ComContactSave.Parameters.AddWithValue("@PHONE3", Row.Item("PHONE3").ToString)
                            ComContactSave.Parameters.AddWithValue("@EMAIL1", Row.Item("EMAIL1").ToString)
                            ComContactSave.Parameters.AddWithValue("@EMAIL2", Row.Item("EMAIL2").ToString)
                            ComContactSave.ExecuteNonQuery()
                        End Using
                        Using ComReturnID As New MySqlCommand(My.Resources.SqlLastID, Con)
                            ComReturnID.Transaction = Trans
                            Row.Item("ID") = ComReturnID.ExecuteScalar
                            Row.Item("PROVIDERID") = ID
                        End Using
                    Else
                        Using ComContactUpdate As New MySqlCommand(My.Resources.ProviderContactUpdate, Con)
                            ComContactUpdate.Transaction = Trans
                            ComContactUpdate.Parameters.AddWithValue("@ID", Row.Item("ID"))
                            ComContactUpdate.Parameters.AddWithValue("@PROVIDERID", Row.Item("PROVIDERID"))
                            ComContactUpdate.Parameters.AddWithValue("@NAME", Row.Item("NAME").ToString)
                            ComContactUpdate.Parameters.AddWithValue("@JOBTITLE", Row.Item("JOBTITLE").ToString)
                            ComContactUpdate.Parameters.AddWithValue("@PHONE1", Row.Item("PHONE1").ToString)
                            ComContactUpdate.Parameters.AddWithValue("@PHONE2", Row.Item("PHONE2").ToString)
                            ComContactUpdate.Parameters.AddWithValue("@PHONE3", Row.Item("PHONE3").ToString)
                            ComContactUpdate.Parameters.AddWithValue("@EMAIL1", Row.Item("EMAIL1").ToString)
                            ComContactUpdate.Parameters.AddWithValue("@EMAIL2", Row.Item("EMAIL2").ToString)
                            ComContactUpdate.ExecuteNonQuery()
                        End Using
                    End If
                Next Row
                Trans.Commit()
            End Using
        End Using
    End Sub

    Public Sub Delete()
        Using Con As New MySqlConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New MySqlCommand(My.Resources.ProviderDelete, Con)
                Com.Parameters.AddWithValue("@ID", ID)
                Com.ExecuteNonQuery()
            End Using
        End Using
    End Sub



End Class
