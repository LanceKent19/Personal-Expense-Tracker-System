<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        save_btn = New Button()
        update_btn = New Button()
        delete_btn = New Button()
        clear_btn = New Button()
        description_txt = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        amount_txt = New TextBox()
        txt_search = New TextBox()
        GroupBox1 = New GroupBox()
        category_cb = New ComboBox()
        Label6 = New Label()
        date_picker = New DateTimePicker()
        expenseid_txt = New TextBox()
        Label4 = New Label()
        add_btn = New Button()
        Label5 = New Label()
        Label7 = New Label()
        totalamount_label = New Label()
        datepicker_from = New DateTimePicker()
        datepicker_to = New DateTimePicker()
        Label8 = New Label()
        Label9 = New Label()
        summary_btn = New Button()
        logout_btn = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(77, 148)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(757, 277)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Expense ID"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Category"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "Description"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "Date"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Amount"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' save_btn
        ' 
        save_btn.BackColor = Color.White
        save_btn.Cursor = Cursors.Hand
        save_btn.Location = New Point(63, -1)
        save_btn.Margin = New Padding(4, 3, 4, 3)
        save_btn.Name = "save_btn"
        save_btn.Size = New Size(65, 28)
        save_btn.TabIndex = 1
        save_btn.Text = "Save"
        save_btn.UseVisualStyleBackColor = False
        ' 
        ' update_btn
        ' 
        update_btn.BackColor = Color.White
        update_btn.Cursor = Cursors.Hand
        update_btn.Location = New Point(127, -1)
        update_btn.Margin = New Padding(4, 3, 4, 3)
        update_btn.Name = "update_btn"
        update_btn.Size = New Size(65, 28)
        update_btn.TabIndex = 2
        update_btn.Text = "Update"
        update_btn.UseVisualStyleBackColor = False
        ' 
        ' delete_btn
        ' 
        delete_btn.BackColor = Color.White
        delete_btn.Cursor = Cursors.Hand
        delete_btn.Location = New Point(191, -1)
        delete_btn.Margin = New Padding(4, 3, 4, 3)
        delete_btn.Name = "delete_btn"
        delete_btn.Size = New Size(65, 28)
        delete_btn.TabIndex = 5
        delete_btn.Text = "Delete"
        delete_btn.UseVisualStyleBackColor = False
        ' 
        ' clear_btn
        ' 
        clear_btn.BackColor = Color.White
        clear_btn.Cursor = Cursors.Hand
        clear_btn.Location = New Point(255, -1)
        clear_btn.Margin = New Padding(4, 3, 4, 3)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(65, 28)
        clear_btn.TabIndex = 6
        clear_btn.Text = "Clear"
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' description_txt
        ' 
        description_txt.CharacterCasing = CharacterCasing.Upper
        description_txt.Location = New Point(373, 48)
        description_txt.Name = "description_txt"
        description_txt.Size = New Size(164, 23)
        description_txt.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(373, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(77, 14)
        Label1.TabIndex = 11
        Label1.Text = "Description"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(185, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 14)
        Label2.TabIndex = 12
        Label2.Text = "Category"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(742, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 14)
        Label3.TabIndex = 13
        Label3.Text = "Amount"
        ' 
        ' amount_txt
        ' 
        amount_txt.Location = New Point(742, 47)
        amount_txt.Name = "amount_txt"
        amount_txt.Size = New Size(164, 23)
        amount_txt.TabIndex = 16
        ' 
        ' txt_search
        ' 
        txt_search.CharacterCasing = CharacterCasing.Upper
        txt_search.Location = New Point(77, 119)
        txt_search.Name = "txt_search"
        txt_search.PlaceholderText = "Search Here...."
        txt_search.Size = New Size(282, 23)
        txt_search.TabIndex = 17
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox1.BackColor = Color.White
        GroupBox1.Controls.Add(category_cb)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(date_picker)
        GroupBox1.Controls.Add(expenseid_txt)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(description_txt)
        GroupBox1.Controls.Add(amount_txt)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(0, 464)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(919, 94)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Entry:"
        ' 
        ' category_cb
        ' 
        category_cb.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        category_cb.FormattingEnabled = True
        category_cb.Location = New Point(185, 48)
        category_cb.Name = "category_cb"
        category_cb.Size = New Size(163, 22)
        category_cb.TabIndex = 21
        category_cb.Text = "SELECT CATEGORY"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(573, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 14)
        Label6.TabIndex = 20
        Label6.Text = "Date"
        ' 
        ' date_picker
        ' 
        date_picker.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        date_picker.Format = DateTimePickerFormat.Short
        date_picker.Location = New Point(573, 49)
        date_picker.Name = "date_picker"
        date_picker.Size = New Size(115, 22)
        date_picker.TabIndex = 19
        date_picker.Value = New Date(2024, 12, 13, 9, 19, 25, 0)
        ' 
        ' expenseid_txt
        ' 
        expenseid_txt.Location = New Point(6, 47)
        expenseid_txt.Name = "expenseid_txt"
        expenseid_txt.Size = New Size(164, 23)
        expenseid_txt.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(7, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 14)
        Label4.TabIndex = 18
        Label4.Text = "Expense ID"
        ' 
        ' add_btn
        ' 
        add_btn.BackColor = Color.White
        add_btn.Cursor = Cursors.Hand
        add_btn.Location = New Point(-1, -1)
        add_btn.Margin = New Padding(4, 3, 4, 3)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(65, 28)
        add_btn.TabIndex = 20
        add_btn.Text = "New"
        add_btn.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlDarkDark
        Label5.Location = New Point(274, 55)
        Label5.Name = "Label5"
        Label5.Size = New Size(404, 32)
        Label5.TabIndex = 21
        Label5.Text = "Personal Expense Tracker"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Location = New Point(77, 437)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 16)
        Label7.TabIndex = 22
        Label7.Text = "Total Amount:"
        ' 
        ' totalamount_label
        ' 
        totalamount_label.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        totalamount_label.AutoSize = True
        totalamount_label.Font = New Font("Verdana", 9.75F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        totalamount_label.Location = New Point(182, 437)
        totalamount_label.Name = "totalamount_label"
        totalamount_label.Size = New Size(15, 16)
        totalamount_label.TabIndex = 23
        totalamount_label.Text = "0"
        totalamount_label.TextAlign = ContentAlignment.TopRight
        ' 
        ' datepicker_from
        ' 
        datepicker_from.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datepicker_from.Format = DateTimePickerFormat.Short
        datepicker_from.Location = New Point(500, 117)
        datepicker_from.Name = "datepicker_from"
        datepicker_from.Size = New Size(110, 22)
        datepicker_from.TabIndex = 24
        ' 
        ' datepicker_to
        ' 
        datepicker_to.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datepicker_to.Format = DateTimePickerFormat.Short
        datepicker_to.Location = New Point(706, 117)
        datepicker_to.Name = "datepicker_to"
        datepicker_to.Size = New Size(128, 22)
        datepicker_to.TabIndex = 25
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(456, 123)
        Label8.Name = "Label8"
        Label8.Size = New Size(38, 14)
        Label8.TabIndex = 26
        Label8.Text = "From"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(679, 123)
        Label9.Name = "Label9"
        Label9.Size = New Size(21, 14)
        Label9.TabIndex = 27
        Label9.Text = "To"
        ' 
        ' summary_btn
        ' 
        summary_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        summary_btn.BackColor = Color.White
        summary_btn.Cursor = Cursors.Hand
        summary_btn.Location = New Point(703, 431)
        summary_btn.Margin = New Padding(4, 3, 4, 3)
        summary_btn.Name = "summary_btn"
        summary_btn.Size = New Size(131, 28)
        summary_btn.TabIndex = 28
        summary_btn.Text = "Summary Report"
        summary_btn.UseVisualStyleBackColor = False
        ' 
        ' logout_btn
        ' 
        logout_btn.BackColor = Color.Transparent
        logout_btn.BackgroundImageLayout = ImageLayout.None
        logout_btn.Cursor = Cursors.Hand
        logout_btn.FlatAppearance.BorderColor = Color.White
        logout_btn.FlatAppearance.BorderSize = 0
        logout_btn.FlatAppearance.MouseDownBackColor = Color.Transparent
        logout_btn.FlatAppearance.MouseOverBackColor = Color.Transparent
        logout_btn.FlatStyle = FlatStyle.Flat
        logout_btn.Location = New Point(722, -1)
        logout_btn.Name = "logout_btn"
        logout_btn.Size = New Size(197, 28)
        logout_btn.TabIndex = 30
        logout_btn.Text = "Hi, Username"
        logout_btn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(918, 557)
        Controls.Add(logout_btn)
        Controls.Add(summary_btn)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(datepicker_to)
        Controls.Add(datepicker_from)
        Controls.Add(totalamount_label)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(add_btn)
        Controls.Add(GroupBox1)
        Controls.Add(txt_search)
        Controls.Add(clear_btn)
        Controls.Add(delete_btn)
        Controls.Add(update_btn)
        Controls.Add(save_btn)
        Controls.Add(DataGridView1)
        Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        MinimumSize = New Size(934, 596)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Personal Expense Tracker"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents save_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents clear_btn As Button
    Friend WithEvents description_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents amount_txt As TextBox
    Friend WithEvents txt_search As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents expenseid_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents add_btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents date_picker As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents totalamount_label As Label
    Friend WithEvents datepicker_from As DateTimePicker
    Friend WithEvents datepicker_to As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents category_cb As ComboBox
    Friend WithEvents summary_btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents logout_btn As Button

End Class
