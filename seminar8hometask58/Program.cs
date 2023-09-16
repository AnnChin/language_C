// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

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

int lenColumnA = LengthArray($"Задайте количество столбцов 1 массива: ");
int lenLineA = LengthArray($"Задайте количество строк 1 массива: ");
int[,] arrA = new int[lenLineA, lenColumnA];
RandomArray(arrA);
PrintArray(arrA);
Console.WriteLine();

int lenColumnB = LengthArray($"Задайте количество столбцов 2 массива: ");
int lenLineB = LengthArray($"Задайте количество строк 2 массива: ");
int[,] arrB = new int[lenLineB, lenColumnB];
RandomArray(arrB);
PrintArray(arrB);
Console.WriteLine();

if (lenColumnA != lenLineB) Console.Write("Array is not exists");
else
{
    int[,] multyArr = new int[lenLineA, lenColumnB];
    for (int i = 0; i < multyArr.GetLength(0); i++)
    {
        for (int j = 0; j < multyArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < multyArr.GetLength(1); k++)
            {
                sum = sum + arrA[i, k] * arrB[k, j];
            }
            multyArr[i, j] = sum;
        }
    }
    PrintArray(multyArr);
}