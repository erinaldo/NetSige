Imports System.Data.SQLite
Public Class Session
    Private Shared _User As User
    Private Shared _StartTime As Date = Nothing
    Private Shared _EndTime As Date = Nothing
    Private Shared _FoundUser As Boolean = False
    Private Shared _CorrectPassword As Boolean = False
    Private Shared _Logged As Boolean = False

    Public Shared ReadOnly Property StartTime As Date
        Get
            Return _StartTime
        End Get
    End Property
    Public Shared ReadOnly Property EndTime As Date
        Get
            Return _EndTime
        End Get
    End Property
    Public Shared ReadOnly Property FoundUser As Boolean
        Get
            Return _FoundUser
        End Get
    End Property
    Public Shared ReadOnly Property CorrectPassword As Boolean
        Get
            Return _CorrectPassword
        End Get
    End Property
    Public Shared ReadOnly Property Logged As Boolean
        Get
            Return _Logged
        End Get
    End Property
    Public Shared ReadOnly Property User As User
        Get
            Return _User
        End Get
    End Property


    Public Shared Sub Login(ByVal Username As String, ByVal Password As String)
        Dim Table As New DataTable
        Dim SavedPassword As String
        Dim TypedPassword As String = Cryptograph.GetMD5Hash(Password)
        Using Con As New SQLiteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.SessionCheckUser, Con)
                Com.Parameters.AddWithValue("@USERNAME", Username)
                Using Adp As New SQLiteDataAdapter(Com)
                    Adp.Fill(Table)
                End Using
            End Using
        End Using
        If Table.Rows.Count = 0 Then
            _FoundUser = False
        Else
            _FoundUser = True
            SavedPassword = Table.Rows(0).Item("PASSWORD").ToString
            If SavedPassword = TypedPassword Then
                _CorrectPassword = True

                _User = New User(Table.Rows(0).Item("ID"))
                _StartTime = Now
                _Logged = True
            Else
                _CorrectPassword = False
                _User = Nothing
                _StartTime = Nothing
                _Logged = False
            End If
        End If
    End Sub

    Public Shared Sub Logout()
        If Logged Then
            _EndTime = Now
            Using Writer = New IO.StreamWriter(Common.SessionPath & "\" & Session.User.Username & " - " & Session.StartTime.ToString("dd.MM.yyyy HH.mm.ss") & " - " & Session.EndTime.ToString("dd.MM.yyyy HH.mm.ss"), True, Text.Encoding.UTF8)
            End Using
            _Logged = False
            _CorrectPassword = False
            _FoundUser = False
            _StartTime = Nothing
            _EndTime = Nothing
            _User = Nothing
        Else
            Throw New Exception("Ainda não foi feito um login.")
        End If

    End Sub


End Class
