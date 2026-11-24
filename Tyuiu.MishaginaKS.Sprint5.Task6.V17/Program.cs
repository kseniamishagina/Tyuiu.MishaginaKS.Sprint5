using System;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task6.V17.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task6.V17;

class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Задание #6 | Вариант 17";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл в котором есть набор символьных данных. Найти количество       *");
        Console.WriteLine("* пробелов, идущих подряд больше одного, в заданной строке.              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V17.txt");
        File.WriteAllText(path, "Это  пример  строки с лишними пробелами.");

        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.LoadFromDataFile(path);
        Console.WriteLine("Количество пробелов, идущих подряд больше одного = " + res);

        Console.ReadKey();
    }
}

