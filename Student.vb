Imports System.Data.SqlClient

Public Class Student
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer Nitro 5\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub filldepartment()
        con.open()
        Dim query = "select * from DepartmentTable"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        DepCb.DataSource = tbl
        DepCb.DisplayMember = "DepName"
        DepCb.ValueMember = "DepName"
        con.close()

    End Sub
    Private Sub displaay()
        con.open()
        Dim query = "select StId,StName,StSemester,StDep,StPhone,StDOB,StGender from StudentTable"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        StudentDGV.DataSource = ds.Tables(0)
        con.close()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim back = New Main
        back.Show()
        Me.Hide()

    End Sub

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldepartment()
        displaay()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If StNameTb.Text = "" Or SemCb.SelectedIndex = -1 Or DepCb.SelectedIndex = -1 Or StPhoneTb.Text = "" Or GenCb.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            Try

                con.Open()
                Dim qur = "select StName,StSemester,StDep,StPhone from StudentTable where StName='" & StNameTb.Text & "' AND StSemester='" & SemCb.Text & "' AND StDep='" & DepCb.Text & "' AND StPhone='" & StPhoneTb.Text & "'"
                Dim comm As New SqlCommand(qur, con)
                Dim rdr As SqlDataReader = comm.ExecuteReader
                If rdr.Read Then
                    MsgBox("Student Information Already Exists")
                    StNameTb.Text = ""
                    SemCb.Text = ""
                    DepCb.Text = ""
                    StPhoneTb.Text = ""
                    GenCb.Text = ""
                    rdr.Close()
                Else
                    con.close()
                    con.open()
                    Dim query = "insert into StudentTable([StName],[StSemester],[StDep],[StPhone],[StDOB],[StGender]) values('" & StNameTb.Text & "','" & SemCb.SelectedItem.ToString() & "','" & DepCb.SelectedValue.ToString() & "','" & StPhoneTb.Text & "','" & StDOB.Value.Date & "','" & GenCb.SelectedItem.ToString() & "')"
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    con.close()
                    con.open()
                    Dim query2 = "update StudentTable set StOldFees=0,StTotalPayment=0 where StName='" & StNameTb.Text & "' AND StSemester='" & SemCb.SelectedItem.ToString() & "' AND StDep='" & DepCb.SelectedValue.ToString() & "'"
                    Dim cmd2 As New SqlCommand(query2, con)
                    cmd2.ExecuteNonQuery()
                    con.close()
                    con.open()
                    Dim query33 = "update S set S.StCurrentFees=F.Fees FROM StudentTable S Join FeesupdateTable F ON S.StSemester=F.Semester AND S.StDep=F.Department where StName='" & StNameTb.Text & "'"
                    Dim cmd3 As New SqlCommand(query33, con)
                    cmd3.ExecuteNonQuery()
                    con.close()
                    MsgBox("Student record Saved")
                    StNameTb.Text = ""
                    SemCb.Text = ""
                    DepCb.Text = ""
                    StPhoneTb.Text = ""
                    GenCb.Text = ""
                    'con.Close()
                    displaay()
                End If
                con.close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub srbtn_Click(sender As Object, e As EventArgs) Handles srbtn.Click
        Dim ha = New StdSearch()
        ha.Show()
        Me.Hide()
    End Sub

    Private Sub paybhn_Click(sender As Object, e As EventArgs) Handles paybhn.Click
        Dim pa = New StFe()
        pa.Show()
        Me.Hide()
    End Sub

    Private Sub rfr_Click(sender As Object, e As EventArgs) Handles rfr.Click
        filldepartment()
        displaay()
    End Sub
End Class