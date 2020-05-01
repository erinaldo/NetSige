Imports ControlLibrary
Public Class FrmFilter
    Private _Object As Object
    Private _Filter As Object
    Private _QueriedTextBox As QueriedBox

    Public Sub New(ByVal Obj As Object, ByVal Filter As Object, ByVal QueriedTextBox As QueriedBox)
        InitializeComponent()
        _Object = Obj
        _Filter = Filter
        _QueriedTextBox = QueriedTextBox
        _Filter.DataGrid = DgvData
        PgFilter.SelectedObject = _Filter
        _Filter.Filter
    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        _Filter.Clean
    End Sub

    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        _Filter.Filter
    End Sub

    Private Sub DgvData_SelectionChanged(sender As Object, e As EventArgs) Handles DgvData.SelectionChanged
        BtnImport.Enabled = If(DgvData.SelectedRows.Count = 1, True, False)
    End Sub

    Private Sub DgvData_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DgvData.MouseDoubleClick
        Dim ClickPlace As DataGridView.HitTestInfo = DgvData.HitTest(e.X, e.Y)
        If ClickPlace.Type = DataGridViewHitTestType.Cell Then
            BtnImport.PerformClick()
        End If
    End Sub

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click
        _QueriedTextBox.Freeze(DgvData.SelectedRows(0).Cells("ID").Value, True)
        Dispose()
    End Sub
End Class