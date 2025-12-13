using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MedvedevDP.Sprint6.Task0.V16.Lib;

namespace Tyuiu.MedvedevDP.Sprint6.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3;
            double res = ds.Calculate(x);
            double wait = 3.111;

            Assert.AreEqual(wait, res);
        }
    }
}
