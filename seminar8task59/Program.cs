// Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int lenColumn = LengthArray($"Задайте количество столбцов массива: ");
int lenLine = LengthArray($"Задайте количество строк массива: ");
int[,] array = new int[lenLine, lenColumn];
RandomArray(array);
PrintArray(array);
Console.WriteLine();

int min = array[0, 0];
int minI = 0;
int minJ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < min)
        {
            min = array[i, j];
            minI = i;
            minJ = j;
        }
    }
}

int[,] newArr = new int[lenLine - 1, lenColumn - 1];
int m = 0;
int n = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (minI != i && minJ != j)
        {
            newArr[m, n] = array[i, j];
            n++;
        }
    }
    if (minI != i)
    {
        m++;
    }
}
PrintArray(newArr);
