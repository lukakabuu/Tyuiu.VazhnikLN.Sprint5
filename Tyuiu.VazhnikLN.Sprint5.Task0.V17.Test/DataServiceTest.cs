using System.IO;
namespace Tyuiu.VazhnikLN.Sprint5.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string pad = @"C:\Users\user\source\repos\Tyuiu.VazhnikLN.Sprint5\bin\debug\OutPutFileTask0.txt";
            FileInfo fileinfo = new FileInfo(pad);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
