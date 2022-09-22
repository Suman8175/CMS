<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FeesUpdate
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Depart = New System.Windows.Forms.ComboBox()
        Me.Semes = New System.Windows.Forms.ComboBox()
        Me.FeesData = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FeesSave = New System.Windows.Forms.Button()
        Me.FeesUp = New System.Windows.Forms.Button()
        Me.FeesDel = New System.Windows.Forms.Button()
        Me.FeesShow = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rsh = New System.Windows.Forms.PictureBox()
        Me.qwwe = New System.Windows.Forms.Button()
        Me.nvc = New System.Windows.Forms.Button()
        CType(Me.FeesShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.rsh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Depart
        '
        Me.Depart.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Depart.FormattingEnabled = True
        Me.Depart.Location = New System.Drawing.Point(320, 288)
        Me.Depart.Name = "Depart"
        Me.Depart.Size = New System.Drawing.Size(170, 31)
        Me.Depart.TabIndex = 0
        '
        'Semes
        '
        Me.Semes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Semes.FormattingEnabled = True
        Me.Semes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.Semes.Location = New System.Drawing.Point(598, 289)
        Me.Semes.Name = "Semes"
        Me.Semes.Size = New System.Drawing.Size(151, 31)
        Me.Semes.TabIndex = 1
        '
        'FeesData
        '
        Me.FeesData.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FeesData.Location = New System.Drawing.Point(887, 289)
        Me.FeesData.Name = "FeesData"
        Me.FeesData.Size = New System.Drawing.Size(125, 32)
        Me.FeesData.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(306, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Department"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(610, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 34)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Semester"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(900, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 34)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fees"
        '
        'FeesSave
        '
        Me.FeesSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FeesSave.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FeesSave.Location = New System.Drawing.Point(338, 394)
        Me.FeesSave.Name = "FeesSave"
        Me.FeesSave.Size = New System.Drawing.Size(143, 37)
        Me.FeesSave.TabIndex = 6
        Me.FeesSave.Text = "Save"
        Me.FeesSave.UseVisualStyleBackColor = True
        '
        'FeesUp
        '
        Me.FeesUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FeesUp.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FeesUp.Location = New System.Drawing.Point(592, 394)
        Me.FeesUp.Name = "FeesUp"
        Me.FeesUp.Size = New System.Drawing.Size(126, 37)
        Me.FeesUp.TabIndex = 7
        Me.FeesUp.Text = "Update"
        Me.FeesUp.UseVisualStyleBackColor = True
        '
        'FeesDel
        '
        Me.FeesDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FeesDel.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FeesDel.Location = New System.Drawing.Point(857, 394)
        Me.FeesDel.Name = "FeesDel"
        Me.FeesDel.Size = New System.Drawing.Size(124, 37)
        Me.FeesDel.TabIndex = 8
        Me.FeesDel.Text = "Delete"
        Me.FeesDel.UseVisualStyleBackColor = True
        '
        'FeesShow
        '
        Me.FeesShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FeesShow.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FeesShow.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.FeesShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.FeesShow.DefaultCellStyle = DataGridViewCellStyle6
        Me.FeesShow.EnableHeadersVisualStyles = False
        Me.FeesShow.Location = New System.Drawing.Point(296, 516)
        Me.FeesShow.Name = "FeesShow"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FeesShow.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.FeesShow.RowHeadersWidth = 51
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.FeesShow.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.FeesShow.RowTemplate.Height = 29
        Me.FeesShow.Size = New System.Drawing.Size(817, 225)
        Me.FeesShow.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.nvc)
        Me.Panel1.Controls.Add(Me.qwwe)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 739)
        Me.Panel1.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(2, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(242, 86)
        Me.Panel3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(110, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 56)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "LGIC"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.LGIClogo
        Me.PictureBox2.Location = New System.Drawing.Point(1, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.back
        Me.PictureBox1.Location = New System.Drawing.Point(17, 539)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(204, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(247, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(875, 87)
        Me.Panel2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(206, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(492, 58)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Student Fees Update"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label6.Location = New System.Drawing.Point(603, 475)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 37)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fees Table"
        '
        'rsh
        '
        Me.rsh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rsh.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.refresh
        Me.rsh.Location = New System.Drawing.Point(505, 469)
        Me.rsh.Name = "rsh"
        Me.rsh.Size = New System.Drawing.Size(82, 43)
        Me.rsh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rsh.TabIndex = 13
        Me.rsh.TabStop = False
        '
        'qwwe
        '
        Me.qwwe.BackColor = System.Drawing.Color.SteelBlue
        Me.qwwe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.qwwe.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.qwwe.ForeColor = System.Drawing.Color.White
        Me.qwwe.Location = New System.Drawing.Point(17, 152)
        Me.qwwe.Name = "qwwe"
        Me.qwwe.Size = New System.Drawing.Size(212, 40)
        Me.qwwe.TabIndex = 2
        Me.qwwe.Text = "Add Student"
        Me.qwwe.UseVisualStyleBackColor = False
        '
        'nvc
        '
        Me.nvc.BackColor = System.Drawing.Color.SteelBlue
        Me.nvc.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.nvc.ForeColor = System.Drawing.Color.White
        Me.nvc.Location = New System.Drawing.Point(14, 279)
        Me.nvc.Name = "nvc"
        Me.nvc.Size = New System.Drawing.Size(211, 40)
        Me.nvc.TabIndex = 3
        Me.nvc.Text = "Pay Student Fees"
        Me.nvc.UseVisualStyleBackColor = False
        '
        'FeesUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 753)
        Me.Controls.Add(Me.rsh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FeesShow)
        Me.Controls.Add(Me.FeesDel)
        Me.Controls.Add(Me.FeesUp)
        Me.Controls.Add(Me.FeesSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FeesData)
        Me.Controls.Add(Me.Semes)
        Me.Controls.Add(Me.Depart)
        Me.Name = "FeesUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FeesUpdate"
        CType(Me.FeesShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.rsh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Depart As ComboBox
    Friend WithEvents Semes As ComboBox
    Friend WithEvents FeesData As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FeesSave As Button
    Friend WithEvents FeesUp As Button
    Friend WithEvents FeesDel As Button
    Friend WithEvents FeesShow As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rsh As PictureBox
    Friend WithEvents nvc As Button
    Friend WithEvents qwwe As Button
End Class
