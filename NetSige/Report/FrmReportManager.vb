Imports System.Data.SQLite
Imports System.IO
Imports ControlLibrary
Public Class FrmReportManager
    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        Dim Report As IO.FileInfo
        Dim Parameter As IO.FileInfo
        If OfdReport.ShowDialog = DialogResult.OK Then
            Try
                Using Con As New SQLiteConnection(Common.ConnectionString)
                    Con.Open()
                    Using Tran As SQLiteTransaction = Con.BeginTransaction(IsolationLevel.Serializable)
                        For Each FileName In OfdReport.FileNames
                            Report = New IO.FileInfo(FileName)
                            Parameter = New IO.FileInfo(Strings.Left(FileName, FileName.Length - 4) & ".par")
                            If Report.Exists And Parameter.Exists Then
                                Report.CopyTo(Common.ReportPath & "\" & Report.Name)
                                Parameter.CopyTo(Common.ReportPath & "\" & Parameter.Name)
                                Using Com As New SQLiteCommand(My.Resources.ReportInsert, Con)
                                    Com.Transaction = Tran
                                    Com.Parameters.AddWithValue("@PATH", Common.ReportPath & "\" & Strings.Left(Report.Name, Report.Name.Length - 4))
                                    Com.ExecuteNonQuery()
                                End Using
                            Else
                                MsgBox("Não foi possível incluir o relatório " & Report.Name & ". verifique se o arquivo .par e .rep existem no caminho especificado.")
                            End If
                        Next FileName
                        Tran.Commit()
                        LoadReports()
                    End Using
                End Using
            Catch ex As Exception
                CMessageBox.Show("ERRO0000", "Ocorreu um erro incluir o relatório.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
            End Try
        End If
    End Sub

    Private Sub LoadReports()
        'Dim Table As New DataTable
        'Dim File As FileInfo
        'Dim Parameter As String
        'Try
        '    Using Con As New SQLiteConnection(Common.ConnectionString)
        '        Con.Open()
        '        Using Com = New SQLiteCommand(My.Resources.ReportSelect, Con)
        '            Using Adp As New SQLiteDataAdapter(Com)
        '                Adp.Fill(Table)





        '                For Each Row As DataRow In Table.Rows
        '                    File = New FileInfo(Row.Item("PATH") & ".par")
        '                    If File.Exists Then
        '                        Using Reader = File.OpenText
        '                            Do Until Reader.EndOfStream
        '                                Parameter = Reader.ReadLine
        '                                If Strings.Left(Parameter, 3) = "GRP" Then Row.Item("GROUP") = Strings.Right(Parameter, Parameter.Length - 4)
        '                                If Strings.Left(Parameter, 3) = "DSP" Then Row.Item("NAME") = Strings.Right(Parameter, Parameter.Length - 4)
        '                            Loop
        '                        End Using
        '                    End If
        '                Next Row
        '                DgvReports.DataSource = Table
        '                DgvReports.Columns("ID").Visible = False
        '                DgvReports.Columns("PATH").Visible = False
        '                DgvReports.Columns("REPORTDIRECT").Visible = False
        '                DgvReports.Columns("REPORTGROUP").HeaderText = "Grupo"
        '                DgvReports.Columns("NAME").HeaderText = "Nome"
        '            End Using
        '        End Using
        '    End Using
        'Catch ex As Exception
        '    CMessageBox.Show("ERRO0000", "Ocorreu um erro ao carregar os relatórios.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
        'End Try
    End Sub

    Private Sub FrmReportManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReports()
    End Sub
End Class