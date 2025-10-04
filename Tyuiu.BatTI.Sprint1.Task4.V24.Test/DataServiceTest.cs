using Tyuiu.BatTI.Sprint1.Task4.V24.Lib;

namespace Tyuiu.BatTI.Sprint1.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            double wait = 0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
