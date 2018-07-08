Public Class SubReportHidden
  Private ReadOnly Property CycleRanges As ICycleRanges
  Private ReadOnly Property CyclePerentage As Integer

  Public Sub New(ByVal cycleRanges As ICycleRanges, ByVal cyclePercent As Integer)
    If cycleRanges Is Nothing Then Throw New ArgumentNullException("cycleRanges")
    If cyclePercent <= 0 Then Throw New ArgumentOutOfRangeException("cyclePercent")

    _CycleRanges = cycleRanges
    _CyclePerentage = cyclePercent
  End Sub

  Public Function IsHidden() As Boolean
    Return Not (CyclePerentage > CycleRanges.MinCycleRange AndAlso CyclePerentage <= CycleRanges.MaxCycleRange)
  End Function
End Class
