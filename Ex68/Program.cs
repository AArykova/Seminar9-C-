// SЗадача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(n,m) = 29

int numberN = 2;
int numberM = 3;

Recursion(numberM, numberN);
//Console.WriteLine(Recursion(numberM, numberN));

int Recursion(int M, int N)
{
    if (M ==0)  
        return N+1;
        else 
            if (N == 0) Recursion(M-1,1);
            else 
                return Recursion(M-1, Recursion(M, N-1));
}
