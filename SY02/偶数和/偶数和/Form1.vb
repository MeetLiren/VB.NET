Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, s As Integer
        s = 0
        For i = 0 To 200 Step 2
            s = s + i
        Next
        TextBox1.Text = s

    End Sub
End Class
