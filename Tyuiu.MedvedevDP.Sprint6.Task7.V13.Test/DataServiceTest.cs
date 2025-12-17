using Tyuiu.MedvedevDP.Sprint6.Task7.V13.Lib;
namespace Tyuiu.MedvedevDP.Sprint6.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string tempFile = Path.GetTempFileName();

            string[] lines = new string[10];
            for (int i = 0; i < 10; i++)
            {
                lines[i] = string.Join(";", Enumerable.Range(1, 10));
            }

            File.WriteAllLines(tempFile, lines);

            int[,] result = ds.GetMatrix(tempFile);

            // Проверяем размеры
            Assert.AreEqual(10, result.GetLength(0));
            Assert.AreEqual(10, result.GetLength(1));

            Assert.AreEqual(111, result[0, 5]);
            Assert.AreEqual(111, result[1, 5]);
            File.Delete(tempFile);
        }
    }
}