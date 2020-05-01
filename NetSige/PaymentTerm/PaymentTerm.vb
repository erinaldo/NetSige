Imports System.ComponentModel
Imports System.Data.SQLite
Public Class PaymentTerm
    Public Class Filter
        <Browsable(False)>
        Public Property DataGrid As New DataGridView
        Public Property ID As String
        <TypeConverter(GetType(StatusFilterCollection))>
        <DisplayName("Status")>
        Public Overridable Property Status As String
        <DisplayName("Nome")>
        Public Property Name As String
        <TypeConverter(GetType(TypeOfDaysFilterCollection))>
        <DisplayName("Tipo de Prazo")>
        Public Property TypeOfDays As String
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
                Using Com As New SQLiteCommand(My.Resources.PaymentTermFilter, Con)
                    If ID <> Nothing Then Com.Parameters.AddWithValue("@ID", ID) : Filtering = True Else Com.Parameters.AddWithValue("@ID", "%")
                    If Status <> Nothing Then Com.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status)) : Filtering = True Else Com.Parameters.AddWithValue("@STATUSID", "%")
                    If Name <> Nothing Then Com.Parameters.AddWithValue("@NAME", Name) : Filtering = True Else Com.Parameters.AddWithValue("@NAME", "%")
                    If TypeOfDays <> Nothing Then Com.Parameters.AddWithValue("@TYPEOFDAYSID", Common.PaymentTermTypes.IndexOf(TypeOfDays)) : Filtering = True Else Com.Parameters.AddWithValue("@TYPEOFDAYSID", "%")
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

        Private Class TypeOfDaysFilterCollection
            Inherits StringConverter
            Public Overrides Function GetStandardValuesSupported(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValuesExclusive(ByVal context As ITypeDescriptorContext) As Boolean
                Return True
            End Function
            Public Overrides Function GetStandardValues(ByVal context As ITypeDescriptorContext) As StandardValuesCollection
                Return New StandardValuesCollection(Common.PaymentTermTypes)
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
    Public Property Name As String
    Public Property TypeOfDays As String = "Dias Corridos"

    Public Property Composition As New List(Of Integer)
    Public Property CompositionTable As New DataTable

    Private _UserID As Long = Session.User.ID
    Public ReadOnly Property UserID As Long
        Get
            Return _UserID
        End Get
    End Property


    Public Sub New()
        CompositionTable.Rows.Add()
    End Sub

    Public Sub New(ByVal Identifier As Long)
        Load(Identifier)
    End Sub

    Public Sub Load(ByVal Identifier As Long)
        Dim TablePayment As New DataTable
        Dim TableComposition As New DataTable
        Dim Column As DataColumn

        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Tran As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComPayment As New SQLiteCommand(My.Resources.PaymentTermSelect, Con)
                    ComPayment.Parameters.AddWithValue("@ID", Identifier)
                    ComPayment.Transaction = Tran
                    Using Adp As New SQLiteDataAdapter(ComPayment)
                        Adp.Fill(TablePayment)
                    End Using
                End Using
                Using ComPaymentComposition As New SQLiteCommand(My.Resources.PaymentTermDaySelect, Con)
                    ComPaymentComposition.Parameters.AddWithValue("@ID", Identifier)
                    ComPaymentComposition.Transaction = Tran
                    Using Adp As New SQLiteDataAdapter(ComPaymentComposition)
                        Adp.Fill(TableComposition)
                    End Using
                End Using
                Tran.Commit()
            End Using
        End Using
        If TablePayment.Rows.Count = 1 Then
            _ID = TablePayment.Rows(0).Item("ID").ToString
            Status = Common.SimpleStatusTypes(TablePayment.Rows(0).Item("STATUSID"))
            _CreationDate = TablePayment.Rows(0).Item("CREATIONDATE").ToString
            Name = TablePayment.Rows(0).Item("NAME").ToString
            TypeOfDays = Common.PaymentTermTypes(TablePayment.Rows(0).Item("TYPEOFDAYSID"))
            _UserID = TablePayment.Rows(0).Item("USERID")

            CompositionTable = New DataTable

            CompositionTable.Rows.Add()
            For i = 0 To TableComposition.Rows.Count - 1
                Column = New DataColumn With {
                    .ColumnName = i + 1 & "ª Parcela",
                    .Caption = TableComposition.Rows(i).Item("ID")
                }
                CompositionTable.Columns.Add(Column)
                CompositionTable.Rows(0).Item(i + 1 & "ª Parcela") = TableComposition.Rows(i).Item("DAYS")
            Next i
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
                Using ComSave As New SQLiteCommand(My.Resources.PaymentTermInsert, Con)
                    ComSave.Transaction = Tran
                    ComSave.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                    ComSave.Parameters.AddWithValue("@CREATIONDATE", Now.ToString("yyyy-MM-dd"))
                    ComSave.Parameters.AddWithValue("@NAME", Name)
                    ComSave.Parameters.AddWithValue("@TYPEOFDAYSID", Common.PaymentTermTypes.IndexOf(TypeOfDays))
                    ComSave.Parameters.AddWithValue("@USERID", Session.User.ID)
                    ComSave.ExecuteNonQuery()
                End Using
                Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                    ComReturnID.Transaction = Tran
                    _ID = ComReturnID.ExecuteScalar
                    _CreationDate = Today
                End Using
                For i = 0 To CompositionTable.Columns.Count - 1
                    Using ComCompositionSave As New SQLiteCommand(My.Resources.PaymentTermDayInsert, Con)
                        ComCompositionSave.Transaction = Tran
                        ComCompositionSave.Parameters.AddWithValue("@PAYMENTTERMID", ID)
                        ComCompositionSave.Parameters.AddWithValue("@DAYS", CompositionTable.Rows(0).Item(i))
                        ComCompositionSave.ExecuteNonQuery()
                    End Using
                    Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                        ComReturnID.Transaction = Tran
                        CompositionTable.Columns(i).Caption = ComReturnID.ExecuteScalar
                    End Using
                Next i
                Tran.Commit()
            End Using
        End Using
    End Sub

    Private Sub SaveChanges()
        Dim TableDb As New DataTable
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Trans As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComUpdatePayment As New SQLiteCommand(My.Resources.PaymentTermUpdate, Con)
                    ComUpdatePayment.Transaction = Trans
                    ComUpdatePayment.Parameters.AddWithValue("@ID", ID)
                    ComUpdatePayment.Parameters.AddWithValue("@STATUSID", Common.SimpleStatusTypes.IndexOf(Status))
                    ComUpdatePayment.Parameters.AddWithValue("@NAME", Name)
                    ComUpdatePayment.Parameters.AddWithValue("@TYPEOFDAYSID", Common.PaymentTermTypes.IndexOf(TypeOfDays))
                    ComUpdatePayment.Parameters.AddWithValue("@USERID", UserID)
                    ComUpdatePayment.ExecuteNonQuery()
                End Using

                Using ComCompositionSelect As New SQLiteCommand(My.Resources.PaymentTermDaySelect, Con)
                    ComCompositionSelect.Parameters.AddWithValue("@ID", ID)
                    ComCompositionSelect.Transaction = Trans
                    Using Adp As New SQLiteDataAdapter(ComCompositionSelect)
                        Adp.Fill(TableDb)
                    End Using
                End Using



                Dim DeleteDay As Boolean = True


                For i = 0 To TableDb.Rows.Count - 1
                    For j = 0 To CompositionTable.Columns.Count - 1
                        If CompositionTable.Columns(j).Caption > 0 And CompositionTable.Columns(j).Caption = TableDb.Rows(i).Item("ID") Then
                            DeleteDay = False
                        End If
                    Next j

                    If DeleteDay = True Then

                        Using ConDeleteDays As New SQLiteCommand(My.Resources.PaymentTermDayDelete, Con)
                            ConDeleteDays.Transaction = Trans
                            ConDeleteDays.Parameters.AddWithValue("@ID", TableDb.Rows(i).Item("ID"))
                            ConDeleteDays.Parameters.AddWithValue("@PAYMENTTERMID", TableDb.Rows(i).Item("PAYMENTTERMID"))
                            ConDeleteDays.ExecuteNonQuery()
                        End Using

                    End If
                    DeleteDay = True

                Next i




                For i = 0 To CompositionTable.Columns.Count - 1

                    If CompositionTable.Columns(i).Caption = 0 Then
                        Using ComCompositionSave As New SQLiteCommand(My.Resources.PaymentTermDayInsert, Con)
                            ComCompositionSave.Transaction = Trans
                            ComCompositionSave.Parameters.AddWithValue("@PAYMENTTERMID", ID)
                            ComCompositionSave.Parameters.AddWithValue("@DAYS", CompositionTable.Rows(0).Item(i))
                            ComCompositionSave.ExecuteNonQuery()
                        End Using
                        Using ComReturnID As New SQLiteCommand(My.Resources.SqlLastID, Con)
                            ComReturnID.Transaction = Trans
                            CompositionTable.Columns(i).Caption = ComReturnID.ExecuteScalar
                        End Using
                    Else
                        Using ComCompositionUpdate As New SQLiteCommand(My.Resources.PaymentTermDayUpdate, Con)
                            ComCompositionUpdate.Transaction = Trans
                            ComCompositionUpdate.Parameters.AddWithValue("@ID", CompositionTable.Columns(i).Caption)
                            ComCompositionUpdate.Parameters.AddWithValue("@PAYMENTTERMID", ID)
                            ComCompositionUpdate.Parameters.AddWithValue("@DAYS", CompositionTable.Rows(0).Item(i))
                            ComCompositionUpdate.ExecuteNonQuery()
                        End Using
                    End If

                Next i


                Trans.Commit()
            End Using
        End Using
    End Sub

    Public Sub Delete()
        Using Con As New SqliteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.PaymentTermDelete, Con)
                Com.Parameters.AddWithValue("@ID", ID)
                Com.ExecuteNonQuery()
            End Using
        End Using
    End Sub



End Class
