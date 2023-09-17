// Напишите программу, которая будет
// принимать на вход число и возвращать сумму его цифр

Console.Write($"Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNum(int x)
{
    if (x == 0) return 0;
    else return x % 10 + SumNum(x / 10);
}

Console.WriteLine(SumNum(n));