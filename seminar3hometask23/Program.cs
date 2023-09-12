// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел
// от 1 до N.

Console.Write("Insert number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i} ^ 3 = {Math.Pow(i,3)}");
}