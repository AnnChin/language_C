// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int n = 10;
int[] array = new int[n];
Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-100, 100);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0) array[j] = array[j] * -1;
    else array[j] = array[j] * -1;
    Console.Write($"{array[j]}, ");
}
