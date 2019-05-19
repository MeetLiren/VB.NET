Public Class Form1
    Dim i, s, s1 As Integer
    Dim t As String
    
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        t = TextBox1.Text
        For i = 1 To t
            s += i
            s1 += s
        Next
        MsgBox(s1)
    End Sub
End Class
