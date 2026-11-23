using System;
using System.IO;
using System.Text;
using Tyuiu.MishaginaKS.Sprint5.Task3.V15.Lib;
namespace Tyuiu.MishaginaKS.Sprint5.Task3.V15;

class Program

{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Задание #3 | Вариант 15";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение F(x) = -1.4x^3 + 2.3x^2 + 0.6x, вычислить его значение   *");
        Console.WriteLine("* при x = 5, результат сохранить в бинарный файл OutPutFileTask3.bin      *");
        Console.WriteLine("* и вывести на консоль.                                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 5;
        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");

        double value;
        using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open), Encoding.UTF8))
        {
            value = reader.ReadDouble();
        }

        Console.WriteLine("Значение функции = " + value);

        Console.ReadKey();
    }
}

