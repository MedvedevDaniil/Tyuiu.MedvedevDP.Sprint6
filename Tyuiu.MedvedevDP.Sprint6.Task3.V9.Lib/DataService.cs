using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MedvedevDP.Sprint6.Task3.V9.Lib
{

    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int[] Column5 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                Column5[i] = matrix[i, 4];
            }

            Array.Sort(Column5);

            for (int i = 0; i < rows; i++)
            {
                matrix[i, 4] = Column5[i];
            }

            return matrix;
        }
    }
}