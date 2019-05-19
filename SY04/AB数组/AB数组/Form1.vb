Public Class Form1
    Dim A(,) As Integer = {{35, 67, 52, 50}, {33, 47, 66, 39}, {47, 56, 66, 41}, {30, 69, 55, 38}}
    Dim B(,) As Integer = {{103, 115, 125, 101}, {133, 127, 132, 135}, {111, 103, 134, 118}, {123, 109, 113, 130}}

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j, s As Integer

        For i = 0 To 3
            For j = 0 To i
                Label1.Text &= A(i, j) & Space(3 - Len(Trim(A(i, j))))

            Next
            Label1.Text &= vbCrLf
        Next
        Label1.Text &= "A数组"

        For i = 0 To 3
            Label2.Text &= Space(i * 4)
            For j = i To 3
                Label2.Text &= Space(4 - Len(Trim(B(i, j)))) & B(i, j)

            Next
            Label2.Text &= vbCrLf
        Next
        Label2.Text &= "  B数组"

        For i = 1 To 4
            For j = 1 To 4
                If i = j Or i + j = 5 Then
                    s += A(i - 1, j - 1)
                End If
            Next
        Next
        Label3.Text = "A数组对角线元素和为" & s
    End Sub
End Class
