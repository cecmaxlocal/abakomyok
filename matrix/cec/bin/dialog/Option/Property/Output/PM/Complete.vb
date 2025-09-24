Public Class Complete
    Public Overrides ToCompleteHeaders As StrArgs
    Public Overrides ToCompleteTails As StrArgs
    Public Overrides ToCompleteBody As Strings
    Public Overrides ToCompleteProperty As Strings
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class