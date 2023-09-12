// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int n = 8;
int[] array = new int[n];
Random rnd = new Random();
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,100);
    Console.Write($"{array[i]}, ");
}
Console.Write("]");