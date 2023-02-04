// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("От ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("До ");
int n = int.Parse(Console.ReadLine()!);

void SummMN (int M, int N, int summ)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов от m до n: {summ}"); 
        return;
    }
    summ = summ + M;
    M++;
    SummMN(M, N, summ);
}

SummMN(m, n, 0);