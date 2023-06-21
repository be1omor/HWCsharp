// Задача 64: Задайте значение N. 
// Напишите программу, которая 
// выведет все натуральные числа в 
// промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int Promt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void NaturalNumber(int number, int count)
{
    if (number >= count)
    {
        Console.Write($"{number} ");
        NaturalNumber(number - 1, count);
    }
}

// string PrintNumber(int number)
// {
//     if (number == 1) return "1";

//     return $"{number} {PrintNumber(number - 1)}";
// }

int n = Promt("Введите число: ");
int i = 1;
//Console.WriteLine(PrintNumber(n));
NaturalNumber(n, i);