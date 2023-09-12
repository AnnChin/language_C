// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

Console.WriteLine("Insert x coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("your coordinates in 1 quarter plane");
else if (x < 0 && y > 0) Console.WriteLine("your coordinates in 2 quarter plane");
else if (x < 0 && y < 0) Console.WriteLine("your coordinates in 3 quarter plane");
else if (x > 0 && y < 0) Console.WriteLine("your coordinates in 4 quarter plane");
   