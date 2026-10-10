using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VazhnikLN.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string pass = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");
            FileInfo fileInfo = new FileInfo(pass);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(pass);
            string strline = "";
            using (StreamReader Reader = new StreamReader(path))
            {
                string line;
                while ((line = Reader.ReadLine()) != null)
                {
                    if (((line.ToLower()).Contains("сс") == true))
                    {
                        strline = strline + line.Replace("сс", "");
                    }
                    File.AppendAllText(pass, strline);
                    strline = "";

                }
            }
            return pass;
        }
    }
}
