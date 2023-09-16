// Заполните спирально массив 4 на 4.
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int LengthArray(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// void RandomArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(1, 10);
//         }
//     }
// }




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

int lenColumn = LengthArray($"Задайте количество столбцов массива: ");
int lenLine = LengthArray($"Задайте количество строк массива: ");
int[,] arr = new int[lenLine, lenColumn];

if (lenLine != lenColumn) Console.Write("Array is not exists");
else
{
    int n = 1;
    int i = 0;
    int j = 0;
    while (n <= lenLine * lenLine)
    {
        arr[i, j] = n;
        n++;
        if (i <= j + 1 && i + j < lenLine - 1) j++;
        else if (i < j && i + j >= lenLine - 1) i++;
        else if (i >= j && i + j > lenLine - 1) j--;
        else i--;
    }
    PrintArray(arr);
}