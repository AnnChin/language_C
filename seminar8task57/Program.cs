// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

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

void CountArrayDigits(int[,] arr, int n)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (n == arr[i, j]) count++;
        }
    }
    if (count != 0) Console.WriteLine($"Количество {n} в массиве = {count}");
}

int n = 0;

while (n < 10)
{
    CountArrayDigits(array, n);
    n++;
}