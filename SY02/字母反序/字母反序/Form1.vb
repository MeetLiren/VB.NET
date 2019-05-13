Public Class Form1
    Dim s, i As Integer
    Dim t, ch As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ch = TextBox1.Text
        s = Len(ch)

        For i = 1 To s
            t = Mid(ch, i, 1)
            If UCase(t) >= "A" And UCase(t) <= "Z" Then
                TextBox2.Text = t & TextBox2.Text
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
