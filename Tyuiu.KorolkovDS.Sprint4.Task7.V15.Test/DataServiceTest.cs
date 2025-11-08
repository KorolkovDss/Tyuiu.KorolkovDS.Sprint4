using Tyuiu.KorolkovDS.Sprint4.Task7.V15.Lib;

namespace Tyuiu.KorolkovDS.Sprint4.Task7.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "10293847";
            int n = 4;
            int m = 2;
            int wait = 4;
            int res = ds.Calculate(n, m, str);
            Assert.AreEqual(wait, res);
        }
    }
    
}
