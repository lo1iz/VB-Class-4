<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ComboBoxFaculty = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMajor = New System.Windows.Forms.ComboBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เลขบัตรประชาชน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(153, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อ-นามสกุล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "คณะที่เลือก"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "สาขาวิชา"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(262, 85)
        Me.TextBoxId.MaxLength = 13
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(191, 20)
        Me.TextBoxId.TabIndex = 4
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(262, 124)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(191, 20)
        Me.TextBoxName.TabIndex = 5
        '
        'ComboBoxFaculty
        '
        Me.ComboBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFaculty.FormattingEnabled = True
        Me.ComboBoxFaculty.Location = New System.Drawing.Point(262, 162)
        Me.ComboBoxFaculty.Name = "ComboBoxFaculty"
        Me.ComboBoxFaculty.Size = New System.Drawing.Size(191, 21)
        Me.ComboBoxFaculty.TabIndex = 6
        '
        'ComboBoxMajor
        '
        Me.ComboBoxMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxMajor.FormattingEnabled = True
        Me.ComboBoxMajor.Location = New System.Drawing.Point(262, 194)
        Me.ComboBoxMajor.Name = "ComboBoxMajor"
        Me.ComboBoxMajor.Size = New System.Drawing.Size(191, 21)
        Me.ComboBoxMajor.TabIndex = 7
        '
        'ButtonOK
        '
        Me.ButtonOK.Enabled = False
        Me.ButtonOK.Location = New System.Drawing.Point(166, 274)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(119, 55)
        Me.ButtonOK.TabIndex = 8
        Me.ButtonOK.Text = "ยืนยัน"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Enabled = False
        Me.ButtonReset.Location = New System.Drawing.Point(325, 274)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(119, 55)
        Me.ButtonReset.TabIndex = 9
        Me.ButtonReset.Text = "ล้างข้อมูล"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 374)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ComboBoxMajor)
        Me.Controls.Add(Me.ComboBoxFaculty)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ComboBoxFaculty As ComboBox
    Friend WithEvents ComboBoxMajor As ComboBox
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonReset As Button
End Class
