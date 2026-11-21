using System;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task0.V1.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task0.V1;

class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Задание #0 | Вариант 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение F(x) = x^3 + 2x^2 + 5x + 4, вычислить его значение       *");
        Console.WriteLine("* при x = 3, результат сохранить в текстовый файл OutPutFileTask0.txt     *");
        Console.WriteLine("* и вывести на консоль.                                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;
        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.WriteLine("Значение функции = " + File.ReadAllText(res));

        Console.ReadKey();
    }
}

