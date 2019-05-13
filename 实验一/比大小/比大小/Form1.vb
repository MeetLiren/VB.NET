Public Class Form1
    Dim t, x, y, z As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        x = Val(TextBox1.Text)
        y = Val(TextBox2.Text)
        z = Val(TextBox3.Text)
        If x < y Then
            t = x
            x = y
            y = t
        End If
        If y < z Then
            t = y
            y = z
            z = t
            If x < y Then
                t = x
                x = y
                y = t
            End If
        End If
        TextBox4.Text = x & ">" & y & ">" & z
    End Sub
End Class
