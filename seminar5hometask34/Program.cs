// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве


// функция массива
int[] Massive()
{
    int n = 10;
    int[] arr = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

// функция печати массива
void PrintMassive(int[] Mass)
{
    for (int i = 0; i < Mass.Length; i++)
    {
        Console.Write($"{Mass[i]}, ");
    }
    Console.WriteLine();
}

// функция счетчика
int Counted(int[] con)
{
    int count = 0;
    for (int i = 0; i < con.Length; i++)
    {
        if (con[i] % 2 == 0) count = count + 1;
    }
    return count;
}

int[] arr = Massive();
PrintMassive(arr);
Console.WriteLine($"Количество четных чисел = {Counted(arr)}");