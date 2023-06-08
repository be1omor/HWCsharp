﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();
int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}
double[] Massive(int size)
{
    // int [] array = new int [8];
    double [] array = new double [size];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 100)/100.00;  // генератор [a,b)
        // Console.Write (array[i]+" ");
    }
    return array;
}
void PrintMassive(double[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+" ");
    }
    Console.WriteLine (" ");
}
double[] FindMiaxArray(double[] array)
{
    int size = array.Length;
    int current_index = 0;
    double fstMax = array[current_index];
    double scdMax = array[current_index];
    int fstMaxIndex = 0;
    int scdMaxIndex = 0;
    double fstMin = array[current_index];
    double scdMin = array[current_index];
    int fstMinIndex = 0;    
    int scdMinIndex = 0;
    double[] rezult = new double[8];
    while (current_index < size)
    {
        if (array[current_index]>fstMax)
        {
            fstMax = array[current_index];
            fstMaxIndex = current_index;
        }
        if (array[current_index]<fstMin)
        {
            fstMin = array[current_index];
            fstMinIndex = current_index;
        }
        current_index ++;
    }
    // Console.WriteLine($"fmsx {fstMax} {fstMaxIndex} fmin {fstMin} {fstMinIndex}"); debug output
    current_index = 0;
    if (fstMaxIndex == 0)
    {
        scdMax = array[1];
    }
    if (fstMinIndex == 0)
    {
        scdMin = array[1];
    }
    while (current_index < size)
    {
        if (current_index != fstMaxIndex)
        {
            if (array[current_index] > scdMax)
            {
                scdMax = array[current_index];
                scdMaxIndex = current_index;
            }
        }
        if (current_index != fstMinIndex)
        {
            if (array[current_index] < scdMin)
            {
                scdMin = array[current_index];
                scdMinIndex = current_index;
            }
        }
        current_index ++;
    }
    // Console.WriteLine($"smax {scdMax} {scdMaxIndex} smin {scdMin} {scdMinIndex}"); debug output
    rezult[0]=fstMax;
    rezult[1]=fstMin;
    rezult[2]=scdMax;
    rezult[3]=scdMin;
    rezult[4]=fstMaxIndex;
    rezult[5]=fstMinIndex;
    rezult[6]=scdMaxIndex;
    rezult[7]=scdMinIndex;
    return rezult;
}
int size = Prompt("Введите длинну массива: ");
double[] array = Massive(size);
PrintMassive(array);
double[] minmax = FindMiaxArray(array);
// PrintMassive(minmax); debug output
double fstsum = minmax[0]-minmax[1];
double scdsum = minmax[2]-minmax[3];
Console.WriteLine($"Разнице между максимальным и минимальным равна: {fstsum}");
Console.WriteLine($"Разнице между вторым максимальным и вторым минимальным равна: {scdsum}");