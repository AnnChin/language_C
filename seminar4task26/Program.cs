// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Leng(string numb)
{
    int NumLength = numb.Length;
    return NumLength;
}

Console.Write("Insert number: ");
string i = Console.ReadLine();
Console.WriteLine(Leng(i));

// for (int i = 0; i < length; i++)