// Задайте значение N.
// Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N.

Console.Write($"Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void Order(int x)
{
    if (x == 0)
    {
        return;
    }
    Order(x-1);
    Console.Write($"{x}, ");
}

Order(n);