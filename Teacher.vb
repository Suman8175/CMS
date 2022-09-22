Imports System.Data.SqlClient
Public Class Teacher

    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer Nitro 5\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub filldepartment()
        con.open()
        Dim query = "select * from DepartmentTable"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        TeacherDb.DataSource = tbl
        TeacherDb.DisplayMember = "DepName"
        TeacherDb.ValueMember = "DepName"
        con.close()
    End Sub

    Private Sub display()
        con.open()
        Dim query = "select TId,TName,TGender,TDep,TPhone,TDOB from TeacherTable"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        TeacherDGV.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim back = New Main()
        back.Show()
        Me.Hide()

    End Sub

    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldepartment()
        display()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If TName.Text = "" Or TeacherDb.SelectedIndex = -1 Or TPhone.Text = "" Or TGender.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            Try
                con.open()
                Dim qur = "select TName,TGender,TDep,TPhone from TeacherTable where TName='" & TName.Text & "' AND TGender='" & TGender.Text & "'AND TDep='" & TeacherDb.Text & "' AND TPhone='" & TPhone.Text & "'"
                Dim comd As New SqlCommand(qur, con)
                Dim rder As SqlDataReader = comd.ExecuteReader
                If rder.Read Then
                    MsgBox("Teacher Information already exists")
                    TName.Text = ""
                    TeacherDb.Text = ""
                    TPhone.Text = ""
                    TGender.Text = ""
                    rder.Close()
                Else
                    con.close()
                    con.open()
                    Dim query = "insert into TeacherTable([TName],[TGender],[TDep],[TPhone],[TDOB]) values('" & TName.Text & "','" & TGender.SelectedItem.ToString() & "','" & TeacherDb.SelectedValue.ToString() & "','" & TPhone.Text & "','" & TDOB.Value.Date & "')"
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    Dim query2 = "update TeacherTable set TSalary=0,TPayment=0 where TName='" & TName.Text & "' AND TDep='" & TeacherDb.SelectedValue.ToString() & "'"
                    Dim cmd2 As New SqlCommand(query2, con)
                    cmd2.ExecuteNonQuery()
                    MsgBox("Teacher Record Saved")
                    TName.Text = ""
                    TeacherDb.Text = ""
                    TPhone.Text = ""
                    TGender.Text = ""
                    con.close()
                    display()
                End If
                con.close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub pu_Click(sender As Object, e As EventArgs) Handles pu.Click
        Dim j = New payte()
        j.Show()
        Me.Hide()
    End Sub

    Private Sub seb_Click(sender As Object, e As EventArgs) Handles seb.Click
        Dim sa = New TeacherSearch()
        sa.Show()
        Me.Hide()
    End Sub

    Private Sub ref_Click(sender As Object, e As EventArgs) Handles ref.Click
        filldepartment()
        display()

    End Sub
End Class