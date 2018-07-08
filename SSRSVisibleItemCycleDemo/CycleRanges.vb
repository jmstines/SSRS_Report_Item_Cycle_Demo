Public Class CycleRanges : Implements ICycleRanges
  Public ReadOnly Property MinCycleRange As Long Implements ICycleRanges.MinCycleRange
  Public ReadOnly Property MaxCycleRange As Long Implements ICycleRanges.MaxCycleRange
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
    _MinCycleRange = CLng(((Page - 1) / PageCount) * 100)
  End Sub

  Private Sub SetMaxCycleRange()
    _MaxCycleRange = CLng(((Page / PageCount) * 100))
  End Sub
End Class