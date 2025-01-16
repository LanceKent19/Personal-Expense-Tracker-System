Imports MySql.Data.MySqlClient

Public Class Form1
    Private ReadOnly connString As String = "Server=localhost;Database=expensetracker_db;User ID=root;Password=;"
    Private i As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the DateTimePicker format
        date_picker.Format = DateTimePickerFormat.Custom
        date_picker.CustomFormat = "yyyy-MM-dd"
        LoadCategories()
        LoadData()
        ToggleControls(False, False, False)
        expenseid_txt.ReadOnly = True

    End Sub

    ' Load Categories from category_tb into ComboBox
    Private Sub LoadCategories()
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "SELECT category_name FROM category_tb"
                Using cmd As New MySqlCommand(query, conn)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        category_cb.Items.Clear()
                        While dr.Read()
                            category_cb.Items.Add(dr("category_name").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to load categories: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadData()
        DataGridView1.Rows.Clear()

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT * FROM expense_tb", conn)
                    Using dr = cmd.ExecuteReader()
                        While dr.Read()
                            DataGridView1.Rows.Add(dr("expense_id"), dr("category"), dr("description"),
                                               CDate(dr("date")).ToString("yyyy-MM-dd"), dr("amount"))
                        End While
                    End Using
                End Using
            End Using

            ' Calculate total amount after loading data
            CalculateTotalAmount()

            If DataGridView1.Rows.Count = 0 Then MessageBox.Show("No records found.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CalculateTotalAmount()
        Dim total As Decimal = 0

        ' Use column index 4 for the "amount" column
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells(4).Value)
            End If
        Next

        totalamount_label.Text = total.ToString()
    End Sub

    Private Sub Save()
        If Not ValidateInputs() Then Exit Sub

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO expense_tb (category, description, date, amount) VALUES (@Category, @Description, @Date, @Amount)", conn)
                    AddParameters(cmd)
                    i = cmd.ExecuteNonQuery()
                    ShowMessage(i, "Record Saved Successfully!", "Record Save Failed!")
                End Using
            End Using
            Clear()
            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Edit()
        If Not ValidateInputs() Then Exit Sub

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("UPDATE expense_tb SET category=@Category, description=@Description, date=@Date, amount=@Amount WHERE expense_id=@ExpenseId", conn)
                    AddParameters(cmd)
                    i = cmd.ExecuteNonQuery()
                    ShowMessage(i, "Record Updated Successfully!", "Record Update Failed!")
                End Using
            End Using
            Clear()
            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Delete()
        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Using conn As New MySqlConnection(connString)
                    conn.Open()
                    Using cmd As New MySqlCommand("DELETE FROM expense_tb WHERE expense_id=@ExpenseId", conn)
                        cmd.Parameters.AddWithValue("@ExpenseId", expenseid_txt.Text)
                        i = cmd.ExecuteNonQuery()
                        ShowMessage(i, "Record Deleted Successfully!", "Record Delete Failed!")
                    End Using
                End Using
                Clear()
                LoadData()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub SearchData()
        DataGridView1.Rows.Clear()

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand("SELECT * FROM expense_tb WHERE expense_id LIKE @Search OR category LIKE @Search OR description LIKE @Search OR date LIKE @Search OR amount LIKE @Search ", conn)
                    cmd.Parameters.AddWithValue("@Search", "%" & txt_search.Text & "%")
                    Using dr = cmd.ExecuteReader()
                        While dr.Read()
                            DataGridView1.Rows.Add(dr("expense_id"), dr("category"), dr("description"), CDate(dr("date")).ToString("yyyy-MM-dd"), dr("amount"))
                        End While
                    End Using
                End Using
            End Using

            If DataGridView1.Rows.Count = 0 Then MessageBox.Show("No records found.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Clear()
        expenseid_txt.Clear()
        description_txt.Clear()
        category_cb.SelectedIndex = -1 ' Clears ComboBox selection
        amount_txt.Clear()
    End Sub

    Private Sub AddParameters(cmd As MySqlCommand)
        cmd.Parameters.AddWithValue("@ExpenseId", expenseid_txt.Text)
        cmd.Parameters.AddWithValue("@Category", category_cb.Text)
        cmd.Parameters.AddWithValue("@Description", description_txt.Text)
        cmd.Parameters.AddWithValue("@Date", date_picker.Value.ToString("yyyy-MM-dd"))
        cmd.Parameters.AddWithValue("@Amount", amount_txt.Text)
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(category_cb.Text) OrElse
           String.IsNullOrWhiteSpace(description_txt.Text) OrElse
           String.IsNullOrWhiteSpace(amount_txt.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return False
        End If
        Return True
    End Function

    Private Sub ShowMessage(result As Integer, successMsg As String, errorMsg As String)
        MessageBox.Show(If(result > 0, successMsg, errorMsg))
    End Sub

    ' --- Toggle Controls Function ---
    Private Sub ToggleControls(enableTextBoxes As Boolean, enableEditButtons As Boolean, enableAddButtons As Boolean)
        ' Enable Textboxes
        description_txt.Enabled = enableTextBoxes
        category_cb.Enabled = enableTextBoxes
        date_picker.Enabled = enableTextBoxes
        amount_txt.Enabled = enableTextBoxes

        ' Enable Edit/Delete/Update Buttons
        update_btn.Enabled = enableEditButtons
        delete_btn.Enabled = enableEditButtons
        clear_btn.Enabled = enableEditButtons Or enableAddButtons

        ' Enable Save Button Only in Add Mode
        save_btn.Enabled = enableAddButtons
    End Sub

    ' Event Handlers
    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        Save()
        Clear()
        ToggleControls(False, False, False) ' Reset after saving
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Edit()
        Clear()
        ToggleControls(False, False, False) ' Reset after updating
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Delete()
        Clear()
        ToggleControls(False, False, False) ' Reset after deleting
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        Clear()
        ToggleControls(False, False, False) ' Reset after clearing
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Clear()
        ToggleControls(True, False, True) ' Enable textboxes and Save button
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        SearchData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row = DataGridView1.Rows(e.RowIndex)
            expenseid_txt.Text = row.Cells(0).Value.ToString()
            category_cb.Text = row.Cells(1).Value.ToString()
            description_txt.Text = row.Cells(2).Value.ToString()
            amount_txt.Text = row.Cells(4).Value.ToString()

            Dim selectedDate As DateTime
            If DateTime.TryParse(row.Cells(3).Value.ToString(), selectedDate) Then
                date_picker.Value = selectedDate
            Else
                MessageBox.Show("Invalid date format.")
            End If
            ' Enable Edit/Delete Mode (Add is not enabled)
            ToggleControls(True, True, False)
            update_btn.Enabled = False
        End If
    End Sub
    ' Compare initial values to current textbox values
    Private Sub EnableUpdateIfModified()
        If expenseid_txt.Text <> "" AndAlso
           (category_cb.Text <> DataGridView1.CurrentRow.Cells(1).Value.ToString() OrElse
            description_txt.Text <> DataGridView1.CurrentRow.Cells(2).Value.ToString() OrElse
            date_picker.Value.ToString("yyyy-MM-dd") <> DataGridView1.CurrentRow.Cells(3).Value.ToString() OrElse
            amount_txt.Text <> DataGridView1.CurrentRow.Cells(4).Value.ToString()) Then

            update_btn.Enabled = True ' Enable only if modified
        Else
            update_btn.Enabled = False ' Disable if no change
        End If
    End Sub

    Private Sub txt_firstname_TextChanged(sender As Object, e As EventArgs)
        EnableUpdateIfModified()
    End Sub

    Private Sub txt_lastname_TextChanged(sender As Object, e As EventArgs) Handles description_txt.TextChanged
        EnableUpdateIfModified()
    End Sub

    Private Sub txt_studentno_TextChanged(sender As Object, e As EventArgs) Handles amount_txt.TextChanged
        EnableUpdateIfModified()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles date_picker.ValueChanged
        EnableUpdateIfModified()
    End Sub

    Private Sub totalamount_label_Click(sender As Object, e As EventArgs) Handles totalamount_label.Click

    End Sub
    Private Sub FilterData()
        DataGridView1.Rows.Clear()

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' SQL query with date filter
                Dim query As String = "SELECT * FROM expense_tb WHERE date BETWEEN @FromDate AND @ToDate"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@FromDate", datepicker_from.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ToDate", datepicker_to.Value.ToString("yyyy-MM-dd"))

                    Using dr = cmd.ExecuteReader()
                        While dr.Read()
                            DataGridView1.Rows.Add(dr("expense_id"), dr("category"), dr("description"),
                                               CDate(dr("date")).ToString("yyyy-MM-dd"), dr("amount"))
                        End While
                    End Using
                End Using
            End Using

            ' Calculate total amount after filtering
            CalculateTotalAmount()

            If DataGridView1.Rows.Count = 0 Then MessageBox.Show("No records found.")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub datepicker_from_ValueChanged(sender As Object, e As EventArgs) Handles datepicker_from.ValueChanged
        FilterData()
    End Sub

    Private Sub datepicker_to_ValueChanged(sender As Object, e As EventArgs) Handles datepicker_to.ValueChanged
        FilterData()
    End Sub

    Private Sub category_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles category_cb.SelectedIndexChanged

    End Sub

    Private Sub summary_btn_Click(sender As Object, e As EventArgs) Handles summary_btn.Click
        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                ' Calculate Total, Average, Max, Min Expenses
                Using cmd As New MySqlCommand("
                SELECT 
                    IFNULL(SUM(amount), 0) AS TotalExpenses, 
                    IFNULL(AVG(amount), 0) AS AverageExpense, 
                    IFNULL(MAX(amount), 0) AS HighestExpense, 
                    IFNULL(MIN(amount), 0) AS LowestExpense 
                FROM expense_tb", conn)
                    Using dr = cmd.ExecuteReader()
                        If dr.Read() Then
                            Dim summary As String = $"Summary Report:" & Environment.NewLine &
                                                    $"----------------------------" & Environment.NewLine &
                                                    $"Total Expenses: {dr("TotalExpenses")}" & Environment.NewLine &
                                                    $"Average Expense: {dr("AverageExpense")}" & Environment.NewLine &
                                                    $"Highest Expense: {dr("HighestExpense")}" & Environment.NewLine &
                                                    $"Lowest Expense: {dr("LowestExpense")}"
                            MessageBox.Show(summary, "Summary Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using

                ' Breakdown by Category
                Using cmd As New MySqlCommand("
                SELECT category, IFNULL(SUM(amount), 0) AS TotalCategory 
                FROM expense_tb 
                GROUP BY category", conn)
                    Using dr = cmd.ExecuteReader()
                        Dim breakdown As String = "Category Breakdown:" & Environment.NewLine &
                                                  "----------------------------" & Environment.NewLine
                        While dr.Read()
                            breakdown &= $"{dr("category")}: {dr("TotalCategory")}" & Environment.NewLine
                        End While
                        MessageBox.Show(breakdown, "Category Breakdown", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        ' Confirm logout action with a dialog box
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?",
                                                 "Confirm Logout",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            ' Create an instance of LoginPage
            Dim loginForm As New LoginPage

            ' Show the Login page
            loginForm.ShowDialog()

            ' Hide the current form (Form1)
            Me.Close()
        End If
    End Sub
End Class
