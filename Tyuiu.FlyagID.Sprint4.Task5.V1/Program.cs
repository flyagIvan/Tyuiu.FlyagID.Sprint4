using System;
using Tyuiu.FlyagID.Sprint4.Task5.V1.Lib;

Console.Title = "Спринт #4 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы                                                 *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Заменить положительные элементы массива 5x5 на 1                        *");
Console.WriteLine("***************************************************************************");

int rows = 5;
int cols = 5;
int[,] matrix = new int[rows, cols];
Random rand = new Random();

Console.WriteLine("Исходный массив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = rand.Next(-9, 9);
        Console.Write(matrix[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}

DataService ds = new DataService();
int[,] result = ds.Calculate(matrix);

Console.WriteLine("***************************************************************************");
Console.WriteLine("Результат:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(result[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}

Console.ReadLine();
