Public Class Form1
    Dim a(100) As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Select()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        Dim i As Integer

        If Asc(e.KeyChar) = 13 Then
            a(i) = ComboBox1.Items.Add(ComboBox1.Text)
        End If


    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim t, n, max, imax, min, imin As Integer
        imax = 0
        n = ComboBox1.Items.Count
        max = 0
        min = ComboBox1.Items(0)
        For i = 0 To n - 1
            '寻找最大值
            If Val(ComboBox1.Items(i)) > max Then
                max = ComboBox1.Items(i)
                '记下最大值的下标
                imax = i
            End If
            'If Val(ComboBox1.Items(i)) < min Then
            'max = ComboBox1.Items(i)
            '记下最大值的下标
            'imin = i
            ' End If


        Next i

        t = ComboBox1.Items(n - 1)
        ComboBox1.Items(n - 1) = ComboBox1.Items(imax)
        ComboBox1.Items(imax) = t

        For i = 1 To n - 1
            '寻找最大值
            If ComboBox1.Items(i) < min Then
                min = ComboBox1.Items(i)
                '记下最大值的下标
                imin = i
            End If
        Next

        t = ComboBox1.Items(0)
        ComboBox1.Items(0) = ComboBox1.Items(imin)
        ComboBox1.Items(imin) = t


    End Sub
End Class
