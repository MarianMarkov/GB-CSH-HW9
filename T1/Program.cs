// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write(" От ");
int m = int.Parse(Console.ReadLine()!);
Console.Write(" До ");
int n = int.Parse(Console.ReadLine()!);
int summ = 0;
for (int i = m; i < n + 1; i++)
{
    if (i > 0)
    {
        summ = summ + i;
    }
}
Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {summ}");