// Задайте массив вещественных чисел.
// Найдите разницу между минимальным и максимальным элементом массива

// функция создания массива
int[] Massive()
{
    int n = 10;
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

// функция печати массива
void PrintMassive(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

// функция поиска макс
int ScanMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

// функция поиска мин
int ScanMin(int[] arr)
{
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

// Функция разности мин макс
int Dif(int[] arr)
{
    int dif = ScanMax(arr) - ScanMin(arr);
    return dif;
}

int[] arr = Massive();
PrintMassive(arr);

Console.WriteLine($"difference = {Dif(arr)}");




