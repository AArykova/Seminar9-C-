// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
int summa = 0;
if (numberM > numberN) 
{
    Console.WriteLine("Введите корректные числа");
}
else
    Recursion(numberM, numberN, summa);

void Recursion(int M, int N, int s)
{
    if (M > N)
    {
        Console.WriteLine("Сумма чисел равна: " + s);
        return;
    }
    s += M;
    Recursion(M+1, N, s); 
}