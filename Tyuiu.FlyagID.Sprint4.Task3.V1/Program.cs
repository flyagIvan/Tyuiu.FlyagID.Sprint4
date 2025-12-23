using System;
using Tyuiu.FlyagID.Sprint4.Task3.V1.Lib;

Console.Title = "Спринт #4 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (статические данные)                            *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Найти сумму элементов последнего столбца массива 5x5.                  *");
Console.WriteLine("***************************************************************************");

int[,] array =
{
    { 3, 4, 3, 4, 1 },
    { 8, 1, 6, 6, 9 },
    { 9, 8, 5, 1, 3 },
    { 1, 8, 7, 1, 2 },
    { 9, 9, 7, 5, 6 }
};

Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(array);

Console.WriteLine($"Сумма элементов последнего столбца = {result}");
Console.ReadLine();
