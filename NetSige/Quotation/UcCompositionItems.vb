Imports ControlLibrary
Public Class UcCompositionItems
    Private Sub UcCompositionItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QueriedBox.DefaultDbProvider = "System.Data.SQLite"
        QueriedBox.DefaultConnectionString = Common.ConnectionString
    End Sub

    Private Sub DtbQtd_TextChanged(sender As Object, e As EventArgs) Handles DtbQtd.TextChanged

    End Sub

    Private Sub QtbName_FreezedPrimaryKeyChanged(sender As Object) Handles QtbName.FreezedPrimaryKeyChanged
        If QtbName.FreezedPrimaryKey <> 0 Then
            BtnInclude.Enabled = True
        Else
            BtnInclude.Enabled = False
        End If
    End Sub

    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        Include()
    End Sub

    Private Sub DgvProviders_SelectionChanged(sender As Object, e As EventArgs) Handles DgvItems.SelectionChanged
        If DgvItems.SelectedRows.Count = 1 Then
            BtnRemove.Enabled = True
        Else
            BtnRemove.Enabled = False
        End If
    End Sub



    Private Sub QtbName_KeyDown(sender As Object, e As KeyEventArgs) Handles QtbName.KeyDown, DtbQtd.KeyDown, TxtComplement.KeyDown
        If e.KeyCode = Keys.Enter Then
            If QtbName.IsFreezed And DtbQtd.DecimalValue > 0 Then
                Include()
            End If
            e.Handled = True
            e.SuppressKeyPress = True
        ElseIf DgvItems.SelectedRows.Count = 1 And e.KeyCode = Keys.Delete Then
            DgvItems.Rows.RemoveAt(DgvItems.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub Include()
        Dim Item As Item
        For i = 0 To DgvItems.Rows.Count - 1
            If DgvItems.Rows(i).Tag = QtbName.FreezedPrimaryKey Then
                If CMessageBox.Show("Esse item já está na lista, deseja incluir novamente?", CMessageBox.CMessageBoxType.Question, CMessageBox.CMessageBoxButtons.YesNo) = DialogResult.No Then
                    Exit Sub
                End If
            End If
        Next i
        Item = New Item(QtbName.FreezedPrimaryKey)
        DgvItems.Rows.Add(DtbQtd.DecimalValue, Item.Name, TxtComplement.text)
        DgvItems.Rows(DgvItems.Rows.Count - 1).Tag = Item.ID
        QtbName.Clear()
        DtbQtd.Text = 0
        TxtComplement.Clear()
        DtbQtd.Select()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        DgvItems.Rows.RemoveAt(DgvItems.SelectedRows(0).Index)
    End Sub

    Private Sub DtbQtd_Enter(sender As Object, e As EventArgs) Handles DtbQtd.Enter
        DtbQtd.SelectAll()
    End Sub
End Class
