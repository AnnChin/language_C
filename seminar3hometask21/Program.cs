// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2


Console.Write("Insert A coordinate x: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert A coordinate y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert A coordinate z: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert B coordinate x: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert B coordinate y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert B coordinate z: ");
int zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A ({xA},{yA},{zA}); B ({xB},{yB},{zB})");

double result = Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));

Console.WriteLine($"Distance between your points = {result}");
