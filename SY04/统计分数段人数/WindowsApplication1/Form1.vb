Public Class Form1
    Dim mark(19) As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Randomize()
        For i = 1 To 20
            mark(i - 1) = Int(Rnd() * 101)
            Label1.Text &= mark(i - 1) & "  "
            If i Mod 5 = 0 Then
                Label1.Text &= vbCrLf

            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim s(9) As Integer
        Dim i, k As Integer
        For i = 0 To 19
            k = mark(i) \ 10
            Select Case k
                Case 0 To 5
                    s(5) = s(5) + 1

                Case 9 To 10
                    s(9) = s(9) + 1

                Case 6 To 8
                    s(k) = s(k) + 1
                   
            End Select

        Next
        Label2.Text &= "<60的人数有" & s(5) & vbCrLf
        Label2.Text &= "60-70的人数有" & s(6) & vbCrLf
        Label2.Text &= "70-80的人数有" & s(7) & vbCrLf
        Label2.Text &= "80-90的人数有" & s(8) & vbCrLf
        Label2.Text &= "90-100的人数有" & s(9) & vbCrLf
    End Sub
End Class
