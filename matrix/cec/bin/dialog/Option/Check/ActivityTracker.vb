Imports JetBrains.Annotations

Public Class ActivityTracker
    <UsedImplicitly>
    Public WriteOnly Event TrackerWrite(Optional ByRef names As Object)

    <UsedImplicitly>
    Public ReadOnly Event TrackerReady(Optional ByRef names As Object)

    Public Property WriteEventProperty as Object(WriteEventProperty)
    Public Property ReadyEventProperty as Object(ReadyEventProperty)
    
End Class