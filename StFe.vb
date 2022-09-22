Imports System.Data.SqlClient

Public Class StFe
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer Nitro 5\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub display()
        con.open()
        Dim query = "select StId,StName,StSemester,StDep,StCurrentFees,StOldFees from StudentTable"

        Dim adapter As SqlDataAdapter
        Dim cmd As New SqlCommand(query, con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        StFeesP.DataSource = ds.Tables(0)
        con.close()
    End Sub

    Public Sub fin(f As String)
        con.open()
        Dim query As String = "SELECT StId,StName,StSemester,StDep,StCurrentFees,StOldFees from StudentTable WHERE CONCAT(StId,StName,StSemester,StDep,StCurrentFees,StOldFees) like '%" & f & "%'"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        StFeesP.DataSource = table
        con.close()
    End Sub
    Private Sub StFe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display()
        fin("")
    End Sub

    Private Sub bb_Click(sender As Object, e As EventArgs) Handles bb.Click
        Dim cho = New Main()
        cho.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fin(SerchBx.Text)
    End Sub

    Dim k = 0
    Public s As Integer
    Private Sub StFeesP_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles StFeesP.CellMouseClick
        Dim row As DataGridViewRow = StFeesP.Rows(e.RowIndex)
        StName.Text = row.Cells(1).Value.ToString
        StSem.Text = row.Cells(2).Value.ToString
        StDep.Text = row.Cells(3).Value.ToString
        StCurrentFees.Text = row.Cells(4).Value.ToString
        StOldFees.Text = row.Cells(5).Value.ToString
        Dim a, b, c As Integer

        a = StCurrentFees.Text
        b = StOldFees.Text
        s = StOldFees.Text
        c = a + b
        Result.Text = a + b
        k = Convert.ToInt32(row.Cells(0).Value.ToString)
    End Sub

    Private Sub PaymentBtn_Click(sender As Object, e As EventArgs) Handles PaymentBtn.Click
        If StName.Text = "" Or StSem.Text = "" Or StDep.Text = "" Then
            MsgBox("Missing Information")
        Else


            Dim x, y, z As Integer
            x = Paid.Text
            y = s
            z = x - y
            If (y - x) < 0 Then
                Try
                    con.open()
                    Dim query = "update StudentTable set StOldFees=0,StCurrentFees=StCurrentFees-'" & z & "' where StId= " & k & ""
                    Dim cmd As New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Student Fees Paid")
                    StName.Text = ""
                    StSem.Text = ""
                    StDep.Text = ""
                    StCurrentFees.Text = ""
                    StOldFees.Text = ""
                    Result.Text = ""
                    Paid.Text = ""
                    Dim query2 = "update StudentTable set StTotalPayment=StTotalPayment+'" & x & "' where StId=" & k & ""
                    Dim cmdw As New SqlCommand(query2, con)
                    cmdw.ExecuteNonQuery()
                    con.close()
                    display()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                Try
                    con.open()
                    Dim query = "update StudentTable set StOldFees=StOldFees-'" & x & "' where StId=" & k & ""
                    Dim cmd As New SqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Student Fees Partially Paid")
                    StName.Text = ""
                    StSem.Text = ""
                    StDep.Text = ""
                    StCurrentFees.Text = ""
                    StOldFees.Text = ""
                    Result.Text = ""
                    Paid.Text = ""
                    Dim query2 = "update StudentTable set StTotalPayment=StTotalPayment+'" & x & "'where StId=" & k & ""
                    Dim cmd2 As New SqlCommand(query2, con)
                    cmd2.ExecuteNonQuery()
                    con.close()
                    display()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Adst_Click(sender As Object, e As EventArgs) Handles Adst.Click
        Dim ad = New Student()
        ad.Show()
        Me.Hide()
    End Sub

    Private Sub SrSt_Click(sender As Object, e As EventArgs) Handles SrSt.Click
        Dim sr = New StdSearch()
        sr.Show()
        Me.Hide()
    End Sub
End Class