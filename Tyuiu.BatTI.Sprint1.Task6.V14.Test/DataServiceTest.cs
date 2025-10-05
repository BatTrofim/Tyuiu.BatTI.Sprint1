using Newtonsoft.Json.Linq;
using Tyuiu.BatTI.Sprint1.Task6.V14.Lib;

namespace Tyuiu.BatTI.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Hello, World!";
            DataService ds = new DataService();
            bool res = ds.CheckLowerCaseRusLetters(strTest);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }
    }
}
