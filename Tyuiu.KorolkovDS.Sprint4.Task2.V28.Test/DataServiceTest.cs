using Tyuiu.KorolkovDS.Sprint4.Task2.V28.Lib;

namespace Tyuiu.KorolkovDS.Sprint4.Task2.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 4, 0, 3, 6, 9 };
            int res = ds.Calculate(array);
            int wait = 12;
            Assert.AreEqual(wait, res);

        }
    }
}
