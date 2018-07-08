Imports SSRSVisibleItemCycleDemo

Public Class CurrentDateTimeProviderMock : Implements IDateTimeProvider
  Public Sub New(ByVal now As DateTime, ByVal today As DateTime)
    _Now = now
    _Today = today
  End Sub
  Public ReadOnly Property Now As Date Implements IDateTimeProvider.Now
  Public ReadOnly Property Today As Date Implements IDateTimeProvider.Today
End Class
