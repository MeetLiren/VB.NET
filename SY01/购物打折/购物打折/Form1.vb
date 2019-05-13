Public Class Form1
    Dim x As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        x = Val(TextBox1.Text)
        If x < 1000 Then
            TextBox2.Text = x
        ElseIf 1000 <= x And x < 2000 Then
            TextBox2.Text = Val(x * 0.9)
        ElseIf 2000 <= x And x < 3000 Then
            TextBox2.Text = Val(x * 0.8)
        ElseIf x >= 3000 Then
            TextBox2.Text = Val(x * 0.7)
        End If
    End Sub
End Class
