Public Class Form1
    Function IsWs(ByVal m%)
        Dim i As Integer
        Dim s As Integer

        s = 0
        For i = 1 To m / 2
            If m Mod i = 0 Then
                s += i
            End If
        Next
        If s = m Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        Dim t As String

        Label1.Text &= "1000以内的完数为：" & vbCrLf
        For i = 1 To 1000
            If IsWs(i) Then
                Label1.Text &= i & "="
                For j = 1 To i / 2
                    If i Mod j = 0 Then
                        t &= j & "+"
                    End If
                Next
                Label1.Text &= t.Remove(Len(t) - 1, 1) & vbCrLf
            End If

        Next
    End Sub
End Class
