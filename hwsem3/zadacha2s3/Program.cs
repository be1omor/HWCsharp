// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Promtp(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((Math.Pow((x2 - x1), 2) +
                                (Math.Pow((y2 - y1), 2)) +
                                (Math.Pow((z2 - z1), 2))));
    Console.Write($"Расстояние между точками составляет -> {result}");
}

int x1 = Promtp("Введите координату х1: ");
int y1 = Promtp("Введите координату y1: ");
int z1 = Promtp("Введите координату z1: ");
int x2 = Promtp("Введите координату x2: ");
int y2 = Promtp("Введите координату y2: ");
int z2 = Promtp("Введите координату z2: ");
Console.WriteLine($"Координата точки А ({x1}, {y1}, {z1}) и точки В ({x2}, {y2}, {z2}) ");

Distance(x1,y1,z1,x2,y2,z2);
