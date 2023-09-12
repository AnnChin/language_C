// Напишите программу, которая принимает на вход число N
//  и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.Write("Insert number: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(i));