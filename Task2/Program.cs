// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int rec(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return rec(m - 1, 1);
    else if (m > 0 && n > 0)
        return rec(m - 1, rec(m, n -1));
    return rec(m, n);
}

Console.Clear();
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));