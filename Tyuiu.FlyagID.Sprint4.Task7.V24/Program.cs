using System;
using Tyuiu.FlyagID.Sprint4.Task7.V24.Lib;

Console.Title = "Спринт #4 | Выполнил: Фляг Иван Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы и строки                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #24                                                             *");
Console.WriteLine("* Выполнил: Фляг Иван Дмитриевич | ИСПб-25-1                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр.                                      *");
Console.WriteLine("* Преобразовать ее в матрицу 5x3 и                                        *");
Console.WriteLine("* найти произведение чётных чисел.                                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int n = 5;
int m = 3;
string value = "651827384219648";

Console.WriteLine($"Строка: {value}");
Console.WriteLine($"Размер матрицы: {n} x {m}");

Console.WriteLine("\nМатрица:");
int index = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(value[index] + "\t");
        index++;
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(n, m, value);

Console.WriteLine($"Произведение чётных чисел = {result}");
Console.ReadLine();
