<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterPage))
        Label1 = New Label()
        username_tb = New TextBox()
        clear_btn = New Button()
        register_btn = New Button()
        Label2 = New Label()
        password_tb = New TextBox()
        confirmpass_tb = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(100, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 14)
        Label1.TabIndex = 8
        Label1.Text = "Username:"
        ' 
        ' username_tb
        ' 
        username_tb.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        username_tb.Location = New Point(101, 69)
        username_tb.Name = "username_tb"
        username_tb.Size = New Size(210, 22)
        username_tb.TabIndex = 1
        ' 
        ' clear_btn
        ' 
        clear_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        clear_btn.Cursor = Cursors.Hand
        clear_btn.Location = New Point(224, 231)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(87, 43)
        clear_btn.TabIndex = 5
        clear_btn.Text = "Clear"
        clear_btn.UseVisualStyleBackColor = True
        ' 
        ' register_btn
        ' 
        register_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        register_btn.Cursor = Cursors.Hand
        register_btn.Location = New Point(101, 231)
        register_btn.Name = "register_btn"
        register_btn.Size = New Size(87, 43)
        register_btn.TabIndex = 4
        register_btn.Text = "Register"
        register_btn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(100, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 14)
        Label2.TabIndex = 13
        Label2.Text = "Password:"
        ' 
        ' password_tb
        ' 
        password_tb.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        password_tb.Location = New Point(100, 131)
        password_tb.Name = "password_tb"
        password_tb.PasswordChar = "*"c
        password_tb.Size = New Size(211, 22)
        password_tb.TabIndex = 2
        ' 
        ' confirmpass_tb
        ' 
        confirmpass_tb.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        confirmpass_tb.Location = New Point(101, 197)
        confirmpass_tb.Name = "confirmpass_tb"
        confirmpass_tb.PasswordChar = "*"c
        confirmpass_tb.Size = New Size(210, 22)
        confirmpass_tb.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(101, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 14)
        Label3.TabIndex = 16
        Label3.Text = "Confirm:"
        ' 
        ' RegisterPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(419, 315)
        Controls.Add(confirmpass_tb)
        Controls.Add(Label3)
        Controls.Add(clear_btn)
        Controls.Add(password_tb)
        Controls.Add(Label2)
        Controls.Add(register_btn)
        Controls.Add(username_tb)
        Controls.Add(Label1)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "RegisterPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "REGISTER"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents username_tb As TextBox
    Friend WithEvents clear_btn As Button
    Friend WithEvents register_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents password_tb As TextBox
    Friend WithEvents confirmpass_tb As TextBox
    Friend WithEvents Label3 As Label
End Class
