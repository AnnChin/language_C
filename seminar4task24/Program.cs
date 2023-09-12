// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Sum(int n)
{
    if(n == 1) return n;
    else return n+Sum(n-1);
}
Console.Write("Insert number: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write(Sum(i));