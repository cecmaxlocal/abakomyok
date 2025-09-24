Public Class Typographic
    Public Overrides Function Equals(obj As Object) As Type
        Return obj.GetType()
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class