Public Class List
    Private _names As Object

    Public Overrides Function Equals(obj As Object) As Type
        Return MyBase.GetType()
    End Function

    Public Sub New(names As Object, names1 As Object())
        Names = names
        Me._names = names
        Names = names1
        _names = names
        names = New ActivityListener()
    End Sub
     
End Class