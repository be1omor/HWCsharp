void FindWeekEnd(int num)
{
    if (8 > num && num > 5)
    {
        Console.WriteLine("Это выходной день.");
    }
    else if (6 > num && num > 0)
    {
        Console.WriteLine("Это рабочий день.");
    }
    else
    {
        Console.WriteLine("Такого дня недели нет :(");
    }
}
Console.Write("Введите число обозначающее день недели: ");
int number = int.Parse(Console.ReadLine()!);
FindWeekEnd(number);