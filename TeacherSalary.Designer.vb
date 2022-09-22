<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherSalary
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btp = New System.Windows.Forms.Button()
        Me.bts = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TeDep = New System.Windows.Forms.ComboBox()
        Me.TeName = New System.Windows.Forms.ComboBox()
        Me.TeSave = New System.Windows.Forms.Button()
        Me.TeEdit = New System.Windows.Forms.Button()
        Me.TeDelete = New System.Windows.Forms.Button()
        Me.TDGV = New System.Windows.Forms.DataGridView()
        Me.TeSalary = New System.Windows.Forms.TextBox()
        Me.TNam = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rtr = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.rtr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.btp)
        Me.Panel1.Controls.Add(Me.bts)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 749)
        Me.Panel1.TabIndex = 0
        '
        'btp
        '
        Me.btp.BackColor = System.Drawing.Color.SteelBlue
        Me.btp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btp.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btp.ForeColor = System.Drawing.Color.White
        Me.btp.Location = New System.Drawing.Point(9, 328)
        Me.btp.Name = "btp"
        Me.btp.Size = New System.Drawing.Size(275, 41)
        Me.btp.TabIndex = 3
        Me.btp.Text = "Search Teacher"
        Me.btp.UseVisualStyleBackColor = False
        '
        'bts
        '
        Me.bts.BackColor = System.Drawing.Color.SteelBlue
        Me.bts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bts.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bts.ForeColor = System.Drawing.Color.White
        Me.bts.Location = New System.Drawing.Point(7, 193)
        Me.bts.Name = "bts"
        Me.bts.Size = New System.Drawing.Size(277, 46)
        Me.bts.TabIndex = 2
        Me.bts.Text = "Pay Teacher Salary"
        Me.bts.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(286, 73)
        Me.Panel3.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(139, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 56)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "LGIC"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.LGIClogo
        Me.PictureBox2.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.back
        Me.PictureBox1.Location = New System.Drawing.Point(21, 568)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(236, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TeDep
        '
        Me.TeDep.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TeDep.FormattingEnabled = True
        Me.TeDep.Location = New System.Drawing.Point(446, 212)
        Me.TeDep.Name = "TeDep"
        Me.TeDep.Size = New System.Drawing.Size(151, 31)
        Me.TeDep.TabIndex = 1
        '
        'TeName
        '
        Me.TeName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TeName.FormattingEnabled = True
        Me.TeName.Location = New System.Drawing.Point(774, 211)
        Me.TeName.Name = "TeName"
        Me.TeName.Size = New System.Drawing.Size(151, 31)
        Me.TeName.TabIndex = 2
        '
        'TeSave
        '
        Me.TeSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TeSave.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TeSave.Location = New System.Drawing.Point(460, 365)
        Me.TeSave.Name = "TeSave"
        Me.TeSave.Size = New System.Drawing.Size(144, 35)
        Me.TeSave.TabIndex = 3
        Me.TeSave.Text = "Save"
        Me.TeSave.UseVisualStyleBackColor = True
        '
        'TeEdit
        '
        Me.TeEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TeEdit.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TeEdit.Location = New System.Drawing.Point(701, 365)
        Me.TeEdit.Name = "TeEdit"
        Me.TeEdit.Size = New System.Drawing.Size(135, 35)
        Me.TeEdit.TabIndex = 4
        Me.TeEdit.Text = "Update"
        Me.TeEdit.UseVisualStyleBackColor = True
        '
        'TeDelete
        '
        Me.TeDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TeDelete.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TeDelete.Location = New System.Drawing.Point(939, 365)
        Me.TeDelete.Name = "TeDelete"
        Me.TeDelete.Size = New System.Drawing.Size(144, 35)
        Me.TeDelete.TabIndex = 5
        Me.TeDelete.Text = "Delete"
        Me.TeDelete.UseVisualStyleBackColor = True
        '
        'TDGV
        '
        Me.TDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TDGV.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TDGV.EnableHeadersVisualStyles = False
        Me.TDGV.Location = New System.Drawing.Point(337, 500)
        Me.TDGV.Name = "TDGV"
        Me.TDGV.RowHeadersWidth = 51
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.TDGV.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.TDGV.RowTemplate.Height = 29
        Me.TDGV.Size = New System.Drawing.Size(907, 241)
        Me.TDGV.TabIndex = 6
        '
        'TeSalary
        '
        Me.TeSalary.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TeSalary.Location = New System.Drawing.Point(1085, 211)
        Me.TeSalary.Name = "TeSalary"
        Me.TeSalary.Size = New System.Drawing.Size(159, 32)
        Me.TeSalary.TabIndex = 7
        '
        'TNam
        '
        Me.TNam.AutoSize = True
        Me.TNam.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TNam.Location = New System.Drawing.Point(363, 171)
        Me.TNam.Name = "TNam"
        Me.TNam.Size = New System.Drawing.Size(311, 34)
        Me.TNam.TabIndex = 8
        Me.TNam.Text = "Teacher's Department"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(742, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 34)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Teacher's Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(1036, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 34)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Teacher's Salary"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(290, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 74)
        Me.Panel2.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(270, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(393, 58)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Teacher's Salary"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label5.Location = New System.Drawing.Point(772, 455)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(219, 37)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Salary Record"
        '
        'rtr
        '
        Me.rtr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rtr.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.refresh
        Me.rtr.Location = New System.Drawing.Point(696, 457)
        Me.rtr.Name = "rtr"
        Me.rtr.Size = New System.Drawing.Size(70, 37)
        Me.rtr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rtr.TabIndex = 13
        Me.rtr.TabStop = False
        '
        'TeacherSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 753)
        Me.Controls.Add(Me.rtr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TNam)
        Me.Controls.Add(Me.TeSalary)
        Me.Controls.Add(Me.TDGV)
        Me.Controls.Add(Me.TeDelete)
        Me.Controls.Add(Me.TeEdit)
        Me.Controls.Add(Me.TeSave)
        Me.Controls.Add(Me.TeName)
        Me.Controls.Add(Me.TeDep)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TeacherSalary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeacherSalary"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.rtr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TeDep As ComboBox
    Friend WithEvents TeName As ComboBox
    Friend WithEvents TeSave As Button
    Friend WithEvents TeEdit As Button
    Friend WithEvents TeDelete As Button
    Friend WithEvents TDGV As DataGridView
    Friend WithEvents TeSalary As TextBox
    Friend WithEvents TNam As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bts As Button
    Friend WithEvents btp As Button
    Friend WithEvents rtr As PictureBox
End Class
