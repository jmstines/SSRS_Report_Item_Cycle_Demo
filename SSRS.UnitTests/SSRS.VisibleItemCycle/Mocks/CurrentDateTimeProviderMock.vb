Imports SSRSVisibleItemCycleDemo

Public Class CurrentDateTimeProviderMock : Implements IDateTimeProvider
  Public Sub New(ByVal today As DateTime, ByVal now As DateTime)
    If now < today Then Throw New ArgumentOutOfRangeException("now < today")

    _Now = now
    _Today = today
  End Sub
  Public ReadOnly Property Now As Date Implements IDateTimeProvider.Now
  Public ReadOnly Property Today As Date Implements IDateTimeProvider.Today
End Class
