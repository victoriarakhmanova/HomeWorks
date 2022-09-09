// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*

int[] CreateArray()
{
    Console.Write("How many elements do you want to enter?\t");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter the number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountNumMoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {       
        if (array[i] > 0) count++;               
    }
    return count;
}

int[] newArray = CreateArray();
ShowArray(newArray);
Console.WriteLine($"The number of elements more then ZERO is {CountNumMoreZero(newArray)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
void FindCrossTwoLines(double b1, double b2, double k1, double k2)
{
Console.WriteLine("Enter b1: ");
 b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter b2: ");
 b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter k1: ");
 k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter k2: ");
 k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;


Console.Write($"The cross of two lines in : {x}, {y}");
}

double b1=0, k1=0, b2=0, k2=0;
FindCrossTwoLines(b1,b2,k1,k2);


