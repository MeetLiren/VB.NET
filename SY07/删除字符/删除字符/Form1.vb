Public Class Form1
    Sub DeleStr(ByRef s1 As String, ByRef s2 As String)
        Dim i, j As Integer
        Dim word As String

        i = InStr(s1, s2)
        For i = 1 To Len(s1)
            If i = 0 Then
                s1 = s1
            Else
                j = InStr(s1, s2)
                If j <= i Then
                    s1 = s1
                Else
                    word = s1.Remove(j - 1, Len(s2))
                    s1 = word
                End If
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s1, s2 As String

        s1 = TextBox1.Text
        s2 = TextBox2.Text
        Call DeleStr(s1, s2)
        TextBox3.Text = s1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Focus()
    End Sub
End Class
