// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void Kub(int num)
{
    for (int i = 1; i <= num; i++)
    {
        double kub=0;
        kub = Math.Pow((i), 3);
        Console.Write($"{kub} ");
    }
    // int i=1;
    // while(i<=num)
    // {
    //     double kub=0;
    //     kub = Math.Pow((i), 3);
    //     Console.Write($"{kub} ");
    //     i++;
    // }
}
string mess = "Введите число: ";
int chislo = Prompt(mess);
Kub(chislo);
