Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim s As String
        For i = 1 To 9
            Label1.Text &= Space(10 + i) & StrDup(18 - 2 * i, Chr(64 + i)) & vbCrLf
        Next
    End Sub
End Class
