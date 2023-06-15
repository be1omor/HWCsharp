// Задача 50. Напишите программу, 
// которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет 
// [1,7]-это позиция элемента 1 - строка, 7 - столбец

Console.Clear();

string Prompt2 (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    return value;
}

int Promt(string msg)
{
    Console.Write(msg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
int[,] GenerMas(int m, int n)
{
    int[,] mas = new int [m,n];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i,j]= new Random().Next(1, 10);
        }
    }
    return mas;
}
void PrintMas(int[,] arr)
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
int[,] massiv = GenerMas(row, col);
PrintMas(massiv);
int temp1 = row;
int temp2 = col;
string temp = string.Empty;
int i = 1;
while (i>0)
{
    row = Promt("Введите строку элемента: ");
    col = Promt("Введите столбец элемента: ");
    int a = row-1;
    int b = col-1;
    if (row<=0 || row>massiv.GetLength(0) || col<=0 || col>massiv.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }
    else
    {
        Console.WriteLine($"Искомый элемент в массиве равен: {massiv[a,b]}");
    }
    temp = Prompt2("Вы хотите еще поискать элементы? (Y-да, N-нет): ");
    if (temp.ToLower() == "y")
    {
        i++;
    }
    else
    {
        i=-1;
    }
}