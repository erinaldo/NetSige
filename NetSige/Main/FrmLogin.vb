Imports ControlLibrary

Public Class FrmLogin
    Private Sub FrmLogin_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawLine(Pens.LightSteelBlue, New Point(10, 65), New Point(296, 65))
        e.Graphics.DrawLine(Pens.LightSteelBlue, New Point(130, 108), New Point(296, 108))
        e.Graphics.DrawLine(Pens.LightSteelBlue, New Point(130, 140), New Point(296, 140))
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            Session.Login(TxtUsername.Text, TxtPassword.Text)
            If Session.FoundUser Then
                If Session.CorrectPassword Then
                    Hide()
                    QueriedBox.DefaultConnectionString = Common.ConnectionString
                    QueriedBox.DefaultDbProvider = "System.Data.SQLite"
                    CMessageBox.CMessageBoxStyle.TitleFont = New Font("Century Gothic", 9.75, FontStyle.Bold)
                    CMessageBox.CMessageBoxStyle.MessageFont = New Font("Century Gothic", 9.75, FontStyle.Regular)
                    'CMessageBox.Show("Falha no Login", "Usuário não encontrado.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
                    If Not IO.Directory.Exists(Common.DatabasePath) Then IO.Directory.CreateDirectory(Common.DatabasePath)
                    If Not IO.Directory.Exists(Common.SessionPath) Then IO.Directory.CreateDirectory(Common.SessionPath)
                    If Not IO.Directory.Exists(Common.ItemImagesPath) Then IO.Directory.CreateDirectory(Common.ItemImagesPath)
                    If Not IO.Directory.Exists(Common.LogoImagesPath) Then IO.Directory.CreateDirectory(Common.LogoImagesPath)
                    If Not IO.Directory.Exists(Common.QuotationFilesPath) Then IO.Directory.CreateDirectory(Common.QuotationFilesPath)
                    If Not IO.Directory.Exists(Common.ReportPath) Then IO.Directory.CreateDirectory(Common.ReportPath)
                    FrmMain.Show()
                    'Form1.Show()
                Else
                    CMessageBox.Show("Falha no Login", "Senha incorreta.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
                End If
            Else
                CMessageBox.Show("Falha no Login", "Usuário não encontrado.", CMessageBox.CMessageBoxType.Warning, CMessageBox.CMessageBoxButtons.OK)
            End If
        Catch ex As Exception
            CMessageBox.Show("ERRO0000", "Ocorreu um erro ao acessar os dados.", CMessageBox.CMessageBoxType.Error, CMessageBox.CMessageBoxButtons.OK, ex)
        End Try
    End Sub

    Private Sub TxtUsernameTxtPassword_TextChanged(sender As Object, e As EventArgs) Handles TxtUsername.TextChanged, TxtPassword.TextChanged
        If TxtUsername.Text = Nothing Or TxtPassword.Text = Nothing Then
            BtnLogin.Enabled = False
        Else
            BtnLogin.Enabled = True
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnLogin.Enabled = True
    End Sub
End Class
