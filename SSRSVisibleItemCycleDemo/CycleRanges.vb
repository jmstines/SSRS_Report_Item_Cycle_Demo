Public Class CycleRanges : Implements ICycleRanges
  Public ReadOnly Property MinCycleRangePercent As Integer Implements ICycleRanges.MinCycleRangePercent
  Public ReadOnly Property MaxCycleRangePercent As Integer Implements ICycleRanges.MaxCycleRangePercent
  Private Property PageCount As Integer
  Private Property Page As Integer

  Public Sub New(ByVal page As Integer, ByVal pageCount As Integer)
    If page.Equals(0) Then Throw New ArgumentOutOfRangeException("page")
    If pageCount.Equals(0) Then Throw New ArgumentOutOfRangeException("pageCount")

    Me.PageCount = pageCount
    Me.Page = page

    SetMinCycleRange()
    SetMaxCycleRange()
  End Sub

  Private Sub SetMinCycleRange()
    _MinCycleRangePercent = (((Page - 1) / PageCount) * 100)
  End Sub

  Private Sub SetMaxCycleRange()
    _MaxCycleRangePercent = (((Page / PageCount) * 100))
  End Sub
End Class