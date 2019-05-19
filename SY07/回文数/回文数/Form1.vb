Public Class Form1

    Function IsH(ByVal n)
        Dim t, c1, c2 As String
        Dim i, c As Integer

        t = Trim(Str(n))

        '错误写法，想偷懒不写for循环，整个算法全部错误，愚蠢至极，愚蠢至极
        'If Len(t) = 1 Then
        'rn True
        'ElseIf Len(t) Mod 2 = 0 Then
        'MsgBox(Len(t) \ 2)
        'c1 = Mid(t, 1, Len(t) \ 2)
        'c2 = Mid(t, Len(t) \ 2 + 1, Len(t))
        'If c1 = c2 Then
        'Return True
        'Else
        'Return False
        ' End If
        'Else
        'MsgBox(Len(t) / 2)
        'c1 = Mid(t, 1, Len(t) \ 2)
        'c2 = Mid(t, Len(t) \ 2 + 2, Len(t))
        'If c1 = c2 Then
        'Return True
        'Else
        'Return False
        ' End If
        'End If

        c2 = ""
        c = Len(t)
        If c Mod 2 = 0 Then
            c1 = Mid(t, 1, Len(t) \ 2)
            For i = c To c \ 2 + 1 Step -1
                c2 &= Mid(t, i, 1)
            Next
            If c1 = c2 Then
                Return True
            Else
                Return False
            End If
        Else
            c1 = Mid(t, 1, Len(t) \ 2)
            For i = c To c \ 2 + 2 Step -1
                c2 &= Mid(t, i, 1)
                If c1 = c2 Then
                    Return True
                Else
                    Return False
                End If
            Next
        End If
    End Function



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n As Integer

        If TextBox1.Text = "" Then
            MsgBox("请输入数值")
        End If
        n = Str(TextBox1.Text)
        
        If IsH(n) Then
            TextBox2.Text &= n & "    " & "★" & vbCrLf
        Else
            TextBox2.Text &= n & vbCrLf
        End If
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub
End Class
