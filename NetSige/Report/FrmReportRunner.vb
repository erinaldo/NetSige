Imports System.IO
Imports ControlLibrary

Public Class FrmReportRunner
    Private _ReportPath As String
    Public Sub New(ByVal ReportPath As String)
        Dim Line As String
        Dim Parameters() As String
        Dim DataTypes() As String
        Dim Comments() As String
        InitializeComponent()
        _ReportPath = ReportPath
        If File.Exists(ReportPath) Then
            Line = IO.File.ReadAllLines(ReportPath).ElementAt(2).ToString
            Line = Strings.Right(Line, Line.Length - 4)
            Parameters = Line.Split(";")
            Line = IO.File.ReadAllLines(ReportPath).ElementAt(3).ToString
            Line = Strings.Right(Line, Line.Length - 4)
            DataTypes = Line.Split(";")
            Line = IO.File.ReadAllLines(ReportPath).ElementAt(4).ToString
            Line = Strings.Right(Line, Line.Length - 4)
            Comments = Line.Split(";")
            DgvParamaters.Columns.Add("PARAMETER", "Parâmetro")
            DgvParamaters.Columns("PARAMETER").ReadOnly = True
            DgvParamaters.Columns("PARAMETER").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            DgvParamaters.Columns("PARAMETER").MinimumWidth = 100
            DgvParamaters.Columns("PARAMETER").DefaultCellStyle.BackColor = Color.WhiteSmoke
            DgvParamaters.Columns("PARAMETER").DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke
            DgvParamaters.Columns("PARAMETER").DefaultCellStyle.SelectionForeColor = Color.Black
            DgvParamaters.Columns("PARAMETER").SortMode = DataGridViewColumnSortMode.NotSortable
            DgvParamaters.Columns.Add("VALUE", "Valor")
            DgvParamaters.Columns("VALUE").SortMode = DataGridViewColumnSortMode.NotSortable
            DgvParamaters.Columns("VALUE").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            For i = 0 To Parameters.Count - 1
                DgvParamaters.Rows.Add(Parameters(i))
                DgvParamaters.Rows(DgvParamaters.Rows.Count - 1).Tag = DataTypes(i) & ";" & Comments(i)
                DgvParamaters.Rows(DgvParamaters.Rows.Count - 1).Height = 25
            Next i
        Else
            'arquivo nao existe
        End If
    End Sub
    Private Sub FrmReportRunner_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        DgvParamaters.Rows(0).Cells(1).Selected = True
        DgvParamaters.CurrentCell = DgvParamaters.Rows(0).Cells(1)
        DgvParamaters.BeginEdit(True)
        TxtComment.Text = DgvParamaters.Rows(DgvParamaters.SelectedCells(0).RowIndex).Tag.ToString.Split(";").ElementAt(1)
    End Sub
    Private Sub DgvParamaters_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvParamaters.CellClick
        If DgvParamaters.SelectedCells(0).ColumnIndex = 0 Then
            DgvParamaters.Rows(DgvParamaters.SelectedCells(0).RowIndex).Cells(1).Selected = True
            DgvParamaters.CurrentCell = DgvParamaters.Rows(DgvParamaters.SelectedCells(0).RowIndex).Cells(1)
            DgvParamaters.BeginEdit(True)
        End If
        TxtComment.Text = DgvParamaters.Rows(DgvParamaters.SelectedCells(0).RowIndex).Tag.ToString.Split(";").ElementAt(1)
    End Sub

    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles BtnRun.Click
        Dim Parameters As New List(Of Object)
        Dim Result As Report.ReportResult
        Dim DataType As String
        For i = 0 To DgvParamaters.Rows.Count - 1
            DataType = DgvParamaters.Rows(i).Tag.ToString.Split(";").ElementAt(0)
            Select Case DataType
                Case Is = "Integer"
                    If Not IsNumeric(DgvParamaters.Rows(i).Cells(1).Value) Then
                        CMessageBox.Show("Por favor informe um número inteiro.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
                        DgvParamaters.Rows(i).Cells(1).Selected = True
                        DgvParamaters.CurrentCell = DgvParamaters.Rows(i).Cells(1)
                        DgvParamaters.BeginEdit(True)
                        Exit Sub
                    Else
                        If Not CInt(DgvParamaters.Rows(i).Cells(1).Value) = DgvParamaters.Rows(i).Cells(1).Value Then
                            CMessageBox.Show("Por favor informe um número inteiro.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
                            DgvParamaters.Rows(i).Cells(1).Selected = True
                            DgvParamaters.CurrentCell = DgvParamaters.Rows(i).Cells(1)
                            DgvParamaters.BeginEdit(True)
                            Exit Sub
                        End If
                    End If
                Case Is = "String"
                    DgvParamaters.Rows(i).Cells(1).Value = CStr(DgvParamaters.Rows(i).Cells(1).Value)
                Case Is = "Date"
                    If Not IsDate(DgvParamaters.Rows(i).Cells(1).Value) Then
                        CMessageBox.Show("Por favor informe uma data válida.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
                        DgvParamaters.Rows(i).Cells(1).Selected = True
                        DgvParamaters.CurrentCell = DgvParamaters.Rows(i).Cells(1)
                        DgvParamaters.BeginEdit(True)
                        Exit Sub
                    End If
                Case Is = "Decimal"
                    If Not IsNumeric(DgvParamaters.Rows(i).Cells(1).Value) Then
                        CMessageBox.Show("Por favor informe um número.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
                        DgvParamaters.Rows(i).Cells(1).Selected = True
                        DgvParamaters.CurrentCell = DgvParamaters.Rows(i).Cells(1)
                        DgvParamaters.BeginEdit(True)
                        Exit Sub
                    End If
            End Select
            Parameters.Add(DgvParamaters.Rows(i).Cells(1).Value)
        Next i
        Cursor = Cursors.WaitCursor
        Result = Report.Compile(_ReportPath, Parameters)
        Cursor = Cursors.Default
        If Not Result.Sucesss Then
            CMessageBox.Show(Result.Message, CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
        Else

        End If

    End Sub
End Class