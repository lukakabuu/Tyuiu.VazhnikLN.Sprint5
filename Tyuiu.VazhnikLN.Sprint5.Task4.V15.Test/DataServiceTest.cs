using Tyuiu.VazhnikLN.Sprint5.Task4.V15.Lib;
namespace Tyuiu.VazhnikLN.Sprint5.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string pad = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V15.txt"); ;
            FileInfo fileinfo = new FileInfo(pad);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]

        public void CheckNum()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask4V15.txt");
            double res_wait = 3.54;
            double res = double.Parse(File.ReadAllText(path).Trim(), System.Globalization.CultureInfo.InvariantCulture);
            Assert.AreEqual(res, res_wait);
        }
        
    }
}
