Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ListView
Imports Microsoft.VisualBasic.ApplicationServices

Public Class AdminHome
    Dim user As New UserModule()
    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm()
    End Sub

    Private Sub InitializeForm()
        studentName.Text = user.FirstName
        textUsername.Text = user.Username
        textFirstname.Text = user.FirstName
        textMiddlename.Text = user.MiddleName
        textLastname.Text = user.LastName
        textEmail.Text = user.Email
        textBirthdate.Text = user.Birthdate

        LoadSurveyData()
        DisplayStudentUsers()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Hold on", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            user.Logout()
            AdminLoginForm.Show()
            Close()
        Else
            ' Do nothing
        End If
    End Sub

    Private Sub LoadSurveyData()
        Dim dt As DataTable = SurveyModule.GetAllStudentSurveys()
        surveyDataGrid.Rows.Clear()
        For Each row As DataRow In dt.Rows
            Dim formattedStudentId As String = row("student_id").ToString().PadLeft(5, "0"c)
            surveyDataGrid.Rows.Add(
            row("id"),
            formattedStudentId,
            row("student_name"),
            row("suggested_degree"),
            row("created_date"),
            "View"
        )
        Next
    End Sub

    Private Sub DisplayStudentUsers()
        Dim userModule As New UserModule
        Dim students As List(Of Student) = userModule.GetAllStudents()
        usersDatagrid.Rows.Clear()

        For Each student In students
            Dim formattedStudentId As String = student.Id.ToString().PadLeft(5, "0"c)
            usersDatagrid.Rows.Add(
                formattedStudentId,
                student.FirstName & " " & student.LastName,
                student.Username,
                student.Email,
                student.Birthdate,
                "Edit",
                "Delete",
                student.MiddleName,
                student.FirstName,
                student.LastName
            )
        Next

    End Sub

    Private Sub surveyDataGrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles surveyDataGrid.CellContentClick
        If e.RowIndex >= 0 Then
            If e.ColumnIndex = surveyDataGrid.Columns("action").Index AndAlso surveyDataGrid.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString = "View" Then
                Dim id As String = surveyDataGrid.Rows(e.RowIndex).Cells("id").Value
                Dim studentId = surveyDataGrid.Rows(e.RowIndex).Cells("student_id").Value.ToString
                Dim studentName = surveyDataGrid.Rows(e.RowIndex).Cells("student_name").Value.ToString
                Dim suggestedDegree = surveyDataGrid.Rows(e.RowIndex).Cells("suggested_degree").Value.ToString
                Dim createdDate = Convert.ToDateTime(surveyDataGrid.Rows(e.RowIndex).Cells("created_date").Value)

                Dim details As New StudentSurveyDetails With {
                    .Id = id,
                    .StudentId = studentId,
                    .StudentName = studentName,
                    .SuggestedDegree = suggestedDegree,
                    .CreatedDate = createdDate
                }

                CurrentSurveyDetails = details

                Dim detailsForm As New StudentAnswers
                detailsForm.Show()
            End If
        End If
    End Sub

    Private Sub ViewStudentDetails()
        Dim details As StudentSurveyDetails = StudentSurveyModule.CurrentSurveyDetails
        If details IsNot Nothing Then
            StudentAnswers.Show()
        Else
            MessageBox.Show("No details available.")
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub usersDatagrid_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles usersDatagrid.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim student As New Student With {
            .Id = Integer.Parse(usersDatagrid.Rows(e.RowIndex).Cells("studentId").Value.ToString()),
            .FirstName = usersDatagrid.Rows(e.RowIndex).Cells("firstname").Value.ToString(),
            .LastName = usersDatagrid.Rows(e.RowIndex).Cells("lastname").Value.ToString(),
            .MiddleName = usersDatagrid.Rows(e.RowIndex).Cells("middlename").Value.ToString(),
            .Username = usersDatagrid.Rows(e.RowIndex).Cells("username").Value.ToString(),
            .Email = usersDatagrid.Rows(e.RowIndex).Cells("email").Value.ToString(),
            .Birthdate = Date.Parse(usersDatagrid.Rows(e.RowIndex).Cells("birthdate").Value.ToString())
        }

            If e.ColumnIndex = usersDatagrid.Columns("Edit").Index Then
                EditStudent(student)
            End If

            If e.ColumnIndex = usersDatagrid.Columns("Delete").Index Then
                DeleteStudent(student)
            End If
        End If
    End Sub

    Private Sub EditStudent(student As Student)
        CurrentStudentDetails = student
        StudentDetailsUpdate.Show()
    End Sub

    Private Sub DeleteStudent(student As Student)
        Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete {student.FirstName} {student.LastName}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim userModule As New UserModule()
            userModule.DeleteStudent(student.Id)

            DisplayStudentUsers()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim userModule As New UserModule
        Dim userId = user.UserId

        If userModule.UpdateUser(
            userId,
            textUsername.Text,
            textFirstname.Text,
            textMiddlename.Text,
            textLastname.Text,
            textEmail.Text,
            textBirthdate.Text
            ) Then

            InitializeForm()
            MessageBox.Show("Admin information updated successfully.")
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        StudentDetailCreate.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InitializeForm()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newPassword As String = textPassword.Text
        Dim confirmPassword As String = textPasswordConfirmation.Text
        Dim userId As Integer = user.UserId

        user.ChangePassword(userId, newPassword, confirmPassword)
    End Sub
End Class