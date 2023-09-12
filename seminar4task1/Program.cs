// void SayLang(string lang)
// {
//     Console.WriteLine($"Lang {lang}!!!");
// }

// SayLang("kjhvb");
// SayLang("rtgb");
// SayLang("qasd");


int SayMax(int num1, int num2)
{
    if (num1 > num2)
    {
        num1 = num1 + 10;
        return num1 + 10;
    }
    else
    {
        num2 = num2 * 2;
        return num2 * 2;
    }
}
Console.WriteLine($"{SayMax(5,3)}");
int x1 = SayMax(2,7);
Console.WriteLine(x1);