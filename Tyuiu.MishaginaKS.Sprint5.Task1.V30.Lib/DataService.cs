namespace Tyuiu.MishaginaKS.Sprint5.Task1.V30.Lib;

using tyuiu.cources.programming.interfaces.Sprint5;

public class DataService : ISprint5Task1V30

{
    public string SaveToFileTextData(int startValue, int stopValue)

    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

        FileInfo fileInfo = new FileInfo(path);
        if (fileInfo.Exists)
        {
            File.Delete(path);
        }

        double y;
        string strY;

        for (int x = startValue; x <= stopValue; x++)

        {
            if (2 - 2 * x == 0)
            {
                y = 0;
            }
            else
            {
                y = Math.Round(Math.Cos(x) + (Math.Sin(x) / (2.0 - 2.0 * x)) - 4 * x, 2);
            }

            strY = Convert.ToString(y);

            if (x != stopValue)
            {
                File.AppendAllText(path, strY + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(path, strY);
            }
        }

        return path;
    }
}
