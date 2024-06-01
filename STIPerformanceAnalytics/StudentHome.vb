Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json

Public Class StudentHome
    Dim user As New UserModule()
    Dim questions As List(Of SurveyQuestion) = SurveyModule.GetSurveyQuestions()
    Private submitButton As Button

    Private Sub StudentHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm()
        InitializeSurveyForm()
    End Sub

    Private Sub InitializeSurveyForm()

        DisplayQuestions(questions)

    End Sub

    Private Sub InitializeForm()
        studentName.Text = user.FirstName

        textUsername.Text = user.Username
        textFirstname.Text = user.FirstName
        textMiddlename.Text = user.MiddleName
        textLastname.Text = user.LastName
        textEmail.Text = user.Email
        textBirthdate.Text = user.Birthdate

    End Sub

    Private Sub DisplayQuestions(questions As List(Of SurveyQuestion))
        Dim yOffset As Integer = 78
        Dim xOffset As Integer = 12

        Dim lblTitle As New Label()
        lblTitle.Text = "Please answer the survey to get your suggested degree"
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20.25)
        ' lblTitle.Location = New Point(17, 7)
        Panel1.Controls.Add(lblTitle)

        For Each question As SurveyQuestion In questions
            Dim lblQuestion As New Label()
            lblQuestion.Text = question.Question
            lblQuestion.AutoSize = True
            lblQuestion.Location = New Point(xOffset, yOffset)
            Panel1.Controls.Add(lblQuestion)
            yOffset += 30

            If question.Type = "radio" Then
                Dim pnlChoices As New FlowLayoutPanel()
                pnlChoices.Location = New Point(xOffset, yOffset)
                pnlChoices.AutoSize = True
                pnlChoices.Tag = question
                pnlChoices.AutoSizeMode = AutoSizeMode.GrowAndShrink
                pnlChoices.BorderStyle = BorderStyle.None
                pnlChoices.FlowDirection = FlowDirection.LeftToRight
                Panel1.Controls.Add(pnlChoices)

                For Each choice As String In question.Choices
                    Dim rbChoice As New RadioButton()
                    rbChoice.Text = choice
                    rbChoice.AutoSize = True
                    rbChoice.Tag = question
                    pnlChoices.Controls.Add(rbChoice)
                Next
                yOffset += pnlChoices.Height + 10
            ElseIf question.Type = "checkbox" Then
                For Each choice As String In question.Choices
                    Dim cbChoice As New CheckBox()
                    cbChoice.Text = choice
                    cbChoice.AutoSize = True
                    cbChoice.Tag = question
                    cbChoice.Location = New Point(xOffset, yOffset)
                    Panel1.Controls.Add(cbChoice)
                    yOffset += 25
                Next
            ElseIf question.Type = "input" Then
                Dim txtInput As New TextBox()
                txtInput.Size = New Size(200, 20)
                txtInput.Tag = question
                txtInput.Location = New Point(xOffset, yOffset)
                Panel1.Controls.Add(txtInput)
                yOffset += 25
            End If

            yOffset += 10
        Next

        Panel1.Height = yOffset + 50

        submitButton = New Button()
        submitButton.Text = "Submit"
        submitButton.Size = New Size(100, 30)
        submitButton.Location = New Point(xOffset, yOffset)
        AddHandler submitButton.Click, AddressOf SubmitButton_Click
        Panel1.Controls.Add(submitButton)
    End Sub

    Public Function EndSurvey(labelMessage As String) As Boolean
        Dim controlsToRemove As New List(Of Control)(Panel1.Controls.OfType(Of Control)())
        For Each ctrl As Control In controlsToRemove
            Panel1.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next

        Panel1.Controls.Clear()
        InitializeSurveyForm()

        Return True
    End Function


    Private Sub SubmitButton_Click(sender As Object, e As EventArgs)
        If ValidateAnswers() Then
            Dim answerModel As New List(Of AnswerInfo)()

            Dim index As Integer = 0

            For Each control As Control In Panel1.Controls
                If TypeOf control Is Panel Then
                    For Each subControl As Control In control.Controls
                        If TypeOf subControl Is RadioButton AndAlso DirectCast(subControl, RadioButton).Checked Then
                            answerModel.Add(New AnswerInfo(subControl.Tag.Id, subControl.Tag.Question, subControl.Tag.Type, subControl.Text))
                        End If
                    Next
                ElseIf TypeOf control Is TextBox Then
                    answerModel.Add(New AnswerInfo(control.Tag.Id, control.Tag.Question, control.Tag.Type, control.Text))
                ElseIf TypeOf control Is CheckBox AndAlso DirectCast(control, CheckBox).Checked Then
                    answerModel.Add(New AnswerInfo(control.Tag.Id, control.Tag.Question, control.Tag.Type, control.Text))
                End If

                index = index + 1
            Next

            Try
                Dim userId As Integer = user.UserId
                Dim result As String = SurveyModule.SaveSurveyData(answerModel, userId)
                EndSurvey(result)
                MessageBox.Show($"{result} is the suggested degree for you, based on your answers.")
            Catch ex As Exception
                MessageBox.Show("An error occurred while saving your answers: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please answer all the questions before submitting.")
        End If
    End Sub


    Private Function ValidateAnswers() As Boolean
        For Each control As Control In Panel1.Controls
            If TypeOf control Is FlowLayoutPanel Then
                Dim radioChecked As Boolean = False
                For Each subControl As Control In control.Controls
                    If TypeOf subControl Is RadioButton AndAlso DirectCast(subControl, RadioButton).Checked Then
                        radioChecked = True
                        Exit For
                    End If
                Next
                If Not radioChecked Then Return False
            End If
            If TypeOf control Is TextBox AndAlso String.IsNullOrWhiteSpace(control.Text) Then
                Return False
            End If
            'If TypeOf control Is CheckBox AndAlso DirectCast(control, CheckBox).Checked = False Then
            '   Return False
            'End If
        Next
        Return True
    End Function

    Private Sub OnDelayTimerTick(sender As Object, e As EventArgs)
        Dim delayTimer As Timer = CType(sender, Timer)
        delayTimer.Stop()
        Dim main As New Form1()
        main.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Hold on", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            user.Logout()
            Form1.Show()
            Me.Close()
        Else
            ' Do nothing
        End If
    End Sub

    Public Class AnswerInfo
        Public Property QuestionId As Integer
        Public Property QuestionText As String
        Public Property QuestionType As String
        Public Property Answer As String

        Public Sub New(questionId As Integer, questionText As String, questionType As String, answer As String)
            Me.QuestionId = questionId
            Me.QuestionText = questionText
            Me.QuestionType = questionType
            Me.Answer = answer
        End Sub
    End Class

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
            MessageBox.Show("User information updated successfully.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newPassword As String = textPassword.Text
        Dim confirmPassword As String = textPasswordConfirmation.Text
        Dim userId As Integer = user.UserId

        user.ChangePassword(userId, newPassword, confirmPassword)
    End Sub
End Class