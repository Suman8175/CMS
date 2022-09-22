Imports System.Data.SqlClient

Public Class TeacherSearch
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer Nitro 5\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub filldep()
        con.open()
        Dim query = "select * from DepartmentTable"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        TDep.DataSource = tbl
        TDep.DisplayMember = "DepName"
        TDep.ValueMember = "DepName"
        con.close()

    End Sub

    Private Sub filldata()
        con.open()
        Dim query = "select TId,TName,TGender,TDep,TPhone,TDOB from TeacherTable"
        Dim adapter As SqlDataAdapter
        Dim cmd As New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        TeacherDGV.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Public Sub find(valuetosearch As String)
        Dim searchquery As String = "SELECT TId,TName,TGender,TDep,TPhone,TDOB from TeacherTable WHERE CONCAT(TId,TName,TGender,TDep,TPhone,TDOB) like '%" & valuetosearch & "%'"
        Dim command As New SqlCommand(searchquery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        TeacherDGV.DataSource = table

    End Sub


    Private Sub TeacherSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldep()
        filldata()
        find("")
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        find(SearchTeacher.Text)
    End Sub

    Dim key = 0
    Private Sub TeacherDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TeacherDGV.CellMouseClick
        Dim row As DataGridViewRow = TeacherDGV.Rows(e.RowIndex)
        TName.Text = row.Cells(1).Value.ToString
        TGender.Text = row.Cells(2).Value.ToString
        TDep.Text = row.Cells(3).Value.ToString
        TPhone.Text = row.Cells(4).Value.ToString
        TDOB.Text = row.Cells(5).Value.ToString
        If TName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If TName.Text = "" Or TGender.Text = "" Or TDep.Text = "" Or TPhone.Text = "" Or TDOB.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.open()
                Dim query = "update TeacherTable set TName='" & TName.Text & "',TGender='" & TGender.SelectedItem.ToString() & "',TDep='" & TDep.SelectedValue.ToString() & "',TPhone='" & TPhone.Text & "',TDOB='" & TDOB.Value.Date & "' where TId =" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Teacher Record Saved")
                TName.Text = ""
                TGender.Text = ""
                TDep.Text = ""
                TPhone.Text = ""
                TDOB.Text = ""
                con.close()
                filldata()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If key = 0 Then
            MsgBox("Select the teacher record you want to delete")
        Else
            Try
                con.open()
                Dim query = "delete from TeacherTable where TId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Teacher Record Deleted Sucessfully")
                TName.Text = ""
                TDep.Text = ""
                TGender.Text = ""
                TPhone.Text = ""
                TDOB.Text = ""
                con.close()
                filldata()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim back = New Main
        back.Show()
        Me.Hide()
    End Sub



    Private Sub tsc_Click(sender As Object, e As EventArgs) Handles tsc.Click
        Dim ae = New Teacher()
        ae.Show()
        Me.Hide()
    End Sub

    Private Sub Pte_Click(sender As Object, e As EventArgs) Handles Pte.Click
        Dim pt = New payte()
        pt.Show()
        Me.Hide()
    End Sub

    Private Sub rq_Click(sender As Object, e As EventArgs) Handles rq.Click
        filldep()
        filldata()
    End Sub
End Class