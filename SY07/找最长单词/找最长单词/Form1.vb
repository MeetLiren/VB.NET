Public Class Form1

    Sub MaxLength(ByRef s, ByRef Maxword)
        Dim i, j As Integer
        Dim word As String

        i = InStr(s, " ")
        If i = 0 Then
            word = s
            If Len(Maxword) < Len(word) Then
                Maxword = word
            End If
        Else
            word = Mid(s, 1, i - 1)
            If Len(Maxword) < Len(word) Then
                Maxword = word
            End If
            s = Mid(s, i + 1)
            MaxLength(s, Maxword)
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim text, maxword As String

        text = TextBox1.Text
        maxword = ""
        Call MaxLength(text, maxword)
        TextBox2.Text = maxword
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub
End Class
