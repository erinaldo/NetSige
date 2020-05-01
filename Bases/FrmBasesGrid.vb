Imports ControlLibrary
Public Class FrmBasesGrid
    Private _Provider As New Provider
    Private _Filter As Provider.Filter
    Public Sub New()
        InitializeComponent()
        SplitContainer1.Panel1Collapsed = True
        SplitContainer1.SplitterDistance = 250
        SplitContainer2.Panel1Collapsed = True
        SplitContainer2.SplitterDistance = 300
        _Filter = New Provider.Filter(DgvData)
        _Filter.Filter()
        PgFilter.SelectedObject = _Filter
        PgFilter.ExpandAllGridItems()
        Common.DataGridViewDoubleBuffered(DgvData, True)
    End Sub
    Private Sub BtnInclude_Click(sender As Object, e As EventArgs) Handles BtnInclude.Click
        Dim Form As New FrmProvider(New Provider, Me)
        Form.ShowDialog()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim Form As FrmProvider
        If DgvData.SelectedRows.Count = 1 Then
            Try
                _Provider = New Provider(DgvData.SelectedRows(0).Cells("ID").Value)
                Form = New FrmProvider(_Provider, Me)
                Form.DgvContacts.DataSource = _Provider.ContactsTable
                Form.ShowDialog()
            Catch ex As Exception
                CustomMessageBox.Show("ERRO0000", "Ocorreu um erro ao carregar o registro.", CustomMessageBoxType.Error, CustomMessageBoxButtons.OK, ex)
            End Try
        End If
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If DgvData.SelectedRows.Count = 1 Then
            If CustomMessageBox.Show("Deseja excluir o registro selecionado?", CustomMessageBoxType.Question, CustomMessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    _Provider.Load((DgvData.SelectedRows(0).Cells("ID").Value))
                    Try
                        _Provider.Delete()
                        _Filter.Filter(DgvData.SelectedRows(0).Index)
                    Catch ex As Exception
                        CustomMessageBox.Show("ERRO0000", "Ocorreu um erro ao excluir o registro.", CustomMessageBoxType.Error, CustomMessageBoxButtons.OK, ex)
                    End Try
                Catch ex As Exception
                    CustomMessageBox.Show("ERRO0000", "Ocorreu um erro ao excluir o registro.", CustomMessageBoxType.Error, CustomMessageBoxButtons.OK, ex)
                End Try
            End If
        End If
    End Sub
    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        Dim SelectedRow As Integer = 0
        If DgvData.SelectedRows.Count = 1 Then
            SelectedRow = DgvData.SelectedRows(0).Index
        End If
        _Filter.Filter(SelectedRow)
    End Sub
    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click
        SplitContainer1.Panel1Collapsed = If(BtnFilter.Checked, False, True)
        SplitContainer1.SplitterDistance = 350
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dim Index As Integer = FrmMain.TabCtrlWindows.SelectedIndex
        FrmMain.TabCtrlWindows.TabPages.Remove(FrmMain.TabCtrlWindows.SelectedTab)
        If Index > 0 Then
            FrmMain.TabCtrlWindows.SelectTab(Index - 1)
        End If
    End Sub
    Private Sub BtnCloseFilter_Click(sender As Object, e As EventArgs) Handles BtnCloseFilter.Click
        SplitContainer1.Panel1Collapsed = True
        BtnFilter.Checked = False
    End Sub
    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        _Filter.Clean()
        PgFilter.Refresh()
        With LblStatus
            .Text = Nothing
            .ForeColor = Color.Black
            .Font = New Font(.Font, FontStyle.Regular)
        End With
    End Sub
    Private Sub BtnFilter2_Click(sender As Object, e As EventArgs) Handles BtnFilter2.Click
        If _Filter.Filter() = True Then
            With LblStatus
                .Text = "Filtro Ativo"
                .ForeColor = Color.Red
                .Font = New Font(.Font, FontStyle.Bold)
            End With
        Else
            With LblStatus
                .Text = Nothing
                .ForeColor = Color.Black
                .Font = New Font(.Font, FontStyle.Regular)
            End With
        End If
    End Sub
    Private Sub DgvData_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DgvData.MouseDoubleClick
        Dim ClickPlace As DataGridView.HitTestInfo = DgvData.HitTest(e.X, e.Y)
        If ClickPlace.Type = DataGridViewHitTestType.Cell Then
            BtnEdit.PerformClick()
        End If
    End Sub

    Private Sub Form_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        For i = 0 To DgvData.Rows.Count - 1
            If DgvData.Rows(i).Cells("Status").Value = "Ativo" Then
                DgvData.Rows(i).Cells("Status").Style.ForeColor = Color.Blue
            Else
                DgvData.Rows(i).Cells("Status").Style.ForeColor = Color.Red
            End If
        Next
    End Sub

    Private Sub BtnDetails_Click(sender As Object, e As EventArgs) Handles BtnDetails.Click
        SplitContainer2.Panel1Collapsed = If(BtnDetails.Checked, False, True)
    End Sub

    Private Sub DgvData_SelectionChanged(sender As Object, e As EventArgs) Handles DgvData.SelectionChanged
        Dim Provider As Provider
        Try
            If DgvData.SelectedRows.Count = 1 Then
                Provider = New Provider(DgvData.SelectedRows(0).Cells("ID").Value)
                DgvDetails.DataSource = Provider.ContactsTable
                DgvDetails.Columns(0).HeaderText = "Nome"
                DgvDetails.Columns(1).HeaderText = "Cargo"
                DgvDetails.Columns(2).HeaderText = "Telefone 1"
                DgvDetails.Columns(3).HeaderText = "Telefone 2"
                DgvDetails.Columns(4).HeaderText = "Telefone 3"
                DgvDetails.Columns(5).HeaderText = "E-Mail 1"
                DgvDetails.Columns(6).HeaderText = "E-Mail 2"
            Else
                DgvDetails.DataSource = Nothing
            End If
        Catch ex As Exception
            CustomMessageBox.Show("ERRO0000", "Ocorreu um erro ao consultar os contatos do fornecedor selecionado.", CustomMessageBoxType.Error, CustomMessageBoxButtons.OK, ex)
        End Try
    End Sub

    Private Sub BtnCloseDetails_Click(sender As Object, e As EventArgs) Handles BtnCloseDetails.Click
        SplitContainer2.Panel1Collapsed = True
        BtnDetails.Checked = False
    End Sub



End Class