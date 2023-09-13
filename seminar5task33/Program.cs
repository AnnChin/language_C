// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


Console.WriteLine("Insert number: ");
int num = Convert.ToInt32(Console.ReadLine());

int n = 10;
int[] array = new int[n];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-10, 11);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();

string flag = "No";
for (int j = 0; j < array.Length; j++)
{
    if (array[j] == num || array[j] == num * -1)
    {
        flag = "Yes";
        break;
    }
}

Console.Write(flag);