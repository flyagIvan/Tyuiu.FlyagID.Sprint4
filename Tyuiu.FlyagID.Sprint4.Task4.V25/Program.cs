using System;
using Tyuiu.FlyagID.Sprint4.Task4.V25.Lib;

Console.Title = "Спринт #4 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Найти сумму чётных элементов массива 5x5.                              *");
Console.WriteLine("***************************************************************************");

int[,] matrix =
{
    { 3, 2, 4, 4, 4 },
    { 2, 6, 6, 3, 2 },
    { 4, 2, 5, 5, 3 },
    { 5, 5, 6, 4, 3 },
    { 2, 6, 5, 6, 2 }
};

Console.WriteLine("Исходная матрица:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(matrix);

Console.WriteLine($"Сумма чётных элементов массива = {result}");
Console.ReadLine();
