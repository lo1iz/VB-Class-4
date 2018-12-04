Public Class Form1
    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim menu As String = ListBoxMenu.SelectedItem
        ListBoxOrder.Items.Add(menu)
    End Sub

    Private Sub ListBoxMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMenu.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Menu() As String = {"ข้าวกระพราหมู", "ข้าวกระเพราไก่", "ข้าวกระเพราเนื้อ", "ข้าวกระเพราทะเล", "ข้าวกระเพรามังสวิรัติ", "ข้าวกระเพราเจ", "น้ำเปล่า", "น้ำผลไม้รวม", "น้ำชา"}
        ListBoxOrder.Items.Clear()
        ListBoxMenu.Items.Clear()
        ListBoxMenu.Items.AddRange(Menu)
    End Sub

    Private Sub ButtonOut_Click(sender As Object, e As EventArgs) Handles ButtonOut.Click
        Dim menudel As String = ListBoxOrder.SelectedItem
        ListBoxOrder.Items.Remove(menudel)
    End Sub

    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        Dim message As String = ""
        For Each items In ListBoxOrder.Items
            message &= items & vbNewLine
        Next


        Dim Confirm As DialogResult
        Confirm = MessageBox.Show("ยืนยันการสั่งอาหารหรือไม่?", "ยืนยันรายการ", MessageBoxButtons.YesNo)
        If Confirm = DialogResult.Yes Then
            MessageBox.Show("รายการอาหาร" & vbNewLine & message, "รายการอาหาร", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ListBoxOrder.Items.Clear()
        End If

    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        ListBoxOrder.Items.Clear()
    End Sub
End Class
