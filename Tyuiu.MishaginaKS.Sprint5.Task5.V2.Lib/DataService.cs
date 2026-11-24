namespace Tyuiu.MishaginaKS.Sprint5.Task5.V2.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;

public class DataService : ISprint5Task5V2

{
    public double LoadFromDataFile(string path)

    {
        double sum = 0;
        int count = 0;

        string text = File.ReadAllText(path);
        string[] values = text.Split(',');

        foreach (string item in values)
        {
            string cleanItem = item.Trim().Replace('.', ',');
            if (!string.IsNullOrEmpty(cleanItem))
            {
                double num = Convert.ToDouble(cleanItem);
                if (num > 0)
                {
                    sum += num;
                    count++;
                }
            }
        }

        double average = count > 0 ? sum / count : 0;
        return Math.Round(average, 3);
    }
}
    

