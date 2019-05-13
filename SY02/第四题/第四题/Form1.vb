Public Class Form1
    Dim n As Integer
    Dim s#, i#
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n = 0
        i = 1
        s = 1
        Do While 1 / i >= 0.00001
            n += 1
            i = (i + n)
            s = s + 1 / i
        Loop
        TextBox1.Text = s
        TextBox2.Text = n
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If 1 / i > 0.00001 Then
            For n = 0 To 500
                n += 1
                i = (i + n)
                s = s + 1 / i
            Next
        End If

        TextBox3.Text = s
        TextBox4.Text = n
    End Sub
End Class
