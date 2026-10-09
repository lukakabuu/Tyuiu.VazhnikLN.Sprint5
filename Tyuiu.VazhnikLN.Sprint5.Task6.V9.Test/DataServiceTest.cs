using Tyuiu.VazhnikLN.Sprint5.Task6.V9.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string pad = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V9.txt");
            int wait = 2;
            int res = ds.LoadFromDataFile(pad);
            Assert.AreEqual(wait, res);
        }
    }
}
