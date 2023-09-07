//Напишите программу, которая выводит только третью цифру заданного числа или сообщает, что третьей цифры нет


Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine("There is no such number");
}
else if (a < 1000)
{
    int b = a % 10;
    Console.WriteLine(b);
}
else if (a <10000)
{
    int b = a % 100/10;
    Console.WriteLine(b);
}
else if (a <100000)
{
    int b = a % 1000/100;
    Console.WriteLine(b);
}
else if (a <1000000)
{
    int b = a % 10000/1000;
    Console.WriteLine(b);
}
else if (a <10000000)
{
    int b = a % 100000/10000;
    Console.WriteLine(b);
}