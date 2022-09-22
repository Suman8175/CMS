Imports System.Data.SqlClient
Public Class payte
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer Nitro 5\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub di()
        con.open()
        Dim query = "select TId,TName,TDep,TSalary from TeacherTable"
        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgt.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Private Sub src(v As String)
        con.open()
        Dim searchquery = "SELECT TId,TName,TDep,TSalary from TeacherTable WHERE CONCAT(TName,TDep,TSalary) like '%" & v & "%'"
        Dim cmd As New SqlCommand(searchquery, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgt.DataSource = table
        con.close()
    End Sub

    Private Sub payte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        di()
        src("")
    End Sub

    Private Sub srchic_Click(sender As Object, e As EventArgs) Handles srchic.Click
        src(srchcode.Text)
    End Sub

    Private Sub bc_Click(sender As Object, e As EventArgs) Handles bc.Click
        Dim a = New Main()
        a.Show()
        Me.Hide()
    End Sub

    Dim ky = 0

    Private Sub dgt_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgt.CellMouseClick
        Dim row As DataGridViewRow = dgt.Rows(e.RowIndex)
        TName.Text = row.Cells(1).Value.ToString
        TDep.Text = row.Cells(2).Value.ToString
        TSalary.Text = row.Cells(3).Value.ToString
        ky = Convert.ToInt32(row.Cells(0).Value.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TName.Text = "" Or TDep.Text = "" Or TSalary.Text = "" Or payme.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.open()
                Dim query = "update TeacherTable set TPayment=TPayment+'" & payme.Text & "',TSalary=TSalary-'" & payme.Text & "' where TId=" & ky & ""
                Dim cmd As New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                con.close()
                TName.Text = ""
                TDep.Text = ""
                TSalary.Text = ""
                payme.Text = ""
                di()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub jgf_Click(sender As Object, e As EventArgs) Handles jgf.Click
        Dim pg = New Teacher()
        pg.Show()
        Me.Hide()
    End Sub

    Private Sub okkl_Click(sender As Object, e As EventArgs) Handles okkl.Click
        Dim k = New TeacherSearch()
        k.Show()
        Me.Hide()
    End Sub
End Class