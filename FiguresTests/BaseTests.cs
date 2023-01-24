using Figures;
using Figures.FiguresList;

namespace FiguresTests
{
    [TestClass]
    public class BaseTests
    {
        [TestMethod]
        public void TestCircleGettingArea()
        {
            double expected = 84.9;
            FigureInfo<Circle> figureInfo = new(parameters: 5.2);
            double area = figureInfo.GetFigureArea();
            Assert.AreEqual(expected, area, delta: 0.1);
        }

        [TestMethod]
        public void TestCircleGettingAreaWithNegativeRadius()
        {
            double expected = 0.0;
            FigureInfo<Circle> figureInfo = new(parameters: -.6);
            double area = figureInfo.GetFigureArea();
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        public void TestTriangleGettingArea()
        {
            double expected = 11.3;
            FigureInfo<Triangle> figureInfo = new(parameters: new double[3] { 6.2, 10.01, 4.8 });
            double area = figureInfo.GetFigureArea();
            Assert.AreEqual(expected, area, delta: 0.1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangleThrownFigureNotExistException()
        {
            FigureInfo<Triangle> figureInfo = new(parameters: new double[3] { 6.2, 15.01, 4.8 });
            Assert.ThrowsException<ArgumentException>(() => figureInfo.GetFigureArea());
        }

        [TestMethod]
        public void TestFigureThrowsOnInitArgsException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                FigureInfo<Circle> figureInfo = new(parameters: new double[3] { 6.2, 10.01, 4.8 });
            });
        }

        [TestMethod]
        public void TestTriangleIsRightAngled()
        {
            Triangle triangle = new();
            triangle.Initialize(parameters: new double[3] { 6.0, 10.0, 8.0 });
            Assert.IsTrue(triangle.IsRightAngled());
        }
    }
}