﻿Public Class Form1
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim menu As String = ListBoxMenu.SelectedItem
        MessageBox.Show("คุณเลือกข้าวกล่อง" & vbNewLine & menu)
    End Sub
End Class
