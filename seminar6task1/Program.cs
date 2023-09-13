int[] num = { 1, 2, 3, 4, 5, 6 };
int[,] nums = { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] num2 = new int [2,3];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        Console.Write($"{nums[i,j]} ");
    }
    Console.WriteLine();      
}