namespace Tyuiu.MishaginaKS.Sprint5.Task7.V9.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
public class DataService : ISprint5Task7V9

{
    public string LoadDataAndSave(string path)

    {
        string savePath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V9.txt");

        FileInfo fileInfo = new FileInfo(savePath);
        if (fileInfo.Exists)
        {
            File.Delete(savePath);
        }

        string text = File.ReadAllText(path);
        string result = "";

        foreach (char c in text)
        {
            if (!(c >= 'A' && c <= 'Z'))
            {
                result += c;
            }
        }

        File.WriteAllText(savePath, result);

        return savePath;
    }
}

