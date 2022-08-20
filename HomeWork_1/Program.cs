// Задача 2.
/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Решение.

  Console.Write("Input first integer number: ");
  int number1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input second integer number: ");
  int number2 = Convert.ToInt32(Console.ReadLine());

  if (number1 > number2)

  {
      Console.WriteLine($"Мах number is { number1}");
      Console.WriteLine($"Мin number is { number2}");

  }

  else
  {

       Console.WriteLine($"Max number is { number2}");
       Console.WriteLine($"Мin number is { number1}");

  }
    


//Задача 4.

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 

Решение.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third integer number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2 && num1>= num3)
{
      Console.WriteLine($"Мах number is {num1}");
}

if (num2 >= num1 && num2>= num3 )
{   
      Console.WriteLine($"Мах number is {num2}");
}

if (num3 >= num1 && num3>= num2 )
{     
      Console.WriteLine($"Мах number is {num3}");
}



//Задача 6.

Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Решение.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
      Console.WriteLine("да");
}
else
{
      Console.WriteLine("нет");

}

//Задача 8.
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.Write("Input positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current <=number)
{
    Console.Write(current + " ");
    current += 2;
}
*/