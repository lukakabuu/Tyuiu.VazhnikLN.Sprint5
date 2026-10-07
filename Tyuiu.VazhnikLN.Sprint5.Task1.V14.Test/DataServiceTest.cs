using Tyuiu.VazhnikLN.Sprint5.Task1.V14.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string pad = ds.SaveToFileTextData(-5, 5);
            FileInfo fileinfo = new FileInfo(pad);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
