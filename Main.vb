Public Class Main
    Dim iscollapsed As Boolean = True
    Dim iscollapsed2 As Boolean = True
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DropPanel1.Size = DropPanel1.MinimumSize
        Panel3.Size = Panel3.MinimumSize
        Panel3.Location = New Point(3, 252)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If iscollapsed Then
            DropStudent.Image = My.Resources.down

            DropPanel1.Height += 10
            If DropPanel1.Size = DropPanel1.MaximumSize Then
                Panel3.Location = New Point(3, 404)
                Timer1.Stop()
                iscollapsed = False
            End If
        Else
            DropStudent.Image = My.Resources.left
            DropPanel1.Height -= 10
            If DropPanel1.Size = DropPanel1.MinimumSize Then
                Panel3.Location = New Point(3, 252)
                Timer1.Stop()
                iscollapsed = True
            End If
        End If
    End Sub

    Private Sub DropStudent_Click(sender As Object, e As EventArgs) Handles DropStudent.Click

        If Size = DropPanel1.MinimumSize Then
            Size = DropPanel1.MaximumSize
        End If
        iscollapsed2 = False
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If iscollapsed2 Then
            DropTeacher.Image = My.Resources.down
            Panel3.Height += 10
            If Panel3.Size = Panel3.MaximumSize Then
                Timer2.Stop()
                iscollapsed2 = False
            End If
        Else
            DropTeacher.Image = My.Resources.left
            Panel3.Height -= 10
            If Panel3.Size = Panel3.MinimumSize Then
                Timer2.Stop()
                iscollapsed2 = True


            End If
        End If
    End Sub

    Private Sub DropTeacher_Click(sender As Object, e As EventArgs) Handles DropTeacher.Click
        iscollapsed = False
        Timer1.Start()
        Timer2.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Student.Show()
        Me.Hide()

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim u = New Dash()
        u.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim de = New Department
        de.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        StdSearch.Show()
        Me.Hide()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Teacher.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TeacherSearch.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim go = New FeesUpdate
        go.Show()
        Me.Hide()
    End Sub

    Private Sub StudentFeesPayment_Click(sender As Object, e As EventArgs) Handles StudentFeesPayment.Click
        Dim q = New StFe()
        q.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim v = New TeacherSalary()
        v.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub pays_Click(sender As Object, e As EventArgs) Handles pays.Click
        Dim vc = New payte()
        vc.Show()
        Me.Hide()
    End Sub
End Class