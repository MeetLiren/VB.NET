Public Class Form1
    Dim i, j, k As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 1 To 9
            For j = 0 To 9
                For k = 0 To 9
                    If i * 100 + j * 10 + k = i ^ 3 + j ^ 3 + k ^ 3 Then
                        Label1.Text &= i * 100 + j * 10 + k & vbCrLf
                    End If
                Next
            Next
        Next
    End Sub
End Class
