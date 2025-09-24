Imports JetBrains.Annotations

Public Class Assembly
    
    Public Sub Path()
        For Each o As Object In PathOutput()
            Write("Check the Files: ", o)
        Next
    End Function

    
    Public Sub PathFiles(Optional files As Object)
        For Each o As Object In PathOutput(Nothing)
            Write("Check Buffer Files: ", o)
        Next
    End Function

    
    Public Sub PathLocal (names As Object, home As Object)
        Write("Hello World!!\CE104155-5401-43C2-A715-5A8B1CF759D9")
    End Function

    Public ReadOnly Property Local(home As Object) As Object
        Get
            Throw New NotImplementedException
        End Get
    End Property

    Public Property LocalAdd( ) As Object
    Public Property LocalForm() As Object


    Sub New(<NotNull> pathOutput As Object())
        Me.PathOutput() = pathOutput
    End Sub

    <NotNull>
    Public Property PathOutput() as Object()
End Class