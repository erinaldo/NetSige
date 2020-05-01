Imports System.Data.SQLite
Public Class Common
    Public Shared SessionPath As String = Application.StartupPath & "\Session"
    Public Shared DatabasePath As String = Application.StartupPath & "\Data"
    Public Shared ItemImagesPath As String = Application.StartupPath & "\Item"
    Public Shared LogoImagesPath As String = Application.StartupPath & "\Logo"
    Public Shared ReportPath As String = Application.StartupPath & "\Report"
    Public Shared QuotationFilesPath As String = Application.StartupPath & "\Quotation"
    Public Shared ConnectionString As String = "Data Source=" & DatabasePath & "\pm.db;Version=3;UTF8Encoding=True;foreign keys=true;"

    Public Enum Routines
        Order = 0
        Quotation = 1
        Person = 2
        Item = 3
        ItemGroup = 4
        ItemUnit = 5
        CostSharing = 6
        PaymentTerm = 7
        User = 8
        Privileges = 9
        Report = 10
        Dashboard = 11
    End Enum


    Public Shared SimpleStatusTypes As New List(Of String) From {
        "Ativo",
        "Inativo"
    }
    'Public Shared QuotationStatusTypes As New List(Of String) From {
    '    "Pendente",
    '    "Incompleta",
    '    "Calculada",
    '    "Cancelada"
    '}
    'Public Shared QuotationOfferTypes As New List(Of String) From {
    '    "Por Item",
    '    "Global"
    '}
    Public Shared PersonEntityTypes As New List(Of String) From {
        "Pessoa Física",
        "Pessoa Jurídica"
    }
    Public Shared PersonCategoryTypes As New List(Of String) From {
        "Fornecedor",
        "Cliente",
        "Transportadora"
    }
    Public Shared PaymentTermTypes As New List(Of String) From {
        "Dias Úteis",
        "Dias Corridos"
    }
    Public Shared OrderStatusTypes As New List(Of String) From {
        "Pendente",
        "Parc. Recebido",
        "Recebido",
        "Cancelado"
    }
    Public Shared CarrierTypes As New List(Of String) From {
        "Sem Frete",
        "CIF",
        "FOB",
        "Terceiro"
    }
    Public Shared YesNoTypes As New List(Of String) From {
        "Não",
        "Sim"
    }
    Public Shared Sub DataGridViewDoubleBuffered(ByVal dgv As DataGridView, ByVal setting As Boolean)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As Reflection.PropertyInfo = dgvType.GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        pi.SetValue(dgv, setting, Nothing)
    End Sub

    'Public Shared Sub SetDoubleBuffered(ByVal c As System.Windows.Forms.Control)
    '    If System.Windows.Forms.SystemInformation.TerminalServerSession Then Return
    '    Dim aProp As System.Reflection.PropertyInfo = GetType(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance)
    '    aProp.SetValue(c, True, Nothing)
    'End Sub

    Public Shared Sub DebugQuery(ByVal Command As SQLiteCommand)
        Dim Query As String = Command.CommandText
        For Each Parameter As SQLiteParameter In Command.Parameters
            Query = Query.Replace(Parameter.ParameterName, "'" & Parameter.Value & "'")
        Next
        Debug.Print(Query)
    End Sub

    Public Shared Function IsDocumentValid(ByVal Document As String, ByVal DocumentType As String) As Boolean
        Dim DadosArray() As String
        Dim N1, N2 As Integer
        Dim Number(13) As Integer
        Dim Sum As Integer
        Dim Result1 As Integer
        Dim Result2 As Integer
        Select Case DocumentType
            Case Is = "CPF"
                DadosArray = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44",
                                  "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}
                Document = Trim(Document)
                For i = 0 To DadosArray.Length - 1
                    If Document.Length <> 14 Or DadosArray(i).Equals(Document) Then
                        Return False
                    End If
                Next
                Document = Document.Replace(".", Nothing).Replace("-", Nothing).Replace("/", Nothing)
                If Document = "00000000000" Then Return False
                For x = 0 To 1
                    N1 = 0
                    For i = 0 To 8 + x
                        N1 = N1 + Val(Document.Substring(i, 1)) * (10 + x - i)
                    Next
                    N2 = 11 - (N1 - (Int(N1 / 11) * 11))
                    If N2 = 10 Or N2 = 11 Then N2 = 0
                    If N2 <> Val(Document.Substring(9 + x, 1)) Then
                        Return False
                    End If
                Next
                Return True
            Case Is = "CNPJ"
                DadosArray = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44",
                                  "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}
                Document = Trim(Document)
                For i = 0 To DadosArray.Length - 1
                    If Document.Length <> 18 Or DadosArray(i).Equals(Document) Then
                        Return False
                    End If
                Next
                Document = Document.Substring(0, 2) + Document.Substring(3, 3) + Document.Substring(7, 3) + Document.Substring(11, 4) + Document.Substring(16)
                If Document = "00000000000000" Then Return False
                For i = 0 To Number.Length - 1
                    Number(i) = CInt(Document.Substring(i, 1))
                Next
                Sum = Number(0) * 5 + Number(1) * 4 + Number(2) * 3 + Number(3) * 2 + Number(4) * 9 + Number(5) * 8 + Number(6) * 7 +
                       Number(7) * 6 + Number(8) * 5 + Number(9) * 4 + Number(10) * 3 + Number(11) * 2
                Sum = Sum - (11 * (Int(Sum / 11)))
                If Sum = 0 Or Sum = 1 Then
                    Result1 = 0
                Else
                    Result1 = 11 - Sum
                End If
                If Result1 = Number(12) Then
                    Sum = Number(0) * 6 + Number(1) * 5 + Number(2) * 4 + Number(3) * 3 + Number(4) * 2 + Number(5) * 9 + Number(6) * 8 +
                             Number(7) * 7 + Number(8) * 6 + Number(9) * 5 + Number(10) * 4 + Number(11) * 3 + Number(12) * 2
                    Sum = Sum - (11 * (Int(Sum / 11)))
                    If Sum = 0 Or Sum = 1 Then
                        Result2 = 0
                    Else
                        Result2 = 11 - Sum
                    End If
                    If Result2 = Number(13) Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
        End Select
        Return False
    End Function
End Class