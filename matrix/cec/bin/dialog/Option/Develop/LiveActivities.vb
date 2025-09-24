

Public Class LiveActivities
    Public Overloads Shadows Default Shared Sub Activities()
        ValueType()
    End Sub

    Private Shared Sub ValueType()
        Throw New NotImplementedException
    End Sub

    Public Overloads Shadows Default Shared Sub App()
       AppActivate() 
    End Sub

    Private Shared Sub AppActivate()
        Throw New NotImplementedException
    End Sub

    Public Overloads Shadows Default Shared Sub Header()
        For Each o In Object
            Console.WriteLine("Hello World!\")    
        Next
    End Sub

    Public Overloads Shadows Default Shared Sub Activities(Optional ParamArray info)
        Write(FileNumber := 1, ParameterAttributes)
    End Sub

    Private Shared Function ParameterAttributes() As Object()
        Throw New NotImplementedException
    End Function
End Class