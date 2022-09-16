// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
/*
void OutputNums(int M, int N)
{
    Console.Write(M + " ");
    if (M < N) OutputNums(M + 1, N);

    
}
OutputNums(1, 5);
OutputNums(4, 8);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNumbers (int M, int N)
{
    {   
        if (M <= N) return (SumNumbers(M +1, N) + M );
        else return 0;
   
    }
}
 Console.Write(SumNumbers(4,8)); 
 */

//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int Akkerman(int n, int m)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);

}


Console.WriteLine(Akkerman(3, 2));


int Ackermann(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return Ackermann(M - 1, 1);
    if (M > 0 && N > 0) return Ackermann(M - 1, Ackermann(M, N - 1));
    return Ackermann(M, N);
}
Console.WriteLine(Ackermann(3, 2));