// Задайте двумерный массив размером m x n.
// заполненный случайными вещественными числами.

int LengthArray(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void RandomArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] arr)
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
double[,] array = new double[lenLine, lenColumn];
RandomArray(array);
PrintArray(array);