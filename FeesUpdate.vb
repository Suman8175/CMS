Imports System.Data.SqlClient
Public Class FeesUpdate

    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer Nitro 5\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub filldepart()
        con.open()
        Dim query = "select * from DepartmentTable"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        Depart.DataSource = tbl
        Depart.DisplayMember = "DepName"
        Depart.ValueMember = "DepName"
        con.close()
    End Sub

    Private Sub disp()
        con.open()
        Dim query = "select * from FeesUpdateTable"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        FeesShow.DataSource = ds.Tables(0)
        con.close()
    End Sub

    Private Sub FeesUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filldepart()
        disp()
    End Sub

    Private Sub FeesSave_Click(sender As Object, e As EventArgs) Handles FeesSave.Click
        If Depart.SelectedIndex = -1 Or Semes.SelectedIndex = -1 Or FeesData.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.open()
                Dim query = "insert into FeesUpdateTable([Department],[Semester],[Fees]) values('" & Depart.SelectedValue.ToString() & "','" & Semes.SelectedItem.ToString() & "','" & FeesData.Text & "') "
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim query2 = "update StudentTable Set StCurrentFees='" & FeesData.Text & "' WHERE StDep='" & Depart.SelectedValue.ToString() & "'AND StSemester='" & Semes.SelectedItem.ToString() & "'"
                Dim cmd2 As SqlCommand
                cmd2 = New SqlCommand(query2, con)
                cmd2.ExecuteNonQuery()
                MsgBox("Fees Saved According to Department and Semester")

                Depart.Text = ""
                Semes.Text = ""
                FeesData.Text = ""
                con.close()
                disp()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Dim keyy = 0
    Private Sub FeesShow_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles FeesShow.CellMouseClick

        Dim row As DataGridViewRow = FeesShow.Rows(e.RowIndex)
        Depart.Text = row.Cells(1).Value.ToString
        Semes.Text = row.Cells(2).Value.ToString
        FeesData.Text = row.Cells(3).Value.ToString
        If Depart.Text = "" Then
            keyy = 0
        Else
            keyy = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub FeesUp_Click(sender As Object, e As EventArgs) Handles FeesUp.Click
        If Depart.SelectedIndex = -1 Or Semes.SelectedIndex = -1 Or FeesData.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.open()
                Dim query = "update FeesUpdateTable set Department='" & Depart.SelectedValue.ToString() & "',Semester='" & Semes.SelectedItem.ToString() & "',Fees='" & FeesData.Text & "'where FId=" & keyy & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim query2 = "update StudentTable set StCurrentFees='" & FeesData.Text & "'WHERE StDep='" & Depart.SelectedValue.ToString() & "'And StSemester='" & Semes.SelectedItem.ToString() & "'"
                Dim cmd2 As SqlCommand
                cmd2 = New SqlCommand(query2, con)
                cmd2.ExecuteNonQuery()
                MsgBox("Fees Updated")
                Depart.Text = ""
                Semes.Text = ""
                FeesData.Text = ""
                con.close()
                disp()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub FeesDel_Click(sender As Object, e As EventArgs) Handles FeesDel.Click
        If keyy = 0 Then
            MsgBox("Select the record you want to delete ")
        Else
            Try
                con.open()
                Dim query = "delete from FeesUpdateTable where FId= " & keyy & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                Dim query2 = "update StudentTable SET StCurrentFees=0 WHERE StDep='" & Depart.SelectedValue.ToString() & "' AND StSemester=" & Semes.SelectedItem.ToString() & ""
                Dim cmd2 As SqlCommand
                cmd2 = New SqlCommand(query2, con)
                cmd2.ExecuteNonQuery()
                MsgBox("Selected Record Deleted")
                Depart.Text = ""
                Semes.Text = ""
                FeesData.Text = ""
                con.close()
                disp()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim x = New Main()
        x.Show()
        Me.Hide()
    End Sub

    Private Sub rsh_Click(sender As Object, e As EventArgs) Handles rsh.Click
        filldepart()
        disp()
    End Sub

    Private Sub qwwe_Click(sender As Object, e As EventArgs) Handles qwwe.Click
        Dim gf = New Student()
        gf.Show()
        Me.Hide()
    End Sub

    Private Sub nvc_Click(sender As Object, e As EventArgs) Handles nvc.Click
        Dim uy = New StFe()
        uy.Show()
        Me.Hide()
    End Sub
End Class