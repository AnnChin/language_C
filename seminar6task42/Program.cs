// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Insert number: ");
int a = Convert.ToInt32(Console.ReadLine());
int x = a;
int count = 0;
while (x != 0)
{
    x = x / 2;
    count++;
}

int[] array = new int [count];
for (int i = 0; a != 0; i++)
{
    array[i] = a % 2;
    a = a / 2;
}

void PrintMassive(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}

int[] arr2 = new int[array.Length];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    arr2[j] = array[array.Length -1 - i];
    j++;
}

PrintMassive(arr2);

// // int x = a;
// int[] arr = new int[a];
// for (int i = 0; a / 2 == 0; i++)
// {
//     arr[i] = a % 2;
//     a = a / 2;
// }

// void PrintMassive(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.WriteLine();
// }

// PrintMassive(arr);

// // int[] arr2 = new int[arr.Length];
// // int j = 0;
// // for (int i = 0; i < arr.Length; i++)
// // {
// //     arr2[j] = arr[arr.Length - 1 - i];
// //     j++;
// // }
// // PrintMassive(arr2);