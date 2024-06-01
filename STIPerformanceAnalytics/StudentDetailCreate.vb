Public Class StudentDetailCreate
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = textUsername.Text
        Dim firstName As String = textFirstname.Text
        Dim middleName As String = textMiddlename.Text
        Dim lastName As String = textLastname.Text
        Dim email As String = textEmail.Text
        Dim birthdate As String = textBirthdate.Text
        Dim password As String = textPassword.Text
        Dim confirmPassword As String = textPasswordConfirmation.Text
        Dim isAdmin As Boolean = isAdminCheckBox.Checked

        Dim userModule As New UserModule
        Dim userId As Integer = userModule.CreateUser(username, firstName, middleName, lastName, email, birthdate, password, confirmPassword, isAdmin)

        If userId <> -1 Then
            MessageBox.Show("User created successfully. User ID: " & userId, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("User creation failed. Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class