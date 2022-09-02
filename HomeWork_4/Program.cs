// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
/*
int RaiseToAPower(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res *= a;
        
    }
    return res;
}
Console.WriteLine("Enter the number A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number B: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} raise to the power {b} is {RaiseToAPower(a,b)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int SumDigits(int num)
{
    int sum = 0;
    while(num >0)
    {
       sum = sum + num % 10;
       num = num/10;       
        
    }
    return sum;
}
Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of the number {num} is {SumDigits(num)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
*/



int[] CreateArray()
{
    Console.Write("Enter the number of array elements: \t ");
    int elements = Convert.ToInt32(Console.ReadLine());
    int[] number = new int[elements];
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write("Enter the element of array: \t ");
        number[i] = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}
void PrintArray(int[] array)
{
 Console.WriteLine("Output of the array:");
 

for (int i = 0; i < array.Length; i++)
{
    
    Console.Write(array[i]);
}
}
int[] array = CreateArray();
PrintArray(array);


