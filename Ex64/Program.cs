// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
//M = 1; N = 9. -> "3, 6, 9"
//M = 13; N = 20. -> "15, 18"

Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());

if (numberN > numberM) Console.WriteLine("Введите корректные числа");
Console.WriteLine();

Recursion(numberN, numberM);

void Recursion(int N, int M)
{
    if (N > M) return;
    if (N % 3 == 0) Console.WriteLine(N);
    Recursion(N+1, M);
}
