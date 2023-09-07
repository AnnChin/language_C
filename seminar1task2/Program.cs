// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число, определяющее день недели: ");
int temp = Convert.ToInt32(Console.ReadLine());
if (temp == 1)
{
    Console.WriteLine("Tuday is Monday");
}
else if (temp == 2)
{
    Console.WriteLine("Tuday is Tuesday");
}
else if (temp == 3)
{
    Console.WriteLine("Tuday is Wednesday");
}
else if (temp == 4)
{
    Console.WriteLine("Tuday is Thursday");
}
else if (temp == 5)
{
    Console.WriteLine("Tuday is Friady");
}
else if (temp == 6)
{
    Console.WriteLine("Tuday is Saturday");
}
else
{
    Console.WriteLine("Tuday is Sunday");
}