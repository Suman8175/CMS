<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherSearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TName = New System.Windows.Forms.TextBox()
        Me.TGender = New System.Windows.Forms.ComboBox()
        Me.TDep = New System.Windows.Forms.ComboBox()
        Me.TPhone = New System.Windows.Forms.TextBox()
        Me.TDOB = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SearchTeacher = New System.Windows.Forms.TextBox()
        Me.TeacherDGV = New System.Windows.Forms.DataGridView()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pte = New System.Windows.Forms.Button()
        Me.tsc = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rq = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.rq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(588, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1124, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(867, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(1216, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(553, 302)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 27)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PhoneNo."
        '
        'TName
        '
        Me.TName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TName.Location = New System.Drawing.Point(553, 243)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(156, 32)
        Me.TName.TabIndex = 5
        '
        'TGender
        '
        Me.TGender.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TGender.FormattingEnabled = True
        Me.TGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.TGender.Location = New System.Drawing.Point(842, 244)
        Me.TGender.Name = "TGender"
        Me.TGender.Size = New System.Drawing.Size(133, 31)
        Me.TGender.TabIndex = 6
        '
        'TDep
        '
        Me.TDep.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TDep.FormattingEnabled = True
        Me.TDep.Location = New System.Drawing.Point(1124, 244)
        Me.TDep.Name = "TDep"
        Me.TDep.Size = New System.Drawing.Size(145, 31)
        Me.TDep.TabIndex = 7
        '
        'TPhone
        '
        Me.TPhone.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TPhone.Location = New System.Drawing.Point(553, 342)
        Me.TPhone.Name = "TPhone"
        Me.TPhone.Size = New System.Drawing.Size(151, 32)
        Me.TPhone.TabIndex = 8
        '
        'TDOB
        '
        Me.TDOB.Location = New System.Drawing.Point(1120, 340)
        Me.TDOB.Name = "TDOB"
        Me.TDOB.Size = New System.Drawing.Size(260, 27)
        Me.TDOB.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.Search_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(1101, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'SearchTeacher
        '
        Me.SearchTeacher.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SearchTeacher.Location = New System.Drawing.Point(733, 117)
        Me.SearchTeacher.Name = "SearchTeacher"
        Me.SearchTeacher.Size = New System.Drawing.Size(353, 36)
        Me.SearchTeacher.TabIndex = 11
        '
        'TeacherDGV
        '
        Me.TeacherDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TeacherDGV.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TeacherDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TeacherDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TeacherDGV.EnableHeadersVisualStyles = False
        Me.TeacherDGV.Location = New System.Drawing.Point(463, 540)
        Me.TeacherDGV.Name = "TeacherDGV"
        Me.TeacherDGV.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.TeacherDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.TeacherDGV.RowTemplate.Height = 29
        Me.TeacherDGV.Size = New System.Drawing.Size(993, 301)
        Me.TeacherDGV.TabIndex = 12
        '
        'EditBtn
        '
        Me.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditBtn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditBtn.Location = New System.Drawing.Point(733, 416)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(116, 40)
        Me.EditBtn.TabIndex = 13
        Me.EditBtn.Text = "Update"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteBtn.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteBtn.Location = New System.Drawing.Point(1042, 416)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(138, 40)
        Me.DeleteBtn.TabIndex = 14
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Pte)
        Me.Panel1.Controls.Add(Me.tsc)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(4, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 848)
        Me.Panel1.TabIndex = 15
        '
        'Pte
        '
        Me.Pte.BackColor = System.Drawing.Color.SteelBlue
        Me.Pte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pte.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Pte.ForeColor = System.Drawing.Color.White
        Me.Pte.Location = New System.Drawing.Point(6, 385)
        Me.Pte.Name = "Pte"
        Me.Pte.Size = New System.Drawing.Size(273, 47)
        Me.Pte.TabIndex = 3
        Me.Pte.Text = "Pay Teacher Salary"
        Me.Pte.UseVisualStyleBackColor = False
        '
        'tsc
        '
        Me.tsc.BackColor = System.Drawing.Color.SteelBlue
        Me.tsc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tsc.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tsc.ForeColor = System.Drawing.Color.White
        Me.tsc.Location = New System.Drawing.Point(4, 244)
        Me.tsc.Name = "tsc"
        Me.tsc.Size = New System.Drawing.Size(275, 45)
        Me.tsc.TabIndex = 2
        Me.tsc.Text = "Add Teacher"
        Me.tsc.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(289, 76)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.LGIClogo
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(130, 76)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.back
        Me.PictureBox2.Location = New System.Drawing.Point(19, 660)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(245, 165)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(294, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1176, 77)
        Me.Panel2.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(409, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(386, 58)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Teacher Record"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(149, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 56)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "LGIC"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(839, 495)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 37)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Teacher Record"
        '
        'rq
        '
        Me.rq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rq.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.refresh
        Me.rq.Location = New System.Drawing.Point(735, 486)
        Me.rq.Name = "rq"
        Me.rq.Size = New System.Drawing.Size(80, 48)
        Me.rq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rq.TabIndex = 19
        Me.rq.TabStop = False
        '
        'TeacherSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 853)
        Me.Controls.Add(Me.rq)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.TeacherDGV)
        Me.Controls.Add(Me.SearchTeacher)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TDOB)
        Me.Controls.Add(Me.TPhone)
        Me.Controls.Add(Me.TDep)
        Me.Controls.Add(Me.TGender)
        Me.Controls.Add(Me.TName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TeacherSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeacherSearch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.rq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TName As TextBox
    Friend WithEvents TGender As ComboBox
    Friend WithEvents TDep As ComboBox
    Friend WithEvents TPhone As TextBox
    Friend WithEvents TDOB As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SearchTeacher As TextBox
    Friend WithEvents TeacherDGV As DataGridView
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tsc As Button
    Friend WithEvents Pte As Button
    Friend WithEvents rq As PictureBox
End Class
