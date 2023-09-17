// Напишите программу, которая на входпринимает 2 числа A и B,
// и возводит число А в целую степень В с помощью рекурсии.

Console.Write($"Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите степень возведения: ");
int m = Convert.ToInt32(Console.ReadLine());


int PowNum(int x, int y)
{
    if (y == 0)
    {
        return 1;
    }
    else return x * PowNum(x, y - 1);

}

Console.Write(PowNum(n, m));