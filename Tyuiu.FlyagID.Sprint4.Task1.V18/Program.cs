using System;
using Tyuiu.FlyagID.Sprint4.Task1.V18.Lib;

Console.Title = "Спринт #4 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов.                    *");
Console.WriteLine("* Подсчитать сумму нечётных элементов массива.                            *");
Console.WriteLine("***************************************************************************");

int[] array = new int[16];

Console.WriteLine("Введите 16 целых чисел (от 3 до 9):");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Элемент [{i + 1}] = ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nВведённый массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(array);

Console.WriteLine($"Сумма нечётных элементов массива = {result}");
Console.ReadLine();
