using System;
using System.IO;
using Tyuiu.MishaginaKS.Sprint5.Task1.V30.Lib;

namespace Tyuiu.MishaginaKS.Sprint5.Task1.V30;

class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Задание #1 | Вариант 30";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция F(x) = cos(x) + sin(x)/(2 - 2x) - 4x. Произвести           *");
        Console.WriteLine("* табулирование на диапазоне [-5; 5] с шагом 1. Результат сохранить       *");
        Console.WriteLine("* в текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу.    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!\n");

        string[] lines = File.ReadAllLines(res);

        Console.WriteLine("+----------+----------+");
        Console.WriteLine("|    X     |   f(x)   |");
        Console.WriteLine("+----------+----------+");

        int currentX = startValue;
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine("| {0,6:d}   |  {1,6}  |", currentX, lines[i]);
            currentX++;
        }

        Console.WriteLine("+----------+----------+");
        Console.ReadKey();
    }
}

