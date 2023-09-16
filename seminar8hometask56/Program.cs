// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

void SearchMinLine(int[,] arr)
{
    int[] arrSumLine = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sumLine = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumLine = sumLine + arr[i, j];
        }
        arrSumLine[i] = sumLine;
        Console.Write($"{arrSumLine[i]}, ");
    }
    int k = 0;
    int min = arrSumLine[0];
    int minK = 0;
    while (k < arrSumLine.Length)
    {
        if (arrSumLine[k] < min)
        {
            min = arrSumLine[k];
            minK = k;
        }
        k++;
    }
    Console.WriteLine($"Min line = {minK+1}");
}

int lenColumn = LengthArray($"Задайте количество столбцов: ");
int lenLine = LengthArray($"Задайте количество строк: ");
if (lenColumn != lenLine)
{
    Console.Write("Array is not square");
}
else
{
    int[,] array = new int[lenLine, lenColumn];
    RandomArray(array);
    PrintArray(array);
    SearchMinLine(array);
}


