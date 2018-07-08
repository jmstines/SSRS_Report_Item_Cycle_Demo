Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SSRSVisibleItemCycleDemo

<TestClass()> Public Class CyclePercentageUnitTests
  Private Property DateTime1 As IDateTimeProvider = New CurrentDateTimeProviderMock("7/8/2018 12:00:00 AM", "7/8/2018 4:10:00 PM")
  Private Property FullCycle As Integer = 60

  <TestMethod()> Public Sub CurrentCycle()
    Dim cyclePercent As Integer = New CyclePercentage(DateTime1).GetCyclePercentage(FullCycle)
    Assert.AreEqual(97000, cyclePercent)
  End Sub

  <TestMethod()> Public Sub FullCycleOutOfRange()
    Dim OutOfRangeCycle As Integer = 0
    Try
      Dim cyclePercent As Integer = New CyclePercentage(DateTime1).GetCyclePercentage(OutOfRangeCycle)
    Catch ex As Exception
      Assert.AreEqual("fullCycle", ex.Message)
    End Try
  End Sub
End Class
