using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MedvedevDP.Sprint6.Task1.V18.Lib
{
    public class DataService : ISprint6Task1V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double y;
            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            int cnt = 0;
            for (int i = startValue; i < stopValue + 1; i++)
            {
                y = (2 * Math.Sin(i)) / (3 * i + 1.2) + Math.Cos(i) - 7 * i * 2;
                y = Math.Round(y, 2);
                res[cnt] = y;
                cnt++;
            }
            return res;
        }
    }
}
