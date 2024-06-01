Imports Microsoft.VisualBasic.ApplicationServices

Public Class StudentDetailsUpdate
    Dim student As Student = StudentModule.CurrentStudentDetails
    Dim userModule As New UserModule

    Private Sub StudentDetailsUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        textUsername.Text = Student.Username
        textFirstname.Text = Student.FirstName
        textMiddlename.Text = Student.MiddleName
        textLastname.Text = Student.LastName
        textEmail.Text = Student.Email
        textBirthdate.Text = student.Birthdate

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim userId = student.Id

        If userModule.UpdateUser(
            userId,
            textUsername.Text,
            textFirstname.Text,
            textMiddlename.Text,
            textLastname.Text,
            textEmail.Text,
            textBirthdate.Text
            ) Then

            MessageBox.Show("User information updated successfully.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newPassword As String = textPassword.Text
        Dim confirmPassword As String = textPasswordConfirmation.Text
        Dim userId As Integer = student.Id

        userModule.ChangePassword(userId, newPassword, confirmPassword)
    End Sub
End Class