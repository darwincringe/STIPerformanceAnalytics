﻿Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports BCrypt.Net

Public Class UserModule
    Private Shared _username As String
    Private Shared _firstName As String
    Private Shared _lastName As String
    Private Shared _middleName As String
    Private Shared _birthdate As Date
    Private Shared _email As String
    Private Shared _userType As String
    Private Shared _userId As String

    ' Properties
    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property MiddleName As String
        Get
            Return _middleName
        End Get
        Set(value As String)
            _middleName = value
        End Set
    End Property

    Public Property Birthdate As Date
        Get
            Return _birthdate
        End Get
        Set(value As Date)
            _birthdate = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property UserType As String
        Get
            Return _userType
        End Get
        Set(value As String)
            _userType = value
        End Set
    End Property

    Public Property UserId As String
        Get
            Return _userId
        End Get
        Set(value As String)
            _userId = value
        End Set
    End Property

    Public Sub SetUser(username As String, firstName As String, lastName As String, middleName As String, birthdate As Date, email As String, userType As String, userId As String)
        _username = username
        _firstName = firstName
        _lastName = lastName
        _middleName = middleName
        _birthdate = birthdate
        _email = email
        _userType = userType
        _userId = userId
    End Sub

    Public Function GetUser() As String
        Return $"{_firstName} {_lastName}"
    End Function

    Public ReadOnly Property FullName As String
        Get
            Return $"{FirstName} {LastName}"
        End Get
    End Property

    Public Sub Logout()
        _username = String.Empty
        _firstName = String.Empty
        _lastName = String.Empty
        _middleName = String.Empty
        _birthdate = DateTime.MinValue
        _email = String.Empty
        _userType = String.Empty
        _userId = String.Empty
    End Sub

    Private Function ValidateUserInputs(username As String, firstName As String, lastName As String, email As String, birthdate As String) As Boolean
        If String.IsNullOrWhiteSpace(username) Then
            MessageBox.Show("Username is required.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(firstName) Then
            MessageBox.Show("First name is required.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(lastName) Then
            MessageBox.Show("Last name is required.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Email is required.")
            Return False
        End If

        If String.IsNullOrWhiteSpace(birthdate) OrElse Not Date.TryParse(birthdate, Nothing) Then
            MessageBox.Show("Valid birthdate is required.")
            Return False
        End If

        Dim emailPattern As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        If Not Regex.IsMatch(email, emailPattern) Then
            MessageBox.Show("Please enter a valid email address.")
            Return False
        End If

        Return True
    End Function

    Private Function IsUniqueUser(username As String, email As String, userId As String) As Boolean
        Dim connectionString As String = Globals.connectionString
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM users WHERE (username = @Username OR email = @Email) AND id <> @UserId"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@UserId", userId)

                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Username or email already exists.")
                        Return False
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error connecting to database: " & ex.Message)
                Return False
            End Try
        End Using

        Return True
    End Function

    Public Function UpdateUser(userId As String, username As String, firstName As String, middleName As String, lastName As String, email As String, birthdate As String) As Boolean
        If Not ValidateUserInputs(username, firstName, lastName, email, birthdate) Then
            Return False
        End If

        If Not IsUniqueUser(username, email, userId) Then
            Return False
        End If

        Dim connectionString As String = Globals.connectionString
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE users SET username = @Username, firstname = @Firstname, middlename = @Middlename, lastname = @Lastname, email = @Email, birthdate = @Birthdate WHERE id = @UserId"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Firstname", firstName)
                    command.Parameters.AddWithValue("@Middlename", If(String.IsNullOrWhiteSpace(middleName), DBNull.Value, middleName))
                    command.Parameters.AddWithValue("@Lastname", lastName)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Birthdate", Date.Parse(birthdate))
                    command.Parameters.AddWithValue("@UserId", userId)

                    command.ExecuteNonQuery()

                    SetUser(
                        username,
                        firstName,
                        lastName,
                        middleName,
                        Date.Parse(birthdate),
                        email,
                        _userType,
                        userId
                    )

                    Return True
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error updating database: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    Public Function CreateUser(username As String, firstName As String, middleName As String, lastName As String, email As String, birthdate As String, password As String, confirmPassword As String, isAdmin As Boolean) As Integer
        If Not ValidateUserInputs(username, firstName, lastName, email, birthdate) Then
            Return -1
        End If

        ' Validate password
        Dim userModule As New UserModule
        If Not userModule.ValidatePassword(password, confirmPassword) Then
            Return -2
        End If


        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)

        Dim connectionString As String = Globals.connectionString
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                Dim userType As String = If(isAdmin, "admin", "student")

                Dim query As String = "INSERT INTO users (username, firstname, middlename, lastname, email, birthdate, type, password) VALUES (@Username, @Firstname, @Middlename, @Lastname, @Email, @Birthdate, @UserType, @Password)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", username)
                    command.Parameters.AddWithValue("@Firstname", firstName)
                    command.Parameters.AddWithValue("@Middlename", If(String.IsNullOrWhiteSpace(middleName), DBNull.Value, middleName))
                    command.Parameters.AddWithValue("@Lastname", lastName)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Birthdate", Date.Parse(birthdate))
                    command.Parameters.AddWithValue("@UserType", userType)
                    command.Parameters.AddWithValue("@Password", hashedPassword)

                    command.ExecuteNonQuery()

                    query = "SELECT LAST_INSERT_ID()"
                    command.CommandText = query
                    Dim userId As Integer = Convert.ToInt32(command.ExecuteScalar())

                    Return userId
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error creating user: " & ex.Message)
                Return -3
            End Try
        End Using
    End Function

    Public Function GetAllStudents() As List(Of Student)
        Dim students As New List(Of Student)()
        Using connection As New MySqlConnection(Globals.connectionString)
            Try
                connection.Open()
                Dim query As String = "
                SELECT 
                    id,
                    username,
                    firstname,
                    middlename,
                    lastname,
                    birthdate,
                    email
                FROM 
                    users 
                WHERE 
                    type = 'student'"

                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim student As New Student()
                            student.Id = Convert.ToInt32(reader("id"))
                            student.Username = reader("username").ToString()
                            student.FirstName = reader("firstname").ToString()
                            student.MiddleName = reader("middlename").ToString()
                            student.LastName = reader("lastname").ToString()
                            student.Birthdate = Convert.ToDateTime(reader("birthdate"))
                            student.Email = reader("email").ToString()
                            students.Add(student)
                        End While
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error fetching students: " & ex.Message)
            End Try
        End Using
        Return students
    End Function

    Public Sub DeleteStudent(studentId As Integer)
        Dim connectionString As String = Globals.connectionString
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "DELETE FROM users WHERE id = @StudentId"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@StudentId", studentId)
                    command.ExecuteNonQuery()
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error deleting student: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Function ChangePassword(userId As Integer, newPassword As String, confirmPassword As String) As Boolean
        Dim userModule As New UserModule
        If Not userModule.ValidatePassword(newPassword, confirmPassword) Then
            Return False
        End If

        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(newPassword)

        Try
            ' Update the password in the database
            Using connection As New MySqlConnection(Globals.connectionString)
                connection.Open()
                Dim query As String = "UPDATE users SET password = @Password WHERE id = @UserId"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Password", hashedPassword)
                    command.Parameters.AddWithValue("@UserId", userId)
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function ValidatePassword(newPassword As String, confirmPassword As String) As Boolean
        If newPassword.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not newPassword.Equals(confirmPassword) Then
            MessageBox.Show("Password and password confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

End Class
