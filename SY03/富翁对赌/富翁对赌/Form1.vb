Public Class Form1
    Dim i As Integer
    Dim s#
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        s = 0.01
        For i = 1 To 30

            s *= 2
        Next
        Label1.Text = s
    End Sub
End Class
