// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел
// от 1 до N.


Console.Write("Insert number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= num; i++)
{
    Console.WriteLine($"{i} ^ 2 = {Math.Pow(i,2)}, ");
}