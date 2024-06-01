
Public Class StudentAnswers

    Private Sub StudentAnswers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim details As StudentSurveyDetails = StudentSurveyModule.CurrentSurveyDetails

        textStudentName.Text = details.StudentName
        textStudentid.Text = details.StudentId

        Dim answers As List(Of StudentSurveyAnswer) = SurveyModule.GetStudentSurveyAnswers(details.Id)

        Panel1.Controls.Clear()

        Dim startY As Integer = 10
        Dim spacing As Integer = 60

        For Each answer In answers
            Dim questionLabel As New Label()
            questionLabel.Text = answer.Question
            questionLabel.AutoSize = True
            questionLabel.Location = New Point(10, startY)

            Dim answerLabel As New Label()
            answerLabel.Text = answer.Answer
            answerLabel.AutoSize = True
            answerLabel.Location = New Point(10, startY + 30)

            Panel1.Controls.Add(questionLabel)
            Panel1.Controls.Add(answerLabel)

            startY += spacing
        Next

    End Sub
End Class