// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Request(string message)
{
  int result = 0;
  Console.WriteLine(message);
  result = Convert.ToInt32(Console.ReadLine());
  return result;
}

string ListOfNumbers(int number)
{
  if (number == 1) return "1";
  return $"{number}, " + $"{ListOfNumbers(number - 1)}";
}


try
{
  int n = Request("Введите число N:");
  Console.WriteLine($"\nЧисла в промежутке от {n} до 1:");
  Console.Write($"N = {n} -> \"{ListOfNumbers(n)}\"");
}

catch
{
  Console.WriteLine("Были введены некорректные данные.");
}