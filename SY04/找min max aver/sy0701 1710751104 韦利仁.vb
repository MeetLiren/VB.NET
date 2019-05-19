Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim A%(9)
        Dim min, imin, max, imax, i, t As Integer
        min = 100
        max = 0
        Randomize()
        For i = 0 To 9
            A(i) = Int(Rnd() * 99 + 1)
            Label1.Text &= A(i) & Space(9 - Len(Trim(A(i))))
            If A(i) < min Then
                min = A(i)
                imin = i
                Label2.Text = "最小值" & A(imin)
            End If
            If A(i) > max Then
                max = A(i)
                imax = i
                Label3.Text = "最大值" & A(imax)

            End If
        Next
        

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
