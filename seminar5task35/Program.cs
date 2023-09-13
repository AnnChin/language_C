// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// функция создания массива
int[] Massive()
{
    int n = 123;
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

// функция счетчика
int Counted(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) count = count + 1;
    }
    return count;
}

int[] arr = Massive();
PrintMassive(arr);
Console.WriteLine($"Количество нужных чисел = {Counted(arr)}");


// int n = 123;
// int[] array = new int[n];
// Random rnd = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(0, 1000);
//     Console.Write($"{array[i]}, ");
// }
// Console.WriteLine();

// int count = 0;
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] = [10, 99]) count = count + 1;
// }

// Console.WriteLine(count);