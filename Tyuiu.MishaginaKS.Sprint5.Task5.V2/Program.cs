using System;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task5.V2.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task5.V2;

class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Задание #5 | Вариант 2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл с набором значений. Найти среднее всех положительных           *");
        Console.WriteLine("* значений. Полученный результат вывести на консоль (округлить до 3       *");
        Console.WriteLine("* знаков после запятой).                                                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V2.txt");
        File.WriteAllText(path, "14, 0, 23, 0, -10, 25, 17, 17, 15, 6, 24, -1, -5, -7, 24, 8, 21, 4, 1, 5");

        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Среднее положительных элементов = " + res);

        Console.ReadKey();
    }
}

