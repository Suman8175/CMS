
Imports System.Data.SqlClient
Public Class Dash
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Acer Nitro 5\Documents\CollegeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Dim t = New Main()
        t.Show()
        Me.Hide()
    End Sub
    Private Sub stcount()
        Dim stn As Integer
        con.open()
        Dim query = "select COUNT(StId) from StudentTable"
        Dim cmd As New SqlCommand(query, con)
        stn = cmd.ExecuteScalar
        NoStudents.Text = stn
        con.close()
    End Sub

    Private Sub teaccoun()
        Dim teac As Integer
        con.open()
        Dim query = "select COUNT(TId) from TeacherTable"
        Dim cmd As New SqlCommand(query, con)
        teac = cmd.ExecuteScalar
        NoTeachers.Text = teac
        con.close()
    End Sub

    Private Sub depcoun()
        Dim depc As Integer
        con.open()
        Dim query = "select COUNT(DepId) from DepartmentTable"
        Dim cmd As New SqlCommand(query, con)
        depc = cmd.ExecuteScalar
        NoDepartments.Text = depc
        con.close()
    End Sub
    Private Sub feec()
        Dim fcou As Integer
        con.open()
        Dim query = "select SUM(StTotalPayment) from StudentTable"
        Dim cmd As New SqlCommand(query, con)
        fcou = cmd.ExecuteScalar
        TotalFees.Text = fcou
        con.close()
    End Sub

    Private Sub lll()
        Dim cc, bb, aa As Integer
        con.open()
        Dim query = "select SUM(StCurrentFees) from StudentTable"
        Dim cmd As New SqlCommand(query, con)
        cc = cmd.ExecuteScalar
        Dim query2 = "select SUM(StOldFees) from StudentTable"
        Dim cmd2 As New SqlCommand(query2, con)
        bb = cmd2.ExecuteScalar
        aa = cc + bb
        TotalFeesRemaining.Text = aa
        con.close()
    End Sub

    Private Sub asf()
        Dim cc As Integer
        con.open()
        Dim query = "select SUM(TPayment) from TeacherTable"
        Dim cmd As New SqlCommand(query, con)
        cc = cmd.ExecuteScalar
        TotalSalary.Text = cc
        con.close()
    End Sub
    Private Sub Dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stcount()
        teaccoun()
        depcoun()
        feec()
        lll()
        asf()
    End Sub

    Private Sub ape_Click(sender As Object, e As EventArgs) Handles ape.Click
        Dim gsdf = New Department()
        gsdf.Show()
        Me.Hide()
    End Sub

    Private Sub Asn_Click(sender As Object, e As EventArgs) Handles Asn.Click
        Dim jh = New Student()
        jh.Show()
        Me.Hide()
    End Sub

    Private Sub aty_Click(sender As Object, e As EventArgs) Handles aty.Click
        Dim qi = New Teacher()
        qi.Show()
        Me.Hide()
    End Sub
End Class