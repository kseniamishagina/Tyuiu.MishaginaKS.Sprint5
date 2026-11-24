using System;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task4.V11.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task4.V11;

class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Задание #4 | Вариант 11";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Прочитать значение из файла и подставить вместо X в формулу             *");
        Console.WriteLine("* y = sin(x) + x^2 / 2. Вычислить значение по формуле (округлить до 3     *");
        Console.WriteLine("* знаков после запятой) и вернуть полученный результат на консоль.        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V11.txt");
        File.WriteAllText(path, "2.61");

        Console.WriteLine("Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);

        Console.ReadKey();
    }
}

