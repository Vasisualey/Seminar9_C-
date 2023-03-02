// Задача 69. Напишите программу, которая на вход принимает
// два числа A и B, и возводит число A в целую степень B с помощью рекурсии.

int n = GetNumberFromUser($"Введите число ", "Ошибка ввода!");
int m = GetNumberFromUser($"введите степень", "Ошибка ввода!");
int result = GetResult(n,m);
Console.Write($"{n},{m} -> {result}");


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



int GetResult(int n, int m)
{
    if (m == 1) return n;
    else
    {
        m--;
        return n* GetResult(n,m);
    }
}
