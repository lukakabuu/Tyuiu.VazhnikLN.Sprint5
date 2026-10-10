using Tyuiu.VazhnikLN.Sprint5.Task7.V19.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V19.txt");
            string pad = ds.LoadDataAndSave(path);
            FileInfo fileinfo = new FileInfo(pad);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
