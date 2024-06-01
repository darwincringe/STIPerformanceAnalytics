
Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim userType As String = "student"

        If LoginModule.ValidateLogin(username, password, userType) Then
            Dim studentHome As New StudentHome()
            studentHome.Show()
            ResetInputs()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim adminForm As New AdminLoginForm()
        adminForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub ResetInputs()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
