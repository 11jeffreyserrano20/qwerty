Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connStr As String = "server=localhost;user id=root;password=;database=newlogin"

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles T1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection(connStr)

        Try
            conn.Open()

            Dim query As String = "SELECT * FROM newuser WHERE username=@username AND password=@password"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", T1.Text)
            cmd.Parameters.AddWithValue("@password", T2.Text)

            reader = cmd.ExecuteReader

            If reader.HasRows Then
                MessageBox.Show("LogIn Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                T1.Focus()
                T2.Clear()
            End If


        Catch ex As Exception
            MessageBox.Show("ERROR:" & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
