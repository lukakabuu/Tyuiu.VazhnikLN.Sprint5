using Tyuiu.VazhnikLN.Sprint5.Task5.V27.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string pad = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V27.txt"); ;
            FileInfo fileinfo = new FileInfo(pad);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
