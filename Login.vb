Public Class Login
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Image = My.Resources.image_processing20200609_12570_ccioui
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
            CheckBox1.Image = My.Resources.OOjs_UI_icon_eyeClosed_svg
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Please enter username and password")
        ElseIf TextBox1.Text = "Username" And TextBox2.Text = "password" Then
            Dim obj = New Main
            obj.Show()
            Me.Hide()
        Else
            MsgBox("Username and passwword donot match.Please Try again")
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class