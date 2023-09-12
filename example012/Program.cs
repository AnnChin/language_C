// // Вид 1
// void Metod1()
// {
//     Console.WriteLine("Avtor AnnChin");
// }
// Metod1();



// // Вид 2
// void Metod2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Metod2(msg: "Message text");

// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Metod21(msg: "Message text", count: 4);



// // Вид 3
// int Metod3()
// {
//     return DateTime.Now.Year;
// }

// int year = Metod3();
// Console.WriteLine(year);



// // Вид 4
// string Metod4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while(i<count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Metod4(10, "Anna is beautiful ");
// Console.WriteLine(res);


// // Цикл for
// string Metod4(int count, string text)
// {
//     string result = string.Empty;
//     for(int i = 0; i<count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Metod4(10, "Anna is beautiful ");
// Console.WriteLine(res);


// // Цикл в цикле

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }


// ====== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".

// Ясна ли задача?

string text = "– Я думаю, – сказал князь, улыбаясь, – что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3]  // r

string Replace(string text, char oldVlue, char newVlue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldVlue) result = result + $"{newVlue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);