using System;
using Tyuiu.FlyagID.Sprint4.Task0.V17.Lib;

Console.Title = "Спринт #4 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 0 до 9.                          *");
Console.WriteLine("* Подсчитать сумму чётных элементов массива.                              *");
Console.WriteLine("***************************************************************************");

int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.GetSumEvenArrEl(array);

Console.WriteLine($"Сумма чётных элементов массива = {result}");
Console.ReadLine();
