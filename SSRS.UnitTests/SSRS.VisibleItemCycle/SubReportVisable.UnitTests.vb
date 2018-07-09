Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SSRSVisibleItemCycleDemo

<TestClass()> Public Class SubReportVisable
  Private cycleRangesOne As ICycleRanges
  Private ReportRefreshOne As SubReportHidden
  Private ReportRefreshTwo As SubReportHidden

  Private ReadOnly CyclePercentOne As Integer = 15
  Private ReadOnly CyclePercentOneEdge As Integer = 25
  Private ReadOnly CyclePercentThree As Integer = 26

  <TestMethod()> Public Sub ReportRefreshOne_Report1of4Hidden_False()
    cycleRangesOne = New CycleRangesMock(0, 25)
    ReportRefreshOne = New SubReportHidden(cycleRangesOne, CyclePercentOne)

    Assert.IsFalse(ReportRefreshOne.IsHidden())
  End Sub

  <TestMethod()> Public Sub ReportRefreshOne_Report2of4Visable_True()
    cycleRangesOne = New CycleRangesMock(25, 50)
    ReportRefreshOne = New SubReportHidden(cycleRangesOne, CyclePercentOne)

    Assert.IsTrue(ReportRefreshOne.IsHidden())
  End Sub

  <TestMethod()> Public Sub ReportRefreshOne_Report3of4Hidden_True()
    cycleRangesOne = New CycleRangesMock(50, 75)
    ReportRefreshOne = New SubReportHidden(cycleRangesOne, CyclePercentOne)

    Assert.IsTrue(ReportRefreshOne.IsHidden())
  End Sub

  <TestMethod()> Public Sub ReportRefreshOne_Report4of4Hidden_True()
    cycleRangesOne = New CycleRangesMock(75, 100)
    ReportRefreshOne = New SubReportHidden(cycleRangesOne, CyclePercentOne)

    Assert.IsTrue(ReportRefreshOne.IsHidden())
  End Sub

  <TestMethod()> Public Sub ReportRefreshTwo_Report1of4Hidden_False()
    cycleRangesOne = New CycleRangesMock(0, 25)
    ReportRefreshTwo = New SubReportHidden(cycleRangesOne, CyclePercentOneEdge)

    Assert.IsFalse(ReportRefreshTwo.IsHidden)
  End Sub

  <TestMethod()> Public Sub ReportRefreshTwo_Report2of4Hidden_True()
    cycleRangesOne = New CycleRangesMock(25, 50)
    ReportRefreshTwo = New SubReportHidden(cycleRangesOne, CyclePercentOneEdge)

    Assert.IsTrue(ReportRefreshTwo.IsHidden)
  End Sub

  <TestMethod()> Public Sub ReportRefreshTwo_Report3of4Hidden_True()
    cycleRangesOne = New CycleRangesMock(50, 75)
    ReportRefreshTwo = New SubReportHidden(cycleRangesOne, CyclePercentOneEdge)

    Assert.IsTrue(ReportRefreshTwo.IsHidden)
  End Sub

  <TestMethod()> Public Sub ReportRefresTwo_Report4of4Hidden_True()
    cycleRangesOne = New CycleRangesMock(75, 100)
    ReportRefreshTwo = New SubReportHidden(cycleRangesOne, CyclePercentOneEdge)

    Assert.IsTrue(ReportRefreshTwo.IsHidden)
  End Sub

  <TestMethod()> Public Sub ReportRefreshTwo_Report1of4Hidden2_True()
    cycleRangesOne = New CycleRangesMock(0, 25)
    ReportRefreshTwo = New SubReportHidden(cycleRangesOne, CyclePercentThree)

    Assert.IsTrue(ReportRefreshTwo.IsHidden)
  End Sub

  <TestMethod()> Public Sub ReportRefreshTwo_Report2of4Hidden2_False()
    cycleRangesOne = New CycleRangesMock(25, 50)
    ReportRefreshTwo = New SubReportHidden(cycleRangesOne, CyclePercentThree)

    Assert.IsFalse(ReportRefreshTwo.IsHidden)
  End Sub

  <TestMethod()> Public Sub ReportRefreshTwo_Report3of4Hidden2_True()
    cycleRangesOne = New CycleRangesMock(50, 75)
    ReportRefreshTwo = New SubReportHidden(cycleRangesOne, CyclePercentThree)

    Assert.IsTrue(ReportRefreshTwo.IsHidden)
  End Sub

  <TestMethod()> Public Sub ReportRefresTwo_Report4of4Hidden2_True()
    cycleRangesOne = New CycleRangesMock(75, 100)
    ReportRefreshTwo = New SubReportHidden(cycleRangesOne, CyclePercentThree)

    Assert.IsTrue(ReportRefreshTwo.IsHidden)
  End Sub

End Class