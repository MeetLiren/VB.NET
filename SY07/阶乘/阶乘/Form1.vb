Public Class Form1
    Function f(ByVal n%) As Double


        If (n = 1) Then
            f = 1
        Else
            f = n * f(n - 1)
        End If


        'For i = 1 To m
        's2 = s2 * i
        'Next

        'j = n - m
        'For i = 1 To j
        's3 = s3 * i
        'Next


    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim m, n As Integer
        m = Val(TextBox1.Text)
        n = Val(TextBox2.Text)

        If m > n Then
            TextBox3.Text = f(m) / f(n) / f(m - n)
        Else
            TextBox3.Text = f(n) / f(m) / f(n - m)

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub
End Class
