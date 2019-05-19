Public Class Form1

    Function prime(ByVal m)
        Dim i As Integer
        If m = 1 Then
            Return False
        Else
            For i = 2 To System.Math.Sqrt(m)
                If m Mod i = 0 Then
                    Return False
                End If
            Next
            Return True
        End If

    End Function

    Sub odd(ByRef m, ByRef odd1, ByRef odd2)
        Dim i, j As Integer

        For i = 3 To m - 1 Step 2
            For j = i To m - 1 Step 2
                If m = i + j Then
                    If prime(i) And prime(j) Then

                        odd1 = i
                        odd2 = j

                    End If

                End If
            Next
        Next
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, n As Integer
        Dim odd1, odd2 As Integer

        For i = 6 To 100
            If i Mod 2 = 0 Then
                'Call odd(i, odd1, odd2)
                'ListBox1.Items.Add(i & "=" & odd1 & "+" & odd2)
                For j = 3 To i - 1 Step 2
                    For k = j To i - 1 Step 2
                        If i = k + j Then
                            If prime(j) Then
                                If prime(k) Then
                                    odd1 = j
                                    odd2 = k
                                    ListBox1.Items.Add(i & "=" & odd1 & "+" & odd2)
                                End If
                                
                            End If

                        End If
                    Next
                Next

            End If
        Next
        'Call odd(20, odd1, odd2)
        'MsgBox(odd1, odd2)
        'If prime(3) Then
        'MsgBox("素数")
        ' Else
        'MsgBox("错误")
        'End If

        n = ListBox1.Items.Count
        TextBox1.Text = "6到100之间有" & n & "对素数和"
    End Sub
End Class
