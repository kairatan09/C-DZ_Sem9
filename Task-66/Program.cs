// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Request(string message)
{
  int result = 0;
  Console.WriteLine(message);
  result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int ElementsSum(int m, int n)
{
  if (n == m) return n;
  return m + ElementsSum(m + 1, n);
}

try
{
  int m = Request("Введите целое число M");
  int n = Request("Введите целое число N");
  if (m > n) (m, n) = (n, m);
  Console.WriteLine($"\nСумма натуральных элементов в промежутке от {m} до {n} равна - {ElementsSum(m, n)}");
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}