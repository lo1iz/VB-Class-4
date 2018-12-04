Public Class Form1
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim message As String = ""
        For Each items In ListBoxMenu.SelectedItems
            message &= items & vbNewLine
        Next
        MessageBox.Show("คุณเลือกข้าวกล่อง " & vbNewLine & message)
    End Sub
End Class
