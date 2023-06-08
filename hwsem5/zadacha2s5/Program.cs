// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
int [] Massive (int size) //создаёт массив чисел
                          //заданной длинны
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(-10, 10);
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
void EvenNumbers(int [] num) //считает сумму чётных элементов массива
{
    int sumEvenEl=0;
    int sumNoEvenEl=0;
    for (int i = 0; i < num.Length; i++)
    {
        if (i%2==0)
        {
            sumEvenEl+=num[i];
        }
        else
        {
            sumNoEvenEl+=num[i];
        }
    }
    Console.WriteLine(sumNoEvenEl);
}
string mess = "Задайте длину массива: ";
int sizeNumber = Prompt(mess);
Massive(sizeNumber);
int [] massiv = Massive(sizeNumber);
Console.WriteLine("Ваш массив.");
OutputDisplay(massiv);
Console.WriteLine("Сумма элементов массива стоящих на нечетных позициях: ");
EvenNumbers(massiv);
