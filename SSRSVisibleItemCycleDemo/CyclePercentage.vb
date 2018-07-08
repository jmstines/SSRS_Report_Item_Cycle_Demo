Public Class CyclePercentage
  Private ReadOnly Property CurrentTimeInSeconds As Integer
  Private ReadOnly Property DateTimeProvider As IDateTimeProvider
  Public Sub New(ByVal dateTimeProvider As IDateTimeProvider)
    Me.DateTimeProvider = dateTimeProvider
    SetCurrentTimeInSeconds()
  End Sub
  Public Function GetCyclePercentage(ByVal fullCycle As Integer) As Integer
    If fullCycle <= 0 Then Throw New IndexOutOfRangeException("fullCycle")

    Return CurrentTimeInSeconds / fullCycle * 100
  End Function
  Private Sub SetCurrentTimeInSeconds()
    _CurrentTimeInSeconds = DateDiff(DateInterval.Second, DateTimeProvider.Today, DateTimeProvider.Now)
  End Sub
End Class