using Tyuiu.KorolkovDS.Sprint4.Task5.V11.Lib;

namespace Tyuiu.KorolkovDS.Sprint4.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,] { { -3, 4, -1 },
                                         { 7, -2, -3 },
                                         { -9, 4, -2 } };

            int[,] wait = new int[,] {  { -3, 1, -1 },
                                         { 1, -2, -3 },
                                         { -9, 1, -2 } };
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
