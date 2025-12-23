using System;
using Tyuiu.FlyagID.Sprint4.Task2.V7.Lib;

Console.Title = "Спринт #4 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (генерация случайных чисел)                    *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан массив из 12 элементов [4..9].                                      *");
Console.WriteLine("* Подсчитать сумму чётных элементов массива.                              *");
Console.WriteLine("***************************************************************************");

int[] array = new int[12];
Random rnd = new Random();

Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(4, 10); // 4..9
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(array);

Console.WriteLine($"Сумма чётных элементов массива = {result}");
Console.ReadLine();
