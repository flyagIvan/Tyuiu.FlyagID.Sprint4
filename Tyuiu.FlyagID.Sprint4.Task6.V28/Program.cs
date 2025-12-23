using System;
using Tyuiu.FlyagID.Sprint4.Task6.V28.Lib;

Console.Title = "Спринт #4 | Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы строк                                          *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #28                                                             *");
Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
Console.WriteLine("***************************************************************************");

string[] array = { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };

Console.WriteLine("Исходный массив:");
foreach (string item in array)
{
    Console.WriteLine($"{item} (длина {item.Length})");
}

DataService ds = new DataService();
string[] result = ds.Calculate(array);

Console.WriteLine("***************************************************************************");
Console.WriteLine("Результат (длина = 4):");
foreach (string item in result)
{
    Console.WriteLine(item);
}

Console.ReadLine();
