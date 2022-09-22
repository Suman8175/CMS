
Imports System.Data.SqlClient
Public Class TeacherSalary
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer Nitro 5\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim ase = New Main()
        ase.Show()
        Me.Hide()
    End Sub

    Private Sub dd()
        con.open()
        Dim query = "select TId,TDep,TName,TSalary from TeacherTable"
        Dim cmd As New SqlCommand(query, con)
        Dim adpater = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adpater)
        Dim tbl As DataSet
        tbl = New DataSet
        adpater.Fill(tbl)
        TDGV.DataSource = tbl.Tables(0)
        con.close()
    End Sub
    Private Sub are()
        con.open()
        Dim query = "select DepName from DepartmentTable"
        Dim cmd As New SqlCommand(query, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        TeDep.Items.Clear()
        While reader.Read()
            TeDep.Items.Add(reader("DepName"))
        End While
        con.close()
    End Sub

    Private Sub TeDep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TeDep.SelectedIndexChanged
        con.open()
        TeName.Text = ""
        Dim query = "select Tname from TeacherTable where TDep='" & TeDep.Text & "'"
        Dim cmd As New SqlCommand(query, con)
        Dim reader As SqlDataReader = cmd.ExecuteReader
        TeName.Items.Clear()
        While reader.Read()
            TeName.Items.Add(reader("TName"))
        End While
        con.close()
    End Sub

    Private Sub TeacherSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        are()
        dd()
    End Sub

    Private Sub TeSave_Click(sender As Object, e As EventArgs) Handles TeSave.Click

        con.open()
        Dim query = " update TeacherTable set TSalary=TSalary + '" & TeSalary.Text & "' where TDep='" & TeDep.Text & "' AND TName='" & TeName.Text & "'"
        Dim cmd As New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        con.close()
        TeSalary.Text = ""
        TeDep.Text = ""
        TeName.Text = ""
        MsgBox("Teachers Salary has been setup.")
        dd()
    End Sub

    Dim ik = 0
    Private Sub TDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TDGV.CellMouseClick

        Dim row As DataGridViewRow = TDGV.Rows(e.RowIndex)
        TeDep.Text = row.Cells(1).Value.ToString
        TeName.Text = row.Cells(2).Value.ToString
        TeSalary.Text = row.Cells(3).Value.ToString()
        If TeName.Text = "" Then
            ik = 0
        Else
            ik = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub TeEdit_Click(sender As Object, e As EventArgs) Handles TeEdit.Click
        con.open()
        Dim query = "update TeacherTable set TDep='" & TeDep.Text & "',TName='" & TeName.Text & "',TSalary='" & TeSalary.Text & "'where TId=" & ik & ""
        Dim cmd As New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        con.close()
        TeSalary.Text = ""
        TeName.Text = ""
        TeDep.Text = ""
        MsgBox("Teacher Salary Information Updated")
        dd()
    End Sub

    Private Sub TeDelete_Click(sender As Object, e As EventArgs) Handles TeDelete.Click
        con.open()
        Dim query = "update TeacherTable set TSalary=0 where TName='" & TeName.Text & "' AND TDep='" & TeDep.Text & "'"
        Dim cmd As New SqlCommand(query, con)
        cmd.ExecuteNonQuery()
        con.close()
        TeSalary.Text = ""
        TeName.Text = ""
        TeDep.Text = ""
        MsgBox("Teacher Salary Information Deleted")
        dd()
    End Sub

    Private Sub bts_Click(sender As Object, e As EventArgs) Handles bts.Click
        Dim pe = New payte()
        pe.Show()
        Me.Hide()
    End Sub

    Private Sub btp_Click(sender As Object, e As EventArgs) Handles btp.Click
        Dim st = New TeacherSearch()
        st.Show()
        Me.Hide()
    End Sub

    Private Sub rtr_Click(sender As Object, e As EventArgs) Handles rtr.Click
        dd()
        are()
    End Sub
End Class