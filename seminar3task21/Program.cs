// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// AB = √(xb - xa)2 + (yb - ya)2


Console.Write("Insert A coordinate x: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert A coordinate y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert B coordinate x: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert B coordinate y: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A ({xA},{yA}); B ({xB},{yB})");

double result = Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2));

Console.WriteLine($"Distance between your points = {result}");