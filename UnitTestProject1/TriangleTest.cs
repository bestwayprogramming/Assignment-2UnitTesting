using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void AnalyzeTriangle_Equilateral_ReturnsEquilateral()
    { 
        int side1 = 3, side2 = 3, side3 = 3;

        string result = Triangle.AnalyzeTriangle(side1, side2, side3);

        Assert.AreEqual("Equilateral triangle", result);
    }
}
