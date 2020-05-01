Imports System.ComponentModel
Imports System.Data.SQLite
Public Class User

    Public Class Filter
        <Browsable(False)>
        Public Property DataGrid As New DataGridView
        Private Shared _StatusList As New List(Of String)
        Public Property ID As String
        <DisplayName("Status")>
        <TypeConverter(GetType(StatusFilterCollection))>
        Public Overridable Property Status As String
        <DisplayName("Nome")>
        Public Property Name As String
        <DisplayName("Usuário")>
        Public Property Username As String
        <DisplayName("Telefone")>
        Public Property Phone As String
        <DisplayName("E-Mail")>
        Public Property Email As String
        <TypeConverter(GetType(ExpandableObjectConverter))>
        <DisplayName("Data de Criação")>
        Public Property CreationDate As New Dates
        Public Sub New(ByVal Grid As DataGridView)
            DataGrid = Grid
            _StatusList = New List(Of String) From {Nothing, "Ativo", "Inativo"}
        End Sub
        Public Sub New()

        End Sub
        Public Overridable Function Filter(Optional ByVal SelectedRow As Integer = 0) As Boolean
            Dim Table As New DataTable
            Dim Filtering As Boolean
            Using Con As New SQLiteConnection(Common.ConnectionString)
                Con.Open()
                Using Com As New SQLiteCommand(My.Resources.UserFilter, Con)
                    If ID <> Nothing Then Com.Parameters.AddWithValue("@ID", ID) : Filtering = True Else Com.Parameters.AddWithValue("@ID", "%")
                    If Status <> Nothing Then Com.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status)) : Filtering = True Else Com.Parameters.AddWithValue("@STATUSID", "%")
                    If Name <> Nothing Then Com.Parameters.AddWithValue("@NAME", Name) : Filtering = True Else Com.Parameters.AddWithValue("@NAME", "%")
                    If Username <> Nothing Then Com.Parameters.AddWithValue("@USERNAME", Username) : Filtering = True Else Com.Parameters.AddWithValue("@USERNAME", "%")
                    If Phone <> Nothing Then Com.Parameters.AddWithValue("@PHONE", Phone) : Filtering = True Else Com.Parameters.AddWithValue("@PHONE", "%")
                    If Email <> Nothing Then Com.Parameters.AddWithValue("@EMAIL", Email) : Filtering = True Else Com.Parameters.AddWithValue("@EMAIL", "%")
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
            Username = Nothing
            Phone = Nothing
            Email = Nothing
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
                Return New StandardValuesCollection(_StatusList)
            End Function
        End Class
        Public Class Dates
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
    Private _ID As Long
    Public ReadOnly Property ID As Long
        Get
            Return _ID
        End Get
    End Property
    Private _UserID As Long = If(Session.Logged, Session.User.ID, 0)
    Public ReadOnly Property UserID As Long
        Get
            Return _UserID
        End Get
    End Property
    Public Property Status As String = "Ativo"
    Private _CreationDate As Date
    Public ReadOnly Property CreationDate As Date
        Get
            Return _CreationDate
        End Get
    End Property
    Public Property Username As String
    Public Property Password As String
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal Identifier As Long)
        Load(Identifier)
    End Sub

    Public Sub Load(ByVal Identifier As Long)
        Dim Table As New DataTable
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.UserSelect, Con)
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
            Username = Table.Rows(0).Item("USERNAME").ToString
            Name = Table.Rows(0).Item("NAME").ToString
            Email = Table.Rows(0).Item("EMAIL").ToString
            Phone = Table.Rows(0).Item("PHONE").ToString
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
        Using Con As New SqliteConnection(Common.ConnectionString)
            Con.Open()
            Using Tra As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComSave As New SQLiteCommand(My.Resources.UserInsert, Con)
                    ComSave.Transaction = Tra
                    ComSave.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                    ComSave.Parameters.AddWithValue("@CREATIONDATE", Now.ToString("yyyy-MM-dd"))
                    ComSave.Parameters.AddWithValue("@USERNAME", Username)
                    ComSave.Parameters.AddWithValue("@PASSWORD", Cryptograph.GetMD5Hash("123mudar"))
                    ComSave.Parameters.AddWithValue("@NAME", Name)
                    ComSave.Parameters.AddWithValue("@EMAIL", Email)
                    ComSave.Parameters.AddWithValue("@PHONE", Phone)
                    ComSave.Parameters.AddWithValue("@USERID", Session.User.ID)
                    ComSave.ExecuteNonQuery()
                End Using
                Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                    ComReturnID.Transaction = Tra
                    _ID = ComReturnID.ExecuteScalar
                    _CreationDate = Today
                End Using
                Tra.Commit()
            End Using
        End Using
    End Sub

    Private Sub SaveChanges()
        Using Con As New SqliteConnection(Common.ConnectionString)
            Con.Open()
            Using ComUpdate As New SQLiteCommand(My.Resources.UserUpdate, Con)
                ComUpdate.Parameters.AddWithValue("@ID", ID)
                ComUpdate.Parameters.AddWithValue("@USERID", Session.User.ID)
                ComUpdate.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                ComUpdate.Parameters.AddWithValue("@USERNAME", Username)
                ComUpdate.Parameters.AddWithValue("@NAME", Name)
                ComUpdate.Parameters.AddWithValue("@EMAIL", Email)
                ComUpdate.Parameters.AddWithValue("@PHONE", Phone)
                ComUpdate.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub Delete()
        Using Con As New SqliteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.UserDelete, Con)
                Com.Parameters.AddWithValue("@ID", ID)
                Com.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Class