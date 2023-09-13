// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

int n = 12;
int[] array = new int[n];
Random rnd = new Random();
int sumPlus = 0;
int sumMinus = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-9, 10);
    Console.Write($"{array[i]}, ");
    if (array[i] > 0) sumPlus = sumPlus + array[i];
    else sumMinus = sumMinus + array[i];
}
Console.WriteLine($"Sum of positive elements {sumPlus}");
Console.WriteLine($"Sum of negative elements {sumMinus}");