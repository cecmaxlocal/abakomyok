Public Class Analysis
    Public Overrides Function Equals(obj As Object) As Type
        Return MyBase.GetType()
    End Function

    Public Overrides Function GetHashCode() As Type
        Return MyBase.GetType()
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class