// string[,] table = new string[2,5];
// table[1,2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }



void PrintArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            mat[i, j] = new Random().Next(1, 10);
        }
    }
}


int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);