namespace Tyuiu.MishaginaKS.Sprint5.Task6.V17.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;

public class DataService : ISprint5Task6V17

{
    public int LoadFromDataFile(string path)

    {
        int count = 0;
        string text = File.ReadAllText(path);

        for (int i = 0; i < text.Length - 1; i++)

        {
            if (text[i] == ' ' && text[i + 1] == ' ')

            {
                if (i == 0 || text[i - 1] != ' ')

                {
                    count++;
                }
            }
        }

        return count;
    }
}
