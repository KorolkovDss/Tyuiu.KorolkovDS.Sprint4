using Tyuiu.KorolkovDS.Sprint4.Task4.V30.Lib;

namespace Tyuiu.KorolkovDS.Sprint4.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] { { 3, 4, 1 },
                                         { 7, 2, 3 },
                                         { 9, 4, 2 } } ;

            

            int[,] wait = new int[,] { {0, 4, 0},
                                       {0, 2, 0},
                                       {0, 4, 2} };
            int[,] res = ds.Calculate(matrix);
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
