using Tyuiu.MedvedevDP.Sprint6.Task1.V18.Lib;
namespace Tyuiu.MedvedevDP.Sprint6.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] wait = new double[len];
            wait[0] = 70.14;
            wait[1] = 55.21;
            wait[2] = 41.05;
            wait[3] = 27.96;
            wait[4] = 15.48;
            wait[5] = 1;
            wait[6] = -13.06;
            wait[7] = -28.16;
            wait[8] = -42.96;
            wait[9] = -56.77;
            wait[10] = -69.83;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
