using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MedvedevDP.Sprint6.Task5.V11.Lib
{
    public class DataService : ISprint6Task5V11
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            List<double> num = new List<double>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 5 == 0)
                    {
                        num.Add(Convert.ToDouble(line));
                    }
                }
            }
            return num.ToArray();
        }
    }
}