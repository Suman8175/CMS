<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StdSearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.STDGV = New System.Windows.Forms.DataGridView()
        Me.SearchStd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.STName = New System.Windows.Forms.TextBox()
        Me.STSem = New System.Windows.Forms.ComboBox()
        Me.STDep = New System.Windows.Forms.ComboBox()
        Me.STPhone = New System.Windows.Forms.TextBox()
        Me.STDOB = New System.Windows.Forms.DateTimePicker()
        Me.STGen = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EditBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.SemUpdate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rw = New System.Windows.Forms.PictureBox()
        CType(Me.STDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.rw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'STDGV
        '
        Me.STDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.STDGV.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.STDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.STDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.STDGV.EnableHeadersVisualStyles = False
        Me.STDGV.Location = New System.Drawing.Point(369, 490)
        Me.STDGV.Name = "STDGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.STDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.STDGV.RowHeadersWidth = 51
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.STDGV.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.STDGV.RowTemplate.Height = 29
        Me.STDGV.Size = New System.Drawing.Size(1101, 331)
        Me.STDGV.TabIndex = 0
        '
        'SearchStd
        '
        Me.SearchStd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchStd.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SearchStd.Location = New System.Drawing.Point(853, 23)
        Me.SearchStd.Name = "SearchStd"
        Me.SearchStd.Size = New System.Drawing.Size(195, 36)
        Me.SearchStd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(601, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(879, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Semester"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(905, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 34)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DOB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(1185, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 34)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(585, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 34)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "PhoneNo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(1195, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 34)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Gender"
        '
        'STName
        '
        Me.STName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.STName.Location = New System.Drawing.Point(563, 154)
        Me.STName.Name = "STName"
        Me.STName.Size = New System.Drawing.Size(162, 32)
        Me.STName.TabIndex = 9
        '
        'STSem
        '
        Me.STSem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.STSem.FormattingEnabled = True
        Me.STSem.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.STSem.Location = New System.Drawing.Point(879, 153)
        Me.STSem.Name = "STSem"
        Me.STSem.Size = New System.Drawing.Size(139, 31)
        Me.STSem.TabIndex = 10
        '
        'STDep
        '
        Me.STDep.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.STDep.FormattingEnabled = True
        Me.STDep.Location = New System.Drawing.Point(1185, 153)
        Me.STDep.Name = "STDep"
        Me.STDep.Size = New System.Drawing.Size(184, 31)
        Me.STDep.TabIndex = 11
        '
        'STPhone
        '
        Me.STPhone.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.STPhone.Location = New System.Drawing.Point(563, 269)
        Me.STPhone.Name = "STPhone"
        Me.STPhone.Size = New System.Drawing.Size(162, 32)
        Me.STPhone.TabIndex = 12
        '
        'STDOB
        '
        Me.STDOB.Location = New System.Drawing.Point(817, 270)
        Me.STDOB.Name = "STDOB"
        Me.STDOB.Size = New System.Drawing.Size(250, 27)
        Me.STDOB.TabIndex = 13
        '
        'STGen
        '
        Me.STGen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.STGen.FormattingEnabled = True
        Me.STGen.Items.AddRange(New Object() {"Male", "Female"})
        Me.STGen.Location = New System.Drawing.Point(1185, 266)
        Me.STGen.Name = "STGen"
        Me.STGen.Size = New System.Drawing.Size(149, 31)
        Me.STGen.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.Search_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(1072, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'EditBtn
        '
        Me.EditBtn.BackColor = System.Drawing.Color.Transparent
        Me.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditBtn.Location = New System.Drawing.Point(489, 349)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(172, 41)
        Me.EditBtn.TabIndex = 16
        Me.EditBtn.Text = "Update"
        Me.EditBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DeleteBtn.Location = New System.Drawing.Point(849, 349)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(169, 41)
        Me.DeleteBtn.TabIndex = 17
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'SemUpdate
        '
        Me.SemUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SemUpdate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SemUpdate.Location = New System.Drawing.Point(1215, 349)
        Me.SemUpdate.Name = "SemUpdate"
        Me.SemUpdate.Size = New System.Drawing.Size(197, 41)
        Me.SemUpdate.TabIndex = 18
        Me.SemUpdate.Text = "Update Semester"
        Me.SemUpdate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(25, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 839)
        Me.Panel1.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(17, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(286, 56)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Pay Student Fees"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(17, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(286, 53)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add Student"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(3, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(247, 67)
        Me.Panel3.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(122, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 49)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "LGIC"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.LGIClogo
        Me.PictureBox3.Location = New System.Drawing.Point(14, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(110, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.back
        Me.PictureBox2.Location = New System.Drawing.Point(17, 614)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(286, 172)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.SearchStd)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(277, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1193, 72)
        Me.Panel2.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(309, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(392, 58)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Student Records"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label9.Location = New System.Drawing.Point(769, 443)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(245, 34)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Students Records"
        '
        'rw
        '
        Me.rw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rw.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.refresh
        Me.rw.Location = New System.Drawing.Point(681, 438)
        Me.rw.Name = "rw"
        Me.rw.Size = New System.Drawing.Size(86, 43)
        Me.rw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rw.TabIndex = 22
        Me.rw.TabStop = False
        '
        'StdSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 853)
        Me.Controls.Add(Me.rw)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SemUpdate)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.STGen)
        Me.Controls.Add(Me.STDOB)
        Me.Controls.Add(Me.STPhone)
        Me.Controls.Add(Me.STDep)
        Me.Controls.Add(Me.STSem)
        Me.Controls.Add(Me.STName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.STDGV)
        Me.Name = "StdSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StdSearch"
        CType(Me.STDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.rw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents STDGV As DataGridView
    Friend WithEvents SearchStd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents STName As TextBox
    Friend WithEvents STSem As ComboBox
    Friend WithEvents STDep As ComboBox
    Friend WithEvents STPhone As TextBox
    Friend WithEvents STDOB As DateTimePicker
    Friend WithEvents STGen As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents SemUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents rw As PictureBox
End Class
