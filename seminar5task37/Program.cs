// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
int[] arr2 = new int[arr1.Length / 2];
int j = 0;
for (int i = 0; i < arr1.Length / 2; i++)
{
    arr2[j] = arr1[i] * arr1[arr1.Length -1 - i];
    j++;
}
PrintMassive(arr1);
PrintMassive(arr2);





// int n = 10;
// int[] array = new int[n];
// Random rnd = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(0, 100);
//     Console.Write($"{array[i]}, ");
// }
// Console.WriteLine();

// int[] prod = new int[array.Length / 2];
// int a = 0;
// for (int j = 0; j < array.Length / 2; j++)
// {
//     prod[a] = array[j] * array[array.Length - j];
//     Console.Write($"{prod[a]}, ");
//     a++;
// }