Public Class CurrentDateTimeProvider : Implements IDateTimeProvider

  Public ReadOnly Property Now As DateTime Implements IDateTimeProvider.Now
    Get
      Now = System.DateTime.UtcNow
    End Get
  End Property
  Public ReadOnly Property Today As DateTime Implements IDateTimeProvider.Today
    Get
      Today = System.DateTime.Today
    End Get
  End Property
End Class
