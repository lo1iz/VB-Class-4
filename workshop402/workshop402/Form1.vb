Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxFaculty.Items.Add("คณะวิศวกรรมศาสตร์")
        ComboBoxFaculty.Items.Add("คณะเทคโนโลยีสารสนเทศ")
        ComboBoxFaculty.Items.Add("คณะบริหารธุรกิจ")
    End Sub

    Private Sub ComboBoxFaculty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFaculty.SelectedIndexChanged
        Dim EN() As String = {"สาขาวิศวกรรมยานยนต์", "สาขาวิศวกรรมการผลิต", "สาขาวิศวกรรมคอมพิวเตอร์", "สาขาวิศวกรรมไฟฟ้า"}
        Dim IT() As String = {"สาขาเทคโนโลยีสารสนเทศ", "สาขาเทคโนโลยีมัลติมิเดีย", "สาขาเทคโนโลยีสารสนเทศทางธุรกิจ"}
        Dim BA() As String = {"สาขาบริหารธุรกิจญี่ปุ่น", "สาขาการจัดการอุตสาหกรรม", "สาขาการบัญชี", "สาขาการจัดการทรัพยากรมนุษย์"}

        If ComboBoxFaculty.SelectedIndex = 0 Then
            ComboBoxMajor.Items.Clear()
            ComboBoxMajor.Items.AddRange(EN)
        ElseIf ComboBoxFaculty.SelectedIndex = 1 Then
            ComboBoxMajor.Items.Clear()
            ComboBoxMajor.Items.AddRange(IT)
        ElseIf ComboBoxFaculty.SelectedIndex = 2 Then
            ComboBoxMajor.Items.Clear()
            ComboBoxMajor.Items.AddRange(BA)
        End If

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim confirm As DialogResult
        confirm = MessageBox.Show("ยืนยันข้อมูลหรือไม่", "ยืนยันข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then

            Dim type As String = ComboBoxFaculty.SelectedItem
            Dim subject As String = ComboBoxMajor.SelectedItem
            Dim number As String = TextBoxId.Text
            Dim name As String = TextBoxName.Text

            MessageBox.Show("เลขบัตรประชาชน : " & number & vbNewLine &
                            "ชื่อ นามสกุล : " & name & vbNewLine &
                            "คณะ : " & type & vbNewLine &
                            "สาขา : " & subject)
        End If
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxId.Text = ""
        TextBoxName.Text = ""
        ComboBoxFaculty.Items.Clear()

        ComboBoxMajor.Items.Clear()
        ButtonOK.Enabled = False
        ButtonReset.Enabled = False
    End Sub

    Private Sub TextBoxId_TextChanged(sender As Object, e As EventArgs) Handles TextBoxId.TextChanged, ComboBoxMajor.SelectedIndexChanged, TextBoxId.TextChanged, TextBoxName.TextChanged
        If TextBoxId.Text <> "" And TextBoxName.Text <> "" And ComboBoxFaculty.SelectedItem <> "" And ComboBoxMajor.SelectedItem <> "" Then
            ButtonOK.Enabled = True
        ElseIf TextBoxId.Text <> "" Or TextBoxName.Text <> "" Or ComboBoxFaculty.SelectedItem <> "" Or ComboBoxMajor.SelectedItem <> "" Then
            ButtonReset.Enabled = True
        Else
            ButtonOK.Enabled = False
            ButtonReset.Enabled = False
        End If
    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub

    Private Sub ComboBoxMajor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMajor.SelectedIndexChanged

    End Sub
End Class
