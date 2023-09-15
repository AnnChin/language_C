// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int LengthArray(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void RandomArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-100, 100);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int lenColumn = LengthArray($"Задайте количество столбцов: ");
int lenLine = LengthArray($"Задайте количество строк: ");
int[,] array = new int[lenLine, lenColumn];
RandomArray(array);
PrintArray(array);

Console.WriteLine();

int[] temp = new int[lenColumn];
for (int i = 0; i < temp.Length; i++)
{
    int m = 0;
    temp[i] = array[0, m];
    m++;
}

int[] flag = new int[lenColumn];
for (int i = 0; i < flag.Length; i++)
{
    int m = 0;
    flag[i] = array[lenLine - 1, m];
    m++;
}

for (int i = 0; i < temp.Length; i++)
{
    int m = 0;
    array[lenLine - 1, m] = temp[i];
    m++;
}

for (int i = 0; i < flag.Length; i++)
{
    int m = 0;
    array[0, m] = flag[i];
    m++;
}

PrintArray(array);