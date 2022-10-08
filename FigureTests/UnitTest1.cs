using Lab001;
namespace FigureTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Point p1 = new Point(1, 4);
            Point p2 = new Point(1, 1);
            Point p3 = new Point(4, 1);
            Point p4 = new Point(5, 1);
            Point p5 = new Point(5, 4);
            Figure f1 = new Figure(p1, p2, p3);
            Figure f2 = new Figure(p1, p2, p3, p4);
            Figure f3 = new Figure(p1, p2, p3, p4, p5);
            double per3 = 6 + Math.Sqrt(18);
            double per4 = 12;
            double per5 = 14;
            Assert.AreEqual(per3, f1.PerimeterCalculator());
            Assert.AreEqual(per4, f2.PerimeterCalculator());
            Assert.AreEqual(per5, f3.PerimeterCalculator());
        }
    }
}