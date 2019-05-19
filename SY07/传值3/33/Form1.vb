Public Class Form1

    
    Sub procMin(ByRef a%(), ByRef amin%)
        Dim i, t As Integer

        'amin = a(1)
        t = UBound(a)
        amin = a(0)
        For i = 0 To t
            'MsgBox(a(i)) 
            If a(i) < amin Then
                amin = a(i)
            End If
        Next

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a%(9)
        Dim i As Integer
        ListBox1.Text = ""

        Randomize()
        For i = 0 To 9
            a(i) = Int(Rnd() * 900 - 999)
            ListBox1.Items.Add(a(i))
        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim amin As Integer
        Dim i As Integer
        Dim b%(9)

        For i = 0 To 9
            b(i) = ListBox1.Items(i)
            'MsgBox(b(i))
        Next
        'Call procMin({1, 3}, amin)
        'MsgBox(amin)
        Call procMin(b, amin)
        TextBox2.Text = amin
    End Sub

    
End Class
