Public Class AdminLoginForm
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub AdminLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AdminLoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim userType As String = "admin"

        If LoginModule.ValidateLogin(username, password, userType) Then
            MessageBox.Show("Login successful!")
            ' Hide login form and show main form
            ' Me.Hide()
            ResetInputs()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Perform your desired action here
            ' For example, you can trigger the login process
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub ResetInputs()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Enable key preview for the form
    End Sub
End Class