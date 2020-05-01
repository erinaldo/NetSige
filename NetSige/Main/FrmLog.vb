Imports System.Data.SQLite
Imports ControlLibrary
Public Class FrmLog
    Private _Routine As Long
    Private _Registry As Long
    Public Sub New(ByVal Routine As Common.Routines, ByVal Registry As Integer)
        InitializeComponent()
        _Routine = Routine
        _Registry = Registry
        Try
            CarregarHistorico()
            If Session.User.ID <> 1 Then
                BtnClean.Enabled = False
                BtnClean.ToolTipText = "Limpar Histórico (Somente para administradores.)"
            End If
        Catch ex As Exception
            CMessageBox.Show("ERRO0000", "Ocorreu um erro ao retornar o histórico do registo.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
        End Try
    End Sub
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Dispose()
    End Sub
    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        If CMessageBox.Show("Todo o histórico desse registro será excluido. Deseja continuar?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Using Con As New SqliteConnection(Common.ConnectionString)
                    Con.Open()
                    Using Com As New SQLiteCommand(My.Resources.HistoryDelete, Con)
                        Com.Parameters.AddWithValue("@ROUTINEID", _Routine)
                        Com.Parameters.AddWithValue("@REGISTRY", _Registry)
                        Com.ExecuteNonQuery()
                        DgvLog.DataSource = Nothing
                    End Using
                End Using
            Catch ex As Exception
                CMessageBox.Show("ERRO0000", "Ocorreu um erro ao excluir o histórico do registo.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
            End Try
        End If
    End Sub
    Private Sub CarregarHistorico()
        Dim Table As New DataTable
        Using Con As New SqliteConnection(Common.ConnectionString)
            Con.Open()
            Using Com As New SQLiteCommand(My.Resources.HistorySelect, Con)
                Com.Parameters.AddWithValue("@ROUTINEID", _Routine)
                Com.Parameters.AddWithValue("@REGISTRY", _Registry)
                Using Adp As New SQLiteDataAdapter(Com)
                    Adp.Fill(Table)
                    DgvLog.DataSource = Table
                End Using
            End Using
        End Using
    End Sub
End Class