// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void SortMas(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = j + 1; k < mas.GetLength(1); k++)
            {
                if (mas[i, j] < mas[i, k])
                {
                    int temp = mas[i, j];
                    mas[i, j] = mas[i, k];
                    mas[i, k] = temp;
                }
            }
            Console.Write($"{mas[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = Promt("Введите кол-во строк: ");
int n = Promt("Введите кол-во столбцов: ");
int[,] array = GenRandMas(m, n);
PrintMas(array);
Console.WriteLine();
Console.WriteLine("Элементы строк массива отсортированы по убыванию.");
SortMas(array);