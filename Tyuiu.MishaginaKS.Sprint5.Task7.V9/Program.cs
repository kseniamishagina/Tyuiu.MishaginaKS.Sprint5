using System;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task7.V9.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task7.V9;
class Program

{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Задание #7 | Вариант 9";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #9                                                              *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Удалить все           *");
        Console.WriteLine("* заглавные латинские буквы из файла. Полученный результат сохранить      *");
        Console.WriteLine("* в файл OutPutDataFileTask7V9.txt.                                       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V9.txt");
        File.WriteAllText(path, "Hello, Мир! Это Is My First Program.");

        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string resPath = ds.LoadDataAndSave(path);

        Console.WriteLine("Находится в файле: " + resPath);
        Console.WriteLine("Содержимое выходного файла: " + File.ReadAllText(resPath));

        Console.ReadKey();
    }
}

