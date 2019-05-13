Public Class Form1
    Dim i, n As Integer
    Dim t#
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n = TextBox1.Text
        t = 2
        For i = 1 To n
            t = t * (2 * i) ^ 2 / (2 * i - 1) / (2 * i + 1)
        Next
        MsgBox(t)
        TextBox1.Focus()
    End Sub
End Class
