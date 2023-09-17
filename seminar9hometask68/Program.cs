// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write($"Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ack(int x, int y)
{
    if (x == 0) return y +1;
    else if (y == 0) return Ack(x-1,1);
    else return Ack(x-1, Ack(x, y-1));
}

Console.Write($"m = {m}, n = {n} -> A(m,n) = {Ack(m, n)}");