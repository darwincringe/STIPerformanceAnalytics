Imports MySql.Data.MySqlClient
Imports BCrypt.Net
Imports Mysqlx.XDevAPI.Common
Imports Microsoft.VisualBasic.ApplicationServices

Module LoginModule
    Dim user As New UserModule()
    Function ValidateLogin(username As String, password As String, Optional userType As String = "student") As Boolean
        Using connection As New MySqlConnection(Globals.connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT * FROM Users WHERE username = @username AND type = @userType"
                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@userType", userType)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim storedHash As String = reader("password").ToString()
                        If BCrypt.Net.BCrypt.Verify(password, storedHash) Then
                            Console.WriteLine("Login Success")

                            User.SetUser(
                                reader("username").ToString(),
                                reader("firstname").ToString(),
                                reader("lastname").ToString(),
                                reader("middlename").ToString(),
                                DateTime.Parse(reader("birthdate").ToString()),
                                reader("email").ToString(),
                                reader("type").ToString(),
                                reader("id").ToString().PadLeft(4, "0"c)
                            )

                            MessageBox.Show("Welcome back, " & User.FirstName)
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

End Module
