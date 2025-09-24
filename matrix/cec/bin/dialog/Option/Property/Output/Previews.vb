Public Structure Previews
    Public Overrides Function ToString() As Type
        Return AppActivate()
    End Function

    Private Shared Function AppActivate() As Type
        Throw New NotImplementedException
    End Function
End Structure