//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Create2dRandomArray()
{
    Console.WriteLine("Input number of rows:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of colmns:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    double[,] newArray = new double[rows,columns];
    
    for (int i = 0; i < rows; i++)
    
        for (int j = 0; j < columns; j++)
        
            newArray[i,j] = new Random().Next(minValue,maxValue+1)+ new Random().NextDouble();   
        
    return newArray;
}
void Show2dArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]:f2}" + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Clear();
double[,] newArray=Create2dRandomArray();
Show2dArray(newArray);


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int[,] Create2dArray()
{
    Console.Write("Input the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    
         for (int j = 0; j < columns; j++)
        
            newArray[i, j] = new Random().Next(minValue, maxValue+1);
      
    
    return newArray;
}
void Show2dArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindNumWithIndex(int[,] array,int i, int j)
{  
     if ((i <= array.GetLength(0)) && (j <= array.GetLength(1)))
            Console.WriteLine($"{array[i,j]}");    
    
     else                    
        Console.WriteLine("The element is absent");
}
Console.Clear();
int[,] newArr = Create2dArray();
Show2dArray(newArr);

Console.WriteLine("Input the index of row:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the index of column:");
int j = Convert.ToInt32(Console.ReadLine());
FindNumWithIndex(newArr,i,j);
*/



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*

double[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)

        for (int j = 0; j < columns; j++)

            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            Console.Write(array[i, j] + "\t ");

        Console.WriteLine();

    }
    Console.WriteLine();
}
double AverageOfColumns(double[,] array, double average)
{  
    for (int j = 0; j < array.GetLength(1); j++)
    {    
        double sum = 0;    
        average = 0;   
        for (int i = 0; i < array.GetLength(0); i++)
        {       
             
            sum += array[i, j];
        }
        average = sum / array.GetLength(0);
        Console.Write($"{average:f2}" + "\t ");
    }
       
    return average;
}
Console.Clear();
double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double average = 0;
AverageOfColumns(myArray,average);
*/