// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write($"Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNum(int x, int y)
{
    if (x == y)
    {
        return x;
    }
    return x + SumNum(x + 1, y);
}

Console.Write($"Сумма элементов между {n} и {m} = {SumNum(m, n)}");