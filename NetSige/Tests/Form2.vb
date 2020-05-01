Imports System.Data.SQLite

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As New DataTable
        Using con As New SQLiteConnection(Common.ConnectionString)
            Using com As New SQLiteCommand("select * from itemunit;", con)
                Using Adp As New SQLiteDataAdapter(com)
                    con.Open()
                    Adp.Fill(t)
                    DataGridView1.DataSource = t

                    Dim Newtable As DataTable = DataGridView1.DataSource.copy


                End Using
            End Using
        End Using
    End Sub

End Class