Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text


Public Class RegisterPage
    Private connString As String = "Server=localhost;Database=expensetracker_db;User ID=root;Password=;"

    Private Sub RegisterPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        register_btn.Enabled = False ' Disable button initially
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        username_tb.Text = ""
        password_tb.Text = ""
        confirmpass_tb.Text = ""
    End Sub
    Private Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Dim sb As New StringBuilder()
            For Each b As Byte In hash
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        ' Validate passwords match
        If password_tb.Text <> confirmpass_tb.Text Then
            MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Check if username already exists
                Dim checkQuery As String = "SELECT COUNT(*) FROM user_tb WHERE username = @Username"
                Using checkCmd As New MySqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@Username", username_tb.Text)
                    Dim userExists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If userExists > 0 Then
                        MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Hash the password before storing
                Dim hashedPassword As String = HashPassword(password_tb.Text)

                ' Insert new user
                Dim query As String = "INSERT INTO user_tb (username, password) VALUES (@Username, @Password)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", username_tb.Text)
                    cmd.Parameters.AddWithValue("@Password", hashedPassword)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        clear_btn_Click(Nothing, Nothing) ' Clear fields after success
                        Me.Close()
                    Else
                        MessageBox.Show("Registration Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Enable Register Button when all fields are filled
    Private Sub InputFields_TextChanged(sender As Object, e As EventArgs) _
        Handles username_tb.TextChanged, password_tb.TextChanged, confirmpass_tb.TextChanged
        register_btn.Enabled = Not (String.IsNullOrWhiteSpace(username_tb.Text) Or
                                    String.IsNullOrWhiteSpace(password_tb.Text) Or
                                    String.IsNullOrWhiteSpace(confirmpass_tb.Text))
    End Sub
End Class
