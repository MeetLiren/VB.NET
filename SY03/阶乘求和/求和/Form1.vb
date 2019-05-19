Public Class Form1
    Dim i, j, n, s, t As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        n = TextBox1.Text
        For i = 2 To n Step 2
            t = 1
            For j = i To 1 Step -1

                t = t * j

            Next
        Next i
        s += t
        MsgBox(s)
    End Sub
End Class
