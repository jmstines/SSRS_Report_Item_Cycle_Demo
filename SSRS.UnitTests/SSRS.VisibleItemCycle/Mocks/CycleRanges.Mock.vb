Imports SSRSVisibleItemCycleDemo

Public Class CycleRangesMock : Implements ICycleRanges
  Public Property MaxCycleRangePercent As Integer Implements ICycleRanges.MaxCycleRangePercent
  Public Property MinCycleRangePercent As Integer Implements ICycleRanges.MinCycleRangePercent
  Public Sub New(ByVal min As Long, ByVal max As Long)
    If min < 0 Then Throw New ArgumentOutOfRangeException("min")
    If max.Equals(0) Then Throw New ArgumentOutOfRangeException("max")

    MinCycleRangePercent = min
    MaxCycleRangePercent = max
  End Sub
End Class
