﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine (PrintNumbers(num));
int PrintNumbers (int num)
{
    if (num == 1)
    {
        return 1;
    }
    else 
    {
        Console.Write ($"{num}, ");
        num = PrintNumbers(num-1);
    }
    return num;
}

