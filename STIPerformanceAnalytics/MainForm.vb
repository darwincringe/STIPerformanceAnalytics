Imports MySql.Data.MySqlClient
Imports BCrypt.Net
Imports Mysqlx.XDevAPI.Common

Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If ValidateLogin(username, password) Then
            MessageBox.Show("Login successful!")
            ' Proceed with opening the admin panel or next form
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub

    Private Function ValidateLogin(username As String, password As String) As Boolean
        Using connection As New MySqlConnection(Globals.connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT password FROM Users WHERE username = @username"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim storedHash As String = reader("password").ToString()
                        If BCrypt.Net.BCrypt.Verify(password, storedHash) Then
                            Console.WriteLine("Login Success")
                            Return True
                        End If
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error connecting to database: " & ex.Message)
            End Try
        End Using
        Return False
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim adminForm As New AdminLoginForm()
        adminForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' Perform your desired action here
            ' For example, you can trigger the login process
            btnLogin_Click(sender, e)
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' Enable key preview for the form
    End Sub
End Class
