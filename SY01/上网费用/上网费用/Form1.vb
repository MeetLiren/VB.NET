Public Class Form1
    Dim x As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        x = Val(TextBox1.Text)
        If x < 10 Then
            TextBox2.Text = 30
        ElseIf x >= 10 And x < 50 Then
            TextBox2.Text = Val(x * 2.5)
        ElseIf x > 50 Then
            TextBox2.Text = Val(x * 2)
            If TextBox2.Text > 150 Then
                TextBox2.Text = 150
            End If
        End If
    End Sub
End Class
