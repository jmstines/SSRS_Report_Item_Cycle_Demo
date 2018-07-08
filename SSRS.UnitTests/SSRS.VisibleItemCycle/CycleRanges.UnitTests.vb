Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SSRSVisibleItemCycleDemo

<TestClass()> Public Class CycleRangesUnitTests
  Private Property PageCount As Integer = 4
  Private Property Cycle1of4 As ICycleRanges = New CycleRanges(page:=1, pageCount:=PageCount)
  Private Property Cycle2of4 As ICycleRanges = New CycleRanges(page:=2, pageCount:=PageCount)
  Private Property Cycle3of4 As ICycleRanges = New CycleRanges(page:=3, pageCount:=PageCount)
  Private Property Cycle4of4 As ICycleRanges = New CycleRanges(page:=4, pageCount:=PageCount)

  <TestMethod()> Public Sub Cycle1of4_Min_Zero()
    Assert.AreEqual(0, Cycle1of4.MinCycleRangePercent)
  End Sub

  <TestMethod()> Public Sub Cycle1of4_Max_25()
    Assert.AreEqual(25, Cycle1of4.MaxCycleRangePercent)
  End Sub

  <TestMethod()> Public Sub Cycle2of4_Min_26()
    Assert.AreEqual(25, Cycle2of4.MinCycleRangePercent)
  End Sub

  <TestMethod()> Public Sub Cycle2of4_Max_50()
    Assert.AreEqual(50, Cycle2of4.MaxCycleRangePercent)
  End Sub

  <TestMethod()> Public Sub Cycle3of4_Min_50()
    Assert.AreEqual(50, Cycle3of4.MinCycleRangePercent)
  End Sub

  <TestMethod()> Public Sub Cycle3of4_Max_75()
    Assert.AreEqual(75, Cycle3of4.MaxCycleRangePercent)
  End Sub

  <TestMethod()> Public Sub Cycle4of4_Min_75()
    Assert.AreEqual(75, Cycle4of4.MinCycleRangePercent)
  End Sub

  <TestMethod()> Public Sub Cycle4of4_Max_100()
    Assert.AreEqual(100, Cycle4of4.MaxCycleRangePercent)
  End Sub
End Class
