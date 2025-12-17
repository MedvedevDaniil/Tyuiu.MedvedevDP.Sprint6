using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MedvedevDP.Sprint6.Task7.V13.Lib
{
    public class DataService : ISprint6Task7V13
    {
        public int[,] GetMatrix(string path)
        {
            string[] mass = File.ReadAllLines(path);
            int s = 10;
            for (int i = 0; i < s; i++)
            {
                mass[i] = mass[i].Replace(";", " ");
            }

            int[,] matrix = new int[s, s];
            for (int i = 0; i < s; i++)
            {
                int[] row = mass[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < s; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int[,] res = new int[s, s];
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int xCol = 5;
            for (int r = 0; r < rows; r++)
            {
                for (int c = xCol; c <= xCol; c++)
                {
                    if ((matrix[r, c] > 0) && (matrix[r, c] % 2 == 0))
                    {
                        matrix[r, c] = 111;
                    }
                }
            }
            return matrix;
        }
    }
}