<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentHome
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
        components = New ComponentModel.Container()
        Label4 = New Label()
        studentName = New Label()
        UserModuleBindingSource = New BindingSource(components)
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Panel1 = New Panel()
        Label6 = New Label()
        TabPage2 = New TabPage()
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
        btnLogout = New Button()
        CType(UserModuleBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 30)
        Label4.TabIndex = 18
        Label4.Text = "Hi, "
        ' 
        ' studentName
        ' 
        studentName.AutoSize = True
        studentName.DataBindings.Add(New Binding("Text", UserModuleBindingSource, "FullName", True))
        studentName.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studentName.Location = New Point(57, 27)
        studentName.Name = "studentName"
        studentName.Size = New Size(154, 30)
        studentName.TabIndex = 19
        studentName.Text = "Student Name"
        ' 
        ' UserModuleBindingSource
        ' 
        UserModuleBindingSource.DataSource = GetType(UserModule)
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 78)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 360)
        TabControl1.TabIndex = 20
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 332)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Survey Dashboard"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(Label6)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(762, 326)
        Panel1.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.DataBindings.Add(New Binding("Text", UserModuleBindingSource, "FullName", True))
        Label6.Font = New Font("Segoe UI", 20.25F)
        Label6.Location = New Point(7, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(666, 37)
        Label6.TabIndex = 22
        Label6.Text = "Please answer the survey to get your suggested degree"
        Label6.Visible = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(textUsername)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(textBirthdate)
        TabPage2.Controls.Add(btnUpdate)
        TabPage2.Controls.Add(textEmail)
        TabPage2.Controls.Add(textLastname)
        TabPage2.Controls.Add(textMiddlename)
        TabPage2.Controls.Add(textFirstname)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label1)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(Label3)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 332)
        TabPage2.TabIndex = 1
        TabPage2.Text = "User Information"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' textUsername
        ' 
        textUsername.Location = New Point(140, 65)
        textUsername.Name = "textUsername"
        textUsername.Size = New Size(177, 23)
        textUsername.TabIndex = 39
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(23, 63)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 21)
        Label9.TabIndex = 38
        Label9.Text = "Username:"
        ' 
        ' textBirthdate
        ' 
        textBirthdate.Location = New Point(140, 193)
        textBirthdate.Name = "textBirthdate"
        textBirthdate.Size = New Size(177, 23)
        textBirthdate.TabIndex = 37
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(242, 268)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 36
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' textEmail
        ' 
        textEmail.Location = New Point(140, 225)
        textEmail.Name = "textEmail"
        textEmail.Size = New Size(177, 23)
        textEmail.TabIndex = 35
        ' 
        ' textLastname
        ' 
        textLastname.Location = New Point(140, 160)
        textLastname.Name = "textLastname"
        textLastname.Size = New Size(177, 23)
        textLastname.TabIndex = 33
        ' 
        ' textMiddlename
        ' 
        textMiddlename.Location = New Point(140, 126)
        textMiddlename.Name = "textMiddlename"
        textMiddlename.Size = New Size(177, 23)
        textMiddlename.TabIndex = 32
        ' 
        ' textFirstname
        ' 
        textFirstname.Location = New Point(140, 96)
        textFirstname.Name = "textFirstname"
        textFirstname.Size = New Size(177, 23)
        textFirstname.TabIndex = 31
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(23, 124)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 21)
        Label8.TabIndex = 30
        Label8.Text = "Middlename:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(20, 20)
        Label5.Name = "Label5"
        Label5.Size = New Size(169, 30)
        Label5.TabIndex = 25
        Label5.Text = "User Information"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(23, 158)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 21)
        Label7.TabIndex = 21
        Label7.Text = "Lastname:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 21)
        Label1.TabIndex = 21
        Label1.Text = "Firstname:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 23
        Label2.Text = "Birthdate:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(23, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 24
        Label3.Text = "Email:"
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(709, 35)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 21
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' StudentHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogout)
        Controls.Add(TabControl1)
        Controls.Add(studentName)
        Controls.Add(Label4)
        DataBindings.Add(New Binding("Text", UserModuleBindingSource, "FullName", True))
        Name = "StudentHome"
        Text = "Home"
        CType(UserModuleBindingSource, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents studentName As Label
    Friend WithEvents UserModuleBindingSource As BindingSource
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents textEmail As TextBox
    Friend WithEvents textLastname As TextBox
    Friend WithEvents textMiddlename As TextBox
    Friend WithEvents textFirstname As TextBox
    Friend WithEvents dateBirthdate As DateTimePicker
    Friend WithEvents textBirthdate As TextBox
    Friend WithEvents textUsername As TextBox
    Friend WithEvents Label9 As Label
End Class
