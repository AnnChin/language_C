// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Insert number quarter plane: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1) Console.WriteLine("x = [1;1000], y = [1:1000]");
else if (quarter == 2) Console.WriteLine("x = [-1;-1000], y = [1;1000]");
else if (quarter == 3) Console.WriteLine("x = [-1;-1000], y = [-1;-1000]");
else if (quarter == 4) Console.WriteLine("x = [1;1000], y = [-1;-1000]");
else Console.WriteLine("does not exist");