Module StudentSurveyModule
    Private _currentSurveyDetails As StudentSurveyDetails

    Public Property CurrentSurveyDetails As StudentSurveyDetails
        Get
            Return _currentSurveyDetails
        End Get
        Set(value As StudentSurveyDetails)
            _currentSurveyDetails = value
        End Set
    End Property
End Module