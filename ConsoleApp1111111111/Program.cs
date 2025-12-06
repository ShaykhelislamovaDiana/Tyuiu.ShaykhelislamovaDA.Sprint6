using Tyuiu.ShaykhelislamovaDA.Sprint6.Task3.V11.Lib;
namespace ConsoleApp1111111111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] arr = { { 9, 2, 3 }, { 7, 8, 9 }, { 7, 5, 6 } };
            int[] res = ds.Calculate(arr);
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + "\t");
            }
        }
    }
}
