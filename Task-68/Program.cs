// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Request(string message)
{
  int result = 0;
  Console.Write(message);
  result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Ackermann(int m, int n)
{
  if (m == 0)
    return n + 1;
  else if (n == 0)
    return Ackermann(m - 1, 1);
  else
    return Ackermann(m - 1, Ackermann(m, n - 1));
} 


try
{
  int m = Request("Введите целое число M:\t");
  int n = Request("Введите целое число N:\t");
  Console.WriteLine($"\nA({m}, {n}) = {Ackermann(m, n)}");
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}