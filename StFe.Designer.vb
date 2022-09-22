<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StFe
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
        Me.StFeesP = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SrSt = New System.Windows.Forms.Button()
        Me.Adst = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bb = New System.Windows.Forms.PictureBox()
        Me.SerchBx = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StName = New System.Windows.Forms.Label()
        Me.StSem = New System.Windows.Forms.Label()
        Me.StDep = New System.Windows.Forms.Label()
        Me.StCurrentFees = New System.Windows.Forms.Label()
        Me.StOldFees = New System.Windows.Forms.Label()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.Paid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PaymentBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.StFeesP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StFeesP
        '
        Me.StFeesP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StFeesP.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StFeesP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.StFeesP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StFeesP.EnableHeadersVisualStyles = False
        Me.StFeesP.GridColor = System.Drawing.Color.White
        Me.StFeesP.Location = New System.Drawing.Point(289, 640)
        Me.StFeesP.Name = "StFeesP"
        Me.StFeesP.RowHeadersWidth = 51
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.StFeesP.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.StFeesP.RowTemplate.Height = 29
        Me.StFeesP.Size = New System.Drawing.Size(1064, 188)
        Me.StFeesP.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.SrSt)
        Me.Panel1.Controls.Add(Me.Adst)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.bb)
        Me.Panel1.Location = New System.Drawing.Point(12, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 836)
        Me.Panel1.TabIndex = 1
        '
        'SrSt
        '
        Me.SrSt.BackColor = System.Drawing.Color.SteelBlue
        Me.SrSt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SrSt.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SrSt.ForeColor = System.Drawing.Color.White
        Me.SrSt.Location = New System.Drawing.Point(14, 340)
        Me.SrSt.Name = "SrSt"
        Me.SrSt.Size = New System.Drawing.Size(252, 47)
        Me.SrSt.TabIndex = 3
        Me.SrSt.Text = "Search Student"
        Me.SrSt.UseVisualStyleBackColor = False
        '
        'Adst
        '
        Me.Adst.BackColor = System.Drawing.Color.SteelBlue
        Me.Adst.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Adst.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Adst.ForeColor = System.Drawing.Color.White
        Me.Adst.Location = New System.Drawing.Point(14, 241)
        Me.Adst.Name = "Adst"
        Me.Adst.Size = New System.Drawing.Size(252, 52)
        Me.Adst.TabIndex = 2
        Me.Adst.Text = "Add Student"
        Me.Adst.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(263, 68)
        Me.Panel3.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(125, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 47)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "LGIC"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.LGIClogo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(101, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'bb
        '
        Me.bb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bb.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.back
        Me.bb.Location = New System.Drawing.Point(14, 661)
        Me.bb.Name = "bb"
        Me.bb.Size = New System.Drawing.Size(228, 132)
        Me.bb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bb.TabIndex = 0
        Me.bb.TabStop = False
        '
        'SerchBx
        '
        Me.SerchBx.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SerchBx.Location = New System.Drawing.Point(399, 109)
        Me.SerchBx.Name = "SerchBx"
        Me.SerchBx.Size = New System.Drawing.Size(385, 32)
        Me.SerchBx.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.CollegeMgmtSoftware.My.Resources.Resources.Search_Icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(801, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(419, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(687, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 27)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Student Semester"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(969, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Student Department"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(384, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Current Semester Fees"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(664, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Previous Remaining Fees"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(1004, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 27)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Total Fees"
        '
        'StName
        '
        Me.StName.BackColor = System.Drawing.Color.LightSkyBlue
        Me.StName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StName.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.StName.Location = New System.Drawing.Point(419, 262)
        Me.StName.Name = "StName"
        Me.StName.Size = New System.Drawing.Size(160, 37)
        Me.StName.TabIndex = 10
        '
        'StSem
        '
        Me.StSem.BackColor = System.Drawing.Color.LightSkyBlue
        Me.StSem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StSem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StSem.Location = New System.Drawing.Point(707, 261)
        Me.StSem.Name = "StSem"
        Me.StSem.Size = New System.Drawing.Size(160, 37)
        Me.StSem.TabIndex = 11
        '
        'StDep
        '
        Me.StDep.BackColor = System.Drawing.Color.LightSkyBlue
        Me.StDep.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StDep.Location = New System.Drawing.Point(982, 263)
        Me.StDep.Name = "StDep"
        Me.StDep.Size = New System.Drawing.Size(160, 37)
        Me.StDep.TabIndex = 12
        '
        'StCurrentFees
        '
        Me.StCurrentFees.BackColor = System.Drawing.Color.LightSkyBlue
        Me.StCurrentFees.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StCurrentFees.Location = New System.Drawing.Point(419, 385)
        Me.StCurrentFees.Name = "StCurrentFees"
        Me.StCurrentFees.Size = New System.Drawing.Size(160, 37)
        Me.StCurrentFees.TabIndex = 13
        '
        'StOldFees
        '
        Me.StOldFees.BackColor = System.Drawing.Color.LightSkyBlue
        Me.StOldFees.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StOldFees.Location = New System.Drawing.Point(707, 385)
        Me.StOldFees.Name = "StOldFees"
        Me.StOldFees.Size = New System.Drawing.Size(160, 37)
        Me.StOldFees.TabIndex = 14
        '
        'Result
        '
        Me.Result.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Result.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Result.Location = New System.Drawing.Point(969, 390)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(160, 32)
        Me.Result.TabIndex = 16
        '
        'Paid
        '
        Me.Paid.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Paid.Location = New System.Drawing.Point(768, 501)
        Me.Paid.Name = "Paid"
        Me.Paid.Size = New System.Drawing.Size(143, 32)
        Me.Paid.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(541, 506)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 23)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Enter Fees Payment"
        '
        'PaymentBtn
        '
        Me.PaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PaymentBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.PaymentBtn.FlatAppearance.BorderSize = 3
        Me.PaymentBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PaymentBtn.Location = New System.Drawing.Point(947, 497)
        Me.PaymentBtn.Name = "PaymentBtn"
        Me.PaymentBtn.Size = New System.Drawing.Size(94, 32)
        Me.PaymentBtn.TabIndex = 19
        Me.PaymentBtn.Text = "Pay"
        Me.PaymentBtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(284, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1090, 71)
        Me.Panel2.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(279, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(525, 58)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Student Fees Payment"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label10.Location = New System.Drawing.Point(592, 587)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(429, 34)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Student Fees Payment Records"
        '
        'StFe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 853)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PaymentBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Paid)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.StOldFees)
        Me.Controls.Add(Me.StCurrentFees)
        Me.Controls.Add(Me.StDep)
        Me.Controls.Add(Me.StSem)
        Me.Controls.Add(Me.StName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SerchBx)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StFeesP)
        Me.Name = "StFe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StFe"
        CType(Me.StFeesP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StFeesP As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bb As PictureBox
    Friend WithEvents SerchBx As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents StName As Label
    Friend WithEvents StSem As Label
    Friend WithEvents StDep As Label
    Friend WithEvents StCurrentFees As Label
    Friend WithEvents StOldFees As Label
    Friend WithEvents Result As TextBox
    Friend WithEvents Paid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PaymentBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents SrSt As Button
    Friend WithEvents Adst As Button
End Class
