// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
/*
bool Palindrom(int number)
{
    int t = number;
    int rev = 0;
    while (t > 0)
    {
        int l = t % 10;
        rev = rev * 10 + l;
        t = t / 10;
    }
    return rev == number;
}
Console.WriteLine("Enter the number:");
int number = Convert.ToInt32(Console.ReadLine());

if (Palindrom(number))
{
    Console.WriteLine($"The number {number} is Palindrom");

}
else
{
    Console.WriteLine($"The number {number} is not Palindrom");

}
*/


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Length(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double dx = x2 - x1;
    double dy = y2 - y1;
    double dz = z2 - z1;

    return Math.Sqrt(dx * dx + dy * dy + dz * dz);
}

Console.Write("Введите х координату точки A: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату точки A: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату точки A: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите х координату точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y координату точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите z координату точки B: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double len = Length(x1,x2,y1,y2,z1,z2);

Console.Write($"Длина отрезка с точками А ({x1},{y1},{z1}) и B ({x2},{y2},{z2}) равна {len}");

*/
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void NumCube(int n)
{
    int i = 1;
    while (i <= n)
    {
        double result = Math.Pow(i, 3); //int result = i*i*i
        Console.WriteLine(result);
        i++;
    }

}
Console.WriteLine($"Enter the numder: ");
int cube = Convert.ToInt32(Console.ReadLine());

NumCube(cube);

*/