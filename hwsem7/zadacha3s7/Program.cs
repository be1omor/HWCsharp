// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int Promt(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int[,] GenMas(int row, int col)
{
    Random random = new Random();
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = random.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMas(int[,] arr)
{
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] PrintAver(int[,] arr)
{
    double[] columnAverages = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        columnAverages[j] = sum / arr.GetLength(1);
        Console.WriteLine($"Среднее арифметическое столбца {j + 1}: {columnAverages[j]}");
    }
    
    return columnAverages;
}

int rows = Promt("Введите кол-во строк: ");
int cols = Promt("Введите кол-во столбцов: ");
int[,] massiv = GenMas(rows, cols);
PrintMas(massiv);
PrintAver(massiv);