// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int n = 8;
int[] array = new int[n];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(0,2);
    Console.Write($"{array[i]}, ");
}
