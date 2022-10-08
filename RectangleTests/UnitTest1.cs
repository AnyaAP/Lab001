using Lab001;
namespace RectangleTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 2;
            double b = 5;
            double area = 10;
            double per = 14;
            Rectangle rec = new Rectangle(a, b);
            Assert.AreEqual(area, rec.AreaCalculator());
            Assert.AreEqual(per, rec.PerimeterCalculator());
        }
    }
}