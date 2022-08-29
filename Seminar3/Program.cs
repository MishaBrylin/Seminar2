// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void CoordByQuadrant(int quadrant)
{
    string output = "некоторые вводные данные";
    if (quadrant == 1)
        output = $"Для четверти {quadrant} x>0 y>0";
    if (quadrant == 2)
        output = $"Для четверти {quadrant} x<0 y>0";
    if (quadrant == 3)
        output = $"Для четверти {quadrant} x<0 y<0";
    if (quadrant == 4)
        output = $"Для четверти {quadrant} x>0 y<0";
    Console.WriteLine(output);
}
Console.WriteLine("Введите номер четверти ");
int quad = Convert.ToInt32(Console.ReadLine());
CoordByQuadrant(quad);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double lenSegment(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double len = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2)+(z - y2) * (z1 - z2));
    return len;
}

Console.WriteLine("введите кординаты первой точки");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите кординаты второй точки");
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Длина отрезка между точками равна {lenSegment(x1, y1, z1, x2, y2, z2)}");

//Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void SquaresTable(int n)
{
    int i = 0;
    while (i <= n)
    {
        Console.WriteLine($" куб {i} = {i * i* i }");
        i++;
    }
}

int quad = Convert.ToInt32(Console.ReadLine());
SquaresTable(quad);

