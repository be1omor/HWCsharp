// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int Promt(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GenRandMas(int rows, int cols)
{
    Random rand = new Random();
    int[,] arr = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = rand.Next(1, 10);
        }
    }
    return arr;
}

void PrintMas(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
}

int StringSearch(int[,] mas)
{
    int minSum = int.MaxValue;
    int minRow = -1;

    for (int i = 0; i < mas.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < mas.GetLength(1); j++)
        {
            sum += mas[i, j];
        }

        if (sum <= minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }

    Console.WriteLine($"Строка с наименьшей суммой элементов = {minRow+1} (индекс строки = {minRow})");
    return minRow;
}

int m = Promt("Введите кол-во строк: ");
int n = Promt("Введите кол-во столбцов: ");
int[,] array = GenRandMas(m, n);
PrintMas(array);
Console.WriteLine();
StringSearch(array);