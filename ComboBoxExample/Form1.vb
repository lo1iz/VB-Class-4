Public Class Form1
    Private Sub ButtonShow_Click(sender As Object, e As EventArgs) Handles ButtonShow.Click
        Dim type As String = ComboType.SelectedItem
        Dim subject As String = ComboSubject.SelectedItem
        MessageBox.Show("ประเภทวิชา : " & type & vbNewLine &
                        "รายวิชา : " & subject)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboType.Items.Add("Lecture")
        ComboType.Items.Add("Laboratory")
    End Sub

    Private Sub ComboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboType.SelectedIndexChanged
        Dim lecture() As String = {"INT-101",
                                   "INT-103",
                                   "INT-301"}
        Dim lab() As String = {"INT-102",
                               "INT-104",
                               "INT-302"}
        If ComboType.SelectedIndex = 0 Then
            ComboSubject.Items.Clear()
            ComboSubject.Items.AddRange(lecture)
        ElseIf ComboType.SelectedIndex = 1 Then
            ComboSubject.Items.Clear()
            ComboSubject.Items.AddRange(lab)
        End If
    End Sub
End Class
