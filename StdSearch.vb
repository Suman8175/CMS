Imports System.Data.SqlClient

Public Class StdSearch
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer Nitro 5\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub depfill()
        con.open()
        Dim query = "select * from DepartmentTable"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        STDep.DataSource = tbl
        STDep.DisplayMember = "DepName"
        STDep.ValueMember = "DepName"
        con.close()
    End Sub
    Private Sub depdisp()
        con.open()
        Dim query = "select StId,StName,StSemester,StDep,StPhone,StDOB,StGender from StudentTable"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        STDGV.DataSource = ds.Tables(0)
        con.close()

    End Sub
    Public Sub filt(valuetosearch As String)
        Dim searchquery As String = "SELECT StId,StName,StSemester,StDep,StPhone,StDOB,StGender from StudentTable WHERE CONCAT(StId,StName,StSemester,StDep,StPhone,StGender) like '%" & valuetosearch & "%'"
        Dim command As New SqlCommand(searchquery, con)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        STDGV.DataSource = table

    End Sub

    Private Sub StdSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        depfill()
        depdisp()
        filt("")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        filt(SearchStd.Text)
    End Sub
    Dim stkey = 0
    Private Sub STDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles STDGV.CellMouseClick
        Dim row As DataGridViewRow = STDGV.Rows(e.RowIndex)
        STName.Text = row.Cells(1).Value.ToString
        STSem.Text = row.Cells(2).Value.ToString
        STDep.Text = row.Cells(3).Value.ToString
        STPhone.Text = row.Cells(4).Value.ToString
        STDOB.Text = row.Cells(5).Value.ToString
        STGen.Text = row.Cells(6).Value.ToString()
        If STName.Text = "" Then
            stkey = 0
        Else
            stkey = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If STName.Text = "" Or STSem.SelectedIndex = -1 Or STDep.Text = "" Or STPhone.Text = "" Or STDOB.Text = "" Or STGen.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.open()
                Dim query = "update StudentTable set StName='" & STName.Text & "',StSemester='" & STSem.SelectedItem.ToString() & "',StDep='" & STDep.SelectedValue.ToString() & "',StPhone='" & STPhone.Text & "',StDOB='" & STDOB.Value.Date & "',STGender='" & STGen.SelectedItem.ToString() & "'where StId=" & stkey & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Record Updated")
                STName.Text = ""
                STSem.Text = ""
                STDep.Text = ""
                STPhone.Text = ""
                STDOB.Text = ""
                STGen.Text = ""
                con.close()
                depdisp()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If stkey = 0 Then
            MsgBox("Select the student record you want to delete")
        Else
            Try
                con.open()
                Dim query = "delete from StudentTable where StId=" & stkey & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Student record deleted")
                STName.Text = ""
                STSem.Text = ""
                STDep.Text = ""
                STPhone.Text = ""
                STDOB.Text = ""
                STGen.Text = ""
                con.close()
                depdisp()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SemUpdate_Click(sender As Object, e As EventArgs) Handles SemUpdate.Click
        If (MsgBox("Do you really want to update semester of all student?", vbQuestion + vbYesNo, "Ask")) = vbYes Then
            Try
                con.open()
                Dim quer = "update StudentTable SET StOldFees=StOldFees+ISNULL(StCurrentFees,0) where StSemester<>'Passout'"
                Dim cm As New SqlCommand(quer, con)
                cm.ExecuteNonQuery()
                Dim query = "update StudentTable SET StSemester=StSemester+1 where StSemester<>'PassOut'"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                con.close()
                con.open()
                Dim q = "update S SET S.StCurrentFees=F.Fees FROM StudentTable S JOIN FeesUpdateTable F ON S.StSemester=F.Semester AND S.StDep=F.Department where F.Fees IS NOT NULL"
                Dim c As New SqlCommand(q, con)
                c.ExecuteNonQuery()
                con.close()
                con.open()
                Dim query2 = "update StudentTable SET StSemester='PassOut' WHERE StSemester='9'"
                Dim cmd2 As SqlCommand
                cmd2 = New SqlCommand(query2, con)
                cmd2.ExecuteNonQuery()

                con.close()
                depdisp()

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ad = New Student()
        ad.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fst = New StFe()
        fst.Show()
        Me.Hide()
    End Sub

    Private Sub rw_Click(sender As Object, e As EventArgs) Handles rw.Click
        depfill()
        depdisp()
    End Sub
End Class