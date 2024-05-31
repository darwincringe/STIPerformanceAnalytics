Imports System.Text
Imports MySql.Data.MySqlClient

Module SurveyModule
    Function GetSurveyQuestions() As List(Of SurveyQuestion)
        Dim questions As New List(Of SurveyQuestion)()
        Using connection As New MySqlConnection(Globals.connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT * FROM survey_questionnaire"
                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim question As New SurveyQuestion()
                            question.Id = reader("id")
                            question.Question = reader("question").ToString()
                            question.Type = reader("type").ToString()
                            question.Choices = reader("choices").ToString().Split(","c).ToList()
                            questions.Add(question)
                        End While
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error connecting to database: " & ex.Message)
            End Try
        End Using
        Return questions
    End Function

    Public Function SaveSurveyData(answerModel As List(Of StudentHome.AnswerInfo), userId As Integer)
        Dim labelMessage As String = ""
        Using connection As New MySqlConnection(Globals.connectionString)
            Try
                connection.Open()

                Dim insertSurveyQuery As String = "INSERT INTO student_surveys (user_id, created_date, suggested_degree) VALUES (@UserId, @CreatedDate, @SuggestedDegree)"

                Dim surveyId As Integer
                Using insertSurveyCommand As New MySqlCommand(insertSurveyQuery, connection)
                    insertSurveyCommand.Parameters.AddWithValue("@UserId", userId)
                    insertSurveyCommand.Parameters.AddWithValue("@CreatedDate", DateTime.Now)
                    insertSurveyCommand.Parameters.AddWithValue("@SuggestedDegree", "")
                    insertSurveyCommand.ExecuteNonQuery()
                    surveyId = CInt(insertSurveyCommand.LastInsertedId)
                End Using

                Dim insertAnswerQuery As String = "INSERT INTO student_survey_answers (student_survey_id, question_id, question, answer, type) VALUES (@SurveyId, @QuestionId, @Question, @Answer, @Type)"
                Using insertAnswerCommand As New MySqlCommand(insertAnswerQuery, connection)
                    For Each answer In answerModel
                        insertAnswerCommand.Parameters.Clear()
                        insertAnswerCommand.Parameters.AddWithValue("@SurveyId", surveyId)
                        insertAnswerCommand.Parameters.AddWithValue("@QuestionId", answer.QuestionId)
                        insertAnswerCommand.Parameters.AddWithValue("@Question", answer.QuestionText)
                        insertAnswerCommand.Parameters.AddWithValue("@Answer", answer.Answer)
                        insertAnswerCommand.Parameters.AddWithValue("@Type", answer.QuestionType)
                        insertAnswerCommand.ExecuteNonQuery()
                    Next
                End Using

                Dim suggestedDegree As String = GetSuggestedDegree(surveyId)

                Dim updateSurveyQuery As String = "UPDATE student_surveys SET suggested_degree = @SuggestedDegree WHERE id = @SurveyId"
                Using updateSurveyCommand As New MySqlCommand(updateSurveyQuery, connection)
                    updateSurveyCommand.Parameters.AddWithValue("@SuggestedDegree", suggestedDegree)
                    updateSurveyCommand.Parameters.AddWithValue("@SurveyId", surveyId)
                    updateSurveyCommand.ExecuteNonQuery()
                End Using

                labelMessage = suggestedDegree

            Catch ex As MySqlException
                Return False
                MessageBox.Show("Error connecting to database: " & ex.Message)
            End Try

        End Using

        Return labelMessage

    End Function

    Private Function GetSuggestedDegree(surveyId As Integer) As String
        Dim suggestedDegreeCounts As New Dictionary(Of String, Integer)()

        Using connection As New MySqlConnection(Globals.connectionString)
            Try
                connection.Open()

                Dim queryAnswers As String = "SELECT question_id, answer FROM student_survey_answers WHERE student_survey_id = @SurveyId"
                Dim surveyAnswers As New List(Of SurveyAnswer)()
                Using cmdAnswers As New MySqlCommand(queryAnswers, connection)
                    cmdAnswers.Parameters.AddWithValue("@SurveyId", surveyId)
                    Using readerAnswers As MySqlDataReader = cmdAnswers.ExecuteReader()
                        While readerAnswers.Read()
                            surveyAnswers.Add(New SurveyAnswer() With {
                                .QuestionId = readerAnswers("question_id"),
                                .Answer = readerAnswers("answer").ToString().Trim()
                            })
                        End While
                    End Using
                End Using

                For Each surveyAnswer In surveyAnswers
                    Dim querySuggestions As String = "SELECT suggested_degree FROM question_choice_suggestions WHERE question_id = @QuestionId AND choice = @Answer"
                    Using cmdSuggestions As New MySqlCommand(querySuggestions, connection)
                        cmdSuggestions.Parameters.AddWithValue("@QuestionId", surveyAnswer.QuestionId)
                        cmdSuggestions.Parameters.AddWithValue("@Answer", surveyAnswer.Answer)

                        Using readerSuggestions As MySqlDataReader = cmdSuggestions.ExecuteReader()
                            While readerSuggestions.Read()
                                Dim suggestedDegree As String = readerSuggestions("suggested_degree").ToString()
                                If suggestedDegreeCounts.ContainsKey(suggestedDegree) Then
                                    suggestedDegreeCounts(suggestedDegree) += 1
                                Else
                                    suggestedDegreeCounts(suggestedDegree) = 1
                                End If
                            End While
                        End Using
                    End Using
                Next

                Dim highestCount As Integer = 0
                Dim suggestedDegreeMessage As String = ""

                For Each kvp As KeyValuePair(Of String, Integer) In suggestedDegreeCounts
                    If kvp.Value > highestCount Then
                        highestCount = kvp.Value
                        suggestedDegreeMessage = kvp.Key
                    End If
                Next

                Return suggestedDegreeMessage
            Catch ex As MySqlException
                MessageBox.Show("Error connecting to database: " & ex.Message)
                Return ""
            End Try
        End Using
    End Function

    Private Class SurveyAnswer
        Public Property QuestionId As Integer
        Public Property Answer As String
    End Class
End Module

Public Class SurveyQuestion
    Public Property Id As Integer
    Public Property Question As String
    Public Property Type As String
    Public Property Choices As List(Of String)
End Class
