using Tyuiu.VazhnikLN.Sprint5.Task0.V17.Lib;
using System.IO;
namespace Tyuiu.VazhnikLN.Sprint5.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string pad = ds.SaveToFileTextData(3);
            FileInfo fileinfo = new FileInfo(pad);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
