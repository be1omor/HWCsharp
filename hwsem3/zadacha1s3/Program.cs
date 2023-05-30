// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int FindPal(int number)
{
    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int num4 = number / 10 % 10;
    int num5 = number % 10;
    if (num1 == num5 || num2 == num4) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
    return number;
}
void Nachalo(int number2)
{
    if (number2 > 10000 && number2 < 99999) FindPal(number2);
    else Console.WriteLine("Введите корректрое число");
}
Console.Write("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine()!);
Nachalo(a);
