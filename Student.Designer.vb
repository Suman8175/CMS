<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.paybhn = New System.Windows.Forms.Button()
        Me.srbtn = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StNameTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GenCb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DepCb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StPhoneTb = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SemCb = New System.Windows.Forms.ComboBox()
        Me.StudentDGV = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rfr = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rfr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.paybhn)
        Me.Panel1.Controls.Add(Me.srbtn)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 888)
        Me.Panel1.TabIndex = 0
        '
        'paybhn
        '
        Me.paybhn.BackColor = System.Drawing.Color.SteelBlue
        Me.paybhn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paybhn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.paybhn.ForeColor = System.Drawing.Color.White
        Me.paybhn.Location = New System.Drawing.Point(16, 508)
        Me.paybhn.Name = "paybhn"
        Me.paybhn.Size = New System.Drawing.Size(287, 47)
        Me.paybhn.TabIndex = 14
        Me.paybhn.Text = "Pay Student Fees"
        Me.paybhn.UseVisualStyleBackColor = False
        '
        'srbtn
        '
        Me.srbtn.BackColor = System.Drawing.Color.SteelBlue
        Me.srbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.srbtn.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.srbtn.ForeColor = System.Drawing.Color.White
        Me.srbtn.Location = New System.Drawing.Point(16, 401)
        Me.srbtn.Name = "srbtn"
        Me.srbtn.Size = New System.Drawing.Size(287, 44)
        Me.srbtn.TabIndex = 13
        Me.srbtn.Text = "Search Student"
        Me.srbtn.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(13, 706)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(279, 130)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 101)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(303, 251)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(13, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 76)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(134, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 62)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LGIC"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(310, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1173, 87)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(984, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(391, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 64)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Students"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(362, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'StNameTb
        '
        Me.StNameTb.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StNameTb.Location = New System.Drawing.Point(326, 159)
        Me.StNameTb.Name = "StNameTb"
        Me.StNameTb.Size = New System.Drawing.Size(199, 36)
        Me.StNameTb.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(1039, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 37)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gender"
        '
        'GenCb
        '
        Me.GenCb.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GenCb.FormattingEnabled = True
        Me.GenCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenCb.Location = New System.Drawing.Point(1017, 285)
        Me.GenCb.Name = "GenCb"
        Me.GenCb.Size = New System.Drawing.Size(151, 35)
        Me.GenCb.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(362, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 37)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DOB"
        '
        'StDOB
        '
        Me.StDOB.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StDOB.Location = New System.Drawing.Point(314, 281)
        Me.StDOB.Name = "StDOB"
        Me.StDOB.Size = New System.Drawing.Size(406, 36)
        Me.StDOB.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(857, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 37)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Department"
        '
        'DepCb
        '
        Me.DepCb.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DepCb.FormattingEnabled = True
        Me.DepCb.Location = New System.Drawing.Point(874, 158)
        Me.DepCb.Name = "DepCb"
        Me.DepCb.Size = New System.Drawing.Size(151, 35)
        Me.DepCb.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(1139, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 37)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "PhoneNo."
        '
        'StPhoneTb
        '
        Me.StPhoneTb.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.StPhoneTb.Location = New System.Drawing.Point(1125, 158)
        Me.StPhoneTb.Name = "StPhoneTb"
        Me.StPhoneTb.Size = New System.Drawing.Size(199, 36)
        Me.StPhoneTb.TabIndex = 11
        '
        'SaveBtn
        '
        Me.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveBtn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SaveBtn.Location = New System.Drawing.Point(761, 341)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(214, 51)
        Me.SaveBtn.TabIndex = 15
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(635, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 37)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Semester"
        '
        'SemCb
        '
        Me.SemCb.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SemCb.FormattingEnabled = True
        Me.SemCb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.SemCb.Location = New System.Drawing.Point(635, 160)
        Me.SemCb.Name = "SemCb"
        Me.SemCb.Size = New System.Drawing.Size(151, 35)
        Me.SemCb.TabIndex = 18
        '
        'StudentDGV
        '
        Me.StudentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentDGV.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.StudentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentDGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.StudentDGV.EnableHeadersVisualStyles = False
        Me.StudentDGV.Location = New System.Drawing.Point(326, 472)
        Me.StudentDGV.Name = "StudentDGV"
        Me.StudentDGV.RowHeadersWidth = 55
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.StudentDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.StudentDGV.RowTemplate.Height = 29
        Me.StudentDGV.Size = New System.Drawing.Size(1133, 401)
        Me.StudentDGV.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label10.Location = New System.Drawing.Point(761, 432)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(251, 37)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Student Records"
        '
        'rfr
        '
        Me.rfr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rfr.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.refresh
        Me.rfr.Location = New System.Drawing.Point(697, 432)
        Me.rfr.Name = "rfr"
        Me.rfr.Size = New System.Drawing.Size(58, 37)
        Me.rfr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rfr.TabIndex = 21
        Me.rfr.TabStop = False
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 953)
        Me.Controls.Add(Me.rfr)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.StudentDGV)
        Me.Controls.Add(Me.SemCb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.StPhoneTb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DepCb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.StDOB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GenCb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StNameTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rfr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents paybhn As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StNameTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GenCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents StDOB As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents DepCb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents StPhoneTb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SemCb As ComboBox
    Friend WithEvents StudentDGV As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents srbtn As Button
    Friend WithEvents rfr As PictureBox
End Class
