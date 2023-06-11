// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int[] CreateMassiv(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }

    return array;
}
void PrintMas(int[] array)
{
    Console.WriteLine("Ваш массив");
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine("]");
    //Console.WriteLine();
}
int SearchNumber(int[] array)
{
    int positivnum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            positivnum++;
        }
    }
    Console.WriteLine($"Кол-во положительных элементов массива = {positivnum}");
    return positivnum;
}
int size = Prompt("Введите длину массива: ");
int[] mas = CreateMassiv(size);
PrintMas(mas);
SearchNumber(mas);
