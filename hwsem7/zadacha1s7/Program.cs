// Задача 47. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
int Promt(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
double[,] GenerMas(int m, int n)
{
    double[,] mas = new double [m,n];
    Random rand = new Random();
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j]= rand.NextDouble();
        }
    }
    return mas;
}
void PrintMas(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }

}
int row = Promt("Введите кол-во строк: ");
int col = Promt("Введите кол-во столбцов: ");
double[,] massiv = GenerMas(row, col);
PrintMas(massiv);