Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, m, r, t, g As Integer
        n = Val(TextBox1.Text)
        m = Val(TextBox2.Text)

        If m < n Then
            t = m
            m = n
            n = t
        End If
        r = m Mod n
        Do While (r <> 0)
            m = n
            n = r
            r = m Mod n
        Loop
        g = n
        TextBox3.Text &= TextBox1.Text & Space(8 - Len(TextBox1.Text)) & TextBox2.Text & Space(8 - Len(TextBox2.Text)) & g & vbCrLf
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()

    End Sub
End Class
