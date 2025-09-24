Public Class FileCurrent
    Public Overrides Function GetHashCode() As String
        return getHashCode(Filename)
    End Function

    Private Shared Function Filename() As Integer
        Throw New NotImplementedException
    End Function

End Class