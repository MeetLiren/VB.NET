Public Class Form1
    Dim s, i As Integer
    Dim ch, t As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        t = TextBox1.Text
        s = Len(t)

        For i = 1 To s
            ch = Mid(t, i, 1)
            If UCase(ch) >= "A" And UCase(ch) <= "Z" Then
                TextBox2.Text = ch & TextBox2.Text
            End If
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class
