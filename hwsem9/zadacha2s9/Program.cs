// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int Promt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumNaturalNum(int num1, int num2, int num3)
{
    num3 += num1;
    if (num1 != num2)
    {
        return SumNaturalNum(num1 + 1, num2, num3);
    }
    return num3;
}

int m = Promt("Введите число M: ");
int n = Promt("Введите число N: ");
int z = 0;
Console.Write($"Сумма натуральных элементов в промежутке от M до N = {SumNaturalNum(m, n, z)}");
