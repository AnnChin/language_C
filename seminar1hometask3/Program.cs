// Напишите программу, которая на вход принимает число и выдает является ли число четным (делится на 2 без остатка)

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = (number % 2);

if (result == 0)
{
    Console.WriteLine("Ваше число четное");
}
else
{
    Console.WriteLine("Ваше число нечетное");
}