Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mark(5) As Integer
        Dim i, n, s As Integer


        n = 0

        For i = 0 To 5
            mark(i) = InputBox("输入第" & i + 1 & "位学生的成绩")
            n = n + mark(i)
            s = mark(i) / 5

            Label1.Text &= mark(i) & StrDup(s, "★") & vbCrLf
        Next

    End Sub
End Class
