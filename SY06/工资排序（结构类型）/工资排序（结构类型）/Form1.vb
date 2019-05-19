Public Class Form1
    Structure staffType
        Dim number As String        '工号
        Dim name As String          '姓名
        Dim salary As Integer       '工资
    End Structure
    Dim n%
    Dim staff(9) As staffType
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer

        With staff(n)
            .number = TextBox1.Text
            .name = TextBox2.Text
            .salary = TextBox3.Text

        End With

        TextBox4.Text = "工号" & Space(7) & "姓名" & Space(9) & "工资" & vbCrLf
        n = n + 1
        If n >= 10 Then
            MsgBox("最多存储10个员工的信息")
        End If
        
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        For i = 0 To n - 1
            With staff(i)

                TextBox4.Text &= .number & Space(10 - Len(Trim(.number))) & .name & Space(14 - (Len(Trim(.name)) * 2)) & .salary & vbCrLf
                'TextBox4.Text &= .number & "      " & .name & Space(6 - Len(TextBox2.Text)) & .salary & vbCrLf
                'MsgBox(Len(Trim(.name)))
            End With
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim t, i, j As Integer
        Dim t2, t1 As String
        Dim min, imin As Integer

        TextBox4.Text = "工号" & Space(7) & "姓名" & Space(9) & "工资" & vbCrLf

        For j = 0 To n
            min = staff(j).salary
            'MsgBox("min:" & staff(j).salary)
            imin = j
            For i = j + 1 To n - 1
                If staff(i).salary < min Then
                    'MsgBox("i:" & staff(i).salary)
                    min = staff(i).salary
                    imin = i

                End If
            Next



            With staff(n)                                 '此时with staff()可以不用写
                t = staff(imin).salary
                t2 = staff(imin).number
                t1 = staff(imin).name
                staff(imin).salary = staff(j).salary
                staff(imin).number = staff(j).number
                staff(imin).name = staff(j).name
                staff(j).salary = t
                staff(j).number = t2
                staff(j).name = t1

            End With
            'MsgBox(staff(0).salary)
        Next
        For i = 0 To n - 1
            TextBox4.Text &= staff(i).number & Space(10 - Len(Trim(staff(i).number))) & staff(i).name & Space(14 - (Len(Trim(staff(i).name)) * 2)) & staff(i).salary & vbCrLf

        Next i
    End Sub
End Class
