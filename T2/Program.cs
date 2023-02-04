// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
Console.Write(" m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write(" n = ");
int n = int.Parse(Console.ReadLine()!);

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

Console.Write("Функция Аккермана = ");
Console.Write(Ack(m,n));