// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

// функция создания массива
int[] Massive()
{
    int n = 10;
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
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

int[] arr1 = Massive();
int[] arr2 = new int[arr1.Length];
int j = 0;
for (int i = 0; i < arr1.Length; i++)
{
    arr2[j] = arr1[i];
    j++;
}
PrintMassive(arr1);
PrintMassive(arr2);