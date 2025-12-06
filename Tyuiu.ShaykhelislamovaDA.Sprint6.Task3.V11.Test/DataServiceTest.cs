using Tyuiu.ShaykhelislamovaDA.Sprint6.Task3.V11.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] arr = { { 1, 3, 7 }, { 9, 4, 2 }, { 3, 3, 5 } };
            int[,] wait = { { 1, 3, 7 }, { 3, 4, 2 }, { 9, 3, 5 } };
            int[,] res = ds.Calculate(arr);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
