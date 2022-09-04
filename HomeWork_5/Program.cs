// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);

    }
    return newArray;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + " ");
    Console.WriteLine();

}

int CountEvenNum(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 ==0)
         count ++;
    }
    return count;
}

Console.WriteLine("Enter the size of array:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
PrintArray(newArray);
Console.WriteLine($"The count of even numbers is {CountEvenNum(newArray)}");

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);

    }
    return newArray;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + " ");
    Console.WriteLine();

}
int SumOddIndex(int[]array)
{
   int sum = 0;
   for (int i = 1; i < array.Length; i+=2)
   {
        sum+= array[i];
        
   }
   return sum;

}
Console.WriteLine("Enter the size of array:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
PrintArray(newArray);
Console.WriteLine($"The sum of elements is {SumOddIndex(newArray)}");
*/
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
double[] CreateRandomArray(int size, int min, int max)
{
    double[] newArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1) + new Random().NextDouble();

    }
    return newArray;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)

        Console.Write($"{array[i]:f2} ");
    Console.WriteLine();

}

double SubtractionMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        
        if (array[i] < min) min = array[i];
        
    }
    double res = max - min;

    return res;
}



Console.WriteLine("Enter the size of array:");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(size, min, max);
PrintArray(newArray);

Console.WriteLine($"The subtraction of max and min is {SubtractionMaxMin(newArray):f2}");
