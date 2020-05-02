Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports System.Data.SQLite
Public Class CostSharing
    Public Class Filter
        <Browsable(False)>
        Public Property DataGrid As New DataGridView
        Public Property ID As String
        <DisplayName("Status")>
        <TypeConverter(GetType(StatusFilterCollection))>
        Public Overridable Property Status As String
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
                Using Com As New SQLiteCommand(My.Resources.CostSharingFilter, Con)
                    If ID <> Nothing Then Com.Parameters.AddWithValue("@ID", ID) : Filtering = True Else Com.Parameters.AddWithValue("@ID", "%")
                    If Status <> Nothing Then Com.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status)) : Filtering = True Else Com.Parameters.AddWithValue("@STATUSID", "%")
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
                    If CreationDate.MinimumDate <> Nothing Then Com.Parameters.AddWithValue("@CREATIONDATEI", CreationDate.MinimumDate) : Filtering = True Else Com.Parameters.AddWithValue("@CREATIONDATEI", "1000-01-01")
                    If CreationDate.MaximumDate <> Nothing Then Com.Parameters.AddWithValue("@CREATIONDATEF", CreationDate.MaximumDate) : Filtering = True Else Com.Parameters.AddWithValue("@CREATIONDATEF", "9999-12-31")
                    Using Adp As New SQLiteDataAdapter(Com)
                        Adp.Fill(Table)
                        _DataGrid.DataSource = Table
                    End Using
                End Using
            End Using
            If _DataGrid.Rows.Count > 0 Then
                If SelectedRow < _DataGrid.Rows.Count Then
                    _DataGrid.Rows(SelectedRow).Selected = True
                ElseIf SelectedRow >= _DataGrid.Rows.Count Then
                    _DataGrid.Rows(_DataGrid.Rows.Count - 1).Selected = True
                End If
            End If
            Return Filtering
        End Function
        Public Sub Clean()
            ID = Nothing
            Status = Nothing
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

    Public Class Local
        Public Property ID As Long
        Public Property Seq As Long
        Public Property Name As String
        Public Property ZipCode As String
        Public Property Address As String
        Public Property Number As String
        Public Property Complement As String
        Public Property District As String
        Public Property City As String
        Public Property State As String
        Public Property Phone As String
        Public Property Email As String
    End Class

    Public Class LocalCollection
        Inherits Collection(Of Local)

        Public Function GetLastSeq() As Long
            Return If(Items.Count = 0, 0, Items.Max(Function(x) x.Seq))
        End Function
        Protected Overrides Sub InsertItem(index As Integer, item As Local)
            If Items.Count = 0 Then
                item.Seq = 1
            Else
                item.Seq = GetLastSeq() + 1
            End If
            MyBase.InsertItem(index, item)
        End Sub
    End Class

    Public Sub GetLocals(ByVal Dgv As DataGridView, Optional ByVal SeqToSelect As Long = 0)
        Dim SelectedRow As Long = If(Dgv.SelectedRows.Count = 1, Dgv.SelectedRows(0).Index, 0)
        Dgv.Rows.Clear()
        Dgv.Columns.Clear()
        Dgv.Columns.Add("ID", "ID")
        Dgv.Columns.Add("SEQ", "Seq.")
        Dgv.Columns.Add("COSTSHARINGID", "COSTSHARINGID")
        Dgv.Columns.Add("NAME", "Nome")
        Dgv.Columns.Add("ZIPCODE", "CEP")
        Dgv.Columns.Add("ADDRESS", "Endereço")
        Dgv.Columns.Add("NUMBER", "Nº")
        Dgv.Columns.Add("COMPLEMENT", "Complemento")
        Dgv.Columns.Add("DISTRICT", "Bairro")
        Dgv.Columns.Add("CITY", "Cidade")
        Dgv.Columns.Add("STATE", "Estado")

        Dgv.Columns.Add("PHONE", "Telefone")
        Dgv.Columns.Add("EMAIL", "E-Mail")

        Dgv.Columns("ID").Visible = False
        Dgv.Columns("COSTSHARINGID").Visible = False
        For Each Local As Local In Locals
            Dgv.Rows.Add({Local.ID, Local.Seq, ID, Local.Name, Local.ZipCode, Local.Address, Local.Number, Local.Complement, Local.District, Local.City, Local.State, Local.Phone, Local.Email})
        Next Local
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
    Private _CreationDate As Date = Today
    Public ReadOnly Property CreationDate As Date
        Get
            Return _CreationDate
        End Get
    End Property
    Public Property LogoPath As String
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
    Public Property Locals As New LocalCollection
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
        Dim TableCostSharing As New DataTable
        Dim TableLocal As New DataTable
        Dim Local As New Local
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Tran As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using Com As New SQLiteCommand(My.Resources.CostSharingSelect, Con)
                    Com.Parameters.AddWithValue("@ID", Identifier)
                    Com.Transaction = Tran
                    Using Adp As New SQLiteDataAdapter(Com)
                        Adp.Fill(TableCostSharing)
                    End Using
                End Using
                Using ComLocal As New SQLiteCommand(My.Resources.CostSharingLocalSelect, Con)
                    ComLocal.Parameters.AddWithValue("@ID", Identifier)
                    ComLocal.Transaction = Tran
                    Using Adp As New SQLiteDataAdapter(ComLocal)
                        Adp.Fill(TableLocal)
                    End Using
                End Using
                Tran.Commit()
            End Using
        End Using
        If TableCostSharing.Rows.Count = 1 Then
            _ID = TableCostSharing.Rows(0).Item("ID").ToString
            Status = Common.SimpleStatusTypes(TableCostSharing.Rows(0).Item("STATUSID"))
            _CreationDate = TableCostSharing.Rows(0).Item("CREATIONDATE").ToString
            LogoPath = TableCostSharing.Rows(0).Item("LOGOPATH").ToString
            Name = TableCostSharing.Rows(0).Item("NAME").ToString
            Businessname = TableCostSharing.Rows(0).Item("BUSINESSNAME").ToString
            Document1 = TableCostSharing.Rows(0).Item("DOCUMENT1").ToString
            Document2 = TableCostSharing.Rows(0).Item("DOCUMENT2").ToString
            Document3 = TableCostSharing.Rows(0).Item("DOCUMENT3").ToString
            ZipCode = TableCostSharing.Rows(0).Item("ZIPCODE").ToString
            Address = TableCostSharing.Rows(0).Item("ADDRESS").ToString
            Number = TableCostSharing.Rows(0).Item("NUMBER").ToString
            Complement = TableCostSharing.Rows(0).Item("COMPLEMENT").ToString
            District = TableCostSharing.Rows(0).Item("DISTRICT").ToString
            City = TableCostSharing.Rows(0).Item("CITY").ToString
            State = TableCostSharing.Rows(0).Item("STATE").ToString
            Note = TableCostSharing.Rows(0).Item("NOTE").ToString
            _UserID = TableCostSharing.Rows(0).Item("USERID")
            For Each RowLocal As DataRow In TableLocal.Rows
                Local = New Local With {
                    .ID = RowLocal.Item("ID"),
                    .Seq = RowLocal.Item("SEQ"),
                    .Name = RowLocal.Item("NAME").ToString,
                    .ZipCode = RowLocal.Item("ZIPCODE").ToString,
                    .Address = RowLocal.Item("ADDRESS").ToString,
                    .Number = RowLocal.Item("NUMBER").ToString,
                    .Complement = RowLocal.Item("COMPLEMENT").ToString,
                    .District = RowLocal.Item("DISTRICT").ToString,
                    .City = RowLocal.Item("CITY").ToString,
                    .State = RowLocal.Item("STATE").ToString,
                    .Phone = RowLocal.Item("PHONE").ToString,
                    .Email = RowLocal.Item("EMAIL").ToString
                }
                Locals.Add(Local)
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
                Using ComSave As New SQLiteCommand(My.Resources.CostSharingInsert, Con)
                    ComSave.Transaction = Tran
                    ComSave.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                    ComSave.Parameters.AddWithValue("@CREATIONDATE", Now.ToString("yyyy-MM-dd"))
                    ComSave.Parameters.AddWithValue("@LOGOPATH", LogoPath)
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
                    ComSave.Parameters.AddWithValue("@USERID", Session.User.ID)
                    ComSave.ExecuteNonQuery()
                End Using
                Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                    ComReturnID.Transaction = Tran
                    _ID = ComReturnID.ExecuteScalar
                    _CreationDate = Today
                End Using
                For Each Local In Locals
                    Using ComLocalSave As New SQLiteCommand(My.Resources.CostSharingLocalInsert, Con)
                        ComLocalSave.Transaction = Tran
                        ComLocalSave.Parameters.AddWithValue("@SEQ", Local.Seq)
                        ComLocalSave.Parameters.AddWithValue("@COSTSHARINGID", ID)
                        ComLocalSave.Parameters.AddWithValue("@NAME", Local.Name)
                        ComLocalSave.Parameters.AddWithValue("@ZIPCODE", Local.ZipCode)
                        ComLocalSave.Parameters.AddWithValue("@ADDRESS", Local.Address)
                        ComLocalSave.Parameters.AddWithValue("@NUMBER", Local.Number)
                        ComLocalSave.Parameters.AddWithValue("@COMPLEMENT", Local.Complement)
                        ComLocalSave.Parameters.AddWithValue("@DISTRICT", Local.District)
                        ComLocalSave.Parameters.AddWithValue("@CITY", Local.City)
                        ComLocalSave.Parameters.AddWithValue("@STATE", Local.State)
                        ComLocalSave.Parameters.AddWithValue("@PHONE", Local.Phone)
                        ComLocalSave.Parameters.AddWithValue("@EMAIL", Local.Email)
                        ComLocalSave.ExecuteNonQuery()
                    End Using
                    Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                        ComReturnID.Transaction = Tran
                        Local.ID = ComReturnID.ExecuteScalar
                    End Using
                Next Local
                Using ComLastSeq As New SQLiteCommand(My.Resources.CostSharingLastLocalSeqUpdate, Con)
                    ComLastSeq.Transaction = Tran
                    ComLastSeq.Parameters.AddWithValue("@ID", ID)
                    ComLastSeq.Parameters.AddWithValue("@LASTLOCALSEQ", Locals.GetLastSeq)
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
                Using ComUpdateCostSharing As New SQLiteCommand(My.Resources.CostSharingUpdate, Con)
                    ComUpdateCostSharing.Transaction = Tran
                    ComUpdateCostSharing.Parameters.AddWithValue("@ID", ID)
                    ComUpdateCostSharing.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                    ComUpdateCostSharing.Parameters.AddWithValue("@LOGOPATH", LogoPath)
                    ComUpdateCostSharing.Parameters.AddWithValue("@NAME", Name)
                    ComUpdateCostSharing.Parameters.AddWithValue("@BUSINESSNAME", Businessname)
                    ComUpdateCostSharing.Parameters.AddWithValue("@DOCUMENT1", Document1)
                    ComUpdateCostSharing.Parameters.AddWithValue("@DOCUMENT2", Document2)
                    ComUpdateCostSharing.Parameters.AddWithValue("@DOCUMENT3", Document3)
                    ComUpdateCostSharing.Parameters.AddWithValue("@ZIPCODE", ZipCode)
                    ComUpdateCostSharing.Parameters.AddWithValue("@ADDRESS", Address)
                    ComUpdateCostSharing.Parameters.AddWithValue("@NUMBER", Number)
                    ComUpdateCostSharing.Parameters.AddWithValue("@COMPLEMENT", Complement)
                    ComUpdateCostSharing.Parameters.AddWithValue("@DISTRICT", District)
                    ComUpdateCostSharing.Parameters.AddWithValue("@CITY", City)
                    ComUpdateCostSharing.Parameters.AddWithValue("@STATE", State)
                    ComUpdateCostSharing.Parameters.AddWithValue("@NOTE", Note)
                    ComUpdateCostSharing.Parameters.AddWithValue("@USERID", UserID)
                    Common.DebugQuery(ComUpdateCostSharing)
                    ComUpdateCostSharing.ExecuteNonQuery()
                End Using
                Using ComSelectLocals As New SQLiteCommand(My.Resources.CostSharingLocalSelect, Con)
                    ComSelectLocals.Transaction = Tran
                    ComSelectLocals.Parameters.AddWithValue("@ID", ID)
                    Using Adp As New SQLiteDataAdapter(ComSelectLocals)
                        Adp.Fill(Table)
                    End Using
                End Using

                For Each RowDb As DataRow In Table.Rows
                    If Not Locals.AsEnumerable().Where(Function(c) c.ID.Equals(RowDb.Item("ID"))).Count() > 0 Then
                        Using ConDeleteLocal As New SQLiteCommand(My.Resources.CostSharingLocalDelete, Con)
                            ConDeleteLocal.Transaction = Tran
                            ConDeleteLocal.Parameters.AddWithValue("@ID", RowDb.Item("ID"))
                            ConDeleteLocal.Parameters.AddWithValue("@COSTSHARINGID", RowDb.Item("COSTSHARINGID"))
                            ConDeleteLocal.ExecuteNonQuery()
                        End Using
                    End If
                Next
                For Each Local As Local In Locals
                    If Local.ID = 0 Then
                        Using ComLocalSave As New SQLiteCommand(My.Resources.CostSharingLocalInsert, Con)
                            ComLocalSave.Transaction = Tran
                            ComLocalSave.Parameters.AddWithValue("@SEQ", Local.Seq)
                            ComLocalSave.Parameters.AddWithValue("@COSTSHARINGID", ID)
                            ComLocalSave.Parameters.AddWithValue("@NAME", Local.Name)
                            ComLocalSave.Parameters.AddWithValue("@ZIPCODE", Local.ZipCode)
                            ComLocalSave.Parameters.AddWithValue("@ADDRESS", Local.Address)
                            ComLocalSave.Parameters.AddWithValue("@NUMBER", Local.Number)
                            ComLocalSave.Parameters.AddWithValue("@COMPLEMENT", Local.Complement)
                            ComLocalSave.Parameters.AddWithValue("@DISTRICT", Local.District)
                            ComLocalSave.Parameters.AddWithValue("@CITY", Local.City)
                            ComLocalSave.Parameters.AddWithValue("@STATE", Local.State)
                            ComLocalSave.Parameters.AddWithValue("@PHONE", Local.Phone)
                            ComLocalSave.Parameters.AddWithValue("@EMAIL", Local.Email)
                            ComLocalSave.ExecuteNonQuery()
                        End Using
                        Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                            ComReturnID.Transaction = Tran
                            Local.ID = ComReturnID.ExecuteScalar
                        End Using
                        Using ComCostSharingLastSeqUpdate As New SQLiteCommand(My.Resources.CostSharingLastLocalSeqUpdate, Con)
                            ComCostSharingLastSeqUpdate.Transaction = Tran
                            ComCostSharingLastSeqUpdate.Parameters.AddWithValue("@ID", ID)
                            ComCostSharingLastSeqUpdate.Parameters.AddWithValue("@LASTLOCALSEQ", Local.Seq)
                            ComCostSharingLastSeqUpdate.ExecuteNonQuery()
                        End Using
                    Else
                        Using ComLocalUpdate As New SQLiteCommand(My.Resources.CostSharingLocalUpdate, Con)
                            ComLocalUpdate.Transaction = Tran
                            ComLocalUpdate.Parameters.AddWithValue("@ID", Local.ID)
                            ComLocalUpdate.Parameters.AddWithValue("@COSTSHARINGID", ID)
                            ComLocalUpdate.Parameters.AddWithValue("@NAME", Local.Name)
                            ComLocalUpdate.Parameters.AddWithValue("@ZIPCODE", Local.ZipCode)
                            ComLocalUpdate.Parameters.AddWithValue("@ADDRESS", Local.Address)
                            ComLocalUpdate.Parameters.AddWithValue("@NUMBER", Local.Number)
                            ComLocalUpdate.Parameters.AddWithValue("@COMPLEMENT", Local.Complement)
                            ComLocalUpdate.Parameters.AddWithValue("@DISTRICT", Local.District)
                            ComLocalUpdate.Parameters.AddWithValue("@CITY", Local.City)
                            ComLocalUpdate.Parameters.AddWithValue("@STATE", Local.State)
                            ComLocalUpdate.Parameters.AddWithValue("@PHONE", Local.Phone)
                            ComLocalUpdate.Parameters.AddWithValue("@EMAIL", Local.Email)
                            ComLocalUpdate.ExecuteNonQuery()
                        End Using
                    End If
                Next Local
                Tran.Commit()
                End Using
            End Using
    End Sub


    Public Sub Delete()
        Using Con As New SqliteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.CostSharingDelete, Con)
                Com.Parameters.AddWithValue("@ID", ID)
                Com.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class
