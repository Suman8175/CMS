<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payte
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.srchcode = New System.Windows.Forms.TextBox()
        Me.srchic = New System.Windows.Forms.PictureBox()
        Me.dgt = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bc = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TDep = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TSalary = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.payme = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.jgf = New System.Windows.Forms.Button()
        Me.okkl = New System.Windows.Forms.Button()
        CType(Me.srchic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.bc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'srchcode
        '
        Me.srchcode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.srchcode.Location = New System.Drawing.Point(428, 120)
        Me.srchcode.Name = "srchcode"
        Me.srchcode.Size = New System.Drawing.Size(545, 32)
        Me.srchcode.TabIndex = 0
        '
        'srchic
        '
        Me.srchic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.srchic.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.Search_Icon
        Me.srchic.Location = New System.Drawing.Point(979, 113)
        Me.srchic.Name = "srchic"
        Me.srchic.Size = New System.Drawing.Size(102, 39)
        Me.srchic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.srchic.TabIndex = 1
        Me.srchic.TabStop = False
        '
        'dgt
        '
        Me.dgt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgt.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgt.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgt.EnableHeadersVisualStyles = False
        Me.dgt.Location = New System.Drawing.Point(304, 616)
        Me.dgt.Name = "dgt"
        Me.dgt.RowHeadersWidth = 51
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgt.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgt.RowTemplate.Height = 29
        Me.dgt.Size = New System.Drawing.Size(1066, 212)
        Me.dgt.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.okkl)
        Me.Panel1.Controls.Add(Me.jgf)
        Me.Panel1.Controls.Add(Me.bc)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(268, 850)
        Me.Panel1.TabIndex = 3
        '
        'bc
        '
        Me.bc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bc.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.back
        Me.bc.Location = New System.Drawing.Point(26, 689)
        Me.bc.Name = "bc"
        Me.bc.Size = New System.Drawing.Size(196, 136)
        Me.bc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.bc.TabIndex = 1
        Me.bc.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(268, 81)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(116, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 56)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LGIC"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CollegeMgmtSoftware.My.Resources.Resources.LGIClogo
        Me.PictureBox1.Location = New System.Drawing.Point(4, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(270, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1107, 81)
        Me.Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(314, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(459, 58)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pay Teacher Salary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(388, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Teacher's Name"
        '
        'TName
        '
        Me.TName.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TName.Location = New System.Drawing.Point(403, 285)
        Me.TName.Name = "TName"
        Me.TName.Size = New System.Drawing.Size(160, 37)
        Me.TName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(716, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 27)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Teacher's Department"
        '
        'TDep
        '
        Me.TDep.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TDep.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TDep.Location = New System.Drawing.Point(754, 285)
        Me.TDep.Name = "TDep"
        Me.TDep.Size = New System.Drawing.Size(160, 37)
        Me.TDep.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(1099, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 27)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Teacher's Salary"
        '
        'TSalary
        '
        Me.TSalary.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TSalary.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TSalary.Location = New System.Drawing.Point(1110, 285)
        Me.TSalary.Name = "TSalary"
        Me.TSalary.Size = New System.Drawing.Size(160, 37)
        Me.TSalary.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(534, 491)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 27)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Enter Salary Payment"
        '
        'payme
        '
        Me.payme.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.payme.Location = New System.Drawing.Point(815, 486)
        Me.payme.Name = "payme"
        Me.payme.Size = New System.Drawing.Size(158, 32)
        Me.payme.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(1033, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 32)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Pay"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label6.Location = New System.Drawing.Point(643, 569)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(435, 44)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Salary Payment Record"
        '
        'jgf
        '
        Me.jgf.BackColor = System.Drawing.Color.SteelBlue
        Me.jgf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.jgf.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.jgf.ForeColor = System.Drawing.Color.White
        Me.jgf.Location = New System.Drawing.Point(21, 215)
        Me.jgf.Name = "jgf"
        Me.jgf.Size = New System.Drawing.Size(229, 46)
        Me.jgf.TabIndex = 2
        Me.jgf.Text = "Add Teacher"
        Me.jgf.UseVisualStyleBackColor = False
        '
        'okkl
        '
        Me.okkl.BackColor = System.Drawing.Color.SteelBlue
        Me.okkl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.okkl.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.okkl.ForeColor = System.Drawing.Color.White
        Me.okkl.Location = New System.Drawing.Point(21, 332)
        Me.okkl.Name = "okkl"
        Me.okkl.Size = New System.Drawing.Size(229, 45)
        Me.okkl.TabIndex = 3
        Me.okkl.Text = "Search Teacher"
        Me.okkl.UseVisualStyleBackColor = False
        '
        'payte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 853)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.payme)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TSalary)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TDep)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgt)
        Me.Controls.Add(Me.srchic)
        Me.Controls.Add(Me.srchcode)
        Me.Name = "payte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "payte"
        CType(Me.srchic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.bc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents srchcode As TextBox
    Friend WithEvents srchic As PictureBox
    Friend WithEvents dgt As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bc As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TDep As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TSalary As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents payme As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents okkl As Button
    Friend WithEvents jgf As Button
End Class
