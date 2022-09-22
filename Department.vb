Imports System.Data.SqlClient

Public Class Department
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer Nitro 5\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub display()
        con.open()
        Dim query = "select * from DepartmentTable"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DepartmentDGV.DataSource = ds.Tables(0)
        con.close()

    End Sub
    Private Sub Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If DepNameTb.Text = "" Or DescTb.Text = "" Or FacultyTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.Open()
                Dim query = "insert into DepartmentTable values('" & DepNameTb.Text & "','" & DescTb.Text & "','" & FacultyTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Department Saved")
                DepNameTb.Text = ""
                DescTb.Text = ""
                FacultyTb.Text = ""
                con.Close()
                display()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Select the department")
        Else
            Try
                con.Open()
                Dim query = "delete from DepartmentTable where DepId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Department deleted")
                DepNameTb.Text = ""
                DescTb.Text = ""
                FacultyTb.Text = ""
                con.Close()
                display()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Dim key = 0
    Private Sub DepartmentDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DepartmentDGV.CellMouseClick
        Dim row As DataGridViewRow = DepartmentDGV.Rows(e.RowIndex)
        DepNameTb.Text = row.Cells(1).Value.ToString
        DescTb.Text = row.Cells(2).Value.ToString
        FacultyTb.Text = row.Cells(3).Value.ToString
        If DepNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If DepNameTb.Text = "" Or DescTb.Text = "" Or FacultyTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.Open()
                Dim query = "update DepartmentTable set DepName='" & DepNameTb.Text & "',DepDesc='" & DescTb.Text & "',DepFac='" & FacultyTb.Text & "'where DepId=" & key & " "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Department Saved")
                DepNameTb.Text = ""
                DescTb.Text = ""
                FacultyTb.Text = ""
                con.Close()
                display()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim abc = New Main()
        abc.Show()
        Me.Hide()

    End Sub

    Private Sub AdS_Click(sender As Object, e As EventArgs) Handles AdS.Click
        Dim af = New Student()
        af.Show()
        Me.Hide()
    End Sub

    Private Sub AdT_Click(sender As Object, e As EventArgs) Handles AdT.Click
        Dim te = New Teacher()
        te.Show()
        Me.Hide()
    End Sub
End Class