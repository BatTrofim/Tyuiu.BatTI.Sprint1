using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BatTI.Sprint1.Task2.V8.Lib;


namespace Tyuiu.BatTI.Sprint1.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 1;
            var res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(6, res);
        }
    }
}
