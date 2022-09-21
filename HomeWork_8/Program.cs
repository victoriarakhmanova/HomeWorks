// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int[,] Create2dArray()
{
    Console.Write("Input the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];
     for (int i = 0; i < rows; i++)
    
         for (int j = 0; j < columns; j++)
        
            newArray[i, j] = new Random().Next(min, max+1);
      
    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortingArray(int[,] arr)


{
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
    return arr;
}

Console.Clear();

int [,] newArr = Create2dArray();
Show2dArray(newArr);
Show2dArray(SortingArray(newArr));




*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] Create2dArray()
{
    Console.Write("Input the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];
     for (int i = 0; i < rows; i++)
    
         for (int j = 0; j < columns; j++)
        
            newArray[i, j] = new Random().Next(min, max+1);
      
    
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] SumRowArray(int[,] array)
{
    int[] count = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++ )
    {
        count[i] = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
          count[i]+= array[i,j];
        }
        Console.Write($"{count[i]}" +" ");
               
    }    
    return count;
}    

int FindMin(int[]arr)
{
int pos = 0;
int min = arr[0];
for(int i = 0; i< arr.Length; i++)
{
    if(arr[i]< min)
    {min = arr[i];
    pos = i;

    }
       
}
        
    return pos;
 
}                                                                                                                                                                                                                                                                                                                                                             


Console.Clear();

int [,] newArr = Create2dArray();
Show2dArray(newArr);
int[] array = SumRowArray(newArr);

Console.WriteLine($"\nMinSum in {FindMin(array)+1} row");   
 */

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*

Console.Clear();
Console.Write("Input the rows of Arr1: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the columns of Arr1: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the rows of Arr2: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the columns of Arr2: ");
int columns2 = Convert.ToInt32(Console.ReadLine());


void Create2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(4);

        }
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] array1 = new int[rows1, columns1];
Create2dArray(array1);
Show2dArray(array1);

int[,] array2 = new int[rows2, columns2];
Create2dArray(array2);
Show2dArray(array2);




int[,] MultiplyArray(int[,] array1, int[,] array2, int[,] resArray)
{
    if(array1.GetLength(0) == array2.GetLength(1))
    {       
   
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                resArray[i, j] += array1[i, k] * array2[k, j];
            }
        }

    }
    
    }
    return resArray;
    
        
    
    
}




int[,] resArray = new int[rows1, columns2];

Show2dArray(MultiplyArray(array1, array2, resArray));
*/



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)



int[,,] Create3dArray(int rows, int сolumns, int lists) 
{
    return new int[rows, сolumns, lists];
}

void FillArray(int[,,] array, int rowValue, int сolValue, int listValue)
{
    
    Random rend = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int lists = array.GetLength(2);
    int numbers = 10;

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++) 
        {
            for (int k = 0; k< lists; k++)
            {
                array[i,j,k] = numbers;
                numbers++;
            }
        }

    }
}


void Show3dArray(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int lines = array.GetLength(2);

    for (int row = 0; row < rows; row++) 
    {
        for (int column = 0; column < columns; column++)
        {
            for (int line = 0; line < lines; line++)
            {
                Console.Write($"{array[row, column, line],3} ({row}, {column}, {line})" + "\t");

            }
        }
        Console.WriteLine();
    }
}



    Console.Clear(); 
    int[,,] array = Create3dArray(2, 2, 2);
    FillArray(array, 0, 10, 10);
    Show3dArray(array);
    Console.WriteLine();



