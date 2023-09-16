// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

int LengthArray(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void RandomArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(1, 50);
            }
        }
    }
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"arr[{i},{j},{k}]={arr[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int lenColumn = LengthArray($"Задайте количество столбцов массива: ");
int lenLine = LengthArray($"Задайте количество строк массива: ");
int lenDepth = LengthArray($"Задайте глубину массива: ");

int[,,] arrA = new int[lenLine, lenColumn, lenDepth];
RandomArray(arrA);
PrintArray(arrA);
