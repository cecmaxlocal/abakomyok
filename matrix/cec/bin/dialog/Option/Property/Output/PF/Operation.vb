Imports JetBrains.Annotations

Public Class Operation
    <CanBeNull> '' can view off and on
    Public Overrides ToOutput() As String
    Public Overrides ToOutputProperty As StrArgs
    Public Overrides ToOutputPreviews As StrArgs
    Public Overrides ToOutputPreviewsProperty As StrArgs
    Public Overrides ToOutputPreviewsNow As StrArgs
    Public Overrides ToOutputPreviewsWindow As StrArgs
    Public Overrides ToOutputPreviewsObject As StrArgs
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class