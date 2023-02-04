// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
Console.Write(" m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write(" n = ");
int n = int.Parse(Console.ReadLine()!);

int AckermannF(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckermannF(m - 1, 1);
  else return AckermannF(m - 1, AckermannF(m, n - 1));
}

Console.Write("Функция Аккермана = ");
Console.Write(AckermannF(m,n));