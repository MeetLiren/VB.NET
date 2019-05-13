Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String = "★★★★★★★★★★★★★★★★★★★★★"
        Dim w As String = "☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆"
        Dim i As Integer
        For i = 1 To 10

            If i Mod 2 = 0 Then
                Label1.Text &= Space(20 - 2 * i) & Mid(s, 1, i * 2 - 1) & vbCrLf
            End If
            If i Mod 2 <> 0 Then
                Label1.Text &= Space(20 - 2 * i) & Mid(w, 1, i * 2 - 1) & vbCrLf
            End If
        Next
    End Sub
End Class
