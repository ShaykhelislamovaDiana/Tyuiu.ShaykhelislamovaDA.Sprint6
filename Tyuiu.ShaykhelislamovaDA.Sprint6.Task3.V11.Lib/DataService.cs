using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] arr = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        arr[i] = matrix[i, j];
                    }
                }
            }
            Array.Sort(arr);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = arr[i];
                    }
                }
            }
            return matrix;
        }
    }
}
