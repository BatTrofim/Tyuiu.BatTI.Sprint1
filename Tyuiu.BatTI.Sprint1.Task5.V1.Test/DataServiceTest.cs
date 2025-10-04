using Tyuiu.BatTI.Sprint1.Task5.V1.Lib;

namespace Tyuiu.BatTI.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = -1.0;
            double y1 = 2.0;
            double x2 = 3;
            double y2 = 2.0;
            DataService ds = new DataService();

            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);

            int wait = 4;
            Assert.AreEqual(wait, result);
        }
    }
}
