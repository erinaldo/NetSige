Imports System.Data.SQLite
Public Class Quotation
    Public Class QuotationProvider
        Public Property ID As Long
        Public Property Provider As New Person
        Public Property CarrierType As String = "Sem Frete"
        Public Property CarrierPrice As Decimal
        Public Property GeneralDiscout As Decimal
        Public Property GeneralExpense As Decimal
    End Class
    Public Class QuotationItem
        Public Property ID As Long
        Public Property Quantity As Decimal
        Public Property ItemUnit As New ItemUnit
        Public Property Item As New Item
        Public Property ItemGroup As New ItemGroup
        Public Property Complement As String
    End Class
    Public Class Answer
        Public Property ID As Long
        Public Property QuotationProvider As New QuotationProvider
        Public Property QuotationItem As New QuotationItem
        Public Property Price As Decimal
        Public Property ICMS As Integer
        Public Property ICMSST As Decimal
        Public Property IPI As Integer
        Public Property Discount As Decimal
        Public Property Expense As Decimal
        Public Property Note As String
    End Class

    Public ReadOnly Property Providers As New List(Of Person)
    Public ReadOnly Property Items As New List(Of Item)

    Public Property Answers As New List(Of Answer)



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
    Public Property CostCenter As String
    Public Property OfferType As String = "Por Item"
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
        Dim TableQuotation As New DataTable
        Dim TableAnswer As New DataTable
        Dim Answer As Answer

        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Tran As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                Using ComQuotationSelect As New SQLiteCommand(My.Resources.QuotationSelect, Con)
                    ComQuotationSelect.Transaction = Tran
                    ComQuotationSelect.Parameters.AddWithValue("@ID", Identifier)
                    Using Adp As New SQLiteDataAdapter(ComQuotationSelect)
                        Adp.Fill(TableQuotation)
                    End Using
                End Using
                Using ComQuotationAnswerSelect As New SQLiteCommand(My.Resources.QuotationAnswerSelect, Con)
                    ComQuotationAnswerSelect.Transaction = Tran
                    ComQuotationAnswerSelect.Parameters.AddWithValue("@ID", Identifier)
                    Using Adp As New SQLiteDataAdapter(ComQuotationAnswerSelect)
                        Adp.Fill(TableAnswer)
                    End Using
                End Using
            End Using
        End Using

        If TableQuotation.Rows.Count = 1 Then
            _ID = TableQuotation.Rows(0).Item("ID").ToString
            Status = Common.SimpleStatusTypes(TableQuotation.Rows(0).Item("STATUSID"))
            _CreationDate = TableQuotation.Rows(0).Item("CREATIONDATE").ToString
            Note = TableQuotation.Rows(0).Item("NOTE").ToString
            _UserID = TableQuotation.Rows(0).Item("USERID")

            For Each RowItem As DataRow In TableAnswer.Rows

                Answer = New Answer
                Answer.ID = RowItem.Item("ID")
                'Answer.QuotationProvider = New Provider(RowItem.Item("PROVIDERID"))
                'Answer.QuotationItem = New Item(RowItem.Item("ITEMID"))
                Answer.Note = RowItem.Item("NOTE")
                Answer.Price = RowItem.Item("PRICE")
                Answer.ICMS = RowItem.Item("ICMS")
                Answer.ICMSST = RowItem.Item("ICMSST")
                Answer.IPI = RowItem.Item("IPI")
                Answer.Discount = RowItem.Item("DISCOUNT")
                Answer.Expense = RowItem.Item("EXPENSE")
                Answers.Add(Answer)
            Next RowItem



        Else
            Throw New Exception(String.Format("O registro de ID {0} não foi encontrado.", Identifier))
        End If
    End Sub
End Class




