<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Label1 = New Label()
        username_tb = New TextBox()
        showpass_btn = New CheckBox()
        login_btn = New Button()
        register_link = New LinkLabel()
        Label2 = New Label()
        password_tb = New TextBox()
        clear_btn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 14)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' username_tb
        ' 
        username_tb.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        username_tb.Location = New Point(67, 89)
        username_tb.Name = "username_tb"
        username_tb.Size = New Size(270, 22)
        username_tb.TabIndex = 1
        ' 
        ' showpass_btn
        ' 
        showpass_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        showpass_btn.AutoSize = True
        showpass_btn.Cursor = Cursors.Hand
        showpass_btn.Location = New Point(66, 179)
        showpass_btn.Name = "showpass_btn"
        showpass_btn.Size = New Size(127, 18)
        showpass_btn.TabIndex = 2
        showpass_btn.Text = "Show Password"
        showpass_btn.UseVisualStyleBackColor = True
        ' 
        ' login_btn
        ' 
        login_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        login_btn.Cursor = Cursors.Hand
        login_btn.Location = New Point(66, 217)
        login_btn.Name = "login_btn"
        login_btn.Size = New Size(87, 43)
        login_btn.TabIndex = 3
        login_btn.Text = "Login"
        login_btn.UseVisualStyleBackColor = True
        ' 
        ' register_link
        ' 
        register_link.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        register_link.AutoSize = True
        register_link.LinkColor = Color.Black
        register_link.Location = New Point(262, 183)
        register_link.Name = "register_link"
        register_link.Size = New Size(59, 14)
        register_link.TabIndex = 4
        register_link.TabStop = True
        register_link.Text = "Register"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(66, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 14)
        Label2.TabIndex = 5
        Label2.Text = "Password:"
        ' 
        ' password_tb
        ' 
        password_tb.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        password_tb.Location = New Point(66, 151)
        password_tb.Name = "password_tb"
        password_tb.PasswordChar = "*"c
        password_tb.Size = New Size(270, 22)
        password_tb.TabIndex = 6
        ' 
        ' clear_btn
        ' 
        clear_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        clear_btn.Cursor = Cursors.Hand
        clear_btn.Location = New Point(249, 217)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(87, 43)
        clear_btn.TabIndex = 7
        clear_btn.Text = "Clear"
        clear_btn.UseVisualStyleBackColor = True
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(403, 290)
        Controls.Add(clear_btn)
        Controls.Add(password_tb)
        Controls.Add(Label2)
        Controls.Add(register_link)
        Controls.Add(login_btn)
        Controls.Add(showpass_btn)
        Controls.Add(username_tb)
        Controls.Add(Label1)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(419, 329)
        Name = "LoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents username_tb As TextBox
    Friend WithEvents showpass_btn As CheckBox
    Friend WithEvents login_btn As Button
    Friend WithEvents register_link As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents password_tb As TextBox
    Friend WithEvents clear_btn As Button
End Class
