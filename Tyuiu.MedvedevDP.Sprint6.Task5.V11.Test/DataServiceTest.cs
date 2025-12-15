using Tyuiu.MedvedevDP.Sprint6.Task5.V11.Lib;
namespace Tyuiu.MedvedevDP.Sprint6.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask5V11.txt";
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(res, new double[] { 10.0 });
        }
    }
}