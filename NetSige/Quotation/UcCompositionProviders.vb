Imports ControlLibrary
Public Class UcCompositionProviders
    Private Sub UcCompositionProviders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        QueriedBox.DefaultDbProvider = "System.Data.SQLite"
        QueriedBox.DefaultConnectionString = Common.ConnectionString
        QtbDocument.Dependents.Add(QtbName)
        QtbName.Dependents.Add(QtbDocument)
    End Sub

    Private Sub QtbName_FreezedPrimaryKeyChanged(sender As Object) Handles QtbName.FreezedPrimaryKeyChanged, QtbDocument.FreezedPrimaryKeyChanged
        If QtbDocument.FreezedPrimaryKey <> 0 And QtbName.FreezedPrimaryKey <> 0 Then
            BtnInclude.Enabled = True
        Else
            BtnInclude.Enabled = False
        End If
    End Sub

    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        Include()
    End Sub

    Private Sub DgvProviders_SelectionChanged(sender As Object, e As EventArgs) Handles DgvProviders.SelectionChanged
        If DgvProviders.SelectedRows.Count = 1 Then
            BtnRemove.Enabled = True
        Else
            BtnRemove.Enabled = False
        End If
    End Sub

    Private Sub QtbName_KeyDown(sender As Object, e As KeyEventArgs) Handles QtbDocument.KeyDown, QtbName.KeyDown
        If e.KeyCode = Keys.Enter Then
            If QtbName.IsFreezed Then
                Include()
            End If
            e.Handled = True
            e.SuppressKeyPress = True
        ElseIf DgvProviders.SelectedRows.Count = 1 And e.KeyCode = Keys.Delete Then
            DgvProviders.Rows.RemoveAt(DgvProviders.SelectedRows(0).Index)
        End If
    End Sub

    Private Sub Include()
        For i = 0 To DgvProviders.Rows.Count - 1
            If DgvProviders.Rows(i).Tag = QtbDocument.FreezedPrimaryKey Then
                CMessageBox.Show("Esse fornecedor já está na lista.", CMessageBox.CMessageBoxType.Information, CMessageBox.CMessageBoxButtons.OK)
                Exit Sub
            End If
        Next i
        Dim Provider As New Person(QtbDocument.FreezedPrimaryKey)
        DgvProviders.Rows.Add(Provider.Document1, Provider.Name, Provider.City, Provider.State)
        DgvProviders.Rows(DgvProviders.Rows.Count - 1).Tag = Provider.ID
        QtbDocument.Clear()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        DgvProviders.Rows.RemoveAt(DgvProviders.SelectedRows(0).Index)
    End Sub
End Class
