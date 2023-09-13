// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
    arr2[j] = arr1[arr1.Length -1 - i];
    j++;
}
PrintMassive(arr1);
PrintMassive(arr2);