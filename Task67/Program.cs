// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
Console.Clear();
int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");
int result = GetResult(n);
Console.Write($"{n} -> {result}");


int GetNumberFromUser(string message, string errorMessage) // это проверка правильности метода
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}



int GetResult(int n)
{
    if (n == 0) return 0;
    else
    {
        return n%10 + GetResult(n/10);
    }
}