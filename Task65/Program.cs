// Задача 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Clear();
int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
int sum = 0;
int res = PrintNumber(m, n);
Console.WriteLine(res);

int PrintNumber(int m, int n)
{
    if (m == n)
    {
        return sum += m;
    }
    return sum += m + PrintNumber(m + 1, n);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
