<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleCRUD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SimpleCRUD))
        Label1 = New Label()
        student_no_txtb = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        add_btn = New Button()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 14)
        Label1.TabIndex = 0
        Label1.Text = "Student Number:"
        ' 
        ' student_no_txtb
        ' 
        student_no_txtb.Location = New Point(17, 33)
        student_no_txtb.Name = "student_no_txtb"
        student_no_txtb.Size = New Size(111, 22)
        student_no_txtb.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(174, 33)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 22)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(174, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 14)
        Label2.TabIndex = 2
        Label2.Text = "Firstname:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(414, 33)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(188, 22)
        TextBox2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(414, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 14)
        Label3.TabIndex = 4
        Label3.Text = "Lastname:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(661, 33)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(191, 22)
        TextBox3.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(661, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 14)
        Label4.TabIndex = 6
        Label4.Text = "Student No."
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(0, 41)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(781, 259)
        DataGridView1.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.Control
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(student_no_txtb)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(0, 301)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(864, 67)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Entry:"
        ' 
        ' add_btn
        ' 
        add_btn.BackgroundImageLayout = ImageLayout.Center
        add_btn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        add_btn.ForeColor = Color.CornflowerBlue
        add_btn.Image = CType(resources.GetObject("add_btn.Image"), Image)
        add_btn.Location = New Point(15, 371)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(62, 43)
        add_btn.TabIndex = 10
        add_btn.TextAlign = ContentAlignment.MiddleLeft
        add_btn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.CornflowerBlue
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(96, 371)
        Button1.Name = "Button1"
        Button1.Size = New Size(56, 43)
        Button1.TabIndex = 11
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' SimpleCRUD
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(781, 420)
        Controls.Add(Button1)
        Controls.Add(add_btn)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "SimpleCRUD"
        Text = "CRUD"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents student_no_txtb As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents add_btn As Button
    Friend WithEvents Button1 As Button
End Class
