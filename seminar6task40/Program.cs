// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.


Console.Write("Insert first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert third number: ");
int c = Convert.ToInt32(Console.ReadLine());

string temp = "No";
if(a < b + c && b < c + a && c < b + a) temp = "Yes";

Console.WriteLine(temp);