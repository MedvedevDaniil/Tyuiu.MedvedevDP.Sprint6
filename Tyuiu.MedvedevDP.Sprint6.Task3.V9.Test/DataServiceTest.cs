using Tyuiu.MedvedevDP.Sprint6.Task3.V9.Lib;
namespace Tyuiu.MedvedevDP.Sprint6.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matr = new int[5, 5] { { 4, 5, 5, 6, 4 }, { 7, 8, 4, 7, 3 }, { 5, 6, 5, 8, 5 }, { 7, 5, 8, 7, 8 }, { 4, 7, 7, 8, 8 } };
            int[,] res = ds.Calculate(matr);
            int[,] wait = new int[5, 5] { { 4, 5, 5, 6, 3 }, { 7, 8, 4, 7, 4 }, { 5, 6, 5, 8, 5 }, { 7, 5, 8, 7, 8 }, { 4, 7, 7, 8, 8 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}