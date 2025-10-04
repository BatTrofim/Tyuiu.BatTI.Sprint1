using Tyuiu.BatTI.Sprint1.Task3.V11.Lib;

namespace Tyuiu.BatTI.Sprint1.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = -1.0;
            double y1 = 3.0;
            double x2 = 4.0;
            double y2 = 2.0;
            double x3 = 1.0;
            double y3 = -2.0;
            double wait = 11.5;
            var res = ds.TriangleArea(x1, y1, x2, y2, x3, y3);
            Assert.AreEqual(wait, res);

        }
    }
}
