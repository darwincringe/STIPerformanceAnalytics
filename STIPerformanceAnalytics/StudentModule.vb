Module StudentModule
    Private _currentStudentDetails As Student

    Public Property CurrentStudentDetails As Student
        Get
            Return _currentStudentDetails
        End Get
        Set(value As Student)
            _currentStudentDetails = value
        End Set
    End Property
End Module