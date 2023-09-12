// Напишите цикл, который принимает на вход два числа (А,В)
// и возводит число А в натуральную степень В

double Degree(int a, int b)
{
    double n = Math.Pow(a, b);
    return n;
}

Console.Write("Insert num 1: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert num 2: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write(Degree(A, B));