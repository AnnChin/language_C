﻿// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int square = Convert.ToInt32(Console.ReadLine());
int result = number * number;

if (square == result)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}