namespace Tyuiu.MishaginaKS.Sprint5.Task4.V11.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;

public class DataService : ISprint5Task4V11
{
    public double LoadFromDataFile(string path)

    {
        string strX = File.ReadAllText(path).Trim().Replace('.', ',');
        double x = Convert.ToDouble(strX);

        double res = Math.Sin(x) + (Math.Pow(x, 2) / 2.0);
        return Math.Round(res, 3);
    }
}

