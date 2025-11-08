using Tyuiu.KorolkovDS.Sprint4.Task1.V22.Lib;

namespace Tyuiu.KorolkovDS.Sprint4.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };
            int res = ds.Calculate(array);
            int wait = 295245;
            Assert.AreEqual(res, wait);
        }
    }
}
