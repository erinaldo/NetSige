Public Class Cryptograph
    Shared ReadOnly Password As String = "+JJ>V\`ly7&VQFJOfwH+B,?@wU5]d9Adz](}HQO,"
    Shared SaltBytes() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
    Public Shared Function Encrypt(ByVal PlainText As String) As String
        Dim TextString As Byte() = Text.Encoding.Default.GetBytes(PlainText)
        Dim RijndaelCipher As Security.Cryptography.RijndaelManaged = New Security.Cryptography.RijndaelManaged()
        Dim SecretKey As Security.Cryptography.Rfc2898DeriveBytes = New Security.Cryptography.Rfc2898DeriveBytes(Password, SaltBytes, 1000)
        Dim Encryptor As Security.Cryptography.ICryptoTransform = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16))
        Dim memoryStream As IO.MemoryStream = New IO.MemoryStream()
        Dim encStream As Security.Cryptography.CryptoStream = New Security.Cryptography.CryptoStream(memoryStream, Encryptor, Security.Cryptography.CryptoStreamMode.Write)
        encStream.Write(TextString, 0, TextString.Length)
        encStream.FlushFinalBlock()
        Dim CipherBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        encStream.Close()
        Return Convert.ToBase64String(CipherBytes)
    End Function
    Public Shared Function Decrypt(ByVal PlainText As String) As String
        Dim TextString As Byte() = Convert.FromBase64String(PlainText)
        Dim RijndaelCipher As Security.Cryptography.RijndaelManaged = New Security.Cryptography.RijndaelManaged()
        Dim SecretKey As Security.Cryptography.Rfc2898DeriveBytes = New Security.Cryptography.Rfc2898DeriveBytes(Password, SaltBytes, 1000)
        Dim decryptor As Security.Cryptography.ICryptoTransform = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16))
        Dim memoryStream As IO.MemoryStream = New IO.MemoryStream(TextString)
        Dim cryptoStream As Security.Cryptography.CryptoStream = New Security.Cryptography.CryptoStream(memoryStream, decryptor, Security.Cryptography.CryptoStreamMode.Read)
        TextString = New Byte(TextString.Length - 1) {}
        Dim DecryptedCount As Integer = cryptoStream.Read(TextString, 0, TextString.Length)
        memoryStream.Close()
        cryptoStream.Close()
        Return Text.Encoding.Default.GetString(TextString)
    End Function
    Public Shared Function GetMD5Hash(ByVal TextString As String) As String
        Using Hasher As Security.Cryptography.MD5 = Security.Cryptography.MD5.Create()
            Dim Bytes As Byte() = Hasher.ComputeHash(Text.Encoding.UTF8.GetBytes(TextString))
            Dim SBuilder As New Text.StringBuilder()
            For n As Integer = 0 To Bytes.Length - 1
                SBuilder.Append(Bytes(n).ToString("X2"))
            Next n
            Return SBuilder.ToString()
        End Using
    End Function
End Class
