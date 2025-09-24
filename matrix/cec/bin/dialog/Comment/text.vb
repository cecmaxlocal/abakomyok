Public Interface IText
    Public Overloads Custom Event Comment As Str
End Interface

Public Delegate Sub Str(sender As Object, args As StrArgs)

Public Class StrArgs
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class

Public Interface IStr
    Public Overloads Function Text() As Object
End Interface