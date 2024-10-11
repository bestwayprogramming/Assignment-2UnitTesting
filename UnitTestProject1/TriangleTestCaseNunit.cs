using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void AnalyzeTriangle_Equilateral_ReturnsEquilateral()
        {
            int a = 3, b = 3, c = 3;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Equilateral triangle"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesCase1_ReturnsIsosceles()
        {
            int a = 5, b = 5, c = 3;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Isosceles triangle"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesCase2_ReturnsIsosceles()
        {
            int a = 4, b = 3, c = 4;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Isosceles triangle"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_IsoscelesCase3_ReturnsIsosceles()
        {
            int a = 6, b = 6, c = 10;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Isosceles triangle"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_ScaleneCase1_ReturnsScalene()
        {
            int a = 3, b = 4, c = 5;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Scalene triangle"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_ScaleneCase2_ReturnsScalene()
        {
            int a = 5, b = 7, c = 8;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Scalene triangle"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_ScaleneCase3_ReturnsScalene()
        {
            int a = 10, b = 12, c = 15;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Scalene triangle"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_ScaleneCase4_ReturnsScalene()
        {
            int a = 8, b = 15, c = 17;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Scalene triangle"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_ScaleneCase5_ReturnsScalene()
        {
            int a = 7, b = 24, c = 25;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Scalene triangle"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_ZeroSide1_ReturnsInvalid()
        {
            int a = 0, b = 3, c = 4;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_ZeroSide2_ReturnsInvalid()
        {
            int a = 3, b = 0, c = 4;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_ZeroSide3_ReturnsInvalid()
        {
            int a = 3, b = 4, c = 0;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("Invalid Triangle - a zero has been detected"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_InvalidTriangle1_ReturnsInvalid()
        {
            int a = 1, b = 2, c = 3;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("INVALID!!"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_InvalidTriangle2_ReturnsInvalid()
        {
            int a = 10, b = 1, c = 2;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("INVALID!!"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }

        [Test]
        public void AnalyzeTriangle_InvalidTriangle3_ReturnsInvalid()
        {
            int a = 1, b = 10, c = 1;
            string result = Triangle.AnalyzeTriangle(a, b, c);
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.EqualTo("INVALID!!"));
                Assert.That(result.Length, Is.GreaterThan(0));
            });
        }
    }
}
