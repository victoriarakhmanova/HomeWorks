//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
456 -> 5
782 -> 8
918 -> 1

Решение.

void ThreeDigitNum(int num)
{
    int dec = num % 100;
    int ed = num % 10;
    int res = (dec - ed)/10;
    
    if ((num >=100) && (num<=999))    


    Console.WriteLine($"{res} is the middle digit in {num}");

    else
    {    
        Console.WriteLine($"The number {num} is not in the condition");
    }    
    

}
Console.WriteLine("Add integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
ThreeDigitNum(num);

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6



int FindThirdDigit(int num)
{
    if (num < 0)
    {
        num = -num;
    }
    if (num < 99)
    {
        Console.WriteLine($"The third digit of number is upsent");
    }

    else
    {

        while (num > 999)

            num = num / 10;

        int res = num % 10;
        Console.WriteLine($"The third digit of number is {res}");

    }
    return num;
}




Console.WriteLine("Add integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
FindThirdDigit(num);



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет


void WeekendCheck(int number)
{
    if(number>7)
    {
        Console.Write($"{number} is not in condition");
    }
    else
    {
        while((number<8)&(number>0))
        {
        if(number>5)
        {
            Console.Write($"{number}th day is Weekend");
              break;
        }

       
        else
        {
             Console.Write($"{number} day is Weekdays");
              break;
        }

        }
    }  
}
Console.Write("Enter the number of the day of the week:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
WeekendCheck(number);
*/