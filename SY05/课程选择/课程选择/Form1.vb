Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        ListBox1.Items.Add("C/C++程序设计")
        ListBox1.Items.Add("Java程序设计")
        ListBox1.Items.Add("Python程序设计")
        ListBox1.Items.Add("VB程序设计")
        ListBox1.Items.Add("Web程序设计")
        ListBox1.Items.Add("大学计算机基础")
        ListBox1.Items.Add("多媒体技术与应用")
        ListBox1.Items.Add("软件技术基础")
        ListBox1.Items.Add("数据库技术与应用")
        ListBox1.Items.Add("网络技术及应用")
        ListBox1.Items.Add("硬件技术及基础")
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim knt As Integer = ListBox1.Items.Count

        ListBox2.Items.Add(ListBox1.Text)
        If ListBox1.SelectedIndex = -1 Then
            ListBox2.Items.RemoveAt(ListBox2.Items.Count - 1)
            Exit Sub
        End If

        ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)

        If ListBox2.Items.Count > 3 Then
            MsgBox("只能最多选择三门课程")
            ListBox2.Items.RemoveAt(ListBox2.Items.Count - 1)
            
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'MsgBox(ListBox1.SelectedIndex)
        'ListBox2.Items.Add(ListBox1.Text)
        'ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' MsgBox(ListBox2.Items.Count)
        If ListBox2.Items.Count > 3 Then
            MsgBox("只能最多选择三门课程")
        Else
            MsgBox("选择完成")
        End If
    End Sub

    
End Class
