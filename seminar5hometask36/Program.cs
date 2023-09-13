// Задайте одномерный массив, заполненный случайнфми числами.
// Найдите сумму элементов, стоящих на четных позициях

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

// функция суммы
int SumEven(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) sum = sum + arr[i];
    }
    return sum;
}

int[] arr = Massive();
PrintMassive(arr);
Console.WriteLine($"Сумма элементов четных позиций = {SumEven(arr)}");