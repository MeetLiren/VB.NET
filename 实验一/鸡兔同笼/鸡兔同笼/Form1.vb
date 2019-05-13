Public Class Form1
    Dim x, y, m, n As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        m = TextBox1.Text
        n = TextBox2.Text
        For x = 0 To 99
            y = Val(m - x)
            If 2 * x + 4 * y = n Then
                TextBox3.Text = "鸡：" & x & "兔：" & y
            ElseIf 2 * x + 4 * y <> n Then
                MsgBox("头不对脚，你养的是怪物吧！")

            End If
            End
        Next
    End Sub
End Class
