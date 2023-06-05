// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
//int
void Result(int a, int b)
{
    //double result = Math.Pow((a), b);
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine($"{result} ");
    //return result;
}
void Cycle()
{
    while (true)
    {
        string messA = "Введите число A: ";
        int numberA = Prompt(messA);
        string messB = "Введите число B: ";
        int numberB = Prompt(messB);
        Result(numberA, numberB);
    }
}
Cycle();