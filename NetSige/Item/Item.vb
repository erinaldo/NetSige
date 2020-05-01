Imports System.ComponentModel
Imports System.Data.SQLite
Public Class Item
    Public Class Filter
        <Browsable(False)>
        Public Property DataGrid As New DataGridView
        Public Property ID As String
        <TypeConverter(GetType(StatusFilterCollection))>
        <DisplayName("Status")>
        Public Overridable Property Status As String
        <DisplayName("Nome")>
        Public Property Name As String
        <DisplayName("Unidade")>
        Public Property ItemUnit As String
        <DisplayName("Grupo")>
        Public Property ItemGroup As String
        <DisplayName("Cód. Interno")>
        Public Property InternalCode As String
        <DisplayName("Fabricante")>
        Public Property Manufacturer As String
        <DisplayName("Cód. Fabricante")>
        Public Property ManufacturerCode As String
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
                Using Com As New SQLiteCommand(My.Resources.ItemFilter, Con)
                    If ID <> Nothing Then Com.Parameters.AddWithValue("@ID", ID) : Filtering = True Else Com.Parameters.AddWithValue("@ID", "%")
                    If Status <> Nothing Then Com.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status)) : Filtering = True Else Com.Parameters.AddWithValue("@STATUSID", "%")
                    If Name <> Nothing Then Com.Parameters.AddWithValue("@NAME", Name) : Filtering = True Else Com.Parameters.AddWithValue("@NAME", "%")
                    If ItemUnit <> Nothing Then Com.Parameters.AddWithValue("@ITEMUNIT", ItemUnit) : Filtering = True Else Com.Parameters.AddWithValue("@ITEMUNIT", "%")
                    If ItemGroup <> Nothing Then Com.Parameters.AddWithValue("@ITEMGROUP", ItemGroup) : Filtering = True Else Com.Parameters.AddWithValue("@ITEMGROUP", "%")
                    If InternalCode <> Nothing Then Com.Parameters.AddWithValue("@INTERNALCODE", InternalCode) : Filtering = True Else Com.Parameters.AddWithValue("@INTERNALCODE", "%")
                    If Manufacturer <> Nothing Then Com.Parameters.AddWithValue("@MANUFACTURER", Manufacturer) : Filtering = True Else Com.Parameters.AddWithValue("@MANUFACTURER", "%")
                    If ManufacturerCode <> Nothing Then Com.Parameters.AddWithValue("@MANUFACTURERCODE", ManufacturerCode) : Filtering = True Else Com.Parameters.AddWithValue("@MANUFACTURERCODE", "%")
                    If Note <> Nothing Then Com.Parameters.AddWithValue("@NOTE", Note) : Filtering = True Else Com.Parameters.AddWithValue("@NOTE", "%")
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
            Name = Nothing
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


    Public Sub GetTransactions(ByVal Dgv As DataGridView)
        Dim Table As New DataTable
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.ItemTransactions, Con)
                Com.Parameters.AddWithValue("@ID", ID)
                Using Adp As New SQLiteDataAdapter(Com)
                    Adp.Fill(Table)
                End Using
            End Using
        End Using
        Dgv.DataSource = Table
        Dgv.Columns("PURCHASEORDER").HeaderText = "Pedido"
        Dgv.Columns("CREATIONDATE").HeaderText = "Data"
        Dgv.Columns("PERSON").HeaderText = "Pessoa"
        Dgv.Columns("UNIT").HeaderText = "Und."
        Dgv.Columns("QUANTITY").HeaderText = "Qtd."
        Dgv.Columns("PRICE").HeaderText = "Preço"
        Dgv.Columns("IPI").HeaderText = "IPI"
        Dgv.Columns("QUANTITY").DefaultCellStyle.Format = "N2"
        Dgv.Columns("QUANTITY").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dgv.Columns("PRICE").DefaultCellStyle.Format = "N2"
        Dgv.Columns("PRICE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Dgv.Columns("IPI").DefaultCellStyle.Format = "#0%"
        Dgv.Columns("IPI").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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

    Public Property PhotoPath As String


    Public Property Name As String


    Public Property ItemUnit As New ItemUnit
    Public Property ItemGroup As New ItemGroup
    Public Property InternalCode As String
    Public Property Manufacturer As String
    Public Property ManufacturerCode As String
    Public Property Note As String

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
        Dim Table As New DataTable
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.ItemSelect, Con)
                Com.Parameters.AddWithValue("@ID", Identifier)
                Using Adp As New SQLiteDataAdapter(Com)
                    Adp.Fill(Table)
                End Using
            End Using
        End Using
        If Table.Rows.Count = 1 Then
            _ID = Table.Rows(0).Item("ID").ToString
            Status = Common.SimpleStatusTypes(Table.Rows(0).Item("STATUSID"))
            _CreationDate = Table.Rows(0).Item("CREATIONDATE").ToString
            PhotoPath = Table.Rows(0).Item("PHOTOPATH").ToString
            Name = Table.Rows(0).Item("NAME").ToString
            ItemUnit = New ItemUnit(Table.Rows(0).Item("ITEMUNITID"))
            ItemGroup = New ItemGroup(Table.Rows(0).Item("ITEMGROUPID"))
            InternalCode = Table.Rows(0).Item("INTERNALCODE").ToString
            Manufacturer = Table.Rows(0).Item("MANUFACTURER").ToString
            ManufacturerCode = Table.Rows(0).Item("MANUFACTURERCODE").ToString
            Note = Table.Rows(0).Item("NOTE").ToString
            _UserID = Table.Rows(0).Item("USERID")
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
                Using ComSave As New SQLiteCommand(My.Resources.ItemInsert, Con)
                    ComSave.Transaction = Tran
                    ComSave.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                    ComSave.Parameters.AddWithValue("@CREATIONDATE", Now.ToString("yyyy-MM-dd"))
                    ComSave.Parameters.AddWithValue("@PHOTOPATH", PhotoPath)
                    ComSave.Parameters.AddWithValue("@NAME", Name)
                    ComSave.Parameters.AddWithValue("@ITEMUNIT", ItemUnit.ID)
                    ComSave.Parameters.AddWithValue("@ITEMGROUP", ItemGroup.ID)
                    ComSave.Parameters.AddWithValue("@INTERNALCODE", InternalCode)
                    ComSave.Parameters.AddWithValue("@MANUFACTURER", Manufacturer)
                    ComSave.Parameters.AddWithValue("@MANUFACTURERCODE", ManufacturerCode)
                    ComSave.Parameters.AddWithValue("@NOTE", Note)
                    ComSave.Parameters.AddWithValue("@USERID", Session.User.ID)
                    ComSave.ExecuteNonQuery()
                End Using
                Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                    ComReturnID.Transaction = Tran
                    _ID = ComReturnID.ExecuteScalar
                    _CreationDate = Today
                End Using
                Tran.Commit()
            End Using
        End Using
    End Sub

    Private Sub SaveChanges()
        Dim Table As New DataTable
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using ComUpdate As New SQLiteCommand(My.Resources.ItemUpdate, Con)
                ComUpdate.Parameters.AddWithValue("@ID", ID)
                ComUpdate.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                ComUpdate.Parameters.AddWithValue("@PHOTOPATH", PhotoPath)
                ComUpdate.Parameters.AddWithValue("@NAME", Name)
                ComUpdate.Parameters.AddWithValue("@ITEMUNIT", ItemUnit.ID)
                ComUpdate.Parameters.AddWithValue("@ITEMGROUP", ItemGroup.ID)
                ComUpdate.Parameters.AddWithValue("@INTERNALCODE", InternalCode)
                ComUpdate.Parameters.AddWithValue("@MANUFACTURER", Manufacturer)
                ComUpdate.Parameters.AddWithValue("@MANUFACTURERCODE", ManufacturerCode)
                ComUpdate.Parameters.AddWithValue("@NOTE", Note)
                ComUpdate.Parameters.AddWithValue("@USERID", UserID)
                ComUpdate.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Delete()
        Using Con As New SqliteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.ItemDelete, Con)
                Com.Parameters.AddWithValue("@ID", ID)
                Com.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class
