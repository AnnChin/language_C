// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Insert number: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = 0; i <= n; i++)
{
    result = i + result;
}
Console.Write($"Sum of numbers from 1 to {n} = {result}");