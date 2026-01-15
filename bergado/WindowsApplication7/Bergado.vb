Imports MySql.Data.MySqlClient

Public Class Form3
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    ' ✅ Change this based on your XAMPP settings
    Private connStr As String = "server=localhost;userid=root;password=;database=roel"

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ========= FORM LOAD =========
        LoadStudents()

        Tsearch.Text = "🔍 Search..."
        Tsearch.ForeColor = Color.Gray
    End Sub
    Private Sub tsearch_Enter(sender As Object, e As EventArgs) Handles Tsearch.Enter
        If Tsearch.Text = "🔍 Search..." Then
            Tsearch.Text = ""
            Tsearch.ForeColor = Color.Black
        End If
    End Sub

    ' Handle Leave event
    Private Sub tsearch_Leave(sender As Object, e As EventArgs) Handles Tsearch.Leave
        If Tsearch.Text = "" Then
            Tsearch.Text = "🔍 Search..."
            Tsearch.ForeColor = Color.Gray
        End If
    End Sub
    ' ========= LOAD STUDENTS =========
    Private Sub LoadStudents(Optional search As String = "")
        Try
            Using connection As New MySqlConnection(connStr)
                connection.Open()
                Dim query As String = "SELECT * FROM sia WHERE Fullname LIKE @search OR Subject LIKE @search OR Score LIKE @search"
                Using da As New MySqlDataAdapter(query, connection)
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" & search & "%")
                    Dim dt As New DataTable
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error: " & ex.Message)
        End Try
    End Sub



    Private Sub badd_Click(sender As Object, e As EventArgs) Handles badd.Click
        Try
            Using connection As New MySqlConnection(connStr)
                connection.Open()
                Dim query As String = "INSERT INTO sia (Fullname,Subject,Score) VALUES (@fullname, @subject, @score)"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@fullname", Fullname.Text)
                    cmd.Parameters.AddWithValue("@subject", Subject.Text)
                    cmd.Parameters.AddWithValue("@score", Score.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("✅ Student Added Successfully!")
            LoadStudents()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("❌ Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Bupdate_Click(sender As Object, e As EventArgs) Handles Bupdate.Click
        If id.Text = "" Then
            MessageBox.Show("⚠ Please select a student to update.")
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(connStr)
                connection.Open()
                Dim query As String = "UPDATE sia SET Fullname=@fullname, Subject=@subject, Score=@score WHERE ID=@id"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@fullname", Fullname.Text)
                    cmd.Parameters.AddWithValue("@subject", Subject.Text)
                    cmd.Parameters.AddWithValue("@score", Score.Text)
                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("✅ Student Updated Successfully!")
            LoadStudents()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("❌ Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Bdelete_Click(sender As Object, e As EventArgs) Handles Bdelete.Click
        If id.Text = "" Then
            MessageBox.Show("⚠ Please select a student to delete.")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(connStr)
                connection.Open()
                Dim query As String = "DELETE FROM sia WHERE ID=@id"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("🗑 Student Deleted Successfully!")
            LoadStudents()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("❌ Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Tsearch_TextChanged(sender As Object, e As EventArgs) Handles Tsearch.TextChanged
        LoadStudents(Tsearch.Text)
        If Tsearch.Text <> "🔍 Search..." Then
            LoadStudents(Tsearch.Text)
        End If
    End Sub

    ' ========= SELECT ROW =========
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            id.Text = row.Cells("ID").Value.ToString()
            Fullname.Text = row.Cells("Fullname").Value.ToString()
            Subject.Text = row.Cells("Subject").Value.ToString()
            Score.Text = row.Cells("Score").Value.ToString()
        End If
    End Sub

    ' ========= CLEAR FIELDS =========
    Private Sub ClearFields()
        id.Clear()
        Fullname.Clear()
        Subject.Clear()
        Score.Clear()
    End Sub

    Private Sub Tname_TextChanged(sender As Object, e As EventArgs) Handles Fullname.TextChanged

    End Sub

    Private Sub Tpurok_TextChanged(sender As Object, e As EventArgs) Handles Subject.TextChanged

    End Sub

    Private Sub id_TextChanged(sender As Object, e As EventArgs) Handles id.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LAbel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub sbni_TextChanged(sender As Object, e As EventArgs) Handles Score.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class