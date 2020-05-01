Public Class FrmZipCode
    Public Sub New(ByVal Person As Person)
        InitializeComponent()
        TxtZipCode.Text = Person.ZipCode
        TxtAddress.Text = Person.Address
        TxtDistrict.Text = Person.District
        TxtCity.Text = Person.City
        TxtState.Text = Person.State
        TxtZipCode.Select(0, 0)
    End Sub

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            BtnClose.PerformClick()
        End If
    End Sub
End Class