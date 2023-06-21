// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
int Promt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int Akkerman(int m, int n) 
{
    if (m == 0) 
    {
        return n + 1;
    }
    if (n == 0) 
    {
        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Promt("Введите число m: ");
int n = Promt("Введите число n: ");

Console.Write($"A(m,n) = {Akkerman(m,n)}");