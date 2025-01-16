Imports MySql.Data.MySqlClient

Public Class LoginPage
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Try
            Using conn As New MySqlConnection("Server=localhost;Database=expensetracker_db;User ID=root;Password=;")
                conn.Open()

                ' Check username and password
                Using cmd As New MySqlCommand("SELECT username FROM user_tb WHERE username=@Username AND password=@Password", conn)
                    cmd.Parameters.AddWithValue("@Username", username_tb.Text)
                    cmd.Parameters.AddWithValue("@Password", password_tb.Text)

                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        MessageBox.Show($"Welcome, {result}!!!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        Dim mainForm As New Form1
                        mainForm.ShowDialog()
                        Me.Close() ' Close login form after main form is close

                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        username_tb.Text = ""
        password_tb.Text = ""
        showpass_btn.Checked = False ' Reset the checkbox when clearing
    End Sub

    Private Sub showpass_btn_CheckedChanged(sender As Object, e As EventArgs) Handles showpass_btn.CheckedChanged
        If showpass_btn.Checked Then
            password_tb.PasswordChar = "" ' Show the password
        Else
            password_tb.PasswordChar = "*" ' Mask the password
        End If
    End Sub

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login_btn.Enabled = False
    End Sub

    Private Sub register_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles register_link.LinkClicked
        Dim registerForm As New RegisterPage
        registerForm.TopMost = True   ' Ensure it overlays the current form
        registerForm.ShowDialog()
    End Sub
    Private Sub InputFields_TextChanged(sender As Object, e As EventArgs) _
      Handles username_tb.TextChanged, password_tb.TextChanged

        ' Enable register button only if all fields are filled
        login_btn.Enabled = Not (String.IsNullOrWhiteSpace(username_tb.Text) Or
                                    String.IsNullOrWhiteSpace(password_tb.Text))
    End Sub
End Class