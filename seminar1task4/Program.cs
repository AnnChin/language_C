// 5*. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = n1;

if (n1==0)
{
    Console.Write("0");
}
else
{
    if (n1>0)
    {
        n1=n1*(-1);
        for (int i = n1; i<n2+1; i++)
        {
            if (i==n2)
            {
                Console.Write($"{i}");
            }
            else
            {
                Console.Write($"{i}, ");
            }
        }
    }
    else
    {
        n2=n2*(-1);
        for (int i = n1; i<n2+1; i++)
        {
            if (i==n2)
            {
                Console.Write($"{i}");
            }
            else
            {
                Console.Write($"{i}, ");
            }
        }
    }
}