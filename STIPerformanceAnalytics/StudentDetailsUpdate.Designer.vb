<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDetailsUpdate
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
        textUsername = New TextBox()
        Label9 = New Label()
        textBirthdate = New TextBox()
        btnUpdate = New Button()
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
        Label4 = New Label()
        textPassword = New TextBox()
        Label6 = New Label()
        textPasswordConfirmation = New TextBox()
        Label10 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' textUsername
        ' 
        textUsername.Location = New Point(144, 68)
        textUsername.Name = "textUsername"
        textUsername.Size = New Size(177, 23)
        textUsername.TabIndex = 53
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(30, 69)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 21)
        Label9.TabIndex = 52
        Label9.Text = "Username:"
        ' 
        ' textBirthdate
        ' 
        textBirthdate.Location = New Point(144, 196)
        textBirthdate.Name = "textBirthdate"
        textBirthdate.Size = New Size(177, 23)
        textBirthdate.TabIndex = 51
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(246, 271)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 50
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' textEmail
        ' 
        textEmail.Location = New Point(144, 228)
        textEmail.Name = "textEmail"
        textEmail.Size = New Size(177, 23)
        textEmail.TabIndex = 49
        ' 
        ' textLastname
        ' 
        textLastname.Location = New Point(144, 163)
        textLastname.Name = "textLastname"
        textLastname.Size = New Size(177, 23)
        textLastname.TabIndex = 48
        ' 
        ' textMiddlename
        ' 
        textMiddlename.Location = New Point(144, 129)
        textMiddlename.Name = "textMiddlename"
        textMiddlename.Size = New Size(177, 23)
        textMiddlename.TabIndex = 47
        ' 
        ' textFirstname
        ' 
        textFirstname.Location = New Point(144, 99)
        textFirstname.Name = "textFirstname"
        textFirstname.Size = New Size(177, 23)
        textFirstname.TabIndex = 46
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(30, 130)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 21)
        Label8.TabIndex = 45
        Label8.Text = "Middlename:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(27, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(169, 30)
        Label5.TabIndex = 44
        Label5.Text = "User Information"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(30, 164)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 21)
        Label7.TabIndex = 40
        Label7.Text = "Lastname:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(30, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 21)
        Label1.TabIndex = 41
        Label1.Text = "Firstname:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 197)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 42
        Label2.Text = "Birthdate:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(30, 229)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 43
        Label3.Text = "Email:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(410, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(166, 30)
        Label4.TabIndex = 54
        Label4.Text = "Security Settings"
        ' 
        ' textPassword
        ' 
        textPassword.Location = New Point(559, 71)
        textPassword.Name = "textPassword"
        textPassword.PasswordChar = "*"c
        textPassword.Size = New Size(177, 23)
        textPassword.TabIndex = 58
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(413, 72)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 21)
        Label6.TabIndex = 57
        Label6.Text = "New Password:"
        ' 
        ' textPasswordConfirmation
        ' 
        textPasswordConfirmation.Location = New Point(559, 102)
        textPasswordConfirmation.Name = "textPasswordConfirmation"
        textPasswordConfirmation.PasswordChar = "*"c
        textPasswordConfirmation.Size = New Size(177, 23)
        textPasswordConfirmation.TabIndex = 56
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(413, 103)
        Label10.Name = "Label10"
        Label10.Size = New Size(140, 21)
        Label10.TabIndex = 55
        Label10.Text = "Confirm Password:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(618, 137)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 23)
        Button1.TabIndex = 59
        Button1.Text = "Change Password"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' StudentDetailsUpdate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(textPassword)
        Controls.Add(Label6)
        Controls.Add(textPasswordConfirmation)
        Controls.Add(Label10)
        Controls.Add(Label4)
        Controls.Add(textUsername)
        Controls.Add(Label9)
        Controls.Add(textBirthdate)
        Controls.Add(btnUpdate)
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
        Name = "StudentDetailsUpdate"
        Text = "StudentDetailsUpdate"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textUsername As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textBirthdate As TextBox
    Friend WithEvents btnUpdate As Button
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
    Friend WithEvents Label4 As Label
    Friend WithEvents textPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textPasswordConfirmation As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
End Class
