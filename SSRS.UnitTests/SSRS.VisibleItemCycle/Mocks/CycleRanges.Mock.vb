Imports SSRSVisibleItemCycleDemo

Public Class CycleRangesMock : Implements ICycleRanges
  Public Property MaxCycleRange As Long Implements ICycleRanges.MaxCycleRange
  Public Property MinCycleRange As Long Implements ICycleRanges.MinCycleRange
  Public Sub New(ByVal min As Long, ByVal max As Long)
    If min < 0 Then Throw New ArgumentOutOfRangeException("min")
    If max.Equals(0) Then Throw New ArgumentOutOfRangeException("max")

    MinCycleRange = min
    MaxCycleRange = max
  End Sub
End Class
