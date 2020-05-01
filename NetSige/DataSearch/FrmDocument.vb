Public Class FrmDocument
    Public Sub New(ByVal Person As Person)
        InitializeComponent()
        TxtName.Text = Person.Name
        TxtBusinessName.Text = Person.Businessname
        TxtDocument1.Text = Person.Document1
        TxtZipCode.Text = Person.ZipCode
        TxtAddress.Text = Person.Address
        TxtNumber.Text = Person.Number
        TxtComplement.Text = Person.Complement
        TxtDistrict.Text = Person.District
        TxtCity.Text = Person.City
        TxtState.Text = Person.State
        TxtName.Select(0, 0)
    End Sub
    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSave.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            BtnClose.PerformClick()
        End If
    End Sub

End Class