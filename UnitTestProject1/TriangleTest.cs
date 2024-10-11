using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void AnalyzeTriangle_ValidEquilateralTriangle_ReturnsEquilateral()
        {
            int side1 = 3, side2 = 3, side3 = 3;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Equilateral triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ValidIsoscelesTriangle1_ReturnsIsosceles()
        {
            int side1 = 5, side2 = 5, side3 = 3;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ValidIsoscelesTriangle2_ReturnsIsosceles()
        {
            int side1 = 4, side2 = 3, side3 = 4;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ValidIsoscelesTriangle3_ReturnsIsosceles()
        {
            int side1 = 6, side2 = 6, side3 = 10;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Isosceles triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ValidScaleneTriangle1_ReturnsScalene()
        {
            int side1 = 3, side2 = 4, side3 = 5;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ValidScaleneTriangle2_ReturnsScalene()
        {
            int side1 = 5, side2 = 7, side3 = 8;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ValidScaleneTriangle3_ReturnsScalene()
        {
            int side1 = 10, side2 = 12, side3 = 15;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ValidScaleneTriangle4_ReturnsScalene()
        {
            int side1 = 8, side2 = 15, side3 = 17;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ValidScaleneTriangle5_ReturnsScalene()
        {
            int side1 = 7, side2 = 24, side3 = 25;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Scalene triangle"));
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthSide1_ReturnsInvalid()
        {
            int side1 = 0, side2 = 3, side3 = 4;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthSide2_ReturnsInvalid()
        {
            int side1 = 3, side2 = 0, side3 = 4;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void AnalyzeTriangle_ZeroLengthSide3_ReturnsInvalid()
        {
            int side1 = 3, side2 = 4, side3 = 0;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
        }

        [Test]
        public void AnalyzeTriangle_InvalidSides1_ReturnsInvalid()
        {
            int side1 = 1, side2 = 2, side3 = 3;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }

        [Test]
        public void AnalyzeTriangle_InvalidSides2_ReturnsInvalid()
        {
            int side1 = 10, side2 = 1, side3 = 2;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }

        [Test]
        public void AnalyzeTriangle_InvalidSides3_ReturnsInvalid()
        {
            int side1 = 1, side2 = 10, side3 = 1;
            string result = Triangle.AnalyzeTriangle(side1, side2, side3);
            Assert.That(result, Is.EqualTo("INVALID!!"));
        }
    }
}
