// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Введите число, определяющее день недели: ");
int temp = Convert.ToInt32(Console.ReadLine());
if (temp < 1)
{
    Console.WriteLine("There is no such day");
}
else if (temp <= 5)
{
    Console.WriteLine("No, it's not a holiday");
}
else if (temp <= 7)
{
    Console.WriteLine("Yes, it's a holiday");
}
else if (temp > 7)
{
    Console.WriteLine("There is no such day");
}