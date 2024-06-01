<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDetailCreate
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
        Button1 = New Button()
        textPassword = New TextBox()
        Label6 = New Label()
        textPasswordConfirmation = New TextBox()
        Label10 = New Label()
        textUsername = New TextBox()
        Label9 = New Label()
        textBirthdate = New TextBox()
        textEmail = New TextBox()
        textLastname = New TextBox()
        textMiddlename = New TextBox()
        textFirstname = New TextBox()
        Label8 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        isAdminCheckBox = New CheckBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(576, 145)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 23)
        Button1.TabIndex = 10
        Button1.Text = "Create User"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' textPassword
        ' 
        textPassword.Location = New Point(517, 79)
        textPassword.Name = "textPassword"
        textPassword.PasswordChar = "*"c
        textPassword.Size = New Size(177, 23)
        textPassword.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(371, 80)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 21)
        Label6.TabIndex = 77
        Label6.Text = "New Password:"
        ' 
        ' textPasswordConfirmation
        ' 
        textPasswordConfirmation.Location = New Point(517, 110)
        textPasswordConfirmation.Name = "textPasswordConfirmation"
        textPasswordConfirmation.PasswordChar = "*"c
        textPasswordConfirmation.Size = New Size(177, 23)
        textPasswordConfirmation.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(371, 111)
        Label10.Name = "Label10"
        Label10.Size = New Size(140, 21)
        Label10.TabIndex = 75
        Label10.Text = "Confirm Password:"
        ' 
        ' textUsername
        ' 
        textUsername.Location = New Point(163, 76)
        textUsername.Name = "textUsername"
        textUsername.Size = New Size(177, 23)
        textUsername.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(49, 77)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 21)
        Label9.TabIndex = 72
        Label9.Text = "Username:"
        ' 
        ' textBirthdate
        ' 
        textBirthdate.Location = New Point(163, 204)
        textBirthdate.Name = "textBirthdate"
        textBirthdate.Size = New Size(177, 23)
        textBirthdate.TabIndex = 5
        textBirthdate.Text = "01/01/2000"
        ' 
        ' textEmail
        ' 
        textEmail.Location = New Point(163, 236)
        textEmail.Name = "textEmail"
        textEmail.Size = New Size(177, 23)
        textEmail.TabIndex = 6
        ' 
        ' textLastname
        ' 
        textLastname.Location = New Point(163, 171)
        textLastname.Name = "textLastname"
        textLastname.Size = New Size(177, 23)
        textLastname.TabIndex = 4
        ' 
        ' textMiddlename
        ' 
        textMiddlename.Location = New Point(163, 137)
        textMiddlename.Name = "textMiddlename"
        textMiddlename.Size = New Size(177, 23)
        textMiddlename.TabIndex = 3
        ' 
        ' textFirstname
        ' 
        textFirstname.Location = New Point(163, 107)
        textFirstname.Name = "textFirstname"
        textFirstname.Size = New Size(177, 23)
        textFirstname.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(49, 138)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 21)
        Label8.TabIndex = 65
        Label8.Text = "Middlename:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(46, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 30)
        Label5.TabIndex = 64
        Label5.Text = "Create New User"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(49, 172)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 21)
        Label7.TabIndex = 60
        Label7.Text = "Lastname:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(49, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 21)
        Label1.TabIndex = 61
        Label1.Text = "Firstname:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(49, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 62
        Label2.Text = "Birthdate:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(49, 237)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 63
        Label3.Text = "Email:"
        ' 
        ' isAdminCheckBox
        ' 
        isAdminCheckBox.AutoSize = True
        isAdminCheckBox.Location = New Point(163, 278)
        isAdminCheckBox.Name = "isAdminCheckBox"
        isAdminCheckBox.Size = New Size(62, 19)
        isAdminCheckBox.TabIndex = 7
        isAdminCheckBox.Text = "Admin"
        isAdminCheckBox.UseVisualStyleBackColor = True
        ' 
        ' StudentDetailCreate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(isAdminCheckBox)
        Controls.Add(Button1)
        Controls.Add(textPassword)
        Controls.Add(Label6)
        Controls.Add(textPasswordConfirmation)
        Controls.Add(Label10)
        Controls.Add(textUsername)
        Controls.Add(Label9)
        Controls.Add(textBirthdate)
        Controls.Add(textEmail)
        Controls.Add(textLastname)
        Controls.Add(textMiddlename)
        Controls.Add(textFirstname)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Name = "StudentDetailCreate"
        Text = "StudentDetailCreate"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents textPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textPasswordConfirmation As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents textUsername As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textBirthdate As TextBox
    Friend WithEvents textEmail As TextBox
    Friend WithEvents textLastname As TextBox
    Friend WithEvents textMiddlename As TextBox
    Friend WithEvents textFirstname As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents isAdminCheckBox As CheckBox
End Class
