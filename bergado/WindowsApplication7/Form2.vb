Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form2
    Private conn As MySqlconnection
    Private cmd As MySqlcommand
    Private selectedimagepath As String = ""
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=newlogin")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.IsNullOrWhiteSpace(fname.Text) OrElse
                   String.IsNullOrWhiteSpace(lname.Text) OrElse
                    String.IsNullOrWhiteSpace(age.Text) OrElse
                    String.IsNullOrWhiteSpace(uname.Text) OrElse
                    String.IsNullOrWhiteSpace(pass.Text) OrElse
                    String.IsNullOrWhiteSpace(email.Text) Then

                MessageBox.Show("Please fill out all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


        Catch ex As Exception
                MessageBox.Show("Please fill out all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Dim gender As String = ""
        If male.Checked Then
            gender = "Male"
        ElseIf female.Checked Then
            gender = "Female"
        Else
            MessageBox.Show("please select gender")
        End If


        Dim sql As String = "INSERT INTO newuser" & "(ID, Fname, Lname, Age, Gender, Username, Password, Email, profile image)" &
            "VALUES (@ID, @Fnames, @Lname, @Ages, @Gender, @Usernames, @Passwords, @Email, 'User', 'Active', @profile image)"
        conn.Open()
        cmd = New MySqlCommand(sql, conn)

        cmd.Parameters.AddWithValue("@Fname", fname.Text.Trim())
        cmd.Parameters.AddWithValue("@Lname", lname.Text.Trim())
        cmd.Parameters.AddWithValue("@Gender", gender)
        cmd.Parameters.AddWithValue("@Username", uname.Text.Trim())
        cmd.Parameters.AddWithValue("@Password", pass.Text.Trim())
        cmd.Parameters.AddWithValue("@Email", email.Text.Trim())
        cmd.Parameters.AddWithValue("@ProfileImage", If(String.IsNullOrEmpty(selectedimagepath),
            DBNull.Value, Path.GetFileName(selectedimagepath)))

        cmd.ExecuteNonQuery()

        MessageBox.Show("Registration Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        fname.Clear()
        lname.Clear()
        age.Clear()
        uname.Clear()
        pass.Clear()
        email.Clear()
        male.Checked = False
        female.Checked = False
        pimage.Image = Nothing
        selectedimagepath = ""

        Try
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        fname.Clear()
        lname.Clear()
        age.Clear()
        uname.Clear()
        pass.Clear()
        email.Clear()
        male.Checked = False
        female.Checked = False
        pimage.Image = Nothing
        selectedimagepath = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                selectedimagepath = ofd.FileName
                pimage.Image = Image.FromFile(selectedimagepath)

            End If
        End Using
    End Sub
End Class