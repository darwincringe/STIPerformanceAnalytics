<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        btnLogout = New Button()
        studentName = New Label()
        Label4 = New Label()
        TabControl1 = New TabControl()
        TabPage3 = New TabPage()
        surveyDataGrid = New DataGridView()
        id = New DataGridViewTextBoxColumn()
        student_id = New DataGridViewTextBoxColumn()
        student_name = New DataGridViewTextBoxColumn()
        suggested_degree = New DataGridViewTextBoxColumn()
        created_date = New DataGridViewTextBoxColumn()
        action = New DataGridViewButtonColumn()
        TabPage1 = New TabPage()
        Panel1 = New Panel()
        Button1 = New Button()
        usersDatagrid = New DataGridView()
        studentid = New DataGridViewTextBoxColumn()
        studetname = New DataGridViewTextBoxColumn()
        username = New DataGridViewTextBoxColumn()
        email = New DataGridViewTextBoxColumn()
        birthdate = New DataGridViewTextBoxColumn()
        edit = New DataGridViewButtonColumn()
        Delete = New DataGridViewButtonColumn()
        middlename = New DataGridViewTextBoxColumn()
        firstname = New DataGridViewTextBoxColumn()
        lastname = New DataGridViewTextBoxColumn()
        btnCreate = New Button()
        TabPage2 = New TabPage()
        Button2 = New Button()
        textUsername = New TextBox()
        textPassword = New TextBox()
        Label9 = New Label()
        Label6 = New Label()
        textBirthdate = New TextBox()
        textPasswordConfirmation = New TextBox()
        btnUpdate = New Button()
        Label10 = New Label()
        textEmail = New TextBox()
        Label11 = New Label()
        textLastname = New TextBox()
        textMiddlename = New TextBox()
        textFirstname = New TextBox()
        Label8 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TabControl1.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(surveyDataGrid, ComponentModel.ISupportInitialize).BeginInit()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(usersDatagrid, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(709, 33)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(75, 23)
        btnLogout.TabIndex = 24
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' studentName
        ' 
        studentName.AutoSize = True
        studentName.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        studentName.Location = New Point(57, 25)
        studentName.Name = "studentName"
        studentName.Size = New Size(143, 30)
        studentName.TabIndex = 23
        studentName.Text = "Admin Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 30)
        Label4.TabIndex = 22
        Label4.Text = "Hi, "
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 78)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 373)
        TabControl1.TabIndex = 25
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(surveyDataGrid)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(768, 345)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Survey Dashboard"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' surveyDataGrid
        ' 
        surveyDataGrid.AllowUserToAddRows = False
        surveyDataGrid.AllowUserToDeleteRows = False
        surveyDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        surveyDataGrid.Columns.AddRange(New DataGridViewColumn() {id, student_id, student_name, suggested_degree, created_date, action})
        surveyDataGrid.Dock = DockStyle.Fill
        surveyDataGrid.Location = New Point(0, 0)
        surveyDataGrid.Name = "surveyDataGrid"
        surveyDataGrid.Size = New Size(768, 345)
        surveyDataGrid.TabIndex = 31
        ' 
        ' id
        ' 
        id.HeaderText = "ID"
        id.Name = "id"
        id.Visible = False
        ' 
        ' student_id
        ' 
        student_id.HeaderText = "Student ID"
        student_id.Name = "student_id"
        student_id.Resizable = DataGridViewTriState.True
        ' 
        ' student_name
        ' 
        student_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        student_name.HeaderText = "Student Name"
        student_name.Name = "student_name"
        ' 
        ' suggested_degree
        ' 
        suggested_degree.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        suggested_degree.HeaderText = "Suggested Degree"
        suggested_degree.Name = "suggested_degree"
        ' 
        ' created_date
        ' 
        created_date.HeaderText = "Created Date"
        created_date.Name = "created_date"
        created_date.Width = 130
        ' 
        ' action
        ' 
        action.HeaderText = "Action"
        action.Name = "action"
        action.Text = "View"
        action.Width = 70
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 345)
        TabPage1.TabIndex = 0
        TabPage1.Text = "User Management"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(usersDatagrid)
        Panel1.Controls.Add(btnCreate)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(762, 339)
        Panel1.TabIndex = 24
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(134, 11)
        Button1.Name = "Button1"
        Button1.Size = New Size(77, 23)
        Button1.TabIndex = 33
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' usersDatagrid
        ' 
        usersDatagrid.AllowUserToAddRows = False
        usersDatagrid.AllowUserToDeleteRows = False
        usersDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        usersDatagrid.Columns.AddRange(New DataGridViewColumn() {studentid, studetname, username, email, birthdate, edit, Delete, middlename, firstname, lastname})
        usersDatagrid.Location = New Point(3, 45)
        usersDatagrid.Name = "usersDatagrid"
        usersDatagrid.Size = New Size(756, 294)
        usersDatagrid.TabIndex = 32
        ' 
        ' studentid
        ' 
        studentid.HeaderText = "Student ID"
        studentid.Name = "studentid"
        studentid.Resizable = DataGridViewTriState.True
        ' 
        ' studetname
        ' 
        studetname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        studetname.HeaderText = "Student Name"
        studetname.Name = "studetname"
        ' 
        ' username
        ' 
        username.HeaderText = "Username"
        username.Name = "username"
        ' 
        ' email
        ' 
        email.HeaderText = "Email"
        email.Name = "email"
        ' 
        ' birthdate
        ' 
        birthdate.HeaderText = "Birthdate"
        birthdate.Name = "birthdate"
        birthdate.Width = 130
        ' 
        ' edit
        ' 
        edit.HeaderText = "Edit"
        edit.Name = "edit"
        edit.Text = "Edit"
        edit.Width = 45
        ' 
        ' Delete
        ' 
        Delete.HeaderText = "Delete"
        Delete.Name = "Delete"
        Delete.Resizable = DataGridViewTriState.True
        Delete.SortMode = DataGridViewColumnSortMode.Automatic
        Delete.Width = 55
        ' 
        ' middlename
        ' 
        middlename.HeaderText = "Middlename"
        middlename.Name = "middlename"
        middlename.Visible = False
        ' 
        ' firstname
        ' 
        firstname.HeaderText = "First Name"
        firstname.Name = "firstname"
        firstname.Visible = False
        ' 
        ' lastname
        ' 
        lastname.HeaderText = "Lastname"
        lastname.Name = "lastname"
        lastname.Visible = False
        ' 
        ' btnCreate
        ' 
        btnCreate.Location = New Point(3, 11)
        btnCreate.Name = "btnCreate"
        btnCreate.Size = New Size(118, 23)
        btnCreate.TabIndex = 29
        btnCreate.Text = "Create Student"
        btnCreate.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Button2)
        TabPage2.Controls.Add(textUsername)
        TabPage2.Controls.Add(textPassword)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(textBirthdate)
        TabPage2.Controls.Add(textPasswordConfirmation)
        TabPage2.Controls.Add(btnUpdate)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(textEmail)
        TabPage2.Controls.Add(Label11)
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
        TabPage2.Size = New Size(768, 345)
        TabPage2.TabIndex = 1
        TabPage2.Text = "User Information"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(575, 134)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 23)
        Button2.TabIndex = 10
        Button2.Text = "Change Password"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' textUsername
        ' 
        textUsername.Location = New Point(140, 65)
        textUsername.Name = "textUsername"
        textUsername.Size = New Size(177, 23)
        textUsername.TabIndex = 1
        ' 
        ' textPassword
        ' 
        textPassword.Location = New Point(516, 68)
        textPassword.Name = "textPassword"
        textPassword.PasswordChar = "*"c
        textPassword.Size = New Size(177, 23)
        textPassword.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(26, 66)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 21)
        Label9.TabIndex = 38
        Label9.Text = "Username:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(370, 69)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 21)
        Label6.TabIndex = 63
        Label6.Text = "New Password:"
        ' 
        ' textBirthdate
        ' 
        textBirthdate.Location = New Point(140, 193)
        textBirthdate.Name = "textBirthdate"
        textBirthdate.Size = New Size(177, 23)
        textBirthdate.TabIndex = 5
        ' 
        ' textPasswordConfirmation
        ' 
        textPasswordConfirmation.Location = New Point(516, 99)
        textPasswordConfirmation.Name = "textPasswordConfirmation"
        textPasswordConfirmation.PasswordChar = "*"c
        textPasswordConfirmation.Size = New Size(177, 23)
        textPasswordConfirmation.TabIndex = 9
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(242, 268)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 7
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(370, 100)
        Label10.Name = "Label10"
        Label10.Size = New Size(140, 21)
        Label10.TabIndex = 61
        Label10.Text = "Confirm Password:"
        ' 
        ' textEmail
        ' 
        textEmail.Location = New Point(140, 225)
        textEmail.Name = "textEmail"
        textEmail.Size = New Size(177, 23)
        textEmail.TabIndex = 6
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(367, 23)
        Label11.Name = "Label11"
        Label11.Size = New Size(166, 30)
        Label11.TabIndex = 60
        Label11.Text = "Security Settings"
        ' 
        ' textLastname
        ' 
        textLastname.Location = New Point(140, 160)
        textLastname.Name = "textLastname"
        textLastname.Size = New Size(177, 23)
        textLastname.TabIndex = 4
        ' 
        ' textMiddlename
        ' 
        textMiddlename.Location = New Point(140, 126)
        textMiddlename.Name = "textMiddlename"
        textMiddlename.Size = New Size(177, 23)
        textMiddlename.TabIndex = 3
        ' 
        ' textFirstname
        ' 
        textFirstname.Location = New Point(140, 96)
        textFirstname.Name = "textFirstname"
        textFirstname.Size = New Size(177, 23)
        textFirstname.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(26, 127)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 21)
        Label8.TabIndex = 30
        Label8.Text = "Middlename:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(23, 23)
        Label5.Name = "Label5"
        Label5.Size = New Size(169, 30)
        Label5.TabIndex = 25
        Label5.Text = "User Information"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(26, 161)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 21)
        Label7.TabIndex = 21
        Label7.Text = "Lastname:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 21)
        Label1.TabIndex = 21
        Label1.Text = "Firstname:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 194)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 21)
        Label2.TabIndex = 23
        Label2.Text = "Birthdate:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(26, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 21)
        Label3.TabIndex = 24
        Label3.Text = "Email:"
        ' 
        ' AdminHome
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Controls.Add(btnLogout)
        Controls.Add(studentName)
        Controls.Add(Label4)
        Name = "AdminHome"
        Text = "AdminHome"
        TabControl1.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        CType(surveyDataGrid, ComponentModel.ISupportInitialize).EndInit()
        TabPage1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(usersDatagrid, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents studentName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPage2 As TabPage
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
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnCreate As Button
    Friend WithEvents usersDatagrid As DataGridView
    Friend WithEvents surveyDataGrid As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents student_id As DataGridViewTextBoxColumn
    Friend WithEvents student_name As DataGridViewTextBoxColumn
    Friend WithEvents suggested_degree As DataGridViewTextBoxColumn
    Friend WithEvents created_date As DataGridViewTextBoxColumn
    Friend WithEvents action As DataGridViewButtonColumn
    Friend WithEvents studentid As DataGridViewTextBoxColumn
    Friend WithEvents studetname As DataGridViewTextBoxColumn
    Friend WithEvents username As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents birthdate As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents middlename As DataGridViewTextBoxColumn
    Friend WithEvents firstname As DataGridViewTextBoxColumn
    Friend WithEvents lastname As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents textPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textPasswordConfirmation As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
