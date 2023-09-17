// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа от M до N.

Console.Write($"Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());


void Order(int x, int y)
{
    if (x > y)
    {
        return;
    }
    Console.Write($"{x}, ");
    Order(x + 1, y);
}

Order(m, n);