// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int [] Massive (int size) //создаёт массив из трёхзначный 
                          //чисел заданной длинны
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
        //Console.WriteLine(res[i]);
    }
    return res;
}
int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void OutputDisplay(int [] array) //выводит созданный массив на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}
void EvenNumbers(int [] num) //считает кол-во чётных элементов массива
{
    int i=0;
    foreach (int el in num)
    {
        if (el%2 == 0)
        {
            i++;
        }
    }
    Console.WriteLine(i);
}
string mess = "Задайте длину массива: ";
int sizeNumber = Prompt(mess);
Massive(sizeNumber);
int [] massiv = Massive(sizeNumber);
Console.WriteLine("Ваш массив.");
OutputDisplay(massiv);
Console.WriteLine("Кол-во чётных чисел массива: ");
EvenNumbers(massiv);
