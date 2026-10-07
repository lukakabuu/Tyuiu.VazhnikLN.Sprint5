using Tyuiu.VazhnikLN.Sprint5.Task2.V17.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 2, 1, 7 }, { 1, 2, 4 }, { 2, 3, 4 } };
            string pad = ds.SaveToFileTextData(matrix);
            FileInfo fileinfo = new FileInfo(pad);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
