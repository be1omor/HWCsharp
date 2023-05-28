int FindSecondDigit(int num)
{
    int secondNumber = num % 100 / 10;
    Console.WriteLine("Вторая цифра вашего числа " + secondNumber);
    return secondNumber;
}

void Nachalo(int num)
{
    if (1000 > num && 99 < num)
    {
        FindSecondDigit(num);
    }
    else
    {
        Console.Write("Вы ввели некорректное число!");
    }
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Nachalo(number);
