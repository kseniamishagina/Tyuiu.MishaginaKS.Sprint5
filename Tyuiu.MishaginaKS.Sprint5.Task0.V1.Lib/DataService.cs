namespace Tyuiu.MishaginaKS.Sprint5.Task0.V1.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
public class DataService : ISprint5Task0V1

{
    public string SaveToFileTextData(int x)

    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

        double y = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) + 5 * x + 4;
        y = Math.Round(y, 3);

        File.WriteAllText(path, Convert.ToString(y));

        return path;
    }
}
