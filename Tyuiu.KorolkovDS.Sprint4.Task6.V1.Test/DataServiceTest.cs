using Tyuiu.KorolkovDS.Sprint4.Task6.V1.Lib;

namespace Tyuiu.KorolkovDS.Sprint4.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res = ds.Calculate(array);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
