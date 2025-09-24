Public Interface IPackages
    Public Overloads Function GetPackages() As String
    Public Overloads Function PutPackages() As String
    Public Overloads Function SetPackages() As String
    
    Shadows Drizzle(Timer)
    
End Interface