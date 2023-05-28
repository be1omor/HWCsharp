int ThreeDigit(int num)
{
    int thirdNumber = num / 1 % 10;
    Console.WriteLine("Третья цифра вашего числа " + thirdNumber);
    return thirdNumber;
}
int FourDigit(int num)
{
    int thirdNumber = num / 10 % 10;
    Console.WriteLine("Третья цифра вашего числа " + thirdNumber);
    return thirdNumber;
}
int FiveDigit(int num)
{
    int thirdNumber = num / 100 % 100 % 10;
    Console.WriteLine("Третья цифра вашего числа " + thirdNumber);
    return thirdNumber;
}
int SixDigit(int num)
{
    int thirdNumber = num / 1000 % 100 % 10 % 10;
    Console.WriteLine("Третья цифра вашего числа " + thirdNumber);
    return thirdNumber;
}
int FindThirdDigit(int num)
{
    if (1000 > num && num > 99)
    {
        ThreeDigit(num);
        return num;
    }
    else if (10000 > num && num > 999)
    {
        FourDigit(num);
        return num;
    }
    else if (100000 > num && num > 9999)
    {
        FiveDigit(num);
        return num;
    }
    else if (1000000 > num && num > 99999)
    {
        SixDigit(num);
        return num;
    }
    else
    {
        int thirdNumber = num;
        Console.WriteLine("Введите число где кол-во знаков меньше либо равно шести");
        return thirdNumber;
    }
}
void Nachalo(int num)
{
    if (99 < num)
    {
        FindThirdDigit(num);
    }
    else
    {
        Console.Write("Третьей цифры нет.");
    }
}
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Nachalo(number);