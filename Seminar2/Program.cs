//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Pack(int a)
{
    int res = (a / 10) % 10;
    return res;
}
int a = Convert.ToInt32(Console.ReadLine());
int res = Pack(a);
WriteLine($"вотророе цифра числа {a} цифра {res}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Pack2(int b)
{
    int res2 = (b / 100) % 10;
    return res2;
}
int b = Convert.ToInt32(Console.ReadLine());
int res2 = Pack2(b);
if (b >= 1000)
    Console.WriteLine($"третье цифра числа {b} цифра {res2}");
else
    {
    if (b <= -1000)
        Console.WriteLine($"третье цифра числа {b} цифра {res2}");
    else
        Console.WriteLine("третьей цифры нет");
    }

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void Pack3(int z)
{
    if (z == 6)
    Console.WriteLine($"{z} день недели выходной");
    else
    {
        if (z == 7)
            Console.WriteLine($"{z} день недели выходной");
        else 
            Console.WriteLine($"{z} день недели не выходной");
    }
}
int z = Convert.ToInt32(Console.ReadLine());
Pack3(z);
