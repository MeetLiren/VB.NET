Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim i, j As Integer
        Dim a(,) As Integer

        n = Val(TextBox2.Text)
        TextBox1.Text = ""
        ReDim a(n, n)
        'For i = 0 To n
        'a(i, 0) = 1
        'a(i, i) = 1
        'MsgBox(a(i, 0))
        'TextBox1.Text &= a(i, i) & vbCrLf
        ' Next

        For i = 0 To n - 1
            For j = 0 To i
                If j = 0 Then
                    a(i, j) = 1
                ElseIf i = j Then
                    a(i, j) = 1
                Else
                    a(i, j) = a(i - 1, j - 1) + a(i - 1, j)
                End If

                TextBox1.Text &= a(i, j) & Space(4 - Len(Trim(a(i, j))))
            Next
            TextBox1.Text &= vbCrLf
        Next

    End Sub
End Class
