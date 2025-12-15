using Tyuiu.MedvedevDP.Sprint6.Task6.V10.Lib;
namespace Tyuiu.MedvedevDP.Sprint6.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile_WorksCorrectly()
        {

            string tempFile = Path.Combine(Path.GetTempPath(), "InputTestV10.txt");
            File.WriteAllText(tempFile,
                "We write awesome words with workflow. Sometimes Windows waits.");


            DataService ds = new DataService();
            string actual = ds.CollectTextFromFile(tempFile);

 
            string expected = "write awesome words with workflow waits";

            Assert.AreEqual(expected, actual);
        }
    }
}