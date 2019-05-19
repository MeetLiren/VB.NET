Public Class Form1
    Dim i%, n%
    Dim a() As String = {"+", "-", "×", "÷"}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim I%
        n = UBound(a)
        ComboBox1.Text = "+"
        For i = 0 To n
            ComboBox1.Items.Add(a(i))
        Next
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        'Dim result As Integer
        'If ComboBox1.Text = ComboBox1.Items(0) Then
        'result = Val(TextBox1.Text) + TextBox2.Text
        'If result <> TextBox3.Text Then
        'Label2.Text &= "错误" & "答案为：" & result
        ' Else
        'Label2.Text &= result
        ' End If
        'End If
    End Sub

    
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As Integer
        If ComboBox1.Text = ComboBox1.Items(0) Then
            result = Val(TextBox1.Text) + Val(TextBox2.Text)
            If result <> TextBox3.Text Then
                Label2.Text = "错误" & "答案为：" & result
            Else
                Label2.Text = result
            End If
        End If
        If ComboBox1.Text = ComboBox1.Items(1) Then
            result = Val(TextBox1.Text) - Val(TextBox2.Text)
            If result <> TextBox3.Text Then
                Label2.Text = "错误" & "答案为：" & result
            Else
                Label2.Text = result
            End If
        End If
        If ComboBox1.Text = ComboBox1.Items(2) Then
            result = Val(TextBox1.Text) * Val(TextBox2.Text)
            If result <> TextBox3.Text Then
                Label2.Text = "错误" & "答案为：" & result
            Else
                Label2.Text = result
            End If
        End If
        If ComboBox1.Text = ComboBox1.Items(3) Then
            result = Val(TextBox1.Text) + Val(TextBox2.Text)
            If result <> TextBox3.Text Then
                Label2.Text = "错误" & "答案为：" & result
            Else
                Label2.Text = result
            End If
        End If
    End Sub
End Class
