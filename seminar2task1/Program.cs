// int x = 18;
// while (x > 5)
// {
//     x = x - 1;
//     if (x == 10)
//         continue;
//     Console.WriteLine(x);
// }

// for (int i = 0; i < 88; i = i + 3)
// {
//     Console.WriteLine(i);
// }

// // double y = Convert.ToDouble(Console.Readline());

// double z = Math.Abs(-12.4); //12.4

// double a = Math.Round(20.5417389, 2); //20.54

// double b = Math.Sqrt(16); // 4

// double c = Math.Pow(3, 2); //9

for (int i = 0; i < 10; i++)
{
    int x = new Random().Next(10, 100);
    if (x % 10 > x / 10)
    {
        Console.WriteLine(x % 10);
    }
    else
    {
        Console.WriteLine(x / 10);
    }
}

