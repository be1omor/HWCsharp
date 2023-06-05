// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void Digit(int num)
{
    if (num < 100000)
    {
        int z = num / 1 % 10;
        int x = num / 10 % 10;
        int c = num / 100 % 100 % 10;
        int v = num / 1000 % 100 % 10 % 10;
        int b = num / 10000 % 100 % 10 % 10 % 10;
        int result = z + x + c + v + b;
        Console.Write($"Сумма цифр числа = {result}");
    }
    else Console.WriteLine("Введите число не более пятизначного.");
}

string mess = "Введите число: ";
int number = Prompt(mess);
Digit(number);