// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
            arr[i, j] = new Random().Next(1, 10);
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
void ChangeArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                arr[i, j] = Convert.ToInt32(Math.Pow(arr[i, j], 2));
            }
        }
    }
}

ChangeArray(array);
PrintArray(array);